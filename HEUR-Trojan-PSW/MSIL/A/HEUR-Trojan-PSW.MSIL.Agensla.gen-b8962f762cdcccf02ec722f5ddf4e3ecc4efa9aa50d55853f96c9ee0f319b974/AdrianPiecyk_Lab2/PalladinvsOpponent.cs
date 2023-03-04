using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AdrianPiecyk_Lab2;

public class PalladinvsOpponent : Form
{
	private Palladin palladin;

	private Opponent monster;

	private IContainer components = null;

	private Label labelHPMonster;

	private Label labelHPPalladin;

	private Label labelManaPalladin;

	private ProgressBar progressBarManaPalladin;

	private ProgressBar progressBarHPMonster;

	private ProgressBar progressBarHPPalladin;

	private TextBox textBoxADMonster;

	private Label labelADMonster;

	private TextBox textBoxAPPalladin;

	private TextBox textBoxADPalladin;

	private Button buttonFurious;

	private Button buttonMasor;

	private Button buttonSpearThrow;

	private Label labelAPPalladin;

	private Label labelADPalladin;

	private Button buttonAttackPalladin;

	private TextBox textBoxSpellsVoice;

	private PictureBox pictureBoxMonster;

	private PictureBox pictureBoxPalladin;

	public PalladinvsOpponent()
	{
		InitializeComponent();
	}

	private void PalladinvsOpponent_Load(object sender, EventArgs e)
	{
		pictureBoxPalladin.set_Image(Image.FromFile("C:\\Users\\Adrian\\Desktop\\c# obraz\\palladin.jpg"));
		pictureBoxMonster.set_Image(Image.FromFile("C:\\Users\\Adrian\\Desktop\\c# obraz\\monster.jpg"));
		progressBarHPPalladin.set_Value(100);
		progressBarManaPalladin.set_Value(100);
		progressBarHPMonster.set_Value(100);
		palladin = new Palladin("Patheon", 30, 130, 2400, 700);
		((Control)textBoxADPalladin).set_Text(palladin.AttackDamage.ToString());
		((Control)textBoxAPPalladin).set_Text(palladin.AbilityPower.ToString());
		monster = new Opponent("GAZOL", 0, 0, 40, 10000);
		((Control)textBoxADMonster).set_Text(monster.AttackDamage.ToString());
	}

