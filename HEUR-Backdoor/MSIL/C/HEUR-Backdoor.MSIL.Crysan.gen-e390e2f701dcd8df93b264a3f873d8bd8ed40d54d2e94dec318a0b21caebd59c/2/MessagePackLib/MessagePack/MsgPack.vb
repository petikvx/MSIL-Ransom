Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.IO

Namespace MessagePackLib.MessagePack
	' Token: 0x0200001E RID: 30
	Public Class MsgPack
		Implements IEnumerable

		' Token: 0x06000089 RID: 137 RVA: 0x000024DB File Offset: 0x000006DB
		Private Sub SetName(value As String)
			Me.name = value
			Me.lowerName = Me.name.ToLower()
		End Sub

		' Token: 0x0600008A RID: 138 RVA: 0x00004A08 File Offset: 0x00002C08
		Private Sub Clear()
			For i As Integer = 0 To Me.children.Count - 1
				Me.children(i).Clear()
			Next
			Me.children.Clear()
		End Sub

		' Token: 0x0600008B RID: 139 RVA: 0x00004A4C File Offset: 0x00002C4C
		Private Function InnerAdd() As MsgPack
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.parent = Me
			Me.children.Add(msgPack)
			Return msgPack
		End Function

		' Token: 0x0600008C RID: 140 RVA: 0x00004A74 File Offset: 0x00002C74
		Private Function IndexOf(name As String) As Integer
			Dim num As Integer = -1
			Dim num2 As Integer = -1
			Dim text As String = name.ToLower()
			For Each msgPack As MsgPack In Me.children
				num += 1
				If text.Equals(msgPack.lowerName) Then
					num2 = num
					Exit For
				End If
			Next
			Return num2
		End Function

		' Token: 0x0600008D RID: 141 RVA: 0x00004AF0 File Offset: 0x00002CF0
		Public Function FindObject(name As String) As MsgPack
			Dim num As Integer = Me.IndexOf(name)
			If num = -1 Then
				Return Nothing
			End If
			Return Me.children(num)
		End Function

		' Token: 0x0600008E RID: 142 RVA: 0x000024F5 File Offset: 0x000006F5
		Private Function InnerAddMapChild() As MsgPack
			If Me.valueType <> MsgPackType.Map Then
				Me.Clear()
				Me.valueType = MsgPackType.Map
			End If
			Return Me.InnerAdd()
		End Function

		' Token: 0x0600008F RID: 143 RVA: 0x00002516 File Offset: 0x00000716
		Private Function InnerAddArrayChild() As MsgPack
			If Me.valueType <> MsgPackType.Array Then
				Me.Clear()
				Me.valueType = MsgPackType.Array
			End If
			Return Me.InnerAdd()
		End Function

		' Token: 0x06000090 RID: 144 RVA: 0x00002537 File Offset: 0x00000737
		Public Function AddArrayChild() As MsgPack
			Return Me.InnerAddArrayChild()
		End Function

		' Token: 0x06000091 RID: 145 RVA: 0x00004B1C File Offset: 0x00002D1C
		Private Sub WriteMap(ms As Stream)
			Dim count As Integer = Me.children.Count
			If count <= 15 Then
				Dim b As Byte = 128 + CByte(count)
				ms.WriteByte(b)
			ElseIf count <= 65535 Then
				Dim b As Byte = 222
				ms.WriteByte(b)
				Dim array As Byte() = BytesTools.SwapBytes(BitConverter.GetBytes(CShort(count)))
				ms.Write(array, 0, array.Length)
			Else
				Dim b As Byte = 223
				ms.WriteByte(b)
				Dim array As Byte() = BytesTools.SwapBytes(BitConverter.GetBytes(count))
				ms.Write(array, 0, array.Length)
			End If
			For i As Integer = 0 To count - 1
				WriteTools.WriteString(ms, Me.children(i).name)
				Me.children(i).Encode2Stream(ms)
			Next
		End Sub

		' Token: 0x06000092 RID: 146 RVA: 0x00004BE4 File Offset: 0x00002DE4
		Private Sub WirteArray(ms As Stream)
			Dim count As Integer = Me.children.Count
			If count <= 15 Then
				Dim b As Byte = 144 + CByte(count)
				ms.WriteByte(b)
			ElseIf count <= 65535 Then
				Dim b As Byte = 220
				ms.WriteByte(b)
				Dim array As Byte() = BytesTools.SwapBytes(BitConverter.GetBytes(CShort(count)))
				ms.Write(array, 0, array.Length)
			Else
				Dim b As Byte = 221
				ms.WriteByte(b)
				Dim array As Byte() = BytesTools.SwapBytes(BitConverter.GetBytes(count))
				ms.Write(array, 0, array.Length)
			End If
			For i As Integer = 0 To count - 1
				Me.children(i).Encode2Stream(ms)
			Next
		End Sub

		' Token: 0x06000093 RID: 147 RVA: 0x0000253F File Offset: 0x0000073F
		Public Sub SetAsInteger(value As Long)
			Me.innerValue = value
			Me.valueType = MsgPackType.[Integer]
		End Sub

		' Token: 0x06000094 RID: 148 RVA: 0x00002554 File Offset: 0x00000754
		Public Sub SetAsUInt64(value As ULong)
			Me.innerValue = value
			Me.valueType = MsgPackType.UInt64
		End Sub

		' Token: 0x06000095 RID: 149 RVA: 0x00004C98 File Offset: 0x00002E98
		Public Function GetAsUInt64() As ULong
			Select Case Me.valueType
				Case MsgPackType.[String]
					Return ULong.Parse(Me.innerValue.ToString().Trim())
				Case MsgPackType.[Integer]
					Return Convert.ToUInt64(CLng(Me.innerValue))
				Case MsgPackType.UInt64
					Return CULng(Me.innerValue)
				Case MsgPackType.Float
					Return Convert.ToUInt64(CDbl(Me.innerValue))
				Case MsgPackType.[Single]
					Return Convert.ToUInt64(CSng(Me.innerValue))
				Case MsgPackType.DateTime
					Return Convert.ToUInt64(CType(Me.innerValue, DateTime))
			End Select
			Return 0UL
		End Function

		' Token: 0x06000096 RID: 150 RVA: 0x00004D40 File Offset: 0x00002F40
		Public Function GetAsInteger() As Long
			Select Case Me.valueType
				Case MsgPackType.[String]
					Return Long.Parse(Me.innerValue.ToString().Trim())
				Case MsgPackType.[Integer]
					Return CLng(Me.innerValue)
				Case MsgPackType.UInt64
					Return Convert.ToInt64(CLng(Me.innerValue))
				Case MsgPackType.Float
					Return Convert.ToInt64(CDbl(Me.innerValue))
				Case MsgPackType.[Single]
					Return Convert.ToInt64(CSng(Me.innerValue))
				Case MsgPackType.DateTime
					Return Convert.ToInt64(CType(Me.innerValue, DateTime))
			End Select
			Return 0L
		End Function

		' Token: 0x06000097 RID: 151 RVA: 0x00004DE8 File Offset: 0x00002FE8
		Public Function GetAsFloat() As Double
			Select Case Me.valueType
				Case MsgPackType.[String]
					Return Double.Parse(CStr(Me.innerValue))
				Case MsgPackType.[Integer]
					Return Convert.ToDouble(CLng(Me.innerValue))
				Case MsgPackType.Float
					Return CDbl(Me.innerValue)
				Case MsgPackType.[Single]
					Return CDbl(CSng(Me.innerValue))
				Case MsgPackType.DateTime
					Return CDbl(Convert.ToInt64(CType(Me.innerValue, DateTime)))
			End Select
			Return 0.0
		End Function

		' Token: 0x06000098 RID: 152 RVA: 0x00002569 File Offset: 0x00000769
		Public Sub SetAsBytes(value As Byte())
			Me.innerValue = value
			Me.valueType = MsgPackType.Binary
		End Sub

		' Token: 0x06000099 RID: 153 RVA: 0x00004E7C File Offset: 0x0000307C
		Public Function GetAsBytes() As Byte()
			Select Case Me.valueType
				Case MsgPackType.[String]
					Return BytesTools.GetUtf8Bytes(Me.innerValue.ToString())
				Case MsgPackType.[Integer]
					Return BitConverter.GetBytes(CLng(Me.innerValue))
				Case MsgPackType.Float
					Return BitConverter.GetBytes(CDbl(Me.innerValue))
				Case MsgPackType.[Single]
					Return BitConverter.GetBytes(CSng(Me.innerValue))
				Case MsgPackType.DateTime
					Return BitConverter.GetBytes(CType(Me.innerValue, DateTime).ToBinary())
				Case MsgPackType.Binary
					Return CType(Me.innerValue, Byte())
			End Select
			Return New Byte(-1) {}
		End Function

		' Token: 0x0600009A RID: 154 RVA: 0x0000257A File Offset: 0x0000077A
		Public Sub Add(key As String, value As String)
			Dim msgPack As MsgPack = Me.InnerAddArrayChild()
			msgPack.name = key
			msgPack.SetAsString(value)
		End Sub

		' Token: 0x0600009B RID: 155 RVA: 0x0000258F File Offset: 0x0000078F
		Public Sub Add(key As String, value As Integer)
			Dim msgPack As MsgPack = Me.InnerAddArrayChild()
			msgPack.name = key
			msgPack.SetAsInteger(CLng(value))
		End Sub

		' Token: 0x0600009C RID: 156 RVA: 0x00004F2C File Offset: 0x0000312C
		Public Function LoadFileAsBytes(fileName As String) As Boolean
			If File.Exists(fileName) Then
				Dim fileStream As FileStream = New FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read)
				Dim array As Byte() = New Byte(fileStream.Length - 1) {}
				fileStream.Read(array, 0, CInt(fileStream.Length))
				fileStream.Close()
				fileStream.Dispose()
				Me.SetAsBytes(array)
				Return True
			End If
			Return False
		End Function

		' Token: 0x0600009D RID: 157 RVA: 0x00004F84 File Offset: 0x00003184
		Public Function SaveBytesToFile(fileName As String) As Boolean
			If Me.innerValue IsNot Nothing Then
				Dim fileStream As FileStream = New FileStream(fileName, FileMode.Append)
				fileStream.Write(CType(Me.innerValue, Byte()), 0, CType(Me.innerValue, Byte()).Length)
				fileStream.Close()
				fileStream.Dispose()
				Return True
			End If
			Return False
		End Function

		' Token: 0x0600009E RID: 158 RVA: 0x00004FD0 File Offset: 0x000031D0
		Public Function ForcePathObject(path As String) As MsgPack
			Dim msgPack As MsgPack = Me
			Dim array As String() = path.Trim().Split(New Char() { "."c, "/"c, "\"c })
			If array.Length = 0 Then
				Return Nothing
			End If
			Dim text As String
			If array.Length > 1 Then
				For i As Integer = 0 To array.Length - 1 - 1
					text = array(i)
					Dim msgPack2 As MsgPack = msgPack.FindObject(text)
					If msgPack2 Is Nothing Then
						msgPack = msgPack.InnerAddMapChild()
						msgPack.SetName(text)
					Else
						msgPack = msgPack2
					End If
				Next
			End If
			text = array(array.Length - 1)
			Dim num As Integer = msgPack.IndexOf(text)
			If num > -1 Then
				Return msgPack.children(num)
			End If
			msgPack = msgPack.InnerAddMapChild()
			msgPack.SetName(text)
			Return msgPack
		End Function

		' Token: 0x0600009F RID: 159 RVA: 0x000025A5 File Offset: 0x000007A5
		Public Sub SetAsNull()
			Me.Clear()
			Me.innerValue = Nothing
			Me.valueType = MsgPackType.Null
		End Sub

		' Token: 0x060000A0 RID: 160 RVA: 0x000025BB File Offset: 0x000007BB
		Public Sub SetAsString(value As String)
			Me.innerValue = value
			Me.valueType = MsgPackType.[String]
		End Sub

		' Token: 0x060000A1 RID: 161 RVA: 0x000025CB File Offset: 0x000007CB
		Public Function GetAsString() As String
			If Me.innerValue Is Nothing Then
				Return ""
			End If
			Return Me.innerValue.ToString()
		End Function

		' Token: 0x060000A2 RID: 162 RVA: 0x000025E9 File Offset: 0x000007E9
		Public Sub SetAsBoolean(bVal As Boolean)
			Me.valueType = MsgPackType.[Boolean]
			Me.innerValue = bVal
		End Sub

		' Token: 0x060000A3 RID: 163 RVA: 0x000025FE File Offset: 0x000007FE
		Public Sub SetAsSingle(fVal As Single)
			Me.valueType = MsgPackType.[Single]
			Me.innerValue = fVal
		End Sub

		' Token: 0x060000A4 RID: 164 RVA: 0x00002614 File Offset: 0x00000814
		Public Sub SetAsFloat(fVal As Double)
			Me.valueType = MsgPackType.Float
			Me.innerValue = fVal
		End Sub

		' Token: 0x060000A5 RID: 165 RVA: 0x0000508C File Offset: 0x0000328C
		Public Sub DecodeFromBytes(bytes As Byte())
			Using memoryStream As MemoryStream = New MemoryStream()
				bytes = Zip.Decompress(bytes)
				memoryStream.Write(bytes, 0, bytes.Length)
				memoryStream.Position = 0L
				Me.DecodeFromStream(memoryStream)
			End Using
		End Sub

		' Token: 0x060000A6 RID: 166 RVA: 0x000050E4 File Offset: 0x000032E4
		Public Sub DecodeFromFile(fileName As String)
			Dim fileStream As FileStream = New FileStream(fileName, FileMode.Open)
			Me.DecodeFromStream(fileStream)
			fileStream.Dispose()
		End Sub

		' Token: 0x060000A7 RID: 167 RVA: 0x00005108 File Offset: 0x00003308
		Public Sub DecodeFromStream(ms As Stream)
			Dim b As Byte = CByte(ms.ReadByte())
			If b <= 127 Then
				Me.SetAsInteger(CLng(CULng(b)))
				Return
			End If
			If b >= 128 AndAlso b <= 143 Then
				Me.Clear()
				Me.valueType = MsgPackType.Map
				Dim num As Integer = CInt((b - 128))
				For i As Integer = 0 To num - 1
					Dim msgPack As MsgPack = Me.InnerAdd()
					msgPack.SetName(ReadTools.ReadString(ms))
					msgPack.DecodeFromStream(ms)
				Next
				Return
			End If
			If b >= 144 AndAlso b <= 159 Then
				Me.Clear()
				Me.valueType = MsgPackType.Array
				Dim num As Integer = CInt((b - 144))
				For i As Integer = 0 To num - 1
					Me.InnerAdd().DecodeFromStream(ms)
				Next
				Return
			End If
			If b >= 160 AndAlso b <= 191 Then
				Dim num As Integer = CInt((b - 160))
				Me.SetAsString(ReadTools.ReadString(ms, num))
				Return
			End If
			If b >= 224 AndAlso b <= 255 Then
				Me.SetAsInteger(CLng(CSByte(b)))
				Return
			End If
			If b = 192 Then
				Me.SetAsNull()
				Return
			End If
			If b = 193 Then
				Throw New Exception("(never used) type $c1")
			End If
			If b = 194 Then
				Me.SetAsBoolean(False)
				Return
			End If
			If b = 195 Then
				Me.SetAsBoolean(True)
				Return
			End If
			If b = 196 Then
				Dim num As Integer = ms.ReadByte()
				Dim array As Byte() = New Byte(num - 1) {}
				ms.Read(array, 0, num)
				Me.SetAsBytes(array)
				Return
			End If
			If b = 197 Then
				Dim array As Byte() = New Byte(1) {}
				ms.Read(array, 0, 2)
				array = BytesTools.SwapBytes(array)
				Dim num As Integer = CInt(BitConverter.ToUInt16(array, 0))
				array = New Byte(num - 1) {}
				ms.Read(array, 0, num)
				Me.SetAsBytes(array)
				Return
			End If
			If b = 198 Then
				Dim array As Byte() = New Byte(3) {}
				ms.Read(array, 0, 4)
				array = BytesTools.SwapBytes(array)
				Dim num As Integer = BitConverter.ToInt32(array, 0)
				array = New Byte(num - 1) {}
				ms.Read(array, 0, num)
				Me.SetAsBytes(array)
				Return
			End If
			If b = 199 OrElse b = 200 OrElse b = 201 Then
				Throw New Exception("(ext8,ext16,ex32) type $c7,$c8,$c9")
			End If
			If b = 202 Then
				Dim array As Byte() = New Byte(3) {}
				ms.Read(array, 0, 4)
				array = BytesTools.SwapBytes(array)
				Me.SetAsSingle(BitConverter.ToSingle(array, 0))
				Return
			End If
			If b = 203 Then
				Dim array As Byte() = New Byte(7) {}
				ms.Read(array, 0, 8)
				array = BytesTools.SwapBytes(array)
				Me.SetAsFloat(BitConverter.ToDouble(array, 0))
				Return
			End If
			If b = 204 Then
				b = CByte(ms.ReadByte())
				Me.SetAsInteger(CLng(CULng(b)))
				Return
			End If
			If b = 205 Then
				Dim array As Byte() = New Byte(1) {}
				ms.Read(array, 0, 2)
				array = BytesTools.SwapBytes(array)
				Me.SetAsInteger(CLng(CULng(BitConverter.ToUInt16(array, 0))))
				Return
			End If
			If b = 206 Then
				Dim array As Byte() = New Byte(3) {}
				ms.Read(array, 0, 4)
				array = BytesTools.SwapBytes(array)
				Me.SetAsInteger(CLng(CULng(BitConverter.ToUInt32(array, 0))))
				Return
			End If
			If b = 207 Then
				Dim array As Byte() = New Byte(7) {}
				ms.Read(array, 0, 8)
				array = BytesTools.SwapBytes(array)
				Me.SetAsUInt64(BitConverter.ToUInt64(array, 0))
				Return
			End If
			If b = 220 Then
				Dim array As Byte() = New Byte(1) {}
				ms.Read(array, 0, 2)
				array = BytesTools.SwapBytes(array)
				Dim num As Integer = CInt(BitConverter.ToInt16(array, 0))
				Me.Clear()
				Me.valueType = MsgPackType.Array
				For i As Integer = 0 To num - 1
					Me.InnerAdd().DecodeFromStream(ms)
				Next
				Return
			End If
			If b = 221 Then
				Dim array As Byte() = New Byte(3) {}
				ms.Read(array, 0, 4)
				array = BytesTools.SwapBytes(array)
				Dim num As Integer = CInt(BitConverter.ToInt16(array, 0))
				Me.Clear()
				Me.valueType = MsgPackType.Array
				For i As Integer = 0 To num - 1
					Me.InnerAdd().DecodeFromStream(ms)
				Next
				Return
			End If
			If b = 217 Then
				Me.SetAsString(ReadTools.ReadString(b, ms))
				Return
			End If
			If b = 222 Then
				Dim array As Byte() = New Byte(1) {}
				ms.Read(array, 0, 2)
				array = BytesTools.SwapBytes(array)
				Dim num As Integer = CInt(BitConverter.ToInt16(array, 0))
				Me.Clear()
				Me.valueType = MsgPackType.Map
				For i As Integer = 0 To num - 1
					Dim msgPack2 As MsgPack = Me.InnerAdd()
					msgPack2.SetName(ReadTools.ReadString(ms))
					msgPack2.DecodeFromStream(ms)
				Next
				Return
			End If
			If b = 222 Then
				Dim array As Byte() = New Byte(1) {}
				ms.Read(array, 0, 2)
				array = BytesTools.SwapBytes(array)
				Dim num As Integer = CInt(BitConverter.ToInt16(array, 0))
				Me.Clear()
				Me.valueType = MsgPackType.Map
				For i As Integer = 0 To num - 1
					Dim msgPack3 As MsgPack = Me.InnerAdd()
					msgPack3.SetName(ReadTools.ReadString(ms))
					msgPack3.DecodeFromStream(ms)
				Next
				Return
			End If
			If b = 223 Then
				Dim array As Byte() = New Byte(3) {}
				ms.Read(array, 0, 4)
				array = BytesTools.SwapBytes(array)
				Dim num As Integer = BitConverter.ToInt32(array, 0)
				Me.Clear()
				Me.valueType = MsgPackType.Map
				For i As Integer = 0 To num - 1
					Dim msgPack4 As MsgPack = Me.InnerAdd()
					msgPack4.SetName(ReadTools.ReadString(ms))
					msgPack4.DecodeFromStream(ms)
				Next
				Return
			End If
			If b = 218 Then
				Me.SetAsString(ReadTools.ReadString(b, ms))
				Return
			End If
			If b = 219 Then
				Me.SetAsString(ReadTools.ReadString(b, ms))
				Return
			End If
			If b = 208 Then
				Me.SetAsInteger(CLng(CSByte(ms.ReadByte())))
				Return
			End If
			If b = 209 Then
				Dim array As Byte() = New Byte(1) {}
				ms.Read(array, 0, 2)
				array = BytesTools.SwapBytes(array)
				Me.SetAsInteger(CLng(BitConverter.ToInt16(array, 0)))
				Return
			End If
			If b = 210 Then
				Dim array As Byte() = New Byte(3) {}
				ms.Read(array, 0, 4)
				array = BytesTools.SwapBytes(array)
				Me.SetAsInteger(CLng(BitConverter.ToInt32(array, 0)))
				Return
			End If
			If b = 211 Then
				Dim array As Byte() = New Byte(7) {}
				ms.Read(array, 0, 8)
				array = BytesTools.SwapBytes(array)
				Me.SetAsInteger(BitConverter.ToInt64(array, 0))
			End If
		End Sub

		' Token: 0x060000A8 RID: 168 RVA: 0x0000571C File Offset: 0x0000391C
		Public Function Encode2Bytes() As Byte()
			Dim array2 As Byte()
			Using memoryStream As MemoryStream = New MemoryStream()
				Me.Encode2Stream(memoryStream)
				Dim array As Byte() = New Byte(memoryStream.Length - 1) {}
				memoryStream.Position = 0L
				memoryStream.Read(array, 0, CInt(memoryStream.Length))
				array2 = Zip.Compress(array)
			End Using
			Return array2
		End Function

		' Token: 0x060000A9 RID: 169 RVA: 0x00005788 File Offset: 0x00003988
		Public Sub Encode2Stream(ms As Stream)
			Select Case Me.valueType
				Case MsgPackType.Unknown, MsgPackType.Null
					WriteTools.WriteNull(ms)
					Return
				Case MsgPackType.Map
					Me.WriteMap(ms)
					Return
				Case MsgPackType.Array
					Me.WirteArray(ms)
					Return
				Case MsgPackType.[String]
					WriteTools.WriteString(ms, CStr(Me.innerValue))
					Return
				Case MsgPackType.[Integer]
					WriteTools.WriteInteger(ms, CLng(Me.innerValue))
					Return
				Case MsgPackType.UInt64
					WriteTools.WriteUInt64(ms, CULng(Me.innerValue))
					Return
				Case MsgPackType.[Boolean]
					WriteTools.WriteBoolean(ms, CBool(Me.innerValue))
					Return
				Case MsgPackType.Float
					WriteTools.WriteFloat(ms, CDbl(Me.innerValue))
					Return
				Case MsgPackType.[Single]
					WriteTools.WriteFloat(ms, CDbl(CSng(Me.innerValue)))
					Return
				Case MsgPackType.DateTime
					WriteTools.WriteInteger(ms, Me.GetAsInteger())
					Return
				Case MsgPackType.Binary
					WriteTools.WriteBinary(ms, CType(Me.innerValue, Byte()))
					Return
				Case Else
					WriteTools.WriteNull(ms)
					Return
			End Select
		End Sub

		' Token: 0x17000010 RID: 16
		' (get) Token: 0x060000AA RID: 170 RVA: 0x00002629 File Offset: 0x00000829
		' (set) Token: 0x060000AB RID: 171 RVA: 0x00002631 File Offset: 0x00000831
		Public Property AsString As String
			Get
				Return Me.GetAsString()
			End Get
			Set(value As String)
				Me.SetAsString(value)
			End Set
		End Property

		' Token: 0x17000011 RID: 17
		' (get) Token: 0x060000AC RID: 172 RVA: 0x0000263A File Offset: 0x0000083A
		' (set) Token: 0x060000AD RID: 173 RVA: 0x00002642 File Offset: 0x00000842
		Public Property AsInteger As Long
			Get
				Return Me.GetAsInteger()
			End Get
			Set(value As Long)
				Me.SetAsInteger(value)
			End Set
		End Property

		' Token: 0x17000012 RID: 18
		' (get) Token: 0x060000AE RID: 174 RVA: 0x0000264B File Offset: 0x0000084B
		' (set) Token: 0x060000AF RID: 175 RVA: 0x00002653 File Offset: 0x00000853
		Public Property AsFloat As Double
			Get
				Return Me.GetAsFloat()
			End Get
			Set(value As Double)
				Me.SetAsFloat(value)
			End Set
		End Property

		' Token: 0x17000013 RID: 19
		' (get) Token: 0x060000B0 RID: 176 RVA: 0x00005880 File Offset: 0x00003A80
		Public ReadOnly Property AsArray As MsgPackArray
			Get
				SyncLock Me
					If Me.refAsArray Is Nothing Then
						Me.refAsArray = New MsgPackArray(Me, Me.children)
					End If
				End SyncLock
				Return Me.refAsArray
			End Get
		End Property

		' Token: 0x17000014 RID: 20
		' (get) Token: 0x060000B1 RID: 177 RVA: 0x0000265C File Offset: 0x0000085C
		Public ReadOnly Property ValueType As MsgPackType
			Get
				Return Me.valueType
			End Get
		End Property

		' Token: 0x060000B2 RID: 178 RVA: 0x00002664 File Offset: 0x00000864
		Function GetEnumerator() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return New MsgPackEnum(Me.children)
		End Function

		' Token: 0x04000047 RID: 71
		Private name As String

		' Token: 0x04000048 RID: 72
		Private lowerName As String

		' Token: 0x04000049 RID: 73
		Private innerValue As Object

		' Token: 0x0400004A RID: 74
		Private valueType As MsgPackType

		' Token: 0x0400004B RID: 75
		Private parent As MsgPack

		' Token: 0x0400004C RID: 76
		Private children As List(Of MsgPack) = New List(Of MsgPack)()

		' Token: 0x0400004D RID: 77
		Private refAsArray As MsgPackArray
	End Class
End Namespace
