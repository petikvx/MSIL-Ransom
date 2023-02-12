Imports System
Imports Microsoft.Win32

Namespace Main.Tools
	' Token: 0x02000020 RID: 32
	Public NotInheritable Class RegistryHelper
		' Token: 0x060000BE RID: 190 RVA: 0x000023D2 File Offset: 0x000005D2
		Private Sub New()
		End Sub

		' Token: 0x060000BF RID: 191 RVA: 0x00007C10 File Offset: 0x00005E10
		Public Shared Function GetValueFromRegKey(keyBase As BaseKey, keyName As String, valueName As String, defaultValue As Object) As Object
			Dim registryKey As RegistryKey = If((keyBase = BaseKey.[Default]), Registry.CurrentUser.OpenSubKey(keyName), Registry.LocalMachine.OpenSubKey(keyName))
			If registryKey IsNot Nothing AndAlso Array.IndexOf(Of String)(registryKey.GetValueNames(), valueName) > -1 Then
				Dim value As Object = registryKey.GetValue(valueName)
				If value IsNot Nothing Then
					Return value
				End If
			End If
			Return defaultValue
		End Function

		' Token: 0x060000C0 RID: 192 RVA: 0x00007C68 File Offset: 0x00005E68
		Public Shared Function GetValueFromRegKey(keyName As String, valueName As String, defaultValue As Object) As Object
			Return RegistryHelper.GetValueFromRegKey(BaseKey.[Default], keyName, valueName, defaultValue)
		End Function

		' Token: 0x060000C1 RID: 193 RVA: 0x00007C80 File Offset: 0x00005E80
		Public Shared Sub SetValueToRegKey(keyBase As BaseKey, keyName As String, valueName As String, newValue As Object)
			If newValue Is Nothing Then
				Throw New ArgumentException("new value cannot be null")
			End If
			Dim registryKey As RegistryKey = If((keyBase = BaseKey.[Default]), Registry.CurrentUser.OpenSubKey(keyName, True), Registry.LocalMachine.OpenSubKey(keyName, True))
			If registryKey Is Nothing Then
				registryKey = If((keyBase = BaseKey.[Default]), Registry.CurrentUser.CreateSubKey(keyName), Registry.LocalMachine.CreateSubKey(keyName))
			End If
			registryKey.SetValue(valueName, newValue)
		End Sub

		' Token: 0x060000C2 RID: 194 RVA: 0x00002680 File Offset: 0x00000880
		Public Shared Sub SetValueToRegKey(keyName As String, valueName As String, newValue As Object)
			RegistryHelper.SetValueToRegKey(BaseKey.[Default], keyName, valueName, newValue)
		End Sub

		' Token: 0x060000C3 RID: 195 RVA: 0x00007CE8 File Offset: 0x00005EE8
		Public Shared Sub RemoveValueFromRegKey(keyBase As BaseKey, keyName As String, valueName As String)
			Dim registryKey As RegistryKey = If((keyBase = BaseKey.[Default]), Registry.CurrentUser.OpenSubKey(keyName, True), Registry.LocalMachine.OpenSubKey(keyName, True))
			If registryKey IsNot Nothing AndAlso Array.IndexOf(Of String)(registryKey.GetValueNames(), valueName) > -1 Then
				registryKey.DeleteValue(valueName, False)
			End If
		End Sub

		' Token: 0x060000C4 RID: 196 RVA: 0x0000268B File Offset: 0x0000088B
		Public Shared Sub RemoveValueFromRegKey(keyName As String, valueName As String)
			RegistryHelper.RemoveValueFromRegKey(BaseKey.[Default], keyName, valueName)
		End Sub
	End Class
End Namespace
