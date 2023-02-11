using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using p0H8;

namespace Tw5;

[DesignerGenerated]
public class Gd8 : Form
{
	private IContainer components;

	internal virtual Button HouseEntry
	{
		[CompilerGenerated]
		get
		{
			return _HouseEntry;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = m2Q;
			Button houseEntry = _HouseEntry;
			if (houseEntry != null)
			{
				((Control)houseEntry).remove_Click(eventHandler);
			}
			_HouseEntry = value;
			houseEntry = _HouseEntry;
			if (houseEntry != null)
			{
				((Control)houseEntry).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button RentInfo
	{
		[CompilerGenerated]
		get
		{
			return _RentInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Yz5;
			Button rentInfo = _RentInfo;
			if (rentInfo != null)
			{
				((Control)rentInfo).remove_Click(eventHandler);
			}
			_RentInfo = value;
			rentInfo = _RentInfo;
			if (rentInfo != null)
			{
				((Control)rentInfo).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button EBillInfo
	{
		[CompilerGenerated]
		get
		{
			return _EBillInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = j2Y;
			Button eBillInfo = _EBillInfo;
			if (eBillInfo != null)
			{
				((Control)eBillInfo).remove_Click(eventHandler);
			}
			_EBillInfo = value;
			eBillInfo = _EBillInfo;
			if (eBillInfo != null)
			{
				((Control)eBillInfo).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button BookingInfo
	{
		[CompilerGenerated]
		get
		{
			return _BookingInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = a2H;
			Button bookingInfo = _BookingInfo;
			if (bookingInfo != null)
			{
				((Control)bookingInfo).remove_Click(eventHandler);
			}
			_BookingInfo = value;
			bookingInfo = _BookingInfo;
			if (bookingInfo != null)
			{
				((Control)bookingInfo).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button AlertNotification
	{
		[CompilerGenerated]
		get
		{
			return _AlertNotification;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = a8A;
			Button alertNotification = _AlertNotification;
			if (alertNotification != null)
			{
				((Control)alertNotification).remove_Click(eventHandler);
			}
			_AlertNotification = value;
			alertNotification = _AlertNotification;
			if (alertNotification != null)
			{
				((Control)alertNotification).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Pp3;
			Button button = _Button1;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	public Gd8()
	{
		((Form)this).add_Load((EventHandler)Xj5);
		x6Q();
	}

	[DebuggerNonUserCode]
	protected override void d2X(bool d8P)
	{
		try
		{
			if (d8P && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(d8P);
		}
	}

	[DebuggerStepThrough]
	private void x6Q()
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
		HouseEntry = new Button();
		RentInfo = new Button();
		EBillInfo = new Button();
		BookingInfo = new Button();
		AlertNotification = new Button();
		Button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)HouseEntry).set_Location(new Point(100, 94));
		((Control)HouseEntry).set_Name("HouseEntry");
		((Control)HouseEntry).set_Size(new Size(173, 47));
		((Control)HouseEntry).set_TabIndex(0);
		((ButtonBase)HouseEntry).set_Text("House Entry");
		((ButtonBase)HouseEntry).set_UseVisualStyleBackColor(true);
		((Control)RentInfo).set_Location(new Point(100, 210));
		((Control)RentInfo).set_Name("RentInfo");
		((Control)RentInfo).set_Size(new Size(173, 47));
		((Control)RentInfo).set_TabIndex(1);
		((ButtonBase)RentInfo).set_Text("Rent Info");
		((ButtonBase)RentInfo).set_UseVisualStyleBackColor(true);
		((Control)EBillInfo).set_Location(new Point(100, 313));
		((Control)EBillInfo).set_Name("EBillInfo");
		((Control)EBillInfo).set_Size(new Size(173, 47));
		((Control)EBillInfo).set_TabIndex(2);
		((ButtonBase)EBillInfo).set_Text("E-Bill Info");
		((ButtonBase)EBillInfo).set_UseVisualStyleBackColor(true);
		((Control)BookingInfo).set_Location(new Point(100, 421));
		((Control)BookingInfo).set_Name("BookingInfo");
		((Control)BookingInfo).set_Size(new Size(173, 47));
		((Control)BookingInfo).set_TabIndex(3);
		((ButtonBase)BookingInfo).set_Text("Booking Info");
		((ButtonBase)BookingInfo).set_UseVisualStyleBackColor(true);
		((Control)AlertNotification).set_Location(new Point(100, 541));
		((Control)AlertNotification).set_Name("AlertNotification");
		((Control)AlertNotification).set_Size(new Size(173, 47));
		((Control)AlertNotification).set_TabIndex(4);
		((ButtonBase)AlertNotification).set_Text("Alert Notification");
		((ButtonBase)AlertNotification).set_UseVisualStyleBackColor(true);
		((Control)Button1).set_Location(new Point(530, 313));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(232, 68));
		((Control)Button1).set_TabIndex(5);
		((ButtonBase)Button1).set_Text("<----");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(924, 694));
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)AlertNotification);
		((Control)this).get_Controls().Add((Control)(object)BookingInfo);
		((Control)this).get_Controls().Add((Control)(object)EBillInfo);
		((Control)this).get_Controls().Add((Control)(object)RentInfo);
		((Control)this).get_Controls().Add((Control)(object)HouseEntry);
		((Control)this).set_Name("Admin_Function");
		((Form)this).set_Text("Admin_Function");
		((Control)this).ResumeLayout(false);
	}

	private void m2Q(object sender, EventArgs e)
	{
		((Control)Ga6q.Forms.House_Entry).Show();
	}

	private void Yz5(object sender, EventArgs e)
	{
		((Control)Ga6q.Forms.Rent_Info).Show();
	}

	private void j2Y(object sender, EventArgs e)
	{
		((Control)Ga6q.Forms.Pay_eletricity).Show();
	}

	private void a2H(object sender, EventArgs e)
	{
		((Control)Ga6q.Forms.Booking_Info).Show();
	}

	private void a8A(object sender, EventArgs e)
	{
		((Control)Ga6q.Forms.Alert_Notification).Show();
	}

	internal static bool Tf3(int Yc6)
	{
		string[] array = new string[4] { "L", "o", "a", "d" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "Load", false) != 0)
		{
			string text = array[new Random().Next(0, checked(Yc6 + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "L", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "o", "a", "d" };
				Yc6 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "L", false) == 0 && Operators.CompareString(text, "o", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "a", "d" };
				Yc6 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Lo", false) == 0 && Operators.CompareString(text, "a", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "d" };
				Yc6 = -1;
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

	private void Pp3(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Xj5(object sender, EventArgs e)
	{
	}
}
