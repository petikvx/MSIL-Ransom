using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using o3C;

namespace s9X;

[DesignerGenerated]
public class d0F : Form
{
	private IContainer components;

	private Label _Label1;

	private ComboBox _ComboBox1;

	private TextBox _TextBox1;

	internal Label W;

	internal Button X;

	public d0F()
	{
		((Form)this).add_Load((EventHandler)r8X);
		f9Q();
	}

	protected override void z3P(bool Zi8)
	{
		try
		{
			if (Zi8 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Zi8);
		}
	}

	private void f9Q()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected O, but got Unknown
		Xp0(new Label());
		s6Q(new ComboBox());
		i8J(new Label());
		Hs0(new TextBox());
		Pf3(new Button());
		((Control)this).SuspendLayout();
		z0N().set_AutoSize(true);
		((Control)z0N()).set_Font(new Font("Microsoft Tai Le", 10.2f, (FontStyle)7, (GraphicsUnit)3, (byte)0));
		((Control)z0N()).set_Location(new Point(62, 30));
		((Control)z0N()).set_Name("Label1");
		((Control)z0N()).set_Size(new Size(193, 22));
		((Control)z0N()).set_TabIndex(0);
		z0N().set_Text("Liste Des Médicaments");
		((ListControl)Zi2()).set_FormattingEnabled(true);
		Zi2().get_Items().AddRange(new object[110]
		{
			"ABIRATERONE GT 250 MG, Comprimé", "Boite de 120 - PPV: 10411.00 dhs", "ABSTRAL 100 µG, Comprimé sublingual", "Boite de 10 - PPV: 937.00 dhs", "ABSTRAL 200 µG, Comprimé sublingual", "Boite de 10 - PPV: 937.00 dhs", "ABSTRAL 400 µG, Comprimé sublingual", "Boite de 10 - PPV: 937.00 dhs", "ACARBOSE LAPROPHAN 100 MG, Comprimé", "Boite de 30 - PPV: 64.40 dhs",
			"ACARBOSE LAPROPHAN 100 MG, Comprimé", "Boite de 90 - PPV: 166.10 dhs", "ACARBOSE LAPROPHAN 50 MG, Comprimé", "Boite de 90 - PPV: 64.40 dhs", "ACARBOSE LAPROPHAN 50MG, Comprimé", "Boite de 30 - PPV: 42.20 dhs", "ACARD 50 MG, Comprimé pelliculé", "Boite de 28 - PPV: 79.00 dhs", "ACARD 50 MG, Comprimé pelliculé", "Boite de 14 - PPV: 40.00 dhs",
			"ACCUPRIL 20 MG, Comprimé enrobé sécable", "Boîte de 28 - PPV: 103.50 dhs", "ACCUPRIL 5 MG, Comprimé sécable", "Boîte de 28 - PPV: 41.70 dhs", "ACDigest, Gélule", "Blister de 30 - PPC: 59.00 dhs", "BACAZIRED 40 MG / ML (60 MG / 1,5 ML), pour perfusion", "Boite de 1 flacon 1,5 ml de solution à diluer et 1 flacon de 4,5 ml de solvant - PPV: 22044.00 dhs", "BACICOLINE 25 M UI + 1G+ 50 M UI, Collyre", "Boîte de 1 - PPV: 32.50 dhs",
			"BACQURE 500 MG / 500 MG, Poudre pour perfusion", "Flacon de 30 ML - PPV: 129.40 dhs", "BACTALL 250 MG, Comprimé enrobé", "Boîte de 10 - PPV: 31.80 dhs", "BACTALL 500 MG, Comprimé enrobé", "Boîte de 10 - PPV: 57.90 dhs", "BACTOGERME, Antiseptique cutané", "Flacon de 60 ML - PPV: 38.00 dhs", "BACTOSPRAY, Solution antiseptique sans alcool", "Flacon de 125 ML - PPV: 138.00 dhs",
			"BACTOX 1 G, Sachet", "Boîte de 12 - PPV: 70.40 dhs", "BACTOX 1 G, Sachet", "Boîte de 24 - PPV: 117.30 dhs", "BACTRIM FORTE 800 MG / 160 MG, Comprimé", "Boîte de 10 - PPV: 33.60 dhs", "BACTRIM FORTE 800 MG / 160 MG, Comprimé", "Boîte de 20 - PPV: 62.80 dhs", "FACTANE 100 UI/ML, Poudre et solvant pour solution injectable", "1 Boite de 1 flacon de poudre +10 ML de solvant - PPV: 5550.00 dhs",
			"FACTANE 100 UI/ML, Poudre et solvant pour solution injectable", "1 boite de 1 flacon de poudre + 2.5 ML de solvant - PPV: 1588.00 dhs", "FACTANE 100 UI/ML, Poudre et solvant pour solution injectable", "1 boite de 1 flacon + 5 ML de solvant - PPV: 2906.00 dhs", "FACTEUR IX DE COAGULATION HUMAIN-CNTS 1000 UI/ 20 ML, Poudre et solvant pour solution injectable à 50 UI / ML", "1 boite de 1 flacon de poudre + Flacon de solvant - PPV: 3920.00 dhs", "FACTEUR IX DE COAGULATION HUMAIN-CNTS 500 UI/ 10 ML, Poudre et solvant pour solution injectable à 50 UI / ML", "Boite de poudre plus un flacon de solvant . - PPV: 1483.00 dhs", "FACTEUR VIII DE COAGULATION HUMAIN-CNTS 100 UI / ml - 1000 UI/10 ML, Poudre et solvant pour solution injectable", "Boite de poudre plus un flacon de solvant - PPV: 2950.00 dhs",
			"FACTEUR VIII DE COAGULATION HUMAIN-CNTS 100 UI/ml- 500 UI/ 5 ML, Poudre et solvant pour solution injectable", "Boite de poudre plus un flacon de solvant - PPV: 2300.00 dhs", "FACTIVE 320 Mg, Comprimé pelliculé", "Boite de 5 - PPV: 213.00 dhs", "FACTIVE 320 MG, Comprimé pelliculé", "Boite de 7 - PPV: 282.00 dhs", "EAU P.P.I. 10 ml", "Boîte de 100 - PPV: 304.00 dhs", "EAU P.P.I. Injectable 5 ML", "Boîte de 100 - PPV: 304.00 dhs",
			"EBETAXEL 100 MG / 16,7 ML, Solution à diluer pour perfusion", "Flacon de 16,7 ml - PPV: 1115.00 dhs", "EBETAXEL 150 MG / 25 ML, Solution à diluer pour perfusion", "Flacon de 25 ml - PPV: 2371.00 dhs", "EBETAXEL 30 MG / 5 ML, Solution à diluer pour perfusion", "Flacon de 5 ml - PPV: 590.00 dhs", "EBETAXEL 300 MG / 50 ML, Solution à diluer pour perfusion", "Flacon 50 ml - PPV: 2069.00 dhs", "EBIXA 10 MG, Comprimé pelliculé", "Boite de 28 - PPV: 231.00 dhs",
			"EBIXA 20 MG, Comprimé pelliculé", "Boite de 28 - PPV: 371.00 dhs", "ECLARAN 10 , Gel pour application cutanée", "Tube de 45 g - PPV: 31.40 dhs", "", "Médicament", "VACCIN ANTIDIPHTÉRIQUE et ANTITÉTANIQUE ADULTES et ADOLESCENTS ANATOXINE DIPHTÉRIQUE >= 2 UI, ANATOXINE TÉTANIQUE >= 40 UI, suspension injectable", "Boîte de 1 ampoule - PPV: 14.00 dhs", "VACCIN BCG 1X105 et 33X105 CFU DE BCG VIVANT Poudre et solvant pour suspension", "Boîte de 1 Flacon de lyophilysat +1 Flacon de solvant - PPV: 61.20 dhs",
			"VALDOXAN 25 Mg, Comprimé", "Boite de 28 - PPV: 310.00 dhs", "VALDOXAN 25 Mg, Comprimés", "Boite de 14 comprimés - PPV: 249.00 dhs", "VALEX 500 MG, Comprime enrobé", "Boite de 14 - PPV: 152.50 dhs", "VALEX 500 MG, Comprime enrobé", "Boite de 7 - PPV: 83.60 dhs", "VALEX 500 MG, Comprime enrobé", "Boite de 42 - PPV: 434.50 dhs",
			"VALIUM GOUTTES 1%, Solution buvable", "Solution buvable en facon de 20 ml - PPV: 28.60 dhs", "VALIUM ROCHE 10 mg, Comprimé sécable", "Boîte de 30 - PPV: 24.30 dhs", "VALIUM ROCHE 5 mg, Comprimé sécable", "Boîte de 40 - PPV: 21.40 dhs", "VALPAKINE 200 mg/ml , Solution buvable", "Flacon de 40 ml - PPV: 44.15 dhs", "VALPAKINE 5,764 g/100 ml , Solution buvable", "Flacon de 150 ml - PPV: 42.00 dhs"
		});
		((Control)Zi2()).set_Location(new Point(50, 71));
		((Control)Zi2()).set_Name("ComboBox1");
		((Control)Zi2()).set_Size(new Size(498, 24));
		((Control)Zi2()).set_TabIndex(1);
		Ld9().set_AutoSize(true);
		((Control)Ld9()).set_Font(new Font("Microsoft Tai Le", 10.2f, (FontStyle)7, (GraphicsUnit)3, (byte)0));
		((Control)Ld9()).set_Location(new Point(46, 151));
		((Control)Ld9()).set_Name("Label2");
		((Control)Ld9()).set_Size(new Size(160, 22));
		((Control)Ld9()).set_TabIndex(2);
		Ld9().set_Text("Médicament choisi");
		((Control)Jk9()).set_Location(new Point(50, 231));
		((Control)Jk9()).set_Name("TextBox1");
		((Control)Jk9()).set_Size(new Size(498, 22));
		((Control)Jk9()).set_TabIndex(3);
		((ButtonBase)b8N()).set_FlatStyle((FlatStyle)1);
		((Control)b8N()).set_Location(new Point(191, 303));
		((Control)b8N()).set_Name("Button1");
		((Control)b8N()).set_Size(new Size(250, 60));
		((Control)b8N()).set_TabIndex(4);
		((ButtonBase)b8N()).set_Text("Ordonné");
		((ButtonBase)b8N()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.LightGreen);
		((Form)this).set_ClientSize(new Size(628, 384));
		((Control)this).get_Controls().Add((Control)(object)b8N());
		((Control)this).get_Controls().Add((Control)(object)Jk9());
		((Control)this).get_Controls().Add((Control)(object)Ld9());
		((Control)this).get_Controls().Add((Control)(object)Zi2());
		((Control)this).get_Controls().Add((Control)(object)z0N());
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form11");
		((Form)this).set_Text("Form11");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label z0N()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xp0(Label q1J)
	{
		_Label1 = q1J;
	}

