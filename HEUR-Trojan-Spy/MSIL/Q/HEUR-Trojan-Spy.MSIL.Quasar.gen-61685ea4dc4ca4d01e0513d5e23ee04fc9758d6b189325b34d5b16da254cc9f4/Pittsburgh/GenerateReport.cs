using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Pittsburgh;

public class GenerateReport : Window, IComponentConnector
{
	internal RadioButton radioButton1;

	internal RadioButton radioButton2;

	private bool _contentLoaded;

	public GenerateReport()
	{
		InitializeComponent();
	}

	private void Window_Loaded(object sender, RoutedEventArgs e)
	{
		string[] files = Directory.GetFiles("ReportTemplates");
		for (int i = 0; i < files.Length; i++)
		{
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/pRaY;component/generatereport.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		switch (connectionId)
		{
		default:
			_contentLoaded = true;
			break;
		case 1:
			((FrameworkElement)(GenerateReport)target).add_Loaded(new RoutedEventHandler(Window_Loaded));
			break;
		case 2:
			radioButton1 = (RadioButton)target;
			break;
		case 3:
			radioButton2 = (RadioButton)target;
			break;
		}
	}
}
