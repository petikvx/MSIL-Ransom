using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace UiJYiNvGWeAgvdh;

public sealed class qYGhbgYMkFdbXtd : SymmetricAlgorithm
{
	private sealed class xdafETfIWmGuC : ICryptoTransform, IDisposable
	{
		private static readonly byte[] rzATGGVVLfoyu;

		private static readonly byte[] IBIuaMAlZfG;

		private readonly int HpftlwpRybE;

		private uint[] YhQcgCgzjyShUe;

		[NonSerialized]
		internal static GetString getString_0;

		public int InputBlockSize => 64;

		public int OutputBlockSize => 64;

		public bool CanTransformMultipleBlocks => true;

		public bool CanReuseTransform => false;

		public xdafETfIWmGuC(byte[] byte_0, byte[] byte_1, int int_0)
		{
			Initialize(byte_0, byte_1);
			HpftlwpRybE = int_0;
		}

		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			if (inputBuffer == null)
			{
				throw new ArgumentNullException(getString_0(107399510));
			}
			if (inputOffset >= 0 && inputOffset < inputBuffer.Length)
			{
				if (inputCount >= 0 && inputOffset + inputCount <= inputBuffer.Length)
				{
					if (outputBuffer == null)
					{
						throw new ArgumentNullException(getString_0(107399427));
					}
					if (outputOffset >= 0 && outputOffset + inputCount <= outputBuffer.Length)
					{
						if (YhQcgCgzjyShUe == null)
						{
							throw new ObjectDisposedException(GetType().Name);
						}
						byte[] array = new byte[64];
						int num = 0;
						while (inputCount > 0)
						{
							Hash(array, YhQcgCgzjyShUe);
							YhQcgCgzjyShUe[8] = AddOne(YhQcgCgzjyShUe[8]);
							if (YhQcgCgzjyShUe[8] == 0)
							{
								YhQcgCgzjyShUe[9] = AddOne(YhQcgCgzjyShUe[9]);
							}
							int num2 = Math.Min(64, inputCount);
							for (int i = 0; i < num2; i++)
							{
								outputBuffer[outputOffset + i] = (byte)(inputBuffer[inputOffset + i] ^ array[i]);
							}
							num += num2;
							inputCount -= 64;
							outputOffset += 64;
							inputOffset += 64;
						}
						return num;
					}
					throw new ArgumentOutOfRangeException(getString_0(107399442));
				}
				throw new ArgumentOutOfRangeException(getString_0(107399476));
			}
			throw new ArgumentOutOfRangeException(getString_0(107399461));
		}

		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			if (inputCount < 0)
			{
				throw new ArgumentOutOfRangeException(getString_0(107399476));
			}
			byte[] array = new byte[inputCount];
			TransformBlock(inputBuffer, inputOffset, inputCount, array, 0);
			return array;
		}

		public void Dispose()
		{
			if (YhQcgCgzjyShUe != null)
			{
				Array.Clear(YhQcgCgzjyShUe, 0, YhQcgCgzjyShUe.Length);
			}
			YhQcgCgzjyShUe = null;
		}

		private static uint Rotate(uint uint_0, int int_0)
		{
			return (uint_0 << int_0) | (uint_0 >> 32 - int_0);
		}

		private static uint Add(uint uint_0, uint uint_1)
		{
			return uint_0 + uint_1;
		}

		private static uint AddOne(uint uint_0)
		{
			return uint_0 + 1;
		}

		private void Hash(byte[] byte_0, uint[] uint_0)
		{
			uint[] array = (uint[])uint_0.Clone();
			for (int num = HpftlwpRybE; num > 0; num -= 2)
			{
				array[4] ^= Rotate(Add(array[0], array[12]), 7);
				array[8] ^= Rotate(Add(array[4], array[0]), 9);
				array[12] ^= Rotate(Add(array[8], array[4]), 13);
				array[0] ^= Rotate(Add(array[12], array[8]), 18);
				array[9] ^= Rotate(Add(array[5], array[1]), 7);
				array[13] ^= Rotate(Add(array[9], array[5]), 9);
				array[1] ^= Rotate(Add(array[13], array[9]), 13);
				array[5] ^= Rotate(Add(array[1], array[13]), 18);
				array[14] ^= Rotate(Add(array[10], array[6]), 7);
				array[2] ^= Rotate(Add(array[14], array[10]), 9);
				array[6] ^= Rotate(Add(array[2], array[14]), 13);
				array[10] ^= Rotate(Add(array[6], array[2]), 18);
				array[3] ^= Rotate(Add(array[15], array[11]), 7);
				array[7] ^= Rotate(Add(array[3], array[15]), 9);
				array[11] ^= Rotate(Add(array[7], array[3]), 13);
				array[15] ^= Rotate(Add(array[11], array[7]), 18);
				array[1] ^= Rotate(Add(array[0], array[3]), 7);
				array[2] ^= Rotate(Add(array[1], array[0]), 9);
				array[3] ^= Rotate(Add(array[2], array[1]), 13);
				array[0] ^= Rotate(Add(array[3], array[2]), 18);
				array[6] ^= Rotate(Add(array[5], array[4]), 7);
				array[7] ^= Rotate(Add(array[6], array[5]), 9);
				array[4] ^= Rotate(Add(array[7], array[6]), 13);
				array[5] ^= Rotate(Add(array[4], array[7]), 18);
				array[11] ^= Rotate(Add(array[10], array[9]), 7);
				array[8] ^= Rotate(Add(array[11], array[10]), 9);
				array[9] ^= Rotate(Add(array[8], array[11]), 13);
				array[10] ^= Rotate(Add(array[9], array[8]), 18);
				array[12] ^= Rotate(Add(array[15], array[14]), 7);
				array[13] ^= Rotate(Add(array[12], array[15]), 9);
				array[14] ^= Rotate(Add(array[13], array[12]), 13);
				array[15] ^= Rotate(Add(array[14], array[13]), 18);
			}
			for (int i = 0; i < 16; i++)
			{
				ToBytes(Add(array[i], uint_0[i]), byte_0, 4 * i);
			}
		}

		private void Initialize(byte[] byte_0, byte[] byte_1)
		{
			YhQcgCgzjyShUe = new uint[16];
			YhQcgCgzjyShUe[1] = ToUInt32(byte_0, 0);
			YhQcgCgzjyShUe[2] = ToUInt32(byte_0, 4);
			YhQcgCgzjyShUe[3] = ToUInt32(byte_0, 8);
			YhQcgCgzjyShUe[4] = ToUInt32(byte_0, 12);
			byte[] byte_2 = ((byte_0.Length == 32) ? rzATGGVVLfoyu : IBIuaMAlZfG);
			int num = byte_0.Length - 16;
			YhQcgCgzjyShUe[11] = ToUInt32(byte_0, num);
			YhQcgCgzjyShUe[12] = ToUInt32(byte_0, num + 4);
			YhQcgCgzjyShUe[13] = ToUInt32(byte_0, num + 8);
			YhQcgCgzjyShUe[14] = ToUInt32(byte_0, num + 12);
			YhQcgCgzjyShUe[0] = ToUInt32(byte_2, 0);
			YhQcgCgzjyShUe[5] = ToUInt32(byte_2, 4);
			YhQcgCgzjyShUe[10] = ToUInt32(byte_2, 8);
			YhQcgCgzjyShUe[15] = ToUInt32(byte_2, 12);
			YhQcgCgzjyShUe[6] = ToUInt32(byte_1, 0);
			YhQcgCgzjyShUe[7] = ToUInt32(byte_1, 4);
			YhQcgCgzjyShUe[8] = 0u;
			YhQcgCgzjyShUe[9] = 0u;
		}

		private static uint ToUInt32(byte[] byte_0, int int_0)
		{
			return (uint)(byte_0[int_0] | (byte_0[int_0 + 1] << 8) | (byte_0[int_0 + 2] << 16) | (byte_0[int_0 + 3] << 24));
		}

		private static void ToBytes(uint uint_0, byte[] byte_0, int int_0)
		{
			byte_0[int_0] = (byte)uint_0;
			byte_0[int_0 + 1] = (byte)(uint_0 >> 8);
			byte_0[int_0 + 2] = (byte)(uint_0 >> 16);
			byte_0[int_0 + 3] = (byte)(uint_0 >> 24);
		}

		static xdafETfIWmGuC()
		{
			Strings.CreateGetStringDelegate(typeof(xdafETfIWmGuC));
			rzATGGVVLfoyu = Encoding.ASCII.GetBytes(getString_0(107399393));
			IBIuaMAlZfG = Encoding.ASCII.GetBytes(getString_0(107399880));
		}
	}

	private int HpftlwpRybE;

	[NonSerialized]
	internal static GetString getString_0;

	public override byte[] IV
	{
		get
		{
			return base.IV;
		}
		set
		{
			mCUnlqDIkTLo(value, getString_0(107399610));
			IVValue = (byte[])value.Clone();
		}
	}

	public static byte[] ytKbEkOaFFyA(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] array = null;
		using qYGhbgYMkFdbXtd qYGhbgYMkFdbXtd2 = new qYGhbgYMkFdbXtd();
		using MemoryStream memoryStream = new MemoryStream();
		qYGhbgYMkFdbXtd2.Key = byte_1;
		qYGhbgYMkFdbXtd2.IV = byte_2;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, qYGhbgYMkFdbXtd2.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.FlushFinalBlock();
		}
		return memoryStream.ToArray();
	}

	public qYGhbgYMkFdbXtd()
	{
		LegalBlockSizesValue = new KeySizes[1]
		{
			new KeySizes(512, 512, 0)
		};
		LegalKeySizesValue = new KeySizes[1]
		{
			new KeySizes(128, 256, 128)
		};
		BlockSizeValue = 512;
		KeySizeValue = 256;
		HpftlwpRybE = 20;
	}

	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return CreateEncryptor(rgbKey, rgbIV);
	}

	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
	{
		if (rgbKey == null)
		{
			throw new ArgumentNullException(getString_0(107399633));
		}
		if (!ValidKeySize(rgbKey.Length * 8))
		{
			throw new CryptographicException(getString_0(107399624));
		}
		mCUnlqDIkTLo(rgbIV, getString_0(107399563));
		return new xdafETfIWmGuC(rgbKey, rgbIV, HpftlwpRybE);
	}

	public override void GenerateIV()
	{
		IVValue = RrQluMNcpMKfDA(8);
	}

	public override void GenerateKey()
	{
		KeyValue = RrQluMNcpMKfDA(KeySize / 8);
	}

	private static void mCUnlqDIkTLo(byte[] byte_0, string string_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException(string_0);
		}
		if (byte_0.Length != 8)
		{
			throw new CryptographicException(getString_0(107399522));
		}
	}

	private static byte[] RrQluMNcpMKfDA(int int_0)
	{
		byte[] array = new byte[int_0];
		using RandomNumberGenerator randomNumberGenerator = new RNGCryptoServiceProvider();
		randomNumberGenerator.GetBytes(array);
		return array;
	}

	static qYGhbgYMkFdbXtd()
	{
		Strings.CreateGetStringDelegate(typeof(qYGhbgYMkFdbXtd));
	}
}
