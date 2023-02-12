Imports System
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net
Imports System.Runtime.InteropServices
Imports Microsoft.Win32

Namespace Main.Tools
	' Token: 0x02000061 RID: 97
	Public NotInheritable Class Wallpaper
		' Token: 0x060001EA RID: 490 RVA: 0x000023D2 File Offset: 0x000005D2
		Private Sub New()
		End Sub

		' Token: 0x060001EB RID: 491
		Private Declare Auto Function SystemParametersInfo Lib "user32.dll" (uAction As Integer, uParam As Integer, lpvParam As String, fuWinIni As Integer) As Integer

		' Token: 0x060001EC RID: 492 RVA: 0x000119F8 File Offset: 0x0000FBF8
		Public Shared Sub [Set](uri As Uri, style As Wallpaper.Style)
			Try
				Dim stream As Stream = New WebClient().OpenRead(uri.ToString())
				Dim image As Image = Image.FromStream(stream)
				Dim text As String = Path.Combine(Path.GetTempPath(), "wallpaper.bmp")
				image.Save(text, ImageFormat.Bmp)
				Dim registryKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Control Panel\Desktop", True)
				If style = Wallpaper.Style.Stretched Then
					registryKey.SetValue("WallpaperStyle", 2.ToString())
					registryKey.SetValue("TileWallpaper", 0.ToString())
				End If
				If style = Wallpaper.Style.Centered Then
					registryKey.SetValue("WallpaperStyle", 1.ToString())
					registryKey.SetValue("TileWallpaper", 0.ToString())
				End If
				If style = Wallpaper.Style.Tiled Then
					registryKey.SetValue("WallpaperStyle", 1.ToString())
					registryKey.SetValue("TileWallpaper", 1.ToString())
				End If
				If style = Wallpaper.Style.Fill Then
					registryKey.SetValue("WallpaperStyle", 10.ToString())
					registryKey.SetValue("TileWallpaper", 0.ToString())
				End If
				If style = Wallpaper.Style.Fit Then
					registryKey.SetValue("WallpaperStyle", 6.ToString())
					registryKey.SetValue("TileWallpaper", 0.ToString())
				End If
				If style = Wallpaper.Style.Span Then
					registryKey.SetValue("WallpaperStyle", 22.ToString())
					registryKey.SetValue("TileWallpaper", 0.ToString())
				End If
				If style = Wallpaper.Style.Stretch Then
					registryKey.SetValue("WallpaperStyle", 2.ToString())
					registryKey.SetValue("TileWallpaper", 0.ToString())
				End If
				If style = Wallpaper.Style.Tile Then
					registryKey.SetValue("WallpaperStyle", 0.ToString())
					registryKey.SetValue("TileWallpaper", 1.ToString())
				End If
				If style = Wallpaper.Style.Center Then
					registryKey.SetValue("WallpaperStyle", 0.ToString())
					registryKey.SetValue("TileWallpaper", 0.ToString())
				End If
				Wallpaper.SystemParametersInfo(20, 0, text, 3)
			Catch
			End Try
		End Sub

		' Token: 0x040001A1 RID: 417
		Private Const SPI_SETDESKWALLPAPER As Integer = 20

		' Token: 0x040001A2 RID: 418
		Private Const SPIF_UPDATEINIFILE As Integer = 1

		' Token: 0x040001A3 RID: 419
		Private Const SPIF_SENDWININICHANGE As Integer = 2

		' Token: 0x02000062 RID: 98
		Public Enum Style
			' Token: 0x040001A5 RID: 421
			Tiled
			' Token: 0x040001A6 RID: 422
			Centered
			' Token: 0x040001A7 RID: 423
			Stretched
			' Token: 0x040001A8 RID: 424
			Fill
			' Token: 0x040001A9 RID: 425
			Fit
			' Token: 0x040001AA RID: 426
			Span
			' Token: 0x040001AB RID: 427
			Stretch
			' Token: 0x040001AC RID: 428
			Tile
			' Token: 0x040001AD RID: 429
			Center
		End Enum
	End Class
End Namespace
