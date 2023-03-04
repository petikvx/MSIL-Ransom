using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Costura;

[CompilerGenerated]
internal static class AssemblyLoader
{
	private static readonly Dictionary<string, bool> nullCache = new Dictionary<string, bool>();

	private static readonly Dictionary<string, string> assemblyNames = new Dictionary<string, string>();

	private static readonly Dictionary<string, string> symbolNames = new Dictionary<string, string>();

	private static ResolveEventHandler CS_0024_003C_003E9__CachedAnonymousMethodDelegate1;

	private static string CultureToString(CultureInfo culture)
	{
		if (culture == null)
		{
			return "";
		}
		return AssemblyLoader.smethod_0(culture);
	}

	private static Assembly ReadExistingAssembly(AssemblyName name)
	{
		AppDomain appDomain_ = AssemblyLoader.smethod_1();
		Assembly[] array = AssemblyLoader.smethod_2(appDomain_);
		Assembly[] array2 = array;
		int num = 0;
		Assembly assembly;
		while (true)
		{
			if (num < array2.Length)
			{
				assembly = array2[num];
				AssemblyName assemblyName_ = AssemblyLoader.smethod_3(assembly);
				if (AssemblyLoader.smethod_5(AssemblyLoader.smethod_4(assemblyName_), AssemblyLoader.smethod_4(name), StringComparison.InvariantCultureIgnoreCase) && AssemblyLoader.smethod_5(CultureToString(AssemblyLoader.smethod_6(assemblyName_)), CultureToString(AssemblyLoader.smethod_6(name)), StringComparison.InvariantCultureIgnoreCase))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return assembly;
	}

	private static void CopyTo(Stream source, Stream destination)
	{
		byte[] array = new byte[81920];
		int int_;
		while ((int_ = AssemblyLoader.smethod_8(source, array, 0, array.Length)) != 0)
		{
			AssemblyLoader.smethod_7(destination, array, 0, int_);
		}
	}

	private static Stream LoadStream(string fullname)
	{
		Assembly assembly_ = AssemblyLoader.smethod_9();
		if (AssemblyLoader.smethod_10(fullname, ".zip"))
		{
			Stream stream = AssemblyLoader.smethod_11(assembly_, fullname);
			try
			{
				DeflateStream deflateStream = AssemblyLoader.smethod_12(stream, CompressionMode.Decompress);
				try
				{
					MemoryStream memoryStream = AssemblyLoader.smethod_13();
					CopyTo(deflateStream, memoryStream);
					AssemblyLoader.smethod_14((Stream)memoryStream, 0L);
					return memoryStream;
				}
				finally
				{
					if (deflateStream != null)
					{
						AssemblyLoader.smethod_15((IDisposable)deflateStream);
					}
				}
			}
			finally
			{
				if (stream != null)
				{
					AssemblyLoader.smethod_15((IDisposable)stream);
				}
			}
		}
		return AssemblyLoader.smethod_11(assembly_, fullname);
	}

	private static Stream LoadStream(Dictionary<string, string> resourceNames, string name)
	{
		if (resourceNames.TryGetValue(name, out var value))
		{
			return LoadStream(value);
		}
		return null;
	}

	private static byte[] ReadStream(Stream stream)
	{
		byte[] array = new byte[AssemblyLoader.smethod_16(stream)];
		AssemblyLoader.smethod_8(stream, array, 0, array.Length);
		return array;
	}

	private static Assembly ReadFromEmbeddedResources(Dictionary<string, string> assemblyNames, Dictionary<string, string> symbolNames, AssemblyName requestedAssemblyName)
	{
		string text = AssemblyLoader.smethod_17(AssemblyLoader.smethod_4(requestedAssemblyName));
		if (AssemblyLoader.smethod_6(requestedAssemblyName) != null && !AssemblyLoader.smethod_18(AssemblyLoader.smethod_0(AssemblyLoader.smethod_6(requestedAssemblyName))))
		{
			text = AssemblyLoader.smethod_19("{0}.{1}", (object)AssemblyLoader.smethod_0(AssemblyLoader.smethod_6(requestedAssemblyName)), (object)text);
		}
		Stream stream = LoadStream(assemblyNames, text);
		byte[] byte_;
		try
		{
			if (stream == null)
			{
				return null;
			}
			byte_ = ReadStream(stream);
		}
		finally
		{
			if (stream != null)
			{
				AssemblyLoader.smethod_15((IDisposable)stream);
			}
		}
		Stream stream2 = LoadStream(symbolNames, text);
		try
		{
			if (stream2 != null)
			{
				byte[] byte_2 = ReadStream(stream2);
				return AssemblyLoader.smethod_20(byte_, byte_2);
			}
		}
		finally
		{
			if (stream2 != null)
			{
				AssemblyLoader.smethod_15((IDisposable)stream2);
			}
		}
		return AssemblyLoader.smethod_21(byte_);
	}

	public static Assembly ResolveAssembly(string assemblyName)
	{
		if (nullCache.ContainsKey(assemblyName))
		{
			return null;
		}
		AssemblyName assemblyName2 = AssemblyLoader.smethod_22(assemblyName);
		Assembly assembly = ReadExistingAssembly(assemblyName2);
		if ((object)assembly != null)
		{
			return assembly;
		}
		assembly = ReadFromEmbeddedResources(assemblyNames, symbolNames, assemblyName2);
		if ((object)assembly == null)
		{
			nullCache.Add(assemblyName, value: true);
			if (AssemblyLoader.smethod_23(assemblyName2) == AssemblyNameFlags.Retargetable)
			{
				assembly = AssemblyLoader.smethod_24(assemblyName2);
			}
		}
		return assembly;
	}

	static AssemblyLoader()
	{
		assemblyNames.Add("newtonsoft.json", "costura.newtonsoft.json.dll.zip");
	}

	private static Assembly _003CAttach_003Eb__0(object s, ResolveEventArgs e)
	{
		return ResolveAssembly(AssemblyLoader.smethod_25(e));
	}

	public static void Attach()
	{
		AppDomain appDomain_ = AssemblyLoader.smethod_1();
		AssemblyLoader.smethod_26(appDomain_, (ResolveEventHandler)((object s, ResolveEventArgs e) => ResolveAssembly(AssemblyLoader.smethod_25(e))));
	}

	static string smethod_0(CultureInfo cultureInfo_0)
	{
		return cultureInfo_0.Name;
	}

	static AppDomain smethod_1()
	{
		return AppDomain.CurrentDomain;
	}

	static Assembly[] smethod_2(AppDomain appDomain_0)
	{
		return appDomain_0.GetAssemblies();
	}

	static AssemblyName smethod_3(Assembly assembly_0)
	{
		return assembly_0.GetName();
	}

	static string smethod_4(AssemblyName assemblyName_0)
	{
		return assemblyName_0.Name;
	}

	static bool smethod_5(string string_0, string string_1, StringComparison stringComparison_0)
	{
		return string.Equals(string_0, string_1, stringComparison_0);
	}

	static CultureInfo smethod_6(AssemblyName assemblyName_0)
	{
		return assemblyName_0.CultureInfo;
	}

	static void smethod_7(Stream stream_0, byte[] byte_0, int int_0, int int_1)
	{
		stream_0.Write(byte_0, int_0, int_1);
	}

	static int smethod_8(Stream stream_0, byte[] byte_0, int int_0, int int_1)
	{
		return stream_0.Read(byte_0, int_0, int_1);
	}

	static Assembly smethod_9()
	{
		return Assembly.GetExecutingAssembly();
	}

	static bool smethod_10(string string_0, string string_1)
	{
		return string_0.EndsWith(string_1);
	}

	static Stream smethod_11(Assembly assembly_0, string string_0)
	{
		return assembly_0.GetManifestResourceStream(string_0);
	}

	static DeflateStream smethod_12(Stream stream_0, CompressionMode compressionMode_0)
	{
		return new DeflateStream(stream_0, compressionMode_0);
	}

	static MemoryStream smethod_13()
	{
		return new MemoryStream();
	}

	static void smethod_14(Stream stream_0, long long_0)
	{
		stream_0.Position = long_0;
	}

	static void smethod_15(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static long smethod_16(Stream stream_0)
	{
		return stream_0.Length;
	}

	static string smethod_17(string string_0)
	{
		return string_0.ToLowerInvariant();
	}

	static bool smethod_18(string string_0)
	{
		return string.IsNullOrEmpty(string_0);
	}

	static string smethod_19(string string_0, object object_0, object object_1)
	{
		return string.Format(string_0, object_0, object_1);
	}

	static Assembly smethod_20(byte[] byte_0, byte[] byte_1)
	{
		return Assembly.Load(byte_0, byte_1);
	}

	static Assembly smethod_21(byte[] byte_0)
	{
		return Assembly.Load(byte_0);
	}

	static AssemblyName smethod_22(string string_0)
	{
		return new AssemblyName(string_0);
	}

	static AssemblyNameFlags smethod_23(AssemblyName assemblyName_0)
	{
		return assemblyName_0.Flags;
	}

	static Assembly smethod_24(AssemblyName assemblyName_0)
	{
		return Assembly.Load(assemblyName_0);
	}

	static string smethod_25(ResolveEventArgs resolveEventArgs_0)
	{
		return resolveEventArgs_0.Name;
	}

	static void smethod_26(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0)
	{
		appDomain_0.AssemblyResolve += resolveEventHandler_0;
	}
}
