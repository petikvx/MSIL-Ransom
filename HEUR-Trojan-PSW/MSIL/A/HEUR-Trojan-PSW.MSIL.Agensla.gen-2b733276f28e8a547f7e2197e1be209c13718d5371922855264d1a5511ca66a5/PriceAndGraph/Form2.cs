using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PriceAndGraph;

public class Form2 : Form
{
	private IContainer components = null;

	private Label label1;

	private NumericUpDown Angulo;

	private Label label2;

	private Label label3;

	private NumericUpDown Velocidad;

	private Label label4;

	private GroupBox groupBox1;

	private Label label10;

	private Label label9;

	private Label label8;

	private Label label7;

	private Label label6;

	private TextBox a_max;

	private TextBox distancia;

	private TextBox tiempo;

	private Label label5;

	private Button initBtn;

	public Form2()
	{
		InitializeComponent();
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	private void numericUpDown1_ValueChanged(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		double num = 0.0;
		double num2 = 0.0;
		double num3 = (double)Angulo.get_Value();
		double num4 = (double)Velocidad.get_Value();
		((Control)initBtn).set_Enabled(false);
		num2 = 1.0;
		while (num >= 0.0)
		{
			num = num4 * Math.Sin(num3 * Math.PI / 180.0) * num2 / 30.0 - 4.9 * Math.Pow(num2 / 30.0, 2.0);
			_ = num4 * Math.Cos(num3 * Math.PI / 180.0) * num2 / 30.0;
			num2 += 1.0;
		}
		((Control)tiempo).set_Text((num2 / 30.0).ToString() ?? "");
		((Control)distancia).set_Text((num4 * Math.Cos(num3 * Math.PI / 180.0) * num2 / 30.0).ToString() ?? "");
		((Control)a_max).set_Text((Math.Pow(num4 * Math.Sin(num3 * Math.PI / 180.0), 2.0) / 19.6).ToString() ?? "");
		((Control)initBtn).set_Enabled(true);
	}

	private void textBox3_TextChanged(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_074e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0925: Unknown result type (might be due to invalid IL or missing references)
		//IL_0983: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af2: Expected O, but got Unknown
		//IL_0af7: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		label1 = new Label();
		Angulo = new NumericUpDown();
		label2 = new Label();
		label3 = new Label();
		Velocidad = new NumericUpDown();
		label4 = new Label();
		groupBox1 = new GroupBox();
		initBtn = new Button();
		label10 = new Label();
		label9 = new Label();
		label8 = new Label();
		label7 = new Label();
		label6 = new Label();
		a_max = new TextBox();
		distancia = new TextBox();
		tiempo = new TextBox();
		label5 = new Label();
		((ISupportInitialize)Angulo).BeginInit();
		((ISupportInitialize)Velocidad).BeginInit();
		((Control)groupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(32, 48));
		((Control)label1).set_Margin(new Padding(8, 0, 8, 0));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(199, 32));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Angulo de tiro:");
		((Control)label1).add_Click((EventHandler)label1_Click);
		((Control)Angulo).set_Location(new Point(240, 38));
		((Control)Angulo).set_Margin(new Padding(8, 7, 8, 7));
		Angulo.set_Maximum(new decimal(new int[4] { 89, 0, 0, 0 }));
		Angulo.set_Minimum(new decimal(new int[4] { 1, 0, 0, 0 }));
		((Control)Angulo).set_Name("Angulo");
		((Control)Angulo).set_Size(new Size(117, 38));
		((Control)Angulo).set_TabIndex(1);
		Angulo.set_Value(new decimal(new int[4] { 1, 0, 0, 0 }));
		Angulo.add_ValueChanged((EventHandler)numericUpDown1_ValueChanged);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(373, 48));
		((Control)label2).set_Margin(new Padding(8, 0, 8, 0));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(102, 32));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("grados");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(32, 138));
		((Control)label3).set_Margin(new Padding(8, 0, 8, 0));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(243, 32));
		((Control)label3).set_TabIndex(3);
		((Control)label3).set_Text("Velocidad de tiro: ");
		((Control)Velocidad).set_Location(new Point(272, 129));
		((Control)Velocidad).set_Margin(new Padding(8, 7, 8, 7));
		Velocidad.set_Maximum(new decimal(new int[4] { 340, 0, 0, 0 }));
		((Control)Velocidad).set_Name("Velocidad");
		((Control)Velocidad).set_Size(new Size(155, 38));
		((Control)Velocidad).set_TabIndex(4);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(443, 138));
		((Control)label4).set_Margin(new Padding(8, 0, 8, 0));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(60, 32));
		((Control)label4).set_TabIndex(5);
		((Control)label4).set_Text("m/s");
		((Control)groupBox1).get_Controls().Add((Control)(object)initBtn);
		((Control)groupBox1).get_Controls().Add((Control)(object)label10);
		((Control)groupBox1).get_Controls().Add((Control)(object)label9);
		((Control)groupBox1).get_Controls().Add((Control)(object)label8);
		((Control)groupBox1).get_Controls().Add((Control)(object)label7);
		((Control)groupBox1).get_Controls().Add((Control)(object)label6);
		((Control)groupBox1).get_Controls().Add((Control)(object)a_max);
		((Control)groupBox1).get_Controls().Add((Control)(object)distancia);
		((Control)groupBox1).get_Controls().Add((Control)(object)tiempo);
		((Control)groupBox1).get_Controls().Add((Control)(object)label5);
		((Control)groupBox1).set_Location(new Point(13, 224));
		((Control)groupBox1).set_Margin(new Padding(8, 7, 8, 7));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Padding(new Padding(8, 7, 8, 7));
		((Control)groupBox1).set_Size(new Size(563, 484));
		((Control)groupBox1).set_TabIndex(6);
		groupBox1.set_TabStop(false);
		((Control)groupBox1).set_Text("Simulacion");
		((Control)initBtn).set_Location(new Point(181, 45));
		((Control)initBtn).set_Margin(new Padding(8, 7, 8, 7));
		((Control)initBtn).set_Name("initBtn");
		((Control)initBtn).set_Size(new Size(200, 55));
		((Control)initBtn).set_TabIndex(9);
		((Control)initBtn).set_Text("Iniciar");
		((ButtonBase)initBtn).set_UseVisualStyleBackColor(true);
		((Control)initBtn).add_Click((EventHandler)button1_Click);
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_Location(new Point(309, 396));
		((Control)label10).set_Margin(new Padding(8, 0, 8, 0));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(101, 32));
		((Control)label10).set_TabIndex(8);
		((Control)label10).set_Text("metros");
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_Location(new Point(309, 286));
		((Control)label9).set_Margin(new Padding(8, 0, 8, 0));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(101, 32));
		((Control)label9).set_TabIndex(7);
		((Control)label9).set_Text("metros");
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Location(new Point(309, 179));
		((Control)label8).set_Margin(new Padding(8, 0, 8, 0));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(139, 32));
		((Control)label8).set_TabIndex(6);
		((Control)label8).set_Text("segundos");
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Location(new Point(27, 341));
		((Control)label7).set_Margin(new Padding(8, 0, 8, 0));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(204, 32));
		((Control)label7).set_TabIndex(5);
		((Control)label7).set_Text("Altura maxima:");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Location(new Point(27, 234));
		((Control)label6).set_Margin(new Padding(8, 0, 8, 0));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(141, 32));
		((Control)label6).set_TabIndex(4);
		((Control)label6).set_Text("Distancia:");
		((Control)a_max).set_Location(new Point(27, 386));
		((Control)a_max).set_Margin(new Padding(8, 7, 8, 7));
		((Control)a_max).set_Name("a_max");
		((Control)a_max).set_Size(new Size(260, 38));
		((Control)a_max).set_TabIndex(3);
		((Control)a_max).add_TextChanged((EventHandler)textBox3_TextChanged);
		((Control)distancia).set_Location(new Point(27, 277));
		((Control)distancia).set_Margin(new Padding(8, 7, 8, 7));
		((Control)distancia).set_Name("distancia");
		((Control)distancia).set_Size(new Size(260, 38));
		((Control)distancia).set_TabIndex(2);
		((Control)tiempo).set_Location(new Point(27, 169));
		((Control)tiempo).set_Margin(new Padding(8, 7, 8, 7));
		((Control)tiempo).set_Name("tiempo");
		((Control)tiempo).set_Size(new Size(260, 38));
		((Control)tiempo).set_TabIndex(1);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Location(new Point(27, 126));
		((Control)label5).set_Margin(new Padding(8, 0, 8, 0));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(118, 32));
		((Control)label5).set_TabIndex(0);
		((Control)label5).set_Text("Tiempo:");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(16f, 31f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(779, 739));
		((Control)this).get_Controls().Add((Control)(object)groupBox1);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)Velocidad);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)Angulo);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(8, 7, 8, 7));
		((Control)this).set_Name("Form2");
		((Control)this).set_Text("Tiro Parabolico");
		((ISupportInitialize)Angulo).EndInit();
		((ISupportInitialize)Velocidad).EndInit();
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
