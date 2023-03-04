using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AdrianPiecyk_Lab2;

public class AssassinvsOpponent : Form
{
	private Assassin assassin;

	private Opponent monster;

	private IContainer components = null;

	private TextBox textBoxSpellsVoice;

	private Button buttonAttackAssassin;

	private Label labelHPMonster;

	private Label labelHPAssassin;

	private Label labelManaAssassin;

	private ProgressBar progressBarManaAssassin;

	private ProgressBar progressBarHPMonster;

	private ProgressBar progressBarHPAssassin;

	private TextBox textBoxADMonster;

	private Label labelADMonster;

	private TextBox textBoxAPAssassin;

	private TextBox textBoxADAssassin;

	private Button buttonShadowAttack;

	private Button buttonDragonSwift;

	private Button buttonShuriken;

	private Label labelAPAssassin;

	private Label labelADAssassin;

	private PictureBox pictureBoxMonster;

	private PictureBox pictureBoxAssassin;

	public AssassinvsOpponent()
	{
		InitializeComponent();
	}

	private void AssassinvsOpponent_Load(object sender, EventArgs e)
	{
		pictureBoxAssassin.set_Image(Image.FromFile("C:\\Users\\Adrian\\Desktop\\c# obraz\\assassin.jpg"));
		pictureBoxMonster.set_Image(Image.FromFile("C:\\Users\\Adrian\\Desktop\\c# obraz\\monster.jpg"));
		progressBarHPAssassin.set_Value(100);
		progressBarManaAssassin.set_Value(100);
		progressBarHPMonster.set_Value(100);
		assassin = new Assassin("JED", 50, 170, 2200, 900);
		((Control)textBoxADAssassin).set_Text(assassin.AttackDamage.ToString());
		((Control)textBoxAPAssassin).set_Text(assassin.AbilityPower.ToString());
		monster = new Opponent("GAZOL", 0, 0, 40, 10000);
		((Control)textBoxADMonster).set_Text(monster.AttackDamage.ToString());
	}

