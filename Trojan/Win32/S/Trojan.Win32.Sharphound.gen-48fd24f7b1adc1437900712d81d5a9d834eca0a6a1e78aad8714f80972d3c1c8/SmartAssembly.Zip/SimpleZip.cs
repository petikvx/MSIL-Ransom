using System;
using System.IO;
using System.Security.Cryptography;

namespace SmartAssembly.Zip;

public static class SimpleZip
{
	internal sealed class Inflater
	{
		private static readonly int[] CPLENS = new int[29]
		{
			3, 4, 5, 6, 7, 8, 9, 10, 11, 13,
			15, 17, 19, 23, 27, 31, 35, 43, 51, 59,
			67, 83, 99, 115, 131, 163, 195, 227, 258
		};

		private static readonly int[] CPLEXT = new int[29]
		{
			0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
			1, 1, 2, 2, 2, 2, 3, 3, 3, 3,
			4, 4, 4, 4, 5, 5, 5, 5, 0
		};

		private static readonly int[] CPDIST = new int[30]
		{
			1, 2, 3, 4, 5, 7, 9, 13, 17, 25,
			33, 49, 65, 97, 129, 193, 257, 385, 513, 769,
			1025, 1537, 2049, 3073, 4097, 6145, 8193, 12289, 16385, 24577
		};

		private static readonly int[] CPDEXT = new int[30]
		{
			0, 0, 0, 0, 1, 1, 2, 2, 3, 3,
			4, 4, 5, 5, 6, 6, 7, 7, 8, 8,
			9, 9, 10, 10, 11, 11, 12, 12, 13, 13
		};

		private const int DECODE_HEADER = 0;

		private const int DECODE_DICT = 1;

		private const int DECODE_BLOCKS = 2;

		private const int DECODE_STORED_LEN1 = 3;

		private const int DECODE_STORED_LEN2 = 4;

		private const int DECODE_STORED = 5;

		private const int DECODE_DYN_HEADER = 6;

		private const int DECODE_HUFFMAN = 7;

		private const int DECODE_HUFFMAN_LENBITS = 8;

		private const int DECODE_HUFFMAN_DIST = 9;

		private const int DECODE_HUFFMAN_DISTBITS = 10;

		private const int DECODE_CHKSUM = 11;

		private const int FINISHED = 12;

		private int mode;

		private int neededBits;

		private int repLength;

		private int repDist;

		private int uncomprLen;

		private bool isLastBlock;

		private StreamManipulator input;

		private OutputWindow outputWindow;

		private InflaterDynHeader dynHeader;

		private InflaterHuffmanTree litlenTree;

		private InflaterHuffmanTree distTree;

		public Inflater(byte[] bytes)
		{
			input = new StreamManipulator();
			outputWindow = new OutputWindow();
			mode = 2;
			input.SetInput(bytes, 0, bytes.Length);
		}

		private bool DecodeHuffman()
		{
			int num = outputWindow.GetFreeSpace();
			while (num >= 258)
			{
				switch (mode)
				{
				case 7:
				{
					int symbol;
					while (((symbol = litlenTree.GetSymbol(input)) & -256) == 0)
					{
						outputWindow.Write(symbol);
						if (--num < 258)
						{
							return true;
						}
					}
					if (symbol >= 257)
					{
						repLength = CPLENS[symbol - 257];
						neededBits = CPLEXT[symbol - 257];
						goto case 8;
					}
					if (symbol < 0)
					{
						return false;
					}
					distTree = null;
					litlenTree = null;
					mode = 2;
					return true;
				}
				case 8:
					if (neededBits > 0)
					{
						mode = 8;
						int num3 = input.PeekBits(neededBits);
						if (num3 < 0)
						{
							return false;
						}
						input.DropBits(neededBits);
						repLength += num3;
					}
					mode = 9;
					goto case 9;
				case 9:
				{
					int symbol = distTree.GetSymbol(input);
					if (symbol >= 0)
					{
						repDist = CPDIST[symbol];
						neededBits = CPDEXT[symbol];
						goto case 10;
					}
					return false;
				}
				case 10:
					if (neededBits > 0)
					{
						mode = 10;
						int num2 = input.PeekBits(neededBits);
						if (num2 < 0)
						{
							return false;
						}
						input.DropBits(neededBits);
						repDist += num2;
					}
					outputWindow.Repeat(repLength, repDist);
					num -= repLength;
					mode = 7;
					break;
				}
			}
			return true;
		}

		private bool Decode()
		{
			switch (mode)
			{
			case 2:
			{
				if (isLastBlock)
				{
					mode = 12;
					return false;
				}
				int num = input.PeekBits(3);
				if (num < 0)
				{
					return false;
				}
				input.DropBits(3);
				if (((uint)num & (true ? 1u : 0u)) != 0)
				{
					isLastBlock = true;
				}
				switch (num >> 1)
				{
				case 0:
					input.SkipToByteBoundary();
					mode = 3;
					break;
				case 1:
					litlenTree = InflaterHuffmanTree.defLitLenTree;
					distTree = InflaterHuffmanTree.defDistTree;
					mode = 7;
					break;
				case 2:
					dynHeader = new InflaterDynHeader();
					mode = 6;
					break;
				}
				return true;
			}
			case 3:
				if ((uncomprLen = input.PeekBits(16)) < 0)
				{
					return false;
				}
				input.DropBits(16);
				mode = 4;
				goto case 4;
			case 4:
				if (input.PeekBits(16) < 0)
				{
					return false;
				}
				input.DropBits(16);
				mode = 5;
				goto case 5;
			case 5:
			{
				int num2 = outputWindow.CopyStored(input, uncomprLen);
				uncomprLen -= num2;
				if (uncomprLen == 0)
				{
					mode = 2;
					return true;
				}
				return !input.IsNeedingInput;
			}
			case 6:
				if (!dynHeader.Decode(input))
				{
					return false;
				}
				litlenTree = dynHeader.BuildLitLenTree();
				distTree = dynHeader.BuildDistTree();
				mode = 7;
				goto case 7;
			case 7:
			case 8:
			case 9:
			case 10:
				return DecodeHuffman();
			default:
				return false;
			case 12:
				return false;
			}
		}

