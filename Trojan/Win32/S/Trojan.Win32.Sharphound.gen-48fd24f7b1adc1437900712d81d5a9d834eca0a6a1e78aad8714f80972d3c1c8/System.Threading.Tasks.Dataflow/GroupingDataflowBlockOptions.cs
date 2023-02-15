using System.Diagnostics;

namespace System.Threading.Tasks.Dataflow;

[DebuggerDisplay("TaskScheduler = {TaskScheduler}, MaxMessagesPerTask = {MaxMessagesPerTask}, BoundedCapacity = {BoundedCapacity}, Greedy = {Greedy}, MaxNumberOfGroups = {MaxNumberOfGroups}")]
public class GroupingDataflowBlockOptions : DataflowBlockOptions
{
	internal new static readonly GroupingDataflowBlockOptions Default = new GroupingDataflowBlockOptions();

	private bool _greedy = true;

	private long _maxNumberOfGroups = -1L;

	public bool Greedy
	{
		get
		{
			return _greedy;
		}
		set
		{
			_greedy = value;
		}
	}

	public long MaxNumberOfGroups
	{
		get
		{
			return _maxNumberOfGroups;
		}
		set
		{
			if (value <= 0L && value != -1L)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			_maxNumberOfGroups = value;
		}
	}

	internal long ActualMaxNumberOfGroups
	{
		get
		{
			if (_maxNumberOfGroups != -1L)
			{
				return _maxNumberOfGroups;
			}
			return long.MaxValue;
		}
	}

	internal new GroupingDataflowBlockOptions DefaultOrClone()
	{
		if (this != Default)
		{
			return new GroupingDataflowBlockOptions
			{
				TaskScheduler = base.TaskScheduler,
				CancellationToken = base.CancellationToken,
				MaxMessagesPerTask = base.MaxMessagesPerTask,
				BoundedCapacity = base.BoundedCapacity,
				NameFormat = base.NameFormat,
				EnsureOrdered = base.EnsureOrdered,
				Greedy = Greedy,
				MaxNumberOfGroups = MaxNumberOfGroups
			};
		}
		return this;
	}
}
