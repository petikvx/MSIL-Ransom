using System.Windows;
using White.Core.UIItems;

namespace White.Core.InputDevices;

public interface IMouse
{
	Point Location { get; set; }

	void RightClick();

	void Click();

	void DoubleClick(Point point);

	void Click(Point point);

	void DragAndDrop(IUIItem draggedItem, IUIItem dropItem);

	void DragAndDrop(IUIItem draggedItem, Point startPosition, IUIItem dropItem, Point endPosition);
}
