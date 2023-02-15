using System.Diagnostics.Tracing;
using System.Linq;

namespace System.Threading.Tasks.Dataflow.Internal;

[EventSource(Name = "System.Threading.Tasks.Dataflow.DataflowEventSource", Guid = "16F53577-E41D-43D4-B47E-C17025BF4025", LocalizationResources = "FxResources.System.Threading.Tasks.Dataflow.SR")]
internal sealed class DataflowEtwProvider : EventSource
{
	internal enum TaskLaunchedReason
	{
		ProcessingInputMessages = 1,
		OfferingOutputMessages
	}

	internal enum BlockCompletionReason
	{
		RanToCompletion = 5,
		Faulted = 7,
		Canceled = 6
	}

	internal static readonly DataflowEtwProvider Log = new DataflowEtwProvider();

	private const EventKeywords ALL_KEYWORDS = EventKeywords.All;

	private const int DATAFLOWBLOCKCREATED_EVENTID = 1;

	private const int TASKLAUNCHED_EVENTID = 2;

	private const int BLOCKCOMPLETED_EVENTID = 3;

	private const int BLOCKLINKED_EVENTID = 4;

	private const int BLOCKUNLINKED_EVENTID = 5;

	private DataflowEtwProvider()
	{
	}

	[NonEvent]
	internal void DataflowBlockCreated(IDataflowBlock block, DataflowBlockOptions dataflowBlockOptions)
	{
		if (IsEnabled(EventLevel.Informational, EventKeywords.All))
		{
			DataflowBlockCreated(Common.GetNameForDebugger(block, dataflowBlockOptions), Common.GetBlockId(block));
		}
	}

	[Event(1, Level = EventLevel.Informational)]
	private void DataflowBlockCreated(string blockName, int blockId)
	{
		WriteEvent(1, blockName, blockId);
	}

	[NonEvent]
	internal void TaskLaunchedForMessageHandling(IDataflowBlock block, Task task, TaskLaunchedReason reason, int availableMessages)
	{
		if (IsEnabled(EventLevel.Informational, EventKeywords.All))
		{
			TaskLaunchedForMessageHandling(Common.GetBlockId(block), reason, availableMessages, task.Id);
		}
	}

	[Event(2, Level = EventLevel.Informational)]
	private void TaskLaunchedForMessageHandling(int blockId, TaskLaunchedReason reason, int availableMessages, int taskId)
	{
		WriteEvent(2, blockId, reason, availableMessages, taskId);
	}

	[NonEvent]
	internal void DataflowBlockCompleted(IDataflowBlock block)
	{
		if (!IsEnabled(EventLevel.Informational, EventKeywords.All))
		{
			return;
		}
		Task potentiallyNotSupportedCompletionTask = Common.GetPotentiallyNotSupportedCompletionTask(block);
		if (potentiallyNotSupportedCompletionTask == null || !potentiallyNotSupportedCompletionTask.IsCompleted)
		{
			return;
		}
		BlockCompletionReason status = (BlockCompletionReason)potentiallyNotSupportedCompletionTask.Status;
		string exceptionData = string.Empty;
		if (potentiallyNotSupportedCompletionTask.IsFaulted)
		{
			try
			{
				exceptionData = string.Join(Environment.NewLine, Enumerable.Select(potentiallyNotSupportedCompletionTask.Exception!.InnerExceptions, (Exception e) => e.ToString()));
			}
			catch
			{
			}
		}
		DataflowBlockCompleted(Common.GetBlockId(block), status, exceptionData);
	}

	[Event(3, Level = EventLevel.Informational)]
	private void DataflowBlockCompleted(int blockId, BlockCompletionReason reason, string exceptionData)
	{
		WriteEvent(3, blockId, reason, exceptionData);
	}

	[NonEvent]
	internal void DataflowBlockLinking<T>(ISourceBlock<T> source, ITargetBlock<T> target)
	{
		if (IsEnabled(EventLevel.Informational, EventKeywords.All))
		{
			DataflowBlockLinking(Common.GetBlockId(source), Common.GetBlockId(target));
		}
	}

	[Event(4, Level = EventLevel.Informational)]
	private void DataflowBlockLinking(int sourceId, int targetId)
	{
		WriteEvent(4, sourceId, targetId);
	}

	[NonEvent]
	internal void DataflowBlockUnlinking<T>(ISourceBlock<T> source, ITargetBlock<T> target)
	{
		if (IsEnabled(EventLevel.Informational, EventKeywords.All))
		{
			DataflowBlockUnlinking(Common.GetBlockId(source), Common.GetBlockId(target));
		}
	}

	[Event(5, Level = EventLevel.Informational)]
	private void DataflowBlockUnlinking(int sourceId, int targetId)
	{
		WriteEvent(5, sourceId, targetId);
	}
}
