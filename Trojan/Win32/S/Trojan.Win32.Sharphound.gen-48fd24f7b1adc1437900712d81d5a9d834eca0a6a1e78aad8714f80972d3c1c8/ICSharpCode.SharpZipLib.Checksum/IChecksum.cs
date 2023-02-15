using System;

namespace ICSharpCode.SharpZipLib.Checksum;

public interface IChecksum
{
	long Value { get; }

	void Reset();

	void Update(int bval);

	void Update(byte[] buffer);

	void Update(ArraySegment<byte> segment);
}
