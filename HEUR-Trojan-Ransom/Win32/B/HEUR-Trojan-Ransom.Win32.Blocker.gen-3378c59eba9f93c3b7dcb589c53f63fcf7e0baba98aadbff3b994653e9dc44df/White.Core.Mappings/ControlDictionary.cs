using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Automation;
using White.Core.UIItems;
using White.Core.UIItems.ListBoxItems;
using White.Core.UIItems.MenuItems;
using White.Core.UIItems.PropertyGridItems;
using White.Core.UIItems.Scrolling;
using White.Core.UIItems.TabItems;
using White.Core.UIItems.TableItems;
using White.Core.UIItems.TreeItems;
using White.Core.UIItems.WindowStripControls;

namespace White.Core.Mappings;

public class ControlDictionary
{
	public static readonly ControlDictionary Instance = new ControlDictionary();

	private readonly ControlDictionaryItems items = new ControlDictionaryItems();

	private readonly List<Type> editableControls = new List<Type>();

	private ControlDictionary()
	{
		items.AddFrameworkSpecificPrimary(ControlType.Edit, typeof(TextBox), typeof(WinFormTextBox), typeof(TextBox), typeof(TextBox));
		items.AddWinFormPrimary(typeof(WinFormSlider), ControlType.Slider);
		items.AddWPFPrimary(typeof(WPFSlider), ControlType.Slider);
		items.AddSilverlightPrimary(typeof(WPFSlider), ControlType.Slider);
		items.AddPrimary(typeof(Thumb), ControlType.Thumb);
		items.AddPrimary(typeof(Button), ControlType.Button);
		items.AddPrimary(typeof(CheckBox), ControlType.CheckBox);
		items.AddPrimary(typeof(ListBox), ControlType.List);
		items.AddPrimary(typeof(Hyperlink), ControlType.Hyperlink);
		items.AddPrimary(typeof(Tree), ControlType.Tree);
		items.AddPrimary(typeof(RadioButton), ControlType.RadioButton);
		items.AddPrimary(typeof(Table), ControlType.Table);
		items.AddPrimary(typeof(MultilineTextBox), ControlType.Document);
		items.AddPrimary(typeof(Tab), ControlType.Tab, hasPrimaryChildren: true);
		items.AddPrimary(typeof(ListView), ControlType.DataGrid);
		items.AddPrimary(typeof(ToolStrip), ControlType.ToolBar);
		items.AddWin32Primary(typeof(MenuBar), ControlType.MenuBar);
		items.AddWinFormPrimary(typeof(MenuBar), ControlType.MenuBar);
		items.AddWPFPrimary(typeof(MenuBar), ControlType.Menu);
		items.AddSilverlightPrimary(typeof(MenuBar), ControlType.Menu);
		items.AddPrimary(typeof(ProgressBar), ControlType.ProgressBar);
		items.AddPrimary(typeof(Spinner), ControlType.Spinner);
		items.Add(new ControlDictionaryItem(typeof(Panel), ControlType.Pane, "", identifiedByClassName: false, isPrimary: true, isExcluded: false, null, hasPrimaryChildren: true));
		ControlDictionaryItem controlDictionaryItem = ControlDictionaryItem.Primary(typeof(PropertyGrid), ControlType.Pane);
		controlDictionaryItem.IsIdentifiedByName = true;
		items.Add(controlDictionaryItem);
		items.AddFrameworkSpecificPrimary(ControlType.Text, typeof(Label), typeof(Label), typeof(WPFLabel), typeof(WPFLabel));
		items.AddFrameworkSpecificPrimary(ControlType.ComboBox, typeof(Win32ComboBox), typeof(WinFormComboBox), typeof(WPFComboBox), typeof(WPFComboBox));
		items.AddFrameworkSpecificPrimary(ControlType.StatusBar, typeof(StatusStrip), typeof(StatusStrip), typeof(WPFStatusBar), typeof(WPFStatusBar));
		items.AddWPFPrimary(typeof(Image), ControlType.Image);
		items.AddSilverlightPrimary(typeof(Image), ControlType.Image);
		items.AddWin32Primary(typeof(Image), ControlType.Image);
		items.AddSecondary(typeof(TableRowHeader), ControlType.Header);
		items.AddSecondary(typeof(TabPage), ControlType.TabItem, hasPrimaryChildren: true);
		items.AddSecondary(typeof(VScrollBar), ControlType.ScrollBar);
		items.AddSecondary(typeof(HScrollBar), ControlType.ScrollBar);
		items.AddSecondary(typeof(TableHeader), ControlType.Custom);
		items.AddSecondary(typeof(TableRow), ControlType.Custom);
		items.AddSecondary(typeof(Menu), ControlType.MenuItem);
		items.AddSecondary(typeof(ListViewRow), ControlType.DataItem);
		items.Add(ControlDictionaryItem.WinFormSecondary(typeof(Win32ListItem), ControlType.ListItem));
		items.Add(ControlDictionaryItem.Win32Secondary(typeof(Win32ListItem), ControlType.ListItem));
		items.Add(ControlDictionaryItem.WPFSecondary(typeof(WPFListItem), ControlType.ListItem));
		items.Add(ControlDictionaryItem.SilverlightSecondary(typeof(WPFListItem), ControlType.ListItem));
		items.Add(ControlDictionaryItem.WinFormSecondary(typeof(Win32TreeNode), ControlType.TreeItem));
		items.Add(ControlDictionaryItem.WPFSecondary(typeof(WPFTreeNode), ControlType.TreeItem));
		items.Add(ControlDictionaryItem.Win32Secondary(typeof(Win32TreeNode), ControlType.TreeItem));
		items.Add(new ControlDictionaryItem(typeof(DateTimePicker), ControlType.Pane, "SysDateTimePick32", identifiedByClassName: true, isPrimary: true, isExcluded: false, null, hasPrimaryChildren: false));
		items.Add(new ControlDictionaryItem(typeof(GroupBox), ControlType.Group, string.Empty, identifiedByClassName: false, isPrimary: true, isExcluded: false, null, hasPrimaryChildren: true));
		items.Add(new ControlDictionaryItem(null, ControlType.TitleBar, string.Empty, identifiedByClassName: false, isPrimary: false, isExcluded: true, null, hasPrimaryChildren: false));
		items.Add(new ControlDictionaryItem(null, ControlType.Pane, string.Empty, identifiedByClassName: false, isPrimary: false, isExcluded: false, null, hasPrimaryChildren: true));
		editableControls.Add(typeof(TextBox));
		editableControls.Add(typeof(CheckBox));
		editableControls.Add(typeof(RadioButton));
		editableControls.Add(typeof(ListControl));
	}