	private void buttonAttackPalladin_Click(object sender, EventArgs e)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		monster.HP -= palladin.Attack();
		palladin.HP -= monster.Attack();
		if (monster.HP <= 0)
		{
			monster.HP = 0;
			progressBarHPMonster.set_Value(monster.PercentHP());
			string text = "Good job my friend your opponent has been killed!";
			MessageBox.Show(text);
			((Control)this).set_Visible(false);
		}
		else
		{
			progressBarHPMonster.set_Value(monster.PercentHP());
		}
		if (palladin.HP <= 0)
		{
			palladin.HP = 0;
			progressBarHPPalladin.set_Value(palladin.PercentHP());
			string text2 = "You are death, try again!";
			MessageBox.Show(text2);
			((Control)this).set_Visible(false);
		}
		else
		{
			progressBarHPPalladin.set_Value(palladin.PercentHP());
		}
	}

	private void buttonSpearThrow_Click(object sender, EventArgs e)
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		palladin.Mana -= 150;
		palladin.HP -= monster.Attack();
		if (palladin.Mana <= 0)
		{
			((Control)buttonSpearThrow).set_Enabled(false);
		}
		else
		{
			progressBarManaPalladin.set_Value(palladin.PercentMana());
		}
		((Control)textBoxSpellsVoice).set_Text(palladin.Spellfirst());
		monster.HP -= 500;
		if (monster.HP <= 0)
		{
			monster.HP = 0;
			progressBarHPMonster.set_Value(monster.PercentHP());
			string text = "Good job my friend your opponent has been killed!";
			MessageBox.Show(text);
			((Control)this).set_Visible(false);
		}
		else
		{
			progressBarHPMonster.set_Value(monster.PercentHP());
		}
		if (palladin.HP <= 0)
		{
			palladin.HP = 0;
			progressBarHPPalladin.set_Value(palladin.PercentHP());
			string text2 = "You are death, try again!";
			MessageBox.Show(text2);
			((Control)this).set_Visible(false);
		}
		else
		{
			progressBarHPPalladin.set_Value(palladin.PercentHP());
		}
	}

	private void buttonMasor_Click(object sender, EventArgs e)
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		palladin.Mana -= 250;
		palladin.HP -= monster.Attack();
		if (palladin.Mana <= 0)
		{
			((Control)buttonMasor).set_Enabled(false);
		}
		else
		{
			progressBarManaPalladin.set_Value(palladin.PercentMana());
		}
		((Control)textBoxSpellsVoice).set_Text(palladin.Spellsecond());
		monster.HP -= 700;
		if (monster.HP <= 0)
		{
			monster.HP = 0;
			progressBarHPMonster.set_Value(monster.PercentHP());
			string text = "Good job my friend your opponent has been killed!";
			MessageBox.Show(text);
			((Control)this).set_Visible(false);
		}
		else
		{
			progressBarHPMonster.set_Value(monster.PercentHP());
		}
		if (palladin.HP <= 0)
		{
			palladin.HP = 0;
			progressBarHPPalladin.set_Value(palladin.PercentHP());
			string text2 = "You are death, try again!";
			MessageBox.Show(text2);
			((Control)this).set_Visible(false);
		}
		else
		{
			progressBarHPPalladin.set_Value(palladin.PercentHP());
		}
	}

	private void buttonFurious_Click(object sender, EventArgs e)
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		palladin.Mana -= 400;
		palladin.HP -= monster.Attack();
		if (palladin.Mana <= 0)
		{
			((Control)buttonFurious).set_Enabled(false);
		}
		else
		{
			progressBarManaPalladin.set_Value(palladin.PercentMana());
		}
		((Control)textBoxSpellsVoice).set_Text(palladin.Spellsecond());
		monster.HP -= 1000;
		if (monster.HP <= 0)
		{
			monster.HP = 0;
			progressBarHPMonster.set_Value(monster.PercentHP());
			string text = "Good job my friend your opponent has been killed!";
			MessageBox.Show(text);
			((Control)this).set_Visible(false);
		}
		else
		{
			progressBarHPMonster.set_Value(monster.PercentHP());
		}
		if (palladin.HP <= 0)
		{
			palladin.HP = 0;
			progressBarHPPalladin.set_Value(palladin.PercentHP());
			string text2 = "You are death, try again!";
			MessageBox.Show(text2);
			((Control)this).set_Visible(false);
		}
		else
		{
			progressBarHPPalladin.set_Value(palladin.PercentHP());
		}
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
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected O, but got Unknown
		//IL_0684: Unknown result type (might be due to invalid IL or missing references)
		//IL_068e: Expected O, but got Unknown
		//IL_0709: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Expected O, but got Unknown
		labelHPMonster = new Label();
		labelHPPalladin = new Label();
		labelManaPalladin = new Label();
		progressBarManaPalladin = new ProgressBar();
		progressBarHPMonster = new ProgressBar();
		progressBarHPPalladin = new ProgressBar();
		textBoxADMonster = new TextBox();
		labelADMonster = new Label();
		textBoxAPPalladin = new TextBox();
		textBoxADPalladin = new TextBox();
		buttonFurious = new Button();
		buttonMasor = new Button();
		buttonSpearThrow = new Button();
		labelAPPalladin = new Label();
		labelADPalladin = new Label();
		buttonAttackPalladin = new Button();
		textBoxSpellsVoice = new TextBox();
		pictureBoxMonster = new PictureBox();
		pictureBoxPalladin = new PictureBox();
		((ISupportInitialize)pictureBoxMonster).BeginInit();
		((ISupportInitialize)pictureBoxPalladin).BeginInit();
		((Control)this).SuspendLayout();
		((Control)labelHPMonster).set_AutoSize(true);
		((Control)labelHPMonster).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)labelHPMonster).set_Location(new Point(397, 400));
		((Control)labelHPMonster).set_Name("labelHPMonster");
		((Control)labelHPMonster).set_Size(new Size(26, 15));
		((Control)labelHPMonster).set_TabIndex(60);
		((Control)labelHPMonster).set_Text("HP");
		((Control)labelHPPalladin).set_AutoSize(true);
		((Control)labelHPPalladin).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)labelHPPalladin).set_Location(new Point(107, 400));
		((Control)labelHPPalladin).set_Name("labelHPPalladin");
		((Control)labelHPPalladin).set_Size(new Size(26, 15));
		((Control)labelHPPalladin).set_TabIndex(59);
		((Control)labelHPPalladin).set_Text("HP");
		((Control)labelManaPalladin).set_AutoSize(true);
		((Control)labelManaPalladin).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)labelManaPalladin).set_Location(new Point(89, 426));
		((Control)labelManaPalladin).set_Name("labelManaPalladin");
		((Control)labelManaPalladin).set_Size(new Size(43, 15));
		((Control)labelManaPalladin).set_TabIndex(58);
		((Control)labelManaPalladin).set_Text("Mana");
		((Control)progressBarManaPalladin).set_Location(new Point(138, 426));
		((Control)progressBarManaPalladin).set_Name("progressBarManaPalladin");
		((Control)progressBarManaPalladin).set_Size(new Size(205, 23));
		((Control)progressBarManaPalladin).set_TabIndex(57);
		((Control)progressBarHPMonster).set_Location(new Point(429, 400));
		((Control)progressBarHPMonster).set_Name("progressBarHPMonster");
		((Control)progressBarHPMonster).set_Size(new Size(205, 23));
		((Control)progressBarHPMonster).set_TabIndex(56);
		((Control)progressBarHPPalladin).set_Location(new Point(138, 400));
		((Control)progressBarHPPalladin).set_Name("progressBarHPPalladin");
		((Control)progressBarHPPalladin).set_Size(new Size(205, 23));
		((Control)progressBarHPPalladin).set_TabIndex(55);
		((Control)textBoxADMonster).set_Enabled(false);
		((Control)textBoxADMonster).set_Location(new Point(670, 145));
		((Control)textBoxADMonster).set_Name("textBoxADMonster");
		((Control)textBoxADMonster).set_Size(new Size(45, 20));
		((Control)textBoxADMonster).set_TabIndex(53);
		((Control)labelADMonster).set_AutoSize(true);
		((Control)labelADMonster).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)labelADMonster).set_Location(new Point(639, 145));
		((Control)labelADMonster).set_Name("labelADMonster");
		((Control)labelADMonster).set_Size(new Size(25, 15));
		((Control)labelADMonster).set_TabIndex(51);
		((Control)labelADMonster).set_Text("AD");
		((Control)textBoxAPPalladin).set_Enabled(false);
		((Control)textBoxAPPalladin).set_Location(new Point(56, 176));
		((Control)textBoxAPPalladin).set_Name("textBoxAPPalladin");
		((Control)textBoxAPPalladin).set_Size(new Size(45, 20));
		((Control)textBoxAPPalladin).set_TabIndex(50);
		((Control)textBoxADPalladin).set_Enabled(false);
		((Control)textBoxADPalladin).set_Location(new Point(56, 141));
		((Control)textBoxADPalladin).set_Name("textBoxADPalladin");
		((Control)textBoxADPalladin).set_Size(new Size(45, 20));
		((Control)textBoxADPalladin).set_TabIndex(49);
		((Control)buttonFurious).set_Location(new Point(26, 315));
		((Control)buttonFurious).set_Name("buttonFurious");
		((Control)buttonFurious).set_Size(new Size(96, 23));
		((Control)buttonFurious).set_TabIndex(48);
		((Control)buttonFurious).set_Text("Furious");
		((ButtonBase)buttonFurious).set_UseVisualStyleBackColor(true);
		((Control)buttonFurious).add_Click((EventHandler)buttonFurious_Click);
		((Control)buttonMasor).set_Location(new Point(26, 265));
		((Control)buttonMasor).set_Name("buttonMasor");
		((Control)buttonMasor).set_Size(new Size(75, 23));
		((Control)buttonMasor).set_TabIndex(47);
		((Control)buttonMasor).set_Text("Masor");
		((ButtonBase)buttonMasor).set_UseVisualStyleBackColor(true);
		((Control)buttonMasor).add_Click((EventHandler)buttonMasor_Click);
		((Control)buttonSpearThrow).set_Location(new Point(26, 218));
		((Control)buttonSpearThrow).set_Name("buttonSpearThrow");
		((Control)buttonSpearThrow).set_Size(new Size(96, 23));
		((Control)buttonSpearThrow).set_TabIndex(46);
		((Control)buttonSpearThrow).set_Text("Spear Throw");
		((ButtonBase)buttonSpearThrow).set_UseVisualStyleBackColor(true);
		((Control)buttonSpearThrow).add_Click((EventHandler)buttonSpearThrow_Click);
		((Control)labelAPPalladin).set_AutoSize(true);
		((Control)labelAPPalladin).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)labelAPPalladin).set_Location(new Point(23, 177));
		((Control)labelAPPalladin).set_Name("labelAPPalladin");
		((Control)labelAPPalladin).set_Size(new Size(24, 15));
		((Control)labelAPPalladin).set_TabIndex(45);
		((Control)labelAPPalladin).set_Text("AP");
		((Control)labelADPalladin).set_AutoSize(true);
		((Control)labelADPalladin).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)labelADPalladin).set_Location(new Point(23, 142));
		((Control)labelADPalladin).set_Name("labelADPalladin");
		((Control)labelADPalladin).set_Size(new Size(25, 15));
		((Control)labelADPalladin).set_TabIndex(44);
		((Control)labelADPalladin).set_Text("AD");
		((Control)buttonAttackPalladin).set_Location(new Point(187, 79));
		((Control)buttonAttackPalladin).set_Name("buttonAttackPalladin");
		((Control)buttonAttackPalladin).set_Size(new Size(101, 37));
		((Control)buttonAttackPalladin).set_TabIndex(43);
		((Control)buttonAttackPalladin).set_Text("Basic Attack");
		((ButtonBase)buttonAttackPalladin).set_UseVisualStyleBackColor(true);
		((Control)buttonAttackPalladin).add_Click((EventHandler)buttonAttackPalladin_Click);
		((Control)textBoxSpellsVoice).set_Enabled(false);
		((Control)textBoxSpellsVoice).set_Location(new Point(167, 21));
		((TextBoxBase)textBoxSpellsVoice).set_Multiline(true);
		((Control)textBoxSpellsVoice).set_Name("textBoxSpellsVoice");
		((Control)textBoxSpellsVoice).set_Size(new Size(147, 33));
		((Control)textBoxSpellsVoice).set_TabIndex(42);
		((Control)pictureBoxMonster).set_Location(new Point(429, 138));
		((Control)pictureBoxMonster).set_Name("pictureBoxMonster");
		((Control)pictureBoxMonster).set_Size(new Size(205, 256));
		pictureBoxMonster.set_SizeMode((PictureBoxSizeMode)1);
		pictureBoxMonster.set_TabIndex(41);
		pictureBoxMonster.set_TabStop(false);
		((Control)pictureBoxMonster).set_UseWaitCursor(true);
		((Control)pictureBoxPalladin).set_Location(new Point(138, 138));
		((Control)pictureBoxPalladin).set_Name("pictureBoxPalladin");
		((Control)pictureBoxPalladin).set_Size(new Size(205, 256));
		pictureBoxPalladin.set_SizeMode((PictureBoxSizeMode)1);
		pictureBoxPalladin.set_TabIndex(40);
		pictureBoxPalladin.set_TabStop(false);
		((Control)pictureBoxPalladin).set_UseWaitCursor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(739, 471));
		((Control)this).get_Controls().Add((Control)(object)labelHPMonster);
		((Control)this).get_Controls().Add((Control)(object)labelHPPalladin);
		((Control)this).get_Controls().Add((Control)(object)labelManaPalladin);
		((Control)this).get_Controls().Add((Control)(object)progressBarManaPalladin);
		((Control)this).get_Controls().Add((Control)(object)progressBarHPMonster);
		((Control)this).get_Controls().Add((Control)(object)progressBarHPPalladin);
		((Control)this).get_Controls().Add((Control)(object)textBoxADMonster);
		((Control)this).get_Controls().Add((Control)(object)labelADMonster);
		((Control)this).get_Controls().Add((Control)(object)textBoxAPPalladin);
		((Control)this).get_Controls().Add((Control)(object)textBoxADPalladin);
		((Control)this).get_Controls().Add((Control)(object)buttonFurious);
		((Control)this).get_Controls().Add((Control)(object)buttonMasor);
		((Control)this).get_Controls().Add((Control)(object)buttonSpearThrow);
		((Control)this).get_Controls().Add((Control)(object)labelAPPalladin);
		((Control)this).get_Controls().Add((Control)(object)labelADPalladin);
		((Control)this).get_Controls().Add((Control)(object)buttonAttackPalladin);
		((Control)this).get_Controls().Add((Control)(object)textBoxSpellsVoice);
		((Control)this).get_Controls().Add((Control)(object)pictureBoxMonster);
		((Control)this).get_Controls().Add((Control)(object)pictureBoxPalladin);
		((Control)this).set_Name("PalladinvsOpponent");
		((Control)this).set_Text("PalladinvsOpponent");
		((Form)this).add_Load((EventHandler)PalladinvsOpponent_Load);
		((ISupportInitialize)pictureBoxMonster).EndInit();
		((ISupportInitialize)pictureBoxPalladin).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
