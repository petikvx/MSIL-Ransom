Imports System

Namespace SmartAssembly.Attributes
	' Token: 0x0200002C RID: 44
	<AttributeUsage(AttributeTargets.Assembly Or AttributeTargets.[Module] Or AttributeTargets.[Class] Or AttributeTargets.Struct Or AttributeTargets.[Enum] Or AttributeTargets.Constructor Or AttributeTargets.Method Or AttributeTargets.[Property] Or AttributeTargets.Field Or AttributeTargets.[Event] Or AttributeTargets.[Interface] Or AttributeTargets.Parameter Or AttributeTargets.[Delegate])>
	Public NotInheritable Class DoNotObfuscateAttribute
		Inherits Attribute

	End Class
End Namespace
