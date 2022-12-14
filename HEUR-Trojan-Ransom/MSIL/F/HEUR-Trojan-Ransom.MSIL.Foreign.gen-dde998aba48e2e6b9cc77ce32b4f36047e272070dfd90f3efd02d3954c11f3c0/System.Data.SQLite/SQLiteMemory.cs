namespace System.Data.SQLite;

internal static class SQLiteMemory
{
	public static IntPtr Allocate(int size)
	{
		return UnsafeNativeMethods.sqlite3_malloc(size);
	}

	public static int Size(IntPtr pMemory)
	{
		return UnsafeNativeMethods.sqlite3_malloc_size_interop(pMemory);
	}

	public static void Free(IntPtr pMemory)
	{
		UnsafeNativeMethods.sqlite3_free(pMemory);
	}
}