		public int Inflate(byte[] buf, int offset, int len)
		{
			int num = 0;
			do
			{
				if (mode != 11)
				{
					int num2 = outputWindow.CopyOutput(buf, offset, len);
					offset += num2;
					num += num2;
					len -= num2;
					if (len == 0)
					{
						return num;
					}
				}
			}
			while (Decode() || (outputWindow.GetAvailable() > 0 && mode != 11));
			return num;
		}
	}

	internal sealed class StreamManipulator
	{
		private byte[] window;

		private int window_start;

		private int window_end;

		private uint buffer;

		private int bits_in_buffer;

		public int AvailableBits => bits_in_buffer;

		public int AvailableBytes => window_end - window_start + (bits_in_buffer >> 3);

		public bool IsNeedingInput => window_start == window_end;

		public int PeekBits(int n)
		{
			if (bits_in_buffer < n)
			{
				if (window_start == window_end)
				{
					return -1;
				}
				buffer |= (uint)(((window[window_start++] & 0xFF) | ((window[window_start++] & 0xFF) << 8)) << bits_in_buffer);
				bits_in_buffer += 16;
			}
			return (int)(buffer & ((1 << n) - 1));
		}

		public void DropBits(int n)
		{
			buffer >>= n;
			bits_in_buffer -= n;
		}

		public void SkipToByteBoundary()
		{
			buffer >>= bits_in_buffer & 7;
			bits_in_buffer &= -8;
		}

		public int CopyBytes(byte[] output, int offset, int length)
		{
			int num = 0;
			while (bits_in_buffer > 0 && length > 0)
			{
				output[offset++] = (byte)buffer;
				buffer >>= 8;
				bits_in_buffer -= 8;
				length--;
				num++;
			}
			if (length == 0)
			{
				return num;
			}
			int num2 = window_end - window_start;
			if (length > num2)
			{
				length = num2;
			}
			Array.Copy(window, window_start, output, offset, length);
			window_start += length;
			if (((uint)(window_start - window_end) & (true ? 1u : 0u)) != 0)
			{
				buffer = window[window_start++] & 0xFFu;
				bits_in_buffer = 8;
			}
			return num + length;
		}

		public void Reset()
		{
			bits_in_buffer = 0;
			window_end = 0;
			window_start = 0;
			buffer = 0u;
		}

		public void SetInput(byte[] buf, int off, int len)
		{
			if (window_start < window_end)
			{
				throw new InvalidOperationException();
			}
			int num = off + len;
			if (0 <= off && off <= num && num <= buf.Length)
			{
				if (((uint)len & (true ? 1u : 0u)) != 0)
				{
					buffer |= (uint)((buf[off++] & 0xFF) << bits_in_buffer);
					bits_in_buffer += 8;
				}
				window = buf;
				window_start = off;
				window_end = num;
				return;
			}
			throw new ArgumentOutOfRangeException();
		}
	}

	internal sealed class OutputWindow
	{
		private const int WINDOW_SIZE = 32768;

		private const int WINDOW_MASK = 32767;

		private byte[] window = new byte[32768];

		private int windowEnd;

		private int windowFilled;

		public void Write(int abyte)
		{
			if (windowFilled++ == 32768)
			{
				throw new InvalidOperationException();
			}
			window[windowEnd++] = (byte)abyte;
			windowEnd &= 32767;
		}

		private void SlowRepeat(int repStart, int len)
		{
			while (len-- > 0)
			{
				window[windowEnd++] = window[repStart++];
				windowEnd &= 32767;
				repStart &= 0x7FFF;
			}
		}

		public void Repeat(int len, int dist)
		{
			if ((windowFilled += len) > 32768)
			{
				throw new InvalidOperationException();
			}
			int num = (windowEnd - dist) & 0x7FFF;
			int num2 = 32768 - len;
			if (num <= num2 && windowEnd < num2)
			{
				if (len <= dist)
				{
					Array.Copy(window, num, window, windowEnd, len);
					windowEnd += len;
				}
				else
				{
					while (len-- > 0)
					{
						window[windowEnd++] = window[num++];
					}
				}
			}
			else
			{
				SlowRepeat(num, len);
			}
		}

		public int CopyStored(StreamManipulator input, int len)
		{
			len = Math.Min(Math.Min(len, 32768 - windowFilled), input.AvailableBytes);
			int num = 32768 - windowEnd;
			int num2;
			if (len > num)
			{
				num2 = input.CopyBytes(window, windowEnd, num);
				if (num2 == num)
				{
					num2 += input.CopyBytes(window, 0, len - num);
				}
			}
			else
			{
				num2 = input.CopyBytes(window, windowEnd, len);
			}
			windowEnd = (windowEnd + num2) & 0x7FFF;
			windowFilled += num2;
			return num2;
		}

		public void CopyDict(byte[] dict, int offset, int len)
		{
			if (windowFilled > 0)
			{
				throw new InvalidOperationException();
			}
			if (len > 32768)
			{
				offset += len - 32768;
				len = 32768;
			}
			Array.Copy(dict, offset, window, 0, len);
			windowEnd = len & 0x7FFF;
		}

		public int GetFreeSpace()
		{
			return 32768 - windowFilled;
		}

		public int GetAvailable()
		{
			return windowFilled;
		}

		public int CopyOutput(byte[] output, int offset, int len)
		{
			int num = windowEnd;
			if (len > windowFilled)
			{
				len = windowFilled;
			}
			else
			{
				num = (windowEnd - windowFilled + len) & 0x7FFF;
			}
			int num2 = len;
			int num3 = len - num;
			if (num3 > 0)
			{
				Array.Copy(window, 32768 - num3, output, offset, num3);
				offset += num3;
				len = num;
			}
			Array.Copy(window, num - len, output, offset, len);
			windowFilled -= num2;
			if (windowFilled < 0)
			{
				throw new InvalidOperationException();
			}
			return num2;
		}

		public void Reset()
		{
			windowEnd = 0;
			windowFilled = 0;
		}
	}

	internal sealed class InflaterHuffmanTree
	{
		private const int MAX_BITLEN = 15;

		private short[] tree;

		public static readonly InflaterHuffmanTree defLitLenTree;

		public static readonly InflaterHuffmanTree defDistTree;

		static InflaterHuffmanTree()
		{
			byte[] array = new byte[288];
			int num = 0;
			while (num < 144)
			{
				array[num++] = 8;
			}
			while (num < 256)
			{
				array[num++] = 9;
			}
			while (num < 280)
			{
				array[num++] = 7;
			}
			while (num < 288)
			{
				array[num++] = 8;
			}
			defLitLenTree = new InflaterHuffmanTree(array);
			array = new byte[32];
			num = 0;
			while (num < 32)
			{
				array[num++] = 5;
			}
			defDistTree = new InflaterHuffmanTree(array);
		}

