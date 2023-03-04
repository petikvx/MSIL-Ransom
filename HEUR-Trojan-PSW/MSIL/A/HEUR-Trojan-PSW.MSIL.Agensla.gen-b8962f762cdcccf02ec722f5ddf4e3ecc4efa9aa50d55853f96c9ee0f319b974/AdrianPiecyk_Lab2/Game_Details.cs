using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AdrianPiecyk_Lab2;

public class Game_Details : Form
{
	private IContainer components = null;

	private Label labelGameDetails;

	public Game_Details()
	{
		InitializeComponent();
	}

	private void Game_Details_Load(object sender, EventArgs e)
	{
		((Control)this).set_BackgroundImage(Image.FromFile("C:\\Users\\Adrian\\Desktop\\c# obraz\\szczegoly.jpg"));
		((Control)labelGameDetails).set_Text("Gra stworzona w celach laboratorium na zajęcia koła naukowego KREDEK by Adrian Piecyk");
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		labelGameDetails = new Label();
		((Control)this).SuspendLayout();
		((Control)labelGameDetails).set_Anchor((AnchorStyles)0);
		((Control)labelGameDetails).set_AutoSize(true);
		((Control)labelGameDetails).set_BackColor(Color.Transparent);
		((Control)labelGameDetails).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)labelGameDetails).set_ForeColor(Color.AntiqueWhite);
		((Control)labelGameDetails).set_Location(new Point(134, 87));
		((Control)labelGameDetails).set_Name("labelGameDetails");
		((Control)labelGameDetails).set_Size(new Size(60, 24));
		((Control)labelGameDetails).set_TabIndex(0);
		((Control)labelGameDetails).set_Text("Tekst");
		labelGameDetails.set_TextAlign((ContentAlignment)16);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(1084, 461));
		((Control)this).get_Controls().Add((Control)(object)labelGameDetails);
		((Control)this).set_Name("Game_Details");
		((Control)this).set_Text("Game_Details");
		((Form)this).add_Load((EventHandler)Game_Details_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
