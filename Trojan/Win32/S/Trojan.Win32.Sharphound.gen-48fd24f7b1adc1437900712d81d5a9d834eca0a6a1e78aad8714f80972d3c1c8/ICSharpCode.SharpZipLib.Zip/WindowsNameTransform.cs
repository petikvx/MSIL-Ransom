using System;
using System.IO;
using System.Text;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Zip;

public class WindowsNameTransform : INameTransform
{
	private const int MaxPath = 260;

	private string _baseDirectory;

	private bool _trimIncomingPaths;

	private char _replacementChar = '_';

	private bool _allowParentTraversal;

	private static readonly char[] InvalidEntryChars = new char[39]
	{
		'"', '<', '>', '|', '\0', '\u0001', '\u0002', '\u0003', '\u0004', '\u0005',
		'\u0006', '\a', '\b', '\t', '\n', '\v', '\f', '\r', '\u000e', '\u000f',
		'\u0010', '\u0011', '\u0012', '\u0013', '\u0014', '\u0015', '\u0016', '\u0017', '\u0018', '\u0019',
		'\u001a', '\u001b', '\u001c', '\u001d', '\u001e', '\u001f', '*', '?', ':'
	};

	public string BaseDirectory
	{
		get
		{
			return _baseDirectory;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			_baseDirectory = Path.GetFullPath(value);
		}
	}

	public bool AllowParentTraversal
	{
		get
		{
			return _allowParentTraversal;
		}
		set
		{
			_allowParentTraversal = value;
		}
	}

	public bool TrimIncomingPaths
	{
		get
		{
			return _trimIncomingPaths;
		}
		set
		{
			_trimIncomingPaths = value;
		}
	}

	public char Replacement
	{
		get
		{
			return _replacementChar;
		}
		set
		{
			int num = 0;
			while (true)
			{
				if (num < InvalidEntryChars.Length)
				{
					if (InvalidEntryChars[num] != value)
					{
						num++;
						continue;
					}
					throw new ArgumentException("invalid path character");
				}
				if (value != Path.DirectorySeparatorChar && value != Path.AltDirectorySeparatorChar)
				{
					break;
				}
				throw new ArgumentException("invalid replacement character");
			}
			_replacementChar = value;
		}
	}

	public WindowsNameTransform(string baseDirectory, bool allowParentTraversal = false)
	{
		BaseDirectory = baseDirectory ?? throw new ArgumentNullException("baseDirectory", "Directory name is invalid");
		AllowParentTraversal = allowParentTraversal;
	}

	public WindowsNameTransform()
	{
	}

	public string TransformDirectory(string name)
	{
		name = TransformFile(name);
		if (name.Length > 0)
		{
			while (true)
			{
				string text = name;
				char directorySeparatorChar = Path.DirectorySeparatorChar;
				if (text.EndsWith(directorySeparatorChar.ToString(), StringComparison.Ordinal))
				{
					name = name.Remove(name.Length - 1, 1);
					continue;
				}
				break;
			}
			return name;
		}
		throw new InvalidNameException("Cannot have an empty directory name");
	}

	public string TransformFile(string name)
	{
		if (name != null)
		{
			name = MakeValidName(name, _replacementChar);
			if (_trimIncomingPaths)
			{
				name = Path.GetFileName(name);
			}
			if (_baseDirectory != null)
			{
				name = Path.Combine(_baseDirectory, name);
				if (!_allowParentTraversal && !Path.GetFullPath(name).StartsWith(_baseDirectory, StringComparison.InvariantCultureIgnoreCase))
				{
					throw new InvalidNameException("Parent traversal in paths is not allowed");
				}
			}
		}
		else
		{
			name = string.Empty;
		}
		return name;
	}

	public static bool IsValidName(string name)
	{
		if (name != null && name.Length <= 260)
		{
			return string.Compare(name, MakeValidName(name, '_'), StringComparison.Ordinal) == 0;
		}
		return false;
	}

	public static string MakeValidName(string name, char replacement)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		string text = name;
		char directorySeparatorChar = Path.DirectorySeparatorChar;
		name = WindowsPathUtils.DropPathRoot(text.Replace("/", directorySeparatorChar.ToString()));
		while (name.Length > 0 && name[0] == Path.DirectorySeparatorChar)
		{
			name = name.Remove(0, 1);
		}
		while (name.Length > 0 && name[name.Length - 1] == Path.DirectorySeparatorChar)
		{
			name = name.Remove(name.Length - 1, 1);
		}
		int num;
		for (num = name.IndexOf(string.Format("{0}{0}", Path.DirectorySeparatorChar), StringComparison.Ordinal); num >= 0; num = name.IndexOf(string.Format("{0}{0}", Path.DirectorySeparatorChar), StringComparison.Ordinal))
		{
			name = name.Remove(num, 1);
		}
		num = name.IndexOfAny(InvalidEntryChars);
		if (num >= 0)
		{
			StringBuilder stringBuilder = new StringBuilder(name);
			while (num >= 0)
			{
				stringBuilder[num] = replacement;
				num = ((num < name.Length) ? name.IndexOfAny(InvalidEntryChars, num + 1) : (-1));
			}
			name = stringBuilder.ToString();
		}
		if (name.Length > 260)
		{
			throw new PathTooLongException();
		}
		return name;
	}
}