	public virtual bool HasPrimaryChildren(ControlType controlType)
	{
		if (((object)controlType).Equals((object?)ControlType.Custom))
		{
			return true;
		}
		ControlDictionaryItem controlDictionaryItem = items.FindBy(controlType);
		if (controlDictionaryItem == null)
		{
			throw new ControlDictionaryException("Could not find control of type " + controlType.get_LocalizedControlType());
		}
		return controlDictionaryItem.HasPrimaryChildren;
	}

	public virtual ControlType GetControlType(Type testControlType, string frameworkId)
	{
		return items.FindBy(testControlType, frameworkId).ControlType;
	}

	public virtual ControlType GetControlType(Type testControlType)
	{
		return items.FindBy(testControlType, null).ControlType;
	}

	public virtual Type GetTestControlType(ControlType controlType, string frameWorkId, bool isNativeControl)
	{
		ControlDictionaryItem controlDictionaryItem2 = items.Find(delegate(ControlDictionaryItem controlDictionaryItem)
		{
			string frameworkId = controlDictionaryItem.FrameworkId;
			if (!((object)controlDictionaryItem.ControlType).Equals((object?)controlType))
			{
				return false;
			}
			if (frameworkId == null)
			{
				return true;
			}
			if (string.IsNullOrEmpty(frameWorkId))
			{
				if (object.Equals(frameworkId, "Win32") && isNativeControl)
				{
					return true;
				}
				if (object.Equals(frameworkId, "WPF") && !isNativeControl)
				{
					return true;
				}
			}
			return object.Equals(frameWorkId, frameworkId);
		});
		if (controlDictionaryItem2 == null)
		{
			throw new ControlDictionaryException($"Could not find TestControl for ControlType={controlType.get_LocalizedControlType()} and FrameworkId:{frameWorkId}");
		}
		return controlDictionaryItem2.TestControlType;
	}

