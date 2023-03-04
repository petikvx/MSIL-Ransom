using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AdrianPiecyk_Lab2;

public class MagevsOpponent : Form
{
	private Opponent monster;

	private Mage mag;

	private IContainer components = null;

	private PictureBox pictureBoxMage;

	private PictureBox pictureBoxMonster;

	private TextBox textBoxSpellsVoice;

	private Button buttonAttackMage;

	private TextBox textBoxAPMage;

	private TextBox textBoxADMage;

	private Button buttonManaRestore;

	private Button buttonDarkPulse;

	private Button buttonFireBomb;

	private Label labelAPMage;

	private Label labelADMage;

	private TextBox textBoxADMonster;

	private Label labelADMonster;

	private Label labelHPMonster;

	private Label labelHPMage;

	private Label labelManaMage;

	private ProgressBar progressBarManaMage;

	private ProgressBar progressBarHPMonster;

	private ProgressBar progressBarHPMage;

	public MagevsOpponent()
	{
		InitializeComponent();
	}

	private void MagevsOpponent_Load(object sender, EventArgs e)
	{
		pictureBoxMage.set_Image(Image.FromFile("C:\\Users\\Adrian\\Desktop\\c# obraz\\mage.png"));
		pictureBoxMonster.set_Image(Image.FromFile("C:\\Users\\Adrian\\Desktop\\c# obraz\\monster.jpg"));
		progressBarHPMage.set_Value(100);
		progressBarManaMage.set_Value(100);
		progressBarHPMonster.set_Value(100);
		mag = new Mage("Darsy", 1100, 100, 1500, 1600);
		((Control)textBoxADMage).set_Text(mag.AttackDamage.ToString());
		((Control)textBoxAPMage).set_Text(mag.AbilityPower.ToString());
		monster = new Opponent("GAZOL", 0, 0, 40, 10000);
		((Control)textBoxADMonster).set_Text(monster.AttackDamage.ToString());
	}

