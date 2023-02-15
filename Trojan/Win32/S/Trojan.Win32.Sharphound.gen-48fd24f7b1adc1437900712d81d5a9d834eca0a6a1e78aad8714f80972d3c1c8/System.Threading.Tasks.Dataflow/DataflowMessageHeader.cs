using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks.Dataflow;

[DebuggerDisplay("Id = {Id}")]
[IsReadOnlyAttribute1]
public struct DataflowMessageHeader : IEquatable<DataflowMessageHeader>
{
	private readonly long _id;

	public bool IsValid => (ulong)_id > 0uL;

	public long Id => _id;

	public DataflowMessageHeader(long id)
	{
		if (id == 0L)
		{
			throw new ArgumentException(SR1.Argument_InvalidMessageId, "id");
		}
		_id = id;
	}

	public bool Equals(DataflowMessageHeader other)
	{
		return this == other;
	}

	public override bool Equals(object obj)
	{
		if (obj is DataflowMessageHeader)
		{
			return this == (DataflowMessageHeader)obj;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (int)Id;
	}

	public static bool operator ==(DataflowMessageHeader left, DataflowMessageHeader right)
	{
		return left.Id == right.Id;
	}

	public static bool operator !=(DataflowMessageHeader left, DataflowMessageHeader right)
	{
		return left.Id != right.Id;
	}
}
