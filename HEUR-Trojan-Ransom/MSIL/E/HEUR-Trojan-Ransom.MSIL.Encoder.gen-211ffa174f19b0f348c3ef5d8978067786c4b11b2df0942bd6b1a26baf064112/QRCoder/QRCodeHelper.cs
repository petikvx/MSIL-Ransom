using System.Drawing;

namespace QRCoder;

public static class QRCodeHelper
{
	public static Bitmap GetQRCode(string plainText, int pixelsPerModule, Color darkColor, Color lightColor, QRCodeGenerator.ECCLevel eccLevel, bool forceUtf8 = false, bool utf8BOM = false, QRCodeGenerator.EciMode eciMode = QRCodeGenerator.EciMode.Default, int requestedVersion = -1, Bitmap icon = null, int iconSizePercent = 15, int iconBorderWidth = 6, bool drawQuietZones = true)
	{
		using QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
		using QRCodeData data = qRCodeGenerator.CreateQrCode(plainText, eccLevel, forceUtf8, utf8BOM, eciMode, requestedVersion);
		using QRCode qRCode = new QRCode(data);
		return qRCode.GetGraphic(pixelsPerModule, darkColor, lightColor, icon, iconSizePercent, iconBorderWidth, drawQuietZones);
	}
}
