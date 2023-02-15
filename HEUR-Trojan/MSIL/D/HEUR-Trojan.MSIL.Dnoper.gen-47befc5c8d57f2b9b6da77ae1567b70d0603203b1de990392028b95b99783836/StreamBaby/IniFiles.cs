using System;
using System.Collections.Specialized;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace StreamBaby;

public class IniFiles
{
	public string FileName;

	[DllImport("kernel32")]
	private static extern bool WritePrivateProfileString(string section, string key, string val, string filePath);

	[DllImport("kernel32")]
	private static extern int GetPrivateProfileString(string section, string key, string def, byte[] retVal, int size, string filePath);

	public IniFiles(string AFileName)
	{
		FileInfo fileInfo = new FileInfo(AFileName);
		if (!fileInfo.Exists)
		{
			StreamWriter streamWriter = new StreamWriter(AFileName, append: false, Encoding.Default);
			try
			{
				streamWriter.Write("#表格配置档案");
				streamWriter.Close();
			}
			catch
			{
				throw new ApplicationException("Ini文件不存在");
			}
		}
		FileName = fileInfo.FullName;
	}

	public void WriteString(string Section, string Ident, string Value)
	{
		if (!WritePrivateProfileString(Section, Ident, Value, FileName))
		{
			throw new ApplicationException("写Ini文件出错");
		}
	}

	public string ReadString(string Section, string Ident, string Default)
	{
		byte[] array = new byte[65535];
		int privateProfileString = GetPrivateProfileString(Section, Ident, Default, array, array.GetUpperBound(0), FileName);
		string @string = Encoding.GetEncoding(0).GetString(array);
		@string = @string.Substring(0, privateProfileString);
		return @string.Trim();
	}

	public int ReadInteger(string Section, string Ident, int Default)
	{
		string value = ReadString(Section, Ident, Convert.ToString(Default));
		try
		{
			return Convert.ToInt32(value);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return Default;
		}
	}

	public void WriteInteger(string Section, string Ident, int Value)
	{
		WriteString(Section, Ident, Value.ToString());
	}

	public bool ReadBool(string Section, string Ident, bool Default)
	{
		try
		{
			return Convert.ToBoolean(ReadString(Section, Ident, Convert.ToString(Default)));
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return Default;
		}
	}

	public void WriteBool(string Section, string Ident, bool Value)
	{
		WriteString(Section, Ident, Convert.ToString(Value));
	}

	public void ReadSection(string Section, StringCollection Idents)
	{
		byte[] array = new byte[16384];
		int privateProfileString = GetPrivateProfileString(Section, null, null, array, array.GetUpperBound(0), FileName);
		GetStringsFromBuffer(array, privateProfileString, Idents);
	}

	private void GetStringsFromBuffer(byte[] Buffer, int bufLen, StringCollection Strings)
	{
		Strings.Clear();
		if (bufLen == 0)
		{
			return;
		}
		int num = 0;
		for (int i = 0; i < bufLen; i++)
		{
			if (Buffer[i] == 0 && i - num > 0)
			{
				string @string = Encoding.GetEncoding(0).GetString(Buffer, num, i - num);
				Strings.Add(@string);
				num = i + 1;
			}
		}
	}

	public void ReadSections(StringCollection SectionList)
	{
		byte[] array = new byte[65535];
		int num = 0;
		num = GetPrivateProfileString(null, null, null, array, array.GetUpperBound(0), FileName);
		GetStringsFromBuffer(array, num, SectionList);
	}

	public void ReadSectionValues(string Section, NameValueCollection Values)
	{
		StringCollection stringCollection = new StringCollection();
		ReadSection(Section, stringCollection);
		Values.Clear();
		StringEnumerator enumerator = stringCollection.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				Values.Add(current, ReadString(Section, current, ""));
			}
		}
		finally
		{
			if (enumerator is IDisposable disposable)
			{
				disposable.Dispose();
			}
		}
	}

	public void EraseSection(string Section)
	{
		if (!WritePrivateProfileString(Section, null, null, FileName))
		{
			throw new ApplicationException("无法清除Ini文件中的Section");
		}
	}

	public void DeleteKey(string Section, string Ident)
	{
		WritePrivateProfileString(Section, Ident, null, FileName);
	}

	public void UpdateFile()
	{
		WritePrivateProfileString(null, null, null, FileName);
	}

	public bool ValueExists(string Section, string Ident)
	{
		StringCollection stringCollection = new StringCollection();
		ReadSection(Section, stringCollection);
		return stringCollection.IndexOf(Ident) > -1;
	}

	~IniFiles()
	{
		UpdateFile();
	}

	public void Dispose()
	{
		try
		{
		}
		catch
		{
		}
	}
}
