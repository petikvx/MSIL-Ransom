using System.Text;

namespace Anubis;

public static class AesGcm256
{
	public static string Decrypt(byte[] encryptedBytes, byte[] key, byte[] iv)
	{
		string empty = string.Empty;
		try
		{
			GcmBlockCipher gcmBlockCipher = new GcmBlockCipher(new AesFastEngine());
			gcmBlockCipher.Init(forEncryption: false, new AeadParameters(new KeyParameter(key), 128, iv, null));
			byte[] array = new byte[gcmBlockCipher.GetOutputSize(encryptedBytes.Length)];
			int outOff = gcmBlockCipher.ProcessBytes(encryptedBytes, 0, encryptedBytes.Length, array, 0);
			gcmBlockCipher.DoFinal(array, outOff);
			return Encoding.UTF8.GetString(array).TrimEnd("\r\n\0".ToCharArray());
		}
		catch
		{
			return empty;
		}
	}
}
