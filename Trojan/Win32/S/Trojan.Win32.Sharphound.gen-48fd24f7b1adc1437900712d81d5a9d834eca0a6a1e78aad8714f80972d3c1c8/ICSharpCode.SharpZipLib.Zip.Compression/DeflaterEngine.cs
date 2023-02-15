using System;
using ICSharpCode.SharpZipLib.Checksum;

namespace ICSharpCode.SharpZipLib.Zip.Compression;

public class DeflaterEngine
{
	private const int TooFar = 4096;

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

	private DeflateStrategy strategy;

	private int max_chain;

	private int max_lazy;

	private int niceLength;

	private int goodLength;

	private int compressionFunction;

	private byte[] inputBuf;

	private long totalIn;

	private int inputOff;

	private int inputEnd;

	private DeflaterPending pending;

	private DeflaterHuffman huffman;

	private Adler32 adler;

	public int Adler
	{
		get
		{
			if (adler == null)
			{
				return 0;
			}
			return (int)adler.Value;
		}
	}

	public long TotalIn => totalIn;

	public DeflateStrategy Strategy
	{
		get
		{
			return strategy;
		}
		set
		{
			strategy = value;
		}
	}

	public DeflaterEngine(DeflaterPending pending)
		: this(pending, noAdlerCalculation: false)
	{
	}

	public DeflaterEngine(DeflaterPending pending, bool noAdlerCalculation)
	{
		this.pending = pending;
		huffman = new DeflaterHuffman(pending);
		if (!noAdlerCalculation)
		{
			adler = new Adler32();
		}
		window = new byte[65536];
		head = new short[32768];
		prev = new short[32768];
		strstart = 1;
		blockStart = 1;
	}

	public bool Deflate(bool flush, bool finish)
	{
		bool flag;
		do
		{
			FillWindow();
			bool flush2 = flush && inputOff == inputEnd;
			flag = compressionFunction switch
			{
				0 => DeflateStored(flush2, finish), 
				1 => DeflateFast(flush2, finish), 
				2 => DeflateSlow(flush2, finish), 
				_ => throw new InvalidOperationException("unknown compressionFunction"), 
			};
		}
		while (pending.IsFlushed && flag);
		return flag;
	}

