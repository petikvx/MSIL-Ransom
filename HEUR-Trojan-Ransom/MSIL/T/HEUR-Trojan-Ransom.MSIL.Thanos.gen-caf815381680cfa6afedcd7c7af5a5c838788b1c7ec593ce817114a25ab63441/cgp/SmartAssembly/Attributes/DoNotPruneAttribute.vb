Imports System

Namespace SmartAssembly.Attributes
	' Token: 0x0200002D RID: 45
	<AttributeUsage(AttributeTargets.Assembly Or AttributeTargets.[Module] Or AttributeTargets.[Class] Or AttributeTargets.Struct Or AttributeTargets.[Enum] Or AttributeTargets.Constructor Or AttributeTargets.Method Or AttributeTargets.[Property] Or AttributeTargets.Field Or AttributeTargets.[Event] Or AttributeTargets.[Interface] Or AttributeTargets.Parameter Or AttributeTargets.[Delegate])>
	Public NotInheritable Class DoNotPruneAttribute
		Inherits Attribute

	End Class
End Namespace
