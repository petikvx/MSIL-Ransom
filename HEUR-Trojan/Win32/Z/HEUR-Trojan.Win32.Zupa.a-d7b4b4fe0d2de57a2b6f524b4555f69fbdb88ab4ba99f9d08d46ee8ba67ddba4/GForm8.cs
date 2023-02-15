using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using UNIVERSALGAME.Properties;

public sealed class GForm8 : Form
{
	[Serializable]
	private sealed class Class53
	{
		public static readonly Class53 class53_0 = new Class53();

		public static Func<KeyValuePair<int, string>, bool> func_0;

		internal bool method_0(KeyValuePair<int, string> keyValuePair_0)
		{
			return keyValuePair_0.Key == Settings.Default.Server_Index;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct21 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public GForm8 gform8_0;

		private TaskAwaiter<List<GClass9>> taskAwaiter_0;

		private void MoveNext()
		{
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Expected O, but got Unknown
			int num = int_0;
			GForm8 gForm = gform8_0;
			try
			{
				TaskAwaiter<List<GClass9>> awaiter;
				if (num != 0)
				{
					awaiter = GClass6.smethod_4().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<List<GClass9>>);
					num = -1;
					int_0 = -1;
				}
				List<GClass9> result = awaiter.GetResult();
				List<GClass9> list = result;
				if (list != null)
				{
					List<GClass9>.Enumerator enumerator = list.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							GClass9 current = enumerator.Current;
							if (GClass6.smethod_0().Equals(7) && (current.ID.Equals(1) || current.ID.Equals(5)))
							{
								gForm.dictionary_0.Add(current.ID, current.SERVER);
							}
							else if (GClass6.smethod_0().Equals(1))
							{
								gForm.dictionary_0.Add(current.ID, current.SERVER);
							}
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator).Dispose();
						}
					}
					gForm.comboBox_0.set_DataSource((object)new BindingSource((object)gForm.dictionary_0, (string)null));
					((ListControl)gForm.comboBox_0).set_DisplayMember(Class60.smethod_0(-2050195496));
					((ListControl)gForm.comboBox_0).set_ValueMember(Class60.smethod_0(-2050195500));
					if (GClass6.smethod_0().Equals(7) && Settings.Default.Server_Index.Equals(5))
					{
						((ListControl)gForm.comboBox_0).set_SelectedIndex(1);
					}
					else
					{
						((ListControl)gForm.comboBox_0).set_SelectedIndex(gForm.dictionary_0.FirstOrDefault(Class53.class53_0.method_0)!.Key - 1);
					}
					gForm.bool_0 = false;
				}
				else
				{
					((Form)gForm).Close();
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncVoidMethodBuilder_0.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private Dictionary<int, string> dictionary_0 = new Dictionary<int, string>();

	public GClass1 gclass1_0;

	public string string_0;

	private bool bool_0 = true;

	private IContainer icontainer_0;

	private TableLayoutPanel tableLayoutPanel_0;

	private TableLayoutPanel tableLayoutPanel_1;

	private Button button_0;

	private ComboBox comboBox_0;

	private TableLayoutPanel tableLayoutPanel_2;

	public GForm8()
	{
		method_0();
	}

	private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Settings.Default.Server_Index = ((KeyValuePair<int, string>)comboBox_0.get_SelectedItem()).Key;
			((SettingsBase)Settings.Default).Save();
		}
	}

	private async void GForm8_Load(object sender, EventArgs e)
	{
		List<GClass9> list = await GClass6.smethod_4();
		if (list != null)
		{
			foreach (GClass9 item in list)
			{
				if (GClass6.smethod_0().Equals(7) && (item.ID.Equals(1) || item.ID.Equals(5)))
				{
					dictionary_0.Add(item.ID, item.SERVER);
				}
				else if (GClass6.smethod_0().Equals(1))
				{
					dictionary_0.Add(item.ID, item.SERVER);
				}
			}
			comboBox_0.set_DataSource((object)new BindingSource((object)dictionary_0, (string)null));
			((ListControl)comboBox_0).set_DisplayMember(Class60.smethod_0(-2050195496));
			((ListControl)comboBox_0).set_ValueMember(Class60.smethod_0(-2050195500));
			if (GClass6.smethod_0().Equals(7) && Settings.Default.Server_Index.Equals(5))
			{
				((ListControl)comboBox_0).set_SelectedIndex(1);
			}
			else
			{
				((ListControl)comboBox_0).set_SelectedIndex(dictionary_0.FirstOrDefault(Class53.class53_0.method_0)!.Key - 1);
			}
			bool_0 = false;
		}
		else
		{
			((Form)this).Close();
		}
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if (gclass1_0 != null)
		{
			GForm6 gForm = new GForm6();
			try
			{
				((Control)this).Hide();
				((Form)gForm).add_Closed((EventHandler)method_1);
				gForm.gclass1_0 = gclass1_0;
				gForm.string_0 = string_0;
				((Form)gForm).ShowDialog();
				return;
			}
			finally
			{
				((IDisposable)(object)gForm).Dispose();
			}
		}
		((Form)this).Close();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void method_0()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected O, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected O, but got Unknown
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected O, but got Unknown
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected O, but got Unknown
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected O, but got Unknown
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected O, but got Unknown
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected O, but got Unknown
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm8));
		tableLayoutPanel_0 = new TableLayoutPanel();
		tableLayoutPanel_1 = new TableLayoutPanel();
		button_0 = new Button();
		tableLayoutPanel_2 = new TableLayoutPanel();
		comboBox_0 = new ComboBox();
		((Control)tableLayoutPanel_0).SuspendLayout();
		((Control)tableLayoutPanel_1).SuspendLayout();
		((Control)tableLayoutPanel_2).SuspendLayout();
		((Control)this).SuspendLayout();
		tableLayoutPanel_0.set_ColumnCount(1);
		tableLayoutPanel_0.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel_0.get_Controls().Add((Control)(object)tableLayoutPanel_1, 0, 2);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)tableLayoutPanel_2, 0, 1);
		((Control)tableLayoutPanel_0).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_0).set_Location(new Point(0, 0));
		((Control)tableLayoutPanel_0).set_Name(Class60.smethod_0(-2050208027));
		tableLayoutPanel_0.set_RowCount(4);
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 5f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 40f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 50f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 5f));
		((Control)tableLayoutPanel_0).set_Size(new Size(284, 91));
		((Control)tableLayoutPanel_0).set_TabIndex(1);
		tableLayoutPanel_1.set_ColumnCount(3);
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 10f));
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 80f));
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 10f));
		tableLayoutPanel_1.get_Controls().Add((Control)(object)button_0, 1, 0);
		((Control)tableLayoutPanel_1).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_1).set_Location(new Point(3, 43));
		((Control)tableLayoutPanel_1).set_Name(Class60.smethod_0(-2050208091));
		tableLayoutPanel_1.set_RowCount(1);
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)tableLayoutPanel_1).set_Size(new Size(278, 39));
		((Control)tableLayoutPanel_1).set_TabIndex(1);
		((Control)button_0).set_BackColor(Color.LightSeaGreen);
		((Control)button_0).set_Cursor(Cursors.get_Hand());
		((Control)button_0).set_Dock((DockStyle)5);
		((ButtonBase)button_0).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button_0).set_FlatStyle((FlatStyle)0);
		((Control)button_0).set_Font(new Font(Class60.smethod_0(-2050208051), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)222));
		((Control)button_0).set_ForeColor(SystemColors.ControlLightLight);
		((Control)button_0).set_Location(new Point(30, 3));
		((Control)button_0).set_Name(Class60.smethod_0(-2050226346));
		((Control)button_0).set_Size(new Size(216, 33));
		((Control)button_0).set_TabIndex(0);
		((Control)button_0).set_Text(Class60.smethod_0(-2050226376));
		((ButtonBase)button_0).set_UseVisualStyleBackColor(false);
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		tableLayoutPanel_2.set_ColumnCount(3);
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 10f));
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 80f));
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 10f));
		tableLayoutPanel_2.get_Controls().Add((Control)(object)comboBox_0, 1, 0);
		((Control)tableLayoutPanel_2).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_2).set_Location(new Point(3, 7));
		((Control)tableLayoutPanel_2).set_Name(Class60.smethod_0(-2050211088));
		tableLayoutPanel_2.set_RowCount(1);
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)tableLayoutPanel_2).set_Size(new Size(278, 30));
		((Control)tableLayoutPanel_2).set_TabIndex(2);
		((Control)comboBox_0).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_0).set_Dock((DockStyle)5);
		comboBox_0.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_0).set_Font(new Font(Class60.smethod_0(-2050210859), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_0).set_FormattingEnabled(true);
		((Control)comboBox_0).set_Location(new Point(30, 3));
		((Control)comboBox_0).set_Name(Class60.smethod_0(-2050226421));
		((Control)comboBox_0).set_Size(new Size(216, 29));
		((Control)comboBox_0).set_TabIndex(7);
		comboBox_0.add_SelectedIndexChanged((EventHandler)comboBox_0_SelectedIndexChanged);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.DarkSlateGray);
		((Form)this).set_ClientSize(new Size(284, 91));
		((Control)this).get_Controls().Add((Control)(object)tableLayoutPanel_0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject(Class60.smethod_0(-2050208183)));
		((Control)this).set_Name(Class60.smethod_0(-2050226404));
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text(Class60.smethod_0(-2050226461));
		((Form)this).add_Load((EventHandler)GForm8_Load);
		((Control)tableLayoutPanel_0).ResumeLayout(false);
		((Control)tableLayoutPanel_1).ResumeLayout(false);
		((Control)tableLayoutPanel_2).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void method_1(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
