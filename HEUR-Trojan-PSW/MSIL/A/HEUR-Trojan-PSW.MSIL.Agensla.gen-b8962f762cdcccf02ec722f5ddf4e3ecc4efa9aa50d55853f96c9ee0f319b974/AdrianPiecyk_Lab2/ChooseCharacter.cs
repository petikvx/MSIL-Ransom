using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AdrianPiecyk_Lab2;

public class ChooseCharacter : Form
{
	private IContainer components = null;

	private PictureBox pictureBoxWarrior;

	private PictureBox pictureBoxMage;

	private PictureBox pictureBoxAssassin;

	private PictureBox pictureBoxPalladin;

	private Label labelChooseCharacter;

	private Button buttonCreateWarrior;

	private Button buttonCreateMage;

	private Button buttonCreateAssassin;

	private Button buttonCreatePalladin;

	private Label labelWarrior;

	private Label labelMage;

	private Label labelAssassin;

	private Label labelPalladin;

	public ChooseCharacter()
	{
		InitializeComponent();
	}

	private void ChooseCharacter_Load(object sender, EventArgs e)
	{
		pictureBoxWarrior.set_Image(Image.FromFile("C:\\Users\\Adrian\\Desktop\\c# obraz\\warrior.jpg"));
		pictureBoxMage.set_Image(Image.FromFile("C:\\Users\\Adrian\\Desktop\\c# obraz\\mage.png"));
		pictureBoxAssassin.set_Image(Image.FromFile("C:\\Users\\Adrian\\Desktop\\c# obraz\\assassin.jpg"));
		pictureBoxPalladin.set_Image(Image.FromFile("C:\\Users\\Adrian\\Desktop\\c# obraz\\palladin.jpg"));
		((Control)labelChooseCharacter).set_Text("Choose your charakter");
	}

	private void buttonCreateWarrior_Click(object sender, EventArgs e)
	{
		WarriorvsOpponent warriorvsOpponent = new WarriorvsOpponent();
		((Control)warriorvsOpponent).Show();
	}

	private void buttonCreateMage_Click(object sender, EventArgs e)
	{
		MagevsOpponent magevsOpponent = new MagevsOpponent();
		((Control)magevsOpponent).Show();
	}

	private void buttonCreateAssassin_Click(object sender, EventArgs e)
	{
		AssassinvsOpponent assassinvsOpponent = new AssassinvsOpponent();
		((Control)assassinvsOpponent).Show();
	}

