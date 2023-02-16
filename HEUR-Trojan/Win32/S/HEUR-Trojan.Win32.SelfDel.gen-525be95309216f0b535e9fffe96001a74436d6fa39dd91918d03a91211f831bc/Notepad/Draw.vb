Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports Microsoft.VisualBasic.CompilerServices

Namespace vHack_Loader
	' Token: 0x02000009 RID: 9
	Friend NotInheritable Module Draw
		' Token: 0x06000018 RID: 24 RVA: 0x000022B4 File Offset: 0x000004B4
		Public Function RoundRect(Rectangle As Rectangle, Curve As Integer) As GraphicsPath
			Dim graphicsPath As GraphicsPath = New GraphicsPath()
			Dim num As Integer = Curve * 2
			graphicsPath.AddArc(New Rectangle(Rectangle.X, Rectangle.Y, num, num), -180F, 90F)
			graphicsPath.AddArc(New Rectangle(Rectangle.Width - num + Rectangle.X, Rectangle.Y, num, num), -90F, 90F)
			graphicsPath.AddArc(New Rectangle(Rectangle.Width - num + Rectangle.X, Rectangle.Height - num + Rectangle.Y, num, num), 0F, 90F)
			graphicsPath.AddArc(New Rectangle(Rectangle.X, Rectangle.Height - num + Rectangle.Y, num, num), 90F, 90F)
			graphicsPath.AddLine(New Point(Rectangle.X, Rectangle.Height - num + Rectangle.Y), New Point(Rectangle.X, Curve + Rectangle.Y))
			Return graphicsPath
		End Function

		' Token: 0x06000019 RID: 25 RVA: 0x000023C0 File Offset: 0x000005C0
		Public Function RoundRect(X As Integer, Y As Integer, Width As Integer, Height As Integer, Curve As Integer) As GraphicsPath
			Dim rectangle As Rectangle = New Rectangle(X, Y, Width, Height)
			Dim graphicsPath As GraphicsPath = New GraphicsPath()
			Dim num As Integer = Curve * 2
			graphicsPath.AddArc(New Rectangle(rectangle.X, rectangle.Y, num, num), -180F, 90F)
			graphicsPath.AddArc(New Rectangle(rectangle.Width - num + rectangle.X, rectangle.Y, num, num), -90F, 90F)
			graphicsPath.AddArc(New Rectangle(rectangle.Width - num + rectangle.X, rectangle.Height - num + rectangle.Y, num, num), 0F, 90F)
			graphicsPath.AddArc(New Rectangle(rectangle.X, rectangle.Height - num + rectangle.Y, num, num), 90F, 90F)
			graphicsPath.AddLine(New Point(rectangle.X, rectangle.Height - num + rectangle.Y), New Point(rectangle.X, Curve + rectangle.Y))
			Return graphicsPath
		End Function
	End Module
End Namespace
