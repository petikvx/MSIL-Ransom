Imports System
Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports System.Runtime.InteropServices.ComTypes

Namespace Client.Helper
	' Token: 0x0200000D RID: 13
	Friend Class Camera
		' Token: 0x06000048 RID: 72 RVA: 0x00002261 File Offset: 0x00000461
		Public Shared Function havecamera() As Boolean
			Return Camera.FindDevices().Length <> 0
		End Function

		' Token: 0x06000049 RID: 73 RVA: 0x00002271 File Offset: 0x00000471
		Public Shared Function FindDevices() As String()
			Return Camera.GetFiltes(Camera.CLSID_VideoInputDeviceCategory).ToArray()
		End Function

		' Token: 0x0600004A RID: 74 RVA: 0x00003BF4 File Offset: 0x00001DF4
		Public Shared Function GetFiltes(category As Guid) As List(Of String)
			Dim result As List(Of String) = New List(Of String)()
			Camera.EnumMonikers(category, Function(moniker As IMoniker, prop As Camera.IPropertyBag)
				Dim obj As Object = Nothing
				prop.Read("FriendlyName", obj, 0)
				Dim text As String = CStr(obj)
				result.Add(text)
				Return False
			End Function)
			Return result
		End Function

		' Token: 0x0600004B RID: 75 RVA: 0x00003C2C File Offset: 0x00001E2C
		Private Shared Sub EnumMonikers(category As Guid, func As Func(Of IMoniker, Camera.IPropertyBag, Boolean))
			Dim enumMoniker As IEnumMoniker = Nothing
			Dim createDevEnum As Camera.ICreateDevEnum = Nothing
			Try
				createDevEnum = CType(Activator.CreateInstance(Type.GetTypeFromCLSID(Camera.CLSID_SystemDeviceEnum)), Camera.ICreateDevEnum)
				createDevEnum.CreateClassEnumerator(category, enumMoniker, 0)
				If enumMoniker IsNot Nothing Then
					Dim array As IMoniker() = New IMoniker(0) {}
					Dim zero As IntPtr = IntPtr.Zero
					While enumMoniker.[Next](array.Length, array, zero) = 0
						Dim moniker As IMoniker = array(0)
						Dim obj As Object = Nothing
						Dim iid_IPropertyBag As Guid = Camera.IID_IPropertyBag
						moniker.BindToStorage(Nothing, Nothing, iid_IPropertyBag, obj)
						Dim propertyBag As Camera.IPropertyBag = CType(obj, Camera.IPropertyBag)
						Try
							If func(moniker, propertyBag) Then
								Exit Try
							End If
						Finally
							Marshal.ReleaseComObject(propertyBag)
							If moniker IsNot Nothing Then
								Marshal.ReleaseComObject(moniker)
							End If
						End Try
					End While
				End If
			Finally
				If enumMoniker IsNot Nothing Then
					Marshal.ReleaseComObject(enumMoniker)
				End If
				If createDevEnum IsNot Nothing Then
					Marshal.ReleaseComObject(createDevEnum)
				End If
			End Try
		End Sub

		' Token: 0x0400002E RID: 46
		Public Shared CLSID_VideoInputDeviceCategory As Guid = New Guid("{860BB310-5D01-11d0-BD3B-00A0C911CE86}")

		' Token: 0x0400002F RID: 47
		Public Shared CLSID_SystemDeviceEnum As Guid = New Guid("{62BE5D10-60EB-11d0-BD3B-00A0C911CE86}")

		' Token: 0x04000030 RID: 48
		Public Shared IID_IPropertyBag As Guid = New Guid("{55272A00-42CB-11CE-8135-00AA004BB851}")

		' Token: 0x0200000E RID: 14
		<ComVisible(True)>
		<Guid("29840822-5B84-11D0-BD3B-00A0C911CE86")>
		<InterfaceType(ComInterfaceType.InterfaceIsIUnknown)>
		<ComImport()>
		Public Interface ICreateDevEnum
			' Token: 0x0600004E RID: 78
			Function CreateClassEnumerator(<[In]()> ByRef pType As Guid, <[In]()> <Out()> ByRef ppEnumMoniker As IEnumMoniker, <[In]()> dwFlags As Integer) As Integer
		End Interface

		' Token: 0x0200000F RID: 15
		<ComVisible(True)>
		<Guid("55272A00-42CB-11CE-8135-00AA004BB851")>
		<InterfaceType(ComInterfaceType.InterfaceIsIUnknown)>
		<ComImport()>
		Public Interface IPropertyBag
			' Token: 0x0600004F RID: 79
			Function Read(<MarshalAs(UnmanagedType.LPWStr)> PropName As String, ByRef Var As Object, ErrorLog As Integer) As Integer

			' Token: 0x06000050 RID: 80
			Function Write(PropName As String, ByRef Var As Object) As Integer
		End Interface
	End Class
End Namespace
