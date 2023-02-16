Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace vHack_Loader
	' Token: 0x02000012 RID: 18
	Public Class ExcisionPanel
		Inherits ContainerControl

		' Token: 0x06000047 RID: 71 RVA: 0x00003E2A File Offset: 0x0000202A
		Public Sub New()
			MyBase.SetStyle(ControlStyles.UserPaint Or ControlStyles.SupportsTransparentBackColor, True)
			Me.BackColor = Color.Transparent
			MyBase.Size = New Size(100, 45)
			Me.DoubleBuffered = True
		End Sub

		' Token: 0x06000048 RID: 72 RVA: 0x00003E60 File Offset: 0x00002060
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Dim bitmap As Bitmap = New Bitmap(MyBase.Width, MyBase.Height)
			Dim graphics As Graphics = Graphics.FromImage(bitmap)
			Dim rectangle As Rectangle = New Rectangle(0, 0, MyBase.Width - 1, MyBase.Height - 1)
			MyBase.OnPaint(e)
			graphics.Clear(Color.Transparent)
			New ImageToCodeClass()
			graphics.SmoothingMode = SmoothingMode.HighQuality
			graphics.CompositingQuality = CompositingQuality.HighQuality
			graphics.FillPath(New SolidBrush(Color.FromArgb(58, 56, 57)), Draw.RoundRect(rectangle, 3))
			graphics.DrawPath(New Pen(New SolidBrush(Color.FromArgb(77, 77, 77))), Draw.RoundRect(rectangle, 3))
			NewLateBinding.LateCall(e.Graphics, Nothing, "DrawImage", New Object() { bitmap.Clone(), 0, 0 }, Nothing, Nothing, Nothing, True)
			graphics.Dispose()
			bitmap.Dispose()
		End Sub
	End Class
End Namespace
