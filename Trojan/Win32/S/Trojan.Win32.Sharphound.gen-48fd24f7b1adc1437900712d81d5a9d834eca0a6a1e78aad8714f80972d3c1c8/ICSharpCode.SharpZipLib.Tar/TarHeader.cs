using System;
using System.Text;

namespace ICSharpCode.SharpZipLib.Tar;

public class TarHeader
{
	public const int NAMELEN = 100;

	public const int MODELEN = 8;

	public const int UIDLEN = 8;

	public const int GIDLEN = 8;

	public const int CHKSUMLEN = 8;

	public const int CHKSUMOFS = 148;

	public const int SIZELEN = 12;

	public const int MAGICLEN = 6;

	public const int VERSIONLEN = 2;

	public const int MODTIMELEN = 12;

	public const int UNAMELEN = 32;

	public const int GNAMELEN = 32;

	public const int DEVLEN = 8;

	public const int PREFIXLEN = 155;

	public const byte LF_OLDNORM = 0;

	public const byte LF_NORMAL = 48;

	public const byte LF_LINK = 49;

	public const byte LF_SYMLINK = 50;

	public const byte LF_CHR = 51;

	public const byte LF_BLK = 52;

	public const byte LF_DIR = 53;

	public const byte LF_FIFO = 54;

	public const byte LF_CONTIG = 55;

	public const byte LF_GHDR = 103;

	public const byte LF_XHDR = 120;

	public const byte LF_ACL = 65;

	public const byte LF_GNU_DUMPDIR = 68;

	public const byte LF_EXTATTR = 69;

	public const byte LF_META = 73;

	public const byte LF_GNU_LONGLINK = 75;

	public const byte LF_GNU_LONGNAME = 76;

	public const byte LF_GNU_MULTIVOL = 77;

	public const byte LF_GNU_NAMES = 78;

	public const byte LF_GNU_SPARSE = 83;

	public const byte LF_GNU_VOLHDR = 86;

	public const string TMAGIC = "ustar";

	public const string GNU_TMAGIC = "ustar  ";

	private const long timeConversionFactor = 10000000L;

	private static readonly DateTime dateTime1970 = new DateTime(1970, 1, 1, 0, 0, 0, 0);

	private string name;

	private int mode;

	private int userId;

	private int groupId;

	private long size;

	private DateTime modTime;

	private int checksum;

	private bool isChecksumValid;

	private byte typeFlag;

	private string linkName;

	private string magic;

	private string version;

	private string userName;

	private string groupName;

	private int devMajor;

	private int devMinor;

	internal static int userIdAsSet;

	internal static int groupIdAsSet;

	internal static string userNameAsSet;

	internal static string groupNameAsSet = "None";

	internal static int defaultUserId;

	internal static int defaultGroupId;

	internal static string defaultGroupName = "None";

	internal static string defaultUser;

	public string Name
	{
		get
		{
			return name;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			name = value;
		}
	}

	public int Mode
	{
		get
		{
			return mode;
		}
		set
		{
			mode = value;
		}
	}

	public int UserId
	{
		get
		{
			return userId;
		}
		set
		{
			userId = value;
		}
	}

	public int GroupId
	{
		get
		{
			return groupId;
		}
		set
		{
			groupId = value;
		}
	}

	public long Size
	{
		get
		{
			return size;
		}
		set
		{
			if (value < 0L)
			{
				throw new ArgumentOutOfRangeException("value", "Cannot be less than zero");
			}
			size = value;
		}
	}

	public DateTime ModTime
	{
		get
		{
			return modTime;
		}
		set
		{
			if (value < dateTime1970)
			{
				throw new ArgumentOutOfRangeException("value", "ModTime cannot be before Jan 1st 1970");
			}
			modTime = new DateTime(value.Year, value.Month, value.Day, value.Hour, value.Minute, value.Second);
		}
	}

	public int Checksum => checksum;

	public bool IsChecksumValid => isChecksumValid;

	public byte TypeFlag
	{
		get
		{
			return typeFlag;
		}
		set
		{
			typeFlag = value;
		}
	}

	public string LinkName
	{
		get
		{
			return linkName;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			linkName = value;
		}
	}

	public string Magic
	{
		get
		{
			return magic;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			magic = value;
		}
	}

	public string Version
	{
		get
		{
			return version;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			version = value;
		}
	}

	public string UserName
	{
		get
		{
			return userName;
		}
		set
		{
			if (value != null)
			{
				userName = value.Substring(0, Math.Min(32, value.Length));
				return;
			}
			string text = "user";
			if (text.Length > 32)
			{
				text = text.Substring(0, 32);
			}
			userName = text;
		}
	}

	public string GroupName
	{
		get
		{
			return groupName;
		}
		set
		{
			if (value == null)
			{
				groupName = "None";
			}
			else
			{
				groupName = value;
			}
		}
	}

	public int DevMajor
	{
		get
		{
			return devMajor;
		}
		set
		{
			devMajor = value;
		}
	}

	public int DevMinor
	{
		get
		{
			return devMinor;
		}
		set
		{
			devMinor = value;
		}
	}

