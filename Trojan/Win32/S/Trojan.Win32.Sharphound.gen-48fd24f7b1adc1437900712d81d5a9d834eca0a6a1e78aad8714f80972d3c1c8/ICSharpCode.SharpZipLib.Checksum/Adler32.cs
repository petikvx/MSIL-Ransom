using System;

namespace ICSharpCode.SharpZipLib.Checksum;

public sealed class Adler32 : IChecksum
{
	private static readonly uint BASE = 65521u;

	private uint checkValue;

	public long Value => checkValue;

	public Adler32()
	{
		Reset();
	}

	public void Reset()
	{
		checkValue = 1u;
	}

	public void Update(int bval)
	{
		uint num = checkValue & 0xFFFFu;
		uint num2 = checkValue >> 16;
		num = (uint)((int)num + (bval & 0xFF)) % BASE;
		num2 = (num + num2) % BASE;
		checkValue = (num2 << 16) + num;
	}

	public void Update(byte[] buffer)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		Update(new ArraySegment<byte>(buffer, 0, buffer.Length));
	}

	public void Update(ArraySegment<byte> segment)
	{
		uint num = checkValue & 0xFFFFu;
		uint num2 = checkValue >> 16;
		int num3 = segment.Count;
		int offset = segment.Offset;
		while (num3 > 0)
		{
			int num4 = 3800;
			if (3800 > num3)
			{
				num4 = num3;
			}
			num3 -= num4;
			while (--num4 >= 0)
			{
				num += (uint)(segment.Array[offset++] & 0xFF);
				num2 += num;
			}
			num %= BASE;
			num2 %= BASE;
		}
		checkValue = (num2 << 16) | num;
	}
}
