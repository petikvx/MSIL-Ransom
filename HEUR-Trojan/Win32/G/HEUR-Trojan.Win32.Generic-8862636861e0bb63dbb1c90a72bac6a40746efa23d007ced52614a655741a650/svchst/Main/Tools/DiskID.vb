Imports System
Imports System.IO
Imports System.Management

Namespace Main.Tools
	' Token: 0x0200002A RID: 42
	Friend Class DiskID
		' Token: 0x060000E3 RID: 227 RVA: 0x00009560 File Offset: 0x00007760
		Public Shared Function getDiskID() As String
			Return DiskID.DiskId()
		End Function

		' Token: 0x060000E4 RID: 228 RVA: 0x00009574 File Offset: 0x00007774
		Public Shared Function getDiskID(diskLetter As String) As String
			Return DiskID.DiskId(diskLetter)
		End Function

		' Token: 0x060000E5 RID: 229 RVA: 0x0000958C File Offset: 0x0000778C
		Private Shared Function DiskId() As String
			Return DiskID.DiskId("")
		End Function

		' Token: 0x060000E6 RID: 230 RVA: 0x000095A8 File Offset: 0x000077A8
		Private Shared Function DiskId(diskLetter As String) As String
			If diskLetter = "" Then
				For Each driveInfo As DriveInfo In DriveInfo.GetDrives()
					If driveInfo.IsReady Then
						diskLetter = driveInfo.RootDirectory.ToString()
						Exit For
					End If
				Next
			End If
			If diskLetter.EndsWith(":\") Then
				diskLetter = diskLetter.Substring(0, diskLetter.Length - 2)
			End If
			Dim managementObject As ManagementObject = New ManagementObject("win32_logicaldisk.deviceid=""" + diskLetter + ":""")
			managementObject.[Get]()
			Dim text As String = managementObject("VolumeSerialNumber").ToString()
			managementObject.Dispose()
			Return text
		End Function
	End Class
End Namespace