		public InflaterHuffmanTree(byte[] codeLengths)
		{
			BuildTree(codeLengths);
		}

		private void BuildTree(byte[] codeLengths)
		{
			int[] array = new int[16];
			int[] array2 = new int[16];
			foreach (int num in codeLengths)
			{
				if (num > 0)
				{
					array[num]++;
				}
			}
			int num2 = 0;
			int num3 = 512;
			for (int j = 1; j <= 15; j++)
			{
				array2[j] = num2;
				num2 += array[j] << 16 - j;
				if (j >= 10)
				{
					int num4 = array2[j] & 0x1FF80;
					int num5 = num2 & 0x1FF80;
					num3 += num5 - num4 >> 16 - j;
				}
			}
			tree = new short[num3];
			int num6 = 512;
			for (int num7 = 15; num7 >= 10; num7--)
			{
				int num8 = num2 & 0x1FF80;
				num2 -= array[num7] << 16 - num7;
				for (int k = num2 & 0x1FF80; k < num8; k += 128)
				{
					tree[DeflaterHuffman.BitReverse(k)] = (short)((-num6 << 4) | num7);
					num6 += 1 << num7 - 9;
				}
			}
			for (int l = 0; l < codeLengths.Length; l++)
			{
				int num9 = codeLengths[l];
				if (num9 == 0)
				{
					continue;
				}
				num2 = array2[num9];
				int num10 = DeflaterHuffman.BitReverse(num2);
				if (num9 <= 9)
				{
					do
					{
						tree[num10] = (short)((l << 4) | num9);
						num10 += 1 << num9;
					}
					while (num10 < 512);
				}
				else
				{
					int num11 = tree[num10 & 0x1FF];
					int num12 = 1 << (num11 & 0xF);
					num11 = -(num11 >> 4);
					do
					{
						tree[num11 | (num10 >> 9)] = (short)((l << 4) | num9);
						num10 += 1 << num9;
					}
					while (num10 < num12);
				}
				array2[num9] = num2 + (1 << 16 - num9);
			}
		}

