Imports System
Imports System.Reflection
Imports dg3ypDAonQcOidMs0w
Imports rE4lpnT863QnijKQK5
Imports zlqCXdcKao7YZQAGFe

Namespace oRZtxCaSAYh6EEGEIZ
	' Token: 0x0200000F RID: 15
	Friend Class Idt5pgryuYoFVQiX6j
		' Token: 0x0600004E RID: 78 RVA: 0x00005184 File Offset: 0x00003384
		Friend Shared Sub Ec1F5299AxUyY(typemdt As Integer)
			Dim type As Type = Idt5pgryuYoFVQiX6j.Kh2o8BSHbd.ResolveType(33554432 + typemdt)
			For Each fieldInfo As FieldInfo In type.GetFields()
				Dim methodInfo As MethodInfo = CType(Idt5pgryuYoFVQiX6j.Kh2o8BSHbd.ResolveMethod(fieldInfo.MetadataToken + 100663296), MethodInfo)
				fieldInfo.SetValue(Nothing, CType([Delegate].CreateDelegate(type, methodInfo), MulticastDelegate))
			Next
		End Sub

		' Token: 0x0600004F RID: 79 RVA: 0x00002243 File Offset: 0x00000443
		Public Sub New()
			hHEYokUTtehNq5ji0d.LQgF529zBT6Ox()
			MyBase..ctor()
		End Sub

		' Token: 0x06000050 RID: 80 RVA: 0x00002421 File Offset: 0x00000621
		' Note: this type is marked as 'beforefieldinit'.
		Shared Sub New()
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw()
			hHEYokUTtehNq5ji0d.LQgF529zBT6Ox()
			Idt5pgryuYoFVQiX6j.Kh2o8BSHbd = Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.GLmF52oPYUmB1(33554447)).Assembly.ManifestModule
		End Sub

		' Token: 0x04000041 RID: 65
		Friend Shared Kh2o8BSHbd As [Module]

		' Token: 0x02000010 RID: 16
		Friend NotInheritable Class SFU4mbT3GMret7THonf
			Inherits MulticastDelegate

			' Token: 0x06000051 RID: 81
			Public Sub New([object] As Object, method As IntPtr)

			End Sub

			' Token: 0x06000052 RID: 82
			Public Sub Invoke(o As Object)

			' Token: 0x06000053 RID: 83
			Public Function BeginInvoke(o As Object, callback As AsyncCallback, [object] As Object) As IAsyncResult

			' Token: 0x06000054 RID: 84
			Public Sub EndInvoke(result As IAsyncResult)

			' Token: 0x06000055 RID: 85 RVA: 0x0000223C File Offset: 0x0000043C
			Shared Sub New()
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw()
			End Sub
		End Class
	End Class
End Namespace
