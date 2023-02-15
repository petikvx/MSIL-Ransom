using System;
using System.IO;
using ICSharpCode.SharpZipLib.Checksum;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.GZip;

public class GZipOutputStream : DeflaterOutputStream
{
	private enum OutputState
	{
		Header,
		Footer,
		Finished,
		Closed
	}

	protected Crc32 crc = new Crc32();

	private OutputState state_;

	public GZipOutputStream(Stream baseOutputStream)
		: this(baseOutputStream, 4096)
	{
	}

	public GZipOutputStream(Stream baseOutputStream, int size)
		: base(baseOutputStream, new Deflater(-1, noZlibHeaderOrFooter: true), size)
	{
	}

	public void SetLevel(int level)
	{
		if (level < 0 || level > 9)
		{
			throw new ArgumentOutOfRangeException("level", "Compression level must be 0-9");
		}
		deflater_.SetLevel(level);
	}

	public int GetLevel()
	{
		return deflater_.GetLevel();
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (state_ == OutputState.Header)
		{
			WriteHeader();
		}
		if (state_ != OutputState.Footer)
		{
			throw new InvalidOperationException("Write not permitted in current state");
		}
		crc.Update(new ArraySegment<byte>(buffer, offset, count));
		base.Write(buffer, offset, count);
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			Finish();
		}
		finally
		{
			if (state_ != OutputState.Closed)
			{
				state_ = OutputState.Closed;
				if (base.IsStreamOwner)
				{
					baseOutputStream_.Dispose();
				}
			}
		}
	}

	public override void Finish()
	{
		if (state_ == OutputState.Header)
		{
			WriteHeader();
		}
		if (state_ == OutputState.Footer)
		{
			state_ = OutputState.Finished;
			base.Finish();
			uint num = (uint)((ulong)deflater_.TotalIn & 0xFFFFFFFFuL);
			uint num2 = (uint)((ulong)crc.Value & 0xFFFFFFFFuL);
			byte[] array = new byte[8]
			{
				(byte)num2,
				(byte)(num2 >> 8),
				(byte)(num2 >> 16),
				(byte)(num2 >> 24),
				(byte)num,
				(byte)(num >> 8),
				(byte)(num >> 16),
				(byte)(num >> 24)
			};
			baseOutputStream_.Write(array, 0, array.Length);
		}
	}

	private void WriteHeader()
	{
		if (state_ == OutputState.Header)
		{
			state_ = OutputState.Footer;
			int num = (int)((DateTime.Now.Ticks - new DateTime(1970, 1, 1).Ticks) / 10000000L);
			byte[] obj = new byte[10] { 31, 139, 8, 0, 0, 0, 0, 0, 0, 255 };
			obj[4] = (byte)num;
			obj[5] = (byte)(num >> 8);
			obj[6] = (byte)(num >> 16);
			obj[7] = (byte)(num >> 24);
			byte[] array = obj;
			baseOutputStream_.Write(array, 0, array.Length);
		}
	}
}
