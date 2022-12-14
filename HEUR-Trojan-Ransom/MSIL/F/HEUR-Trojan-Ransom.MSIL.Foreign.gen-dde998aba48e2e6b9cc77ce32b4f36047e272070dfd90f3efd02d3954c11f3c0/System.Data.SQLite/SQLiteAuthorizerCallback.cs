using System.Runtime.InteropServices;

namespace System.Data.SQLite;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate SQLiteAuthorizerReturnCode SQLiteAuthorizerCallback(IntPtr pUserData, SQLiteAuthorizerActionCode actionCode, IntPtr pArgument1, IntPtr pArgument2, IntPtr pDatabase, IntPtr pAuthContext);
