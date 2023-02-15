using System.Collections.Generic;
using System.Text;

namespace ICSharpCode.SharpZipLib.Tar;

public class TarExtendedHeaderReader
{
	private const byte LENGTH = 0;

	private const byte KEY = 1;

	private const byte VALUE = 2;

	private const byte END = 3;

	private readonly Dictionary<string, string> headers = new Dictionary<string, string>();

	private string[] headerParts = new string[3];

	private int bbIndex;

	private byte[] byteBuffer;

	private char[] charBuffer;

	private readonly StringBuilder sb = new StringBuilder();

	private readonly Decoder decoder = Encoding.UTF8.GetDecoder();

	private int state;

	private static readonly byte[] StateNext = new byte[3] { 32, 61, 10 };

	public Dictionary<string, string> Headers => headers;

	public TarExtendedHeaderReader()
	{
		ResetBuffers();
	}

	public void Read(byte[] buffer, int length)
	{
		for (int i = 0; i < length; i++)
		{
			byte b = buffer[i];
			if (b == StateNext[state])
			{
				Flush();
				headerParts[state] = sb.ToString();
				sb.Clear();
				if (++state == 3)
				{
					headers.Add(headerParts[1], headerParts[2]);
					headerParts = new string[3];
					state = 0;
				}
			}
			else
			{
				byteBuffer[bbIndex++] = b;
				if (bbIndex == 4)
				{
					Flush();
				}
			}
		}
	}

	private void Flush()
	{
		decoder.Convert(byteBuffer, 0, bbIndex, charBuffer, 0, 4, flush: false, out var _, out var charsUsed, out var _);
		sb.Append(charBuffer, 0, charsUsed);
		ResetBuffers();
	}

	private void ResetBuffers()
	{
		charBuffer = new char[4];
		byteBuffer = new byte[4];
		bbIndex = 0;
	}
}
