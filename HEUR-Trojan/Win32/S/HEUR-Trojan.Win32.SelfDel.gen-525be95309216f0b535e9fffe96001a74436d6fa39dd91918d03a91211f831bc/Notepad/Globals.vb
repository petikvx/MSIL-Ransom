Imports System
Imports System.IO
Imports System.Net
Imports Microsoft.VisualBasic.CompilerServices

Namespace vHack_Loader
	' Token: 0x02000018 RID: 24
	Friend NotInheritable Module Globals
		' Token: 0x06000085 RID: 133 RVA: 0x00005080 File Offset: 0x00003280
		Public Function ProcName() As String
			Return New WebClient().DownloadString("http://mrcheat.us/forum/loader/HackList.php?method=get_proc&hackname=" + system2.HackName + "&game=" + system2.GameName)
		End Function

		' Token: 0x06000086 RID: 134 RVA: 0x000050A8 File Offset: 0x000032A8
		Public Function CreateDirectory() As Object
			Try
				If Not Directory.Exists(Path.GetTempPath() + "\Cheats\" + Globals.ProcName()) Then
					Directory.CreateDirectory(Path.GetTempPath() + "\Cheats\" + Globals.ProcName())
				End If
			Catch ex As Exception
			End Try
			Dim obj As Object
			Return obj
		End Function

		' Token: 0x06000087 RID: 135 RVA: 0x0000510C File Offset: 0x0000330C
		Public Function DLLink() As Object
			Return New WebClient().DownloadString("http://mrcheat.us/forum/loader/HackList.php?method=get_url&hackname=" + system2.HackName + "&game=" + system2.GameName)
		End Function

		' Token: 0x06000088 RID: 136 RVA: 0x00005134 File Offset: 0x00003334
		Public Function DeleteDLL() As Object
			If File.Exists(Globals.DLLLocation) Then
				File.Delete(Globals.DLLLocation)
			End If
			Dim obj As Object
			Return obj
		End Function

		' Token: 0x04000033 RID: 51
		Public DLLLocation As String = Path.Combine(New String() { Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Path.GetTempPath() + "\Cheats\" + Globals.ProcName() + "\", system2.GetCheatName()), ".dll")) })

		' Token: 0x04000034 RID: 52
		Public ProcessName As String = ""
	End Module
End Namespace
