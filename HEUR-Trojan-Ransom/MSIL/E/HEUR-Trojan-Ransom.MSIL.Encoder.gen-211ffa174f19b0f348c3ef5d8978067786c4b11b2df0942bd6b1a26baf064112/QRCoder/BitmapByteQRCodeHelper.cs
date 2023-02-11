namespace QRCoder;

public static class BitmapByteQRCodeHelper
{
	public static byte[] GetQRCode(string plainText, int pixelsPerModule, string darkColorHtmlHex, string lightColorHtmlHex, QRCodeGenerator.ECCLevel eccLevel, bool forceUtf8 = false, bool utf8BOM = false, QRCodeGenerator.EciMode eciMode = QRCodeGenerator.EciMode.Default, int requestedVersion = -1)
	{
		using QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
		using QRCodeData data = qRCodeGenerator.CreateQrCode(plainText, eccLevel, forceUtf8, utf8BOM, eciMode, requestedVersion);
		using BitmapByteQRCode bitmapByteQRCode = new BitmapByteQRCode(data);
		return bitmapByteQRCode.GetGraphic(pixelsPerModule, darkColorHtmlHex, lightColorHtmlHex);
	}

	public static byte[] GetQRCode(string txt, QRCodeGenerator.ECCLevel eccLevel, int size)
	{
		using QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
		using QRCodeData data = qRCodeGenerator.CreateQrCode(txt, eccLevel);
		using BitmapByteQRCode bitmapByteQRCode = new BitmapByteQRCode(data);
		return bitmapByteQRCode.GetGraphic(size);
	}
}