		public int GetSymbol(StreamManipulator input)
		{
			int num;
			int num2;
			if ((num = input.PeekBits(9)) >= 0)
			{
				if ((num2 = tree[num]) >= 0)
				{
					input.DropBits(num2 & 0xF);
					return num2 >> 4;
				}
				int num3 = -(num2 >> 4);
				int n = num2 & 0xF;
				if ((num = input.PeekBits(n)) >= 0)
				{
					num2 = tree[num3 | (num >> 9)];
					input.DropBits(num2 & 0xF);
					return num2 >> 4;
				}
				int availableBits = input.AvailableBits;
				num = input.PeekBits(availableBits);
				num2 = tree[num3 | (num >> 9)];
				if ((num2 & 0xF) <= availableBits)
				{
					input.DropBits(num2 & 0xF);
					return num2 >> 4;
				}
				return -1;
			}
			int availableBits2 = input.AvailableBits;
			num = input.PeekBits(availableBits2);
			num2 = tree[num];
			if (num2 >= 0 && (num2 & 0xF) <= availableBits2)
			{
				input.DropBits(num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
	}

	internal sealed class InflaterDynHeader
	{
		private const int LNUM = 0;

		private const int DNUM = 1;

		private const int BLNUM = 2;

		private const int BLLENS = 3;

		private const int LENS = 4;

		private const int REPS = 5;

		private static readonly int[] repMin = new int[3] { 3, 3, 11 };

		private static readonly int[] repBits = new int[3] { 2, 3, 7 };

		private byte[] blLens;

		private byte[] litdistLens;

		private InflaterHuffmanTree blTree;

		private int mode;

		private int lnum;

		private int dnum;

		private int blnum;

		private int num;

		private int repSymbol;

		private byte lastLen;

		private int ptr;

		private static readonly int[] BL_ORDER = new int[19]
		{
			16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
			11, 4, 12, 3, 13, 2, 14, 1, 15
		};

		public bool Decode(StreamManipulator input)
		{
			while (true)
			{
				switch (mode)
				{
				case 5:
				{
					int n = repBits[repSymbol];
					int num = input.PeekBits(n);
					if (num >= 0)
					{
						input.DropBits(n);
						num += repMin[repSymbol];
						while (num-- > 0)
						{
							litdistLens[ptr++] = lastLen;
						}
						if (ptr == this.num)
						{
							return true;
						}
						goto IL_00a0;
					}
					return false;
				}
				case 4:
				{
					int symbol;
					while (((symbol = blTree.GetSymbol(input)) & -16) == 0)
					{
						litdistLens[ptr++] = (lastLen = (byte)symbol);
						if (ptr == this.num)
						{
							return true;
						}
					}
					if (symbol >= 0)
					{
						if (symbol >= 17)
						{
							lastLen = 0;
						}
						repSymbol = symbol - 16;
						mode = 5;
						goto case 5;
					}
					return false;
				}
				case 3:
					while (ptr < blnum)
					{
						int num2 = input.PeekBits(3);
						if (num2 >= 0)
						{
							input.DropBits(3);
							blLens[BL_ORDER[ptr]] = (byte)num2;
							ptr++;
							continue;
						}
						return false;
					}
					blTree = new InflaterHuffmanTree(blLens);
					blLens = null;
					ptr = 0;
					mode = 4;
					goto case 4;
				case 2:
					blnum = input.PeekBits(4);
					if (blnum >= 0)
					{
						blnum += 4;
						input.DropBits(4);
						blLens = new byte[19];
						ptr = 0;
						mode = 3;
						goto case 3;
					}
					return false;
				case 1:
					dnum = input.PeekBits(5);
					if (dnum >= 0)
					{
						dnum++;
						input.DropBits(5);
						this.num = lnum + dnum;
						litdistLens = new byte[this.num];
						mode = 2;
						goto case 2;
					}
					return false;
				case 0:
					lnum = input.PeekBits(5);
					if (lnum >= 0)
					{
						lnum += 257;
						input.DropBits(5);
						mode = 1;
						goto case 1;
					}
					return false;
				}
				continue;
				IL_00a0:
				mode = 4;
			}
		}

		public InflaterHuffmanTree BuildLitLenTree()
		{
			byte[] array = new byte[lnum];
			Array.Copy(litdistLens, 0, array, 0, lnum);
			return new InflaterHuffmanTree(array);
		}

		public InflaterHuffmanTree BuildDistTree()
		{
			byte[] array = new byte[dnum];
			Array.Copy(litdistLens, lnum, array, 0, dnum);
			return new InflaterHuffmanTree(array);
		}
	}

	internal sealed class Deflater
	{
		private const int IS_FLUSHING = 4;

		private const int IS_FINISHING = 8;

		private const int BUSY_STATE = 16;

		private const int FLUSHING_STATE = 20;

		private const int FINISHING_STATE = 28;

		private const int FINISHED_STATE = 30;

		private int state = 16;

		private long totalOut;

		private DeflaterPending pending;

		private DeflaterEngine engine;

		public long TotalOut => totalOut;

		public bool IsFinished
		{
			get
			{
				if (state == 30)
				{
					return pending.IsFlushed;
				}
				return false;
			}
		}

		public bool IsNeedingInput => engine.NeedsInput();

		public Deflater()
		{
			pending = new DeflaterPending();
			engine = new DeflaterEngine(pending);
		}

		public void Finish()
		{
			state |= 12;
		}

		public void SetInput(byte[] buffer)
		{
			engine.SetInput(buffer);
		}

		public int Deflate(byte[] output)
		{
			int num = 0;
			int num2 = output.Length;
			int num3 = num2;
			while (true)
			{
				int num4 = pending.Flush(output, num, num2);
				num += num4;
				totalOut += num4;
				num2 -= num4;
				if (num2 == 0 || state == 30)
				{
					break;
				}
				if (engine.Deflate((state & 4) != 0, (state & 8) != 0))
				{
					continue;
				}
				if (state != 16)
				{
					if (state == 20)
					{
						for (int num5 = 8 + (-pending.BitCount & 7); num5 > 0; num5 -= 10)
						{
							pending.WriteBits(2, 10);
						}
						state = 16;
					}
					else if (state == 28)
					{
						pending.AlignToByte();
						state = 30;
					}
					continue;
				}
				return num3 - num2;
			}
			return num3 - num2;
		}
	}

	internal sealed class DeflaterHuffman
	{
		public sealed class Tree
		{
			public short[] freqs;

			public byte[] length;

			public int minNumCodes;

			public int numCodes;

			private short[] codes;

			private int[] bl_counts;

			private int maxLength;

			private DeflaterHuffman dh;

			public Tree(DeflaterHuffman dh, int elems, int minCodes, int maxLength)
			{
				this.dh = dh;
				minNumCodes = minCodes;
				this.maxLength = maxLength;
				freqs = new short[elems];
				bl_counts = new int[maxLength];
			}

			public void WriteSymbol(int code)
			{
				dh.pending.WriteBits(codes[code] & 0xFFFF, length[code]);
			}

			public void SetStaticCodes(short[] stCodes, byte[] stLength)
			{
				codes = stCodes;
				length = stLength;
			}

			public void BuildCodes()
			{
				int[] array = new int[maxLength];
				int num = 0;
				codes = new short[freqs.Length];
				for (int i = 0; i < maxLength; i++)
				{
					array[i] = num;
					num += bl_counts[i] << 15 - i;
				}
				for (int j = 0; j < numCodes; j++)
				{
					int num2 = length[j];
					if (num2 > 0)
					{
						codes[j] = BitReverse(array[num2 - 1]);
						array[num2 - 1] += 1 << 16 - num2;
					}
				}
			}

			private void BuildLength(int[] childs)
			{
				length = new byte[freqs.Length];
				int num = childs.Length / 2;
				int num2 = (num + 1) / 2;
				int num3 = 0;
				for (int i = 0; i < maxLength; i++)
				{
					bl_counts[i] = 0;
				}
				int[] array = new int[num];
				array[num - 1] = 0;
				for (int num4 = num - 1; num4 >= 0; num4--)
				{
					if (childs[2 * num4 + 1] != -1)
					{
						int num5 = array[num4] + 1;
						if (num5 > maxLength)
						{
							num5 = maxLength;
							num3++;
						}
						array[childs[2 * num4]] = (array[childs[2 * num4 + 1]] = num5);
					}
					else
					{
						int num6 = array[num4];
						bl_counts[num6 - 1]++;
						length[childs[2 * num4]] = (byte)array[num4];
					}
				}
				if (num3 == 0)
				{
					return;
				}
				int num7 = maxLength - 1;
				while (true)
				{
					if (bl_counts[--num7] != 0)
					{
						do
						{
							bl_counts[num7]--;
							bl_counts[++num7]++;
							num3 -= 1 << maxLength - 1 - num7;
						}
						while (num3 > 0 && num7 < maxLength - 1);
						if (num3 <= 0)
						{
							break;
						}
					}
				}
				bl_counts[maxLength - 1] += num3;
				bl_counts[maxLength - 2] -= num3;
				int num8 = 2 * num2;
				for (int num9 = maxLength; num9 != 0; num9--)
				{
					int num10 = bl_counts[num9 - 1];
					while (num10 > 0)
					{
						int num11 = 2 * childs[num8++];
						if (childs[num11 + 1] == -1)
						{
							length[childs[num11]] = (byte)num9;
							num10--;
						}
					}
				}
			}

			public void BuildTree()
			{
				int num = freqs.Length;
				int[] array = new int[num];
				int num2 = 0;
				int num3 = 0;
				for (int i = 0; i < num; i++)
				{
					int num4 = freqs[i];
					if (num4 != 0)
					{
						int num5 = num2++;
						int num6;
						while (num5 > 0 && freqs[array[num6 = (num5 - 1) / 2]] > num4)
						{
							array[num5] = array[num6];
							num5 = num6;
						}
						array[num5] = i;
						num3 = i;
					}
				}
				while (num2 < 2)
				{
					int num7 = ((num3 < 2) ? (++num3) : 0);
					array[num2++] = num7;
				}
				numCodes = Math.Max(num3 + 1, minNumCodes);
				int num8 = num2;
				int[] array2 = new int[4 * num2 - 2];
				int[] array3 = new int[2 * num2 - 1];
				int num9 = num8;
				for (int j = 0; j < num2; j++)
				{
					int num10 = (array2[2 * j] = array[j]);
					array2[2 * j + 1] = -1;
					array3[j] = freqs[num10] << 8;
					array[j] = j;
				}
				do
				{
					int num11 = array[0];
					int num12 = array[--num2];
					int num13 = 0;
					int num14;
					for (num14 = 1; num14 < num2; num14 = num14 * 2 + 1)
					{
						if (num14 + 1 < num2 && array3[array[num14]] > array3[array[num14 + 1]])
						{
							num14++;
						}
						array[num13] = array[num14];
						num13 = num14;
					}
					int num15 = array3[num12];
					while ((num14 = num13) > 0 && array3[array[num13 = (num14 - 1) / 2]] > num15)
					{
						array[num14] = array[num13];
					}
					array[num14] = num12;
					int num16 = array[0];
					num12 = num9++;
					array2[2 * num12] = num11;
					array2[2 * num12 + 1] = num16;
					int num17 = Math.Min(array3[num11] & 0xFF, array3[num16] & 0xFF);
					num15 = (array3[num12] = array3[num11] + array3[num16] - num17 + 1);
					num13 = 0;
					for (num14 = 1; num14 < num2; num14 = num13 * 2 + 1)
					{
						if (num14 + 1 < num2 && array3[array[num14]] > array3[array[num14 + 1]])
						{
							num14++;
						}
						array[num13] = array[num14];
						num13 = num14;
					}
					while ((num14 = num13) > 0 && array3[array[num13 = (num14 - 1) / 2]] > num15)
					{
						array[num14] = array[num13];
					}
					array[num14] = num12;
				}
				while (num2 > 1);
				BuildLength(array2);
			}

			public int GetEncodedLength()
			{
				int num = 0;
				for (int i = 0; i < freqs.Length; i++)
				{
					num += freqs[i] * length[i];
				}
				return num;
			}

			public void CalcBLFreq(Tree blTree)
			{
				int num = -1;
				int num2 = 0;
				while (num2 < numCodes)
				{
					int num3 = 1;
					int num4 = length[num2];
					int num5;
					int num6;
					if (num4 == 0)
					{
						num5 = 138;
						num6 = 3;
					}
					else
					{
						num5 = 6;
						num6 = 3;
						if (num != num4)
						{
							blTree.freqs[num4]++;
							num3 = 0;
						}
					}
					num = num4;
					num2++;
					while (num2 < numCodes && num == length[num2])
					{
						num2++;
						if (++num3 >= num5)
						{
							break;
						}
					}
					if (num3 < num6)
					{
						blTree.freqs[num] += (short)num3;
					}
					else if (num != 0)
					{
						blTree.freqs[16]++;
					}
					else if (num3 <= 10)
					{
						blTree.freqs[17]++;
					}
					else
					{
						blTree.freqs[18]++;
					}
				}
			}

			public void WriteTree(Tree blTree)
			{
				int num = -1;
				int num2 = 0;
				while (num2 < numCodes)
				{
					int num3 = 1;
					int num4 = length[num2];
					int num5;
					int num6;
					if (num4 == 0)
					{
						num5 = 138;
						num6 = 3;
					}
					else
					{
						num5 = 6;
						num6 = 3;
						if (num != num4)
						{
							blTree.WriteSymbol(num4);
							num3 = 0;
						}
					}
					num = num4;
					num2++;
					while (num2 < numCodes && num == length[num2])
					{
						num2++;
						if (++num3 >= num5)
						{
							break;
						}
					}
					if (num3 < num6)
					{
						while (num3-- > 0)
						{
							blTree.WriteSymbol(num);
						}
					}
					else if (num != 0)
					{
						blTree.WriteSymbol(16);
						dh.pending.WriteBits(num3 - 3, 2);
					}
					else if (num3 <= 10)
					{
						blTree.WriteSymbol(17);
						dh.pending.WriteBits(num3 - 3, 3);
					}
					else
					{
						blTree.WriteSymbol(18);
						dh.pending.WriteBits(num3 - 11, 7);
					}
				}
			}
		}

		private const int BUFSIZE = 16384;

		private const int LITERAL_NUM = 286;

		private const int DIST_NUM = 30;

		private const int BITLEN_NUM = 19;

		private const int REP_3_6 = 16;

		private const int REP_3_10 = 17;

		private const int REP_11_138 = 18;

		private const int EOF_SYMBOL = 256;

		private static readonly int[] BL_ORDER;

		private static readonly byte[] bit4Reverse;

		private DeflaterPending pending;

		private Tree literalTree;

		private Tree distTree;

		private Tree blTree;

		private short[] d_buf;

		private byte[] l_buf;

		private int last_lit;

		private int extra_bits;

		private static readonly short[] staticLCodes;

		private static readonly byte[] staticLLength;

		private static readonly short[] staticDCodes;

		private static readonly byte[] staticDLength;

		public static short BitReverse(int toReverse)
		{
			return (short)((bit4Reverse[toReverse & 0xF] << 12) | (bit4Reverse[(toReverse >> 4) & 0xF] << 8) | (bit4Reverse[(toReverse >> 8) & 0xF] << 4) | bit4Reverse[toReverse >> 12]);
		}

		static DeflaterHuffman()
		{
			BL_ORDER = new int[19]
			{
				16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
				11, 4, 12, 3, 13, 2, 14, 1, 15
			};
			bit4Reverse = new byte[16]
			{
				0, 8, 4, 12, 2, 10, 6, 14, 1, 9,
				5, 13, 3, 11, 7, 15
			};
			staticLCodes = new short[286];
			staticLLength = new byte[286];
			int num = 0;
			while (num < 144)
			{
				staticLCodes[num] = BitReverse(48 + num << 8);
				staticLLength[num++] = 8;
			}
			while (num < 256)
			{
				staticLCodes[num] = BitReverse(256 + num << 7);
				staticLLength[num++] = 9;
			}
			while (num < 280)
			{
				staticLCodes[num] = BitReverse(-256 + num << 9);
				staticLLength[num++] = 7;
			}
			while (num < 286)
			{
				staticLCodes[num] = BitReverse(-88 + num << 8);
				staticLLength[num++] = 8;
			}
			staticDCodes = new short[30];
			staticDLength = new byte[30];
			for (num = 0; num < 30; num++)
			{
				staticDCodes[num] = BitReverse(num << 11);
				staticDLength[num] = 5;
			}
		}

		public DeflaterHuffman(DeflaterPending pending)
		{
			this.pending = pending;
			literalTree = new Tree(this, 286, 257, 15);
			distTree = new Tree(this, 30, 1, 15);
			blTree = new Tree(this, 19, 4, 7);
			d_buf = new short[16384];
			l_buf = new byte[16384];
		}

		public void Init()
		{
			last_lit = 0;
			extra_bits = 0;
		}

		private int Lcode(int len)
		{
			if (len == 255)
			{
				return 285;
			}
			int num = 257;
			while (len >= 8)
			{
				num += 4;
				len >>= 1;
			}
			return num + len;
		}

		private int Dcode(int distance)
		{
			int num = 0;
			while (distance >= 4)
			{
				num += 2;
				distance >>= 1;
			}
			return num + distance;
		}

		public void SendAllTrees(int blTreeCodes)
		{
			blTree.BuildCodes();
			literalTree.BuildCodes();
			distTree.BuildCodes();
			pending.WriteBits(literalTree.numCodes - 257, 5);
			pending.WriteBits(distTree.numCodes - 1, 5);
			pending.WriteBits(blTreeCodes - 4, 4);
			for (int i = 0; i < blTreeCodes; i++)
			{
				pending.WriteBits(blTree.length[BL_ORDER[i]], 3);
			}
			literalTree.WriteTree(blTree);
			distTree.WriteTree(blTree);
		}

		public void CompressBlock()
		{
			for (int i = 0; i < last_lit; i++)
			{
				int num = l_buf[i] & 0xFF;
				int num2 = d_buf[i];
				if (num2-- != 0)
				{
					int num3 = Lcode(num);
					literalTree.WriteSymbol(num3);
					int num4 = (num3 - 261) / 4;
					if (num4 > 0 && num4 <= 5)
					{
						pending.WriteBits(num & ((1 << num4) - 1), num4);
					}
					int num5 = Dcode(num2);
					distTree.WriteSymbol(num5);
					num4 = num5 / 2 - 1;
					if (num4 > 0)
					{
						pending.WriteBits(num2 & ((1 << num4) - 1), num4);
					}
				}
				else
				{
					literalTree.WriteSymbol(num);
				}
			}
			literalTree.WriteSymbol(256);
		}

		public void FlushStoredBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock)
		{
			pending.WriteBits(lastBlock ? 1 : 0, 3);
			pending.AlignToByte();
			pending.WriteShort(storedLength);
			pending.WriteShort(~storedLength);
			pending.WriteBlock(stored, storedOffset, storedLength);
			Init();
		}

		public void FlushBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock)
		{
			literalTree.freqs[256]++;
			literalTree.BuildTree();
			distTree.BuildTree();
			literalTree.CalcBLFreq(blTree);
			distTree.CalcBLFreq(blTree);
			blTree.BuildTree();
			int num = 4;
			for (int num2 = 18; num2 > num; num2--)
			{
				if (blTree.length[BL_ORDER[num2]] > 0)
				{
					num = num2 + 1;
				}
			}
			int num3 = 14 + num * 3 + blTree.GetEncodedLength() + literalTree.GetEncodedLength() + distTree.GetEncodedLength() + extra_bits;
			int num4 = extra_bits;
			for (int i = 0; i < 286; i++)
			{
				num4 += literalTree.freqs[i] * staticLLength[i];
			}
			for (int j = 0; j < 30; j++)
			{
				num4 += distTree.freqs[j] * staticDLength[j];
			}
			if (num3 >= num4)
			{
				num3 = num4;
			}
			if (storedOffset >= 0 && storedLength + 4 < num3 >> 3)
			{
				FlushStoredBlock(stored, storedOffset, storedLength, lastBlock);
			}
			else if (num3 == num4)
			{
				pending.WriteBits(2 + (lastBlock ? 1 : 0), 3);
				literalTree.SetStaticCodes(staticLCodes, staticLLength);
				distTree.SetStaticCodes(staticDCodes, staticDLength);
				CompressBlock();
				Init();
			}
			else
			{
				pending.WriteBits(4 + (lastBlock ? 1 : 0), 3);
				SendAllTrees(num);
				CompressBlock();
				Init();
			}
		}

		public bool IsFull()
		{
			return last_lit >= 16384;
		}

		public bool TallyLit(int lit)
		{
			d_buf[last_lit] = 0;
			l_buf[last_lit++] = (byte)lit;
			literalTree.freqs[lit]++;
			return IsFull();
		}

		public bool TallyDist(int dist, int len)
		{
			d_buf[last_lit] = (short)dist;
			l_buf[last_lit++] = (byte)(len - 3);
			int num = Lcode(len - 3);
			literalTree.freqs[num]++;
			if (num >= 265 && num < 285)
			{
				extra_bits += (num - 261) / 4;
			}
			int num2 = Dcode(dist - 1);
			distTree.freqs[num2]++;
			if (num2 >= 4)
			{
				extra_bits += num2 / 2 - 1;
			}
			return IsFull();
		}
	}

