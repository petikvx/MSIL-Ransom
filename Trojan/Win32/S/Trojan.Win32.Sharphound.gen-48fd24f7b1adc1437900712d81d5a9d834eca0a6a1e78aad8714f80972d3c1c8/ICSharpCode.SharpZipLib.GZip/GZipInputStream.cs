using System;
using System.IO;
using ICSharpCode.SharpZipLib.Checksum;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.GZip;

public class GZipInputStream : InflaterInputStream
{
	protected Crc32 crc;

	private bool readGZIPHeader;

	private bool completedLastBlock;

	public GZipInputStream(Stream baseInputStream)
		: this(baseInputStream, 4096)
	{
	}

	public GZipInputStream(Stream baseInputStream, int size)
		: base(baseInputStream, new Inflater(noHeader: true), size)
	{
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		int num;
		do
		{
			if (!readGZIPHeader)
			{
				try
				{
					if (!ReadHeader())
					{
						return 0;
					}
				}
				catch (Exception ex) when (completedLastBlock && (ex is GZipException || ex is EndOfStreamException))
				{
					return 0;
				}
			}
			num = base.Read(buffer, offset, count);
			if (num > 0)
			{
				crc.Update(new ArraySegment<byte>(buffer, offset, num));
			}
			if (inf.IsFinished)
			{
				ReadFooter();
			}
		}
		while (num <= 0 && count != 0);
		return num;
	}

	private bool ReadHeader()
	{
		this.crc = new Crc32();
		if (inputBuffer.Available <= 0)
		{
			inputBuffer.Fill();
			if (inputBuffer.Available <= 0)
			{
				return false;
			}
		}
		Crc32 crc = new Crc32();
		int num = inputBuffer.ReadLeByte();
		if (num < 0)
		{
			throw new EndOfStreamException("EOS reading GZIP header");
		}
		crc.Update(num);
		if (num != 31)
		{
			throw new GZipException("Error GZIP header, first magic byte doesn't match");
		}
		num = inputBuffer.ReadLeByte();
		if (num < 0)
		{
			throw new EndOfStreamException("EOS reading GZIP header");
		}
		if (num != 139)
		{
			throw new GZipException("Error GZIP header,  second magic byte doesn't match");
		}
		crc.Update(num);
		int num2 = inputBuffer.ReadLeByte();
		if (num2 < 0)
		{
			throw new EndOfStreamException("EOS reading GZIP header");
		}
		if (num2 != 8)
		{
			throw new GZipException("Error GZIP header, data not in deflate format");
		}
		crc.Update(num2);
		int num3 = inputBuffer.ReadLeByte();
		if (num3 < 0)
		{
			throw new EndOfStreamException("EOS reading GZIP header");
		}
		crc.Update(num3);
		if (((uint)num3 & 0xE0u) != 0)
		{
			throw new GZipException("Reserved flag bits in GZIP header != 0");
		}
		int num4 = 0;
		while (true)
		{
			if (num4 < 6)
			{
				int num5 = inputBuffer.ReadLeByte();
				if (num5 >= 0)
				{
					crc.Update(num5);
					num4++;
					continue;
				}
				throw new EndOfStreamException("EOS reading GZIP header");
			}
			if (((uint)num3 & 4u) != 0)
			{
				int num6 = inputBuffer.ReadLeByte();
				int num7 = inputBuffer.ReadLeByte();
				if (num6 < 0 || num7 < 0)
				{
					throw new EndOfStreamException("EOS reading GZIP header");
				}
				crc.Update(num6);
				crc.Update(num7);
				int num8 = (num7 << 8) | num6;
				for (int i = 0; i < num8; i++)
				{
					int num9 = inputBuffer.ReadLeByte();
					if (num9 >= 0)
					{
						crc.Update(num9);
						continue;
					}
					throw new EndOfStreamException("EOS reading GZIP header");
				}
			}
			if (((uint)num3 & 8u) != 0)
			{
				int num10;
				while ((num10 = inputBuffer.ReadLeByte()) > 0)
				{
					crc.Update(num10);
				}
				if (num10 < 0)
				{
					throw new EndOfStreamException("EOS reading GZIP header");
				}
				crc.Update(num10);
			}
			if (((uint)num3 & 0x10u) != 0)
			{
				int num11;
				while ((num11 = inputBuffer.ReadLeByte()) > 0)
				{
					crc.Update(num11);
				}
				if (num11 < 0)
				{
					throw new EndOfStreamException("EOS reading GZIP header");
				}
				crc.Update(num11);
			}
			if ((num3 & 2) == 0)
			{
				break;
			}
			int num12 = inputBuffer.ReadLeByte();
			if (num12 < 0)
			{
				throw new EndOfStreamException("EOS reading GZIP header");
			}
			int num13 = inputBuffer.ReadLeByte();
			if (num13 < 0)
			{
				throw new EndOfStreamException("EOS reading GZIP header");
			}
			if (((num12 << 8) | num13) == ((int)crc.Value & 0xFFFF))
			{
				break;
			}
			throw new GZipException("Header CRC value mismatch");
		}
		readGZIPHeader = true;
		return true;
	}

	private void ReadFooter()
	{
		byte[] array = new byte[8];
		long num = inf.TotalOut & 0xFFFFFFFFL;
		inputBuffer.Available += inf.RemainingInput;
		inf.Reset();
		int num2 = 8;
		while (true)
		{
			if (num2 > 0)
			{
				int num3 = inputBuffer.ReadClearTextBuffer(array, 8 - num2, num2);
				if (num3 > 0)
				{
					num2 -= num3;
					continue;
				}
				throw new EndOfStreamException("EOS reading GZIP footer");
			}
			int num4 = (array[0] & 0xFF) | ((array[1] & 0xFF) << 8) | ((array[2] & 0xFF) << 16) | (array[3] << 24);
			if (num4 != (int)crc.Value)
			{
				throw new GZipException("GZIP crc sum mismatch, theirs \"" + num4 + "\" and ours \"" + (int)crc.Value);
			}
			uint num5 = (array[4] & 0xFFu) | (uint)((array[5] & 0xFF) << 8) | (uint)((array[6] & 0xFF) << 16) | (uint)(array[7] << 24);
			if (num == num5)
			{
				break;
			}
			throw new GZipException("Number of bytes mismatch in footer");
		}
		readGZIPHeader = false;
		completedLastBlock = true;
	}
}
