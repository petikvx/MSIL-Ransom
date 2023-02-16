Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace vHack_Loader
	' Token: 0x02000010 RID: 16
	Public Class ExcisionSeparator
		Inherits Control

		' Token: 0x0600003D RID: 61 RVA: 0x000039D5 File Offset: 0x00001BD5
		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			MyBase.OnMouseDown(e)
			Me.State = MouseState.Down
			MyBase.Invalidate()
		End Sub

		' Token: 0x0600003E RID: 62 RVA: 0x000039EB File Offset: 0x00001BEB
		Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			Me.State = MouseState.Over
			MyBase.Invalidate()
		End Sub

		' Token: 0x0600003F RID: 63 RVA: 0x00003A01 File Offset: 0x00001C01
		Protected Overrides Sub OnMouseEnter(e As EventArgs)
			MyBase.OnMouseEnter(e)
			Me.State = MouseState.Over
			MyBase.Invalidate()
		End Sub

		' Token: 0x06000040 RID: 64 RVA: 0x00003A17 File Offset: 0x00001C17
		Protected Overrides Sub OnMouseLeave(e As EventArgs)
			MyBase.OnMouseLeave(e)
			Me.State = MouseState.None
			MyBase.Invalidate()
		End Sub

		' Token: 0x1700000F RID: 15
		' (get) Token: 0x06000041 RID: 65 RVA: 0x00003A2D File Offset: 0x00001C2D
		' (set) Token: 0x06000042 RID: 66 RVA: 0x00003A35 File Offset: 0x00001C35
		Public Property Horizontal As Boolean
			Get
				Return Me._Horizontal
			End Get
			Set(value As Boolean)
				Me._Horizontal = value
				MyBase.Invalidate()
			End Set
		End Property

		' Token: 0x06000043 RID: 67 RVA: 0x00003A44 File Offset: 0x00001C44
		Public Sub New()
			Me.State = MouseState.None
			Me._Horizontal = True
			MyBase.SetStyle(ControlStyles.UserPaint Or ControlStyles.FixedHeight Or ControlStyles.SupportsTransparentBackColor, True)
			Me.BackColor = Color.Transparent
			Me.ForeColor = Color.FromArgb(205, 205, 205)
			MyBase.Height = 4
			Me.DoubleBuffered = True
		End Sub

		' Token: 0x06000044 RID: 68 RVA: 0x00003AA4 File Offset: 0x00001CA4
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Dim bitmap As Bitmap = New Bitmap(MyBase.Width, MyBase.Height)
			Dim graphics As Graphics = Graphics.FromImage(bitmap)
			MyBase.OnPaint(e)
			graphics.Clear(Me.BackColor)
			graphics.SmoothingMode = SmoothingMode.HighQuality
			Dim horizontal As Boolean = Me._Horizontal
			If horizontal Then
				If horizontal Then
					graphics.DrawLine(New Pen(New SolidBrush(Color.FromArgb(26, 24, 25))), 0, 0, MyBase.Width - 1, 0)
					graphics.DrawLine(New Pen(New SolidBrush(Color.FromArgb(75, 73, 74))), 0, 1, MyBase.Width - 1, 1)
				End If
			Else
				graphics.DrawLine(New Pen(New SolidBrush(Color.FromArgb(26, 24, 25))), 0, 0, 0, MyBase.Height - 1)
				graphics.DrawLine(New Pen(New SolidBrush(Color.FromArgb(75, 73, 74))), 1, 0, 1, MyBase.Height - 1)
			End If
			NewLateBinding.LateCall(e.Graphics, Nothing, "DrawImage", New Object() { bitmap.Clone(), 0, 0 }, Nothing, Nothing, Nothing, True)
			graphics.Dispose()
			bitmap.Dispose()
		End Sub

		' Token: 0x0400001A RID: 26
		Private State As MouseState

		' Token: 0x0400001B RID: 27
		Private _Horizontal As Boolean
	End Class
End Namespace
