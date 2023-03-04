using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AdrianPiecyk_Lab2;

public class WarriorvsOpponent : Form
{
	private Warrior warrior;

	private Opponent monster;

	private IContainer components = null;

	private PictureBox pictureBoxWarrior2;

	private PictureBox pictureBoxMonster;

	private Label labelAD;

	private Label labelAP;

	private Button buttonBerserker;

	private Button buttonDemacia;

	private Button buttonHPbooster;

	private TextBox textBoxADWarrior;

	private TextBox textBoxAPWarrior;

	private Label labelADMonster;

	private TextBox textBoxADMonster;

	private ProgressBar progressBarHPWarrior;

	private ProgressBar progressBarHPMonster;

	private ProgressBar progressBarManaWarrior;

	private Label labelManaWarrior;

	private Label labelHPWarrior;

	private Label labelHPMonster;

	private Button buttonAttackWarrior;

	private TextBox textBoxSpellsVoice;

	public WarriorvsOpponent()
	{
		InitializeComponent();
	}

	private void WarriorvsOpponent_Load(object sender, EventArgs e)
	{
		pictureBoxWarrior2.set_Image(Image.FromFile("C:\\Users\\Adrian\\Desktop\\c# obraz\\warrior.jpg"));
		pictureBoxMonster.set_Image(Image.FromFile("C:\\Users\\Adrian\\Desktop\\c# obraz\\monster.jpg"));
		progressBarHPWarrior.set_Value(100);
		progressBarManaWarrior.set_Value(100);
		progressBarHPMonster.set_Value(100);
		warrior = new Warrior("Aarax", 30, 110, 3000, 400);
		((Control)textBoxADWarrior).set_Text(warrior.AttackDamage.ToString());
		((Control)textBoxAPWarrior).set_Text(warrior.AbilityPower.ToString());
		monster = new Opponent("GAZOL", 0, 0, 40, 10000);
		((Control)textBoxADMonster).set_Text(monster.AttackDamage.ToString());
	}