	internal sealed class DeflaterEngine
	{
		private const int MAX_MATCH = 258;

		private const int MIN_MATCH = 3;

		private const int WSIZE = 32768;

		private const int WMASK = 32767;

		private const int HASH_SIZE = 32768;

		private const int HASH_MASK = 32767;

		private const int HASH_SHIFT = 5;

		private const int MIN_LOOKAHEAD = 262;

		private const int MAX_DIST = 32506;

		private const int TOO_FAR = 4096;

		private int ins_h;

		private short[] head;

		private short[] prev;

		private int matchStart;

		private int matchLen;

		private bool prevAvailable;

		private int blockStart;

		private int strstart;

		private int lookahead;

		private byte[] window;

		private byte[] inputBuf;

		private int totalIn;

		private int inputOff;

		private int inputEnd;

		private DeflaterPending pending;

		private DeflaterHuffman huffman;

		public DeflaterEngine(DeflaterPending pending)
		{
			this.pending = pending;
			huffman = new DeflaterHuffman(pending);
			window = new byte[65536];
			head = new short[32768];
			prev = new short[32768];
			strstart = 1;
			blockStart = 1;
		}

		private void UpdateHash()
		{
			ins_h = (window[strstart] << 5) ^ window[strstart + 1];
		}

		private int InsertString()
		{
			int num = ((ins_h << 5) ^ window[strstart + 2]) & 0x7FFF;
			short num2 = (prev[strstart & 0x7FFF] = head[num]);
			head[num] = (short)strstart;
			ins_h = num;
			return num2 & 0xFFFF;
		}

