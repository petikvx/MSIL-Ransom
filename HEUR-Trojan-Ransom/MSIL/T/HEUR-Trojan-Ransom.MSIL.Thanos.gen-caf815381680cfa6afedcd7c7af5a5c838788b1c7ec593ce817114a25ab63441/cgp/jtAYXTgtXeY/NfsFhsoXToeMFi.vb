Imports System
Imports System.Diagnostics
Imports System.Threading
Imports SmartAssembly.Delegates
Imports SmartAssembly.HouseOfCards

Namespace jtAYXTgtXeY
	' Token: 0x02000014 RID: 20
	Public Module NfsFhsoXToeMFi
		' Token: 0x06000065 RID: 101 RVA: 0x0000CA10 File Offset: 0x0000AC10
		Public Sub kAGVzwoDJniPVrN(string_0 As String)
			Using mutex As Mutex = New Mutex(False, NfsFhsoXToeMFi.getString_0(107402701) + string_0)
				If Not mutex.WaitOne(0, False) Then
					Process.GetCurrentProcess().Kill()
				End If
			End Using
		End Sub

		' Token: 0x06000066 RID: 102 RVA: 0x000028F7 File Offset: 0x00000AF7
		Shared Sub New()
			Strings.CreateGetStringDelegate(GetType(NfsFhsoXToeMFi))
		End Sub

		' Token: 0x04000092 RID: 146
		<NonSerialized()>
		Friend getString_0 As GetString
	End Module
End Namespace