	public virtual Type GetTestControlType(string className)
	{
		if (string.IsNullOrEmpty(className))
		{
			return null;
		}
		return items.Find((ControlDictionaryItem controlDictionaryItem) => !string.IsNullOrEmpty(controlDictionaryItem.ClassName) && className.Contains(controlDictionaryItem.ClassName))?.TestControlType;
	}

	public virtual bool IsPrimaryControl(ControlType controlType, string className, string name)
	{
		return items.Exists(delegate(ControlDictionaryItem controlDictionaryItem)
		{
			if ((controlDictionaryItem.IsPrimary && ((object)controlDictionaryItem.ControlType).Equals((object?)controlType) && !controlDictionaryItem.IsIdentifiedByClassName && !controlDictionaryItem.IsIdentifiedByName) || (!string.IsNullOrEmpty(className) && className.Contains(controlDictionaryItem.ClassName) && controlDictionaryItem.IsIdentifiedByClassName))
			{
				return true;
			}
			return !string.IsNullOrEmpty(name) && name.Equals("PropertyGrid") && controlDictionaryItem.IsIdentifiedByName;
		});
	}

	public virtual bool IsExcluded(ControlType controlType)
	{
		return items.Exists((ControlDictionaryItem controlDictionaryItem) => ((object)controlDictionaryItem.ControlType).Equals((object?)controlType) && controlDictionaryItem.IsExcluded);
	}

	public virtual bool IsControlTypeSupported(ControlType controlType)
	{
		return items.Any((ControlDictionaryItem controlDictionaryItem) => ((object)controlDictionaryItem.ControlType).Equals((object?)controlType));
	}

	public virtual List<ControlType> PrimaryControlTypes(string frameworkId)
	{
		List<ControlType> list = new List<ControlType>();
		foreach (ControlDictionaryItem item in items)
		{
			if (item.OfFramework(frameworkId) && item.IsPrimary && !list.Contains(item.ControlType))
			{
				list.Add(item.ControlType);
			}
		}
		return list;
	}

	public virtual bool IsEditable(UIItem uiItem)
	{
		return editableControls.All((Type t) => t.IsInstanceOfType(uiItem));
	}

	public virtual Type GetTestType(AutomationElement automationElement)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		AutomationElementInformation current = automationElement.get_Current();
		return GetTestType(((AutomationElementInformation)(ref current)).get_ClassName(), ((AutomationElementInformation)(ref current)).get_ControlType(), ((AutomationElementInformation)(ref current)).get_FrameworkId(), ((AutomationElementInformation)(ref current)).get_Name(), ((AutomationElementInformation)(ref current)).get_NativeWindowHandle() != 0);
	}

	public virtual Type GetTestType(string className, ControlType controlType, string frameworkId, string name, bool isNativeControl)
	{
		Type type = GetTestControlType(className);
		if (type == null && "PropertyGrid".Equals(name) && ((object)ControlType.Pane).Equals((object?)controlType))
		{
			type = typeof(PropertyGrid);
		}
		return type ?? GetTestControlType(controlType, frameworkId, isNativeControl);
	}
}
