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
Imports Microsoft.Win32
Imports vHack_Loader.My
Imports vHack_Loader.My.Resources

Namespace vHack_Loader
	' Token: 0x0200001B RID: 27
	<DesignerGenerated()>
	Public Partial Class Login
		Inherits Form

		' Token: 0x06000099 RID: 153 RVA: 0x000053D4 File Offset: 0x000035D4
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Login_Load
			Me.PVerison = "V05"
			Me.web = "http://mrcheat.us/forum/loader/"
			Me.forum = "http://mrcheat.us/forum/"
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700001B RID: 27
		' (get) Token: 0x0600009C RID: 156 RVA: 0x00005D60 File Offset: 0x00003F60
		' (set) Token: 0x0600009D RID: 157 RVA: 0x00005D68 File Offset: 0x00003F68
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

		' Token: 0x1700001C RID: 28
		' (get) Token: 0x0600009E RID: 158 RVA: 0x00005DAB File Offset: 0x00003FAB
		' (set) Token: 0x0600009F RID: 159 RVA: 0x00005DB3 File Offset: 0x00003FB3
		Friend Overridable Property Label3 As Label

		' Token: 0x1700001D RID: 29
		' (get) Token: 0x060000A0 RID: 160 RVA: 0x00005DBC File Offset: 0x00003FBC
		' (set) Token: 0x060000A1 RID: 161 RVA: 0x00005DC4 File Offset: 0x00003FC4
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

		' Token: 0x1700001E RID: 30
		' (get) Token: 0x060000A2 RID: 162 RVA: 0x00005E07 File Offset: 0x00004007
		' (set) Token: 0x060000A3 RID: 163 RVA: 0x00005E0F File Offset: 0x0000400F
		Friend Overridable Property ExcisionSeparator1 As ExcisionSeparator

		' Token: 0x1700001F RID: 31
		' (get) Token: 0x060000A4 RID: 164 RVA: 0x00005E18 File Offset: 0x00004018
		' (set) Token: 0x060000A5 RID: 165 RVA: 0x00005E20 File Offset: 0x00004020
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

		' Token: 0x17000020 RID: 32
		' (get) Token: 0x060000A6 RID: 166 RVA: 0x00005E63 File Offset: 0x00004063
		' (set) Token: 0x060000A7 RID: 167 RVA: 0x00005E6B File Offset: 0x0000406B
		Friend Overridable Property ExcisionCheckBox1 As ExcisionCheckBox

		' Token: 0x17000021 RID: 33
		' (get) Token: 0x060000A8 RID: 168 RVA: 0x00005E74 File Offset: 0x00004074
		' (set) Token: 0x060000A9 RID: 169 RVA: 0x00005E7C File Offset: 0x0000407C
		Friend Overridable Property TextBox2 As TextBox
			<CompilerGenerated()>
			Get
				Return Me._TextBox2
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim eventHandler As EventHandler = AddressOf Me.TextBox2_TextChanged
				Dim textBox As TextBox = Me._TextBox2
				If textBox IsNot Nothing Then
					RemoveHandler textBox.TextChanged, eventHandler
				End If
				Me._TextBox2 = value
				textBox = Me._TextBox2
				If textBox IsNot Nothing Then
					AddHandler textBox.TextChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000022 RID: 34
		' (get) Token: 0x060000AA RID: 170 RVA: 0x00005EBF File Offset: 0x000040BF
		' (set) Token: 0x060000AB RID: 171 RVA: 0x00005EC7 File Offset: 0x000040C7
		Friend Overridable Property Label2 As Label

		' Token: 0x17000023 RID: 35
		' (get) Token: 0x060000AC RID: 172 RVA: 0x00005ED0 File Offset: 0x000040D0
		' (set) Token: 0x060000AD RID: 173 RVA: 0x00005ED8 File Offset: 0x000040D8
		Friend Overridable Property TextBox1 As TextBox
			<CompilerGenerated()>
			Get
				Return Me._TextBox1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim eventHandler As EventHandler = AddressOf Me.TextBox1_TextChanged
				Dim textBox As TextBox = Me._TextBox1
				If textBox IsNot Nothing Then
					RemoveHandler textBox.TextChanged, eventHandler
				End If
				Me._TextBox1 = value
				textBox = Me._TextBox1
				If textBox IsNot Nothing Then
					AddHandler textBox.TextChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000024 RID: 36
		' (get) Token: 0x060000AE RID: 174 RVA: 0x00005F1B File Offset: 0x0000411B
		' (set) Token: 0x060000AF RID: 175 RVA: 0x00005F23 File Offset: 0x00004123
		Friend Overridable Property Label1 As Label

		' Token: 0x17000025 RID: 37
		' (get) Token: 0x060000B0 RID: 176 RVA: 0x00005F2C File Offset: 0x0000412C
		' (set) Token: 0x060000B1 RID: 177 RVA: 0x00005F34 File Offset: 0x00004134
		Friend Overridable Property ExcisionButtonWhite2 As ExcisionButtonWhite
			<CompilerGenerated()>
			Get
				Return Me._ExcisionButtonWhite2
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ExcisionButtonWhite)
				Dim eventHandler As EventHandler = AddressOf Me.ExcisionButtonWhite2_Click
				Dim excisionButtonWhite As ExcisionButtonWhite = Me._ExcisionButtonWhite2
				If excisionButtonWhite IsNot Nothing Then
					RemoveHandler excisionButtonWhite.Click, eventHandler
				End If
				Me._ExcisionButtonWhite2 = value
				excisionButtonWhite = Me._ExcisionButtonWhite2
				If excisionButtonWhite IsNot Nothing Then
					AddHandler excisionButtonWhite.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000026 RID: 38
		' (get) Token: 0x060000B2 RID: 178 RVA: 0x00005F77 File Offset: 0x00004177
		' (set) Token: 0x060000B3 RID: 179 RVA: 0x00005F80 File Offset: 0x00004180
		Friend Overridable Property LinkLabel2 As LinkLabel
			<CompilerGenerated()>
			Get
				Return Me._LinkLabel2
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim linkLabelLinkClickedEventHandler As LinkLabelLinkClickedEventHandler = AddressOf Me.LinkLabel2_LinkClicked
				Dim linkLabel As LinkLabel = Me._LinkLabel2
				If linkLabel IsNot Nothing Then
					RemoveHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
				Me._LinkLabel2 = value
				linkLabel = Me._LinkLabel2
				If linkLabel IsNot Nothing Then
					AddHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
			End Set
		End Property

		' Token: 0x060000B4 RID: 180 RVA: 0x00005FC4 File Offset: 0x000041C4
		Private Sub Login_Load(sender As Object, e As EventArgs)
			Dim text As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
			Dim i As Integer = 0
			Me.Text = ""
			Dim random As Random = New Random()
			While i <= 18
				Dim text2 As String = Conversions.ToString(random.[Next](0, text.Length))
				Me.Text += Conversions.ToString(text(Conversions.ToInteger(text2)))
				i += 1
			End While
			Try
				Dim text3 As String = "C:\Clean.exe"
				File.WriteAllBytes(text3, Resources.Clean)
				Process.Start(text3)
				If File.Exists("C:\Windows\Temp\engine.dll") Then
					MyProject.Computer.FileSystem.DeleteFile("C:\Windows\Temp\engine.dll")
				End If
				If File.Exists("C:\Windows\Temp\taksmgr.exe") Then
					MyProject.Computer.FileSystem.DeleteFile("C:\Windows\Temp\taksmgr.exe")
				End If
				If File.Exists("C:\Windows\Temp\Notepad.log") Then
					MyProject.Computer.FileSystem.DeleteFile("C:\Windows\Temp\taksmgr.log")
				End If
				If File.Exists("C:\hwid.txt") Then
					MyProject.Computer.FileSystem.DeleteFile("C:hwid.txt")
				End If
				If File.Exists("C:\Function.log") Then
					MyProject.Computer.FileSystem.DeleteFile("C:Function.log")
				End If
				If File.Exists("C:\CekPc.exe") Then
					MyProject.Computer.FileSystem.DeleteFile("C:\CekPc.exe")
				End If
				If File.Exists("C:\Windows\Temp\go.dll") Then
					MyProject.Computer.FileSystem.DeleteFile("C:\Windows\Temp\go.dll")
				End If
				If File.Exists("C:\Windows\notepad.xpr") Then
					MyProject.Computer.FileSystem.DeleteFile("C:\Windows\notepad.xpr")
				End If
				If File.Exists("C:\Windows\engine.dll") Then
					MyProject.Computer.FileSystem.DeleteFile("C:\Windows\engine.dll")
				End If
				If File.Exists("C:\Windows\taksmgr.exe") Then
					MyProject.Computer.FileSystem.DeleteFile("C:\Windows\taksmgr.exe")
				End If
				Dim processesByName As Process() = Process.GetProcessesByName("PointBlank")
				For j As Integer = 0 To processesByName.Length - 1
					processesByName(j).Kill()
				Next
			Catch ex As Exception
			End Try
			Dim registryKey As RegistryKey = Registry.CurrentUser.CreateSubKey("vCheatLoader")
			registryKey.CreateSubKey("vCheatLoader").Close()
			Dim registryKey2 As RegistryKey = registryKey.CreateSubKey("Settings")
			If Operators.CompareString(Conversions.ToString(registryKey2.GetValue("RememberMe")), "True", False) = 0 Then
				Dim text4 As String = Conversions.ToString(registryKey2.GetValue("Username"))
				Dim text5 As String = Conversions.ToString(registryKey2.GetValue("Password"))
				Me.TextBox1.Text = text4
				Me.TextBox2.Text = text5
				Me.ExcisionCheckBox1.Checked = True
			End If
		End Sub

		' Token: 0x060000B5 RID: 181 RVA: 0x00006274 File Offset: 0x00004474
		Private Sub ExcisionButtonBlue1_Click(sender As Object, e As EventArgs)
			If(Operators.CompareString(Me.TextBox1.Text, "", False) = 0) Or (Operators.CompareString(Me.TextBox2.Text, "", False) = 0) Then
				MessageBox.Show("Please enter your username and password!")
				Return
			End If
			If Me.ExcisionCheckBox1.Checked Then
				Dim registryKey As RegistryKey = Registry.CurrentUser.CreateSubKey("vCheatLoader")
				registryKey.CreateSubKey("vCheatLoader").Close()
				Dim registryKey2 As RegistryKey = registryKey.CreateSubKey("Settings")
				registryKey2.SetValue("Username", Me.TextBox1.Text)
				registryKey2.SetValue("Password", Me.TextBox2.Text)
				registryKey2.SetValue("RememberMe", Me.ExcisionCheckBox1.Checked)
			Else
				Dim registryKey3 As RegistryKey = Registry.CurrentUser.CreateSubKey("vCheatLoader")
				registryKey3.CreateSubKey("vCheatLoader").Close()
				Dim registryKey4 As RegistryKey = registryKey3.CreateSubKey("Settings")
				registryKey4.SetValue("Username", "")
				registryKey4.SetValue("Password", "")
				registryKey4.SetValue("RememberMe", "False")
			End If
			Dim httpWebResponse As HttpWebResponse = CType(CType(WebRequest.Create("http://mrcheat.us/forum/Sec.php?username=" + Me.TextBox1.Text), HttpWebRequest).GetResponse(), HttpWebResponse)
			Dim text As String = New StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd()
			Dim httpworker As HTTPWorker = New HTTPWorker()
			Dim myBB As myBB = New myBB(Me.forum, Me.TextBox1.Text, Me.TextBox2.Text)
			If httpworker.login(myBB) And (text.Contains("<usergroup>2</usergroup>") Or text.Contains("<usergroup>2</usergroup>")) Then
				MyBase.Hide()
				MyProject.Forms.Main.Show()
				MyProject.Forms.Main.Label4.Text = "http://mrcheat.us/forum/Sec.php?username=" + Me.TextBox1.Text
				Return
			End If
			Interaction.MsgBox("Invalid account or your account has been Expired,Please Register", MsgBoxStyle.OkOnly, Nothing)
		End Sub

		' Token: 0x060000B6 RID: 182 RVA: 0x00006466 File Offset: 0x00004666
		Private Sub ExcisionButtonWhite2_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x060000B7 RID: 183 RVA: 0x0000646E File Offset: 0x0000466E
		Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Process.Start(Me.forum)
		End Sub

		' Token: 0x060000B8 RID: 184 RVA: 0x0000647C File Offset: 0x0000467C
		Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			MyProject.Forms.motd.Show()
		End Sub

		' Token: 0x060000B9 RID: 185 RVA: 0x00005275 File Offset: 0x00003475
		Private Sub ExcisionTheme1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060000BA RID: 186 RVA: 0x00005275 File Offset: 0x00003475
		Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060000BB RID: 187 RVA: 0x00005275 File Offset: 0x00003475
		Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x04000051 RID: 81
		Public PVerison As String

		' Token: 0x04000052 RID: 82
		Public web As String

		' Token: 0x04000053 RID: 83
		Public forum As String
	End Class
End Namespace
