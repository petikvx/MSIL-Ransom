Imports System
Imports System.IO
Imports dg3ypDAonQcOidMs0w
Imports rE4lpnT863QnijKQK5

Namespace NitroRansomware
	' Token: 0x02000005 RID: 5
	Friend Class Logs
		' Token: 0x06000019 RID: 25 RVA: 0x000022CD File Offset: 0x000004CD
		Public Sub New(configType As String, outType As Integer)
			hHEYokUTtehNq5ji0d.LQgF529zBT6Ox()
			MyBase..ctor()
			Me.save = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
			Me.filename = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3846)
			Me.config = configType
			Me.type = outType
		End Sub

		' Token: 0x0600001A RID: 26 RVA: 0x0000446C File Offset: 0x0000266C
		Private Sub Write(append As String, message As String)
			If Me.type = 1 Then
				Using streamWriter As StreamWriter = File.AppendText(Me.save + Me.filename)
					Dim text As String = String.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3868), DateTime.Now.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3892)), append)
					streamWriter.Write(text + message)
					streamWriter.Write(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3916))
					Return
				End Using
			End If
			If Me.type = 0 Then
				Dim text2 As String = String.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3868), DateTime.Now.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3892)), append)
				Console.Write(text2 + message)
				Console.Write(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3916))
			Else
				Using streamWriter2 As StreamWriter = File.AppendText(Me.save + Me.filename)
					Dim text3 As String = String.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3868), DateTime.Now.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3892)), append)
					streamWriter2.Write(text3 + message)
					streamWriter2.Write(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3916))
				End Using
				Dim text4 As String = String.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3868), DateTime.Now.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3892)), append)
				Console.Write(text4 + message)
				Console.Write(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3916))
			End If
		End Sub

		' Token: 0x0600001B RID: 27 RVA: 0x00004614 File Offset: 0x00002814
		Public Sub Debug(message As String)
			If Me.config = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(234) Then
				Me.Write(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(234), message)
			End If
		End Sub

		' Token: 0x0600001C RID: 28 RVA: 0x0000464C File Offset: 0x0000284C
		Public Sub Info(message As String)
			If Me.config = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(234) Then
				Me.Write(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3922), message)
			ElseIf Me.config = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3922) Then
				Me.Write(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3922), message)
			End If
		End Sub

		' Token: 0x0600001D RID: 29 RVA: 0x000046AC File Offset: 0x000028AC
		Public Sub Warning(message As String)
			If Me.config <> WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3934) Then
				Me.Write(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3948), message)
			End If
		End Sub

		' Token: 0x0600001E RID: 30 RVA: 0x00002305 File Offset: 0x00000505
		Public Sub [Error](message As String)
			Me.Write(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3934), message)
		End Sub

		' Token: 0x0600001F RID: 31 RVA: 0x0000223C File Offset: 0x0000043C
		' Note: this type is marked as 'beforefieldinit'.
		Shared Sub New()
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw()
		End Sub

		' Token: 0x04000022 RID: 34
		Private save As String

		' Token: 0x04000023 RID: 35
		Private filename As String

		' Token: 0x04000024 RID: 36
		Private config As String

		' Token: 0x04000025 RID: 37
		Private type As Integer
	End Class
End Namespace