	private void buttonCreatePalladin_Click(object sender, EventArgs e)
	{
		PalladinvsOpponent palladinvsOpponent = new PalladinvsOpponent();
		((Control)palladinvsOpponent).Show();
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
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected O, but got Unknown
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_057d: Expected O, but got Unknown
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Expected O, but got Unknown
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Expected O, but got Unknown
		pictureBoxWarrior = new PictureBox();
		pictureBoxMage = new PictureBox();
		pictureBoxAssassin = new PictureBox();
		pictureBoxPalladin = new PictureBox();
		labelChooseCharacter = new Label();
		buttonCreateWarrior = new Button();
		buttonCreateMage = new Button();
		buttonCreateAssassin = new Button();
		buttonCreatePalladin = new Button();
		labelWarrior = new Label();
		labelMage = new Label();
		labelAssassin = new Label();
		labelPalladin = new Label();
		((ISupportInitialize)pictureBoxWarrior).BeginInit();
		((ISupportInitialize)pictureBoxMage).BeginInit();
		((ISupportInitialize)pictureBoxAssassin).BeginInit();
		((ISupportInitialize)pictureBoxPalladin).BeginInit();
		((Control)this).SuspendLayout();
		((Control)pictureBoxWarrior).set_Location(new Point(12, 243));
		((Control)pictureBoxWarrior).set_Name("pictureBoxWarrior");
		((Control)pictureBoxWarrior).set_Size(new Size(210, 253));
		pictureBoxWarrior.set_SizeMode((PictureBoxSizeMode)1);
		pictureBoxWarrior.set_TabIndex(1);
		pictureBoxWarrior.set_TabStop(false);
		((Control)pictureBoxMage).set_Location(new Point(251, 243));
		((Control)pictureBoxMage).set_Name("pictureBoxMage");
		((Control)pictureBoxMage).set_Size(new Size(210, 253));
		pictureBoxMage.set_SizeMode((PictureBoxSizeMode)1);
		pictureBoxMage.set_TabIndex(2);
		pictureBoxMage.set_TabStop(false);
		((Control)pictureBoxAssassin).set_Location(new Point(484, 243));
		((Control)pictureBoxAssassin).set_Name("pictureBoxAssassin");
		((Control)pictureBoxAssassin).set_Size(new Size(210, 253));
		pictureBoxAssassin.set_SizeMode((PictureBoxSizeMode)1);
		pictureBoxAssassin.set_TabIndex(3);
		pictureBoxAssassin.set_TabStop(false);
		((Control)pictureBoxPalladin).set_Location(new Point(720, 243));
		((Control)pictureBoxPalladin).set_Name("pictureBoxPalladin");
		((Control)pictureBoxPalladin).set_Size(new Size(210, 253));
		pictureBoxPalladin.set_SizeMode((PictureBoxSizeMode)1);
		pictureBoxPalladin.set_TabIndex(4);
		pictureBoxPalladin.set_TabStop(false);
		((Control)labelChooseCharacter).set_AutoSize(true);
		((Control)labelChooseCharacter).set_Font(new Font("Goudy Stout", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)labelChooseCharacter).set_Location(new Point(197, 103));
		((Control)labelChooseCharacter).set_Name("labelChooseCharacter");
		((Control)labelChooseCharacter).set_Size(new Size(161, 28));
		((Control)labelChooseCharacter).set_TabIndex(5);
		((Control)labelChooseCharacter).set_Text("label1");
		((Control)buttonCreateWarrior).set_Location(new Point(78, 511));
		((Control)buttonCreateWarrior).set_Name("buttonCreateWarrior");
		((Control)buttonCreateWarrior).set_Size(new Size(75, 23));
		((Control)buttonCreateWarrior).set_TabIndex(6);
		((Control)buttonCreateWarrior).set_Text("Choose");
		((ButtonBase)buttonCreateWarrior).set_UseVisualStyleBackColor(true);
		((Control)buttonCreateWarrior).add_Click((EventHandler)buttonCreateWarrior_Click);
		((Control)buttonCreateMage).set_Location(new Point(318, 511));
		((Control)buttonCreateMage).set_Name("buttonCreateMage");
		((Control)buttonCreateMage).set_Size(new Size(75, 23));
		((Control)buttonCreateMage).set_TabIndex(7);
		((Control)buttonCreateMage).set_Text("Choose");
		((ButtonBase)buttonCreateMage).set_UseVisualStyleBackColor(true);
		((Control)buttonCreateMage).add_Click((EventHandler)buttonCreateMage_Click);
		((Control)buttonCreateAssassin).set_Location(new Point(555, 511));
		((Control)buttonCreateAssassin).set_Name("buttonCreateAssassin");
		((Control)buttonCreateAssassin).set_Size(new Size(75, 23));
		((Control)buttonCreateAssassin).set_TabIndex(8);
		((Control)buttonCreateAssassin).set_Text("Choose");
		((ButtonBase)buttonCreateAssassin).set_UseVisualStyleBackColor(true);
		((Control)buttonCreateAssassin).add_Click((EventHandler)buttonCreateAssassin_Click);
		((Control)buttonCreatePalladin).set_Location(new Point(813, 511));
		((Control)buttonCreatePalladin).set_Name("buttonCreatePalladin");
		((Control)buttonCreatePalladin).set_Size(new Size(75, 23));
		((Control)buttonCreatePalladin).set_TabIndex(9);
		((Control)buttonCreatePalladin).set_Text("Choose");
		((ButtonBase)buttonCreatePalladin).set_UseVisualStyleBackColor(true);
		((Control)buttonCreatePalladin).add_Click((EventHandler)buttonCreatePalladin_Click);
		((Control)labelWarrior).set_AutoSize(true);
		((Control)labelWarrior).set_Font(new Font("Modern No. 20", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)labelWarrior).set_Location(new Point(84, 210));
		((Control)labelWarrior).set_Name("labelWarrior");
		((Control)labelWarrior).set_Size(new Size(58, 15));
		((Control)labelWarrior).set_TabIndex(10);
		((Control)labelWarrior).set_Text("Warrior");
		((Control)labelMage).set_AutoSize(true);
		((Control)labelMage).set_Font(new Font("Modern No. 20", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)labelMage).set_Location(new Point(342, 208));
		((Control)labelMage).set_Name("labelMage");
		((Control)labelMage).set_Size(new Size(39, 15));
		((Control)labelMage).set_TabIndex(11);
		((Control)labelMage).set_Text("Mage");
		((Control)labelAssassin).set_AutoSize(true);
		((Control)labelAssassin).set_Font(new Font("Modern No. 20", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)labelAssassin).set_Location(new Point(552, 210));
		((Control)labelAssassin).set_Name("labelAssassin");
		((Control)labelAssassin).set_Size(new Size(61, 15));
		((Control)labelAssassin).set_TabIndex(12);
		((Control)labelAssassin).set_Text("Assassin");
		((Control)labelPalladin).set_AutoSize(true);
		((Control)labelPalladin).set_Font(new Font("Modern No. 20", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)labelPalladin).set_Location(new Point(810, 210));
		((Control)labelPalladin).set_Name("labelPalladin");
		((Control)labelPalladin).set_Size(new Size(60, 15));
		((Control)labelPalladin).set_TabIndex(13);
		((Control)labelPalladin).set_Text("Palladin");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(942, 561));
		((Control)this).get_Controls().Add((Control)(object)labelPalladin);
		((Control)this).get_Controls().Add((Control)(object)labelAssassin);
		((Control)this).get_Controls().Add((Control)(object)labelMage);
		((Control)this).get_Controls().Add((Control)(object)labelWarrior);
		((Control)this).get_Controls().Add((Control)(object)buttonCreatePalladin);
		((Control)this).get_Controls().Add((Control)(object)buttonCreateAssassin);
		((Control)this).get_Controls().Add((Control)(object)buttonCreateMage);
		((Control)this).get_Controls().Add((Control)(object)buttonCreateWarrior);
		((Control)this).get_Controls().Add((Control)(object)labelChooseCharacter);
		((Control)this).get_Controls().Add((Control)(object)pictureBoxPalladin);
		((Control)this).get_Controls().Add((Control)(object)pictureBoxAssassin);
		((Control)this).get_Controls().Add((Control)(object)pictureBoxMage);
		((Control)this).get_Controls().Add((Control)(object)pictureBoxWarrior);
		((Control)this).set_Name("ChooseCharacter");
		((Control)this).set_Text("ChooseCharacter");
		((Form)this).add_Load((EventHandler)ChooseCharacter_Load);
		((ISupportInitialize)pictureBoxWarrior).EndInit();
		((ISupportInitialize)pictureBoxMage).EndInit();
		((ISupportInitialize)pictureBoxAssassin).EndInit();
		((ISupportInitialize)pictureBoxPalladin).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
