using System.Runtime.InteropServices;

namespace System.Data.SQLite;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate int SQLiteCollation(IntPtr puser, int len1, IntPtr pv1, int len2, IntPtr pv2);
