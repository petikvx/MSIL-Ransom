using System.Diagnostics;

namespace System.Threading.Tasks.Dataflow;

[DebuggerDisplay("PropagateCompletion = {PropagateCompletion}, MaxMessages = {MaxMessages}, Append = {Append}")]
public class DataflowLinkOptions
{
	internal const int Unbounded = -1;

	private bool _propagateCompletion;

	private int _maxNumberOfMessages = -1;

	private bool _append = true;

	internal static readonly DataflowLinkOptions Default = new DataflowLinkOptions();

	internal static readonly DataflowLinkOptions UnlinkAfterOneAndPropagateCompletion = new DataflowLinkOptions
	{
		MaxMessages = 1,
		PropagateCompletion = true
	};

	public bool PropagateCompletion
	{
		get
		{
			return _propagateCompletion;
		}
		set
		{
			_propagateCompletion = value;
		}
	}

	public int MaxMessages
	{
		get
		{
			return _maxNumberOfMessages;
		}
		set
		{
			if (value < 1 && value != -1)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			_maxNumberOfMessages = value;
		}
	}

	public bool Append
	{
		get
		{
			return _append;
		}
		set
		{
			_append = value;
		}
	}
}
