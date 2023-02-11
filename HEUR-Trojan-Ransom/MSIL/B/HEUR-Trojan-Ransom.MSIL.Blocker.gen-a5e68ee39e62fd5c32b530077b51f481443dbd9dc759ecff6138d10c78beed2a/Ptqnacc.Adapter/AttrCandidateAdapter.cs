using System;
using System.Windows.Forms;
using Apjmqciddnbbpsnfq.Consumers;

namespace Ptqnacc.Adapter;

public class AttrCandidateAdapter
{
	private static AttrCandidateAdapter CalculateSingleton;

	[STAThread]
	private static void SelectPage()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Rule());
	}

	internal static bool SelectSingleton()
	{
		return CalculateSingleton == null;
	}

	internal static AttrCandidateAdapter InstantiateSingleton()
	{
		return CalculateSingleton;
	}
}
