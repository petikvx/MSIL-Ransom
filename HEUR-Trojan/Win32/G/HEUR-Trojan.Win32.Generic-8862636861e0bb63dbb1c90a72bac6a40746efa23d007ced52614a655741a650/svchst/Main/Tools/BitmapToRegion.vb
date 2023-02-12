Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging

Namespace Main.Tools
	' Token: 0x0200001A RID: 26
	Public Module BitmapToRegion
		' Token: 0x0600009F RID: 159 RVA: 0x00007630 File Offset: 0x00005830
		Public Function getRegion(inputBmp As Bitmap, transperancyKey As Color, tolerance As Integer) As Region
			Dim graphicsPath As GraphicsPath = New GraphicsPath()
			For i As Integer = 0 To inputBmp.Width - 1
				For j As Integer = 0 To inputBmp.Height - 1
					If Not BitmapToRegion.colorsMatch(inputBmp.GetPixel(i, j), transperancyKey, tolerance) Then
						graphicsPath.AddRectangle(New Rectangle(i, j, 1, 1))
					End If
				Next
			Next
			Dim region As Region = New Region(graphicsPath)
			graphicsPath.Dispose()
			Return region
		End Function

		' Token: 0x060000A0 RID: 160 RVA: 0x000076A0 File Offset: 0x000058A0
		Private Function colorsMatch(color1 As Color, color2 As Color, tolerance As Integer) As Boolean
			If tolerance < 0 Then
				tolerance = 0
			End If
			Return Math.Abs(CInt((color1.R - color2.R))) <= tolerance AndAlso Math.Abs(CInt((color1.G - color2.G))) <= tolerance AndAlso Math.Abs(CInt((color1.B - color2.B))) <= tolerance
		End Function

		' Token: 0x060000A1 RID: 161 RVA: 0x00007704 File Offset: 0x00005904
		Private Function colorsMatch(pixelPtr As __Pointer(Of UInteger), color1 As Color, tolerance As Integer) As Boolean
			If tolerance < 0 Then
				tolerance = 0
			End If
			Dim b As Byte = CByte((__Dereference(pixelPtr) >> 24))
			Dim b2 As Byte = CByte((__Dereference(pixelPtr) >> 16))
			Dim b3 As Byte = CByte((__Dereference(pixelPtr) >> 8))
			Dim b4 As Byte = CByte((__Dereference(pixelPtr)))
			Dim color2 As Color = Color.FromArgb(CInt(b), CInt(b2), CInt(b3), CInt(b4))
			Return Math.Abs(CInt((color1.A - color2.A))) <= tolerance AndAlso Math.Abs(CInt((color1.R - color2.R))) <= tolerance AndAlso Math.Abs(CInt((color1.G - color2.G))) <= tolerance AndAlso Math.Abs(CInt((color1.B - color2.B))) <= tolerance
		End Function

		' Token: 0x060000A2 RID: 162 RVA: 0x000077A0 File Offset: 0x000059A0
		Public Function getRegionFast(bitmap As Bitmap, transparencyKey As Color, tolerance As Integer) As Region
			Dim graphicsUnit As GraphicsUnit = GraphicsUnit.Pixel
			Dim bounds As RectangleF = bitmap.GetBounds(graphicsUnit)
			Dim rectangle As Rectangle = New Rectangle(CInt(bounds.Left), CInt(bounds.Top), CInt(bounds.Width), CInt(bounds.Height))
			Dim num As Integer = CInt(bounds.Height)
			Dim num2 As Integer = CInt(bounds.Width)
			If tolerance <= 0 Then
				tolerance = 1
			End If
			Dim bitmapData As BitmapData = bitmap.LockBits(rectangle, ImageLockMode.[ReadOnly], PixelFormat.Format32bppArgb)
			Dim ptr As __Pointer(Of UInteger) = CType(bitmapData.Scan0.ToPointer(), __Pointer(Of UInteger))
			Dim graphicsPath As GraphicsPath = New GraphicsPath()
			For i As Integer = 0 To num - 1
				Dim ptr2 As __Pointer(Of Byte) = CType(ptr, __Pointer(Of Byte))
				Dim j As Integer = 0
				While j < num2
					If Not BitmapToRegion.colorsMatch(ptr, transparencyKey, tolerance) Then
						Dim num3 As Integer = j
						While j < num2 AndAlso Not BitmapToRegion.colorsMatch(ptr, transparencyKey, tolerance)
							j += 1
							ptr += 1
						End While
						graphicsPath.AddRectangle(New Rectangle(num3, i, j - num3, 1))
					End If
					j += 1
					ptr += 1
				End While
				ptr = CType((ptr2 + bitmapData.Stride), __Pointer(Of UInteger))
			Next
			Dim region As Region = New Region(graphicsPath)
			graphicsPath.Dispose()
			bitmap.UnlockBits(bitmapData)
			Return region
		End Function
	End Module
End Namespace
