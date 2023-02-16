Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace vHack_Loader
	' Token: 0x02000014 RID: 20
	<DefaultEvent("CheckedChanged")>
	Public Class ExcisionRadioButton
		Inherits Control

		' Token: 0x06000056 RID: 86 RVA: 0x00004294 File Offset: 0x00002494
		Protected Overrides Sub OnMouseEnter(e As EventArgs)
			MyBase.OnMouseEnter(e)
			Me.State = MouseState.Over
			MyBase.Invalidate()
		End Sub

		' Token: 0x06000057 RID: 87 RVA: 0x000042AA File Offset: 0x000024AA
		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			MyBase.OnMouseDown(e)
			Me.State = MouseState.Down
			MyBase.Invalidate()
		End Sub

		' Token: 0x06000058 RID: 88 RVA: 0x000042C0 File Offset: 0x000024C0
		Protected Overrides Sub OnMouseLeave(e As EventArgs)
			MyBase.OnMouseLeave(e)
			Me.State = MouseState.None
			MyBase.Invalidate()
		End Sub

		' Token: 0x06000059 RID: 89 RVA: 0x000042D6 File Offset: 0x000024D6
		Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			Me.State = MouseState.Over
			MyBase.Invalidate()
		End Sub

		' Token: 0x0600005A RID: 90 RVA: 0x000042EC File Offset: 0x000024EC
		Protected Overrides Sub OnResize(e As EventArgs)
			MyBase.OnResize(e)
			MyBase.Height = 16
		End Sub

		' Token: 0x0600005B RID: 91 RVA: 0x00003F9F File Offset: 0x0000219F
		Protected Overrides Sub OnTextChanged(e As EventArgs)
			MyBase.OnTextChanged(e)
			MyBase.Invalidate()
		End Sub

		' Token: 0x17000011 RID: 17
		' (get) Token: 0x0600005C RID: 92 RVA: 0x000042FD File Offset: 0x000024FD
		' (set) Token: 0x0600005D RID: 93 RVA: 0x00004308 File Offset: 0x00002508
		Public Property Checked As Boolean
			Get
				Return Me._Checked
			End Get
			Set(value As Boolean)
				Me._Checked = value
				Me.InvalidateControls()
				Dim checkedChangedEvent As ExcisionRadioButton.CheckedChangedEventHandler = Me.CheckedChangedEvent
				If checkedChangedEvent IsNot Nothing Then
					checkedChangedEvent(Me)
				End If
				MyBase.Invalidate()
			End Set
		End Property

		' Token: 0x0600005E RID: 94 RVA: 0x00004339 File Offset: 0x00002539
		Protected Overrides Sub OnClick(e As EventArgs)
			If Not Me._Checked Then
				Me.Checked = True
			End If
			MyBase.OnClick(e)
		End Sub

		' Token: 0x14000002 RID: 2
		' (add) Token: 0x0600005F RID: 95 RVA: 0x00004354 File Offset: 0x00002554
		' (remove) Token: 0x06000060 RID: 96 RVA: 0x0000438C File Offset: 0x0000258C
		Public Event CheckedChanged As ExcisionRadioButton.CheckedChangedEventHandler

		' Token: 0x06000061 RID: 97 RVA: 0x000043C1 File Offset: 0x000025C1
		Protected Overrides Sub OnCreateControl()
			MyBase.OnCreateControl()
			Me.InvalidateControls()
		End Sub

		' Token: 0x06000062 RID: 98 RVA: 0x000043D0 File Offset: 0x000025D0
		Private Sub InvalidateControls()
			If MyBase.IsHandleCreated AndAlso Me._Checked Then
				Try
					For Each obj As Object In MyBase.Parent.Controls
						Dim control As Control = CType(obj, Control)
						If control IsNot Me AndAlso TypeOf control Is ExcisionRadioButton Then
							CType(control, ExcisionRadioButton).Checked = False
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x06000063 RID: 99 RVA: 0x00004454 File Offset: 0x00002654
		Public Sub New()
			Me.State = MouseState.None
			MyBase.SetStyle(ControlStyles.UserPaint Or ControlStyles.SupportsTransparentBackColor, True)
			Me.BackColor = Color.Transparent
			Me.ForeColor = Color.Black
			MyBase.Size = New Size(150, 16)
			Me.DoubleBuffered = True
		End Sub

		' Token: 0x06000064 RID: 100 RVA: 0x000044AC File Offset: 0x000026AC
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Dim bitmap As Bitmap = New Bitmap(MyBase.Width, MyBase.Height)
			Dim graphics As Graphics = Graphics.FromImage(bitmap)
			Dim rectangle As Rectangle = New Rectangle(0, 0, MyBase.Height, MyBase.Height - 1)
			Dim rectangle2 As Rectangle = New Rectangle(1, 1, MyBase.Height - 2, MyBase.Height - 3)
			graphics.SmoothingMode = SmoothingMode.HighQuality
			graphics.CompositingQuality = CompositingQuality.HighQuality
			graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit
			graphics.Clear(Me.BackColor)
			Dim linearGradientBrush As LinearGradientBrush = New LinearGradientBrush(rectangle, Color.FromArgb(60, 60, 60), Color.FromArgb(45, 45, 45), 90F)
			graphics.FillEllipse(linearGradientBrush, rectangle)
			graphics.DrawEllipse(New Pen(Color.FromArgb(26, 26, 26)), rectangle)
			graphics.DrawEllipse(New Pen(Color.FromArgb(70, 70, 70)), rectangle2)
			If Me.Checked Then
				Dim font As Font = New Font("Marlett", 6F, FontStyle.Bold)
				graphics.DrawString("n", font, New SolidBrush(Color.FromArgb(222, 222, 222)), 3F, 4F)
			End If
			Dim font2 As Font = New Font("Tahoma", 8F, FontStyle.Bold)
			Dim brush As Brush = New SolidBrush(Color.FromArgb(200, 200, 200))
			graphics.DrawString(Me.Text, font2, brush, New Point(18, 7), New StringFormat() With { .Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Center })
			NewLateBinding.LateCall(e.Graphics, Nothing, "DrawImage", New Object() { bitmap.Clone(), 0, 0 }, Nothing, Nothing, Nothing, True)
			graphics.Dispose()
			bitmap.Dispose()
		End Sub

		' Token: 0x0400001F RID: 31
		Private R1 As Rectangle

		' Token: 0x04000020 RID: 32
		Private G1 As LinearGradientBrush

		' Token: 0x04000021 RID: 33
		Private State As MouseState

		' Token: 0x04000022 RID: 34
		Private _Checked As Boolean

		' Token: 0x02000025 RID: 37
		' (Invoke) Token: 0x06000187 RID: 391
		Public Delegate Sub CheckedChangedEventHandler(sender As Object)
	End Class
End Namespace
