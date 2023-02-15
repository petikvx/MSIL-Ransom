using System.Diagnostics;

namespace System.Threading.Tasks.Dataflow;

[DebuggerDisplay("TaskScheduler = {TaskScheduler}, MaxMessagesPerTask = {MaxMessagesPerTask}, BoundedCapacity = {BoundedCapacity}")]
public class DataflowBlockOptions
{
	public const int Unbounded = -1;

	private TaskScheduler _taskScheduler = TaskScheduler.Default;

	private CancellationToken _cancellationToken = CancellationToken.None;

	private int _maxMessagesPerTask = -1;

	private int _boundedCapacity = -1;

	private string _nameFormat = "{0} Id={1}";

	private bool _ensureOrdered = true;

	internal static readonly DataflowBlockOptions Default = new DataflowBlockOptions();

	public TaskScheduler TaskScheduler
	{
		get
		{
			return _taskScheduler;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			_taskScheduler = value;
		}
	}

	public CancellationToken CancellationToken
	{
		get
		{
			return _cancellationToken;
		}
		set
		{
			_cancellationToken = value;
		}
	}

	public int MaxMessagesPerTask
	{
		get
		{
			return _maxMessagesPerTask;
		}
		set
		{
			if (value < 1 && value != -1)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			_maxMessagesPerTask = value;
		}
	}

	internal int ActualMaxMessagesPerTask
	{
		get
		{
			if (_maxMessagesPerTask != -1)
			{
				return _maxMessagesPerTask;
			}
			return int.MaxValue;
		}
	}

	public int BoundedCapacity
	{
		get
		{
			return _boundedCapacity;
		}
		set
		{
			if (value < 1 && value != -1)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			_boundedCapacity = value;
		}
	}

	public string NameFormat
	{
		get
		{
			return _nameFormat;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			_nameFormat = value;
		}
	}

	public bool EnsureOrdered
	{
		get
		{
			return _ensureOrdered;
		}
		set
		{
			_ensureOrdered = value;
		}
	}

	internal DataflowBlockOptions DefaultOrClone()
	{
		if (this != Default)
		{
			return new DataflowBlockOptions
			{
				TaskScheduler = TaskScheduler,
				CancellationToken = CancellationToken,
				MaxMessagesPerTask = MaxMessagesPerTask,
				BoundedCapacity = BoundedCapacity,
				NameFormat = NameFormat,
				EnsureOrdered = EnsureOrdered
			};
		}
		return this;
	}
}