		private void SlideWindow()
		{
			Array.Copy(window, 32768, window, 0, 32768);
			matchStart -= 32768;
			strstart -= 32768;
			blockStart -= 32768;
			for (int i = 0; i < 32768; i++)
			{
				int num = head[i] & 0xFFFF;
				head[i] = (short)((num >= 32768) ? (num - 32768) : 0);
			}
			for (int j = 0; j < 32768; j++)
			{
				int num2 = prev[j] & 0xFFFF;
				prev[j] = (short)((num2 >= 32768) ? (num2 - 32768) : 0);
			}
		}

		public void FillWindow()
		{
			if (strstart >= 65274)
			{
				SlideWindow();
			}
			while (lookahead < 262 && inputOff < inputEnd)
			{
				int num = 65536 - lookahead - strstart;
				if (num > inputEnd - inputOff)
				{
					num = inputEnd - inputOff;
				}
				Array.Copy(inputBuf, inputOff, window, strstart + lookahead, num);
				inputOff += num;
				totalIn += num;
				lookahead += num;
			}
			if (lookahead >= 3)
			{
				UpdateHash();
			}
		}

		private bool FindLongestMatch(int curMatch)
		{
			int num = 128;
			int num2 = 128;
			short[] array = prev;
			int num3 = strstart;
			int num4 = strstart + matchLen;
			int num5 = Math.Max(matchLen, 2);
			int num6 = Math.Max(strstart - 32506, 0);
			int num7 = strstart + 258 - 1;
			byte b = window[num4 - 1];
			byte b2 = window[num4];
			if (num5 >= 8)
			{
				num >>= 2;
			}
			if (num2 > lookahead)
			{
				num2 = lookahead;
			}
			do
			{
				if (window[curMatch + num5] != b2 || window[curMatch + num5 - 1] != b || window[curMatch] != window[num3] || window[curMatch + 1] != window[num3 + 1])
				{
					continue;
				}
				int num8 = curMatch + 2;
				num3 += 2;
				while (window[++num3] == window[++num8] && window[++num3] == window[++num8] && window[++num3] == window[++num8] && window[++num3] == window[++num8] && window[++num3] == window[++num8] && window[++num3] == window[++num8] && window[++num3] == window[++num8] && window[++num3] == window[++num8] && num3 < num7)
				{
				}
				if (num3 > num4)
				{
					matchStart = curMatch;
					num4 = num3;
					num5 = num3 - strstart;
					if (num5 >= num2)
					{
						break;
					}
					b = window[num4 - 1];
					b2 = window[num4];
				}
				num3 = strstart;
			}
			while ((curMatch = array[curMatch & 0x7FFF] & 0xFFFF) > num6 && --num != 0);
			matchLen = Math.Min(num5, lookahead);
			return matchLen >= 3;
		}

