using System;
using System.Collections.Generic;
using System.DirectoryServices.Protocols;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using SharpHound3.Enums;
using SharpHound3.LdapWrappers;
using SharpHound3.Producers;

namespace SharpHound3.Tasks;

internal class PipelineBuilder
{
	internal static Task GetBasePipelineForDomain(string domain)
	{
		Options instance = Options.Instance;
		CollectionMethodResolved resolvedCollectionMethods = instance.ResolvedCollectionMethods;
		LdapQueryData ldapQueryData = LdapBuilder.BuildLdapQuery(resolvedCollectionMethods);
		BaseProducer baseProducer = (instance.Stealth ? new StealthProducer(domain, ldapQueryData.LdapFilter, ldapQueryData.LdapProperties) : ((instance.ComputerFile == null) ? ((BaseProducer)new LdapProducer(domain, ldapQueryData.LdapFilter, ldapQueryData.LdapProperties)) : ((BaseProducer)new ComputerFileProducer(domain, null, ldapQueryData.LdapProperties))));
		DataflowLinkOptions linkOptions = new DataflowLinkOptions
		{
			PropagateCompletion = true
		};
		ExecutionDataflowBlockOptions dataflowBlockOptions = new ExecutionDataflowBlockOptions
		{
			EnsureOrdered = false,
			MaxDegreeOfParallelism = 10,
			BoundedCapacity = 500
		};
		List<TransformBlock<LdapWrapper, LdapWrapper>> list = new List<TransformBlock<LdapWrapper, LdapWrapper>>();
		TransformBlock<SearchResultEntry, LdapWrapper> transformBlock = new TransformBlock<SearchResultEntry, LdapWrapper>((Func<SearchResultEntry, LdapWrapper>)ConvertToWrapperTasks.CreateLdapWrapper, new ExecutionDataflowBlockOptions
		{
			EnsureOrdered = false,
			MaxDegreeOfParallelism = 10,
			BoundedCapacity = 500
		});
		transformBlock.LinkTo(DataflowBlock.NullTarget<LdapWrapper>(), (LdapWrapper item) => item == null);
		TransformBlock<LdapWrapper, LdapWrapper> transformBlock2 = null;
		if ((resolvedCollectionMethods & CollectionMethodResolved.ACL) != 0)
		{
			transformBlock2 = new TransformBlock<LdapWrapper, LdapWrapper>((Func<LdapWrapper, Task<LdapWrapper>>)ACLTasks.ProcessAces, dataflowBlockOptions);
			list.Add(transformBlock2);
		}
		if ((resolvedCollectionMethods & CollectionMethodResolved.Group) != 0)
		{
			transformBlock2 = new TransformBlock<LdapWrapper, LdapWrapper>((Func<LdapWrapper, Task<LdapWrapper>>)GroupEnumerationTasks.ProcessGroupMembership, dataflowBlockOptions);
			list.Add(transformBlock2);
		}
		if ((resolvedCollectionMethods & CollectionMethodResolved.ObjectProps) != 0)
		{
			transformBlock2 = new TransformBlock<LdapWrapper, LdapWrapper>((Func<LdapWrapper, Task<LdapWrapper>>)ObjectPropertyTasks.ResolveObjectProperties, dataflowBlockOptions);
			list.Add(transformBlock2);
		}
		if ((resolvedCollectionMethods & CollectionMethodResolved.Container) != 0)
		{
			transformBlock2 = new TransformBlock<LdapWrapper, LdapWrapper>((Func<LdapWrapper, Task<LdapWrapper>>)ContainerTasks.EnumerateContainer, dataflowBlockOptions);
			list.Add(transformBlock2);
		}
		if ((resolvedCollectionMethods & CollectionMethodResolved.GPOLocalGroup) != 0)
		{
			transformBlock2 = new TransformBlock<LdapWrapper, LdapWrapper>((Func<LdapWrapper, Task<LdapWrapper>>)GPOGroupTasks.ParseGPOLocalGroups, dataflowBlockOptions);
			list.Add(transformBlock2);
		}
		if ((resolvedCollectionMethods & CollectionMethodResolved.SPNTargets) != 0)
		{
			transformBlock2 = new TransformBlock<LdapWrapper, LdapWrapper>((Func<LdapWrapper, Task<LdapWrapper>>)SPNTasks.ProcessSPNS, dataflowBlockOptions);
			list.Add(transformBlock2);
		}
		if ((resolvedCollectionMethods & CollectionMethodResolved.Trusts) != 0)
		{
			transformBlock2 = new TransformBlock<LdapWrapper, LdapWrapper>((Func<LdapWrapper, LdapWrapper>)TrustTasks.ResolveDomainTrusts, dataflowBlockOptions);
			list.Add(transformBlock2);
		}
		if (instance.IsComputerCollectionSet())
		{
			transformBlock2 = new TransformBlock<LdapWrapper, LdapWrapper>((Func<LdapWrapper, Task<LdapWrapper>>)ComputerAvailableTasks.CheckSMBOpen, dataflowBlockOptions);
			list.Add(transformBlock2);
		}
		if ((resolvedCollectionMethods & CollectionMethodResolved.Sessions) != 0)
		{
			transformBlock2 = new TransformBlock<LdapWrapper, LdapWrapper>((Func<LdapWrapper, Task<LdapWrapper>>)NetSessionTasks.ProcessNetSessions, dataflowBlockOptions);
			list.Add(transformBlock2);
		}
		if ((resolvedCollectionMethods & CollectionMethodResolved.RDP) != 0 || (resolvedCollectionMethods & CollectionMethodResolved.DCOM) != 0 || (resolvedCollectionMethods & CollectionMethodResolved.LocalAdmin) != 0 || (resolvedCollectionMethods & CollectionMethodResolved.PSRemote) != 0)
		{
			transformBlock2 = new TransformBlock<LdapWrapper, LdapWrapper>((Func<LdapWrapper, Task<LdapWrapper>>)LocalGroupTasks.GetLocalGroupMembers, dataflowBlockOptions);
			list.Add(transformBlock2);
		}
		if ((resolvedCollectionMethods & CollectionMethodResolved.LoggedOn) != 0)
		{
			transformBlock2 = new TransformBlock<LdapWrapper, LdapWrapper>((Func<LdapWrapper, Task<LdapWrapper>>)LoggedOnTasks.ProcessLoggedOn, dataflowBlockOptions);
			list.Add(transformBlock2);
		}
		if (list.Count == 0)
		{
			transformBlock.Complete();
			return transformBlock.Completion;
		}
		bool flag = false;
		foreach (TransformBlock<LdapWrapper, LdapWrapper> item in list)
		{
			if (!flag)
			{
				transformBlock.LinkTo(item, linkOptions, (LdapWrapper item) => item != null);
				flag = true;
			}
			else
			{
				transformBlock2.LinkTo(item, linkOptions, (LdapWrapper item) => item != null);
			}
			transformBlock2 = item;
		}
		ITargetBlock<LdapWrapper> targetBlock = ((!instance.NoOutput) ? new ActionBlock<LdapWrapper>((Action<LdapWrapper>)OutputTasks.WriteJsonOutput, new ExecutionDataflowBlockOptions
		{
			BoundedCapacity = 500,
			MaxDegreeOfParallelism = 1,
			EnsureOrdered = false
		}) : new ActionBlock<LdapWrapper>(delegate
		{
		}, dataflowBlockOptions));
		transformBlock2.LinkTo(targetBlock, linkOptions);
		baseProducer.StartProducer(transformBlock);
		return targetBlock.Completion;
	}

