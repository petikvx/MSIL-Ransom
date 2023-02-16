Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace vHack_Loader
	' Token: 0x0200000F RID: 15
	Public Class ExcisionButtonWhite
		Inherits Control

		' Token: 0x06000037 RID: 55 RVA: 0x00003574 File Offset: 0x00001774
		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			MyBase.OnMouseDown(e)
			Me.State = MouseState.Down
			MyBase.Invalidate()
		End Sub

		' Token: 0x06000038 RID: 56 RVA: 0x0000358A File Offset: 0x0000178A
		Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			Me.State = MouseState.Over
			MyBase.Invalidate()
		End Sub

		' Token: 0x06000039 RID: 57 RVA: 0x000035A0 File Offset: 0x000017A0
		Protected Overrides Sub OnMouseEnter(e As EventArgs)
			MyBase.OnMouseEnter(e)
			Me.State = MouseState.Over
			MyBase.Invalidate()
		End Sub

		' Token: 0x0600003A RID: 58 RVA: 0x000035B6 File Offset: 0x000017B6
		Protected Overrides Sub OnMouseLeave(e As EventArgs)
			MyBase.OnMouseLeave(e)
			Me.State = MouseState.None
			MyBase.Invalidate()
		End Sub

		' Token: 0x0600003B RID: 59 RVA: 0x000035CC File Offset: 0x000017CC
		Public Sub New()
			Me.State = MouseState.None
			MyBase.SetStyle(ControlStyles.UserPaint Or ControlStyles.SupportsTransparentBackColor, True)
			Me.BackColor = Color.Transparent
			Me.ForeColor = Color.FromArgb(205, 205, 205)
			Me.DoubleBuffered = True
		End Sub

		' Token: 0x0600003C RID: 60 RVA: 0x00003620 File Offset: 0x00001820
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
					Dim linearGradientBrush As LinearGradientBrush = New LinearGradientBrush(rectangle, Color.FromArgb(225, 225, 225), Color.FromArgb(210, 210, 210), 90F)
					graphics.FillPath(linearGradientBrush, Draw.RoundRect(rectangle, 4))
					New Pen(New SolidBrush(Color.FromArgb(254, 254, 254)))
					graphics.DrawPath(Pens.Black, Draw.RoundRect(rectangle, 4))
					Dim pen As Pen = New Pen(Color.FromArgb(255, 255, 255))
					graphics.DrawPath(pen, Draw.RoundRect(rectangle2, 4))
					graphics.DrawString(Me.Text, font, New SolidBrush(Color.FromArgb(82, 87, 93)), New Rectangle(0, 1, MyBase.Width - 1, MyBase.Height - 1), New StringFormat() With { .Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center })
				Case MouseState.Over
					Dim linearGradientBrush2 As LinearGradientBrush = New LinearGradientBrush(rectangle, Color.FromArgb(222, 222, 222), Color.FromArgb(222, 222, 222), 90F)
					graphics.FillPath(linearGradientBrush2, Draw.RoundRect(rectangle, 4))
					New Pen(New SolidBrush(Color.FromArgb(222, 222, 222)))
					graphics.DrawPath(Pens.Black, Draw.RoundRect(rectangle, 4))
					Dim pen2 As Pen = New Pen(Color.FromArgb(255, 255, 255))
					graphics.DrawPath(pen2, Draw.RoundRect(rectangle2, 4))
					graphics.DrawString(Me.Text, font, New SolidBrush(Color.FromArgb(85, 85, 85)), New Rectangle(0, 1, MyBase.Width - 1, MyBase.Height - 1), New StringFormat() With { .Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center })
				Case MouseState.Down
					Dim linearGradientBrush3 As LinearGradientBrush = New LinearGradientBrush(rectangle, Color.FromArgb(254, 254, 254), Color.FromArgb(248, 246, 247), 90F)
					graphics.FillPath(linearGradientBrush3, Draw.RoundRect(rectangle, 4))
					New Pen(New SolidBrush(Color.FromArgb(254, 254, 254)))
					graphics.DrawPath(Pens.Black, Draw.RoundRect(rectangle, 4))
					Dim pen3 As Pen = New Pen(Color.FromArgb(255, 255, 255))
					graphics.DrawPath(pen3, Draw.RoundRect(rectangle2, 4))
					graphics.DrawString(Me.Text, font, New SolidBrush(Color.FromArgb(82, 87, 93)), New Rectangle(0, 1, MyBase.Width - 1, MyBase.Height - 1), New StringFormat() With { .Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center })
			End Select
			NewLateBinding.LateCall(e.Graphics, Nothing, "DrawImage", New Object() { bitmap.Clone(), 0, 0 }, Nothing, Nothing, Nothing, True)
			graphics.Dispose()
			bitmap.Dispose()
		End Sub

		' Token: 0x04000019 RID: 25
		Private State As MouseState
	End Class
End Namespace