		private bool DeflateSlow(bool flush, bool finish)
		{
			if (lookahead < 262 && !flush)
			{
				return false;
			}
			do
			{
				if (lookahead >= 262 || flush)
				{
					if (lookahead != 0)
					{
						if (strstart >= 65274)
						{
							SlideWindow();
						}
						int num = matchStart;
						int num2 = matchLen;
						if (lookahead >= 3)
						{
							int num3 = InsertString();
							if (num3 != 0 && strstart - num3 <= 32506 && FindLongestMatch(num3) && matchLen <= 5 && matchLen == 3 && strstart - matchStart > 4096)
							{
								matchLen = 2;
							}
						}
						if (num2 >= 3 && matchLen <= num2)
						{
							huffman.TallyDist(strstart - 1 - num, num2);
							num2 -= 2;
							do
							{
								strstart++;
								lookahead--;
								if (lookahead >= 3)
								{
									InsertString();
								}
							}
							while (--num2 > 0);
							strstart++;
							lookahead--;
							prevAvailable = false;
							matchLen = 2;
						}
						else
						{
							if (prevAvailable)
							{
								huffman.TallyLit(window[strstart - 1] & 0xFF);
							}
							prevAvailable = true;
							strstart++;
							lookahead--;
						}
						continue;
					}
					if (prevAvailable)
					{
						huffman.TallyLit(window[strstart - 1] & 0xFF);
					}
					prevAvailable = false;
					huffman.FlushBlock(window, blockStart, strstart - blockStart, finish);
					blockStart = strstart;
					return false;
				}
				return true;
			}
			while (!huffman.IsFull());
			int num4 = strstart - blockStart;
			if (prevAvailable)
			{
				num4--;
			}
			bool flag = finish && lookahead == 0 && !prevAvailable;
			huffman.FlushBlock(window, blockStart, num4, flag);
			blockStart += num4;
			return !flag;
		}

		public bool Deflate(bool flush, bool finish)
		{
			bool flag;
			do
			{
				FillWindow();
				bool flush2 = flush && inputOff == inputEnd;
				flag = DeflateSlow(flush2, finish);
			}
			while (pending.IsFlushed && flag);
			return flag;
		}

		public void SetInput(byte[] buffer)
		{
			inputBuf = buffer;
			inputOff = 0;
			inputEnd = buffer.Length;
		}

		public bool NeedsInput()
		{
			return inputEnd == inputOff;
		}
	}

	internal sealed class DeflaterPending
	{
		protected byte[] buf = new byte[65536];

		private int start;

		private int end;

		private uint bits;

		private int bitCount;

		public int BitCount => bitCount;

		public bool IsFlushed => end == 0;

		public void WriteShort(int s)
		{
			buf[end++] = (byte)s;
			buf[end++] = (byte)(s >> 8);
		}

		public void WriteBlock(byte[] block, int offset, int len)
		{
			Array.Copy(block, offset, buf, end, len);
			end += len;
		}

		public void AlignToByte()
		{
			if (bitCount > 0)
			{
				buf[end++] = (byte)bits;
				if (bitCount > 8)
				{
					buf[end++] = (byte)(bits >> 8);
				}
			}
			bits = 0u;
			bitCount = 0;
		}

		public void WriteBits(int b, int count)
		{
			bits |= (uint)(b << bitCount);
			bitCount += count;
			if (bitCount >= 16)
			{
				buf[end++] = (byte)bits;
				buf[end++] = (byte)(bits >> 8);
				bits >>= 16;
				bitCount -= 16;
			}
		}

