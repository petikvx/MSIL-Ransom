Imports System

Namespace MessagePackLib.MessagePack
	' Token: 0x0200001F RID: 31
	Public Enum MsgPackType
		' Token: 0x0400004F RID: 79
		Unknown
		' Token: 0x04000050 RID: 80
		Null
		' Token: 0x04000051 RID: 81
		Map
		' Token: 0x04000052 RID: 82
		Array
		' Token: 0x04000053 RID: 83
		[String]
		' Token: 0x04000054 RID: 84
		[Integer]
		' Token: 0x04000055 RID: 85
		UInt64
		' Token: 0x04000056 RID: 86
		[Boolean]
		' Token: 0x04000057 RID: 87
		Float
		' Token: 0x04000058 RID: 88
		[Single]
		' Token: 0x04000059 RID: 89
		DateTime
		' Token: 0x0400005A RID: 90
		Binary
	End Enum
End Namespace
