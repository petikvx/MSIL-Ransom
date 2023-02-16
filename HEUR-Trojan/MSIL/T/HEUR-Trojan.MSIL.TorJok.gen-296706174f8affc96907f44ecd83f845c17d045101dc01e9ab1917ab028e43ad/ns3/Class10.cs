using System;
using System.Security.Cryptography;
using System.Text;
using ns0;

namespace ns3;

internal sealed class Class10
{
	public sealed class Class11 : SymmetricAlgorithm
	{
		internal sealed class Class12 : IDisposable, ICryptoTransform
		{
			internal static readonly byte[] byte_0 = Encoding.ASCII.GetBytes("expand 32-byte k");

			internal static readonly byte[] byte_1 = Encoding.ASCII.GetBytes("expand 16-byte k");

			internal uint[] uint_0;

			internal readonly int int_0;

			bool ICryptoTransform.CanReuseTransform => false;

			bool ICryptoTransform.CanTransformMultipleBlocks => true;

			int ICryptoTransform.InputBlockSize => 64;

			int ICryptoTransform.OutputBlockSize => 64;

			public Class12(byte[] byte_2, byte[] byte_3, int int_1)
			{
				Class27.smethod_35(byte_3, byte_2, this);
				int_0 = int_1;
			}

			unsafe int ICryptoTransform.TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
			{
				void* ptr = stackalloc byte[12];
				if (inputBuffer == null)
				{
					throw new ArgumentNullException("inputBuffer");
				}
				if (inputOffset >= 0 && inputOffset < inputBuffer.Length)
				{
					if (inputCount >= 0 && inputOffset + inputCount <= inputBuffer.Length)
					{
						if (outputBuffer == null)
						{
							throw new ArgumentNullException("outputBuffer");
						}
						if (outputOffset >= 0 && outputOffset + inputCount <= outputBuffer.Length)
						{
							if (uint_0 == null)
							{
								throw new ObjectDisposedException(GetType().Name);
							}
							byte[] array = new byte[64];
							*(int*)ptr = 0;
							while (inputCount > 0)
							{
								Class27.smethod_121(this, array, uint_0);
								uint_0[8] = uint_0[8] + 1;
								if (uint_0[8] == 0)
								{
									uint_0[9] = uint_0[9] + 1;
								}
								*(int*)((byte*)ptr + 4) = Math.Min(64, inputCount);
								*(int*)((byte*)ptr + 8) = 0;
								while (*(int*)((byte*)ptr + 8) < *(int*)((byte*)ptr + 4))
								{
									outputBuffer[outputOffset + *(int*)((byte*)ptr + 8)] = (byte)(inputBuffer[inputOffset + *(int*)((byte*)ptr + 8)] ^ array[*(int*)((byte*)ptr + 8)]);
									(*(int*)((byte*)ptr + 8))++;
								}
								*(int*)ptr += *(int*)((byte*)ptr + 4);
								inputCount -= 64;
								outputOffset += 64;
								inputOffset += 64;
							}
							return *(int*)ptr;
						}
						throw new ArgumentOutOfRangeException("outputOffset");
					}
					throw new ArgumentOutOfRangeException("inputCount");
				}
				throw new ArgumentOutOfRangeException("inputOffset");
			}

			byte[] ICryptoTransform.TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
			{
				if (inputCount < 0)
				{
					throw new ArgumentOutOfRangeException("inputCount");
				}
				byte[] array = new byte[inputCount];
				((ICryptoTransform)this).TransformBlock(inputBuffer, inputOffset, inputCount, array, 0);
				return array;
			}

			void IDisposable.Dispose()
			{
				if (uint_0 != null)
				{
					Array.Clear(uint_0, 0, uint_0.Length);
				}
				uint_0 = null;
			}
		}

		private int int_0;

		byte[] SymmetricAlgorithm.IV
		{
			get
			{
				return base.IV;
			}
			set
			{
				Class27.smethod_0(value, "value");
				IVValue = (byte[])value.Clone();
			}
		}

		public Class11()
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
			int_0 = 20;
		}

		ICryptoTransform SymmetricAlgorithm.CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
		{
			return CreateEncryptor(rgbKey, rgbIV);
		}

		ICryptoTransform SymmetricAlgorithm.CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
		{
			if (rgbKey == null)
			{
				throw new ArgumentNullException("rgbKey");
			}
			if (!ValidKeySize(rgbKey.Length * 8))
			{
				throw new CryptographicException("Invalid key size; it must be 128 or 256 bits.");
			}
			Class27.smethod_0(rgbIV, "rgbIV");
			return new Class12(rgbKey, rgbIV, int_0);
		}

		void SymmetricAlgorithm.GenerateIV()
		{
			IVValue = Class27.smethod_118(8);
		}

		void SymmetricAlgorithm.GenerateKey()
		{
			KeyValue = Class27.smethod_118(KeySize / 8);
		}
	}
}
