using System;
using KoiVM.Runtime;

internal class Beds_002DProtector : Attribute
{
	public Beds_002DProtector(string string_0)
	{
		VMEntry.Run(typeof(Beds_002DProtector).TypeHandle, 35u, new object[2] { this, string_0 });
	}
}
