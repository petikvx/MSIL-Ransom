using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomWindowsForm;

public class MinMaxButton : Button
{
	public enum CustomFormState
	{
		Normal,
		Maximize
	}

	private Color clr1;

	private Color color = Color.Gray;

	private Color m_hovercolor = Color.FromArgb(180, 200, 240);

	private Color clickcolor = Color.FromArgb(160, 180, 200);

	private int textX = 6;

	private int textY = -20;

	private string text = "_";

	private CustomFormState _customFormState;

	public CustomFormState CFormState
	{
		get
		{
			return _customFormState;
		}
		set
		{
			_customFormState = value;
			((Control)this).Invalidate();
		}
	}

	public string DisplayText
	{
		get
		{
			return text;
		}
		set
		{
			text = value;
			((Control)this).Invalidate();
		}
	}

	public Color BZBackColor
	{
		get
		{
			return color;
		}
		set
		{
			color = value;
			((Control)this).Invalidate();
		}
	}

	public Color MouseHoverColor
	{
		get
		{
			return m_hovercolor;
		}
		set
		{
			m_hovercolor = value;
			((Control)this).Invalidate();
		}
	}

	public Color MouseClickColor1
	{
		get
		{
			return clickcolor;
		}
		set
		{
			clickcolor = value;
			((Control)this).Invalidate();
		}
	}

	public int TextLocation_X
	{
		get
		{
			return textX;
		}
		set
		{
			textX = value;
			((Control)this).Invalidate();
		}
	}

	public int TextLocation_Y
	{
		get
		{
			return textY;
		}
		set
		{
			textY = value;
			((Control)this).Invalidate();
		}
	}

	public MinMaxButton()
	{
		((Control)this).set_Size(new Size(31, 24));
		((Control)this).set_ForeColor(Color.White);
		((ButtonBase)this).set_FlatStyle((FlatStyle)0);
		((Control)this).set_Text("_");
		text = ((Control)this).get_Text();
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		((Button)this).OnMouseEnter(e);
		clr1 = color;
		color = m_hovercolor;
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((Button)this).OnMouseLeave(e);
		color = clr1;
	}

	protected override void OnMouseDown(MouseEventArgs mevent)
	{
		((ButtonBase)this).OnMouseDown(mevent);
		color = clickcolor;
	}

	protected override void OnMouseUp(MouseEventArgs mevent)
	{
		((Button)this).OnMouseUp(mevent);
		color = clr1;
	}

	protected override void OnPaint(PaintEventArgs pe)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		((ButtonBase)this).OnPaint(pe);
		switch (_customFormState)
		{
		case CustomFormState.Maximize:
		{
			pe.get_Graphics().FillRectangle((Brush)new SolidBrush(color), ((Control)this).get_ClientRectangle());
			for (int j = 0; j < 2; j++)
			{
				pe.get_Graphics().DrawRectangle(new Pen(((Control)this).get_ForeColor()), textX + 5, textY, 8, 8);
				pe.get_Graphics().FillRectangle((Brush)new SolidBrush(((Control)this).get_ForeColor()), textX + 5, textY - 1, 9, 4);
				pe.get_Graphics().DrawRectangle(new Pen(((Control)this).get_ForeColor()), textX + 2, textY + 5, 8, 8);
				pe.get_Graphics().FillRectangle((Brush)new SolidBrush(((Control)this).get_ForeColor()), textX + 2, textY + 4, 9, 4);
			}
			break;
		}
		case CustomFormState.Normal:
		{
			pe.get_Graphics().FillRectangle((Brush)new SolidBrush(color), ((Control)this).get_ClientRectangle());
			for (int i = 0; i < 2; i++)
			{
				pe.get_Graphics().DrawRectangle(new Pen(((Control)this).get_ForeColor()), textX + i + 1, textY, 10, 10);
				pe.get_Graphics().FillRectangle((Brush)new SolidBrush(((Control)this).get_ForeColor()), textX + 1, textY - 1, 12, 4);
			}
			break;
		}
		}
	}
}
