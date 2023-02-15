using System;
using System.Security.Cryptography;

namespace ICSharpCode.SharpZipLib.Encryption;

internal class ZipAESTransform : IDisposable, ICryptoTransform
{
	private class IncrementalHash : HMACSHA1
	{
		private bool _finalised;

		public IncrementalHash(byte[] key)
			: base(key)
		{
		}

		public static IncrementalHash CreateHMAC(string n, byte[] key)
		{
			return new IncrementalHash(key);
		}

		public void AppendData(byte[] buffer, int offset, int count)
		{
			TransformBlock(buffer, offset, count, buffer, offset);
		}

		public byte[] GetHashAndReset()
		{
			if (!_finalised)
			{
				byte[] inputBuffer = new byte[0];
				TransformFinalBlock(inputBuffer, 0, 0);
				_finalised = true;
			}
			return Hash;
		}
	}

	private static class HashAlgorithmName
	{
		public static string SHA1;
	}

	private const int PWD_VER_LENGTH = 2;

	private const int KEY_ROUNDS = 1000;

	private const int ENCRYPT_BLOCK = 16;

	private int _blockSize;

	private readonly ICryptoTransform _encryptor;

	private readonly byte[] _counterNonce;

	private byte[] _encryptBuffer;

	private int _encrPos;

	private byte[] _pwdVerifier;

	private IncrementalHash _hmacsha1;

	private byte[] _authCode;

	private bool _writeMode;

	public byte[] PwdVerifier => _pwdVerifier;

	public int InputBlockSize => _blockSize;

	public int OutputBlockSize => _blockSize;

	public bool CanTransformMultipleBlocks => true;

	public bool CanReuseTransform => true;

	public ZipAESTransform(string key, byte[] saltBytes, int blockSize, bool writeMode)
	{
		if (blockSize != 16 && blockSize != 32)
		{
			throw new Exception("Invalid blocksize " + blockSize + ". Must be 16 or 32.");
		}
		if (saltBytes.Length != blockSize / 2)
		{
			throw new Exception("Invalid salt len. Must be " + blockSize / 2 + " for blocksize " + blockSize);
		}
		_blockSize = blockSize;
		_encryptBuffer = new byte[_blockSize];
		_encrPos = 16;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(key, saltBytes, 1000);
		Aes aes = Aes.Create();
		aes.Mode = CipherMode.ECB;
		_counterNonce = new byte[_blockSize];
		byte[] bytes = rfc2898DeriveBytes.GetBytes(_blockSize);
		byte[] bytes2 = rfc2898DeriveBytes.GetBytes(_blockSize);
		_encryptor = aes.CreateEncryptor(bytes, new byte[16]);
		_pwdVerifier = rfc2898DeriveBytes.GetBytes(2);
		_hmacsha1 = IncrementalHash.CreateHMAC(HashAlgorithmName.SHA1, bytes2);
		_writeMode = writeMode;
	}

	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
	{
		if (!_writeMode)
		{
			_hmacsha1.AppendData(inputBuffer, inputOffset, inputCount);
		}
		for (int i = 0; i < inputCount; i++)
		{
			if (_encrPos == 16)
			{
				int num = 0;
				while (++_counterNonce[num] == 0)
				{
					num++;
				}
				_encryptor.TransformBlock(_counterNonce, 0, _blockSize, _encryptBuffer, 0);
				_encrPos = 0;
			}
			outputBuffer[i + outputOffset] = (byte)(inputBuffer[i + inputOffset] ^ _encryptBuffer[_encrPos++]);
		}
		if (_writeMode)
		{
			_hmacsha1.AppendData(outputBuffer, outputOffset, inputCount);
		}
		return inputCount;
	}

	public byte[] GetAuthCode()
	{
		if (_authCode == null)
		{
			_authCode = _hmacsha1.GetHashAndReset();
		}
		return _authCode;
	}

	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
	{
		if (inputCount > 0)
		{
			throw new NotImplementedException("TransformFinalBlock is not implemented and inputCount is greater than 0");
		}
		return new byte[0];
	}

	public void Dispose()
	{
		_encryptor.Dispose();
	}
}
