Imports System
Imports System.Reflection
Imports System.Reflection.Emit
Imports ns0
Imports SmartAssembly.Delegates
Imports SmartAssembly.StringsEncoding

Namespace SmartAssembly.HouseOfCards
	' Token: 0x02000029 RID: 41
	Public Module Strings
		' Token: 0x060000E4 RID: 228 RVA: 0x0000F9F4 File Offset: 0x0000DBF4
		<Attribute0()>
		Public Sub CreateGetStringDelegate(ownerType As Type)
			For Each fieldInfo As FieldInfo In ownerType.GetFields(BindingFlags.[Static] Or BindingFlags.NonPublic Or BindingFlags.GetField)
				Try
					If fieldInfo.FieldType Is GetType(GetString) Then
						Dim dynamicMethod As DynamicMethod = New DynamicMethod(String.Empty, GetType(String), New Type() { GetType(Integer) }, ownerType.[Module], True)
						Dim ilgenerator As ILGenerator = dynamicMethod.GetILGenerator()
						ilgenerator.Emit(OpCodes.Ldarg_0)
						For Each methodInfo As MethodInfo In GetType(Strings).GetMethods(BindingFlags.[Static] Or BindingFlags.[Public])
							If methodInfo.ReturnType Is GetType(String) Then
								ilgenerator.Emit(OpCodes.Ldc_I4, fieldInfo.MetadataToken And 16777215)
								ilgenerator.Emit(OpCodes.[Sub])
								ilgenerator.Emit(OpCodes.[Call], methodInfo)
								IL_E9:
								ilgenerator.Emit(OpCodes.Ret)
								fieldInfo.SetValue(Nothing, dynamicMethod.CreateDelegate(GetType(GetString)))
								Return
							End If
						Next
						GoTo IL_E9
					End If
				Catch
				End Try
			Next
		End Sub
	End Module
End Namespace
