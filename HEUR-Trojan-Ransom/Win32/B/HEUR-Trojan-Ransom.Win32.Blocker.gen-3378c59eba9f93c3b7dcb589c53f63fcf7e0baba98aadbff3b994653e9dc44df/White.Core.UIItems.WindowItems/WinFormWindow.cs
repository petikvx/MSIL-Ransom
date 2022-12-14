using System.Windows.Automation;
using White.Core.Factory;
using White.Core.Sessions;
using White.Core.UIItems.Finders;
using White.Core.UIItems.MenuItems;
using White.Core.UIItems.Scrolling;

namespace White.Core.UIItems.WindowItems;

[PlatformSpecificItem]
internal class WinFormWindow : Window
{
	private WinFormScrollBars winFormScrollBars;

	public override PopUpMenu Popup
	{
		get
		{
			factory.TryGetPopupMenu(this, out var popUpMenu);
			return popUpMenu;
		}
	}

	public override IScrollBars ScrollBars
	{
		get
		{
			if (winFormScrollBars == null)
			{
				winFormScrollBars = new WinFormScrollBars(automationElement, actionListener);
			}
			return winFormScrollBars;
		}
	}

	protected WinFormWindow()
	{
	}

	public WinFormWindow(AutomationElement automationElement, InitializeOption initializeOption)
		: this(automationElement, initializeOption, new NullWindowSession())
	{
	}

	internal WinFormWindow(AutomationElement automationElement, InitializeOption initializeOption, WindowSession windowSession)
		: base(automationElement, initializeOption, windowSession)
	{
	}

	public override T Get<T>(string primaryIdentification)
	{
		if (typeof(T).Equals(typeof(Image)))
		{
			IUIItem iUIItem = factory.WinFormImage(primaryIdentification, this);
			return (T)iUIItem;
		}
		return base.Get<T>(primaryIdentification);
	}

	public override bool HasPopup()
	{
		PopUpMenu popUpMenu;
		return factory.TryGetPopupMenu(this, out popUpMenu);
	}

	public override Window ModalWindow(string title, InitializeOption option)
	{
		return factory.ModalWindow(title, option, WindowSession.ModalWindowSession(option));
	}

	public override Window ModalWindow(SearchCriteria searchCriteria, InitializeOption option)
	{
		return factory.ModalWindow(searchCriteria, option, WindowSession.ModalWindowSession(option));
	}
}
