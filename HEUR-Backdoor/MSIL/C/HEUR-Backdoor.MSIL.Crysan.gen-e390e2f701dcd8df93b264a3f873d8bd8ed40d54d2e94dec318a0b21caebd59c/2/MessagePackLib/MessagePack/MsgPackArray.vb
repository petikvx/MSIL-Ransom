Imports System
Imports System.Collections.Generic

Namespace MessagePackLib.MessagePack
	' Token: 0x0200001D RID: 29
	Public Class MsgPackArray
		' Token: 0x06000082 RID: 130 RVA: 0x00002461 File Offset: 0x00000661
		Public Sub New(msgpackObj As MsgPack, listObj As List(Of MsgPack))
			Me.owner = msgpackObj
			Me.children = listObj
		End Sub

		' Token: 0x06000083 RID: 131 RVA: 0x00002477 File Offset: 0x00000677
		Public Function Add() As MsgPack
			Return Me.owner.AddArrayChild()
		End Function

		' Token: 0x06000084 RID: 132 RVA: 0x00002484 File Offset: 0x00000684
		Public Function Add(value As String) As MsgPack
			Dim msgPack As MsgPack = Me.owner.AddArrayChild()
			msgPack.AsString = value
			Return msgPack
		End Function

		' Token: 0x06000085 RID: 133 RVA: 0x00002498 File Offset: 0x00000698
		Public Function Add(value As Long) As MsgPack
			Dim msgPack As MsgPack = Me.owner.AddArrayChild()
			msgPack.SetAsInteger(value)
			Return msgPack
		End Function

		' Token: 0x06000086 RID: 134 RVA: 0x000024AC File Offset: 0x000006AC
		Public Function Add(value As Double) As MsgPack
			Dim msgPack As MsgPack = Me.owner.AddArrayChild()
			msgPack.SetAsFloat(value)
			Return msgPack
		End Function

		' Token: 0x1700000E RID: 14
		Public ReadOnly Default Property Item(index As Integer) As MsgPack
			Get
				Return Me.children(index)
			End Get
		End Property

		' Token: 0x1700000F RID: 15
		' (get) Token: 0x06000088 RID: 136 RVA: 0x000024CE File Offset: 0x000006CE
		Public ReadOnly Property Length As Integer
			Get
				Return Me.children.Count
			End Get
		End Property

		' Token: 0x04000045 RID: 69
		Private children As List(Of MsgPack)

		' Token: 0x04000046 RID: 70
		Private owner As MsgPack
	End Class
End Namespace
