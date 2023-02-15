using System;
using System.IO;
using System.Security.Cryptography;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Encryption;

internal class ZipAESStream : CryptoStream
{
	private const int AUTH_CODE_LENGTH = 10;

	private const int CRYPTO_BLOCK_SIZE = 16;

	private const int BLOCK_AND_AUTH = 26;

	private Stream _stream;

	private ZipAESTransform _transform;

	private byte[] _slideBuffer;

	private int _slideBufStartPos;

	private int _slideBufFreePos;

	private byte[] _transformBuffer;

	private int _transformBufferFreePos;

	private int _transformBufferStartPos;

	private bool HasBufferedData
	{
		get
		{
			if (_transformBuffer != null)
			{
				return _transformBufferStartPos < _transformBufferFreePos;
			}
			return false;
		}
	}

	public ZipAESStream(Stream stream, ZipAESTransform transform, CryptoStreamMode mode)
		: base(stream, transform, mode)
	{
		_stream = stream;
		_transform = transform;
		_slideBuffer = new byte[1024];
		if (mode != 0)
		{
			throw new Exception("ZipAESStream only for read");
		}
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (count == 0)
		{
			return 0;
		}
		int num = 0;
		if (HasBufferedData)
		{
			num = ReadBufferedData(buffer, offset, count);
			if (num == count)
			{
				return num;
			}
			offset += num;
			count -= num;
		}
		if (_slideBuffer != null)
		{
			num += ReadAndTransform(buffer, offset, count);
		}
		return num;
	}

	private int ReadAndTransform(byte[] buffer, int offset, int count)
	{
		int num = 0;
		while (num < count)
		{
			int count2 = count - num;
			int num2 = _slideBufFreePos - _slideBufStartPos;
			int num3 = 26 - num2;
			if (_slideBuffer.Length - _slideBufFreePos < num3)
			{
				int num4 = 0;
				int num5 = _slideBufStartPos;
				while (num5 < _slideBufFreePos)
				{
					_slideBuffer[num4] = _slideBuffer[num5];
					num5++;
					num4++;
				}
				_slideBufFreePos -= _slideBufStartPos;
				_slideBufStartPos = 0;
			}
			int num6 = StreamUtils.ReadRequestedBytes(_stream, _slideBuffer, _slideBufFreePos, num3);
			_slideBufFreePos += num6;
			num2 = _slideBufFreePos - _slideBufStartPos;
			if (num2 >= 26)
			{
				int num7 = TransformAndBufferBlock(buffer, offset, count2, 16);
				num += num7;
				offset += num7;
				continue;
			}
			if (num2 > 10)
			{
				int blockSize = num2 - 10;
				num += TransformAndBufferBlock(buffer, offset, count2, blockSize);
			}
			else if (num2 < 10)
			{
				throw new Exception("Internal error missed auth code");
			}
			byte[] authCode = _transform.GetAuthCode();
			for (int i = 0; i < 10; i++)
			{
				if (authCode[i] != _slideBuffer[_slideBufStartPos + i])
				{
					throw new Exception("AES Authentication Code does not match. This is a super-CRC check on the data in the file after compression and encryption. \r\nThe file may be damaged.");
				}
			}
			_slideBuffer = null;
			break;
		}
		return num;
	}

	private int ReadBufferedData(byte[] buffer, int offset, int count)
	{
		int num = Math.Min(count, _transformBufferFreePos - _transformBufferStartPos);
		Array.Copy(_transformBuffer, _transformBufferStartPos, buffer, offset, count);
		_transformBufferStartPos += num;
		return num;
	}

	private int TransformAndBufferBlock(byte[] buffer, int offset, int count, int blockSize)
	{
		bool num = blockSize > count;
		if (num && _transformBuffer == null)
		{
			_transformBuffer = new byte[16];
			if (!num)
			{
				goto IL_0025;
			}
		}
		else if (!num)
		{
			goto IL_0025;
		}
		byte[] array = _transformBuffer;
		goto IL_002e;
		IL_0025:
		array = buffer;
		goto IL_002e;
		IL_002e:
		byte[] outputBuffer = array;
		int outputOffset = ((!num) ? offset : 0);
		_transform.TransformBlock(_slideBuffer, _slideBufStartPos, blockSize, outputBuffer, outputOffset);
		_slideBufStartPos += blockSize;
		if (!num)
		{
			return blockSize;
		}
		Array.Copy(_transformBuffer, 0, buffer, offset, count);
		_transformBufferStartPos = count;
		_transformBufferFreePos = blockSize;
		return count;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new NotImplementedException();
	}
}