	private void buttonShuriken_Click(object sender, EventArgs e)
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		assassin.Mana -= 50;
		assassin.HP -= monster.Attack();
		if (assassin.Mana <= 0)
		{
			((Control)buttonShuriken).set_Enabled(false);
		}
		else
		{
			progressBarManaAssassin.set_Value(assassin.PercentMana());
		}
		((Control)textBoxSpellsVoice).set_Text(assassin.Spellfirst());
		monster.HP -= 100;
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
		if (assassin.HP <= 0)
		{
			assassin.HP = 0;
			progressBarHPAssassin.set_Value(assassin.PercentHP());
			string text2 = "You are death, try again!";
			MessageBox.Show(text2);
			((Control)this).set_Visible(false);
		}
		else
		{
			progressBarHPAssassin.set_Value(assassin.PercentHP());
		}
	}

	private void buttonAttackAssassin_Click(object sender, EventArgs e)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		monster.HP -= assassin.Attack();
		assassin.HP -= monster.Attack();
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
		if (assassin.HP <= 0)
		{
			assassin.HP = 0;
			progressBarHPAssassin.set_Value(assassin.PercentHP());
			string text2 = "You are death, try again!";
			MessageBox.Show(text2);
			((Control)this).set_Visible(false);
		}
		else
		{
			progressBarHPAssassin.set_Value(assassin.PercentHP());
		}
	}

	private void buttonDragonSwift_Click(object sender, EventArgs e)
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		assassin.Mana -= 250;
		assassin.HP -= monster.Attack();
		if (assassin.Mana <= 0)
		{
			((Control)buttonDragonSwift).set_Enabled(false);
		}
		else
		{
			progressBarManaAssassin.set_Value(assassin.PercentMana());
		}
		((Control)textBoxSpellsVoice).set_Text(assassin.Spellsecond());
		monster.HP -= 400;
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
		if (assassin.HP <= 0)
		{
			assassin.HP = 0;
			progressBarHPAssassin.set_Value(assassin.PercentHP());
			string text2 = "You are death, try again!";
			MessageBox.Show(text2);
			((Control)this).set_Visible(false);
		}
		else
		{
			progressBarHPAssassin.set_Value(assassin.PercentHP());
		}
	}

	private void buttonShadowAttack_Click(object sender, EventArgs e)
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		assassin.Mana -= 400;
		assassin.HP -= monster.Attack();
		if (assassin.Mana <= 0)
		{
			((Control)buttonShadowAttack).set_Enabled(false);
		}
		else
		{
			progressBarManaAssassin.set_Value(assassin.PercentMana());
		}
		((Control)textBoxSpellsVoice).set_Text(assassin.Spellsecond());
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
		if (assassin.HP <= 0)
		{
			assassin.HP = 0;
			progressBarHPAssassin.set_Value(assassin.PercentHP());
			string text2 = "You are death, try again!";
			MessageBox.Show(text2);
			((Control)this).set_Visible(false);
		}
		else
		{
			progressBarHPAssassin.set_Value(assassin.PercentHP());
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
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected O, but got Unknown
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected O, but got Unknown
		//IL_076c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0776: Expected O, but got Unknown
		//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Expected O, but got Unknown
		//IL_0ac5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acf: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AssassinvsOpponent));
		textBoxSpellsVoice = new TextBox();
		buttonAttackAssassin = new Button();
		labelHPMonster = new Label();
		labelHPAssassin = new Label();
		labelManaAssassin = new Label();
		progressBarManaAssassin = new ProgressBar();
		progressBarHPMonster = new ProgressBar();
		progressBarHPAssassin = new ProgressBar();
		textBoxADMonster = new TextBox();
		labelADMonster = new Label();
		textBoxAPAssassin = new TextBox();
		textBoxADAssassin = new TextBox();
		buttonShadowAttack = new Button();
		buttonDragonSwift = new Button();
		buttonShuriken = new Button();
		labelAPAssassin = new Label();
		labelADAssassin = new Label();
		pictureBoxMonster = new PictureBox();
		pictureBoxAssassin = new PictureBox();
		((ISupportInitialize)pictureBoxMonster).BeginInit();
		((ISupportInitialize)pictureBoxAssassin).BeginInit();
		((Control)this).SuspendLayout();
		((Control)textBoxSpellsVoice).set_Enabled(false);
		((Control)textBoxSpellsVoice).set_Location(new Point(161, 26));
		((TextBoxBase)textBoxSpellsVoice).set_Multiline(true);
		((Control)textBoxSpellsVoice).set_Name("textBoxSpellsVoice");
		((Control)textBoxSpellsVoice).set_Size(new Size(147, 33));
		((Control)textBoxSpellsVoice).set_TabIndex(41);
		((Control)buttonAttackAssassin).set_Location(new Point(183, 90));
		((Control)buttonAttackAssassin).set_Name("buttonAttackAssassin");
		((Control)buttonAttackAssassin).set_Size(new Size(101, 37));
		((Control)buttonAttackAssassin).set_TabIndex(40);
		((Control)buttonAttackAssassin).set_Text("Basic Attack");
		((ButtonBase)buttonAttackAssassin).set_UseVisualStyleBackColor(true);
		((Control)buttonAttackAssassin).add_Click((EventHandler)buttonAttackAssassin_Click);
		((Control)labelHPMonster).set_AutoSize(true);
		((Control)labelHPMonster).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)labelHPMonster).set_Location(new Point(387, 395));
		((Control)labelHPMonster).set_Name("labelHPMonster");
		((Control)labelHPMonster).set_Size(new Size(26, 15));
		((Control)labelHPMonster).set_TabIndex(39);
		((Control)labelHPMonster).set_Text("HP");
		((Control)labelHPAssassin).set_AutoSize(true);
		((Control)labelHPAssassin).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)labelHPAssassin).set_Location(new Point(95, 395));
		((Control)labelHPAssassin).set_Name("labelHPAssassin");
		((Control)labelHPAssassin).set_Size(new Size(26, 15));
		((Control)labelHPAssassin).set_TabIndex(38);
		((Control)labelHPAssassin).set_Text("HP");
		((Control)labelManaAssassin).set_AutoSize(true);
		((Control)labelManaAssassin).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)labelManaAssassin).set_Location(new Point(77, 421));
		((Control)labelManaAssassin).set_Name("labelManaAssassin");
		((Control)labelManaAssassin).set_Size(new Size(43, 15));
		((Control)labelManaAssassin).set_TabIndex(37);
		((Control)labelManaAssassin).set_Text("Mana");
		((Control)progressBarManaAssassin).set_Location(new Point(126, 421));
		((Control)progressBarManaAssassin).set_Name("progressBarManaAssassin");
		((Control)progressBarManaAssassin).set_Size(new Size(205, 23));
		((Control)progressBarManaAssassin).set_TabIndex(36);
		((Control)progressBarHPMonster).set_Location(new Point(419, 395));
		((Control)progressBarHPMonster).set_Name("progressBarHPMonster");
		((Control)progressBarHPMonster).set_Size(new Size(205, 23));
		((Control)progressBarHPMonster).set_TabIndex(35);
		((Control)progressBarHPAssassin).set_Location(new Point(126, 395));
		((Control)progressBarHPAssassin).set_Name("progressBarHPAssassin");
		((Control)progressBarHPAssassin).set_Size(new Size(205, 23));
		((Control)progressBarHPAssassin).set_TabIndex(34);
		((Control)textBoxADMonster).set_Enabled(false);
		((Control)textBoxADMonster).set_Location(new Point(673, 138));
		((Control)textBoxADMonster).set_Name("textBoxADMonster");
		((Control)textBoxADMonster).set_Size(new Size(45, 20));
		((Control)textBoxADMonster).set_TabIndex(32);
		((Control)labelADMonster).set_AutoSize(true);
		((Control)labelADMonster).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)labelADMonster).set_Location(new Point(642, 138));
		((Control)labelADMonster).set_Name("labelADMonster");
		((Control)labelADMonster).set_Size(new Size(25, 15));
		((Control)labelADMonster).set_TabIndex(30);
		((Control)labelADMonster).set_Text("AD");
		((Control)textBoxAPAssassin).set_Enabled(false);
		((Control)textBoxAPAssassin).set_Location(new Point(54, 168));
		((Control)textBoxAPAssassin).set_Name("textBoxAPAssassin");
		((Control)textBoxAPAssassin).set_Size(new Size(45, 20));
		((Control)textBoxAPAssassin).set_TabIndex(29);
		((Control)textBoxADAssassin).set_Enabled(false);
		((Control)textBoxADAssassin).set_Location(new Point(54, 133));
		((Control)textBoxADAssassin).set_Name("textBoxADAssassin");
		((Control)textBoxADAssassin).set_Size(new Size(45, 20));
		((Control)textBoxADAssassin).set_TabIndex(28);
		((Control)buttonShadowAttack).set_Location(new Point(24, 307));
		((Control)buttonShadowAttack).set_Name("buttonShadowAttack");
		((Control)buttonShadowAttack).set_Size(new Size(96, 23));
		((Control)buttonShadowAttack).set_TabIndex(27);
		((Control)buttonShadowAttack).set_Text("Shadow Attack");
		((ButtonBase)buttonShadowAttack).set_UseVisualStyleBackColor(true);
		((Control)buttonShadowAttack).add_Click((EventHandler)buttonShadowAttack_Click);
		((Control)buttonDragonSwift).set_Location(new Point(24, 256));
		((Control)buttonDragonSwift).set_Name("buttonDragonSwift");
		((Control)buttonDragonSwift).set_Size(new Size(96, 23));
		((Control)buttonDragonSwift).set_TabIndex(26);
		((Control)buttonDragonSwift).set_Text("Dragon Swift");
		((ButtonBase)buttonDragonSwift).set_UseVisualStyleBackColor(true);
		((Control)buttonDragonSwift).add_Click((EventHandler)buttonDragonSwift_Click);
		((Control)buttonShuriken).set_Location(new Point(24, 209));
		((Control)buttonShuriken).set_Name("buttonShuriken");
		((Control)buttonShuriken).set_Size(new Size(75, 23));
		((Control)buttonShuriken).set_TabIndex(25);
		((Control)buttonShuriken).set_Text("Shuriken");
		((ButtonBase)buttonShuriken).set_UseVisualStyleBackColor(true);
		((Control)buttonShuriken).add_Click((EventHandler)buttonShuriken_Click);
		((Control)labelAPAssassin).set_AutoSize(true);
		((Control)labelAPAssassin).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)labelAPAssassin).set_Location(new Point(21, 169));
		((Control)labelAPAssassin).set_Name("labelAPAssassin");
		((Control)labelAPAssassin).set_Size(new Size(24, 15));
		((Control)labelAPAssassin).set_TabIndex(24);
		((Control)labelAPAssassin).set_Text("AP");
		((Control)labelADAssassin).set_AutoSize(true);
		((Control)labelADAssassin).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)labelADAssassin).set_Location(new Point(20, 138));
		((Control)labelADAssassin).set_Name("labelADAssassin");
		((Control)labelADAssassin).set_Size(new Size(25, 15));
		((Control)labelADAssassin).set_TabIndex(23);
		((Control)labelADAssassin).set_Text("AD");
		((Control)pictureBoxMonster).set_Location(new Point(419, 133));
		((Control)pictureBoxMonster).set_Name("pictureBoxMonster");
		((Control)pictureBoxMonster).set_Size(new Size(205, 256));
		pictureBoxMonster.set_SizeMode((PictureBoxSizeMode)1);
		pictureBoxMonster.set_TabIndex(22);
		pictureBoxMonster.set_TabStop(false);
		((Control)pictureBoxMonster).set_UseWaitCursor(true);
		((Control)pictureBoxAssassin).set_Location(new Point(126, 133));
		((Control)pictureBoxAssassin).set_Name("pictureBoxAssassin");
		((Control)pictureBoxAssassin).set_Size(new Size(205, 256));
		pictureBoxAssassin.set_SizeMode((PictureBoxSizeMode)1);
		pictureBoxAssassin.set_TabIndex(21);
		pictureBoxAssassin.set_TabStop(false);
		((Control)pictureBoxAssassin).set_UseWaitCursor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(739, 471));
		((Control)this).get_Controls().Add((Control)(object)textBoxSpellsVoice);
		((Control)this).get_Controls().Add((Control)(object)buttonAttackAssassin);
		((Control)this).get_Controls().Add((Control)(object)labelHPMonster);
		((Control)this).get_Controls().Add((Control)(object)labelHPAssassin);
		((Control)this).get_Controls().Add((Control)(object)labelManaAssassin);
		((Control)this).get_Controls().Add((Control)(object)progressBarManaAssassin);
		((Control)this).get_Controls().Add((Control)(object)progressBarHPMonster);
		((Control)this).get_Controls().Add((Control)(object)progressBarHPAssassin);
		((Control)this).get_Controls().Add((Control)(object)textBoxADMonster);
		((Control)this).get_Controls().Add((Control)(object)labelADMonster);
		((Control)this).get_Controls().Add((Control)(object)textBoxAPAssassin);
		((Control)this).get_Controls().Add((Control)(object)textBoxADAssassin);
		((Control)this).get_Controls().Add((Control)(object)buttonShadowAttack);
		((Control)this).get_Controls().Add((Control)(object)buttonDragonSwift);
		((Control)this).get_Controls().Add((Control)(object)buttonShuriken);
		((Control)this).get_Controls().Add((Control)(object)labelAPAssassin);
		((Control)this).get_Controls().Add((Control)(object)labelADAssassin);
		((Control)this).get_Controls().Add((Control)(object)pictureBoxMonster);
		((Control)this).get_Controls().Add((Control)(object)pictureBoxAssassin);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("AssassinvsOpponent");
		((Control)this).set_Text("AssassinvsOpponent");
		((Form)this).add_Load((EventHandler)AssassinvsOpponent_Load);
		((ISupportInitialize)pictureBoxMonster).EndInit();
		((ISupportInitialize)pictureBoxAssassin).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
