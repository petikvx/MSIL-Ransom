using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Cd6;
using Microsoft.VisualBasic.CompilerServices;

namespace Mw5;

public class e3J : Button
{
	public e3J()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).add_Click((EventHandler)delegate
		{
			Sr5();
		});
		((ButtonBase)this).set_AutoSize(false);
		((Control)this).set_Dock((DockStyle)1);
		((ButtonBase)this).set_BackColor(Color.AliceBlue);
		((ButtonBase)this).set_FlatStyle((FlatStyle)0);
		((ButtonBase)this).get_FlatAppearance().set_BorderSize(0);
		((Control)this).set_Margin(new Padding(4, 4, 4, 0));
		((Control)this).set_Size(new Size(525, 30));
		((ButtonBase)this).set_TextAlign((ContentAlignment)16);
	}

	private void Sr5()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Invalid comparison between Unknown and I4
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				OleDbConnection val = new OleDbConnection();
				string currentDirectory = Directory.GetCurrentDirectory();
				currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
				currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
				string connectionString = "provider=microsoft.ACE.OLEDB.12.0 ; data source = " + currentDirectory + "\\hms_Database.accdb";
				val.set_ConnectionString(connectionString);
				string text = "Yes";
				if (Operators.CompareString(Rg8.Forms.Form17.dept.get_Text(), "Emergency", false) == 0)
				{
					string text2 = ((ButtonBase)this).get_Text();
					short num = 0;
					Array array = text2.ToArray();
					text2 = "";
					int num2 = array.Length - 1;
					for (int i = 1; i <= num2 && !Operators.ConditionalCompareObjectEqual(array.GetValue(i), (object)"D", false); i++)
					{
						if (num == 1)
						{
							text2 = Conversions.ToString(Operators.ConcatenateObject((object)text2, array.GetValue(i)));
						}
						if (Operators.ConditionalCompareObjectEqual(array.GetValue(i), (object)":", false))
						{
							num = 1;
						}
					}
					text2.Trim();
					val.Open();
					OleDbCommand val2 = new OleDbCommand("UPDATE  Emergency_DataBase SET Completed ='" + text + "'  where  ( ID Like '" + Conversions.ToString(Conversions.ToInteger(text2)) + "' )", val);
					if (unchecked((int)MessageBox.Show("Are u sure,The case is Completed", "Warning", (MessageBoxButtons)4)) == 7)
					{
						val.Close();
						return;
					}
					try
					{
						val2.ExecuteNonQuery();
						((Component)(object)val2).Dispose();
						MessageBox.Show("Marked As Completed");
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						MessageBox.Show(ex2.Message);
						ProjectData.ClearProjectError();
					}
					val.Close();
					return;
				}
				string text3 = ((ButtonBase)this).get_Text();
				short num3 = 0;
				short num4 = 0;
				Array array2 = text3.ToArray();
				text3 = "";
				int num5 = array2.Length - 1;
				for (int j = 1; j <= num5 && !Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(array2.GetValue(j), (object)"P", false), (object)(num4 == 1))); j++)
				{
					if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(array2.GetValue(j), (object)"P", false), (object)(num4 == 0))))
					{
						num4 = 1;
					}
					if (num3 == 1)
					{
						text3 = Conversions.ToString(Operators.ConcatenateObject((object)text3, array2.GetValue(j)));
					}
					if (Operators.ConditionalCompareObjectEqual(array2.GetValue(j), (object)":", false))
					{
						num3 = 1;
					}
				}
				text3.Trim();
				Rg8.Forms.Form15.TextBox2.set_Text(Conversions.ToString(Conversions.ToInteger(text3)));
				((Control)Rg8.Forms.Form15).Show();
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				MessageBox.Show(ex4.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	[SpecialName]
	[DebuggerHidden]
	[CompilerGenerated]
	private void d0T(object sender, EventArgs e)
	{
		Sr5();
	}
}
