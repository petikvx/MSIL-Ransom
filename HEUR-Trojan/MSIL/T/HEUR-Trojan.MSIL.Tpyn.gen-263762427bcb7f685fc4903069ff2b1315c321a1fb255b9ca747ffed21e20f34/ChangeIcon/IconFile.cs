using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;

namespace ChangeIcon;

public class IconFile
{
	private ICONDIR _iconDir = default(ICONDIR);

	private ArrayList _iconEntry = new ArrayList();

	private ArrayList _iconImage = new ArrayList();

	public int GetImageCount()
	{
		return _iconDir.idCount;
	}

	public byte[] GetImageData(int index)
	{
		return (byte[])_iconImage[index];
	}

	public unsafe void Load(string fileName)
	{
		FileStream fileStream = null;
		BinaryReader binaryReader = null;
		byte[] array = null;
		try
		{
			fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			binaryReader = new BinaryReader(fileStream);
			array = binaryReader.ReadBytes(sizeof(ICONDIR));
			try
			{
				fixed (ICONDIR* ptr = &_iconDir)
				{
					Marshal.Copy(array, 0, (IntPtr)ptr, sizeof(ICONDIR));
				}
			}
			finally
			{
			}
			for (int i = 0; i < _iconDir.idCount; i++)
			{
				ICONDIRENTRY iCONDIRENTRY = default(ICONDIRENTRY);
				array = binaryReader.ReadBytes(sizeof(ICONDIRENTRY));
				ICONDIRENTRY* ptr2 = &iCONDIRENTRY;
				Marshal.Copy(array, 0, (IntPtr)ptr2, sizeof(ICONDIRENTRY));
				_iconEntry.Add(iCONDIRENTRY);
			}
			for (int j = 0; j < _iconDir.idCount; j++)
			{
				fileStream.Position = ((ICONDIRENTRY)_iconEntry[j]).dwImageOffset;
				byte[] value = binaryReader.ReadBytes((int)((ICONDIRENTRY)_iconEntry[j]).dwBytesInRes);
				_iconImage.Add(value);
			}
			_ = (byte[])_iconImage[0];
		}
		catch
		{
		}
		finally
		{
			binaryReader?.Close();
			fileStream?.Close();
		}
	}

	private unsafe int SizeOfIconGroupData()
	{
		return sizeof(ICONDIR) + sizeof(GRPICONDIRENTRY) * GetImageCount();
	}

	public unsafe byte[] CreateIconGroupData(uint nBaseID)
	{
		byte[] array = new byte[SizeOfIconGroupData()];
		fixed (ICONDIR* ptr = &_iconDir)
		{
			Marshal.Copy((IntPtr)ptr, array, 0, sizeof(ICONDIR));
		}
		int num = sizeof(ICONDIR);
		for (int i = 0; i < GetImageCount(); i++)
		{
			GRPICONDIRENTRY gRPICONDIRENTRY = default(GRPICONDIRENTRY);
			BITMAPINFOHEADER bITMAPINFOHEADER = default(BITMAPINFOHEADER);
			BITMAPINFOHEADER* ptr2 = &bITMAPINFOHEADER;
			Marshal.Copy(GetImageData(i), 0, (IntPtr)ptr2, sizeof(BITMAPINFOHEADER));
			gRPICONDIRENTRY.bWidth = ((ICONDIRENTRY)_iconEntry[i]).bWidth;
			gRPICONDIRENTRY.bHeight = ((ICONDIRENTRY)_iconEntry[i]).bHeight;
			gRPICONDIRENTRY.bColorCount = ((ICONDIRENTRY)_iconEntry[i]).bColorCount;
			gRPICONDIRENTRY.bReserved = ((ICONDIRENTRY)_iconEntry[i]).bReserved;
			gRPICONDIRENTRY.wPlanes = bITMAPINFOHEADER.biPlanes;
			gRPICONDIRENTRY.wBitCount = bITMAPINFOHEADER.biBitCount;
			gRPICONDIRENTRY.dwBytesInRes = ((ICONDIRENTRY)_iconEntry[i]).dwBytesInRes;
			gRPICONDIRENTRY.nID = (ushort)(nBaseID + i);
			GRPICONDIRENTRY* ptr3 = &gRPICONDIRENTRY;
			Marshal.Copy((IntPtr)ptr3, array, num, Marshal.SizeOf((object)gRPICONDIRENTRY));
			num += sizeof(GRPICONDIRENTRY);
		}
		return array;
	}
}
