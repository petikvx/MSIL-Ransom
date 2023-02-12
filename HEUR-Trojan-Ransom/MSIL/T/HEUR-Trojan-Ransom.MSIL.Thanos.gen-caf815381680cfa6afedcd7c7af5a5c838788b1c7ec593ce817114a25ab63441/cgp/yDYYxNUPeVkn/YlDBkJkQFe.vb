Imports System
Imports System.Diagnostics
Imports System.Runtime.InteropServices
Imports SmartAssembly.Delegates
Imports SmartAssembly.HouseOfCards

Namespace yDYYxNUPeVkn
	' Token: 0x0200001B RID: 27
	Friend NotInheritable Class YlDBkJkQFe
		' Token: 0x060000AB RID: 171
		Private Declare Ansi Function CloseHandle Lib "kernel32" (intptr_0 As IntPtr) As Boolean

		' Token: 0x060000AC RID: 172
		Private Declare Ansi Function OpenProcess Lib "kernel32" (int_0 As Integer, bool_0 As Boolean, uint_0 As UInteger) As IntPtr

		' Token: 0x060000AD RID: 173
		Private Declare Ansi Function ReadProcessMemory Lib "kernel32" (SkaxiWBhtNv As IntPtr, XMttJyTlCRpu As IntPtr, <Out()> iGqQNPbOtyetG As Byte(), LKZjaKVcPTXG As UInteger, ByRef wSKaxouhlDX As UInteger) As Boolean

		' Token: 0x060000AE RID: 174
		Private Declare Ansi Function WriteProcessMemory Lib "kernel32" (intptr_0 As IntPtr, intptr_1 As IntPtr, byte_0 As Byte(), uint_0 As UInteger, ByRef uint_1 As UInteger) As Boolean

		' Token: 0x060000AF RID: 175
		Private Declare Ansi Function VirtualProtectEx Lib "kernel32" (intptr_0 As IntPtr, intptr_1 As IntPtr, uint_0 As UInteger, uint_1 As UInteger, ByRef uint_2 As UInteger) As Boolean

		' Token: 0x060000B0 RID: 176
		Private Declare Ansi Function Module32Next Lib "kernel32" (intptr_0 As IntPtr, ByRef tvfAiHatgcfHJ_0 As YlDBkJkQFe.TVfAiHatgcfHJ) As Boolean

		' Token: 0x060000B1 RID: 177
		Private Declare Ansi Function Module32First Lib "kernel32" (intptr_0 As IntPtr, ByRef tvfAiHatgcfHJ_0 As YlDBkJkQFe.TVfAiHatgcfHJ) As Boolean

		' Token: 0x060000B2 RID: 178
		Private Declare Ansi Function CreateToolhelp32Snapshot Lib "kernel32" (uint_0 As UInteger, uint_1 As UInteger) As IntPtr

		' Token: 0x060000B3 RID: 179
		Private Declare Ansi Function VirtualAllocEx Lib "kernel32" (intptr_0 As IntPtr, intptr_1 As IntPtr, uint_0 As UInteger, uint_1 As UInteger, uint_2 As UInteger) As IntPtr

		' Token: 0x060000B4 RID: 180 RVA: 0x0000E37C File Offset: 0x0000C57C
		Private Shared Function anjQAVFkRLXzuXg(intptr_0 As IntPtr, intptr_1 As IntPtr, uint_0 As UInteger) As Byte()
			' The following expression was wrapped in a checked-statement
			Dim array As Byte() = New Byte(CInt((CULng(uint_0) - 1UL)) + 1 - 1) {}
			Dim array2 As Byte() = array
			Dim num As UInteger = 0UI
			YlDBkJkQFe.ReadProcessMemory(intptr_0, intptr_1, array2, uint_0, num)
			Return array
		End Function

		' Token: 0x060000B5 RID: 181 RVA: 0x0000E3B0 File Offset: 0x0000C5B0
		Private Shared Function RulTTQNOnybLt(intptr_0 As IntPtr, uint_0 As UInteger, string_0 As String) As UInteger
			Dim intPtr As IntPtr
			Dim num As UInteger = BitConverter.ToUInt32(YlDBkJkQFe.anjQAVFkRLXzuXg(intptr_0, CType(CLng((CULng(uint_0) + 60UL)), IntPtr), 4UI), 0)
			Dim num2 As UInteger = BitConverter.ToUInt32(YlDBkJkQFe.anjQAVFkRLXzuXg(intptr_0, CType(CLng((CULng((uint_0 + num)) + 120UL)), IntPtr), 4UI), 0)
			Dim array As Byte() = YlDBkJkQFe.anjQAVFkRLXzuXg(intptr_0, CType(CLng((CULng((uint_0 + num2)))), IntPtr), 40UI)
			Dim num3 As Integer = BitConverter.ToInt32(array, 24)
			Dim num4 As UInteger = BitConverter.ToUInt32(array, 32) + uint_0
			Dim num5 As UInteger = BitConverter.ToUInt32(array, 28) + uint_0
			Dim num6 As UInteger = BitConverter.ToUInt32(array, 36) + uint_0
			intPtr = Marshal.AllocHGlobal(64)
			Dim num7 As Integer = num3
			Dim num8 As Integer = 1
			Dim num13 As UInteger
			While True
				Dim num9 As Integer = num8
				Dim num10 As Integer = num7
				If num9 > num10 Then
					GoTo IL_15C
				End If
				Dim num11 As UInteger = BitConverter.ToUInt32(YlDBkJkQFe.anjQAVFkRLXzuXg(intptr_0, CType(CLng((CULng(num4) + CULng((CLng(((num8 - 1) * 4)))))), IntPtr), 4UI), 0)
				Marshal.Copy(YlDBkJkQFe.anjQAVFkRLXzuXg(intptr_0, CType(CLng((CULng((uint_0 + num11)))), IntPtr), 64UI), 0, intPtr, 64)
				Dim text As String = Marshal.PtrToStringAnsi(intPtr)
				Dim num12 As UInteger = CUInt(BitConverter.ToInt16(YlDBkJkQFe.anjQAVFkRLXzuXg(intptr_0, CType(CLng((CULng(num6) + CULng((CLng(((num8 - 1) * 2)))))), IntPtr), 2UI), 0))
				num13 = BitConverter.ToUInt32(YlDBkJkQFe.anjQAVFkRLXzuXg(intptr_0, CType(CLng((CULng(num5) + CULng(num12) * 4UL)), IntPtr), 4UI), 0) + uint_0
				If String.Compare(text, string_0, True) = 0 Then
					Exit For
				End If
				num8 += 1
			End While
			Marshal.FreeHGlobal(intPtr)
			Return num13
			IL_15C:
			Marshal.FreeHGlobal(intPtr)
			Return 0UI
		End Function

		' Token: 0x060000B6 RID: 182 RVA: 0x0000E524 File Offset: 0x0000C724
		Private Shared Function HeAZQAVgOvoM(string_0 As String, string_1 As String) As IntPtr
			' The following expression was wrapped in a checked-statement
			Dim intPtr As IntPtr = YlDBkJkQFe.CreateToolhelp32Snapshot(24UI, CUInt(Process.GetProcessesByName(string_0)(0).Id))
			Dim zero As IntPtr = IntPtr.Zero
			Dim intPtr2 As IntPtr
			If intPtr = zero Then
				intPtr2 = zero
			Else
				Dim tvfAiHatgcfHJ As YlDBkJkQFe.TVfAiHatgcfHJ = Nothing
				tvfAiHatgcfHJ.ESRrReYbeSisjQ = CUInt(Marshal.SizeOf(Of YlDBkJkQFe.TVfAiHatgcfHJ)(tvfAiHatgcfHJ))
				If YlDBkJkQFe.Module32First(intPtr, tvfAiHatgcfHJ) Then
					Do
						If tvfAiHatgcfHJ.VYvTaeGokUP.ToInt64() <= 2147483647L Then
							If String.Compare(string_1, tvfAiHatgcfHJ.fAVApAuzehrH, True) = 0 Then
								GoTo IL_8A
							End If
						End If
					Loop While YlDBkJkQFe.Module32Next(intPtr, tvfAiHatgcfHJ)
					GoTo IL_94
					IL_8A:
					Return tvfAiHatgcfHJ.VYvTaeGokUP
				End If
				IL_94:
				intPtr2 = zero
			End If
			Return intPtr2
		End Function

		' Token: 0x060000B7 RID: 183 RVA: 0x00002B63 File Offset: 0x00000D63
		Private Shared Function XLTaRtpBXMZ(int_0 As Integer, int_1 As Integer) As Integer
			' The following expression was wrapped in a checked-expression
			Return int_0 - int_1 - 5
		End Function

		' Token: 0x060000B8 RID: 184 RVA: 0x0000E5C8 File Offset: 0x0000C7C8
		Public Shared Sub XVLtWYVmnRvNaK(string_0 As String)
			Dim array As Byte() = New Byte(96) {}
			Dim array2 As UInteger() = New UInteger(3) {}
			Dim array3 As Byte()() = New Byte(3)() {}
			Dim num As UInteger = 0UI
			Dim array4 As Byte() = New Byte(4) {}
			array4(0) = 233
			Dim array5 As Byte() = array4
			Dim array6 As Byte()() = New Byte()() { YlDBkJkQFe.KjohIikJHTooQ, YlDBkJkQFe.XXtuIvZJQQuBzMqL, YlDBkJkQFe.kbgthXbOQkhfmO }
			Dim num2 As UInteger
			Dim intPtr As IntPtr
			Dim num3 As UInteger
			Dim num4 As UInteger
			Dim num5 As UInteger
			num2 = CUInt((array6(0).Length + array6(1).Length + array6(2).Length))
			intPtr = YlDBkJkQFe.OpenProcess(56, False, CUInt(Process.GetProcessesByName(string_0)(0).Id))
			Dim zero As IntPtr = IntPtr.Zero
			num3 = CUInt(CInt(YlDBkJkQFe.VirtualAllocEx(intPtr, zero, CUInt((CULng(num2) + 96UL)), 12288UI, 64UI)))
			num4 = CUInt(CInt(YlDBkJkQFe.RulTTQNOnybLt(intPtr, CUInt(CInt(YlDBkJkQFe.HeAZQAVgOvoM(string_0, YlDBkJkQFe.getString_0(107400247)))), YlDBkJkQFe.getString_0(107400262))))
			num5 = CUInt(CInt(YlDBkJkQFe.RulTTQNOnybLt(intPtr, CUInt(CInt(YlDBkJkQFe.HeAZQAVgOvoM(string_0, YlDBkJkQFe.getString_0(107400247)))), YlDBkJkQFe.getString_0(107400213))))
			array2(0) = CUInt(CInt(YlDBkJkQFe.RulTTQNOnybLt(intPtr, CUInt(CInt(YlDBkJkQFe.HeAZQAVgOvoM(string_0, YlDBkJkQFe.getString_0(107400184)))), YlDBkJkQFe.getString_0(107400203))))
			array2(1) = CUInt(CInt(YlDBkJkQFe.RulTTQNOnybLt(intPtr, CUInt(CInt(YlDBkJkQFe.HeAZQAVgOvoM(string_0, YlDBkJkQFe.getString_0(107400184)))), YlDBkJkQFe.getString_0(107400142))))
			array2(2) = CUInt(CInt(YlDBkJkQFe.RulTTQNOnybLt(intPtr, CUInt(CInt(YlDBkJkQFe.HeAZQAVgOvoM(string_0, YlDBkJkQFe.getString_0(107400184)))), YlDBkJkQFe.getString_0(107400121))))
			array3(0) = YlDBkJkQFe.anjQAVFkRLXzuXg(intPtr, CType(CLng(CULng(array2(0))), IntPtr), 24UI)
			array3(1) = YlDBkJkQFe.anjQAVFkRLXzuXg(intPtr, CType(CLng(CULng(array2(1))), IntPtr), 24UI)
			array3(2) = YlDBkJkQFe.anjQAVFkRLXzuXg(intPtr, CType(CLng(CULng(array2(2))), IntPtr), 24UI)
			BitConverter.GetBytes(num4).CopyTo(array, 0)
			BitConverter.GetBytes(num5).CopyTo(array, 4)
			BitConverter.GetBytes(Process.GetCurrentProcess().Id).CopyTo(array, 8)
			BitConverter.GetBytes(array2(0)).CopyTo(array, 12)
			BitConverter.GetBytes(array2(1)).CopyTo(array, 16)
			BitConverter.GetBytes(array2(2)).CopyTo(array, 20)
			array3(0).CopyTo(array, 24)
			array3(1).CopyTo(array, 48)
			array3(2).CopyTo(array, 72)
			Dim num6 As UInteger = num3
			Dim intPtr2 As IntPtr = intPtr
			Dim intPtr3 As IntPtr = CType(CLng(CULng(num6)), IntPtr)
			Dim array7 As Byte() = array
			Dim num7 As UInteger = 0UI
			YlDBkJkQFe.WriteProcessMemory(intPtr2, intPtr3, array7, 96UI, num7)
			num6 = CUInt((CULng(num6) + 96UL))
			Dim num8 As Integer = array6.Length - 1
			Dim num9 As Integer = 0
			While True
				Dim num10 As Integer = num9
				Dim num11 As Integer = num8
				If num10 > num11 Then
					Exit For
				End If
				Dim intPtr4 As IntPtr = intPtr
				Dim intPtr5 As IntPtr = CType(CLng((CULng(num6))), IntPtr)
				Dim array8 As Byte() = array6(num9)
				Dim num12 As UInteger = CUInt(array6(num9).Length)
				num7 = 0UI
				YlDBkJkQFe.WriteProcessMemory(intPtr4, intPtr5, array8, num12, num7)
				num6 = CUInt((CULng(num6) + CULng((CLng(array6(num9).Length)))))
				num9 += 1
			End While
			Dim intPtr6 As IntPtr = intPtr
			Dim intPtr7 As IntPtr = CType(CLng((CULng(num3))), IntPtr)
			Dim num13 As UInteger = CUInt((CULng(num2) + 96UL))
			num7 = 0UI
			YlDBkJkQFe.VirtualProtectEx(intPtr6, intPtr7, num13, 16UI, num7)
			num6 = CUInt((CULng(num3) + 96UL))
			BitConverter.GetBytes(YlDBkJkQFe.XLTaRtpBXMZ(CInt(num6), CInt(array2(0)))).CopyTo(array5, 1)
			YlDBkJkQFe.VirtualProtectEx(intPtr, CType(CLng((CULng(array2(0)))), IntPtr), CUInt(array5.Length), 64UI, num)
			Dim intPtr8 As IntPtr = intPtr
			Dim intPtr9 As IntPtr = CType(CLng((CULng(array2(0)))), IntPtr)
			Dim array9 As Byte() = array5
			Dim num14 As UInteger = CUInt(array5.Length)
			num7 = 0UI
			YlDBkJkQFe.WriteProcessMemory(intPtr8, intPtr9, array9, num14, num7)
			Dim intPtr10 As IntPtr = intPtr
			Dim intPtr11 As IntPtr = CType(CLng((CULng(array2(0)))), IntPtr)
			Dim num15 As UInteger = CUInt(array5.Length)
			Dim num16 As UInteger = num
			num7 = 0UI
			YlDBkJkQFe.VirtualProtectEx(intPtr10, intPtr11, num15, num16, num7)
			num6 = CUInt((CULng(num6) + CULng((CLng(array6(0).Length)))))
			BitConverter.GetBytes(YlDBkJkQFe.XLTaRtpBXMZ(CInt(num6), CInt(array2(1)))).CopyTo(array5, 1)
			YlDBkJkQFe.VirtualProtectEx(intPtr, CType(CLng((CULng(array2(1)))), IntPtr), CUInt(array5.Length), 64UI, num)
			Dim intPtr12 As IntPtr = intPtr
			Dim intPtr13 As IntPtr = CType(CLng((CULng(array2(1)))), IntPtr)
			Dim array10 As Byte() = array5
			Dim num17 As UInteger = CUInt(array5.Length)
			num7 = 0UI
			YlDBkJkQFe.WriteProcessMemory(intPtr12, intPtr13, array10, num17, num7)
			Dim intPtr14 As IntPtr = intPtr
			Dim intPtr15 As IntPtr = CType(CLng((CULng(array2(1)))), IntPtr)
			Dim num18 As UInteger = CUInt(array5.Length)
			Dim num19 As UInteger = num
			num7 = 0UI
			YlDBkJkQFe.VirtualProtectEx(intPtr14, intPtr15, num18, num19, num7)
			num6 = CUInt((CULng(num6) + CULng((CLng(array6(1).Length)))))
			BitConverter.GetBytes(YlDBkJkQFe.XLTaRtpBXMZ(CInt(num6), CInt(array2(2)))).CopyTo(array5, 1)
			YlDBkJkQFe.VirtualProtectEx(intPtr, CType(CLng((CULng(array2(2)))), IntPtr), CUInt(array5.Length), 64UI, num)
			Dim intPtr16 As IntPtr = intPtr
			Dim intPtr17 As IntPtr = CType(CLng((CULng(array2(2)))), IntPtr)
			Dim array11 As Byte() = array5
			Dim num20 As UInteger = CUInt(array5.Length)
			num7 = 0UI
			YlDBkJkQFe.WriteProcessMemory(intPtr16, intPtr17, array11, num20, num7)
			Dim intPtr18 As IntPtr = intPtr
			Dim intPtr19 As IntPtr = CType(CLng((CULng(array2(2)))), IntPtr)
			Dim num21 As UInteger = CUInt(array5.Length)
			Dim num22 As UInteger = num
			num7 = 0UI
			YlDBkJkQFe.VirtualProtectEx(intPtr18, intPtr19, num21, num22, num7)
			YlDBkJkQFe.CloseHandle(intPtr)
		End Sub

		' Token: 0x060000BA RID: 186 RVA: 0x0000EB04 File Offset: 0x0000CD04
		' Note: this type is marked as 'beforefieldinit'.
		Shared Sub New()
			Strings.CreateGetStringDelegate(GetType(YlDBkJkQFe))
			YlDBkJkQFe.KjohIikJHTooQ = New Byte() { 85, 139, 236, 131, 236, 20, 86, 199, 69, 248, 1, 0, 0, 192, 232, 0, 0, 0, 0, 88, 37, 0, 240, Byte.MaxValue, Byte.MaxValue, 137, 69, 252, Byte.MaxValue, 117, 24, Byte.MaxValue, 117, 20, Byte.MaxValue, 117, 16, Byte.MaxValue, 117, 12, Byte.MaxValue, 117, 8, 139, 69, 252, 131, 192, 24, Byte.MaxValue, 208, 137, 69, 248, 131, 125, 248, 0, 15, 140, 168, 0, 0, 0, Byte.MaxValue, 117, 8, 139, 69, 252, Byte.MaxValue, 16, 139, 240, 139, 69, 252, Byte.MaxValue, 80, 4, 59, 240, 116, 10, 131, 125, 8, Byte.MaxValue, 15, 133, 138, 0, 0, 0, 131, 101, 244, 0, 235, 7, 139, 69, 244, 64, 137, 69, 244, 131, 125, 244, 3, 115, 119, 139, 69, 244, 139, 77, 252, 131, 124, 129, 12, 0, 116, 101, 139, 69, 244, 139, 77, 252, 139, 68, 129, 12, 59, 69, 12, 114, 86, 139, 69, 12, 3, 69, 20, 139, 77, 244, 139, 85, 252, 57, 68, 138, 12, 115, 68, 139, 69, 244, 139, 77, 252, 139, 68, 129, 12, 43, 69, 12, 137, 69, 240, 131, 101, 236, 0, 235, 7, 139, 69, 236, 64, 137, 69, 236, 131, 125, 236, 24, 115, 33, 139, 69, 244, 107, 192, 24, 139, 77, 252, 141, 68, 1, 24, 139, 77, 236, 3, 77, 240, 139, 85, 16, 139, 117, 236, 138, 4, 48, 136, 4, 10, 235, 210, 233, 124, Byte.MaxValue, Byte.MaxValue, Byte.MaxValue, 139, 69, 248, 94, 201, 194, 20, 0 }
			YlDBkJkQFe.XXtuIvZJQQuBzMqL = New Byte() { 85, 139, 236, 81, 81, 199, 69, 248, 1, 0, 0, 192, 232, 0, 0, 0, 0, 88, 37, 0, 240, Byte.MaxValue, Byte.MaxValue, 137, 69, 252, 131, 125, 20, 0, 116, 22, 139, 69, 20, 139, 77, 252, 139, 0, 59, 65, 8, 117, 9, 199, 69, 248, 34, 0, 0, 192, 235, 23, Byte.MaxValue, 117, 20, Byte.MaxValue, 117, 16, Byte.MaxValue, 117, 12, Byte.MaxValue, 117, 8, 139, 69, 252, 131, 192, 48, Byte.MaxValue, 208, 137, 69, 248, 139, 69, 248, 201, 194, 16, 0 }
			YlDBkJkQFe.kbgthXbOQkhfmO = New Byte() { 85, 139, 236, 131, 236, 28, 86, 87, 199, 69, 236, 1, 0, 0, 192, 232, 0, 0, 0, 0, 88, 37, 0, 240, Byte.MaxValue, Byte.MaxValue, 137, 69, 240, Byte.MaxValue, 117, 20, Byte.MaxValue, 117, 16, Byte.MaxValue, 117, 12, Byte.MaxValue, 117, 8, 139, 69, 240, 131, 192, 72, Byte.MaxValue, 208, 137, 69, 236, 131, 125, 236, 0, 15, 140, 78, 1, 0, 0, 131, 125, 8, 5, 117, 93, 131, 101, 248, 0, 139, 69, 12, 137, 69, 244, 139, 69, 244, 131, 56, 0, 116, 70, 139, 69, 244, 137, 69, 248, 139, 69, 248, 139, 77, 248, 3, 8, 137, 77, 244, 139, 69, 244, 139, 77, 240, 139, 64, 68, 59, 65, 8, 117, 37, 139, 69, 244, 131, 56, 0, 117, 8, 139, 69, 248, 131, 32, 0, 235, 15, 139, 69, 248, 139, 0, 139, 77, 244, 3, 1, 139, 77, 248, 137, 1, 139, 69, 248, 137, 69, 244, 235, 178, 233, 235, 0, 0, 0, 131, 125, 8, 16, 15, 133, 225, 0, 0, 0, 139, 69, 12, 137, 69, 252, 131, 101, 232, 0, 235, 7, 139, 69, 232, 64, 137, 69, 232, 139, 69, 252, 139, 77, 232, 59, 8, 15, 131, 192, 0, 0, 0, 139, 69, 232, 193, 224, 4, 139, 77, 252, 139, 85, 240, 139, 68, 1, 4, 59, 66, 8, 15, 133, 162, 0, 0, 0, 139, 69, 232, 193, 224, 4, 139, 77, 252, 198, 68, 1, 9, 0, 139, 69, 232, 193, 224, 4, 139, 77, 252, 131, 100, 1, 16, 0, 139, 69, 232, 193, 224, 4, 51, 201, 139, 85, 252, 102, 137, 76, 2, 10, 139, 69, 232, 193, 224, 4, 139, 77, 252, 131, 100, 1, 12, 0, 139, 69, 232, 193, 224, 4, 139, 77, 252, 198, 68, 1, 8, 0, 139, 69, 232, 193, 224, 4, 139, 77, 252, 131, 100, 1, 4, 0, 139, 69, 232, 137, 69, 228, 235, 7, 139, 69, 228, 64, 137, 69, 228, 139, 69, 252, 139, 77, 228, 59, 8, 115, 33, 139, 69, 228, 64, 193, 224, 4, 139, 77, 252, 141, 116, 1, 4, 139, 69, 228, 193, 224, 4, 139, 77, 252, 141, 124, 1, 4, 165, 165, 165, 165, 235, 206, 139, 69, 252, 139, 0, 72, 139, 77, 252, 137, 1, 139, 69, 232, 72, 137, 69, 232, 233, 43, Byte.MaxValue, Byte.MaxValue, Byte.MaxValue, 139, 69, 236, 95, 94, 201, 194, 16, 0 }
		End Sub

		' Token: 0x040000AA RID: 170
		Private Shared KjohIikJHTooQ As Byte()

		' Token: 0x040000AB RID: 171
		Private Shared XXtuIvZJQQuBzMqL As Byte()

		' Token: 0x040000AC RID: 172
		Private Shared kbgthXbOQkhfmO As Byte()

		' Token: 0x040000AD RID: 173
		<NonSerialized()>
		Friend Shared getString_0 As GetString

		' Token: 0x0200001C RID: 28
		Public Structure TVfAiHatgcfHJ
			' Token: 0x040000AE RID: 174
			Public ESRrReYbeSisjQ As UInteger

			' Token: 0x040000AF RID: 175
			Public gxTcsoqvEqAwDeaJ As UInteger

			' Token: 0x040000B0 RID: 176
			Public OXctZrDTdtlJb As UInteger

			' Token: 0x040000B1 RID: 177
			Public AMrPIUOGUx As UInteger

			' Token: 0x040000B2 RID: 178
			Public bNSEbsCivc As UInteger

			' Token: 0x040000B3 RID: 179
			Public VYvTaeGokUP As IntPtr

			' Token: 0x040000B4 RID: 180
			Public cDUaMWbcCmd As UInteger

			' Token: 0x040000B5 RID: 181
			Public uMyHukOrdz As IntPtr

			' Token: 0x040000B6 RID: 182
			<MarshalAs(UnmanagedType.ByValTStr, SizeConst := 256)>
			Public fAVApAuzehrH As String

			' Token: 0x040000B7 RID: 183
			<MarshalAs(UnmanagedType.ByValTStr, SizeConst := 260)>
			Public DKdLEvsYDHBth As String
		End Structure
	End Class
End Namespace
