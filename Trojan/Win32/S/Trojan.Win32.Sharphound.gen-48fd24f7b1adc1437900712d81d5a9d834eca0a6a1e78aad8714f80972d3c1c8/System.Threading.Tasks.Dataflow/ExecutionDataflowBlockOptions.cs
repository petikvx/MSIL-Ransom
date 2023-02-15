using System.Diagnostics;

namespace System.Threading.Tasks.Dataflow;

[DebuggerDisplay("TaskScheduler = {TaskScheduler}, MaxMessagesPerTask = {MaxMessagesPerTask}, BoundedCapacity = {BoundedCapacity}, MaxDegreeOfParallelism = {MaxDegreeOfParallelism}")]
public class ExecutionDataflowBlockOptions : DataflowBlockOptions
{
	internal new static readonly ExecutionDataflowBlockOptions Default = new ExecutionDataflowBlockOptions();

	private int _maxDegreeOfParallelism = 1;

	private bool _singleProducerConstrained;

	public int MaxDegreeOfParallelism
	{
		get
		{
			return _maxDegreeOfParallelism;
		}
		set
		{
			if (value < 1 && value != -1)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			_maxDegreeOfParallelism = value;
		}
	}

	public bool SingleProducerConstrained
	{
		get
		{
			return _singleProducerConstrained;
		}
		set
		{
			_singleProducerConstrained = value;
		}
	}

	internal int ActualMaxDegreeOfParallelism
	{
		get
		{
			if (_maxDegreeOfParallelism != -1)
			{
				return _maxDegreeOfParallelism;
			}
			return int.MaxValue;
		}
	}

	internal bool SupportsParallelExecution
	{
		get
		{
			if (_maxDegreeOfParallelism != -1)
			{
				return _maxDegreeOfParallelism > 1;
			}
			return true;
		}
	}

	internal new ExecutionDataflowBlockOptions DefaultOrClone()
	{
		if (this != Default)
		{
			return new ExecutionDataflowBlockOptions
			{
				TaskScheduler = base.TaskScheduler,
				CancellationToken = base.CancellationToken,
				MaxMessagesPerTask = base.MaxMessagesPerTask,
				BoundedCapacity = base.BoundedCapacity,
				NameFormat = base.NameFormat,
				EnsureOrdered = base.EnsureOrdered,
				MaxDegreeOfParallelism = MaxDegreeOfParallelism,
				SingleProducerConstrained = SingleProducerConstrained
			};
		}
		return this;
	}
}
