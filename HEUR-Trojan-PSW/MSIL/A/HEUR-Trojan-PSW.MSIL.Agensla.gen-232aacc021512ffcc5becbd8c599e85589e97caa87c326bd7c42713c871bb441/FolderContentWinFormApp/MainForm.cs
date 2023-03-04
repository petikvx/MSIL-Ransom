using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FolderContentWinFormApp;

public class MainForm : Form
{
	private DirectoryInfo _SelectedDirectory;

	private FileInfo[] _files;

	private StringBuilder clipData;

	private IContainer components = null;

	private Button browseButton;

	private FolderBrowserDialog folderBrowserDialog;

	private Button saveButton;

	private SaveFileDialog saveFileDialog;

	public MainForm()
	{
		InitializeComponent();
		((Control)saveButton).set_Enabled(false);
		((FileDialog)saveFileDialog).set_Filter("txt files (*.txt)|*.txt");
		((FileDialog)saveFileDialog).set_FilterIndex(1);
		((FileDialog)saveFileDialog).set_RestoreDirectory(true);
		((FileDialog)saveFileDialog).add_FileOk((CancelEventHandler)SaveFileDialogOnFileOk);
	}

	private void SaveFileDialogOnFileOk(object sender, CancelEventArgs e)
	{
		string fileName = ((FileDialog)saveFileDialog).get_FileName();
		string text = "";
		FileInfo[] files = _files;
		foreach (FileInfo fileInfo in files)
		{
			text += fileInfo.Name;
			text += "\n";
		}
		WriteNamesToFile(fileName, _files);
		((Control)saveButton).set_Enabled(false);
	}

	private void browseButton_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		folderBrowserDialog = new FolderBrowserDialog();
		DialogResult val = ((CommonDialog)folderBrowserDialog).ShowDialog();
		if ((int)val == 1)
		{
			_SelectedDirectory = new DirectoryInfo(folderBrowserDialog.get_SelectedPath());
			((Control)saveButton).set_Enabled(true);
		}
		_files = _SelectedDirectory.GetFiles("*.*", SearchOption.AllDirectories);
		clipData = new StringBuilder();
		foreach (string item in GetFileNamesFromPath(_files))
		{
			clipData.AppendLine(item);
		}
		Clipboard.SetText(clipData.ToString());
		MessageBox.Show("File names copied in Clipboard\nClick \"Save as Text File\" to save as text file");
	}

	private void saveButton_Click(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((CommonDialog)saveFileDialog).ShowDialog();
	}

	public static void WriteNamesToFile(string saveAsName, FileInfo[] fileInfos)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			File.WriteAllText(saveAsName, Clipboard.GetText());
		}
		catch (Exception ex)
		{
			MessageBox.Show("Exception: " + ex.Message);
		}
	}

	private static List<string> GetFileNamesFromPath(FileInfo[] fileInfos)
	{
		List<string> list = new List<string>();
		string directoryName = fileInfos[0].DirectoryName;
		list.Add(fileInfos[0].Directory!.Name);
		foreach (FileInfo fileInfo in fileInfos)
		{
			if (directoryName == fileInfo.DirectoryName)
			{
				list.Add("\t" + fileInfo.Name);
				continue;
			}
			directoryName = fileInfo.DirectoryName;
			list.Add(fileInfo.Directory!.Name);
		}
		return list;
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
		browseButton = new Button();
		folderBrowserDialog = new FolderBrowserDialog();
		saveButton = new Button();
		saveFileDialog = new SaveFileDialog();
		((Control)this).SuspendLayout();
		((Control)browseButton).set_Location(new Point(42, 12));
		((Control)browseButton).set_Name("browseButton");
		((Control)browseButton).set_Size(new Size(177, 23));
		((Control)browseButton).set_TabIndex(0);
		((Control)browseButton).set_Text("<< Browse >>");
		((ButtonBase)browseButton).set_UseVisualStyleBackColor(true);
		((Control)browseButton).add_Click((EventHandler)browseButton_Click);
		((Control)saveButton).set_Location(new Point(42, 51));
		((Control)saveButton).set_Name("saveButton");
		((Control)saveButton).set_Size(new Size(177, 23));
		((Control)saveButton).set_TabIndex(0);
		((Control)saveButton).set_Text("Save as Text File");
		((ButtonBase)saveButton).set_UseVisualStyleBackColor(true);
		((Control)saveButton).add_Click((EventHandler)saveButton_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(253, 100));
		((Control)this).get_Controls().Add((Control)(object)saveButton);
		((Control)this).get_Controls().Add((Control)(object)browseButton);
		((Control)this).set_Name("MainForm");
		((Control)this).ResumeLayout(false);
	}
}