	private void buttonAttackWarrior_Click(object sender, EventArgs e)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		monster.HP -= warrior.Attack();
		warrior.HP -= monster.Attack();
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
		if (warrior.HP <= 0)
		{
			warrior.HP = 0;
			progressBarHPWarrior.set_Value(warrior.PercentHP());
			string text2 = "You are death, try again!";
			MessageBox.Show(text2);
			((Control)this).set_Visible(false);
		}
		else
		{
			progressBarHPWarrior.set_Value(warrior.PercentHP());
		}
	}

	private void buttonBerserker_Click(object sender, EventArgs e)
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		warrior.Mana -= 150;
		warrior.HP -= monster.Attack();
		if (warrior.Mana <= 0)
		{
			((Control)buttonBerserker).set_Enabled(false);
		}
		else
		{
			progressBarManaWarrior.set_Value(warrior.PercentMana());
		}
		((Control)textBoxSpellsVoice).set_Text(warrior.Spellfirst());
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
		if (warrior.HP <= 0)
		{
			warrior.HP = 0;
			progressBarHPWarrior.set_Value(warrior.PercentHP());
			string text2 = "You are death, try again!";
			MessageBox.Show(text2);
			((Control)this).set_Visible(false);
		}
		else
		{
			progressBarHPWarrior.set_Value(warrior.PercentHP());
		}
	}

	private void buttonDemacia_Click(object sender, EventArgs e)
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		warrior.Mana -= 250;
		warrior.HP -= monster.Attack();
		if (warrior.Mana <= 0)
		{
			((Control)buttonDemacia).set_Enabled(false);
		}
		else
		{
			progressBarManaWarrior.set_Value(warrior.PercentMana());
		}
		((Control)textBoxSpellsVoice).set_Text(warrior.Spellsecond());
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
		if (warrior.HP <= 0)
		{
			warrior.HP = 0;
			progressBarHPWarrior.set_Value(warrior.PercentHP());
			string text2 = "You are death, try again!";
			MessageBox.Show(text2);
			((Control)this).set_Visible(false);
		}
		else
		{
			progressBarHPWarrior.set_Value(warrior.PercentHP());
		}
	}

	private void buttonHPbooster_Click(object sender, EventArgs e)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		warrior.HP += 100;
		warrior.Mana -= 100;
		((Control)textBoxSpellsVoice).set_Text(warrior.Spellthird());
		if (warrior.Mana <= 0)
		{
			((Control)buttonHPbooster).set_Enabled(false);
		}
		else
		{
			((Control)textBoxAPWarrior).set_Text(warrior.AbilityPower.ToString());
			progressBarHPWarrior.set_Value(warrior.PercentHP());
		}
		if (warrior.HP <= 0)
		{
			warrior.HP = 0;
			progressBarHPWarrior.set_Value(warrior.PercentHP());
			string text = "You are death, try again!";
			MessageBox.Show(text);
			((Control)this).set_Visible(false);
		}
		else
		{
			progressBarHPWarrior.set_Value(warrior.PercentHP());
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
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_056f: Expected O, but got Unknown
		//IL_0764: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Expected O, but got Unknown
		//IL_07f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ff: Expected O, but got Unknown
		//IL_0886: Unknown result type (might be due to invalid IL or missing references)
		//IL_0890: Expected O, but got Unknown
		pictureBoxWarrior2 = new PictureBox();
		pictureBoxMonster = new PictureBox();
		labelAD = new Label();
		labelAP = new Label();
		buttonBerserker = new Button();
		buttonDemacia = new Button();
		buttonHPbooster = new Button();
		textBoxADWarrior = new TextBox();
		textBoxAPWarrior = new TextBox();
		labelADMonster = new Label();
		textBoxADMonster = new TextBox();
		progressBarHPWarrior = new ProgressBar();
		progressBarHPMonster = new ProgressBar();
		progressBarManaWarrior = new ProgressBar();
		labelManaWarrior = new Label();
		labelHPWarrior = new Label();
		labelHPMonster = new Label();
		buttonAttackWarrior = new Button();
		textBoxSpellsVoice = new TextBox();
		((ISupportInitialize)pictureBoxWarrior2).BeginInit();
		((ISupportInitialize)pictureBoxMonster).BeginInit();
		((Control)this).SuspendLayout();
		((Control)pictureBoxWarrior2).set_Location(new Point(117, 138));
		((Control)pictureBoxWarrior2).set_Name("pictureBoxWarrior2");
		((Control)pictureBoxWarrior2).set_Size(new Size(205, 256));
		pictureBoxWarrior2.set_SizeMode((PictureBoxSizeMode)1);
		pictureBoxWarrior2.set_TabIndex(0);
		pictureBoxWarrior2.set_TabStop(false);
		((Control)pictureBoxWarrior2).set_UseWaitCursor(true);
		((Control)pictureBoxMonster).set_Location(new Point(410, 138));
		((Control)pictureBoxMonster).set_Name("pictureBoxMonster");
		((Control)pictureBoxMonster).set_Size(new Size(205, 256));
		pictureBoxMonster.set_SizeMode((PictureBoxSizeMode)1);
		pictureBoxMonster.set_TabIndex(1);
		pictureBoxMonster.set_TabStop(false);
		((Control)pictureBoxMonster).set_UseWaitCursor(true);
		((Control)labelAD).set_AutoSize(true);
		((Control)labelAD).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)labelAD).set_Location(new Point(11, 143));
		((Control)labelAD).set_Name("labelAD");
		((Control)labelAD).set_Size(new Size(25, 15));
		((Control)labelAD).set_TabIndex(2);
		((Control)labelAD).set_Text("AD");
		((Control)labelAD).set_UseWaitCursor(true);
		((Control)labelAP).set_AutoSize(true);
		((Control)labelAP).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)labelAP).set_Location(new Point(12, 174));
		((Control)labelAP).set_Name("labelAP");
		((Control)labelAP).set_Size(new Size(24, 15));
		((Control)labelAP).set_TabIndex(3);
		((Control)labelAP).set_Text("AP");
		((Control)labelAP).set_UseWaitCursor(true);
		((Control)buttonBerserker).set_Location(new Point(15, 214));
		((Control)buttonBerserker).set_Name("buttonBerserker");
		((Control)buttonBerserker).set_Size(new Size(75, 23));
		((Control)buttonBerserker).set_TabIndex(4);
		((Control)buttonBerserker).set_Text("Berserker");
		((ButtonBase)buttonBerserker).set_UseVisualStyleBackColor(true);
		((Control)buttonBerserker).set_UseWaitCursor(true);
		((Control)buttonBerserker).add_Click((EventHandler)buttonBerserker_Click);
		((Control)buttonDemacia).set_Location(new Point(15, 262));
		((Control)buttonDemacia).set_Name("buttonDemacia");
		((Control)buttonDemacia).set_Size(new Size(75, 23));
		((Control)buttonDemacia).set_TabIndex(5);
		((Control)buttonDemacia).set_Text("Demacia");
		((ButtonBase)buttonDemacia).set_UseVisualStyleBackColor(true);
		((Control)buttonDemacia).set_UseWaitCursor(true);
		((Control)buttonDemacia).add_Click((EventHandler)buttonDemacia_Click);
		((Control)buttonHPbooster).set_Location(new Point(15, 312));
		((Control)buttonHPbooster).set_Name("buttonHPbooster");
		((Control)buttonHPbooster).set_Size(new Size(96, 23));
		((Control)buttonHPbooster).set_TabIndex(6);
		((Control)buttonHPbooster).set_Text("HP BOOSTER");
		((ButtonBase)buttonHPbooster).set_UseVisualStyleBackColor(true);
		((Control)buttonHPbooster).set_UseWaitCursor(true);
		((Control)buttonHPbooster).add_Click((EventHandler)buttonHPbooster_Click);
		((Control)textBoxADWarrior).set_Enabled(false);
		((Control)textBoxADWarrior).set_Location(new Point(45, 138));
		((Control)textBoxADWarrior).set_Name("textBoxADWarrior");
		((Control)textBoxADWarrior).set_Size(new Size(45, 20));
		((Control)textBoxADWarrior).set_TabIndex(7);
		((Control)textBoxADWarrior).set_UseWaitCursor(true);
		((Control)textBoxAPWarrior).set_Enabled(false);
		((Control)textBoxAPWarrior).set_Location(new Point(45, 173));
		((Control)textBoxAPWarrior).set_Name("textBoxAPWarrior");
		((Control)textBoxAPWarrior).set_Size(new Size(45, 20));
		((Control)textBoxAPWarrior).set_TabIndex(8);
		((Control)textBoxAPWarrior).set_UseWaitCursor(true);
		((Control)labelADMonster).set_AutoSize(true);
		((Control)labelADMonster).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)labelADMonster).set_Location(new Point(633, 143));
		((Control)labelADMonster).set_Name("labelADMonster");
		((Control)labelADMonster).set_Size(new Size(25, 15));
		((Control)labelADMonster).set_TabIndex(9);
		((Control)labelADMonster).set_Text("AD");
		((Control)labelADMonster).set_UseWaitCursor(true);
		((Control)textBoxADMonster).set_Enabled(false);
		((Control)textBoxADMonster).set_Location(new Point(664, 143));
		((Control)textBoxADMonster).set_Name("textBoxADMonster");
		((Control)textBoxADMonster).set_Size(new Size(45, 20));
		((Control)textBoxADMonster).set_TabIndex(11);
		((Control)textBoxADMonster).set_UseWaitCursor(true);
		((Control)progressBarHPWarrior).set_Location(new Point(117, 400));
		((Control)progressBarHPWarrior).set_Name("progressBarHPWarrior");
		((Control)progressBarHPWarrior).set_Size(new Size(205, 23));
		((Control)progressBarHPWarrior).set_TabIndex(13);
		((Control)progressBarHPWarrior).set_UseWaitCursor(true);
		((Control)progressBarHPMonster).set_Location(new Point(410, 400));
		((Control)progressBarHPMonster).set_Name("progressBarHPMonster");
		((Control)progressBarHPMonster).set_Size(new Size(205, 23));
		((Control)progressBarHPMonster).set_TabIndex(14);
		((Control)progressBarHPMonster).set_UseWaitCursor(true);
		((Control)progressBarManaWarrior).set_Location(new Point(117, 426));
		((Control)progressBarManaWarrior).set_Name("progressBarManaWarrior");
		((Control)progressBarManaWarrior).set_Size(new Size(205, 23));
		((Control)progressBarManaWarrior).set_TabIndex(15);
		((Control)progressBarManaWarrior).set_UseWaitCursor(true);
		((Control)labelManaWarrior).set_AutoSize(true);
		((Control)labelManaWarrior).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)labelManaWarrior).set_Location(new Point(68, 426));
		((Control)labelManaWarrior).set_Name("labelManaWarrior");
		((Control)labelManaWarrior).set_Size(new Size(43, 15));
		((Control)labelManaWarrior).set_TabIndex(16);
		((Control)labelManaWarrior).set_Text("Mana");
		((Control)labelManaWarrior).set_UseWaitCursor(true);
		((Control)labelHPWarrior).set_AutoSize(true);
		((Control)labelHPWarrior).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)labelHPWarrior).set_Location(new Point(86, 400));
		((Control)labelHPWarrior).set_Name("labelHPWarrior");
		((Control)labelHPWarrior).set_Size(new Size(26, 15));
		((Control)labelHPWarrior).set_TabIndex(17);
		((Control)labelHPWarrior).set_Text("HP");
		((Control)labelHPWarrior).set_UseWaitCursor(true);
		((Control)labelHPMonster).set_AutoSize(true);
		((Control)labelHPMonster).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)labelHPMonster).set_Location(new Point(378, 400));
		((Control)labelHPMonster).set_Name("labelHPMonster");
		((Control)labelHPMonster).set_Size(new Size(26, 15));
		((Control)labelHPMonster).set_TabIndex(18);
		((Control)labelHPMonster).set_Text("HP");
		((Control)labelHPMonster).set_UseWaitCursor(true);
		((Control)buttonAttackWarrior).set_Location(new Point(174, 95));
		((Control)buttonAttackWarrior).set_Name("buttonAttackWarrior");
		((Control)buttonAttackWarrior).set_Size(new Size(101, 37));
		((Control)buttonAttackWarrior).set_TabIndex(19);
		((Control)buttonAttackWarrior).set_Text("Basic Attack");
		((ButtonBase)buttonAttackWarrior).set_UseVisualStyleBackColor(true);
		((Control)buttonAttackWarrior).set_UseWaitCursor(true);
		((Control)buttonAttackWarrior).add_Click((EventHandler)buttonAttackWarrior_Click);
		((Control)textBoxSpellsVoice).set_Enabled(false);
		((Control)textBoxSpellsVoice).set_Location(new Point(152, 31));
		((TextBoxBase)textBoxSpellsVoice).set_Multiline(true);
		((Control)textBoxSpellsVoice).set_Name("textBoxSpellsVoice");
		((Control)textBoxSpellsVoice).set_Size(new Size(147, 33));
		((Control)textBoxSpellsVoice).set_TabIndex(20);
		((Control)textBoxSpellsVoice).set_UseWaitCursor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(739, 471));
		((Control)this).get_Controls().Add((Control)(object)textBoxSpellsVoice);
		((Control)this).get_Controls().Add((Control)(object)buttonAttackWarrior);
		((Control)this).get_Controls().Add((Control)(object)labelHPMonster);
		((Control)this).get_Controls().Add((Control)(object)labelHPWarrior);
		((Control)this).get_Controls().Add((Control)(object)labelManaWarrior);
		((Control)this).get_Controls().Add((Control)(object)progressBarManaWarrior);
		((Control)this).get_Controls().Add((Control)(object)progressBarHPMonster);
		((Control)this).get_Controls().Add((Control)(object)progressBarHPWarrior);
		((Control)this).get_Controls().Add((Control)(object)textBoxADMonster);
		((Control)this).get_Controls().Add((Control)(object)labelADMonster);
		((Control)this).get_Controls().Add((Control)(object)textBoxAPWarrior);
		((Control)this).get_Controls().Add((Control)(object)textBoxADWarrior);
		((Control)this).get_Controls().Add((Control)(object)buttonHPbooster);
		((Control)this).get_Controls().Add((Control)(object)buttonDemacia);
		((Control)this).get_Controls().Add((Control)(object)buttonBerserker);
		((Control)this).get_Controls().Add((Control)(object)labelAP);
		((Control)this).get_Controls().Add((Control)(object)labelAD);
		((Control)this).get_Controls().Add((Control)(object)pictureBoxMonster);
		((Control)this).get_Controls().Add((Control)(object)pictureBoxWarrior2);
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		((Control)this).set_Name("WarriorvsOpponent");
		((Control)this).set_Text("WarriorvsOpponent");
		((Control)this).set_UseWaitCursor(true);
		((Form)this).add_Load((EventHandler)WarriorvsOpponent_Load);
		((ISupportInitialize)pictureBoxWarrior2).EndInit();
		((ISupportInitialize)pictureBoxMonster).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
