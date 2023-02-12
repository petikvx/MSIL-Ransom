Imports System
Imports System.Reflection
Imports System.Reflection.Emit
Imports ns0

Namespace SmartAssembly.HouseOfCards
	' Token: 0x02000028 RID: 40
	Public Module MemberRefsProxy
		' Token: 0x060000E2 RID: 226 RVA: 0x0000F794 File Offset: 0x0000D994
		<Attribute0()>
		Public Sub CreateMemberRefsDelegates(typeID As Integer)
			Dim typeFromHandle As Type
			Try
				typeFromHandle = Type.GetTypeFromHandle(MemberRefsProxy.moduleHandle_0.ResolveTypeHandle(33554433 + typeID))
			Catch
				Return
			End Try
			Dim fields As FieldInfo() = typeFromHandle.GetFields(BindingFlags.[Static] Or BindingFlags.NonPublic Or BindingFlags.GetField)
			Dim i As Integer = 0
			IL_2D:
			While i < fields.Length
				Dim fieldInfo As FieldInfo = fields(i)
				Dim name As String = fieldInfo.Name
				Dim flag As Boolean = False
				Dim num As Integer = 0
				Dim j As Integer = name.Length - 1
				IL_99:
				While j >= 0
					Dim c As Char = name(j)
					If c = "~"c Then
						flag = True
						IL_A3:
						Dim methodInfo As MethodInfo
						Try
							methodInfo = CType(MethodBase.GetMethodFromHandle(MemberRefsProxy.moduleHandle_0.ResolveMethodHandle(num + 167772161)), MethodInfo)
						Catch
							GoTo IL_209
						End Try
						GoTo IL_CA
						IL_209:
						i += 1
						GoTo IL_2D
						IL_CA:
						Dim [delegate] As [Delegate]
						If methodInfo.IsStatic Then
							Try
								[delegate] = [Delegate].CreateDelegate(fieldInfo.FieldType, methodInfo)
								GoTo IL_1FA
							Catch ex As Exception
								GoTo IL_209
							End Try
						End If
						Dim parameters As ParameterInfo() = methodInfo.GetParameters()
						Dim num2 As Integer = parameters.Length + 1
						Dim array As Type() = New Type(num2 - 1) {}
						array(0) = GetType(Object)
						For k As Integer = 1 To num2 - 1
							array(k) = parameters(k - 1).ParameterType
						Next
						Dim dynamicMethod As DynamicMethod = New DynamicMethod(String.Empty, methodInfo.ReturnType, array, typeFromHandle, True)
						Dim ilgenerator As ILGenerator = dynamicMethod.GetILGenerator()
						ilgenerator.Emit(OpCodes.Ldarg_0)
						If num2 > 1 Then
							ilgenerator.Emit(OpCodes.Ldarg_1)
						End If
						If num2 > 2 Then
							ilgenerator.Emit(OpCodes.Ldarg_2)
						End If
						If num2 > 3 Then
							ilgenerator.Emit(OpCodes.Ldarg_3)
						End If
						If num2 > 4 Then
							For l As Integer = 4 To num2 - 1
								ilgenerator.Emit(OpCodes.Ldarg_S, l)
							Next
						End If
						ilgenerator.Emit(OpCodes.Tailcall)
						ilgenerator.Emit(If(flag, OpCodes.Callvirt, OpCodes.[Call]), methodInfo)
						ilgenerator.Emit(OpCodes.Ret)
						Try
							[delegate] = dynamicMethod.CreateDelegate(typeFromHandle)
						Catch
							GoTo IL_209
						End Try
						IL_1FA:
						Try
							fieldInfo.SetValue(Nothing, [delegate])
						Catch
						End Try
						GoTo IL_209
					End If
					For m As Integer = 0 To 58 - 1
						If MemberRefsProxy.char_0(m) = c Then
							num = num * 58 + m
							IL_93:
							j -= 1
							GoTo IL_99
						End If
					Next
					GoTo IL_93
				End While
				GoTo IL_A3
			End While
		End Sub

		' Token: 0x060000E3 RID: 227 RVA: 0x00002C0C File Offset: 0x00000E0C
		Shared Sub New()
			If GetType(MulticastDelegate) IsNot Nothing Then
				MemberRefsProxy.moduleHandle_0 = Assembly.GetExecutingAssembly().GetModules()(0).ModuleHandle
			End If
		End Sub

		' Token: 0x040000D2 RID: 210
		Private moduleHandle_0 As ModuleHandle

		' Token: 0x040000D3 RID: 211
		Private char_0 As Char() = New Char() { ChrW(1), ChrW(2), ChrW(3), ChrW(4), ChrW(5), ChrW(6), ChrW(7), vbBack, ChrW(14), ChrW(15), ChrW(16), ChrW(17), ChrW(18), ChrW(19), ChrW(20), ChrW(21), ChrW(22), ChrW(23), ChrW(24), ChrW(25), ChrW(26), ChrW(27), ChrW(28), ChrW(29), ChrW(30), ChrW(31), ChrW(127), ChrW(128), ChrW(129), ChrW(130), ChrW(131), ChrW(132), ChrW(134), ChrW(135), ChrW(136), ChrW(137), ChrW(138), ChrW(139), ChrW(140), ChrW(141), ChrW(142), ChrW(143), ChrW(144), ChrW(145), ChrW(146), ChrW(147), ChrW(148), ChrW(149), ChrW(150), ChrW(151), ChrW(152), ChrW(153), ChrW(154), ChrW(155), ChrW(156), ChrW(157), ChrW(158), ChrW(159) }
	End Module
End Namespace
