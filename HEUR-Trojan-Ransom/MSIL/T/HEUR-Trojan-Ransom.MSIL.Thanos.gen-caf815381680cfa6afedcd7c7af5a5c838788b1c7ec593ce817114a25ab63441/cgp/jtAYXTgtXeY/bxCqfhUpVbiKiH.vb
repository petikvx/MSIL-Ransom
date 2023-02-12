Imports System
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Threading
Imports SmartAssembly.Delegates
Imports SmartAssembly.HouseOfCards

Namespace jtAYXTgtXeY
	' Token: 0x02000011 RID: 17
	Public NotInheritable Class bxCqfhUpVbiKiH
		' Token: 0x06000053 RID: 83 RVA: 0x00002663 File Offset: 0x00000863
		Private Sub New()
		End Sub

		' Token: 0x06000054 RID: 84
		Private Declare Auto Function SystemParametersInfo Lib "user32.dll" (int_0 As Integer, int_1 As Integer, string_0 As String, int_2 As Integer) As Integer

		' Token: 0x06000055 RID: 85 RVA: 0x0000C504 File Offset: 0x0000A704
		Public Shared Sub kcLLRkHjiFuq(uri_0 As Uri)
			Try
				Dim stream As Stream = New WebClient().OpenRead(uri_0.ToString())
				Dim image As Image = Image.FromStream(stream)
				Dim text As String = Path.Combine(Path.GetTempPath(), bxCqfhUpVbiKiH.getString_0(107402464))
				image.Save(text, ImageFormat.Bmp)
				bxCqfhUpVbiKiH.SystemParametersInfo(20, 0, text, 3)
				Thread.Sleep(5000)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000056 RID: 86 RVA: 0x000028C4 File Offset: 0x00000AC4
		Shared Sub New()
			Strings.CreateGetStringDelegate(GetType(bxCqfhUpVbiKiH))
		End Sub

		' Token: 0x0400008F RID: 143
		<NonSerialized()>
		Friend Shared getString_0 As GetString
	End Class
End Namespace