	public TarHeader()
	{
		Magic = "ustar";
		Version = " ";
		Name = "";
		LinkName = "";
		UserId = defaultUserId;
		GroupId = defaultGroupId;
		UserName = defaultUser;
		GroupName = defaultGroupName;
		Size = 0L;
	}

	[Obsolete("Use the Name property instead", true)]
	public string GetName()
	{
		return name;
	}

	public object Clone()
	{
		return MemberwiseClone();
	}

	public void ParseBuffer(byte[] header)
	{
		if (header == null)
		{
			throw new ArgumentNullException("header");
		}
		int num = 0;
		name = ParseName(header, 0, 100).ToString();
		num = 100;
		mode = (int)ParseOctal(header, 100, 8);
		num = 108;
		UserId = (int)ParseOctal(header, 108, 8);
		num = 116;
		GroupId = (int)ParseOctal(header, 116, 8);
		num = 124;
		Size = ParseBinaryOrOctal(header, 124, 12);
		num = 136;
		ModTime = GetDateTimeFromCTime(ParseOctal(header, 136, 12));
		num = 148;
		checksum = (int)ParseOctal(header, 148, 8);
		num = 156;
		num = 157;
		TypeFlag = header[156];
		LinkName = ParseName(header, 157, 100).ToString();
		num = 257;
		Magic = ParseName(header, 257, 6).ToString();
		num = 263;
		if (Magic == "ustar")
		{
			Version = ParseName(header, num, 2).ToString();
			num += 2;
			UserName = ParseName(header, num, 32).ToString();
			num += 32;
			GroupName = ParseName(header, num, 32).ToString();
			num += 32;
			DevMajor = (int)ParseOctal(header, num, 8);
			num += 8;
			DevMinor = (int)ParseOctal(header, num, 8);
			num += 8;
			string text = ParseName(header, num, 155).ToString();
			if (!string.IsNullOrEmpty(text))
			{
				Name = text + "/" + Name;
			}
		}
		isChecksumValid = Checksum == MakeCheckSum(header);
	}

	public void WriteHeader(byte[] outBuffer)
	{
		if (outBuffer == null)
		{
			throw new ArgumentNullException("outBuffer");
		}
		int num = 0;
		num = GetNameBytes(Name, outBuffer, 0, 100);
		num = GetOctalBytes(mode, outBuffer, num, 8);
		num = GetOctalBytes(UserId, outBuffer, num, 8);
		num = GetOctalBytes(GroupId, outBuffer, num, 8);
		num = GetBinaryOrOctalBytes(Size, outBuffer, num, 12);
		num = GetOctalBytes(GetCTime(ModTime), outBuffer, num, 12);
		int offset = num;
		for (int i = 0; i < 8; i++)
		{
			outBuffer[num++] = 32;
		}
		outBuffer[num++] = TypeFlag;
		num = GetNameBytes(LinkName, outBuffer, num, 100);
		num = GetAsciiBytes(Magic, 0, outBuffer, num, 6);
		num = GetNameBytes(Version, outBuffer, num, 2);
		num = GetNameBytes(UserName, outBuffer, num, 32);
		num = GetNameBytes(GroupName, outBuffer, num, 32);
		if (TypeFlag == 51 || TypeFlag == 52)
		{
			num = GetOctalBytes(DevMajor, outBuffer, num, 8);
			num = GetOctalBytes(DevMinor, outBuffer, num, 8);
		}
		while (num < outBuffer.Length)
		{
			outBuffer[num++] = 0;
		}
		checksum = ComputeCheckSum(outBuffer);
		GetCheckSumOctalBytes(checksum, outBuffer, offset, 8);
		isChecksumValid = true;
	}

	public override int GetHashCode()
	{
		return Name.GetHashCode();
	}

	public override bool Equals(object obj)
	{
		if (obj is TarHeader tarHeader)
		{
			return name == tarHeader.name && mode == tarHeader.mode && UserId == tarHeader.UserId && GroupId == tarHeader.GroupId && Size == tarHeader.Size && ModTime == tarHeader.ModTime && Checksum == tarHeader.Checksum && TypeFlag == tarHeader.TypeFlag && LinkName == tarHeader.LinkName && Magic == tarHeader.Magic && Version == tarHeader.Version && UserName == tarHeader.UserName && GroupName == tarHeader.GroupName && DevMajor == tarHeader.DevMajor && DevMinor == tarHeader.DevMinor;
		}
		return false;
	}

	internal static void SetValueDefaults(int userId, string userName, int groupId, string groupName)
	{
		defaultUserId = (userIdAsSet = userId);
		defaultUser = (userNameAsSet = userName);
		defaultGroupId = (groupIdAsSet = groupId);
		defaultGroupName = (groupNameAsSet = groupName);
	}

	internal static void RestoreSetValues()
	{
		defaultUserId = userIdAsSet;
		defaultUser = userNameAsSet;
		defaultGroupId = groupIdAsSet;
		defaultGroupName = groupNameAsSet;
	}