	internal static Task GetLoopPipelineForDomain(string domain)
	{
		Options instance = Options.Instance;
		CollectionMethodResolved loopCollectionMethods = instance.GetLoopCollectionMethods();
		Helpers.StartNewRun();
		LdapQueryData ldapQueryData = LdapBuilder.BuildLdapQuery(loopCollectionMethods);
		BaseProducer baseProducer = ((!Options.Instance.Stealth) ? ((BaseProducer)new LdapProducer(domain, ldapQueryData.LdapFilter, ldapQueryData.LdapProperties)) : ((BaseProducer)new StealthProducer(domain, ldapQueryData.LdapFilter, ldapQueryData.LdapProperties)));
		DataflowLinkOptions linkOptions = new DataflowLinkOptions
		{
			PropagateCompletion = true
		};
		ExecutionDataflowBlockOptions dataflowBlockOptions = new ExecutionDataflowBlockOptions
		{
			EnsureOrdered = false,
			MaxDegreeOfParallelism = 10,
			BoundedCapacity = 500
		};
		List<TransformBlock<LdapWrapper, LdapWrapper>> list = new List<TransformBlock<LdapWrapper, LdapWrapper>>();
		TransformBlock<SearchResultEntry, LdapWrapper> transformBlock = new TransformBlock<SearchResultEntry, LdapWrapper>((Func<SearchResultEntry, LdapWrapper>)ConvertToWrapperTasks.CreateLdapWrapper, new ExecutionDataflowBlockOptions
		{
			EnsureOrdered = false,
			MaxDegreeOfParallelism = 10,
			BoundedCapacity = 500
		});
		transformBlock.LinkTo(DataflowBlock.NullTarget<LdapWrapper>(), (LdapWrapper item) => item == null);
		TransformBlock<LdapWrapper, LdapWrapper> transformBlock2 = null;
		if (!instance.SkipPortScan && instance.IsComputerCollectionSet())
		{
			transformBlock2 = new TransformBlock<LdapWrapper, LdapWrapper>((Func<LdapWrapper, Task<LdapWrapper>>)ComputerAvailableTasks.CheckSMBOpen, dataflowBlockOptions);
			list.Add(transformBlock2);
		}
		if ((loopCollectionMethods & CollectionMethodResolved.Sessions) != 0)
		{
			transformBlock2 = new TransformBlock<LdapWrapper, LdapWrapper>((Func<LdapWrapper, Task<LdapWrapper>>)NetSessionTasks.ProcessNetSessions, dataflowBlockOptions);
			list.Add(transformBlock2);
		}
		if ((loopCollectionMethods & CollectionMethodResolved.RDP) != 0 || (loopCollectionMethods & CollectionMethodResolved.DCOM) != 0 || (loopCollectionMethods & CollectionMethodResolved.LocalAdmin) != 0 || (loopCollectionMethods & CollectionMethodResolved.PSRemote) != 0)
		{
			transformBlock2 = new TransformBlock<LdapWrapper, LdapWrapper>((Func<LdapWrapper, Task<LdapWrapper>>)LocalGroupTasks.GetLocalGroupMembers, dataflowBlockOptions);
			list.Add(transformBlock2);
		}
		if ((loopCollectionMethods & CollectionMethodResolved.LoggedOn) != 0)
		{
			transformBlock2 = new TransformBlock<LdapWrapper, LdapWrapper>((Func<LdapWrapper, Task<LdapWrapper>>)LoggedOnTasks.ProcessLoggedOn, dataflowBlockOptions);
			list.Add(transformBlock2);
		}
		if (list.Count == 0)
		{
			transformBlock.Complete();
			return transformBlock.Completion;
		}
		bool flag = false;
		foreach (TransformBlock<LdapWrapper, LdapWrapper> item in list)
		{
			if (!flag)
			{
				transformBlock.LinkTo(item, linkOptions, (LdapWrapper item) => item != null);
				flag = true;
			}
			else
			{
				transformBlock2.LinkTo(item, linkOptions, (LdapWrapper item) => item != null);
			}
			transformBlock2 = item;
		}
		ITargetBlock<LdapWrapper> targetBlock = ((!instance.NoOutput) ? new ActionBlock<LdapWrapper>((Action<LdapWrapper>)OutputTasks.WriteJsonOutput, new ExecutionDataflowBlockOptions
		{
			BoundedCapacity = 500,
			MaxDegreeOfParallelism = 1,
			EnsureOrdered = false
		}) : new ActionBlock<LdapWrapper>(delegate
		{
		}, dataflowBlockOptions));
		transformBlock2.LinkTo(targetBlock, linkOptions);
		baseProducer.StartProducer(transformBlock);
		return targetBlock.Completion;
	}
}
