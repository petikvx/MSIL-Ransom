using System;
using System.IO;
using System.Reflection;
using System.Text;
using CSharpx;
using CommandLine.Infrastructure;

namespace CommandLine.Text;

public class HeadingInfo
{
	private readonly string programName;

	private readonly string version;

	public static HeadingInfo Empty => new HeadingInfo("");

	public static HeadingInfo Default
	{
		get
		{
			string text = ReflectionHelper.GetAttribute<AssemblyTitleAttribute>().MapValueOrDefault<AssemblyTitleAttribute, string>((AssemblyTitleAttribute titleAttribute) => titleAttribute.Title, ReflectionHelper.GetAssemblyName());
			string text2 = ReflectionHelper.GetAttribute<AssemblyInformationalVersionAttribute>().MapValueOrDefault<AssemblyInformationalVersionAttribute, string>((AssemblyInformationalVersionAttribute versionAttribute) => versionAttribute.InformationalVersion, ReflectionHelper.GetAssemblyVersion());
			return new HeadingInfo(text, text2);
		}
	}

	public HeadingInfo(string programName, string version = null)
	{
		if (string.IsNullOrWhiteSpace("programName"))
		{
			throw new ArgumentException("programName");
		}
		this.programName = programName;
		this.version = version;
	}

	public static implicit operator string(HeadingInfo info)
	{
		return info.ToString();
	}

	public override string ToString()
	{
		bool flag = string.IsNullOrEmpty(version);
		return new StringBuilder(programName.Length + ((!flag) ? (version.Length + 1) : 0)).Append(programName).AppendWhen(!flag, " ", version).ToString();
	}

	public void WriteMessage(string message, TextWriter writer)
	{
		if (string.IsNullOrWhiteSpace("message"))
		{
			throw new ArgumentException("message");
		}
		if (writer == null)
		{
			throw new ArgumentNullException("writer");
		}
		writer.WriteLine(new StringBuilder(programName.Length + message.Length + 2).Append(programName).Append(": ").Append(message)
			.ToString());
	}

	public void WriteMessage(string message)
	{
		WriteMessage(message, Console.Out);
	}

	public void WriteError(string message)
	{
		WriteMessage(message, Console.Error);
	}
}
