Imports System

Namespace frgoWklvEOSV
	' Token: 0x0200000C RID: 12
	Public NotInheritable Class AnLYutpDjmCX
		' Token: 0x0600003D RID: 61 RVA: 0x0000BEF4 File Offset: 0x0000A0F4
		Public Shared Function cVQEpGjgoi(int_0 As Integer) As String
			Dim random As Random = New Random()
			Dim text As String = Nothing
			Dim i As Integer = 0
			While i < 32
				Dim c As Char = CChar((random.[Next](33, 127) Mod 255))
				If Convert.ToInt32(c) = 34 Then
					GoTo IL_48
				End If
				If Convert.ToInt32(c) = 92 Then
					GoTo IL_48
				End If
				text += Convert.ToChar(c)
				IL_4C:
				i += 1
				Continue While
				IL_48:
				i -= 1
				GoTo IL_4C
			End While
			Return text
		End Function
	End Class
End Namespace
