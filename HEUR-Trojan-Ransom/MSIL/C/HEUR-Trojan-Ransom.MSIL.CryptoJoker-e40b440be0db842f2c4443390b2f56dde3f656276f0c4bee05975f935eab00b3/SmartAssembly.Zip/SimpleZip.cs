using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace SmartAssembly.Zip;

public static class SimpleZip
{
	internal sealed class Inflater
	{
		private static readonly int[] CPLENS;

		private static readonly int[] CPLEXT;

		private static readonly int[] CPDIST;

		private static readonly int[] CPDEXT;

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

		public Inflater(byte[] P_0)
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}

		private bool DecodeHuffman()
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}

		private bool Decode()
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}

		public int Inflate(byte[] P_0, int P_1, int P_2)
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}
	}

	internal sealed class StreamManipulator
	{
		private byte[] window;

		private int window_start;

		private int window_end;

		private uint buffer;

		private int bits_in_buffer;

		public int PeekBits(int P_0)
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}

		public void DropBits(int P_0)
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}

		[SpecialName]
		public int get_AvailableBits()
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}

		[SpecialName]
		public int get_AvailableBytes()
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}

		public void SkipToByteBoundary()
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}

		[SpecialName]
		public bool get_IsNeedingInput()
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}

		public int CopyBytes(byte[] P_0, int P_1, int P_2)
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}

		public void SetInput(byte[] P_0, int P_1, int P_2)
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}
	}

	internal sealed class OutputWindow
	{
		private byte[] window;

		private int windowEnd;

		private int windowFilled;

		public void Write(int P_0)
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}

		private void SlowRepeat(int P_0, int P_1, int P_2)
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}

		public void Repeat(int P_0, int P_1)
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}

		public int CopyStored(StreamManipulator P_0, int P_1)
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}

		public int GetFreeSpace()
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}

		public int GetAvailable()
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}

		public int CopyOutput(byte[] P_0, int P_1, int P_2)
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}
	}

	internal sealed class InflaterHuffmanTree
	{
		private short[] tree;

		public static readonly InflaterHuffmanTree defLitLenTree;

		public static readonly InflaterHuffmanTree defDistTree;

		static InflaterHuffmanTree()
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}

		public InflaterHuffmanTree(byte[] P_0)
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}

		private void BuildTree(byte[] P_0)
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}

		public int GetSymbol(StreamManipulator P_0)
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}
	}

	internal sealed class InflaterDynHeader
	{
		private static readonly int[] repMin;

		private static readonly int[] repBits;

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

		private static readonly int[] BL_ORDER;

		public bool Decode(StreamManipulator P_0)
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}

		public InflaterHuffmanTree BuildLitLenTree()
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}

		public InflaterHuffmanTree BuildDistTree()
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}
	}

	internal sealed class DeflaterHuffman
	{
		private static readonly int[] BL_ORDER;

		private static readonly byte[] bit4Reverse;

		private static readonly short[] staticLCodes;

		private static readonly byte[] staticLLength;

		private static readonly short[] staticDCodes;

		private static readonly byte[] staticDLength;

		public static short BitReverse(int P_0)
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}

		static DeflaterHuffman()
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}
	}

	internal sealed class ZipStream : MemoryStream
	{
		public int ReadShort()
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}

		public int ReadInt()
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}

		public ZipStream(byte[] P_0)
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}
	}

	private static bool PublicKeysMatch(Assembly P_0, Assembly P_1)
	{
	//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
	}

	private static ICryptoTransform GetAesTransform(byte[] P_0, byte[] P_1, bool P_2)
	{
	//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
	}

	private static ICryptoTransform GetDesTransform(byte[] P_0, byte[] P_1, bool P_2)
	{
	//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
	}

	public static byte[] Unzip(byte[] P_0)
	{
	//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
	}
}
