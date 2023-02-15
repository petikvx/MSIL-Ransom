namespace System.Threading.Tasks.Dataflow.Internal;

[Flags]
internal enum TargetCoreOptions : byte
{
	None = 0,
	UsesAsyncCompletion = 1,
	RepresentsBlockCompletion = 2
}