		public int Flush(byte[] output, int offset, int length)
		{
			if (bitCount >= 8)
			{
				buf[end++] = (byte)bits;
				bits >>= 8;
				bitCount -= 8;
			}
			if (length > end - start)
			{
				length = end - start;
				Array.Copy(buf, start, output, offset, length);
				start = 0;
				end = 0;
			}
			else
			{
				Array.Copy(buf, start, output, offset, length);
				start += length;
			}
			return length;
		}
	}

	internal sealed class ZipStream : MemoryStream
	{
		public void WriteShort(int value)
		{
			WriteByte((byte)((uint)value & 0xFFu));
			WriteByte((byte)((uint)(value >> 8) & 0xFFu));
		}

		public void WriteInt(int value)
		{
			WriteShort(value);
			WriteShort(value >> 16);
		}

		public int ReadShort()
		{
			return ReadByte() | (ReadByte() << 8);
		}

		public int ReadInt()
		{
			return ReadShort() | (ReadShort() << 16);
		}

		public ZipStream()
		{
		}

		public ZipStream(byte[] buffer)
			: base(buffer, writable: false)
		{
		}
	}

	public static string ExceptionMessage;

	private static ICryptoTransform GetAesTransform(byte[] key, byte[] iv, bool decrypt)
	{
		using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
		return decrypt ? aesCryptoServiceProvider.CreateDecryptor(key, iv) : aesCryptoServiceProvider.CreateEncryptor(key, iv);
	}

	public static CompressionAlgorithm GetCompressionAlgorithm(byte[] data)
	{
		if (data != null && data.Length >= 4)
		{
			int num;
			using (ZipStream zipStream = new ZipStream(data))
			{
				num = zipStream.ReadInt();
			}
			if (num == 67324752)
			{
				return CompressionAlgorithm.PKZip;
			}
			int num2 = num >> 24;
			num -= num2 << 24;
			if (num == 8223355)
			{
				return (CompressionAlgorithm)num2;
			}
			return (CompressionAlgorithm)(-2);
		}
		return (CompressionAlgorithm)(-1);
	}

	public static byte[] Unzip(byte[] buffer)
	{
		ZipStream zipStream = new ZipStream(buffer);
		byte[] array = new byte[0];
		int num = zipStream.ReadInt();
		int num2 = num >> 24;
		if (num - (num2 << 24) == 8223355)
		{
			switch (num2)
			{
			case 1:
			{
				int num3 = zipStream.ReadInt();
				array = new byte[num3];
				int num5;
				for (int i = 0; i < num3; i += num5)
				{
					int num4 = zipStream.ReadInt();
					num5 = zipStream.ReadInt();
					byte[] array2 = new byte[num4];
					zipStream.Read(array2, 0, array2.Length);
					new Inflater(array2).Inflate(array, i, num5);
				}
				break;
			}
			default:
				throw new ArgumentOutOfRangeException("version", num2, "Selected compression algorithm is not supported.");
			case 3:
			{
				byte[] key = new byte[16]
				{
					137, 175, 94, 90, 159, 136, 243, 201, 29, 213,
					192, 131, 201, 32, 47, 214
				};
				byte[] iv = new byte[16]
				{
					188, 142, 90, 95, 9, 45, 111, 233, 235, 170,
					9, 85, 193, 102, 37, 209
				};
				using (ICryptoTransform cryptoTransform = GetAesTransform(key, iv, decrypt: true))
				{
					array = Unzip(cryptoTransform.TransformFinalBlock(buffer, 4, buffer.Length - 4));
				}
				break;
			}
			}
			zipStream.Close();
			zipStream = null;
			return array;
		}
		throw new FormatException("Unknown Header");
	}

	public static byte[] Zip(byte[] buffer)
	{
		return Zip(buffer, CompressionAlgorithm.RawZip, null, null);
	}

	public static byte[] ZipAndAes(byte[] buffer, byte[] key, byte[] iv)
	{
		return Zip(buffer, CompressionAlgorithm.RawZipAndAes, key, iv);
	}

	private static byte[] Zip(byte[] buffer, CompressionAlgorithm algorithm, byte[] key, byte[] iv)
	{
		try
		{
			ZipStream zipStream = new ZipStream();
			switch (algorithm)
			{
			case CompressionAlgorithm.RawZip:
			{
				zipStream.WriteInt(25000571);
				zipStream.WriteInt(buffer.Length);
				byte[] array3;
				for (int i = 0; i < buffer.Length; i += array3.Length)
				{
					array3 = new byte[Math.Min(2097151, buffer.Length - i)];
					Buffer.BlockCopy(buffer, i, array3, 0, array3.Length);
					long position = zipStream.Position;
					zipStream.WriteInt(0);
					zipStream.WriteInt(array3.Length);
					Deflater deflater = new Deflater();
					deflater.SetInput(array3);
					while (!deflater.IsNeedingInput)
					{
						byte[] array4 = new byte[512];
						int num = deflater.Deflate(array4);
						if (num <= 0)
						{
							break;
						}
						zipStream.Write(array4, 0, num);
					}
					deflater.Finish();
					while (!deflater.IsFinished)
					{
						byte[] array5 = new byte[512];
						int num2 = deflater.Deflate(array5);
						if (num2 <= 0)
						{
							break;
						}
						zipStream.Write(array5, 0, num2);
					}
					long position2 = zipStream.Position;
					zipStream.Position = position;
					zipStream.WriteInt((int)deflater.TotalOut);
					zipStream.Position = position2;
				}
				break;
			}
			default:
				throw new ArgumentOutOfRangeException("algorithm", algorithm, "Selected compression algorithm is not supported.");
			case CompressionAlgorithm.RawZipAndAes:
			{
				zipStream.WriteInt(58555003);
				byte[] array = Zip(buffer, CompressionAlgorithm.RawZip, null, null);
				using (ICryptoTransform cryptoTransform = GetAesTransform(key, iv, decrypt: false))
				{
					byte[] array2 = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
					zipStream.Write(array2, 0, array2.Length);
				}
				break;
			}
			}
			zipStream.Flush();
			zipStream.Close();
			return zipStream.ToArray();
		}
		catch (Exception ex)
		{
			ExceptionMessage = "ERR 2003: " + ex.Message;
			throw;
		}
	}
}
