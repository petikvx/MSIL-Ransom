using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AxWMPLib;
using Microsoft.VisualBasic.CompilerServices;

namespace SAITMCalculator;

[DesignerGenerated]
public sealed class AboutBox1 : Form
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("LabelCompanyName")]
	[CompilerGenerated]
	private Label oDlotdjii;

	private IContainer icontainer_0;

	[field: AccessedThroughProperty("TableLayoutPanel")]
	internal virtual TableLayoutPanel TableLayoutPanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LogoPictureBox")]
	internal virtual PictureBox LogoPictureBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LabelProductName")]
	internal virtual Label LabelProductName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LabelVersion")]
	internal virtual Label LabelVersion
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label LabelCompanyName
	{
		[CompilerGenerated]
		get
		{
			return oDlotdjii;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			oDlotdjii = value;
		}
	}

	[field: AccessedThroughProperty("TextBoxDescription")]
	internal virtual TextBox TextBoxDescription
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button OKButton
	{
		[CompilerGenerated]
		get
		{
			return _OKButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_0;
			Button oKButton = _OKButton;
			if (oKButton != null)
			{
				((Control)oKButton).remove_Click(eventHandler);
			}
			_OKButton = value;
			oKButton = _OKButton;
			if (oKButton != null)
			{
				((Control)oKButton).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("LabelCopyright")]
	internal virtual Label LabelCopyright
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("mediaplayer")]
	internal virtual AxWindowsMediaPlayer mediaplayer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public AboutBox1()
	{
		Class8.BpPkGHSz2q2OL();
		((Form)this)._002Ector();
		((Form)this).add_Load((EventHandler)AboutBox1_Load);
		zwtNkixwY();
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
	private void zwtNkixwY()
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
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0702: Unknown result type (might be due to invalid IL or missing references)
		//IL_070c: Expected O, but got Unknown
		//IL_07ba: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AboutBox1));
		TableLayoutPanel = new TableLayoutPanel();
		LogoPictureBox = new PictureBox();
		LabelProductName = new Label();
		LabelVersion = new Label();
		LabelCopyright = new Label();
		LabelCompanyName = new Label();
		TextBoxDescription = new TextBox();
		OKButton = new Button();
		mediaplayer = new AxWindowsMediaPlayer();
		((Control)TableLayoutPanel).SuspendLayout();
		((ISupportInitialize)LogoPictureBox).BeginInit();
		((ISupportInitialize)mediaplayer).BeginInit();
		((Control)this).SuspendLayout();
		((Control)TableLayoutPanel).set_Anchor((AnchorStyles)15);
		TableLayoutPanel.set_ColumnCount(2);
		TableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 33f));
		TableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 67f));
		TableLayoutPanel.get_Controls().Add((Control)(object)LogoPictureBox, 0, 0);
		TableLayoutPanel.get_Controls().Add((Control)(object)LabelProductName, 1, 0);
		TableLayoutPanel.get_Controls().Add((Control)(object)LabelVersion, 1, 1);
		TableLayoutPanel.get_Controls().Add((Control)(object)LabelCopyright, 1, 2);
		TableLayoutPanel.get_Controls().Add((Control)(object)LabelCompanyName, 1, 3);
		TableLayoutPanel.get_Controls().Add((Control)(object)TextBoxDescription, 1, 4);
		TableLayoutPanel.get_Controls().Add((Control)(object)OKButton, 1, 5);
		((Control)TableLayoutPanel).set_Location(new Point(9, 9));
		((Control)TableLayoutPanel).set_Name("TableLayoutPanel");
		TableLayoutPanel.set_RowCount(6);
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 50f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		((Control)TableLayoutPanel).set_Size(new Size(507, 368));
		((Control)TableLayoutPanel).set_TabIndex(0);
		((Control)LogoPictureBox).set_BackgroundImage((Image)(object)Class6.smethod_1());
		((Control)LogoPictureBox).set_BackgroundImageLayout((ImageLayout)2);
		((Control)LogoPictureBox).set_Dock((DockStyle)5);
		((Control)LogoPictureBox).set_Location(new Point(3, 3));
		((Control)LogoPictureBox).set_Name("LogoPictureBox");
		TableLayoutPanel.SetRowSpan((Control)(object)LogoPictureBox, 6);
		((Control)LogoPictureBox).set_Size(new Size(161, 362));
		LogoPictureBox.set_SizeMode((PictureBoxSizeMode)1);
		LogoPictureBox.set_TabIndex(0);
		LogoPictureBox.set_TabStop(false);
		((Control)LabelProductName).set_Dock((DockStyle)5);
		((Control)LabelProductName).set_Location(new Point(173, 0));
		((Control)LabelProductName).set_Margin(new Padding(6, 0, 3, 0));
		((Control)LabelProductName).set_MaximumSize(new Size(0, 17));
		((Control)LabelProductName).set_Name("LabelProductName");
		((Control)LabelProductName).set_Size(new Size(331, 17));
		((Control)LabelProductName).set_TabIndex(0);
		LabelProductName.set_Text("Product Name  CSSCal 0.1\r\n");
		LabelProductName.set_TextAlign((ContentAlignment)16);
		((Control)LabelVersion).set_Dock((DockStyle)5);
		((Control)LabelVersion).set_Location(new Point(173, 36));
		((Control)LabelVersion).set_Margin(new Padding(6, 0, 3, 0));
		((Control)LabelVersion).set_MaximumSize(new Size(0, 17));
		((Control)LabelVersion).set_Name("LabelVersion");
		((Control)LabelVersion).set_Size(new Size(331, 17));
		((Control)LabelVersion).set_TabIndex(0);
		LabelVersion.set_Text("Version 0.1a\r\n");
		LabelVersion.set_TextAlign((ContentAlignment)16);
		((Control)LabelCopyright).set_Dock((DockStyle)5);
		((Control)LabelCopyright).set_Location(new Point(173, 72));
		((Control)LabelCopyright).set_Margin(new Padding(6, 0, 3, 0));
		((Control)LabelCopyright).set_MaximumSize(new Size(0, 17));
		((Control)LabelCopyright).set_Name("LabelCopyright");
		((Control)LabelCopyright).set_Size(new Size(331, 17));
		((Control)LabelCopyright).set_TabIndex(0);
		LabelCopyright.set_Text("Copyright  BLD Dilanga ");
		LabelCopyright.set_TextAlign((ContentAlignment)16);
		((Control)LabelCompanyName).set_Dock((DockStyle)5);
		((Control)LabelCompanyName).set_Location(new Point(173, 108));
		((Control)LabelCompanyName).set_Margin(new Padding(6, 0, 3, 0));
		((Control)LabelCompanyName).set_MaximumSize(new Size(0, 17));
		((Control)LabelCompanyName).set_Name("LabelCompanyName");
		((Control)LabelCompanyName).set_Size(new Size(331, 17));
		((Control)LabelCompanyName).set_TabIndex(0);
		LabelCompanyName.set_Text("Date 2010/02/10 \r\n");
		LabelCompanyName.set_TextAlign((ContentAlignment)16);
		((Control)TextBoxDescription).set_Dock((DockStyle)5);
		((Control)TextBoxDescription).set_Location(new Point(173, 147));
		((Control)TextBoxDescription).set_Margin(new Padding(6, 3, 3, 3));
		TextBoxDescription.set_Multiline(true);
		((Control)TextBoxDescription).set_Name("TextBoxDescription");
		((TextBoxBase)TextBoxDescription).set_ReadOnly(true);
		TextBoxDescription.set_ScrollBars((ScrollBars)3);
		((Control)TextBoxDescription).set_Size(new Size(331, 178));
		((Control)TextBoxDescription).set_TabIndex(0);
		((Control)TextBoxDescription).set_TabStop(false);
		TextBoxDescription.set_Text(componentResourceManager.GetString("TextBoxDescription.Text"));
		((Control)OKButton).set_Anchor((AnchorStyles)10);
		OKButton.set_DialogResult((DialogResult)2);
		((Control)OKButton).set_Location(new Point(429, 342));
		((Control)OKButton).set_Name("OKButton");
		((Control)OKButton).set_Size(new Size(75, 23));
		((Control)OKButton).set_TabIndex(0);
		((ButtonBase)OKButton).set_Text("&OK");
		((AxHost)mediaplayer).set_Enabled(true);
		((Control)mediaplayer).set_Location(new Point(541, 374));
		((Control)mediaplayer).set_Name("mediaplayer");
		((AxHost)mediaplayer).set_OcxState((State)componentResourceManager.GetObject("mediaplayer.OcxState"));
		((Control)mediaplayer).set_Size(new Size(38, 45));
		((Control)mediaplayer).set_TabIndex(57);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.WhiteSmoke);
		((Form)this).set_CancelButton((IButtonControl)(object)OKButton);
		((Form)this).set_ClientSize(new Size(528, 389));
		((Control)this).get_Controls().Add((Control)(object)mediaplayer);
		((Control)this).get_Controls().Add((Control)(object)TableLayoutPanel);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("AboutBox1");
		((Control)this).set_Padding(new Padding(9));
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Form)this).set_Text("About");
		((Control)TableLayoutPanel).ResumeLayout(false);
		((Control)TableLayoutPanel).PerformLayout();
		((ISupportInitialize)LogoPictureBox).EndInit();
		((ISupportInitialize)mediaplayer).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void AboutBox1_Load(object sender, EventArgs e)
	{
	}

	private void method_0(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
