using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;

namespace Pittsburgh;

public class NewRule : Window, IComponentConnector
{
	public Rule newRule;

	internal TextBox TitleBox;

	internal TextBlock textBlock1;

	internal TextBlock textBlock3;

	internal TextBox RegexBox;

	internal TextBox ExtensionBox;

	internal TextBlock textBlock2;

	internal TextBox GuidanceBox;

	internal TextBlock textBlock4;

	internal TextBox DescriptionBox;

	internal TextBlock textBlock5;

	internal Button Save;

	internal Button Cancel;

	private bool _contentLoaded;

	public NewRule()
	{
		InitializeComponent();
	}

	private void Cancel_Click(object sender, RoutedEventArgs e)
	{
		((Window)this).Close();
	}

	private void Save_Click(object sender, RoutedEventArgs e)
	{
		string text = TitleBox.get_Text();
		string text2 = DescriptionBox.get_Text();
		string text3 = RegexBox.get_Text();
		List<string> extensions = new List<string>(ExtensionBox.get_Text().Split(new char[1] { ',' }));
		List<string> guidance = new List<string>(Regex.Split(GuidanceBox.get_Text(), "\r\n"));
		newRule = new Rule(text, text2, text3, extensions, guidance);
		((Window)this).Close();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/pRaY;component/newrule.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		switch (connectionId)
		{
		default:
			_contentLoaded = true;
			break;
		case 1:
			TitleBox = (TextBox)target;
			break;
		case 2:
			textBlock1 = (TextBlock)target;
			break;
		case 3:
			textBlock3 = (TextBlock)target;
			break;
		case 4:
			RegexBox = (TextBox)target;
			break;
		case 5:
			ExtensionBox = (TextBox)target;
			break;
		case 6:
			textBlock2 = (TextBlock)target;
			break;
		case 7:
			GuidanceBox = (TextBox)target;
			break;
		case 8:
			textBlock4 = (TextBlock)target;
			break;
		case 9:
			DescriptionBox = (TextBox)target;
			break;
		case 10:
			textBlock5 = (TextBlock)target;
			break;
		case 11:
			Save = (Button)target;
			((ButtonBase)Save).add_Click(new RoutedEventHandler(Save_Click));
			break;
		case 12:
			Cancel = (Button)target;
			((ButtonBase)Cancel).add_Click(new RoutedEventHandler(Cancel_Click));
			break;
		}
	}
}
