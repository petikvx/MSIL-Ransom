using Castle.DynamicProxy;
using White.Core.Bricks;
using White.Core.Interceptors;
using White.Core.UIItems;
using White.Core.UIItems.Actions;

namespace White.Core.Factory;

public static class UIItemProxyFactory
{
	public static IUIItem Create(IUIItem item, ActionListener actionListener)
	{
		return (IUIItem)DynamicProxyGenerator.Instance.CreateProxy((IInterceptor)(object)new CoreInterceptor(item, actionListener), item.GetType());
	}
}
