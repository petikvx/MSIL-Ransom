using System;
using System.Runtime.InteropServices;
using System.Security;

namespace MetroFramework.Native;

[SuppressUnmanagedCodeSecurity]
internal sealed class WinCaret
{
	private IntPtr controlHandle;

	[DllImport("User32.dll")]
	private static extern bool CreateCaret(IntPtr hWnd, int hBitmap, int nWidth, int nHeight);

	[DllImport("User32.dll")]
	private static extern bool SetCaretPos(int x, int y);

	[DllImport("User32.dll")]
	private static extern bool DestroyCaret();

	[DllImport("User32.dll")]
	private static extern bool ShowCaret(IntPtr hWnd);

	[DllImport("User32.dll")]
	public static extern bool HideCaret(IntPtr hWnd);

	public WinCaret(IntPtr ownerHandle)
	{
		controlHandle = ownerHandle;
	}

	public bool Create(int width, int height)
	{
		return CreateCaret(controlHandle, 0, width, height);
	}

	public void Hide()
	{
		HideCaret(controlHandle);
	}

	public void Show()
	{
		ShowCaret(controlHandle);
	}

	public bool SetPosition(int x, int y)
	{
		return SetCaretPos(x, y);
	}

	public void Destroy()
	{
		DestroyCaret();
	}
}
