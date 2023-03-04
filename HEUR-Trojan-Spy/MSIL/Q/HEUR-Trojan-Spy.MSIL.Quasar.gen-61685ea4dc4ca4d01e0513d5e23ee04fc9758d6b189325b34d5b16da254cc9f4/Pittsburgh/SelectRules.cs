using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;

namespace Pittsburgh;

public class SelectRules : Window, IComponentConnector
{
	private List<Rule> _rules;

	private bool _contentLoaded;

	public SelectRules()
	{
		InitializeComponent();
	}

	public SelectRules(List<Rule> rules)
	{
		_rules = rules;
	}

	private void InitializeRuleList()
	{
		foreach (Rule rule in _rules)
		{
			_ = rule;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/pRaY;component/selectrules.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		_contentLoaded = true;
	}
}
