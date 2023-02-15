using System;
using System.Collections.Generic;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.Zip.Compression;

internal class InflaterDynHeader
{
	private const int LITLEN_MAX = 286;

	private const int DIST_MAX = 30;

	private const int CODELEN_MAX = 316;

	private const int META_MAX = 19;

	private static readonly int[] MetaCodeLengthIndex = new int[19]
	{
		16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
		11, 4, 12, 3, 13, 2, 14, 1, 15
	};

	private readonly StreamManipulator input;

	private readonly IEnumerator<bool> state;

	private readonly IEnumerable<bool> stateMachine;

	private byte[] codeLengths = new byte[316];

	private InflaterHuffmanTree litLenTree;

	private InflaterHuffmanTree distTree;

	private int litLenCodeCount;

	private int distanceCodeCount;

	private int metaCodeCount;

	public InflaterHuffmanTree LiteralLengthTree => litLenTree ?? throw new StreamDecodingException("Header properties were accessed before header had been successfully read");

	public InflaterHuffmanTree DistanceTree => distTree ?? throw new StreamDecodingException("Header properties were accessed before header had been successfully read");

	public bool AttemptRead()
	{
		if (state.MoveNext())
		{
			return state.Current;
		}
		return true;
	}

	public InflaterDynHeader(StreamManipulator input)
	{
		this.input = input;
		stateMachine = CreateStateMachine();
		state = stateMachine.GetEnumerator();
	}

	private IEnumerable<bool> CreateStateMachine()
	{
		while (!input.TryGetBits(5, ref litLenCodeCount, 257))
		{
			yield return false;
		}
		while (!input.TryGetBits(5, ref distanceCodeCount, 1))
		{
			yield return false;
		}
		while (!input.TryGetBits(4, ref metaCodeCount, 4))
		{
			yield return false;
		}
		int dataCodeCount = litLenCodeCount + distanceCodeCount;
		if (litLenCodeCount > 286)
		{
			throw new ValueOutOfRangeException("litLenCodeCount");
		}
		if (distanceCodeCount > 30)
		{
			throw new ValueOutOfRangeException("distanceCodeCount");
		}
		if (metaCodeCount > 19)
		{
			throw new ValueOutOfRangeException("metaCodeCount");
		}
		for (int i = 0; i < metaCodeCount; i++)
		{
			while (!input.TryGetBits(3, ref codeLengths, MetaCodeLengthIndex[i]))
			{
				yield return false;
			}
		}
		InflaterHuffmanTree metaCodeTree = new InflaterHuffmanTree(codeLengths);
		int index = 0;
		while (true)
		{
			if (index < dataCodeCount)
			{
				int symbol;
				while ((symbol = metaCodeTree.GetSymbol(input)) < 0)
				{
					yield return false;
				}
				if (symbol < 16)
				{
					codeLengths[index++] = (byte)symbol;
					continue;
				}
				int i = 0;
				byte codeLength;
				if (symbol == 16)
				{
					if (index == 0)
					{
						break;
					}
					codeLength = codeLengths[index - 1];
					while (!input.TryGetBits(2, ref i, 3))
					{
						yield return false;
					}
				}
				else if (symbol == 17)
				{
					codeLength = 0;
					while (!input.TryGetBits(3, ref i, 3))
					{
						yield return false;
					}
				}
				else
				{
					codeLength = 0;
					while (!input.TryGetBits(7, ref i, 11))
					{
						yield return false;
					}
				}
				if (index + i <= dataCodeCount)
				{
					while (i-- > 0)
					{
						codeLengths[index++] = codeLength;
					}
					continue;
				}
				throw new StreamDecodingException("Cannot repeat code lengths past total number of data code lengths");
			}
			if (codeLengths[256] == 0)
			{
				throw new StreamDecodingException("Inflater dynamic header end-of-block code missing");
			}
			litLenTree = new InflaterHuffmanTree(new ArraySegment<byte>(codeLengths, 0, litLenCodeCount));
			distTree = new InflaterHuffmanTree(new ArraySegment<byte>(codeLengths, litLenCodeCount, distanceCodeCount));
			yield return true;
			yield break;
		}
		throw new StreamDecodingException("Cannot repeat previous code length when no other code length has been read");
	}
}
