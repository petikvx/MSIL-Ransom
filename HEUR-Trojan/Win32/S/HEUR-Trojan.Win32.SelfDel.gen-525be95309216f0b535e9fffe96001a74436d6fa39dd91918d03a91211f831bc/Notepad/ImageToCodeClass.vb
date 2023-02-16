Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO

Namespace vHack_Loader
	' Token: 0x0200000A RID: 10
	Public Class ImageToCodeClass
		' Token: 0x0600001B RID: 27 RVA: 0x000024DF File Offset: 0x000006DF
		Public Function ImageToCode(Img As Bitmap) As String
			Return Convert.ToBase64String(CType(TypeDescriptor.GetConverter(Img).ConvertTo(Img, GetType(Byte())), Byte()))
		End Function

		' Token: 0x0600001C RID: 28 RVA: 0x00002501 File Offset: 0x00000701
		Public Function CodeToImage(Code As String) As Image
			Return Image.FromStream(New MemoryStream(Convert.FromBase64String(Code)))
		End Function
	End Class
End Namespace