	public void SetInput(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (inputOff < inputEnd)
		{
			throw new InvalidOperationException("Old input was not completely processed");
		}
		int num = offset + count;
		if (offset > num || num > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		inputBuf = buffer;
		inputOff = offset;
		inputEnd = num;
	}

	public bool NeedsInput()
	{
		return inputEnd == inputOff;
	}

	public void SetDictionary(byte[] buffer, int offset, int length)
	{
		adler?.Update(new ArraySegment<byte>(buffer, offset, length));
		if (length >= 3)
		{
			if (length > 32506)
			{
				offset += length - 32506;
				length = 32506;
			}
			Array.Copy(buffer, offset, window, strstart, length);
			UpdateHash();
			length--;
			while (--length > 0)
			{
				InsertString();
				strstart++;
			}
			strstart += 2;
			blockStart = strstart;
		}
	}

	public void Reset()
	{
		huffman.Reset();
		adler?.Reset();
		strstart = 1;
		blockStart = 1;
		lookahead = 0;
		totalIn = 0L;
		prevAvailable = false;
		matchLen = 2;
		for (int i = 0; i < 32768; i++)
		{
			head[i] = 0;
		}
		for (int j = 0; j < 32768; j++)
		{
			prev[j] = 0;
		}
	}

	public void ResetAdler()
	{
		adler?.Reset();
	}

	public void SetLevel(int level)
	{
		if (level >= 0 && level <= 9)
		{
			goodLength = DeflaterConstants.GOOD_LENGTH[level];
			max_lazy = DeflaterConstants.MAX_LAZY[level];
			niceLength = DeflaterConstants.NICE_LENGTH[level];
			max_chain = DeflaterConstants.MAX_CHAIN[level];
			if (DeflaterConstants.COMPR_FUNC[level] == compressionFunction)
			{
				return;
			}
			switch (compressionFunction)
			{
			case 0:
				if (strstart > blockStart)
				{
					huffman.FlushStoredBlock(window, blockStart, strstart - blockStart, lastBlock: false);
					blockStart = strstart;
				}
				UpdateHash();
				break;
			case 1:
				if (strstart > blockStart)
				{
					huffman.FlushBlock(window, blockStart, strstart - blockStart, lastBlock: false);
					blockStart = strstart;
				}
				break;
			case 2:
				if (prevAvailable)
				{
					huffman.TallyLit(window[strstart - 1] & 0xFF);
				}
				if (strstart > blockStart)
				{
					huffman.FlushBlock(window, blockStart, strstart - blockStart, lastBlock: false);
					blockStart = strstart;
				}
				prevAvailable = false;
				matchLen = 2;
				break;
			}
			compressionFunction = DeflaterConstants.COMPR_FUNC[level];
			return;
		}
		throw new ArgumentOutOfRangeException("level");
	}

	public void FillWindow()
	{
		if (strstart >= 65274)
		{
			SlideWindow();
		}
		if (lookahead < 262 && inputOff < inputEnd)
		{
			int num = 65536 - lookahead - strstart;
			if (num > inputEnd - inputOff)
			{
				num = inputEnd - inputOff;
			}
			Array.Copy(inputBuf, inputOff, window, strstart + lookahead, num);
			adler?.Update(new ArraySegment<byte>(inputBuf, inputOff, num));
			inputOff += num;
			totalIn += num;
			lookahead += num;
		}
		if (lookahead >= 3)
		{
			UpdateHash();
		}
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

	private bool FindLongestMatch(int curMatch)
	{
		int num = strstart;
		int num2 = num + Math.Min(258, lookahead) - 1;
		int num3 = Math.Max(num - 32506, 0);
		byte[] array = window;
		short[] array2 = prev;
		int num4 = max_chain;
		int num5 = Math.Min(niceLength, lookahead);
		matchLen = Math.Max(matchLen, 2);
		if (num + matchLen > num2)
		{
			return false;
		}
		byte b = array[num + matchLen - 1];
		byte b2 = array[num + matchLen];
		if (matchLen >= goodLength)
		{
			num4 >>= 2;
		}
		do
		{
			int num6 = curMatch;
			num = strstart;
			if (array[num6 + matchLen] != b2 || array[num6 + matchLen - 1] != b || array[num6] != array[num] || array[++num6] != array[++num])
			{
				continue;
			}
			switch ((num2 - num) % 8)
			{
			case 1:
				if (array[++num] != array[++num6])
				{
				}
				break;
			case 2:
				if (array[++num] == array[++num6] && array[++num] != array[++num6])
				{
				}
				break;
			case 3:
				if (array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] != array[++num6])
				{
				}
				break;
			case 4:
				if (array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] != array[++num6])
				{
				}
				break;
			case 5:
				if (array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] != array[++num6])
				{
				}
				break;
			case 6:
				if (array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] != array[++num6])
				{
				}
				break;
			case 7:
				if (array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] == array[++num6])
				{
					_ = array[++num];
					_ = array[++num6];
				}
				break;
			}
			if (array[num] == array[num6])
			{
				do
				{
					if (num == num2)
					{
						num++;
						num6++;
						break;
					}
				}
				while (array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] == array[++num6]);
			}
			if (num - strstart > matchLen)
			{
				matchStart = curMatch;
				matchLen = num - strstart;
				if (matchLen >= num5)
				{
					break;
				}
				b = array[num - 1];
				b2 = array[num];
			}
		}
		while ((curMatch = array2[curMatch & 0x7FFF] & 0xFFFF) > num3 && --num4 != 0);
		return matchLen >= 3;
	}

	private bool DeflateStored(bool flush, bool finish)
	{
		if (!flush && lookahead == 0)
		{
			return false;
		}
		strstart += lookahead;
		lookahead = 0;
		int num = strstart - blockStart;
		if (num >= DeflaterConstants.MAX_BLOCK_SIZE || (blockStart < 32768 && num >= 32506) || flush)
		{
			bool flag = finish;
			if (num > DeflaterConstants.MAX_BLOCK_SIZE)
			{
				num = DeflaterConstants.MAX_BLOCK_SIZE;
				flag = false;
			}
			huffman.FlushStoredBlock(window, blockStart, num, flag);
			blockStart += num;
			if (!flag)
			{
				return num != 0;
			}
			return false;
		}
		return true;
	}

	private bool DeflateFast(bool flush, bool finish)
	{
		if (lookahead < 262 && !flush)
		{
			return false;
		}
		do
		{
			IL_0173:
			if (lookahead >= 262 || flush)
			{
				if (lookahead != 0)
				{
					if (strstart > 65274)
					{
						SlideWindow();
					}
					int num;
					if (lookahead >= 3 && (num = InsertString()) != 0 && strategy != DeflateStrategy.HuffmanOnly && strstart - num <= 32506 && FindLongestMatch(num))
					{
						bool flag = huffman.TallyDist(strstart - matchStart, matchLen);
						lookahead -= matchLen;
						if (matchLen <= max_lazy && lookahead >= 3)
						{
							while (--matchLen > 0)
							{
								strstart++;
								InsertString();
							}
							strstart++;
						}
						else
						{
							strstart += matchLen;
							if (lookahead >= 2)
							{
								UpdateHash();
							}
						}
						matchLen = 2;
						if (!flag)
						{
							goto IL_0173;
						}
					}
					else
					{
						huffman.TallyLit(window[strstart] & 0xFF);
						strstart++;
						lookahead--;
					}
					continue;
				}
				huffman.FlushBlock(window, blockStart, strstart - blockStart, finish);
				blockStart = strstart;
				return false;
			}
			return true;
		}
		while (!huffman.IsFull());
		bool flag2 = finish && lookahead == 0;
		huffman.FlushBlock(window, blockStart, strstart - blockStart, flag2);
		blockStart = strstart;
		return !flag2;
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
						if (strategy != DeflateStrategy.HuffmanOnly && num3 != 0 && strstart - num3 <= 32506 && FindLongestMatch(num3) && matchLen <= 5 && (strategy == DeflateStrategy.Filtered || (matchLen == 3 && strstart - matchStart > 4096)))
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
}
