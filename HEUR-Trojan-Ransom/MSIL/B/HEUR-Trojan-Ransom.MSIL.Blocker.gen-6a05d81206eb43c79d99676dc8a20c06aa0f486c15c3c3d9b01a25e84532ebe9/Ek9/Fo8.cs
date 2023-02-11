using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using p9K;

namespace Ek9;

[DesignerGenerated]
public class Fo8 : Form
{
	private IContainer components;

	private Button _BookingInfo;

	private Button _AlertNotification;

	internal Button I;

	internal Button V;

	internal Button E;

	internal Button p;

	public Fo8()
	{
		((Form)this).add_Load((EventHandler)Kc2);
		f6D();
	}

	protected override void t9M(bool q4A)
	{
		try
		{
			if (q4A && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(q4A);
		}
	}

	private void f6D()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
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
		Kx5(new Button());
		r7R(new Button());
		Nj1(new Button());
		b4Q(new Button());
		s0W(new Button());
		Fq6(new Button());
		((Control)this).SuspendLayout();
		((Control)Gg4()).set_Location(new Point(100, 94));
		((Control)Gg4()).set_Name("HouseEntry");
		((Control)Gg4()).set_Size(new Size(173, 47));
		((Control)Gg4()).set_TabIndex(0);
		((ButtonBase)Gg4()).set_Text("House Entry");
		((ButtonBase)Gg4()).set_UseVisualStyleBackColor(true);
		((Control)d2S()).set_Location(new Point(100, 210));
		((Control)d2S()).set_Name("RentInfo");
		((Control)d2S()).set_Size(new Size(173, 47));
		((Control)d2S()).set_TabIndex(1);
		((ButtonBase)d2S()).set_Text("Rent Info");
		((ButtonBase)d2S()).set_UseVisualStyleBackColor(true);
		((Control)t3S()).set_Location(new Point(100, 313));
		((Control)t3S()).set_Name("EBillInfo");
		((Control)t3S()).set_Size(new Size(173, 47));
		((Control)t3S()).set_TabIndex(2);
		((ButtonBase)t3S()).set_Text("E-Bill Info");
		((ButtonBase)t3S()).set_UseVisualStyleBackColor(true);
		((Control)Se1()).set_Location(new Point(100, 421));
		((Control)Se1()).set_Name("BookingInfo");
		((Control)Se1()).set_Size(new Size(173, 47));
		((Control)Se1()).set_TabIndex(3);
		((ButtonBase)Se1()).set_Text("Booking Info");
		((ButtonBase)Se1()).set_UseVisualStyleBackColor(true);
		((Control)Xr7()).set_Location(new Point(100, 541));
		((Control)Xr7()).set_Name("AlertNotification");
		((Control)Xr7()).set_Size(new Size(173, 47));
		((Control)Xr7()).set_TabIndex(4);
		((ButtonBase)Xr7()).set_Text("Alert Notification");
		((ButtonBase)Xr7()).set_UseVisualStyleBackColor(true);
		((Control)p6H()).set_Location(new Point(530, 313));
		((Control)p6H()).set_Name("Button1");
		((Control)p6H()).set_Size(new Size(232, 68));
		((Control)p6H()).set_TabIndex(5);
		((ButtonBase)p6H()).set_Text("<----");
		((ButtonBase)p6H()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(924, 694));
		((Control)this).get_Controls().Add((Control)(object)p6H());
		((Control)this).get_Controls().Add((Control)(object)Xr7());
		((Control)this).get_Controls().Add((Control)(object)Se1());
		((Control)this).get_Controls().Add((Control)(object)t3S());
		((Control)this).get_Controls().Add((Control)(object)d2S());
		((Control)this).get_Controls().Add((Control)(object)Gg4());
		((Control)this).set_Name("Admin_Function");
		((Form)this).set_Text("Admin_Function");
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Button Gg4()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kx5(Button En8)
	{
		EventHandler eventHandler = Qe7;
		Button i = I;
		if (i != null)
		{
			((Control)i).remove_Click(eventHandler);
		}
		Button val = (I = En8);
		i = I;
		if (i != null)
		{
			((Control)i).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button d2S()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r7R(Button p0X)
	{
		EventHandler eventHandler = Yz7;
		Button v = V;
		if (v != null)
		{
			((Control)v).remove_Click(eventHandler);
		}
		Button val = (V = p0X);
		v = V;
		if (v != null)
		{
			((Control)v).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button t3S()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nj1(Button Gk1)
	{
		EventHandler eventHandler = g2W;
		Button e = E;
		if (e != null)
		{
			((Control)e).remove_Click(eventHandler);
		}
		Button val = (E = Gk1);
		e = E;
		if (e != null)
		{
			((Control)e).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Se1()
	{
		return _BookingInfo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b4Q(Button Gm7)
	{
		EventHandler eventHandler = Sj0;
		Button bookingInfo = _BookingInfo;
		if (bookingInfo != null)
		{
			((Control)bookingInfo).remove_Click(eventHandler);
		}
		_BookingInfo = Gm7;
		bookingInfo = _BookingInfo;
		if (bookingInfo != null)
		{
			((Control)bookingInfo).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Xr7()
	{
		return _AlertNotification;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s0W(Button Hd0)
	{
		EventHandler eventHandler = k8F;
		Button alertNotification = _AlertNotification;
		if (alertNotification != null)
		{
			((Control)alertNotification).remove_Click(eventHandler);
		}
		_AlertNotification = Hd0;
		alertNotification = _AlertNotification;
		if (alertNotification != null)
		{
			((Control)alertNotification).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button p6H()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fq6(Button Fw1)
	{
		EventHandler eventHandler = Lc2;
		Button val = p;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (p = Fw1);
		val = p;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	private void Qe7(object sender, EventArgs e)
	{
		((Control)Gj9.Forms.Cx1()).Show();
	}

	private void Yz7(object sender, EventArgs e)
	{
		((Control)Gj9.Forms.t8C()).Show();
	}

	private void g2W(object sender, EventArgs e)
	{
		((Control)Gj9.Forms.Ad3()).Show();
	}

	private void Sj0(object sender, EventArgs e)
	{
		((Control)Gj9.Forms.s3J()).Show();
	}

	private void k8F(object sender, EventArgs e)
	{
		((Control)Gj9.Forms.s2P()).Show();
	}

	internal static bool Mo4(int Ef1)
	{
		string[] array = new string[4] { "L", "o", "a", "d" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "Load", false) != 0)
		{
			string text = array[new Random().Next(0, checked(Ef1 + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "L", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "o", "a", "d" };
				Ef1 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "L", false) == 0 && Operators.CompareString(text, "o", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "a", "d" };
				Ef1 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Lo", false) == 0 && Operators.CompareString(text, "a", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "d" };
				Ef1 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Loa", false) == 0 && Operators.CompareString(text, "d", false) == 0)
			{
				stringBuilder.Append(text);
			}
		}
		if (Operators.CompareString(stringBuilder.ToString(), "Load", false) == 0)
		{
			return true;
		}
		return false;
	}

	private void Lc2(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Kc2(object sender, EventArgs e)
	{
	}
}
