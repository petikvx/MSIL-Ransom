using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public sealed class GClass8
{
	private int int_0;

	private IntPtr intptr_0;

	private int int_1;

	public GClass8(Keys keys_0, Form form_0)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected I4, but got Unknown
		int_0 = (int)keys_0;
		intptr_0 = ((Control)form_0).get_Handle();
		int_1 = GetHashCode();
	}

	[DllImport("user32.dll")]
	private static extern bool RegisterHotKey(IntPtr intptr_1, int int_2, int int_3, int int_4);

	[DllImport("user32.dll")]
	private static extern bool UnregisterHotKey(IntPtr intptr_1, int int_2);

	public override int GetHashCode()
	{
		return int_0 ^ intptr_0.ToInt32();
	}

	public bool method_0()
	{
		return RegisterHotKey(intptr_0, int_1, 0, int_0);
	}

	public bool method_1()
	{
		return UnregisterHotKey(intptr_0, int_1);
	}
}
