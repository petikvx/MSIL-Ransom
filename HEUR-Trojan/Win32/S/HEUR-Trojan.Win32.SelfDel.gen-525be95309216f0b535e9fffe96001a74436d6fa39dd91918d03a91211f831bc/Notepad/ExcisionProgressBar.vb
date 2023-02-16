Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace vHack_Loader
	' Token: 0x02000016 RID: 22
	Public Class ExcisionProgressBar
		Inherits Control

		' Token: 0x17000012 RID: 18
		' (get) Token: 0x0600006C RID: 108 RVA: 0x00004C09 File Offset: 0x00002E09
		' (set) Token: 0x0600006D RID: 109 RVA: 0x00004C11 File Offset: 0x00002E11
		Public Property Maximum As Integer
			Get
				Return Me._Maximum
			End Get
			Set(value As Integer)
				If value < Me._Value Then
					Me._Value = value
				End If
				Me._Maximum = value
				MyBase.Invalidate()
			End Set
		End Property

		' Token: 0x17000013 RID: 19
		' (get) Token: 0x0600006E RID: 110 RVA: 0x00004C30 File Offset: 0x00002E30
		' (set) Token: 0x0600006F RID: 111 RVA: 0x00004C53 File Offset: 0x00002E53
		Public Property Value As Integer
			Get
				Dim num As Integer
				If Me._Value = 0 Then
					num = 0
				Else
					num = Me._Value
				End If
				Return num
			End Get
			Set(value As Integer)
				If value > Me._Maximum Then
					value = Me._Maximum
				End If
				Me._Value = value
				MyBase.Invalidate()
			End Set
		End Property

		' Token: 0x17000014 RID: 20
		' (get) Token: 0x06000070 RID: 112 RVA: 0x00004C73 File Offset: 0x00002E73
		' (set) Token: 0x06000071 RID: 113 RVA: 0x00004C7B File Offset: 0x00002E7B
		Public Property ShowPercentage As Boolean
			Get
				Return Me._ShowPercentage
			End Get
			Set(value As Boolean)
				Me._ShowPercentage = value
				MyBase.Invalidate()
			End Set
		End Property

		' Token: 0x06000072 RID: 114 RVA: 0x00004C8A File Offset: 0x00002E8A
		Protected Overrides Sub CreateHandle()
			MyBase.CreateHandle()
			AddressOf Me.Animate.IsBackground = True
		End Sub

		' Token: 0x06000073 RID: 115 RVA: 0x00004CAC File Offset: 0x00002EAC
		Public Sub Animate()
			While True
				If Me.OFS <= MyBase.Width Then
					Dim ptr As Integer = Me.OFS
					Me.OFS = ptr + 1
				Else
					Me.OFS = 0
				End If
				MyBase.Invalidate()
				Thread.Sleep(Me.Speed)
			End While
		End Sub

		' Token: 0x06000074 RID: 116 RVA: 0x00004CF0 File Offset: 0x00002EF0
		Public Sub New()
			Me.OFS = 0
			Me.Speed = 50
			Me._Maximum = 100
			Me._Value = 0
			Me._ShowPercentage = False
			Me.DoubleBuffered = True
			MyBase.SetStyle(ControlStyles.UserPaint Or ControlStyles.SupportsTransparentBackColor, True)
			Me.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000075 RID: 117 RVA: 0x00004D48 File Offset: 0x00002F48
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Dim bitmap As Bitmap = New Bitmap(MyBase.Width, MyBase.Height)
			Dim graphics As Graphics = Graphics.FromImage(bitmap)
			graphics.SmoothingMode = SmoothingMode.HighQuality
			Dim num As Integer = CInt(Math.Round(CDbl(Me._Value) / CDbl(Me._Maximum) * CDbl(MyBase.Width)))
			graphics.Clear(Me.BackColor)
			Dim bitmap2 As Bitmap = CType(New ImageToCodeClass().CodeToImage("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"), Bitmap)
			Dim textureBrush As TextureBrush = New TextureBrush(bitmap2, WrapMode.TileFlipX)
			graphics.FillPath(textureBrush, Draw.RoundRect(New Rectangle(0, 0, MyBase.Width - 1, MyBase.Height - 1), 2))
			graphics.DrawPath(New Pen(New SolidBrush(Color.FromArgb(26, 26, 26))), Draw.RoundRect(New Rectangle(1, 1, MyBase.Width - 3, MyBase.Height - 3), 2))
			Dim linearGradientBrush As LinearGradientBrush = New LinearGradientBrush(New Rectangle(2, 2, num - 5, MyBase.Height - 5), Color.FromArgb(60, 60, 60), Color.FromArgb(45, 45, 45), 90F)
			graphics.FillPath(linearGradientBrush, Draw.RoundRect(New Rectangle(2, 2, num - 5, MyBase.Height - 5), 2))
			graphics.DrawPath(New Pen(Color.FromArgb(190, 70, 70, 70)), Draw.RoundRect(New Rectangle(0, 0, MyBase.Width - 1, MyBase.Height - 1), 2))
			graphics.DrawPath(New Pen(Color.FromArgb(150, 97, 94, 90)), Draw.RoundRect(New Rectangle(2, 2, num - 5, MyBase.Height - 5), 2))
			If Me._ShowPercentage Then
				graphics.DrawString(Convert.ToString(Me.Value + "%"), New Font("Tahoma", 9F, FontStyle.Bold), Brushes.White, New Rectangle(0, 1, MyBase.Width - 1, MyBase.Height - 1), New StringFormat() With { .Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center })
			End If
			NewLateBinding.LateCall(e.Graphics, Nothing, "DrawImage", New Object() { bitmap.Clone(), 0, 0 }, Nothing, Nothing, Nothing, True)
			graphics.Dispose()
			bitmap.Dispose()
		End Sub

		' Token: 0x04000028 RID: 40
		Private OFS As Integer

		' Token: 0x04000029 RID: 41
		Private Speed As Integer

		' Token: 0x0400002A RID: 42
		Private _Maximum As Integer

		' Token: 0x0400002B RID: 43
		Private _Value As Integer

		' Token: 0x0400002C RID: 44
		Private _ShowPercentage As Boolean
	End Class
End Namespace
