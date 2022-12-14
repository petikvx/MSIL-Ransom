using System.Resources;
using Microsoft.Win32;

namespace WatsonDialog;

internal static class Constants
{
	internal const string SQL_BASE_REGKEY_STRING = "SOFTWARE\\Microsoft\\Microsoft SQL Server";

	internal const string AGNOSTIC_REGKEY_STRING = "SOFTWARE\\Microsoft\\Microsoft SQL Server\\90";

	internal const string HELP_REGKEY_STRING = "SOFTWARE\\Microsoft\\Microsoft SQL Server\\90\\Bootstrap";

	internal const string INSTANCE_NAMES_REGKEY_STRING = "SOFTWARE\\Microsoft\\Microsoft SQL Server\\Instance Names";

	internal const string NS_REGKEY_STRING = "SOFTWARE\\Microsoft\\Microsoft SQL Server\\90\\NS";

	internal const string DTS_REGKEY_STRING = "SOFTWARE\\Microsoft\\Microsoft SQL Server\\90\\DTS";

	internal const string SQLBROWSER_REGKEY_STRING = "SOFTWARE\\Microsoft\\Microsoft SQL Server\\90\\SQL Browser";

	internal const string WOW_SQL_BASE_REGKEY_STRING = "SOFTWARE\\Wow6432Node\\Microsoft\\Microsoft SQL Server";

	internal const string WOW_AGNOSTIC_REGKEY_STRING = "SOFTWARE\\Wow6432Node\\Microsoft\\Microsoft SQL Server\\90";

	internal const string WOW_HELP_REGKEY_STRING = "SOFTWARE\\Wow6432Node\\Microsoft\\Microsoft SQL Server\\90\\Bootstrap";

	internal const string WOW_INSTANCE_NAMES_REGKEY_STRING = "SOFTWARE\\Wow6432Node\\Microsoft\\Microsoft SQL Server\\Instance Names";

	internal const string WOW_NS_REGKEY_STRING = "SOFTWARE\\Wow6432Node\\Microsoft\\Microsoft SQL Server\\90\\NS";

	internal const string WOW_DTS_REGKEY_STRING = "SOFTWARE\\Wow6432Node\\Microsoft\\Microsoft SQL Server\\90\\DTS";

	internal const string WOW_SQLBROWSER_REGKEY_STRING = "SOFTWARE\\Wow6432Node\\Microsoft\\Microsoft SQL Server\\90\\SQL Browser";

	internal const string AGNOSTIC_ERROR_REGNAME_STRING = "EnableErrorReporting";

	internal const string AGNOSTIC_USAGE_REGNAME_STRING = "CustomerFeedback";

	internal const string AGNOSTIC_ERROR_DIR_REGNAME_STRING = "ErrorReportingDir";

	internal const string HELP_REGNAME_STRING = "BootstrapDir";

	internal const string DEFAULT_INSTANCE_INTERNAL_NAME = "MSSQLSERVER";

	internal const string AWARE_ERROR_REGNAME_STRING = "EnableErrorReporting";

	internal const string AWARE_USAGE_REGNAME_STRING = "CustomerFeedback";

	internal const string AWARE_ERROR_DIR_REGNAME_STRING = "ErrorDumpDir";

	internal const string AWARE_REGKEY_SUBSTR = "\\CPE";

	internal const string SQL_SERVER_REGNAME = "SQL";

	internal const string ANALYSIS_SERVICE_REGNAME = "OLAP";

	internal const string REPORT_SERVICE_REGNAME = "RS";

	internal const string CLUSTER_REGKEY_SUBSTR = "\\Cluster";

	internal const string CLUSTER_NAME_REGNAME = "ClusterName";

	internal const int REGKEY_ON = 1;

	internal const int REGKEY_OFF = 0;

	internal const string AGNOSTIC_ID = "<AGNOSTIC>";

	internal const string WOW_AGNOSTIC_ID = "<WOW_AGNOSTIC>";

	internal const string WYUKON_ID = "MSSQL.2005";

	internal const string CLUSTER_RESOURCE_TYPE_SQL_SERVER = "SQL Server";

	internal const string CLUSTER_RESOURCE_TYPE_GENERIC_SERVICE = "Generic Service";

	internal const string CLUSTER_RESOURCE_PROPERTY_NAME_VIRTUAL_SERVER = "VirtualServerName";

	internal const string CLUSTER_RESOURCE_PROPERTY_NAME_SERVICE_NAME = "ServiceName";

	internal const string SQLSERVER2005_PREFIX = "SQLServer2005";

	internal const string MSSQLSERVER_GROUP_NAME = "SQLServer2005MSSQLUser";

	internal const string SQLAGENT_GROUP_NAME = "SQLServer2005SQLAgentUser";

	internal const string MSOLAP_GROUP_NAME = "SQLServer2005MSOLAPUser";

	internal const string REPORTSERVER_GROUP_NAME = "SQLServer2005ReportServerUser";

	internal const string REPORTWEBSERVICE_GROUP_NAME = "SQLServer2005ReportingServicesWebServiceUser";

	internal const string NOTIFICATIONSERVICES_GROUP_NAME = "SQLServer2005NotificationServicesUser";

	internal const string DTS_GROUP_NAME = "SQLServer2005DTSUser";

	internal const string SQLBROWSER_GROUP_NAME = "SQLServer2005SQLBrowserUser";

