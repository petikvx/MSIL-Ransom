namespace System.Data.SQLite;

[Flags]
public enum SQLiteConnectionFlags : long
{
	None = 0L,
	LogPrepare = 1L,
	LogPreBind = 2L,
	LogBind = 4L,
	LogCallbackException = 8L,
	LogBackup = 0x10L,
	NoExtensionFunctions = 0x20L,
	BindUInt32AsInt64 = 0x40L,
	BindAllAsText = 0x80L,
	GetAllAsText = 0x100L,
	NoLoadExtension = 0x200L,
	NoCreateModule = 0x400L,
	NoBindFunctions = 0x800L,
	NoLogModule = 0x1000L,
	LogModuleError = 0x2000L,
	LogModuleException = 0x4000L,
	TraceWarning = 0x8000L,
	ConvertInvariantText = 0x10000L,
	BindInvariantText = 0x20000L,
	NoConnectionPool = 0x40000L,
	UseConnectionPool = 0x80000L,
	UseConnectionTypes = 0x100000L,
	NoGlobalTypes = 0x200000L,
	StickyHasRows = 0x400000L,
	StrictEnlistment = 0x800000L,
	MapIsolationLevels = 0x1000000L,
	DetectTextAffinity = 0x2000000L,
	DetectStringType = 0x4000000L,
	NoConvertSettings = 0x8000000L,
	BindDateTimeWithKind = 0x10000000L,
	RollbackOnException = 0x20000000L,
	DenyOnException = 0x40000000L,
	InterruptOnException = 0x80000000L,
	UnbindFunctionsOnClose = 0x100000000L,
	NoVerifyTextAffinity = 0x200000000L,
	UseConnectionBindValueCallbacks = 0x400000000L,
	UseConnectionReadValueCallbacks = 0x800000000L,
	UseParameterNameForTypeName = 0x1000000000L,
	UseParameterDbTypeForTypeName = 0x2000000000L,
	NoVerifyTypeAffinity = 0x4000000000L,
	AllowNestedTransactions = 0x8000000000L,
	BindAndGetAllAsText = 0x180L,
	ConvertAndBindInvariantText = 0x30000L,
	BindAndGetAllAsInvariantText = 0x20180L,
	ConvertAndBindAndGetAllAsInvariantText = 0x30180L,
	UseConnectionAllValueCallbacks = 0xC00000000L,
	UseParameterAnythingForTypeName = 0x3000000000L,
	LogAll = 0x601FL,
	Default = 0x4008L,
	DefaultAndLogAll = 0x601FL
}
