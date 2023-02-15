using System;
using System.Runtime.InteropServices;

namespace DnsClient;

internal class DisposableIntPtr : IDisposable
{
	private IntPtr _ptr;

	public IntPtr Ptr => _ptr;

	public bool IsValid { get; private set; } = true;


	private DisposableIntPtr()
	{
	}

	public static DisposableIntPtr Alloc(int size)
	{
		DisposableIntPtr disposableIntPtr = new DisposableIntPtr();
		try
		{
			disposableIntPtr._ptr = Marshal.AllocHGlobal(size);
			return disposableIntPtr;
		}
		catch (OutOfMemoryException)
		{
			disposableIntPtr.IsValid = false;
			return disposableIntPtr;
		}
	}

	public void Dispose()
	{
		Marshal.FreeHGlobal(_ptr);
	}
}