	[SpecialName]
	internal virtual ComboBox Zi2()
	{
		return _ComboBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s6Q(ComboBox s2D)
	{
		EventHandler eventHandler = Ki5;
		ComboBox comboBox = _ComboBox1;
		if (comboBox != null)
		{
			comboBox.remove_SelectedIndexChanged(eventHandler);
		}
		_ComboBox1 = s2D;
		comboBox = _ComboBox1;
		if (comboBox != null)
		{
			comboBox.add_SelectedIndexChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Ld9()
	{
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i8J(Label Ho2)
	{
		Label val = (W = Ho2);
	}

	[SpecialName]
	internal virtual TextBox Jk9()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hs0(TextBox Ji1)
	{
		_TextBox1 = Ji1;
	}

	[SpecialName]
	internal virtual Button b8N()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pf3(Button b6D)
	{
		EventHandler eventHandler = k6R;
		Button x = X;
		if (x != null)
		{
			((Control)x).remove_Click(eventHandler);
		}
		Button val = (X = b6D);
		x = X;
		if (x != null)
		{
			((Control)x).add_Click(eventHandler);
		}
	}

	private void r8X(object sender, EventArgs e)
	{
	}

	private void k6R(object sender, EventArgs e)
	{
		Qm5.Forms.Xp1().m0MT().set_Text(Jk9().get_Text());
		((Control)Qm5.Forms.Xp1()).Show();
		((Form)this).Close();
	}

	private void Ki5(object sender, EventArgs e)
	{
		Jk9().set_Text(Zi2().get_SelectedItem().ToString());
	}

	internal static bool j7X(string Lt9)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(Lt9);
			webRequest.GetResponse();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		return true;
	}
}
