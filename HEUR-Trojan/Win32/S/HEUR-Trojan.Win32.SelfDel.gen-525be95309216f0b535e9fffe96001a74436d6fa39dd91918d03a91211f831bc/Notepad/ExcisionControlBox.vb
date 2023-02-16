Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace vHack_Loader
	' Token: 0x02000015 RID: 21
	Public Class ExcisionControlBox
		Inherits Control

		' Token: 0x06000065 RID: 101 RVA: 0x00004668 File Offset: 0x00002868
		Public Sub New()
			Me.State = MouseState.None
			Me.MinBtn = New Rectangle(0, 0, 32, 25)
			Me.CloseBtn = New Rectangle(33, 0, 65, 25)
			MyBase.SetStyle(ControlStyles.UserPaint Or ControlStyles.SupportsTransparentBackColor, True)
			Me.BackColor = Color.Transparent
			Me.ForeColor = Color.FromArgb(205, 205, 205)
			MyBase.Size = New Size(65, 26)
			Me.DoubleBuffered = True
		End Sub

		' Token: 0x06000066 RID: 102 RVA: 0x000046EC File Offset: 0x000028EC
		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			MyBase.OnMouseDown(e)
			If(Me.X > Me.MinBtn.X) And (Me.X < Me.MinBtn.X + 32) Then
				MyBase.FindForm().WindowState = FormWindowState.Minimized
			Else
				MyBase.FindForm().Close()
			End If
			Me.State = MouseState.Down
			MyBase.Invalidate()
		End Sub

		' Token: 0x06000067 RID: 103 RVA: 0x00004752 File Offset: 0x00002952
		Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			Me.State = MouseState.Over
			MyBase.Invalidate()
		End Sub

		' Token: 0x06000068 RID: 104 RVA: 0x00004768 File Offset: 0x00002968
		Protected Overrides Sub OnMouseEnter(e As EventArgs)
			MyBase.OnMouseEnter(e)
			Me.State = MouseState.Over
			MyBase.Invalidate()
		End Sub

		' Token: 0x06000069 RID: 105 RVA: 0x0000477E File Offset: 0x0000297E
		Protected Overrides Sub OnMouseLeave(e As EventArgs)
			MyBase.OnMouseLeave(e)
			Me.State = MouseState.None
			MyBase.Invalidate()
		End Sub

		' Token: 0x0600006A RID: 106 RVA: 0x00004794 File Offset: 0x00002994
		Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
			MyBase.OnMouseMove(e)
			Me.X = e.Location.X
			MyBase.Invalidate()
		End Sub

		' Token: 0x0600006B RID: 107 RVA: 0x000047C4 File Offset: 0x000029C4
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Dim bitmap As Bitmap = New Bitmap(MyBase.Width, MyBase.Height)
			Dim graphics As Graphics = Graphics.FromImage(bitmap)
			New Rectangle(0, 0, 64, 25)
			New Rectangle(1, 1, 62, 23)
			MyBase.OnPaint(e)
			graphics.Clear(Me.BackColor)
			Dim font As Font = New Font("Marlett", 10F, FontStyle.Bold)
			graphics.SmoothingMode = SmoothingMode.HighQuality
			Select Case Me.State
				Case MouseState.None
					graphics.DrawString("r", font, New SolidBrush(Color.FromArgb(178, 178, 178)), New Rectangle(17, 1, MyBase.Width - 1, MyBase.Height - 1), New StringFormat() With { .Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center })
					graphics.DrawString("0", font, New SolidBrush(Color.FromArgb(178, 178, 178)), New Rectangle(8, 1, MyBase.Width - 1, MyBase.Height - 1), New StringFormat() With { .Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Center })
				Case MouseState.Over
					If(Me.X > Me.MinBtn.X) And (Me.X < Me.MinBtn.X + 32) Then
						graphics.DrawString("0", font, New SolidBrush(Color.FromArgb(178, 178, 178)), New Rectangle(8, 1, MyBase.Width - 1, MyBase.Height - 1), New StringFormat() With { .Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Center })
						graphics.DrawString("0", font, New SolidBrush(Color.FromArgb(95, Color.Green)), New Rectangle(8, 1, MyBase.Width - 1, MyBase.Height - 1), New StringFormat() With { .Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Center })
						graphics.DrawString("r", font, New SolidBrush(Color.FromArgb(178, 178, 178)), New Rectangle(17, 1, MyBase.Width - 1, MyBase.Height - 1), New StringFormat() With { .Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center })
					Else
						graphics.DrawString("r", font, New SolidBrush(Color.FromArgb(178, 178, 178)), New Rectangle(17, 1, MyBase.Width - 1, MyBase.Height - 1), New StringFormat() With { .Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center })
						graphics.DrawString("r", font, New SolidBrush(Color.FromArgb(95, Color.Red)), New Rectangle(17, 1, MyBase.Width - 1, MyBase.Height - 1), New StringFormat() With { .Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center })
						graphics.DrawString("0", font, New SolidBrush(Color.FromArgb(178, 178, 178)), New Rectangle(8, 1, MyBase.Width - 1, MyBase.Height - 1), New StringFormat() With { .Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Center })
					End If
				Case MouseState.Down
					graphics.DrawString("r", font, New SolidBrush(Color.FromArgb(178, 178, 178)), New Rectangle(17, 1, MyBase.Width - 1, MyBase.Height - 1), New StringFormat() With { .Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center })
					graphics.DrawString("0", font, New SolidBrush(Color.FromArgb(178, 178, 178)), New Rectangle(8, 1, MyBase.Width - 1, MyBase.Height - 1), New StringFormat() With { .Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Center })
			End Select
			NewLateBinding.LateCall(e.Graphics, Nothing, "DrawImage", New Object() { bitmap.Clone(), 0, 0 }, Nothing, Nothing, Nothing, True)
			graphics.Dispose()
			bitmap.Dispose()
		End Sub

		' Token: 0x04000024 RID: 36
		Private State As MouseState

		' Token: 0x04000025 RID: 37
		Private X As Integer

		' Token: 0x04000026 RID: 38
		Private MinBtn As Rectangle

		' Token: 0x04000027 RID: 39
		Private CloseBtn As Rectangle
	End Class
End Namespace
