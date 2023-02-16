Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace vHack_Loader
	' Token: 0x0200001D RID: 29
	<DesignerGenerated()>
	Public Partial Class motd
		Inherits Form

		' Token: 0x06000139 RID: 313 RVA: 0x000087D4 File Offset: 0x000069D4
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.motd_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700005B RID: 91
		' (get) Token: 0x0600013C RID: 316 RVA: 0x00008B06 File Offset: 0x00006D06
		' (set) Token: 0x0600013D RID: 317 RVA: 0x00008B10 File Offset: 0x00006D10
		Friend Overridable Property ExcisionTheme1 As ExcisionTheme
			<CompilerGenerated()>
			Get
				Return Me._ExcisionTheme1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ExcisionTheme)
				Dim eventHandler As EventHandler = AddressOf Me.ExcisionTheme1_Click
				Dim excisionTheme As ExcisionTheme = Me._ExcisionTheme1
				If excisionTheme IsNot Nothing Then
					RemoveHandler excisionTheme.Click, eventHandler
				End If
				Me._ExcisionTheme1 = value
				excisionTheme = Me._ExcisionTheme1
				If excisionTheme IsNot Nothing Then
					AddHandler excisionTheme.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700005C RID: 92
		' (get) Token: 0x0600013E RID: 318 RVA: 0x00008B53 File Offset: 0x00006D53
		' (set) Token: 0x0600013F RID: 319 RVA: 0x00008B5C File Offset: 0x00006D5C
		Friend Overridable Property ExcisionButtonDefault1 As ExcisionButtonDefault
			<CompilerGenerated()>
			Get
				Return Me._ExcisionButtonDefault1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ExcisionButtonDefault)
				Dim eventHandler As EventHandler = AddressOf Me.ExcisionButtonDefault1_Click
				Dim excisionButtonDefault As ExcisionButtonDefault = Me._ExcisionButtonDefault1
				If excisionButtonDefault IsNot Nothing Then
					RemoveHandler excisionButtonDefault.Click, eventHandler
				End If
				Me._ExcisionButtonDefault1 = value
				excisionButtonDefault = Me._ExcisionButtonDefault1
				If excisionButtonDefault IsNot Nothing Then
					AddHandler excisionButtonDefault.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700005D RID: 93
		' (get) Token: 0x06000140 RID: 320 RVA: 0x00008B9F File Offset: 0x00006D9F
		' (set) Token: 0x06000141 RID: 321 RVA: 0x00008BA8 File Offset: 0x00006DA8
		Friend Overridable Property RichTextBox1 As RichTextBox
			<CompilerGenerated()>
			Get
				Return Me._RichTextBox1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Dim eventHandler As EventHandler = AddressOf Me.RichTextBox1_TextChanged
				Dim richTextBox As RichTextBox = Me._RichTextBox1
				If richTextBox IsNot Nothing Then
					RemoveHandler richTextBox.TextChanged, eventHandler
				End If
				Me._RichTextBox1 = value
				richTextBox = Me._RichTextBox1
				If richTextBox IsNot Nothing Then
					AddHandler richTextBox.TextChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x06000142 RID: 322 RVA: 0x00008BEB File Offset: 0x00006DEB
		Private Sub motd_Load(sender As Object, e As EventArgs)
			Me.RichTextBox1.Text = Conversions.ToString(system2.GetMOTD())
		End Sub

		' Token: 0x06000143 RID: 323 RVA: 0x00006466 File Offset: 0x00004666
		Private Sub ExcisionButtonDefault1_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06000144 RID: 324 RVA: 0x00005275 File Offset: 0x00003475
		Private Sub ExcisionTheme1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000145 RID: 325 RVA: 0x00005275 File Offset: 0x00003475
		Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)
		End Sub
	End Class
End Namespace
