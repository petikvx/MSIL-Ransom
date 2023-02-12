Imports System
Imports System.IO
Imports System.Text
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Main.Tools
	' Token: 0x02000057 RID: 87
	Public Class SQLiteHandler
		' Token: 0x060001C8 RID: 456 RVA: 0x0000FC3C File Offset: 0x0000DE3C
		Public Sub New(baseName As String)
			If File.Exists(baseName) Then
				FileSystem.FileOpen(1, baseName, OpenMode.Binary, OpenAccess.Read, OpenShare.[Shared], -1)
				Dim text As String = Strings.Space(CInt(FileSystem.LOF(1)))
				FileSystem.FileGet(1, text, -1L, False)
				FileSystem.FileClose(New Integer() { 1 })
				Me.db_bytes = Encoding.[Default].GetBytes(text)
				If Encoding.[Default].GetString(Me.db_bytes, 0, 15).CompareTo("SQLite format 3") <> 0 Then
					Throw New Exception("Not a valid SQLite 3 Database File")
				End If
				If Me.db_bytes(52) > 0 Then
					Throw New Exception("Auto-vacuum capable database is not supported")
				End If
				Me.page_size = CUShort(Me.ConvertToInteger(16, 2))
				Me.encoding = Me.ConvertToInteger(56, 4)
				If Decimal.Compare(New Decimal(Me.encoding), 0D) = 0 Then
					Me.encoding = 1UL
				End If
				Me.ReadMasterTable(100UL)
			End If
		End Sub

		' Token: 0x060001C9 RID: 457 RVA: 0x0000FD5C File Offset: 0x0000DF5C
		Private Function ConvertToInteger(startIndex As Integer, Size As Integer) As ULong
			Dim num As ULong
			If(Size > 8) Or (Size = 0) Then
				num = 0UL
			Else
				Dim num2 As ULong = 0UL
				Dim num3 As Integer = Size - 1
				For i As Integer = 0 To num3
					num2 = (num2 << 8) Or CULng(Me.db_bytes(startIndex + i))
				Next
				num = num2
			End If
			Return num
		End Function

		' Token: 0x060001CA RID: 458 RVA: 0x0000FDB8 File Offset: 0x0000DFB8
		Private Function CVL(startIndex As Integer, endIndex As Integer) As Long
			endIndex += 1
			Dim array As Byte() = New Byte(7) {}
			Dim num As Integer = endIndex - startIndex
			Dim flag As Boolean = False
			Dim num2 As Long
			If(num = 0) Or (num > 9) Then
				num2 = 0L
			ElseIf num = 1 Then
				array(0) = Me.db_bytes(startIndex) And 127
				num2 = BitConverter.ToInt64(array, 0)
			Else
				If num = 9 Then
					flag = True
				End If
				Dim num3 As Integer = 1
				Dim num4 As Integer = 7
				Dim num5 As Integer = 0
				If flag Then
					array(0) = Me.db_bytes(endIndex - 1)
					endIndex -= 1
					num5 = 1
				End If
				For i As Integer = endIndex - 1 To startIndex Step -1
					If i - 1 >= startIndex Then
						array(num5) = CByte(((CInt(CByte((Me.db_bytes(i) >> ((num3 - 1) And 7)))) And (255 >> num3)) Or CInt(CByte((Me.db_bytes(i - 1) << (num4 And 7))))))
						num3 += 1
						num5 += 1
						num4 -= 1
					ElseIf Not flag Then
						array(num5) = CByte((CInt(CByte((Me.db_bytes(i) >> ((num3 - 1) And 7)))) And (255 >> num3)))
					End If
				Next
				num2 = BitConverter.ToInt64(array, 0)
			End If
			Return num2
		End Function

		' Token: 0x060001CB RID: 459 RVA: 0x0000FEEC File Offset: 0x0000E0EC
		Public Function GetRowCount() As Integer
			Return Me.table_entries.Length
		End Function

		' Token: 0x060001CC RID: 460 RVA: 0x0000FF04 File Offset: 0x0000E104
		Public Function GetTableNames() As String()
			Dim array As String() = Nothing
			Dim num As Integer = 0
			Dim num2 As Integer = Me.master_table_entries.Length - 1
			For i As Integer = 0 To num2
				If Me.master_table_entries(i).item_type = "table" Then
					array = CType(Utils.CopyArray(array, New String(num + 1 - 1) {}), String())
					array(num) = Me.master_table_entries(i).item_name
					num += 1
				End If
			Next
			Return array
		End Function

		' Token: 0x060001CD RID: 461 RVA: 0x0000FF80 File Offset: 0x0000E180
		Public Function GetValue(row_num As Integer, field As Integer) As String
			Dim text As String
			If row_num >= Me.table_entries.Length Then
				text = Nothing
			ElseIf field >= Me.table_entries(row_num).content.Length Then
				text = Nothing
			Else
				text = Me.table_entries(row_num).content(field)
			End If
			Return text
		End Function

		' Token: 0x060001CE RID: 462 RVA: 0x0000FFD8 File Offset: 0x0000E1D8
		Public Function GetValue(row_num As Integer, field As String) As String
			Dim num As Integer = -1
			Dim num2 As Integer = Me.field_names.Length - 1
			For i As Integer = 0 To num2
				If Me.field_names(i).ToLower().CompareTo(field.ToLower()) = 0 Then
					num = i
					IL_3F:
					Dim text As String
					If num = -1 Then
						text = Nothing
					Else
						text = Me.GetValue(row_num, num)
					End If
					Return text
				End If
			Next
			GoTo IL_3F
		End Function

		' Token: 0x060001CF RID: 463 RVA: 0x0001003C File Offset: 0x0000E23C
		Private Function GVL(startIndex As Integer) As Integer
			Dim num As Integer
			If startIndex > Me.db_bytes.Length Then
				num = 0
			Else
				Dim num2 As Integer = startIndex + 8
				For i As Integer = startIndex To num2
					If i > Me.db_bytes.Length - 1 Then
						Return 0
					End If
					If(Me.db_bytes(i) And 128) <> 128 Then
						Return i
					End If
				Next
				num = startIndex + 8
			End If
			Return num
		End Function

		' Token: 0x060001D0 RID: 464 RVA: 0x000100A8 File Offset: 0x0000E2A8
		Private Function IsOdd(value As Long) As Boolean
			Return(value And 1L) = 1L
		End Function

		' Token: 0x060001D1 RID: 465 RVA: 0x000100CC File Offset: 0x0000E2CC
		Private Sub ReadMasterTable(Offset As ULong)
			If Me.db_bytes(CInt(Offset)) = 13 Then
				Dim num As UShort = Convert.ToUInt16(Decimal.Subtract(New Decimal(Me.ConvertToInteger(Convert.ToInt32(Decimal.Add(New Decimal(Offset), 3D)), 2)), 1D))
				Dim num2 As Integer = 0
				If Me.master_table_entries IsNot Nothing Then
					num2 = Me.master_table_entries.Length
					Me.master_table_entries = CType(Utils.CopyArray(Me.master_table_entries, New SQLiteHandler.sqlite_master_entry(Me.master_table_entries.Length + CInt(num) + 1 - 1) {}), SQLiteHandler.sqlite_master_entry())
				Else
					Me.master_table_entries = New SQLiteHandler.sqlite_master_entry(CInt((num + 1US)) - 1) {}
				End If
				Dim num3 As Integer = CInt(num)
				For i As Integer = 0 To num3
					Dim num4 As ULong = Me.ConvertToInteger(Convert.ToInt32(Decimal.Add(Decimal.Add(New Decimal(Offset), 8D), New Decimal(i * 2))), 2)
					If Decimal.Compare(New Decimal(Offset), 100D) <> 0 Then
						num4 += Offset
					End If
					Dim num5 As Integer = Me.GVL(CInt(num4))
					Me.CVL(CInt(num4), num5)
					Dim num6 As Integer = Me.GVL(Convert.ToInt32(Decimal.Add(Decimal.Add(New Decimal(num4), Decimal.Subtract(New Decimal(num5), New Decimal(num4))), 1D)))
					Me.master_table_entries(num2 + i).row_id = Me.CVL(Convert.ToInt32(Decimal.Add(Decimal.Add(New Decimal(num4), Decimal.Subtract(New Decimal(num5), New Decimal(num4))), 1D)), num6)
					num4 = Convert.ToUInt64(Decimal.Add(Decimal.Add(New Decimal(num4), Decimal.Subtract(New Decimal(num6), New Decimal(num4))), 1D))
					num5 = Me.GVL(CInt(num4))
					num6 = num5
					Dim num7 As Long = Me.CVL(CInt(num4), num5)
					Dim array As Long() = New Long(4) {}
					Dim num8 As Integer = 0
					Do
						num5 = num6 + 1
						num6 = Me.GVL(num5)
						array(num8) = Me.CVL(num5, num6)
						If array(num8) > 9L Then
							If Me.IsOdd(array(num8)) Then
								array(num8) = CLng(Math.Round(CDbl((array(num8) - 13L)) / 2.0))
							Else
								array(num8) = CLng(Math.Round(CDbl((array(num8) - 12L)) / 2.0))
							End If
						Else
							array(num8) = CLng(CULng(Me.SQLDataTypeSize(CInt(array(num8)))))
						End If
						num8 += 1
					Loop While num8 <= 4
					If Decimal.Compare(New Decimal(Me.encoding), 1D) = 0 Then
						Me.master_table_entries(num2 + i).item_type = Encoding.[Default].GetString(Me.db_bytes, Convert.ToInt32(Decimal.Add(New Decimal(num4), New Decimal(num7))), CInt(array(0)))
					ElseIf Decimal.Compare(New Decimal(Me.encoding), 2D) = 0 Then
						Me.master_table_entries(num2 + i).item_type = Encoding.Unicode.GetString(Me.db_bytes, Convert.ToInt32(Decimal.Add(New Decimal(num4), New Decimal(num7))), CInt(array(0)))
					ElseIf Decimal.Compare(New Decimal(Me.encoding), 3D) = 0 Then
						Me.master_table_entries(num2 + i).item_type = Encoding.BigEndianUnicode.GetString(Me.db_bytes, Convert.ToInt32(Decimal.Add(New Decimal(num4), New Decimal(num7))), CInt(array(0)))
					End If
					If Decimal.Compare(New Decimal(Me.encoding), 1D) = 0 Then
						Me.master_table_entries(num2 + i).item_name = Encoding.[Default].GetString(Me.db_bytes, Convert.ToInt32(Decimal.Add(Decimal.Add(New Decimal(num4), New Decimal(num7)), New Decimal(array(0)))), CInt(array(1)))
					ElseIf Decimal.Compare(New Decimal(Me.encoding), 2D) = 0 Then
						Me.master_table_entries(num2 + i).item_name = Encoding.Unicode.GetString(Me.db_bytes, Convert.ToInt32(Decimal.Add(Decimal.Add(New Decimal(num4), New Decimal(num7)), New Decimal(array(0)))), CInt(array(1)))
					ElseIf Decimal.Compare(New Decimal(Me.encoding), 3D) = 0 Then
						Me.master_table_entries(num2 + i).item_name = Encoding.BigEndianUnicode.GetString(Me.db_bytes, Convert.ToInt32(Decimal.Add(Decimal.Add(New Decimal(num4), New Decimal(num7)), New Decimal(array(0)))), CInt(array(1)))
					End If
					Me.master_table_entries(num2 + i).root_num = CLng(Me.ConvertToInteger(Convert.ToInt32(Decimal.Add(Decimal.Add(Decimal.Add(Decimal.Add(New Decimal(num4), New Decimal(num7)), New Decimal(array(0))), New Decimal(array(1))), New Decimal(array(2)))), CInt(array(3))))
					If Decimal.Compare(New Decimal(Me.encoding), 1D) = 0 Then
						Me.master_table_entries(num2 + i).sql_statement = Encoding.[Default].GetString(Me.db_bytes, Convert.ToInt32(Decimal.Add(Decimal.Add(Decimal.Add(Decimal.Add(Decimal.Add(New Decimal(num4), New Decimal(num7)), New Decimal(array(0))), New Decimal(array(1))), New Decimal(array(2))), New Decimal(array(3)))), CInt(array(4)))
					ElseIf Decimal.Compare(New Decimal(Me.encoding), 2D) = 0 Then
						Me.master_table_entries(num2 + i).sql_statement = Encoding.Unicode.GetString(Me.db_bytes, Convert.ToInt32(Decimal.Add(Decimal.Add(Decimal.Add(Decimal.Add(Decimal.Add(New Decimal(num4), New Decimal(num7)), New Decimal(array(0))), New Decimal(array(1))), New Decimal(array(2))), New Decimal(array(3)))), CInt(array(4)))
					ElseIf Decimal.Compare(New Decimal(Me.encoding), 3D) = 0 Then
						Me.master_table_entries(num2 + i).sql_statement = Encoding.BigEndianUnicode.GetString(Me.db_bytes, Convert.ToInt32(Decimal.Add(Decimal.Add(Decimal.Add(Decimal.Add(Decimal.Add(New Decimal(num4), New Decimal(num7)), New Decimal(array(0))), New Decimal(array(1))), New Decimal(array(2))), New Decimal(array(3)))), CInt(array(4)))
					End If
				Next
			ElseIf Me.db_bytes(CInt(Offset)) = 5 Then
				Dim num9 As UShort = Convert.ToUInt16(Decimal.Subtract(New Decimal(Me.ConvertToInteger(Convert.ToInt32(Decimal.Add(New Decimal(Offset), 3D)), 2)), 1D))
				Dim num10 As Integer = CInt(num9)
				For j As Integer = 0 To num10
					Dim num11 As UShort = CUShort(Me.ConvertToInteger(Convert.ToInt32(Decimal.Add(Decimal.Add(New Decimal(Offset), 12D), New Decimal(j * 2))), 2))
					If Decimal.Compare(New Decimal(Offset), 100D) = 0 Then
						Me.ReadMasterTable(Convert.ToUInt64(Decimal.Multiply(Decimal.Subtract(New Decimal(Me.ConvertToInteger(CInt(num11), 4)), 1D), New Decimal(CInt(Me.page_size)))))
					Else
						Me.ReadMasterTable(Convert.ToUInt64(Decimal.Multiply(Decimal.Subtract(New Decimal(Me.ConvertToInteger(CInt((Offset + CULng(num11))), 4)), 1D), New Decimal(CInt(Me.page_size)))))
					End If
				Next
				Me.ReadMasterTable(Convert.ToUInt64(Decimal.Multiply(Decimal.Subtract(New Decimal(Me.ConvertToInteger(Convert.ToInt32(Decimal.Add(New Decimal(Offset), 8D)), 4)), 1D), New Decimal(CInt(Me.page_size)))))
			End If
		End Sub

		' Token: 0x060001D2 RID: 466 RVA: 0x00010968 File Offset: 0x0000EB68
		Public Function ReadTable(TableName As String) As Boolean
			Dim num As Integer = -1
			Dim num2 As Integer = Me.master_table_entries.Length - 1
			For i As Integer = 0 To num2
				If Me.master_table_entries(i).item_name.ToLower().CompareTo(TableName.ToLower()) = 0 Then
					num = i
					IL_4E:
					Dim flag As Boolean
					If num = -1 Then
						flag = False
					Else
						Dim array As String() = Me.master_table_entries(num).sql_statement.Substring(Me.master_table_entries(num).sql_statement.IndexOf("(") + 1).Split(New Char() { ","c })
						Dim num3 As Integer = array.Length - 1
						For j As Integer = 0 To num3
							array(j) = array(j).TrimStart(New Char(-1) {})
							Dim num4 As Integer = array(j).IndexOf(" ")
							If num4 > 0 Then
								array(j) = array(j).Substring(0, num4)
							End If
							If array(j).IndexOf("UNIQUE") = 0 Then
								Exit For
							End If
							Me.field_names = CType(Utils.CopyArray(Me.field_names, New String(j + 1 - 1) {}), String())
							Me.field_names(j) = array(j)
						Next
						flag = Me.ReadTableFromOffset(CULng(((Me.master_table_entries(num).root_num - 1L) * CLng(CULng(Me.page_size)))))
					End If
					Return flag
				End If
			Next
			GoTo IL_4E
		End Function

		' Token: 0x060001D3 RID: 467 RVA: 0x00010ADC File Offset: 0x0000ECDC
		Private Function ReadTableFromOffset(Offset As ULong) As Boolean
			If Me.db_bytes(CInt(Offset)) = 13 Then
				Dim num As Integer = Convert.ToInt32(Decimal.Subtract(New Decimal(Me.ConvertToInteger(Convert.ToInt32(Decimal.Add(New Decimal(Offset), 3D)), 2)), 1D))
				Dim num2 As Integer = 0
				If Me.table_entries IsNot Nothing Then
					num2 = Me.table_entries.Length
					Me.table_entries = CType(Utils.CopyArray(Me.table_entries, New SQLiteHandler.table_entry(Me.table_entries.Length + num + 1 - 1) {}), SQLiteHandler.table_entry())
				Else
					Me.table_entries = New SQLiteHandler.table_entry(num + 1 - 1) {}
				End If
				Dim num3 As Integer = num
				For i As Integer = 0 To num3
					Dim array As SQLiteHandler.record_header_field() = Nothing
					Dim num4 As ULong = Me.ConvertToInteger(Convert.ToInt32(Decimal.Add(Decimal.Add(New Decimal(Offset), 8D), New Decimal(i * 2))), 2)
					If Decimal.Compare(New Decimal(Offset), 100D) <> 0 Then
						num4 += Offset
					End If
					Dim num5 As Integer = Me.GVL(CInt(num4))
					Me.CVL(CInt(num4), num5)
					Dim num6 As Integer = Me.GVL(Convert.ToInt32(Decimal.Add(Decimal.Add(New Decimal(num4), Decimal.Subtract(New Decimal(num5), New Decimal(num4))), 1D)))
					Me.table_entries(num2 + i).row_id = Me.CVL(Convert.ToInt32(Decimal.Add(Decimal.Add(New Decimal(num4), Decimal.Subtract(New Decimal(num5), New Decimal(num4))), 1D)), num6)
					num4 = Convert.ToUInt64(Decimal.Add(Decimal.Add(New Decimal(num4), Decimal.Subtract(New Decimal(num6), New Decimal(num4))), 1D))
					num5 = Me.GVL(CInt(num4))
					num6 = num5
					Dim num7 As Long = Me.CVL(CInt(num4), num5)
					Dim num8 As Long = Convert.ToInt64(Decimal.Add(Decimal.Subtract(New Decimal(num4), New Decimal(num5)), 1D))
					Dim num9 As Integer = 0
					While num8 < num7
						array = CType(Utils.CopyArray(array, New SQLiteHandler.record_header_field(num9 + 1 - 1) {}), SQLiteHandler.record_header_field())
						num5 = num6 + 1
						num6 = Me.GVL(num5)
						array(num9).type = Me.CVL(num5, num6)
						If array(num9).type > 9L Then
							If Me.IsOdd(array(num9).type) Then
								array(num9).size = CLng(Math.Round(CDbl((array(num9).type - 13L)) / 2.0))
							Else
								array(num9).size = CLng(Math.Round(CDbl((array(num9).type - 12L)) / 2.0))
							End If
						Else
							array(num9).size = CLng(CULng(Me.SQLDataTypeSize(CInt(array(num9).type))))
						End If
						num8 = num8 + CLng((num6 - num5)) + 1L
						num9 += 1
					End While
					Me.table_entries(num2 + i).content = New String(array.Length - 1 + 1 - 1) {}
					Dim num10 As Integer = 0
					Dim num11 As Integer = array.Length - 1
					For j As Integer = 0 To num11
						If array(j).type > 9L Then
							If Not Me.IsOdd(array(j).type) Then
								If Decimal.Compare(New Decimal(Me.encoding), 1D) = 0 Then
									Me.table_entries(num2 + i).content(j) = Encoding.[Default].GetString(Me.db_bytes, Convert.ToInt32(Decimal.Add(Decimal.Add(New Decimal(num4), New Decimal(num7)), New Decimal(num10))), CInt(array(j).size))
								ElseIf Decimal.Compare(New Decimal(Me.encoding), 2D) = 0 Then
									Me.table_entries(num2 + i).content(j) = Encoding.Unicode.GetString(Me.db_bytes, Convert.ToInt32(Decimal.Add(Decimal.Add(New Decimal(num4), New Decimal(num7)), New Decimal(num10))), CInt(array(j).size))
								ElseIf Decimal.Compare(New Decimal(Me.encoding), 3D) = 0 Then
									Me.table_entries(num2 + i).content(j) = Encoding.BigEndianUnicode.GetString(Me.db_bytes, Convert.ToInt32(Decimal.Add(Decimal.Add(New Decimal(num4), New Decimal(num7)), New Decimal(num10))), CInt(array(j).size))
								End If
							Else
								Me.table_entries(num2 + i).content(j) = Encoding.[Default].GetString(Me.db_bytes, Convert.ToInt32(Decimal.Add(Decimal.Add(New Decimal(num4), New Decimal(num7)), New Decimal(num10))), CInt(array(j).size))
							End If
						Else
							Me.table_entries(num2 + i).content(j) = Conversions.ToString(Me.ConvertToInteger(Convert.ToInt32(Decimal.Add(Decimal.Add(New Decimal(num4), New Decimal(num7)), New Decimal(num10))), CInt(array(j).size)))
						End If
						num10 += CInt(array(j).size)
					Next
				Next
			ElseIf Me.db_bytes(CInt(Offset)) = 5 Then
				Dim num12 As UShort = Convert.ToUInt16(Decimal.Subtract(New Decimal(Me.ConvertToInteger(Convert.ToInt32(Decimal.Add(New Decimal(Offset), 3D)), 2)), 1D))
				Dim num13 As Integer = CInt(num12)
				For k As Integer = 0 To num13
					Dim num14 As UShort = CUShort(Me.ConvertToInteger(Convert.ToInt32(Decimal.Add(Decimal.Add(New Decimal(Offset), 12D), New Decimal(k * 2))), 2))
					Me.ReadTableFromOffset(Convert.ToUInt64(Decimal.Multiply(Decimal.Subtract(New Decimal(Me.ConvertToInteger(CInt((Offset + CULng(num14))), 4)), 1D), New Decimal(CInt(Me.page_size)))))
				Next
				Me.ReadTableFromOffset(Convert.ToUInt64(Decimal.Multiply(Decimal.Subtract(New Decimal(Me.ConvertToInteger(Convert.ToInt32(Decimal.Add(New Decimal(Offset), 8D)), 4)), 1D), New Decimal(CInt(Me.page_size)))))
			End If
			Return True
		End Function

		' Token: 0x04000190 RID: 400
		Private db_bytes As Byte()

		' Token: 0x04000191 RID: 401
		Private encoding As ULong

		' Token: 0x04000192 RID: 402
		Private field_names As String()

		' Token: 0x04000193 RID: 403
		Private master_table_entries As SQLiteHandler.sqlite_master_entry()

		' Token: 0x04000194 RID: 404
		Private page_size As UShort

		' Token: 0x04000195 RID: 405
		Private SQLDataTypeSize As Byte() = New Byte() { 0, 1, 2, 3, 4, 6, 8, 8, 0, 0 }

		' Token: 0x04000196 RID: 406
		Private table_entries As SQLiteHandler.table_entry()

		' Token: 0x02000058 RID: 88
		Private Structure record_header_field
			' Token: 0x04000197 RID: 407
			Public size As Long

			' Token: 0x04000198 RID: 408
			Public type As Long
		End Structure

		' Token: 0x02000059 RID: 89
		Private Structure sqlite_master_entry
			' Token: 0x04000199 RID: 409
			Public row_id As Long

			' Token: 0x0400019A RID: 410
			Public item_type As String

			' Token: 0x0400019B RID: 411
			Public item_name As String

			' Token: 0x0400019C RID: 412
			Public astable_name As String

			' Token: 0x0400019D RID: 413
			Public root_num As Long

			' Token: 0x0400019E RID: 414
			Public sql_statement As String
		End Structure

		' Token: 0x0200005A RID: 90
		Private Structure table_entry
			' Token: 0x0400019F RID: 415
			Public row_id As Long

			' Token: 0x040001A0 RID: 416
			Public content As String()
		End Structure
	End Class
End Namespace
