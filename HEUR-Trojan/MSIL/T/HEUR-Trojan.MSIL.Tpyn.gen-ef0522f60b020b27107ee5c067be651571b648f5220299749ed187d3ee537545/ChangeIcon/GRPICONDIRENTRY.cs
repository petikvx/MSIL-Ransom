using System.Runtime.InteropServices;

namespace ChangeIcon;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public struct GRPICONDIRENTRY
{
	public byte bWidth;

	public byte bHeight;

	public byte bColorCount;

	public byte bReserved;

	public ushort wPlanes;

	public ushort wBitCount;

	public uint dwBytesInRes;

	public ushort nID;
}