	internal const string HELP_TOPIC = "html\\e72c43b6-a2bd-4545-9aff-79c83b21180d.htm";

	internal const int INSTANCE_COLUMN = 0;

	internal const int COMPONENT_COLUMN = 1;

	internal const int USAGE_CHECKBOX_COLUMN = 2;

	internal const int ERROR_CHECKBOX_COLUMN = 3;

	internal const int ERROR_REPORTS_COLUMN = 4;

	internal const int BROWSE_COLUMN = 5;

	internal const int CHECKBOX_COLUMN_WIDTH = 80;

	internal const int TEXT_COLUMN_WIDTH = 100;

	internal const int PATH_COLUMN_WIDTH = 146;

	internal const int BROWSE_COLUMN_WIDTH = 18;

	internal const int EXTRA_GRID_WIDTH = 11;

	internal const int GRID_SCROLLBAR_WIDTH = 16;

	internal const int HEIGHT_DIFFERENCE = 202;

	internal const int DEFAULT_HEIGHT_EXPANDED = 528;

	internal const int DEFAULT_HEIGHT_COLLAPSED = 324;

	internal const int NUM_COLUMNS = 6;

	internal const int MAX_PATH_LENGTH = 247;

	internal static readonly RegistryKey BASE_REGKEY = Registry.LocalMachine;

	private static ResourceManager rm = new ResourceManager("WatsonDialog.Custom", typeof(Constants).Module.Assembly);

	internal static readonly string COMPONENT_SQL_SERVER_STRING = rm.GetString("ComponentSqlServerString");

	internal static readonly string COMPONENT_ANALYSIS_SERVER_STRING = rm.GetString("ComponentAnalysisServerString");

	internal static readonly string COMPONENT_REPORT_SERVER_STRING = rm.GetString("ComponentReportServerString");

	internal static readonly string COMPONENT_AGNOSTIC_STRING = rm.GetString("ComponentAgnosticString");

	internal static readonly string WOW_COMPONENT_AGNOSTIC_STRING = rm.GetString("WowComponentAgnosticString");

	internal static readonly string INSTANCE_AGNOSTIC_STRING = rm.GetString("InstanceAgnosticString");

	internal static readonly string DEFAULT_INSTANCE_DISPLAY_NAME = rm.GetString("DefaultInstanceDisplayName");

	internal static readonly string INSTANCE_COLUMN_HEADER = rm.GetString("InstanceColumnHeader");

	internal static readonly string COMPONENT_COLUMN_HEADER = rm.GetString("ComponentColumnHeader");

	internal static readonly string USAGE_CHECKBOX_COLUMN_HEADER = rm.GetString("UsageCheckboxColumnHeader");

	internal static readonly string ERROR_CHECKBOX_COLUMN_HEADER = rm.GetString("ErrorCheckboxColumnHeader");

	internal static readonly string ERROR_REPORTS_COLUMN_HEADER = rm.GetString("ErrorReportsColumnHeader");

	internal static readonly string OPTIONS_BUTTON_TEXT_HIDE = rm.GetString("OptionsButtonTextHide");

	internal static readonly string OPTIONS_BUTTON_TEXT_SHOW = rm.GetString("OptionsButtonTextShow");

	internal static readonly string BROWSE_BUTTON_TEXT = rm.GetString("BrowseButtonText");

	internal static readonly string BROWSE_DESCRIPTION = rm.GetString("BrowseDescription");

	internal static readonly string GRID_ACCESSIBLE_NAME = rm.GetString("GridAccessibleName");

	internal static readonly string ERROR_MESSAGE_TITLE = rm.GetString("ErrorMessageTitle");

	internal static readonly string INVALID_DIRECTORY = rm.GetString("InvalidDirectory");

	internal static readonly string INVALID_BLANK_DIRECTORY = rm.GetString("InvalidBlankDirectory");

	internal static readonly string ACCESS_ERROR = rm.GetString("AccessError");

	internal static readonly string ACCESS_ERROR_SPECIFIC = rm.GetString("AccessErrorSpecific");

	internal static readonly string UPDATE_ERROR_SPECIFIC = rm.GetString("UpdateErrorSpecific");

	internal static readonly string CONFIRM_FOLDER_CREATE = rm.GetString("ConfirmFolderCreate");

	internal static readonly string CREATE_FOLDER_CAPTION = rm.GetString("CreateFolderCaption");

	internal static readonly string UNKNOWN_SERVICE = rm.GetString("UnknownService");

	internal static readonly string CORRUPT_REGISTRY = rm.GetString("CorruptRegistry");

	internal static readonly string USER_IS_NOT_ADMIN = rm.GetString("UserIsNotAdmin");

	internal static readonly string CORRUPT_REGISTRY_BOOTSTRAP = rm.GetString("CorruptRegistryBootstrap");

	internal static readonly string CANNOT_UPDATE_NON_ACTIVE_NODE = rm.GetString("CannotUpdateNonActiveNode");

	internal static readonly string GENERIC_CONFIGURATION_ERROR = rm.GetString("GenericConfigurationError");

	internal static readonly string PRIVACY_POLICY_LINK = rm.GetString("PrivacyPolicyLink");

	internal static readonly string PRIVACY_LINK = rm.GetString("PrivacyLinkText");

	internal static readonly string HELP_DIR_SUFFIX = rm.GetString("HelpDirSuffix");

	internal static readonly string HELP_FILE_NAME = rm.GetString("HelpFileName");
}
