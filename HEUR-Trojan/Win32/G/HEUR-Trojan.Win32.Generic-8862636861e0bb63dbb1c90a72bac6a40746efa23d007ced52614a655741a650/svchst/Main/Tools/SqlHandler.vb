Imports System
Imports System.IO
Imports System.Text

Namespace Main.Tools
	' Token: 0x02000024 RID: 36
	Friend Class SqlHandler
		' Token: 0x060000CF RID: 207 RVA: 0x00008484 File Offset: 0x00006684
		Public Sub New(fileName As String)
			Me._fileBytes = File.ReadAllBytes(fileName)
			Me._pageSize = Me.ConvertToULong(16, 2)
			Me._dbEncoding = Me.ConvertToULong(56, 4)
			Me.ReadMasterTable(100L)
		End Sub

		' Token: 0x060000D0 RID: 208 RVA: 0x000084E8 File Offset: 0x000066E8
		Public Function GetValue(rowNum As Integer, field As Integer) As String
			Dim text As String
			Try
				If rowNum >= Me._tableEntries.Length Then
					text = Nothing
				Else
					text = If((field >= Me._tableEntries(rowNum).Content.Length), Nothing, Me._tableEntries(rowNum).Content(field))
				End If
			Catch
				text = Nothing
			End Try
			Return text
		End Function

		' Token: 0x060000D1 RID: 209 RVA: 0x00008550 File Offset: 0x00006750
		Public Function GetRowCount() As Integer
			Return Me._tableEntries.Length
		End Function

		' Token: 0x060000D2 RID: 210 RVA: 0x00008568 File Offset: 0x00006768
		Private Function ReadTableFromOffset(offset As ULong) As Boolean
			Dim flag As Boolean
			Try
				' The following expression was wrapped in a checked-expression
				' The following expression was wrapped in a checked-expression
				If Me._fileBytes(CInt((CType(offset, IntPtr)))) = 13 Then
					Dim num As UShort = CUShort((Me.ConvertToULong(CInt(offset) + 3, 2) - 1UL))
					Dim num2 As Integer = 0
					If Me._tableEntries IsNot Nothing Then
						num2 = Me._tableEntries.Length
						Array.Resize(Of SqlHandler.TableEntry)(Me._tableEntries, Me._tableEntries.Length + CInt(num) + 1)
					Else
						Me._tableEntries = New SqlHandler.TableEntry(CInt((num + 1US)) - 1) {}
					End If
					For num3 As UShort = 0US To num
						Dim num4 As ULong = Me.ConvertToULong(CInt(offset) + 8 + CInt((num3 * 2US)), 2)
						If offset <> 100UL Then
							num4 += offset
						End If
						Dim num5 As Integer = Me.Gvl(CInt(num4))
						Me.Cvl(CInt(num4), num5)
						Dim num6 As Integer = Me.Gvl(CInt((num4 + CULng((CLng(num5) - CLng(num4))) + 1UL)))
						Me.Cvl(CInt((num4 + CULng((CLng(num5) - CLng(num4))) + 1UL)), num6)
						Dim num7 As ULong = num4 + CULng((CLng(num6) - CLng(num4) + 1L))
						Dim num8 As Integer = Me.Gvl(CInt(num7))
						Dim num9 As Integer = num8
						Dim num10 As Long = Me.Cvl(CInt(num7), num8)
						Dim array As SqlHandler.RecordHeaderField() = Nothing
						Dim num11 As Long = CLng((num7 - CULng(CLng(num8)) + 1UL))
						Dim num12 As Integer = 0
						While num11 < num10
							Array.Resize(Of SqlHandler.RecordHeaderField)(array, num12 + 1)
							Dim num13 As Integer = num9 + 1
							num9 = Me.Gvl(num13)
							array(num12).Type = Me.Cvl(num13, num9)
							array(num12).Size = CLng(If((array(num12).Type <= 9L), CULng(Me._sqlDataTypeSize(CInt((CType(array(num12).Type, IntPtr))))), CULng(If((Not SqlHandler.IsOdd(array(num12).Type)), ((array(num12).Type - 12L) / 2L), ((array(num12).Type - 13L) / 2L)))))
							num11 = num11 + CLng((num9 - num13)) + 1L
							num12 += 1
						End While
						If array IsNot Nothing Then
							Me._tableEntries(num2 + CInt(num3)).Content = New String(array.Length - 1) {}
							Dim num14 As Integer = 0
							For i As Integer = 0 To array.Length - 1
								If array(i).Type > 9L Then
									If Not SqlHandler.IsOdd(array(i).Type) Then
										If Me._dbEncoding = 1UL Then
											Me._tableEntries(num2 + CInt(num3)).Content(i) = Encoding.[Default].GetString(Me._fileBytes, CInt((num7 + CULng(num10) + CULng(CLng(num14)))), CInt(array(i).Size))
										ElseIf Me._dbEncoding = 2UL Then
											Me._tableEntries(num2 + CInt(num3)).Content(i) = Encoding.Unicode.GetString(Me._fileBytes, CInt((num7 + CULng(num10) + CULng(CLng(num14)))), CInt(array(i).Size))
										ElseIf Me._dbEncoding = 3UL Then
											Me._tableEntries(num2 + CInt(num3)).Content(i) = Encoding.BigEndianUnicode.GetString(Me._fileBytes, CInt((num7 + CULng(num10) + CULng(CLng(num14)))), CInt(array(i).Size))
										End If
									Else
										Me._tableEntries(num2 + CInt(num3)).Content(i) = Encoding.[Default].GetString(Me._fileBytes, CInt((num7 + CULng(num10) + CULng(CLng(num14)))), CInt(array(i).Size))
									End If
								Else
									Me._tableEntries(num2 + CInt(num3)).Content(i) = Convert.ToString(Me.ConvertToULong(CInt((num7 + CULng(num10) + CULng(CLng(num14)))), CInt(array(i).Size)))
								End If
								num14 += CInt(array(i).Size)
							Next
						End If
					Next
				ElseIf Me._fileBytes(CInt((CType(offset, IntPtr)))) = 5 Then
					Dim num15 As UShort = CUShort((Me.ConvertToULong(CInt((offset + 3UL)), 2) - 1UL))
					For num16 As UShort = 0US To num15
						Dim num17 As UShort = CUShort(Me.ConvertToULong(CInt(offset) + 12 + CInt((num16 * 2US)), 2))
						Me.ReadTableFromOffset((Me.ConvertToULong(CInt((offset + CULng(num17))), 4) - 1UL) * Me._pageSize)
					Next
					Me.ReadTableFromOffset((Me.ConvertToULong(CInt((offset + 8UL)), 4) - 1UL) * Me._pageSize)
				End If
				flag = True
			Catch
				flag = False
			End Try
			Return flag
		End Function

		' Token: 0x060000D3 RID: 211 RVA: 0x00008AAC File Offset: 0x00006CAC
		Private Sub ReadMasterTable(offset As Long)
			Try
				' The following expression was wrapped in a checked-expression
				Dim b As Byte = Me._fileBytes(CInt((CType(offset, IntPtr))))
				Dim b2 As Byte = b
				If b2 <> 5 Then
					If b2 = 13 Then
						Dim num As ULong = Me.ConvertToULong(CInt(offset) + 3, 2) - 1UL
						Dim num2 As Integer = 0
						If Me._masterTableEntries IsNot Nothing Then
							num2 = Me._masterTableEntries.Length
							Array.Resize(Of SqlHandler.SqliteMasterEntry)(Me._masterTableEntries, Me._masterTableEntries.Length + CInt(num) + 1)
						Else
							Me._masterTableEntries = New SqlHandler.SqliteMasterEntry(num + 1UL - 1) {}
						End If
						For num3 As ULong = 0UL To num
							Dim num4 As ULong = Me.ConvertToULong(CInt(offset) + 8 + CInt(num3) * 2, 2)
							If offset <> 100L Then
								num4 += CULng(offset)
							End If
							Dim num5 As Integer = Me.Gvl(CInt(num4))
							Me.Cvl(CInt(num4), num5)
							Dim num6 As Integer = Me.Gvl(CInt((num4 + CULng((CLng(num5) - CLng(num4))) + 1UL)))
							Me.Cvl(CInt((num4 + CULng((CLng(num5) - CLng(num4))) + 1UL)), num6)
							Dim num7 As ULong = num4 + CULng((CLng(num6) - CLng(num4) + 1L))
							Dim num8 As Integer = Me.Gvl(CInt(num7))
							Dim num9 As Integer = num8
							Dim num10 As Long = Me.Cvl(CInt(num7), num8)
							Dim array As Long() = New Long(4) {}
							For i As Integer = 0 To 4
								Dim num11 As Integer = num9 + 1
								num9 = Me.Gvl(num11)
								array(i) = Me.Cvl(num11, num9)
								array(i) = CLng(If((array(i) <= 9L), CULng(Me._sqlDataTypeSize(CInt((CType(array(i), IntPtr))))), CULng(If((Not SqlHandler.IsOdd(array(i))), ((array(i) - 12L) / 2L), ((array(i) - 13L) / 2L)))))
							Next
							If Me._dbEncoding = 1UL Then
								Me._masterTableEntries(num2 + CInt(num3)).ItemName = Encoding.[Default].GetString(Me._fileBytes, CInt((num7 + CULng(num10) + CULng(array(0)))), CInt(array(1)))
							ElseIf Me._dbEncoding = 2UL Then
								Me._masterTableEntries(num2 + CInt(num3)).ItemName = Encoding.Unicode.GetString(Me._fileBytes, CInt((num7 + CULng(num10) + CULng(array(0)))), CInt(array(1)))
							ElseIf Me._dbEncoding = 3UL Then
								Me._masterTableEntries(num2 + CInt(num3)).ItemName = Encoding.BigEndianUnicode.GetString(Me._fileBytes, CInt((num7 + CULng(num10) + CULng(array(0)))), CInt(array(1)))
							End If
							Me._masterTableEntries(num2 + CInt(num3)).RootNum = CLng(Me.ConvertToULong(CInt((num7 + CULng(num10) + CULng(array(0)) + CULng(array(1)) + CULng(array(2)))), CInt(array(3))))
							If Me._dbEncoding = 1UL Then
								Me._masterTableEntries(num2 + CInt(num3)).SqlStatement = Encoding.[Default].GetString(Me._fileBytes, CInt((num7 + CULng(num10) + CULng(array(0)) + CULng(array(1)) + CULng(array(2)) + CULng(array(3)))), CInt(array(4)))
							ElseIf Me._dbEncoding = 2UL Then
								Me._masterTableEntries(num2 + CInt(num3)).SqlStatement = Encoding.Unicode.GetString(Me._fileBytes, CInt((num7 + CULng(num10) + CULng(array(0)) + CULng(array(1)) + CULng(array(2)) + CULng(array(3)))), CInt(array(4)))
							ElseIf Me._dbEncoding = 3UL Then
								Me._masterTableEntries(num2 + CInt(num3)).SqlStatement = Encoding.BigEndianUnicode.GetString(Me._fileBytes, CInt((num7 + CULng(num10) + CULng(array(0)) + CULng(array(1)) + CULng(array(2)) + CULng(array(3)))), CInt(array(4)))
							End If
						Next
					End If
				Else
					Dim num12 As UShort = CUShort((Me.ConvertToULong(CInt(offset) + 3, 2) - 1UL))
					For j As Integer = 0 To CInt(num12)
						Dim num13 As UShort = CUShort(Me.ConvertToULong(CInt(offset) + 12 + j * 2, 2))
						If offset = 100L Then
							Me.ReadMasterTable(CLng(((Me.ConvertToULong(CInt(num13), 4) - 1UL) * Me._pageSize)))
						Else
							Me.ReadMasterTable(CLng(((Me.ConvertToULong(CInt((offset + CLng(CULng(num13)))), 4) - 1UL) * Me._pageSize)))
						End If
					Next
					Me.ReadMasterTable(CLng(((Me.ConvertToULong(CInt(offset) + 8, 4) - 1UL) * Me._pageSize)))
				End If
			Catch
			End Try
		End Sub

		' Token: 0x060000D4 RID: 212 RVA: 0x00008FB0 File Offset: 0x000071B0
		Public Function ReadTable(tableName As String) As Boolean
			Dim flag As Boolean
			Try
				Dim num As Integer = -1
				Dim i As Integer = 0
				While i <= Me._masterTableEntries.Length
					If String.Compare(Me._masterTableEntries(i).ItemName.ToLower(), tableName.ToLower(), StringComparison.Ordinal) <> 0 Then
						i += 1
					Else
						num = i
						IL_46:
						If num = -1 Then
							Return False
						End If
						Dim array As String() = Me._masterTableEntries(num).SqlStatement.Substring(Me._masterTableEntries(num).SqlStatement.IndexOf("(", StringComparison.Ordinal) + 1).Split(New Char() { ","c })
						For j As Integer = 0 To array.Length - 1
							array(j) = array(j).TrimStart(New Char(-1) {})
							Dim num2 As Integer = array(j).IndexOf(" "c)
							If num2 > 0 Then
								array(j) = array(j).Substring(0, num2)
							End If
							If array(j).IndexOf("UNIQUE", StringComparison.Ordinal) <> 0 Then
								Array.Resize(Of String)(Me._fieldNames, j + 1)
								Me._fieldNames(j) = array(j)
							End If
						Next
						Return Me.ReadTableFromOffset(CULng(((Me._masterTableEntries(num).RootNum - 1L) * CLng(Me._pageSize))))
					End If
				End While
				GoTo IL_46
			Catch
				flag = False
			End Try
			Return flag
		End Function

		' Token: 0x060000D5 RID: 213 RVA: 0x00009128 File Offset: 0x00007328
		Private Function ConvertToULong(startIndex As Integer, size As Integer) As ULong
			Dim num As ULong
			Try
				If(size > 8) Or (size = 0) Then
					num = 0UL
				Else
					Dim num2 As ULong = 0UL
					For i As Integer = 0 To size - 1
						num2 = (num2 << 8) Or CULng(Me._fileBytes(startIndex + i))
					Next
					num = num2
				End If
			Catch
				num = 0UL
			End Try
			Return num
		End Function

		' Token: 0x060000D6 RID: 214 RVA: 0x0000919C File Offset: 0x0000739C
		Private Function Gvl(startIdx As Integer) As Integer
			Dim num As Integer
			Try
				If startIdx > Me._fileBytes.Length Then
					num = 0
				Else
					For i As Integer = startIdx To startIdx + 8
						If i > Me._fileBytes.Length - 1 Then
							Return 0
						End If
						If(Me._fileBytes(i) And 128) <> 128 Then
							Return i
						End If
					Next
					num = startIdx + 8
				End If
			Catch
				num = 0
			End Try
			Return num
		End Function

		' Token: 0x060000D7 RID: 215 RVA: 0x0000921C File Offset: 0x0000741C
		Private Function Cvl(startIdx As Integer, endIdx As Integer) As Long
			Dim num2 As Long
			Try
				endIdx += 1
				Dim array As Byte() = New Byte(7) {}
				Dim num As Integer = endIdx - startIdx
				Dim flag As Boolean = False
				If(num = 0) Or (num > 9) Then
					num2 = 0L
				ElseIf num = 1 Then
					array(0) = Me._fileBytes(startIdx) And 127
					num2 = BitConverter.ToInt64(array, 0)
				Else
					If num = 9 Then
						flag = True
					End If
					Dim num3 As Integer = 1
					Dim num4 As Integer = 7
					Dim num5 As Integer = 0
					If flag Then
						array(0) = Me._fileBytes(endIdx - 1)
						endIdx -= 1
						num5 = 1
					End If
					For i As Integer = endIdx - 1 To startIdx Step -1
						If i - 1 >= startIdx Then
							array(num5) = CByte((((Me._fileBytes(i) >> num3 - 1) And (255 >> num3)) Or (CInt(Me._fileBytes(i - 1)) << num4)))
							num3 += 1
							num5 += 1
							num4 -= 1
						ElseIf Not flag Then
							array(num5) = CByte(((Me._fileBytes(i) >> num3 - 1) And (255 >> num3)))
						End If
					Next
					num2 = BitConverter.ToInt64(array, 0)
				End If
			Catch
				num2 = 0L
			End Try
			Return num2
		End Function

		' Token: 0x060000D8 RID: 216 RVA: 0x0000936C File Offset: 0x0000756C
		Private Shared Function IsOdd(value As Long) As Boolean
			Return(value And 1L) = 1L
		End Function

		' Token: 0x040000B9 RID: 185
		Private _sqlDataTypeSize As Byte() = New Byte() { 0, 1, 2, 3, 4, 6, 8, 8, 0, 0 }

		' Token: 0x040000BA RID: 186
		Private _dbEncoding As ULong

		' Token: 0x040000BB RID: 187
		Private _fileBytes As Byte()

		' Token: 0x040000BC RID: 188
		Private _pageSize As ULong

		' Token: 0x040000BD RID: 189
		Private _fieldNames As String()

		' Token: 0x040000BE RID: 190
		Private _masterTableEntries As SqlHandler.SqliteMasterEntry()

		' Token: 0x040000BF RID: 191
		Private _tableEntries As SqlHandler.TableEntry()

		' Token: 0x02000025 RID: 37
		Private Structure RecordHeaderField
			' Token: 0x040000C0 RID: 192
			Public Size As Long

			' Token: 0x040000C1 RID: 193
			Public Type As Long
		End Structure

		' Token: 0x02000026 RID: 38
		Private Structure TableEntry
			' Token: 0x040000C2 RID: 194
			Public Content As String()
		End Structure

		' Token: 0x02000027 RID: 39
		Private Structure SqliteMasterEntry
			' Token: 0x040000C3 RID: 195
			Public ItemName As String

			' Token: 0x040000C4 RID: 196
			Public RootNum As Long

			' Token: 0x040000C5 RID: 197
			Public SqlStatement As String
		End Structure
	End Class
End Namespace
