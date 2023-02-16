Imports System
Imports System.Net
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports vHack_Loader.My

Namespace vHack_Loader
	' Token: 0x0200001F RID: 31
	Friend NotInheritable Module system2
		' Token: 0x06000149 RID: 329 RVA: 0x00008CAC File Offset: 0x00006EAC
		Public Sub LoadUpHacks()
			Dim webClient As WebClient = New WebClient()
			MyProject.Forms.Main.ListView1.Items.Clear()
			For Each text As String In webClient.DownloadString("http://mrcheat.us/forum/loader/HackList.php?method=list_hacks").Split(New Char() { "<"c })
				text = text.Replace("/br>", "")
				system2.AddItem(text.Split(New Char() { "|"c })(0), text.Split(New Char() { "|"c })(1), text.Split(New Char() { "|"c })(2), text.Split(New Char() { "|"c })(3), text.Split(New Char() { "|"c })(4), text.Split(New Char() { "|"c })(5))
			Next
		End Sub

		' Token: 0x0600014A RID: 330 RVA: 0x00008D94 File Offset: 0x00006F94
		Public Sub AddItem(name As String, owner As String, details As String, source As String, screenshot As String, datee As String)
			Dim listViewItem As ListViewItem = New ListViewItem(New String() { name, owner, details, source, screenshot, datee })
			MyProject.Forms.Main.ListView1.Items.Add(listViewItem)
		End Sub

		' Token: 0x0600014B RID: 331 RVA: 0x00008DE4 File Offset: 0x00006FE4
		Public Sub ChechforUpdate()
			Using webClient As WebClient = New WebClient()
				If Operators.CompareString(webClient.DownloadString(MyProject.Forms.Login.web + "/Infomation.php?Action=Version"), MyProject.Forms.Login.PVerison, False) = 0 Then
					system2.GetMOTD()
				Else
					Dim text As String = webClient.DownloadString(MyProject.Forms.Login.web + "/Infomation.php?Action=Link")
					Interaction.MsgBox("New update Has Been Released!", MsgBoxStyle.Information, "Attention")
					MyProject.Forms.Updater.DownloadLink = text
					MyProject.Forms.Updater.Show()
				End If
			End Using
		End Sub

		' Token: 0x0600014C RID: 332 RVA: 0x00008EA4 File Offset: 0x000070A4
		Public Function GetMOTD() As Object
			Dim obj As Object
			Using webClient As WebClient = New WebClient()
				obj = webClient.DownloadString(MyProject.Forms.Login.web + "/Infomation.php?Action=Motd")
			End Using
			Return obj
		End Function

		' Token: 0x0600014D RID: 333 RVA: 0x00008EF4 File Offset: 0x000070F4
		Public Function GetCheatName() As Object
			Dim obj As Object
			Using webClient As WebClient = New WebClient()
				obj = webClient.DownloadString(MyProject.Forms.Login.web + "/Infomation.php?Action=Cheatname")
			End Using
			Return obj
		End Function

		' Token: 0x0600014E RID: 334 RVA: 0x00008F44 File Offset: 0x00007144
		Public Function GetCheatGame() As Object
			Dim obj As Object
			Using webClient As WebClient = New WebClient()
				obj = webClient.DownloadString(MyProject.Forms.Login.web + "/Infomation.php?Action=Cheatgame")
			End Using
			Return obj
		End Function

		' Token: 0x0600014F RID: 335 RVA: 0x00008F94 File Offset: 0x00007194
		Public Function GetCheatCoder() As Object
			Dim obj As Object
			Using webClient As WebClient = New WebClient()
				obj = webClient.DownloadString(MyProject.Forms.Login.web + "/Infomation.php?Action=Cheatcoder")
			End Using
			Return obj
		End Function

		' Token: 0x06000150 RID: 336 RVA: 0x00008FE4 File Offset: 0x000071E4
		Public Function GetLastUpdated() As Object
			Dim obj As Object
			Using webClient As WebClient = New WebClient()
				obj = webClient.DownloadString(MyProject.Forms.Login.web + "/Infomation.php?Action=Lastupdated")
			End Using
			Return obj
		End Function

		' Token: 0x06000151 RID: 337 RVA: 0x00009034 File Offset: 0x00007234
		Public Function GetStatus() As Object
			Dim obj As Object
			Using webClient As WebClient = New WebClient()
				If Operators.CompareString(webClient.DownloadString(MyProject.Forms.Login.web + "/Infomation.php?Action=Status"), "0", False) = 0 Then
					obj = "Working!"
				Else
					obj = "Not Working!"
				End If
			End Using
			Return obj
		End Function

		' Token: 0x06000152 RID: 338 RVA: 0x000090A0 File Offset: 0x000072A0
		Public Function GetDLink() As Object
			Dim obj As Object
			Using webClient As WebClient = New WebClient()
				obj = webClient.DownloadString(MyProject.Forms.Login.web + "/Infomation.php?Action=Dlurl")
			End Using
			Return obj
		End Function

		' Token: 0x06000153 RID: 339 RVA: 0x000090F0 File Offset: 0x000072F0
		Public Function GetMd5Hash(md5Hash As MD5, input As String) As String
			Dim array As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input))
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Dim num As Integer = array.Length - 1
			For i As Integer = 0 To num
				stringBuilder.Append(array(i).ToString("x2"))
			Next
			Return stringBuilder.ToString()
		End Function

		' Token: 0x06000154 RID: 340 RVA: 0x00009148 File Offset: 0x00007348
		Public Function GetCheats() As Object
			Dim array As String() = New String(5) {}
			array(0) = Conversions.ToString(system2.GetCheatName())
			array(1) = Conversions.ToString(system2.GetCheatGame())
			array(2) = Conversions.ToString(system2.GetCheatCoder())
			array(3) = Conversions.ToString(system2.GetLastUpdated())
			array(4) = Conversions.ToString(system2.GetStatus())
			Dim listViewItem As ListViewItem = New ListViewItem(array)
			MyProject.Forms.Main.ListView1.Items.Add(listViewItem)
			Dim obj As Object
			Return obj
		End Function

		' Token: 0x06000155 RID: 341 RVA: 0x000091C0 File Offset: 0x000073C0
		Public Sub GetStatus(hackName As String)
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Integer = MyProject.Forms.Main.ListView1.SelectedItems.Count - 1
				For i As Integer = 0 To num
					hackName = MyProject.Forms.Main.ListView1.SelectedItems(i).SubItems(4).Text
				Next
				If hackName.Contains("Not Working!") Then
					MyProject.Forms.Main.ExcisionButtonBlue1.Enabled = False
				Else
					MyProject.Forms.Main.ExcisionButtonBlue1.Enabled = True
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0400008D RID: 141
		Public HackName As String = ""

		' Token: 0x0400008E RID: 142
		Public GameName As String = ""
	End Module
End Namespace
