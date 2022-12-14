using System.Windows.Automation;
using White.Core.UIItems.Actions;
using White.Core.UIItems.Finders;

namespace White.Core.UIItems.MenuItems;

public class PopUpMenu : UIItem
{
	private readonly Menus topLevelMenus;

	public virtual Menus Items => topLevelMenus;

	protected PopUpMenu()
	{
	}

	public PopUpMenu(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
		base.actionListener = actionListener;
		topLevelMenus = new Menus(automationElement, actionListener);
	}

	public virtual Menu Item(params string[] text)
	{
		return topLevelMenus.Find(text);
	}

	public virtual Menu ItemBy(params SearchCriteria[] path)
	{
		return topLevelMenus.Find(path);
	}
}
