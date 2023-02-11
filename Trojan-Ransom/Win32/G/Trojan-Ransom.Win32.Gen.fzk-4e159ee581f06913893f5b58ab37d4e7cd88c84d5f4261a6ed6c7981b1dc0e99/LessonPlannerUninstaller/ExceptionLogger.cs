using System;
using System.Diagnostics;

namespace LessonPlannerUninstaller;

internal static class ExceptionLogger
{
	public static void FormatLogMessage(Exception ex)
	{
	}

	public static void LogEvent(string msg)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		try
		{
			EventLog val = new EventLog();
			val.set_Source("Application");
			val.WriteEntry(msg, (EventLogEntryType)1);
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}
}
