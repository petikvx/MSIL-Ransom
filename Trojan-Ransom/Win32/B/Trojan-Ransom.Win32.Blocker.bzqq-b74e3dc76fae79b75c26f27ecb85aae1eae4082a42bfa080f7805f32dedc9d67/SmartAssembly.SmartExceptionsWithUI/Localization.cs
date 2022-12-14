namespace SmartAssembly.SmartExceptionsWithUI;

internal class Localization
{
	public const int Width = 419;

	public const int Height = 264;

	public const int DebugButtonWidth = 64;

	public const int SendReportButtonWidth = 105;

	public const int DontSendButtonWidth = 75;

	public const int OKRetryButtonWidth = 105;

	public const int CancelButtonWidth = 80;

	public const int ContinueCheckBoxWidth = 226;

	public const int ContinueButtonWidth = 100;

	public const int QuitButtonWidth = 100;

	public const string CannotAttachApp = "{0} cannot initialize itself because some permissions are not granted.\n\nYou probably try to launch {0} in a partial-trust situation. It's usually the case when the application is hosted on a network share.\n\nYou need to run {0} in full-trust, or at least grant it the UnmanagedCode security permission.\n\nTo grant this application the required permission, contact your system administrator, or use the Microsoft .NET Framework Configuration tool.";

	public const string SecurityExceptionMessage = "{0} attempted to perform an operation not allowed by the security policy. To grant this application the required permission, contact your system administrator, or use the Microsoft .NET Framework Configuration tool.\n\n";

	public const string ContinueOrQuit = "If you click Continue, the application will ignore this error and attempt to continue. If you click Quit, the application will close immediately.\n\n";

	public const string SecurityException = "Security error";

	public const string FatalError = "{0} Unexpected Error";

	public const string SecurityExceptionHeader = "{0} attempted to perform an operation not allowed by the security policy.";

	public const string CompanyInterestedInLearning = "To help improve the software you use, {0} is interested in learning more about this error. We have created a report about the error for you to send to us.";

	public const string IgnoreThisError = "Ignore this error and attempt to &continue.";

	public const string PleaseTellCompany = "Please tell {0} about this problem.";

	public const string SendReportButton = "&Send Error Report";

	public const string DontSendButton = "&Don't Send";

	public const string CancelButton = "&Cancel";

	public const string OKButton = "&OK";

	public const string RetryButton = "&Retry";

	public const string SaveReportButton = "Save Report";

	public const string DebugButton = "De&bug";

	public const string ContinueButton = "&Continue";

	public const string QuitButton = "&Quit";

	public const string AppHasEncounteredAProblem = "{0} has encountered a problem.\nWe are sorry for the inconvenience.";

	public const string PleaseWaitWhileSending = "Please wait while {0} is sending the report to {1} through the Internet.";

	public const string PreparingReport = "Preparing the error report.";

	public const string ConnectingToServer = "Connecting to server.";

	public const string TransferringReport = "Transferring report.";

	public const string CompletedThankYou = "Error reporting completed. Thank you.";

	public const string ErrorReporting = "Error Reporting";
}