	private void buttonAttackMage_Click(object sender, EventArgs e)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		monster.HP -= mag.Attack();
		mag.HP -= monster.Attack();
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
		if (mag.HP <= 0)
		{
			mag.HP = 0;
			progressBarHPMage.set_Value(mag.PercentHP());
			string text2 = "You are death, try again!";
			MessageBox.Show(text2);
			((Control)this).set_Visible(false);
		}
		else
		{
			progressBarHPMage.set_Value(mag.PercentHP());
		}
	}

	private void buttonFireBomb_Click(object sender, EventArgs e)
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		mag.Mana -= 150;
		mag.HP -= monster.Attack();
		if (mag.Mana <= 0)
		{
			((Control)buttonFireBomb).set_Enabled(false);
		}
		else
		{
			progressBarManaMage.set_Value(mag.PercentMana());
		}
		((Control)textBoxSpellsVoice).set_Text(mag.Spellfirst());
		monster.HP -= 600;
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
		if (mag.HP <= 0)
		{
			mag.HP = 0;
			progressBarHPMage.set_Value(mag.PercentHP());
			string text2 = "You are death, try again!";
			MessageBox.Show(text2);
			((Control)this).set_Visible(false);
		}
		else
		{
			progressBarHPMage.set_Value(mag.PercentHP());
		}
	}

	private void buttonDarkPulse_Click(object sender, EventArgs e)
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		mag.Mana -= 200;
		mag.HP -= monster.Attack();
		if (mag.Mana <= 0)
		{
			((Control)buttonDarkPulse).set_Enabled(false);
		}
		else
		{
			progressBarManaMage.set_Value(mag.PercentMana());
		}
		((Control)textBoxSpellsVoice).set_Text(mag.Spellsecond());
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
		if (mag.HP <= 0)
		{
			mag.HP = 0;
			progressBarHPMage.set_Value(mag.PercentHP());
			string text2 = "You are death, try again!";
			MessageBox.Show(text2);
			((Control)this).set_Visible(false);
		}
		else
		{
			progressBarHPMage.set_Value(mag.PercentHP());
		}
	}

	private void buttonManaRestore_Click(object sender, EventArgs e)
	{
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		mag.Mana += 300;
		mag.HP -= monster.Attack();
		((Control)textBoxSpellsVoice).set_Text(mag.Spellthird());
		if (mag.Mana <= 0)
		{
			((Control)buttonManaRestore).set_Enabled(false);
		}
		else
		{
			progressBarManaMage.set_Value(mag.PercentMana());
		}
		if (mag.HP <= 0)
		{
			mag.HP = 0;
			progressBarHPMage.set_Value(mag.PercentHP());
			string text = "You are death, try again!";
			MessageBox.Show(text);
			((Control)this).set_Visible(false);
		}
		else
		{
			progressBarHPMage.set_Value(mag.PercentHP());
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
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Expected O, but got Unknown
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Expected O, but got Unknown
		//IL_0650: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Expected O, but got Unknown
		//IL_06d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e2: Expected O, but got Unknown
		//IL_0760: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Expected O, but got Unknown
		//IL_07e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ef: Expected O, but got Unknown
		pictureBoxMage = new PictureBox();
		pictureBoxMonster = new PictureBox();
		textBoxSpellsVoice = new TextBox();
		buttonAttackMage = new Button();
		textBoxAPMage = new TextBox();
		textBoxADMage = new TextBox();
		buttonManaRestore = new Button();
		buttonDarkPulse = new Button();
		buttonFireBomb = new Button();
		labelAPMage = new Label();
		labelADMage = new Label();
		textBoxADMonster = new TextBox();
		labelADMonster = new Label();
		labelHPMonster = new Label();
		labelHPMage = new Label();
		labelManaMage = new Label();
		progressBarManaMage = new ProgressBar();
		progressBarHPMonster = new ProgressBar();
		progressBarHPMage = new ProgressBar();
		((ISupportInitialize)pictureBoxMage).BeginInit();
		((ISupportInitialize)pictureBoxMonster).BeginInit();
		((Control)this).SuspendLayout();
		((Control)pictureBoxMage).set_Location(new Point(135, 148));
		((Control)pictureBoxMage).set_Name("pictureBoxMage");
		((Control)pictureBoxMage).set_Size(new Size(205, 256));
		pictureBoxMage.set_SizeMode((PictureBoxSizeMode)1);
		pictureBoxMage.set_TabIndex(1);
		pictureBoxMage.set_TabStop(false);
		((Control)pictureBoxMage).set_UseWaitCursor(true);
		((Control)pictureBoxMonster).set_Location(new Point(426, 148));
		((Control)pictureBoxMonster).set_Name("pictureBoxMonster");
		((Control)pictureBoxMonster).set_Size(new Size(205, 256));
		pictureBoxMonster.set_SizeMode((PictureBoxSizeMode)1);
		pictureBoxMonster.set_TabIndex(2);
		pictureBoxMonster.set_TabStop(false);
		((Control)pictureBoxMonster).set_UseWaitCursor(true);
		((Control)textBoxSpellsVoice).set_Enabled(false);
		((Control)textBoxSpellsVoice).set_Location(new Point(164, 31));
		((TextBoxBase)textBoxSpellsVoice).set_Multiline(true);
		((Control)textBoxSpellsVoice).set_Name("textBoxSpellsVoice");
		((Control)textBoxSpellsVoice).set_Size(new Size(147, 33));
		((Control)textBoxSpellsVoice).set_TabIndex(21);
		((Control)buttonAttackMage).set_Location(new Point(184, 89));
		((Control)buttonAttackMage).set_Name("buttonAttackMage");
		((Control)buttonAttackMage).set_Size(new Size(101, 37));
		((Control)buttonAttackMage).set_TabIndex(22);
		((Control)buttonAttackMage).set_Text("Basic Attack");
		((ButtonBase)buttonAttackMage).set_UseVisualStyleBackColor(true);
		((Control)buttonAttackMage).add_Click((EventHandler)buttonAttackMage_Click);
		((Control)textBoxAPMage).set_Enabled(false);
		((Control)textBoxAPMage).set_Location(new Point(53, 186));
		((Control)textBoxAPMage).set_Name("textBoxAPMage");
		((Control)textBoxAPMage).set_Size(new Size(45, 20));
		((Control)textBoxAPMage).set_TabIndex(29);
		((Control)textBoxADMage).set_Enabled(false);
		((Control)textBoxADMage).set_Location(new Point(53, 151));
		((Control)textBoxADMage).set_Name("textBoxADMage");
		((Control)textBoxADMage).set_Size(new Size(45, 20));
		((Control)textBoxADMage).set_TabIndex(28);
		((Control)buttonManaRestore).set_Location(new Point(23, 325));
		((Control)buttonManaRestore).set_Name("buttonManaRestore");
		((Control)buttonManaRestore).set_Size(new Size(96, 23));
		((Control)buttonManaRestore).set_TabIndex(27);
		((Control)buttonManaRestore).set_Text("Mana Restore");
		((ButtonBase)buttonManaRestore).set_UseVisualStyleBackColor(true);
		((Control)buttonManaRestore).add_Click((EventHandler)buttonManaRestore_Click);
		((Control)buttonDarkPulse).set_Location(new Point(23, 275));
		((Control)buttonDarkPulse).set_Name("buttonDarkPulse");
		((Control)buttonDarkPulse).set_Size(new Size(75, 23));
		((Control)buttonDarkPulse).set_TabIndex(26);
		((Control)buttonDarkPulse).set_Text("Dark Pulse");
		((ButtonBase)buttonDarkPulse).set_UseVisualStyleBackColor(true);
		((Control)buttonDarkPulse).add_Click((EventHandler)buttonDarkPulse_Click);
		((Control)buttonFireBomb).set_Location(new Point(23, 227));
		((Control)buttonFireBomb).set_Name("buttonFireBomb");
		((Control)buttonFireBomb).set_Size(new Size(75, 23));
		((Control)buttonFireBomb).set_TabIndex(25);
		((Control)buttonFireBomb).set_Text("Fire Bomb");
		((ButtonBase)buttonFireBomb).set_UseVisualStyleBackColor(true);
		((Control)buttonFireBomb).add_Click((EventHandler)buttonFireBomb_Click);
		((Control)labelAPMage).set_AutoSize(true);
		((Control)labelAPMage).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)labelAPMage).set_Location(new Point(20, 187));
		((Control)labelAPMage).set_Name("labelAPMage");
		((Control)labelAPMage).set_Size(new Size(24, 15));
		((Control)labelAPMage).set_TabIndex(24);
		((Control)labelAPMage).set_Text("AP");
		((Control)labelADMage).set_AutoSize(true);
		((Control)labelADMage).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)labelADMage).set_Location(new Point(20, 152));
		((Control)labelADMage).set_Name("labelADMage");
		((Control)labelADMage).set_Size(new Size(25, 15));
		((Control)labelADMage).set_TabIndex(23);
		((Control)labelADMage).set_Text("AD");
		((Control)textBoxADMonster).set_Enabled(false);
		((Control)textBoxADMonster).set_Location(new Point(667, 155));
		((Control)textBoxADMonster).set_Name("textBoxADMonster");
		((Control)textBoxADMonster).set_Size(new Size(45, 20));
		((Control)textBoxADMonster).set_TabIndex(32);
		((Control)labelADMonster).set_AutoSize(true);
		((Control)labelADMonster).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)labelADMonster).set_Location(new Point(636, 155));
		((Control)labelADMonster).set_Name("labelADMonster");
		((Control)labelADMonster).set_Size(new Size(25, 15));
		((Control)labelADMonster).set_TabIndex(30);
		((Control)labelADMonster).set_Text("AD");
		((Control)labelHPMonster).set_AutoSize(true);
		((Control)labelHPMonster).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)labelHPMonster).set_Location(new Point(394, 410));
		((Control)labelHPMonster).set_Name("labelHPMonster");
		((Control)labelHPMonster).set_Size(new Size(26, 15));
		((Control)labelHPMonster).set_TabIndex(39);
		((Control)labelHPMonster).set_Text("HP");
		((Control)labelHPMage).set_AutoSize(true);
		((Control)labelHPMage).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)labelHPMage).set_Location(new Point(104, 410));
		((Control)labelHPMage).set_Name("labelHPMage");
		((Control)labelHPMage).set_Size(new Size(26, 15));
		((Control)labelHPMage).set_TabIndex(38);
		((Control)labelHPMage).set_Text("HP");
		((Control)labelManaMage).set_AutoSize(true);
		((Control)labelManaMage).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)labelManaMage).set_Location(new Point(86, 436));
		((Control)labelManaMage).set_Name("labelManaMage");
		((Control)labelManaMage).set_Size(new Size(43, 15));
		((Control)labelManaMage).set_TabIndex(37);
		((Control)labelManaMage).set_Text("Mana");
		((Control)progressBarManaMage).set_Location(new Point(135, 436));
		((Control)progressBarManaMage).set_Name("progressBarManaMage");
		((Control)progressBarManaMage).set_Size(new Size(205, 23));
		((Control)progressBarManaMage).set_TabIndex(36);
		((Control)progressBarHPMonster).set_Location(new Point(426, 410));
		((Control)progressBarHPMonster).set_Name("progressBarHPMonster");
		((Control)progressBarHPMonster).set_Size(new Size(205, 23));
		((Control)progressBarHPMonster).set_TabIndex(35);
		((Control)progressBarHPMage).set_Location(new Point(135, 410));
		((Control)progressBarHPMage).set_Name("progressBarHPMage");
		((Control)progressBarHPMage).set_Size(new Size(205, 23));
		((Control)progressBarHPMage).set_TabIndex(34);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(739, 471));
		((Control)this).get_Controls().Add((Control)(object)labelHPMonster);
		((Control)this).get_Controls().Add((Control)(object)labelHPMage);
		((Control)this).get_Controls().Add((Control)(object)labelManaMage);
		((Control)this).get_Controls().Add((Control)(object)progressBarManaMage);
		((Control)this).get_Controls().Add((Control)(object)progressBarHPMonster);
		((Control)this).get_Controls().Add((Control)(object)progressBarHPMage);
		((Control)this).get_Controls().Add((Control)(object)textBoxADMonster);
		((Control)this).get_Controls().Add((Control)(object)labelADMonster);
		((Control)this).get_Controls().Add((Control)(object)textBoxAPMage);
		((Control)this).get_Controls().Add((Control)(object)textBoxADMage);
		((Control)this).get_Controls().Add((Control)(object)buttonManaRestore);
		((Control)this).get_Controls().Add((Control)(object)buttonDarkPulse);
		((Control)this).get_Controls().Add((Control)(object)buttonFireBomb);
		((Control)this).get_Controls().Add((Control)(object)labelAPMage);
		((Control)this).get_Controls().Add((Control)(object)labelADMage);
		((Control)this).get_Controls().Add((Control)(object)buttonAttackMage);
		((Control)this).get_Controls().Add((Control)(object)textBoxSpellsVoice);
		((Control)this).get_Controls().Add((Control)(object)pictureBoxMonster);
		((Control)this).get_Controls().Add((Control)(object)pictureBoxMage);
		((Control)this).set_Name("MagevsOpponent");
		((Control)this).set_Text("MagevsOpponent");
		((Form)this).add_Load((EventHandler)MagevsOpponent_Load);
		((ISupportInitialize)pictureBoxMage).EndInit();
		((ISupportInitialize)pictureBoxMonster).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
