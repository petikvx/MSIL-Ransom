using System;
using System.Runtime.InteropServices;

namespace CommandLine.Text;

[ComVisible(false)]
[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
public sealed class AssemblyLicenseAttribute : MultilineTextAttribute
{
	public AssemblyLicenseAttribute(string line1)
		: base(line1)
	{
	}

	public AssemblyLicenseAttribute(string line1, string line2)
		: base(line1, line2)
	{
	}

	public AssemblyLicenseAttribute(string line1, string line2, string line3)
		: base(line1, line2, line3)
	{
	}

	public AssemblyLicenseAttribute(string line1, string line2, string line3, string line4)
		: base(line1, line2, line3, line4)
	{
	}

	public AssemblyLicenseAttribute(string line1, string line2, string line3, string line4, string line5)
		: base(line1, line2, line3, line4, line5)
	{
	}
}
