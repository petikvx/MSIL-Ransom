using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ns0;

namespace SmartAssembly.SmartExceptionsCore.UI;

[DesignerCategory("Code")]
public class PoweredBy : Control
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 3790)]
	private struct Struct12
	{
	}

	private Label label_0 = new Label();

	private PictureBox pictureBox_0 = new PictureBox();

	private ToolTip toolTip_0 = new ToolTip();

	private float float_0 = 1f;

	private static readonly Array array_0;

	private static readonly object object_0 = new char[1895];

	private static readonly Array array_1;

	internal static byte byte_0/* Not supported: data(00) */;

	internal float float_1;

	protected override void OnResize(EventArgs e)
	{
		((Control)this).set_Size(new Size(Convert.ToInt32(112f * float_0), Convert.ToInt32(32f * float_1)));
		((Control)this).OnResize(e);
	}

	protected override void ScaleCore(float dx, float dy)
	{
		float_0 = dx;
		float num = (float_1 = dy);
		((Control)this).ScaleCore(dx, dy);
		((Control)this).OnResize(EventArgs.Empty);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (toolTip_0 != null)
			{
				((Component)(object)toolTip_0).Dispose();
			}
			if (pictureBox_0 != null)
			{
				((Component)(object)pictureBox_0).Dispose();
			}
		}
		((Control)this).Dispose(disposing);
	}

	private void PoweredBy_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start("http://www.red-gate.com/products/dotnet-development/smartassembly/?utm_source=smartassemblyui&utm_medium=supportlink&utm_content=aerdialogbox&utm_campaign=smartassembly");
		}
		catch
		{
		}
	}

	public PoweredBy()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		float num = (float_1 = 1f);
		((Control)this)._002Ector();
		((Control)this).SuspendLayout();
		label_0.set_FlatStyle((FlatStyle)3);
		((Control)label_0).set_Location(new Point(0, 10));
		((Control)label_0).set_Size(new Size(62, 24));
		((Control)label_0).set_Text("Powered by");
		pictureBox_0.set_Image((Image)(object)Class18.smethod_0("{logo}"));
		((Control)pictureBox_0).set_Location(new Point(72, 0));
		((Control)pictureBox_0).set_Size(new Size(32, 32));
		pictureBox_0.set_SizeMode((PictureBoxSizeMode)1);
		((Control)label_0).add_Click((EventHandler)PoweredBy_Click);
		((Control)pictureBox_0).add_Click((EventHandler)PoweredBy_Click);
		((Control)this).add_Click((EventHandler)PoweredBy_Click);
		((Control)this).set_Cursor(Cursors.get_Hand());
		((Control)this).set_TabStop(false);
		((Control)this).set_Size(new Size(112, 32));
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[2]
		{
			(Control)pictureBox_0,
			(Control)label_0
		});
		toolTip_0.SetToolTip((Control)(object)this, "Powered by SmartAssembly");
		toolTip_0.SetToolTip((Control)(object)label_0, "Powered by SmartAssembly");
		toolTip_0.SetToolTip((Control)(object)pictureBox_0, "Powered by SmartAssembly");
		((Control)this).ResumeLayout(true);
	}

	static PoweredBy()
	{
		char[] array = new char[8];
		array[7] = '???';
		array[2] = '???';
		array[3] = '???';
		array[0] = '???';
		array[4] = '???';
		array[5] = '???';
		array[6] = '???';
		array[1] = '???';
		array_1 = new string[51];
		array_0 = array;
	}
}
