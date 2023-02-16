Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace vHack_Loader
	' Token: 0x0200000E RID: 14
	Public Class ExcisionButtonBlue
		Inherits Control

		' Token: 0x06000031 RID: 49 RVA: 0x000031EC File Offset: 0x000013EC
		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			MyBase.OnMouseDown(e)
			Me.State = MouseState.Down
			MyBase.Invalidate()
		End Sub

		' Token: 0x06000032 RID: 50 RVA: 0x00003202 File Offset: 0x00001402
		Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			Me.State = MouseState.Over
			MyBase.Invalidate()
		End Sub

		' Token: 0x06000033 RID: 51 RVA: 0x00003218 File Offset: 0x00001418
		Protected Overrides Sub OnMouseEnter(e As EventArgs)
			MyBase.OnMouseEnter(e)
			Me.State = MouseState.Over
			MyBase.Invalidate()
		End Sub

		' Token: 0x06000034 RID: 52 RVA: 0x0000322E File Offset: 0x0000142E
		Protected Overrides Sub OnMouseLeave(e As EventArgs)
			MyBase.OnMouseLeave(e)
			Me.State = MouseState.None
			MyBase.Invalidate()
		End Sub

		' Token: 0x06000035 RID: 53 RVA: 0x00003244 File Offset: 0x00001444
		Public Sub New()
			Me.State = MouseState.None
			MyBase.SetStyle(ControlStyles.UserPaint Or ControlStyles.SupportsTransparentBackColor, True)
			Me.BackColor = Color.Transparent
			Me.ForeColor = Color.FromArgb(205, 205, 205)
			Me.DoubleBuffered = True
		End Sub

		' Token: 0x06000036 RID: 54 RVA: 0x00003298 File Offset: 0x00001498
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Dim bitmap As Bitmap = New Bitmap(MyBase.Width, MyBase.Height)
			Dim graphics As Graphics = Graphics.FromImage(bitmap)
			Dim rectangle As Rectangle = New Rectangle(0, 0, MyBase.Width - 1, MyBase.Height - 1)
			Dim rectangle2 As Rectangle = New Rectangle(1, 1, MyBase.Width - 3, MyBase.Height - 3)
			MyBase.OnPaint(e)
			graphics.Clear(Me.BackColor)
			Dim font As Font = New Font("Tahoma", 10F, FontStyle.Bold)
			graphics.SmoothingMode = SmoothingMode.HighQuality
			Select Case Me.State
				Case MouseState.None
					Dim linearGradientBrush As LinearGradientBrush = New LinearGradientBrush(rectangle, Color.FromArgb(85, 156, 188), Color.FromArgb(58, 136, 175), 90F)
					graphics.FillPath(linearGradientBrush, Draw.RoundRect(rectangle, 4))
					New Pen(New SolidBrush(Color.FromArgb(29, 46, 54)))
					graphics.DrawPath(Pens.Black, Draw.RoundRect(rectangle, 4))
					Dim pen As Pen = New Pen(Color.FromArgb(129, 175, 201))
					graphics.DrawPath(pen, Draw.RoundRect(rectangle2, 4))
				Case MouseState.Over
					Dim linearGradientBrush2 As LinearGradientBrush = New LinearGradientBrush(rectangle, Color.FromArgb(45, 105, 135), Color.FromArgb(30, 90, 120), 90F)
					graphics.FillPath(linearGradientBrush2, Draw.RoundRect(rectangle, 4))
					New Pen(New SolidBrush(Color.FromArgb(29, 46, 54)))
					graphics.DrawPath(Pens.Black, Draw.RoundRect(rectangle, 4))
					Dim pen2 As Pen = New Pen(Color.FromArgb(114, 160, 186))
					graphics.DrawPath(pen2, Draw.RoundRect(rectangle2, 4))
				Case MouseState.Down
					Dim linearGradientBrush3 As LinearGradientBrush = New LinearGradientBrush(rectangle, Color.FromArgb(85, 156, 188), Color.FromArgb(58, 136, 175), 90F)
					graphics.FillPath(linearGradientBrush3, Draw.RoundRect(rectangle, 4))
					New Pen(New SolidBrush(Color.FromArgb(29, 46, 54)))
					graphics.DrawPath(Pens.Black, Draw.RoundRect(rectangle, 4))
					Dim pen3 As Pen = New Pen(Color.FromArgb(129, 175, 201))
					graphics.DrawPath(pen3, Draw.RoundRect(rectangle2, 4))
			End Select
			graphics.DrawString(Me.Text, font, New SolidBrush(Color.WhiteSmoke), New Rectangle(0, 1, MyBase.Width - 1, MyBase.Height - 1), New StringFormat() With { .Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center })
			NewLateBinding.LateCall(e.Graphics, Nothing, "DrawImage", New Object() { bitmap.Clone(), 0, 0 }, Nothing, Nothing, Nothing, True)
			graphics.Dispose()
			bitmap.Dispose()
		End Sub

		' Token: 0x04000018 RID: 24
		Private State As MouseState
	End Class
End Namespace
