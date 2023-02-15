namespace ChangeIcon;

public struct ICONDIRENTRY
{
	public byte bWidth;

	public byte bHeight;

	public byte bColorCount;

	public byte bReserved;

	public ushort wPlanes;

	public ushort wBitCount;

	public uint dwBytesInRes;

	public uint dwImageOffset;
}
