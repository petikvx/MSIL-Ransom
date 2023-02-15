using System;
using System.Runtime.InteropServices;

namespace ChangeIcon;

internal class IconInjector
{
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern int UpdateResource(IntPtr hUpdate, uint lpType, uint lpName, ushort wLanguage, byte[] lpData, uint cbData);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr BeginUpdateResource(string pFileName, [MarshalAs(UnmanagedType.Bool)] bool bDeleteExistingResources);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool EndUpdateResource(IntPtr hUpdate, bool fDiscard);

	public static void InjectIcon(string execFileName, string iconFileName)
	{
		try
		{
			InjectIcon(execFileName, iconFileName, 1u, 1u);
		}
		catch
		{
		}
	}

	private static void InjectIcon(string execFileName, string iconFileName, uint iconGroupID, uint iconBaseID)
	{
		IconFile iconFile = new IconFile();
		iconFile.Load(iconFileName);
		IntPtr hUpdate = BeginUpdateResource(execFileName, bDeleteExistingResources: false);
		byte[] array = iconFile.CreateIconGroupData(iconBaseID);
		UpdateResource(hUpdate, 14u, iconGroupID, 0, array, (uint)array.Length);
		for (int i = 0; i < iconFile.GetImageCount(); i++)
		{
			byte[] imageData = iconFile.GetImageData(i);
			UpdateResource(hUpdate, 3u, (uint)(iconBaseID + i), 0, imageData, (uint)imageData.Length);
		}
		EndUpdateResource(hUpdate, fDiscard: false);
	}

	public static void RemoveIcon(string execFileName)
	{
		try
		{
			RemoveIcon(execFileName, 1u, 1u);
		}
		catch
		{
		}
	}

	private static void RemoveIcon(string execFileName, uint iconGroupID, uint iconBaseID)
	{
		IntPtr hUpdate = BeginUpdateResource(execFileName, bDeleteExistingResources: false);
		UpdateResource(hUpdate, 14u, iconGroupID, 0, null, 0u);
		EndUpdateResource(hUpdate, fDiscard: false);
	}
}
