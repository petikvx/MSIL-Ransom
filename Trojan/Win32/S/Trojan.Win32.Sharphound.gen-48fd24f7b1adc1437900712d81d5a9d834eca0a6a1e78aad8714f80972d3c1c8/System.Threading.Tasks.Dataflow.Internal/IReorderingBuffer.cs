namespace System.Threading.Tasks.Dataflow.Internal;

internal interface IReorderingBuffer
{
	void IgnoreItem(long id);
}
