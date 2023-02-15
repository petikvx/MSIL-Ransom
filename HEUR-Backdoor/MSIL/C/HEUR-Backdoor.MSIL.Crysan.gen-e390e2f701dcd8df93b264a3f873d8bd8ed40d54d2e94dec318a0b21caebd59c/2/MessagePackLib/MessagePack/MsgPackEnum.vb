Imports System
Imports System.Collections
Imports System.Collections.Generic

Namespace MessagePackLib.MessagePack
	' Token: 0x0200001C RID: 28
	Public Class MsgPackEnum
		Implements IEnumerator

		' Token: 0x0600007E RID: 126 RVA: 0x0000240C File Offset: 0x0000060C
		Public Sub New(obj As List(Of MsgPack))
			Me.children = obj
		End Sub

		' Token: 0x1700000D RID: 13
		' (get) Token: 0x0600007F RID: 127 RVA: 0x00002422 File Offset: 0x00000622
		ReadOnly Property Current As Object Implements System.Collections.IEnumerator.Current
			Get
				Return Me.children(Me.position)
			End Get
		End Property

		' Token: 0x06000080 RID: 128 RVA: 0x00002435 File Offset: 0x00000635
		Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
			Me.position += 1
			Return Me.position < Me.children.Count
		End Function

		' Token: 0x06000081 RID: 129 RVA: 0x00002458 File Offset: 0x00000658
		Sub Reset() Implements System.Collections.IEnumerator.Reset
			Me.position = -1
		End Sub

		' Token: 0x04000043 RID: 67
		Private children As List(Of MsgPack)

		' Token: 0x04000044 RID: 68
		Private position As Integer = -1
	End Class
End Namespace
