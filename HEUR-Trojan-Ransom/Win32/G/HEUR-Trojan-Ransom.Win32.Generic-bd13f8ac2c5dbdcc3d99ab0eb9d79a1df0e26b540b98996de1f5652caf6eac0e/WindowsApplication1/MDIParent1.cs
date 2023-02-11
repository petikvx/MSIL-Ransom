using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using WindowsApplication1.My;

namespace WindowsApplication1;

[DesignerGenerated]
public class MDIParent1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("ContentsToolStripMenuItem")]
	private ToolStripMenuItem _ContentsToolStripMenuItem;

	[AccessedThroughProperty("HelpMenu")]
	private ToolStripMenuItem _HelpMenu;

	[AccessedThroughProperty("IndexToolStripMenuItem")]
	private ToolStripMenuItem _IndexToolStripMenuItem;

	[AccessedThroughProperty("SearchToolStripMenuItem")]
	private ToolStripMenuItem _SearchToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator8")]
	private ToolStripSeparator _ToolStripSeparator8;

	[AccessedThroughProperty("AboutToolStripMenuItem")]
	private ToolStripMenuItem _AboutToolStripMenuItem;

	[AccessedThroughProperty("ArrangeIconsToolStripMenuItem")]
	private ToolStripMenuItem _ArrangeIconsToolStripMenuItem;

	[AccessedThroughProperty("CloseAllToolStripMenuItem")]
	private ToolStripMenuItem _CloseAllToolStripMenuItem;

	[AccessedThroughProperty("NewWindowToolStripMenuItem")]
	private ToolStripMenuItem _NewWindowToolStripMenuItem;

	[AccessedThroughProperty("WindowsMenu")]
	private ToolStripMenuItem _WindowsMenu;

	[AccessedThroughProperty("CascadeToolStripMenuItem")]
	private ToolStripMenuItem _CascadeToolStripMenuItem;

	[AccessedThroughProperty("TileVerticalToolStripMenuItem")]
	private ToolStripMenuItem _TileVerticalToolStripMenuItem;

	[AccessedThroughProperty("TileHorizontalToolStripMenuItem")]
	private ToolStripMenuItem _TileHorizontalToolStripMenuItem;

	[AccessedThroughProperty("OptionsToolStripMenuItem")]
	private ToolStripMenuItem _OptionsToolStripMenuItem;

	[AccessedThroughProperty("HelpToolStripButton")]
	private ToolStripButton _HelpToolStripButton;

	[AccessedThroughProperty("ToolStripSeparator2")]
	private ToolStripSeparator _ToolStripSeparator2;

	[AccessedThroughProperty("PrintPreviewToolStripButton")]
	private ToolStripButton _PrintPreviewToolStripButton;

	[AccessedThroughProperty("ToolTip")]
	private ToolTip _ToolTip;

	[AccessedThroughProperty("ToolStripStatusLabel")]
	private ToolStripStatusLabel _ToolStripStatusLabel;

	[AccessedThroughProperty("StatusStrip")]
	private StatusStrip _StatusStrip;

	[AccessedThroughProperty("PrintToolStripButton")]
	private ToolStripButton _PrintToolStripButton;

	[AccessedThroughProperty("NewToolStripButton")]
	private ToolStripButton _NewToolStripButton;

	[AccessedThroughProperty("ToolStrip")]
	private ToolStrip _ToolStrip;

	[AccessedThroughProperty("OpenToolStripButton")]
	private ToolStripButton _OpenToolStripButton;

	[AccessedThroughProperty("SaveToolStripButton")]
	private ToolStripButton _SaveToolStripButton;

	[AccessedThroughProperty("ToolStripSeparator1")]
	private ToolStripSeparator _ToolStripSeparator1;

	[AccessedThroughProperty("PrintPreviewToolStripMenuItem")]
	private ToolStripMenuItem _PrintPreviewToolStripMenuItem;

	[AccessedThroughProperty("PrintToolStripMenuItem")]
	private ToolStripMenuItem _PrintToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator4")]
	private ToolStripSeparator _ToolStripSeparator4;

	[AccessedThroughProperty("ExitToolStripMenuItem")]
	private ToolStripMenuItem _ExitToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator5")]
	private ToolStripSeparator _ToolStripSeparator5;

	[AccessedThroughProperty("PrintSetupToolStripMenuItem")]
	private ToolStripMenuItem _PrintSetupToolStripMenuItem;

	[AccessedThroughProperty("SaveAsToolStripMenuItem")]
	private ToolStripMenuItem _SaveAsToolStripMenuItem;

	[AccessedThroughProperty("NewToolStripMenuItem")]
	private ToolStripMenuItem _NewToolStripMenuItem;

	[AccessedThroughProperty("FileMenu")]
	private ToolStripMenuItem _FileMenu;

	[AccessedThroughProperty("OpenToolStripMenuItem")]
	private ToolStripMenuItem _OpenToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator3")]
	private ToolStripSeparator _ToolStripSeparator3;

	[AccessedThroughProperty("SaveToolStripMenuItem")]
	private ToolStripMenuItem _SaveToolStripMenuItem;

	[AccessedThroughProperty("MenuStrip")]
	private MenuStrip _MenuStrip;

	[AccessedThroughProperty("EditMenu")]
	private ToolStripMenuItem _EditMenu;

	[AccessedThroughProperty("UndoToolStripMenuItem")]
	private ToolStripMenuItem _UndoToolStripMenuItem;

	[AccessedThroughProperty("RedoToolStripMenuItem")]
	private ToolStripMenuItem _RedoToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator6")]
	private ToolStripSeparator _ToolStripSeparator6;

	[AccessedThroughProperty("CutToolStripMenuItem")]
	private ToolStripMenuItem _CutToolStripMenuItem;

	[AccessedThroughProperty("CopyToolStripMenuItem")]
	private ToolStripMenuItem _CopyToolStripMenuItem;

	[AccessedThroughProperty("PasteToolStripMenuItem")]
	private ToolStripMenuItem _PasteToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator7")]
	private ToolStripSeparator _ToolStripSeparator7;

	[AccessedThroughProperty("SelectAllToolStripMenuItem")]
	private ToolStripMenuItem _SelectAllToolStripMenuItem;

	[AccessedThroughProperty("ViewMenu")]
	private ToolStripMenuItem _ViewMenu;

	[AccessedThroughProperty("ToolBarToolStripMenuItem")]
	private ToolStripMenuItem _ToolBarToolStripMenuItem;

	[AccessedThroughProperty("StatusBarToolStripMenuItem")]
	private ToolStripMenuItem _StatusBarToolStripMenuItem;

	[AccessedThroughProperty("ToolsMenu")]
	private ToolStripMenuItem _ToolsMenu;

	[AccessedThroughProperty("MenuStrip1")]
	private MenuStrip _MenuStrip1;

	[AccessedThroughProperty("ToolStripMenuItem1")]
	private ToolStripMenuItem _ToolStripMenuItem1;

	[AccessedThroughProperty("ToolStripMenuItem2")]
	private ToolStripMenuItem _ToolStripMenuItem2;

	[AccessedThroughProperty("ToolStripMenuItem3")]
	private ToolStripMenuItem _ToolStripMenuItem3;

	[AccessedThroughProperty("ToolStripSeparator9")]
	private ToolStripSeparator _ToolStripSeparator9;

	[AccessedThroughProperty("ToolStripMenuItem4")]
	private ToolStripMenuItem _ToolStripMenuItem4;

	[AccessedThroughProperty("ToolStripMenuItem5")]
	private ToolStripMenuItem _ToolStripMenuItem5;

	[AccessedThroughProperty("ToolStripSeparator10")]
	private ToolStripSeparator _ToolStripSeparator10;

	[AccessedThroughProperty("ToolStripMenuItem6")]
	private ToolStripMenuItem _ToolStripMenuItem6;

	[AccessedThroughProperty("ToolStripMenuItem7")]
	private ToolStripMenuItem _ToolStripMenuItem7;

	[AccessedThroughProperty("ToolStripMenuItem8")]
	private ToolStripMenuItem _ToolStripMenuItem8;

	[AccessedThroughProperty("ToolStripSeparator11")]
	private ToolStripSeparator _ToolStripSeparator11;

	[AccessedThroughProperty("ToolStripMenuItem9")]
	private ToolStripMenuItem _ToolStripMenuItem9;

	[AccessedThroughProperty("ToolStripMenuItem10")]
	private ToolStripMenuItem _ToolStripMenuItem10;

	[AccessedThroughProperty("ToolStripMenuItem11")]
	private ToolStripMenuItem _ToolStripMenuItem11;

	[AccessedThroughProperty("ToolStripMenuItem12")]
	private ToolStripMenuItem _ToolStripMenuItem12;

	[AccessedThroughProperty("ToolStripSeparator12")]
	private ToolStripSeparator _ToolStripSeparator12;

	[AccessedThroughProperty("ToolStripMenuItem13")]
	private ToolStripMenuItem _ToolStripMenuItem13;

	[AccessedThroughProperty("ToolStripMenuItem14")]
	private ToolStripMenuItem _ToolStripMenuItem14;

	[AccessedThroughProperty("ToolStripMenuItem15")]
	private ToolStripMenuItem _ToolStripMenuItem15;

	[AccessedThroughProperty("ToolStripSeparator13")]
	private ToolStripSeparator _ToolStripSeparator13;

	[AccessedThroughProperty("ToolStripMenuItem16")]
	private ToolStripMenuItem _ToolStripMenuItem16;

	[AccessedThroughProperty("ToolStripMenuItem17")]
	private ToolStripMenuItem _ToolStripMenuItem17;

	[AccessedThroughProperty("ToolStripMenuItem18")]
	private ToolStripMenuItem _ToolStripMenuItem18;

	[AccessedThroughProperty("ToolStripMenuItem19")]
	private ToolStripMenuItem _ToolStripMenuItem19;

	[AccessedThroughProperty("ToolStripMenuItem20")]
	private ToolStripMenuItem _ToolStripMenuItem20;

	[AccessedThroughProperty("ToolStripMenuItem21")]
	private ToolStripMenuItem _ToolStripMenuItem21;

	[AccessedThroughProperty("ToolStripMenuItem22")]
	private ToolStripMenuItem _ToolStripMenuItem22;

	[AccessedThroughProperty("ToolStripMenuItem23")]
	private ToolStripMenuItem _ToolStripMenuItem23;

	[AccessedThroughProperty("ToolStripMenuItem24")]
	private ToolStripMenuItem _ToolStripMenuItem24;

	[AccessedThroughProperty("ToolStripMenuItem25")]
	private ToolStripMenuItem _ToolStripMenuItem25;

	[AccessedThroughProperty("ToolStripMenuItem26")]
	private ToolStripMenuItem _ToolStripMenuItem26;

	[AccessedThroughProperty("ToolStripMenuItem27")]
	private ToolStripMenuItem _ToolStripMenuItem27;

	[AccessedThroughProperty("ToolStripMenuItem28")]
	private ToolStripMenuItem _ToolStripMenuItem28;

	[AccessedThroughProperty("ToolStripMenuItem29")]
	private ToolStripMenuItem _ToolStripMenuItem29;

	[AccessedThroughProperty("ToolStripMenuItem30")]
	private ToolStripMenuItem _ToolStripMenuItem30;

	[AccessedThroughProperty("ToolStripMenuItem31")]
	private ToolStripMenuItem _ToolStripMenuItem31;

	[AccessedThroughProperty("ToolStripMenuItem32")]
	private ToolStripMenuItem _ToolStripMenuItem32;

	[AccessedThroughProperty("ToolStripSeparator14")]
	private ToolStripSeparator _ToolStripSeparator14;

	[AccessedThroughProperty("ToolStripMenuItem33")]
	private ToolStripMenuItem _ToolStripMenuItem33;

	[AccessedThroughProperty("ToolStripSeparator15")]
	private ToolStripSeparator _ToolStripSeparator15;

	[AccessedThroughProperty("ToolStripButton1")]
	private ToolStripButton _ToolStripButton1;

	[AccessedThroughProperty("StatusStrip1")]
	private StatusStrip _StatusStrip1;

	[AccessedThroughProperty("ToolStripStatusLabel1")]
	private ToolStripStatusLabel _ToolStripStatusLabel1;

	[AccessedThroughProperty("ToolStripButton2")]
	private ToolStripButton _ToolStripButton2;

	[AccessedThroughProperty("ToolStripButton3")]
	private ToolStripButton _ToolStripButton3;

	[AccessedThroughProperty("ToolStripSeparator16")]
	private ToolStripSeparator _ToolStripSeparator16;

	[AccessedThroughProperty("ToolStrip1")]
	private ToolStrip _ToolStrip1;

	[AccessedThroughProperty("ToolStripButton4")]
	private ToolStripButton _ToolStripButton4;

	[AccessedThroughProperty("ToolStripButton5")]
	private ToolStripButton _ToolStripButton5;

	[AccessedThroughProperty("ToolStripButton6")]
	private ToolStripButton _ToolStripButton6;

	[AccessedThroughProperty("ToolTip1")]
	private ToolTip _ToolTip1;

	[AccessedThroughProperty("MenuStrip2")]
	private MenuStrip _MenuStrip2;

	[AccessedThroughProperty("ToolStripMenuItem34")]
	private ToolStripMenuItem _ToolStripMenuItem34;

	[AccessedThroughProperty("ToolStripMenuItem35")]
	private ToolStripMenuItem _ToolStripMenuItem35;

	[AccessedThroughProperty("ToolStripMenuItem36")]
	private ToolStripMenuItem _ToolStripMenuItem36;

	[AccessedThroughProperty("ToolStripSeparator17")]
	private ToolStripSeparator _ToolStripSeparator17;

	[AccessedThroughProperty("ToolStripMenuItem37")]
	private ToolStripMenuItem _ToolStripMenuItem37;

	[AccessedThroughProperty("ToolStripMenuItem38")]
	private ToolStripMenuItem _ToolStripMenuItem38;

	[AccessedThroughProperty("ToolStripSeparator18")]
	private ToolStripSeparator _ToolStripSeparator18;

	[AccessedThroughProperty("ToolStripMenuItem39")]
	private ToolStripMenuItem _ToolStripMenuItem39;

	[AccessedThroughProperty("ToolStripMenuItem40")]
	private ToolStripMenuItem _ToolStripMenuItem40;

	[AccessedThroughProperty("ToolStripMenuItem41")]
	private ToolStripMenuItem _ToolStripMenuItem41;

	[AccessedThroughProperty("ToolStripSeparator19")]
	private ToolStripSeparator _ToolStripSeparator19;

	[AccessedThroughProperty("ToolStripMenuItem42")]
	private ToolStripMenuItem _ToolStripMenuItem42;

	[AccessedThroughProperty("ToolStripMenuItem43")]
	private ToolStripMenuItem _ToolStripMenuItem43;

	[AccessedThroughProperty("ToolStripMenuItem44")]
	private ToolStripMenuItem _ToolStripMenuItem44;

	[AccessedThroughProperty("ToolStripMenuItem45")]
	private ToolStripMenuItem _ToolStripMenuItem45;

	[AccessedThroughProperty("ToolStripSeparator20")]
	private ToolStripSeparator _ToolStripSeparator20;

	[AccessedThroughProperty("ToolStripMenuItem46")]
	private ToolStripMenuItem _ToolStripMenuItem46;

	[AccessedThroughProperty("ToolStripMenuItem47")]
	private ToolStripMenuItem _ToolStripMenuItem47;

	[AccessedThroughProperty("ToolStripMenuItem48")]
	private ToolStripMenuItem _ToolStripMenuItem48;

	[AccessedThroughProperty("ToolStripSeparator21")]
	private ToolStripSeparator _ToolStripSeparator21;

	[AccessedThroughProperty("ToolStripMenuItem49")]
	private ToolStripMenuItem _ToolStripMenuItem49;

	[AccessedThroughProperty("ToolStripMenuItem50")]
	private ToolStripMenuItem _ToolStripMenuItem50;

	[AccessedThroughProperty("ToolStripMenuItem51")]
	private ToolStripMenuItem _ToolStripMenuItem51;

	[AccessedThroughProperty("ToolStripMenuItem52")]
	private ToolStripMenuItem _ToolStripMenuItem52;

	[AccessedThroughProperty("ToolStripMenuItem53")]
	private ToolStripMenuItem _ToolStripMenuItem53;

	[AccessedThroughProperty("ToolStripMenuItem54")]
	private ToolStripMenuItem _ToolStripMenuItem54;

	[AccessedThroughProperty("ToolStripMenuItem55")]
	private ToolStripMenuItem _ToolStripMenuItem55;

	[AccessedThroughProperty("ToolStripMenuItem56")]
	private ToolStripMenuItem _ToolStripMenuItem56;

	[AccessedThroughProperty("ToolStripMenuItem57")]
	private ToolStripMenuItem _ToolStripMenuItem57;

	[AccessedThroughProperty("ToolStripMenuItem58")]
	private ToolStripMenuItem _ToolStripMenuItem58;

	[AccessedThroughProperty("ToolStripMenuItem59")]
	private ToolStripMenuItem _ToolStripMenuItem59;

	[AccessedThroughProperty("ToolStripMenuItem60")]
	private ToolStripMenuItem _ToolStripMenuItem60;

	[AccessedThroughProperty("ToolStripMenuItem61")]
	private ToolStripMenuItem _ToolStripMenuItem61;

	[AccessedThroughProperty("ToolStripMenuItem62")]
	private ToolStripMenuItem _ToolStripMenuItem62;

	[AccessedThroughProperty("ToolStripMenuItem63")]
	private ToolStripMenuItem _ToolStripMenuItem63;

	[AccessedThroughProperty("ToolStripMenuItem64")]
	private ToolStripMenuItem _ToolStripMenuItem64;

	[AccessedThroughProperty("ToolStripMenuItem65")]
	private ToolStripMenuItem _ToolStripMenuItem65;

	[AccessedThroughProperty("ToolStripSeparator22")]
	private ToolStripSeparator _ToolStripSeparator22;

	[AccessedThroughProperty("ToolStripMenuItem66")]
	private ToolStripMenuItem _ToolStripMenuItem66;

	[AccessedThroughProperty("ToolStripSeparator23")]
	private ToolStripSeparator _ToolStripSeparator23;

	[AccessedThroughProperty("ToolStripButton7")]
	private ToolStripButton _ToolStripButton7;

	[AccessedThroughProperty("StatusStrip2")]
	private StatusStrip _StatusStrip2;

	[AccessedThroughProperty("ToolStripStatusLabel2")]
	private ToolStripStatusLabel _ToolStripStatusLabel2;

	[AccessedThroughProperty("ToolStripButton8")]
	private ToolStripButton _ToolStripButton8;

	[AccessedThroughProperty("ToolStripButton9")]
	private ToolStripButton _ToolStripButton9;

	[AccessedThroughProperty("ToolStripSeparator24")]
	private ToolStripSeparator _ToolStripSeparator24;

	[AccessedThroughProperty("ToolStrip2")]
	private ToolStrip _ToolStrip2;

	[AccessedThroughProperty("ToolStripButton10")]
	private ToolStripButton _ToolStripButton10;

	[AccessedThroughProperty("ToolStripButton11")]
	private ToolStripButton _ToolStripButton11;

	[AccessedThroughProperty("ToolStripButton12")]
	private ToolStripButton _ToolStripButton12;

	[AccessedThroughProperty("ToolTip2")]
	private ToolTip _ToolTip2;

	[AccessedThroughProperty("MenuStrip3")]
	private MenuStrip _MenuStrip3;

	[AccessedThroughProperty("ToolStripMenuItem67")]
	private ToolStripMenuItem _ToolStripMenuItem67;

	[AccessedThroughProperty("ToolStripMenuItem68")]
	private ToolStripMenuItem _ToolStripMenuItem68;

	[AccessedThroughProperty("ToolStripMenuItem69")]
	private ToolStripMenuItem _ToolStripMenuItem69;

	[AccessedThroughProperty("ToolStripSeparator25")]
	private ToolStripSeparator _ToolStripSeparator25;

	[AccessedThroughProperty("ToolStripMenuItem70")]
	private ToolStripMenuItem _ToolStripMenuItem70;

	[AccessedThroughProperty("ToolStripMenuItem71")]
	private ToolStripMenuItem _ToolStripMenuItem71;

	[AccessedThroughProperty("ToolStripSeparator26")]
	private ToolStripSeparator _ToolStripSeparator26;

	[AccessedThroughProperty("ToolStripMenuItem72")]
	private ToolStripMenuItem _ToolStripMenuItem72;

	[AccessedThroughProperty("ToolStripMenuItem73")]
	private ToolStripMenuItem _ToolStripMenuItem73;

	[AccessedThroughProperty("ToolStripMenuItem74")]
	private ToolStripMenuItem _ToolStripMenuItem74;

	[AccessedThroughProperty("ToolStripSeparator27")]
	private ToolStripSeparator _ToolStripSeparator27;

	[AccessedThroughProperty("ToolStripMenuItem75")]
	private ToolStripMenuItem _ToolStripMenuItem75;

	[AccessedThroughProperty("ToolStripMenuItem76")]
	private ToolStripMenuItem _ToolStripMenuItem76;

	[AccessedThroughProperty("ToolStripMenuItem77")]
	private ToolStripMenuItem _ToolStripMenuItem77;

	[AccessedThroughProperty("ToolStripMenuItem78")]
	private ToolStripMenuItem _ToolStripMenuItem78;

	[AccessedThroughProperty("ToolStripSeparator28")]
	private ToolStripSeparator _ToolStripSeparator28;

	[AccessedThroughProperty("ToolStripMenuItem79")]
	private ToolStripMenuItem _ToolStripMenuItem79;

	[AccessedThroughProperty("ToolStripMenuItem80")]
	private ToolStripMenuItem _ToolStripMenuItem80;

	[AccessedThroughProperty("ToolStripMenuItem81")]
	private ToolStripMenuItem _ToolStripMenuItem81;

	[AccessedThroughProperty("ToolStripSeparator29")]
	private ToolStripSeparator _ToolStripSeparator29;

	[AccessedThroughProperty("ToolStripMenuItem82")]
	private ToolStripMenuItem _ToolStripMenuItem82;

	[AccessedThroughProperty("ToolStripMenuItem83")]
	private ToolStripMenuItem _ToolStripMenuItem83;

	[AccessedThroughProperty("ToolStripMenuItem84")]
	private ToolStripMenuItem _ToolStripMenuItem84;

	[AccessedThroughProperty("ToolStripMenuItem85")]
	private ToolStripMenuItem _ToolStripMenuItem85;

	[AccessedThroughProperty("ToolStripMenuItem86")]
	private ToolStripMenuItem _ToolStripMenuItem86;

	[AccessedThroughProperty("ToolStripMenuItem87")]
	private ToolStripMenuItem _ToolStripMenuItem87;

	[AccessedThroughProperty("ToolStripMenuItem88")]
	private ToolStripMenuItem _ToolStripMenuItem88;

	[AccessedThroughProperty("ToolStripMenuItem89")]
	private ToolStripMenuItem _ToolStripMenuItem89;

	[AccessedThroughProperty("ToolStripMenuItem90")]
	private ToolStripMenuItem _ToolStripMenuItem90;

	[AccessedThroughProperty("ToolStripMenuItem91")]
	private ToolStripMenuItem _ToolStripMenuItem91;

	[AccessedThroughProperty("ToolStripMenuItem92")]
	private ToolStripMenuItem _ToolStripMenuItem92;

	[AccessedThroughProperty("ToolStripMenuItem93")]
	private ToolStripMenuItem _ToolStripMenuItem93;

	[AccessedThroughProperty("ToolStripMenuItem94")]
	private ToolStripMenuItem _ToolStripMenuItem94;

	[AccessedThroughProperty("ToolStripMenuItem95")]
	private ToolStripMenuItem _ToolStripMenuItem95;

	[AccessedThroughProperty("ToolStripMenuItem96")]
	private ToolStripMenuItem _ToolStripMenuItem96;

	[AccessedThroughProperty("ToolStripMenuItem97")]
	private ToolStripMenuItem _ToolStripMenuItem97;

	[AccessedThroughProperty("ToolStripMenuItem98")]
	private ToolStripMenuItem _ToolStripMenuItem98;

	[AccessedThroughProperty("ToolStripSeparator30")]
	private ToolStripSeparator _ToolStripSeparator30;

	[AccessedThroughProperty("ToolStripMenuItem99")]
	private ToolStripMenuItem _ToolStripMenuItem99;

	[AccessedThroughProperty("ToolStripSeparator31")]
	private ToolStripSeparator _ToolStripSeparator31;

	[AccessedThroughProperty("ToolStripButton13")]
	private ToolStripButton _ToolStripButton13;

	[AccessedThroughProperty("StatusStrip3")]
	private StatusStrip _StatusStrip3;

	[AccessedThroughProperty("ToolStripStatusLabel3")]
	private ToolStripStatusLabel _ToolStripStatusLabel3;

	[AccessedThroughProperty("ToolStripButton14")]
	private ToolStripButton _ToolStripButton14;

	[AccessedThroughProperty("ToolStripButton15")]
	private ToolStripButton _ToolStripButton15;

	[AccessedThroughProperty("ToolStripSeparator32")]
	private ToolStripSeparator _ToolStripSeparator32;

	[AccessedThroughProperty("ToolStrip3")]
	private ToolStrip _ToolStrip3;

	[AccessedThroughProperty("ToolStripButton16")]
	private ToolStripButton _ToolStripButton16;

	[AccessedThroughProperty("ToolStripButton17")]
	private ToolStripButton _ToolStripButton17;

	[AccessedThroughProperty("ToolStripButton18")]
	private ToolStripButton _ToolStripButton18;

	[AccessedThroughProperty("ToolTip3")]
	private ToolTip _ToolTip3;

	[AccessedThroughProperty("MenuStrip4")]
	private MenuStrip _MenuStrip4;

	[AccessedThroughProperty("ToolStripMenuItem100")]
	private ToolStripMenuItem _ToolStripMenuItem100;

	[AccessedThroughProperty("ToolStripMenuItem101")]
	private ToolStripMenuItem _ToolStripMenuItem101;

	[AccessedThroughProperty("ToolStripMenuItem102")]
	private ToolStripMenuItem _ToolStripMenuItem102;

	[AccessedThroughProperty("ToolStripSeparator33")]
	private ToolStripSeparator _ToolStripSeparator33;

	[AccessedThroughProperty("ToolStripMenuItem103")]
	private ToolStripMenuItem _ToolStripMenuItem103;

	[AccessedThroughProperty("ToolStripMenuItem104")]
	private ToolStripMenuItem _ToolStripMenuItem104;

	[AccessedThroughProperty("ToolStripSeparator34")]
	private ToolStripSeparator _ToolStripSeparator34;

	[AccessedThroughProperty("ToolStripMenuItem105")]
	private ToolStripMenuItem _ToolStripMenuItem105;

	[AccessedThroughProperty("ToolStripMenuItem106")]
	private ToolStripMenuItem _ToolStripMenuItem106;

	[AccessedThroughProperty("ToolStripMenuItem107")]
	private ToolStripMenuItem _ToolStripMenuItem107;

	[AccessedThroughProperty("ToolStripSeparator35")]
	private ToolStripSeparator _ToolStripSeparator35;

	[AccessedThroughProperty("ToolStripMenuItem108")]
	private ToolStripMenuItem _ToolStripMenuItem108;

	[AccessedThroughProperty("ToolStripMenuItem109")]
	private ToolStripMenuItem _ToolStripMenuItem109;

	[AccessedThroughProperty("ToolStripMenuItem110")]
	private ToolStripMenuItem _ToolStripMenuItem110;

	[AccessedThroughProperty("ToolStripMenuItem111")]
	private ToolStripMenuItem _ToolStripMenuItem111;

	[AccessedThroughProperty("ToolStripSeparator36")]
	private ToolStripSeparator _ToolStripSeparator36;

	[AccessedThroughProperty("ToolStripMenuItem112")]
	private ToolStripMenuItem _ToolStripMenuItem112;

	[AccessedThroughProperty("ToolStripMenuItem113")]
	private ToolStripMenuItem _ToolStripMenuItem113;

	[AccessedThroughProperty("ToolStripMenuItem114")]
	private ToolStripMenuItem _ToolStripMenuItem114;

	[AccessedThroughProperty("ToolStripSeparator37")]
	private ToolStripSeparator _ToolStripSeparator37;

	[AccessedThroughProperty("ToolStripMenuItem115")]
	private ToolStripMenuItem _ToolStripMenuItem115;

	[AccessedThroughProperty("ToolStripMenuItem116")]
	private ToolStripMenuItem _ToolStripMenuItem116;

	[AccessedThroughProperty("ToolStripMenuItem117")]
	private ToolStripMenuItem _ToolStripMenuItem117;

	[AccessedThroughProperty("ToolStripMenuItem118")]
	private ToolStripMenuItem _ToolStripMenuItem118;

	[AccessedThroughProperty("ToolStripMenuItem119")]
	private ToolStripMenuItem _ToolStripMenuItem119;

	[AccessedThroughProperty("ToolStripMenuItem120")]
	private ToolStripMenuItem _ToolStripMenuItem120;

	[AccessedThroughProperty("ToolStripMenuItem121")]
	private ToolStripMenuItem _ToolStripMenuItem121;

	[AccessedThroughProperty("ToolStripMenuItem122")]
	private ToolStripMenuItem _ToolStripMenuItem122;

	[AccessedThroughProperty("ToolStripMenuItem123")]
	private ToolStripMenuItem _ToolStripMenuItem123;

	[AccessedThroughProperty("ToolStripMenuItem124")]
	private ToolStripMenuItem _ToolStripMenuItem124;

	[AccessedThroughProperty("ToolStripMenuItem125")]
	private ToolStripMenuItem _ToolStripMenuItem125;

	[AccessedThroughProperty("ToolStripMenuItem126")]
	private ToolStripMenuItem _ToolStripMenuItem126;

	[AccessedThroughProperty("ToolStripMenuItem127")]
	private ToolStripMenuItem _ToolStripMenuItem127;

	[AccessedThroughProperty("ToolStripMenuItem128")]
	private ToolStripMenuItem _ToolStripMenuItem128;

	[AccessedThroughProperty("ToolStripMenuItem129")]
	private ToolStripMenuItem _ToolStripMenuItem129;

	[AccessedThroughProperty("ToolStripMenuItem130")]
	private ToolStripMenuItem _ToolStripMenuItem130;

	[AccessedThroughProperty("ToolStripMenuItem131")]
	private ToolStripMenuItem _ToolStripMenuItem131;

	[AccessedThroughProperty("ToolStripSeparator38")]
	private ToolStripSeparator _ToolStripSeparator38;

	[AccessedThroughProperty("ToolStripMenuItem132")]
	private ToolStripMenuItem _ToolStripMenuItem132;

	[AccessedThroughProperty("ToolStripSeparator39")]
	private ToolStripSeparator _ToolStripSeparator39;

	[AccessedThroughProperty("ToolStripButton19")]
	private ToolStripButton _ToolStripButton19;

	[AccessedThroughProperty("StatusStrip4")]
	private StatusStrip _StatusStrip4;

	[AccessedThroughProperty("ToolStripStatusLabel4")]
	private ToolStripStatusLabel _ToolStripStatusLabel4;

	[AccessedThroughProperty("ToolStripButton20")]
	private ToolStripButton _ToolStripButton20;

	[AccessedThroughProperty("ToolStripButton21")]
	private ToolStripButton _ToolStripButton21;

	[AccessedThroughProperty("ToolStripSeparator40")]
	private ToolStripSeparator _ToolStripSeparator40;

	[AccessedThroughProperty("ToolStrip4")]
	private ToolStrip _ToolStrip4;

	[AccessedThroughProperty("ToolStripButton22")]
	private ToolStripButton _ToolStripButton22;

	[AccessedThroughProperty("ToolStripButton23")]
	private ToolStripButton _ToolStripButton23;

	[AccessedThroughProperty("ToolStripButton24")]
	private ToolStripButton _ToolStripButton24;

	[AccessedThroughProperty("ToolTip4")]
	private ToolTip _ToolTip4;

	[AccessedThroughProperty("MenuStrip5")]
	private MenuStrip _MenuStrip5;

	[AccessedThroughProperty("ToolStripMenuItem133")]
	private ToolStripMenuItem _ToolStripMenuItem133;

	[AccessedThroughProperty("ToolStripMenuItem134")]
	private ToolStripMenuItem _ToolStripMenuItem134;

	[AccessedThroughProperty("ToolStripMenuItem135")]
	private ToolStripMenuItem _ToolStripMenuItem135;

	[AccessedThroughProperty("ToolStripSeparator41")]
	private ToolStripSeparator _ToolStripSeparator41;

	[AccessedThroughProperty("ToolStripMenuItem136")]
	private ToolStripMenuItem _ToolStripMenuItem136;

	[AccessedThroughProperty("ToolStripMenuItem137")]
	private ToolStripMenuItem _ToolStripMenuItem137;

	[AccessedThroughProperty("ToolStripSeparator42")]
	private ToolStripSeparator _ToolStripSeparator42;

	[AccessedThroughProperty("ToolStripMenuItem138")]
	private ToolStripMenuItem _ToolStripMenuItem138;

	[AccessedThroughProperty("ToolStripMenuItem139")]
	private ToolStripMenuItem _ToolStripMenuItem139;

	[AccessedThroughProperty("ToolStripMenuItem140")]
	private ToolStripMenuItem _ToolStripMenuItem140;

	[AccessedThroughProperty("ToolStripSeparator43")]
	private ToolStripSeparator _ToolStripSeparator43;

	[AccessedThroughProperty("ToolStripMenuItem141")]
	private ToolStripMenuItem _ToolStripMenuItem141;

	[AccessedThroughProperty("ToolStripMenuItem142")]
	private ToolStripMenuItem _ToolStripMenuItem142;

	[AccessedThroughProperty("ToolStripMenuItem143")]
	private ToolStripMenuItem _ToolStripMenuItem143;

	[AccessedThroughProperty("ToolStripMenuItem144")]
	private ToolStripMenuItem _ToolStripMenuItem144;

	[AccessedThroughProperty("ToolStripSeparator44")]
	private ToolStripSeparator _ToolStripSeparator44;

	[AccessedThroughProperty("ToolStripMenuItem145")]
	private ToolStripMenuItem _ToolStripMenuItem145;

	[AccessedThroughProperty("ToolStripMenuItem146")]
	private ToolStripMenuItem _ToolStripMenuItem146;

	[AccessedThroughProperty("ToolStripMenuItem147")]
	private ToolStripMenuItem _ToolStripMenuItem147;

	[AccessedThroughProperty("ToolStripSeparator45")]
	private ToolStripSeparator _ToolStripSeparator45;

	[AccessedThroughProperty("ToolStripMenuItem148")]
	private ToolStripMenuItem _ToolStripMenuItem148;

	[AccessedThroughProperty("ToolStripMenuItem149")]
	private ToolStripMenuItem _ToolStripMenuItem149;

	[AccessedThroughProperty("ToolStripMenuItem150")]
	private ToolStripMenuItem _ToolStripMenuItem150;

	[AccessedThroughProperty("ToolStripMenuItem151")]
	private ToolStripMenuItem _ToolStripMenuItem151;

	[AccessedThroughProperty("ToolStripMenuItem152")]
	private ToolStripMenuItem _ToolStripMenuItem152;

	[AccessedThroughProperty("ToolStripMenuItem153")]
	private ToolStripMenuItem _ToolStripMenuItem153;

	[AccessedThroughProperty("ToolStripMenuItem154")]
	private ToolStripMenuItem _ToolStripMenuItem154;

	[AccessedThroughProperty("ToolStripMenuItem155")]
	private ToolStripMenuItem _ToolStripMenuItem155;

	[AccessedThroughProperty("ToolStripMenuItem156")]
	private ToolStripMenuItem _ToolStripMenuItem156;

	[AccessedThroughProperty("ToolStripMenuItem157")]
	private ToolStripMenuItem _ToolStripMenuItem157;

	[AccessedThroughProperty("ToolStripMenuItem158")]
	private ToolStripMenuItem _ToolStripMenuItem158;

	[AccessedThroughProperty("ToolStripMenuItem159")]
	private ToolStripMenuItem _ToolStripMenuItem159;

	[AccessedThroughProperty("ToolStripMenuItem160")]
	private ToolStripMenuItem _ToolStripMenuItem160;

	[AccessedThroughProperty("ToolStripMenuItem161")]
	private ToolStripMenuItem _ToolStripMenuItem161;

	[AccessedThroughProperty("ToolStripMenuItem162")]
	private ToolStripMenuItem _ToolStripMenuItem162;

	[AccessedThroughProperty("ToolStripMenuItem163")]
	private ToolStripMenuItem _ToolStripMenuItem163;

	[AccessedThroughProperty("ToolStripMenuItem164")]
	private ToolStripMenuItem _ToolStripMenuItem164;

	[AccessedThroughProperty("ToolStripSeparator46")]
	private ToolStripSeparator _ToolStripSeparator46;

	[AccessedThroughProperty("ToolStripMenuItem165")]
	private ToolStripMenuItem _ToolStripMenuItem165;

	[AccessedThroughProperty("ToolStripSeparator47")]
	private ToolStripSeparator _ToolStripSeparator47;

	[AccessedThroughProperty("ToolStripButton25")]
	private ToolStripButton _ToolStripButton25;

	[AccessedThroughProperty("StatusStrip5")]
	private StatusStrip _StatusStrip5;

	[AccessedThroughProperty("ToolStripStatusLabel5")]
	private ToolStripStatusLabel _ToolStripStatusLabel5;

	[AccessedThroughProperty("ToolStripButton26")]
	private ToolStripButton _ToolStripButton26;

	[AccessedThroughProperty("ToolStripButton27")]
	private ToolStripButton _ToolStripButton27;

	[AccessedThroughProperty("ToolStripSeparator48")]
	private ToolStripSeparator _ToolStripSeparator48;

	[AccessedThroughProperty("ToolStrip5")]
	private ToolStrip _ToolStrip5;

	[AccessedThroughProperty("ToolStripButton28")]
	private ToolStripButton _ToolStripButton28;

	[AccessedThroughProperty("ToolStripButton29")]
	private ToolStripButton _ToolStripButton29;

	[AccessedThroughProperty("ToolStripButton30")]
	private ToolStripButton _ToolStripButton30;

	[AccessedThroughProperty("ToolTip5")]
	private ToolTip _ToolTip5;

	[AccessedThroughProperty("MenuStrip6")]
	private MenuStrip _MenuStrip6;

	[AccessedThroughProperty("ToolStripMenuItem166")]
	private ToolStripMenuItem _ToolStripMenuItem166;

	[AccessedThroughProperty("ToolStripMenuItem167")]
	private ToolStripMenuItem _ToolStripMenuItem167;

	[AccessedThroughProperty("ToolStripMenuItem168")]
	private ToolStripMenuItem _ToolStripMenuItem168;

	[AccessedThroughProperty("ToolStripSeparator49")]
	private ToolStripSeparator _ToolStripSeparator49;

	[AccessedThroughProperty("ToolStripMenuItem169")]
	private ToolStripMenuItem _ToolStripMenuItem169;

	[AccessedThroughProperty("ToolStripMenuItem170")]
	private ToolStripMenuItem _ToolStripMenuItem170;

	[AccessedThroughProperty("ToolStripSeparator50")]
	private ToolStripSeparator _ToolStripSeparator50;

	[AccessedThroughProperty("ToolStripMenuItem171")]
	private ToolStripMenuItem _ToolStripMenuItem171;

	[AccessedThroughProperty("ToolStripMenuItem172")]
	private ToolStripMenuItem _ToolStripMenuItem172;

	[AccessedThroughProperty("ToolStripMenuItem173")]
	private ToolStripMenuItem _ToolStripMenuItem173;

	[AccessedThroughProperty("ToolStripSeparator51")]
	private ToolStripSeparator _ToolStripSeparator51;

	[AccessedThroughProperty("ToolStripMenuItem174")]
	private ToolStripMenuItem _ToolStripMenuItem174;

	[AccessedThroughProperty("ToolStripMenuItem175")]
	private ToolStripMenuItem _ToolStripMenuItem175;

	[AccessedThroughProperty("ToolStripMenuItem176")]
	private ToolStripMenuItem _ToolStripMenuItem176;

	[AccessedThroughProperty("ToolStripMenuItem177")]
	private ToolStripMenuItem _ToolStripMenuItem177;

	[AccessedThroughProperty("ToolStripSeparator52")]
	private ToolStripSeparator _ToolStripSeparator52;

	[AccessedThroughProperty("ToolStripMenuItem178")]
	private ToolStripMenuItem _ToolStripMenuItem178;

	[AccessedThroughProperty("ToolStripMenuItem179")]
	private ToolStripMenuItem _ToolStripMenuItem179;

	[AccessedThroughProperty("ToolStripMenuItem180")]
	private ToolStripMenuItem _ToolStripMenuItem180;

	[AccessedThroughProperty("ToolStripSeparator53")]
	private ToolStripSeparator _ToolStripSeparator53;

	[AccessedThroughProperty("ToolStripMenuItem181")]
	private ToolStripMenuItem _ToolStripMenuItem181;

	[AccessedThroughProperty("ToolStripMenuItem182")]
	private ToolStripMenuItem _ToolStripMenuItem182;

	[AccessedThroughProperty("ToolStripMenuItem183")]
	private ToolStripMenuItem _ToolStripMenuItem183;

	[AccessedThroughProperty("ToolStripMenuItem184")]
	private ToolStripMenuItem _ToolStripMenuItem184;

	[AccessedThroughProperty("ToolStripMenuItem185")]
	private ToolStripMenuItem _ToolStripMenuItem185;

	[AccessedThroughProperty("ToolStripMenuItem186")]
	private ToolStripMenuItem _ToolStripMenuItem186;

	[AccessedThroughProperty("ToolStripMenuItem187")]
	private ToolStripMenuItem _ToolStripMenuItem187;

	[AccessedThroughProperty("ToolStripMenuItem188")]
	private ToolStripMenuItem _ToolStripMenuItem188;

	[AccessedThroughProperty("ToolStripMenuItem189")]
	private ToolStripMenuItem _ToolStripMenuItem189;

	[AccessedThroughProperty("ToolStripMenuItem190")]
	private ToolStripMenuItem _ToolStripMenuItem190;

	[AccessedThroughProperty("ToolStripMenuItem191")]
	private ToolStripMenuItem _ToolStripMenuItem191;

	[AccessedThroughProperty("ToolStripMenuItem192")]
	private ToolStripMenuItem _ToolStripMenuItem192;

	[AccessedThroughProperty("ToolStripMenuItem193")]
	private ToolStripMenuItem _ToolStripMenuItem193;

	[AccessedThroughProperty("ToolStripMenuItem194")]
	private ToolStripMenuItem _ToolStripMenuItem194;

	[AccessedThroughProperty("ToolStripMenuItem195")]
	private ToolStripMenuItem _ToolStripMenuItem195;

	[AccessedThroughProperty("ToolStripMenuItem196")]
	private ToolStripMenuItem _ToolStripMenuItem196;

	[AccessedThroughProperty("ToolStripMenuItem197")]
	private ToolStripMenuItem _ToolStripMenuItem197;

	[AccessedThroughProperty("ToolStripSeparator54")]
	private ToolStripSeparator _ToolStripSeparator54;

	[AccessedThroughProperty("ToolStripMenuItem198")]
	private ToolStripMenuItem _ToolStripMenuItem198;

	[AccessedThroughProperty("ToolStripSeparator55")]
	private ToolStripSeparator _ToolStripSeparator55;

	[AccessedThroughProperty("ToolStripButton31")]
	private ToolStripButton _ToolStripButton31;

	[AccessedThroughProperty("StatusStrip6")]
	private StatusStrip _StatusStrip6;

	[AccessedThroughProperty("ToolStripStatusLabel6")]
	private ToolStripStatusLabel _ToolStripStatusLabel6;

	[AccessedThroughProperty("ToolStripButton32")]
	private ToolStripButton _ToolStripButton32;

	[AccessedThroughProperty("ToolStripButton33")]
	private ToolStripButton _ToolStripButton33;

	[AccessedThroughProperty("ToolStripSeparator56")]
	private ToolStripSeparator _ToolStripSeparator56;

	[AccessedThroughProperty("ToolStrip6")]
	private ToolStrip _ToolStrip6;

	[AccessedThroughProperty("ToolStripButton34")]
	private ToolStripButton _ToolStripButton34;

	[AccessedThroughProperty("ToolStripButton35")]
	private ToolStripButton _ToolStripButton35;

	[AccessedThroughProperty("ToolStripButton36")]
	private ToolStripButton _ToolStripButton36;

	[AccessedThroughProperty("ToolTip6")]
	private ToolTip _ToolTip6;

	private int m_ChildFormNumber;

	internal virtual ToolStripMenuItem ContentsToolStripMenuItem
	{
		get
		{
			return _ContentsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ContentsToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem HelpMenu
	{
		get
		{
			return _HelpMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_HelpMenu = value;
		}
	}

	internal virtual ToolStripMenuItem IndexToolStripMenuItem
	{
		get
		{
			return _IndexToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_IndexToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem SearchToolStripMenuItem
	{
		get
		{
			return _SearchToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_SearchToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator8
	{
		get
		{
			return _ToolStripSeparator8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator8 = value;
		}
	}

	internal virtual ToolStripMenuItem AboutToolStripMenuItem
	{
		get
		{
			return _AboutToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_AboutToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem ArrangeIconsToolStripMenuItem
	{
		get
		{
			return _ArrangeIconsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = ArrangeIconsToolStripMenuItem_Click;
			if (_ArrangeIconsToolStripMenuItem != null)
			{
				((ToolStripItem)_ArrangeIconsToolStripMenuItem).remove_Click(eventHandler);
			}
			_ArrangeIconsToolStripMenuItem = value;
			if (_ArrangeIconsToolStripMenuItem != null)
			{
				((ToolStripItem)_ArrangeIconsToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem CloseAllToolStripMenuItem
	{
		get
		{
			return _CloseAllToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = CloseAllToolStripMenuItem_Click;
			if (_CloseAllToolStripMenuItem != null)
			{
				((ToolStripItem)_CloseAllToolStripMenuItem).remove_Click(eventHandler);
			}
			_CloseAllToolStripMenuItem = value;
			if (_CloseAllToolStripMenuItem != null)
			{
				((ToolStripItem)_CloseAllToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem NewWindowToolStripMenuItem
	{
		get
		{
			return _NewWindowToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = ShowNewForm;
			if (_NewWindowToolStripMenuItem != null)
			{
				((ToolStripItem)_NewWindowToolStripMenuItem).remove_Click(eventHandler);
			}
			_NewWindowToolStripMenuItem = value;
			if (_NewWindowToolStripMenuItem != null)
			{
				((ToolStripItem)_NewWindowToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem WindowsMenu
	{
		get
		{
			return _WindowsMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_WindowsMenu = value;
		}
	}

	internal virtual ToolStripMenuItem CascadeToolStripMenuItem
	{
		get
		{
			return _CascadeToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = CascadeToolStripMenuItem_Click;
			if (_CascadeToolStripMenuItem != null)
			{
				((ToolStripItem)_CascadeToolStripMenuItem).remove_Click(eventHandler);
			}
			_CascadeToolStripMenuItem = value;
			if (_CascadeToolStripMenuItem != null)
			{
				((ToolStripItem)_CascadeToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem TileVerticalToolStripMenuItem
	{
		get
		{
			return _TileVerticalToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = TileVerticalToolStripMenuItem_Click;
			if (_TileVerticalToolStripMenuItem != null)
			{
				((ToolStripItem)_TileVerticalToolStripMenuItem).remove_Click(eventHandler);
			}
			_TileVerticalToolStripMenuItem = value;
			if (_TileVerticalToolStripMenuItem != null)
			{
				((ToolStripItem)_TileVerticalToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem TileHorizontalToolStripMenuItem
	{
		get
		{
			return _TileHorizontalToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = TileHorizontalToolStripMenuItem_Click;
			if (_TileHorizontalToolStripMenuItem != null)
			{
				((ToolStripItem)_TileHorizontalToolStripMenuItem).remove_Click(eventHandler);
			}
			_TileHorizontalToolStripMenuItem = value;
			if (_TileHorizontalToolStripMenuItem != null)
			{
				((ToolStripItem)_TileHorizontalToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem OptionsToolStripMenuItem
	{
		get
		{
			return _OptionsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_OptionsToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripButton HelpToolStripButton
	{
		get
		{
			return _HelpToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_HelpToolStripButton = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator2
	{
		get
		{
			return _ToolStripSeparator2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator2 = value;
		}
	}

	internal virtual ToolStripButton PrintPreviewToolStripButton
	{
		get
		{
			return _PrintPreviewToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PrintPreviewToolStripButton = value;
		}
	}

	internal virtual ToolTip ToolTip
	{
		get
		{
			return _ToolTip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolTip = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel
	{
		get
		{
			return _ToolStripStatusLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripStatusLabel = value;
		}
	}

	internal virtual StatusStrip StatusStrip
	{
		get
		{
			return _StatusStrip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_StatusStrip = value;
		}
	}

	internal virtual ToolStripButton PrintToolStripButton
	{
		get
		{
			return _PrintToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PrintToolStripButton = value;
		}
	}

	internal virtual ToolStripButton NewToolStripButton
	{
		get
		{
			return _NewToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = ShowNewForm;
			if (_NewToolStripButton != null)
			{
				((ToolStripItem)_NewToolStripButton).remove_Click(eventHandler);
			}
			_NewToolStripButton = value;
			if (_NewToolStripButton != null)
			{
				((ToolStripItem)_NewToolStripButton).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStrip ToolStrip
	{
		get
		{
			return _ToolStrip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStrip = value;
		}
	}

	internal virtual ToolStripButton OpenToolStripButton
	{
		get
		{
			return _OpenToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = OpenFile;
			if (_OpenToolStripButton != null)
			{
				((ToolStripItem)_OpenToolStripButton).remove_Click(eventHandler);
			}
			_OpenToolStripButton = value;
			if (_OpenToolStripButton != null)
			{
				((ToolStripItem)_OpenToolStripButton).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripButton SaveToolStripButton
	{
		get
		{
			return _SaveToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_SaveToolStripButton = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator1
	{
		get
		{
			return _ToolStripSeparator1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator1 = value;
		}
	}

	internal virtual ToolStripMenuItem PrintPreviewToolStripMenuItem
	{
		get
		{
			return _PrintPreviewToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PrintPreviewToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem PrintToolStripMenuItem
	{
		get
		{
			return _PrintToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PrintToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator4
	{
		get
		{
			return _ToolStripSeparator4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator4 = value;
		}
	}

	internal virtual ToolStripMenuItem ExitToolStripMenuItem
	{
		get
		{
			return _ExitToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = ExitToolsStripMenuItem_Click;
			if (_ExitToolStripMenuItem != null)
			{
				((ToolStripItem)_ExitToolStripMenuItem).remove_Click(eventHandler);
			}
			_ExitToolStripMenuItem = value;
			if (_ExitToolStripMenuItem != null)
			{
				((ToolStripItem)_ExitToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator5
	{
		get
		{
			return _ToolStripSeparator5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator5 = value;
		}
	}

	internal virtual ToolStripMenuItem PrintSetupToolStripMenuItem
	{
		get
		{
			return _PrintSetupToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PrintSetupToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem SaveAsToolStripMenuItem
	{
		get
		{
			return _SaveAsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = SaveAsToolStripMenuItem_Click;
			if (_SaveAsToolStripMenuItem != null)
			{
				((ToolStripItem)_SaveAsToolStripMenuItem).remove_Click(eventHandler);
			}
			_SaveAsToolStripMenuItem = value;
			if (_SaveAsToolStripMenuItem != null)
			{
				((ToolStripItem)_SaveAsToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem NewToolStripMenuItem
	{
		get
		{
			return _NewToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = ShowNewForm;
			if (_NewToolStripMenuItem != null)
			{
				((ToolStripItem)_NewToolStripMenuItem).remove_Click(eventHandler);
			}
			_NewToolStripMenuItem = value;
			if (_NewToolStripMenuItem != null)
			{
				((ToolStripItem)_NewToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem FileMenu
	{
		get
		{
			return _FileMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_FileMenu = value;
		}
	}

	internal virtual ToolStripMenuItem OpenToolStripMenuItem
	{
		get
		{
			return _OpenToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = OpenFile;
			if (_OpenToolStripMenuItem != null)
			{
				((ToolStripItem)_OpenToolStripMenuItem).remove_Click(eventHandler);
			}
			_OpenToolStripMenuItem = value;
			if (_OpenToolStripMenuItem != null)
			{
				((ToolStripItem)_OpenToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator3
	{
		get
		{
			return _ToolStripSeparator3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator3 = value;
		}
	}

	internal virtual ToolStripMenuItem SaveToolStripMenuItem
	{
		get
		{
			return _SaveToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_SaveToolStripMenuItem = value;
		}
	}

	internal virtual MenuStrip MenuStrip
	{
		get
		{
			return _MenuStrip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MenuStrip = value;
		}
	}

	internal virtual ToolStripMenuItem EditMenu
	{
		get
		{
			return _EditMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_EditMenu = value;
		}
	}

	internal virtual ToolStripMenuItem UndoToolStripMenuItem
	{
		get
		{
			return _UndoToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_UndoToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem RedoToolStripMenuItem
	{
		get
		{
			return _RedoToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RedoToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator6
	{
		get
		{
			return _ToolStripSeparator6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator6 = value;
		}
	}

	internal virtual ToolStripMenuItem CutToolStripMenuItem
	{
		get
		{
			return _CutToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = CutToolStripMenuItem_Click;
			if (_CutToolStripMenuItem != null)
			{
				((ToolStripItem)_CutToolStripMenuItem).remove_Click(eventHandler);
			}
			_CutToolStripMenuItem = value;
			if (_CutToolStripMenuItem != null)
			{
				((ToolStripItem)_CutToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem CopyToolStripMenuItem
	{
		get
		{
			return _CopyToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = CopyToolStripMenuItem_Click;
			if (_CopyToolStripMenuItem != null)
			{
				((ToolStripItem)_CopyToolStripMenuItem).remove_Click(eventHandler);
			}
			_CopyToolStripMenuItem = value;
			if (_CopyToolStripMenuItem != null)
			{
				((ToolStripItem)_CopyToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem PasteToolStripMenuItem
	{
		get
		{
			return _PasteToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = PasteToolStripMenuItem_Click;
			if (_PasteToolStripMenuItem != null)
			{
				((ToolStripItem)_PasteToolStripMenuItem).remove_Click(eventHandler);
			}
			_PasteToolStripMenuItem = value;
			if (_PasteToolStripMenuItem != null)
			{
				((ToolStripItem)_PasteToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator7
	{
		get
		{
			return _ToolStripSeparator7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator7 = value;
		}
	}

	internal virtual ToolStripMenuItem SelectAllToolStripMenuItem
	{
		get
		{
			return _SelectAllToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_SelectAllToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem ViewMenu
	{
		get
		{
			return _ViewMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ViewMenu = value;
		}
	}

	internal virtual ToolStripMenuItem ToolBarToolStripMenuItem
	{
		get
		{
			return _ToolBarToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = ToolBarToolStripMenuItem_Click;
			if (_ToolBarToolStripMenuItem != null)
			{
				((ToolStripItem)_ToolBarToolStripMenuItem).remove_Click(eventHandler);
			}
			_ToolBarToolStripMenuItem = value;
			if (_ToolBarToolStripMenuItem != null)
			{
				((ToolStripItem)_ToolBarToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem StatusBarToolStripMenuItem
	{
		get
		{
			return _StatusBarToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = StatusBarToolStripMenuItem_Click;
			if (_StatusBarToolStripMenuItem != null)
			{
				((ToolStripItem)_StatusBarToolStripMenuItem).remove_Click(eventHandler);
			}
			_StatusBarToolStripMenuItem = value;
			if (_StatusBarToolStripMenuItem != null)
			{
				((ToolStripItem)_StatusBarToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ToolsMenu
	{
		get
		{
			return _ToolsMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolsMenu = value;
		}
	}

	internal virtual MenuStrip MenuStrip1
	{
		get
		{
			return _MenuStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MenuStrip1 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem1
	{
		get
		{
			return _ToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem1 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem2
	{
		get
		{
			return _ToolStripMenuItem2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem2 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem3
	{
		get
		{
			return _ToolStripMenuItem3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem3 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator9
	{
		get
		{
			return _ToolStripSeparator9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator9 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem4
	{
		get
		{
			return _ToolStripMenuItem4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem4 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem5
	{
		get
		{
			return _ToolStripMenuItem5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem5 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator10
	{
		get
		{
			return _ToolStripSeparator10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator10 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem6
	{
		get
		{
			return _ToolStripMenuItem6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem6 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem7
	{
		get
		{
			return _ToolStripMenuItem7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem7 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem8
	{
		get
		{
			return _ToolStripMenuItem8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem8 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator11
	{
		get
		{
			return _ToolStripSeparator11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator11 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem9
	{
		get
		{
			return _ToolStripMenuItem9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem9 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem10
	{
		get
		{
			return _ToolStripMenuItem10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem10 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem11
	{
		get
		{
			return _ToolStripMenuItem11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem11 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem12
	{
		get
		{
			return _ToolStripMenuItem12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem12 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator12
	{
		get
		{
			return _ToolStripSeparator12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator12 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem13
	{
		get
		{
			return _ToolStripMenuItem13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem13 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem14
	{
		get
		{
			return _ToolStripMenuItem14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem14 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem15
	{
		get
		{
			return _ToolStripMenuItem15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem15 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator13
	{
		get
		{
			return _ToolStripSeparator13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator13 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem16
	{
		get
		{
			return _ToolStripMenuItem16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem16 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem17
	{
		get
		{
			return _ToolStripMenuItem17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem17 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem18
	{
		get
		{
			return _ToolStripMenuItem18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem18 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem19
	{
		get
		{
			return _ToolStripMenuItem19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem19 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem20
	{
		get
		{
			return _ToolStripMenuItem20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem20 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem21
	{
		get
		{
			return _ToolStripMenuItem21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem21 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem22
	{
		get
		{
			return _ToolStripMenuItem22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem22 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem23
	{
		get
		{
			return _ToolStripMenuItem23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem23 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem24
	{
		get
		{
			return _ToolStripMenuItem24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem24 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem25
	{
		get
		{
			return _ToolStripMenuItem25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem25 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem26
	{
		get
		{
			return _ToolStripMenuItem26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem26 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem27
	{
		get
		{
			return _ToolStripMenuItem27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem27 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem28
	{
		get
		{
			return _ToolStripMenuItem28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem28 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem29
	{
		get
		{
			return _ToolStripMenuItem29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem29 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem30
	{
		get
		{
			return _ToolStripMenuItem30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem30 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem31
	{
		get
		{
			return _ToolStripMenuItem31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem31 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem32
	{
		get
		{
			return _ToolStripMenuItem32;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem32 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator14
	{
		get
		{
			return _ToolStripSeparator14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator14 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem33
	{
		get
		{
			return _ToolStripMenuItem33;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem33 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator15
	{
		get
		{
			return _ToolStripSeparator15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator15 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton1
	{
		get
		{
			return _ToolStripButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton1 = value;
		}
	}

	internal virtual StatusStrip StatusStrip1
	{
		get
		{
			return _StatusStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_StatusStrip1 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel1
	{
		get
		{
			return _ToolStripStatusLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripStatusLabel1 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton2
	{
		get
		{
			return _ToolStripButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton2 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton3
	{
		get
		{
			return _ToolStripButton3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton3 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator16
	{
		get
		{
			return _ToolStripSeparator16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator16 = value;
		}
	}

	internal virtual ToolStrip ToolStrip1
	{
		get
		{
			return _ToolStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStrip1 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton4
	{
		get
		{
			return _ToolStripButton4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton4 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton5
	{
		get
		{
			return _ToolStripButton5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton5 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton6
	{
		get
		{
			return _ToolStripButton6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton6 = value;
		}
	}

	internal virtual ToolTip ToolTip1
	{
		get
		{
			return _ToolTip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolTip1 = value;
		}
	}

	internal virtual MenuStrip MenuStrip2
	{
		get
		{
			return _MenuStrip2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MenuStrip2 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem34
	{
		get
		{
			return _ToolStripMenuItem34;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem34 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem35
	{
		get
		{
			return _ToolStripMenuItem35;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem35 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem36
	{
		get
		{
			return _ToolStripMenuItem36;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem36 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator17
	{
		get
		{
			return _ToolStripSeparator17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator17 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem37
	{
		get
		{
			return _ToolStripMenuItem37;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem37 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem38
	{
		get
		{
			return _ToolStripMenuItem38;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem38 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator18
	{
		get
		{
			return _ToolStripSeparator18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator18 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem39
	{
		get
		{
			return _ToolStripMenuItem39;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem39 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem40
	{
		get
		{
			return _ToolStripMenuItem40;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem40 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem41
	{
		get
		{
			return _ToolStripMenuItem41;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem41 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator19
	{
		get
		{
			return _ToolStripSeparator19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator19 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem42
	{
		get
		{
			return _ToolStripMenuItem42;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem42 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem43
	{
		get
		{
			return _ToolStripMenuItem43;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem43 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem44
	{
		get
		{
			return _ToolStripMenuItem44;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem44 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem45
	{
		get
		{
			return _ToolStripMenuItem45;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem45 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator20
	{
		get
		{
			return _ToolStripSeparator20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator20 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem46
	{
		get
		{
			return _ToolStripMenuItem46;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem46 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem47
	{
		get
		{
			return _ToolStripMenuItem47;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem47 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem48
	{
		get
		{
			return _ToolStripMenuItem48;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem48 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator21
	{
		get
		{
			return _ToolStripSeparator21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator21 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem49
	{
		get
		{
			return _ToolStripMenuItem49;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem49 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem50
	{
		get
		{
			return _ToolStripMenuItem50;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem50 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem51
	{
		get
		{
			return _ToolStripMenuItem51;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem51 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem52
	{
		get
		{
			return _ToolStripMenuItem52;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem52 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem53
	{
		get
		{
			return _ToolStripMenuItem53;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem53 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem54
	{
		get
		{
			return _ToolStripMenuItem54;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem54 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem55
	{
		get
		{
			return _ToolStripMenuItem55;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem55 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem56
	{
		get
		{
			return _ToolStripMenuItem56;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem56 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem57
	{
		get
		{
			return _ToolStripMenuItem57;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem57 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem58
	{
		get
		{
			return _ToolStripMenuItem58;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem58 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem59
	{
		get
		{
			return _ToolStripMenuItem59;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem59 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem60
	{
		get
		{
			return _ToolStripMenuItem60;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem60 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem61
	{
		get
		{
			return _ToolStripMenuItem61;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem61 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem62
	{
		get
		{
			return _ToolStripMenuItem62;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem62 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem63
	{
		get
		{
			return _ToolStripMenuItem63;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem63 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem64
	{
		get
		{
			return _ToolStripMenuItem64;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem64 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem65
	{
		get
		{
			return _ToolStripMenuItem65;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem65 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator22
	{
		get
		{
			return _ToolStripSeparator22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator22 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem66
	{
		get
		{
			return _ToolStripMenuItem66;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem66 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator23
	{
		get
		{
			return _ToolStripSeparator23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator23 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton7
	{
		get
		{
			return _ToolStripButton7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton7 = value;
		}
	}

	internal virtual StatusStrip StatusStrip2
	{
		get
		{
			return _StatusStrip2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_StatusStrip2 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel2
	{
		get
		{
			return _ToolStripStatusLabel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripStatusLabel2 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton8
	{
		get
		{
			return _ToolStripButton8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton8 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton9
	{
		get
		{
			return _ToolStripButton9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton9 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator24
	{
		get
		{
			return _ToolStripSeparator24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator24 = value;
		}
	}

	internal virtual ToolStrip ToolStrip2
	{
		get
		{
			return _ToolStrip2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStrip2 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton10
	{
		get
		{
			return _ToolStripButton10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton10 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton11
	{
		get
		{
			return _ToolStripButton11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton11 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton12
	{
		get
		{
			return _ToolStripButton12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton12 = value;
		}
	}

	internal virtual ToolTip ToolTip2
	{
		get
		{
			return _ToolTip2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolTip2 = value;
		}
	}

	internal virtual MenuStrip MenuStrip3
	{
		get
		{
			return _MenuStrip3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MenuStrip3 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem67
	{
		get
		{
			return _ToolStripMenuItem67;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem67 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem68
	{
		get
		{
			return _ToolStripMenuItem68;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem68 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem69
	{
		get
		{
			return _ToolStripMenuItem69;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem69 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator25
	{
		get
		{
			return _ToolStripSeparator25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator25 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem70
	{
		get
		{
			return _ToolStripMenuItem70;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem70 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem71
	{
		get
		{
			return _ToolStripMenuItem71;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem71 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator26
	{
		get
		{
			return _ToolStripSeparator26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator26 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem72
	{
		get
		{
			return _ToolStripMenuItem72;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem72 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem73
	{
		get
		{
			return _ToolStripMenuItem73;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem73 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem74
	{
		get
		{
			return _ToolStripMenuItem74;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem74 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator27
	{
		get
		{
			return _ToolStripSeparator27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator27 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem75
	{
		get
		{
			return _ToolStripMenuItem75;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem75 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem76
	{
		get
		{
			return _ToolStripMenuItem76;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem76 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem77
	{
		get
		{
			return _ToolStripMenuItem77;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem77 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem78
	{
		get
		{
			return _ToolStripMenuItem78;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem78 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator28
	{
		get
		{
			return _ToolStripSeparator28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator28 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem79
	{
		get
		{
			return _ToolStripMenuItem79;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem79 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem80
	{
		get
		{
			return _ToolStripMenuItem80;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem80 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem81
	{
		get
		{
			return _ToolStripMenuItem81;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem81 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator29
	{
		get
		{
			return _ToolStripSeparator29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator29 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem82
	{
		get
		{
			return _ToolStripMenuItem82;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem82 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem83
	{
		get
		{
			return _ToolStripMenuItem83;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem83 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem84
	{
		get
		{
			return _ToolStripMenuItem84;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem84 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem85
	{
		get
		{
			return _ToolStripMenuItem85;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem85 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem86
	{
		get
		{
			return _ToolStripMenuItem86;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem86 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem87
	{
		get
		{
			return _ToolStripMenuItem87;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem87 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem88
	{
		get
		{
			return _ToolStripMenuItem88;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem88 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem89
	{
		get
		{
			return _ToolStripMenuItem89;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem89 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem90
	{
		get
		{
			return _ToolStripMenuItem90;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem90 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem91
	{
		get
		{
			return _ToolStripMenuItem91;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem91 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem92
	{
		get
		{
			return _ToolStripMenuItem92;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem92 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem93
	{
		get
		{
			return _ToolStripMenuItem93;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem93 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem94
	{
		get
		{
			return _ToolStripMenuItem94;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem94 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem95
	{
		get
		{
			return _ToolStripMenuItem95;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem95 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem96
	{
		get
		{
			return _ToolStripMenuItem96;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem96 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem97
	{
		get
		{
			return _ToolStripMenuItem97;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem97 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem98
	{
		get
		{
			return _ToolStripMenuItem98;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem98 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator30
	{
		get
		{
			return _ToolStripSeparator30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator30 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem99
	{
		get
		{
			return _ToolStripMenuItem99;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem99 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator31
	{
		get
		{
			return _ToolStripSeparator31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator31 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton13
	{
		get
		{
			return _ToolStripButton13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton13 = value;
		}
	}

	internal virtual StatusStrip StatusStrip3
	{
		get
		{
			return _StatusStrip3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_StatusStrip3 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel3
	{
		get
		{
			return _ToolStripStatusLabel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripStatusLabel3 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton14
	{
		get
		{
			return _ToolStripButton14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton14 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton15
	{
		get
		{
			return _ToolStripButton15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton15 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator32
	{
		get
		{
			return _ToolStripSeparator32;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator32 = value;
		}
	}

	internal virtual ToolStrip ToolStrip3
	{
		get
		{
			return _ToolStrip3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStrip3 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton16
	{
		get
		{
			return _ToolStripButton16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton16 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton17
	{
		get
		{
			return _ToolStripButton17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton17 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton18
	{
		get
		{
			return _ToolStripButton18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton18 = value;
		}
	}

	internal virtual ToolTip ToolTip3
	{
		get
		{
			return _ToolTip3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolTip3 = value;
		}
	}

	internal virtual MenuStrip MenuStrip4
	{
		get
		{
			return _MenuStrip4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MenuStrip4 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem100
	{
		get
		{
			return _ToolStripMenuItem100;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem100 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem101
	{
		get
		{
			return _ToolStripMenuItem101;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem101 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem102
	{
		get
		{
			return _ToolStripMenuItem102;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem102 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator33
	{
		get
		{
			return _ToolStripSeparator33;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator33 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem103
	{
		get
		{
			return _ToolStripMenuItem103;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem103 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem104
	{
		get
		{
			return _ToolStripMenuItem104;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem104 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator34
	{
		get
		{
			return _ToolStripSeparator34;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator34 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem105
	{
		get
		{
			return _ToolStripMenuItem105;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem105 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem106
	{
		get
		{
			return _ToolStripMenuItem106;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem106 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem107
	{
		get
		{
			return _ToolStripMenuItem107;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem107 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator35
	{
		get
		{
			return _ToolStripSeparator35;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator35 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem108
	{
		get
		{
			return _ToolStripMenuItem108;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem108 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem109
	{
		get
		{
			return _ToolStripMenuItem109;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem109 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem110
	{
		get
		{
			return _ToolStripMenuItem110;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem110 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem111
	{
		get
		{
			return _ToolStripMenuItem111;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem111 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator36
	{
		get
		{
			return _ToolStripSeparator36;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator36 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem112
	{
		get
		{
			return _ToolStripMenuItem112;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem112 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem113
	{
		get
		{
			return _ToolStripMenuItem113;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem113 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem114
	{
		get
		{
			return _ToolStripMenuItem114;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem114 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator37
	{
		get
		{
			return _ToolStripSeparator37;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator37 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem115
	{
		get
		{
			return _ToolStripMenuItem115;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem115 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem116
	{
		get
		{
			return _ToolStripMenuItem116;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem116 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem117
	{
		get
		{
			return _ToolStripMenuItem117;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem117 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem118
	{
		get
		{
			return _ToolStripMenuItem118;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem118 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem119
	{
		get
		{
			return _ToolStripMenuItem119;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem119 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem120
	{
		get
		{
			return _ToolStripMenuItem120;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem120 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem121
	{
		get
		{
			return _ToolStripMenuItem121;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem121 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem122
	{
		get
		{
			return _ToolStripMenuItem122;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem122 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem123
	{
		get
		{
			return _ToolStripMenuItem123;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem123 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem124
	{
		get
		{
			return _ToolStripMenuItem124;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem124 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem125
	{
		get
		{
			return _ToolStripMenuItem125;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem125 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem126
	{
		get
		{
			return _ToolStripMenuItem126;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem126 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem127
	{
		get
		{
			return _ToolStripMenuItem127;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem127 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem128
	{
		get
		{
			return _ToolStripMenuItem128;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem128 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem129
	{
		get
		{
			return _ToolStripMenuItem129;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem129 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem130
	{
		get
		{
			return _ToolStripMenuItem130;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem130 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem131
	{
		get
		{
			return _ToolStripMenuItem131;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem131 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator38
	{
		get
		{
			return _ToolStripSeparator38;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator38 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem132
	{
		get
		{
			return _ToolStripMenuItem132;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem132 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator39
	{
		get
		{
			return _ToolStripSeparator39;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator39 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton19
	{
		get
		{
			return _ToolStripButton19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton19 = value;
		}
	}

	internal virtual StatusStrip StatusStrip4
	{
		get
		{
			return _StatusStrip4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_StatusStrip4 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel4
	{
		get
		{
			return _ToolStripStatusLabel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripStatusLabel4 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton20
	{
		get
		{
			return _ToolStripButton20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton20 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton21
	{
		get
		{
			return _ToolStripButton21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton21 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator40
	{
		get
		{
			return _ToolStripSeparator40;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator40 = value;
		}
	}

	internal virtual ToolStrip ToolStrip4
	{
		get
		{
			return _ToolStrip4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStrip4 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton22
	{
		get
		{
			return _ToolStripButton22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton22 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton23
	{
		get
		{
			return _ToolStripButton23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton23 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton24
	{
		get
		{
			return _ToolStripButton24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton24 = value;
		}
	}

	internal virtual ToolTip ToolTip4
	{
		get
		{
			return _ToolTip4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolTip4 = value;
		}
	}

	internal virtual MenuStrip MenuStrip5
	{
		get
		{
			return _MenuStrip5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MenuStrip5 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem133
	{
		get
		{
			return _ToolStripMenuItem133;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem133 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem134
	{
		get
		{
			return _ToolStripMenuItem134;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem134 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem135
	{
		get
		{
			return _ToolStripMenuItem135;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem135 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator41
	{
		get
		{
			return _ToolStripSeparator41;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator41 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem136
	{
		get
		{
			return _ToolStripMenuItem136;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem136 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem137
	{
		get
		{
			return _ToolStripMenuItem137;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem137 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator42
	{
		get
		{
			return _ToolStripSeparator42;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator42 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem138
	{
		get
		{
			return _ToolStripMenuItem138;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem138 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem139
	{
		get
		{
			return _ToolStripMenuItem139;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem139 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem140
	{
		get
		{
			return _ToolStripMenuItem140;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem140 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator43
	{
		get
		{
			return _ToolStripSeparator43;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator43 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem141
	{
		get
		{
			return _ToolStripMenuItem141;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem141 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem142
	{
		get
		{
			return _ToolStripMenuItem142;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem142 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem143
	{
		get
		{
			return _ToolStripMenuItem143;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem143 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem144
	{
		get
		{
			return _ToolStripMenuItem144;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem144 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator44
	{
		get
		{
			return _ToolStripSeparator44;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator44 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem145
	{
		get
		{
			return _ToolStripMenuItem145;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem145 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem146
	{
		get
		{
			return _ToolStripMenuItem146;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem146 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem147
	{
		get
		{
			return _ToolStripMenuItem147;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem147 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator45
	{
		get
		{
			return _ToolStripSeparator45;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator45 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem148
	{
		get
		{
			return _ToolStripMenuItem148;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem148 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem149
	{
		get
		{
			return _ToolStripMenuItem149;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem149 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem150
	{
		get
		{
			return _ToolStripMenuItem150;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem150 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem151
	{
		get
		{
			return _ToolStripMenuItem151;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem151 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem152
	{
		get
		{
			return _ToolStripMenuItem152;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem152 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem153
	{
		get
		{
			return _ToolStripMenuItem153;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem153 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem154
	{
		get
		{
			return _ToolStripMenuItem154;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem154 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem155
	{
		get
		{
			return _ToolStripMenuItem155;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem155 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem156
	{
		get
		{
			return _ToolStripMenuItem156;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem156 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem157
	{
		get
		{
			return _ToolStripMenuItem157;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem157 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem158
	{
		get
		{
			return _ToolStripMenuItem158;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem158 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem159
	{
		get
		{
			return _ToolStripMenuItem159;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem159 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem160
	{
		get
		{
			return _ToolStripMenuItem160;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem160 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem161
	{
		get
		{
			return _ToolStripMenuItem161;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem161 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem162
	{
		get
		{
			return _ToolStripMenuItem162;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem162 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem163
	{
		get
		{
			return _ToolStripMenuItem163;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem163 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem164
	{
		get
		{
			return _ToolStripMenuItem164;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem164 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator46
	{
		get
		{
			return _ToolStripSeparator46;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator46 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem165
	{
		get
		{
			return _ToolStripMenuItem165;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem165 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator47
	{
		get
		{
			return _ToolStripSeparator47;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator47 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton25
	{
		get
		{
			return _ToolStripButton25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton25 = value;
		}
	}

	internal virtual StatusStrip StatusStrip5
	{
		get
		{
			return _StatusStrip5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_StatusStrip5 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel5
	{
		get
		{
			return _ToolStripStatusLabel5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripStatusLabel5 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton26
	{
		get
		{
			return _ToolStripButton26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton26 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton27
	{
		get
		{
			return _ToolStripButton27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton27 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator48
	{
		get
		{
			return _ToolStripSeparator48;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator48 = value;
		}
	}

	internal virtual ToolStrip ToolStrip5
	{
		get
		{
			return _ToolStrip5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStrip5 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton28
	{
		get
		{
			return _ToolStripButton28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton28 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton29
	{
		get
		{
			return _ToolStripButton29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton29 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton30
	{
		get
		{
			return _ToolStripButton30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton30 = value;
		}
	}

	internal virtual ToolTip ToolTip5
	{
		get
		{
			return _ToolTip5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolTip5 = value;
		}
	}

	internal virtual MenuStrip MenuStrip6
	{
		get
		{
			return _MenuStrip6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MenuStrip6 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem166
	{
		get
		{
			return _ToolStripMenuItem166;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem166 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem167
	{
		get
		{
			return _ToolStripMenuItem167;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem167 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem168
	{
		get
		{
			return _ToolStripMenuItem168;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem168 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator49
	{
		get
		{
			return _ToolStripSeparator49;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator49 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem169
	{
		get
		{
			return _ToolStripMenuItem169;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem169 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem170
	{
		get
		{
			return _ToolStripMenuItem170;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem170 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator50
	{
		get
		{
			return _ToolStripSeparator50;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator50 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem171
	{
		get
		{
			return _ToolStripMenuItem171;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem171 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem172
	{
		get
		{
			return _ToolStripMenuItem172;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem172 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem173
	{
		get
		{
			return _ToolStripMenuItem173;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem173 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator51
	{
		get
		{
			return _ToolStripSeparator51;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator51 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem174
	{
		get
		{
			return _ToolStripMenuItem174;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem174 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem175
	{
		get
		{
			return _ToolStripMenuItem175;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem175 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem176
	{
		get
		{
			return _ToolStripMenuItem176;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem176 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem177
	{
		get
		{
			return _ToolStripMenuItem177;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem177 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator52
	{
		get
		{
			return _ToolStripSeparator52;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator52 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem178
	{
		get
		{
			return _ToolStripMenuItem178;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem178 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem179
	{
		get
		{
			return _ToolStripMenuItem179;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem179 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem180
	{
		get
		{
			return _ToolStripMenuItem180;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem180 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator53
	{
		get
		{
			return _ToolStripSeparator53;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator53 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem181
	{
		get
		{
			return _ToolStripMenuItem181;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem181 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem182
	{
		get
		{
			return _ToolStripMenuItem182;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem182 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem183
	{
		get
		{
			return _ToolStripMenuItem183;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem183 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem184
	{
		get
		{
			return _ToolStripMenuItem184;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem184 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem185
	{
		get
		{
			return _ToolStripMenuItem185;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem185 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem186
	{
		get
		{
			return _ToolStripMenuItem186;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem186 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem187
	{
		get
		{
			return _ToolStripMenuItem187;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem187 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem188
	{
		get
		{
			return _ToolStripMenuItem188;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem188 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem189
	{
		get
		{
			return _ToolStripMenuItem189;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem189 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem190
	{
		get
		{
			return _ToolStripMenuItem190;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem190 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem191
	{
		get
		{
			return _ToolStripMenuItem191;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem191 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem192
	{
		get
		{
			return _ToolStripMenuItem192;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem192 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem193
	{
		get
		{
			return _ToolStripMenuItem193;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem193 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem194
	{
		get
		{
			return _ToolStripMenuItem194;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem194 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem195
	{
		get
		{
			return _ToolStripMenuItem195;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem195 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem196
	{
		get
		{
			return _ToolStripMenuItem196;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem196 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem197
	{
		get
		{
			return _ToolStripMenuItem197;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem197 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator54
	{
		get
		{
			return _ToolStripSeparator54;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator54 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem198
	{
		get
		{
			return _ToolStripMenuItem198;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem198 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator55
	{
		get
		{
			return _ToolStripSeparator55;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator55 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton31
	{
		get
		{
			return _ToolStripButton31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton31 = value;
		}
	}

	internal virtual StatusStrip StatusStrip6
	{
		get
		{
			return _StatusStrip6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_StatusStrip6 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel6
	{
		get
		{
			return _ToolStripStatusLabel6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripStatusLabel6 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton32
	{
		get
		{
			return _ToolStripButton32;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton32 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton33
	{
		get
		{
			return _ToolStripButton33;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton33 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator56
	{
		get
		{
			return _ToolStripSeparator56;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator56 = value;
		}
	}

	internal virtual ToolStrip ToolStrip6
	{
		get
		{
			return _ToolStrip6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStrip6 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton34
	{
		get
		{
			return _ToolStripButton34;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton34 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton35
	{
		get
		{
			return _ToolStripButton35;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton35 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton36
	{
		get
		{
			return _ToolStripButton36;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton36 = value;
		}
	}

	internal virtual ToolTip ToolTip6
	{
		get
		{
			return _ToolTip6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolTip6 = value;
		}
	}

	public MDIParent1()
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected O, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected O, but got Unknown
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected O, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected O, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected O, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected O, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected O, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected O, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected O, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected O, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected O, but got Unknown
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected O, but got Unknown
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected O, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected O, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected O, but got Unknown
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected O, but got Unknown
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Expected O, but got Unknown
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected O, but got Unknown
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected O, but got Unknown
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected O, but got Unknown
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Expected O, but got Unknown
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Expected O, but got Unknown
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected O, but got Unknown
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected O, but got Unknown
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Expected O, but got Unknown
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected O, but got Unknown
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected O, but got Unknown
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Expected O, but got Unknown
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Expected O, but got Unknown
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Expected O, but got Unknown
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected O, but got Unknown
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected O, but got Unknown
		//IL_055b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Expected O, but got Unknown
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected O, but got Unknown
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected O, but got Unknown
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Expected O, but got Unknown
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Expected O, but got Unknown
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected O, but got Unknown
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Expected O, but got Unknown
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Expected O, but got Unknown
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Expected O, but got Unknown
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected O, but got Unknown
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d3: Expected O, but got Unknown
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Expected O, but got Unknown
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Expected O, but got Unknown
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Expected O, but got Unknown
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Expected O, but got Unknown
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected O, but got Unknown
		//IL_060b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Expected O, but got Unknown
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected O, but got Unknown
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_062b: Expected O, but got Unknown
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected O, but got Unknown
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Expected O, but got Unknown
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Expected O, but got Unknown
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Expected O, but got Unknown
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_0662: Expected O, but got Unknown
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_066d: Expected O, but got Unknown
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Expected O, but got Unknown
		//IL_0679: Unknown result type (might be due to invalid IL or missing references)
		//IL_0683: Expected O, but got Unknown
		//IL_0684: Unknown result type (might be due to invalid IL or missing references)
		//IL_068e: Expected O, but got Unknown
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Expected O, but got Unknown
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Expected O, but got Unknown
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06af: Expected O, but got Unknown
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Expected O, but got Unknown
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Expected O, but got Unknown
		//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Expected O, but got Unknown
		//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e1: Expected O, but got Unknown
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Expected O, but got Unknown
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected O, but got Unknown
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0702: Expected O, but got Unknown
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Expected O, but got Unknown
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0718: Expected O, but got Unknown
		//IL_0719: Unknown result type (might be due to invalid IL or missing references)
		//IL_0723: Expected O, but got Unknown
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		//IL_072e: Expected O, but got Unknown
		//IL_072f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0739: Expected O, but got Unknown
		//IL_073a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Expected O, but got Unknown
		//IL_0745: Unknown result type (might be due to invalid IL or missing references)
		//IL_074f: Expected O, but got Unknown
		//IL_0750: Unknown result type (might be due to invalid IL or missing references)
		//IL_075a: Expected O, but got Unknown
		//IL_075b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Expected O, but got Unknown
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0771: Unknown result type (might be due to invalid IL or missing references)
		//IL_077b: Expected O, but got Unknown
		//IL_077c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0786: Expected O, but got Unknown
		//IL_0787: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Expected O, but got Unknown
		//IL_0792: Unknown result type (might be due to invalid IL or missing references)
		//IL_079c: Expected O, but got Unknown
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a7: Expected O, but got Unknown
		//IL_07a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b2: Expected O, but got Unknown
		//IL_07b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Expected O, but got Unknown
		//IL_07be: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c8: Expected O, but got Unknown
		//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d3: Expected O, but got Unknown
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07de: Expected O, but got Unknown
		//IL_07df: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Expected O, but got Unknown
		//IL_07ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f4: Expected O, but got Unknown
		//IL_07f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ff: Expected O, but got Unknown
		//IL_0800: Unknown result type (might be due to invalid IL or missing references)
		//IL_080a: Expected O, but got Unknown
		//IL_080b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0815: Expected O, but got Unknown
		//IL_0816: Unknown result type (might be due to invalid IL or missing references)
		//IL_0820: Expected O, but got Unknown
		//IL_0821: Unknown result type (might be due to invalid IL or missing references)
		//IL_082b: Expected O, but got Unknown
		//IL_082c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0836: Expected O, but got Unknown
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_0841: Expected O, but got Unknown
		//IL_0842: Unknown result type (might be due to invalid IL or missing references)
		//IL_084c: Expected O, but got Unknown
		//IL_084d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0857: Expected O, but got Unknown
		//IL_0858: Unknown result type (might be due to invalid IL or missing references)
		//IL_0862: Expected O, but got Unknown
		//IL_0863: Unknown result type (might be due to invalid IL or missing references)
		//IL_086d: Expected O, but got Unknown
		//IL_086e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0878: Expected O, but got Unknown
		//IL_0879: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Expected O, but got Unknown
		//IL_0884: Unknown result type (might be due to invalid IL or missing references)
		//IL_088e: Expected O, but got Unknown
		//IL_088f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0899: Expected O, but got Unknown
		//IL_089a: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a4: Expected O, but got Unknown
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08af: Expected O, but got Unknown
		//IL_08b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ba: Expected O, but got Unknown
		//IL_08bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c5: Expected O, but got Unknown
		//IL_08c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d0: Expected O, but got Unknown
		//IL_08d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08db: Expected O, but got Unknown
		//IL_08dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e6: Expected O, but got Unknown
		//IL_08e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f1: Expected O, but got Unknown
		//IL_08f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fc: Expected O, but got Unknown
		//IL_08fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0907: Expected O, but got Unknown
		//IL_0908: Unknown result type (might be due to invalid IL or missing references)
		//IL_0912: Expected O, but got Unknown
		//IL_0919: Unknown result type (might be due to invalid IL or missing references)
		//IL_0923: Expected O, but got Unknown
		//IL_0924: Unknown result type (might be due to invalid IL or missing references)
		//IL_092e: Expected O, but got Unknown
		//IL_092f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0939: Expected O, but got Unknown
		//IL_093a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0944: Expected O, but got Unknown
		//IL_0945: Unknown result type (might be due to invalid IL or missing references)
		//IL_094f: Expected O, but got Unknown
		//IL_0950: Unknown result type (might be due to invalid IL or missing references)
		//IL_095a: Expected O, but got Unknown
		//IL_095b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0965: Expected O, but got Unknown
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		//IL_0970: Expected O, but got Unknown
		//IL_0971: Unknown result type (might be due to invalid IL or missing references)
		//IL_097b: Expected O, but got Unknown
		//IL_097c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0986: Expected O, but got Unknown
		//IL_0987: Unknown result type (might be due to invalid IL or missing references)
		//IL_0991: Expected O, but got Unknown
		//IL_0992: Unknown result type (might be due to invalid IL or missing references)
		//IL_099c: Expected O, but got Unknown
		//IL_099d: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a7: Expected O, but got Unknown
		//IL_09a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Expected O, but got Unknown
		//IL_09b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bd: Expected O, but got Unknown
		//IL_09be: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c8: Expected O, but got Unknown
		//IL_09c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d3: Expected O, but got Unknown
		//IL_09d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09de: Expected O, but got Unknown
		//IL_09df: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e9: Expected O, but got Unknown
		//IL_09ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f4: Expected O, but got Unknown
		//IL_09f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ff: Expected O, but got Unknown
		//IL_0a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0a: Expected O, but got Unknown
		//IL_0a0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a15: Expected O, but got Unknown
		//IL_0a16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a20: Expected O, but got Unknown
		//IL_0a21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2b: Expected O, but got Unknown
		//IL_0a2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a36: Expected O, but got Unknown
		//IL_0a37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a41: Expected O, but got Unknown
		//IL_0a42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4c: Expected O, but got Unknown
		//IL_0a4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a57: Expected O, but got Unknown
		//IL_0a58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a62: Expected O, but got Unknown
		//IL_0a63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6d: Expected O, but got Unknown
		//IL_0a6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a78: Expected O, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a83: Expected O, but got Unknown
		//IL_0a84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8e: Expected O, but got Unknown
		//IL_0a8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a99: Expected O, but got Unknown
		//IL_0a9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa4: Expected O, but got Unknown
		//IL_0aa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaf: Expected O, but got Unknown
		//IL_0ab0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aba: Expected O, but got Unknown
		//IL_0abb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac5: Expected O, but got Unknown
		//IL_0ac6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad0: Expected O, but got Unknown
		//IL_0ad1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adb: Expected O, but got Unknown
		//IL_0adc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae6: Expected O, but got Unknown
		//IL_0ae7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af1: Expected O, but got Unknown
		//IL_0af2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afc: Expected O, but got Unknown
		//IL_0afd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b07: Expected O, but got Unknown
		//IL_0b08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b12: Expected O, but got Unknown
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1d: Expected O, but got Unknown
		//IL_0b1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b28: Expected O, but got Unknown
		//IL_0b29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b33: Expected O, but got Unknown
		//IL_0b34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3e: Expected O, but got Unknown
		//IL_0b3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b49: Expected O, but got Unknown
		//IL_0b4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b54: Expected O, but got Unknown
		//IL_0b5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b65: Expected O, but got Unknown
		//IL_0b66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b70: Expected O, but got Unknown
		//IL_0b71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7b: Expected O, but got Unknown
		//IL_0b7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b86: Expected O, but got Unknown
		//IL_0b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b91: Expected O, but got Unknown
		//IL_0b92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9c: Expected O, but got Unknown
		//IL_0b9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba7: Expected O, but got Unknown
		//IL_0ba8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb2: Expected O, but got Unknown
		//IL_0bb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbd: Expected O, but got Unknown
		//IL_0bbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc8: Expected O, but got Unknown
		//IL_0bc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd3: Expected O, but got Unknown
		//IL_0bd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bde: Expected O, but got Unknown
		//IL_0bdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be9: Expected O, but got Unknown
		//IL_0bea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf4: Expected O, but got Unknown
		//IL_0bf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bff: Expected O, but got Unknown
		//IL_0c00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0a: Expected O, but got Unknown
		//IL_0c0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c15: Expected O, but got Unknown
		//IL_0c16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c20: Expected O, but got Unknown
		//IL_0c21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2b: Expected O, but got Unknown
		//IL_0c2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c36: Expected O, but got Unknown
		//IL_0c37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c41: Expected O, but got Unknown
		//IL_0c42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4c: Expected O, but got Unknown
		//IL_0c4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c57: Expected O, but got Unknown
		//IL_0c58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c62: Expected O, but got Unknown
		//IL_0c63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6d: Expected O, but got Unknown
		//IL_0c6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c78: Expected O, but got Unknown
		//IL_0c79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c83: Expected O, but got Unknown
		//IL_0c84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8e: Expected O, but got Unknown
		//IL_0c8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c99: Expected O, but got Unknown
		//IL_0c9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca4: Expected O, but got Unknown
		//IL_0ca5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caf: Expected O, but got Unknown
		//IL_0cb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cba: Expected O, but got Unknown
		//IL_0cbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc5: Expected O, but got Unknown
		//IL_0cc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd0: Expected O, but got Unknown
		//IL_0cd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdb: Expected O, but got Unknown
		//IL_0cdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce6: Expected O, but got Unknown
		//IL_0ce7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf1: Expected O, but got Unknown
		//IL_0cf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfc: Expected O, but got Unknown
		//IL_0cfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d07: Expected O, but got Unknown
		//IL_0d08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d12: Expected O, but got Unknown
		//IL_0d13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1d: Expected O, but got Unknown
		//IL_0d1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d28: Expected O, but got Unknown
		//IL_0d29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d33: Expected O, but got Unknown
		//IL_0d34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3e: Expected O, but got Unknown
		//IL_0d3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d49: Expected O, but got Unknown
		//IL_0d4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d54: Expected O, but got Unknown
		//IL_0d55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5f: Expected O, but got Unknown
		//IL_0d60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6a: Expected O, but got Unknown
		//IL_0d6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d75: Expected O, but got Unknown
		//IL_0d76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d80: Expected O, but got Unknown
		//IL_0d81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8b: Expected O, but got Unknown
		//IL_0d8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d96: Expected O, but got Unknown
		//IL_0d9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected O, but got Unknown
		//IL_0da8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db2: Expected O, but got Unknown
		//IL_0db3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbd: Expected O, but got Unknown
		//IL_0dbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc8: Expected O, but got Unknown
		//IL_0dc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd3: Expected O, but got Unknown
		//IL_0dd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dde: Expected O, but got Unknown
		//IL_0ddf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de9: Expected O, but got Unknown
		//IL_0dea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df4: Expected O, but got Unknown
		//IL_0df5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dff: Expected O, but got Unknown
		//IL_0e00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0a: Expected O, but got Unknown
		//IL_0e0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e15: Expected O, but got Unknown
		//IL_0e16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e20: Expected O, but got Unknown
		//IL_0e21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2b: Expected O, but got Unknown
		//IL_0e2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e36: Expected O, but got Unknown
		//IL_0e37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e41: Expected O, but got Unknown
		//IL_0e42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4c: Expected O, but got Unknown
		//IL_0e4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e57: Expected O, but got Unknown
		//IL_0e58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e62: Expected O, but got Unknown
		//IL_0e63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6d: Expected O, but got Unknown
		//IL_0e6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e78: Expected O, but got Unknown
		//IL_0e79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e83: Expected O, but got Unknown
		//IL_0e84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8e: Expected O, but got Unknown
		//IL_0e8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e99: Expected O, but got Unknown
		//IL_0e9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea4: Expected O, but got Unknown
		//IL_0ea5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eaf: Expected O, but got Unknown
		//IL_0eb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eba: Expected O, but got Unknown
		//IL_0ebb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec5: Expected O, but got Unknown
		//IL_0ec6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed0: Expected O, but got Unknown
		//IL_0ed1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0edb: Expected O, but got Unknown
		//IL_0edc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee6: Expected O, but got Unknown
		//IL_0ee7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef1: Expected O, but got Unknown
		//IL_0ef2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efc: Expected O, but got Unknown
		//IL_0efd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f07: Expected O, but got Unknown
		//IL_0f08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f12: Expected O, but got Unknown
		//IL_0f13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1d: Expected O, but got Unknown
		//IL_0f1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f28: Expected O, but got Unknown
		//IL_0f29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f33: Expected O, but got Unknown
		//IL_0f34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3e: Expected O, but got Unknown
		//IL_0f3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f49: Expected O, but got Unknown
		//IL_0f4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f54: Expected O, but got Unknown
		//IL_0f55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5f: Expected O, but got Unknown
		//IL_0f60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6a: Expected O, but got Unknown
		//IL_0f6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f75: Expected O, but got Unknown
		//IL_0f76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f80: Expected O, but got Unknown
		//IL_0f81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8b: Expected O, but got Unknown
		//IL_0f8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f96: Expected O, but got Unknown
		//IL_0f97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa1: Expected O, but got Unknown
		//IL_0fa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fac: Expected O, but got Unknown
		//IL_0fad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb7: Expected O, but got Unknown
		//IL_0fb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc2: Expected O, but got Unknown
		//IL_0fc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcd: Expected O, but got Unknown
		//IL_0fce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd8: Expected O, but got Unknown
		//IL_0fdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe9: Expected O, but got Unknown
		//IL_1268: Unknown result type (might be due to invalid IL or missing references)
		//IL_1272: Expected O, but got Unknown
		//IL_12de: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e8: Expected O, but got Unknown
		//IL_137e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1388: Expected O, but got Unknown
		//IL_1459: Unknown result type (might be due to invalid IL or missing references)
		//IL_1463: Expected O, but got Unknown
		//IL_14cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d9: Expected O, but got Unknown
		//IL_166d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1677: Expected O, but got Unknown
		//IL_16e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ed: Expected O, but got Unknown
		//IL_1783: Unknown result type (might be due to invalid IL or missing references)
		//IL_178d: Expected O, but got Unknown
		//IL_17f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1803: Expected O, but got Unknown
		//IL_186f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1879: Expected O, but got Unknown
		//IL_1dbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc5: Expected O, but got Unknown
		//IL_1e21: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e2b: Expected O, but got Unknown
		//IL_1fb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fbf: Expected O, but got Unknown
		//IL_2024: Unknown result type (might be due to invalid IL or missing references)
		//IL_202e: Expected O, but got Unknown
		//IL_2093: Unknown result type (might be due to invalid IL or missing references)
		//IL_209d: Expected O, but got Unknown
		//IL_2129: Unknown result type (might be due to invalid IL or missing references)
		//IL_2133: Expected O, but got Unknown
		//IL_2198: Unknown result type (might be due to invalid IL or missing references)
		//IL_21a2: Expected O, but got Unknown
		//IL_222e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2238: Expected O, but got Unknown
		//IL_24cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_24d7: Expected O, but got Unknown
		//IL_2543: Unknown result type (might be due to invalid IL or missing references)
		//IL_254d: Expected O, but got Unknown
		//IL_25e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_25ed: Expected O, but got Unknown
		//IL_26be: Unknown result type (might be due to invalid IL or missing references)
		//IL_26c8: Expected O, but got Unknown
		//IL_2734: Unknown result type (might be due to invalid IL or missing references)
		//IL_273e: Expected O, but got Unknown
		//IL_28d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_28dc: Expected O, but got Unknown
		//IL_2948: Unknown result type (might be due to invalid IL or missing references)
		//IL_2952: Expected O, but got Unknown
		//IL_29e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_29f2: Expected O, but got Unknown
		//IL_2a5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a68: Expected O, but got Unknown
		//IL_2ad4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ade: Expected O, but got Unknown
		//IL_3020: Unknown result type (might be due to invalid IL or missing references)
		//IL_302a: Expected O, but got Unknown
		//IL_3086: Unknown result type (might be due to invalid IL or missing references)
		//IL_3090: Expected O, but got Unknown
		//IL_3184: Unknown result type (might be due to invalid IL or missing references)
		//IL_318e: Expected O, but got Unknown
		//IL_32ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_32b7: Expected O, but got Unknown
		//IL_331c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3326: Expected O, but got Unknown
		//IL_3470: Unknown result type (might be due to invalid IL or missing references)
		//IL_347a: Expected O, but got Unknown
		//IL_34df: Unknown result type (might be due to invalid IL or missing references)
		//IL_34e9: Expected O, but got Unknown
		//IL_354e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3558: Expected O, but got Unknown
		//IL_3734: Unknown result type (might be due to invalid IL or missing references)
		//IL_373e: Expected O, but got Unknown
		//IL_37aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_37b4: Expected O, but got Unknown
		//IL_384a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3854: Expected O, but got Unknown
		//IL_3925: Unknown result type (might be due to invalid IL or missing references)
		//IL_392f: Expected O, but got Unknown
		//IL_399b: Unknown result type (might be due to invalid IL or missing references)
		//IL_39a5: Expected O, but got Unknown
		//IL_3b39: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b43: Expected O, but got Unknown
		//IL_3baf: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bb9: Expected O, but got Unknown
		//IL_3c4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c59: Expected O, but got Unknown
		//IL_3cc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ccf: Expected O, but got Unknown
		//IL_3d3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d45: Expected O, but got Unknown
		//IL_4287: Unknown result type (might be due to invalid IL or missing references)
		//IL_4291: Expected O, but got Unknown
		//IL_42ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_42f7: Expected O, but got Unknown
		//IL_43eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_43f5: Expected O, but got Unknown
		//IL_4514: Unknown result type (might be due to invalid IL or missing references)
		//IL_451e: Expected O, but got Unknown
		//IL_4583: Unknown result type (might be due to invalid IL or missing references)
		//IL_458d: Expected O, but got Unknown
		//IL_46d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_46e1: Expected O, but got Unknown
		//IL_4746: Unknown result type (might be due to invalid IL or missing references)
		//IL_4750: Expected O, but got Unknown
		//IL_47b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_47bf: Expected O, but got Unknown
		//IL_499e: Unknown result type (might be due to invalid IL or missing references)
		//IL_49a8: Expected O, but got Unknown
		//IL_4a14: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a1e: Expected O, but got Unknown
		//IL_4ab4: Unknown result type (might be due to invalid IL or missing references)
		//IL_4abe: Expected O, but got Unknown
		//IL_4b8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b99: Expected O, but got Unknown
		//IL_4c05: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c0f: Expected O, but got Unknown
		//IL_4da3: Unknown result type (might be due to invalid IL or missing references)
		//IL_4dad: Expected O, but got Unknown
		//IL_4e19: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e23: Expected O, but got Unknown
		//IL_4eb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ec3: Expected O, but got Unknown
		//IL_4f2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f39: Expected O, but got Unknown
		//IL_4fa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_4faf: Expected O, but got Unknown
		//IL_54f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_54fb: Expected O, but got Unknown
		//IL_5557: Unknown result type (might be due to invalid IL or missing references)
		//IL_5561: Expected O, but got Unknown
		//IL_5655: Unknown result type (might be due to invalid IL or missing references)
		//IL_565f: Expected O, but got Unknown
		//IL_577e: Unknown result type (might be due to invalid IL or missing references)
		//IL_5788: Expected O, but got Unknown
		//IL_57ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_57f7: Expected O, but got Unknown
		//IL_5944: Unknown result type (might be due to invalid IL or missing references)
		//IL_594e: Expected O, but got Unknown
		//IL_59b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_59bd: Expected O, but got Unknown
		//IL_5a22: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a2c: Expected O, but got Unknown
		//IL_5c0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c15: Expected O, but got Unknown
		//IL_5c81: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c8b: Expected O, but got Unknown
		//IL_5d21: Unknown result type (might be due to invalid IL or missing references)
		//IL_5d2b: Expected O, but got Unknown
		//IL_5dfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e06: Expected O, but got Unknown
		//IL_5e72: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e7c: Expected O, but got Unknown
		//IL_6010: Unknown result type (might be due to invalid IL or missing references)
		//IL_601a: Expected O, but got Unknown
		//IL_6086: Unknown result type (might be due to invalid IL or missing references)
		//IL_6090: Expected O, but got Unknown
		//IL_6126: Unknown result type (might be due to invalid IL or missing references)
		//IL_6130: Expected O, but got Unknown
		//IL_619c: Unknown result type (might be due to invalid IL or missing references)
		//IL_61a6: Expected O, but got Unknown
		//IL_6212: Unknown result type (might be due to invalid IL or missing references)
		//IL_621c: Expected O, but got Unknown
		//IL_675e: Unknown result type (might be due to invalid IL or missing references)
		//IL_6768: Expected O, but got Unknown
		//IL_67c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_67ce: Expected O, but got Unknown
		//IL_68c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_68cc: Expected O, but got Unknown
		//IL_69eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_69f5: Expected O, but got Unknown
		//IL_6a5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_6a64: Expected O, but got Unknown
		//IL_6bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_6bbb: Expected O, but got Unknown
		//IL_6c20: Unknown result type (might be due to invalid IL or missing references)
		//IL_6c2a: Expected O, but got Unknown
		//IL_6c8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_6c99: Expected O, but got Unknown
		//IL_6e78: Unknown result type (might be due to invalid IL or missing references)
		//IL_6e82: Expected O, but got Unknown
		//IL_6eee: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ef8: Expected O, but got Unknown
		//IL_6f8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_6f98: Expected O, but got Unknown
		//IL_7069: Unknown result type (might be due to invalid IL or missing references)
		//IL_7073: Expected O, but got Unknown
		//IL_70df: Unknown result type (might be due to invalid IL or missing references)
		//IL_70e9: Expected O, but got Unknown
		//IL_727d: Unknown result type (might be due to invalid IL or missing references)
		//IL_7287: Expected O, but got Unknown
		//IL_72f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_72fd: Expected O, but got Unknown
		//IL_7393: Unknown result type (might be due to invalid IL or missing references)
		//IL_739d: Expected O, but got Unknown
		//IL_7409: Unknown result type (might be due to invalid IL or missing references)
		//IL_7413: Expected O, but got Unknown
		//IL_747f: Unknown result type (might be due to invalid IL or missing references)
		//IL_7489: Expected O, but got Unknown
		//IL_79cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_79d5: Expected O, but got Unknown
		//IL_7a31: Unknown result type (might be due to invalid IL or missing references)
		//IL_7a3b: Expected O, but got Unknown
		//IL_7b2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_7b39: Expected O, but got Unknown
		//IL_7c58: Unknown result type (might be due to invalid IL or missing references)
		//IL_7c62: Expected O, but got Unknown
		//IL_7cc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_7cd1: Expected O, but got Unknown
		//IL_7e1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_7e28: Expected O, but got Unknown
		//IL_7e8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_7e97: Expected O, but got Unknown
		//IL_7efc: Unknown result type (might be due to invalid IL or missing references)
		//IL_7f06: Expected O, but got Unknown
		//IL_80e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_80ef: Expected O, but got Unknown
		//IL_815b: Unknown result type (might be due to invalid IL or missing references)
		//IL_8165: Expected O, but got Unknown
		//IL_81fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_8205: Expected O, but got Unknown
		//IL_82d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_82e0: Expected O, but got Unknown
		//IL_834c: Unknown result type (might be due to invalid IL or missing references)
		//IL_8356: Expected O, but got Unknown
		//IL_84ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_84f4: Expected O, but got Unknown
		//IL_8560: Unknown result type (might be due to invalid IL or missing references)
		//IL_856a: Expected O, but got Unknown
		//IL_8600: Unknown result type (might be due to invalid IL or missing references)
		//IL_860a: Expected O, but got Unknown
		//IL_8676: Unknown result type (might be due to invalid IL or missing references)
		//IL_8680: Expected O, but got Unknown
		//IL_86ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_86f6: Expected O, but got Unknown
		//IL_8c38: Unknown result type (might be due to invalid IL or missing references)
		//IL_8c42: Expected O, but got Unknown
		//IL_8c9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_8ca8: Expected O, but got Unknown
		//IL_8d9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_8da6: Expected O, but got Unknown
		//IL_8ec5: Unknown result type (might be due to invalid IL or missing references)
		//IL_8ecf: Expected O, but got Unknown
		//IL_8f34: Unknown result type (might be due to invalid IL or missing references)
		//IL_8f3e: Expected O, but got Unknown
		//IL_908b: Unknown result type (might be due to invalid IL or missing references)
		//IL_9095: Expected O, but got Unknown
		//IL_90fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_9104: Expected O, but got Unknown
		//IL_9169: Unknown result type (might be due to invalid IL or missing references)
		//IL_9173: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MDIParent1));
		MenuStrip = new MenuStrip();
		FileMenu = new ToolStripMenuItem();
		NewToolStripMenuItem = new ToolStripMenuItem();
		OpenToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator3 = new ToolStripSeparator();
		SaveToolStripMenuItem = new ToolStripMenuItem();
		SaveAsToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator4 = new ToolStripSeparator();
		PrintToolStripMenuItem = new ToolStripMenuItem();
		PrintPreviewToolStripMenuItem = new ToolStripMenuItem();
		PrintSetupToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator5 = new ToolStripSeparator();
		ExitToolStripMenuItem = new ToolStripMenuItem();
		EditMenu = new ToolStripMenuItem();
		UndoToolStripMenuItem = new ToolStripMenuItem();
		RedoToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator6 = new ToolStripSeparator();
		CutToolStripMenuItem = new ToolStripMenuItem();
		CopyToolStripMenuItem = new ToolStripMenuItem();
		PasteToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator7 = new ToolStripSeparator();
		SelectAllToolStripMenuItem = new ToolStripMenuItem();
		ViewMenu = new ToolStripMenuItem();
		ToolBarToolStripMenuItem = new ToolStripMenuItem();
		StatusBarToolStripMenuItem = new ToolStripMenuItem();
		ToolsMenu = new ToolStripMenuItem();
		OptionsToolStripMenuItem = new ToolStripMenuItem();
		WindowsMenu = new ToolStripMenuItem();
		NewWindowToolStripMenuItem = new ToolStripMenuItem();
		CascadeToolStripMenuItem = new ToolStripMenuItem();
		TileVerticalToolStripMenuItem = new ToolStripMenuItem();
		TileHorizontalToolStripMenuItem = new ToolStripMenuItem();
		CloseAllToolStripMenuItem = new ToolStripMenuItem();
		ArrangeIconsToolStripMenuItem = new ToolStripMenuItem();
		HelpMenu = new ToolStripMenuItem();
		ContentsToolStripMenuItem = new ToolStripMenuItem();
		IndexToolStripMenuItem = new ToolStripMenuItem();
		SearchToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator8 = new ToolStripSeparator();
		AboutToolStripMenuItem = new ToolStripMenuItem();
		ToolStrip = new ToolStrip();
		NewToolStripButton = new ToolStripButton();
		OpenToolStripButton = new ToolStripButton();
		SaveToolStripButton = new ToolStripButton();
		ToolStripSeparator1 = new ToolStripSeparator();
		PrintToolStripButton = new ToolStripButton();
		PrintPreviewToolStripButton = new ToolStripButton();
		ToolStripSeparator2 = new ToolStripSeparator();
		HelpToolStripButton = new ToolStripButton();
		StatusStrip = new StatusStrip();
		ToolStripStatusLabel = new ToolStripStatusLabel();
		ToolTip = new ToolTip(components);
		MenuStrip1 = new MenuStrip();
		ToolStripMenuItem1 = new ToolStripMenuItem();
		ToolStripMenuItem2 = new ToolStripMenuItem();
		ToolStripMenuItem3 = new ToolStripMenuItem();
		ToolStripSeparator9 = new ToolStripSeparator();
		ToolStripMenuItem4 = new ToolStripMenuItem();
		ToolStripMenuItem5 = new ToolStripMenuItem();
		ToolStripSeparator10 = new ToolStripSeparator();
		ToolStripMenuItem6 = new ToolStripMenuItem();
		ToolStripMenuItem7 = new ToolStripMenuItem();
		ToolStripMenuItem8 = new ToolStripMenuItem();
		ToolStripSeparator11 = new ToolStripSeparator();
		ToolStripMenuItem9 = new ToolStripMenuItem();
		ToolStripMenuItem10 = new ToolStripMenuItem();
		ToolStripMenuItem11 = new ToolStripMenuItem();
		ToolStripMenuItem12 = new ToolStripMenuItem();
		ToolStripSeparator12 = new ToolStripSeparator();
		ToolStripMenuItem13 = new ToolStripMenuItem();
		ToolStripMenuItem14 = new ToolStripMenuItem();
		ToolStripMenuItem15 = new ToolStripMenuItem();
		ToolStripSeparator13 = new ToolStripSeparator();
		ToolStripMenuItem16 = new ToolStripMenuItem();
		ToolStripMenuItem17 = new ToolStripMenuItem();
		ToolStripMenuItem18 = new ToolStripMenuItem();
		ToolStripMenuItem19 = new ToolStripMenuItem();
		ToolStripMenuItem20 = new ToolStripMenuItem();
		ToolStripMenuItem21 = new ToolStripMenuItem();
		ToolStripMenuItem22 = new ToolStripMenuItem();
		ToolStripMenuItem23 = new ToolStripMenuItem();
		ToolStripMenuItem24 = new ToolStripMenuItem();
		ToolStripMenuItem25 = new ToolStripMenuItem();
		ToolStripMenuItem26 = new ToolStripMenuItem();
		ToolStripMenuItem27 = new ToolStripMenuItem();
		ToolStripMenuItem28 = new ToolStripMenuItem();
		ToolStripMenuItem29 = new ToolStripMenuItem();
		ToolStripMenuItem30 = new ToolStripMenuItem();
		ToolStripMenuItem31 = new ToolStripMenuItem();
		ToolStripMenuItem32 = new ToolStripMenuItem();
		ToolStripSeparator14 = new ToolStripSeparator();
		ToolStripMenuItem33 = new ToolStripMenuItem();
		ToolStripSeparator15 = new ToolStripSeparator();
		ToolStripButton1 = new ToolStripButton();
		StatusStrip1 = new StatusStrip();
		ToolStripStatusLabel1 = new ToolStripStatusLabel();
		ToolStripButton2 = new ToolStripButton();
		ToolStripButton3 = new ToolStripButton();
		ToolStripSeparator16 = new ToolStripSeparator();
		ToolStrip1 = new ToolStrip();
		ToolStripButton4 = new ToolStripButton();
		ToolStripButton5 = new ToolStripButton();
		ToolStripButton6 = new ToolStripButton();
		ToolTip1 = new ToolTip(components);
		MenuStrip2 = new MenuStrip();
		ToolStripMenuItem34 = new ToolStripMenuItem();
		ToolStripMenuItem35 = new ToolStripMenuItem();
		ToolStripMenuItem36 = new ToolStripMenuItem();
		ToolStripSeparator17 = new ToolStripSeparator();
		ToolStripMenuItem37 = new ToolStripMenuItem();
		ToolStripMenuItem38 = new ToolStripMenuItem();
		ToolStripSeparator18 = new ToolStripSeparator();
		ToolStripMenuItem39 = new ToolStripMenuItem();
		ToolStripMenuItem40 = new ToolStripMenuItem();
		ToolStripMenuItem41 = new ToolStripMenuItem();
		ToolStripSeparator19 = new ToolStripSeparator();
		ToolStripMenuItem42 = new ToolStripMenuItem();
		ToolStripMenuItem43 = new ToolStripMenuItem();
		ToolStripMenuItem44 = new ToolStripMenuItem();
		ToolStripMenuItem45 = new ToolStripMenuItem();
		ToolStripSeparator20 = new ToolStripSeparator();
		ToolStripMenuItem46 = new ToolStripMenuItem();
		ToolStripMenuItem47 = new ToolStripMenuItem();
		ToolStripMenuItem48 = new ToolStripMenuItem();
		ToolStripSeparator21 = new ToolStripSeparator();
		ToolStripMenuItem49 = new ToolStripMenuItem();
		ToolStripMenuItem50 = new ToolStripMenuItem();
		ToolStripMenuItem51 = new ToolStripMenuItem();
		ToolStripMenuItem52 = new ToolStripMenuItem();
		ToolStripMenuItem53 = new ToolStripMenuItem();
		ToolStripMenuItem54 = new ToolStripMenuItem();
		ToolStripMenuItem55 = new ToolStripMenuItem();
		ToolStripMenuItem56 = new ToolStripMenuItem();
		ToolStripMenuItem57 = new ToolStripMenuItem();
		ToolStripMenuItem58 = new ToolStripMenuItem();
		ToolStripMenuItem59 = new ToolStripMenuItem();
		ToolStripMenuItem60 = new ToolStripMenuItem();
		ToolStripMenuItem61 = new ToolStripMenuItem();
		ToolStripMenuItem62 = new ToolStripMenuItem();
		ToolStripMenuItem63 = new ToolStripMenuItem();
		ToolStripMenuItem64 = new ToolStripMenuItem();
		ToolStripMenuItem65 = new ToolStripMenuItem();
		ToolStripSeparator22 = new ToolStripSeparator();
		ToolStripMenuItem66 = new ToolStripMenuItem();
		ToolStripSeparator23 = new ToolStripSeparator();
		ToolStripButton7 = new ToolStripButton();
		StatusStrip2 = new StatusStrip();
		ToolStripStatusLabel2 = new ToolStripStatusLabel();
		ToolStripButton8 = new ToolStripButton();
		ToolStripButton9 = new ToolStripButton();
		ToolStripSeparator24 = new ToolStripSeparator();
		ToolStrip2 = new ToolStrip();
		ToolStripButton10 = new ToolStripButton();
		ToolStripButton11 = new ToolStripButton();
		ToolStripButton12 = new ToolStripButton();
		ToolTip2 = new ToolTip(components);
		MenuStrip3 = new MenuStrip();
		ToolStripMenuItem67 = new ToolStripMenuItem();
		ToolStripMenuItem68 = new ToolStripMenuItem();
		ToolStripMenuItem69 = new ToolStripMenuItem();
		ToolStripSeparator25 = new ToolStripSeparator();
		ToolStripMenuItem70 = new ToolStripMenuItem();
		ToolStripMenuItem71 = new ToolStripMenuItem();
		ToolStripSeparator26 = new ToolStripSeparator();
		ToolStripMenuItem72 = new ToolStripMenuItem();
		ToolStripMenuItem73 = new ToolStripMenuItem();
		ToolStripMenuItem74 = new ToolStripMenuItem();
		ToolStripSeparator27 = new ToolStripSeparator();
		ToolStripMenuItem75 = new ToolStripMenuItem();
		ToolStripMenuItem76 = new ToolStripMenuItem();
		ToolStripMenuItem77 = new ToolStripMenuItem();
		ToolStripMenuItem78 = new ToolStripMenuItem();
		ToolStripSeparator28 = new ToolStripSeparator();
		ToolStripMenuItem79 = new ToolStripMenuItem();
		ToolStripMenuItem80 = new ToolStripMenuItem();
		ToolStripMenuItem81 = new ToolStripMenuItem();
		ToolStripSeparator29 = new ToolStripSeparator();
		ToolStripMenuItem82 = new ToolStripMenuItem();
		ToolStripMenuItem83 = new ToolStripMenuItem();
		ToolStripMenuItem84 = new ToolStripMenuItem();
		ToolStripMenuItem85 = new ToolStripMenuItem();
		ToolStripMenuItem86 = new ToolStripMenuItem();
		ToolStripMenuItem87 = new ToolStripMenuItem();
		ToolStripMenuItem88 = new ToolStripMenuItem();
		ToolStripMenuItem89 = new ToolStripMenuItem();
		ToolStripMenuItem90 = new ToolStripMenuItem();
		ToolStripMenuItem91 = new ToolStripMenuItem();
		ToolStripMenuItem92 = new ToolStripMenuItem();
		ToolStripMenuItem93 = new ToolStripMenuItem();
		ToolStripMenuItem94 = new ToolStripMenuItem();
		ToolStripMenuItem95 = new ToolStripMenuItem();
		ToolStripMenuItem96 = new ToolStripMenuItem();
		ToolStripMenuItem97 = new ToolStripMenuItem();
		ToolStripMenuItem98 = new ToolStripMenuItem();
		ToolStripSeparator30 = new ToolStripSeparator();
		ToolStripMenuItem99 = new ToolStripMenuItem();
		ToolStripSeparator31 = new ToolStripSeparator();
		ToolStripButton13 = new ToolStripButton();
		StatusStrip3 = new StatusStrip();
		ToolStripStatusLabel3 = new ToolStripStatusLabel();
		ToolStripButton14 = new ToolStripButton();
		ToolStripButton15 = new ToolStripButton();
		ToolStripSeparator32 = new ToolStripSeparator();
		ToolStrip3 = new ToolStrip();
		ToolStripButton16 = new ToolStripButton();
		ToolStripButton17 = new ToolStripButton();
		ToolStripButton18 = new ToolStripButton();
		ToolTip3 = new ToolTip(components);
		MenuStrip4 = new MenuStrip();
		ToolStripMenuItem100 = new ToolStripMenuItem();
		ToolStripMenuItem101 = new ToolStripMenuItem();
		ToolStripMenuItem102 = new ToolStripMenuItem();
		ToolStripSeparator33 = new ToolStripSeparator();
		ToolStripMenuItem103 = new ToolStripMenuItem();
		ToolStripMenuItem104 = new ToolStripMenuItem();
		ToolStripSeparator34 = new ToolStripSeparator();
		ToolStripMenuItem105 = new ToolStripMenuItem();
		ToolStripMenuItem106 = new ToolStripMenuItem();
		ToolStripMenuItem107 = new ToolStripMenuItem();
		ToolStripSeparator35 = new ToolStripSeparator();
		ToolStripMenuItem108 = new ToolStripMenuItem();
		ToolStripMenuItem109 = new ToolStripMenuItem();
		ToolStripMenuItem110 = new ToolStripMenuItem();
		ToolStripMenuItem111 = new ToolStripMenuItem();
		ToolStripSeparator36 = new ToolStripSeparator();
		ToolStripMenuItem112 = new ToolStripMenuItem();
		ToolStripMenuItem113 = new ToolStripMenuItem();
		ToolStripMenuItem114 = new ToolStripMenuItem();
		ToolStripSeparator37 = new ToolStripSeparator();
		ToolStripMenuItem115 = new ToolStripMenuItem();
		ToolStripMenuItem116 = new ToolStripMenuItem();
		ToolStripMenuItem117 = new ToolStripMenuItem();
		ToolStripMenuItem118 = new ToolStripMenuItem();
		ToolStripMenuItem119 = new ToolStripMenuItem();
		ToolStripMenuItem120 = new ToolStripMenuItem();
		ToolStripMenuItem121 = new ToolStripMenuItem();
		ToolStripMenuItem122 = new ToolStripMenuItem();
		ToolStripMenuItem123 = new ToolStripMenuItem();
		ToolStripMenuItem124 = new ToolStripMenuItem();
		ToolStripMenuItem125 = new ToolStripMenuItem();
		ToolStripMenuItem126 = new ToolStripMenuItem();
		ToolStripMenuItem127 = new ToolStripMenuItem();
		ToolStripMenuItem128 = new ToolStripMenuItem();
		ToolStripMenuItem129 = new ToolStripMenuItem();
		ToolStripMenuItem130 = new ToolStripMenuItem();
		ToolStripMenuItem131 = new ToolStripMenuItem();
		ToolStripSeparator38 = new ToolStripSeparator();
		ToolStripMenuItem132 = new ToolStripMenuItem();
		ToolStripSeparator39 = new ToolStripSeparator();
		ToolStripButton19 = new ToolStripButton();
		StatusStrip4 = new StatusStrip();
		ToolStripStatusLabel4 = new ToolStripStatusLabel();
		ToolStripButton20 = new ToolStripButton();
		ToolStripButton21 = new ToolStripButton();
		ToolStripSeparator40 = new ToolStripSeparator();
		ToolStrip4 = new ToolStrip();
		ToolStripButton22 = new ToolStripButton();
		ToolStripButton23 = new ToolStripButton();
		ToolStripButton24 = new ToolStripButton();
		ToolTip4 = new ToolTip(components);
		MenuStrip5 = new MenuStrip();
		ToolStripMenuItem133 = new ToolStripMenuItem();
		ToolStripMenuItem134 = new ToolStripMenuItem();
		ToolStripMenuItem135 = new ToolStripMenuItem();
		ToolStripSeparator41 = new ToolStripSeparator();
		ToolStripMenuItem136 = new ToolStripMenuItem();
		ToolStripMenuItem137 = new ToolStripMenuItem();
		ToolStripSeparator42 = new ToolStripSeparator();
		ToolStripMenuItem138 = new ToolStripMenuItem();
		ToolStripMenuItem139 = new ToolStripMenuItem();
		ToolStripMenuItem140 = new ToolStripMenuItem();
		ToolStripSeparator43 = new ToolStripSeparator();
		ToolStripMenuItem141 = new ToolStripMenuItem();
		ToolStripMenuItem142 = new ToolStripMenuItem();
		ToolStripMenuItem143 = new ToolStripMenuItem();
		ToolStripMenuItem144 = new ToolStripMenuItem();
		ToolStripSeparator44 = new ToolStripSeparator();
		ToolStripMenuItem145 = new ToolStripMenuItem();
		ToolStripMenuItem146 = new ToolStripMenuItem();
		ToolStripMenuItem147 = new ToolStripMenuItem();
		ToolStripSeparator45 = new ToolStripSeparator();
		ToolStripMenuItem148 = new ToolStripMenuItem();
		ToolStripMenuItem149 = new ToolStripMenuItem();
		ToolStripMenuItem150 = new ToolStripMenuItem();
		ToolStripMenuItem151 = new ToolStripMenuItem();
		ToolStripMenuItem152 = new ToolStripMenuItem();
		ToolStripMenuItem153 = new ToolStripMenuItem();
		ToolStripMenuItem154 = new ToolStripMenuItem();
		ToolStripMenuItem155 = new ToolStripMenuItem();
		ToolStripMenuItem156 = new ToolStripMenuItem();
		ToolStripMenuItem157 = new ToolStripMenuItem();
		ToolStripMenuItem158 = new ToolStripMenuItem();
		ToolStripMenuItem159 = new ToolStripMenuItem();
		ToolStripMenuItem160 = new ToolStripMenuItem();
		ToolStripMenuItem161 = new ToolStripMenuItem();
		ToolStripMenuItem162 = new ToolStripMenuItem();
		ToolStripMenuItem163 = new ToolStripMenuItem();
		ToolStripMenuItem164 = new ToolStripMenuItem();
		ToolStripSeparator46 = new ToolStripSeparator();
		ToolStripMenuItem165 = new ToolStripMenuItem();
		ToolStripSeparator47 = new ToolStripSeparator();
		ToolStripButton25 = new ToolStripButton();
		StatusStrip5 = new StatusStrip();
		ToolStripStatusLabel5 = new ToolStripStatusLabel();
		ToolStripButton26 = new ToolStripButton();
		ToolStripButton27 = new ToolStripButton();
		ToolStripSeparator48 = new ToolStripSeparator();
		ToolStrip5 = new ToolStrip();
		ToolStripButton28 = new ToolStripButton();
		ToolStripButton29 = new ToolStripButton();
		ToolStripButton30 = new ToolStripButton();
		ToolTip5 = new ToolTip(components);
		MenuStrip6 = new MenuStrip();
		ToolStripMenuItem166 = new ToolStripMenuItem();
		ToolStripMenuItem167 = new ToolStripMenuItem();
		ToolStripMenuItem168 = new ToolStripMenuItem();
		ToolStripSeparator49 = new ToolStripSeparator();
		ToolStripMenuItem169 = new ToolStripMenuItem();
		ToolStripMenuItem170 = new ToolStripMenuItem();
		ToolStripSeparator50 = new ToolStripSeparator();
		ToolStripMenuItem171 = new ToolStripMenuItem();
		ToolStripMenuItem172 = new ToolStripMenuItem();
		ToolStripMenuItem173 = new ToolStripMenuItem();
		ToolStripSeparator51 = new ToolStripSeparator();
		ToolStripMenuItem174 = new ToolStripMenuItem();
		ToolStripMenuItem175 = new ToolStripMenuItem();
		ToolStripMenuItem176 = new ToolStripMenuItem();
		ToolStripMenuItem177 = new ToolStripMenuItem();
		ToolStripSeparator52 = new ToolStripSeparator();
		ToolStripMenuItem178 = new ToolStripMenuItem();
		ToolStripMenuItem179 = new ToolStripMenuItem();
		ToolStripMenuItem180 = new ToolStripMenuItem();
		ToolStripSeparator53 = new ToolStripSeparator();
		ToolStripMenuItem181 = new ToolStripMenuItem();
		ToolStripMenuItem182 = new ToolStripMenuItem();
		ToolStripMenuItem183 = new ToolStripMenuItem();
		ToolStripMenuItem184 = new ToolStripMenuItem();
		ToolStripMenuItem185 = new ToolStripMenuItem();
		ToolStripMenuItem186 = new ToolStripMenuItem();
		ToolStripMenuItem187 = new ToolStripMenuItem();
		ToolStripMenuItem188 = new ToolStripMenuItem();
		ToolStripMenuItem189 = new ToolStripMenuItem();
		ToolStripMenuItem190 = new ToolStripMenuItem();
		ToolStripMenuItem191 = new ToolStripMenuItem();
		ToolStripMenuItem192 = new ToolStripMenuItem();
		ToolStripMenuItem193 = new ToolStripMenuItem();
		ToolStripMenuItem194 = new ToolStripMenuItem();
		ToolStripMenuItem195 = new ToolStripMenuItem();
		ToolStripMenuItem196 = new ToolStripMenuItem();
		ToolStripMenuItem197 = new ToolStripMenuItem();
		ToolStripSeparator54 = new ToolStripSeparator();
		ToolStripMenuItem198 = new ToolStripMenuItem();
		ToolStripSeparator55 = new ToolStripSeparator();
		ToolStripButton31 = new ToolStripButton();
		StatusStrip6 = new StatusStrip();
		ToolStripStatusLabel6 = new ToolStripStatusLabel();
		ToolStripButton32 = new ToolStripButton();
		ToolStripButton33 = new ToolStripButton();
		ToolStripSeparator56 = new ToolStripSeparator();
		ToolStrip6 = new ToolStrip();
		ToolStripButton34 = new ToolStripButton();
		ToolStripButton35 = new ToolStripButton();
		ToolStripButton36 = new ToolStripButton();
		ToolTip6 = new ToolTip(components);
		((Control)MenuStrip).SuspendLayout();
		((Control)ToolStrip).SuspendLayout();
		((Control)StatusStrip).SuspendLayout();
		((Control)MenuStrip1).SuspendLayout();
		((Control)StatusStrip1).SuspendLayout();
		((Control)ToolStrip1).SuspendLayout();
		((Control)MenuStrip2).SuspendLayout();
		((Control)StatusStrip2).SuspendLayout();
		((Control)ToolStrip2).SuspendLayout();
		((Control)MenuStrip3).SuspendLayout();
		((Control)StatusStrip3).SuspendLayout();
		((Control)ToolStrip3).SuspendLayout();
		((Control)MenuStrip4).SuspendLayout();
		((Control)StatusStrip4).SuspendLayout();
		((Control)ToolStrip4).SuspendLayout();
		((Control)MenuStrip5).SuspendLayout();
		((Control)StatusStrip5).SuspendLayout();
		((Control)ToolStrip5).SuspendLayout();
		((Control)MenuStrip6).SuspendLayout();
		((Control)StatusStrip6).SuspendLayout();
		((Control)ToolStrip6).SuspendLayout();
		((Control)this).SuspendLayout();
		((ToolStrip)MenuStrip).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)FileMenu,
			(ToolStripItem)EditMenu,
			(ToolStripItem)ViewMenu,
			(ToolStripItem)ToolsMenu,
			(ToolStripItem)WindowsMenu,
			(ToolStripItem)HelpMenu
		});
		MenuStrip menuStrip = MenuStrip;
		Point location = new Point(0, 0);
		((Control)menuStrip).set_Location(location);
		MenuStrip.set_MdiWindowListItem(WindowsMenu);
		((Control)MenuStrip).set_Name("MenuStrip");
		MenuStrip menuStrip2 = MenuStrip;
		Size size = new Size(632, 24);
		((Control)menuStrip2).set_Size(size);
		((Control)MenuStrip).set_TabIndex(5);
		((Control)MenuStrip).set_Text("MenuStrip");
		((ToolStripDropDownItem)FileMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)NewToolStripMenuItem,
			(ToolStripItem)OpenToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator3,
			(ToolStripItem)SaveToolStripMenuItem,
			(ToolStripItem)SaveAsToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator4,
			(ToolStripItem)PrintToolStripMenuItem,
			(ToolStripItem)PrintPreviewToolStripMenuItem,
			(ToolStripItem)PrintSetupToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator5,
			(ToolStripItem)ExitToolStripMenuItem
		});
		((ToolStripItem)FileMenu).set_ImageTransparentColor(SystemColors.ActiveBorder);
		((ToolStripItem)FileMenu).set_Name("FileMenu");
		ToolStripMenuItem fileMenu = FileMenu;
		size = new Size(54, 20);
		((ToolStripItem)fileMenu).set_Size(size);
		((ToolStripItem)FileMenu).set_Text("&Fichier");
		((ToolStripItem)NewToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("NewToolStripMenuItem.Image"));
		((ToolStripItem)NewToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)NewToolStripMenuItem).set_Name("NewToolStripMenuItem");
		NewToolStripMenuItem.set_ShortcutKeys((Keys)131150);
		ToolStripMenuItem newToolStripMenuItem = NewToolStripMenuItem;
		size = new Size(231, 22);
		((ToolStripItem)newToolStripMenuItem).set_Size(size);
		((ToolStripItem)NewToolStripMenuItem).set_Text("&Nouveau");
		((ToolStripItem)OpenToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("OpenToolStripMenuItem.Image"));
		((ToolStripItem)OpenToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)OpenToolStripMenuItem).set_Name("OpenToolStripMenuItem");
		OpenToolStripMenuItem.set_ShortcutKeys((Keys)131151);
		ToolStripMenuItem openToolStripMenuItem = OpenToolStripMenuItem;
		size = new Size(231, 22);
		((ToolStripItem)openToolStripMenuItem).set_Size(size);
		((ToolStripItem)OpenToolStripMenuItem).set_Text("&Ouvrir");
		((ToolStripItem)ToolStripSeparator3).set_Name("ToolStripSeparator3");
		ToolStripSeparator toolStripSeparator = ToolStripSeparator3;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator).set_Size(size);
		((ToolStripItem)SaveToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("SaveToolStripMenuItem.Image"));
		((ToolStripItem)SaveToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)SaveToolStripMenuItem).set_Name("SaveToolStripMenuItem");
		SaveToolStripMenuItem.set_ShortcutKeys((Keys)131155);
		ToolStripMenuItem saveToolStripMenuItem = SaveToolStripMenuItem;
		size = new Size(231, 22);
		((ToolStripItem)saveToolStripMenuItem).set_Size(size);
		((ToolStripItem)SaveToolStripMenuItem).set_Text("&Enregistrer");
		((ToolStripItem)SaveAsToolStripMenuItem).set_Name("SaveAsToolStripMenuItem");
		ToolStripMenuItem saveAsToolStripMenuItem = SaveAsToolStripMenuItem;
		size = new Size(231, 22);
		((ToolStripItem)saveAsToolStripMenuItem).set_Size(size);
		((ToolStripItem)SaveAsToolStripMenuItem).set_Text("Enregistrer &sous");
		((ToolStripItem)ToolStripSeparator4).set_Name("ToolStripSeparator4");
		ToolStripSeparator toolStripSeparator2 = ToolStripSeparator4;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator2).set_Size(size);
		((ToolStripItem)PrintToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("PrintToolStripMenuItem.Image"));
		((ToolStripItem)PrintToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)PrintToolStripMenuItem).set_Name("PrintToolStripMenuItem");
		PrintToolStripMenuItem.set_ShortcutKeys((Keys)131152);
		ToolStripMenuItem printToolStripMenuItem = PrintToolStripMenuItem;
		size = new Size(231, 22);
		((ToolStripItem)printToolStripMenuItem).set_Size(size);
		((ToolStripItem)PrintToolStripMenuItem).set_Text("&Imprimer");
		((ToolStripItem)PrintPreviewToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("PrintPreviewToolStripMenuItem.Image"));
		((ToolStripItem)PrintPreviewToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)PrintPreviewToolStripMenuItem).set_Name("PrintPreviewToolStripMenuItem");
		ToolStripMenuItem printPreviewToolStripMenuItem = PrintPreviewToolStripMenuItem;
		size = new Size(231, 22);
		((ToolStripItem)printPreviewToolStripMenuItem).set_Size(size);
		((ToolStripItem)PrintPreviewToolStripMenuItem).set_Text("Aperçu a&vant impression");
		((ToolStripItem)PrintSetupToolStripMenuItem).set_Name("PrintSetupToolStripMenuItem");
		ToolStripMenuItem printSetupToolStripMenuItem = PrintSetupToolStripMenuItem;
		size = new Size(231, 22);
		((ToolStripItem)printSetupToolStripMenuItem).set_Size(size);
		((ToolStripItem)PrintSetupToolStripMenuItem).set_Text("Configuration de l'impression");
		((ToolStripItem)ToolStripSeparator5).set_Name("ToolStripSeparator5");
		ToolStripSeparator toolStripSeparator3 = ToolStripSeparator5;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator3).set_Size(size);
		((ToolStripItem)ExitToolStripMenuItem).set_Name("ExitToolStripMenuItem");
		ToolStripMenuItem exitToolStripMenuItem = ExitToolStripMenuItem;
		size = new Size(231, 22);
		((ToolStripItem)exitToolStripMenuItem).set_Size(size);
		((ToolStripItem)ExitToolStripMenuItem).set_Text("&Quitter");
		((ToolStripDropDownItem)EditMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)UndoToolStripMenuItem,
			(ToolStripItem)RedoToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator6,
			(ToolStripItem)CutToolStripMenuItem,
			(ToolStripItem)CopyToolStripMenuItem,
			(ToolStripItem)PasteToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator7,
			(ToolStripItem)SelectAllToolStripMenuItem
		});
		((ToolStripItem)EditMenu).set_Name("EditMenu");
		ToolStripMenuItem editMenu = EditMenu;
		size = new Size(56, 20);
		((ToolStripItem)editMenu).set_Size(size);
		((ToolStripItem)EditMenu).set_Text("&Edition");
		((ToolStripItem)UndoToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("UndoToolStripMenuItem.Image"));
		((ToolStripItem)UndoToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)UndoToolStripMenuItem).set_Name("UndoToolStripMenuItem");
		UndoToolStripMenuItem.set_ShortcutKeys((Keys)131162);
		ToolStripMenuItem undoToolStripMenuItem = UndoToolStripMenuItem;
		size = new Size(206, 22);
		((ToolStripItem)undoToolStripMenuItem).set_Size(size);
		((ToolStripItem)UndoToolStripMenuItem).set_Text("&Annuler");
		((ToolStripItem)RedoToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("RedoToolStripMenuItem.Image"));
		((ToolStripItem)RedoToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)RedoToolStripMenuItem).set_Name("RedoToolStripMenuItem");
		RedoToolStripMenuItem.set_ShortcutKeys((Keys)131161);
		ToolStripMenuItem redoToolStripMenuItem = RedoToolStripMenuItem;
		size = new Size(206, 22);
		((ToolStripItem)redoToolStripMenuItem).set_Size(size);
		((ToolStripItem)RedoToolStripMenuItem).set_Text("&Rétablir");
		((ToolStripItem)ToolStripSeparator6).set_Name("ToolStripSeparator6");
		ToolStripSeparator toolStripSeparator4 = ToolStripSeparator6;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator4).set_Size(size);
		((ToolStripItem)CutToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("CutToolStripMenuItem.Image"));
		((ToolStripItem)CutToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)CutToolStripMenuItem).set_Name("CutToolStripMenuItem");
		CutToolStripMenuItem.set_ShortcutKeys((Keys)131160);
		ToolStripMenuItem cutToolStripMenuItem = CutToolStripMenuItem;
		size = new Size(206, 22);
		((ToolStripItem)cutToolStripMenuItem).set_Size(size);
		((ToolStripItem)CutToolStripMenuItem).set_Text("Co&uper");
		((ToolStripItem)CopyToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("CopyToolStripMenuItem.Image"));
		((ToolStripItem)CopyToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)CopyToolStripMenuItem).set_Name("CopyToolStripMenuItem");
		CopyToolStripMenuItem.set_ShortcutKeys((Keys)131139);
		ToolStripMenuItem copyToolStripMenuItem = CopyToolStripMenuItem;
		size = new Size(206, 22);
		((ToolStripItem)copyToolStripMenuItem).set_Size(size);
		((ToolStripItem)CopyToolStripMenuItem).set_Text("&Copier");
		((ToolStripItem)PasteToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("PasteToolStripMenuItem.Image"));
		((ToolStripItem)PasteToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)PasteToolStripMenuItem).set_Name("PasteToolStripMenuItem");
		PasteToolStripMenuItem.set_ShortcutKeys((Keys)131158);
		ToolStripMenuItem pasteToolStripMenuItem = PasteToolStripMenuItem;
		size = new Size(206, 22);
		((ToolStripItem)pasteToolStripMenuItem).set_Size(size);
		((ToolStripItem)PasteToolStripMenuItem).set_Text("&Coller");
		((ToolStripItem)ToolStripSeparator7).set_Name("ToolStripSeparator7");
		ToolStripSeparator toolStripSeparator5 = ToolStripSeparator7;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator5).set_Size(size);
		((ToolStripItem)SelectAllToolStripMenuItem).set_Name("SelectAllToolStripMenuItem");
		SelectAllToolStripMenuItem.set_ShortcutKeys((Keys)131137);
		ToolStripMenuItem selectAllToolStripMenuItem = SelectAllToolStripMenuItem;
		size = new Size(206, 22);
		((ToolStripItem)selectAllToolStripMenuItem).set_Size(size);
		((ToolStripItem)SelectAllToolStripMenuItem).set_Text("Sélectionner &tout");
		((ToolStripDropDownItem)ViewMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolBarToolStripMenuItem,
			(ToolStripItem)StatusBarToolStripMenuItem
		});
		((ToolStripItem)ViewMenu).set_Name("ViewMenu");
		ToolStripMenuItem viewMenu = ViewMenu;
		size = new Size(70, 20);
		((ToolStripItem)viewMenu).set_Size(size);
		((ToolStripItem)ViewMenu).set_Text("&Affichage");
		ToolBarToolStripMenuItem.set_Checked(true);
		ToolBarToolStripMenuItem.set_CheckOnClick(true);
		ToolBarToolStripMenuItem.set_CheckState((CheckState)1);
		((ToolStripItem)ToolBarToolStripMenuItem).set_Name("ToolBarToolStripMenuItem");
		ToolStripMenuItem toolBarToolStripMenuItem = ToolBarToolStripMenuItem;
		size = new Size(143, 22);
		((ToolStripItem)toolBarToolStripMenuItem).set_Size(size);
		((ToolStripItem)ToolBarToolStripMenuItem).set_Text("&Barre d'outils");
		StatusBarToolStripMenuItem.set_Checked(true);
		StatusBarToolStripMenuItem.set_CheckOnClick(true);
		StatusBarToolStripMenuItem.set_CheckState((CheckState)1);
		((ToolStripItem)StatusBarToolStripMenuItem).set_Name("StatusBarToolStripMenuItem");
		ToolStripMenuItem statusBarToolStripMenuItem = StatusBarToolStripMenuItem;
		size = new Size(143, 22);
		((ToolStripItem)statusBarToolStripMenuItem).set_Size(size);
		((ToolStripItem)StatusBarToolStripMenuItem).set_Text("&Barre d'état");
		((ToolStripDropDownItem)ToolsMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)OptionsToolStripMenuItem });
		((ToolStripItem)ToolsMenu).set_Name("ToolsMenu");
		ToolStripMenuItem toolsMenu = ToolsMenu;
		size = new Size(50, 20);
		((ToolStripItem)toolsMenu).set_Size(size);
		((ToolStripItem)ToolsMenu).set_Text("&Outils");
		((ToolStripItem)OptionsToolStripMenuItem).set_Name("OptionsToolStripMenuItem");
		ToolStripMenuItem optionsToolStripMenuItem = OptionsToolStripMenuItem;
		size = new Size(116, 22);
		((ToolStripItem)optionsToolStripMenuItem).set_Size(size);
		((ToolStripItem)OptionsToolStripMenuItem).set_Text("&Options");
		((ToolStripDropDownItem)WindowsMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)NewWindowToolStripMenuItem,
			(ToolStripItem)CascadeToolStripMenuItem,
			(ToolStripItem)TileVerticalToolStripMenuItem,
			(ToolStripItem)TileHorizontalToolStripMenuItem,
			(ToolStripItem)CloseAllToolStripMenuItem,
			(ToolStripItem)ArrangeIconsToolStripMenuItem
		});
		((ToolStripItem)WindowsMenu).set_Name("WindowsMenu");
		ToolStripMenuItem windowsMenu = WindowsMenu;
		size = new Size(63, 20);
		((ToolStripItem)windowsMenu).set_Size(size);
		((ToolStripItem)WindowsMenu).set_Text("F&enêtres");
		((ToolStripItem)NewWindowToolStripMenuItem).set_Name("NewWindowToolStripMenuItem");
		ToolStripMenuItem newWindowToolStripMenuItem = NewWindowToolStripMenuItem;
		size = new Size(190, 22);
		((ToolStripItem)newWindowToolStripMenuItem).set_Size(size);
		((ToolStripItem)NewWindowToolStripMenuItem).set_Text("&Nouvelle fenêtre");
		((ToolStripItem)CascadeToolStripMenuItem).set_Name("CascadeToolStripMenuItem");
		ToolStripMenuItem cascadeToolStripMenuItem = CascadeToolStripMenuItem;
		size = new Size(190, 22);
		((ToolStripItem)cascadeToolStripMenuItem).set_Size(size);
		((ToolStripItem)CascadeToolStripMenuItem).set_Text("&Cascade");
		((ToolStripItem)TileVerticalToolStripMenuItem).set_Name("TileVerticalToolStripMenuItem");
		ToolStripMenuItem tileVerticalToolStripMenuItem = TileVerticalToolStripMenuItem;
		size = new Size(190, 22);
		((ToolStripItem)tileVerticalToolStripMenuItem).set_Size(size);
		((ToolStripItem)TileVerticalToolStripMenuItem).set_Text("Mosaïque &verticale");
		((ToolStripItem)TileHorizontalToolStripMenuItem).set_Name("TileHorizontalToolStripMenuItem");
		ToolStripMenuItem tileHorizontalToolStripMenuItem = TileHorizontalToolStripMenuItem;
		size = new Size(190, 22);
		((ToolStripItem)tileHorizontalToolStripMenuItem).set_Size(size);
		((ToolStripItem)TileHorizontalToolStripMenuItem).set_Text("Mosaïque &horizontale");
		((ToolStripItem)CloseAllToolStripMenuItem).set_Name("CloseAllToolStripMenuItem");
		ToolStripMenuItem closeAllToolStripMenuItem = CloseAllToolStripMenuItem;
		size = new Size(190, 22);
		((ToolStripItem)closeAllToolStripMenuItem).set_Size(size);
		((ToolStripItem)CloseAllToolStripMenuItem).set_Text("&Fermer tout");
		((ToolStripItem)ArrangeIconsToolStripMenuItem).set_Name("ArrangeIconsToolStripMenuItem");
		ToolStripMenuItem arrangeIconsToolStripMenuItem = ArrangeIconsToolStripMenuItem;
		size = new Size(190, 22);
		((ToolStripItem)arrangeIconsToolStripMenuItem).set_Size(size);
		((ToolStripItem)ArrangeIconsToolStripMenuItem).set_Text("&Réorganiser les icônes");
		((ToolStripDropDownItem)HelpMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ContentsToolStripMenuItem,
			(ToolStripItem)IndexToolStripMenuItem,
			(ToolStripItem)SearchToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator8,
			(ToolStripItem)AboutToolStripMenuItem
		});
		((ToolStripItem)HelpMenu).set_Name("HelpMenu");
		ToolStripMenuItem helpMenu = HelpMenu;
		size = new Size(24, 20);
		((ToolStripItem)helpMenu).set_Size(size);
		((ToolStripItem)HelpMenu).set_Text("&?");
		((ToolStripItem)ContentsToolStripMenuItem).set_Name("ContentsToolStripMenuItem");
		ContentsToolStripMenuItem.set_ShortcutKeys((Keys)131184);
		ToolStripMenuItem contentsToolStripMenuItem = ContentsToolStripMenuItem;
		size = new Size(166, 22);
		((ToolStripItem)contentsToolStripMenuItem).set_Size(size);
		((ToolStripItem)ContentsToolStripMenuItem).set_Text("&Contenu");
		((ToolStripItem)IndexToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("IndexToolStripMenuItem.Image"));
		((ToolStripItem)IndexToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)IndexToolStripMenuItem).set_Name("IndexToolStripMenuItem");
		ToolStripMenuItem indexToolStripMenuItem = IndexToolStripMenuItem;
		size = new Size(166, 22);
		((ToolStripItem)indexToolStripMenuItem).set_Size(size);
		((ToolStripItem)IndexToolStripMenuItem).set_Text("&Index");
		((ToolStripItem)SearchToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("SearchToolStripMenuItem.Image"));
		((ToolStripItem)SearchToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)SearchToolStripMenuItem).set_Name("SearchToolStripMenuItem");
		ToolStripMenuItem searchToolStripMenuItem = SearchToolStripMenuItem;
		size = new Size(166, 22);
		((ToolStripItem)searchToolStripMenuItem).set_Size(size);
		((ToolStripItem)SearchToolStripMenuItem).set_Text("&Rechercher");
		((ToolStripItem)ToolStripSeparator8).set_Name("ToolStripSeparator8");
		ToolStripSeparator toolStripSeparator6 = ToolStripSeparator8;
		size = new Size(163, 6);
		((ToolStripItem)toolStripSeparator6).set_Size(size);
		((ToolStripItem)AboutToolStripMenuItem).set_Name("AboutToolStripMenuItem");
		ToolStripMenuItem aboutToolStripMenuItem = AboutToolStripMenuItem;
		size = new Size(166, 22);
		((ToolStripItem)aboutToolStripMenuItem).set_Size(size);
		((ToolStripItem)AboutToolStripMenuItem).set_Text("À pr&opos de...");
		ToolStrip.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)NewToolStripButton,
			(ToolStripItem)OpenToolStripButton,
			(ToolStripItem)SaveToolStripButton,
			(ToolStripItem)ToolStripSeparator1,
			(ToolStripItem)PrintToolStripButton,
			(ToolStripItem)PrintPreviewToolStripButton,
			(ToolStripItem)ToolStripSeparator2,
			(ToolStripItem)HelpToolStripButton
		});
		ToolStrip toolStrip = ToolStrip;
		location = new Point(0, 24);
		((Control)toolStrip).set_Location(location);
		((Control)ToolStrip).set_Name("ToolStrip");
		ToolStrip toolStrip2 = ToolStrip;
		size = new Size(632, 25);
		((Control)toolStrip2).set_Size(size);
		((Control)ToolStrip).set_TabIndex(6);
		((Control)ToolStrip).set_Text("ToolStrip");
		((ToolStripItem)NewToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)NewToolStripButton).set_Image((Image)componentResourceManager.GetObject("NewToolStripButton.Image"));
		((ToolStripItem)NewToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)NewToolStripButton).set_Name("NewToolStripButton");
		ToolStripButton newToolStripButton = NewToolStripButton;
		size = new Size(23, 22);
		((ToolStripItem)newToolStripButton).set_Size(size);
		((ToolStripItem)NewToolStripButton).set_Text("Nouveau");
		((ToolStripItem)OpenToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)OpenToolStripButton).set_Image((Image)componentResourceManager.GetObject("OpenToolStripButton.Image"));
		((ToolStripItem)OpenToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)OpenToolStripButton).set_Name("OpenToolStripButton");
		ToolStripButton openToolStripButton = OpenToolStripButton;
		size = new Size(23, 22);
		((ToolStripItem)openToolStripButton).set_Size(size);
		((ToolStripItem)OpenToolStripButton).set_Text("Ouvrir");
		((ToolStripItem)SaveToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)SaveToolStripButton).set_Image((Image)componentResourceManager.GetObject("SaveToolStripButton.Image"));
		((ToolStripItem)SaveToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)SaveToolStripButton).set_Name("SaveToolStripButton");
		ToolStripButton saveToolStripButton = SaveToolStripButton;
		size = new Size(23, 22);
		((ToolStripItem)saveToolStripButton).set_Size(size);
		((ToolStripItem)SaveToolStripButton).set_Text("Enregistrer");
		((ToolStripItem)ToolStripSeparator1).set_Name("ToolStripSeparator1");
		ToolStripSeparator toolStripSeparator7 = ToolStripSeparator1;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator7).set_Size(size);
		((ToolStripItem)PrintToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)PrintToolStripButton).set_Image((Image)componentResourceManager.GetObject("PrintToolStripButton.Image"));
		((ToolStripItem)PrintToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)PrintToolStripButton).set_Name("PrintToolStripButton");
		ToolStripButton printToolStripButton = PrintToolStripButton;
		size = new Size(23, 22);
		((ToolStripItem)printToolStripButton).set_Size(size);
		((ToolStripItem)PrintToolStripButton).set_Text("Imprimer");
		((ToolStripItem)PrintPreviewToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)PrintPreviewToolStripButton).set_Image((Image)componentResourceManager.GetObject("PrintPreviewToolStripButton.Image"));
		((ToolStripItem)PrintPreviewToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)PrintPreviewToolStripButton).set_Name("PrintPreviewToolStripButton");
		ToolStripButton printPreviewToolStripButton = PrintPreviewToolStripButton;
		size = new Size(23, 22);
		((ToolStripItem)printPreviewToolStripButton).set_Size(size);
		((ToolStripItem)PrintPreviewToolStripButton).set_Text("Aperçu avant impression");
		((ToolStripItem)ToolStripSeparator2).set_Name("ToolStripSeparator2");
		ToolStripSeparator toolStripSeparator8 = ToolStripSeparator2;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator8).set_Size(size);
		((ToolStripItem)HelpToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)HelpToolStripButton).set_Image((Image)componentResourceManager.GetObject("HelpToolStripButton.Image"));
		((ToolStripItem)HelpToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)HelpToolStripButton).set_Name("HelpToolStripButton");
		ToolStripButton helpToolStripButton = HelpToolStripButton;
		size = new Size(23, 22);
		((ToolStripItem)helpToolStripButton).set_Size(size);
		((ToolStripItem)HelpToolStripButton).set_Text("Aide");
		((ToolStrip)StatusStrip).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel });
		StatusStrip statusStrip = StatusStrip;
		location = new Point(0, 431);
		((Control)statusStrip).set_Location(location);
		((Control)StatusStrip).set_Name("StatusStrip");
		StatusStrip statusStrip2 = StatusStrip;
		size = new Size(632, 22);
		((Control)statusStrip2).set_Size(size);
		((Control)StatusStrip).set_TabIndex(7);
		((Control)StatusStrip).set_Text("StatusStrip");
		((ToolStripItem)ToolStripStatusLabel).set_Name("ToolStripStatusLabel");
		ToolStripStatusLabel toolStripStatusLabel = ToolStripStatusLabel;
		size = new Size(27, 17);
		((ToolStripItem)toolStripStatusLabel).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel).set_Text("État");
		((ToolStrip)MenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem1,
			(ToolStripItem)ToolStripMenuItem10,
			(ToolStripItem)ToolStripMenuItem17,
			(ToolStripItem)ToolStripMenuItem20,
			(ToolStripItem)ToolStripMenuItem22,
			(ToolStripItem)ToolStripMenuItem29
		});
		MenuStrip menuStrip3 = MenuStrip1;
		location = new Point(0, 74);
		((Control)menuStrip3).set_Location(location);
		MenuStrip1.set_MdiWindowListItem(ToolStripMenuItem22);
		((Control)MenuStrip1).set_Name("MenuStrip1");
		MenuStrip menuStrip4 = MenuStrip1;
		size = new Size(632, 24);
		((Control)menuStrip4).set_Size(size);
		((Control)MenuStrip1).set_TabIndex(9);
		((Control)MenuStrip1).set_Text("MenuStrip1");
		((ToolStripDropDownItem)ToolStripMenuItem1).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)ToolStripMenuItem2,
			(ToolStripItem)ToolStripMenuItem3,
			(ToolStripItem)ToolStripSeparator9,
			(ToolStripItem)ToolStripMenuItem4,
			(ToolStripItem)ToolStripMenuItem5,
			(ToolStripItem)ToolStripSeparator10,
			(ToolStripItem)ToolStripMenuItem6,
			(ToolStripItem)ToolStripMenuItem7,
			(ToolStripItem)ToolStripMenuItem8,
			(ToolStripItem)ToolStripSeparator11,
			(ToolStripItem)ToolStripMenuItem9
		});
		((ToolStripItem)ToolStripMenuItem1).set_ImageTransparentColor(SystemColors.ActiveBorder);
		((ToolStripItem)ToolStripMenuItem1).set_Name("ToolStripMenuItem1");
		ToolStripMenuItem toolStripMenuItem = ToolStripMenuItem1;
		size = new Size(54, 20);
		((ToolStripItem)toolStripMenuItem).set_Size(size);
		((ToolStripItem)ToolStripMenuItem1).set_Text("&Fichier");
		((ToolStripItem)ToolStripMenuItem2).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem2.Image"));
		((ToolStripItem)ToolStripMenuItem2).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem2).set_Name("ToolStripMenuItem2");
		ToolStripMenuItem2.set_ShortcutKeys((Keys)131150);
		ToolStripMenuItem toolStripMenuItem2 = ToolStripMenuItem2;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem2).set_Size(size);
		((ToolStripItem)ToolStripMenuItem2).set_Text("&Nouveau");
		((ToolStripItem)ToolStripMenuItem3).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem3.Image"));
		((ToolStripItem)ToolStripMenuItem3).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem3).set_Name("ToolStripMenuItem3");
		ToolStripMenuItem3.set_ShortcutKeys((Keys)131151);
		ToolStripMenuItem toolStripMenuItem3 = ToolStripMenuItem3;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem3).set_Size(size);
		((ToolStripItem)ToolStripMenuItem3).set_Text("&Ouvrir");
		((ToolStripItem)ToolStripSeparator9).set_Name("ToolStripSeparator9");
		ToolStripSeparator toolStripSeparator9 = ToolStripSeparator9;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator9).set_Size(size);
		((ToolStripItem)ToolStripMenuItem4).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem4.Image"));
		((ToolStripItem)ToolStripMenuItem4).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem4).set_Name("ToolStripMenuItem4");
		ToolStripMenuItem4.set_ShortcutKeys((Keys)131155);
		ToolStripMenuItem toolStripMenuItem4 = ToolStripMenuItem4;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem4).set_Size(size);
		((ToolStripItem)ToolStripMenuItem4).set_Text("&Enregistrer");
		((ToolStripItem)ToolStripMenuItem5).set_Name("ToolStripMenuItem5");
		ToolStripMenuItem toolStripMenuItem5 = ToolStripMenuItem5;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem5).set_Size(size);
		((ToolStripItem)ToolStripMenuItem5).set_Text("Enregistrer &sous");
		((ToolStripItem)ToolStripSeparator10).set_Name("ToolStripSeparator10");
		ToolStripSeparator toolStripSeparator10 = ToolStripSeparator10;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator10).set_Size(size);
		((ToolStripItem)ToolStripMenuItem6).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem6.Image"));
		((ToolStripItem)ToolStripMenuItem6).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem6).set_Name("ToolStripMenuItem6");
		ToolStripMenuItem6.set_ShortcutKeys((Keys)131152);
		ToolStripMenuItem toolStripMenuItem6 = ToolStripMenuItem6;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem6).set_Size(size);
		((ToolStripItem)ToolStripMenuItem6).set_Text("&Imprimer");
		((ToolStripItem)ToolStripMenuItem7).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem7.Image"));
		((ToolStripItem)ToolStripMenuItem7).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem7).set_Name("ToolStripMenuItem7");
		ToolStripMenuItem toolStripMenuItem7 = ToolStripMenuItem7;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem7).set_Size(size);
		((ToolStripItem)ToolStripMenuItem7).set_Text("Aperçu a&vant impression");
		((ToolStripItem)ToolStripMenuItem8).set_Name("ToolStripMenuItem8");
		ToolStripMenuItem toolStripMenuItem8 = ToolStripMenuItem8;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem8).set_Size(size);
		((ToolStripItem)ToolStripMenuItem8).set_Text("Configuration de l'impression");
		((ToolStripItem)ToolStripSeparator11).set_Name("ToolStripSeparator11");
		ToolStripSeparator toolStripSeparator11 = ToolStripSeparator11;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator11).set_Size(size);
		((ToolStripItem)ToolStripMenuItem9).set_Name("ToolStripMenuItem9");
		ToolStripMenuItem toolStripMenuItem9 = ToolStripMenuItem9;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem9).set_Size(size);
		((ToolStripItem)ToolStripMenuItem9).set_Text("&Quitter");
		((ToolStripDropDownItem)ToolStripMenuItem10).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripMenuItem11,
			(ToolStripItem)ToolStripMenuItem12,
			(ToolStripItem)ToolStripSeparator12,
			(ToolStripItem)ToolStripMenuItem13,
			(ToolStripItem)ToolStripMenuItem14,
			(ToolStripItem)ToolStripMenuItem15,
			(ToolStripItem)ToolStripSeparator13,
			(ToolStripItem)ToolStripMenuItem16
		});
		((ToolStripItem)ToolStripMenuItem10).set_Name("ToolStripMenuItem10");
		ToolStripMenuItem toolStripMenuItem10 = ToolStripMenuItem10;
		size = new Size(56, 20);
		((ToolStripItem)toolStripMenuItem10).set_Size(size);
		((ToolStripItem)ToolStripMenuItem10).set_Text("&Edition");
		((ToolStripItem)ToolStripMenuItem11).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem11.Image"));
		((ToolStripItem)ToolStripMenuItem11).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem11).set_Name("ToolStripMenuItem11");
		ToolStripMenuItem11.set_ShortcutKeys((Keys)131162);
		ToolStripMenuItem toolStripMenuItem11 = ToolStripMenuItem11;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem11).set_Size(size);
		((ToolStripItem)ToolStripMenuItem11).set_Text("&Annuler");
		((ToolStripItem)ToolStripMenuItem12).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem12.Image"));
		((ToolStripItem)ToolStripMenuItem12).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem12).set_Name("ToolStripMenuItem12");
		ToolStripMenuItem12.set_ShortcutKeys((Keys)131161);
		ToolStripMenuItem toolStripMenuItem12 = ToolStripMenuItem12;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem12).set_Size(size);
		((ToolStripItem)ToolStripMenuItem12).set_Text("&Rétablir");
		((ToolStripItem)ToolStripSeparator12).set_Name("ToolStripSeparator12");
		ToolStripSeparator toolStripSeparator12 = ToolStripSeparator12;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator12).set_Size(size);
		((ToolStripItem)ToolStripMenuItem13).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem13.Image"));
		((ToolStripItem)ToolStripMenuItem13).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem13).set_Name("ToolStripMenuItem13");
		ToolStripMenuItem13.set_ShortcutKeys((Keys)131160);
		ToolStripMenuItem toolStripMenuItem13 = ToolStripMenuItem13;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem13).set_Size(size);
		((ToolStripItem)ToolStripMenuItem13).set_Text("Co&uper");
		((ToolStripItem)ToolStripMenuItem14).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem14.Image"));
		((ToolStripItem)ToolStripMenuItem14).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem14).set_Name("ToolStripMenuItem14");
		ToolStripMenuItem14.set_ShortcutKeys((Keys)131139);
		ToolStripMenuItem toolStripMenuItem14 = ToolStripMenuItem14;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem14).set_Size(size);
		((ToolStripItem)ToolStripMenuItem14).set_Text("&Copier");
		((ToolStripItem)ToolStripMenuItem15).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem15.Image"));
		((ToolStripItem)ToolStripMenuItem15).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem15).set_Name("ToolStripMenuItem15");
		ToolStripMenuItem15.set_ShortcutKeys((Keys)131158);
		ToolStripMenuItem toolStripMenuItem15 = ToolStripMenuItem15;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem15).set_Size(size);
		((ToolStripItem)ToolStripMenuItem15).set_Text("&Coller");
		((ToolStripItem)ToolStripSeparator13).set_Name("ToolStripSeparator13");
		ToolStripSeparator toolStripSeparator13 = ToolStripSeparator13;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator13).set_Size(size);
		((ToolStripItem)ToolStripMenuItem16).set_Name("ToolStripMenuItem16");
		ToolStripMenuItem16.set_ShortcutKeys((Keys)131137);
		ToolStripMenuItem toolStripMenuItem16 = ToolStripMenuItem16;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem16).set_Size(size);
		((ToolStripItem)ToolStripMenuItem16).set_Text("Sélectionner &tout");
		((ToolStripDropDownItem)ToolStripMenuItem17).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolStripMenuItem18,
			(ToolStripItem)ToolStripMenuItem19
		});
		((ToolStripItem)ToolStripMenuItem17).set_Name("ToolStripMenuItem17");
		ToolStripMenuItem toolStripMenuItem17 = ToolStripMenuItem17;
		size = new Size(70, 20);
		((ToolStripItem)toolStripMenuItem17).set_Size(size);
		((ToolStripItem)ToolStripMenuItem17).set_Text("&Affichage");
		ToolStripMenuItem18.set_Checked(true);
		ToolStripMenuItem18.set_CheckOnClick(true);
		ToolStripMenuItem18.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem18).set_Name("ToolStripMenuItem18");
		ToolStripMenuItem toolStripMenuItem18 = ToolStripMenuItem18;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem18).set_Size(size);
		((ToolStripItem)ToolStripMenuItem18).set_Text("&Barre d'outils");
		ToolStripMenuItem19.set_Checked(true);
		ToolStripMenuItem19.set_CheckOnClick(true);
		ToolStripMenuItem19.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem19).set_Name("ToolStripMenuItem19");
		ToolStripMenuItem toolStripMenuItem19 = ToolStripMenuItem19;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem19).set_Size(size);
		((ToolStripItem)ToolStripMenuItem19).set_Text("&Barre d'état");
		((ToolStripDropDownItem)ToolStripMenuItem20).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripMenuItem21 });
		((ToolStripItem)ToolStripMenuItem20).set_Name("ToolStripMenuItem20");
		ToolStripMenuItem toolStripMenuItem20 = ToolStripMenuItem20;
		size = new Size(50, 20);
		((ToolStripItem)toolStripMenuItem20).set_Size(size);
		((ToolStripItem)ToolStripMenuItem20).set_Text("&Outils");
		((ToolStripItem)ToolStripMenuItem21).set_Name("ToolStripMenuItem21");
		ToolStripMenuItem toolStripMenuItem21 = ToolStripMenuItem21;
		size = new Size(116, 22);
		((ToolStripItem)toolStripMenuItem21).set_Size(size);
		((ToolStripItem)ToolStripMenuItem21).set_Text("&Options");
		((ToolStripDropDownItem)ToolStripMenuItem22).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem23,
			(ToolStripItem)ToolStripMenuItem24,
			(ToolStripItem)ToolStripMenuItem25,
			(ToolStripItem)ToolStripMenuItem26,
			(ToolStripItem)ToolStripMenuItem27,
			(ToolStripItem)ToolStripMenuItem28
		});
		((ToolStripItem)ToolStripMenuItem22).set_Name("ToolStripMenuItem22");
		ToolStripMenuItem toolStripMenuItem22 = ToolStripMenuItem22;
		size = new Size(63, 20);
		((ToolStripItem)toolStripMenuItem22).set_Size(size);
		((ToolStripItem)ToolStripMenuItem22).set_Text("F&enêtres");
		((ToolStripItem)ToolStripMenuItem23).set_Name("ToolStripMenuItem23");
		ToolStripMenuItem toolStripMenuItem23 = ToolStripMenuItem23;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem23).set_Size(size);
		((ToolStripItem)ToolStripMenuItem23).set_Text("&Nouvelle fenêtre");
		((ToolStripItem)ToolStripMenuItem24).set_Name("ToolStripMenuItem24");
		ToolStripMenuItem toolStripMenuItem24 = ToolStripMenuItem24;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem24).set_Size(size);
		((ToolStripItem)ToolStripMenuItem24).set_Text("&Cascade");
		((ToolStripItem)ToolStripMenuItem25).set_Name("ToolStripMenuItem25");
		ToolStripMenuItem toolStripMenuItem25 = ToolStripMenuItem25;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem25).set_Size(size);
		((ToolStripItem)ToolStripMenuItem25).set_Text("Mosaïque &verticale");
		((ToolStripItem)ToolStripMenuItem26).set_Name("ToolStripMenuItem26");
		ToolStripMenuItem toolStripMenuItem26 = ToolStripMenuItem26;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem26).set_Size(size);
		((ToolStripItem)ToolStripMenuItem26).set_Text("Mosaïque &horizontale");
		((ToolStripItem)ToolStripMenuItem27).set_Name("ToolStripMenuItem27");
		ToolStripMenuItem toolStripMenuItem27 = ToolStripMenuItem27;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem27).set_Size(size);
		((ToolStripItem)ToolStripMenuItem27).set_Text("&Fermer tout");
		((ToolStripItem)ToolStripMenuItem28).set_Name("ToolStripMenuItem28");
		ToolStripMenuItem toolStripMenuItem28 = ToolStripMenuItem28;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem28).set_Size(size);
		((ToolStripItem)ToolStripMenuItem28).set_Text("&Réorganiser les icônes");
		((ToolStripDropDownItem)ToolStripMenuItem29).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ToolStripMenuItem30,
			(ToolStripItem)ToolStripMenuItem31,
			(ToolStripItem)ToolStripMenuItem32,
			(ToolStripItem)ToolStripSeparator14,
			(ToolStripItem)ToolStripMenuItem33
		});
		((ToolStripItem)ToolStripMenuItem29).set_Name("ToolStripMenuItem29");
		ToolStripMenuItem toolStripMenuItem29 = ToolStripMenuItem29;
		size = new Size(24, 20);
		((ToolStripItem)toolStripMenuItem29).set_Size(size);
		((ToolStripItem)ToolStripMenuItem29).set_Text("&?");
		((ToolStripItem)ToolStripMenuItem30).set_Name("ToolStripMenuItem30");
		ToolStripMenuItem30.set_ShortcutKeys((Keys)131184);
		ToolStripMenuItem toolStripMenuItem30 = ToolStripMenuItem30;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem30).set_Size(size);
		((ToolStripItem)ToolStripMenuItem30).set_Text("&Contenu");
		((ToolStripItem)ToolStripMenuItem31).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem31.Image"));
		((ToolStripItem)ToolStripMenuItem31).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem31).set_Name("ToolStripMenuItem31");
		ToolStripMenuItem toolStripMenuItem31 = ToolStripMenuItem31;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem31).set_Size(size);
		((ToolStripItem)ToolStripMenuItem31).set_Text("&Index");
		((ToolStripItem)ToolStripMenuItem32).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem32.Image"));
		((ToolStripItem)ToolStripMenuItem32).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem32).set_Name("ToolStripMenuItem32");
		ToolStripMenuItem toolStripMenuItem32 = ToolStripMenuItem32;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem32).set_Size(size);
		((ToolStripItem)ToolStripMenuItem32).set_Text("&Rechercher");
		((ToolStripItem)ToolStripSeparator14).set_Name("ToolStripSeparator14");
		ToolStripSeparator toolStripSeparator14 = ToolStripSeparator14;
		size = new Size(163, 6);
		((ToolStripItem)toolStripSeparator14).set_Size(size);
		((ToolStripItem)ToolStripMenuItem33).set_Name("ToolStripMenuItem33");
		ToolStripMenuItem toolStripMenuItem33 = ToolStripMenuItem33;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem33).set_Size(size);
		((ToolStripItem)ToolStripMenuItem33).set_Text("À pr&opos de...");
		((ToolStripItem)ToolStripSeparator15).set_Name("ToolStripSeparator15");
		ToolStripSeparator toolStripSeparator15 = ToolStripSeparator15;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator15).set_Size(size);
		((ToolStripItem)ToolStripButton1).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton1).set_Image((Image)componentResourceManager.GetObject("ToolStripButton1.Image"));
		((ToolStripItem)ToolStripButton1).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton1).set_Name("ToolStripButton1");
		ToolStripButton toolStripButton = ToolStripButton1;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton).set_Size(size);
		((ToolStripItem)ToolStripButton1).set_Text("Aide");
		((ToolStrip)StatusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel1 });
		StatusStrip statusStrip3 = StatusStrip1;
		location = new Point(0, 409);
		((Control)statusStrip3).set_Location(location);
		((Control)StatusStrip1).set_Name("StatusStrip1");
		StatusStrip statusStrip4 = StatusStrip1;
		size = new Size(632, 22);
		((Control)statusStrip4).set_Size(size);
		((Control)StatusStrip1).set_TabIndex(11);
		((Control)StatusStrip1).set_Text("StatusStrip");
		((ToolStripItem)ToolStripStatusLabel1).set_Name("ToolStripStatusLabel1");
		ToolStripStatusLabel toolStripStatusLabel2 = ToolStripStatusLabel1;
		size = new Size(27, 17);
		((ToolStripItem)toolStripStatusLabel2).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel1).set_Text("État");
		((ToolStripItem)ToolStripButton2).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton2).set_Image((Image)componentResourceManager.GetObject("ToolStripButton2.Image"));
		((ToolStripItem)ToolStripButton2).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton2).set_Name("ToolStripButton2");
		ToolStripButton toolStripButton2 = ToolStripButton2;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton2).set_Size(size);
		((ToolStripItem)ToolStripButton2).set_Text("Aperçu avant impression");
		((ToolStripItem)ToolStripButton3).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton3).set_Image((Image)componentResourceManager.GetObject("ToolStripButton3.Image"));
		((ToolStripItem)ToolStripButton3).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton3).set_Name("ToolStripButton3");
		ToolStripButton toolStripButton3 = ToolStripButton3;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton3).set_Size(size);
		((ToolStripItem)ToolStripButton3).set_Text("Imprimer");
		((ToolStripItem)ToolStripSeparator16).set_Name("ToolStripSeparator16");
		ToolStripSeparator toolStripSeparator16 = ToolStripSeparator16;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator16).set_Size(size);
		ToolStrip1.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripButton4,
			(ToolStripItem)ToolStripButton5,
			(ToolStripItem)ToolStripButton6,
			(ToolStripItem)ToolStripSeparator16,
			(ToolStripItem)ToolStripButton3,
			(ToolStripItem)ToolStripButton2,
			(ToolStripItem)ToolStripSeparator15,
			(ToolStripItem)ToolStripButton1
		});
		ToolStrip toolStrip3 = ToolStrip1;
		location = new Point(0, 49);
		((Control)toolStrip3).set_Location(location);
		((Control)ToolStrip1).set_Name("ToolStrip1");
		ToolStrip toolStrip4 = ToolStrip1;
		size = new Size(632, 25);
		((Control)toolStrip4).set_Size(size);
		((Control)ToolStrip1).set_TabIndex(10);
		((Control)ToolStrip1).set_Text("ToolStrip");
		((ToolStripItem)ToolStripButton4).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton4).set_Image((Image)componentResourceManager.GetObject("ToolStripButton4.Image"));
		((ToolStripItem)ToolStripButton4).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton4).set_Name("ToolStripButton4");
		ToolStripButton toolStripButton4 = ToolStripButton4;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton4).set_Size(size);
		((ToolStripItem)ToolStripButton4).set_Text("Nouveau");
		((ToolStripItem)ToolStripButton5).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton5).set_Image((Image)componentResourceManager.GetObject("ToolStripButton5.Image"));
		((ToolStripItem)ToolStripButton5).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton5).set_Name("ToolStripButton5");
		ToolStripButton toolStripButton5 = ToolStripButton5;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton5).set_Size(size);
		((ToolStripItem)ToolStripButton5).set_Text("Ouvrir");
		((ToolStripItem)ToolStripButton6).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton6).set_Image((Image)componentResourceManager.GetObject("ToolStripButton6.Image"));
		((ToolStripItem)ToolStripButton6).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton6).set_Name("ToolStripButton6");
		ToolStripButton toolStripButton6 = ToolStripButton6;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton6).set_Size(size);
		((ToolStripItem)ToolStripButton6).set_Text("Enregistrer");
		((ToolStrip)MenuStrip2).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem34,
			(ToolStripItem)ToolStripMenuItem43,
			(ToolStripItem)ToolStripMenuItem50,
			(ToolStripItem)ToolStripMenuItem53,
			(ToolStripItem)ToolStripMenuItem55,
			(ToolStripItem)ToolStripMenuItem62
		});
		MenuStrip menuStrip5 = MenuStrip2;
		location = new Point(0, 123);
		((Control)menuStrip5).set_Location(location);
		MenuStrip2.set_MdiWindowListItem(ToolStripMenuItem55);
		((Control)MenuStrip2).set_Name("MenuStrip2");
		MenuStrip menuStrip6 = MenuStrip2;
		size = new Size(632, 24);
		((Control)menuStrip6).set_Size(size);
		((Control)MenuStrip2).set_TabIndex(12);
		((Control)MenuStrip2).set_Text("MenuStrip2");
		((ToolStripDropDownItem)ToolStripMenuItem34).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)ToolStripMenuItem35,
			(ToolStripItem)ToolStripMenuItem36,
			(ToolStripItem)ToolStripSeparator17,
			(ToolStripItem)ToolStripMenuItem37,
			(ToolStripItem)ToolStripMenuItem38,
			(ToolStripItem)ToolStripSeparator18,
			(ToolStripItem)ToolStripMenuItem39,
			(ToolStripItem)ToolStripMenuItem40,
			(ToolStripItem)ToolStripMenuItem41,
			(ToolStripItem)ToolStripSeparator19,
			(ToolStripItem)ToolStripMenuItem42
		});
		((ToolStripItem)ToolStripMenuItem34).set_ImageTransparentColor(SystemColors.ActiveBorder);
		((ToolStripItem)ToolStripMenuItem34).set_Name("ToolStripMenuItem34");
		ToolStripMenuItem toolStripMenuItem34 = ToolStripMenuItem34;
		size = new Size(54, 20);
		((ToolStripItem)toolStripMenuItem34).set_Size(size);
		((ToolStripItem)ToolStripMenuItem34).set_Text("&Fichier");
		((ToolStripItem)ToolStripMenuItem35).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem35.Image"));
		((ToolStripItem)ToolStripMenuItem35).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem35).set_Name("ToolStripMenuItem35");
		ToolStripMenuItem35.set_ShortcutKeys((Keys)131150);
		ToolStripMenuItem toolStripMenuItem35 = ToolStripMenuItem35;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem35).set_Size(size);
		((ToolStripItem)ToolStripMenuItem35).set_Text("&Nouveau");
		((ToolStripItem)ToolStripMenuItem36).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem36.Image"));
		((ToolStripItem)ToolStripMenuItem36).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem36).set_Name("ToolStripMenuItem36");
		ToolStripMenuItem36.set_ShortcutKeys((Keys)131151);
		ToolStripMenuItem toolStripMenuItem36 = ToolStripMenuItem36;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem36).set_Size(size);
		((ToolStripItem)ToolStripMenuItem36).set_Text("&Ouvrir");
		((ToolStripItem)ToolStripSeparator17).set_Name("ToolStripSeparator17");
		ToolStripSeparator toolStripSeparator17 = ToolStripSeparator17;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator17).set_Size(size);
		((ToolStripItem)ToolStripMenuItem37).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem37.Image"));
		((ToolStripItem)ToolStripMenuItem37).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem37).set_Name("ToolStripMenuItem37");
		ToolStripMenuItem37.set_ShortcutKeys((Keys)131155);
		ToolStripMenuItem toolStripMenuItem37 = ToolStripMenuItem37;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem37).set_Size(size);
		((ToolStripItem)ToolStripMenuItem37).set_Text("&Enregistrer");
		((ToolStripItem)ToolStripMenuItem38).set_Name("ToolStripMenuItem38");
		ToolStripMenuItem toolStripMenuItem38 = ToolStripMenuItem38;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem38).set_Size(size);
		((ToolStripItem)ToolStripMenuItem38).set_Text("Enregistrer &sous");
		((ToolStripItem)ToolStripSeparator18).set_Name("ToolStripSeparator18");
		ToolStripSeparator toolStripSeparator18 = ToolStripSeparator18;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator18).set_Size(size);
		((ToolStripItem)ToolStripMenuItem39).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem39.Image"));
		((ToolStripItem)ToolStripMenuItem39).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem39).set_Name("ToolStripMenuItem39");
		ToolStripMenuItem39.set_ShortcutKeys((Keys)131152);
		ToolStripMenuItem toolStripMenuItem39 = ToolStripMenuItem39;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem39).set_Size(size);
		((ToolStripItem)ToolStripMenuItem39).set_Text("&Imprimer");
		((ToolStripItem)ToolStripMenuItem40).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem40.Image"));
		((ToolStripItem)ToolStripMenuItem40).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem40).set_Name("ToolStripMenuItem40");
		ToolStripMenuItem toolStripMenuItem40 = ToolStripMenuItem40;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem40).set_Size(size);
		((ToolStripItem)ToolStripMenuItem40).set_Text("Aperçu a&vant impression");
		((ToolStripItem)ToolStripMenuItem41).set_Name("ToolStripMenuItem41");
		ToolStripMenuItem toolStripMenuItem41 = ToolStripMenuItem41;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem41).set_Size(size);
		((ToolStripItem)ToolStripMenuItem41).set_Text("Configuration de l'impression");
		((ToolStripItem)ToolStripSeparator19).set_Name("ToolStripSeparator19");
		ToolStripSeparator toolStripSeparator19 = ToolStripSeparator19;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator19).set_Size(size);
		((ToolStripItem)ToolStripMenuItem42).set_Name("ToolStripMenuItem42");
		ToolStripMenuItem toolStripMenuItem42 = ToolStripMenuItem42;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem42).set_Size(size);
		((ToolStripItem)ToolStripMenuItem42).set_Text("&Quitter");
		((ToolStripDropDownItem)ToolStripMenuItem43).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripMenuItem44,
			(ToolStripItem)ToolStripMenuItem45,
			(ToolStripItem)ToolStripSeparator20,
			(ToolStripItem)ToolStripMenuItem46,
			(ToolStripItem)ToolStripMenuItem47,
			(ToolStripItem)ToolStripMenuItem48,
			(ToolStripItem)ToolStripSeparator21,
			(ToolStripItem)ToolStripMenuItem49
		});
		((ToolStripItem)ToolStripMenuItem43).set_Name("ToolStripMenuItem43");
		ToolStripMenuItem toolStripMenuItem43 = ToolStripMenuItem43;
		size = new Size(56, 20);
		((ToolStripItem)toolStripMenuItem43).set_Size(size);
		((ToolStripItem)ToolStripMenuItem43).set_Text("&Edition");
		((ToolStripItem)ToolStripMenuItem44).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem44.Image"));
		((ToolStripItem)ToolStripMenuItem44).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem44).set_Name("ToolStripMenuItem44");
		ToolStripMenuItem44.set_ShortcutKeys((Keys)131162);
		ToolStripMenuItem toolStripMenuItem44 = ToolStripMenuItem44;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem44).set_Size(size);
		((ToolStripItem)ToolStripMenuItem44).set_Text("&Annuler");
		((ToolStripItem)ToolStripMenuItem45).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem45.Image"));
		((ToolStripItem)ToolStripMenuItem45).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem45).set_Name("ToolStripMenuItem45");
		ToolStripMenuItem45.set_ShortcutKeys((Keys)131161);
		ToolStripMenuItem toolStripMenuItem45 = ToolStripMenuItem45;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem45).set_Size(size);
		((ToolStripItem)ToolStripMenuItem45).set_Text("&Rétablir");
		((ToolStripItem)ToolStripSeparator20).set_Name("ToolStripSeparator20");
		ToolStripSeparator toolStripSeparator20 = ToolStripSeparator20;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator20).set_Size(size);
		((ToolStripItem)ToolStripMenuItem46).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem46.Image"));
		((ToolStripItem)ToolStripMenuItem46).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem46).set_Name("ToolStripMenuItem46");
		ToolStripMenuItem46.set_ShortcutKeys((Keys)131160);
		ToolStripMenuItem toolStripMenuItem46 = ToolStripMenuItem46;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem46).set_Size(size);
		((ToolStripItem)ToolStripMenuItem46).set_Text("Co&uper");
		((ToolStripItem)ToolStripMenuItem47).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem47.Image"));
		((ToolStripItem)ToolStripMenuItem47).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem47).set_Name("ToolStripMenuItem47");
		ToolStripMenuItem47.set_ShortcutKeys((Keys)131139);
		ToolStripMenuItem toolStripMenuItem47 = ToolStripMenuItem47;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem47).set_Size(size);
		((ToolStripItem)ToolStripMenuItem47).set_Text("&Copier");
		((ToolStripItem)ToolStripMenuItem48).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem48.Image"));
		((ToolStripItem)ToolStripMenuItem48).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem48).set_Name("ToolStripMenuItem48");
		ToolStripMenuItem48.set_ShortcutKeys((Keys)131158);
		ToolStripMenuItem toolStripMenuItem48 = ToolStripMenuItem48;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem48).set_Size(size);
		((ToolStripItem)ToolStripMenuItem48).set_Text("&Coller");
		((ToolStripItem)ToolStripSeparator21).set_Name("ToolStripSeparator21");
		ToolStripSeparator toolStripSeparator21 = ToolStripSeparator21;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator21).set_Size(size);
		((ToolStripItem)ToolStripMenuItem49).set_Name("ToolStripMenuItem49");
		ToolStripMenuItem49.set_ShortcutKeys((Keys)131137);
		ToolStripMenuItem toolStripMenuItem49 = ToolStripMenuItem49;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem49).set_Size(size);
		((ToolStripItem)ToolStripMenuItem49).set_Text("Sélectionner &tout");
		((ToolStripDropDownItem)ToolStripMenuItem50).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolStripMenuItem51,
			(ToolStripItem)ToolStripMenuItem52
		});
		((ToolStripItem)ToolStripMenuItem50).set_Name("ToolStripMenuItem50");
		ToolStripMenuItem toolStripMenuItem50 = ToolStripMenuItem50;
		size = new Size(70, 20);
		((ToolStripItem)toolStripMenuItem50).set_Size(size);
		((ToolStripItem)ToolStripMenuItem50).set_Text("&Affichage");
		ToolStripMenuItem51.set_Checked(true);
		ToolStripMenuItem51.set_CheckOnClick(true);
		ToolStripMenuItem51.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem51).set_Name("ToolStripMenuItem51");
		ToolStripMenuItem toolStripMenuItem51 = ToolStripMenuItem51;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem51).set_Size(size);
		((ToolStripItem)ToolStripMenuItem51).set_Text("&Barre d'outils");
		ToolStripMenuItem52.set_Checked(true);
		ToolStripMenuItem52.set_CheckOnClick(true);
		ToolStripMenuItem52.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem52).set_Name("ToolStripMenuItem52");
		ToolStripMenuItem toolStripMenuItem52 = ToolStripMenuItem52;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem52).set_Size(size);
		((ToolStripItem)ToolStripMenuItem52).set_Text("&Barre d'état");
		((ToolStripDropDownItem)ToolStripMenuItem53).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripMenuItem54 });
		((ToolStripItem)ToolStripMenuItem53).set_Name("ToolStripMenuItem53");
		ToolStripMenuItem toolStripMenuItem53 = ToolStripMenuItem53;
		size = new Size(50, 20);
		((ToolStripItem)toolStripMenuItem53).set_Size(size);
		((ToolStripItem)ToolStripMenuItem53).set_Text("&Outils");
		((ToolStripItem)ToolStripMenuItem54).set_Name("ToolStripMenuItem54");
		ToolStripMenuItem toolStripMenuItem54 = ToolStripMenuItem54;
		size = new Size(116, 22);
		((ToolStripItem)toolStripMenuItem54).set_Size(size);
		((ToolStripItem)ToolStripMenuItem54).set_Text("&Options");
		((ToolStripDropDownItem)ToolStripMenuItem55).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem56,
			(ToolStripItem)ToolStripMenuItem57,
			(ToolStripItem)ToolStripMenuItem58,
			(ToolStripItem)ToolStripMenuItem59,
			(ToolStripItem)ToolStripMenuItem60,
			(ToolStripItem)ToolStripMenuItem61
		});
		((ToolStripItem)ToolStripMenuItem55).set_Name("ToolStripMenuItem55");
		ToolStripMenuItem toolStripMenuItem55 = ToolStripMenuItem55;
		size = new Size(63, 20);
		((ToolStripItem)toolStripMenuItem55).set_Size(size);
		((ToolStripItem)ToolStripMenuItem55).set_Text("F&enêtres");
		((ToolStripItem)ToolStripMenuItem56).set_Name("ToolStripMenuItem56");
		ToolStripMenuItem toolStripMenuItem56 = ToolStripMenuItem56;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem56).set_Size(size);
		((ToolStripItem)ToolStripMenuItem56).set_Text("&Nouvelle fenêtre");
		((ToolStripItem)ToolStripMenuItem57).set_Name("ToolStripMenuItem57");
		ToolStripMenuItem toolStripMenuItem57 = ToolStripMenuItem57;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem57).set_Size(size);
		((ToolStripItem)ToolStripMenuItem57).set_Text("&Cascade");
		((ToolStripItem)ToolStripMenuItem58).set_Name("ToolStripMenuItem58");
		ToolStripMenuItem toolStripMenuItem58 = ToolStripMenuItem58;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem58).set_Size(size);
		((ToolStripItem)ToolStripMenuItem58).set_Text("Mosaïque &verticale");
		((ToolStripItem)ToolStripMenuItem59).set_Name("ToolStripMenuItem59");
		ToolStripMenuItem toolStripMenuItem59 = ToolStripMenuItem59;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem59).set_Size(size);
		((ToolStripItem)ToolStripMenuItem59).set_Text("Mosaïque &horizontale");
		((ToolStripItem)ToolStripMenuItem60).set_Name("ToolStripMenuItem60");
		ToolStripMenuItem toolStripMenuItem60 = ToolStripMenuItem60;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem60).set_Size(size);
		((ToolStripItem)ToolStripMenuItem60).set_Text("&Fermer tout");
		((ToolStripItem)ToolStripMenuItem61).set_Name("ToolStripMenuItem61");
		ToolStripMenuItem toolStripMenuItem61 = ToolStripMenuItem61;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem61).set_Size(size);
		((ToolStripItem)ToolStripMenuItem61).set_Text("&Réorganiser les icônes");
		((ToolStripDropDownItem)ToolStripMenuItem62).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ToolStripMenuItem63,
			(ToolStripItem)ToolStripMenuItem64,
			(ToolStripItem)ToolStripMenuItem65,
			(ToolStripItem)ToolStripSeparator22,
			(ToolStripItem)ToolStripMenuItem66
		});
		((ToolStripItem)ToolStripMenuItem62).set_Name("ToolStripMenuItem62");
		ToolStripMenuItem toolStripMenuItem62 = ToolStripMenuItem62;
		size = new Size(24, 20);
		((ToolStripItem)toolStripMenuItem62).set_Size(size);
		((ToolStripItem)ToolStripMenuItem62).set_Text("&?");
		((ToolStripItem)ToolStripMenuItem63).set_Name("ToolStripMenuItem63");
		ToolStripMenuItem63.set_ShortcutKeys((Keys)131184);
		ToolStripMenuItem toolStripMenuItem63 = ToolStripMenuItem63;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem63).set_Size(size);
		((ToolStripItem)ToolStripMenuItem63).set_Text("&Contenu");
		((ToolStripItem)ToolStripMenuItem64).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem64.Image"));
		((ToolStripItem)ToolStripMenuItem64).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem64).set_Name("ToolStripMenuItem64");
		ToolStripMenuItem toolStripMenuItem64 = ToolStripMenuItem64;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem64).set_Size(size);
		((ToolStripItem)ToolStripMenuItem64).set_Text("&Index");
		((ToolStripItem)ToolStripMenuItem65).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem65.Image"));
		((ToolStripItem)ToolStripMenuItem65).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem65).set_Name("ToolStripMenuItem65");
		ToolStripMenuItem toolStripMenuItem65 = ToolStripMenuItem65;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem65).set_Size(size);
		((ToolStripItem)ToolStripMenuItem65).set_Text("&Rechercher");
		((ToolStripItem)ToolStripSeparator22).set_Name("ToolStripSeparator22");
		ToolStripSeparator toolStripSeparator22 = ToolStripSeparator22;
		size = new Size(163, 6);
		((ToolStripItem)toolStripSeparator22).set_Size(size);
		((ToolStripItem)ToolStripMenuItem66).set_Name("ToolStripMenuItem66");
		ToolStripMenuItem toolStripMenuItem66 = ToolStripMenuItem66;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem66).set_Size(size);
		((ToolStripItem)ToolStripMenuItem66).set_Text("À pr&opos de...");
		((ToolStripItem)ToolStripSeparator23).set_Name("ToolStripSeparator23");
		ToolStripSeparator toolStripSeparator23 = ToolStripSeparator23;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator23).set_Size(size);
		((ToolStripItem)ToolStripButton7).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton7).set_Image((Image)componentResourceManager.GetObject("ToolStripButton7.Image"));
		((ToolStripItem)ToolStripButton7).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton7).set_Name("ToolStripButton7");
		ToolStripButton toolStripButton7 = ToolStripButton7;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton7).set_Size(size);
		((ToolStripItem)ToolStripButton7).set_Text("Aide");
		((ToolStrip)StatusStrip2).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel2 });
		StatusStrip statusStrip5 = StatusStrip2;
		location = new Point(0, 387);
		((Control)statusStrip5).set_Location(location);
		((Control)StatusStrip2).set_Name("StatusStrip2");
		StatusStrip statusStrip6 = StatusStrip2;
		size = new Size(632, 22);
		((Control)statusStrip6).set_Size(size);
		((Control)StatusStrip2).set_TabIndex(14);
		((Control)StatusStrip2).set_Text("StatusStrip");
		((ToolStripItem)ToolStripStatusLabel2).set_Name("ToolStripStatusLabel2");
		ToolStripStatusLabel toolStripStatusLabel3 = ToolStripStatusLabel2;
		size = new Size(27, 17);
		((ToolStripItem)toolStripStatusLabel3).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel2).set_Text("État");
		((ToolStripItem)ToolStripButton8).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton8).set_Image((Image)componentResourceManager.GetObject("ToolStripButton8.Image"));
		((ToolStripItem)ToolStripButton8).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton8).set_Name("ToolStripButton8");
		ToolStripButton toolStripButton8 = ToolStripButton8;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton8).set_Size(size);
		((ToolStripItem)ToolStripButton8).set_Text("Aperçu avant impression");
		((ToolStripItem)ToolStripButton9).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton9).set_Image((Image)componentResourceManager.GetObject("ToolStripButton9.Image"));
		((ToolStripItem)ToolStripButton9).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton9).set_Name("ToolStripButton9");
		ToolStripButton toolStripButton9 = ToolStripButton9;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton9).set_Size(size);
		((ToolStripItem)ToolStripButton9).set_Text("Imprimer");
		((ToolStripItem)ToolStripSeparator24).set_Name("ToolStripSeparator24");
		ToolStripSeparator toolStripSeparator24 = ToolStripSeparator24;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator24).set_Size(size);
		ToolStrip2.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripButton10,
			(ToolStripItem)ToolStripButton11,
			(ToolStripItem)ToolStripButton12,
			(ToolStripItem)ToolStripSeparator24,
			(ToolStripItem)ToolStripButton9,
			(ToolStripItem)ToolStripButton8,
			(ToolStripItem)ToolStripSeparator23,
			(ToolStripItem)ToolStripButton7
		});
		ToolStrip toolStrip5 = ToolStrip2;
		location = new Point(0, 98);
		((Control)toolStrip5).set_Location(location);
		((Control)ToolStrip2).set_Name("ToolStrip2");
		ToolStrip toolStrip6 = ToolStrip2;
		size = new Size(632, 25);
		((Control)toolStrip6).set_Size(size);
		((Control)ToolStrip2).set_TabIndex(13);
		((Control)ToolStrip2).set_Text("ToolStrip");
		((ToolStripItem)ToolStripButton10).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton10).set_Image((Image)componentResourceManager.GetObject("ToolStripButton10.Image"));
		((ToolStripItem)ToolStripButton10).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton10).set_Name("ToolStripButton10");
		ToolStripButton toolStripButton10 = ToolStripButton10;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton10).set_Size(size);
		((ToolStripItem)ToolStripButton10).set_Text("Nouveau");
		((ToolStripItem)ToolStripButton11).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton11).set_Image((Image)componentResourceManager.GetObject("ToolStripButton11.Image"));
		((ToolStripItem)ToolStripButton11).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton11).set_Name("ToolStripButton11");
		ToolStripButton toolStripButton11 = ToolStripButton11;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton11).set_Size(size);
		((ToolStripItem)ToolStripButton11).set_Text("Ouvrir");
		((ToolStripItem)ToolStripButton12).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton12).set_Image((Image)componentResourceManager.GetObject("ToolStripButton12.Image"));
		((ToolStripItem)ToolStripButton12).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton12).set_Name("ToolStripButton12");
		ToolStripButton toolStripButton12 = ToolStripButton12;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton12).set_Size(size);
		((ToolStripItem)ToolStripButton12).set_Text("Enregistrer");
		((ToolStrip)MenuStrip3).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem67,
			(ToolStripItem)ToolStripMenuItem76,
			(ToolStripItem)ToolStripMenuItem83,
			(ToolStripItem)ToolStripMenuItem86,
			(ToolStripItem)ToolStripMenuItem88,
			(ToolStripItem)ToolStripMenuItem95
		});
		MenuStrip menuStrip7 = MenuStrip3;
		location = new Point(0, 172);
		((Control)menuStrip7).set_Location(location);
		MenuStrip3.set_MdiWindowListItem(ToolStripMenuItem88);
		((Control)MenuStrip3).set_Name("MenuStrip3");
		MenuStrip menuStrip8 = MenuStrip3;
		size = new Size(632, 24);
		((Control)menuStrip8).set_Size(size);
		((Control)MenuStrip3).set_TabIndex(15);
		((Control)MenuStrip3).set_Text("MenuStrip3");
		((ToolStripDropDownItem)ToolStripMenuItem67).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)ToolStripMenuItem68,
			(ToolStripItem)ToolStripMenuItem69,
			(ToolStripItem)ToolStripSeparator25,
			(ToolStripItem)ToolStripMenuItem70,
			(ToolStripItem)ToolStripMenuItem71,
			(ToolStripItem)ToolStripSeparator26,
			(ToolStripItem)ToolStripMenuItem72,
			(ToolStripItem)ToolStripMenuItem73,
			(ToolStripItem)ToolStripMenuItem74,
			(ToolStripItem)ToolStripSeparator27,
			(ToolStripItem)ToolStripMenuItem75
		});
		((ToolStripItem)ToolStripMenuItem67).set_ImageTransparentColor(SystemColors.ActiveBorder);
		((ToolStripItem)ToolStripMenuItem67).set_Name("ToolStripMenuItem67");
		ToolStripMenuItem toolStripMenuItem67 = ToolStripMenuItem67;
		size = new Size(54, 20);
		((ToolStripItem)toolStripMenuItem67).set_Size(size);
		((ToolStripItem)ToolStripMenuItem67).set_Text("&Fichier");
		((ToolStripItem)ToolStripMenuItem68).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem68.Image"));
		((ToolStripItem)ToolStripMenuItem68).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem68).set_Name("ToolStripMenuItem68");
		ToolStripMenuItem68.set_ShortcutKeys((Keys)131150);
		ToolStripMenuItem toolStripMenuItem68 = ToolStripMenuItem68;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem68).set_Size(size);
		((ToolStripItem)ToolStripMenuItem68).set_Text("&Nouveau");
		((ToolStripItem)ToolStripMenuItem69).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem69.Image"));
		((ToolStripItem)ToolStripMenuItem69).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem69).set_Name("ToolStripMenuItem69");
		ToolStripMenuItem69.set_ShortcutKeys((Keys)131151);
		ToolStripMenuItem toolStripMenuItem69 = ToolStripMenuItem69;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem69).set_Size(size);
		((ToolStripItem)ToolStripMenuItem69).set_Text("&Ouvrir");
		((ToolStripItem)ToolStripSeparator25).set_Name("ToolStripSeparator25");
		ToolStripSeparator toolStripSeparator25 = ToolStripSeparator25;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator25).set_Size(size);
		((ToolStripItem)ToolStripMenuItem70).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem70.Image"));
		((ToolStripItem)ToolStripMenuItem70).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem70).set_Name("ToolStripMenuItem70");
		ToolStripMenuItem70.set_ShortcutKeys((Keys)131155);
		ToolStripMenuItem toolStripMenuItem70 = ToolStripMenuItem70;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem70).set_Size(size);
		((ToolStripItem)ToolStripMenuItem70).set_Text("&Enregistrer");
		((ToolStripItem)ToolStripMenuItem71).set_Name("ToolStripMenuItem71");
		ToolStripMenuItem toolStripMenuItem71 = ToolStripMenuItem71;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem71).set_Size(size);
		((ToolStripItem)ToolStripMenuItem71).set_Text("Enregistrer &sous");
		((ToolStripItem)ToolStripSeparator26).set_Name("ToolStripSeparator26");
		ToolStripSeparator toolStripSeparator26 = ToolStripSeparator26;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator26).set_Size(size);
		((ToolStripItem)ToolStripMenuItem72).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem72.Image"));
		((ToolStripItem)ToolStripMenuItem72).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem72).set_Name("ToolStripMenuItem72");
		ToolStripMenuItem72.set_ShortcutKeys((Keys)131152);
		ToolStripMenuItem toolStripMenuItem72 = ToolStripMenuItem72;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem72).set_Size(size);
		((ToolStripItem)ToolStripMenuItem72).set_Text("&Imprimer");
		((ToolStripItem)ToolStripMenuItem73).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem73.Image"));
		((ToolStripItem)ToolStripMenuItem73).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem73).set_Name("ToolStripMenuItem73");
		ToolStripMenuItem toolStripMenuItem73 = ToolStripMenuItem73;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem73).set_Size(size);
		((ToolStripItem)ToolStripMenuItem73).set_Text("Aperçu a&vant impression");
		((ToolStripItem)ToolStripMenuItem74).set_Name("ToolStripMenuItem74");
		ToolStripMenuItem toolStripMenuItem74 = ToolStripMenuItem74;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem74).set_Size(size);
		((ToolStripItem)ToolStripMenuItem74).set_Text("Configuration de l'impression");
		((ToolStripItem)ToolStripSeparator27).set_Name("ToolStripSeparator27");
		ToolStripSeparator toolStripSeparator27 = ToolStripSeparator27;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator27).set_Size(size);
		((ToolStripItem)ToolStripMenuItem75).set_Name("ToolStripMenuItem75");
		ToolStripMenuItem toolStripMenuItem75 = ToolStripMenuItem75;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem75).set_Size(size);
		((ToolStripItem)ToolStripMenuItem75).set_Text("&Quitter");
		((ToolStripDropDownItem)ToolStripMenuItem76).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripMenuItem77,
			(ToolStripItem)ToolStripMenuItem78,
			(ToolStripItem)ToolStripSeparator28,
			(ToolStripItem)ToolStripMenuItem79,
			(ToolStripItem)ToolStripMenuItem80,
			(ToolStripItem)ToolStripMenuItem81,
			(ToolStripItem)ToolStripSeparator29,
			(ToolStripItem)ToolStripMenuItem82
		});
		((ToolStripItem)ToolStripMenuItem76).set_Name("ToolStripMenuItem76");
		ToolStripMenuItem toolStripMenuItem76 = ToolStripMenuItem76;
		size = new Size(56, 20);
		((ToolStripItem)toolStripMenuItem76).set_Size(size);
		((ToolStripItem)ToolStripMenuItem76).set_Text("&Edition");
		((ToolStripItem)ToolStripMenuItem77).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem77.Image"));
		((ToolStripItem)ToolStripMenuItem77).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem77).set_Name("ToolStripMenuItem77");
		ToolStripMenuItem77.set_ShortcutKeys((Keys)131162);
		ToolStripMenuItem toolStripMenuItem77 = ToolStripMenuItem77;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem77).set_Size(size);
		((ToolStripItem)ToolStripMenuItem77).set_Text("&Annuler");
		((ToolStripItem)ToolStripMenuItem78).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem78.Image"));
		((ToolStripItem)ToolStripMenuItem78).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem78).set_Name("ToolStripMenuItem78");
		ToolStripMenuItem78.set_ShortcutKeys((Keys)131161);
		ToolStripMenuItem toolStripMenuItem78 = ToolStripMenuItem78;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem78).set_Size(size);
		((ToolStripItem)ToolStripMenuItem78).set_Text("&Rétablir");
		((ToolStripItem)ToolStripSeparator28).set_Name("ToolStripSeparator28");
		ToolStripSeparator toolStripSeparator28 = ToolStripSeparator28;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator28).set_Size(size);
		((ToolStripItem)ToolStripMenuItem79).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem79.Image"));
		((ToolStripItem)ToolStripMenuItem79).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem79).set_Name("ToolStripMenuItem79");
		ToolStripMenuItem79.set_ShortcutKeys((Keys)131160);
		ToolStripMenuItem toolStripMenuItem79 = ToolStripMenuItem79;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem79).set_Size(size);
		((ToolStripItem)ToolStripMenuItem79).set_Text("Co&uper");
		((ToolStripItem)ToolStripMenuItem80).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem80.Image"));
		((ToolStripItem)ToolStripMenuItem80).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem80).set_Name("ToolStripMenuItem80");
		ToolStripMenuItem80.set_ShortcutKeys((Keys)131139);
		ToolStripMenuItem toolStripMenuItem80 = ToolStripMenuItem80;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem80).set_Size(size);
		((ToolStripItem)ToolStripMenuItem80).set_Text("&Copier");
		((ToolStripItem)ToolStripMenuItem81).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem81.Image"));
		((ToolStripItem)ToolStripMenuItem81).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem81).set_Name("ToolStripMenuItem81");
		ToolStripMenuItem81.set_ShortcutKeys((Keys)131158);
		ToolStripMenuItem toolStripMenuItem81 = ToolStripMenuItem81;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem81).set_Size(size);
		((ToolStripItem)ToolStripMenuItem81).set_Text("&Coller");
		((ToolStripItem)ToolStripSeparator29).set_Name("ToolStripSeparator29");
		ToolStripSeparator toolStripSeparator29 = ToolStripSeparator29;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator29).set_Size(size);
		((ToolStripItem)ToolStripMenuItem82).set_Name("ToolStripMenuItem82");
		ToolStripMenuItem82.set_ShortcutKeys((Keys)131137);
		ToolStripMenuItem toolStripMenuItem82 = ToolStripMenuItem82;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem82).set_Size(size);
		((ToolStripItem)ToolStripMenuItem82).set_Text("Sélectionner &tout");
		((ToolStripDropDownItem)ToolStripMenuItem83).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolStripMenuItem84,
			(ToolStripItem)ToolStripMenuItem85
		});
		((ToolStripItem)ToolStripMenuItem83).set_Name("ToolStripMenuItem83");
		ToolStripMenuItem toolStripMenuItem83 = ToolStripMenuItem83;
		size = new Size(70, 20);
		((ToolStripItem)toolStripMenuItem83).set_Size(size);
		((ToolStripItem)ToolStripMenuItem83).set_Text("&Affichage");
		ToolStripMenuItem84.set_Checked(true);
		ToolStripMenuItem84.set_CheckOnClick(true);
		ToolStripMenuItem84.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem84).set_Name("ToolStripMenuItem84");
		ToolStripMenuItem toolStripMenuItem84 = ToolStripMenuItem84;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem84).set_Size(size);
		((ToolStripItem)ToolStripMenuItem84).set_Text("&Barre d'outils");
		ToolStripMenuItem85.set_Checked(true);
		ToolStripMenuItem85.set_CheckOnClick(true);
		ToolStripMenuItem85.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem85).set_Name("ToolStripMenuItem85");
		ToolStripMenuItem toolStripMenuItem85 = ToolStripMenuItem85;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem85).set_Size(size);
		((ToolStripItem)ToolStripMenuItem85).set_Text("&Barre d'état");
		((ToolStripDropDownItem)ToolStripMenuItem86).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripMenuItem87 });
		((ToolStripItem)ToolStripMenuItem86).set_Name("ToolStripMenuItem86");
		ToolStripMenuItem toolStripMenuItem86 = ToolStripMenuItem86;
		size = new Size(50, 20);
		((ToolStripItem)toolStripMenuItem86).set_Size(size);
		((ToolStripItem)ToolStripMenuItem86).set_Text("&Outils");
		((ToolStripItem)ToolStripMenuItem87).set_Name("ToolStripMenuItem87");
		ToolStripMenuItem toolStripMenuItem87 = ToolStripMenuItem87;
		size = new Size(116, 22);
		((ToolStripItem)toolStripMenuItem87).set_Size(size);
		((ToolStripItem)ToolStripMenuItem87).set_Text("&Options");
		((ToolStripDropDownItem)ToolStripMenuItem88).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem89,
			(ToolStripItem)ToolStripMenuItem90,
			(ToolStripItem)ToolStripMenuItem91,
			(ToolStripItem)ToolStripMenuItem92,
			(ToolStripItem)ToolStripMenuItem93,
			(ToolStripItem)ToolStripMenuItem94
		});
		((ToolStripItem)ToolStripMenuItem88).set_Name("ToolStripMenuItem88");
		ToolStripMenuItem toolStripMenuItem88 = ToolStripMenuItem88;
		size = new Size(63, 20);
		((ToolStripItem)toolStripMenuItem88).set_Size(size);
		((ToolStripItem)ToolStripMenuItem88).set_Text("F&enêtres");
		((ToolStripItem)ToolStripMenuItem89).set_Name("ToolStripMenuItem89");
		ToolStripMenuItem toolStripMenuItem89 = ToolStripMenuItem89;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem89).set_Size(size);
		((ToolStripItem)ToolStripMenuItem89).set_Text("&Nouvelle fenêtre");
		((ToolStripItem)ToolStripMenuItem90).set_Name("ToolStripMenuItem90");
		ToolStripMenuItem toolStripMenuItem90 = ToolStripMenuItem90;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem90).set_Size(size);
		((ToolStripItem)ToolStripMenuItem90).set_Text("&Cascade");
		((ToolStripItem)ToolStripMenuItem91).set_Name("ToolStripMenuItem91");
		ToolStripMenuItem toolStripMenuItem91 = ToolStripMenuItem91;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem91).set_Size(size);
		((ToolStripItem)ToolStripMenuItem91).set_Text("Mosaïque &verticale");
		((ToolStripItem)ToolStripMenuItem92).set_Name("ToolStripMenuItem92");
		ToolStripMenuItem toolStripMenuItem92 = ToolStripMenuItem92;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem92).set_Size(size);
		((ToolStripItem)ToolStripMenuItem92).set_Text("Mosaïque &horizontale");
		((ToolStripItem)ToolStripMenuItem93).set_Name("ToolStripMenuItem93");
		ToolStripMenuItem toolStripMenuItem93 = ToolStripMenuItem93;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem93).set_Size(size);
		((ToolStripItem)ToolStripMenuItem93).set_Text("&Fermer tout");
		((ToolStripItem)ToolStripMenuItem94).set_Name("ToolStripMenuItem94");
		ToolStripMenuItem toolStripMenuItem94 = ToolStripMenuItem94;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem94).set_Size(size);
		((ToolStripItem)ToolStripMenuItem94).set_Text("&Réorganiser les icônes");
		((ToolStripDropDownItem)ToolStripMenuItem95).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ToolStripMenuItem96,
			(ToolStripItem)ToolStripMenuItem97,
			(ToolStripItem)ToolStripMenuItem98,
			(ToolStripItem)ToolStripSeparator30,
			(ToolStripItem)ToolStripMenuItem99
		});
		((ToolStripItem)ToolStripMenuItem95).set_Name("ToolStripMenuItem95");
		ToolStripMenuItem toolStripMenuItem95 = ToolStripMenuItem95;
		size = new Size(24, 20);
		((ToolStripItem)toolStripMenuItem95).set_Size(size);
		((ToolStripItem)ToolStripMenuItem95).set_Text("&?");
		((ToolStripItem)ToolStripMenuItem96).set_Name("ToolStripMenuItem96");
		ToolStripMenuItem96.set_ShortcutKeys((Keys)131184);
		ToolStripMenuItem toolStripMenuItem96 = ToolStripMenuItem96;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem96).set_Size(size);
		((ToolStripItem)ToolStripMenuItem96).set_Text("&Contenu");
		((ToolStripItem)ToolStripMenuItem97).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem97.Image"));
		((ToolStripItem)ToolStripMenuItem97).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem97).set_Name("ToolStripMenuItem97");
		ToolStripMenuItem toolStripMenuItem97 = ToolStripMenuItem97;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem97).set_Size(size);
		((ToolStripItem)ToolStripMenuItem97).set_Text("&Index");
		((ToolStripItem)ToolStripMenuItem98).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem98.Image"));
		((ToolStripItem)ToolStripMenuItem98).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem98).set_Name("ToolStripMenuItem98");
		ToolStripMenuItem toolStripMenuItem98 = ToolStripMenuItem98;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem98).set_Size(size);
		((ToolStripItem)ToolStripMenuItem98).set_Text("&Rechercher");
		((ToolStripItem)ToolStripSeparator30).set_Name("ToolStripSeparator30");
		ToolStripSeparator toolStripSeparator30 = ToolStripSeparator30;
		size = new Size(163, 6);
		((ToolStripItem)toolStripSeparator30).set_Size(size);
		((ToolStripItem)ToolStripMenuItem99).set_Name("ToolStripMenuItem99");
		ToolStripMenuItem toolStripMenuItem99 = ToolStripMenuItem99;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem99).set_Size(size);
		((ToolStripItem)ToolStripMenuItem99).set_Text("À pr&opos de...");
		((ToolStripItem)ToolStripSeparator31).set_Name("ToolStripSeparator31");
		ToolStripSeparator toolStripSeparator31 = ToolStripSeparator31;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator31).set_Size(size);
		((ToolStripItem)ToolStripButton13).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton13).set_Image((Image)componentResourceManager.GetObject("ToolStripButton13.Image"));
		((ToolStripItem)ToolStripButton13).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton13).set_Name("ToolStripButton13");
		ToolStripButton toolStripButton13 = ToolStripButton13;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton13).set_Size(size);
		((ToolStripItem)ToolStripButton13).set_Text("Aide");
		((ToolStrip)StatusStrip3).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel3 });
		StatusStrip statusStrip7 = StatusStrip3;
		location = new Point(0, 365);
		((Control)statusStrip7).set_Location(location);
		((Control)StatusStrip3).set_Name("StatusStrip3");
		StatusStrip statusStrip8 = StatusStrip3;
		size = new Size(632, 22);
		((Control)statusStrip8).set_Size(size);
		((Control)StatusStrip3).set_TabIndex(17);
		((Control)StatusStrip3).set_Text("StatusStrip");
		((ToolStripItem)ToolStripStatusLabel3).set_Name("ToolStripStatusLabel3");
		ToolStripStatusLabel toolStripStatusLabel4 = ToolStripStatusLabel3;
		size = new Size(27, 17);
		((ToolStripItem)toolStripStatusLabel4).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel3).set_Text("État");
		((ToolStripItem)ToolStripButton14).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton14).set_Image((Image)componentResourceManager.GetObject("ToolStripButton14.Image"));
		((ToolStripItem)ToolStripButton14).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton14).set_Name("ToolStripButton14");
		ToolStripButton toolStripButton14 = ToolStripButton14;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton14).set_Size(size);
		((ToolStripItem)ToolStripButton14).set_Text("Aperçu avant impression");
		((ToolStripItem)ToolStripButton15).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton15).set_Image((Image)componentResourceManager.GetObject("ToolStripButton15.Image"));
		((ToolStripItem)ToolStripButton15).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton15).set_Name("ToolStripButton15");
		ToolStripButton toolStripButton15 = ToolStripButton15;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton15).set_Size(size);
		((ToolStripItem)ToolStripButton15).set_Text("Imprimer");
		((ToolStripItem)ToolStripSeparator32).set_Name("ToolStripSeparator32");
		ToolStripSeparator toolStripSeparator32 = ToolStripSeparator32;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator32).set_Size(size);
		ToolStrip3.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripButton16,
			(ToolStripItem)ToolStripButton17,
			(ToolStripItem)ToolStripButton18,
			(ToolStripItem)ToolStripSeparator32,
			(ToolStripItem)ToolStripButton15,
			(ToolStripItem)ToolStripButton14,
			(ToolStripItem)ToolStripSeparator31,
			(ToolStripItem)ToolStripButton13
		});
		ToolStrip toolStrip7 = ToolStrip3;
		location = new Point(0, 147);
		((Control)toolStrip7).set_Location(location);
		((Control)ToolStrip3).set_Name("ToolStrip3");
		ToolStrip toolStrip8 = ToolStrip3;
		size = new Size(632, 25);
		((Control)toolStrip8).set_Size(size);
		((Control)ToolStrip3).set_TabIndex(16);
		((Control)ToolStrip3).set_Text("ToolStrip");
		((ToolStripItem)ToolStripButton16).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton16).set_Image((Image)componentResourceManager.GetObject("ToolStripButton16.Image"));
		((ToolStripItem)ToolStripButton16).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton16).set_Name("ToolStripButton16");
		ToolStripButton toolStripButton16 = ToolStripButton16;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton16).set_Size(size);
		((ToolStripItem)ToolStripButton16).set_Text("Nouveau");
		((ToolStripItem)ToolStripButton17).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton17).set_Image((Image)componentResourceManager.GetObject("ToolStripButton17.Image"));
		((ToolStripItem)ToolStripButton17).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton17).set_Name("ToolStripButton17");
		ToolStripButton toolStripButton17 = ToolStripButton17;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton17).set_Size(size);
		((ToolStripItem)ToolStripButton17).set_Text("Ouvrir");
		((ToolStripItem)ToolStripButton18).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton18).set_Image((Image)componentResourceManager.GetObject("ToolStripButton18.Image"));
		((ToolStripItem)ToolStripButton18).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton18).set_Name("ToolStripButton18");
		ToolStripButton toolStripButton18 = ToolStripButton18;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton18).set_Size(size);
		((ToolStripItem)ToolStripButton18).set_Text("Enregistrer");
		((ToolStrip)MenuStrip4).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem100,
			(ToolStripItem)ToolStripMenuItem109,
			(ToolStripItem)ToolStripMenuItem116,
			(ToolStripItem)ToolStripMenuItem119,
			(ToolStripItem)ToolStripMenuItem121,
			(ToolStripItem)ToolStripMenuItem128
		});
		MenuStrip menuStrip9 = MenuStrip4;
		location = new Point(0, 221);
		((Control)menuStrip9).set_Location(location);
		MenuStrip4.set_MdiWindowListItem(ToolStripMenuItem121);
		((Control)MenuStrip4).set_Name("MenuStrip4");
		MenuStrip menuStrip10 = MenuStrip4;
		size = new Size(632, 24);
		((Control)menuStrip10).set_Size(size);
		((Control)MenuStrip4).set_TabIndex(18);
		((Control)MenuStrip4).set_Text("MenuStrip4");
		((ToolStripDropDownItem)ToolStripMenuItem100).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)ToolStripMenuItem101,
			(ToolStripItem)ToolStripMenuItem102,
			(ToolStripItem)ToolStripSeparator33,
			(ToolStripItem)ToolStripMenuItem103,
			(ToolStripItem)ToolStripMenuItem104,
			(ToolStripItem)ToolStripSeparator34,
			(ToolStripItem)ToolStripMenuItem105,
			(ToolStripItem)ToolStripMenuItem106,
			(ToolStripItem)ToolStripMenuItem107,
			(ToolStripItem)ToolStripSeparator35,
			(ToolStripItem)ToolStripMenuItem108
		});
		((ToolStripItem)ToolStripMenuItem100).set_ImageTransparentColor(SystemColors.ActiveBorder);
		((ToolStripItem)ToolStripMenuItem100).set_Name("ToolStripMenuItem100");
		ToolStripMenuItem toolStripMenuItem100 = ToolStripMenuItem100;
		size = new Size(54, 20);
		((ToolStripItem)toolStripMenuItem100).set_Size(size);
		((ToolStripItem)ToolStripMenuItem100).set_Text("&Fichier");
		((ToolStripItem)ToolStripMenuItem101).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem101.Image"));
		((ToolStripItem)ToolStripMenuItem101).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem101).set_Name("ToolStripMenuItem101");
		ToolStripMenuItem101.set_ShortcutKeys((Keys)131150);
		ToolStripMenuItem toolStripMenuItem101 = ToolStripMenuItem101;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem101).set_Size(size);
		((ToolStripItem)ToolStripMenuItem101).set_Text("&Nouveau");
		((ToolStripItem)ToolStripMenuItem102).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem102.Image"));
		((ToolStripItem)ToolStripMenuItem102).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem102).set_Name("ToolStripMenuItem102");
		ToolStripMenuItem102.set_ShortcutKeys((Keys)131151);
		ToolStripMenuItem toolStripMenuItem102 = ToolStripMenuItem102;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem102).set_Size(size);
		((ToolStripItem)ToolStripMenuItem102).set_Text("&Ouvrir");
		((ToolStripItem)ToolStripSeparator33).set_Name("ToolStripSeparator33");
		ToolStripSeparator toolStripSeparator33 = ToolStripSeparator33;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator33).set_Size(size);
		((ToolStripItem)ToolStripMenuItem103).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem103.Image"));
		((ToolStripItem)ToolStripMenuItem103).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem103).set_Name("ToolStripMenuItem103");
		ToolStripMenuItem103.set_ShortcutKeys((Keys)131155);
		ToolStripMenuItem toolStripMenuItem103 = ToolStripMenuItem103;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem103).set_Size(size);
		((ToolStripItem)ToolStripMenuItem103).set_Text("&Enregistrer");
		((ToolStripItem)ToolStripMenuItem104).set_Name("ToolStripMenuItem104");
		ToolStripMenuItem toolStripMenuItem104 = ToolStripMenuItem104;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem104).set_Size(size);
		((ToolStripItem)ToolStripMenuItem104).set_Text("Enregistrer &sous");
		((ToolStripItem)ToolStripSeparator34).set_Name("ToolStripSeparator34");
		ToolStripSeparator toolStripSeparator34 = ToolStripSeparator34;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator34).set_Size(size);
		((ToolStripItem)ToolStripMenuItem105).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem105.Image"));
		((ToolStripItem)ToolStripMenuItem105).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem105).set_Name("ToolStripMenuItem105");
		ToolStripMenuItem105.set_ShortcutKeys((Keys)131152);
		ToolStripMenuItem toolStripMenuItem105 = ToolStripMenuItem105;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem105).set_Size(size);
		((ToolStripItem)ToolStripMenuItem105).set_Text("&Imprimer");
		((ToolStripItem)ToolStripMenuItem106).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem106.Image"));
		((ToolStripItem)ToolStripMenuItem106).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem106).set_Name("ToolStripMenuItem106");
		ToolStripMenuItem toolStripMenuItem106 = ToolStripMenuItem106;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem106).set_Size(size);
		((ToolStripItem)ToolStripMenuItem106).set_Text("Aperçu a&vant impression");
		((ToolStripItem)ToolStripMenuItem107).set_Name("ToolStripMenuItem107");
		ToolStripMenuItem toolStripMenuItem107 = ToolStripMenuItem107;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem107).set_Size(size);
		((ToolStripItem)ToolStripMenuItem107).set_Text("Configuration de l'impression");
		((ToolStripItem)ToolStripSeparator35).set_Name("ToolStripSeparator35");
		ToolStripSeparator toolStripSeparator35 = ToolStripSeparator35;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator35).set_Size(size);
		((ToolStripItem)ToolStripMenuItem108).set_Name("ToolStripMenuItem108");
		ToolStripMenuItem toolStripMenuItem108 = ToolStripMenuItem108;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem108).set_Size(size);
		((ToolStripItem)ToolStripMenuItem108).set_Text("&Quitter");
		((ToolStripDropDownItem)ToolStripMenuItem109).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripMenuItem110,
			(ToolStripItem)ToolStripMenuItem111,
			(ToolStripItem)ToolStripSeparator36,
			(ToolStripItem)ToolStripMenuItem112,
			(ToolStripItem)ToolStripMenuItem113,
			(ToolStripItem)ToolStripMenuItem114,
			(ToolStripItem)ToolStripSeparator37,
			(ToolStripItem)ToolStripMenuItem115
		});
		((ToolStripItem)ToolStripMenuItem109).set_Name("ToolStripMenuItem109");
		ToolStripMenuItem toolStripMenuItem109 = ToolStripMenuItem109;
		size = new Size(56, 20);
		((ToolStripItem)toolStripMenuItem109).set_Size(size);
		((ToolStripItem)ToolStripMenuItem109).set_Text("&Edition");
		((ToolStripItem)ToolStripMenuItem110).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem110.Image"));
		((ToolStripItem)ToolStripMenuItem110).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem110).set_Name("ToolStripMenuItem110");
		ToolStripMenuItem110.set_ShortcutKeys((Keys)131162);
		ToolStripMenuItem toolStripMenuItem110 = ToolStripMenuItem110;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem110).set_Size(size);
		((ToolStripItem)ToolStripMenuItem110).set_Text("&Annuler");
		((ToolStripItem)ToolStripMenuItem111).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem111.Image"));
		((ToolStripItem)ToolStripMenuItem111).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem111).set_Name("ToolStripMenuItem111");
		ToolStripMenuItem111.set_ShortcutKeys((Keys)131161);
		ToolStripMenuItem toolStripMenuItem111 = ToolStripMenuItem111;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem111).set_Size(size);
		((ToolStripItem)ToolStripMenuItem111).set_Text("&Rétablir");
		((ToolStripItem)ToolStripSeparator36).set_Name("ToolStripSeparator36");
		ToolStripSeparator toolStripSeparator36 = ToolStripSeparator36;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator36).set_Size(size);
		((ToolStripItem)ToolStripMenuItem112).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem112.Image"));
		((ToolStripItem)ToolStripMenuItem112).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem112).set_Name("ToolStripMenuItem112");
		ToolStripMenuItem112.set_ShortcutKeys((Keys)131160);
		ToolStripMenuItem toolStripMenuItem112 = ToolStripMenuItem112;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem112).set_Size(size);
		((ToolStripItem)ToolStripMenuItem112).set_Text("Co&uper");
		((ToolStripItem)ToolStripMenuItem113).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem113.Image"));
		((ToolStripItem)ToolStripMenuItem113).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem113).set_Name("ToolStripMenuItem113");
		ToolStripMenuItem113.set_ShortcutKeys((Keys)131139);
		ToolStripMenuItem toolStripMenuItem113 = ToolStripMenuItem113;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem113).set_Size(size);
		((ToolStripItem)ToolStripMenuItem113).set_Text("&Copier");
		((ToolStripItem)ToolStripMenuItem114).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem114.Image"));
		((ToolStripItem)ToolStripMenuItem114).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem114).set_Name("ToolStripMenuItem114");
		ToolStripMenuItem114.set_ShortcutKeys((Keys)131158);
		ToolStripMenuItem toolStripMenuItem114 = ToolStripMenuItem114;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem114).set_Size(size);
		((ToolStripItem)ToolStripMenuItem114).set_Text("&Coller");
		((ToolStripItem)ToolStripSeparator37).set_Name("ToolStripSeparator37");
		ToolStripSeparator toolStripSeparator37 = ToolStripSeparator37;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator37).set_Size(size);
		((ToolStripItem)ToolStripMenuItem115).set_Name("ToolStripMenuItem115");
		ToolStripMenuItem115.set_ShortcutKeys((Keys)131137);
		ToolStripMenuItem toolStripMenuItem115 = ToolStripMenuItem115;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem115).set_Size(size);
		((ToolStripItem)ToolStripMenuItem115).set_Text("Sélectionner &tout");
		((ToolStripDropDownItem)ToolStripMenuItem116).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolStripMenuItem117,
			(ToolStripItem)ToolStripMenuItem118
		});
		((ToolStripItem)ToolStripMenuItem116).set_Name("ToolStripMenuItem116");
		ToolStripMenuItem toolStripMenuItem116 = ToolStripMenuItem116;
		size = new Size(70, 20);
		((ToolStripItem)toolStripMenuItem116).set_Size(size);
		((ToolStripItem)ToolStripMenuItem116).set_Text("&Affichage");
		ToolStripMenuItem117.set_Checked(true);
		ToolStripMenuItem117.set_CheckOnClick(true);
		ToolStripMenuItem117.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem117).set_Name("ToolStripMenuItem117");
		ToolStripMenuItem toolStripMenuItem117 = ToolStripMenuItem117;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem117).set_Size(size);
		((ToolStripItem)ToolStripMenuItem117).set_Text("&Barre d'outils");
		ToolStripMenuItem118.set_Checked(true);
		ToolStripMenuItem118.set_CheckOnClick(true);
		ToolStripMenuItem118.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem118).set_Name("ToolStripMenuItem118");
		ToolStripMenuItem toolStripMenuItem118 = ToolStripMenuItem118;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem118).set_Size(size);
		((ToolStripItem)ToolStripMenuItem118).set_Text("&Barre d'état");
		((ToolStripDropDownItem)ToolStripMenuItem119).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripMenuItem120 });
		((ToolStripItem)ToolStripMenuItem119).set_Name("ToolStripMenuItem119");
		ToolStripMenuItem toolStripMenuItem119 = ToolStripMenuItem119;
		size = new Size(50, 20);
		((ToolStripItem)toolStripMenuItem119).set_Size(size);
		((ToolStripItem)ToolStripMenuItem119).set_Text("&Outils");
		((ToolStripItem)ToolStripMenuItem120).set_Name("ToolStripMenuItem120");
		ToolStripMenuItem toolStripMenuItem120 = ToolStripMenuItem120;
		size = new Size(116, 22);
		((ToolStripItem)toolStripMenuItem120).set_Size(size);
		((ToolStripItem)ToolStripMenuItem120).set_Text("&Options");
		((ToolStripDropDownItem)ToolStripMenuItem121).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem122,
			(ToolStripItem)ToolStripMenuItem123,
			(ToolStripItem)ToolStripMenuItem124,
			(ToolStripItem)ToolStripMenuItem125,
			(ToolStripItem)ToolStripMenuItem126,
			(ToolStripItem)ToolStripMenuItem127
		});
		((ToolStripItem)ToolStripMenuItem121).set_Name("ToolStripMenuItem121");
		ToolStripMenuItem toolStripMenuItem121 = ToolStripMenuItem121;
		size = new Size(63, 20);
		((ToolStripItem)toolStripMenuItem121).set_Size(size);
		((ToolStripItem)ToolStripMenuItem121).set_Text("F&enêtres");
		((ToolStripItem)ToolStripMenuItem122).set_Name("ToolStripMenuItem122");
		ToolStripMenuItem toolStripMenuItem122 = ToolStripMenuItem122;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem122).set_Size(size);
		((ToolStripItem)ToolStripMenuItem122).set_Text("&Nouvelle fenêtre");
		((ToolStripItem)ToolStripMenuItem123).set_Name("ToolStripMenuItem123");
		ToolStripMenuItem toolStripMenuItem123 = ToolStripMenuItem123;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem123).set_Size(size);
		((ToolStripItem)ToolStripMenuItem123).set_Text("&Cascade");
		((ToolStripItem)ToolStripMenuItem124).set_Name("ToolStripMenuItem124");
		ToolStripMenuItem toolStripMenuItem124 = ToolStripMenuItem124;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem124).set_Size(size);
		((ToolStripItem)ToolStripMenuItem124).set_Text("Mosaïque &verticale");
		((ToolStripItem)ToolStripMenuItem125).set_Name("ToolStripMenuItem125");
		ToolStripMenuItem toolStripMenuItem125 = ToolStripMenuItem125;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem125).set_Size(size);
		((ToolStripItem)ToolStripMenuItem125).set_Text("Mosaïque &horizontale");
		((ToolStripItem)ToolStripMenuItem126).set_Name("ToolStripMenuItem126");
		ToolStripMenuItem toolStripMenuItem126 = ToolStripMenuItem126;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem126).set_Size(size);
		((ToolStripItem)ToolStripMenuItem126).set_Text("&Fermer tout");
		((ToolStripItem)ToolStripMenuItem127).set_Name("ToolStripMenuItem127");
		ToolStripMenuItem toolStripMenuItem127 = ToolStripMenuItem127;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem127).set_Size(size);
		((ToolStripItem)ToolStripMenuItem127).set_Text("&Réorganiser les icônes");
		((ToolStripDropDownItem)ToolStripMenuItem128).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ToolStripMenuItem129,
			(ToolStripItem)ToolStripMenuItem130,
			(ToolStripItem)ToolStripMenuItem131,
			(ToolStripItem)ToolStripSeparator38,
			(ToolStripItem)ToolStripMenuItem132
		});
		((ToolStripItem)ToolStripMenuItem128).set_Name("ToolStripMenuItem128");
		ToolStripMenuItem toolStripMenuItem128 = ToolStripMenuItem128;
		size = new Size(24, 20);
		((ToolStripItem)toolStripMenuItem128).set_Size(size);
		((ToolStripItem)ToolStripMenuItem128).set_Text("&?");
		((ToolStripItem)ToolStripMenuItem129).set_Name("ToolStripMenuItem129");
		ToolStripMenuItem129.set_ShortcutKeys((Keys)131184);
		ToolStripMenuItem toolStripMenuItem129 = ToolStripMenuItem129;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem129).set_Size(size);
		((ToolStripItem)ToolStripMenuItem129).set_Text("&Contenu");
		((ToolStripItem)ToolStripMenuItem130).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem130.Image"));
		((ToolStripItem)ToolStripMenuItem130).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem130).set_Name("ToolStripMenuItem130");
		ToolStripMenuItem toolStripMenuItem130 = ToolStripMenuItem130;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem130).set_Size(size);
		((ToolStripItem)ToolStripMenuItem130).set_Text("&Index");
		((ToolStripItem)ToolStripMenuItem131).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem131.Image"));
		((ToolStripItem)ToolStripMenuItem131).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem131).set_Name("ToolStripMenuItem131");
		ToolStripMenuItem toolStripMenuItem131 = ToolStripMenuItem131;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem131).set_Size(size);
		((ToolStripItem)ToolStripMenuItem131).set_Text("&Rechercher");
		((ToolStripItem)ToolStripSeparator38).set_Name("ToolStripSeparator38");
		ToolStripSeparator toolStripSeparator38 = ToolStripSeparator38;
		size = new Size(163, 6);
		((ToolStripItem)toolStripSeparator38).set_Size(size);
		((ToolStripItem)ToolStripMenuItem132).set_Name("ToolStripMenuItem132");
		ToolStripMenuItem toolStripMenuItem132 = ToolStripMenuItem132;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem132).set_Size(size);
		((ToolStripItem)ToolStripMenuItem132).set_Text("À pr&opos de...");
		((ToolStripItem)ToolStripSeparator39).set_Name("ToolStripSeparator39");
		ToolStripSeparator toolStripSeparator39 = ToolStripSeparator39;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator39).set_Size(size);
		((ToolStripItem)ToolStripButton19).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton19).set_Image((Image)componentResourceManager.GetObject("ToolStripButton19.Image"));
		((ToolStripItem)ToolStripButton19).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton19).set_Name("ToolStripButton19");
		ToolStripButton toolStripButton19 = ToolStripButton19;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton19).set_Size(size);
		((ToolStripItem)ToolStripButton19).set_Text("Aide");
		((ToolStrip)StatusStrip4).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel4 });
		StatusStrip statusStrip9 = StatusStrip4;
		location = new Point(0, 343);
		((Control)statusStrip9).set_Location(location);
		((Control)StatusStrip4).set_Name("StatusStrip4");
		StatusStrip statusStrip10 = StatusStrip4;
		size = new Size(632, 22);
		((Control)statusStrip10).set_Size(size);
		((Control)StatusStrip4).set_TabIndex(20);
		((Control)StatusStrip4).set_Text("StatusStrip");
		((ToolStripItem)ToolStripStatusLabel4).set_Name("ToolStripStatusLabel4");
		ToolStripStatusLabel toolStripStatusLabel5 = ToolStripStatusLabel4;
		size = new Size(27, 17);
		((ToolStripItem)toolStripStatusLabel5).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel4).set_Text("État");
		((ToolStripItem)ToolStripButton20).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton20).set_Image((Image)componentResourceManager.GetObject("ToolStripButton20.Image"));
		((ToolStripItem)ToolStripButton20).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton20).set_Name("ToolStripButton20");
		ToolStripButton toolStripButton20 = ToolStripButton20;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton20).set_Size(size);
		((ToolStripItem)ToolStripButton20).set_Text("Aperçu avant impression");
		((ToolStripItem)ToolStripButton21).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton21).set_Image((Image)componentResourceManager.GetObject("ToolStripButton21.Image"));
		((ToolStripItem)ToolStripButton21).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton21).set_Name("ToolStripButton21");
		ToolStripButton toolStripButton21 = ToolStripButton21;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton21).set_Size(size);
		((ToolStripItem)ToolStripButton21).set_Text("Imprimer");
		((ToolStripItem)ToolStripSeparator40).set_Name("ToolStripSeparator40");
		ToolStripSeparator toolStripSeparator40 = ToolStripSeparator40;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator40).set_Size(size);
		ToolStrip4.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripButton22,
			(ToolStripItem)ToolStripButton23,
			(ToolStripItem)ToolStripButton24,
			(ToolStripItem)ToolStripSeparator40,
			(ToolStripItem)ToolStripButton21,
			(ToolStripItem)ToolStripButton20,
			(ToolStripItem)ToolStripSeparator39,
			(ToolStripItem)ToolStripButton19
		});
		ToolStrip toolStrip9 = ToolStrip4;
		location = new Point(0, 196);
		((Control)toolStrip9).set_Location(location);
		((Control)ToolStrip4).set_Name("ToolStrip4");
		ToolStrip toolStrip10 = ToolStrip4;
		size = new Size(632, 25);
		((Control)toolStrip10).set_Size(size);
		((Control)ToolStrip4).set_TabIndex(19);
		((Control)ToolStrip4).set_Text("ToolStrip");
		((ToolStripItem)ToolStripButton22).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton22).set_Image((Image)componentResourceManager.GetObject("ToolStripButton22.Image"));
		((ToolStripItem)ToolStripButton22).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton22).set_Name("ToolStripButton22");
		ToolStripButton toolStripButton22 = ToolStripButton22;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton22).set_Size(size);
		((ToolStripItem)ToolStripButton22).set_Text("Nouveau");
		((ToolStripItem)ToolStripButton23).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton23).set_Image((Image)componentResourceManager.GetObject("ToolStripButton23.Image"));
		((ToolStripItem)ToolStripButton23).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton23).set_Name("ToolStripButton23");
		ToolStripButton toolStripButton23 = ToolStripButton23;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton23).set_Size(size);
		((ToolStripItem)ToolStripButton23).set_Text("Ouvrir");
		((ToolStripItem)ToolStripButton24).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton24).set_Image((Image)componentResourceManager.GetObject("ToolStripButton24.Image"));
		((ToolStripItem)ToolStripButton24).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton24).set_Name("ToolStripButton24");
		ToolStripButton toolStripButton24 = ToolStripButton24;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton24).set_Size(size);
		((ToolStripItem)ToolStripButton24).set_Text("Enregistrer");
		((ToolStrip)MenuStrip5).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem133,
			(ToolStripItem)ToolStripMenuItem142,
			(ToolStripItem)ToolStripMenuItem149,
			(ToolStripItem)ToolStripMenuItem152,
			(ToolStripItem)ToolStripMenuItem154,
			(ToolStripItem)ToolStripMenuItem161
		});
		MenuStrip menuStrip11 = MenuStrip5;
		location = new Point(0, 270);
		((Control)menuStrip11).set_Location(location);
		MenuStrip5.set_MdiWindowListItem(ToolStripMenuItem154);
		((Control)MenuStrip5).set_Name("MenuStrip5");
		MenuStrip menuStrip12 = MenuStrip5;
		size = new Size(632, 24);
		((Control)menuStrip12).set_Size(size);
		((Control)MenuStrip5).set_TabIndex(21);
		((Control)MenuStrip5).set_Text("MenuStrip5");
		((ToolStripDropDownItem)ToolStripMenuItem133).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)ToolStripMenuItem134,
			(ToolStripItem)ToolStripMenuItem135,
			(ToolStripItem)ToolStripSeparator41,
			(ToolStripItem)ToolStripMenuItem136,
			(ToolStripItem)ToolStripMenuItem137,
			(ToolStripItem)ToolStripSeparator42,
			(ToolStripItem)ToolStripMenuItem138,
			(ToolStripItem)ToolStripMenuItem139,
			(ToolStripItem)ToolStripMenuItem140,
			(ToolStripItem)ToolStripSeparator43,
			(ToolStripItem)ToolStripMenuItem141
		});
		((ToolStripItem)ToolStripMenuItem133).set_ImageTransparentColor(SystemColors.ActiveBorder);
		((ToolStripItem)ToolStripMenuItem133).set_Name("ToolStripMenuItem133");
		ToolStripMenuItem toolStripMenuItem133 = ToolStripMenuItem133;
		size = new Size(54, 20);
		((ToolStripItem)toolStripMenuItem133).set_Size(size);
		((ToolStripItem)ToolStripMenuItem133).set_Text("&Fichier");
		((ToolStripItem)ToolStripMenuItem134).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem134.Image"));
		((ToolStripItem)ToolStripMenuItem134).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem134).set_Name("ToolStripMenuItem134");
		ToolStripMenuItem134.set_ShortcutKeys((Keys)131150);
		ToolStripMenuItem toolStripMenuItem134 = ToolStripMenuItem134;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem134).set_Size(size);
		((ToolStripItem)ToolStripMenuItem134).set_Text("&Nouveau");
		((ToolStripItem)ToolStripMenuItem135).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem135.Image"));
		((ToolStripItem)ToolStripMenuItem135).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem135).set_Name("ToolStripMenuItem135");
		ToolStripMenuItem135.set_ShortcutKeys((Keys)131151);
		ToolStripMenuItem toolStripMenuItem135 = ToolStripMenuItem135;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem135).set_Size(size);
		((ToolStripItem)ToolStripMenuItem135).set_Text("&Ouvrir");
		((ToolStripItem)ToolStripSeparator41).set_Name("ToolStripSeparator41");
		ToolStripSeparator toolStripSeparator41 = ToolStripSeparator41;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator41).set_Size(size);
		((ToolStripItem)ToolStripMenuItem136).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem136.Image"));
		((ToolStripItem)ToolStripMenuItem136).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem136).set_Name("ToolStripMenuItem136");
		ToolStripMenuItem136.set_ShortcutKeys((Keys)131155);
		ToolStripMenuItem toolStripMenuItem136 = ToolStripMenuItem136;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem136).set_Size(size);
		((ToolStripItem)ToolStripMenuItem136).set_Text("&Enregistrer");
		((ToolStripItem)ToolStripMenuItem137).set_Name("ToolStripMenuItem137");
		ToolStripMenuItem toolStripMenuItem137 = ToolStripMenuItem137;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem137).set_Size(size);
		((ToolStripItem)ToolStripMenuItem137).set_Text("Enregistrer &sous");
		((ToolStripItem)ToolStripSeparator42).set_Name("ToolStripSeparator42");
		ToolStripSeparator toolStripSeparator42 = ToolStripSeparator42;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator42).set_Size(size);
		((ToolStripItem)ToolStripMenuItem138).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem138.Image"));
		((ToolStripItem)ToolStripMenuItem138).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem138).set_Name("ToolStripMenuItem138");
		ToolStripMenuItem138.set_ShortcutKeys((Keys)131152);
		ToolStripMenuItem toolStripMenuItem138 = ToolStripMenuItem138;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem138).set_Size(size);
		((ToolStripItem)ToolStripMenuItem138).set_Text("&Imprimer");
		((ToolStripItem)ToolStripMenuItem139).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem139.Image"));
		((ToolStripItem)ToolStripMenuItem139).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem139).set_Name("ToolStripMenuItem139");
		ToolStripMenuItem toolStripMenuItem139 = ToolStripMenuItem139;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem139).set_Size(size);
		((ToolStripItem)ToolStripMenuItem139).set_Text("Aperçu a&vant impression");
		((ToolStripItem)ToolStripMenuItem140).set_Name("ToolStripMenuItem140");
		ToolStripMenuItem toolStripMenuItem140 = ToolStripMenuItem140;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem140).set_Size(size);
		((ToolStripItem)ToolStripMenuItem140).set_Text("Configuration de l'impression");
		((ToolStripItem)ToolStripSeparator43).set_Name("ToolStripSeparator43");
		ToolStripSeparator toolStripSeparator43 = ToolStripSeparator43;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator43).set_Size(size);
		((ToolStripItem)ToolStripMenuItem141).set_Name("ToolStripMenuItem141");
		ToolStripMenuItem toolStripMenuItem141 = ToolStripMenuItem141;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem141).set_Size(size);
		((ToolStripItem)ToolStripMenuItem141).set_Text("&Quitter");
		((ToolStripDropDownItem)ToolStripMenuItem142).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripMenuItem143,
			(ToolStripItem)ToolStripMenuItem144,
			(ToolStripItem)ToolStripSeparator44,
			(ToolStripItem)ToolStripMenuItem145,
			(ToolStripItem)ToolStripMenuItem146,
			(ToolStripItem)ToolStripMenuItem147,
			(ToolStripItem)ToolStripSeparator45,
			(ToolStripItem)ToolStripMenuItem148
		});
		((ToolStripItem)ToolStripMenuItem142).set_Name("ToolStripMenuItem142");
		ToolStripMenuItem toolStripMenuItem142 = ToolStripMenuItem142;
		size = new Size(56, 20);
		((ToolStripItem)toolStripMenuItem142).set_Size(size);
		((ToolStripItem)ToolStripMenuItem142).set_Text("&Edition");
		((ToolStripItem)ToolStripMenuItem143).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem143.Image"));
		((ToolStripItem)ToolStripMenuItem143).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem143).set_Name("ToolStripMenuItem143");
		ToolStripMenuItem143.set_ShortcutKeys((Keys)131162);
		ToolStripMenuItem toolStripMenuItem143 = ToolStripMenuItem143;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem143).set_Size(size);
		((ToolStripItem)ToolStripMenuItem143).set_Text("&Annuler");
		((ToolStripItem)ToolStripMenuItem144).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem144.Image"));
		((ToolStripItem)ToolStripMenuItem144).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem144).set_Name("ToolStripMenuItem144");
		ToolStripMenuItem144.set_ShortcutKeys((Keys)131161);
		ToolStripMenuItem toolStripMenuItem144 = ToolStripMenuItem144;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem144).set_Size(size);
		((ToolStripItem)ToolStripMenuItem144).set_Text("&Rétablir");
		((ToolStripItem)ToolStripSeparator44).set_Name("ToolStripSeparator44");
		ToolStripSeparator toolStripSeparator44 = ToolStripSeparator44;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator44).set_Size(size);
		((ToolStripItem)ToolStripMenuItem145).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem145.Image"));
		((ToolStripItem)ToolStripMenuItem145).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem145).set_Name("ToolStripMenuItem145");
		ToolStripMenuItem145.set_ShortcutKeys((Keys)131160);
		ToolStripMenuItem toolStripMenuItem145 = ToolStripMenuItem145;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem145).set_Size(size);
		((ToolStripItem)ToolStripMenuItem145).set_Text("Co&uper");
		((ToolStripItem)ToolStripMenuItem146).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem146.Image"));
		((ToolStripItem)ToolStripMenuItem146).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem146).set_Name("ToolStripMenuItem146");
		ToolStripMenuItem146.set_ShortcutKeys((Keys)131139);
		ToolStripMenuItem toolStripMenuItem146 = ToolStripMenuItem146;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem146).set_Size(size);
		((ToolStripItem)ToolStripMenuItem146).set_Text("&Copier");
		((ToolStripItem)ToolStripMenuItem147).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem147.Image"));
		((ToolStripItem)ToolStripMenuItem147).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem147).set_Name("ToolStripMenuItem147");
		ToolStripMenuItem147.set_ShortcutKeys((Keys)131158);
		ToolStripMenuItem toolStripMenuItem147 = ToolStripMenuItem147;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem147).set_Size(size);
		((ToolStripItem)ToolStripMenuItem147).set_Text("&Coller");
		((ToolStripItem)ToolStripSeparator45).set_Name("ToolStripSeparator45");
		ToolStripSeparator toolStripSeparator45 = ToolStripSeparator45;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator45).set_Size(size);
		((ToolStripItem)ToolStripMenuItem148).set_Name("ToolStripMenuItem148");
		ToolStripMenuItem148.set_ShortcutKeys((Keys)131137);
		ToolStripMenuItem toolStripMenuItem148 = ToolStripMenuItem148;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem148).set_Size(size);
		((ToolStripItem)ToolStripMenuItem148).set_Text("Sélectionner &tout");
		((ToolStripDropDownItem)ToolStripMenuItem149).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolStripMenuItem150,
			(ToolStripItem)ToolStripMenuItem151
		});
		((ToolStripItem)ToolStripMenuItem149).set_Name("ToolStripMenuItem149");
		ToolStripMenuItem toolStripMenuItem149 = ToolStripMenuItem149;
		size = new Size(70, 20);
		((ToolStripItem)toolStripMenuItem149).set_Size(size);
		((ToolStripItem)ToolStripMenuItem149).set_Text("&Affichage");
		ToolStripMenuItem150.set_Checked(true);
		ToolStripMenuItem150.set_CheckOnClick(true);
		ToolStripMenuItem150.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem150).set_Name("ToolStripMenuItem150");
		ToolStripMenuItem toolStripMenuItem150 = ToolStripMenuItem150;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem150).set_Size(size);
		((ToolStripItem)ToolStripMenuItem150).set_Text("&Barre d'outils");
		ToolStripMenuItem151.set_Checked(true);
		ToolStripMenuItem151.set_CheckOnClick(true);
		ToolStripMenuItem151.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem151).set_Name("ToolStripMenuItem151");
		ToolStripMenuItem toolStripMenuItem151 = ToolStripMenuItem151;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem151).set_Size(size);
		((ToolStripItem)ToolStripMenuItem151).set_Text("&Barre d'état");
		((ToolStripDropDownItem)ToolStripMenuItem152).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripMenuItem153 });
		((ToolStripItem)ToolStripMenuItem152).set_Name("ToolStripMenuItem152");
		ToolStripMenuItem toolStripMenuItem152 = ToolStripMenuItem152;
		size = new Size(50, 20);
		((ToolStripItem)toolStripMenuItem152).set_Size(size);
		((ToolStripItem)ToolStripMenuItem152).set_Text("&Outils");
		((ToolStripItem)ToolStripMenuItem153).set_Name("ToolStripMenuItem153");
		ToolStripMenuItem toolStripMenuItem153 = ToolStripMenuItem153;
		size = new Size(116, 22);
		((ToolStripItem)toolStripMenuItem153).set_Size(size);
		((ToolStripItem)ToolStripMenuItem153).set_Text("&Options");
		((ToolStripDropDownItem)ToolStripMenuItem154).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem155,
			(ToolStripItem)ToolStripMenuItem156,
			(ToolStripItem)ToolStripMenuItem157,
			(ToolStripItem)ToolStripMenuItem158,
			(ToolStripItem)ToolStripMenuItem159,
			(ToolStripItem)ToolStripMenuItem160
		});
		((ToolStripItem)ToolStripMenuItem154).set_Name("ToolStripMenuItem154");
		ToolStripMenuItem toolStripMenuItem154 = ToolStripMenuItem154;
		size = new Size(63, 20);
		((ToolStripItem)toolStripMenuItem154).set_Size(size);
		((ToolStripItem)ToolStripMenuItem154).set_Text("F&enêtres");
		((ToolStripItem)ToolStripMenuItem155).set_Name("ToolStripMenuItem155");
		ToolStripMenuItem toolStripMenuItem155 = ToolStripMenuItem155;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem155).set_Size(size);
		((ToolStripItem)ToolStripMenuItem155).set_Text("&Nouvelle fenêtre");
		((ToolStripItem)ToolStripMenuItem156).set_Name("ToolStripMenuItem156");
		ToolStripMenuItem toolStripMenuItem156 = ToolStripMenuItem156;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem156).set_Size(size);
		((ToolStripItem)ToolStripMenuItem156).set_Text("&Cascade");
		((ToolStripItem)ToolStripMenuItem157).set_Name("ToolStripMenuItem157");
		ToolStripMenuItem toolStripMenuItem157 = ToolStripMenuItem157;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem157).set_Size(size);
		((ToolStripItem)ToolStripMenuItem157).set_Text("Mosaïque &verticale");
		((ToolStripItem)ToolStripMenuItem158).set_Name("ToolStripMenuItem158");
		ToolStripMenuItem toolStripMenuItem158 = ToolStripMenuItem158;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem158).set_Size(size);
		((ToolStripItem)ToolStripMenuItem158).set_Text("Mosaïque &horizontale");
		((ToolStripItem)ToolStripMenuItem159).set_Name("ToolStripMenuItem159");
		ToolStripMenuItem toolStripMenuItem159 = ToolStripMenuItem159;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem159).set_Size(size);
		((ToolStripItem)ToolStripMenuItem159).set_Text("&Fermer tout");
		((ToolStripItem)ToolStripMenuItem160).set_Name("ToolStripMenuItem160");
		ToolStripMenuItem toolStripMenuItem160 = ToolStripMenuItem160;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem160).set_Size(size);
		((ToolStripItem)ToolStripMenuItem160).set_Text("&Réorganiser les icônes");
		((ToolStripDropDownItem)ToolStripMenuItem161).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ToolStripMenuItem162,
			(ToolStripItem)ToolStripMenuItem163,
			(ToolStripItem)ToolStripMenuItem164,
			(ToolStripItem)ToolStripSeparator46,
			(ToolStripItem)ToolStripMenuItem165
		});
		((ToolStripItem)ToolStripMenuItem161).set_Name("ToolStripMenuItem161");
		ToolStripMenuItem toolStripMenuItem161 = ToolStripMenuItem161;
		size = new Size(24, 20);
		((ToolStripItem)toolStripMenuItem161).set_Size(size);
		((ToolStripItem)ToolStripMenuItem161).set_Text("&?");
		((ToolStripItem)ToolStripMenuItem162).set_Name("ToolStripMenuItem162");
		ToolStripMenuItem162.set_ShortcutKeys((Keys)131184);
		ToolStripMenuItem toolStripMenuItem162 = ToolStripMenuItem162;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem162).set_Size(size);
		((ToolStripItem)ToolStripMenuItem162).set_Text("&Contenu");
		((ToolStripItem)ToolStripMenuItem163).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem163.Image"));
		((ToolStripItem)ToolStripMenuItem163).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem163).set_Name("ToolStripMenuItem163");
		ToolStripMenuItem toolStripMenuItem163 = ToolStripMenuItem163;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem163).set_Size(size);
		((ToolStripItem)ToolStripMenuItem163).set_Text("&Index");
		((ToolStripItem)ToolStripMenuItem164).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem164.Image"));
		((ToolStripItem)ToolStripMenuItem164).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem164).set_Name("ToolStripMenuItem164");
		ToolStripMenuItem toolStripMenuItem164 = ToolStripMenuItem164;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem164).set_Size(size);
		((ToolStripItem)ToolStripMenuItem164).set_Text("&Rechercher");
		((ToolStripItem)ToolStripSeparator46).set_Name("ToolStripSeparator46");
		ToolStripSeparator toolStripSeparator46 = ToolStripSeparator46;
		size = new Size(163, 6);
		((ToolStripItem)toolStripSeparator46).set_Size(size);
		((ToolStripItem)ToolStripMenuItem165).set_Name("ToolStripMenuItem165");
		ToolStripMenuItem toolStripMenuItem165 = ToolStripMenuItem165;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem165).set_Size(size);
		((ToolStripItem)ToolStripMenuItem165).set_Text("À pr&opos de...");
		((ToolStripItem)ToolStripSeparator47).set_Name("ToolStripSeparator47");
		ToolStripSeparator toolStripSeparator47 = ToolStripSeparator47;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator47).set_Size(size);
		((ToolStripItem)ToolStripButton25).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton25).set_Image((Image)componentResourceManager.GetObject("ToolStripButton25.Image"));
		((ToolStripItem)ToolStripButton25).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton25).set_Name("ToolStripButton25");
		ToolStripButton toolStripButton25 = ToolStripButton25;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton25).set_Size(size);
		((ToolStripItem)ToolStripButton25).set_Text("Aide");
		((ToolStrip)StatusStrip5).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel5 });
		StatusStrip statusStrip11 = StatusStrip5;
		location = new Point(0, 321);
		((Control)statusStrip11).set_Location(location);
		((Control)StatusStrip5).set_Name("StatusStrip5");
		StatusStrip statusStrip12 = StatusStrip5;
		size = new Size(632, 22);
		((Control)statusStrip12).set_Size(size);
		((Control)StatusStrip5).set_TabIndex(23);
		((Control)StatusStrip5).set_Text("StatusStrip");
		((ToolStripItem)ToolStripStatusLabel5).set_Name("ToolStripStatusLabel5");
		ToolStripStatusLabel toolStripStatusLabel6 = ToolStripStatusLabel5;
		size = new Size(27, 17);
		((ToolStripItem)toolStripStatusLabel6).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel5).set_Text("État");
		((ToolStripItem)ToolStripButton26).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton26).set_Image((Image)componentResourceManager.GetObject("ToolStripButton26.Image"));
		((ToolStripItem)ToolStripButton26).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton26).set_Name("ToolStripButton26");
		ToolStripButton toolStripButton26 = ToolStripButton26;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton26).set_Size(size);
		((ToolStripItem)ToolStripButton26).set_Text("Aperçu avant impression");
		((ToolStripItem)ToolStripButton27).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton27).set_Image((Image)componentResourceManager.GetObject("ToolStripButton27.Image"));
		((ToolStripItem)ToolStripButton27).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton27).set_Name("ToolStripButton27");
		ToolStripButton toolStripButton27 = ToolStripButton27;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton27).set_Size(size);
		((ToolStripItem)ToolStripButton27).set_Text("Imprimer");
		((ToolStripItem)ToolStripSeparator48).set_Name("ToolStripSeparator48");
		ToolStripSeparator toolStripSeparator48 = ToolStripSeparator48;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator48).set_Size(size);
		ToolStrip5.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripButton28,
			(ToolStripItem)ToolStripButton29,
			(ToolStripItem)ToolStripButton30,
			(ToolStripItem)ToolStripSeparator48,
			(ToolStripItem)ToolStripButton27,
			(ToolStripItem)ToolStripButton26,
			(ToolStripItem)ToolStripSeparator47,
			(ToolStripItem)ToolStripButton25
		});
		ToolStrip toolStrip11 = ToolStrip5;
		location = new Point(0, 245);
		((Control)toolStrip11).set_Location(location);
		((Control)ToolStrip5).set_Name("ToolStrip5");
		ToolStrip toolStrip12 = ToolStrip5;
		size = new Size(632, 25);
		((Control)toolStrip12).set_Size(size);
		((Control)ToolStrip5).set_TabIndex(22);
		((Control)ToolStrip5).set_Text("ToolStrip");
		((ToolStripItem)ToolStripButton28).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton28).set_Image((Image)componentResourceManager.GetObject("ToolStripButton28.Image"));
		((ToolStripItem)ToolStripButton28).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton28).set_Name("ToolStripButton28");
		ToolStripButton toolStripButton28 = ToolStripButton28;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton28).set_Size(size);
		((ToolStripItem)ToolStripButton28).set_Text("Nouveau");
		((ToolStripItem)ToolStripButton29).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton29).set_Image((Image)componentResourceManager.GetObject("ToolStripButton29.Image"));
		((ToolStripItem)ToolStripButton29).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton29).set_Name("ToolStripButton29");
		ToolStripButton toolStripButton29 = ToolStripButton29;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton29).set_Size(size);
		((ToolStripItem)ToolStripButton29).set_Text("Ouvrir");
		((ToolStripItem)ToolStripButton30).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton30).set_Image((Image)componentResourceManager.GetObject("ToolStripButton30.Image"));
		((ToolStripItem)ToolStripButton30).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton30).set_Name("ToolStripButton30");
		ToolStripButton toolStripButton30 = ToolStripButton30;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton30).set_Size(size);
		((ToolStripItem)ToolStripButton30).set_Text("Enregistrer");
		((ToolStrip)MenuStrip6).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem166,
			(ToolStripItem)ToolStripMenuItem175,
			(ToolStripItem)ToolStripMenuItem182,
			(ToolStripItem)ToolStripMenuItem185,
			(ToolStripItem)ToolStripMenuItem187,
			(ToolStripItem)ToolStripMenuItem194
		});
		MenuStrip menuStrip13 = MenuStrip6;
		location = new Point(0, 319);
		((Control)menuStrip13).set_Location(location);
		MenuStrip6.set_MdiWindowListItem(ToolStripMenuItem187);
		((Control)MenuStrip6).set_Name("MenuStrip6");
		MenuStrip menuStrip14 = MenuStrip6;
		size = new Size(632, 24);
		((Control)menuStrip14).set_Size(size);
		((Control)MenuStrip6).set_TabIndex(24);
		((Control)MenuStrip6).set_Text("MenuStrip6");
		((ToolStripDropDownItem)ToolStripMenuItem166).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)ToolStripMenuItem167,
			(ToolStripItem)ToolStripMenuItem168,
			(ToolStripItem)ToolStripSeparator49,
			(ToolStripItem)ToolStripMenuItem169,
			(ToolStripItem)ToolStripMenuItem170,
			(ToolStripItem)ToolStripSeparator50,
			(ToolStripItem)ToolStripMenuItem171,
			(ToolStripItem)ToolStripMenuItem172,
			(ToolStripItem)ToolStripMenuItem173,
			(ToolStripItem)ToolStripSeparator51,
			(ToolStripItem)ToolStripMenuItem174
		});
		((ToolStripItem)ToolStripMenuItem166).set_ImageTransparentColor(SystemColors.ActiveBorder);
		((ToolStripItem)ToolStripMenuItem166).set_Name("ToolStripMenuItem166");
		ToolStripMenuItem toolStripMenuItem166 = ToolStripMenuItem166;
		size = new Size(54, 20);
		((ToolStripItem)toolStripMenuItem166).set_Size(size);
		((ToolStripItem)ToolStripMenuItem166).set_Text("&Fichier");
		((ToolStripItem)ToolStripMenuItem167).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem167.Image"));
		((ToolStripItem)ToolStripMenuItem167).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem167).set_Name("ToolStripMenuItem167");
		ToolStripMenuItem167.set_ShortcutKeys((Keys)131150);
		ToolStripMenuItem toolStripMenuItem167 = ToolStripMenuItem167;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem167).set_Size(size);
		((ToolStripItem)ToolStripMenuItem167).set_Text("&Nouveau");
		((ToolStripItem)ToolStripMenuItem168).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem168.Image"));
		((ToolStripItem)ToolStripMenuItem168).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem168).set_Name("ToolStripMenuItem168");
		ToolStripMenuItem168.set_ShortcutKeys((Keys)131151);
		ToolStripMenuItem toolStripMenuItem168 = ToolStripMenuItem168;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem168).set_Size(size);
		((ToolStripItem)ToolStripMenuItem168).set_Text("&Ouvrir");
		((ToolStripItem)ToolStripSeparator49).set_Name("ToolStripSeparator49");
		ToolStripSeparator toolStripSeparator49 = ToolStripSeparator49;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator49).set_Size(size);
		((ToolStripItem)ToolStripMenuItem169).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem169.Image"));
		((ToolStripItem)ToolStripMenuItem169).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem169).set_Name("ToolStripMenuItem169");
		ToolStripMenuItem169.set_ShortcutKeys((Keys)131155);
		ToolStripMenuItem toolStripMenuItem169 = ToolStripMenuItem169;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem169).set_Size(size);
		((ToolStripItem)ToolStripMenuItem169).set_Text("&Enregistrer");
		((ToolStripItem)ToolStripMenuItem170).set_Name("ToolStripMenuItem170");
		ToolStripMenuItem toolStripMenuItem170 = ToolStripMenuItem170;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem170).set_Size(size);
		((ToolStripItem)ToolStripMenuItem170).set_Text("Enregistrer &sous");
		((ToolStripItem)ToolStripSeparator50).set_Name("ToolStripSeparator50");
		ToolStripSeparator toolStripSeparator50 = ToolStripSeparator50;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator50).set_Size(size);
		((ToolStripItem)ToolStripMenuItem171).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem171.Image"));
		((ToolStripItem)ToolStripMenuItem171).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem171).set_Name("ToolStripMenuItem171");
		ToolStripMenuItem171.set_ShortcutKeys((Keys)131152);
		ToolStripMenuItem toolStripMenuItem171 = ToolStripMenuItem171;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem171).set_Size(size);
		((ToolStripItem)ToolStripMenuItem171).set_Text("&Imprimer");
		((ToolStripItem)ToolStripMenuItem172).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem172.Image"));
		((ToolStripItem)ToolStripMenuItem172).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem172).set_Name("ToolStripMenuItem172");
		ToolStripMenuItem toolStripMenuItem172 = ToolStripMenuItem172;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem172).set_Size(size);
		((ToolStripItem)ToolStripMenuItem172).set_Text("Aperçu a&vant impression");
		((ToolStripItem)ToolStripMenuItem173).set_Name("ToolStripMenuItem173");
		ToolStripMenuItem toolStripMenuItem173 = ToolStripMenuItem173;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem173).set_Size(size);
		((ToolStripItem)ToolStripMenuItem173).set_Text("Configuration de l'impression");
		((ToolStripItem)ToolStripSeparator51).set_Name("ToolStripSeparator51");
		ToolStripSeparator toolStripSeparator51 = ToolStripSeparator51;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator51).set_Size(size);
		((ToolStripItem)ToolStripMenuItem174).set_Name("ToolStripMenuItem174");
		ToolStripMenuItem toolStripMenuItem174 = ToolStripMenuItem174;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem174).set_Size(size);
		((ToolStripItem)ToolStripMenuItem174).set_Text("&Quitter");
		((ToolStripDropDownItem)ToolStripMenuItem175).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripMenuItem176,
			(ToolStripItem)ToolStripMenuItem177,
			(ToolStripItem)ToolStripSeparator52,
			(ToolStripItem)ToolStripMenuItem178,
			(ToolStripItem)ToolStripMenuItem179,
			(ToolStripItem)ToolStripMenuItem180,
			(ToolStripItem)ToolStripSeparator53,
			(ToolStripItem)ToolStripMenuItem181
		});
		((ToolStripItem)ToolStripMenuItem175).set_Name("ToolStripMenuItem175");
		ToolStripMenuItem toolStripMenuItem175 = ToolStripMenuItem175;
		size = new Size(56, 20);
		((ToolStripItem)toolStripMenuItem175).set_Size(size);
		((ToolStripItem)ToolStripMenuItem175).set_Text("&Edition");
		((ToolStripItem)ToolStripMenuItem176).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem176.Image"));
		((ToolStripItem)ToolStripMenuItem176).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem176).set_Name("ToolStripMenuItem176");
		ToolStripMenuItem176.set_ShortcutKeys((Keys)131162);
		ToolStripMenuItem toolStripMenuItem176 = ToolStripMenuItem176;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem176).set_Size(size);
		((ToolStripItem)ToolStripMenuItem176).set_Text("&Annuler");
		((ToolStripItem)ToolStripMenuItem177).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem177.Image"));
		((ToolStripItem)ToolStripMenuItem177).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem177).set_Name("ToolStripMenuItem177");
		ToolStripMenuItem177.set_ShortcutKeys((Keys)131161);
		ToolStripMenuItem toolStripMenuItem177 = ToolStripMenuItem177;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem177).set_Size(size);
		((ToolStripItem)ToolStripMenuItem177).set_Text("&Rétablir");
		((ToolStripItem)ToolStripSeparator52).set_Name("ToolStripSeparator52");
		ToolStripSeparator toolStripSeparator52 = ToolStripSeparator52;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator52).set_Size(size);
		((ToolStripItem)ToolStripMenuItem178).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem178.Image"));
		((ToolStripItem)ToolStripMenuItem178).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem178).set_Name("ToolStripMenuItem178");
		ToolStripMenuItem178.set_ShortcutKeys((Keys)131160);
		ToolStripMenuItem toolStripMenuItem178 = ToolStripMenuItem178;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem178).set_Size(size);
		((ToolStripItem)ToolStripMenuItem178).set_Text("Co&uper");
		((ToolStripItem)ToolStripMenuItem179).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem179.Image"));
		((ToolStripItem)ToolStripMenuItem179).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem179).set_Name("ToolStripMenuItem179");
		ToolStripMenuItem179.set_ShortcutKeys((Keys)131139);
		ToolStripMenuItem toolStripMenuItem179 = ToolStripMenuItem179;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem179).set_Size(size);
		((ToolStripItem)ToolStripMenuItem179).set_Text("&Copier");
		((ToolStripItem)ToolStripMenuItem180).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem180.Image"));
		((ToolStripItem)ToolStripMenuItem180).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem180).set_Name("ToolStripMenuItem180");
		ToolStripMenuItem180.set_ShortcutKeys((Keys)131158);
		ToolStripMenuItem toolStripMenuItem180 = ToolStripMenuItem180;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem180).set_Size(size);
		((ToolStripItem)ToolStripMenuItem180).set_Text("&Coller");
		((ToolStripItem)ToolStripSeparator53).set_Name("ToolStripSeparator53");
		ToolStripSeparator toolStripSeparator53 = ToolStripSeparator53;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator53).set_Size(size);
		((ToolStripItem)ToolStripMenuItem181).set_Name("ToolStripMenuItem181");
		ToolStripMenuItem181.set_ShortcutKeys((Keys)131137);
		ToolStripMenuItem toolStripMenuItem181 = ToolStripMenuItem181;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem181).set_Size(size);
		((ToolStripItem)ToolStripMenuItem181).set_Text("Sélectionner &tout");
		((ToolStripDropDownItem)ToolStripMenuItem182).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolStripMenuItem183,
			(ToolStripItem)ToolStripMenuItem184
		});
		((ToolStripItem)ToolStripMenuItem182).set_Name("ToolStripMenuItem182");
		ToolStripMenuItem toolStripMenuItem182 = ToolStripMenuItem182;
		size = new Size(70, 20);
		((ToolStripItem)toolStripMenuItem182).set_Size(size);
		((ToolStripItem)ToolStripMenuItem182).set_Text("&Affichage");
		ToolStripMenuItem183.set_Checked(true);
		ToolStripMenuItem183.set_CheckOnClick(true);
		ToolStripMenuItem183.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem183).set_Name("ToolStripMenuItem183");
		ToolStripMenuItem toolStripMenuItem183 = ToolStripMenuItem183;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem183).set_Size(size);
		((ToolStripItem)ToolStripMenuItem183).set_Text("&Barre d'outils");
		ToolStripMenuItem184.set_Checked(true);
		ToolStripMenuItem184.set_CheckOnClick(true);
		ToolStripMenuItem184.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem184).set_Name("ToolStripMenuItem184");
		ToolStripMenuItem toolStripMenuItem184 = ToolStripMenuItem184;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem184).set_Size(size);
		((ToolStripItem)ToolStripMenuItem184).set_Text("&Barre d'état");
		((ToolStripDropDownItem)ToolStripMenuItem185).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripMenuItem186 });
		((ToolStripItem)ToolStripMenuItem185).set_Name("ToolStripMenuItem185");
		ToolStripMenuItem toolStripMenuItem185 = ToolStripMenuItem185;
		size = new Size(50, 20);
		((ToolStripItem)toolStripMenuItem185).set_Size(size);
		((ToolStripItem)ToolStripMenuItem185).set_Text("&Outils");
		((ToolStripItem)ToolStripMenuItem186).set_Name("ToolStripMenuItem186");
		ToolStripMenuItem toolStripMenuItem186 = ToolStripMenuItem186;
		size = new Size(116, 22);
		((ToolStripItem)toolStripMenuItem186).set_Size(size);
		((ToolStripItem)ToolStripMenuItem186).set_Text("&Options");
		((ToolStripDropDownItem)ToolStripMenuItem187).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem188,
			(ToolStripItem)ToolStripMenuItem189,
			(ToolStripItem)ToolStripMenuItem190,
			(ToolStripItem)ToolStripMenuItem191,
			(ToolStripItem)ToolStripMenuItem192,
			(ToolStripItem)ToolStripMenuItem193
		});
		((ToolStripItem)ToolStripMenuItem187).set_Name("ToolStripMenuItem187");
		ToolStripMenuItem toolStripMenuItem187 = ToolStripMenuItem187;
		size = new Size(63, 20);
		((ToolStripItem)toolStripMenuItem187).set_Size(size);
		((ToolStripItem)ToolStripMenuItem187).set_Text("F&enêtres");
		((ToolStripItem)ToolStripMenuItem188).set_Name("ToolStripMenuItem188");
		ToolStripMenuItem toolStripMenuItem188 = ToolStripMenuItem188;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem188).set_Size(size);
		((ToolStripItem)ToolStripMenuItem188).set_Text("&Nouvelle fenêtre");
		((ToolStripItem)ToolStripMenuItem189).set_Name("ToolStripMenuItem189");
		ToolStripMenuItem toolStripMenuItem189 = ToolStripMenuItem189;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem189).set_Size(size);
		((ToolStripItem)ToolStripMenuItem189).set_Text("&Cascade");
		((ToolStripItem)ToolStripMenuItem190).set_Name("ToolStripMenuItem190");
		ToolStripMenuItem toolStripMenuItem190 = ToolStripMenuItem190;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem190).set_Size(size);
		((ToolStripItem)ToolStripMenuItem190).set_Text("Mosaïque &verticale");
		((ToolStripItem)ToolStripMenuItem191).set_Name("ToolStripMenuItem191");
		ToolStripMenuItem toolStripMenuItem191 = ToolStripMenuItem191;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem191).set_Size(size);
		((ToolStripItem)ToolStripMenuItem191).set_Text("Mosaïque &horizontale");
		((ToolStripItem)ToolStripMenuItem192).set_Name("ToolStripMenuItem192");
		ToolStripMenuItem toolStripMenuItem192 = ToolStripMenuItem192;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem192).set_Size(size);
		((ToolStripItem)ToolStripMenuItem192).set_Text("&Fermer tout");
		((ToolStripItem)ToolStripMenuItem193).set_Name("ToolStripMenuItem193");
		ToolStripMenuItem toolStripMenuItem193 = ToolStripMenuItem193;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem193).set_Size(size);
		((ToolStripItem)ToolStripMenuItem193).set_Text("&Réorganiser les icônes");
		((ToolStripDropDownItem)ToolStripMenuItem194).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ToolStripMenuItem195,
			(ToolStripItem)ToolStripMenuItem196,
			(ToolStripItem)ToolStripMenuItem197,
			(ToolStripItem)ToolStripSeparator54,
			(ToolStripItem)ToolStripMenuItem198
		});
		((ToolStripItem)ToolStripMenuItem194).set_Name("ToolStripMenuItem194");
		ToolStripMenuItem toolStripMenuItem194 = ToolStripMenuItem194;
		size = new Size(24, 20);
		((ToolStripItem)toolStripMenuItem194).set_Size(size);
		((ToolStripItem)ToolStripMenuItem194).set_Text("&?");
		((ToolStripItem)ToolStripMenuItem195).set_Name("ToolStripMenuItem195");
		ToolStripMenuItem195.set_ShortcutKeys((Keys)131184);
		ToolStripMenuItem toolStripMenuItem195 = ToolStripMenuItem195;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem195).set_Size(size);
		((ToolStripItem)ToolStripMenuItem195).set_Text("&Contenu");
		((ToolStripItem)ToolStripMenuItem196).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem196.Image"));
		((ToolStripItem)ToolStripMenuItem196).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem196).set_Name("ToolStripMenuItem196");
		ToolStripMenuItem toolStripMenuItem196 = ToolStripMenuItem196;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem196).set_Size(size);
		((ToolStripItem)ToolStripMenuItem196).set_Text("&Index");
		((ToolStripItem)ToolStripMenuItem197).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem197.Image"));
		((ToolStripItem)ToolStripMenuItem197).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem197).set_Name("ToolStripMenuItem197");
		ToolStripMenuItem toolStripMenuItem197 = ToolStripMenuItem197;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem197).set_Size(size);
		((ToolStripItem)ToolStripMenuItem197).set_Text("&Rechercher");
		((ToolStripItem)ToolStripSeparator54).set_Name("ToolStripSeparator54");
		ToolStripSeparator toolStripSeparator54 = ToolStripSeparator54;
		size = new Size(163, 6);
		((ToolStripItem)toolStripSeparator54).set_Size(size);
		((ToolStripItem)ToolStripMenuItem198).set_Name("ToolStripMenuItem198");
		ToolStripMenuItem toolStripMenuItem198 = ToolStripMenuItem198;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem198).set_Size(size);
		((ToolStripItem)ToolStripMenuItem198).set_Text("À pr&opos de...");
		((ToolStripItem)ToolStripSeparator55).set_Name("ToolStripSeparator55");
		ToolStripSeparator toolStripSeparator55 = ToolStripSeparator55;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator55).set_Size(size);
		((ToolStripItem)ToolStripButton31).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton31).set_Image((Image)componentResourceManager.GetObject("ToolStripButton31.Image"));
		((ToolStripItem)ToolStripButton31).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton31).set_Name("ToolStripButton31");
		ToolStripButton toolStripButton31 = ToolStripButton31;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton31).set_Size(size);
		((ToolStripItem)ToolStripButton31).set_Text("Aide");
		((ToolStrip)StatusStrip6).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel6 });
		StatusStrip statusStrip13 = StatusStrip6;
		location = new Point(0, 299);
		((Control)statusStrip13).set_Location(location);
		((Control)StatusStrip6).set_Name("StatusStrip6");
		StatusStrip statusStrip14 = StatusStrip6;
		size = new Size(632, 22);
		((Control)statusStrip14).set_Size(size);
		((Control)StatusStrip6).set_TabIndex(26);
		((Control)StatusStrip6).set_Text("StatusStrip");
		((ToolStripItem)ToolStripStatusLabel6).set_Name("ToolStripStatusLabel6");
		ToolStripStatusLabel toolStripStatusLabel7 = ToolStripStatusLabel6;
		size = new Size(27, 17);
		((ToolStripItem)toolStripStatusLabel7).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel6).set_Text("État");
		((ToolStripItem)ToolStripButton32).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton32).set_Image((Image)componentResourceManager.GetObject("ToolStripButton32.Image"));
		((ToolStripItem)ToolStripButton32).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton32).set_Name("ToolStripButton32");
		ToolStripButton toolStripButton32 = ToolStripButton32;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton32).set_Size(size);
		((ToolStripItem)ToolStripButton32).set_Text("Aperçu avant impression");
		((ToolStripItem)ToolStripButton33).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton33).set_Image((Image)componentResourceManager.GetObject("ToolStripButton33.Image"));
		((ToolStripItem)ToolStripButton33).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton33).set_Name("ToolStripButton33");
		ToolStripButton toolStripButton33 = ToolStripButton33;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton33).set_Size(size);
		((ToolStripItem)ToolStripButton33).set_Text("Imprimer");
		((ToolStripItem)ToolStripSeparator56).set_Name("ToolStripSeparator56");
		ToolStripSeparator toolStripSeparator56 = ToolStripSeparator56;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator56).set_Size(size);
		ToolStrip6.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripButton34,
			(ToolStripItem)ToolStripButton35,
			(ToolStripItem)ToolStripButton36,
			(ToolStripItem)ToolStripSeparator56,
			(ToolStripItem)ToolStripButton33,
			(ToolStripItem)ToolStripButton32,
			(ToolStripItem)ToolStripSeparator55,
			(ToolStripItem)ToolStripButton31
		});
		ToolStrip toolStrip13 = ToolStrip6;
		location = new Point(0, 294);
		((Control)toolStrip13).set_Location(location);
		((Control)ToolStrip6).set_Name("ToolStrip6");
		ToolStrip toolStrip14 = ToolStrip6;
		size = new Size(632, 25);
		((Control)toolStrip14).set_Size(size);
		((Control)ToolStrip6).set_TabIndex(25);
		((Control)ToolStrip6).set_Text("ToolStrip");
		((ToolStripItem)ToolStripButton34).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton34).set_Image((Image)componentResourceManager.GetObject("ToolStripButton34.Image"));
		((ToolStripItem)ToolStripButton34).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton34).set_Name("ToolStripButton34");
		ToolStripButton toolStripButton34 = ToolStripButton34;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton34).set_Size(size);
		((ToolStripItem)ToolStripButton34).set_Text("Nouveau");
		((ToolStripItem)ToolStripButton35).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton35).set_Image((Image)componentResourceManager.GetObject("ToolStripButton35.Image"));
		((ToolStripItem)ToolStripButton35).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton35).set_Name("ToolStripButton35");
		ToolStripButton toolStripButton35 = ToolStripButton35;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton35).set_Size(size);
		((ToolStripItem)ToolStripButton35).set_Text("Ouvrir");
		((ToolStripItem)ToolStripButton36).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton36).set_Image((Image)componentResourceManager.GetObject("ToolStripButton36.Image"));
		((ToolStripItem)ToolStripButton36).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton36).set_Name("ToolStripButton36");
		ToolStripButton toolStripButton36 = ToolStripButton36;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton36).set_Size(size);
		((ToolStripItem)ToolStripButton36).set_Text("Enregistrer");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(632, 453);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)MenuStrip6);
		((Control)this).get_Controls().Add((Control)(object)StatusStrip6);
		((Control)this).get_Controls().Add((Control)(object)ToolStrip6);
		((Control)this).get_Controls().Add((Control)(object)MenuStrip5);
		((Control)this).get_Controls().Add((Control)(object)StatusStrip5);
		((Control)this).get_Controls().Add((Control)(object)ToolStrip5);
		((Control)this).get_Controls().Add((Control)(object)MenuStrip4);
		((Control)this).get_Controls().Add((Control)(object)StatusStrip4);
		((Control)this).get_Controls().Add((Control)(object)ToolStrip4);
		((Control)this).get_Controls().Add((Control)(object)MenuStrip3);
		((Control)this).get_Controls().Add((Control)(object)StatusStrip3);
		((Control)this).get_Controls().Add((Control)(object)ToolStrip3);
		((Control)this).get_Controls().Add((Control)(object)MenuStrip2);
		((Control)this).get_Controls().Add((Control)(object)StatusStrip2);
		((Control)this).get_Controls().Add((Control)(object)ToolStrip2);
		((Control)this).get_Controls().Add((Control)(object)MenuStrip1);
		((Control)this).get_Controls().Add((Control)(object)StatusStrip1);
		((Control)this).get_Controls().Add((Control)(object)ToolStrip1);
		((Control)this).get_Controls().Add((Control)(object)ToolStrip);
		((Control)this).get_Controls().Add((Control)(object)MenuStrip);
		((Control)this).get_Controls().Add((Control)(object)StatusStrip);
		((Form)this).set_IsMdiContainer(true);
		((Form)this).set_MainMenuStrip(MenuStrip);
		((Control)this).set_Name("MDIParent1");
		((Form)this).set_Text("MDIParent1");
		((Control)MenuStrip).ResumeLayout(false);
		((Control)MenuStrip).PerformLayout();
		((Control)ToolStrip).ResumeLayout(false);
		((Control)ToolStrip).PerformLayout();
		((Control)StatusStrip).ResumeLayout(false);
		((Control)StatusStrip).PerformLayout();
		((Control)MenuStrip1).ResumeLayout(false);
		((Control)MenuStrip1).PerformLayout();
		((Control)StatusStrip1).ResumeLayout(false);
		((Control)StatusStrip1).PerformLayout();
		((Control)ToolStrip1).ResumeLayout(false);
		((Control)ToolStrip1).PerformLayout();
		((Control)MenuStrip2).ResumeLayout(false);
		((Control)MenuStrip2).PerformLayout();
		((Control)StatusStrip2).ResumeLayout(false);
		((Control)StatusStrip2).PerformLayout();
		((Control)ToolStrip2).ResumeLayout(false);
		((Control)ToolStrip2).PerformLayout();
		((Control)MenuStrip3).ResumeLayout(false);
		((Control)MenuStrip3).PerformLayout();
		((Control)StatusStrip3).ResumeLayout(false);
		((Control)StatusStrip3).PerformLayout();
		((Control)ToolStrip3).ResumeLayout(false);
		((Control)ToolStrip3).PerformLayout();
		((Control)MenuStrip4).ResumeLayout(false);
		((Control)MenuStrip4).PerformLayout();
		((Control)StatusStrip4).ResumeLayout(false);
		((Control)StatusStrip4).PerformLayout();
		((Control)ToolStrip4).ResumeLayout(false);
		((Control)ToolStrip4).PerformLayout();
		((Control)MenuStrip5).ResumeLayout(false);
		((Control)MenuStrip5).PerformLayout();
		((Control)StatusStrip5).ResumeLayout(false);
		((Control)StatusStrip5).PerformLayout();
		((Control)ToolStrip5).ResumeLayout(false);
		((Control)ToolStrip5).PerformLayout();
		((Control)MenuStrip6).ResumeLayout(false);
		((Control)MenuStrip6).PerformLayout();
		((Control)StatusStrip6).ResumeLayout(false);
		((Control)StatusStrip6).PerformLayout();
		((Control)ToolStrip6).ResumeLayout(false);
		((Control)ToolStrip6).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void ShowNewForm(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		Form val = new Form();
		val.set_MdiParent((Form)(object)this);
		checked
		{
			m_ChildFormNumber++;
			val.set_Text("Fenêtre " + Conversions.ToString(m_ChildFormNumber));
			((Control)val).Show();
		}
	}

	private void OpenFile(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_InitialDirectory(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments());
		((FileDialog)val).set_Filter("Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*");
		if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
		{
			((FileDialog)val).get_FileName();
		}
	}

	private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).set_InitialDirectory(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments());
		((FileDialog)val).set_Filter("Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*");
		if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
		{
			((FileDialog)val).get_FileName();
		}
	}

	private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void CutToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)ToolStrip).set_Visible(ToolBarToolStripMenuItem.get_Checked());
	}

	private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)StatusStrip).set_Visible(StatusBarToolStripMenuItem.get_Checked());
	}

	private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)0);
	}

	private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)2);
	}

	private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)1);
	}

	private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)3);
	}

	private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Form[] mdiChildren = ((Form)this).get_MdiChildren();
		foreach (Form val in mdiChildren)
		{
			val.Close();
		}
	}
}
