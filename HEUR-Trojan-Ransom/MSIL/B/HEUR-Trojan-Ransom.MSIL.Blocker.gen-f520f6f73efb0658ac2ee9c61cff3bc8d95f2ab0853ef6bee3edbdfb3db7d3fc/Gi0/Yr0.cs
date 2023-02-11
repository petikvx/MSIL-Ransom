using System.ComponentModel.Design;
using System.Configuration;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Mo2;

namespace Gi0;

[HideModuleName]
[StandardModule]
internal sealed class Yr0
{
	internal sealed class s9C
	{
		internal Label x;

		internal Guna2GradientButton w;

		internal s9C()
		{
		}
	}

	[HelpKeyword("My.Settings")]
	internal static k8F m
	{
		get
		{
			//Discarded unreachable code: IL_0002, IL_001c
			ApplicationSettingsBase val = (ApplicationSettingsBase)(object)k8F.Default;
			return val as k8F;
		}
	}
}
