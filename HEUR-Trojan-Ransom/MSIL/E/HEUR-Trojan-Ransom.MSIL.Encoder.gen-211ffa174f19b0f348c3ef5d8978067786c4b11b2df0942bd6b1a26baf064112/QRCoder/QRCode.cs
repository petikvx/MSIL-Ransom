using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace QRCoder;

public class QRCode : AbstractQRCode, IDisposable
{
	public QRCode()
	{
	}

	public QRCode(QRCodeData data)
		: base(data)
	{
	}

	public Bitmap GetGraphic(int pixelsPerModule)
	{
		return GetGraphic(pixelsPerModule, Color.Black, Color.White, drawQuietZones: true);
	}

	public Bitmap GetGraphic(int pixelsPerModule, string darkColorHtmlHex, string lightColorHtmlHex, bool drawQuietZones = true)
	{
		return GetGraphic(pixelsPerModule, ColorTranslator.FromHtml(darkColorHtmlHex), ColorTranslator.FromHtml(lightColorHtmlHex), drawQuietZones);
	}

	public Bitmap GetGraphic(int pixelsPerModule, Color darkColor, Color lightColor, bool drawQuietZones = true)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		int num = (base.QrCodeData.ModuleMatrix.Count - ((!drawQuietZones) ? 8 : 0)) * pixelsPerModule;
		int num2 = ((!drawQuietZones) ? (4 * pixelsPerModule) : 0);
		Bitmap val = new Bitmap(num, num);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			SolidBrush val3 = new SolidBrush(lightColor);
			try
			{
				SolidBrush val4 = new SolidBrush(darkColor);
				try
				{
					for (int i = 0; i < num + num2; i += pixelsPerModule)
					{
						for (int j = 0; j < num + num2; j += pixelsPerModule)
						{
							if (base.QrCodeData.ModuleMatrix[(j + pixelsPerModule) / pixelsPerModule - 1][(i + pixelsPerModule) / pixelsPerModule - 1])
							{
								val2.FillRectangle((Brush)(object)val4, new Rectangle(i - num2, j - num2, pixelsPerModule, pixelsPerModule));
							}
							else
							{
								val2.FillRectangle((Brush)(object)val3, new Rectangle(i - num2, j - num2, pixelsPerModule, pixelsPerModule));
							}
						}
					}
					val2.Save();
					return val;
				}
				finally
				{
					((IDisposable)val4)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	public Bitmap GetGraphic(int pixelsPerModule, Color darkColor, Color lightColor, Bitmap icon = null, int iconSizePercent = 15, int iconBorderWidth = 6, bool drawQuietZones = true)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		int num = (base.QrCodeData.ModuleMatrix.Count - ((!drawQuietZones) ? 8 : 0)) * pixelsPerModule;
		int num2 = ((!drawQuietZones) ? (4 * pixelsPerModule) : 0);
		Bitmap val = new Bitmap(num, num, (PixelFormat)2498570);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			SolidBrush val3 = new SolidBrush(lightColor);
			try
			{
				SolidBrush val4 = new SolidBrush(darkColor);
				try
				{
					val2.set_InterpolationMode((InterpolationMode)7);
					val2.set_CompositingQuality((CompositingQuality)2);
					val2.Clear(lightColor);
					bool flag = icon != null && iconSizePercent > 0 && iconSizePercent <= 100;
					GraphicsPath val5 = null;
					float num3 = 0f;
					float num4 = 0f;
					float num5 = 0f;
					float num6 = 0f;
					if (flag)
					{
						num3 = (float)(iconSizePercent * ((Image)val).get_Width()) / 100f;
						num4 = ((!flag) ? 0f : (num3 * (float)((Image)icon).get_Height() / (float)((Image)icon).get_Width()));
						num5 = ((float)((Image)val).get_Width() - num3) / 2f;
						num6 = ((float)((Image)val).get_Height() - num4) / 2f;
						RectangleF rect = new RectangleF(num5 - (float)iconBorderWidth, num6 - (float)iconBorderWidth, num3 + (float)(iconBorderWidth * 2), num4 + (float)(iconBorderWidth * 2));
						val5 = CreateRoundedRectanglePath(rect, iconBorderWidth * 2);
					}
					for (int i = 0; i < num + num2; i += pixelsPerModule)
					{
						for (int j = 0; j < num + num2; j += pixelsPerModule)
						{
							if (base.QrCodeData.ModuleMatrix[(j + pixelsPerModule) / pixelsPerModule - 1][(i + pixelsPerModule) / pixelsPerModule - 1])
							{
								Rectangle rectangle = new Rectangle(i - num2, j - num2, pixelsPerModule, pixelsPerModule);
								if (flag)
								{
									Region val6 = new Region(rectangle);
									val6.Exclude(val5);
									val2.FillRegion((Brush)(object)val4, val6);
								}
								else
								{
									val2.FillRectangle((Brush)(object)val4, rectangle);
								}
							}
							else
							{
								val2.FillRectangle((Brush)(object)val3, new Rectangle(i - num2, j - num2, pixelsPerModule, pixelsPerModule));
							}
						}
					}
					if (flag)
					{
						RectangleF rectangleF = new RectangleF(num5, num6, num3, num4);
						val2.DrawImage((Image)(object)icon, rectangleF, new RectangleF(0f, 0f, ((Image)icon).get_Width(), ((Image)icon).get_Height()), (GraphicsUnit)2);
					}
					val2.Save();
					return val;
				}
				finally
				{
					((IDisposable)val4)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	internal GraphicsPath CreateRoundedRectanglePath(RectangleF rect, int cornerRadius)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		val.AddArc(rect.X, rect.Y, (float)(cornerRadius * 2), (float)(cornerRadius * 2), 180f, 90f);
		val.AddLine(rect.X + (float)cornerRadius, rect.Y, rect.Right - (float)(cornerRadius * 2), rect.Y);
		val.AddArc(rect.X + rect.Width - (float)(cornerRadius * 2), rect.Y, (float)(cornerRadius * 2), (float)(cornerRadius * 2), 270f, 90f);
		val.AddLine(rect.Right, rect.Y + (float)(cornerRadius * 2), rect.Right, rect.Y + rect.Height - (float)(cornerRadius * 2));
		val.AddArc(rect.X + rect.Width - (float)(cornerRadius * 2), rect.Y + rect.Height - (float)(cornerRadius * 2), (float)(cornerRadius * 2), (float)(cornerRadius * 2), 0f, 90f);
		val.AddLine(rect.Right - (float)(cornerRadius * 2), rect.Bottom, rect.X + (float)(cornerRadius * 2), rect.Bottom);
		val.AddArc(rect.X, rect.Bottom - (float)(cornerRadius * 2), (float)(cornerRadius * 2), (float)(cornerRadius * 2), 90f, 90f);
		val.AddLine(rect.X, rect.Bottom - (float)(cornerRadius * 2), rect.X, rect.Y + (float)(cornerRadius * 2));
		val.CloseFigure();
		return val;
	}
}
