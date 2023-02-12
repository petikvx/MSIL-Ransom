Imports System
Imports System.Net

Namespace Main.Tools
	' Token: 0x02000033 RID: 51
	Public Module IpCalculator
		' Token: 0x06000128 RID: 296 RVA: 0x0000B420 File Offset: 0x00009620
		<System.Runtime.CompilerServices.ExtensionAttribute()>
		Public Function ToUInt(ipAddress As String) As UInteger
			Dim ipaddress As IPAddress = IPAddress.Parse(ipAddress)
			Dim addressBytes As Byte() = ipaddress.GetAddressBytes()
			Array.Reverse(addressBytes)
			Return BitConverter.ToUInt32(addressBytes, 0)
		End Function

		' Token: 0x06000129 RID: 297 RVA: 0x0000B44C File Offset: 0x0000964C
		<System.Runtime.CompilerServices.ExtensionAttribute()>
		Public Function ToString(ipInt As UInteger) As String
			Return ipInt.ToIpAddress().ToString()
		End Function

		' Token: 0x0600012A RID: 298 RVA: 0x0000B468 File Offset: 0x00009668
		<System.Runtime.CompilerServices.ExtensionAttribute()>
		Public Function ToIpAddress(ipInt As UInteger) As IPAddress
			Dim bytes As Byte() = BitConverter.GetBytes(ipInt)
			Array.Reverse(bytes)
			Return New IPAddress(bytes)
		End Function

		' Token: 0x0600012B RID: 299 RVA: 0x0000B48C File Offset: 0x0000968C
		<System.Runtime.CompilerServices.ExtensionAttribute()>
		Public Function ToIpAddress(ipString As String) As IPAddress
			Return IPAddress.Parse(ipString)
		End Function
	End Module
End Namespace
