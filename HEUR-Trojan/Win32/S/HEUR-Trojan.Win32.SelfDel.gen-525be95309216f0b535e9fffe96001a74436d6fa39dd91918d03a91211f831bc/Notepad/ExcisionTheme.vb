Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace vHack_Loader
	' Token: 0x0200000B RID: 11
	Public Class ExcisionTheme
		Inherits ContainerControl

		' Token: 0x0600001D RID: 29 RVA: 0x00002513 File Offset: 0x00000713
		Public Function CreateRound(x As Integer, y As Integer, width As Integer, height As Integer, slope As Integer) As GraphicsPath
			Me.CreateRoundRectangle = New Rectangle(x, y, width, height)
			Return Me.CreateRound(Me.CreateRoundRectangle, slope)
		End Function

		' Token: 0x0600001E RID: 30 RVA: 0x00002534 File Offset: 0x00000734
		Public Function CreateRound(r As Rectangle, slope As Integer) As GraphicsPath
			Me.CreateRoundPath = New GraphicsPath(FillMode.Winding)
			Me.CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180F, 90F)
			Me.CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270F, 90F)
			Me.CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0F, 90F)
			Me.CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90F, 90F)
			Me.CreateRoundPath.CloseFigure()
			Return Me.CreateRoundPath
		End Function

		' Token: 0x0600001F RID: 31 RVA: 0x000025FC File Offset: 0x000007FC
		Public Sub New()
			Me.MouseP = New Point(0, 0)
			Me.Cap = False
			Me.MoveHeight = 35
			Me.pos = 0
			MyBase.SetStyle(ControlStyles.UserPaint Or ControlStyles.SupportsTransparentBackColor, True)
			Me.BackColor = Color.FromArgb(25, 25, 25)
			Me.DoubleBuffered = True
		End Sub

		' Token: 0x06000020 RID: 32 RVA: 0x00002658 File Offset: 0x00000858
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Dim bitmap As Bitmap = New Bitmap(MyBase.Width, MyBase.Height)
			Dim graphics As Graphics = Graphics.FromImage(bitmap)
			Dim rectangle As Rectangle = New Rectangle(0, 0, MyBase.Width - 1, 35)
			Dim rectangle2 As Rectangle = New Rectangle(0, 35, MyBase.Width, MyBase.Height - 35)
			MyBase.OnPaint(e)
			graphics.Clear(Color.Fuchsia)
			graphics.CompositingQuality = CompositingQuality.HighQuality
			Dim bitmap2 As Bitmap = CType(New ImageToCodeClass().CodeToImage("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"), Bitmap)
			Dim textureBrush As TextureBrush = New TextureBrush(bitmap2, WrapMode.TileFlipXY)
			graphics.FillRectangle(textureBrush, rectangle2)
			Dim linearGradientBrush As LinearGradientBrush = New LinearGradientBrush(rectangle, Color.FromArgb(68, 68, 68), Color.FromArgb(45, 45, 45), 90F)
			graphics.FillRectangle(linearGradientBrush, rectangle)
			graphics.DrawRectangle(New Pen(New SolidBrush(Color.FromArgb(26, 26, 26))), rectangle)
			graphics.DrawLine(New Pen(New SolidBrush(Color.FromArgb(70, 70, 70))), 0, 36, MyBase.Width - 1, 36)
			graphics.DrawPath(New Pen(New SolidBrush(Color.FromArgb(15, 15, 15))), Me.CreateRound(New Rectangle(0, 0, MyBase.Width - 1, MyBase.Height - 1), 10))
			graphics.DrawPath(New Pen(New SolidBrush(Color.FromArgb(88, 88, 88))), Me.CreateRound(New Rectangle(1, 1, MyBase.Width - 3, MyBase.Height - 3), 10))
			Dim font As Font = New Font("Tahoma", 10F, FontStyle.Bold)
			graphics.DrawString(MyBase.FindForm().Text, font, Brushes.WhiteSmoke, 12F, 10F)
			graphics.FillRectangle(Brushes.Fuchsia, 0, 0, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, 1, 0, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, 2, 0, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, 3, 0, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, 0, 1, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, 0, 2, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, 0, 3, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, 1, 1, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, MyBase.Width - 1, 0, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, MyBase.Width - 2, 0, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, MyBase.Width - 3, 0, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, MyBase.Width - 4, 0, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, MyBase.Width - 1, 1, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, MyBase.Width - 1, 2, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, MyBase.Width - 1, 3, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, MyBase.Width - 2, 1, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, 0, MyBase.Height - 1, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, 0, MyBase.Height - 2, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, 0, MyBase.Height - 3, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, 0, MyBase.Height - 4, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, 1, MyBase.Height - 1, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, 2, MyBase.Height - 1, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, 3, MyBase.Height - 1, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, 1, MyBase.Height - 1, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, MyBase.Width - 1, MyBase.Height, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, MyBase.Width - 2, MyBase.Height, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, MyBase.Width - 3, MyBase.Height, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, MyBase.Width - 4, MyBase.Height, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, MyBase.Width - 1, MyBase.Height - 1, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, MyBase.Width - 1, MyBase.Height - 2, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, MyBase.Width - 1, MyBase.Height - 3, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, MyBase.Width - 2, MyBase.Height - 1, 1, 1)
			graphics.FillRectangle(Brushes.Fuchsia, MyBase.Width - 3, MyBase.Height - 1, 1, 1)
			NewLateBinding.LateCall(e.Graphics, Nothing, "DrawImage", New Object() { bitmap.Clone(), 0, 0 }, Nothing, Nothing, Nothing, True)
			graphics.Dispose()
			bitmap.Dispose()
		End Sub

		' Token: 0x06000021 RID: 33 RVA: 0x00002B1C File Offset: 0x00000D1C
		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			MyBase.OnMouseDown(e)
			If(e.Button = MouseButtons.Left) And New Rectangle(0, 0, MyBase.Width, Me.MoveHeight).Contains(e.Location) Then
				Me.Cap = True
				Me.MouseP = e.Location
			End If
		End Sub

		' Token: 0x06000022 RID: 34 RVA: 0x00002B74 File Offset: 0x00000D74
		Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			Me.Cap = False
		End Sub

		' Token: 0x06000023 RID: 35 RVA: 0x00002B84 File Offset: 0x00000D84
		Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
			MyBase.OnMouseMove(e)
			If Me.Cap Then
				MyBase.Parent.Location = Control.MousePosition - CType(Me.MouseP, Size)
			End If
		End Sub

		' Token: 0x06000024 RID: 36 RVA: 0x00002BB5 File Offset: 0x00000DB5
		Protected Overrides Sub OnCreateControl()
			MyBase.OnCreateControl()
			MyBase.ParentForm.FormBorderStyle = FormBorderStyle.None
			MyBase.ParentForm.TransparencyKey = Color.Fuchsia
			Me.Dock = DockStyle.Fill
		End Sub

		' Token: 0x04000010 RID: 16
		Private CreateRoundPath As GraphicsPath

		' Token: 0x04000011 RID: 17
		Private CreateRoundRectangle As Rectangle

		' Token: 0x04000012 RID: 18
		Private MouseP As Point

		' Token: 0x04000013 RID: 19
		Private Cap As Boolean

		' Token: 0x04000014 RID: 20
		Private MoveHeight As Integer

		' Token: 0x04000015 RID: 21
		Private pos As Integer
	End Class
End Namespace
