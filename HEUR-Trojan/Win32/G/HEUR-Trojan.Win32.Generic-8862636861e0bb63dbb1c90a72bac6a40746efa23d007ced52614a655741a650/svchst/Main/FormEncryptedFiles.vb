Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports Main.Tools

Namespace Main
	' Token: 0x02000008 RID: 8
	Public Partial Class FormEncryptedFiles
		Inherits Form

		' Token: 0x06000017 RID: 23 RVA: 0x0000230A File Offset: 0x0000050A
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000018 RID: 24 RVA: 0x00003418 File Offset: 0x00001618
		Private Sub FormEncryptedFiles_Load(sender As Object, e As EventArgs)
			For Each text As String In Locker.GetEncryptedFiles()
				If File.Exists(text + ".die") Then
					Me.dataGridViewEncryptedFiles.Rows.Add(New Object() { "", text })
				Else
					Me.dataGridViewEncryptedFiles.Rows.Add(New Object() { "YES", text })
				End If
			Next
		End Sub
	End Class
End Namespace