	private static long ParseBinaryOrOctal(byte[] header, int offset, int length)
	{
		if (header[offset] >= 128)
		{
			long num = 0L;
			for (int i = length - 8; i < length; i++)
			{
				num = (num << 8) | header[offset + i];
			}
			return num;
		}
		return ParseOctal(header, offset, length);
	}

	public static long ParseOctal(byte[] header, int offset, int length)
	{
		if (header == null)
		{
			throw new ArgumentNullException("header");
		}
		long num = 0L;
		bool flag = true;
		int num2 = offset + length;
		for (int i = offset; i < num2 && header[i] != 0; i++)
		{
			if (header[i] == 32 || header[i] == 48)
			{
				if (flag)
				{
					continue;
				}
				if (header[i] == 32)
				{
					break;
				}
			}
			flag = false;
			num = (num << 3) + (header[i] - 48);
		}
		return num;
	}

	public static StringBuilder ParseName(byte[] header, int offset, int length)
	{
		if (header == null)
		{
			throw new ArgumentNullException("header");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", "Cannot be less than zero");
		}
		if (length < 0)
		{
			throw new ArgumentOutOfRangeException("length", "Cannot be less than zero");
		}
		if (offset + length > header.Length)
		{
			throw new ArgumentException("Exceeds header size", "length");
		}
		StringBuilder stringBuilder = new StringBuilder(length);
		for (int i = offset; i < offset + length && header[i] != 0; i++)
		{
			stringBuilder.Append((char)header[i]);
		}
		return stringBuilder;
	}

	public static int GetNameBytes(StringBuilder name, int nameOffset, byte[] buffer, int bufferOffset, int length)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		return GetNameBytes(name.ToString(), nameOffset, buffer, bufferOffset, length);
	}

	public static int GetNameBytes(string name, int nameOffset, byte[] buffer, int bufferOffset, int length)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		int i;
		for (i = 0; i < length && nameOffset + i < name.Length; i++)
		{
			buffer[bufferOffset + i] = (byte)name[nameOffset + i];
		}
		for (; i < length; i++)
		{
			buffer[bufferOffset + i] = 0;
		}
		return bufferOffset + length;
	}

	public static int GetNameBytes(StringBuilder name, byte[] buffer, int offset, int length)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		return GetNameBytes(name.ToString(), 0, buffer, offset, length);
	}

	public static int GetNameBytes(string name, byte[] buffer, int offset, int length)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		return GetNameBytes(name, 0, buffer, offset, length);
	}

	public static int GetAsciiBytes(string toAdd, int nameOffset, byte[] buffer, int bufferOffset, int length)
	{
		if (toAdd == null)
		{
			throw new ArgumentNullException("toAdd");
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		int i;
		for (i = 0; i < length && nameOffset + i < toAdd.Length; i++)
		{
			buffer[bufferOffset + i] = (byte)toAdd[nameOffset + i];
		}
		for (; i < length; i++)
		{
			buffer[bufferOffset + i] = 0;
		}
		return bufferOffset + length;
	}

	public static int GetOctalBytes(long value, byte[] buffer, int offset, int length)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		int num = length - 1;
		buffer[offset + num] = 0;
		num--;
		if (value > 0L)
		{
			long num2 = value;
			while (num >= 0 && num2 > 0L)
			{
				buffer[offset + num] = (byte)(48 + (byte)(num2 & 7L));
				num2 >>= 3;
				num--;
			}
		}
		while (num >= 0)
		{
			buffer[offset + num] = 48;
			num--;
		}
		return offset + length;
	}

	private static int GetBinaryOrOctalBytes(long value, byte[] buffer, int offset, int length)
	{
		if (value > 8589934591L)
		{
			for (int num = length - 1; num > 0; num--)
			{
				buffer[offset + num] = (byte)value;
				value >>= 8;
			}
			buffer[offset] = 128;
			return offset + length;
		}
		return GetOctalBytes(value, buffer, offset, length);
	}

	private static void GetCheckSumOctalBytes(long value, byte[] buffer, int offset, int length)
	{
		GetOctalBytes(value, buffer, offset, length - 1);
	}

	private static int ComputeCheckSum(byte[] buffer)
	{
		int num = 0;
		for (int i = 0; i < buffer.Length; i++)
		{
			num += buffer[i];
		}
		return num;
	}

	private static int MakeCheckSum(byte[] buffer)
	{
		int num = 0;
		for (int i = 0; i < 148; i++)
		{
			num += buffer[i];
		}
		for (int j = 0; j < 8; j++)
		{
			num += 32;
		}
		for (int k = 156; k < buffer.Length; k++)
		{
			num += buffer[k];
		}
		return num;
	}

	private static int GetCTime(DateTime dateTime)
	{
		long ticks = dateTime.Ticks;
		DateTime dateTime2 = dateTime1970;
		return (int)((ticks - dateTime2.Ticks) / 10000000L);
	}

	private static DateTime GetDateTimeFromCTime(long ticks)
	{
		try
		{
			DateTime dateTime = dateTime1970;
			return new DateTime(dateTime.Ticks + ticks * 10000000L);
		}
		catch (ArgumentOutOfRangeException)
		{
			return dateTime1970;
		}
	}
}
