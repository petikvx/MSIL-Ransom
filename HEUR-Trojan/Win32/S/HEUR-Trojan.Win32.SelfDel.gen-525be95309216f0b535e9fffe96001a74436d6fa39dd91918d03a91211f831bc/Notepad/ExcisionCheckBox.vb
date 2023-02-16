Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace vHack_Loader
	' Token: 0x02000013 RID: 19
	<DefaultEvent("CheckedChanged")>
	Public Class ExcisionCheckBox
		Inherits Control

		' Token: 0x06000049 RID: 73 RVA: 0x00003F47 File Offset: 0x00002147
		Protected Overrides Sub OnMouseEnter(e As EventArgs)
			MyBase.OnMouseEnter(e)
			Me.State = MouseState.Over
			MyBase.Invalidate()
		End Sub

		' Token: 0x0600004A RID: 74 RVA: 0x00003F5D File Offset: 0x0000215D
		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			MyBase.OnMouseDown(e)
			Me.State = MouseState.Down
			MyBase.Invalidate()
		End Sub

		' Token: 0x0600004B RID: 75 RVA: 0x00003F73 File Offset: 0x00002173
		Protected Overrides Sub OnMouseLeave(e As EventArgs)
			MyBase.OnMouseLeave(e)
			Me.State = MouseState.None
			MyBase.Invalidate()
		End Sub

		' Token: 0x0600004C RID: 76 RVA: 0x00003F89 File Offset: 0x00002189
		Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			Me.State = MouseState.Over
			MyBase.Invalidate()
		End Sub

		' Token: 0x0600004D RID: 77 RVA: 0x00003F9F File Offset: 0x0000219F
		Protected Overrides Sub OnTextChanged(e As EventArgs)
			MyBase.OnTextChanged(e)
			MyBase.Invalidate()
		End Sub

		' Token: 0x17000010 RID: 16
		' (get) Token: 0x0600004E RID: 78 RVA: 0x00003FAE File Offset: 0x000021AE
		' (set) Token: 0x0600004F RID: 79 RVA: 0x00003FB6 File Offset: 0x000021B6
		Public Property Checked As Boolean
			Get
				Return Me._Checked
			End Get
			Set(value As Boolean)
				Me._Checked = value
				MyBase.Invalidate()
			End Set
		End Property

		' Token: 0x06000050 RID: 80 RVA: 0x00003FC5 File Offset: 0x000021C5
		Protected Overrides Sub OnResize(e As EventArgs)
			MyBase.OnResize(e)
			MyBase.Height = 14
		End Sub

		' Token: 0x06000051 RID: 81 RVA: 0x00003FD8 File Offset: 0x000021D8
		Protected Overrides Sub OnClick(e As EventArgs)
			Me._Checked = Not Me._Checked
			Dim checkedChangedEvent As ExcisionCheckBox.CheckedChangedEventHandler = Me.CheckedChangedEvent
			If checkedChangedEvent IsNot Nothing Then
				checkedChangedEvent(Me)
			End If
			MyBase.OnClick(e)
		End Sub

		' Token: 0x14000001 RID: 1
		' (add) Token: 0x06000052 RID: 82 RVA: 0x0000400C File Offset: 0x0000220C
		' (remove) Token: 0x06000053 RID: 83 RVA: 0x00004044 File Offset: 0x00002244
		Public Event CheckedChanged As ExcisionCheckBox.CheckedChangedEventHandler

		' Token: 0x06000054 RID: 84 RVA: 0x0000407C File Offset: 0x0000227C
		Public Sub New()
			Me.State = MouseState.None
			MyBase.SetStyle(ControlStyles.UserPaint Or ControlStyles.SupportsTransparentBackColor Or ControlStyles.OptimizedDoubleBuffer, True)
			Me.BackColor = Color.Transparent
			Me.ForeColor = Color.Black
			MyBase.Size = New Size(145, 16)
			Me.DoubleBuffered = True
		End Sub

		' Token: 0x06000055 RID: 85 RVA: 0x000040D4 File Offset: 0x000022D4
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Dim bitmap As Bitmap = New Bitmap(MyBase.Width, MyBase.Height)
			Dim graphics As Graphics = Graphics.FromImage(bitmap)
			Dim rectangle As Rectangle = New Rectangle(0, 0, MyBase.Height, MyBase.Height - 1)
			Dim rectangle2 As Rectangle = New Rectangle(1, 1, MyBase.Height - 2, MyBase.Height - 3)
			graphics.SmoothingMode = SmoothingMode.HighQuality
			graphics.CompositingQuality = CompositingQuality.HighQuality
			graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit
			graphics.Clear(Color.Transparent)
			Dim linearGradientBrush As LinearGradientBrush = New LinearGradientBrush(rectangle, Color.FromArgb(60, 60, 60), Color.FromArgb(45, 45, 45), 90F)
			graphics.FillRectangle(linearGradientBrush, linearGradientBrush.Rectangle)
			graphics.DrawRectangle(New Pen(Color.FromArgb(26, 26, 26)), rectangle)
			graphics.DrawRectangle(New Pen(Color.FromArgb(70, 70, 70)), rectangle2)
			If Me.Checked Then
				Dim font As Font = New Font("Marlett", 10F, FontStyle.Regular)
				graphics.DrawString("a", font, New SolidBrush(Color.FromArgb(222, 222, 222)), -1.5F, 0F)
			End If
			Dim font2 As Font = New Font("Tahoma", 8F, FontStyle.Bold)
			Dim brush As Brush = New SolidBrush(Color.FromArgb(200, 200, 200))
			graphics.DrawString(Me.Text, font2, brush, New Point(18, 7), New StringFormat() With { .Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Center })
			NewLateBinding.LateCall(e.Graphics, Nothing, "DrawImage", New Object() { bitmap.Clone(), 0, 0 }, Nothing, Nothing, Nothing, True)
			graphics.Dispose()
			bitmap.Dispose()
		End Sub

		' Token: 0x0400001C RID: 28
		Private State As MouseState

		' Token: 0x0400001D RID: 29
		Private _Checked As Boolean

		' Token: 0x02000024 RID: 36
		' (Invoke) Token: 0x06000183 RID: 387
		Public Delegate Sub CheckedChangedEventHandler(sender As Object)
	End Class
End Namespace
