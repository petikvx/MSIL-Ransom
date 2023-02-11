using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using WindowsApplication1.My;

namespace WindowsApplication1;

[DesignerGenerated]
public class Explorer1 : Form
{
	[AccessedThroughProperty("ToolStripContainer")]
	private ToolStripContainer _ToolStripContainer;

	[AccessedThroughProperty("TreeNodeImageList")]
	private ImageList _TreeNodeImageList;

	[AccessedThroughProperty("ToolStripSeparator7")]
	private ToolStripSeparator _ToolStripSeparator7;

	[AccessedThroughProperty("ToolStripSeparator8")]
	private ToolStripSeparator _ToolStripSeparator8;

	[AccessedThroughProperty("ToolStrip")]
	private ToolStrip _ToolStrip;

	[AccessedThroughProperty("BackToolStripButton")]
	private ToolStripButton _BackToolStripButton;

	[AccessedThroughProperty("ForwardToolStripButton")]
	private ToolStripButton _ForwardToolStripButton;

	[AccessedThroughProperty("FoldersToolStripButton")]
	private ToolStripButton _FoldersToolStripButton;

	[AccessedThroughProperty("ListViewToolStripButton")]
	private ToolStripDropDownButton _ListViewToolStripButton;

	[AccessedThroughProperty("ListToolStripMenuItem")]
	private ToolStripMenuItem _ListToolStripMenuItem;

	[AccessedThroughProperty("DetailsToolStripMenuItem")]
	private ToolStripMenuItem _DetailsToolStripMenuItem;

	[AccessedThroughProperty("LargeIconsToolStripMenuItem")]
	private ToolStripMenuItem _LargeIconsToolStripMenuItem;

	[AccessedThroughProperty("SmallIconsToolStripMenuItem")]
	private ToolStripMenuItem _SmallIconsToolStripMenuItem;

	[AccessedThroughProperty("TileToolStripMenuItem")]
	private ToolStripMenuItem _TileToolStripMenuItem;

	[AccessedThroughProperty("MenuStrip")]
	private MenuStrip _MenuStrip;

	[AccessedThroughProperty("FileToolStripMenuItem")]
	private ToolStripMenuItem _FileToolStripMenuItem;

	[AccessedThroughProperty("NewToolStripMenuItem")]
	private ToolStripMenuItem _NewToolStripMenuItem;

	[AccessedThroughProperty("OpenToolStripMenuItem")]
	private ToolStripMenuItem _OpenToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator1")]
	private ToolStripSeparator _ToolStripSeparator1;

	[AccessedThroughProperty("SaveToolStripMenuItem")]
	private ToolStripMenuItem _SaveToolStripMenuItem;

	[AccessedThroughProperty("SaveAsToolStripMenuItem")]
	private ToolStripMenuItem _SaveAsToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator2")]
	private ToolStripSeparator _ToolStripSeparator2;

	[AccessedThroughProperty("PrintToolStripMenuItem")]
	private ToolStripMenuItem _PrintToolStripMenuItem;

	[AccessedThroughProperty("PrintPreviewToolStripMenuItem")]
	private ToolStripMenuItem _PrintPreviewToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator3")]
	private ToolStripSeparator _ToolStripSeparator3;

	[AccessedThroughProperty("ExitToolStripMenuItem")]
	private ToolStripMenuItem _ExitToolStripMenuItem;

	[AccessedThroughProperty("EditToolStripMenuItem")]
	private ToolStripMenuItem _EditToolStripMenuItem;

	[AccessedThroughProperty("UndoToolStripMenuItem")]
	private ToolStripMenuItem _UndoToolStripMenuItem;

	[AccessedThroughProperty("RedoToolStripMenuItem")]
	private ToolStripMenuItem _RedoToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator4")]
	private ToolStripSeparator _ToolStripSeparator4;

	[AccessedThroughProperty("CutToolStripMenuItem")]
	private ToolStripMenuItem _CutToolStripMenuItem;

	[AccessedThroughProperty("CopyToolStripMenuItem")]
	private ToolStripMenuItem _CopyToolStripMenuItem;

	[AccessedThroughProperty("PasteToolStripMenuItem")]
	private ToolStripMenuItem _PasteToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator5")]
	private ToolStripSeparator _ToolStripSeparator5;

	[AccessedThroughProperty("SelectAllToolStripMenuItem")]
	private ToolStripMenuItem _SelectAllToolStripMenuItem;

	[AccessedThroughProperty("ViewToolStripMenuItem")]
	private ToolStripMenuItem _ViewToolStripMenuItem;

	[AccessedThroughProperty("ToolBarToolStripMenuItem")]
	private ToolStripMenuItem _ToolBarToolStripMenuItem;

	[AccessedThroughProperty("StatusBarToolStripMenuItem")]
	private ToolStripMenuItem _StatusBarToolStripMenuItem;

	[AccessedThroughProperty("FoldersToolStripMenuItem")]
	private ToolStripMenuItem _FoldersToolStripMenuItem;

	[AccessedThroughProperty("ToolsToolStripMenuItem")]
	private ToolStripMenuItem _ToolsToolStripMenuItem;

	[AccessedThroughProperty("OptionsToolStripMenuItem")]
	private ToolStripMenuItem _OptionsToolStripMenuItem;

	[AccessedThroughProperty("HelpToolStripMenuItem")]
	private ToolStripMenuItem _HelpToolStripMenuItem;

	[AccessedThroughProperty("ContentsToolStripMenuItem")]
	private ToolStripMenuItem _ContentsToolStripMenuItem;

	[AccessedThroughProperty("IndexToolStripMenuItem")]
	private ToolStripMenuItem _IndexToolStripMenuItem;

	[AccessedThroughProperty("SearchToolStripMenuItem")]
	private ToolStripMenuItem _SearchToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator6")]
	private ToolStripSeparator _ToolStripSeparator6;

	[AccessedThroughProperty("AboutToolStripMenuItem")]
	private ToolStripMenuItem _AboutToolStripMenuItem;

	[AccessedThroughProperty("SplitContainer")]
	private SplitContainer _SplitContainer;

	[AccessedThroughProperty("TreeView")]
	private TreeView _TreeView;

	[AccessedThroughProperty("ListView")]
	private ListView _ListView;

	[AccessedThroughProperty("StatusStrip")]
	private StatusStrip _StatusStrip;

	[AccessedThroughProperty("ToolStripStatusLabel")]
	private ToolStripStatusLabel _ToolStripStatusLabel;

	[AccessedThroughProperty("ToolTip")]
	private ToolTip _ToolTip;

	[AccessedThroughProperty("ListViewLargeImageList")]
	private ImageList _ListViewLargeImageList;

	[AccessedThroughProperty("ListViewSmallImageList")]
	private ImageList _ListViewSmallImageList;

	private IContainer components;

	[AccessedThroughProperty("MenuStrip2")]
	private MenuStrip _MenuStrip2;

	[AccessedThroughProperty("ToolStripMenuItem21")]
	private ToolStripMenuItem _ToolStripMenuItem21;

	[AccessedThroughProperty("ToolStripMenuItem22")]
	private ToolStripMenuItem _ToolStripMenuItem22;

	[AccessedThroughProperty("ToolStripMenuItem23")]
	private ToolStripMenuItem _ToolStripMenuItem23;

	[AccessedThroughProperty("ToolStripSeparator17")]
	private ToolStripSeparator _ToolStripSeparator17;

	[AccessedThroughProperty("ToolStripMenuItem24")]
	private ToolStripMenuItem _ToolStripMenuItem24;

	[AccessedThroughProperty("ToolStripMenuItem25")]
	private ToolStripMenuItem _ToolStripMenuItem25;

	[AccessedThroughProperty("ToolStripSeparator18")]
	private ToolStripSeparator _ToolStripSeparator18;

	[AccessedThroughProperty("ToolStripMenuItem26")]
	private ToolStripMenuItem _ToolStripMenuItem26;

	[AccessedThroughProperty("ToolStripMenuItem27")]
	private ToolStripMenuItem _ToolStripMenuItem27;

	[AccessedThroughProperty("ToolStripMenuItem28")]
	private ToolStripMenuItem _ToolStripMenuItem28;

	[AccessedThroughProperty("ToolStripSeparator19")]
	private ToolStripSeparator _ToolStripSeparator19;

	[AccessedThroughProperty("ToolStripMenuItem29")]
	private ToolStripMenuItem _ToolStripMenuItem29;

	[AccessedThroughProperty("ToolStripMenuItem30")]
	private ToolStripMenuItem _ToolStripMenuItem30;

	[AccessedThroughProperty("ToolStripMenuItem31")]
	private ToolStripMenuItem _ToolStripMenuItem31;

	[AccessedThroughProperty("ToolStripMenuItem32")]
	private ToolStripMenuItem _ToolStripMenuItem32;

	[AccessedThroughProperty("ToolStripSeparator20")]
	private ToolStripSeparator _ToolStripSeparator20;

	[AccessedThroughProperty("ToolStripMenuItem33")]
	private ToolStripMenuItem _ToolStripMenuItem33;

	[AccessedThroughProperty("ToolStripMenuItem34")]
	private ToolStripMenuItem _ToolStripMenuItem34;

	[AccessedThroughProperty("ToolStripMenuItem35")]
	private ToolStripMenuItem _ToolStripMenuItem35;

	[AccessedThroughProperty("ToolStripSeparator21")]
	private ToolStripSeparator _ToolStripSeparator21;

	[AccessedThroughProperty("ToolStripMenuItem36")]
	private ToolStripMenuItem _ToolStripMenuItem36;

	[AccessedThroughProperty("ToolStripMenuItem37")]
	private ToolStripMenuItem _ToolStripMenuItem37;

	[AccessedThroughProperty("ToolStripMenuItem38")]
	private ToolStripMenuItem _ToolStripMenuItem38;

	[AccessedThroughProperty("ToolStripMenuItem39")]
	private ToolStripMenuItem _ToolStripMenuItem39;

	[AccessedThroughProperty("ToolStripMenuItem40")]
	private ToolStripMenuItem _ToolStripMenuItem40;

	[AccessedThroughProperty("ToolStripMenuItem41")]
	private ToolStripMenuItem _ToolStripMenuItem41;

	[AccessedThroughProperty("ToolStripMenuItem42")]
	private ToolStripMenuItem _ToolStripMenuItem42;

	[AccessedThroughProperty("ToolStripMenuItem43")]
	private ToolStripMenuItem _ToolStripMenuItem43;

	[AccessedThroughProperty("ToolStripMenuItem44")]
	private ToolStripMenuItem _ToolStripMenuItem44;

	[AccessedThroughProperty("ToolStripMenuItem45")]
	private ToolStripMenuItem _ToolStripMenuItem45;

	[AccessedThroughProperty("ToolStripMenuItem46")]
	private ToolStripMenuItem _ToolStripMenuItem46;

	[AccessedThroughProperty("ToolStripMenuItem47")]
	private ToolStripMenuItem _ToolStripMenuItem47;

	[AccessedThroughProperty("ToolStripMenuItem48")]
	private ToolStripMenuItem _ToolStripMenuItem48;

	[AccessedThroughProperty("ToolStripMenuItem49")]
	private ToolStripMenuItem _ToolStripMenuItem49;

	[AccessedThroughProperty("ToolStripMenuItem50")]
	private ToolStripMenuItem _ToolStripMenuItem50;

	[AccessedThroughProperty("ToolStripMenuItem51")]
	private ToolStripMenuItem _ToolStripMenuItem51;

	[AccessedThroughProperty("ToolStripMenuItem52")]
	private ToolStripMenuItem _ToolStripMenuItem52;

	[AccessedThroughProperty("ToolStripSeparator22")]
	private ToolStripSeparator _ToolStripSeparator22;

	[AccessedThroughProperty("ToolStripMenuItem53")]
	private ToolStripMenuItem _ToolStripMenuItem53;

	[AccessedThroughProperty("StatusStrip2")]
	private StatusStrip _StatusStrip2;

	[AccessedThroughProperty("ToolStripStatusLabel2")]
	private ToolStripStatusLabel _ToolStripStatusLabel2;

	[AccessedThroughProperty("ToolStrip2")]
	private ToolStrip _ToolStrip2;

	[AccessedThroughProperty("ToolStripButton4")]
	private ToolStripButton _ToolStripButton4;

	[AccessedThroughProperty("ToolStripButton5")]
	private ToolStripButton _ToolStripButton5;

	[AccessedThroughProperty("ToolStripButton6")]
	private ToolStripButton _ToolStripButton6;

	[AccessedThroughProperty("ToolStripSeparator24")]
	private ToolStripSeparator _ToolStripSeparator24;

	[AccessedThroughProperty("ToolStripButton3")]
	private ToolStripButton _ToolStripButton3;

	[AccessedThroughProperty("ToolStripButton2")]
	private ToolStripButton _ToolStripButton2;

	[AccessedThroughProperty("ToolStripSeparator23")]
	private ToolStripSeparator _ToolStripSeparator23;

	[AccessedThroughProperty("ToolStripButton1")]
	private ToolStripButton _ToolStripButton1;

	[AccessedThroughProperty("MenuStrip1")]
	private MenuStrip _MenuStrip1;

	[AccessedThroughProperty("FileMenu")]
	private ToolStripMenuItem _FileMenu;

	[AccessedThroughProperty("ToolStripMenuItem1")]
	private ToolStripMenuItem _ToolStripMenuItem1;

	[AccessedThroughProperty("ToolStripMenuItem2")]
	private ToolStripMenuItem _ToolStripMenuItem2;

	[AccessedThroughProperty("ToolStripSeparator9")]
	private ToolStripSeparator _ToolStripSeparator9;

	[AccessedThroughProperty("ToolStripMenuItem3")]
	private ToolStripMenuItem _ToolStripMenuItem3;

	[AccessedThroughProperty("ToolStripMenuItem4")]
	private ToolStripMenuItem _ToolStripMenuItem4;

	[AccessedThroughProperty("ToolStripSeparator10")]
	private ToolStripSeparator _ToolStripSeparator10;

	[AccessedThroughProperty("ToolStripMenuItem5")]
	private ToolStripMenuItem _ToolStripMenuItem5;

	[AccessedThroughProperty("ToolStripMenuItem6")]
	private ToolStripMenuItem _ToolStripMenuItem6;

	[AccessedThroughProperty("PrintSetupToolStripMenuItem")]
	private ToolStripMenuItem _PrintSetupToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator11")]
	private ToolStripSeparator _ToolStripSeparator11;

	[AccessedThroughProperty("ToolStripMenuItem7")]
	private ToolStripMenuItem _ToolStripMenuItem7;

	[AccessedThroughProperty("EditMenu")]
	private ToolStripMenuItem _EditMenu;

	[AccessedThroughProperty("ToolStripMenuItem8")]
	private ToolStripMenuItem _ToolStripMenuItem8;

	[AccessedThroughProperty("ToolStripMenuItem9")]
	private ToolStripMenuItem _ToolStripMenuItem9;

	[AccessedThroughProperty("ToolStripSeparator12")]
	private ToolStripSeparator _ToolStripSeparator12;

	[AccessedThroughProperty("ToolStripMenuItem10")]
	private ToolStripMenuItem _ToolStripMenuItem10;

	[AccessedThroughProperty("ToolStripMenuItem11")]
	private ToolStripMenuItem _ToolStripMenuItem11;

	[AccessedThroughProperty("ToolStripMenuItem12")]
	private ToolStripMenuItem _ToolStripMenuItem12;

	[AccessedThroughProperty("ToolStripSeparator13")]
	private ToolStripSeparator _ToolStripSeparator13;

	[AccessedThroughProperty("ToolStripMenuItem13")]
	private ToolStripMenuItem _ToolStripMenuItem13;

	[AccessedThroughProperty("ViewMenu")]
	private ToolStripMenuItem _ViewMenu;

	[AccessedThroughProperty("ToolStripMenuItem14")]
	private ToolStripMenuItem _ToolStripMenuItem14;

	[AccessedThroughProperty("ToolStripMenuItem15")]
	private ToolStripMenuItem _ToolStripMenuItem15;

	[AccessedThroughProperty("ToolsMenu")]
	private ToolStripMenuItem _ToolsMenu;

	[AccessedThroughProperty("ToolStripMenuItem16")]
	private ToolStripMenuItem _ToolStripMenuItem16;

	[AccessedThroughProperty("WindowsMenu")]
	private ToolStripMenuItem _WindowsMenu;

	[AccessedThroughProperty("NewWindowToolStripMenuItem")]
	private ToolStripMenuItem _NewWindowToolStripMenuItem;

	[AccessedThroughProperty("CascadeToolStripMenuItem")]
	private ToolStripMenuItem _CascadeToolStripMenuItem;

	[AccessedThroughProperty("TileVerticalToolStripMenuItem")]
	private ToolStripMenuItem _TileVerticalToolStripMenuItem;

	[AccessedThroughProperty("TileHorizontalToolStripMenuItem")]
	private ToolStripMenuItem _TileHorizontalToolStripMenuItem;

	[AccessedThroughProperty("CloseAllToolStripMenuItem")]
	private ToolStripMenuItem _CloseAllToolStripMenuItem;

	[AccessedThroughProperty("ArrangeIconsToolStripMenuItem")]
	private ToolStripMenuItem _ArrangeIconsToolStripMenuItem;

	[AccessedThroughProperty("HelpMenu")]
	private ToolStripMenuItem _HelpMenu;

	[AccessedThroughProperty("ToolStripMenuItem17")]
	private ToolStripMenuItem _ToolStripMenuItem17;

	[AccessedThroughProperty("ToolStripMenuItem18")]
	private ToolStripMenuItem _ToolStripMenuItem18;

	[AccessedThroughProperty("ToolStripMenuItem19")]
	private ToolStripMenuItem _ToolStripMenuItem19;

	[AccessedThroughProperty("ToolStripSeparator14")]
	private ToolStripSeparator _ToolStripSeparator14;

	[AccessedThroughProperty("ToolStripMenuItem20")]
	private ToolStripMenuItem _ToolStripMenuItem20;

	[AccessedThroughProperty("StatusStrip1")]
	private StatusStrip _StatusStrip1;

	[AccessedThroughProperty("ToolStripStatusLabel1")]
	private ToolStripStatusLabel _ToolStripStatusLabel1;

	[AccessedThroughProperty("ToolStrip1")]
	private ToolStrip _ToolStrip1;

	[AccessedThroughProperty("NewToolStripButton")]
	private ToolStripButton _NewToolStripButton;

	[AccessedThroughProperty("OpenToolStripButton")]
	private ToolStripButton _OpenToolStripButton;

	[AccessedThroughProperty("SaveToolStripButton")]
	private ToolStripButton _SaveToolStripButton;

	[AccessedThroughProperty("ToolStripSeparator16")]
	private ToolStripSeparator _ToolStripSeparator16;

	[AccessedThroughProperty("PrintToolStripButton")]
	private ToolStripButton _PrintToolStripButton;

	[AccessedThroughProperty("PrintPreviewToolStripButton")]
	private ToolStripButton _PrintPreviewToolStripButton;

	[AccessedThroughProperty("ToolStripSeparator15")]
	private ToolStripSeparator _ToolStripSeparator15;

	[AccessedThroughProperty("HelpToolStripButton")]
	private ToolStripButton _HelpToolStripButton;

	[AccessedThroughProperty("ToolTip1")]
	private ToolTip _ToolTip1;

	[AccessedThroughProperty("ToolTip2")]
	private ToolTip _ToolTip2;

	[AccessedThroughProperty("MenuStrip6")]
	private MenuStrip _MenuStrip6;

	[AccessedThroughProperty("ToolStripMenuItem153")]
	private ToolStripMenuItem _ToolStripMenuItem153;

	[AccessedThroughProperty("ToolStripMenuItem154")]
	private ToolStripMenuItem _ToolStripMenuItem154;

	[AccessedThroughProperty("ToolStripMenuItem155")]
	private ToolStripMenuItem _ToolStripMenuItem155;

	[AccessedThroughProperty("ToolStripSeparator49")]
	private ToolStripSeparator _ToolStripSeparator49;

	[AccessedThroughProperty("ToolStripMenuItem156")]
	private ToolStripMenuItem _ToolStripMenuItem156;

	[AccessedThroughProperty("ToolStripMenuItem157")]
	private ToolStripMenuItem _ToolStripMenuItem157;

	[AccessedThroughProperty("ToolStripSeparator50")]
	private ToolStripSeparator _ToolStripSeparator50;

	[AccessedThroughProperty("ToolStripMenuItem158")]
	private ToolStripMenuItem _ToolStripMenuItem158;

	[AccessedThroughProperty("ToolStripMenuItem159")]
	private ToolStripMenuItem _ToolStripMenuItem159;

	[AccessedThroughProperty("ToolStripMenuItem160")]
	private ToolStripMenuItem _ToolStripMenuItem160;

	[AccessedThroughProperty("ToolStripSeparator51")]
	private ToolStripSeparator _ToolStripSeparator51;

	[AccessedThroughProperty("ToolStripMenuItem161")]
	private ToolStripMenuItem _ToolStripMenuItem161;

	[AccessedThroughProperty("ToolStripMenuItem162")]
	private ToolStripMenuItem _ToolStripMenuItem162;

	[AccessedThroughProperty("ToolStripMenuItem163")]
	private ToolStripMenuItem _ToolStripMenuItem163;

	[AccessedThroughProperty("ToolStripMenuItem164")]
	private ToolStripMenuItem _ToolStripMenuItem164;

	[AccessedThroughProperty("ToolStripSeparator52")]
	private ToolStripSeparator _ToolStripSeparator52;

	[AccessedThroughProperty("ToolStripMenuItem165")]
	private ToolStripMenuItem _ToolStripMenuItem165;

	[AccessedThroughProperty("ToolStripMenuItem166")]
	private ToolStripMenuItem _ToolStripMenuItem166;

	[AccessedThroughProperty("ToolStripMenuItem167")]
	private ToolStripMenuItem _ToolStripMenuItem167;

	[AccessedThroughProperty("ToolStripSeparator53")]
	private ToolStripSeparator _ToolStripSeparator53;

	[AccessedThroughProperty("ToolStripMenuItem168")]
	private ToolStripMenuItem _ToolStripMenuItem168;

	[AccessedThroughProperty("ToolStripMenuItem169")]
	private ToolStripMenuItem _ToolStripMenuItem169;

	[AccessedThroughProperty("ToolStripMenuItem170")]
	private ToolStripMenuItem _ToolStripMenuItem170;

	[AccessedThroughProperty("ToolStripMenuItem171")]
	private ToolStripMenuItem _ToolStripMenuItem171;

	[AccessedThroughProperty("ToolStripMenuItem172")]
	private ToolStripMenuItem _ToolStripMenuItem172;

	[AccessedThroughProperty("ToolStripMenuItem173")]
	private ToolStripMenuItem _ToolStripMenuItem173;

	[AccessedThroughProperty("ToolStripMenuItem174")]
	private ToolStripMenuItem _ToolStripMenuItem174;

	[AccessedThroughProperty("ToolStripMenuItem175")]
	private ToolStripMenuItem _ToolStripMenuItem175;

	[AccessedThroughProperty("ToolStripMenuItem176")]
	private ToolStripMenuItem _ToolStripMenuItem176;

	[AccessedThroughProperty("ToolStripMenuItem177")]
	private ToolStripMenuItem _ToolStripMenuItem177;

	[AccessedThroughProperty("ToolStripMenuItem178")]
	private ToolStripMenuItem _ToolStripMenuItem178;

	[AccessedThroughProperty("ToolStripMenuItem179")]
	private ToolStripMenuItem _ToolStripMenuItem179;

	[AccessedThroughProperty("ToolStripMenuItem180")]
	private ToolStripMenuItem _ToolStripMenuItem180;

	[AccessedThroughProperty("ToolStripMenuItem181")]
	private ToolStripMenuItem _ToolStripMenuItem181;

	[AccessedThroughProperty("ToolStripMenuItem182")]
	private ToolStripMenuItem _ToolStripMenuItem182;

	[AccessedThroughProperty("ToolStripMenuItem183")]
	private ToolStripMenuItem _ToolStripMenuItem183;

	[AccessedThroughProperty("ToolStripMenuItem184")]
	private ToolStripMenuItem _ToolStripMenuItem184;

	[AccessedThroughProperty("ToolStripSeparator54")]
	private ToolStripSeparator _ToolStripSeparator54;

	[AccessedThroughProperty("ToolStripMenuItem185")]
	private ToolStripMenuItem _ToolStripMenuItem185;

	[AccessedThroughProperty("StatusStrip6")]
	private StatusStrip _StatusStrip6;

	[AccessedThroughProperty("ToolStripStatusLabel6")]
	private ToolStripStatusLabel _ToolStripStatusLabel6;

	[AccessedThroughProperty("ToolStrip6")]
	private ToolStrip _ToolStrip6;

	[AccessedThroughProperty("ToolStripButton28")]
	private ToolStripButton _ToolStripButton28;

	[AccessedThroughProperty("ToolStripButton29")]
	private ToolStripButton _ToolStripButton29;

	[AccessedThroughProperty("ToolStripButton30")]
	private ToolStripButton _ToolStripButton30;

	[AccessedThroughProperty("ToolStripSeparator56")]
	private ToolStripSeparator _ToolStripSeparator56;

	[AccessedThroughProperty("ToolStripButton27")]
	private ToolStripButton _ToolStripButton27;

	[AccessedThroughProperty("ToolStripButton26")]
	private ToolStripButton _ToolStripButton26;

	[AccessedThroughProperty("ToolStripSeparator55")]
	private ToolStripSeparator _ToolStripSeparator55;

	[AccessedThroughProperty("ToolStripButton25")]
	private ToolStripButton _ToolStripButton25;

	[AccessedThroughProperty("MenuStrip5")]
	private MenuStrip _MenuStrip5;

	[AccessedThroughProperty("ToolStripMenuItem120")]
	private ToolStripMenuItem _ToolStripMenuItem120;

	[AccessedThroughProperty("ToolStripMenuItem121")]
	private ToolStripMenuItem _ToolStripMenuItem121;

	[AccessedThroughProperty("ToolStripMenuItem122")]
	private ToolStripMenuItem _ToolStripMenuItem122;

	[AccessedThroughProperty("ToolStripSeparator41")]
	private ToolStripSeparator _ToolStripSeparator41;

	[AccessedThroughProperty("ToolStripMenuItem123")]
	private ToolStripMenuItem _ToolStripMenuItem123;

	[AccessedThroughProperty("ToolStripMenuItem124")]
	private ToolStripMenuItem _ToolStripMenuItem124;

	[AccessedThroughProperty("ToolStripSeparator42")]
	private ToolStripSeparator _ToolStripSeparator42;

	[AccessedThroughProperty("ToolStripMenuItem125")]
	private ToolStripMenuItem _ToolStripMenuItem125;

	[AccessedThroughProperty("ToolStripMenuItem126")]
	private ToolStripMenuItem _ToolStripMenuItem126;

	[AccessedThroughProperty("ToolStripMenuItem127")]
	private ToolStripMenuItem _ToolStripMenuItem127;

	[AccessedThroughProperty("ToolStripSeparator43")]
	private ToolStripSeparator _ToolStripSeparator43;

	[AccessedThroughProperty("ToolStripMenuItem128")]
	private ToolStripMenuItem _ToolStripMenuItem128;

	[AccessedThroughProperty("ToolStripMenuItem129")]
	private ToolStripMenuItem _ToolStripMenuItem129;

	[AccessedThroughProperty("ToolStripMenuItem130")]
	private ToolStripMenuItem _ToolStripMenuItem130;

	[AccessedThroughProperty("ToolStripMenuItem131")]
	private ToolStripMenuItem _ToolStripMenuItem131;

	[AccessedThroughProperty("ToolStripSeparator44")]
	private ToolStripSeparator _ToolStripSeparator44;

	[AccessedThroughProperty("ToolStripMenuItem132")]
	private ToolStripMenuItem _ToolStripMenuItem132;

	[AccessedThroughProperty("ToolStripMenuItem133")]
	private ToolStripMenuItem _ToolStripMenuItem133;

	[AccessedThroughProperty("ToolStripMenuItem134")]
	private ToolStripMenuItem _ToolStripMenuItem134;

	[AccessedThroughProperty("ToolStripSeparator45")]
	private ToolStripSeparator _ToolStripSeparator45;

	[AccessedThroughProperty("ToolStripMenuItem135")]
	private ToolStripMenuItem _ToolStripMenuItem135;

	[AccessedThroughProperty("ToolStripMenuItem136")]
	private ToolStripMenuItem _ToolStripMenuItem136;

	[AccessedThroughProperty("ToolStripMenuItem137")]
	private ToolStripMenuItem _ToolStripMenuItem137;

	[AccessedThroughProperty("ToolStripMenuItem138")]
	private ToolStripMenuItem _ToolStripMenuItem138;

	[AccessedThroughProperty("ToolStripMenuItem139")]
	private ToolStripMenuItem _ToolStripMenuItem139;

	[AccessedThroughProperty("ToolStripMenuItem140")]
	private ToolStripMenuItem _ToolStripMenuItem140;

	[AccessedThroughProperty("ToolStripMenuItem141")]
	private ToolStripMenuItem _ToolStripMenuItem141;

	[AccessedThroughProperty("ToolStripMenuItem142")]
	private ToolStripMenuItem _ToolStripMenuItem142;

	[AccessedThroughProperty("ToolStripMenuItem143")]
	private ToolStripMenuItem _ToolStripMenuItem143;

	[AccessedThroughProperty("ToolStripMenuItem144")]
	private ToolStripMenuItem _ToolStripMenuItem144;

	[AccessedThroughProperty("ToolStripMenuItem145")]
	private ToolStripMenuItem _ToolStripMenuItem145;

	[AccessedThroughProperty("ToolStripMenuItem146")]
	private ToolStripMenuItem _ToolStripMenuItem146;

	[AccessedThroughProperty("ToolStripMenuItem147")]
	private ToolStripMenuItem _ToolStripMenuItem147;

	[AccessedThroughProperty("ToolStripMenuItem148")]
	private ToolStripMenuItem _ToolStripMenuItem148;

	[AccessedThroughProperty("ToolStripMenuItem149")]
	private ToolStripMenuItem _ToolStripMenuItem149;

	[AccessedThroughProperty("ToolStripMenuItem150")]
	private ToolStripMenuItem _ToolStripMenuItem150;

	[AccessedThroughProperty("ToolStripMenuItem151")]
	private ToolStripMenuItem _ToolStripMenuItem151;

	[AccessedThroughProperty("ToolStripSeparator46")]
	private ToolStripSeparator _ToolStripSeparator46;

	[AccessedThroughProperty("ToolStripMenuItem152")]
	private ToolStripMenuItem _ToolStripMenuItem152;

	[AccessedThroughProperty("StatusStrip5")]
	private StatusStrip _StatusStrip5;

	[AccessedThroughProperty("ToolStripStatusLabel5")]
	private ToolStripStatusLabel _ToolStripStatusLabel5;

	[AccessedThroughProperty("ToolStrip5")]
	private ToolStrip _ToolStrip5;

	[AccessedThroughProperty("ToolStripButton22")]
	private ToolStripButton _ToolStripButton22;

	[AccessedThroughProperty("ToolStripButton23")]
	private ToolStripButton _ToolStripButton23;

	[AccessedThroughProperty("ToolStripButton24")]
	private ToolStripButton _ToolStripButton24;

	[AccessedThroughProperty("ToolStripSeparator48")]
	private ToolStripSeparator _ToolStripSeparator48;

	[AccessedThroughProperty("ToolStripButton21")]
	private ToolStripButton _ToolStripButton21;

	[AccessedThroughProperty("ToolStripButton20")]
	private ToolStripButton _ToolStripButton20;

	[AccessedThroughProperty("ToolStripSeparator47")]
	private ToolStripSeparator _ToolStripSeparator47;

	[AccessedThroughProperty("ToolStripButton19")]
	private ToolStripButton _ToolStripButton19;

	[AccessedThroughProperty("MenuStrip4")]
	private MenuStrip _MenuStrip4;

	[AccessedThroughProperty("ToolStripMenuItem87")]
	private ToolStripMenuItem _ToolStripMenuItem87;

	[AccessedThroughProperty("ToolStripMenuItem88")]
	private ToolStripMenuItem _ToolStripMenuItem88;

	[AccessedThroughProperty("ToolStripMenuItem89")]
	private ToolStripMenuItem _ToolStripMenuItem89;

	[AccessedThroughProperty("ToolStripSeparator33")]
	private ToolStripSeparator _ToolStripSeparator33;

	[AccessedThroughProperty("ToolStripMenuItem90")]
	private ToolStripMenuItem _ToolStripMenuItem90;

	[AccessedThroughProperty("ToolStripMenuItem91")]
	private ToolStripMenuItem _ToolStripMenuItem91;

	[AccessedThroughProperty("ToolStripSeparator34")]
	private ToolStripSeparator _ToolStripSeparator34;

	[AccessedThroughProperty("ToolStripMenuItem92")]
	private ToolStripMenuItem _ToolStripMenuItem92;

	[AccessedThroughProperty("ToolStripMenuItem93")]
	private ToolStripMenuItem _ToolStripMenuItem93;

	[AccessedThroughProperty("ToolStripMenuItem94")]
	private ToolStripMenuItem _ToolStripMenuItem94;

	[AccessedThroughProperty("ToolStripSeparator35")]
	private ToolStripSeparator _ToolStripSeparator35;

	[AccessedThroughProperty("ToolStripMenuItem95")]
	private ToolStripMenuItem _ToolStripMenuItem95;

	[AccessedThroughProperty("ToolStripMenuItem96")]
	private ToolStripMenuItem _ToolStripMenuItem96;

	[AccessedThroughProperty("ToolStripMenuItem97")]
	private ToolStripMenuItem _ToolStripMenuItem97;

	[AccessedThroughProperty("ToolStripMenuItem98")]
	private ToolStripMenuItem _ToolStripMenuItem98;

	[AccessedThroughProperty("ToolStripSeparator36")]
	private ToolStripSeparator _ToolStripSeparator36;

	[AccessedThroughProperty("ToolStripMenuItem99")]
	private ToolStripMenuItem _ToolStripMenuItem99;

	[AccessedThroughProperty("ToolStripMenuItem100")]
	private ToolStripMenuItem _ToolStripMenuItem100;

	[AccessedThroughProperty("ToolStripMenuItem101")]
	private ToolStripMenuItem _ToolStripMenuItem101;

	[AccessedThroughProperty("ToolStripSeparator37")]
	private ToolStripSeparator _ToolStripSeparator37;

	[AccessedThroughProperty("ToolStripMenuItem102")]
	private ToolStripMenuItem _ToolStripMenuItem102;

	[AccessedThroughProperty("ToolStripMenuItem103")]
	private ToolStripMenuItem _ToolStripMenuItem103;

	[AccessedThroughProperty("ToolStripMenuItem104")]
	private ToolStripMenuItem _ToolStripMenuItem104;

	[AccessedThroughProperty("ToolStripMenuItem105")]
	private ToolStripMenuItem _ToolStripMenuItem105;

	[AccessedThroughProperty("ToolStripMenuItem106")]
	private ToolStripMenuItem _ToolStripMenuItem106;

	[AccessedThroughProperty("ToolStripMenuItem107")]
	private ToolStripMenuItem _ToolStripMenuItem107;

	[AccessedThroughProperty("ToolStripMenuItem108")]
	private ToolStripMenuItem _ToolStripMenuItem108;

	[AccessedThroughProperty("ToolStripMenuItem109")]
	private ToolStripMenuItem _ToolStripMenuItem109;

	[AccessedThroughProperty("ToolStripMenuItem110")]
	private ToolStripMenuItem _ToolStripMenuItem110;

	[AccessedThroughProperty("ToolStripMenuItem111")]
	private ToolStripMenuItem _ToolStripMenuItem111;

	[AccessedThroughProperty("ToolStripMenuItem112")]
	private ToolStripMenuItem _ToolStripMenuItem112;

	[AccessedThroughProperty("ToolStripMenuItem113")]
	private ToolStripMenuItem _ToolStripMenuItem113;

	[AccessedThroughProperty("ToolStripMenuItem114")]
	private ToolStripMenuItem _ToolStripMenuItem114;

	[AccessedThroughProperty("ToolStripMenuItem115")]
	private ToolStripMenuItem _ToolStripMenuItem115;

	[AccessedThroughProperty("ToolStripMenuItem116")]
	private ToolStripMenuItem _ToolStripMenuItem116;

	[AccessedThroughProperty("ToolStripMenuItem117")]
	private ToolStripMenuItem _ToolStripMenuItem117;

	[AccessedThroughProperty("ToolStripMenuItem118")]
	private ToolStripMenuItem _ToolStripMenuItem118;

	[AccessedThroughProperty("ToolStripSeparator38")]
	private ToolStripSeparator _ToolStripSeparator38;

	[AccessedThroughProperty("ToolStripMenuItem119")]
	private ToolStripMenuItem _ToolStripMenuItem119;

	[AccessedThroughProperty("StatusStrip4")]
	private StatusStrip _StatusStrip4;

	[AccessedThroughProperty("ToolStripStatusLabel4")]
	private ToolStripStatusLabel _ToolStripStatusLabel4;

	[AccessedThroughProperty("ToolStrip4")]
	private ToolStrip _ToolStrip4;

	[AccessedThroughProperty("ToolStripButton16")]
	private ToolStripButton _ToolStripButton16;

	[AccessedThroughProperty("ToolStripButton17")]
	private ToolStripButton _ToolStripButton17;

	[AccessedThroughProperty("ToolStripButton18")]
	private ToolStripButton _ToolStripButton18;

	[AccessedThroughProperty("ToolStripSeparator40")]
	private ToolStripSeparator _ToolStripSeparator40;

	[AccessedThroughProperty("ToolStripButton15")]
	private ToolStripButton _ToolStripButton15;

	[AccessedThroughProperty("ToolStripButton14")]
	private ToolStripButton _ToolStripButton14;

	[AccessedThroughProperty("ToolStripSeparator39")]
	private ToolStripSeparator _ToolStripSeparator39;

	[AccessedThroughProperty("ToolStripButton13")]
	private ToolStripButton _ToolStripButton13;

	[AccessedThroughProperty("MenuStrip3")]
	private MenuStrip _MenuStrip3;

	[AccessedThroughProperty("ToolStripMenuItem54")]
	private ToolStripMenuItem _ToolStripMenuItem54;

	[AccessedThroughProperty("ToolStripMenuItem55")]
	private ToolStripMenuItem _ToolStripMenuItem55;

	[AccessedThroughProperty("ToolStripMenuItem56")]
	private ToolStripMenuItem _ToolStripMenuItem56;

	[AccessedThroughProperty("ToolStripSeparator25")]
	private ToolStripSeparator _ToolStripSeparator25;

	[AccessedThroughProperty("ToolStripMenuItem57")]
	private ToolStripMenuItem _ToolStripMenuItem57;

	[AccessedThroughProperty("ToolStripMenuItem58")]
	private ToolStripMenuItem _ToolStripMenuItem58;

	[AccessedThroughProperty("ToolStripSeparator26")]
	private ToolStripSeparator _ToolStripSeparator26;

	[AccessedThroughProperty("ToolStripMenuItem59")]
	private ToolStripMenuItem _ToolStripMenuItem59;

	[AccessedThroughProperty("ToolStripMenuItem60")]
	private ToolStripMenuItem _ToolStripMenuItem60;

	[AccessedThroughProperty("ToolStripMenuItem61")]
	private ToolStripMenuItem _ToolStripMenuItem61;

	[AccessedThroughProperty("ToolStripSeparator27")]
	private ToolStripSeparator _ToolStripSeparator27;

	[AccessedThroughProperty("ToolStripMenuItem62")]
	private ToolStripMenuItem _ToolStripMenuItem62;

	[AccessedThroughProperty("ToolStripMenuItem63")]
	private ToolStripMenuItem _ToolStripMenuItem63;

	[AccessedThroughProperty("ToolStripMenuItem64")]
	private ToolStripMenuItem _ToolStripMenuItem64;

	[AccessedThroughProperty("ToolStripMenuItem65")]
	private ToolStripMenuItem _ToolStripMenuItem65;

	[AccessedThroughProperty("ToolStripSeparator28")]
	private ToolStripSeparator _ToolStripSeparator28;

	[AccessedThroughProperty("ToolStripMenuItem66")]
	private ToolStripMenuItem _ToolStripMenuItem66;

	[AccessedThroughProperty("ToolStripMenuItem67")]
	private ToolStripMenuItem _ToolStripMenuItem67;

	[AccessedThroughProperty("ToolStripMenuItem68")]
	private ToolStripMenuItem _ToolStripMenuItem68;

	[AccessedThroughProperty("ToolStripSeparator29")]
	private ToolStripSeparator _ToolStripSeparator29;

	[AccessedThroughProperty("ToolStripMenuItem69")]
	private ToolStripMenuItem _ToolStripMenuItem69;

	[AccessedThroughProperty("ToolStripMenuItem70")]
	private ToolStripMenuItem _ToolStripMenuItem70;

	[AccessedThroughProperty("ToolStripMenuItem71")]
	private ToolStripMenuItem _ToolStripMenuItem71;

	[AccessedThroughProperty("ToolStripMenuItem72")]
	private ToolStripMenuItem _ToolStripMenuItem72;

	[AccessedThroughProperty("ToolStripMenuItem73")]
	private ToolStripMenuItem _ToolStripMenuItem73;

	[AccessedThroughProperty("ToolStripMenuItem74")]
	private ToolStripMenuItem _ToolStripMenuItem74;

	[AccessedThroughProperty("ToolStripMenuItem75")]
	private ToolStripMenuItem _ToolStripMenuItem75;

	[AccessedThroughProperty("ToolStripMenuItem76")]
	private ToolStripMenuItem _ToolStripMenuItem76;

	[AccessedThroughProperty("ToolStripMenuItem77")]
	private ToolStripMenuItem _ToolStripMenuItem77;

	[AccessedThroughProperty("ToolStripMenuItem78")]
	private ToolStripMenuItem _ToolStripMenuItem78;

	[AccessedThroughProperty("ToolStripMenuItem79")]
	private ToolStripMenuItem _ToolStripMenuItem79;

	[AccessedThroughProperty("ToolStripMenuItem80")]
	private ToolStripMenuItem _ToolStripMenuItem80;

	[AccessedThroughProperty("ToolStripMenuItem81")]
	private ToolStripMenuItem _ToolStripMenuItem81;

	[AccessedThroughProperty("ToolStripMenuItem82")]
	private ToolStripMenuItem _ToolStripMenuItem82;

	[AccessedThroughProperty("ToolStripMenuItem83")]
	private ToolStripMenuItem _ToolStripMenuItem83;

	[AccessedThroughProperty("ToolStripMenuItem84")]
	private ToolStripMenuItem _ToolStripMenuItem84;

	[AccessedThroughProperty("ToolStripMenuItem85")]
	private ToolStripMenuItem _ToolStripMenuItem85;

	[AccessedThroughProperty("ToolStripSeparator30")]
	private ToolStripSeparator _ToolStripSeparator30;

	[AccessedThroughProperty("ToolStripMenuItem86")]
	private ToolStripMenuItem _ToolStripMenuItem86;

	[AccessedThroughProperty("StatusStrip3")]
	private StatusStrip _StatusStrip3;

	[AccessedThroughProperty("ToolStripStatusLabel3")]
	private ToolStripStatusLabel _ToolStripStatusLabel3;

	[AccessedThroughProperty("ToolStrip3")]
	private ToolStrip _ToolStrip3;

	[AccessedThroughProperty("ToolStripButton10")]
	private ToolStripButton _ToolStripButton10;

	[AccessedThroughProperty("ToolStripButton11")]
	private ToolStripButton _ToolStripButton11;

	[AccessedThroughProperty("ToolStripButton12")]
	private ToolStripButton _ToolStripButton12;

	[AccessedThroughProperty("ToolStripSeparator32")]
	private ToolStripSeparator _ToolStripSeparator32;

	[AccessedThroughProperty("ToolStripButton9")]
	private ToolStripButton _ToolStripButton9;

	[AccessedThroughProperty("ToolStripButton8")]
	private ToolStripButton _ToolStripButton8;

	[AccessedThroughProperty("ToolStripSeparator31")]
	private ToolStripSeparator _ToolStripSeparator31;

	[AccessedThroughProperty("ToolStripButton7")]
	private ToolStripButton _ToolStripButton7;

	[AccessedThroughProperty("MenuStrip15")]
	private MenuStrip _MenuStrip15;

	[AccessedThroughProperty("ToolStripMenuItem450")]
	private ToolStripMenuItem _ToolStripMenuItem450;

	[AccessedThroughProperty("ToolStripMenuItem451")]
	private ToolStripMenuItem _ToolStripMenuItem451;

	[AccessedThroughProperty("ToolStripMenuItem452")]
	private ToolStripMenuItem _ToolStripMenuItem452;

	[AccessedThroughProperty("ToolStripSeparator121")]
	private ToolStripSeparator _ToolStripSeparator121;

	[AccessedThroughProperty("ToolStripMenuItem453")]
	private ToolStripMenuItem _ToolStripMenuItem453;

	[AccessedThroughProperty("ToolStripMenuItem454")]
	private ToolStripMenuItem _ToolStripMenuItem454;

	[AccessedThroughProperty("ToolStripSeparator122")]
	private ToolStripSeparator _ToolStripSeparator122;

	[AccessedThroughProperty("ToolStripMenuItem455")]
	private ToolStripMenuItem _ToolStripMenuItem455;

	[AccessedThroughProperty("ToolStripMenuItem456")]
	private ToolStripMenuItem _ToolStripMenuItem456;

	[AccessedThroughProperty("ToolStripMenuItem457")]
	private ToolStripMenuItem _ToolStripMenuItem457;

	[AccessedThroughProperty("ToolStripSeparator123")]
	private ToolStripSeparator _ToolStripSeparator123;

	[AccessedThroughProperty("ToolStripMenuItem458")]
	private ToolStripMenuItem _ToolStripMenuItem458;

	[AccessedThroughProperty("ToolStripMenuItem459")]
	private ToolStripMenuItem _ToolStripMenuItem459;

	[AccessedThroughProperty("ToolStripMenuItem460")]
	private ToolStripMenuItem _ToolStripMenuItem460;

	[AccessedThroughProperty("ToolStripMenuItem461")]
	private ToolStripMenuItem _ToolStripMenuItem461;

	[AccessedThroughProperty("ToolStripSeparator124")]
	private ToolStripSeparator _ToolStripSeparator124;

	[AccessedThroughProperty("ToolStripMenuItem462")]
	private ToolStripMenuItem _ToolStripMenuItem462;

	[AccessedThroughProperty("ToolStripMenuItem463")]
	private ToolStripMenuItem _ToolStripMenuItem463;

	[AccessedThroughProperty("ToolStripMenuItem464")]
	private ToolStripMenuItem _ToolStripMenuItem464;

	[AccessedThroughProperty("ToolStripSeparator125")]
	private ToolStripSeparator _ToolStripSeparator125;

	[AccessedThroughProperty("ToolStripMenuItem465")]
	private ToolStripMenuItem _ToolStripMenuItem465;

	[AccessedThroughProperty("ToolStripMenuItem466")]
	private ToolStripMenuItem _ToolStripMenuItem466;

	[AccessedThroughProperty("ToolStripMenuItem467")]
	private ToolStripMenuItem _ToolStripMenuItem467;

	[AccessedThroughProperty("ToolStripMenuItem468")]
	private ToolStripMenuItem _ToolStripMenuItem468;

	[AccessedThroughProperty("ToolStripMenuItem469")]
	private ToolStripMenuItem _ToolStripMenuItem469;

	[AccessedThroughProperty("ToolStripMenuItem470")]
	private ToolStripMenuItem _ToolStripMenuItem470;

	[AccessedThroughProperty("ToolStripMenuItem471")]
	private ToolStripMenuItem _ToolStripMenuItem471;

	[AccessedThroughProperty("ToolStripMenuItem472")]
	private ToolStripMenuItem _ToolStripMenuItem472;

	[AccessedThroughProperty("ToolStripMenuItem473")]
	private ToolStripMenuItem _ToolStripMenuItem473;

	[AccessedThroughProperty("ToolStripMenuItem474")]
	private ToolStripMenuItem _ToolStripMenuItem474;

	[AccessedThroughProperty("ToolStripMenuItem475")]
	private ToolStripMenuItem _ToolStripMenuItem475;

	[AccessedThroughProperty("ToolStripMenuItem476")]
	private ToolStripMenuItem _ToolStripMenuItem476;

	[AccessedThroughProperty("ToolStripMenuItem477")]
	private ToolStripMenuItem _ToolStripMenuItem477;

	[AccessedThroughProperty("ToolStripMenuItem478")]
	private ToolStripMenuItem _ToolStripMenuItem478;

	[AccessedThroughProperty("ToolStripMenuItem479")]
	private ToolStripMenuItem _ToolStripMenuItem479;

	[AccessedThroughProperty("ToolStripMenuItem480")]
	private ToolStripMenuItem _ToolStripMenuItem480;

	[AccessedThroughProperty("ToolStripMenuItem481")]
	private ToolStripMenuItem _ToolStripMenuItem481;

	[AccessedThroughProperty("ToolStripSeparator126")]
	private ToolStripSeparator _ToolStripSeparator126;

	[AccessedThroughProperty("ToolStripMenuItem482")]
	private ToolStripMenuItem _ToolStripMenuItem482;

	[AccessedThroughProperty("StatusStrip15")]
	private StatusStrip _StatusStrip15;

	[AccessedThroughProperty("ToolStripStatusLabel15")]
	private ToolStripStatusLabel _ToolStripStatusLabel15;

	[AccessedThroughProperty("ToolStrip15")]
	private ToolStrip _ToolStrip15;

	[AccessedThroughProperty("ToolStripButton82")]
	private ToolStripButton _ToolStripButton82;

	[AccessedThroughProperty("ToolStripButton83")]
	private ToolStripButton _ToolStripButton83;

	[AccessedThroughProperty("ToolStripButton84")]
	private ToolStripButton _ToolStripButton84;

	[AccessedThroughProperty("ToolStripSeparator128")]
	private ToolStripSeparator _ToolStripSeparator128;

	[AccessedThroughProperty("ToolStripButton81")]
	private ToolStripButton _ToolStripButton81;

	[AccessedThroughProperty("ToolStripButton80")]
	private ToolStripButton _ToolStripButton80;

	[AccessedThroughProperty("ToolStripSeparator127")]
	private ToolStripSeparator _ToolStripSeparator127;

	[AccessedThroughProperty("ToolStripButton79")]
	private ToolStripButton _ToolStripButton79;

	[AccessedThroughProperty("MenuStrip14")]
	private MenuStrip _MenuStrip14;

	[AccessedThroughProperty("ToolStripMenuItem417")]
	private ToolStripMenuItem _ToolStripMenuItem417;

	[AccessedThroughProperty("ToolStripMenuItem418")]
	private ToolStripMenuItem _ToolStripMenuItem418;

	[AccessedThroughProperty("ToolStripMenuItem419")]
	private ToolStripMenuItem _ToolStripMenuItem419;

	[AccessedThroughProperty("ToolStripSeparator113")]
	private ToolStripSeparator _ToolStripSeparator113;

	[AccessedThroughProperty("ToolStripMenuItem420")]
	private ToolStripMenuItem _ToolStripMenuItem420;

	[AccessedThroughProperty("ToolStripMenuItem421")]
	private ToolStripMenuItem _ToolStripMenuItem421;

	[AccessedThroughProperty("ToolStripSeparator114")]
	private ToolStripSeparator _ToolStripSeparator114;

	[AccessedThroughProperty("ToolStripMenuItem422")]
	private ToolStripMenuItem _ToolStripMenuItem422;

	[AccessedThroughProperty("ToolStripMenuItem423")]
	private ToolStripMenuItem _ToolStripMenuItem423;

	[AccessedThroughProperty("ToolStripMenuItem424")]
	private ToolStripMenuItem _ToolStripMenuItem424;

	[AccessedThroughProperty("ToolStripSeparator115")]
	private ToolStripSeparator _ToolStripSeparator115;

	[AccessedThroughProperty("ToolStripMenuItem425")]
	private ToolStripMenuItem _ToolStripMenuItem425;

	[AccessedThroughProperty("ToolStripMenuItem426")]
	private ToolStripMenuItem _ToolStripMenuItem426;

	[AccessedThroughProperty("ToolStripMenuItem427")]
	private ToolStripMenuItem _ToolStripMenuItem427;

	[AccessedThroughProperty("ToolStripMenuItem428")]
	private ToolStripMenuItem _ToolStripMenuItem428;

	[AccessedThroughProperty("ToolStripSeparator116")]
	private ToolStripSeparator _ToolStripSeparator116;

	[AccessedThroughProperty("ToolStripMenuItem429")]
	private ToolStripMenuItem _ToolStripMenuItem429;

	[AccessedThroughProperty("ToolStripMenuItem430")]
	private ToolStripMenuItem _ToolStripMenuItem430;

	[AccessedThroughProperty("ToolStripMenuItem431")]
	private ToolStripMenuItem _ToolStripMenuItem431;

	[AccessedThroughProperty("ToolStripSeparator117")]
	private ToolStripSeparator _ToolStripSeparator117;

	[AccessedThroughProperty("ToolStripMenuItem432")]
	private ToolStripMenuItem _ToolStripMenuItem432;

	[AccessedThroughProperty("ToolStripMenuItem433")]
	private ToolStripMenuItem _ToolStripMenuItem433;

	[AccessedThroughProperty("ToolStripMenuItem434")]
	private ToolStripMenuItem _ToolStripMenuItem434;

	[AccessedThroughProperty("ToolStripMenuItem435")]
	private ToolStripMenuItem _ToolStripMenuItem435;

	[AccessedThroughProperty("ToolStripMenuItem436")]
	private ToolStripMenuItem _ToolStripMenuItem436;

	[AccessedThroughProperty("ToolStripMenuItem437")]
	private ToolStripMenuItem _ToolStripMenuItem437;

	[AccessedThroughProperty("ToolStripMenuItem438")]
	private ToolStripMenuItem _ToolStripMenuItem438;

	[AccessedThroughProperty("ToolStripMenuItem439")]
	private ToolStripMenuItem _ToolStripMenuItem439;

	[AccessedThroughProperty("ToolStripMenuItem440")]
	private ToolStripMenuItem _ToolStripMenuItem440;

	[AccessedThroughProperty("ToolStripMenuItem441")]
	private ToolStripMenuItem _ToolStripMenuItem441;

	[AccessedThroughProperty("ToolStripMenuItem442")]
	private ToolStripMenuItem _ToolStripMenuItem442;

	[AccessedThroughProperty("ToolStripMenuItem443")]
	private ToolStripMenuItem _ToolStripMenuItem443;

	[AccessedThroughProperty("ToolStripMenuItem444")]
	private ToolStripMenuItem _ToolStripMenuItem444;

	[AccessedThroughProperty("ToolStripMenuItem445")]
	private ToolStripMenuItem _ToolStripMenuItem445;

	[AccessedThroughProperty("ToolStripMenuItem446")]
	private ToolStripMenuItem _ToolStripMenuItem446;

	[AccessedThroughProperty("ToolStripMenuItem447")]
	private ToolStripMenuItem _ToolStripMenuItem447;

	[AccessedThroughProperty("ToolStripMenuItem448")]
	private ToolStripMenuItem _ToolStripMenuItem448;

	[AccessedThroughProperty("ToolStripSeparator118")]
	private ToolStripSeparator _ToolStripSeparator118;

	[AccessedThroughProperty("ToolStripMenuItem449")]
	private ToolStripMenuItem _ToolStripMenuItem449;

	[AccessedThroughProperty("StatusStrip14")]
	private StatusStrip _StatusStrip14;

	[AccessedThroughProperty("ToolStripStatusLabel14")]
	private ToolStripStatusLabel _ToolStripStatusLabel14;

	[AccessedThroughProperty("ToolStrip14")]
	private ToolStrip _ToolStrip14;

	[AccessedThroughProperty("ToolStripButton76")]
	private ToolStripButton _ToolStripButton76;

	[AccessedThroughProperty("ToolStripButton77")]
	private ToolStripButton _ToolStripButton77;

	[AccessedThroughProperty("ToolStripButton78")]
	private ToolStripButton _ToolStripButton78;

	[AccessedThroughProperty("ToolStripSeparator120")]
	private ToolStripSeparator _ToolStripSeparator120;

	[AccessedThroughProperty("ToolStripButton75")]
	private ToolStripButton _ToolStripButton75;

	[AccessedThroughProperty("ToolStripButton74")]
	private ToolStripButton _ToolStripButton74;

	[AccessedThroughProperty("ToolStripSeparator119")]
	private ToolStripSeparator _ToolStripSeparator119;

	[AccessedThroughProperty("ToolStripButton73")]
	private ToolStripButton _ToolStripButton73;

	[AccessedThroughProperty("MenuStrip13")]
	private MenuStrip _MenuStrip13;

	[AccessedThroughProperty("ToolStripMenuItem384")]
	private ToolStripMenuItem _ToolStripMenuItem384;

	[AccessedThroughProperty("ToolStripMenuItem385")]
	private ToolStripMenuItem _ToolStripMenuItem385;

	[AccessedThroughProperty("ToolStripMenuItem386")]
	private ToolStripMenuItem _ToolStripMenuItem386;

	[AccessedThroughProperty("ToolStripSeparator105")]
	private ToolStripSeparator _ToolStripSeparator105;

	[AccessedThroughProperty("ToolStripMenuItem387")]
	private ToolStripMenuItem _ToolStripMenuItem387;

	[AccessedThroughProperty("ToolStripMenuItem388")]
	private ToolStripMenuItem _ToolStripMenuItem388;

	[AccessedThroughProperty("ToolStripSeparator106")]
	private ToolStripSeparator _ToolStripSeparator106;

	[AccessedThroughProperty("ToolStripMenuItem389")]
	private ToolStripMenuItem _ToolStripMenuItem389;

	[AccessedThroughProperty("ToolStripMenuItem390")]
	private ToolStripMenuItem _ToolStripMenuItem390;

	[AccessedThroughProperty("ToolStripMenuItem391")]
	private ToolStripMenuItem _ToolStripMenuItem391;

	[AccessedThroughProperty("ToolStripSeparator107")]
	private ToolStripSeparator _ToolStripSeparator107;

	[AccessedThroughProperty("ToolStripMenuItem392")]
	private ToolStripMenuItem _ToolStripMenuItem392;

	[AccessedThroughProperty("ToolStripMenuItem393")]
	private ToolStripMenuItem _ToolStripMenuItem393;

	[AccessedThroughProperty("ToolStripMenuItem394")]
	private ToolStripMenuItem _ToolStripMenuItem394;

	[AccessedThroughProperty("ToolStripMenuItem395")]
	private ToolStripMenuItem _ToolStripMenuItem395;

	[AccessedThroughProperty("ToolStripSeparator108")]
	private ToolStripSeparator _ToolStripSeparator108;

	[AccessedThroughProperty("ToolStripMenuItem396")]
	private ToolStripMenuItem _ToolStripMenuItem396;

	[AccessedThroughProperty("ToolStripMenuItem397")]
	private ToolStripMenuItem _ToolStripMenuItem397;

	[AccessedThroughProperty("ToolStripMenuItem398")]
	private ToolStripMenuItem _ToolStripMenuItem398;

	[AccessedThroughProperty("ToolStripSeparator109")]
	private ToolStripSeparator _ToolStripSeparator109;

	[AccessedThroughProperty("ToolStripMenuItem399")]
	private ToolStripMenuItem _ToolStripMenuItem399;

	[AccessedThroughProperty("ToolStripMenuItem400")]
	private ToolStripMenuItem _ToolStripMenuItem400;

	[AccessedThroughProperty("ToolStripMenuItem401")]
	private ToolStripMenuItem _ToolStripMenuItem401;

	[AccessedThroughProperty("ToolStripMenuItem402")]
	private ToolStripMenuItem _ToolStripMenuItem402;

	[AccessedThroughProperty("ToolStripMenuItem403")]
	private ToolStripMenuItem _ToolStripMenuItem403;

	[AccessedThroughProperty("ToolStripMenuItem404")]
	private ToolStripMenuItem _ToolStripMenuItem404;

	[AccessedThroughProperty("ToolStripMenuItem405")]
	private ToolStripMenuItem _ToolStripMenuItem405;

	[AccessedThroughProperty("ToolStripMenuItem406")]
	private ToolStripMenuItem _ToolStripMenuItem406;

	[AccessedThroughProperty("ToolStripMenuItem407")]
	private ToolStripMenuItem _ToolStripMenuItem407;

	[AccessedThroughProperty("ToolStripMenuItem408")]
	private ToolStripMenuItem _ToolStripMenuItem408;

	[AccessedThroughProperty("ToolStripMenuItem409")]
	private ToolStripMenuItem _ToolStripMenuItem409;

	[AccessedThroughProperty("ToolStripMenuItem410")]
	private ToolStripMenuItem _ToolStripMenuItem410;

	[AccessedThroughProperty("ToolStripMenuItem411")]
	private ToolStripMenuItem _ToolStripMenuItem411;

	[AccessedThroughProperty("ToolStripMenuItem412")]
	private ToolStripMenuItem _ToolStripMenuItem412;

	[AccessedThroughProperty("ToolStripMenuItem413")]
	private ToolStripMenuItem _ToolStripMenuItem413;

	[AccessedThroughProperty("ToolStripMenuItem414")]
	private ToolStripMenuItem _ToolStripMenuItem414;

	[AccessedThroughProperty("ToolStripMenuItem415")]
	private ToolStripMenuItem _ToolStripMenuItem415;

	[AccessedThroughProperty("ToolStripSeparator110")]
	private ToolStripSeparator _ToolStripSeparator110;

	[AccessedThroughProperty("ToolStripMenuItem416")]
	private ToolStripMenuItem _ToolStripMenuItem416;

	[AccessedThroughProperty("StatusStrip13")]
	private StatusStrip _StatusStrip13;

	[AccessedThroughProperty("ToolStripStatusLabel13")]
	private ToolStripStatusLabel _ToolStripStatusLabel13;

	[AccessedThroughProperty("ToolStrip13")]
	private ToolStrip _ToolStrip13;

	[AccessedThroughProperty("ToolStripButton70")]
	private ToolStripButton _ToolStripButton70;

	[AccessedThroughProperty("ToolStripButton71")]
	private ToolStripButton _ToolStripButton71;

	[AccessedThroughProperty("ToolStripButton72")]
	private ToolStripButton _ToolStripButton72;

	[AccessedThroughProperty("ToolStripSeparator112")]
	private ToolStripSeparator _ToolStripSeparator112;

	[AccessedThroughProperty("ToolStripButton69")]
	private ToolStripButton _ToolStripButton69;

	[AccessedThroughProperty("ToolStripButton68")]
	private ToolStripButton _ToolStripButton68;

	[AccessedThroughProperty("ToolStripSeparator111")]
	private ToolStripSeparator _ToolStripSeparator111;

	[AccessedThroughProperty("ToolStripButton67")]
	private ToolStripButton _ToolStripButton67;

	[AccessedThroughProperty("MenuStrip12")]
	private MenuStrip _MenuStrip12;

	[AccessedThroughProperty("ToolStripMenuItem351")]
	private ToolStripMenuItem _ToolStripMenuItem351;

	[AccessedThroughProperty("ToolStripMenuItem352")]
	private ToolStripMenuItem _ToolStripMenuItem352;

	[AccessedThroughProperty("ToolStripMenuItem353")]
	private ToolStripMenuItem _ToolStripMenuItem353;

	[AccessedThroughProperty("ToolStripSeparator97")]
	private ToolStripSeparator _ToolStripSeparator97;

	[AccessedThroughProperty("ToolStripMenuItem354")]
	private ToolStripMenuItem _ToolStripMenuItem354;

	[AccessedThroughProperty("ToolStripMenuItem355")]
	private ToolStripMenuItem _ToolStripMenuItem355;

	[AccessedThroughProperty("ToolStripSeparator98")]
	private ToolStripSeparator _ToolStripSeparator98;

	[AccessedThroughProperty("ToolStripMenuItem356")]
	private ToolStripMenuItem _ToolStripMenuItem356;

	[AccessedThroughProperty("ToolStripMenuItem357")]
	private ToolStripMenuItem _ToolStripMenuItem357;

	[AccessedThroughProperty("ToolStripMenuItem358")]
	private ToolStripMenuItem _ToolStripMenuItem358;

	[AccessedThroughProperty("ToolStripSeparator99")]
	private ToolStripSeparator _ToolStripSeparator99;

	[AccessedThroughProperty("ToolStripMenuItem359")]
	private ToolStripMenuItem _ToolStripMenuItem359;

	[AccessedThroughProperty("ToolStripMenuItem360")]
	private ToolStripMenuItem _ToolStripMenuItem360;

	[AccessedThroughProperty("ToolStripMenuItem361")]
	private ToolStripMenuItem _ToolStripMenuItem361;

	[AccessedThroughProperty("ToolStripMenuItem362")]
	private ToolStripMenuItem _ToolStripMenuItem362;

	[AccessedThroughProperty("ToolStripSeparator100")]
	private ToolStripSeparator _ToolStripSeparator100;

	[AccessedThroughProperty("ToolStripMenuItem363")]
	private ToolStripMenuItem _ToolStripMenuItem363;

	[AccessedThroughProperty("ToolStripMenuItem364")]
	private ToolStripMenuItem _ToolStripMenuItem364;

	[AccessedThroughProperty("ToolStripMenuItem365")]
	private ToolStripMenuItem _ToolStripMenuItem365;

	[AccessedThroughProperty("ToolStripSeparator101")]
	private ToolStripSeparator _ToolStripSeparator101;

	[AccessedThroughProperty("ToolStripMenuItem366")]
	private ToolStripMenuItem _ToolStripMenuItem366;

	[AccessedThroughProperty("ToolStripMenuItem367")]
	private ToolStripMenuItem _ToolStripMenuItem367;

	[AccessedThroughProperty("ToolStripMenuItem368")]
	private ToolStripMenuItem _ToolStripMenuItem368;

	[AccessedThroughProperty("ToolStripMenuItem369")]
	private ToolStripMenuItem _ToolStripMenuItem369;

	[AccessedThroughProperty("ToolStripMenuItem370")]
	private ToolStripMenuItem _ToolStripMenuItem370;

	[AccessedThroughProperty("ToolStripMenuItem371")]
	private ToolStripMenuItem _ToolStripMenuItem371;

	[AccessedThroughProperty("ToolStripMenuItem372")]
	private ToolStripMenuItem _ToolStripMenuItem372;

	[AccessedThroughProperty("ToolStripMenuItem373")]
	private ToolStripMenuItem _ToolStripMenuItem373;

	[AccessedThroughProperty("ToolStripMenuItem374")]
	private ToolStripMenuItem _ToolStripMenuItem374;

	[AccessedThroughProperty("ToolStripMenuItem375")]
	private ToolStripMenuItem _ToolStripMenuItem375;

	[AccessedThroughProperty("ToolStripMenuItem376")]
	private ToolStripMenuItem _ToolStripMenuItem376;

	[AccessedThroughProperty("ToolStripMenuItem377")]
	private ToolStripMenuItem _ToolStripMenuItem377;

	[AccessedThroughProperty("ToolStripMenuItem378")]
	private ToolStripMenuItem _ToolStripMenuItem378;

	[AccessedThroughProperty("ToolStripMenuItem379")]
	private ToolStripMenuItem _ToolStripMenuItem379;

	[AccessedThroughProperty("ToolStripMenuItem380")]
	private ToolStripMenuItem _ToolStripMenuItem380;

	[AccessedThroughProperty("ToolStripMenuItem381")]
	private ToolStripMenuItem _ToolStripMenuItem381;

	[AccessedThroughProperty("ToolStripMenuItem382")]
	private ToolStripMenuItem _ToolStripMenuItem382;

	[AccessedThroughProperty("ToolStripSeparator102")]
	private ToolStripSeparator _ToolStripSeparator102;

	[AccessedThroughProperty("ToolStripMenuItem383")]
	private ToolStripMenuItem _ToolStripMenuItem383;

	[AccessedThroughProperty("StatusStrip12")]
	private StatusStrip _StatusStrip12;

	[AccessedThroughProperty("ToolStripStatusLabel12")]
	private ToolStripStatusLabel _ToolStripStatusLabel12;

	[AccessedThroughProperty("ToolStrip12")]
	private ToolStrip _ToolStrip12;

	[AccessedThroughProperty("ToolStripButton64")]
	private ToolStripButton _ToolStripButton64;

	[AccessedThroughProperty("ToolStripButton65")]
	private ToolStripButton _ToolStripButton65;

	[AccessedThroughProperty("ToolStripButton66")]
	private ToolStripButton _ToolStripButton66;

	[AccessedThroughProperty("ToolStripSeparator104")]
	private ToolStripSeparator _ToolStripSeparator104;

	[AccessedThroughProperty("ToolStripButton63")]
	private ToolStripButton _ToolStripButton63;

	[AccessedThroughProperty("ToolStripButton62")]
	private ToolStripButton _ToolStripButton62;

	[AccessedThroughProperty("ToolStripSeparator103")]
	private ToolStripSeparator _ToolStripSeparator103;

	[AccessedThroughProperty("ToolStripButton61")]
	private ToolStripButton _ToolStripButton61;

	[AccessedThroughProperty("MenuStrip11")]
	private MenuStrip _MenuStrip11;

	[AccessedThroughProperty("ToolStripMenuItem318")]
	private ToolStripMenuItem _ToolStripMenuItem318;

	[AccessedThroughProperty("ToolStripMenuItem319")]
	private ToolStripMenuItem _ToolStripMenuItem319;

	[AccessedThroughProperty("ToolStripMenuItem320")]
	private ToolStripMenuItem _ToolStripMenuItem320;

	[AccessedThroughProperty("ToolStripSeparator89")]
	private ToolStripSeparator _ToolStripSeparator89;

	[AccessedThroughProperty("ToolStripMenuItem321")]
	private ToolStripMenuItem _ToolStripMenuItem321;

	[AccessedThroughProperty("ToolStripMenuItem322")]
	private ToolStripMenuItem _ToolStripMenuItem322;

	[AccessedThroughProperty("ToolStripSeparator90")]
	private ToolStripSeparator _ToolStripSeparator90;

	[AccessedThroughProperty("ToolStripMenuItem323")]
	private ToolStripMenuItem _ToolStripMenuItem323;

	[AccessedThroughProperty("ToolStripMenuItem324")]
	private ToolStripMenuItem _ToolStripMenuItem324;

	[AccessedThroughProperty("ToolStripMenuItem325")]
	private ToolStripMenuItem _ToolStripMenuItem325;

	[AccessedThroughProperty("ToolStripSeparator91")]
	private ToolStripSeparator _ToolStripSeparator91;

	[AccessedThroughProperty("ToolStripMenuItem326")]
	private ToolStripMenuItem _ToolStripMenuItem326;

	[AccessedThroughProperty("ToolStripMenuItem327")]
	private ToolStripMenuItem _ToolStripMenuItem327;

	[AccessedThroughProperty("ToolStripMenuItem328")]
	private ToolStripMenuItem _ToolStripMenuItem328;

	[AccessedThroughProperty("ToolStripMenuItem329")]
	private ToolStripMenuItem _ToolStripMenuItem329;

	[AccessedThroughProperty("ToolStripSeparator92")]
	private ToolStripSeparator _ToolStripSeparator92;

	[AccessedThroughProperty("ToolStripMenuItem330")]
	private ToolStripMenuItem _ToolStripMenuItem330;

	[AccessedThroughProperty("ToolStripMenuItem331")]
	private ToolStripMenuItem _ToolStripMenuItem331;

	[AccessedThroughProperty("ToolStripMenuItem332")]
	private ToolStripMenuItem _ToolStripMenuItem332;

	[AccessedThroughProperty("ToolStripSeparator93")]
	private ToolStripSeparator _ToolStripSeparator93;

	[AccessedThroughProperty("ToolStripMenuItem333")]
	private ToolStripMenuItem _ToolStripMenuItem333;

	[AccessedThroughProperty("ToolStripMenuItem334")]
	private ToolStripMenuItem _ToolStripMenuItem334;

	[AccessedThroughProperty("ToolStripMenuItem335")]
	private ToolStripMenuItem _ToolStripMenuItem335;

	[AccessedThroughProperty("ToolStripMenuItem336")]
	private ToolStripMenuItem _ToolStripMenuItem336;

	[AccessedThroughProperty("ToolStripMenuItem337")]
	private ToolStripMenuItem _ToolStripMenuItem337;

	[AccessedThroughProperty("ToolStripMenuItem338")]
	private ToolStripMenuItem _ToolStripMenuItem338;

	[AccessedThroughProperty("ToolStripMenuItem339")]
	private ToolStripMenuItem _ToolStripMenuItem339;

	[AccessedThroughProperty("ToolStripMenuItem340")]
	private ToolStripMenuItem _ToolStripMenuItem340;

	[AccessedThroughProperty("ToolStripMenuItem341")]
	private ToolStripMenuItem _ToolStripMenuItem341;

	[AccessedThroughProperty("ToolStripMenuItem342")]
	private ToolStripMenuItem _ToolStripMenuItem342;

	[AccessedThroughProperty("ToolStripMenuItem343")]
	private ToolStripMenuItem _ToolStripMenuItem343;

	[AccessedThroughProperty("ToolStripMenuItem344")]
	private ToolStripMenuItem _ToolStripMenuItem344;

	[AccessedThroughProperty("ToolStripMenuItem345")]
	private ToolStripMenuItem _ToolStripMenuItem345;

	[AccessedThroughProperty("ToolStripMenuItem346")]
	private ToolStripMenuItem _ToolStripMenuItem346;

	[AccessedThroughProperty("ToolStripMenuItem347")]
	private ToolStripMenuItem _ToolStripMenuItem347;

	[AccessedThroughProperty("ToolStripMenuItem348")]
	private ToolStripMenuItem _ToolStripMenuItem348;

	[AccessedThroughProperty("ToolStripMenuItem349")]
	private ToolStripMenuItem _ToolStripMenuItem349;

	[AccessedThroughProperty("ToolStripSeparator94")]
	private ToolStripSeparator _ToolStripSeparator94;

	[AccessedThroughProperty("ToolStripMenuItem350")]
	private ToolStripMenuItem _ToolStripMenuItem350;

	[AccessedThroughProperty("StatusStrip11")]
	private StatusStrip _StatusStrip11;

	[AccessedThroughProperty("ToolStripStatusLabel11")]
	private ToolStripStatusLabel _ToolStripStatusLabel11;

	[AccessedThroughProperty("ToolStrip11")]
	private ToolStrip _ToolStrip11;

	[AccessedThroughProperty("ToolStripButton58")]
	private ToolStripButton _ToolStripButton58;

	[AccessedThroughProperty("ToolStripButton59")]
	private ToolStripButton _ToolStripButton59;

	[AccessedThroughProperty("ToolStripButton60")]
	private ToolStripButton _ToolStripButton60;

	[AccessedThroughProperty("ToolStripSeparator96")]
	private ToolStripSeparator _ToolStripSeparator96;

	[AccessedThroughProperty("ToolStripButton57")]
	private ToolStripButton _ToolStripButton57;

	[AccessedThroughProperty("ToolStripButton56")]
	private ToolStripButton _ToolStripButton56;

	[AccessedThroughProperty("ToolStripSeparator95")]
	private ToolStripSeparator _ToolStripSeparator95;

	[AccessedThroughProperty("ToolStripButton55")]
	private ToolStripButton _ToolStripButton55;

	[AccessedThroughProperty("MenuStrip10")]
	private MenuStrip _MenuStrip10;

	[AccessedThroughProperty("ToolStripMenuItem285")]
	private ToolStripMenuItem _ToolStripMenuItem285;

	[AccessedThroughProperty("ToolStripMenuItem286")]
	private ToolStripMenuItem _ToolStripMenuItem286;

	[AccessedThroughProperty("ToolStripMenuItem287")]
	private ToolStripMenuItem _ToolStripMenuItem287;

	[AccessedThroughProperty("ToolStripSeparator81")]
	private ToolStripSeparator _ToolStripSeparator81;

	[AccessedThroughProperty("ToolStripMenuItem288")]
	private ToolStripMenuItem _ToolStripMenuItem288;

	[AccessedThroughProperty("ToolStripMenuItem289")]
	private ToolStripMenuItem _ToolStripMenuItem289;

	[AccessedThroughProperty("ToolStripSeparator82")]
	private ToolStripSeparator _ToolStripSeparator82;

	[AccessedThroughProperty("ToolStripMenuItem290")]
	private ToolStripMenuItem _ToolStripMenuItem290;

	[AccessedThroughProperty("ToolStripMenuItem291")]
	private ToolStripMenuItem _ToolStripMenuItem291;

	[AccessedThroughProperty("ToolStripMenuItem292")]
	private ToolStripMenuItem _ToolStripMenuItem292;

	[AccessedThroughProperty("ToolStripSeparator83")]
	private ToolStripSeparator _ToolStripSeparator83;

	[AccessedThroughProperty("ToolStripMenuItem293")]
	private ToolStripMenuItem _ToolStripMenuItem293;

	[AccessedThroughProperty("ToolStripMenuItem294")]
	private ToolStripMenuItem _ToolStripMenuItem294;

	[AccessedThroughProperty("ToolStripMenuItem295")]
	private ToolStripMenuItem _ToolStripMenuItem295;

	[AccessedThroughProperty("ToolStripMenuItem296")]
	private ToolStripMenuItem _ToolStripMenuItem296;

	[AccessedThroughProperty("ToolStripSeparator84")]
	private ToolStripSeparator _ToolStripSeparator84;

	[AccessedThroughProperty("ToolStripMenuItem297")]
	private ToolStripMenuItem _ToolStripMenuItem297;

	[AccessedThroughProperty("ToolStripMenuItem298")]
	private ToolStripMenuItem _ToolStripMenuItem298;

	[AccessedThroughProperty("ToolStripMenuItem299")]
	private ToolStripMenuItem _ToolStripMenuItem299;

	[AccessedThroughProperty("ToolStripSeparator85")]
	private ToolStripSeparator _ToolStripSeparator85;

	[AccessedThroughProperty("ToolStripMenuItem300")]
	private ToolStripMenuItem _ToolStripMenuItem300;

	[AccessedThroughProperty("ToolStripMenuItem301")]
	private ToolStripMenuItem _ToolStripMenuItem301;

	[AccessedThroughProperty("ToolStripMenuItem302")]
	private ToolStripMenuItem _ToolStripMenuItem302;

	[AccessedThroughProperty("ToolStripMenuItem303")]
	private ToolStripMenuItem _ToolStripMenuItem303;

	[AccessedThroughProperty("ToolStripMenuItem304")]
	private ToolStripMenuItem _ToolStripMenuItem304;

	[AccessedThroughProperty("ToolStripMenuItem305")]
	private ToolStripMenuItem _ToolStripMenuItem305;

	[AccessedThroughProperty("ToolStripMenuItem306")]
	private ToolStripMenuItem _ToolStripMenuItem306;

	[AccessedThroughProperty("ToolStripMenuItem307")]
	private ToolStripMenuItem _ToolStripMenuItem307;

	[AccessedThroughProperty("ToolStripMenuItem308")]
	private ToolStripMenuItem _ToolStripMenuItem308;

	[AccessedThroughProperty("ToolStripMenuItem309")]
	private ToolStripMenuItem _ToolStripMenuItem309;

	[AccessedThroughProperty("ToolStripMenuItem310")]
	private ToolStripMenuItem _ToolStripMenuItem310;

	[AccessedThroughProperty("ToolStripMenuItem311")]
	private ToolStripMenuItem _ToolStripMenuItem311;

	[AccessedThroughProperty("ToolStripMenuItem312")]
	private ToolStripMenuItem _ToolStripMenuItem312;

	[AccessedThroughProperty("ToolStripMenuItem313")]
	private ToolStripMenuItem _ToolStripMenuItem313;

	[AccessedThroughProperty("ToolStripMenuItem314")]
	private ToolStripMenuItem _ToolStripMenuItem314;

	[AccessedThroughProperty("ToolStripMenuItem315")]
	private ToolStripMenuItem _ToolStripMenuItem315;

	[AccessedThroughProperty("ToolStripMenuItem316")]
	private ToolStripMenuItem _ToolStripMenuItem316;

	[AccessedThroughProperty("ToolStripSeparator86")]
	private ToolStripSeparator _ToolStripSeparator86;

	[AccessedThroughProperty("ToolStripMenuItem317")]
	private ToolStripMenuItem _ToolStripMenuItem317;

	[AccessedThroughProperty("StatusStrip10")]
	private StatusStrip _StatusStrip10;

	[AccessedThroughProperty("ToolStripStatusLabel10")]
	private ToolStripStatusLabel _ToolStripStatusLabel10;

	[AccessedThroughProperty("ToolStrip10")]
	private ToolStrip _ToolStrip10;

	[AccessedThroughProperty("ToolStripButton52")]
	private ToolStripButton _ToolStripButton52;

	[AccessedThroughProperty("ToolStripButton53")]
	private ToolStripButton _ToolStripButton53;

	[AccessedThroughProperty("ToolStripButton54")]
	private ToolStripButton _ToolStripButton54;

	[AccessedThroughProperty("ToolStripSeparator88")]
	private ToolStripSeparator _ToolStripSeparator88;

	[AccessedThroughProperty("ToolStripButton51")]
	private ToolStripButton _ToolStripButton51;

	[AccessedThroughProperty("ToolStripButton50")]
	private ToolStripButton _ToolStripButton50;

	[AccessedThroughProperty("ToolStripSeparator87")]
	private ToolStripSeparator _ToolStripSeparator87;

	[AccessedThroughProperty("ToolStripButton49")]
	private ToolStripButton _ToolStripButton49;

	[AccessedThroughProperty("MenuStrip9")]
	private MenuStrip _MenuStrip9;

	[AccessedThroughProperty("ToolStripMenuItem252")]
	private ToolStripMenuItem _ToolStripMenuItem252;

	[AccessedThroughProperty("ToolStripMenuItem253")]
	private ToolStripMenuItem _ToolStripMenuItem253;

	[AccessedThroughProperty("ToolStripMenuItem254")]
	private ToolStripMenuItem _ToolStripMenuItem254;

	[AccessedThroughProperty("ToolStripSeparator73")]
	private ToolStripSeparator _ToolStripSeparator73;

	[AccessedThroughProperty("ToolStripMenuItem255")]
	private ToolStripMenuItem _ToolStripMenuItem255;

	[AccessedThroughProperty("ToolStripMenuItem256")]
	private ToolStripMenuItem _ToolStripMenuItem256;

	[AccessedThroughProperty("ToolStripSeparator74")]
	private ToolStripSeparator _ToolStripSeparator74;

	[AccessedThroughProperty("ToolStripMenuItem257")]
	private ToolStripMenuItem _ToolStripMenuItem257;

	[AccessedThroughProperty("ToolStripMenuItem258")]
	private ToolStripMenuItem _ToolStripMenuItem258;

	[AccessedThroughProperty("ToolStripMenuItem259")]
	private ToolStripMenuItem _ToolStripMenuItem259;

	[AccessedThroughProperty("ToolStripSeparator75")]
	private ToolStripSeparator _ToolStripSeparator75;

	[AccessedThroughProperty("ToolStripMenuItem260")]
	private ToolStripMenuItem _ToolStripMenuItem260;

	[AccessedThroughProperty("ToolStripMenuItem261")]
	private ToolStripMenuItem _ToolStripMenuItem261;

	[AccessedThroughProperty("ToolStripMenuItem262")]
	private ToolStripMenuItem _ToolStripMenuItem262;

	[AccessedThroughProperty("ToolStripMenuItem263")]
	private ToolStripMenuItem _ToolStripMenuItem263;

	[AccessedThroughProperty("ToolStripSeparator76")]
	private ToolStripSeparator _ToolStripSeparator76;

	[AccessedThroughProperty("ToolStripMenuItem264")]
	private ToolStripMenuItem _ToolStripMenuItem264;

	[AccessedThroughProperty("ToolStripMenuItem265")]
	private ToolStripMenuItem _ToolStripMenuItem265;

	[AccessedThroughProperty("ToolStripMenuItem266")]
	private ToolStripMenuItem _ToolStripMenuItem266;

	[AccessedThroughProperty("ToolStripSeparator77")]
	private ToolStripSeparator _ToolStripSeparator77;

	[AccessedThroughProperty("ToolStripMenuItem267")]
	private ToolStripMenuItem _ToolStripMenuItem267;

	[AccessedThroughProperty("ToolStripMenuItem268")]
	private ToolStripMenuItem _ToolStripMenuItem268;

	[AccessedThroughProperty("ToolStripMenuItem269")]
	private ToolStripMenuItem _ToolStripMenuItem269;

	[AccessedThroughProperty("ToolStripMenuItem270")]
	private ToolStripMenuItem _ToolStripMenuItem270;

	[AccessedThroughProperty("ToolStripMenuItem271")]
	private ToolStripMenuItem _ToolStripMenuItem271;

	[AccessedThroughProperty("ToolStripMenuItem272")]
	private ToolStripMenuItem _ToolStripMenuItem272;

	[AccessedThroughProperty("ToolStripMenuItem273")]
	private ToolStripMenuItem _ToolStripMenuItem273;

	[AccessedThroughProperty("ToolStripMenuItem274")]
	private ToolStripMenuItem _ToolStripMenuItem274;

	[AccessedThroughProperty("ToolStripMenuItem275")]
	private ToolStripMenuItem _ToolStripMenuItem275;

	[AccessedThroughProperty("ToolStripMenuItem276")]
	private ToolStripMenuItem _ToolStripMenuItem276;

	[AccessedThroughProperty("ToolStripMenuItem277")]
	private ToolStripMenuItem _ToolStripMenuItem277;

	[AccessedThroughProperty("ToolStripMenuItem278")]
	private ToolStripMenuItem _ToolStripMenuItem278;

	[AccessedThroughProperty("ToolStripMenuItem279")]
	private ToolStripMenuItem _ToolStripMenuItem279;

	[AccessedThroughProperty("ToolStripMenuItem280")]
	private ToolStripMenuItem _ToolStripMenuItem280;

	[AccessedThroughProperty("ToolStripMenuItem281")]
	private ToolStripMenuItem _ToolStripMenuItem281;

	[AccessedThroughProperty("ToolStripMenuItem282")]
	private ToolStripMenuItem _ToolStripMenuItem282;

	[AccessedThroughProperty("ToolStripMenuItem283")]
	private ToolStripMenuItem _ToolStripMenuItem283;

	[AccessedThroughProperty("ToolStripSeparator78")]
	private ToolStripSeparator _ToolStripSeparator78;

	[AccessedThroughProperty("ToolStripMenuItem284")]
	private ToolStripMenuItem _ToolStripMenuItem284;

	[AccessedThroughProperty("StatusStrip9")]
	private StatusStrip _StatusStrip9;

	[AccessedThroughProperty("ToolStripStatusLabel9")]
	private ToolStripStatusLabel _ToolStripStatusLabel9;

	[AccessedThroughProperty("ToolStrip9")]
	private ToolStrip _ToolStrip9;

	[AccessedThroughProperty("ToolStripButton46")]
	private ToolStripButton _ToolStripButton46;

	[AccessedThroughProperty("ToolStripButton47")]
	private ToolStripButton _ToolStripButton47;

	[AccessedThroughProperty("ToolStripButton48")]
	private ToolStripButton _ToolStripButton48;

	[AccessedThroughProperty("ToolStripSeparator80")]
	private ToolStripSeparator _ToolStripSeparator80;

	[AccessedThroughProperty("ToolStripButton45")]
	private ToolStripButton _ToolStripButton45;

	[AccessedThroughProperty("ToolStripButton44")]
	private ToolStripButton _ToolStripButton44;

	[AccessedThroughProperty("ToolStripSeparator79")]
	private ToolStripSeparator _ToolStripSeparator79;

	[AccessedThroughProperty("ToolStripButton43")]
	private ToolStripButton _ToolStripButton43;

	[AccessedThroughProperty("MenuStrip8")]
	private MenuStrip _MenuStrip8;

	[AccessedThroughProperty("ToolStripMenuItem219")]
	private ToolStripMenuItem _ToolStripMenuItem219;

	[AccessedThroughProperty("ToolStripMenuItem220")]
	private ToolStripMenuItem _ToolStripMenuItem220;

	[AccessedThroughProperty("ToolStripMenuItem221")]
	private ToolStripMenuItem _ToolStripMenuItem221;

	[AccessedThroughProperty("ToolStripSeparator65")]
	private ToolStripSeparator _ToolStripSeparator65;

	[AccessedThroughProperty("ToolStripMenuItem222")]
	private ToolStripMenuItem _ToolStripMenuItem222;

	[AccessedThroughProperty("ToolStripMenuItem223")]
	private ToolStripMenuItem _ToolStripMenuItem223;

	[AccessedThroughProperty("ToolStripSeparator66")]
	private ToolStripSeparator _ToolStripSeparator66;

	[AccessedThroughProperty("ToolStripMenuItem224")]
	private ToolStripMenuItem _ToolStripMenuItem224;

	[AccessedThroughProperty("ToolStripMenuItem225")]
	private ToolStripMenuItem _ToolStripMenuItem225;

	[AccessedThroughProperty("ToolStripMenuItem226")]
	private ToolStripMenuItem _ToolStripMenuItem226;

	[AccessedThroughProperty("ToolStripSeparator67")]
	private ToolStripSeparator _ToolStripSeparator67;

	[AccessedThroughProperty("ToolStripMenuItem227")]
	private ToolStripMenuItem _ToolStripMenuItem227;

	[AccessedThroughProperty("ToolStripMenuItem228")]
	private ToolStripMenuItem _ToolStripMenuItem228;

	[AccessedThroughProperty("ToolStripMenuItem229")]
	private ToolStripMenuItem _ToolStripMenuItem229;

	[AccessedThroughProperty("ToolStripMenuItem230")]
	private ToolStripMenuItem _ToolStripMenuItem230;

	[AccessedThroughProperty("ToolStripSeparator68")]
	private ToolStripSeparator _ToolStripSeparator68;

	[AccessedThroughProperty("ToolStripMenuItem231")]
	private ToolStripMenuItem _ToolStripMenuItem231;

	[AccessedThroughProperty("ToolStripMenuItem232")]
	private ToolStripMenuItem _ToolStripMenuItem232;

	[AccessedThroughProperty("ToolStripMenuItem233")]
	private ToolStripMenuItem _ToolStripMenuItem233;

	[AccessedThroughProperty("ToolStripSeparator69")]
	private ToolStripSeparator _ToolStripSeparator69;

	[AccessedThroughProperty("ToolStripMenuItem234")]
	private ToolStripMenuItem _ToolStripMenuItem234;

	[AccessedThroughProperty("ToolStripMenuItem235")]
	private ToolStripMenuItem _ToolStripMenuItem235;

	[AccessedThroughProperty("ToolStripMenuItem236")]
	private ToolStripMenuItem _ToolStripMenuItem236;

	[AccessedThroughProperty("ToolStripMenuItem237")]
	private ToolStripMenuItem _ToolStripMenuItem237;

	[AccessedThroughProperty("ToolStripMenuItem238")]
	private ToolStripMenuItem _ToolStripMenuItem238;

	[AccessedThroughProperty("ToolStripMenuItem239")]
	private ToolStripMenuItem _ToolStripMenuItem239;

	[AccessedThroughProperty("ToolStripMenuItem240")]
	private ToolStripMenuItem _ToolStripMenuItem240;

	[AccessedThroughProperty("ToolStripMenuItem241")]
	private ToolStripMenuItem _ToolStripMenuItem241;

	[AccessedThroughProperty("ToolStripMenuItem242")]
	private ToolStripMenuItem _ToolStripMenuItem242;

	[AccessedThroughProperty("ToolStripMenuItem243")]
	private ToolStripMenuItem _ToolStripMenuItem243;

	[AccessedThroughProperty("ToolStripMenuItem244")]
	private ToolStripMenuItem _ToolStripMenuItem244;

	[AccessedThroughProperty("ToolStripMenuItem245")]
	private ToolStripMenuItem _ToolStripMenuItem245;

	[AccessedThroughProperty("ToolStripMenuItem246")]
	private ToolStripMenuItem _ToolStripMenuItem246;

	[AccessedThroughProperty("ToolStripMenuItem247")]
	private ToolStripMenuItem _ToolStripMenuItem247;

	[AccessedThroughProperty("ToolStripMenuItem248")]
	private ToolStripMenuItem _ToolStripMenuItem248;

	[AccessedThroughProperty("ToolStripMenuItem249")]
	private ToolStripMenuItem _ToolStripMenuItem249;

	[AccessedThroughProperty("ToolStripMenuItem250")]
	private ToolStripMenuItem _ToolStripMenuItem250;

	[AccessedThroughProperty("ToolStripSeparator70")]
	private ToolStripSeparator _ToolStripSeparator70;

	[AccessedThroughProperty("ToolStripMenuItem251")]
	private ToolStripMenuItem _ToolStripMenuItem251;

	[AccessedThroughProperty("StatusStrip8")]
	private StatusStrip _StatusStrip8;

	[AccessedThroughProperty("ToolStripStatusLabel8")]
	private ToolStripStatusLabel _ToolStripStatusLabel8;

	[AccessedThroughProperty("ToolStrip8")]
	private ToolStrip _ToolStrip8;

	[AccessedThroughProperty("ToolStripButton40")]
	private ToolStripButton _ToolStripButton40;

	[AccessedThroughProperty("ToolStripButton41")]
	private ToolStripButton _ToolStripButton41;

	[AccessedThroughProperty("ToolStripButton42")]
	private ToolStripButton _ToolStripButton42;

	[AccessedThroughProperty("ToolStripSeparator72")]
	private ToolStripSeparator _ToolStripSeparator72;

	[AccessedThroughProperty("ToolStripButton39")]
	private ToolStripButton _ToolStripButton39;

	[AccessedThroughProperty("ToolStripButton38")]
	private ToolStripButton _ToolStripButton38;

	[AccessedThroughProperty("ToolStripSeparator71")]
	private ToolStripSeparator _ToolStripSeparator71;

	[AccessedThroughProperty("ToolStripButton37")]
	private ToolStripButton _ToolStripButton37;

	[AccessedThroughProperty("MenuStrip7")]
	private MenuStrip _MenuStrip7;

	[AccessedThroughProperty("ToolStripMenuItem186")]
	private ToolStripMenuItem _ToolStripMenuItem186;

	[AccessedThroughProperty("ToolStripMenuItem187")]
	private ToolStripMenuItem _ToolStripMenuItem187;

	[AccessedThroughProperty("ToolStripMenuItem188")]
	private ToolStripMenuItem _ToolStripMenuItem188;

	[AccessedThroughProperty("ToolStripSeparator57")]
	private ToolStripSeparator _ToolStripSeparator57;

	[AccessedThroughProperty("ToolStripMenuItem189")]
	private ToolStripMenuItem _ToolStripMenuItem189;

	[AccessedThroughProperty("ToolStripMenuItem190")]
	private ToolStripMenuItem _ToolStripMenuItem190;

	[AccessedThroughProperty("ToolStripSeparator58")]
	private ToolStripSeparator _ToolStripSeparator58;

	[AccessedThroughProperty("ToolStripMenuItem191")]
	private ToolStripMenuItem _ToolStripMenuItem191;

	[AccessedThroughProperty("ToolStripMenuItem192")]
	private ToolStripMenuItem _ToolStripMenuItem192;

	[AccessedThroughProperty("ToolStripMenuItem193")]
	private ToolStripMenuItem _ToolStripMenuItem193;

	[AccessedThroughProperty("ToolStripSeparator59")]
	private ToolStripSeparator _ToolStripSeparator59;

	[AccessedThroughProperty("ToolStripMenuItem194")]
	private ToolStripMenuItem _ToolStripMenuItem194;

	[AccessedThroughProperty("ToolStripMenuItem195")]
	private ToolStripMenuItem _ToolStripMenuItem195;

	[AccessedThroughProperty("ToolStripMenuItem196")]
	private ToolStripMenuItem _ToolStripMenuItem196;

	[AccessedThroughProperty("ToolStripMenuItem197")]
	private ToolStripMenuItem _ToolStripMenuItem197;

	[AccessedThroughProperty("ToolStripSeparator60")]
	private ToolStripSeparator _ToolStripSeparator60;

	[AccessedThroughProperty("ToolStripMenuItem198")]
	private ToolStripMenuItem _ToolStripMenuItem198;

	[AccessedThroughProperty("ToolStripMenuItem199")]
	private ToolStripMenuItem _ToolStripMenuItem199;

	[AccessedThroughProperty("ToolStripMenuItem200")]
	private ToolStripMenuItem _ToolStripMenuItem200;

	[AccessedThroughProperty("ToolStripSeparator61")]
	private ToolStripSeparator _ToolStripSeparator61;

	[AccessedThroughProperty("ToolStripMenuItem201")]
	private ToolStripMenuItem _ToolStripMenuItem201;

	[AccessedThroughProperty("ToolStripMenuItem202")]
	private ToolStripMenuItem _ToolStripMenuItem202;

	[AccessedThroughProperty("ToolStripMenuItem203")]
	private ToolStripMenuItem _ToolStripMenuItem203;

	[AccessedThroughProperty("ToolStripMenuItem204")]
	private ToolStripMenuItem _ToolStripMenuItem204;

	[AccessedThroughProperty("ToolStripMenuItem205")]
	private ToolStripMenuItem _ToolStripMenuItem205;

	[AccessedThroughProperty("ToolStripMenuItem206")]
	private ToolStripMenuItem _ToolStripMenuItem206;

	[AccessedThroughProperty("ToolStripMenuItem207")]
	private ToolStripMenuItem _ToolStripMenuItem207;

	[AccessedThroughProperty("ToolStripMenuItem208")]
	private ToolStripMenuItem _ToolStripMenuItem208;

	[AccessedThroughProperty("ToolStripMenuItem209")]
	private ToolStripMenuItem _ToolStripMenuItem209;

	[AccessedThroughProperty("ToolStripMenuItem210")]
	private ToolStripMenuItem _ToolStripMenuItem210;

	[AccessedThroughProperty("ToolStripMenuItem211")]
	private ToolStripMenuItem _ToolStripMenuItem211;

	[AccessedThroughProperty("ToolStripMenuItem212")]
	private ToolStripMenuItem _ToolStripMenuItem212;

	[AccessedThroughProperty("ToolStripMenuItem213")]
	private ToolStripMenuItem _ToolStripMenuItem213;

	[AccessedThroughProperty("ToolStripMenuItem214")]
	private ToolStripMenuItem _ToolStripMenuItem214;

	[AccessedThroughProperty("ToolStripMenuItem215")]
	private ToolStripMenuItem _ToolStripMenuItem215;

	[AccessedThroughProperty("ToolStripMenuItem216")]
	private ToolStripMenuItem _ToolStripMenuItem216;

	[AccessedThroughProperty("ToolStripMenuItem217")]
	private ToolStripMenuItem _ToolStripMenuItem217;

	[AccessedThroughProperty("ToolStripSeparator62")]
	private ToolStripSeparator _ToolStripSeparator62;

	[AccessedThroughProperty("ToolStripMenuItem218")]
	private ToolStripMenuItem _ToolStripMenuItem218;

	[AccessedThroughProperty("StatusStrip7")]
	private StatusStrip _StatusStrip7;

	[AccessedThroughProperty("ToolStripStatusLabel7")]
	private ToolStripStatusLabel _ToolStripStatusLabel7;

	[AccessedThroughProperty("ToolStrip7")]
	private ToolStrip _ToolStrip7;

	[AccessedThroughProperty("ToolStripButton34")]
	private ToolStripButton _ToolStripButton34;

	[AccessedThroughProperty("ToolStripButton35")]
	private ToolStripButton _ToolStripButton35;

	[AccessedThroughProperty("ToolStripButton36")]
	private ToolStripButton _ToolStripButton36;

	[AccessedThroughProperty("ToolStripSeparator64")]
	private ToolStripSeparator _ToolStripSeparator64;

	[AccessedThroughProperty("ToolStripButton33")]
	private ToolStripButton _ToolStripButton33;

	[AccessedThroughProperty("ToolStripButton32")]
	private ToolStripButton _ToolStripButton32;

	[AccessedThroughProperty("ToolStripSeparator63")]
	private ToolStripSeparator _ToolStripSeparator63;

	[AccessedThroughProperty("ToolStripButton31")]
	private ToolStripButton _ToolStripButton31;

	[AccessedThroughProperty("ToolTip3")]
	private ToolTip _ToolTip3;

	[AccessedThroughProperty("ToolTip4")]
	private ToolTip _ToolTip4;

	[AccessedThroughProperty("ToolTip5")]
	private ToolTip _ToolTip5;

	[AccessedThroughProperty("ToolTip6")]
	private ToolTip _ToolTip6;

	[AccessedThroughProperty("ToolTip7")]
	private ToolTip _ToolTip7;

	[AccessedThroughProperty("ToolTip8")]
	private ToolTip _ToolTip8;

	[AccessedThroughProperty("ToolTip9")]
	private ToolTip _ToolTip9;

	[AccessedThroughProperty("ToolTip10")]
	private ToolTip _ToolTip10;

	[AccessedThroughProperty("ToolTip11")]
	private ToolTip _ToolTip11;

	[AccessedThroughProperty("ToolTip12")]
	private ToolTip _ToolTip12;

	[AccessedThroughProperty("ToolTip13")]
	private ToolTip _ToolTip13;

	[AccessedThroughProperty("ToolTip14")]
	private ToolTip _ToolTip14;

	[AccessedThroughProperty("ToolTip15")]
	private ToolTip _ToolTip15;

	internal virtual ToolStripContainer ToolStripContainer
	{
		get
		{
			return _ToolStripContainer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripContainer = value;
		}
	}

	internal virtual ImageList TreeNodeImageList
	{
		get
		{
			return _TreeNodeImageList;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TreeNodeImageList = value;
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

	internal virtual ToolStripButton BackToolStripButton
	{
		get
		{
			return _BackToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_BackToolStripButton = value;
		}
	}

	internal virtual ToolStripButton ForwardToolStripButton
	{
		get
		{
			return _ForwardToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ForwardToolStripButton = value;
		}
	}

	internal virtual ToolStripButton FoldersToolStripButton
	{
		get
		{
			return _FoldersToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = FoldersToolStripButton_Click;
			if (_FoldersToolStripButton != null)
			{
				((ToolStripItem)_FoldersToolStripButton).remove_Click(eventHandler);
			}
			_FoldersToolStripButton = value;
			if (_FoldersToolStripButton != null)
			{
				((ToolStripItem)_FoldersToolStripButton).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripDropDownButton ListViewToolStripButton
	{
		get
		{
			return _ListViewToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListViewToolStripButton = value;
		}
	}

	internal virtual ToolStripMenuItem ListToolStripMenuItem
	{
		get
		{
			return _ListToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = ListToolStripMenuItem_Click;
			if (_ListToolStripMenuItem != null)
			{
				((ToolStripItem)_ListToolStripMenuItem).remove_Click(eventHandler);
			}
			_ListToolStripMenuItem = value;
			if (_ListToolStripMenuItem != null)
			{
				((ToolStripItem)_ListToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem DetailsToolStripMenuItem
	{
		get
		{
			return _DetailsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = DetailsToolStripMenuItem_Click;
			if (_DetailsToolStripMenuItem != null)
			{
				((ToolStripItem)_DetailsToolStripMenuItem).remove_Click(eventHandler);
			}
			_DetailsToolStripMenuItem = value;
			if (_DetailsToolStripMenuItem != null)
			{
				((ToolStripItem)_DetailsToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem LargeIconsToolStripMenuItem
	{
		get
		{
			return _LargeIconsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = LargeIconsToolStripMenuItem_Click;
			if (_LargeIconsToolStripMenuItem != null)
			{
				((ToolStripItem)_LargeIconsToolStripMenuItem).remove_Click(eventHandler);
			}
			_LargeIconsToolStripMenuItem = value;
			if (_LargeIconsToolStripMenuItem != null)
			{
				((ToolStripItem)_LargeIconsToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem SmallIconsToolStripMenuItem
	{
		get
		{
			return _SmallIconsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = SmallIconsToolStripMenuItem_Click;
			if (_SmallIconsToolStripMenuItem != null)
			{
				((ToolStripItem)_SmallIconsToolStripMenuItem).remove_Click(eventHandler);
			}
			_SmallIconsToolStripMenuItem = value;
			if (_SmallIconsToolStripMenuItem != null)
			{
				((ToolStripItem)_SmallIconsToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem TileToolStripMenuItem
	{
		get
		{
			return _TileToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = TileToolStripMenuItem_Click;
			if (_TileToolStripMenuItem != null)
			{
				((ToolStripItem)_TileToolStripMenuItem).remove_Click(eventHandler);
			}
			_TileToolStripMenuItem = value;
			if (_TileToolStripMenuItem != null)
			{
				((ToolStripItem)_TileToolStripMenuItem).add_Click(eventHandler);
			}
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

	internal virtual ToolStripMenuItem FileToolStripMenuItem
	{
		get
		{
			return _FileToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_FileToolStripMenuItem = value;
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
			_NewToolStripMenuItem = value;
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
			EventHandler eventHandler = OpenToolStripMenuItem_Click;
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

	internal virtual ToolStripMenuItem ExitToolStripMenuItem
	{
		get
		{
			return _ExitToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = ExitToolStripMenuItem_Click;
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

	internal virtual ToolStripMenuItem EditToolStripMenuItem
	{
		get
		{
			return _EditToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_EditToolStripMenuItem = value;
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

	internal virtual ToolStripMenuItem CutToolStripMenuItem
	{
		get
		{
			return _CutToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CutToolStripMenuItem = value;
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
			_CopyToolStripMenuItem = value;
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
			_PasteToolStripMenuItem = value;
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

	internal virtual ToolStripMenuItem ViewToolStripMenuItem
	{
		get
		{
			return _ViewToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ViewToolStripMenuItem = value;
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

	internal virtual ToolStripMenuItem FoldersToolStripMenuItem
	{
		get
		{
			return _FoldersToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = FoldersToolStripMenuItem_Click;
			if (_FoldersToolStripMenuItem != null)
			{
				((ToolStripItem)_FoldersToolStripMenuItem).remove_Click(eventHandler);
			}
			_FoldersToolStripMenuItem = value;
			if (_FoldersToolStripMenuItem != null)
			{
				((ToolStripItem)_FoldersToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ToolsToolStripMenuItem
	{
		get
		{
			return _ToolsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolsToolStripMenuItem = value;
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

	internal virtual ToolStripMenuItem HelpToolStripMenuItem
	{
		get
		{
			return _HelpToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_HelpToolStripMenuItem = value;
		}
	}

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

	internal virtual SplitContainer SplitContainer
	{
		get
		{
			return _SplitContainer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_SplitContainer = value;
		}
	}

	internal virtual TreeView TreeView
	{
		get
		{
			return _TreeView;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			TreeViewEventHandler val = new TreeViewEventHandler(TreeView_AfterSelect);
			if (_TreeView != null)
			{
				_TreeView.remove_AfterSelect(val);
			}
			_TreeView = value;
			if (_TreeView != null)
			{
				_TreeView.add_AfterSelect(val);
			}
		}
	}

	internal virtual ListView ListView
	{
		get
		{
			return _ListView;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListView = value;
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

	internal virtual ImageList ListViewLargeImageList
	{
		get
		{
			return _ListViewLargeImageList;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListViewLargeImageList = value;
		}
	}

	internal virtual ImageList ListViewSmallImageList
	{
		get
		{
			return _ListViewSmallImageList;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListViewSmallImageList = value;
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

	internal virtual ToolStripMenuItem NewWindowToolStripMenuItem
	{
		get
		{
			return _NewWindowToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_NewWindowToolStripMenuItem = value;
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
			_CascadeToolStripMenuItem = value;
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
			_TileVerticalToolStripMenuItem = value;
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
			_TileHorizontalToolStripMenuItem = value;
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
			_CloseAllToolStripMenuItem = value;
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
			_ArrangeIconsToolStripMenuItem = value;
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

	internal virtual ToolStripButton NewToolStripButton
	{
		get
		{
			return _NewToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_NewToolStripButton = value;
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
			_OpenToolStripButton = value;
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

	internal virtual MenuStrip MenuStrip15
	{
		get
		{
			return _MenuStrip15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MenuStrip15 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem450
	{
		get
		{
			return _ToolStripMenuItem450;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem450 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem451
	{
		get
		{
			return _ToolStripMenuItem451;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem451 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem452
	{
		get
		{
			return _ToolStripMenuItem452;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem452 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator121
	{
		get
		{
			return _ToolStripSeparator121;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator121 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem453
	{
		get
		{
			return _ToolStripMenuItem453;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem453 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem454
	{
		get
		{
			return _ToolStripMenuItem454;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem454 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator122
	{
		get
		{
			return _ToolStripSeparator122;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator122 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem455
	{
		get
		{
			return _ToolStripMenuItem455;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem455 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem456
	{
		get
		{
			return _ToolStripMenuItem456;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem456 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem457
	{
		get
		{
			return _ToolStripMenuItem457;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem457 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator123
	{
		get
		{
			return _ToolStripSeparator123;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator123 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem458
	{
		get
		{
			return _ToolStripMenuItem458;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem458 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem459
	{
		get
		{
			return _ToolStripMenuItem459;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem459 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem460
	{
		get
		{
			return _ToolStripMenuItem460;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem460 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem461
	{
		get
		{
			return _ToolStripMenuItem461;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem461 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator124
	{
		get
		{
			return _ToolStripSeparator124;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator124 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem462
	{
		get
		{
			return _ToolStripMenuItem462;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem462 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem463
	{
		get
		{
			return _ToolStripMenuItem463;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem463 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem464
	{
		get
		{
			return _ToolStripMenuItem464;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem464 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator125
	{
		get
		{
			return _ToolStripSeparator125;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator125 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem465
	{
		get
		{
			return _ToolStripMenuItem465;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem465 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem466
	{
		get
		{
			return _ToolStripMenuItem466;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem466 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem467
	{
		get
		{
			return _ToolStripMenuItem467;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem467 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem468
	{
		get
		{
			return _ToolStripMenuItem468;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem468 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem469
	{
		get
		{
			return _ToolStripMenuItem469;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem469 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem470
	{
		get
		{
			return _ToolStripMenuItem470;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem470 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem471
	{
		get
		{
			return _ToolStripMenuItem471;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem471 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem472
	{
		get
		{
			return _ToolStripMenuItem472;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem472 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem473
	{
		get
		{
			return _ToolStripMenuItem473;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem473 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem474
	{
		get
		{
			return _ToolStripMenuItem474;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem474 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem475
	{
		get
		{
			return _ToolStripMenuItem475;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem475 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem476
	{
		get
		{
			return _ToolStripMenuItem476;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem476 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem477
	{
		get
		{
			return _ToolStripMenuItem477;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem477 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem478
	{
		get
		{
			return _ToolStripMenuItem478;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem478 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem479
	{
		get
		{
			return _ToolStripMenuItem479;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem479 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem480
	{
		get
		{
			return _ToolStripMenuItem480;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem480 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem481
	{
		get
		{
			return _ToolStripMenuItem481;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem481 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator126
	{
		get
		{
			return _ToolStripSeparator126;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator126 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem482
	{
		get
		{
			return _ToolStripMenuItem482;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem482 = value;
		}
	}

	internal virtual StatusStrip StatusStrip15
	{
		get
		{
			return _StatusStrip15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_StatusStrip15 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel15
	{
		get
		{
			return _ToolStripStatusLabel15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripStatusLabel15 = value;
		}
	}

	internal virtual ToolStrip ToolStrip15
	{
		get
		{
			return _ToolStrip15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStrip15 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton82
	{
		get
		{
			return _ToolStripButton82;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton82 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton83
	{
		get
		{
			return _ToolStripButton83;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton83 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton84
	{
		get
		{
			return _ToolStripButton84;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton84 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator128
	{
		get
		{
			return _ToolStripSeparator128;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator128 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton81
	{
		get
		{
			return _ToolStripButton81;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton81 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton80
	{
		get
		{
			return _ToolStripButton80;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton80 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator127
	{
		get
		{
			return _ToolStripSeparator127;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator127 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton79
	{
		get
		{
			return _ToolStripButton79;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton79 = value;
		}
	}

	internal virtual MenuStrip MenuStrip14
	{
		get
		{
			return _MenuStrip14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MenuStrip14 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem417
	{
		get
		{
			return _ToolStripMenuItem417;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem417 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem418
	{
		get
		{
			return _ToolStripMenuItem418;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem418 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem419
	{
		get
		{
			return _ToolStripMenuItem419;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem419 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator113
	{
		get
		{
			return _ToolStripSeparator113;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator113 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem420
	{
		get
		{
			return _ToolStripMenuItem420;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem420 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem421
	{
		get
		{
			return _ToolStripMenuItem421;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem421 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator114
	{
		get
		{
			return _ToolStripSeparator114;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator114 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem422
	{
		get
		{
			return _ToolStripMenuItem422;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem422 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem423
	{
		get
		{
			return _ToolStripMenuItem423;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem423 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem424
	{
		get
		{
			return _ToolStripMenuItem424;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem424 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator115
	{
		get
		{
			return _ToolStripSeparator115;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator115 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem425
	{
		get
		{
			return _ToolStripMenuItem425;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem425 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem426
	{
		get
		{
			return _ToolStripMenuItem426;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem426 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem427
	{
		get
		{
			return _ToolStripMenuItem427;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem427 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem428
	{
		get
		{
			return _ToolStripMenuItem428;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem428 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator116
	{
		get
		{
			return _ToolStripSeparator116;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator116 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem429
	{
		get
		{
			return _ToolStripMenuItem429;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem429 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem430
	{
		get
		{
			return _ToolStripMenuItem430;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem430 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem431
	{
		get
		{
			return _ToolStripMenuItem431;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem431 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator117
	{
		get
		{
			return _ToolStripSeparator117;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator117 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem432
	{
		get
		{
			return _ToolStripMenuItem432;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem432 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem433
	{
		get
		{
			return _ToolStripMenuItem433;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem433 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem434
	{
		get
		{
			return _ToolStripMenuItem434;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem434 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem435
	{
		get
		{
			return _ToolStripMenuItem435;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem435 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem436
	{
		get
		{
			return _ToolStripMenuItem436;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem436 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem437
	{
		get
		{
			return _ToolStripMenuItem437;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem437 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem438
	{
		get
		{
			return _ToolStripMenuItem438;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem438 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem439
	{
		get
		{
			return _ToolStripMenuItem439;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem439 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem440
	{
		get
		{
			return _ToolStripMenuItem440;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem440 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem441
	{
		get
		{
			return _ToolStripMenuItem441;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem441 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem442
	{
		get
		{
			return _ToolStripMenuItem442;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem442 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem443
	{
		get
		{
			return _ToolStripMenuItem443;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem443 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem444
	{
		get
		{
			return _ToolStripMenuItem444;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem444 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem445
	{
		get
		{
			return _ToolStripMenuItem445;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem445 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem446
	{
		get
		{
			return _ToolStripMenuItem446;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem446 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem447
	{
		get
		{
			return _ToolStripMenuItem447;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem447 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem448
	{
		get
		{
			return _ToolStripMenuItem448;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem448 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator118
	{
		get
		{
			return _ToolStripSeparator118;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator118 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem449
	{
		get
		{
			return _ToolStripMenuItem449;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem449 = value;
		}
	}

	internal virtual StatusStrip StatusStrip14
	{
		get
		{
			return _StatusStrip14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_StatusStrip14 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel14
	{
		get
		{
			return _ToolStripStatusLabel14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripStatusLabel14 = value;
		}
	}

	internal virtual ToolStrip ToolStrip14
	{
		get
		{
			return _ToolStrip14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStrip14 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton76
	{
		get
		{
			return _ToolStripButton76;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton76 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton77
	{
		get
		{
			return _ToolStripButton77;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton77 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton78
	{
		get
		{
			return _ToolStripButton78;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton78 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator120
	{
		get
		{
			return _ToolStripSeparator120;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator120 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton75
	{
		get
		{
			return _ToolStripButton75;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton75 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton74
	{
		get
		{
			return _ToolStripButton74;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton74 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator119
	{
		get
		{
			return _ToolStripSeparator119;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator119 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton73
	{
		get
		{
			return _ToolStripButton73;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton73 = value;
		}
	}

	internal virtual MenuStrip MenuStrip13
	{
		get
		{
			return _MenuStrip13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MenuStrip13 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem384
	{
		get
		{
			return _ToolStripMenuItem384;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem384 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem385
	{
		get
		{
			return _ToolStripMenuItem385;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem385 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem386
	{
		get
		{
			return _ToolStripMenuItem386;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem386 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator105
	{
		get
		{
			return _ToolStripSeparator105;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator105 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem387
	{
		get
		{
			return _ToolStripMenuItem387;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem387 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem388
	{
		get
		{
			return _ToolStripMenuItem388;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem388 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator106
	{
		get
		{
			return _ToolStripSeparator106;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator106 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem389
	{
		get
		{
			return _ToolStripMenuItem389;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem389 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem390
	{
		get
		{
			return _ToolStripMenuItem390;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem390 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem391
	{
		get
		{
			return _ToolStripMenuItem391;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem391 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator107
	{
		get
		{
			return _ToolStripSeparator107;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator107 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem392
	{
		get
		{
			return _ToolStripMenuItem392;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem392 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem393
	{
		get
		{
			return _ToolStripMenuItem393;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem393 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem394
	{
		get
		{
			return _ToolStripMenuItem394;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem394 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem395
	{
		get
		{
			return _ToolStripMenuItem395;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem395 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator108
	{
		get
		{
			return _ToolStripSeparator108;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator108 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem396
	{
		get
		{
			return _ToolStripMenuItem396;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem396 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem397
	{
		get
		{
			return _ToolStripMenuItem397;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem397 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem398
	{
		get
		{
			return _ToolStripMenuItem398;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem398 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator109
	{
		get
		{
			return _ToolStripSeparator109;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator109 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem399
	{
		get
		{
			return _ToolStripMenuItem399;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem399 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem400
	{
		get
		{
			return _ToolStripMenuItem400;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem400 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem401
	{
		get
		{
			return _ToolStripMenuItem401;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem401 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem402
	{
		get
		{
			return _ToolStripMenuItem402;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem402 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem403
	{
		get
		{
			return _ToolStripMenuItem403;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem403 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem404
	{
		get
		{
			return _ToolStripMenuItem404;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem404 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem405
	{
		get
		{
			return _ToolStripMenuItem405;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem405 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem406
	{
		get
		{
			return _ToolStripMenuItem406;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem406 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem407
	{
		get
		{
			return _ToolStripMenuItem407;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem407 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem408
	{
		get
		{
			return _ToolStripMenuItem408;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem408 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem409
	{
		get
		{
			return _ToolStripMenuItem409;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem409 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem410
	{
		get
		{
			return _ToolStripMenuItem410;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem410 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem411
	{
		get
		{
			return _ToolStripMenuItem411;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem411 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem412
	{
		get
		{
			return _ToolStripMenuItem412;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem412 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem413
	{
		get
		{
			return _ToolStripMenuItem413;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem413 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem414
	{
		get
		{
			return _ToolStripMenuItem414;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem414 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem415
	{
		get
		{
			return _ToolStripMenuItem415;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem415 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator110
	{
		get
		{
			return _ToolStripSeparator110;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator110 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem416
	{
		get
		{
			return _ToolStripMenuItem416;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem416 = value;
		}
	}

	internal virtual StatusStrip StatusStrip13
	{
		get
		{
			return _StatusStrip13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_StatusStrip13 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel13
	{
		get
		{
			return _ToolStripStatusLabel13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripStatusLabel13 = value;
		}
	}

	internal virtual ToolStrip ToolStrip13
	{
		get
		{
			return _ToolStrip13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStrip13 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton70
	{
		get
		{
			return _ToolStripButton70;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton70 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton71
	{
		get
		{
			return _ToolStripButton71;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton71 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton72
	{
		get
		{
			return _ToolStripButton72;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton72 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator112
	{
		get
		{
			return _ToolStripSeparator112;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator112 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton69
	{
		get
		{
			return _ToolStripButton69;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton69 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton68
	{
		get
		{
			return _ToolStripButton68;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton68 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator111
	{
		get
		{
			return _ToolStripSeparator111;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator111 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton67
	{
		get
		{
			return _ToolStripButton67;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton67 = value;
		}
	}

	internal virtual MenuStrip MenuStrip12
	{
		get
		{
			return _MenuStrip12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MenuStrip12 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem351
	{
		get
		{
			return _ToolStripMenuItem351;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem351 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem352
	{
		get
		{
			return _ToolStripMenuItem352;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem352 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem353
	{
		get
		{
			return _ToolStripMenuItem353;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem353 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator97
	{
		get
		{
			return _ToolStripSeparator97;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator97 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem354
	{
		get
		{
			return _ToolStripMenuItem354;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem354 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem355
	{
		get
		{
			return _ToolStripMenuItem355;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem355 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator98
	{
		get
		{
			return _ToolStripSeparator98;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator98 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem356
	{
		get
		{
			return _ToolStripMenuItem356;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem356 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem357
	{
		get
		{
			return _ToolStripMenuItem357;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem357 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem358
	{
		get
		{
			return _ToolStripMenuItem358;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem358 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator99
	{
		get
		{
			return _ToolStripSeparator99;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator99 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem359
	{
		get
		{
			return _ToolStripMenuItem359;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem359 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem360
	{
		get
		{
			return _ToolStripMenuItem360;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem360 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem361
	{
		get
		{
			return _ToolStripMenuItem361;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem361 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem362
	{
		get
		{
			return _ToolStripMenuItem362;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem362 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator100
	{
		get
		{
			return _ToolStripSeparator100;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator100 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem363
	{
		get
		{
			return _ToolStripMenuItem363;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem363 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem364
	{
		get
		{
			return _ToolStripMenuItem364;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem364 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem365
	{
		get
		{
			return _ToolStripMenuItem365;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem365 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator101
	{
		get
		{
			return _ToolStripSeparator101;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator101 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem366
	{
		get
		{
			return _ToolStripMenuItem366;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem366 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem367
	{
		get
		{
			return _ToolStripMenuItem367;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem367 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem368
	{
		get
		{
			return _ToolStripMenuItem368;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem368 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem369
	{
		get
		{
			return _ToolStripMenuItem369;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem369 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem370
	{
		get
		{
			return _ToolStripMenuItem370;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem370 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem371
	{
		get
		{
			return _ToolStripMenuItem371;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem371 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem372
	{
		get
		{
			return _ToolStripMenuItem372;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem372 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem373
	{
		get
		{
			return _ToolStripMenuItem373;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem373 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem374
	{
		get
		{
			return _ToolStripMenuItem374;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem374 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem375
	{
		get
		{
			return _ToolStripMenuItem375;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem375 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem376
	{
		get
		{
			return _ToolStripMenuItem376;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem376 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem377
	{
		get
		{
			return _ToolStripMenuItem377;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem377 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem378
	{
		get
		{
			return _ToolStripMenuItem378;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem378 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem379
	{
		get
		{
			return _ToolStripMenuItem379;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem379 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem380
	{
		get
		{
			return _ToolStripMenuItem380;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem380 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem381
	{
		get
		{
			return _ToolStripMenuItem381;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem381 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem382
	{
		get
		{
			return _ToolStripMenuItem382;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem382 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator102
	{
		get
		{
			return _ToolStripSeparator102;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator102 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem383
	{
		get
		{
			return _ToolStripMenuItem383;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem383 = value;
		}
	}

	internal virtual StatusStrip StatusStrip12
	{
		get
		{
			return _StatusStrip12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_StatusStrip12 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel12
	{
		get
		{
			return _ToolStripStatusLabel12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripStatusLabel12 = value;
		}
	}

	internal virtual ToolStrip ToolStrip12
	{
		get
		{
			return _ToolStrip12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStrip12 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton64
	{
		get
		{
			return _ToolStripButton64;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton64 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton65
	{
		get
		{
			return _ToolStripButton65;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton65 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton66
	{
		get
		{
			return _ToolStripButton66;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton66 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator104
	{
		get
		{
			return _ToolStripSeparator104;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator104 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton63
	{
		get
		{
			return _ToolStripButton63;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton63 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton62
	{
		get
		{
			return _ToolStripButton62;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton62 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator103
	{
		get
		{
			return _ToolStripSeparator103;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator103 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton61
	{
		get
		{
			return _ToolStripButton61;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton61 = value;
		}
	}

	internal virtual MenuStrip MenuStrip11
	{
		get
		{
			return _MenuStrip11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MenuStrip11 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem318
	{
		get
		{
			return _ToolStripMenuItem318;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem318 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem319
	{
		get
		{
			return _ToolStripMenuItem319;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem319 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem320
	{
		get
		{
			return _ToolStripMenuItem320;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem320 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator89
	{
		get
		{
			return _ToolStripSeparator89;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator89 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem321
	{
		get
		{
			return _ToolStripMenuItem321;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem321 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem322
	{
		get
		{
			return _ToolStripMenuItem322;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem322 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator90
	{
		get
		{
			return _ToolStripSeparator90;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator90 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem323
	{
		get
		{
			return _ToolStripMenuItem323;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem323 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem324
	{
		get
		{
			return _ToolStripMenuItem324;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem324 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem325
	{
		get
		{
			return _ToolStripMenuItem325;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem325 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator91
	{
		get
		{
			return _ToolStripSeparator91;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator91 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem326
	{
		get
		{
			return _ToolStripMenuItem326;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem326 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem327
	{
		get
		{
			return _ToolStripMenuItem327;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem327 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem328
	{
		get
		{
			return _ToolStripMenuItem328;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem328 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem329
	{
		get
		{
			return _ToolStripMenuItem329;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem329 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator92
	{
		get
		{
			return _ToolStripSeparator92;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator92 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem330
	{
		get
		{
			return _ToolStripMenuItem330;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem330 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem331
	{
		get
		{
			return _ToolStripMenuItem331;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem331 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem332
	{
		get
		{
			return _ToolStripMenuItem332;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem332 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator93
	{
		get
		{
			return _ToolStripSeparator93;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator93 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem333
	{
		get
		{
			return _ToolStripMenuItem333;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem333 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem334
	{
		get
		{
			return _ToolStripMenuItem334;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem334 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem335
	{
		get
		{
			return _ToolStripMenuItem335;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem335 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem336
	{
		get
		{
			return _ToolStripMenuItem336;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem336 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem337
	{
		get
		{
			return _ToolStripMenuItem337;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem337 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem338
	{
		get
		{
			return _ToolStripMenuItem338;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem338 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem339
	{
		get
		{
			return _ToolStripMenuItem339;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem339 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem340
	{
		get
		{
			return _ToolStripMenuItem340;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem340 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem341
	{
		get
		{
			return _ToolStripMenuItem341;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem341 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem342
	{
		get
		{
			return _ToolStripMenuItem342;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem342 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem343
	{
		get
		{
			return _ToolStripMenuItem343;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem343 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem344
	{
		get
		{
			return _ToolStripMenuItem344;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem344 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem345
	{
		get
		{
			return _ToolStripMenuItem345;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem345 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem346
	{
		get
		{
			return _ToolStripMenuItem346;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem346 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem347
	{
		get
		{
			return _ToolStripMenuItem347;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem347 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem348
	{
		get
		{
			return _ToolStripMenuItem348;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem348 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem349
	{
		get
		{
			return _ToolStripMenuItem349;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem349 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator94
	{
		get
		{
			return _ToolStripSeparator94;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator94 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem350
	{
		get
		{
			return _ToolStripMenuItem350;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem350 = value;
		}
	}

	internal virtual StatusStrip StatusStrip11
	{
		get
		{
			return _StatusStrip11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_StatusStrip11 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel11
	{
		get
		{
			return _ToolStripStatusLabel11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripStatusLabel11 = value;
		}
	}

	internal virtual ToolStrip ToolStrip11
	{
		get
		{
			return _ToolStrip11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStrip11 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton58
	{
		get
		{
			return _ToolStripButton58;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton58 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton59
	{
		get
		{
			return _ToolStripButton59;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton59 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton60
	{
		get
		{
			return _ToolStripButton60;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton60 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator96
	{
		get
		{
			return _ToolStripSeparator96;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator96 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton57
	{
		get
		{
			return _ToolStripButton57;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton57 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton56
	{
		get
		{
			return _ToolStripButton56;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton56 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator95
	{
		get
		{
			return _ToolStripSeparator95;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator95 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton55
	{
		get
		{
			return _ToolStripButton55;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton55 = value;
		}
	}

	internal virtual MenuStrip MenuStrip10
	{
		get
		{
			return _MenuStrip10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MenuStrip10 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem285
	{
		get
		{
			return _ToolStripMenuItem285;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem285 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem286
	{
		get
		{
			return _ToolStripMenuItem286;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem286 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem287
	{
		get
		{
			return _ToolStripMenuItem287;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem287 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator81
	{
		get
		{
			return _ToolStripSeparator81;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator81 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem288
	{
		get
		{
			return _ToolStripMenuItem288;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem288 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem289
	{
		get
		{
			return _ToolStripMenuItem289;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem289 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator82
	{
		get
		{
			return _ToolStripSeparator82;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator82 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem290
	{
		get
		{
			return _ToolStripMenuItem290;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem290 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem291
	{
		get
		{
			return _ToolStripMenuItem291;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem291 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem292
	{
		get
		{
			return _ToolStripMenuItem292;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem292 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator83
	{
		get
		{
			return _ToolStripSeparator83;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator83 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem293
	{
		get
		{
			return _ToolStripMenuItem293;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem293 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem294
	{
		get
		{
			return _ToolStripMenuItem294;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem294 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem295
	{
		get
		{
			return _ToolStripMenuItem295;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem295 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem296
	{
		get
		{
			return _ToolStripMenuItem296;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem296 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator84
	{
		get
		{
			return _ToolStripSeparator84;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator84 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem297
	{
		get
		{
			return _ToolStripMenuItem297;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem297 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem298
	{
		get
		{
			return _ToolStripMenuItem298;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem298 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem299
	{
		get
		{
			return _ToolStripMenuItem299;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem299 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator85
	{
		get
		{
			return _ToolStripSeparator85;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator85 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem300
	{
		get
		{
			return _ToolStripMenuItem300;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem300 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem301
	{
		get
		{
			return _ToolStripMenuItem301;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem301 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem302
	{
		get
		{
			return _ToolStripMenuItem302;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem302 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem303
	{
		get
		{
			return _ToolStripMenuItem303;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem303 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem304
	{
		get
		{
			return _ToolStripMenuItem304;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem304 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem305
	{
		get
		{
			return _ToolStripMenuItem305;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem305 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem306
	{
		get
		{
			return _ToolStripMenuItem306;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem306 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem307
	{
		get
		{
			return _ToolStripMenuItem307;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem307 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem308
	{
		get
		{
			return _ToolStripMenuItem308;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem308 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem309
	{
		get
		{
			return _ToolStripMenuItem309;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem309 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem310
	{
		get
		{
			return _ToolStripMenuItem310;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem310 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem311
	{
		get
		{
			return _ToolStripMenuItem311;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem311 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem312
	{
		get
		{
			return _ToolStripMenuItem312;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem312 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem313
	{
		get
		{
			return _ToolStripMenuItem313;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem313 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem314
	{
		get
		{
			return _ToolStripMenuItem314;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem314 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem315
	{
		get
		{
			return _ToolStripMenuItem315;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem315 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem316
	{
		get
		{
			return _ToolStripMenuItem316;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem316 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator86
	{
		get
		{
			return _ToolStripSeparator86;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator86 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem317
	{
		get
		{
			return _ToolStripMenuItem317;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem317 = value;
		}
	}

	internal virtual StatusStrip StatusStrip10
	{
		get
		{
			return _StatusStrip10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_StatusStrip10 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel10
	{
		get
		{
			return _ToolStripStatusLabel10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripStatusLabel10 = value;
		}
	}

	internal virtual ToolStrip ToolStrip10
	{
		get
		{
			return _ToolStrip10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStrip10 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton52
	{
		get
		{
			return _ToolStripButton52;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton52 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton53
	{
		get
		{
			return _ToolStripButton53;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton53 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton54
	{
		get
		{
			return _ToolStripButton54;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton54 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator88
	{
		get
		{
			return _ToolStripSeparator88;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator88 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton51
	{
		get
		{
			return _ToolStripButton51;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton51 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton50
	{
		get
		{
			return _ToolStripButton50;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton50 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator87
	{
		get
		{
			return _ToolStripSeparator87;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator87 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton49
	{
		get
		{
			return _ToolStripButton49;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton49 = value;
		}
	}

	internal virtual MenuStrip MenuStrip9
	{
		get
		{
			return _MenuStrip9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MenuStrip9 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem252
	{
		get
		{
			return _ToolStripMenuItem252;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem252 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem253
	{
		get
		{
			return _ToolStripMenuItem253;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem253 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem254
	{
		get
		{
			return _ToolStripMenuItem254;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem254 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator73
	{
		get
		{
			return _ToolStripSeparator73;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator73 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem255
	{
		get
		{
			return _ToolStripMenuItem255;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem255 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem256
	{
		get
		{
			return _ToolStripMenuItem256;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem256 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator74
	{
		get
		{
			return _ToolStripSeparator74;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator74 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem257
	{
		get
		{
			return _ToolStripMenuItem257;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem257 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem258
	{
		get
		{
			return _ToolStripMenuItem258;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem258 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem259
	{
		get
		{
			return _ToolStripMenuItem259;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem259 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator75
	{
		get
		{
			return _ToolStripSeparator75;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator75 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem260
	{
		get
		{
			return _ToolStripMenuItem260;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem260 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem261
	{
		get
		{
			return _ToolStripMenuItem261;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem261 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem262
	{
		get
		{
			return _ToolStripMenuItem262;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem262 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem263
	{
		get
		{
			return _ToolStripMenuItem263;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem263 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator76
	{
		get
		{
			return _ToolStripSeparator76;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator76 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem264
	{
		get
		{
			return _ToolStripMenuItem264;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem264 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem265
	{
		get
		{
			return _ToolStripMenuItem265;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem265 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem266
	{
		get
		{
			return _ToolStripMenuItem266;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem266 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator77
	{
		get
		{
			return _ToolStripSeparator77;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator77 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem267
	{
		get
		{
			return _ToolStripMenuItem267;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem267 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem268
	{
		get
		{
			return _ToolStripMenuItem268;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem268 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem269
	{
		get
		{
			return _ToolStripMenuItem269;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem269 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem270
	{
		get
		{
			return _ToolStripMenuItem270;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem270 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem271
	{
		get
		{
			return _ToolStripMenuItem271;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem271 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem272
	{
		get
		{
			return _ToolStripMenuItem272;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem272 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem273
	{
		get
		{
			return _ToolStripMenuItem273;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem273 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem274
	{
		get
		{
			return _ToolStripMenuItem274;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem274 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem275
	{
		get
		{
			return _ToolStripMenuItem275;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem275 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem276
	{
		get
		{
			return _ToolStripMenuItem276;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem276 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem277
	{
		get
		{
			return _ToolStripMenuItem277;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem277 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem278
	{
		get
		{
			return _ToolStripMenuItem278;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem278 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem279
	{
		get
		{
			return _ToolStripMenuItem279;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem279 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem280
	{
		get
		{
			return _ToolStripMenuItem280;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem280 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem281
	{
		get
		{
			return _ToolStripMenuItem281;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem281 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem282
	{
		get
		{
			return _ToolStripMenuItem282;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem282 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem283
	{
		get
		{
			return _ToolStripMenuItem283;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem283 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator78
	{
		get
		{
			return _ToolStripSeparator78;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator78 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem284
	{
		get
		{
			return _ToolStripMenuItem284;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem284 = value;
		}
	}

	internal virtual StatusStrip StatusStrip9
	{
		get
		{
			return _StatusStrip9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_StatusStrip9 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel9
	{
		get
		{
			return _ToolStripStatusLabel9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripStatusLabel9 = value;
		}
	}

	internal virtual ToolStrip ToolStrip9
	{
		get
		{
			return _ToolStrip9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStrip9 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton46
	{
		get
		{
			return _ToolStripButton46;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton46 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton47
	{
		get
		{
			return _ToolStripButton47;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton47 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton48
	{
		get
		{
			return _ToolStripButton48;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton48 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator80
	{
		get
		{
			return _ToolStripSeparator80;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator80 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton45
	{
		get
		{
			return _ToolStripButton45;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton45 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton44
	{
		get
		{
			return _ToolStripButton44;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton44 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator79
	{
		get
		{
			return _ToolStripSeparator79;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator79 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton43
	{
		get
		{
			return _ToolStripButton43;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton43 = value;
		}
	}

	internal virtual MenuStrip MenuStrip8
	{
		get
		{
			return _MenuStrip8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MenuStrip8 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem219
	{
		get
		{
			return _ToolStripMenuItem219;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem219 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem220
	{
		get
		{
			return _ToolStripMenuItem220;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem220 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem221
	{
		get
		{
			return _ToolStripMenuItem221;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem221 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator65
	{
		get
		{
			return _ToolStripSeparator65;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator65 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem222
	{
		get
		{
			return _ToolStripMenuItem222;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem222 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem223
	{
		get
		{
			return _ToolStripMenuItem223;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem223 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator66
	{
		get
		{
			return _ToolStripSeparator66;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator66 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem224
	{
		get
		{
			return _ToolStripMenuItem224;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem224 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem225
	{
		get
		{
			return _ToolStripMenuItem225;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem225 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem226
	{
		get
		{
			return _ToolStripMenuItem226;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem226 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator67
	{
		get
		{
			return _ToolStripSeparator67;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator67 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem227
	{
		get
		{
			return _ToolStripMenuItem227;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem227 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem228
	{
		get
		{
			return _ToolStripMenuItem228;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem228 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem229
	{
		get
		{
			return _ToolStripMenuItem229;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem229 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem230
	{
		get
		{
			return _ToolStripMenuItem230;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem230 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator68
	{
		get
		{
			return _ToolStripSeparator68;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator68 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem231
	{
		get
		{
			return _ToolStripMenuItem231;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem231 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem232
	{
		get
		{
			return _ToolStripMenuItem232;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem232 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem233
	{
		get
		{
			return _ToolStripMenuItem233;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem233 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator69
	{
		get
		{
			return _ToolStripSeparator69;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator69 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem234
	{
		get
		{
			return _ToolStripMenuItem234;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem234 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem235
	{
		get
		{
			return _ToolStripMenuItem235;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem235 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem236
	{
		get
		{
			return _ToolStripMenuItem236;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem236 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem237
	{
		get
		{
			return _ToolStripMenuItem237;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem237 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem238
	{
		get
		{
			return _ToolStripMenuItem238;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem238 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem239
	{
		get
		{
			return _ToolStripMenuItem239;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem239 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem240
	{
		get
		{
			return _ToolStripMenuItem240;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem240 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem241
	{
		get
		{
			return _ToolStripMenuItem241;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem241 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem242
	{
		get
		{
			return _ToolStripMenuItem242;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem242 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem243
	{
		get
		{
			return _ToolStripMenuItem243;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem243 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem244
	{
		get
		{
			return _ToolStripMenuItem244;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem244 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem245
	{
		get
		{
			return _ToolStripMenuItem245;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem245 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem246
	{
		get
		{
			return _ToolStripMenuItem246;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem246 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem247
	{
		get
		{
			return _ToolStripMenuItem247;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem247 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem248
	{
		get
		{
			return _ToolStripMenuItem248;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem248 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem249
	{
		get
		{
			return _ToolStripMenuItem249;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem249 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem250
	{
		get
		{
			return _ToolStripMenuItem250;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem250 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator70
	{
		get
		{
			return _ToolStripSeparator70;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator70 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem251
	{
		get
		{
			return _ToolStripMenuItem251;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem251 = value;
		}
	}

	internal virtual StatusStrip StatusStrip8
	{
		get
		{
			return _StatusStrip8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_StatusStrip8 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel8
	{
		get
		{
			return _ToolStripStatusLabel8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripStatusLabel8 = value;
		}
	}

	internal virtual ToolStrip ToolStrip8
	{
		get
		{
			return _ToolStrip8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStrip8 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton40
	{
		get
		{
			return _ToolStripButton40;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton40 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton41
	{
		get
		{
			return _ToolStripButton41;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton41 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton42
	{
		get
		{
			return _ToolStripButton42;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton42 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator72
	{
		get
		{
			return _ToolStripSeparator72;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator72 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton39
	{
		get
		{
			return _ToolStripButton39;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton39 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton38
	{
		get
		{
			return _ToolStripButton38;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton38 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator71
	{
		get
		{
			return _ToolStripSeparator71;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator71 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton37
	{
		get
		{
			return _ToolStripButton37;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripButton37 = value;
		}
	}

	internal virtual MenuStrip MenuStrip7
	{
		get
		{
			return _MenuStrip7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MenuStrip7 = value;
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

	internal virtual ToolStripSeparator ToolStripSeparator57
	{
		get
		{
			return _ToolStripSeparator57;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator57 = value;
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

	internal virtual ToolStripSeparator ToolStripSeparator58
	{
		get
		{
			return _ToolStripSeparator58;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator58 = value;
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

	internal virtual ToolStripSeparator ToolStripSeparator59
	{
		get
		{
			return _ToolStripSeparator59;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator59 = value;
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

	internal virtual ToolStripSeparator ToolStripSeparator60
	{
		get
		{
			return _ToolStripSeparator60;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator60 = value;
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

	internal virtual ToolStripMenuItem ToolStripMenuItem199
	{
		get
		{
			return _ToolStripMenuItem199;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem199 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem200
	{
		get
		{
			return _ToolStripMenuItem200;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem200 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator61
	{
		get
		{
			return _ToolStripSeparator61;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator61 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem201
	{
		get
		{
			return _ToolStripMenuItem201;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem201 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem202
	{
		get
		{
			return _ToolStripMenuItem202;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem202 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem203
	{
		get
		{
			return _ToolStripMenuItem203;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem203 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem204
	{
		get
		{
			return _ToolStripMenuItem204;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem204 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem205
	{
		get
		{
			return _ToolStripMenuItem205;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem205 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem206
	{
		get
		{
			return _ToolStripMenuItem206;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem206 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem207
	{
		get
		{
			return _ToolStripMenuItem207;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem207 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem208
	{
		get
		{
			return _ToolStripMenuItem208;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem208 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem209
	{
		get
		{
			return _ToolStripMenuItem209;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem209 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem210
	{
		get
		{
			return _ToolStripMenuItem210;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem210 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem211
	{
		get
		{
			return _ToolStripMenuItem211;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem211 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem212
	{
		get
		{
			return _ToolStripMenuItem212;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem212 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem213
	{
		get
		{
			return _ToolStripMenuItem213;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem213 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem214
	{
		get
		{
			return _ToolStripMenuItem214;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem214 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem215
	{
		get
		{
			return _ToolStripMenuItem215;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem215 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem216
	{
		get
		{
			return _ToolStripMenuItem216;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem216 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem217
	{
		get
		{
			return _ToolStripMenuItem217;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem217 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator62
	{
		get
		{
			return _ToolStripSeparator62;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator62 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem218
	{
		get
		{
			return _ToolStripMenuItem218;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripMenuItem218 = value;
		}
	}

	internal virtual StatusStrip StatusStrip7
	{
		get
		{
			return _StatusStrip7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_StatusStrip7 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel7
	{
		get
		{
			return _ToolStripStatusLabel7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripStatusLabel7 = value;
		}
	}

	internal virtual ToolStrip ToolStrip7
	{
		get
		{
			return _ToolStrip7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStrip7 = value;
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

	internal virtual ToolStripSeparator ToolStripSeparator64
	{
		get
		{
			return _ToolStripSeparator64;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator64 = value;
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

	internal virtual ToolStripSeparator ToolStripSeparator63
	{
		get
		{
			return _ToolStripSeparator63;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripSeparator63 = value;
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

	internal virtual ToolTip ToolTip7
	{
		get
		{
			return _ToolTip7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolTip7 = value;
		}
	}

	internal virtual ToolTip ToolTip8
	{
		get
		{
			return _ToolTip8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolTip8 = value;
		}
	}

	internal virtual ToolTip ToolTip9
	{
		get
		{
			return _ToolTip9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolTip9 = value;
		}
	}

	internal virtual ToolTip ToolTip10
	{
		get
		{
			return _ToolTip10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolTip10 = value;
		}
	}

	internal virtual ToolTip ToolTip11
	{
		get
		{
			return _ToolTip11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolTip11 = value;
		}
	}

	internal virtual ToolTip ToolTip12
	{
		get
		{
			return _ToolTip12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolTip12 = value;
		}
	}

	internal virtual ToolTip ToolTip13
	{
		get
		{
			return _ToolTip13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolTip13 = value;
		}
	}

	internal virtual ToolTip ToolTip14
	{
		get
		{
			return _ToolTip14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolTip14 = value;
		}
	}

	internal virtual ToolTip ToolTip15
	{
		get
		{
			return _ToolTip15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolTip15 = value;
		}
	}

	public Explorer1()
	{
		((Form)this).add_Load((EventHandler)Explorer1_Load);
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
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected O, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected O, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected O, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected O, but got Unknown
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected O, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected O, but got Unknown
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected O, but got Unknown
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected O, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected O, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected O, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected O, but got Unknown
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected O, but got Unknown
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected O, but got Unknown
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected O, but got Unknown
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected O, but got Unknown
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected O, but got Unknown
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected O, but got Unknown
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected O, but got Unknown
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected O, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected O, but got Unknown
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected O, but got Unknown
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected O, but got Unknown
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected O, but got Unknown
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected O, but got Unknown
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected O, but got Unknown
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected O, but got Unknown
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected O, but got Unknown
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Expected O, but got Unknown
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected O, but got Unknown
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected O, but got Unknown
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected O, but got Unknown
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected O, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected O, but got Unknown
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected O, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected O, but got Unknown
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected O, but got Unknown
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
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f2: Expected O, but got Unknown
		//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0703: Expected O, but got Unknown
		//IL_070a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0714: Expected O, but got Unknown
		//IL_0715: Unknown result type (might be due to invalid IL or missing references)
		//IL_071f: Expected O, but got Unknown
		//IL_0720: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Expected O, but got Unknown
		//IL_072b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0735: Expected O, but got Unknown
		//IL_0736: Unknown result type (might be due to invalid IL or missing references)
		//IL_0740: Expected O, but got Unknown
		//IL_0741: Unknown result type (might be due to invalid IL or missing references)
		//IL_074b: Expected O, but got Unknown
		//IL_074c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Expected O, but got Unknown
		//IL_0757: Unknown result type (might be due to invalid IL or missing references)
		//IL_0761: Expected O, but got Unknown
		//IL_0762: Unknown result type (might be due to invalid IL or missing references)
		//IL_076c: Expected O, but got Unknown
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Expected O, but got Unknown
		//IL_0778: Unknown result type (might be due to invalid IL or missing references)
		//IL_0782: Expected O, but got Unknown
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Expected O, but got Unknown
		//IL_078e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0798: Expected O, but got Unknown
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a3: Expected O, but got Unknown
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ae: Expected O, but got Unknown
		//IL_07af: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b9: Expected O, but got Unknown
		//IL_07ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c4: Expected O, but got Unknown
		//IL_07c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cf: Expected O, but got Unknown
		//IL_07d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Expected O, but got Unknown
		//IL_07db: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e5: Expected O, but got Unknown
		//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f0: Expected O, but got Unknown
		//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Expected O, but got Unknown
		//IL_07fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0806: Expected O, but got Unknown
		//IL_0807: Unknown result type (might be due to invalid IL or missing references)
		//IL_0811: Expected O, but got Unknown
		//IL_0812: Unknown result type (might be due to invalid IL or missing references)
		//IL_081c: Expected O, but got Unknown
		//IL_081d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0827: Expected O, but got Unknown
		//IL_0828: Unknown result type (might be due to invalid IL or missing references)
		//IL_0832: Expected O, but got Unknown
		//IL_0833: Unknown result type (might be due to invalid IL or missing references)
		//IL_083d: Expected O, but got Unknown
		//IL_083e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0848: Expected O, but got Unknown
		//IL_0849: Unknown result type (might be due to invalid IL or missing references)
		//IL_0853: Expected O, but got Unknown
		//IL_0854: Unknown result type (might be due to invalid IL or missing references)
		//IL_085e: Expected O, but got Unknown
		//IL_085f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0869: Expected O, but got Unknown
		//IL_086a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0874: Expected O, but got Unknown
		//IL_0875: Unknown result type (might be due to invalid IL or missing references)
		//IL_087f: Expected O, but got Unknown
		//IL_0880: Unknown result type (might be due to invalid IL or missing references)
		//IL_088a: Expected O, but got Unknown
		//IL_088b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0895: Expected O, but got Unknown
		//IL_0896: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a0: Expected O, but got Unknown
		//IL_08a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ab: Expected O, but got Unknown
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b6: Expected O, but got Unknown
		//IL_08b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c1: Expected O, but got Unknown
		//IL_08c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cc: Expected O, but got Unknown
		//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d7: Expected O, but got Unknown
		//IL_08d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e2: Expected O, but got Unknown
		//IL_08e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ed: Expected O, but got Unknown
		//IL_08ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f8: Expected O, but got Unknown
		//IL_08f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0903: Expected O, but got Unknown
		//IL_0904: Unknown result type (might be due to invalid IL or missing references)
		//IL_090e: Expected O, but got Unknown
		//IL_090f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0919: Expected O, but got Unknown
		//IL_091a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0924: Expected O, but got Unknown
		//IL_0925: Unknown result type (might be due to invalid IL or missing references)
		//IL_092f: Expected O, but got Unknown
		//IL_0930: Unknown result type (might be due to invalid IL or missing references)
		//IL_093a: Expected O, but got Unknown
		//IL_093b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0945: Expected O, but got Unknown
		//IL_094c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0956: Expected O, but got Unknown
		//IL_0957: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Expected O, but got Unknown
		//IL_0962: Unknown result type (might be due to invalid IL or missing references)
		//IL_096c: Expected O, but got Unknown
		//IL_096d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0977: Expected O, but got Unknown
		//IL_0978: Unknown result type (might be due to invalid IL or missing references)
		//IL_0982: Expected O, but got Unknown
		//IL_0983: Unknown result type (might be due to invalid IL or missing references)
		//IL_098d: Expected O, but got Unknown
		//IL_098e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0998: Expected O, but got Unknown
		//IL_0999: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a3: Expected O, but got Unknown
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ae: Expected O, but got Unknown
		//IL_09af: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b9: Expected O, but got Unknown
		//IL_09ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c4: Expected O, but got Unknown
		//IL_09c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cf: Expected O, but got Unknown
		//IL_09d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09da: Expected O, but got Unknown
		//IL_09db: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e5: Expected O, but got Unknown
		//IL_09e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f0: Expected O, but got Unknown
		//IL_09f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fb: Expected O, but got Unknown
		//IL_09fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a06: Expected O, but got Unknown
		//IL_0a07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a11: Expected O, but got Unknown
		//IL_0a12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1c: Expected O, but got Unknown
		//IL_0a1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a27: Expected O, but got Unknown
		//IL_0a28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a32: Expected O, but got Unknown
		//IL_0a33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3d: Expected O, but got Unknown
		//IL_0a3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a48: Expected O, but got Unknown
		//IL_0a49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a53: Expected O, but got Unknown
		//IL_0a54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5e: Expected O, but got Unknown
		//IL_0a5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a69: Expected O, but got Unknown
		//IL_0a6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a74: Expected O, but got Unknown
		//IL_0a75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7f: Expected O, but got Unknown
		//IL_0a80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8a: Expected O, but got Unknown
		//IL_0a8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a95: Expected O, but got Unknown
		//IL_0a96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa0: Expected O, but got Unknown
		//IL_0aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aab: Expected O, but got Unknown
		//IL_0aac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab6: Expected O, but got Unknown
		//IL_0ab7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac1: Expected O, but got Unknown
		//IL_0ac2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acc: Expected O, but got Unknown
		//IL_0acd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad7: Expected O, but got Unknown
		//IL_0ad8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae2: Expected O, but got Unknown
		//IL_0ae3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aed: Expected O, but got Unknown
		//IL_0aee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af8: Expected O, but got Unknown
		//IL_0af9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b03: Expected O, but got Unknown
		//IL_0b04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0e: Expected O, but got Unknown
		//IL_0b0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b19: Expected O, but got Unknown
		//IL_0b1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b24: Expected O, but got Unknown
		//IL_0b25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2f: Expected O, but got Unknown
		//IL_0b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3a: Expected O, but got Unknown
		//IL_0b3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b45: Expected O, but got Unknown
		//IL_0b46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b50: Expected O, but got Unknown
		//IL_0b51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5b: Expected O, but got Unknown
		//IL_0b5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b66: Expected O, but got Unknown
		//IL_0b67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b71: Expected O, but got Unknown
		//IL_0b72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7c: Expected O, but got Unknown
		//IL_0b7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b87: Expected O, but got Unknown
		//IL_0b8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b98: Expected O, but got Unknown
		//IL_0b99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba3: Expected O, but got Unknown
		//IL_0ba4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bae: Expected O, but got Unknown
		//IL_0baf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb9: Expected O, but got Unknown
		//IL_0bba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc4: Expected O, but got Unknown
		//IL_0bc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcf: Expected O, but got Unknown
		//IL_0bd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bda: Expected O, but got Unknown
		//IL_0bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be5: Expected O, but got Unknown
		//IL_0be6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf0: Expected O, but got Unknown
		//IL_0bf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfb: Expected O, but got Unknown
		//IL_0bfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c06: Expected O, but got Unknown
		//IL_0c07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c11: Expected O, but got Unknown
		//IL_0c12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1c: Expected O, but got Unknown
		//IL_0c1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c27: Expected O, but got Unknown
		//IL_0c28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c32: Expected O, but got Unknown
		//IL_0c33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3d: Expected O, but got Unknown
		//IL_0c3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c48: Expected O, but got Unknown
		//IL_0c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c53: Expected O, but got Unknown
		//IL_0c54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5e: Expected O, but got Unknown
		//IL_0c5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c69: Expected O, but got Unknown
		//IL_0c6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c74: Expected O, but got Unknown
		//IL_0c75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7f: Expected O, but got Unknown
		//IL_0c80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8a: Expected O, but got Unknown
		//IL_0c8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c95: Expected O, but got Unknown
		//IL_0c96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca0: Expected O, but got Unknown
		//IL_0ca1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cab: Expected O, but got Unknown
		//IL_0cac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb6: Expected O, but got Unknown
		//IL_0cb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc1: Expected O, but got Unknown
		//IL_0cc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccc: Expected O, but got Unknown
		//IL_0ccd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd7: Expected O, but got Unknown
		//IL_0cd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce2: Expected O, but got Unknown
		//IL_0ce3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ced: Expected O, but got Unknown
		//IL_0cee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf8: Expected O, but got Unknown
		//IL_0cf9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d03: Expected O, but got Unknown
		//IL_0d04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0e: Expected O, but got Unknown
		//IL_0d0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d19: Expected O, but got Unknown
		//IL_0d1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d24: Expected O, but got Unknown
		//IL_0d25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2f: Expected O, but got Unknown
		//IL_0d30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3a: Expected O, but got Unknown
		//IL_0d3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d45: Expected O, but got Unknown
		//IL_0d46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d50: Expected O, but got Unknown
		//IL_0d51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5b: Expected O, but got Unknown
		//IL_0d5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d66: Expected O, but got Unknown
		//IL_0d67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d71: Expected O, but got Unknown
		//IL_0d72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7c: Expected O, but got Unknown
		//IL_0d7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d87: Expected O, but got Unknown
		//IL_0d88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d92: Expected O, but got Unknown
		//IL_0d93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9d: Expected O, but got Unknown
		//IL_0d9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da8: Expected O, but got Unknown
		//IL_0da9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db3: Expected O, but got Unknown
		//IL_0db4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbe: Expected O, but got Unknown
		//IL_0dbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc9: Expected O, but got Unknown
		//IL_0dd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dda: Expected O, but got Unknown
		//IL_0ddb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de5: Expected O, but got Unknown
		//IL_0de6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df0: Expected O, but got Unknown
		//IL_0df1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfb: Expected O, but got Unknown
		//IL_0dfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e06: Expected O, but got Unknown
		//IL_0e07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e11: Expected O, but got Unknown
		//IL_0e12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1c: Expected O, but got Unknown
		//IL_0e1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e27: Expected O, but got Unknown
		//IL_0e28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e32: Expected O, but got Unknown
		//IL_0e33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3d: Expected O, but got Unknown
		//IL_0e3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e48: Expected O, but got Unknown
		//IL_0e49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e53: Expected O, but got Unknown
		//IL_0e54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5e: Expected O, but got Unknown
		//IL_0e5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e69: Expected O, but got Unknown
		//IL_0e6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e74: Expected O, but got Unknown
		//IL_0e75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7f: Expected O, but got Unknown
		//IL_0e80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8a: Expected O, but got Unknown
		//IL_0e8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e95: Expected O, but got Unknown
		//IL_0e96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea0: Expected O, but got Unknown
		//IL_0ea1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eab: Expected O, but got Unknown
		//IL_0eac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb6: Expected O, but got Unknown
		//IL_0eb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec1: Expected O, but got Unknown
		//IL_0ec2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecc: Expected O, but got Unknown
		//IL_0ecd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed7: Expected O, but got Unknown
		//IL_0ed8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee2: Expected O, but got Unknown
		//IL_0ee3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eed: Expected O, but got Unknown
		//IL_0eee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef8: Expected O, but got Unknown
		//IL_0ef9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f03: Expected O, but got Unknown
		//IL_0f04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0e: Expected O, but got Unknown
		//IL_0f0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f19: Expected O, but got Unknown
		//IL_0f1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f24: Expected O, but got Unknown
		//IL_0f25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2f: Expected O, but got Unknown
		//IL_0f30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3a: Expected O, but got Unknown
		//IL_0f3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f45: Expected O, but got Unknown
		//IL_0f46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f50: Expected O, but got Unknown
		//IL_0f51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5b: Expected O, but got Unknown
		//IL_0f5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f66: Expected O, but got Unknown
		//IL_0f67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f71: Expected O, but got Unknown
		//IL_0f72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7c: Expected O, but got Unknown
		//IL_0f7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f87: Expected O, but got Unknown
		//IL_0f88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f92: Expected O, but got Unknown
		//IL_0f93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9d: Expected O, but got Unknown
		//IL_0f9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa8: Expected O, but got Unknown
		//IL_0fa9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb3: Expected O, but got Unknown
		//IL_0fb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbe: Expected O, but got Unknown
		//IL_0fbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc9: Expected O, but got Unknown
		//IL_0fca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd4: Expected O, but got Unknown
		//IL_0fd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdf: Expected O, but got Unknown
		//IL_0fe0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fea: Expected O, but got Unknown
		//IL_0feb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff5: Expected O, but got Unknown
		//IL_0ff6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1000: Expected O, but got Unknown
		//IL_1001: Unknown result type (might be due to invalid IL or missing references)
		//IL_100b: Expected O, but got Unknown
		//IL_1012: Unknown result type (might be due to invalid IL or missing references)
		//IL_101c: Expected O, but got Unknown
		//IL_101d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1027: Expected O, but got Unknown
		//IL_1028: Unknown result type (might be due to invalid IL or missing references)
		//IL_1032: Expected O, but got Unknown
		//IL_1033: Unknown result type (might be due to invalid IL or missing references)
		//IL_103d: Expected O, but got Unknown
		//IL_103e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1048: Expected O, but got Unknown
		//IL_1049: Unknown result type (might be due to invalid IL or missing references)
		//IL_1053: Expected O, but got Unknown
		//IL_1054: Unknown result type (might be due to invalid IL or missing references)
		//IL_105e: Expected O, but got Unknown
		//IL_105f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1069: Expected O, but got Unknown
		//IL_106a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1074: Expected O, but got Unknown
		//IL_1075: Unknown result type (might be due to invalid IL or missing references)
		//IL_107f: Expected O, but got Unknown
		//IL_1080: Unknown result type (might be due to invalid IL or missing references)
		//IL_108a: Expected O, but got Unknown
		//IL_108b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1095: Expected O, but got Unknown
		//IL_1096: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a0: Expected O, but got Unknown
		//IL_10a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ab: Expected O, but got Unknown
		//IL_10ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b6: Expected O, but got Unknown
		//IL_10b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c1: Expected O, but got Unknown
		//IL_10c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cc: Expected O, but got Unknown
		//IL_10cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d7: Expected O, but got Unknown
		//IL_10d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e2: Expected O, but got Unknown
		//IL_10e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ed: Expected O, but got Unknown
		//IL_10ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f8: Expected O, but got Unknown
		//IL_10f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1103: Expected O, but got Unknown
		//IL_1104: Unknown result type (might be due to invalid IL or missing references)
		//IL_110e: Expected O, but got Unknown
		//IL_110f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1119: Expected O, but got Unknown
		//IL_111a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1124: Expected O, but got Unknown
		//IL_1125: Unknown result type (might be due to invalid IL or missing references)
		//IL_112f: Expected O, but got Unknown
		//IL_1130: Unknown result type (might be due to invalid IL or missing references)
		//IL_113a: Expected O, but got Unknown
		//IL_113b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1145: Expected O, but got Unknown
		//IL_1146: Unknown result type (might be due to invalid IL or missing references)
		//IL_1150: Expected O, but got Unknown
		//IL_1151: Unknown result type (might be due to invalid IL or missing references)
		//IL_115b: Expected O, but got Unknown
		//IL_115c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1166: Expected O, but got Unknown
		//IL_1167: Unknown result type (might be due to invalid IL or missing references)
		//IL_1171: Expected O, but got Unknown
		//IL_1172: Unknown result type (might be due to invalid IL or missing references)
		//IL_117c: Expected O, but got Unknown
		//IL_117d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1187: Expected O, but got Unknown
		//IL_1188: Unknown result type (might be due to invalid IL or missing references)
		//IL_1192: Expected O, but got Unknown
		//IL_1193: Unknown result type (might be due to invalid IL or missing references)
		//IL_119d: Expected O, but got Unknown
		//IL_119e: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a8: Expected O, but got Unknown
		//IL_11a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b3: Expected O, but got Unknown
		//IL_11b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11be: Expected O, but got Unknown
		//IL_11bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c9: Expected O, but got Unknown
		//IL_11ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d4: Expected O, but got Unknown
		//IL_11d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11df: Expected O, but got Unknown
		//IL_11e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ea: Expected O, but got Unknown
		//IL_11eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f5: Expected O, but got Unknown
		//IL_11f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1200: Expected O, but got Unknown
		//IL_1201: Unknown result type (might be due to invalid IL or missing references)
		//IL_120b: Expected O, but got Unknown
		//IL_120c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1216: Expected O, but got Unknown
		//IL_1217: Unknown result type (might be due to invalid IL or missing references)
		//IL_1221: Expected O, but got Unknown
		//IL_1222: Unknown result type (might be due to invalid IL or missing references)
		//IL_122c: Expected O, but got Unknown
		//IL_122d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1237: Expected O, but got Unknown
		//IL_1238: Unknown result type (might be due to invalid IL or missing references)
		//IL_1242: Expected O, but got Unknown
		//IL_1243: Unknown result type (might be due to invalid IL or missing references)
		//IL_124d: Expected O, but got Unknown
		//IL_1254: Unknown result type (might be due to invalid IL or missing references)
		//IL_125e: Expected O, but got Unknown
		//IL_125f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1269: Expected O, but got Unknown
		//IL_126a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1274: Expected O, but got Unknown
		//IL_1275: Unknown result type (might be due to invalid IL or missing references)
		//IL_127f: Expected O, but got Unknown
		//IL_1280: Unknown result type (might be due to invalid IL or missing references)
		//IL_128a: Expected O, but got Unknown
		//IL_128b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1295: Expected O, but got Unknown
		//IL_1296: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a0: Expected O, but got Unknown
		//IL_12a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ab: Expected O, but got Unknown
		//IL_12ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b6: Expected O, but got Unknown
		//IL_12b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c1: Expected O, but got Unknown
		//IL_12c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12cc: Expected O, but got Unknown
		//IL_12cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d7: Expected O, but got Unknown
		//IL_12d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e2: Expected O, but got Unknown
		//IL_12e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ed: Expected O, but got Unknown
		//IL_12ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f8: Expected O, but got Unknown
		//IL_12f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1303: Expected O, but got Unknown
		//IL_1304: Unknown result type (might be due to invalid IL or missing references)
		//IL_130e: Expected O, but got Unknown
		//IL_130f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1319: Expected O, but got Unknown
		//IL_131a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1324: Expected O, but got Unknown
		//IL_1325: Unknown result type (might be due to invalid IL or missing references)
		//IL_132f: Expected O, but got Unknown
		//IL_1330: Unknown result type (might be due to invalid IL or missing references)
		//IL_133a: Expected O, but got Unknown
		//IL_133b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1345: Expected O, but got Unknown
		//IL_1346: Unknown result type (might be due to invalid IL or missing references)
		//IL_1350: Expected O, but got Unknown
		//IL_1351: Unknown result type (might be due to invalid IL or missing references)
		//IL_135b: Expected O, but got Unknown
		//IL_135c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1366: Expected O, but got Unknown
		//IL_1367: Unknown result type (might be due to invalid IL or missing references)
		//IL_1371: Expected O, but got Unknown
		//IL_1372: Unknown result type (might be due to invalid IL or missing references)
		//IL_137c: Expected O, but got Unknown
		//IL_137d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1387: Expected O, but got Unknown
		//IL_1388: Unknown result type (might be due to invalid IL or missing references)
		//IL_1392: Expected O, but got Unknown
		//IL_1393: Unknown result type (might be due to invalid IL or missing references)
		//IL_139d: Expected O, but got Unknown
		//IL_139e: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a8: Expected O, but got Unknown
		//IL_13a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b3: Expected O, but got Unknown
		//IL_13b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_13be: Expected O, but got Unknown
		//IL_13bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c9: Expected O, but got Unknown
		//IL_13ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d4: Expected O, but got Unknown
		//IL_13d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_13df: Expected O, but got Unknown
		//IL_13e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ea: Expected O, but got Unknown
		//IL_13eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Expected O, but got Unknown
		//IL_13f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1400: Expected O, but got Unknown
		//IL_1401: Unknown result type (might be due to invalid IL or missing references)
		//IL_140b: Expected O, but got Unknown
		//IL_140c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1416: Expected O, but got Unknown
		//IL_1417: Unknown result type (might be due to invalid IL or missing references)
		//IL_1421: Expected O, but got Unknown
		//IL_1422: Unknown result type (might be due to invalid IL or missing references)
		//IL_142c: Expected O, but got Unknown
		//IL_142d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1437: Expected O, but got Unknown
		//IL_1438: Unknown result type (might be due to invalid IL or missing references)
		//IL_1442: Expected O, but got Unknown
		//IL_1443: Unknown result type (might be due to invalid IL or missing references)
		//IL_144d: Expected O, but got Unknown
		//IL_144e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1458: Expected O, but got Unknown
		//IL_1459: Unknown result type (might be due to invalid IL or missing references)
		//IL_1463: Expected O, but got Unknown
		//IL_1464: Unknown result type (might be due to invalid IL or missing references)
		//IL_146e: Expected O, but got Unknown
		//IL_146f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1479: Expected O, but got Unknown
		//IL_147a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1484: Expected O, but got Unknown
		//IL_1485: Unknown result type (might be due to invalid IL or missing references)
		//IL_148f: Expected O, but got Unknown
		//IL_1496: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a0: Expected O, but got Unknown
		//IL_14a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ab: Expected O, but got Unknown
		//IL_14ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b6: Expected O, but got Unknown
		//IL_14b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c1: Expected O, but got Unknown
		//IL_14c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_14cc: Expected O, but got Unknown
		//IL_14cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d7: Expected O, but got Unknown
		//IL_14d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e2: Expected O, but got Unknown
		//IL_14e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ed: Expected O, but got Unknown
		//IL_14ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f8: Expected O, but got Unknown
		//IL_14f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1503: Expected O, but got Unknown
		//IL_1504: Unknown result type (might be due to invalid IL or missing references)
		//IL_150e: Expected O, but got Unknown
		//IL_150f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1519: Expected O, but got Unknown
		//IL_151a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1524: Expected O, but got Unknown
		//IL_1525: Unknown result type (might be due to invalid IL or missing references)
		//IL_152f: Expected O, but got Unknown
		//IL_1530: Unknown result type (might be due to invalid IL or missing references)
		//IL_153a: Expected O, but got Unknown
		//IL_153b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1545: Expected O, but got Unknown
		//IL_1546: Unknown result type (might be due to invalid IL or missing references)
		//IL_1550: Expected O, but got Unknown
		//IL_1551: Unknown result type (might be due to invalid IL or missing references)
		//IL_155b: Expected O, but got Unknown
		//IL_155c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1566: Expected O, but got Unknown
		//IL_1567: Unknown result type (might be due to invalid IL or missing references)
		//IL_1571: Expected O, but got Unknown
		//IL_1572: Unknown result type (might be due to invalid IL or missing references)
		//IL_157c: Expected O, but got Unknown
		//IL_157d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1587: Expected O, but got Unknown
		//IL_1588: Unknown result type (might be due to invalid IL or missing references)
		//IL_1592: Expected O, but got Unknown
		//IL_1593: Unknown result type (might be due to invalid IL or missing references)
		//IL_159d: Expected O, but got Unknown
		//IL_159e: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a8: Expected O, but got Unknown
		//IL_15a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b3: Expected O, but got Unknown
		//IL_15b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_15be: Expected O, but got Unknown
		//IL_15bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c9: Expected O, but got Unknown
		//IL_15ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d4: Expected O, but got Unknown
		//IL_15d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_15df: Expected O, but got Unknown
		//IL_15e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ea: Expected O, but got Unknown
		//IL_15eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f5: Expected O, but got Unknown
		//IL_15f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1600: Expected O, but got Unknown
		//IL_1601: Unknown result type (might be due to invalid IL or missing references)
		//IL_160b: Expected O, but got Unknown
		//IL_160c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1616: Expected O, but got Unknown
		//IL_1617: Unknown result type (might be due to invalid IL or missing references)
		//IL_1621: Expected O, but got Unknown
		//IL_1622: Unknown result type (might be due to invalid IL or missing references)
		//IL_162c: Expected O, but got Unknown
		//IL_162d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1637: Expected O, but got Unknown
		//IL_1638: Unknown result type (might be due to invalid IL or missing references)
		//IL_1642: Expected O, but got Unknown
		//IL_1643: Unknown result type (might be due to invalid IL or missing references)
		//IL_164d: Expected O, but got Unknown
		//IL_164e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1658: Expected O, but got Unknown
		//IL_1659: Unknown result type (might be due to invalid IL or missing references)
		//IL_1663: Expected O, but got Unknown
		//IL_1664: Unknown result type (might be due to invalid IL or missing references)
		//IL_166e: Expected O, but got Unknown
		//IL_166f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1679: Expected O, but got Unknown
		//IL_167a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1684: Expected O, but got Unknown
		//IL_1685: Unknown result type (might be due to invalid IL or missing references)
		//IL_168f: Expected O, but got Unknown
		//IL_1690: Unknown result type (might be due to invalid IL or missing references)
		//IL_169a: Expected O, but got Unknown
		//IL_169b: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a5: Expected O, but got Unknown
		//IL_16a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b0: Expected O, but got Unknown
		//IL_16b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_16bb: Expected O, but got Unknown
		//IL_16bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c6: Expected O, but got Unknown
		//IL_16c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d1: Expected O, but got Unknown
		//IL_16d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e2: Expected O, but got Unknown
		//IL_16e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ed: Expected O, but got Unknown
		//IL_16ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f8: Expected O, but got Unknown
		//IL_16f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1703: Expected O, but got Unknown
		//IL_1704: Unknown result type (might be due to invalid IL or missing references)
		//IL_170e: Expected O, but got Unknown
		//IL_170f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1719: Expected O, but got Unknown
		//IL_171a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1724: Expected O, but got Unknown
		//IL_1725: Unknown result type (might be due to invalid IL or missing references)
		//IL_172f: Expected O, but got Unknown
		//IL_1730: Unknown result type (might be due to invalid IL or missing references)
		//IL_173a: Expected O, but got Unknown
		//IL_173b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1745: Expected O, but got Unknown
		//IL_1746: Unknown result type (might be due to invalid IL or missing references)
		//IL_1750: Expected O, but got Unknown
		//IL_1751: Unknown result type (might be due to invalid IL or missing references)
		//IL_175b: Expected O, but got Unknown
		//IL_175c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1766: Expected O, but got Unknown
		//IL_1767: Unknown result type (might be due to invalid IL or missing references)
		//IL_1771: Expected O, but got Unknown
		//IL_1772: Unknown result type (might be due to invalid IL or missing references)
		//IL_177c: Expected O, but got Unknown
		//IL_177d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1787: Expected O, but got Unknown
		//IL_1788: Unknown result type (might be due to invalid IL or missing references)
		//IL_1792: Expected O, but got Unknown
		//IL_1793: Unknown result type (might be due to invalid IL or missing references)
		//IL_179d: Expected O, but got Unknown
		//IL_179e: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a8: Expected O, but got Unknown
		//IL_17a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b3: Expected O, but got Unknown
		//IL_17b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_17be: Expected O, but got Unknown
		//IL_17bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c9: Expected O, but got Unknown
		//IL_17ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d4: Expected O, but got Unknown
		//IL_17d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_17df: Expected O, but got Unknown
		//IL_17e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ea: Expected O, but got Unknown
		//IL_17eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_17f5: Expected O, but got Unknown
		//IL_17f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1800: Expected O, but got Unknown
		//IL_1801: Unknown result type (might be due to invalid IL or missing references)
		//IL_180b: Expected O, but got Unknown
		//IL_180c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1816: Expected O, but got Unknown
		//IL_1817: Unknown result type (might be due to invalid IL or missing references)
		//IL_1821: Expected O, but got Unknown
		//IL_1822: Unknown result type (might be due to invalid IL or missing references)
		//IL_182c: Expected O, but got Unknown
		//IL_182d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1837: Expected O, but got Unknown
		//IL_1838: Unknown result type (might be due to invalid IL or missing references)
		//IL_1842: Expected O, but got Unknown
		//IL_1843: Unknown result type (might be due to invalid IL or missing references)
		//IL_184d: Expected O, but got Unknown
		//IL_184e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1858: Expected O, but got Unknown
		//IL_1859: Unknown result type (might be due to invalid IL or missing references)
		//IL_1863: Expected O, but got Unknown
		//IL_1864: Unknown result type (might be due to invalid IL or missing references)
		//IL_186e: Expected O, but got Unknown
		//IL_186f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1879: Expected O, but got Unknown
		//IL_187a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1884: Expected O, but got Unknown
		//IL_1885: Unknown result type (might be due to invalid IL or missing references)
		//IL_188f: Expected O, but got Unknown
		//IL_1890: Unknown result type (might be due to invalid IL or missing references)
		//IL_189a: Expected O, but got Unknown
		//IL_189b: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a5: Expected O, but got Unknown
		//IL_18a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b0: Expected O, but got Unknown
		//IL_18b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_18bb: Expected O, but got Unknown
		//IL_18bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c6: Expected O, but got Unknown
		//IL_18c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d1: Expected O, but got Unknown
		//IL_18d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_18dc: Expected O, but got Unknown
		//IL_18dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_18e7: Expected O, but got Unknown
		//IL_18e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f2: Expected O, but got Unknown
		//IL_18f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_18fd: Expected O, but got Unknown
		//IL_18fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1908: Expected O, but got Unknown
		//IL_1909: Unknown result type (might be due to invalid IL or missing references)
		//IL_1913: Expected O, but got Unknown
		//IL_191a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1924: Expected O, but got Unknown
		//IL_1925: Unknown result type (might be due to invalid IL or missing references)
		//IL_192f: Expected O, but got Unknown
		//IL_1930: Unknown result type (might be due to invalid IL or missing references)
		//IL_193a: Expected O, but got Unknown
		//IL_193b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1945: Expected O, but got Unknown
		//IL_1946: Unknown result type (might be due to invalid IL or missing references)
		//IL_1950: Expected O, but got Unknown
		//IL_1951: Unknown result type (might be due to invalid IL or missing references)
		//IL_195b: Expected O, but got Unknown
		//IL_195c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1966: Expected O, but got Unknown
		//IL_1967: Unknown result type (might be due to invalid IL or missing references)
		//IL_1971: Expected O, but got Unknown
		//IL_1972: Unknown result type (might be due to invalid IL or missing references)
		//IL_197c: Expected O, but got Unknown
		//IL_197d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1987: Expected O, but got Unknown
		//IL_1988: Unknown result type (might be due to invalid IL or missing references)
		//IL_1992: Expected O, but got Unknown
		//IL_1993: Unknown result type (might be due to invalid IL or missing references)
		//IL_199d: Expected O, but got Unknown
		//IL_199e: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a8: Expected O, but got Unknown
		//IL_19a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b3: Expected O, but got Unknown
		//IL_19b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_19be: Expected O, but got Unknown
		//IL_19bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c9: Expected O, but got Unknown
		//IL_19ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d4: Expected O, but got Unknown
		//IL_19d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_19df: Expected O, but got Unknown
		//IL_19e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ea: Expected O, but got Unknown
		//IL_19eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f5: Expected O, but got Unknown
		//IL_19f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a00: Expected O, but got Unknown
		//IL_1a01: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a0b: Expected O, but got Unknown
		//IL_1a0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a16: Expected O, but got Unknown
		//IL_1a17: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a21: Expected O, but got Unknown
		//IL_1a22: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a2c: Expected O, but got Unknown
		//IL_1a2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a37: Expected O, but got Unknown
		//IL_1a38: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a42: Expected O, but got Unknown
		//IL_1a43: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a4d: Expected O, but got Unknown
		//IL_1a4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a58: Expected O, but got Unknown
		//IL_1a59: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a63: Expected O, but got Unknown
		//IL_1a64: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a6e: Expected O, but got Unknown
		//IL_1a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a79: Expected O, but got Unknown
		//IL_1a7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a84: Expected O, but got Unknown
		//IL_1a85: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a8f: Expected O, but got Unknown
		//IL_1a90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a9a: Expected O, but got Unknown
		//IL_1a9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa5: Expected O, but got Unknown
		//IL_1aa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab0: Expected O, but got Unknown
		//IL_1ab1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1abb: Expected O, but got Unknown
		//IL_1abc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac6: Expected O, but got Unknown
		//IL_1ac7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad1: Expected O, but got Unknown
		//IL_1ad2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1adc: Expected O, but got Unknown
		//IL_1add: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ae7: Expected O, but got Unknown
		//IL_1ae8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1af2: Expected O, but got Unknown
		//IL_1af3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1afd: Expected O, but got Unknown
		//IL_1afe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b08: Expected O, but got Unknown
		//IL_1b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b13: Expected O, but got Unknown
		//IL_1b14: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b1e: Expected O, but got Unknown
		//IL_1b1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b29: Expected O, but got Unknown
		//IL_1b2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b34: Expected O, but got Unknown
		//IL_1b35: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b3f: Expected O, but got Unknown
		//IL_1b40: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b4a: Expected O, but got Unknown
		//IL_1b4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b55: Expected O, but got Unknown
		//IL_1b5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b66: Expected O, but got Unknown
		//IL_1b67: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b71: Expected O, but got Unknown
		//IL_1b72: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b7c: Expected O, but got Unknown
		//IL_1b7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b87: Expected O, but got Unknown
		//IL_1b88: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b92: Expected O, but got Unknown
		//IL_1b93: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b9d: Expected O, but got Unknown
		//IL_1b9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba8: Expected O, but got Unknown
		//IL_1ba9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb3: Expected O, but got Unknown
		//IL_1bb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bbe: Expected O, but got Unknown
		//IL_1bbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc9: Expected O, but got Unknown
		//IL_1bca: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bd4: Expected O, but got Unknown
		//IL_1bd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bdf: Expected O, but got Unknown
		//IL_1be0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bea: Expected O, but got Unknown
		//IL_1beb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf5: Expected O, but got Unknown
		//IL_1bf6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c00: Expected O, but got Unknown
		//IL_1c01: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c0b: Expected O, but got Unknown
		//IL_1c0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c16: Expected O, but got Unknown
		//IL_1c17: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c21: Expected O, but got Unknown
		//IL_1c22: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c2c: Expected O, but got Unknown
		//IL_1c2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c37: Expected O, but got Unknown
		//IL_1c38: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c42: Expected O, but got Unknown
		//IL_1c43: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c4d: Expected O, but got Unknown
		//IL_1c4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c58: Expected O, but got Unknown
		//IL_1c59: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c63: Expected O, but got Unknown
		//IL_1c64: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c6e: Expected O, but got Unknown
		//IL_1c6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c79: Expected O, but got Unknown
		//IL_1c7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c84: Expected O, but got Unknown
		//IL_1c85: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c8f: Expected O, but got Unknown
		//IL_1c90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c9a: Expected O, but got Unknown
		//IL_1c9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca5: Expected O, but got Unknown
		//IL_1ca6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb0: Expected O, but got Unknown
		//IL_1cb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cbb: Expected O, but got Unknown
		//IL_1cbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc6: Expected O, but got Unknown
		//IL_1cc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cd1: Expected O, but got Unknown
		//IL_1cd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cdc: Expected O, but got Unknown
		//IL_1cdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce7: Expected O, but got Unknown
		//IL_1ce8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf2: Expected O, but got Unknown
		//IL_1cf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cfd: Expected O, but got Unknown
		//IL_1cfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d08: Expected O, but got Unknown
		//IL_1d09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d13: Expected O, but got Unknown
		//IL_1d14: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d1e: Expected O, but got Unknown
		//IL_1d1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d29: Expected O, but got Unknown
		//IL_1d2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d34: Expected O, but got Unknown
		//IL_1d35: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d3f: Expected O, but got Unknown
		//IL_1d40: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d4a: Expected O, but got Unknown
		//IL_1d4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d55: Expected O, but got Unknown
		//IL_1d56: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d60: Expected O, but got Unknown
		//IL_1d61: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d6b: Expected O, but got Unknown
		//IL_1d6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d76: Expected O, but got Unknown
		//IL_1d77: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d81: Expected O, but got Unknown
		//IL_1d82: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d8c: Expected O, but got Unknown
		//IL_1d8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d97: Expected O, but got Unknown
		//IL_1d9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da8: Expected O, but got Unknown
		//IL_1da9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1db3: Expected O, but got Unknown
		//IL_1db4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dbe: Expected O, but got Unknown
		//IL_1dbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc9: Expected O, but got Unknown
		//IL_1dca: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd4: Expected O, but got Unknown
		//IL_1dd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ddf: Expected O, but got Unknown
		//IL_1de0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dea: Expected O, but got Unknown
		//IL_1deb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df5: Expected O, but got Unknown
		//IL_1df6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e00: Expected O, but got Unknown
		//IL_1e01: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e0b: Expected O, but got Unknown
		//IL_1e0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e16: Expected O, but got Unknown
		//IL_1e17: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e21: Expected O, but got Unknown
		//IL_1e22: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e2c: Expected O, but got Unknown
		//IL_1e2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e37: Expected O, but got Unknown
		//IL_1e38: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e42: Expected O, but got Unknown
		//IL_1e43: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e4d: Expected O, but got Unknown
		//IL_1e4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e58: Expected O, but got Unknown
		//IL_1e59: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e63: Expected O, but got Unknown
		//IL_1e64: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e6e: Expected O, but got Unknown
		//IL_1e6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e79: Expected O, but got Unknown
		//IL_1e7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e84: Expected O, but got Unknown
		//IL_1e85: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e8f: Expected O, but got Unknown
		//IL_1e90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e9a: Expected O, but got Unknown
		//IL_1e9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea5: Expected O, but got Unknown
		//IL_1ea6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eb0: Expected O, but got Unknown
		//IL_1eb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ebb: Expected O, but got Unknown
		//IL_1ebc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ec6: Expected O, but got Unknown
		//IL_1ec7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ed1: Expected O, but got Unknown
		//IL_1ed2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1edc: Expected O, but got Unknown
		//IL_1edd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee7: Expected O, but got Unknown
		//IL_1ee8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ef2: Expected O, but got Unknown
		//IL_1ef3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1efd: Expected O, but got Unknown
		//IL_1efe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f08: Expected O, but got Unknown
		//IL_1f09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f13: Expected O, but got Unknown
		//IL_1f14: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f1e: Expected O, but got Unknown
		//IL_1f1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f29: Expected O, but got Unknown
		//IL_1f2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f34: Expected O, but got Unknown
		//IL_1f35: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f3f: Expected O, but got Unknown
		//IL_1f40: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f4a: Expected O, but got Unknown
		//IL_1f4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f55: Expected O, but got Unknown
		//IL_1f56: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f60: Expected O, but got Unknown
		//IL_1f61: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f6b: Expected O, but got Unknown
		//IL_1f6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f76: Expected O, but got Unknown
		//IL_1f77: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f81: Expected O, but got Unknown
		//IL_1f82: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f8c: Expected O, but got Unknown
		//IL_1f8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f97: Expected O, but got Unknown
		//IL_1f98: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fa2: Expected O, but got Unknown
		//IL_1fa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fad: Expected O, but got Unknown
		//IL_1fae: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fb8: Expected O, but got Unknown
		//IL_1fb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fc3: Expected O, but got Unknown
		//IL_1fc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fce: Expected O, but got Unknown
		//IL_1fcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fd9: Expected O, but got Unknown
		//IL_1fe0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fea: Expected O, but got Unknown
		//IL_1feb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ff5: Expected O, but got Unknown
		//IL_1ff6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2000: Expected O, but got Unknown
		//IL_2001: Unknown result type (might be due to invalid IL or missing references)
		//IL_200b: Expected O, but got Unknown
		//IL_200c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2016: Expected O, but got Unknown
		//IL_2017: Unknown result type (might be due to invalid IL or missing references)
		//IL_2021: Expected O, but got Unknown
		//IL_2022: Unknown result type (might be due to invalid IL or missing references)
		//IL_202c: Expected O, but got Unknown
		//IL_202d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2037: Expected O, but got Unknown
		//IL_2038: Unknown result type (might be due to invalid IL or missing references)
		//IL_2042: Expected O, but got Unknown
		//IL_2043: Unknown result type (might be due to invalid IL or missing references)
		//IL_204d: Expected O, but got Unknown
		//IL_204e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2058: Expected O, but got Unknown
		//IL_2059: Unknown result type (might be due to invalid IL or missing references)
		//IL_2063: Expected O, but got Unknown
		//IL_2064: Unknown result type (might be due to invalid IL or missing references)
		//IL_206e: Expected O, but got Unknown
		//IL_206f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2079: Expected O, but got Unknown
		//IL_207a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2084: Expected O, but got Unknown
		//IL_2085: Unknown result type (might be due to invalid IL or missing references)
		//IL_208f: Expected O, but got Unknown
		//IL_2090: Unknown result type (might be due to invalid IL or missing references)
		//IL_209a: Expected O, but got Unknown
		//IL_209b: Unknown result type (might be due to invalid IL or missing references)
		//IL_20a5: Expected O, but got Unknown
		//IL_20a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_20b0: Expected O, but got Unknown
		//IL_20b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_20bb: Expected O, but got Unknown
		//IL_20bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_20c6: Expected O, but got Unknown
		//IL_20c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_20d1: Expected O, but got Unknown
		//IL_20d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_20dc: Expected O, but got Unknown
		//IL_20dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_20e7: Expected O, but got Unknown
		//IL_20e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_20f2: Expected O, but got Unknown
		//IL_20f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_20fd: Expected O, but got Unknown
		//IL_20fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2108: Expected O, but got Unknown
		//IL_2109: Unknown result type (might be due to invalid IL or missing references)
		//IL_2113: Expected O, but got Unknown
		//IL_2114: Unknown result type (might be due to invalid IL or missing references)
		//IL_211e: Expected O, but got Unknown
		//IL_211f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2129: Expected O, but got Unknown
		//IL_212a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2134: Expected O, but got Unknown
		//IL_2135: Unknown result type (might be due to invalid IL or missing references)
		//IL_213f: Expected O, but got Unknown
		//IL_2140: Unknown result type (might be due to invalid IL or missing references)
		//IL_214a: Expected O, but got Unknown
		//IL_214b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2155: Expected O, but got Unknown
		//IL_2156: Unknown result type (might be due to invalid IL or missing references)
		//IL_2160: Expected O, but got Unknown
		//IL_2161: Unknown result type (might be due to invalid IL or missing references)
		//IL_216b: Expected O, but got Unknown
		//IL_216c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2176: Expected O, but got Unknown
		//IL_2177: Unknown result type (might be due to invalid IL or missing references)
		//IL_2181: Expected O, but got Unknown
		//IL_2182: Unknown result type (might be due to invalid IL or missing references)
		//IL_218c: Expected O, but got Unknown
		//IL_218d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2197: Expected O, but got Unknown
		//IL_2198: Unknown result type (might be due to invalid IL or missing references)
		//IL_21a2: Expected O, but got Unknown
		//IL_21a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ad: Expected O, but got Unknown
		//IL_21ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b8: Expected O, but got Unknown
		//IL_21b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_21c3: Expected O, but got Unknown
		//IL_21c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ce: Expected O, but got Unknown
		//IL_21cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_21d9: Expected O, but got Unknown
		//IL_21da: Unknown result type (might be due to invalid IL or missing references)
		//IL_21e4: Expected O, but got Unknown
		//IL_21e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ef: Expected O, but got Unknown
		//IL_21f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_21fa: Expected O, but got Unknown
		//IL_21fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2205: Expected O, but got Unknown
		//IL_2206: Unknown result type (might be due to invalid IL or missing references)
		//IL_2210: Expected O, but got Unknown
		//IL_2211: Unknown result type (might be due to invalid IL or missing references)
		//IL_221b: Expected O, but got Unknown
		//IL_2222: Unknown result type (might be due to invalid IL or missing references)
		//IL_222c: Expected O, but got Unknown
		//IL_222d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2237: Expected O, but got Unknown
		//IL_2238: Unknown result type (might be due to invalid IL or missing references)
		//IL_2242: Expected O, but got Unknown
		//IL_2243: Unknown result type (might be due to invalid IL or missing references)
		//IL_224d: Expected O, but got Unknown
		//IL_224e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2258: Expected O, but got Unknown
		//IL_2259: Unknown result type (might be due to invalid IL or missing references)
		//IL_2263: Expected O, but got Unknown
		//IL_2264: Unknown result type (might be due to invalid IL or missing references)
		//IL_226e: Expected O, but got Unknown
		//IL_226f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2279: Expected O, but got Unknown
		//IL_227a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2284: Expected O, but got Unknown
		//IL_2285: Unknown result type (might be due to invalid IL or missing references)
		//IL_228f: Expected O, but got Unknown
		//IL_2290: Unknown result type (might be due to invalid IL or missing references)
		//IL_229a: Expected O, but got Unknown
		//IL_229b: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a5: Expected O, but got Unknown
		//IL_22a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_22b0: Expected O, but got Unknown
		//IL_22b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_22bb: Expected O, but got Unknown
		//IL_22bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_22c6: Expected O, but got Unknown
		//IL_22c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_22d1: Expected O, but got Unknown
		//IL_22d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_22dc: Expected O, but got Unknown
		//IL_22dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_22e7: Expected O, but got Unknown
		//IL_22e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_22f2: Expected O, but got Unknown
		//IL_22f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_22fd: Expected O, but got Unknown
		//IL_22fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2308: Expected O, but got Unknown
		//IL_2309: Unknown result type (might be due to invalid IL or missing references)
		//IL_2313: Expected O, but got Unknown
		//IL_2314: Unknown result type (might be due to invalid IL or missing references)
		//IL_231e: Expected O, but got Unknown
		//IL_231f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2329: Expected O, but got Unknown
		//IL_232a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2334: Expected O, but got Unknown
		//IL_2335: Unknown result type (might be due to invalid IL or missing references)
		//IL_233f: Expected O, but got Unknown
		//IL_2340: Unknown result type (might be due to invalid IL or missing references)
		//IL_234a: Expected O, but got Unknown
		//IL_234b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2355: Expected O, but got Unknown
		//IL_2356: Unknown result type (might be due to invalid IL or missing references)
		//IL_2360: Expected O, but got Unknown
		//IL_2361: Unknown result type (might be due to invalid IL or missing references)
		//IL_236b: Expected O, but got Unknown
		//IL_236c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2376: Expected O, but got Unknown
		//IL_2377: Unknown result type (might be due to invalid IL or missing references)
		//IL_2381: Expected O, but got Unknown
		//IL_2382: Unknown result type (might be due to invalid IL or missing references)
		//IL_238c: Expected O, but got Unknown
		//IL_238d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2397: Expected O, but got Unknown
		//IL_2398: Unknown result type (might be due to invalid IL or missing references)
		//IL_23a2: Expected O, but got Unknown
		//IL_23a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_23ad: Expected O, but got Unknown
		//IL_23ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_23b8: Expected O, but got Unknown
		//IL_23b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c3: Expected O, but got Unknown
		//IL_23c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_23ce: Expected O, but got Unknown
		//IL_23cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_23d9: Expected O, but got Unknown
		//IL_23da: Unknown result type (might be due to invalid IL or missing references)
		//IL_23e4: Expected O, but got Unknown
		//IL_23e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_23ef: Expected O, but got Unknown
		//IL_23f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_23fa: Expected O, but got Unknown
		//IL_23fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2405: Expected O, but got Unknown
		//IL_2406: Unknown result type (might be due to invalid IL or missing references)
		//IL_2410: Expected O, but got Unknown
		//IL_2411: Unknown result type (might be due to invalid IL or missing references)
		//IL_241b: Expected O, but got Unknown
		//IL_241c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2426: Expected O, but got Unknown
		//IL_2427: Unknown result type (might be due to invalid IL or missing references)
		//IL_2431: Expected O, but got Unknown
		//IL_2432: Unknown result type (might be due to invalid IL or missing references)
		//IL_243c: Expected O, but got Unknown
		//IL_243d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2447: Expected O, but got Unknown
		//IL_2448: Unknown result type (might be due to invalid IL or missing references)
		//IL_2452: Expected O, but got Unknown
		//IL_2453: Unknown result type (might be due to invalid IL or missing references)
		//IL_245d: Expected O, but got Unknown
		//IL_2464: Unknown result type (might be due to invalid IL or missing references)
		//IL_246e: Expected O, but got Unknown
		//IL_27c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_27d1: Expected O, but got Unknown
		//IL_28ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_28f7: Expected O, but got Unknown
		//IL_296c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2976: Expected O, but got Unknown
		//IL_2a1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a28: Expected O, but got Unknown
		//IL_2b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b13: Expected O, but got Unknown
		//IL_2e04: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e0e: Expected O, but got Unknown
		//IL_2e7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e84: Expected O, but got Unknown
		//IL_2f1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f24: Expected O, but got Unknown
		//IL_2ff5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fff: Expected O, but got Unknown
		//IL_306b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3075: Expected O, but got Unknown
		//IL_31ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_31d8: Expected O, but got Unknown
		//IL_3244: Unknown result type (might be due to invalid IL or missing references)
		//IL_324e: Expected O, but got Unknown
		//IL_32e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_32ee: Expected O, but got Unknown
		//IL_335a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3364: Expected O, but got Unknown
		//IL_33d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_33da: Expected O, but got Unknown
		//IL_3778: Unknown result type (might be due to invalid IL or missing references)
		//IL_3782: Expected O, but got Unknown
		//IL_37de: Unknown result type (might be due to invalid IL or missing references)
		//IL_37e8: Expected O, but got Unknown
		//IL_4096: Unknown result type (might be due to invalid IL or missing references)
		//IL_40a0: Expected O, but got Unknown
		//IL_410c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4116: Expected O, but got Unknown
		//IL_41ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_41b6: Expected O, but got Unknown
		//IL_4287: Unknown result type (might be due to invalid IL or missing references)
		//IL_4291: Expected O, but got Unknown
		//IL_42fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_4307: Expected O, but got Unknown
		//IL_449b: Unknown result type (might be due to invalid IL or missing references)
		//IL_44a5: Expected O, but got Unknown
		//IL_4511: Unknown result type (might be due to invalid IL or missing references)
		//IL_451b: Expected O, but got Unknown
		//IL_45b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_45bb: Expected O, but got Unknown
		//IL_4627: Unknown result type (might be due to invalid IL or missing references)
		//IL_4631: Expected O, but got Unknown
		//IL_469d: Unknown result type (might be due to invalid IL or missing references)
		//IL_46a7: Expected O, but got Unknown
		//IL_4be9: Unknown result type (might be due to invalid IL or missing references)
		//IL_4bf3: Expected O, but got Unknown
		//IL_4c4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c59: Expected O, but got Unknown
		//IL_4e9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ea8: Expected O, but got Unknown
		//IL_4f0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f17: Expected O, but got Unknown
		//IL_4f7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f86: Expected O, but got Unknown
		//IL_5012: Unknown result type (might be due to invalid IL or missing references)
		//IL_501c: Expected O, but got Unknown
		//IL_5081: Unknown result type (might be due to invalid IL or missing references)
		//IL_508b: Expected O, but got Unknown
		//IL_5117: Unknown result type (might be due to invalid IL or missing references)
		//IL_5121: Expected O, but got Unknown
		//IL_52fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_5306: Expected O, but got Unknown
		//IL_5372: Unknown result type (might be due to invalid IL or missing references)
		//IL_537c: Expected O, but got Unknown
		//IL_5412: Unknown result type (might be due to invalid IL or missing references)
		//IL_541c: Expected O, but got Unknown
		//IL_54ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_54f7: Expected O, but got Unknown
		//IL_5563: Unknown result type (might be due to invalid IL or missing references)
		//IL_556d: Expected O, but got Unknown
		//IL_5701: Unknown result type (might be due to invalid IL or missing references)
		//IL_570b: Expected O, but got Unknown
		//IL_5777: Unknown result type (might be due to invalid IL or missing references)
		//IL_5781: Expected O, but got Unknown
		//IL_5817: Unknown result type (might be due to invalid IL or missing references)
		//IL_5821: Expected O, but got Unknown
		//IL_588d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5897: Expected O, but got Unknown
		//IL_5903: Unknown result type (might be due to invalid IL or missing references)
		//IL_590d: Expected O, but got Unknown
		//IL_5e4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e59: Expected O, but got Unknown
		//IL_5eb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ebf: Expected O, but got Unknown
		//IL_6103: Unknown result type (might be due to invalid IL or missing references)
		//IL_610d: Expected O, but got Unknown
		//IL_6172: Unknown result type (might be due to invalid IL or missing references)
		//IL_617c: Expected O, but got Unknown
		//IL_61e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_61eb: Expected O, but got Unknown
		//IL_6277: Unknown result type (might be due to invalid IL or missing references)
		//IL_6281: Expected O, but got Unknown
		//IL_62e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_62f0: Expected O, but got Unknown
		//IL_637c: Unknown result type (might be due to invalid IL or missing references)
		//IL_6386: Expected O, but got Unknown
		//IL_64f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_6502: Expected O, but got Unknown
		//IL_6565: Unknown result type (might be due to invalid IL or missing references)
		//IL_656f: Expected O, but got Unknown
		//IL_6755: Unknown result type (might be due to invalid IL or missing references)
		//IL_675f: Expected O, but got Unknown
		//IL_67cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_67d5: Expected O, but got Unknown
		//IL_686b: Unknown result type (might be due to invalid IL or missing references)
		//IL_6875: Expected O, but got Unknown
		//IL_6946: Unknown result type (might be due to invalid IL or missing references)
		//IL_6950: Expected O, but got Unknown
		//IL_69bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_69c6: Expected O, but got Unknown
		//IL_6b5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_6b64: Expected O, but got Unknown
		//IL_6bd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_6bda: Expected O, but got Unknown
		//IL_6c70: Unknown result type (might be due to invalid IL or missing references)
		//IL_6c7a: Expected O, but got Unknown
		//IL_6ce6: Unknown result type (might be due to invalid IL or missing references)
		//IL_6cf0: Expected O, but got Unknown
		//IL_6d5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_6d66: Expected O, but got Unknown
		//IL_72a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_72b2: Expected O, but got Unknown
		//IL_730e: Unknown result type (might be due to invalid IL or missing references)
		//IL_7318: Expected O, but got Unknown
		//IL_740c: Unknown result type (might be due to invalid IL or missing references)
		//IL_7416: Expected O, but got Unknown
		//IL_7535: Unknown result type (might be due to invalid IL or missing references)
		//IL_753f: Expected O, but got Unknown
		//IL_75a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_75ae: Expected O, but got Unknown
		//IL_76f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_7702: Expected O, but got Unknown
		//IL_7767: Unknown result type (might be due to invalid IL or missing references)
		//IL_7771: Expected O, but got Unknown
		//IL_77d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_77e0: Expected O, but got Unknown
		//IL_79bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_79c9: Expected O, but got Unknown
		//IL_7a35: Unknown result type (might be due to invalid IL or missing references)
		//IL_7a3f: Expected O, but got Unknown
		//IL_7ad5: Unknown result type (might be due to invalid IL or missing references)
		//IL_7adf: Expected O, but got Unknown
		//IL_7bb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_7bba: Expected O, but got Unknown
		//IL_7c26: Unknown result type (might be due to invalid IL or missing references)
		//IL_7c30: Expected O, but got Unknown
		//IL_7dc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_7dce: Expected O, but got Unknown
		//IL_7e3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_7e44: Expected O, but got Unknown
		//IL_7eda: Unknown result type (might be due to invalid IL or missing references)
		//IL_7ee4: Expected O, but got Unknown
		//IL_7f50: Unknown result type (might be due to invalid IL or missing references)
		//IL_7f5a: Expected O, but got Unknown
		//IL_7fc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_7fd0: Expected O, but got Unknown
		//IL_8512: Unknown result type (might be due to invalid IL or missing references)
		//IL_851c: Expected O, but got Unknown
		//IL_8578: Unknown result type (might be due to invalid IL or missing references)
		//IL_8582: Expected O, but got Unknown
		//IL_8676: Unknown result type (might be due to invalid IL or missing references)
		//IL_8680: Expected O, but got Unknown
		//IL_879f: Unknown result type (might be due to invalid IL or missing references)
		//IL_87a9: Expected O, but got Unknown
		//IL_880e: Unknown result type (might be due to invalid IL or missing references)
		//IL_8818: Expected O, but got Unknown
		//IL_8965: Unknown result type (might be due to invalid IL or missing references)
		//IL_896f: Expected O, but got Unknown
		//IL_89d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_89de: Expected O, but got Unknown
		//IL_8a43: Unknown result type (might be due to invalid IL or missing references)
		//IL_8a4d: Expected O, but got Unknown
		//IL_8c2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_8c36: Expected O, but got Unknown
		//IL_8ca2: Unknown result type (might be due to invalid IL or missing references)
		//IL_8cac: Expected O, but got Unknown
		//IL_8d42: Unknown result type (might be due to invalid IL or missing references)
		//IL_8d4c: Expected O, but got Unknown
		//IL_8e1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_8e27: Expected O, but got Unknown
		//IL_8e93: Unknown result type (might be due to invalid IL or missing references)
		//IL_8e9d: Expected O, but got Unknown
		//IL_9031: Unknown result type (might be due to invalid IL or missing references)
		//IL_903b: Expected O, but got Unknown
		//IL_90a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_90b1: Expected O, but got Unknown
		//IL_9147: Unknown result type (might be due to invalid IL or missing references)
		//IL_9151: Expected O, but got Unknown
		//IL_91bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_91c7: Expected O, but got Unknown
		//IL_9233: Unknown result type (might be due to invalid IL or missing references)
		//IL_923d: Expected O, but got Unknown
		//IL_977f: Unknown result type (might be due to invalid IL or missing references)
		//IL_9789: Expected O, but got Unknown
		//IL_97e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_97ef: Expected O, but got Unknown
		//IL_98e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_98ed: Expected O, but got Unknown
		//IL_9a0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_9a16: Expected O, but got Unknown
		//IL_9a7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_9a85: Expected O, but got Unknown
		//IL_9bd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_9bdc: Expected O, but got Unknown
		//IL_9c41: Unknown result type (might be due to invalid IL or missing references)
		//IL_9c4b: Expected O, but got Unknown
		//IL_9cb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_9cba: Expected O, but got Unknown
		//IL_9e99: Unknown result type (might be due to invalid IL or missing references)
		//IL_9ea3: Expected O, but got Unknown
		//IL_9f0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_9f19: Expected O, but got Unknown
		//IL_9faf: Unknown result type (might be due to invalid IL or missing references)
		//IL_9fb9: Expected O, but got Unknown
		//IL_a08a: Unknown result type (might be due to invalid IL or missing references)
		//IL_a094: Expected O, but got Unknown
		//IL_a100: Unknown result type (might be due to invalid IL or missing references)
		//IL_a10a: Expected O, but got Unknown
		//IL_a29e: Unknown result type (might be due to invalid IL or missing references)
		//IL_a2a8: Expected O, but got Unknown
		//IL_a314: Unknown result type (might be due to invalid IL or missing references)
		//IL_a31e: Expected O, but got Unknown
		//IL_a3b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_a3be: Expected O, but got Unknown
		//IL_a42a: Unknown result type (might be due to invalid IL or missing references)
		//IL_a434: Expected O, but got Unknown
		//IL_a4a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_a4aa: Expected O, but got Unknown
		//IL_a9ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_a9f6: Expected O, but got Unknown
		//IL_aa52: Unknown result type (might be due to invalid IL or missing references)
		//IL_aa5c: Expected O, but got Unknown
		//IL_ab50: Unknown result type (might be due to invalid IL or missing references)
		//IL_ab5a: Expected O, but got Unknown
		//IL_ac79: Unknown result type (might be due to invalid IL or missing references)
		//IL_ac83: Expected O, but got Unknown
		//IL_ace8: Unknown result type (might be due to invalid IL or missing references)
		//IL_acf2: Expected O, but got Unknown
		//IL_ae3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_ae49: Expected O, but got Unknown
		//IL_aeae: Unknown result type (might be due to invalid IL or missing references)
		//IL_aeb8: Expected O, but got Unknown
		//IL_af1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_af27: Expected O, but got Unknown
		//IL_b102: Unknown result type (might be due to invalid IL or missing references)
		//IL_b10c: Expected O, but got Unknown
		//IL_b178: Unknown result type (might be due to invalid IL or missing references)
		//IL_b182: Expected O, but got Unknown
		//IL_b218: Unknown result type (might be due to invalid IL or missing references)
		//IL_b222: Expected O, but got Unknown
		//IL_b2f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_b2fd: Expected O, but got Unknown
		//IL_b369: Unknown result type (might be due to invalid IL or missing references)
		//IL_b373: Expected O, but got Unknown
		//IL_b507: Unknown result type (might be due to invalid IL or missing references)
		//IL_b511: Expected O, but got Unknown
		//IL_b57d: Unknown result type (might be due to invalid IL or missing references)
		//IL_b587: Expected O, but got Unknown
		//IL_b61d: Unknown result type (might be due to invalid IL or missing references)
		//IL_b627: Expected O, but got Unknown
		//IL_b693: Unknown result type (might be due to invalid IL or missing references)
		//IL_b69d: Expected O, but got Unknown
		//IL_b709: Unknown result type (might be due to invalid IL or missing references)
		//IL_b713: Expected O, but got Unknown
		//IL_bc55: Unknown result type (might be due to invalid IL or missing references)
		//IL_bc5f: Expected O, but got Unknown
		//IL_bcbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_bcc5: Expected O, but got Unknown
		//IL_bdb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_bdc3: Expected O, but got Unknown
		//IL_bee2: Unknown result type (might be due to invalid IL or missing references)
		//IL_beec: Expected O, but got Unknown
		//IL_bf51: Unknown result type (might be due to invalid IL or missing references)
		//IL_bf5b: Expected O, but got Unknown
		//IL_c0a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_c0ae: Expected O, but got Unknown
		//IL_c113: Unknown result type (might be due to invalid IL or missing references)
		//IL_c11d: Expected O, but got Unknown
		//IL_c182: Unknown result type (might be due to invalid IL or missing references)
		//IL_c18c: Expected O, but got Unknown
		//IL_c368: Unknown result type (might be due to invalid IL or missing references)
		//IL_c372: Expected O, but got Unknown
		//IL_c3de: Unknown result type (might be due to invalid IL or missing references)
		//IL_c3e8: Expected O, but got Unknown
		//IL_c47e: Unknown result type (might be due to invalid IL or missing references)
		//IL_c488: Expected O, but got Unknown
		//IL_c559: Unknown result type (might be due to invalid IL or missing references)
		//IL_c563: Expected O, but got Unknown
		//IL_c5cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_c5d9: Expected O, but got Unknown
		//IL_c76d: Unknown result type (might be due to invalid IL or missing references)
		//IL_c777: Expected O, but got Unknown
		//IL_c7e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_c7ed: Expected O, but got Unknown
		//IL_c883: Unknown result type (might be due to invalid IL or missing references)
		//IL_c88d: Expected O, but got Unknown
		//IL_c8f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_c903: Expected O, but got Unknown
		//IL_c96f: Unknown result type (might be due to invalid IL or missing references)
		//IL_c979: Expected O, but got Unknown
		//IL_cebb: Unknown result type (might be due to invalid IL or missing references)
		//IL_cec5: Expected O, but got Unknown
		//IL_cf21: Unknown result type (might be due to invalid IL or missing references)
		//IL_cf2b: Expected O, but got Unknown
		//IL_d01f: Unknown result type (might be due to invalid IL or missing references)
		//IL_d029: Expected O, but got Unknown
		//IL_d148: Unknown result type (might be due to invalid IL or missing references)
		//IL_d152: Expected O, but got Unknown
		//IL_d1b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_d1c1: Expected O, but got Unknown
		//IL_d30b: Unknown result type (might be due to invalid IL or missing references)
		//IL_d315: Expected O, but got Unknown
		//IL_d37a: Unknown result type (might be due to invalid IL or missing references)
		//IL_d384: Expected O, but got Unknown
		//IL_d3e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_d3f3: Expected O, but got Unknown
		//IL_d5cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_d5d9: Expected O, but got Unknown
		//IL_d645: Unknown result type (might be due to invalid IL or missing references)
		//IL_d64f: Expected O, but got Unknown
		//IL_d6e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_d6ef: Expected O, but got Unknown
		//IL_d7c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_d7ca: Expected O, but got Unknown
		//IL_d836: Unknown result type (might be due to invalid IL or missing references)
		//IL_d840: Expected O, but got Unknown
		//IL_d9d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_d9de: Expected O, but got Unknown
		//IL_da4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_da54: Expected O, but got Unknown
		//IL_daea: Unknown result type (might be due to invalid IL or missing references)
		//IL_daf4: Expected O, but got Unknown
		//IL_db60: Unknown result type (might be due to invalid IL or missing references)
		//IL_db6a: Expected O, but got Unknown
		//IL_dbd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_dbe0: Expected O, but got Unknown
		//IL_e122: Unknown result type (might be due to invalid IL or missing references)
		//IL_e12c: Expected O, but got Unknown
		//IL_e188: Unknown result type (might be due to invalid IL or missing references)
		//IL_e192: Expected O, but got Unknown
		//IL_e286: Unknown result type (might be due to invalid IL or missing references)
		//IL_e290: Expected O, but got Unknown
		//IL_e3af: Unknown result type (might be due to invalid IL or missing references)
		//IL_e3b9: Expected O, but got Unknown
		//IL_e41e: Unknown result type (might be due to invalid IL or missing references)
		//IL_e428: Expected O, but got Unknown
		//IL_e572: Unknown result type (might be due to invalid IL or missing references)
		//IL_e57c: Expected O, but got Unknown
		//IL_e5e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_e5eb: Expected O, but got Unknown
		//IL_e650: Unknown result type (might be due to invalid IL or missing references)
		//IL_e65a: Expected O, but got Unknown
		//IL_e839: Unknown result type (might be due to invalid IL or missing references)
		//IL_e843: Expected O, but got Unknown
		//IL_e8af: Unknown result type (might be due to invalid IL or missing references)
		//IL_e8b9: Expected O, but got Unknown
		//IL_e94f: Unknown result type (might be due to invalid IL or missing references)
		//IL_e959: Expected O, but got Unknown
		//IL_ea2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_ea34: Expected O, but got Unknown
		//IL_eaa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_eaaa: Expected O, but got Unknown
		//IL_ec3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_ec48: Expected O, but got Unknown
		//IL_ecb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_ecbe: Expected O, but got Unknown
		//IL_ed54: Unknown result type (might be due to invalid IL or missing references)
		//IL_ed5e: Expected O, but got Unknown
		//IL_edca: Unknown result type (might be due to invalid IL or missing references)
		//IL_edd4: Expected O, but got Unknown
		//IL_ee40: Unknown result type (might be due to invalid IL or missing references)
		//IL_ee4a: Expected O, but got Unknown
		//IL_f38c: Unknown result type (might be due to invalid IL or missing references)
		//IL_f396: Expected O, but got Unknown
		//IL_f3f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_f3fc: Expected O, but got Unknown
		//IL_f4f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_f4fa: Expected O, but got Unknown
		//IL_f619: Unknown result type (might be due to invalid IL or missing references)
		//IL_f623: Expected O, but got Unknown
		//IL_f688: Unknown result type (might be due to invalid IL or missing references)
		//IL_f692: Expected O, but got Unknown
		//IL_f7df: Unknown result type (might be due to invalid IL or missing references)
		//IL_f7e9: Expected O, but got Unknown
		//IL_f84e: Unknown result type (might be due to invalid IL or missing references)
		//IL_f858: Expected O, but got Unknown
		//IL_f8bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_f8c7: Expected O, but got Unknown
		//IL_faa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_fab0: Expected O, but got Unknown
		//IL_fb1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_fb26: Expected O, but got Unknown
		//IL_fbbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_fbc6: Expected O, but got Unknown
		//IL_fc97: Unknown result type (might be due to invalid IL or missing references)
		//IL_fca1: Expected O, but got Unknown
		//IL_fd0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_fd17: Expected O, but got Unknown
		//IL_feab: Unknown result type (might be due to invalid IL or missing references)
		//IL_feb5: Expected O, but got Unknown
		//IL_ff21: Unknown result type (might be due to invalid IL or missing references)
		//IL_ff2b: Expected O, but got Unknown
		//IL_ffc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_ffcb: Expected O, but got Unknown
		//IL_10037: Unknown result type (might be due to invalid IL or missing references)
		//IL_10041: Expected O, but got Unknown
		//IL_100ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_100b7: Expected O, but got Unknown
		//IL_105f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10603: Expected O, but got Unknown
		//IL_1065f: Unknown result type (might be due to invalid IL or missing references)
		//IL_10669: Expected O, but got Unknown
		//IL_1075d: Unknown result type (might be due to invalid IL or missing references)
		//IL_10767: Expected O, but got Unknown
		//IL_10886: Unknown result type (might be due to invalid IL or missing references)
		//IL_10890: Expected O, but got Unknown
		//IL_108f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_108ff: Expected O, but got Unknown
		//IL_10a4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a56: Expected O, but got Unknown
		//IL_10abb: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ac5: Expected O, but got Unknown
		//IL_10b2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b34: Expected O, but got Unknown
		//IL_10d13: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d1d: Expected O, but got Unknown
		//IL_10d89: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d93: Expected O, but got Unknown
		//IL_10e29: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e33: Expected O, but got Unknown
		//IL_10f04: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f0e: Expected O, but got Unknown
		//IL_10f7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f84: Expected O, but got Unknown
		//IL_11118: Unknown result type (might be due to invalid IL or missing references)
		//IL_11122: Expected O, but got Unknown
		//IL_1118e: Unknown result type (might be due to invalid IL or missing references)
		//IL_11198: Expected O, but got Unknown
		//IL_1122e: Unknown result type (might be due to invalid IL or missing references)
		//IL_11238: Expected O, but got Unknown
		//IL_112a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_112ae: Expected O, but got Unknown
		//IL_1131a: Unknown result type (might be due to invalid IL or missing references)
		//IL_11324: Expected O, but got Unknown
		//IL_11866: Unknown result type (might be due to invalid IL or missing references)
		//IL_11870: Expected O, but got Unknown
		//IL_118cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_118d6: Expected O, but got Unknown
		//IL_119ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_119d4: Expected O, but got Unknown
		//IL_11af3: Unknown result type (might be due to invalid IL or missing references)
		//IL_11afd: Expected O, but got Unknown
		//IL_11b62: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b6c: Expected O, but got Unknown
		//IL_11cb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11cc3: Expected O, but got Unknown
		//IL_11d28: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d32: Expected O, but got Unknown
		//IL_11d97: Unknown result type (might be due to invalid IL or missing references)
		//IL_11da1: Expected O, but got Unknown
		//IL_11f80: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f8a: Expected O, but got Unknown
		//IL_11ff6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12000: Expected O, but got Unknown
		//IL_12096: Unknown result type (might be due to invalid IL or missing references)
		//IL_120a0: Expected O, but got Unknown
		//IL_12171: Unknown result type (might be due to invalid IL or missing references)
		//IL_1217b: Expected O, but got Unknown
		//IL_121e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_121f1: Expected O, but got Unknown
		//IL_12385: Unknown result type (might be due to invalid IL or missing references)
		//IL_1238f: Expected O, but got Unknown
		//IL_123fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_12405: Expected O, but got Unknown
		//IL_1249b: Unknown result type (might be due to invalid IL or missing references)
		//IL_124a5: Expected O, but got Unknown
		//IL_12511: Unknown result type (might be due to invalid IL or missing references)
		//IL_1251b: Expected O, but got Unknown
		//IL_12587: Unknown result type (might be due to invalid IL or missing references)
		//IL_12591: Expected O, but got Unknown
		//IL_12ad3: Unknown result type (might be due to invalid IL or missing references)
		//IL_12add: Expected O, but got Unknown
		//IL_12b39: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b43: Expected O, but got Unknown
		//IL_12c37: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c41: Expected O, but got Unknown
		//IL_12d60: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d6a: Expected O, but got Unknown
		//IL_12dcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_12dd9: Expected O, but got Unknown
		//IL_12f26: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f30: Expected O, but got Unknown
		//IL_12f95: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f9f: Expected O, but got Unknown
		//IL_13004: Unknown result type (might be due to invalid IL or missing references)
		//IL_1300e: Expected O, but got Unknown
		//IL_131ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_131f7: Expected O, but got Unknown
		//IL_13263: Unknown result type (might be due to invalid IL or missing references)
		//IL_1326d: Expected O, but got Unknown
		//IL_13303: Unknown result type (might be due to invalid IL or missing references)
		//IL_1330d: Expected O, but got Unknown
		//IL_133de: Unknown result type (might be due to invalid IL or missing references)
		//IL_133e8: Expected O, but got Unknown
		//IL_13454: Unknown result type (might be due to invalid IL or missing references)
		//IL_1345e: Expected O, but got Unknown
		//IL_135f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_135fc: Expected O, but got Unknown
		//IL_13668: Unknown result type (might be due to invalid IL or missing references)
		//IL_13672: Expected O, but got Unknown
		//IL_13708: Unknown result type (might be due to invalid IL or missing references)
		//IL_13712: Expected O, but got Unknown
		//IL_1377e: Unknown result type (might be due to invalid IL or missing references)
		//IL_13788: Expected O, but got Unknown
		//IL_137f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_137fe: Expected O, but got Unknown
		//IL_13d40: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d4a: Expected O, but got Unknown
		//IL_13da6: Unknown result type (might be due to invalid IL or missing references)
		//IL_13db0: Expected O, but got Unknown
		//IL_13ea4: Unknown result type (might be due to invalid IL or missing references)
		//IL_13eae: Expected O, but got Unknown
		//IL_13fcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_13fd7: Expected O, but got Unknown
		//IL_1403c: Unknown result type (might be due to invalid IL or missing references)
		//IL_14046: Expected O, but got Unknown
		//IL_14193: Unknown result type (might be due to invalid IL or missing references)
		//IL_1419d: Expected O, but got Unknown
		//IL_14202: Unknown result type (might be due to invalid IL or missing references)
		//IL_1420c: Expected O, but got Unknown
		//IL_14271: Unknown result type (might be due to invalid IL or missing references)
		//IL_1427b: Expected O, but got Unknown
		//IL_1445a: Unknown result type (might be due to invalid IL or missing references)
		//IL_14464: Expected O, but got Unknown
		//IL_144d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_144da: Expected O, but got Unknown
		//IL_14570: Unknown result type (might be due to invalid IL or missing references)
		//IL_1457a: Expected O, but got Unknown
		//IL_1464b: Unknown result type (might be due to invalid IL or missing references)
		//IL_14655: Expected O, but got Unknown
		//IL_146c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_146cb: Expected O, but got Unknown
		//IL_1485f: Unknown result type (might be due to invalid IL or missing references)
		//IL_14869: Expected O, but got Unknown
		//IL_148d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_148df: Expected O, but got Unknown
		//IL_14975: Unknown result type (might be due to invalid IL or missing references)
		//IL_1497f: Expected O, but got Unknown
		//IL_149eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_149f5: Expected O, but got Unknown
		//IL_14a61: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a6b: Expected O, but got Unknown
		//IL_14fad: Unknown result type (might be due to invalid IL or missing references)
		//IL_14fb7: Expected O, but got Unknown
		//IL_15013: Unknown result type (might be due to invalid IL or missing references)
		//IL_1501d: Expected O, but got Unknown
		//IL_15111: Unknown result type (might be due to invalid IL or missing references)
		//IL_1511b: Expected O, but got Unknown
		//IL_1523a: Unknown result type (might be due to invalid IL or missing references)
		//IL_15244: Expected O, but got Unknown
		//IL_152a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_152b3: Expected O, but got Unknown
		//IL_15400: Unknown result type (might be due to invalid IL or missing references)
		//IL_1540a: Expected O, but got Unknown
		//IL_1546f: Unknown result type (might be due to invalid IL or missing references)
		//IL_15479: Expected O, but got Unknown
		//IL_154de: Unknown result type (might be due to invalid IL or missing references)
		//IL_154e8: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Explorer1));
		StatusStrip = new StatusStrip();
		ToolStripStatusLabel = new ToolStripStatusLabel();
		TreeNodeImageList = new ImageList(components);
		ToolStrip = new ToolStrip();
		BackToolStripButton = new ToolStripButton();
		ForwardToolStripButton = new ToolStripButton();
		ToolStripSeparator7 = new ToolStripSeparator();
		FoldersToolStripButton = new ToolStripButton();
		ToolStripSeparator8 = new ToolStripSeparator();
		ListViewToolStripButton = new ToolStripDropDownButton();
		ListToolStripMenuItem = new ToolStripMenuItem();
		DetailsToolStripMenuItem = new ToolStripMenuItem();
		LargeIconsToolStripMenuItem = new ToolStripMenuItem();
		SmallIconsToolStripMenuItem = new ToolStripMenuItem();
		TileToolStripMenuItem = new ToolStripMenuItem();
		MenuStrip = new MenuStrip();
		FileToolStripMenuItem = new ToolStripMenuItem();
		NewToolStripMenuItem = new ToolStripMenuItem();
		OpenToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator1 = new ToolStripSeparator();
		SaveToolStripMenuItem = new ToolStripMenuItem();
		SaveAsToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator2 = new ToolStripSeparator();
		PrintToolStripMenuItem = new ToolStripMenuItem();
		PrintPreviewToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator3 = new ToolStripSeparator();
		ExitToolStripMenuItem = new ToolStripMenuItem();
		EditToolStripMenuItem = new ToolStripMenuItem();
		UndoToolStripMenuItem = new ToolStripMenuItem();
		RedoToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator4 = new ToolStripSeparator();
		CutToolStripMenuItem = new ToolStripMenuItem();
		CopyToolStripMenuItem = new ToolStripMenuItem();
		PasteToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator5 = new ToolStripSeparator();
		SelectAllToolStripMenuItem = new ToolStripMenuItem();
		ViewToolStripMenuItem = new ToolStripMenuItem();
		ToolBarToolStripMenuItem = new ToolStripMenuItem();
		StatusBarToolStripMenuItem = new ToolStripMenuItem();
		FoldersToolStripMenuItem = new ToolStripMenuItem();
		ToolsToolStripMenuItem = new ToolStripMenuItem();
		OptionsToolStripMenuItem = new ToolStripMenuItem();
		HelpToolStripMenuItem = new ToolStripMenuItem();
		ContentsToolStripMenuItem = new ToolStripMenuItem();
		IndexToolStripMenuItem = new ToolStripMenuItem();
		SearchToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator6 = new ToolStripSeparator();
		AboutToolStripMenuItem = new ToolStripMenuItem();
		ToolTip = new ToolTip(components);
		ToolStripContainer = new ToolStripContainer();
		SplitContainer = new SplitContainer();
		MenuStrip2 = new MenuStrip();
		ToolStripMenuItem21 = new ToolStripMenuItem();
		ToolStripMenuItem22 = new ToolStripMenuItem();
		ToolStripMenuItem23 = new ToolStripMenuItem();
		ToolStripSeparator17 = new ToolStripSeparator();
		ToolStripMenuItem24 = new ToolStripMenuItem();
		ToolStripMenuItem25 = new ToolStripMenuItem();
		ToolStripSeparator18 = new ToolStripSeparator();
		ToolStripMenuItem26 = new ToolStripMenuItem();
		ToolStripMenuItem27 = new ToolStripMenuItem();
		ToolStripMenuItem28 = new ToolStripMenuItem();
		ToolStripSeparator19 = new ToolStripSeparator();
		ToolStripMenuItem29 = new ToolStripMenuItem();
		ToolStripMenuItem30 = new ToolStripMenuItem();
		ToolStripMenuItem31 = new ToolStripMenuItem();
		ToolStripMenuItem32 = new ToolStripMenuItem();
		ToolStripSeparator20 = new ToolStripSeparator();
		ToolStripMenuItem33 = new ToolStripMenuItem();
		ToolStripMenuItem34 = new ToolStripMenuItem();
		ToolStripMenuItem35 = new ToolStripMenuItem();
		ToolStripSeparator21 = new ToolStripSeparator();
		ToolStripMenuItem36 = new ToolStripMenuItem();
		ToolStripMenuItem37 = new ToolStripMenuItem();
		ToolStripMenuItem38 = new ToolStripMenuItem();
		ToolStripMenuItem39 = new ToolStripMenuItem();
		ToolStripMenuItem40 = new ToolStripMenuItem();
		ToolStripMenuItem41 = new ToolStripMenuItem();
		ToolStripMenuItem42 = new ToolStripMenuItem();
		ToolStripMenuItem43 = new ToolStripMenuItem();
		ToolStripMenuItem44 = new ToolStripMenuItem();
		ToolStripMenuItem45 = new ToolStripMenuItem();
		ToolStripMenuItem46 = new ToolStripMenuItem();
		ToolStripMenuItem47 = new ToolStripMenuItem();
		ToolStripMenuItem48 = new ToolStripMenuItem();
		ToolStripMenuItem49 = new ToolStripMenuItem();
		ToolStripMenuItem50 = new ToolStripMenuItem();
		ToolStripMenuItem51 = new ToolStripMenuItem();
		ToolStripMenuItem52 = new ToolStripMenuItem();
		ToolStripSeparator22 = new ToolStripSeparator();
		ToolStripMenuItem53 = new ToolStripMenuItem();
		StatusStrip2 = new StatusStrip();
		ToolStripStatusLabel2 = new ToolStripStatusLabel();
		ToolStrip2 = new ToolStrip();
		ToolStripButton4 = new ToolStripButton();
		ToolStripButton5 = new ToolStripButton();
		ToolStripButton6 = new ToolStripButton();
		ToolStripSeparator24 = new ToolStripSeparator();
		ToolStripButton3 = new ToolStripButton();
		ToolStripButton2 = new ToolStripButton();
		ToolStripSeparator23 = new ToolStripSeparator();
		ToolStripButton1 = new ToolStripButton();
		MenuStrip1 = new MenuStrip();
		FileMenu = new ToolStripMenuItem();
		ToolStripMenuItem1 = new ToolStripMenuItem();
		ToolStripMenuItem2 = new ToolStripMenuItem();
		ToolStripSeparator9 = new ToolStripSeparator();
		ToolStripMenuItem3 = new ToolStripMenuItem();
		ToolStripMenuItem4 = new ToolStripMenuItem();
		ToolStripSeparator10 = new ToolStripSeparator();
		ToolStripMenuItem5 = new ToolStripMenuItem();
		ToolStripMenuItem6 = new ToolStripMenuItem();
		PrintSetupToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator11 = new ToolStripSeparator();
		ToolStripMenuItem7 = new ToolStripMenuItem();
		EditMenu = new ToolStripMenuItem();
		ToolStripMenuItem8 = new ToolStripMenuItem();
		ToolStripMenuItem9 = new ToolStripMenuItem();
		ToolStripSeparator12 = new ToolStripSeparator();
		ToolStripMenuItem10 = new ToolStripMenuItem();
		ToolStripMenuItem11 = new ToolStripMenuItem();
		ToolStripMenuItem12 = new ToolStripMenuItem();
		ToolStripSeparator13 = new ToolStripSeparator();
		ToolStripMenuItem13 = new ToolStripMenuItem();
		ViewMenu = new ToolStripMenuItem();
		ToolStripMenuItem14 = new ToolStripMenuItem();
		ToolStripMenuItem15 = new ToolStripMenuItem();
		ToolsMenu = new ToolStripMenuItem();
		ToolStripMenuItem16 = new ToolStripMenuItem();
		WindowsMenu = new ToolStripMenuItem();
		NewWindowToolStripMenuItem = new ToolStripMenuItem();
		CascadeToolStripMenuItem = new ToolStripMenuItem();
		TileVerticalToolStripMenuItem = new ToolStripMenuItem();
		TileHorizontalToolStripMenuItem = new ToolStripMenuItem();
		CloseAllToolStripMenuItem = new ToolStripMenuItem();
		ArrangeIconsToolStripMenuItem = new ToolStripMenuItem();
		HelpMenu = new ToolStripMenuItem();
		ToolStripMenuItem17 = new ToolStripMenuItem();
		ToolStripMenuItem18 = new ToolStripMenuItem();
		ToolStripMenuItem19 = new ToolStripMenuItem();
		ToolStripSeparator14 = new ToolStripSeparator();
		ToolStripMenuItem20 = new ToolStripMenuItem();
		StatusStrip1 = new StatusStrip();
		ToolStripStatusLabel1 = new ToolStripStatusLabel();
		ToolStrip1 = new ToolStrip();
		NewToolStripButton = new ToolStripButton();
		OpenToolStripButton = new ToolStripButton();
		SaveToolStripButton = new ToolStripButton();
		ToolStripSeparator16 = new ToolStripSeparator();
		PrintToolStripButton = new ToolStripButton();
		PrintPreviewToolStripButton = new ToolStripButton();
		ToolStripSeparator15 = new ToolStripSeparator();
		HelpToolStripButton = new ToolStripButton();
		TreeView = new TreeView();
		ListView = new ListView();
		ListViewLargeImageList = new ImageList(components);
		ListViewSmallImageList = new ImageList(components);
		ToolTip1 = new ToolTip(components);
		ToolTip2 = new ToolTip(components);
		MenuStrip3 = new MenuStrip();
		ToolStripMenuItem54 = new ToolStripMenuItem();
		ToolStripMenuItem55 = new ToolStripMenuItem();
		ToolStripMenuItem56 = new ToolStripMenuItem();
		ToolStripSeparator25 = new ToolStripSeparator();
		ToolStripMenuItem57 = new ToolStripMenuItem();
		ToolStripMenuItem58 = new ToolStripMenuItem();
		ToolStripSeparator26 = new ToolStripSeparator();
		ToolStripMenuItem59 = new ToolStripMenuItem();
		ToolStripMenuItem60 = new ToolStripMenuItem();
		ToolStripMenuItem61 = new ToolStripMenuItem();
		ToolStripSeparator27 = new ToolStripSeparator();
		ToolStripMenuItem62 = new ToolStripMenuItem();
		ToolStripMenuItem63 = new ToolStripMenuItem();
		ToolStripMenuItem64 = new ToolStripMenuItem();
		ToolStripMenuItem65 = new ToolStripMenuItem();
		ToolStripSeparator28 = new ToolStripSeparator();
		ToolStripMenuItem66 = new ToolStripMenuItem();
		ToolStripMenuItem67 = new ToolStripMenuItem();
		ToolStripMenuItem68 = new ToolStripMenuItem();
		ToolStripSeparator29 = new ToolStripSeparator();
		ToolStripMenuItem69 = new ToolStripMenuItem();
		ToolStripMenuItem70 = new ToolStripMenuItem();
		ToolStripMenuItem71 = new ToolStripMenuItem();
		ToolStripMenuItem72 = new ToolStripMenuItem();
		ToolStripMenuItem73 = new ToolStripMenuItem();
		ToolStripMenuItem74 = new ToolStripMenuItem();
		ToolStripMenuItem75 = new ToolStripMenuItem();
		ToolStripMenuItem76 = new ToolStripMenuItem();
		ToolStripMenuItem77 = new ToolStripMenuItem();
		ToolStripMenuItem78 = new ToolStripMenuItem();
		ToolStripMenuItem79 = new ToolStripMenuItem();
		ToolStripMenuItem80 = new ToolStripMenuItem();
		ToolStripMenuItem81 = new ToolStripMenuItem();
		ToolStripMenuItem82 = new ToolStripMenuItem();
		ToolStripMenuItem83 = new ToolStripMenuItem();
		ToolStripMenuItem84 = new ToolStripMenuItem();
		ToolStripMenuItem85 = new ToolStripMenuItem();
		ToolStripSeparator30 = new ToolStripSeparator();
		ToolStripMenuItem86 = new ToolStripMenuItem();
		ToolStripSeparator31 = new ToolStripSeparator();
		ToolStripButton7 = new ToolStripButton();
		StatusStrip3 = new StatusStrip();
		ToolStripStatusLabel3 = new ToolStripStatusLabel();
		ToolStripButton8 = new ToolStripButton();
		ToolStripButton9 = new ToolStripButton();
		ToolStripSeparator32 = new ToolStripSeparator();
		ToolStrip3 = new ToolStrip();
		ToolStripButton10 = new ToolStripButton();
		ToolStripButton11 = new ToolStripButton();
		ToolStripButton12 = new ToolStripButton();
		ToolTip3 = new ToolTip(components);
		MenuStrip4 = new MenuStrip();
		ToolStripMenuItem87 = new ToolStripMenuItem();
		ToolStripMenuItem88 = new ToolStripMenuItem();
		ToolStripMenuItem89 = new ToolStripMenuItem();
		ToolStripSeparator33 = new ToolStripSeparator();
		ToolStripMenuItem90 = new ToolStripMenuItem();
		ToolStripMenuItem91 = new ToolStripMenuItem();
		ToolStripSeparator34 = new ToolStripSeparator();
		ToolStripMenuItem92 = new ToolStripMenuItem();
		ToolStripMenuItem93 = new ToolStripMenuItem();
		ToolStripMenuItem94 = new ToolStripMenuItem();
		ToolStripSeparator35 = new ToolStripSeparator();
		ToolStripMenuItem95 = new ToolStripMenuItem();
		ToolStripMenuItem96 = new ToolStripMenuItem();
		ToolStripMenuItem97 = new ToolStripMenuItem();
		ToolStripMenuItem98 = new ToolStripMenuItem();
		ToolStripSeparator36 = new ToolStripSeparator();
		ToolStripMenuItem99 = new ToolStripMenuItem();
		ToolStripMenuItem100 = new ToolStripMenuItem();
		ToolStripMenuItem101 = new ToolStripMenuItem();
		ToolStripSeparator37 = new ToolStripSeparator();
		ToolStripMenuItem102 = new ToolStripMenuItem();
		ToolStripMenuItem103 = new ToolStripMenuItem();
		ToolStripMenuItem104 = new ToolStripMenuItem();
		ToolStripMenuItem105 = new ToolStripMenuItem();
		ToolStripMenuItem106 = new ToolStripMenuItem();
		ToolStripMenuItem107 = new ToolStripMenuItem();
		ToolStripMenuItem108 = new ToolStripMenuItem();
		ToolStripMenuItem109 = new ToolStripMenuItem();
		ToolStripMenuItem110 = new ToolStripMenuItem();
		ToolStripMenuItem111 = new ToolStripMenuItem();
		ToolStripMenuItem112 = new ToolStripMenuItem();
		ToolStripMenuItem113 = new ToolStripMenuItem();
		ToolStripMenuItem114 = new ToolStripMenuItem();
		ToolStripMenuItem115 = new ToolStripMenuItem();
		ToolStripMenuItem116 = new ToolStripMenuItem();
		ToolStripMenuItem117 = new ToolStripMenuItem();
		ToolStripMenuItem118 = new ToolStripMenuItem();
		ToolStripSeparator38 = new ToolStripSeparator();
		ToolStripMenuItem119 = new ToolStripMenuItem();
		ToolStripSeparator39 = new ToolStripSeparator();
		ToolStripButton13 = new ToolStripButton();
		StatusStrip4 = new StatusStrip();
		ToolStripStatusLabel4 = new ToolStripStatusLabel();
		ToolStripButton14 = new ToolStripButton();
		ToolStripButton15 = new ToolStripButton();
		ToolStripSeparator40 = new ToolStripSeparator();
		ToolStrip4 = new ToolStrip();
		ToolStripButton16 = new ToolStripButton();
		ToolStripButton17 = new ToolStripButton();
		ToolStripButton18 = new ToolStripButton();
		ToolTip4 = new ToolTip(components);
		MenuStrip5 = new MenuStrip();
		ToolStripMenuItem120 = new ToolStripMenuItem();
		ToolStripMenuItem121 = new ToolStripMenuItem();
		ToolStripMenuItem122 = new ToolStripMenuItem();
		ToolStripSeparator41 = new ToolStripSeparator();
		ToolStripMenuItem123 = new ToolStripMenuItem();
		ToolStripMenuItem124 = new ToolStripMenuItem();
		ToolStripSeparator42 = new ToolStripSeparator();
		ToolStripMenuItem125 = new ToolStripMenuItem();
		ToolStripMenuItem126 = new ToolStripMenuItem();
		ToolStripMenuItem127 = new ToolStripMenuItem();
		ToolStripSeparator43 = new ToolStripSeparator();
		ToolStripMenuItem128 = new ToolStripMenuItem();
		ToolStripMenuItem129 = new ToolStripMenuItem();
		ToolStripMenuItem130 = new ToolStripMenuItem();
		ToolStripMenuItem131 = new ToolStripMenuItem();
		ToolStripSeparator44 = new ToolStripSeparator();
		ToolStripMenuItem132 = new ToolStripMenuItem();
		ToolStripMenuItem133 = new ToolStripMenuItem();
		ToolStripMenuItem134 = new ToolStripMenuItem();
		ToolStripSeparator45 = new ToolStripSeparator();
		ToolStripMenuItem135 = new ToolStripMenuItem();
		ToolStripMenuItem136 = new ToolStripMenuItem();
		ToolStripMenuItem137 = new ToolStripMenuItem();
		ToolStripMenuItem138 = new ToolStripMenuItem();
		ToolStripMenuItem139 = new ToolStripMenuItem();
		ToolStripMenuItem140 = new ToolStripMenuItem();
		ToolStripMenuItem141 = new ToolStripMenuItem();
		ToolStripMenuItem142 = new ToolStripMenuItem();
		ToolStripMenuItem143 = new ToolStripMenuItem();
		ToolStripMenuItem144 = new ToolStripMenuItem();
		ToolStripMenuItem145 = new ToolStripMenuItem();
		ToolStripMenuItem146 = new ToolStripMenuItem();
		ToolStripMenuItem147 = new ToolStripMenuItem();
		ToolStripMenuItem148 = new ToolStripMenuItem();
		ToolStripMenuItem149 = new ToolStripMenuItem();
		ToolStripMenuItem150 = new ToolStripMenuItem();
		ToolStripMenuItem151 = new ToolStripMenuItem();
		ToolStripSeparator46 = new ToolStripSeparator();
		ToolStripMenuItem152 = new ToolStripMenuItem();
		ToolStripSeparator47 = new ToolStripSeparator();
		ToolStripButton19 = new ToolStripButton();
		StatusStrip5 = new StatusStrip();
		ToolStripStatusLabel5 = new ToolStripStatusLabel();
		ToolStripButton20 = new ToolStripButton();
		ToolStripButton21 = new ToolStripButton();
		ToolStripSeparator48 = new ToolStripSeparator();
		ToolStrip5 = new ToolStrip();
		ToolStripButton22 = new ToolStripButton();
		ToolStripButton23 = new ToolStripButton();
		ToolStripButton24 = new ToolStripButton();
		ToolTip5 = new ToolTip(components);
		MenuStrip6 = new MenuStrip();
		ToolStripMenuItem153 = new ToolStripMenuItem();
		ToolStripMenuItem154 = new ToolStripMenuItem();
		ToolStripMenuItem155 = new ToolStripMenuItem();
		ToolStripSeparator49 = new ToolStripSeparator();
		ToolStripMenuItem156 = new ToolStripMenuItem();
		ToolStripMenuItem157 = new ToolStripMenuItem();
		ToolStripSeparator50 = new ToolStripSeparator();
		ToolStripMenuItem158 = new ToolStripMenuItem();
		ToolStripMenuItem159 = new ToolStripMenuItem();
		ToolStripMenuItem160 = new ToolStripMenuItem();
		ToolStripSeparator51 = new ToolStripSeparator();
		ToolStripMenuItem161 = new ToolStripMenuItem();
		ToolStripMenuItem162 = new ToolStripMenuItem();
		ToolStripMenuItem163 = new ToolStripMenuItem();
		ToolStripMenuItem164 = new ToolStripMenuItem();
		ToolStripSeparator52 = new ToolStripSeparator();
		ToolStripMenuItem165 = new ToolStripMenuItem();
		ToolStripMenuItem166 = new ToolStripMenuItem();
		ToolStripMenuItem167 = new ToolStripMenuItem();
		ToolStripSeparator53 = new ToolStripSeparator();
		ToolStripMenuItem168 = new ToolStripMenuItem();
		ToolStripMenuItem169 = new ToolStripMenuItem();
		ToolStripMenuItem170 = new ToolStripMenuItem();
		ToolStripMenuItem171 = new ToolStripMenuItem();
		ToolStripMenuItem172 = new ToolStripMenuItem();
		ToolStripMenuItem173 = new ToolStripMenuItem();
		ToolStripMenuItem174 = new ToolStripMenuItem();
		ToolStripMenuItem175 = new ToolStripMenuItem();
		ToolStripMenuItem176 = new ToolStripMenuItem();
		ToolStripMenuItem177 = new ToolStripMenuItem();
		ToolStripMenuItem178 = new ToolStripMenuItem();
		ToolStripMenuItem179 = new ToolStripMenuItem();
		ToolStripMenuItem180 = new ToolStripMenuItem();
		ToolStripMenuItem181 = new ToolStripMenuItem();
		ToolStripMenuItem182 = new ToolStripMenuItem();
		ToolStripMenuItem183 = new ToolStripMenuItem();
		ToolStripMenuItem184 = new ToolStripMenuItem();
		ToolStripSeparator54 = new ToolStripSeparator();
		ToolStripMenuItem185 = new ToolStripMenuItem();
		ToolStripSeparator55 = new ToolStripSeparator();
		ToolStripButton25 = new ToolStripButton();
		StatusStrip6 = new StatusStrip();
		ToolStripStatusLabel6 = new ToolStripStatusLabel();
		ToolStripButton26 = new ToolStripButton();
		ToolStripButton27 = new ToolStripButton();
		ToolStripSeparator56 = new ToolStripSeparator();
		ToolStrip6 = new ToolStrip();
		ToolStripButton28 = new ToolStripButton();
		ToolStripButton29 = new ToolStripButton();
		ToolStripButton30 = new ToolStripButton();
		ToolTip6 = new ToolTip(components);
		MenuStrip7 = new MenuStrip();
		ToolStripMenuItem186 = new ToolStripMenuItem();
		ToolStripMenuItem187 = new ToolStripMenuItem();
		ToolStripMenuItem188 = new ToolStripMenuItem();
		ToolStripSeparator57 = new ToolStripSeparator();
		ToolStripMenuItem189 = new ToolStripMenuItem();
		ToolStripMenuItem190 = new ToolStripMenuItem();
		ToolStripSeparator58 = new ToolStripSeparator();
		ToolStripMenuItem191 = new ToolStripMenuItem();
		ToolStripMenuItem192 = new ToolStripMenuItem();
		ToolStripMenuItem193 = new ToolStripMenuItem();
		ToolStripSeparator59 = new ToolStripSeparator();
		ToolStripMenuItem194 = new ToolStripMenuItem();
		ToolStripMenuItem195 = new ToolStripMenuItem();
		ToolStripMenuItem196 = new ToolStripMenuItem();
		ToolStripMenuItem197 = new ToolStripMenuItem();
		ToolStripSeparator60 = new ToolStripSeparator();
		ToolStripMenuItem198 = new ToolStripMenuItem();
		ToolStripMenuItem199 = new ToolStripMenuItem();
		ToolStripMenuItem200 = new ToolStripMenuItem();
		ToolStripSeparator61 = new ToolStripSeparator();
		ToolStripMenuItem201 = new ToolStripMenuItem();
		ToolStripMenuItem202 = new ToolStripMenuItem();
		ToolStripMenuItem203 = new ToolStripMenuItem();
		ToolStripMenuItem204 = new ToolStripMenuItem();
		ToolStripMenuItem205 = new ToolStripMenuItem();
		ToolStripMenuItem206 = new ToolStripMenuItem();
		ToolStripMenuItem207 = new ToolStripMenuItem();
		ToolStripMenuItem208 = new ToolStripMenuItem();
		ToolStripMenuItem209 = new ToolStripMenuItem();
		ToolStripMenuItem210 = new ToolStripMenuItem();
		ToolStripMenuItem211 = new ToolStripMenuItem();
		ToolStripMenuItem212 = new ToolStripMenuItem();
		ToolStripMenuItem213 = new ToolStripMenuItem();
		ToolStripMenuItem214 = new ToolStripMenuItem();
		ToolStripMenuItem215 = new ToolStripMenuItem();
		ToolStripMenuItem216 = new ToolStripMenuItem();
		ToolStripMenuItem217 = new ToolStripMenuItem();
		ToolStripSeparator62 = new ToolStripSeparator();
		ToolStripMenuItem218 = new ToolStripMenuItem();
		ToolStripSeparator63 = new ToolStripSeparator();
		ToolStripButton31 = new ToolStripButton();
		StatusStrip7 = new StatusStrip();
		ToolStripStatusLabel7 = new ToolStripStatusLabel();
		ToolStripButton32 = new ToolStripButton();
		ToolStripButton33 = new ToolStripButton();
		ToolStripSeparator64 = new ToolStripSeparator();
		ToolStrip7 = new ToolStrip();
		ToolStripButton34 = new ToolStripButton();
		ToolStripButton35 = new ToolStripButton();
		ToolStripButton36 = new ToolStripButton();
		ToolTip7 = new ToolTip(components);
		MenuStrip8 = new MenuStrip();
		ToolStripMenuItem219 = new ToolStripMenuItem();
		ToolStripMenuItem220 = new ToolStripMenuItem();
		ToolStripMenuItem221 = new ToolStripMenuItem();
		ToolStripSeparator65 = new ToolStripSeparator();
		ToolStripMenuItem222 = new ToolStripMenuItem();
		ToolStripMenuItem223 = new ToolStripMenuItem();
		ToolStripSeparator66 = new ToolStripSeparator();
		ToolStripMenuItem224 = new ToolStripMenuItem();
		ToolStripMenuItem225 = new ToolStripMenuItem();
		ToolStripMenuItem226 = new ToolStripMenuItem();
		ToolStripSeparator67 = new ToolStripSeparator();
		ToolStripMenuItem227 = new ToolStripMenuItem();
		ToolStripMenuItem228 = new ToolStripMenuItem();
		ToolStripMenuItem229 = new ToolStripMenuItem();
		ToolStripMenuItem230 = new ToolStripMenuItem();
		ToolStripSeparator68 = new ToolStripSeparator();
		ToolStripMenuItem231 = new ToolStripMenuItem();
		ToolStripMenuItem232 = new ToolStripMenuItem();
		ToolStripMenuItem233 = new ToolStripMenuItem();
		ToolStripSeparator69 = new ToolStripSeparator();
		ToolStripMenuItem234 = new ToolStripMenuItem();
		ToolStripMenuItem235 = new ToolStripMenuItem();
		ToolStripMenuItem236 = new ToolStripMenuItem();
		ToolStripMenuItem237 = new ToolStripMenuItem();
		ToolStripMenuItem238 = new ToolStripMenuItem();
		ToolStripMenuItem239 = new ToolStripMenuItem();
		ToolStripMenuItem240 = new ToolStripMenuItem();
		ToolStripMenuItem241 = new ToolStripMenuItem();
		ToolStripMenuItem242 = new ToolStripMenuItem();
		ToolStripMenuItem243 = new ToolStripMenuItem();
		ToolStripMenuItem244 = new ToolStripMenuItem();
		ToolStripMenuItem245 = new ToolStripMenuItem();
		ToolStripMenuItem246 = new ToolStripMenuItem();
		ToolStripMenuItem247 = new ToolStripMenuItem();
		ToolStripMenuItem248 = new ToolStripMenuItem();
		ToolStripMenuItem249 = new ToolStripMenuItem();
		ToolStripMenuItem250 = new ToolStripMenuItem();
		ToolStripSeparator70 = new ToolStripSeparator();
		ToolStripMenuItem251 = new ToolStripMenuItem();
		ToolStripSeparator71 = new ToolStripSeparator();
		ToolStripButton37 = new ToolStripButton();
		StatusStrip8 = new StatusStrip();
		ToolStripStatusLabel8 = new ToolStripStatusLabel();
		ToolStripButton38 = new ToolStripButton();
		ToolStripButton39 = new ToolStripButton();
		ToolStripSeparator72 = new ToolStripSeparator();
		ToolStrip8 = new ToolStrip();
		ToolStripButton40 = new ToolStripButton();
		ToolStripButton41 = new ToolStripButton();
		ToolStripButton42 = new ToolStripButton();
		ToolTip8 = new ToolTip(components);
		MenuStrip9 = new MenuStrip();
		ToolStripMenuItem252 = new ToolStripMenuItem();
		ToolStripMenuItem253 = new ToolStripMenuItem();
		ToolStripMenuItem254 = new ToolStripMenuItem();
		ToolStripSeparator73 = new ToolStripSeparator();
		ToolStripMenuItem255 = new ToolStripMenuItem();
		ToolStripMenuItem256 = new ToolStripMenuItem();
		ToolStripSeparator74 = new ToolStripSeparator();
		ToolStripMenuItem257 = new ToolStripMenuItem();
		ToolStripMenuItem258 = new ToolStripMenuItem();
		ToolStripMenuItem259 = new ToolStripMenuItem();
		ToolStripSeparator75 = new ToolStripSeparator();
		ToolStripMenuItem260 = new ToolStripMenuItem();
		ToolStripMenuItem261 = new ToolStripMenuItem();
		ToolStripMenuItem262 = new ToolStripMenuItem();
		ToolStripMenuItem263 = new ToolStripMenuItem();
		ToolStripSeparator76 = new ToolStripSeparator();
		ToolStripMenuItem264 = new ToolStripMenuItem();
		ToolStripMenuItem265 = new ToolStripMenuItem();
		ToolStripMenuItem266 = new ToolStripMenuItem();
		ToolStripSeparator77 = new ToolStripSeparator();
		ToolStripMenuItem267 = new ToolStripMenuItem();
		ToolStripMenuItem268 = new ToolStripMenuItem();
		ToolStripMenuItem269 = new ToolStripMenuItem();
		ToolStripMenuItem270 = new ToolStripMenuItem();
		ToolStripMenuItem271 = new ToolStripMenuItem();
		ToolStripMenuItem272 = new ToolStripMenuItem();
		ToolStripMenuItem273 = new ToolStripMenuItem();
		ToolStripMenuItem274 = new ToolStripMenuItem();
		ToolStripMenuItem275 = new ToolStripMenuItem();
		ToolStripMenuItem276 = new ToolStripMenuItem();
		ToolStripMenuItem277 = new ToolStripMenuItem();
		ToolStripMenuItem278 = new ToolStripMenuItem();
		ToolStripMenuItem279 = new ToolStripMenuItem();
		ToolStripMenuItem280 = new ToolStripMenuItem();
		ToolStripMenuItem281 = new ToolStripMenuItem();
		ToolStripMenuItem282 = new ToolStripMenuItem();
		ToolStripMenuItem283 = new ToolStripMenuItem();
		ToolStripSeparator78 = new ToolStripSeparator();
		ToolStripMenuItem284 = new ToolStripMenuItem();
		ToolStripSeparator79 = new ToolStripSeparator();
		ToolStripButton43 = new ToolStripButton();
		StatusStrip9 = new StatusStrip();
		ToolStripStatusLabel9 = new ToolStripStatusLabel();
		ToolStripButton44 = new ToolStripButton();
		ToolStripButton45 = new ToolStripButton();
		ToolStripSeparator80 = new ToolStripSeparator();
		ToolStrip9 = new ToolStrip();
		ToolStripButton46 = new ToolStripButton();
		ToolStripButton47 = new ToolStripButton();
		ToolStripButton48 = new ToolStripButton();
		ToolTip9 = new ToolTip(components);
		MenuStrip10 = new MenuStrip();
		ToolStripMenuItem285 = new ToolStripMenuItem();
		ToolStripMenuItem286 = new ToolStripMenuItem();
		ToolStripMenuItem287 = new ToolStripMenuItem();
		ToolStripSeparator81 = new ToolStripSeparator();
		ToolStripMenuItem288 = new ToolStripMenuItem();
		ToolStripMenuItem289 = new ToolStripMenuItem();
		ToolStripSeparator82 = new ToolStripSeparator();
		ToolStripMenuItem290 = new ToolStripMenuItem();
		ToolStripMenuItem291 = new ToolStripMenuItem();
		ToolStripMenuItem292 = new ToolStripMenuItem();
		ToolStripSeparator83 = new ToolStripSeparator();
		ToolStripMenuItem293 = new ToolStripMenuItem();
		ToolStripMenuItem294 = new ToolStripMenuItem();
		ToolStripMenuItem295 = new ToolStripMenuItem();
		ToolStripMenuItem296 = new ToolStripMenuItem();
		ToolStripSeparator84 = new ToolStripSeparator();
		ToolStripMenuItem297 = new ToolStripMenuItem();
		ToolStripMenuItem298 = new ToolStripMenuItem();
		ToolStripMenuItem299 = new ToolStripMenuItem();
		ToolStripSeparator85 = new ToolStripSeparator();
		ToolStripMenuItem300 = new ToolStripMenuItem();
		ToolStripMenuItem301 = new ToolStripMenuItem();
		ToolStripMenuItem302 = new ToolStripMenuItem();
		ToolStripMenuItem303 = new ToolStripMenuItem();
		ToolStripMenuItem304 = new ToolStripMenuItem();
		ToolStripMenuItem305 = new ToolStripMenuItem();
		ToolStripMenuItem306 = new ToolStripMenuItem();
		ToolStripMenuItem307 = new ToolStripMenuItem();
		ToolStripMenuItem308 = new ToolStripMenuItem();
		ToolStripMenuItem309 = new ToolStripMenuItem();
		ToolStripMenuItem310 = new ToolStripMenuItem();
		ToolStripMenuItem311 = new ToolStripMenuItem();
		ToolStripMenuItem312 = new ToolStripMenuItem();
		ToolStripMenuItem313 = new ToolStripMenuItem();
		ToolStripMenuItem314 = new ToolStripMenuItem();
		ToolStripMenuItem315 = new ToolStripMenuItem();
		ToolStripMenuItem316 = new ToolStripMenuItem();
		ToolStripSeparator86 = new ToolStripSeparator();
		ToolStripMenuItem317 = new ToolStripMenuItem();
		ToolStripSeparator87 = new ToolStripSeparator();
		ToolStripButton49 = new ToolStripButton();
		StatusStrip10 = new StatusStrip();
		ToolStripStatusLabel10 = new ToolStripStatusLabel();
		ToolStripButton50 = new ToolStripButton();
		ToolStripButton51 = new ToolStripButton();
		ToolStripSeparator88 = new ToolStripSeparator();
		ToolStrip10 = new ToolStrip();
		ToolStripButton52 = new ToolStripButton();
		ToolStripButton53 = new ToolStripButton();
		ToolStripButton54 = new ToolStripButton();
		ToolTip10 = new ToolTip(components);
		MenuStrip11 = new MenuStrip();
		ToolStripMenuItem318 = new ToolStripMenuItem();
		ToolStripMenuItem319 = new ToolStripMenuItem();
		ToolStripMenuItem320 = new ToolStripMenuItem();
		ToolStripSeparator89 = new ToolStripSeparator();
		ToolStripMenuItem321 = new ToolStripMenuItem();
		ToolStripMenuItem322 = new ToolStripMenuItem();
		ToolStripSeparator90 = new ToolStripSeparator();
		ToolStripMenuItem323 = new ToolStripMenuItem();
		ToolStripMenuItem324 = new ToolStripMenuItem();
		ToolStripMenuItem325 = new ToolStripMenuItem();
		ToolStripSeparator91 = new ToolStripSeparator();
		ToolStripMenuItem326 = new ToolStripMenuItem();
		ToolStripMenuItem327 = new ToolStripMenuItem();
		ToolStripMenuItem328 = new ToolStripMenuItem();
		ToolStripMenuItem329 = new ToolStripMenuItem();
		ToolStripSeparator92 = new ToolStripSeparator();
		ToolStripMenuItem330 = new ToolStripMenuItem();
		ToolStripMenuItem331 = new ToolStripMenuItem();
		ToolStripMenuItem332 = new ToolStripMenuItem();
		ToolStripSeparator93 = new ToolStripSeparator();
		ToolStripMenuItem333 = new ToolStripMenuItem();
		ToolStripMenuItem334 = new ToolStripMenuItem();
		ToolStripMenuItem335 = new ToolStripMenuItem();
		ToolStripMenuItem336 = new ToolStripMenuItem();
		ToolStripMenuItem337 = new ToolStripMenuItem();
		ToolStripMenuItem338 = new ToolStripMenuItem();
		ToolStripMenuItem339 = new ToolStripMenuItem();
		ToolStripMenuItem340 = new ToolStripMenuItem();
		ToolStripMenuItem341 = new ToolStripMenuItem();
		ToolStripMenuItem342 = new ToolStripMenuItem();
		ToolStripMenuItem343 = new ToolStripMenuItem();
		ToolStripMenuItem344 = new ToolStripMenuItem();
		ToolStripMenuItem345 = new ToolStripMenuItem();
		ToolStripMenuItem346 = new ToolStripMenuItem();
		ToolStripMenuItem347 = new ToolStripMenuItem();
		ToolStripMenuItem348 = new ToolStripMenuItem();
		ToolStripMenuItem349 = new ToolStripMenuItem();
		ToolStripSeparator94 = new ToolStripSeparator();
		ToolStripMenuItem350 = new ToolStripMenuItem();
		ToolStripSeparator95 = new ToolStripSeparator();
		ToolStripButton55 = new ToolStripButton();
		StatusStrip11 = new StatusStrip();
		ToolStripStatusLabel11 = new ToolStripStatusLabel();
		ToolStripButton56 = new ToolStripButton();
		ToolStripButton57 = new ToolStripButton();
		ToolStripSeparator96 = new ToolStripSeparator();
		ToolStrip11 = new ToolStrip();
		ToolStripButton58 = new ToolStripButton();
		ToolStripButton59 = new ToolStripButton();
		ToolStripButton60 = new ToolStripButton();
		ToolTip11 = new ToolTip(components);
		MenuStrip12 = new MenuStrip();
		ToolStripMenuItem351 = new ToolStripMenuItem();
		ToolStripMenuItem352 = new ToolStripMenuItem();
		ToolStripMenuItem353 = new ToolStripMenuItem();
		ToolStripSeparator97 = new ToolStripSeparator();
		ToolStripMenuItem354 = new ToolStripMenuItem();
		ToolStripMenuItem355 = new ToolStripMenuItem();
		ToolStripSeparator98 = new ToolStripSeparator();
		ToolStripMenuItem356 = new ToolStripMenuItem();
		ToolStripMenuItem357 = new ToolStripMenuItem();
		ToolStripMenuItem358 = new ToolStripMenuItem();
		ToolStripSeparator99 = new ToolStripSeparator();
		ToolStripMenuItem359 = new ToolStripMenuItem();
		ToolStripMenuItem360 = new ToolStripMenuItem();
		ToolStripMenuItem361 = new ToolStripMenuItem();
		ToolStripMenuItem362 = new ToolStripMenuItem();
		ToolStripSeparator100 = new ToolStripSeparator();
		ToolStripMenuItem363 = new ToolStripMenuItem();
		ToolStripMenuItem364 = new ToolStripMenuItem();
		ToolStripMenuItem365 = new ToolStripMenuItem();
		ToolStripSeparator101 = new ToolStripSeparator();
		ToolStripMenuItem366 = new ToolStripMenuItem();
		ToolStripMenuItem367 = new ToolStripMenuItem();
		ToolStripMenuItem368 = new ToolStripMenuItem();
		ToolStripMenuItem369 = new ToolStripMenuItem();
		ToolStripMenuItem370 = new ToolStripMenuItem();
		ToolStripMenuItem371 = new ToolStripMenuItem();
		ToolStripMenuItem372 = new ToolStripMenuItem();
		ToolStripMenuItem373 = new ToolStripMenuItem();
		ToolStripMenuItem374 = new ToolStripMenuItem();
		ToolStripMenuItem375 = new ToolStripMenuItem();
		ToolStripMenuItem376 = new ToolStripMenuItem();
		ToolStripMenuItem377 = new ToolStripMenuItem();
		ToolStripMenuItem378 = new ToolStripMenuItem();
		ToolStripMenuItem379 = new ToolStripMenuItem();
		ToolStripMenuItem380 = new ToolStripMenuItem();
		ToolStripMenuItem381 = new ToolStripMenuItem();
		ToolStripMenuItem382 = new ToolStripMenuItem();
		ToolStripSeparator102 = new ToolStripSeparator();
		ToolStripMenuItem383 = new ToolStripMenuItem();
		ToolStripSeparator103 = new ToolStripSeparator();
		ToolStripButton61 = new ToolStripButton();
		StatusStrip12 = new StatusStrip();
		ToolStripStatusLabel12 = new ToolStripStatusLabel();
		ToolStripButton62 = new ToolStripButton();
		ToolStripButton63 = new ToolStripButton();
		ToolStripSeparator104 = new ToolStripSeparator();
		ToolStrip12 = new ToolStrip();
		ToolStripButton64 = new ToolStripButton();
		ToolStripButton65 = new ToolStripButton();
		ToolStripButton66 = new ToolStripButton();
		ToolTip12 = new ToolTip(components);
		MenuStrip13 = new MenuStrip();
		ToolStripMenuItem384 = new ToolStripMenuItem();
		ToolStripMenuItem385 = new ToolStripMenuItem();
		ToolStripMenuItem386 = new ToolStripMenuItem();
		ToolStripSeparator105 = new ToolStripSeparator();
		ToolStripMenuItem387 = new ToolStripMenuItem();
		ToolStripMenuItem388 = new ToolStripMenuItem();
		ToolStripSeparator106 = new ToolStripSeparator();
		ToolStripMenuItem389 = new ToolStripMenuItem();
		ToolStripMenuItem390 = new ToolStripMenuItem();
		ToolStripMenuItem391 = new ToolStripMenuItem();
		ToolStripSeparator107 = new ToolStripSeparator();
		ToolStripMenuItem392 = new ToolStripMenuItem();
		ToolStripMenuItem393 = new ToolStripMenuItem();
		ToolStripMenuItem394 = new ToolStripMenuItem();
		ToolStripMenuItem395 = new ToolStripMenuItem();
		ToolStripSeparator108 = new ToolStripSeparator();
		ToolStripMenuItem396 = new ToolStripMenuItem();
		ToolStripMenuItem397 = new ToolStripMenuItem();
		ToolStripMenuItem398 = new ToolStripMenuItem();
		ToolStripSeparator109 = new ToolStripSeparator();
		ToolStripMenuItem399 = new ToolStripMenuItem();
		ToolStripMenuItem400 = new ToolStripMenuItem();
		ToolStripMenuItem401 = new ToolStripMenuItem();
		ToolStripMenuItem402 = new ToolStripMenuItem();
		ToolStripMenuItem403 = new ToolStripMenuItem();
		ToolStripMenuItem404 = new ToolStripMenuItem();
		ToolStripMenuItem405 = new ToolStripMenuItem();
		ToolStripMenuItem406 = new ToolStripMenuItem();
		ToolStripMenuItem407 = new ToolStripMenuItem();
		ToolStripMenuItem408 = new ToolStripMenuItem();
		ToolStripMenuItem409 = new ToolStripMenuItem();
		ToolStripMenuItem410 = new ToolStripMenuItem();
		ToolStripMenuItem411 = new ToolStripMenuItem();
		ToolStripMenuItem412 = new ToolStripMenuItem();
		ToolStripMenuItem413 = new ToolStripMenuItem();
		ToolStripMenuItem414 = new ToolStripMenuItem();
		ToolStripMenuItem415 = new ToolStripMenuItem();
		ToolStripSeparator110 = new ToolStripSeparator();
		ToolStripMenuItem416 = new ToolStripMenuItem();
		ToolStripSeparator111 = new ToolStripSeparator();
		ToolStripButton67 = new ToolStripButton();
		StatusStrip13 = new StatusStrip();
		ToolStripStatusLabel13 = new ToolStripStatusLabel();
		ToolStripButton68 = new ToolStripButton();
		ToolStripButton69 = new ToolStripButton();
		ToolStripSeparator112 = new ToolStripSeparator();
		ToolStrip13 = new ToolStrip();
		ToolStripButton70 = new ToolStripButton();
		ToolStripButton71 = new ToolStripButton();
		ToolStripButton72 = new ToolStripButton();
		ToolTip13 = new ToolTip(components);
		MenuStrip14 = new MenuStrip();
		ToolStripMenuItem417 = new ToolStripMenuItem();
		ToolStripMenuItem418 = new ToolStripMenuItem();
		ToolStripMenuItem419 = new ToolStripMenuItem();
		ToolStripSeparator113 = new ToolStripSeparator();
		ToolStripMenuItem420 = new ToolStripMenuItem();
		ToolStripMenuItem421 = new ToolStripMenuItem();
		ToolStripSeparator114 = new ToolStripSeparator();
		ToolStripMenuItem422 = new ToolStripMenuItem();
		ToolStripMenuItem423 = new ToolStripMenuItem();
		ToolStripMenuItem424 = new ToolStripMenuItem();
		ToolStripSeparator115 = new ToolStripSeparator();
		ToolStripMenuItem425 = new ToolStripMenuItem();
		ToolStripMenuItem426 = new ToolStripMenuItem();
		ToolStripMenuItem427 = new ToolStripMenuItem();
		ToolStripMenuItem428 = new ToolStripMenuItem();
		ToolStripSeparator116 = new ToolStripSeparator();
		ToolStripMenuItem429 = new ToolStripMenuItem();
		ToolStripMenuItem430 = new ToolStripMenuItem();
		ToolStripMenuItem431 = new ToolStripMenuItem();
		ToolStripSeparator117 = new ToolStripSeparator();
		ToolStripMenuItem432 = new ToolStripMenuItem();
		ToolStripMenuItem433 = new ToolStripMenuItem();
		ToolStripMenuItem434 = new ToolStripMenuItem();
		ToolStripMenuItem435 = new ToolStripMenuItem();
		ToolStripMenuItem436 = new ToolStripMenuItem();
		ToolStripMenuItem437 = new ToolStripMenuItem();
		ToolStripMenuItem438 = new ToolStripMenuItem();
		ToolStripMenuItem439 = new ToolStripMenuItem();
		ToolStripMenuItem440 = new ToolStripMenuItem();
		ToolStripMenuItem441 = new ToolStripMenuItem();
		ToolStripMenuItem442 = new ToolStripMenuItem();
		ToolStripMenuItem443 = new ToolStripMenuItem();
		ToolStripMenuItem444 = new ToolStripMenuItem();
		ToolStripMenuItem445 = new ToolStripMenuItem();
		ToolStripMenuItem446 = new ToolStripMenuItem();
		ToolStripMenuItem447 = new ToolStripMenuItem();
		ToolStripMenuItem448 = new ToolStripMenuItem();
		ToolStripSeparator118 = new ToolStripSeparator();
		ToolStripMenuItem449 = new ToolStripMenuItem();
		ToolStripSeparator119 = new ToolStripSeparator();
		ToolStripButton73 = new ToolStripButton();
		StatusStrip14 = new StatusStrip();
		ToolStripStatusLabel14 = new ToolStripStatusLabel();
		ToolStripButton74 = new ToolStripButton();
		ToolStripButton75 = new ToolStripButton();
		ToolStripSeparator120 = new ToolStripSeparator();
		ToolStrip14 = new ToolStrip();
		ToolStripButton76 = new ToolStripButton();
		ToolStripButton77 = new ToolStripButton();
		ToolStripButton78 = new ToolStripButton();
		ToolTip14 = new ToolTip(components);
		MenuStrip15 = new MenuStrip();
		ToolStripMenuItem450 = new ToolStripMenuItem();
		ToolStripMenuItem451 = new ToolStripMenuItem();
		ToolStripMenuItem452 = new ToolStripMenuItem();
		ToolStripSeparator121 = new ToolStripSeparator();
		ToolStripMenuItem453 = new ToolStripMenuItem();
		ToolStripMenuItem454 = new ToolStripMenuItem();
		ToolStripSeparator122 = new ToolStripSeparator();
		ToolStripMenuItem455 = new ToolStripMenuItem();
		ToolStripMenuItem456 = new ToolStripMenuItem();
		ToolStripMenuItem457 = new ToolStripMenuItem();
		ToolStripSeparator123 = new ToolStripSeparator();
		ToolStripMenuItem458 = new ToolStripMenuItem();
		ToolStripMenuItem459 = new ToolStripMenuItem();
		ToolStripMenuItem460 = new ToolStripMenuItem();
		ToolStripMenuItem461 = new ToolStripMenuItem();
		ToolStripSeparator124 = new ToolStripSeparator();
		ToolStripMenuItem462 = new ToolStripMenuItem();
		ToolStripMenuItem463 = new ToolStripMenuItem();
		ToolStripMenuItem464 = new ToolStripMenuItem();
		ToolStripSeparator125 = new ToolStripSeparator();
		ToolStripMenuItem465 = new ToolStripMenuItem();
		ToolStripMenuItem466 = new ToolStripMenuItem();
		ToolStripMenuItem467 = new ToolStripMenuItem();
		ToolStripMenuItem468 = new ToolStripMenuItem();
		ToolStripMenuItem469 = new ToolStripMenuItem();
		ToolStripMenuItem470 = new ToolStripMenuItem();
		ToolStripMenuItem471 = new ToolStripMenuItem();
		ToolStripMenuItem472 = new ToolStripMenuItem();
		ToolStripMenuItem473 = new ToolStripMenuItem();
		ToolStripMenuItem474 = new ToolStripMenuItem();
		ToolStripMenuItem475 = new ToolStripMenuItem();
		ToolStripMenuItem476 = new ToolStripMenuItem();
		ToolStripMenuItem477 = new ToolStripMenuItem();
		ToolStripMenuItem478 = new ToolStripMenuItem();
		ToolStripMenuItem479 = new ToolStripMenuItem();
		ToolStripMenuItem480 = new ToolStripMenuItem();
		ToolStripMenuItem481 = new ToolStripMenuItem();
		ToolStripSeparator126 = new ToolStripSeparator();
		ToolStripMenuItem482 = new ToolStripMenuItem();
		ToolStripSeparator127 = new ToolStripSeparator();
		ToolStripButton79 = new ToolStripButton();
		StatusStrip15 = new StatusStrip();
		ToolStripStatusLabel15 = new ToolStripStatusLabel();
		ToolStripButton80 = new ToolStripButton();
		ToolStripButton81 = new ToolStripButton();
		ToolStripSeparator128 = new ToolStripSeparator();
		ToolStrip15 = new ToolStrip();
		ToolStripButton82 = new ToolStripButton();
		ToolStripButton83 = new ToolStripButton();
		ToolStripButton84 = new ToolStripButton();
		ToolTip15 = new ToolTip(components);
		((Control)StatusStrip).SuspendLayout();
		((Control)ToolStrip).SuspendLayout();
		((Control)MenuStrip).SuspendLayout();
		((Control)ToolStripContainer.get_BottomToolStripPanel()).SuspendLayout();
		((Control)ToolStripContainer.get_ContentPanel()).SuspendLayout();
		((Control)ToolStripContainer.get_TopToolStripPanel()).SuspendLayout();
		((Control)ToolStripContainer).SuspendLayout();
		((ISupportInitialize)SplitContainer).BeginInit();
		((Control)SplitContainer.get_Panel1()).SuspendLayout();
		((Control)SplitContainer.get_Panel2()).SuspendLayout();
		((Control)SplitContainer).SuspendLayout();
		((Control)MenuStrip2).SuspendLayout();
		((Control)StatusStrip2).SuspendLayout();
		((Control)ToolStrip2).SuspendLayout();
		((Control)MenuStrip1).SuspendLayout();
		((Control)StatusStrip1).SuspendLayout();
		((Control)ToolStrip1).SuspendLayout();
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
		((Control)MenuStrip7).SuspendLayout();
		((Control)StatusStrip7).SuspendLayout();
		((Control)ToolStrip7).SuspendLayout();
		((Control)MenuStrip8).SuspendLayout();
		((Control)StatusStrip8).SuspendLayout();
		((Control)ToolStrip8).SuspendLayout();
		((Control)MenuStrip9).SuspendLayout();
		((Control)StatusStrip9).SuspendLayout();
		((Control)ToolStrip9).SuspendLayout();
		((Control)MenuStrip10).SuspendLayout();
		((Control)StatusStrip10).SuspendLayout();
		((Control)ToolStrip10).SuspendLayout();
		((Control)MenuStrip11).SuspendLayout();
		((Control)StatusStrip11).SuspendLayout();
		((Control)ToolStrip11).SuspendLayout();
		((Control)MenuStrip12).SuspendLayout();
		((Control)StatusStrip12).SuspendLayout();
		((Control)ToolStrip12).SuspendLayout();
		((Control)MenuStrip13).SuspendLayout();
		((Control)StatusStrip13).SuspendLayout();
		((Control)ToolStrip13).SuspendLayout();
		((Control)MenuStrip14).SuspendLayout();
		((Control)StatusStrip14).SuspendLayout();
		((Control)ToolStrip14).SuspendLayout();
		((Control)MenuStrip15).SuspendLayout();
		((Control)StatusStrip15).SuspendLayout();
		((Control)ToolStrip15).SuspendLayout();
		((Control)this).SuspendLayout();
		StatusStrip.set_Dock((DockStyle)0);
		((ToolStrip)StatusStrip).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel });
		StatusStrip statusStrip = StatusStrip;
		Point location = new Point(0, 0);
		((Control)statusStrip).set_Location(location);
		((Control)StatusStrip).set_Name("StatusStrip");
		StatusStrip statusStrip2 = StatusStrip;
		Size size = new Size(632, 22);
		((Control)statusStrip2).set_Size(size);
		((Control)StatusStrip).set_TabIndex(6);
		((Control)StatusStrip).set_Text("StatusStrip");
		((ToolStripItem)ToolStripStatusLabel).set_Name("ToolStripStatusLabel");
		ToolStripStatusLabel toolStripStatusLabel = ToolStripStatusLabel;
		size = new Size(27, 17);
		((ToolStripItem)toolStripStatusLabel).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel).set_Text("État");
		TreeNodeImageList.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("TreeNodeImageList.ImageStream"));
		TreeNodeImageList.set_TransparentColor(Color.Transparent);
		TreeNodeImageList.get_Images().SetKeyName(0, "ClosedFolder");
		TreeNodeImageList.get_Images().SetKeyName(1, "OpenFolder");
		ToolStrip.set_Anchor((AnchorStyles)8);
		ToolStrip.set_Dock((DockStyle)0);
		ToolStrip.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)BackToolStripButton,
			(ToolStripItem)ForwardToolStripButton,
			(ToolStripItem)ToolStripSeparator7,
			(ToolStripItem)FoldersToolStripButton,
			(ToolStripItem)ToolStripSeparator8,
			(ToolStripItem)ListViewToolStripButton
		});
		ToolStrip toolStrip = ToolStrip;
		location = new Point(3, 24);
		((Control)toolStrip).set_Location(location);
		((Control)ToolStrip).set_Name("ToolStrip");
		ToolStrip toolStrip2 = ToolStrip;
		size = new Size(269, 25);
		((Control)toolStrip2).set_Size(size);
		((Control)ToolStrip).set_TabIndex(0);
		((Control)ToolStrip).set_Text("ToolStrip1");
		((ToolStripItem)BackToolStripButton).set_Enabled(false);
		((ToolStripItem)BackToolStripButton).set_Image((Image)componentResourceManager.GetObject("BackToolStripButton.Image"));
		((ToolStripItem)BackToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)BackToolStripButton).set_Name("BackToolStripButton");
		ToolStripButton backToolStripButton = BackToolStripButton;
		size = new Size(80, 22);
		((ToolStripItem)backToolStripButton).set_Size(size);
		((ToolStripItem)BackToolStripButton).set_Text("Précédent");
		((ToolStripItem)BackToolStripButton).set_ToolTipText("Retourner à l'élément précédent");
		((ToolStripItem)ForwardToolStripButton).set_Enabled(false);
		((ToolStripItem)ForwardToolStripButton).set_Image((Image)componentResourceManager.GetObject("ForwardToolStripButton.Image"));
		((ToolStripItem)ForwardToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ForwardToolStripButton).set_Name("ForwardToolStripButton");
		ToolStripButton forwardToolStripButton = ForwardToolStripButton;
		size = new Size(66, 22);
		((ToolStripItem)forwardToolStripButton).set_Size(size);
		((ToolStripItem)ForwardToolStripButton).set_Text("Suivant");
		((ToolStripItem)ForwardToolStripButton).set_ToolTipText("Avancer à l'élément suivant");
		((ToolStripItem)ToolStripSeparator7).set_Name("ToolStripSeparator7");
		ToolStripSeparator toolStripSeparator = ToolStripSeparator7;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator).set_Size(size);
		FoldersToolStripButton.set_Checked(true);
		FoldersToolStripButton.set_CheckState((CheckState)1);
		((ToolStripItem)FoldersToolStripButton).set_Image((Image)componentResourceManager.GetObject("FoldersToolStripButton.Image"));
		((ToolStripItem)FoldersToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)FoldersToolStripButton).set_Name("FoldersToolStripButton");
		ToolStripButton foldersToolStripButton = FoldersToolStripButton;
		size = new Size(70, 22);
		((ToolStripItem)foldersToolStripButton).set_Size(size);
		((ToolStripItem)FoldersToolStripButton).set_Text("Dossiers");
		((ToolStripItem)FoldersToolStripButton).set_ToolTipText("Activer/Désactiver l'affichage des dossiers");
		((ToolStripItem)ToolStripSeparator8).set_Name("ToolStripSeparator8");
		ToolStripSeparator toolStripSeparator2 = ToolStripSeparator8;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator2).set_Size(size);
		((ToolStripItem)ListViewToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripDropDownItem)ListViewToolStripButton).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ListToolStripMenuItem,
			(ToolStripItem)DetailsToolStripMenuItem,
			(ToolStripItem)LargeIconsToolStripMenuItem,
			(ToolStripItem)SmallIconsToolStripMenuItem,
			(ToolStripItem)TileToolStripMenuItem
		});
		((ToolStripItem)ListViewToolStripButton).set_Image((Image)componentResourceManager.GetObject("ListViewToolStripButton.Image"));
		((ToolStripItem)ListViewToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ListViewToolStripButton).set_Name("ListViewToolStripButton");
		ToolStripDropDownButton listViewToolStripButton = ListViewToolStripButton;
		size = new Size(29, 22);
		((ToolStripItem)listViewToolStripButton).set_Size(size);
		((ToolStripItem)ListViewToolStripButton).set_Text("Vues");
		((ToolStripItem)ListToolStripMenuItem).set_Name("ListToolStripMenuItem");
		ToolStripMenuItem listToolStripMenuItem = ListToolStripMenuItem;
		size = new Size(154, 22);
		((ToolStripItem)listToolStripMenuItem).set_Size(size);
		((ToolStripItem)ListToolStripMenuItem).set_Text("Liste");
		DetailsToolStripMenuItem.set_Checked(true);
		DetailsToolStripMenuItem.set_CheckState((CheckState)1);
		((ToolStripItem)DetailsToolStripMenuItem).set_Name("DetailsToolStripMenuItem");
		ToolStripMenuItem detailsToolStripMenuItem = DetailsToolStripMenuItem;
		size = new Size(154, 22);
		((ToolStripItem)detailsToolStripMenuItem).set_Size(size);
		((ToolStripItem)DetailsToolStripMenuItem).set_Text("Détails");
		((ToolStripItem)LargeIconsToolStripMenuItem).set_Name("LargeIconsToolStripMenuItem");
		ToolStripMenuItem largeIconsToolStripMenuItem = LargeIconsToolStripMenuItem;
		size = new Size(154, 22);
		((ToolStripItem)largeIconsToolStripMenuItem).set_Size(size);
		((ToolStripItem)LargeIconsToolStripMenuItem).set_Text("Grandes icônes");
		((ToolStripItem)SmallIconsToolStripMenuItem).set_Name("SmallIconsToolStripMenuItem");
		ToolStripMenuItem smallIconsToolStripMenuItem = SmallIconsToolStripMenuItem;
		size = new Size(154, 22);
		((ToolStripItem)smallIconsToolStripMenuItem).set_Size(size);
		((ToolStripItem)SmallIconsToolStripMenuItem).set_Text("Petites icônes");
		((ToolStripItem)TileToolStripMenuItem).set_Name("TileToolStripMenuItem");
		ToolStripMenuItem tileToolStripMenuItem = TileToolStripMenuItem;
		size = new Size(154, 22);
		((ToolStripItem)tileToolStripMenuItem).set_Size(size);
		((ToolStripItem)TileToolStripMenuItem).set_Text("Mosaïque");
		((ToolStrip)MenuStrip).set_Dock((DockStyle)0);
		((ToolStrip)MenuStrip).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)FileToolStripMenuItem,
			(ToolStripItem)EditToolStripMenuItem,
			(ToolStripItem)ViewToolStripMenuItem,
			(ToolStripItem)ToolsToolStripMenuItem,
			(ToolStripItem)HelpToolStripMenuItem
		});
		MenuStrip menuStrip = MenuStrip;
		location = new Point(0, 0);
		((Control)menuStrip).set_Location(location);
		((Control)MenuStrip).set_Name("MenuStrip");
		MenuStrip menuStrip2 = MenuStrip;
		size = new Size(632, 24);
		((Control)menuStrip2).set_Size(size);
		((Control)MenuStrip).set_TabIndex(0);
		((Control)MenuStrip).set_Text("MenuStrip1");
		((ToolStripDropDownItem)FileToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[10]
		{
			(ToolStripItem)NewToolStripMenuItem,
			(ToolStripItem)OpenToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator1,
			(ToolStripItem)SaveToolStripMenuItem,
			(ToolStripItem)SaveAsToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator2,
			(ToolStripItem)PrintToolStripMenuItem,
			(ToolStripItem)PrintPreviewToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator3,
			(ToolStripItem)ExitToolStripMenuItem
		});
		((ToolStripItem)FileToolStripMenuItem).set_Name("FileToolStripMenuItem");
		ToolStripMenuItem fileToolStripMenuItem = FileToolStripMenuItem;
		size = new Size(54, 20);
		((ToolStripItem)fileToolStripMenuItem).set_Size(size);
		((ToolStripItem)FileToolStripMenuItem).set_Text("&Fichier");
		((ToolStripItem)NewToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("NewToolStripMenuItem.Image"));
		((ToolStripItem)NewToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)NewToolStripMenuItem).set_Name("NewToolStripMenuItem");
		NewToolStripMenuItem.set_ShortcutKeys((Keys)131150);
		ToolStripMenuItem newToolStripMenuItem = NewToolStripMenuItem;
		size = new Size(205, 22);
		((ToolStripItem)newToolStripMenuItem).set_Size(size);
		((ToolStripItem)NewToolStripMenuItem).set_Text("&Nouveau");
		((ToolStripItem)OpenToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("OpenToolStripMenuItem.Image"));
		((ToolStripItem)OpenToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)OpenToolStripMenuItem).set_Name("OpenToolStripMenuItem");
		OpenToolStripMenuItem.set_ShortcutKeys((Keys)131151);
		ToolStripMenuItem openToolStripMenuItem = OpenToolStripMenuItem;
		size = new Size(205, 22);
		((ToolStripItem)openToolStripMenuItem).set_Size(size);
		((ToolStripItem)OpenToolStripMenuItem).set_Text("&Ouvrir");
		((ToolStripItem)ToolStripSeparator1).set_Name("ToolStripSeparator1");
		ToolStripSeparator toolStripSeparator3 = ToolStripSeparator1;
		size = new Size(202, 6);
		((ToolStripItem)toolStripSeparator3).set_Size(size);
		((ToolStripItem)SaveToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("SaveToolStripMenuItem.Image"));
		((ToolStripItem)SaveToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)SaveToolStripMenuItem).set_Name("SaveToolStripMenuItem");
		SaveToolStripMenuItem.set_ShortcutKeys((Keys)131155);
		ToolStripMenuItem saveToolStripMenuItem = SaveToolStripMenuItem;
		size = new Size(205, 22);
		((ToolStripItem)saveToolStripMenuItem).set_Size(size);
		((ToolStripItem)SaveToolStripMenuItem).set_Text("&Enregistrer");
		((ToolStripItem)SaveAsToolStripMenuItem).set_Name("SaveAsToolStripMenuItem");
		ToolStripMenuItem saveAsToolStripMenuItem = SaveAsToolStripMenuItem;
		size = new Size(205, 22);
		((ToolStripItem)saveAsToolStripMenuItem).set_Size(size);
		((ToolStripItem)SaveAsToolStripMenuItem).set_Text("Enregistrer &sous");
		((ToolStripItem)ToolStripSeparator2).set_Name("ToolStripSeparator2");
		ToolStripSeparator toolStripSeparator4 = ToolStripSeparator2;
		size = new Size(202, 6);
		((ToolStripItem)toolStripSeparator4).set_Size(size);
		((ToolStripItem)PrintToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("PrintToolStripMenuItem.Image"));
		((ToolStripItem)PrintToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)PrintToolStripMenuItem).set_Name("PrintToolStripMenuItem");
		PrintToolStripMenuItem.set_ShortcutKeys((Keys)131152);
		ToolStripMenuItem printToolStripMenuItem = PrintToolStripMenuItem;
		size = new Size(205, 22);
		((ToolStripItem)printToolStripMenuItem).set_Size(size);
		((ToolStripItem)PrintToolStripMenuItem).set_Text("&Imprimer");
		((ToolStripItem)PrintPreviewToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("PrintPreviewToolStripMenuItem.Image"));
		((ToolStripItem)PrintPreviewToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)PrintPreviewToolStripMenuItem).set_Name("PrintPreviewToolStripMenuItem");
		ToolStripMenuItem printPreviewToolStripMenuItem = PrintPreviewToolStripMenuItem;
		size = new Size(205, 22);
		((ToolStripItem)printPreviewToolStripMenuItem).set_Size(size);
		((ToolStripItem)PrintPreviewToolStripMenuItem).set_Text("Aperçu a&vant impression");
		((ToolStripItem)ToolStripSeparator3).set_Name("ToolStripSeparator3");
		ToolStripSeparator toolStripSeparator5 = ToolStripSeparator3;
		size = new Size(202, 6);
		((ToolStripItem)toolStripSeparator5).set_Size(size);
		((ToolStripItem)ExitToolStripMenuItem).set_Name("ExitToolStripMenuItem");
		ToolStripMenuItem exitToolStripMenuItem = ExitToolStripMenuItem;
		size = new Size(205, 22);
		((ToolStripItem)exitToolStripMenuItem).set_Size(size);
		((ToolStripItem)ExitToolStripMenuItem).set_Text("&Quitter");
		((ToolStripDropDownItem)EditToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)UndoToolStripMenuItem,
			(ToolStripItem)RedoToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator4,
			(ToolStripItem)CutToolStripMenuItem,
			(ToolStripItem)CopyToolStripMenuItem,
			(ToolStripItem)PasteToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator5,
			(ToolStripItem)SelectAllToolStripMenuItem
		});
		((ToolStripItem)EditToolStripMenuItem).set_Name("EditToolStripMenuItem");
		ToolStripMenuItem editToolStripMenuItem = EditToolStripMenuItem;
		size = new Size(56, 20);
		((ToolStripItem)editToolStripMenuItem).set_Size(size);
		((ToolStripItem)EditToolStripMenuItem).set_Text("&Edition");
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
		((ToolStripItem)ToolStripSeparator4).set_Name("ToolStripSeparator4");
		ToolStripSeparator toolStripSeparator6 = ToolStripSeparator4;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator6).set_Size(size);
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
		((ToolStripItem)ToolStripSeparator5).set_Name("ToolStripSeparator5");
		ToolStripSeparator toolStripSeparator7 = ToolStripSeparator5;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator7).set_Size(size);
		((ToolStripItem)SelectAllToolStripMenuItem).set_Name("SelectAllToolStripMenuItem");
		SelectAllToolStripMenuItem.set_ShortcutKeys((Keys)131137);
		ToolStripMenuItem selectAllToolStripMenuItem = SelectAllToolStripMenuItem;
		size = new Size(206, 22);
		((ToolStripItem)selectAllToolStripMenuItem).set_Size(size);
		((ToolStripItem)SelectAllToolStripMenuItem).set_Text("Sélectionner &tout");
		((ToolStripDropDownItem)ViewToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)ToolBarToolStripMenuItem,
			(ToolStripItem)StatusBarToolStripMenuItem,
			(ToolStripItem)FoldersToolStripMenuItem
		});
		((ToolStripItem)ViewToolStripMenuItem).set_Name("ViewToolStripMenuItem");
		ToolStripMenuItem viewToolStripMenuItem = ViewToolStripMenuItem;
		size = new Size(70, 20);
		((ToolStripItem)viewToolStripMenuItem).set_Size(size);
		((ToolStripItem)ViewToolStripMenuItem).set_Text("&Affichage");
		ToolBarToolStripMenuItem.set_Checked(true);
		ToolBarToolStripMenuItem.set_CheckState((CheckState)1);
		((ToolStripItem)ToolBarToolStripMenuItem).set_Name("ToolBarToolStripMenuItem");
		ToolStripMenuItem toolBarToolStripMenuItem = ToolBarToolStripMenuItem;
		size = new Size(143, 22);
		((ToolStripItem)toolBarToolStripMenuItem).set_Size(size);
		((ToolStripItem)ToolBarToolStripMenuItem).set_Text("&Barre d'outils");
		StatusBarToolStripMenuItem.set_Checked(true);
		StatusBarToolStripMenuItem.set_CheckState((CheckState)1);
		((ToolStripItem)StatusBarToolStripMenuItem).set_Name("StatusBarToolStripMenuItem");
		ToolStripMenuItem statusBarToolStripMenuItem = StatusBarToolStripMenuItem;
		size = new Size(143, 22);
		((ToolStripItem)statusBarToolStripMenuItem).set_Size(size);
		((ToolStripItem)StatusBarToolStripMenuItem).set_Text("&Barre d'état");
		FoldersToolStripMenuItem.set_Checked(true);
		FoldersToolStripMenuItem.set_CheckState((CheckState)1);
		((ToolStripItem)FoldersToolStripMenuItem).set_Name("FoldersToolStripMenuItem");
		ToolStripMenuItem foldersToolStripMenuItem = FoldersToolStripMenuItem;
		size = new Size(143, 22);
		((ToolStripItem)foldersToolStripMenuItem).set_Size(size);
		((ToolStripItem)FoldersToolStripMenuItem).set_Text("&Dossiers");
		((ToolStripDropDownItem)ToolsToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)OptionsToolStripMenuItem });
		((ToolStripItem)ToolsToolStripMenuItem).set_Name("ToolsToolStripMenuItem");
		ToolStripMenuItem toolsToolStripMenuItem = ToolsToolStripMenuItem;
		size = new Size(50, 20);
		((ToolStripItem)toolsToolStripMenuItem).set_Size(size);
		((ToolStripItem)ToolsToolStripMenuItem).set_Text("&Outils");
		((ToolStripItem)OptionsToolStripMenuItem).set_Name("OptionsToolStripMenuItem");
		ToolStripMenuItem optionsToolStripMenuItem = OptionsToolStripMenuItem;
		size = new Size(116, 22);
		((ToolStripItem)optionsToolStripMenuItem).set_Size(size);
		((ToolStripItem)OptionsToolStripMenuItem).set_Text("&Options");
		((ToolStripDropDownItem)HelpToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ContentsToolStripMenuItem,
			(ToolStripItem)IndexToolStripMenuItem,
			(ToolStripItem)SearchToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator6,
			(ToolStripItem)AboutToolStripMenuItem
		});
		((ToolStripItem)HelpToolStripMenuItem).set_Name("HelpToolStripMenuItem");
		ToolStripMenuItem helpToolStripMenuItem = HelpToolStripMenuItem;
		size = new Size(24, 20);
		((ToolStripItem)helpToolStripMenuItem).set_Size(size);
		((ToolStripItem)HelpToolStripMenuItem).set_Text("&?");
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
		((ToolStripItem)ToolStripSeparator6).set_Name("ToolStripSeparator6");
		ToolStripSeparator toolStripSeparator8 = ToolStripSeparator6;
		size = new Size(163, 6);
		((ToolStripItem)toolStripSeparator8).set_Size(size);
		((ToolStripItem)AboutToolStripMenuItem).set_Name("AboutToolStripMenuItem");
		ToolStripMenuItem aboutToolStripMenuItem = AboutToolStripMenuItem;
		size = new Size(166, 22);
		((ToolStripItem)aboutToolStripMenuItem).set_Size(size);
		((ToolStripItem)AboutToolStripMenuItem).set_Text("À pr&opos de ...");
		((Control)ToolStripContainer.get_BottomToolStripPanel()).get_Controls().Add((Control)(object)StatusStrip);
		((Control)ToolStripContainer.get_ContentPanel()).get_Controls().Add((Control)(object)SplitContainer);
		ToolStripContentPanel contentPanel = ToolStripContainer.get_ContentPanel();
		size = new Size(632, 382);
		((Control)contentPanel).set_Size(size);
		((Control)ToolStripContainer).set_Dock((DockStyle)5);
		ToolStripContainer toolStripContainer = ToolStripContainer;
		location = new Point(0, 0);
		((Control)toolStripContainer).set_Location(location);
		((Control)ToolStripContainer).set_Name("ToolStripContainer");
		ToolStripContainer toolStripContainer2 = ToolStripContainer;
		size = new Size(632, 453);
		((Control)toolStripContainer2).set_Size(size);
		((Control)ToolStripContainer).set_TabIndex(7);
		((Control)ToolStripContainer).set_Text("ToolStripContainer1");
		((Control)ToolStripContainer.get_TopToolStripPanel()).get_Controls().Add((Control)(object)MenuStrip);
		((Control)ToolStripContainer.get_TopToolStripPanel()).get_Controls().Add((Control)(object)ToolStrip);
		SplitContainer.set_Dock((DockStyle)5);
		SplitContainer splitContainer = SplitContainer;
		location = new Point(0, 0);
		((Control)splitContainer).set_Location(location);
		((Control)SplitContainer).set_Name("SplitContainer");
		((Control)SplitContainer.get_Panel1()).get_Controls().Add((Control)(object)MenuStrip6);
		((Control)SplitContainer.get_Panel1()).get_Controls().Add((Control)(object)StatusStrip6);
		((Control)SplitContainer.get_Panel1()).get_Controls().Add((Control)(object)ToolStrip6);
		((Control)SplitContainer.get_Panel1()).get_Controls().Add((Control)(object)MenuStrip5);
		((Control)SplitContainer.get_Panel1()).get_Controls().Add((Control)(object)StatusStrip5);
		((Control)SplitContainer.get_Panel1()).get_Controls().Add((Control)(object)ToolStrip5);
		((Control)SplitContainer.get_Panel1()).get_Controls().Add((Control)(object)MenuStrip4);
		((Control)SplitContainer.get_Panel1()).get_Controls().Add((Control)(object)StatusStrip4);
		((Control)SplitContainer.get_Panel1()).get_Controls().Add((Control)(object)ToolStrip4);
		((Control)SplitContainer.get_Panel1()).get_Controls().Add((Control)(object)MenuStrip3);
		((Control)SplitContainer.get_Panel1()).get_Controls().Add((Control)(object)StatusStrip3);
		((Control)SplitContainer.get_Panel1()).get_Controls().Add((Control)(object)ToolStrip3);
		((Control)SplitContainer.get_Panel1()).get_Controls().Add((Control)(object)MenuStrip2);
		((Control)SplitContainer.get_Panel1()).get_Controls().Add((Control)(object)StatusStrip2);
		((Control)SplitContainer.get_Panel1()).get_Controls().Add((Control)(object)ToolStrip2);
		((Control)SplitContainer.get_Panel1()).get_Controls().Add((Control)(object)MenuStrip1);
		((Control)SplitContainer.get_Panel1()).get_Controls().Add((Control)(object)StatusStrip1);
		((Control)SplitContainer.get_Panel1()).get_Controls().Add((Control)(object)ToolStrip1);
		((Control)SplitContainer.get_Panel1()).get_Controls().Add((Control)(object)TreeView);
		((Control)SplitContainer.get_Panel2()).get_Controls().Add((Control)(object)MenuStrip15);
		((Control)SplitContainer.get_Panel2()).get_Controls().Add((Control)(object)StatusStrip15);
		((Control)SplitContainer.get_Panel2()).get_Controls().Add((Control)(object)ToolStrip15);
		((Control)SplitContainer.get_Panel2()).get_Controls().Add((Control)(object)MenuStrip14);
		((Control)SplitContainer.get_Panel2()).get_Controls().Add((Control)(object)StatusStrip14);
		((Control)SplitContainer.get_Panel2()).get_Controls().Add((Control)(object)ToolStrip14);
		((Control)SplitContainer.get_Panel2()).get_Controls().Add((Control)(object)MenuStrip13);
		((Control)SplitContainer.get_Panel2()).get_Controls().Add((Control)(object)StatusStrip13);
		((Control)SplitContainer.get_Panel2()).get_Controls().Add((Control)(object)ToolStrip13);
		((Control)SplitContainer.get_Panel2()).get_Controls().Add((Control)(object)MenuStrip12);
		((Control)SplitContainer.get_Panel2()).get_Controls().Add((Control)(object)StatusStrip12);
		((Control)SplitContainer.get_Panel2()).get_Controls().Add((Control)(object)ToolStrip12);
		((Control)SplitContainer.get_Panel2()).get_Controls().Add((Control)(object)MenuStrip11);
		((Control)SplitContainer.get_Panel2()).get_Controls().Add((Control)(object)StatusStrip11);
		((Control)SplitContainer.get_Panel2()).get_Controls().Add((Control)(object)ToolStrip11);
		((Control)SplitContainer.get_Panel2()).get_Controls().Add((Control)(object)MenuStrip10);
		((Control)SplitContainer.get_Panel2()).get_Controls().Add((Control)(object)StatusStrip10);
		((Control)SplitContainer.get_Panel2()).get_Controls().Add((Control)(object)ToolStrip10);
		((Control)SplitContainer.get_Panel2()).get_Controls().Add((Control)(object)MenuStrip9);
		((Control)SplitContainer.get_Panel2()).get_Controls().Add((Control)(object)StatusStrip9);
		((Control)SplitContainer.get_Panel2()).get_Controls().Add((Control)(object)ToolStrip9);
		((Control)SplitContainer.get_Panel2()).get_Controls().Add((Control)(object)MenuStrip8);
		((Control)SplitContainer.get_Panel2()).get_Controls().Add((Control)(object)StatusStrip8);
		((Control)SplitContainer.get_Panel2()).get_Controls().Add((Control)(object)ToolStrip8);
		((Control)SplitContainer.get_Panel2()).get_Controls().Add((Control)(object)MenuStrip7);
		((Control)SplitContainer.get_Panel2()).get_Controls().Add((Control)(object)StatusStrip7);
		((Control)SplitContainer.get_Panel2()).get_Controls().Add((Control)(object)ToolStrip7);
		((Control)SplitContainer.get_Panel2()).get_Controls().Add((Control)(object)ListView);
		SplitContainer splitContainer2 = SplitContainer;
		size = new Size(632, 382);
		((Control)splitContainer2).set_Size(size);
		SplitContainer.set_SplitterDistance(211);
		((Control)SplitContainer).set_TabIndex(0);
		SplitContainer.set_Text("SplitContainer1");
		((ToolStrip)MenuStrip2).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem21,
			(ToolStripItem)ToolStripMenuItem30,
			(ToolStripItem)ToolStripMenuItem37,
			(ToolStripItem)ToolStripMenuItem40,
			(ToolStripItem)ToolStripMenuItem42,
			(ToolStripItem)ToolStripMenuItem49
		});
		MenuStrip menuStrip3 = MenuStrip2;
		location = new Point(0, 74);
		((Control)menuStrip3).set_Location(location);
		MenuStrip2.set_MdiWindowListItem(ToolStripMenuItem42);
		((Control)MenuStrip2).set_Name("MenuStrip2");
		MenuStrip menuStrip4 = MenuStrip2;
		size = new Size(211, 24);
		((Control)menuStrip4).set_Size(size);
		((Control)MenuStrip2).set_TabIndex(11);
		((Control)MenuStrip2).set_Text("MenuStrip2");
		((ToolStripDropDownItem)ToolStripMenuItem21).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)ToolStripMenuItem22,
			(ToolStripItem)ToolStripMenuItem23,
			(ToolStripItem)ToolStripSeparator17,
			(ToolStripItem)ToolStripMenuItem24,
			(ToolStripItem)ToolStripMenuItem25,
			(ToolStripItem)ToolStripSeparator18,
			(ToolStripItem)ToolStripMenuItem26,
			(ToolStripItem)ToolStripMenuItem27,
			(ToolStripItem)ToolStripMenuItem28,
			(ToolStripItem)ToolStripSeparator19,
			(ToolStripItem)ToolStripMenuItem29
		});
		((ToolStripItem)ToolStripMenuItem21).set_ImageTransparentColor(SystemColors.ActiveBorder);
		((ToolStripItem)ToolStripMenuItem21).set_Name("ToolStripMenuItem21");
		ToolStripMenuItem toolStripMenuItem = ToolStripMenuItem21;
		size = new Size(54, 20);
		((ToolStripItem)toolStripMenuItem).set_Size(size);
		((ToolStripItem)ToolStripMenuItem21).set_Text("&Fichier");
		((ToolStripItem)ToolStripMenuItem22).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem22.Image"));
		((ToolStripItem)ToolStripMenuItem22).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem22).set_Name("ToolStripMenuItem22");
		ToolStripMenuItem22.set_ShortcutKeys((Keys)131150);
		ToolStripMenuItem toolStripMenuItem2 = ToolStripMenuItem22;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem2).set_Size(size);
		((ToolStripItem)ToolStripMenuItem22).set_Text("&Nouveau");
		((ToolStripItem)ToolStripMenuItem23).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem23.Image"));
		((ToolStripItem)ToolStripMenuItem23).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem23).set_Name("ToolStripMenuItem23");
		ToolStripMenuItem23.set_ShortcutKeys((Keys)131151);
		ToolStripMenuItem toolStripMenuItem3 = ToolStripMenuItem23;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem3).set_Size(size);
		((ToolStripItem)ToolStripMenuItem23).set_Text("&Ouvrir");
		((ToolStripItem)ToolStripSeparator17).set_Name("ToolStripSeparator17");
		ToolStripSeparator toolStripSeparator9 = ToolStripSeparator17;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator9).set_Size(size);
		((ToolStripItem)ToolStripMenuItem24).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem24.Image"));
		((ToolStripItem)ToolStripMenuItem24).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem24).set_Name("ToolStripMenuItem24");
		ToolStripMenuItem24.set_ShortcutKeys((Keys)131155);
		ToolStripMenuItem toolStripMenuItem4 = ToolStripMenuItem24;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem4).set_Size(size);
		((ToolStripItem)ToolStripMenuItem24).set_Text("&Enregistrer");
		((ToolStripItem)ToolStripMenuItem25).set_Name("ToolStripMenuItem25");
		ToolStripMenuItem toolStripMenuItem5 = ToolStripMenuItem25;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem5).set_Size(size);
		((ToolStripItem)ToolStripMenuItem25).set_Text("Enregistrer &sous");
		((ToolStripItem)ToolStripSeparator18).set_Name("ToolStripSeparator18");
		ToolStripSeparator toolStripSeparator10 = ToolStripSeparator18;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator10).set_Size(size);
		((ToolStripItem)ToolStripMenuItem26).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem26.Image"));
		((ToolStripItem)ToolStripMenuItem26).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem26).set_Name("ToolStripMenuItem26");
		ToolStripMenuItem26.set_ShortcutKeys((Keys)131152);
		ToolStripMenuItem toolStripMenuItem6 = ToolStripMenuItem26;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem6).set_Size(size);
		((ToolStripItem)ToolStripMenuItem26).set_Text("&Imprimer");
		((ToolStripItem)ToolStripMenuItem27).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem27.Image"));
		((ToolStripItem)ToolStripMenuItem27).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem27).set_Name("ToolStripMenuItem27");
		ToolStripMenuItem toolStripMenuItem7 = ToolStripMenuItem27;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem7).set_Size(size);
		((ToolStripItem)ToolStripMenuItem27).set_Text("Aperçu a&vant impression");
		((ToolStripItem)ToolStripMenuItem28).set_Name("ToolStripMenuItem28");
		ToolStripMenuItem toolStripMenuItem8 = ToolStripMenuItem28;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem8).set_Size(size);
		((ToolStripItem)ToolStripMenuItem28).set_Text("Configuration de l'impression");
		((ToolStripItem)ToolStripSeparator19).set_Name("ToolStripSeparator19");
		ToolStripSeparator toolStripSeparator11 = ToolStripSeparator19;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator11).set_Size(size);
		((ToolStripItem)ToolStripMenuItem29).set_Name("ToolStripMenuItem29");
		ToolStripMenuItem toolStripMenuItem9 = ToolStripMenuItem29;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem9).set_Size(size);
		((ToolStripItem)ToolStripMenuItem29).set_Text("&Quitter");
		((ToolStripDropDownItem)ToolStripMenuItem30).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripMenuItem31,
			(ToolStripItem)ToolStripMenuItem32,
			(ToolStripItem)ToolStripSeparator20,
			(ToolStripItem)ToolStripMenuItem33,
			(ToolStripItem)ToolStripMenuItem34,
			(ToolStripItem)ToolStripMenuItem35,
			(ToolStripItem)ToolStripSeparator21,
			(ToolStripItem)ToolStripMenuItem36
		});
		((ToolStripItem)ToolStripMenuItem30).set_Name("ToolStripMenuItem30");
		ToolStripMenuItem toolStripMenuItem10 = ToolStripMenuItem30;
		size = new Size(56, 20);
		((ToolStripItem)toolStripMenuItem10).set_Size(size);
		((ToolStripItem)ToolStripMenuItem30).set_Text("&Edition");
		((ToolStripItem)ToolStripMenuItem31).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem31.Image"));
		((ToolStripItem)ToolStripMenuItem31).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem31).set_Name("ToolStripMenuItem31");
		ToolStripMenuItem31.set_ShortcutKeys((Keys)131162);
		ToolStripMenuItem toolStripMenuItem11 = ToolStripMenuItem31;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem11).set_Size(size);
		((ToolStripItem)ToolStripMenuItem31).set_Text("&Annuler");
		((ToolStripItem)ToolStripMenuItem32).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem32.Image"));
		((ToolStripItem)ToolStripMenuItem32).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem32).set_Name("ToolStripMenuItem32");
		ToolStripMenuItem32.set_ShortcutKeys((Keys)131161);
		ToolStripMenuItem toolStripMenuItem12 = ToolStripMenuItem32;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem12).set_Size(size);
		((ToolStripItem)ToolStripMenuItem32).set_Text("&Rétablir");
		((ToolStripItem)ToolStripSeparator20).set_Name("ToolStripSeparator20");
		ToolStripSeparator toolStripSeparator12 = ToolStripSeparator20;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator12).set_Size(size);
		((ToolStripItem)ToolStripMenuItem33).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem33.Image"));
		((ToolStripItem)ToolStripMenuItem33).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem33).set_Name("ToolStripMenuItem33");
		ToolStripMenuItem33.set_ShortcutKeys((Keys)131160);
		ToolStripMenuItem toolStripMenuItem13 = ToolStripMenuItem33;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem13).set_Size(size);
		((ToolStripItem)ToolStripMenuItem33).set_Text("Co&uper");
		((ToolStripItem)ToolStripMenuItem34).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem34.Image"));
		((ToolStripItem)ToolStripMenuItem34).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem34).set_Name("ToolStripMenuItem34");
		ToolStripMenuItem34.set_ShortcutKeys((Keys)131139);
		ToolStripMenuItem toolStripMenuItem14 = ToolStripMenuItem34;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem14).set_Size(size);
		((ToolStripItem)ToolStripMenuItem34).set_Text("&Copier");
		((ToolStripItem)ToolStripMenuItem35).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem35.Image"));
		((ToolStripItem)ToolStripMenuItem35).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem35).set_Name("ToolStripMenuItem35");
		ToolStripMenuItem35.set_ShortcutKeys((Keys)131158);
		ToolStripMenuItem toolStripMenuItem15 = ToolStripMenuItem35;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem15).set_Size(size);
		((ToolStripItem)ToolStripMenuItem35).set_Text("&Coller");
		((ToolStripItem)ToolStripSeparator21).set_Name("ToolStripSeparator21");
		ToolStripSeparator toolStripSeparator13 = ToolStripSeparator21;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator13).set_Size(size);
		((ToolStripItem)ToolStripMenuItem36).set_Name("ToolStripMenuItem36");
		ToolStripMenuItem36.set_ShortcutKeys((Keys)131137);
		ToolStripMenuItem toolStripMenuItem16 = ToolStripMenuItem36;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem16).set_Size(size);
		((ToolStripItem)ToolStripMenuItem36).set_Text("Sélectionner &tout");
		((ToolStripDropDownItem)ToolStripMenuItem37).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolStripMenuItem38,
			(ToolStripItem)ToolStripMenuItem39
		});
		((ToolStripItem)ToolStripMenuItem37).set_Name("ToolStripMenuItem37");
		ToolStripMenuItem toolStripMenuItem17 = ToolStripMenuItem37;
		size = new Size(70, 20);
		((ToolStripItem)toolStripMenuItem17).set_Size(size);
		((ToolStripItem)ToolStripMenuItem37).set_Text("&Affichage");
		ToolStripMenuItem38.set_Checked(true);
		ToolStripMenuItem38.set_CheckOnClick(true);
		ToolStripMenuItem38.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem38).set_Name("ToolStripMenuItem38");
		ToolStripMenuItem toolStripMenuItem18 = ToolStripMenuItem38;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem18).set_Size(size);
		((ToolStripItem)ToolStripMenuItem38).set_Text("&Barre d'outils");
		ToolStripMenuItem39.set_Checked(true);
		ToolStripMenuItem39.set_CheckOnClick(true);
		ToolStripMenuItem39.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem39).set_Name("ToolStripMenuItem39");
		ToolStripMenuItem toolStripMenuItem19 = ToolStripMenuItem39;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem19).set_Size(size);
		((ToolStripItem)ToolStripMenuItem39).set_Text("&Barre d'état");
		((ToolStripDropDownItem)ToolStripMenuItem40).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripMenuItem41 });
		((ToolStripItem)ToolStripMenuItem40).set_Name("ToolStripMenuItem40");
		ToolStripMenuItem toolStripMenuItem20 = ToolStripMenuItem40;
		size = new Size(50, 20);
		((ToolStripItem)toolStripMenuItem20).set_Size(size);
		((ToolStripItem)ToolStripMenuItem40).set_Text("&Outils");
		((ToolStripItem)ToolStripMenuItem41).set_Name("ToolStripMenuItem41");
		ToolStripMenuItem toolStripMenuItem21 = ToolStripMenuItem41;
		size = new Size(116, 22);
		((ToolStripItem)toolStripMenuItem21).set_Size(size);
		((ToolStripItem)ToolStripMenuItem41).set_Text("&Options");
		((ToolStripDropDownItem)ToolStripMenuItem42).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem43,
			(ToolStripItem)ToolStripMenuItem44,
			(ToolStripItem)ToolStripMenuItem45,
			(ToolStripItem)ToolStripMenuItem46,
			(ToolStripItem)ToolStripMenuItem47,
			(ToolStripItem)ToolStripMenuItem48
		});
		((ToolStripItem)ToolStripMenuItem42).set_Name("ToolStripMenuItem42");
		ToolStripMenuItem toolStripMenuItem22 = ToolStripMenuItem42;
		size = new Size(63, 20);
		((ToolStripItem)toolStripMenuItem22).set_Size(size);
		((ToolStripItem)ToolStripMenuItem42).set_Text("F&enêtres");
		((ToolStripItem)ToolStripMenuItem43).set_Name("ToolStripMenuItem43");
		ToolStripMenuItem toolStripMenuItem23 = ToolStripMenuItem43;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem23).set_Size(size);
		((ToolStripItem)ToolStripMenuItem43).set_Text("&Nouvelle fenêtre");
		((ToolStripItem)ToolStripMenuItem44).set_Name("ToolStripMenuItem44");
		ToolStripMenuItem toolStripMenuItem24 = ToolStripMenuItem44;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem24).set_Size(size);
		((ToolStripItem)ToolStripMenuItem44).set_Text("&Cascade");
		((ToolStripItem)ToolStripMenuItem45).set_Name("ToolStripMenuItem45");
		ToolStripMenuItem toolStripMenuItem25 = ToolStripMenuItem45;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem25).set_Size(size);
		((ToolStripItem)ToolStripMenuItem45).set_Text("Mosaïque &verticale");
		((ToolStripItem)ToolStripMenuItem46).set_Name("ToolStripMenuItem46");
		ToolStripMenuItem toolStripMenuItem26 = ToolStripMenuItem46;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem26).set_Size(size);
		((ToolStripItem)ToolStripMenuItem46).set_Text("Mosaïque &horizontale");
		((ToolStripItem)ToolStripMenuItem47).set_Name("ToolStripMenuItem47");
		ToolStripMenuItem toolStripMenuItem27 = ToolStripMenuItem47;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem27).set_Size(size);
		((ToolStripItem)ToolStripMenuItem47).set_Text("&Fermer tout");
		((ToolStripItem)ToolStripMenuItem48).set_Name("ToolStripMenuItem48");
		ToolStripMenuItem toolStripMenuItem28 = ToolStripMenuItem48;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem28).set_Size(size);
		((ToolStripItem)ToolStripMenuItem48).set_Text("&Réorganiser les icônes");
		((ToolStripDropDownItem)ToolStripMenuItem49).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ToolStripMenuItem50,
			(ToolStripItem)ToolStripMenuItem51,
			(ToolStripItem)ToolStripMenuItem52,
			(ToolStripItem)ToolStripSeparator22,
			(ToolStripItem)ToolStripMenuItem53
		});
		((ToolStripItem)ToolStripMenuItem49).set_Name("ToolStripMenuItem49");
		ToolStripMenuItem toolStripMenuItem29 = ToolStripMenuItem49;
		size = new Size(24, 20);
		((ToolStripItem)toolStripMenuItem29).set_Size(size);
		((ToolStripItem)ToolStripMenuItem49).set_Text("&?");
		((ToolStripItem)ToolStripMenuItem50).set_Name("ToolStripMenuItem50");
		ToolStripMenuItem50.set_ShortcutKeys((Keys)131184);
		ToolStripMenuItem toolStripMenuItem30 = ToolStripMenuItem50;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem30).set_Size(size);
		((ToolStripItem)ToolStripMenuItem50).set_Text("&Contenu");
		((ToolStripItem)ToolStripMenuItem51).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem51.Image"));
		((ToolStripItem)ToolStripMenuItem51).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem51).set_Name("ToolStripMenuItem51");
		ToolStripMenuItem toolStripMenuItem31 = ToolStripMenuItem51;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem31).set_Size(size);
		((ToolStripItem)ToolStripMenuItem51).set_Text("&Index");
		((ToolStripItem)ToolStripMenuItem52).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem52.Image"));
		((ToolStripItem)ToolStripMenuItem52).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem52).set_Name("ToolStripMenuItem52");
		ToolStripMenuItem toolStripMenuItem32 = ToolStripMenuItem52;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem32).set_Size(size);
		((ToolStripItem)ToolStripMenuItem52).set_Text("&Rechercher");
		((ToolStripItem)ToolStripSeparator22).set_Name("ToolStripSeparator22");
		ToolStripSeparator toolStripSeparator14 = ToolStripSeparator22;
		size = new Size(163, 6);
		((ToolStripItem)toolStripSeparator14).set_Size(size);
		((ToolStripItem)ToolStripMenuItem53).set_Name("ToolStripMenuItem53");
		ToolStripMenuItem toolStripMenuItem33 = ToolStripMenuItem53;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem33).set_Size(size);
		((ToolStripItem)ToolStripMenuItem53).set_Text("À pr&opos de...");
		((ToolStrip)StatusStrip2).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel2 });
		StatusStrip statusStrip3 = StatusStrip2;
		location = new Point(0, 338);
		((Control)statusStrip3).set_Location(location);
		((Control)StatusStrip2).set_Name("StatusStrip2");
		StatusStrip statusStrip4 = StatusStrip2;
		size = new Size(211, 22);
		((Control)statusStrip4).set_Size(size);
		((Control)StatusStrip2).set_TabIndex(13);
		((Control)StatusStrip2).set_Text("StatusStrip");
		((ToolStripItem)ToolStripStatusLabel2).set_Name("ToolStripStatusLabel2");
		ToolStripStatusLabel toolStripStatusLabel2 = ToolStripStatusLabel2;
		size = new Size(27, 17);
		((ToolStripItem)toolStripStatusLabel2).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel2).set_Text("État");
		ToolStrip2.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripButton4,
			(ToolStripItem)ToolStripButton5,
			(ToolStripItem)ToolStripButton6,
			(ToolStripItem)ToolStripSeparator24,
			(ToolStripItem)ToolStripButton3,
			(ToolStripItem)ToolStripButton2,
			(ToolStripItem)ToolStripSeparator23,
			(ToolStripItem)ToolStripButton1
		});
		ToolStrip toolStrip3 = ToolStrip2;
		location = new Point(0, 49);
		((Control)toolStrip3).set_Location(location);
		((Control)ToolStrip2).set_Name("ToolStrip2");
		ToolStrip toolStrip4 = ToolStrip2;
		size = new Size(211, 25);
		((Control)toolStrip4).set_Size(size);
		((Control)ToolStrip2).set_TabIndex(12);
		((Control)ToolStrip2).set_Text("ToolStrip");
		((ToolStripItem)ToolStripButton4).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton4).set_Image((Image)componentResourceManager.GetObject("ToolStripButton4.Image"));
		((ToolStripItem)ToolStripButton4).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton4).set_Name("ToolStripButton4");
		ToolStripButton toolStripButton = ToolStripButton4;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton).set_Size(size);
		((ToolStripItem)ToolStripButton4).set_Text("Nouveau");
		((ToolStripItem)ToolStripButton5).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton5).set_Image((Image)componentResourceManager.GetObject("ToolStripButton5.Image"));
		((ToolStripItem)ToolStripButton5).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton5).set_Name("ToolStripButton5");
		ToolStripButton toolStripButton2 = ToolStripButton5;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton2).set_Size(size);
		((ToolStripItem)ToolStripButton5).set_Text("Ouvrir");
		((ToolStripItem)ToolStripButton6).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton6).set_Image((Image)componentResourceManager.GetObject("ToolStripButton6.Image"));
		((ToolStripItem)ToolStripButton6).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton6).set_Name("ToolStripButton6");
		ToolStripButton toolStripButton3 = ToolStripButton6;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton3).set_Size(size);
		((ToolStripItem)ToolStripButton6).set_Text("Enregistrer");
		((ToolStripItem)ToolStripSeparator24).set_Name("ToolStripSeparator24");
		ToolStripSeparator toolStripSeparator15 = ToolStripSeparator24;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator15).set_Size(size);
		((ToolStripItem)ToolStripButton3).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton3).set_Image((Image)componentResourceManager.GetObject("ToolStripButton3.Image"));
		((ToolStripItem)ToolStripButton3).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton3).set_Name("ToolStripButton3");
		ToolStripButton toolStripButton4 = ToolStripButton3;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton4).set_Size(size);
		((ToolStripItem)ToolStripButton3).set_Text("Imprimer");
		((ToolStripItem)ToolStripButton2).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton2).set_Image((Image)componentResourceManager.GetObject("ToolStripButton2.Image"));
		((ToolStripItem)ToolStripButton2).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton2).set_Name("ToolStripButton2");
		ToolStripButton toolStripButton5 = ToolStripButton2;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton5).set_Size(size);
		((ToolStripItem)ToolStripButton2).set_Text("Aperçu avant impression");
		((ToolStripItem)ToolStripSeparator23).set_Name("ToolStripSeparator23");
		ToolStripSeparator toolStripSeparator16 = ToolStripSeparator23;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator16).set_Size(size);
		((ToolStripItem)ToolStripButton1).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton1).set_Image((Image)componentResourceManager.GetObject("ToolStripButton1.Image"));
		((ToolStripItem)ToolStripButton1).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton1).set_Name("ToolStripButton1");
		ToolStripButton toolStripButton6 = ToolStripButton1;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton6).set_Size(size);
		((ToolStripItem)ToolStripButton1).set_Text("Aide");
		((ToolStrip)MenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)FileMenu,
			(ToolStripItem)EditMenu,
			(ToolStripItem)ViewMenu,
			(ToolStripItem)ToolsMenu,
			(ToolStripItem)WindowsMenu,
			(ToolStripItem)HelpMenu
		});
		MenuStrip menuStrip5 = MenuStrip1;
		location = new Point(0, 25);
		((Control)menuStrip5).set_Location(location);
		MenuStrip1.set_MdiWindowListItem(WindowsMenu);
		((Control)MenuStrip1).set_Name("MenuStrip1");
		MenuStrip menuStrip6 = MenuStrip1;
		size = new Size(211, 24);
		((Control)menuStrip6).set_Size(size);
		((Control)MenuStrip1).set_TabIndex(8);
		((Control)MenuStrip1).set_Text("MenuStrip1");
		((ToolStripDropDownItem)FileMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)ToolStripMenuItem1,
			(ToolStripItem)ToolStripMenuItem2,
			(ToolStripItem)ToolStripSeparator9,
			(ToolStripItem)ToolStripMenuItem3,
			(ToolStripItem)ToolStripMenuItem4,
			(ToolStripItem)ToolStripSeparator10,
			(ToolStripItem)ToolStripMenuItem5,
			(ToolStripItem)ToolStripMenuItem6,
			(ToolStripItem)PrintSetupToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator11,
			(ToolStripItem)ToolStripMenuItem7
		});
		((ToolStripItem)FileMenu).set_ImageTransparentColor(SystemColors.ActiveBorder);
		((ToolStripItem)FileMenu).set_Name("FileMenu");
		ToolStripMenuItem fileMenu = FileMenu;
		size = new Size(54, 20);
		((ToolStripItem)fileMenu).set_Size(size);
		((ToolStripItem)FileMenu).set_Text("&Fichier");
		((ToolStripItem)ToolStripMenuItem1).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem1.Image"));
		((ToolStripItem)ToolStripMenuItem1).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem1).set_Name("ToolStripMenuItem1");
		ToolStripMenuItem1.set_ShortcutKeys((Keys)131150);
		ToolStripMenuItem toolStripMenuItem34 = ToolStripMenuItem1;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem34).set_Size(size);
		((ToolStripItem)ToolStripMenuItem1).set_Text("&Nouveau");
		((ToolStripItem)ToolStripMenuItem2).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem2.Image"));
		((ToolStripItem)ToolStripMenuItem2).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem2).set_Name("ToolStripMenuItem2");
		ToolStripMenuItem2.set_ShortcutKeys((Keys)131151);
		ToolStripMenuItem toolStripMenuItem35 = ToolStripMenuItem2;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem35).set_Size(size);
		((ToolStripItem)ToolStripMenuItem2).set_Text("&Ouvrir");
		((ToolStripItem)ToolStripSeparator9).set_Name("ToolStripSeparator9");
		ToolStripSeparator toolStripSeparator17 = ToolStripSeparator9;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator17).set_Size(size);
		((ToolStripItem)ToolStripMenuItem3).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem3.Image"));
		((ToolStripItem)ToolStripMenuItem3).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem3).set_Name("ToolStripMenuItem3");
		ToolStripMenuItem3.set_ShortcutKeys((Keys)131155);
		ToolStripMenuItem toolStripMenuItem36 = ToolStripMenuItem3;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem36).set_Size(size);
		((ToolStripItem)ToolStripMenuItem3).set_Text("&Enregistrer");
		((ToolStripItem)ToolStripMenuItem4).set_Name("ToolStripMenuItem4");
		ToolStripMenuItem toolStripMenuItem37 = ToolStripMenuItem4;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem37).set_Size(size);
		((ToolStripItem)ToolStripMenuItem4).set_Text("Enregistrer &sous");
		((ToolStripItem)ToolStripSeparator10).set_Name("ToolStripSeparator10");
		ToolStripSeparator toolStripSeparator18 = ToolStripSeparator10;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator18).set_Size(size);
		((ToolStripItem)ToolStripMenuItem5).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem5.Image"));
		((ToolStripItem)ToolStripMenuItem5).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem5).set_Name("ToolStripMenuItem5");
		ToolStripMenuItem5.set_ShortcutKeys((Keys)131152);
		ToolStripMenuItem toolStripMenuItem38 = ToolStripMenuItem5;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem38).set_Size(size);
		((ToolStripItem)ToolStripMenuItem5).set_Text("&Imprimer");
		((ToolStripItem)ToolStripMenuItem6).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem6.Image"));
		((ToolStripItem)ToolStripMenuItem6).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem6).set_Name("ToolStripMenuItem6");
		ToolStripMenuItem toolStripMenuItem39 = ToolStripMenuItem6;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem39).set_Size(size);
		((ToolStripItem)ToolStripMenuItem6).set_Text("Aperçu a&vant impression");
		((ToolStripItem)PrintSetupToolStripMenuItem).set_Name("PrintSetupToolStripMenuItem");
		ToolStripMenuItem printSetupToolStripMenuItem = PrintSetupToolStripMenuItem;
		size = new Size(231, 22);
		((ToolStripItem)printSetupToolStripMenuItem).set_Size(size);
		((ToolStripItem)PrintSetupToolStripMenuItem).set_Text("Configuration de l'impression");
		((ToolStripItem)ToolStripSeparator11).set_Name("ToolStripSeparator11");
		ToolStripSeparator toolStripSeparator19 = ToolStripSeparator11;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator19).set_Size(size);
		((ToolStripItem)ToolStripMenuItem7).set_Name("ToolStripMenuItem7");
		ToolStripMenuItem toolStripMenuItem40 = ToolStripMenuItem7;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem40).set_Size(size);
		((ToolStripItem)ToolStripMenuItem7).set_Text("&Quitter");
		((ToolStripDropDownItem)EditMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripMenuItem8,
			(ToolStripItem)ToolStripMenuItem9,
			(ToolStripItem)ToolStripSeparator12,
			(ToolStripItem)ToolStripMenuItem10,
			(ToolStripItem)ToolStripMenuItem11,
			(ToolStripItem)ToolStripMenuItem12,
			(ToolStripItem)ToolStripSeparator13,
			(ToolStripItem)ToolStripMenuItem13
		});
		((ToolStripItem)EditMenu).set_Name("EditMenu");
		ToolStripMenuItem editMenu = EditMenu;
		size = new Size(56, 20);
		((ToolStripItem)editMenu).set_Size(size);
		((ToolStripItem)EditMenu).set_Text("&Edition");
		((ToolStripItem)ToolStripMenuItem8).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem8.Image"));
		((ToolStripItem)ToolStripMenuItem8).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem8).set_Name("ToolStripMenuItem8");
		ToolStripMenuItem8.set_ShortcutKeys((Keys)131162);
		ToolStripMenuItem toolStripMenuItem41 = ToolStripMenuItem8;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem41).set_Size(size);
		((ToolStripItem)ToolStripMenuItem8).set_Text("&Annuler");
		((ToolStripItem)ToolStripMenuItem9).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem9.Image"));
		((ToolStripItem)ToolStripMenuItem9).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem9).set_Name("ToolStripMenuItem9");
		ToolStripMenuItem9.set_ShortcutKeys((Keys)131161);
		ToolStripMenuItem toolStripMenuItem42 = ToolStripMenuItem9;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem42).set_Size(size);
		((ToolStripItem)ToolStripMenuItem9).set_Text("&Rétablir");
		((ToolStripItem)ToolStripSeparator12).set_Name("ToolStripSeparator12");
		ToolStripSeparator toolStripSeparator20 = ToolStripSeparator12;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator20).set_Size(size);
		((ToolStripItem)ToolStripMenuItem10).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem10.Image"));
		((ToolStripItem)ToolStripMenuItem10).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem10).set_Name("ToolStripMenuItem10");
		ToolStripMenuItem10.set_ShortcutKeys((Keys)131160);
		ToolStripMenuItem toolStripMenuItem43 = ToolStripMenuItem10;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem43).set_Size(size);
		((ToolStripItem)ToolStripMenuItem10).set_Text("Co&uper");
		((ToolStripItem)ToolStripMenuItem11).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem11.Image"));
		((ToolStripItem)ToolStripMenuItem11).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem11).set_Name("ToolStripMenuItem11");
		ToolStripMenuItem11.set_ShortcutKeys((Keys)131139);
		ToolStripMenuItem toolStripMenuItem44 = ToolStripMenuItem11;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem44).set_Size(size);
		((ToolStripItem)ToolStripMenuItem11).set_Text("&Copier");
		((ToolStripItem)ToolStripMenuItem12).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem12.Image"));
		((ToolStripItem)ToolStripMenuItem12).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem12).set_Name("ToolStripMenuItem12");
		ToolStripMenuItem12.set_ShortcutKeys((Keys)131158);
		ToolStripMenuItem toolStripMenuItem45 = ToolStripMenuItem12;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem45).set_Size(size);
		((ToolStripItem)ToolStripMenuItem12).set_Text("&Coller");
		((ToolStripItem)ToolStripSeparator13).set_Name("ToolStripSeparator13");
		ToolStripSeparator toolStripSeparator21 = ToolStripSeparator13;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator21).set_Size(size);
		((ToolStripItem)ToolStripMenuItem13).set_Name("ToolStripMenuItem13");
		ToolStripMenuItem13.set_ShortcutKeys((Keys)131137);
		ToolStripMenuItem toolStripMenuItem46 = ToolStripMenuItem13;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem46).set_Size(size);
		((ToolStripItem)ToolStripMenuItem13).set_Text("Sélectionner &tout");
		((ToolStripDropDownItem)ViewMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolStripMenuItem14,
			(ToolStripItem)ToolStripMenuItem15
		});
		((ToolStripItem)ViewMenu).set_Name("ViewMenu");
		ToolStripMenuItem viewMenu = ViewMenu;
		size = new Size(70, 20);
		((ToolStripItem)viewMenu).set_Size(size);
		((ToolStripItem)ViewMenu).set_Text("&Affichage");
		ToolStripMenuItem14.set_Checked(true);
		ToolStripMenuItem14.set_CheckOnClick(true);
		ToolStripMenuItem14.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem14).set_Name("ToolStripMenuItem14");
		ToolStripMenuItem toolStripMenuItem47 = ToolStripMenuItem14;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem47).set_Size(size);
		((ToolStripItem)ToolStripMenuItem14).set_Text("&Barre d'outils");
		ToolStripMenuItem15.set_Checked(true);
		ToolStripMenuItem15.set_CheckOnClick(true);
		ToolStripMenuItem15.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem15).set_Name("ToolStripMenuItem15");
		ToolStripMenuItem toolStripMenuItem48 = ToolStripMenuItem15;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem48).set_Size(size);
		((ToolStripItem)ToolStripMenuItem15).set_Text("&Barre d'état");
		((ToolStripDropDownItem)ToolsMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripMenuItem16 });
		((ToolStripItem)ToolsMenu).set_Name("ToolsMenu");
		ToolStripMenuItem toolsMenu = ToolsMenu;
		size = new Size(50, 20);
		((ToolStripItem)toolsMenu).set_Size(size);
		((ToolStripItem)ToolsMenu).set_Text("&Outils");
		((ToolStripItem)ToolStripMenuItem16).set_Name("ToolStripMenuItem16");
		ToolStripMenuItem toolStripMenuItem49 = ToolStripMenuItem16;
		size = new Size(116, 22);
		((ToolStripItem)toolStripMenuItem49).set_Size(size);
		((ToolStripItem)ToolStripMenuItem16).set_Text("&Options");
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
			(ToolStripItem)ToolStripMenuItem17,
			(ToolStripItem)ToolStripMenuItem18,
			(ToolStripItem)ToolStripMenuItem19,
			(ToolStripItem)ToolStripSeparator14,
			(ToolStripItem)ToolStripMenuItem20
		});
		((ToolStripItem)HelpMenu).set_Name("HelpMenu");
		ToolStripMenuItem helpMenu = HelpMenu;
		size = new Size(24, 20);
		((ToolStripItem)helpMenu).set_Size(size);
		((ToolStripItem)HelpMenu).set_Text("&?");
		((ToolStripItem)ToolStripMenuItem17).set_Name("ToolStripMenuItem17");
		ToolStripMenuItem17.set_ShortcutKeys((Keys)131184);
		ToolStripMenuItem toolStripMenuItem50 = ToolStripMenuItem17;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem50).set_Size(size);
		((ToolStripItem)ToolStripMenuItem17).set_Text("&Contenu");
		((ToolStripItem)ToolStripMenuItem18).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem18.Image"));
		((ToolStripItem)ToolStripMenuItem18).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem18).set_Name("ToolStripMenuItem18");
		ToolStripMenuItem toolStripMenuItem51 = ToolStripMenuItem18;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem51).set_Size(size);
		((ToolStripItem)ToolStripMenuItem18).set_Text("&Index");
		((ToolStripItem)ToolStripMenuItem19).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem19.Image"));
		((ToolStripItem)ToolStripMenuItem19).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem19).set_Name("ToolStripMenuItem19");
		ToolStripMenuItem toolStripMenuItem52 = ToolStripMenuItem19;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem52).set_Size(size);
		((ToolStripItem)ToolStripMenuItem19).set_Text("&Rechercher");
		((ToolStripItem)ToolStripSeparator14).set_Name("ToolStripSeparator14");
		ToolStripSeparator toolStripSeparator22 = ToolStripSeparator14;
		size = new Size(163, 6);
		((ToolStripItem)toolStripSeparator22).set_Size(size);
		((ToolStripItem)ToolStripMenuItem20).set_Name("ToolStripMenuItem20");
		ToolStripMenuItem toolStripMenuItem53 = ToolStripMenuItem20;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem53).set_Size(size);
		((ToolStripItem)ToolStripMenuItem20).set_Text("À pr&opos de...");
		((ToolStrip)StatusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel1 });
		StatusStrip statusStrip5 = StatusStrip1;
		location = new Point(0, 360);
		((Control)statusStrip5).set_Location(location);
		((Control)StatusStrip1).set_Name("StatusStrip1");
		StatusStrip statusStrip6 = StatusStrip1;
		size = new Size(211, 22);
		((Control)statusStrip6).set_Size(size);
		((Control)StatusStrip1).set_TabIndex(10);
		((Control)StatusStrip1).set_Text("StatusStrip");
		((ToolStripItem)ToolStripStatusLabel1).set_Name("ToolStripStatusLabel1");
		ToolStripStatusLabel toolStripStatusLabel3 = ToolStripStatusLabel1;
		size = new Size(27, 17);
		((ToolStripItem)toolStripStatusLabel3).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel1).set_Text("État");
		ToolStrip1.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)NewToolStripButton,
			(ToolStripItem)OpenToolStripButton,
			(ToolStripItem)SaveToolStripButton,
			(ToolStripItem)ToolStripSeparator16,
			(ToolStripItem)PrintToolStripButton,
			(ToolStripItem)PrintPreviewToolStripButton,
			(ToolStripItem)ToolStripSeparator15,
			(ToolStripItem)HelpToolStripButton
		});
		ToolStrip toolStrip5 = ToolStrip1;
		location = new Point(0, 0);
		((Control)toolStrip5).set_Location(location);
		((Control)ToolStrip1).set_Name("ToolStrip1");
		ToolStrip toolStrip6 = ToolStrip1;
		size = new Size(211, 25);
		((Control)toolStrip6).set_Size(size);
		((Control)ToolStrip1).set_TabIndex(9);
		((Control)ToolStrip1).set_Text("ToolStrip");
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
		((ToolStripItem)ToolStripSeparator16).set_Name("ToolStripSeparator16");
		ToolStripSeparator toolStripSeparator23 = ToolStripSeparator16;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator23).set_Size(size);
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
		((ToolStripItem)ToolStripSeparator15).set_Name("ToolStripSeparator15");
		ToolStripSeparator toolStripSeparator24 = ToolStripSeparator15;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator24).set_Size(size);
		((ToolStripItem)HelpToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)HelpToolStripButton).set_Image((Image)componentResourceManager.GetObject("HelpToolStripButton.Image"));
		((ToolStripItem)HelpToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)HelpToolStripButton).set_Name("HelpToolStripButton");
		ToolStripButton helpToolStripButton = HelpToolStripButton;
		size = new Size(23, 22);
		((ToolStripItem)helpToolStripButton).set_Size(size);
		((ToolStripItem)HelpToolStripButton).set_Text("Aide");
		((Control)TreeView).set_Dock((DockStyle)5);
		TreeView.set_ImageIndex(0);
		TreeView.set_ImageList(TreeNodeImageList);
		TreeView treeView = TreeView;
		location = new Point(0, 0);
		((Control)treeView).set_Location(location);
		((Control)TreeView).set_Name("TreeView");
		TreeView.set_SelectedImageIndex(1);
		TreeView.set_ShowLines(false);
		TreeView treeView2 = TreeView;
		size = new Size(211, 382);
		((Control)treeView2).set_Size(size);
		((Control)TreeView).set_TabIndex(0);
		((Control)ListView).set_Dock((DockStyle)5);
		ListView.set_LargeImageList(ListViewLargeImageList);
		ListView listView = ListView;
		location = new Point(0, 0);
		((Control)listView).set_Location(location);
		((Control)ListView).set_Name("ListView");
		ListView listView2 = ListView;
		size = new Size(417, 382);
		((Control)listView2).set_Size(size);
		ListView.set_SmallImageList(ListViewSmallImageList);
		((Control)ListView).set_TabIndex(0);
		ListView.set_UseCompatibleStateImageBehavior(false);
		ListViewLargeImageList.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ListViewLargeImageList.ImageStream"));
		ListViewLargeImageList.set_TransparentColor(Color.Transparent);
		ListViewLargeImageList.get_Images().SetKeyName(0, "Graph1");
		ListViewLargeImageList.get_Images().SetKeyName(1, "Graph2");
		ListViewLargeImageList.get_Images().SetKeyName(2, "Graph3");
		ListViewSmallImageList.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ListViewSmallImageList.ImageStream"));
		ListViewSmallImageList.set_TransparentColor(Color.Transparent);
		ListViewSmallImageList.get_Images().SetKeyName(0, "Graph1");
		ListViewSmallImageList.get_Images().SetKeyName(1, "Graph2");
		ListViewSmallImageList.get_Images().SetKeyName(2, "Graph3");
		((ToolStrip)MenuStrip3).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem54,
			(ToolStripItem)ToolStripMenuItem63,
			(ToolStripItem)ToolStripMenuItem70,
			(ToolStripItem)ToolStripMenuItem73,
			(ToolStripItem)ToolStripMenuItem75,
			(ToolStripItem)ToolStripMenuItem82
		});
		MenuStrip menuStrip7 = MenuStrip3;
		location = new Point(0, 123);
		((Control)menuStrip7).set_Location(location);
		MenuStrip3.set_MdiWindowListItem(ToolStripMenuItem75);
		((Control)MenuStrip3).set_Name("MenuStrip3");
		MenuStrip menuStrip8 = MenuStrip3;
		size = new Size(211, 24);
		((Control)menuStrip8).set_Size(size);
		((Control)MenuStrip3).set_TabIndex(14);
		((Control)MenuStrip3).set_Text("MenuStrip3");
		((ToolStripDropDownItem)ToolStripMenuItem54).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)ToolStripMenuItem55,
			(ToolStripItem)ToolStripMenuItem56,
			(ToolStripItem)ToolStripSeparator25,
			(ToolStripItem)ToolStripMenuItem57,
			(ToolStripItem)ToolStripMenuItem58,
			(ToolStripItem)ToolStripSeparator26,
			(ToolStripItem)ToolStripMenuItem59,
			(ToolStripItem)ToolStripMenuItem60,
			(ToolStripItem)ToolStripMenuItem61,
			(ToolStripItem)ToolStripSeparator27,
			(ToolStripItem)ToolStripMenuItem62
		});
		((ToolStripItem)ToolStripMenuItem54).set_ImageTransparentColor(SystemColors.ActiveBorder);
		((ToolStripItem)ToolStripMenuItem54).set_Name("ToolStripMenuItem54");
		ToolStripMenuItem toolStripMenuItem54 = ToolStripMenuItem54;
		size = new Size(54, 20);
		((ToolStripItem)toolStripMenuItem54).set_Size(size);
		((ToolStripItem)ToolStripMenuItem54).set_Text("&Fichier");
		((ToolStripItem)ToolStripMenuItem55).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem55.Image"));
		((ToolStripItem)ToolStripMenuItem55).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem55).set_Name("ToolStripMenuItem55");
		ToolStripMenuItem55.set_ShortcutKeys((Keys)131150);
		ToolStripMenuItem toolStripMenuItem55 = ToolStripMenuItem55;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem55).set_Size(size);
		((ToolStripItem)ToolStripMenuItem55).set_Text("&Nouveau");
		((ToolStripItem)ToolStripMenuItem56).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem56.Image"));
		((ToolStripItem)ToolStripMenuItem56).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem56).set_Name("ToolStripMenuItem56");
		ToolStripMenuItem56.set_ShortcutKeys((Keys)131151);
		ToolStripMenuItem toolStripMenuItem56 = ToolStripMenuItem56;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem56).set_Size(size);
		((ToolStripItem)ToolStripMenuItem56).set_Text("&Ouvrir");
		((ToolStripItem)ToolStripSeparator25).set_Name("ToolStripSeparator25");
		ToolStripSeparator toolStripSeparator25 = ToolStripSeparator25;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator25).set_Size(size);
		((ToolStripItem)ToolStripMenuItem57).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem57.Image"));
		((ToolStripItem)ToolStripMenuItem57).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem57).set_Name("ToolStripMenuItem57");
		ToolStripMenuItem57.set_ShortcutKeys((Keys)131155);
		ToolStripMenuItem toolStripMenuItem57 = ToolStripMenuItem57;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem57).set_Size(size);
		((ToolStripItem)ToolStripMenuItem57).set_Text("&Enregistrer");
		((ToolStripItem)ToolStripMenuItem58).set_Name("ToolStripMenuItem58");
		ToolStripMenuItem toolStripMenuItem58 = ToolStripMenuItem58;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem58).set_Size(size);
		((ToolStripItem)ToolStripMenuItem58).set_Text("Enregistrer &sous");
		((ToolStripItem)ToolStripSeparator26).set_Name("ToolStripSeparator26");
		ToolStripSeparator toolStripSeparator26 = ToolStripSeparator26;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator26).set_Size(size);
		((ToolStripItem)ToolStripMenuItem59).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem59.Image"));
		((ToolStripItem)ToolStripMenuItem59).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem59).set_Name("ToolStripMenuItem59");
		ToolStripMenuItem59.set_ShortcutKeys((Keys)131152);
		ToolStripMenuItem toolStripMenuItem59 = ToolStripMenuItem59;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem59).set_Size(size);
		((ToolStripItem)ToolStripMenuItem59).set_Text("&Imprimer");
		((ToolStripItem)ToolStripMenuItem60).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem60.Image"));
		((ToolStripItem)ToolStripMenuItem60).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem60).set_Name("ToolStripMenuItem60");
		ToolStripMenuItem toolStripMenuItem60 = ToolStripMenuItem60;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem60).set_Size(size);
		((ToolStripItem)ToolStripMenuItem60).set_Text("Aperçu a&vant impression");
		((ToolStripItem)ToolStripMenuItem61).set_Name("ToolStripMenuItem61");
		ToolStripMenuItem toolStripMenuItem61 = ToolStripMenuItem61;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem61).set_Size(size);
		((ToolStripItem)ToolStripMenuItem61).set_Text("Configuration de l'impression");
		((ToolStripItem)ToolStripSeparator27).set_Name("ToolStripSeparator27");
		ToolStripSeparator toolStripSeparator27 = ToolStripSeparator27;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator27).set_Size(size);
		((ToolStripItem)ToolStripMenuItem62).set_Name("ToolStripMenuItem62");
		ToolStripMenuItem toolStripMenuItem62 = ToolStripMenuItem62;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem62).set_Size(size);
		((ToolStripItem)ToolStripMenuItem62).set_Text("&Quitter");
		((ToolStripDropDownItem)ToolStripMenuItem63).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripMenuItem64,
			(ToolStripItem)ToolStripMenuItem65,
			(ToolStripItem)ToolStripSeparator28,
			(ToolStripItem)ToolStripMenuItem66,
			(ToolStripItem)ToolStripMenuItem67,
			(ToolStripItem)ToolStripMenuItem68,
			(ToolStripItem)ToolStripSeparator29,
			(ToolStripItem)ToolStripMenuItem69
		});
		((ToolStripItem)ToolStripMenuItem63).set_Name("ToolStripMenuItem63");
		ToolStripMenuItem toolStripMenuItem63 = ToolStripMenuItem63;
		size = new Size(56, 20);
		((ToolStripItem)toolStripMenuItem63).set_Size(size);
		((ToolStripItem)ToolStripMenuItem63).set_Text("&Edition");
		((ToolStripItem)ToolStripMenuItem64).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem64.Image"));
		((ToolStripItem)ToolStripMenuItem64).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem64).set_Name("ToolStripMenuItem64");
		ToolStripMenuItem64.set_ShortcutKeys((Keys)131162);
		ToolStripMenuItem toolStripMenuItem64 = ToolStripMenuItem64;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem64).set_Size(size);
		((ToolStripItem)ToolStripMenuItem64).set_Text("&Annuler");
		((ToolStripItem)ToolStripMenuItem65).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem65.Image"));
		((ToolStripItem)ToolStripMenuItem65).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem65).set_Name("ToolStripMenuItem65");
		ToolStripMenuItem65.set_ShortcutKeys((Keys)131161);
		ToolStripMenuItem toolStripMenuItem65 = ToolStripMenuItem65;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem65).set_Size(size);
		((ToolStripItem)ToolStripMenuItem65).set_Text("&Rétablir");
		((ToolStripItem)ToolStripSeparator28).set_Name("ToolStripSeparator28");
		ToolStripSeparator toolStripSeparator28 = ToolStripSeparator28;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator28).set_Size(size);
		((ToolStripItem)ToolStripMenuItem66).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem66.Image"));
		((ToolStripItem)ToolStripMenuItem66).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem66).set_Name("ToolStripMenuItem66");
		ToolStripMenuItem66.set_ShortcutKeys((Keys)131160);
		ToolStripMenuItem toolStripMenuItem66 = ToolStripMenuItem66;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem66).set_Size(size);
		((ToolStripItem)ToolStripMenuItem66).set_Text("Co&uper");
		((ToolStripItem)ToolStripMenuItem67).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem67.Image"));
		((ToolStripItem)ToolStripMenuItem67).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem67).set_Name("ToolStripMenuItem67");
		ToolStripMenuItem67.set_ShortcutKeys((Keys)131139);
		ToolStripMenuItem toolStripMenuItem67 = ToolStripMenuItem67;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem67).set_Size(size);
		((ToolStripItem)ToolStripMenuItem67).set_Text("&Copier");
		((ToolStripItem)ToolStripMenuItem68).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem68.Image"));
		((ToolStripItem)ToolStripMenuItem68).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem68).set_Name("ToolStripMenuItem68");
		ToolStripMenuItem68.set_ShortcutKeys((Keys)131158);
		ToolStripMenuItem toolStripMenuItem68 = ToolStripMenuItem68;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem68).set_Size(size);
		((ToolStripItem)ToolStripMenuItem68).set_Text("&Coller");
		((ToolStripItem)ToolStripSeparator29).set_Name("ToolStripSeparator29");
		ToolStripSeparator toolStripSeparator29 = ToolStripSeparator29;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator29).set_Size(size);
		((ToolStripItem)ToolStripMenuItem69).set_Name("ToolStripMenuItem69");
		ToolStripMenuItem69.set_ShortcutKeys((Keys)131137);
		ToolStripMenuItem toolStripMenuItem69 = ToolStripMenuItem69;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem69).set_Size(size);
		((ToolStripItem)ToolStripMenuItem69).set_Text("Sélectionner &tout");
		((ToolStripDropDownItem)ToolStripMenuItem70).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolStripMenuItem71,
			(ToolStripItem)ToolStripMenuItem72
		});
		((ToolStripItem)ToolStripMenuItem70).set_Name("ToolStripMenuItem70");
		ToolStripMenuItem toolStripMenuItem70 = ToolStripMenuItem70;
		size = new Size(70, 20);
		((ToolStripItem)toolStripMenuItem70).set_Size(size);
		((ToolStripItem)ToolStripMenuItem70).set_Text("&Affichage");
		ToolStripMenuItem71.set_Checked(true);
		ToolStripMenuItem71.set_CheckOnClick(true);
		ToolStripMenuItem71.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem71).set_Name("ToolStripMenuItem71");
		ToolStripMenuItem toolStripMenuItem71 = ToolStripMenuItem71;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem71).set_Size(size);
		((ToolStripItem)ToolStripMenuItem71).set_Text("&Barre d'outils");
		ToolStripMenuItem72.set_Checked(true);
		ToolStripMenuItem72.set_CheckOnClick(true);
		ToolStripMenuItem72.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem72).set_Name("ToolStripMenuItem72");
		ToolStripMenuItem toolStripMenuItem72 = ToolStripMenuItem72;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem72).set_Size(size);
		((ToolStripItem)ToolStripMenuItem72).set_Text("&Barre d'état");
		((ToolStripDropDownItem)ToolStripMenuItem73).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripMenuItem74 });
		((ToolStripItem)ToolStripMenuItem73).set_Name("ToolStripMenuItem73");
		ToolStripMenuItem toolStripMenuItem73 = ToolStripMenuItem73;
		size = new Size(50, 20);
		((ToolStripItem)toolStripMenuItem73).set_Size(size);
		((ToolStripItem)ToolStripMenuItem73).set_Text("&Outils");
		((ToolStripItem)ToolStripMenuItem74).set_Name("ToolStripMenuItem74");
		ToolStripMenuItem toolStripMenuItem74 = ToolStripMenuItem74;
		size = new Size(116, 22);
		((ToolStripItem)toolStripMenuItem74).set_Size(size);
		((ToolStripItem)ToolStripMenuItem74).set_Text("&Options");
		((ToolStripDropDownItem)ToolStripMenuItem75).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem76,
			(ToolStripItem)ToolStripMenuItem77,
			(ToolStripItem)ToolStripMenuItem78,
			(ToolStripItem)ToolStripMenuItem79,
			(ToolStripItem)ToolStripMenuItem80,
			(ToolStripItem)ToolStripMenuItem81
		});
		((ToolStripItem)ToolStripMenuItem75).set_Name("ToolStripMenuItem75");
		ToolStripMenuItem toolStripMenuItem75 = ToolStripMenuItem75;
		size = new Size(63, 20);
		((ToolStripItem)toolStripMenuItem75).set_Size(size);
		((ToolStripItem)ToolStripMenuItem75).set_Text("F&enêtres");
		((ToolStripItem)ToolStripMenuItem76).set_Name("ToolStripMenuItem76");
		ToolStripMenuItem toolStripMenuItem76 = ToolStripMenuItem76;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem76).set_Size(size);
		((ToolStripItem)ToolStripMenuItem76).set_Text("&Nouvelle fenêtre");
		((ToolStripItem)ToolStripMenuItem77).set_Name("ToolStripMenuItem77");
		ToolStripMenuItem toolStripMenuItem77 = ToolStripMenuItem77;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem77).set_Size(size);
		((ToolStripItem)ToolStripMenuItem77).set_Text("&Cascade");
		((ToolStripItem)ToolStripMenuItem78).set_Name("ToolStripMenuItem78");
		ToolStripMenuItem toolStripMenuItem78 = ToolStripMenuItem78;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem78).set_Size(size);
		((ToolStripItem)ToolStripMenuItem78).set_Text("Mosaïque &verticale");
		((ToolStripItem)ToolStripMenuItem79).set_Name("ToolStripMenuItem79");
		ToolStripMenuItem toolStripMenuItem79 = ToolStripMenuItem79;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem79).set_Size(size);
		((ToolStripItem)ToolStripMenuItem79).set_Text("Mosaïque &horizontale");
		((ToolStripItem)ToolStripMenuItem80).set_Name("ToolStripMenuItem80");
		ToolStripMenuItem toolStripMenuItem80 = ToolStripMenuItem80;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem80).set_Size(size);
		((ToolStripItem)ToolStripMenuItem80).set_Text("&Fermer tout");
		((ToolStripItem)ToolStripMenuItem81).set_Name("ToolStripMenuItem81");
		ToolStripMenuItem toolStripMenuItem81 = ToolStripMenuItem81;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem81).set_Size(size);
		((ToolStripItem)ToolStripMenuItem81).set_Text("&Réorganiser les icônes");
		((ToolStripDropDownItem)ToolStripMenuItem82).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ToolStripMenuItem83,
			(ToolStripItem)ToolStripMenuItem84,
			(ToolStripItem)ToolStripMenuItem85,
			(ToolStripItem)ToolStripSeparator30,
			(ToolStripItem)ToolStripMenuItem86
		});
		((ToolStripItem)ToolStripMenuItem82).set_Name("ToolStripMenuItem82");
		ToolStripMenuItem toolStripMenuItem82 = ToolStripMenuItem82;
		size = new Size(24, 20);
		((ToolStripItem)toolStripMenuItem82).set_Size(size);
		((ToolStripItem)ToolStripMenuItem82).set_Text("&?");
		((ToolStripItem)ToolStripMenuItem83).set_Name("ToolStripMenuItem83");
		ToolStripMenuItem83.set_ShortcutKeys((Keys)131184);
		ToolStripMenuItem toolStripMenuItem83 = ToolStripMenuItem83;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem83).set_Size(size);
		((ToolStripItem)ToolStripMenuItem83).set_Text("&Contenu");
		((ToolStripItem)ToolStripMenuItem84).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem84.Image"));
		((ToolStripItem)ToolStripMenuItem84).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem84).set_Name("ToolStripMenuItem84");
		ToolStripMenuItem toolStripMenuItem84 = ToolStripMenuItem84;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem84).set_Size(size);
		((ToolStripItem)ToolStripMenuItem84).set_Text("&Index");
		((ToolStripItem)ToolStripMenuItem85).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem85.Image"));
		((ToolStripItem)ToolStripMenuItem85).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem85).set_Name("ToolStripMenuItem85");
		ToolStripMenuItem toolStripMenuItem85 = ToolStripMenuItem85;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem85).set_Size(size);
		((ToolStripItem)ToolStripMenuItem85).set_Text("&Rechercher");
		((ToolStripItem)ToolStripSeparator30).set_Name("ToolStripSeparator30");
		ToolStripSeparator toolStripSeparator30 = ToolStripSeparator30;
		size = new Size(163, 6);
		((ToolStripItem)toolStripSeparator30).set_Size(size);
		((ToolStripItem)ToolStripMenuItem86).set_Name("ToolStripMenuItem86");
		ToolStripMenuItem toolStripMenuItem86 = ToolStripMenuItem86;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem86).set_Size(size);
		((ToolStripItem)ToolStripMenuItem86).set_Text("À pr&opos de...");
		((ToolStripItem)ToolStripSeparator31).set_Name("ToolStripSeparator31");
		ToolStripSeparator toolStripSeparator31 = ToolStripSeparator31;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator31).set_Size(size);
		((ToolStripItem)ToolStripButton7).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton7).set_Image((Image)componentResourceManager.GetObject("ToolStripButton7.Image"));
		((ToolStripItem)ToolStripButton7).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton7).set_Name("ToolStripButton7");
		ToolStripButton toolStripButton7 = ToolStripButton7;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton7).set_Size(size);
		((ToolStripItem)ToolStripButton7).set_Text("Aide");
		((ToolStrip)StatusStrip3).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel3 });
		StatusStrip statusStrip7 = StatusStrip3;
		location = new Point(0, 316);
		((Control)statusStrip7).set_Location(location);
		((Control)StatusStrip3).set_Name("StatusStrip3");
		StatusStrip statusStrip8 = StatusStrip3;
		size = new Size(211, 22);
		((Control)statusStrip8).set_Size(size);
		((Control)StatusStrip3).set_TabIndex(16);
		((Control)StatusStrip3).set_Text("StatusStrip");
		((ToolStripItem)ToolStripStatusLabel3).set_Name("ToolStripStatusLabel3");
		ToolStripStatusLabel toolStripStatusLabel4 = ToolStripStatusLabel3;
		size = new Size(27, 17);
		((ToolStripItem)toolStripStatusLabel4).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel3).set_Text("État");
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
		((ToolStripItem)ToolStripSeparator32).set_Name("ToolStripSeparator32");
		ToolStripSeparator toolStripSeparator32 = ToolStripSeparator32;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator32).set_Size(size);
		ToolStrip3.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripButton10,
			(ToolStripItem)ToolStripButton11,
			(ToolStripItem)ToolStripButton12,
			(ToolStripItem)ToolStripSeparator32,
			(ToolStripItem)ToolStripButton9,
			(ToolStripItem)ToolStripButton8,
			(ToolStripItem)ToolStripSeparator31,
			(ToolStripItem)ToolStripButton7
		});
		ToolStrip toolStrip7 = ToolStrip3;
		location = new Point(0, 98);
		((Control)toolStrip7).set_Location(location);
		((Control)ToolStrip3).set_Name("ToolStrip3");
		ToolStrip toolStrip8 = ToolStrip3;
		size = new Size(211, 25);
		((Control)toolStrip8).set_Size(size);
		((Control)ToolStrip3).set_TabIndex(15);
		((Control)ToolStrip3).set_Text("ToolStrip");
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
		((ToolStrip)MenuStrip4).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem87,
			(ToolStripItem)ToolStripMenuItem96,
			(ToolStripItem)ToolStripMenuItem103,
			(ToolStripItem)ToolStripMenuItem106,
			(ToolStripItem)ToolStripMenuItem108,
			(ToolStripItem)ToolStripMenuItem115
		});
		MenuStrip menuStrip9 = MenuStrip4;
		location = new Point(0, 172);
		((Control)menuStrip9).set_Location(location);
		MenuStrip4.set_MdiWindowListItem(ToolStripMenuItem108);
		((Control)MenuStrip4).set_Name("MenuStrip4");
		MenuStrip menuStrip10 = MenuStrip4;
		size = new Size(211, 24);
		((Control)menuStrip10).set_Size(size);
		((Control)MenuStrip4).set_TabIndex(17);
		((Control)MenuStrip4).set_Text("MenuStrip4");
		((ToolStripDropDownItem)ToolStripMenuItem87).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)ToolStripMenuItem88,
			(ToolStripItem)ToolStripMenuItem89,
			(ToolStripItem)ToolStripSeparator33,
			(ToolStripItem)ToolStripMenuItem90,
			(ToolStripItem)ToolStripMenuItem91,
			(ToolStripItem)ToolStripSeparator34,
			(ToolStripItem)ToolStripMenuItem92,
			(ToolStripItem)ToolStripMenuItem93,
			(ToolStripItem)ToolStripMenuItem94,
			(ToolStripItem)ToolStripSeparator35,
			(ToolStripItem)ToolStripMenuItem95
		});
		((ToolStripItem)ToolStripMenuItem87).set_ImageTransparentColor(SystemColors.ActiveBorder);
		((ToolStripItem)ToolStripMenuItem87).set_Name("ToolStripMenuItem87");
		ToolStripMenuItem toolStripMenuItem87 = ToolStripMenuItem87;
		size = new Size(54, 20);
		((ToolStripItem)toolStripMenuItem87).set_Size(size);
		((ToolStripItem)ToolStripMenuItem87).set_Text("&Fichier");
		((ToolStripItem)ToolStripMenuItem88).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem88.Image"));
		((ToolStripItem)ToolStripMenuItem88).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem88).set_Name("ToolStripMenuItem88");
		ToolStripMenuItem88.set_ShortcutKeys((Keys)131150);
		ToolStripMenuItem toolStripMenuItem88 = ToolStripMenuItem88;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem88).set_Size(size);
		((ToolStripItem)ToolStripMenuItem88).set_Text("&Nouveau");
		((ToolStripItem)ToolStripMenuItem89).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem89.Image"));
		((ToolStripItem)ToolStripMenuItem89).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem89).set_Name("ToolStripMenuItem89");
		ToolStripMenuItem89.set_ShortcutKeys((Keys)131151);
		ToolStripMenuItem toolStripMenuItem89 = ToolStripMenuItem89;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem89).set_Size(size);
		((ToolStripItem)ToolStripMenuItem89).set_Text("&Ouvrir");
		((ToolStripItem)ToolStripSeparator33).set_Name("ToolStripSeparator33");
		ToolStripSeparator toolStripSeparator33 = ToolStripSeparator33;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator33).set_Size(size);
		((ToolStripItem)ToolStripMenuItem90).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem90.Image"));
		((ToolStripItem)ToolStripMenuItem90).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem90).set_Name("ToolStripMenuItem90");
		ToolStripMenuItem90.set_ShortcutKeys((Keys)131155);
		ToolStripMenuItem toolStripMenuItem90 = ToolStripMenuItem90;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem90).set_Size(size);
		((ToolStripItem)ToolStripMenuItem90).set_Text("&Enregistrer");
		((ToolStripItem)ToolStripMenuItem91).set_Name("ToolStripMenuItem91");
		ToolStripMenuItem toolStripMenuItem91 = ToolStripMenuItem91;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem91).set_Size(size);
		((ToolStripItem)ToolStripMenuItem91).set_Text("Enregistrer &sous");
		((ToolStripItem)ToolStripSeparator34).set_Name("ToolStripSeparator34");
		ToolStripSeparator toolStripSeparator34 = ToolStripSeparator34;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator34).set_Size(size);
		((ToolStripItem)ToolStripMenuItem92).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem92.Image"));
		((ToolStripItem)ToolStripMenuItem92).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem92).set_Name("ToolStripMenuItem92");
		ToolStripMenuItem92.set_ShortcutKeys((Keys)131152);
		ToolStripMenuItem toolStripMenuItem92 = ToolStripMenuItem92;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem92).set_Size(size);
		((ToolStripItem)ToolStripMenuItem92).set_Text("&Imprimer");
		((ToolStripItem)ToolStripMenuItem93).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem93.Image"));
		((ToolStripItem)ToolStripMenuItem93).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem93).set_Name("ToolStripMenuItem93");
		ToolStripMenuItem toolStripMenuItem93 = ToolStripMenuItem93;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem93).set_Size(size);
		((ToolStripItem)ToolStripMenuItem93).set_Text("Aperçu a&vant impression");
		((ToolStripItem)ToolStripMenuItem94).set_Name("ToolStripMenuItem94");
		ToolStripMenuItem toolStripMenuItem94 = ToolStripMenuItem94;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem94).set_Size(size);
		((ToolStripItem)ToolStripMenuItem94).set_Text("Configuration de l'impression");
		((ToolStripItem)ToolStripSeparator35).set_Name("ToolStripSeparator35");
		ToolStripSeparator toolStripSeparator35 = ToolStripSeparator35;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator35).set_Size(size);
		((ToolStripItem)ToolStripMenuItem95).set_Name("ToolStripMenuItem95");
		ToolStripMenuItem toolStripMenuItem95 = ToolStripMenuItem95;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem95).set_Size(size);
		((ToolStripItem)ToolStripMenuItem95).set_Text("&Quitter");
		((ToolStripDropDownItem)ToolStripMenuItem96).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripMenuItem97,
			(ToolStripItem)ToolStripMenuItem98,
			(ToolStripItem)ToolStripSeparator36,
			(ToolStripItem)ToolStripMenuItem99,
			(ToolStripItem)ToolStripMenuItem100,
			(ToolStripItem)ToolStripMenuItem101,
			(ToolStripItem)ToolStripSeparator37,
			(ToolStripItem)ToolStripMenuItem102
		});
		((ToolStripItem)ToolStripMenuItem96).set_Name("ToolStripMenuItem96");
		ToolStripMenuItem toolStripMenuItem96 = ToolStripMenuItem96;
		size = new Size(56, 20);
		((ToolStripItem)toolStripMenuItem96).set_Size(size);
		((ToolStripItem)ToolStripMenuItem96).set_Text("&Edition");
		((ToolStripItem)ToolStripMenuItem97).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem97.Image"));
		((ToolStripItem)ToolStripMenuItem97).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem97).set_Name("ToolStripMenuItem97");
		ToolStripMenuItem97.set_ShortcutKeys((Keys)131162);
		ToolStripMenuItem toolStripMenuItem97 = ToolStripMenuItem97;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem97).set_Size(size);
		((ToolStripItem)ToolStripMenuItem97).set_Text("&Annuler");
		((ToolStripItem)ToolStripMenuItem98).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem98.Image"));
		((ToolStripItem)ToolStripMenuItem98).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem98).set_Name("ToolStripMenuItem98");
		ToolStripMenuItem98.set_ShortcutKeys((Keys)131161);
		ToolStripMenuItem toolStripMenuItem98 = ToolStripMenuItem98;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem98).set_Size(size);
		((ToolStripItem)ToolStripMenuItem98).set_Text("&Rétablir");
		((ToolStripItem)ToolStripSeparator36).set_Name("ToolStripSeparator36");
		ToolStripSeparator toolStripSeparator36 = ToolStripSeparator36;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator36).set_Size(size);
		((ToolStripItem)ToolStripMenuItem99).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem99.Image"));
		((ToolStripItem)ToolStripMenuItem99).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem99).set_Name("ToolStripMenuItem99");
		ToolStripMenuItem99.set_ShortcutKeys((Keys)131160);
		ToolStripMenuItem toolStripMenuItem99 = ToolStripMenuItem99;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem99).set_Size(size);
		((ToolStripItem)ToolStripMenuItem99).set_Text("Co&uper");
		((ToolStripItem)ToolStripMenuItem100).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem100.Image"));
		((ToolStripItem)ToolStripMenuItem100).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem100).set_Name("ToolStripMenuItem100");
		ToolStripMenuItem100.set_ShortcutKeys((Keys)131139);
		ToolStripMenuItem toolStripMenuItem100 = ToolStripMenuItem100;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem100).set_Size(size);
		((ToolStripItem)ToolStripMenuItem100).set_Text("&Copier");
		((ToolStripItem)ToolStripMenuItem101).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem101.Image"));
		((ToolStripItem)ToolStripMenuItem101).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem101).set_Name("ToolStripMenuItem101");
		ToolStripMenuItem101.set_ShortcutKeys((Keys)131158);
		ToolStripMenuItem toolStripMenuItem101 = ToolStripMenuItem101;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem101).set_Size(size);
		((ToolStripItem)ToolStripMenuItem101).set_Text("&Coller");
		((ToolStripItem)ToolStripSeparator37).set_Name("ToolStripSeparator37");
		ToolStripSeparator toolStripSeparator37 = ToolStripSeparator37;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator37).set_Size(size);
		((ToolStripItem)ToolStripMenuItem102).set_Name("ToolStripMenuItem102");
		ToolStripMenuItem102.set_ShortcutKeys((Keys)131137);
		ToolStripMenuItem toolStripMenuItem102 = ToolStripMenuItem102;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem102).set_Size(size);
		((ToolStripItem)ToolStripMenuItem102).set_Text("Sélectionner &tout");
		((ToolStripDropDownItem)ToolStripMenuItem103).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolStripMenuItem104,
			(ToolStripItem)ToolStripMenuItem105
		});
		((ToolStripItem)ToolStripMenuItem103).set_Name("ToolStripMenuItem103");
		ToolStripMenuItem toolStripMenuItem103 = ToolStripMenuItem103;
		size = new Size(70, 20);
		((ToolStripItem)toolStripMenuItem103).set_Size(size);
		((ToolStripItem)ToolStripMenuItem103).set_Text("&Affichage");
		ToolStripMenuItem104.set_Checked(true);
		ToolStripMenuItem104.set_CheckOnClick(true);
		ToolStripMenuItem104.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem104).set_Name("ToolStripMenuItem104");
		ToolStripMenuItem toolStripMenuItem104 = ToolStripMenuItem104;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem104).set_Size(size);
		((ToolStripItem)ToolStripMenuItem104).set_Text("&Barre d'outils");
		ToolStripMenuItem105.set_Checked(true);
		ToolStripMenuItem105.set_CheckOnClick(true);
		ToolStripMenuItem105.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem105).set_Name("ToolStripMenuItem105");
		ToolStripMenuItem toolStripMenuItem105 = ToolStripMenuItem105;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem105).set_Size(size);
		((ToolStripItem)ToolStripMenuItem105).set_Text("&Barre d'état");
		((ToolStripDropDownItem)ToolStripMenuItem106).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripMenuItem107 });
		((ToolStripItem)ToolStripMenuItem106).set_Name("ToolStripMenuItem106");
		ToolStripMenuItem toolStripMenuItem106 = ToolStripMenuItem106;
		size = new Size(50, 20);
		((ToolStripItem)toolStripMenuItem106).set_Size(size);
		((ToolStripItem)ToolStripMenuItem106).set_Text("&Outils");
		((ToolStripItem)ToolStripMenuItem107).set_Name("ToolStripMenuItem107");
		ToolStripMenuItem toolStripMenuItem107 = ToolStripMenuItem107;
		size = new Size(116, 22);
		((ToolStripItem)toolStripMenuItem107).set_Size(size);
		((ToolStripItem)ToolStripMenuItem107).set_Text("&Options");
		((ToolStripDropDownItem)ToolStripMenuItem108).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem109,
			(ToolStripItem)ToolStripMenuItem110,
			(ToolStripItem)ToolStripMenuItem111,
			(ToolStripItem)ToolStripMenuItem112,
			(ToolStripItem)ToolStripMenuItem113,
			(ToolStripItem)ToolStripMenuItem114
		});
		((ToolStripItem)ToolStripMenuItem108).set_Name("ToolStripMenuItem108");
		ToolStripMenuItem toolStripMenuItem108 = ToolStripMenuItem108;
		size = new Size(63, 20);
		((ToolStripItem)toolStripMenuItem108).set_Size(size);
		((ToolStripItem)ToolStripMenuItem108).set_Text("F&enêtres");
		((ToolStripItem)ToolStripMenuItem109).set_Name("ToolStripMenuItem109");
		ToolStripMenuItem toolStripMenuItem109 = ToolStripMenuItem109;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem109).set_Size(size);
		((ToolStripItem)ToolStripMenuItem109).set_Text("&Nouvelle fenêtre");
		((ToolStripItem)ToolStripMenuItem110).set_Name("ToolStripMenuItem110");
		ToolStripMenuItem toolStripMenuItem110 = ToolStripMenuItem110;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem110).set_Size(size);
		((ToolStripItem)ToolStripMenuItem110).set_Text("&Cascade");
		((ToolStripItem)ToolStripMenuItem111).set_Name("ToolStripMenuItem111");
		ToolStripMenuItem toolStripMenuItem111 = ToolStripMenuItem111;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem111).set_Size(size);
		((ToolStripItem)ToolStripMenuItem111).set_Text("Mosaïque &verticale");
		((ToolStripItem)ToolStripMenuItem112).set_Name("ToolStripMenuItem112");
		ToolStripMenuItem toolStripMenuItem112 = ToolStripMenuItem112;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem112).set_Size(size);
		((ToolStripItem)ToolStripMenuItem112).set_Text("Mosaïque &horizontale");
		((ToolStripItem)ToolStripMenuItem113).set_Name("ToolStripMenuItem113");
		ToolStripMenuItem toolStripMenuItem113 = ToolStripMenuItem113;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem113).set_Size(size);
		((ToolStripItem)ToolStripMenuItem113).set_Text("&Fermer tout");
		((ToolStripItem)ToolStripMenuItem114).set_Name("ToolStripMenuItem114");
		ToolStripMenuItem toolStripMenuItem114 = ToolStripMenuItem114;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem114).set_Size(size);
		((ToolStripItem)ToolStripMenuItem114).set_Text("&Réorganiser les icônes");
		((ToolStripDropDownItem)ToolStripMenuItem115).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ToolStripMenuItem116,
			(ToolStripItem)ToolStripMenuItem117,
			(ToolStripItem)ToolStripMenuItem118,
			(ToolStripItem)ToolStripSeparator38,
			(ToolStripItem)ToolStripMenuItem119
		});
		((ToolStripItem)ToolStripMenuItem115).set_Name("ToolStripMenuItem115");
		ToolStripMenuItem toolStripMenuItem115 = ToolStripMenuItem115;
		size = new Size(24, 20);
		((ToolStripItem)toolStripMenuItem115).set_Size(size);
		((ToolStripItem)ToolStripMenuItem115).set_Text("&?");
		((ToolStripItem)ToolStripMenuItem116).set_Name("ToolStripMenuItem116");
		ToolStripMenuItem116.set_ShortcutKeys((Keys)131184);
		ToolStripMenuItem toolStripMenuItem116 = ToolStripMenuItem116;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem116).set_Size(size);
		((ToolStripItem)ToolStripMenuItem116).set_Text("&Contenu");
		((ToolStripItem)ToolStripMenuItem117).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem117.Image"));
		((ToolStripItem)ToolStripMenuItem117).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem117).set_Name("ToolStripMenuItem117");
		ToolStripMenuItem toolStripMenuItem117 = ToolStripMenuItem117;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem117).set_Size(size);
		((ToolStripItem)ToolStripMenuItem117).set_Text("&Index");
		((ToolStripItem)ToolStripMenuItem118).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem118.Image"));
		((ToolStripItem)ToolStripMenuItem118).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem118).set_Name("ToolStripMenuItem118");
		ToolStripMenuItem toolStripMenuItem118 = ToolStripMenuItem118;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem118).set_Size(size);
		((ToolStripItem)ToolStripMenuItem118).set_Text("&Rechercher");
		((ToolStripItem)ToolStripSeparator38).set_Name("ToolStripSeparator38");
		ToolStripSeparator toolStripSeparator38 = ToolStripSeparator38;
		size = new Size(163, 6);
		((ToolStripItem)toolStripSeparator38).set_Size(size);
		((ToolStripItem)ToolStripMenuItem119).set_Name("ToolStripMenuItem119");
		ToolStripMenuItem toolStripMenuItem119 = ToolStripMenuItem119;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem119).set_Size(size);
		((ToolStripItem)ToolStripMenuItem119).set_Text("À pr&opos de...");
		((ToolStripItem)ToolStripSeparator39).set_Name("ToolStripSeparator39");
		ToolStripSeparator toolStripSeparator39 = ToolStripSeparator39;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator39).set_Size(size);
		((ToolStripItem)ToolStripButton13).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton13).set_Image((Image)componentResourceManager.GetObject("ToolStripButton13.Image"));
		((ToolStripItem)ToolStripButton13).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton13).set_Name("ToolStripButton13");
		ToolStripButton toolStripButton13 = ToolStripButton13;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton13).set_Size(size);
		((ToolStripItem)ToolStripButton13).set_Text("Aide");
		((ToolStrip)StatusStrip4).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel4 });
		StatusStrip statusStrip9 = StatusStrip4;
		location = new Point(0, 294);
		((Control)statusStrip9).set_Location(location);
		((Control)StatusStrip4).set_Name("StatusStrip4");
		StatusStrip statusStrip10 = StatusStrip4;
		size = new Size(211, 22);
		((Control)statusStrip10).set_Size(size);
		((Control)StatusStrip4).set_TabIndex(19);
		((Control)StatusStrip4).set_Text("StatusStrip");
		((ToolStripItem)ToolStripStatusLabel4).set_Name("ToolStripStatusLabel4");
		ToolStripStatusLabel toolStripStatusLabel5 = ToolStripStatusLabel4;
		size = new Size(27, 17);
		((ToolStripItem)toolStripStatusLabel5).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel4).set_Text("État");
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
		((ToolStripItem)ToolStripSeparator40).set_Name("ToolStripSeparator40");
		ToolStripSeparator toolStripSeparator40 = ToolStripSeparator40;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator40).set_Size(size);
		ToolStrip4.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripButton16,
			(ToolStripItem)ToolStripButton17,
			(ToolStripItem)ToolStripButton18,
			(ToolStripItem)ToolStripSeparator40,
			(ToolStripItem)ToolStripButton15,
			(ToolStripItem)ToolStripButton14,
			(ToolStripItem)ToolStripSeparator39,
			(ToolStripItem)ToolStripButton13
		});
		ToolStrip toolStrip9 = ToolStrip4;
		location = new Point(0, 147);
		((Control)toolStrip9).set_Location(location);
		((Control)ToolStrip4).set_Name("ToolStrip4");
		ToolStrip toolStrip10 = ToolStrip4;
		size = new Size(211, 25);
		((Control)toolStrip10).set_Size(size);
		((Control)ToolStrip4).set_TabIndex(18);
		((Control)ToolStrip4).set_Text("ToolStrip");
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
		((ToolStrip)MenuStrip5).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem120,
			(ToolStripItem)ToolStripMenuItem129,
			(ToolStripItem)ToolStripMenuItem136,
			(ToolStripItem)ToolStripMenuItem139,
			(ToolStripItem)ToolStripMenuItem141,
			(ToolStripItem)ToolStripMenuItem148
		});
		MenuStrip menuStrip11 = MenuStrip5;
		location = new Point(0, 221);
		((Control)menuStrip11).set_Location(location);
		MenuStrip5.set_MdiWindowListItem(ToolStripMenuItem141);
		((Control)MenuStrip5).set_Name("MenuStrip5");
		MenuStrip menuStrip12 = MenuStrip5;
		size = new Size(211, 24);
		((Control)menuStrip12).set_Size(size);
		((Control)MenuStrip5).set_TabIndex(20);
		((Control)MenuStrip5).set_Text("MenuStrip5");
		((ToolStripDropDownItem)ToolStripMenuItem120).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)ToolStripMenuItem121,
			(ToolStripItem)ToolStripMenuItem122,
			(ToolStripItem)ToolStripSeparator41,
			(ToolStripItem)ToolStripMenuItem123,
			(ToolStripItem)ToolStripMenuItem124,
			(ToolStripItem)ToolStripSeparator42,
			(ToolStripItem)ToolStripMenuItem125,
			(ToolStripItem)ToolStripMenuItem126,
			(ToolStripItem)ToolStripMenuItem127,
			(ToolStripItem)ToolStripSeparator43,
			(ToolStripItem)ToolStripMenuItem128
		});
		((ToolStripItem)ToolStripMenuItem120).set_ImageTransparentColor(SystemColors.ActiveBorder);
		((ToolStripItem)ToolStripMenuItem120).set_Name("ToolStripMenuItem120");
		ToolStripMenuItem toolStripMenuItem120 = ToolStripMenuItem120;
		size = new Size(54, 20);
		((ToolStripItem)toolStripMenuItem120).set_Size(size);
		((ToolStripItem)ToolStripMenuItem120).set_Text("&Fichier");
		((ToolStripItem)ToolStripMenuItem121).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem121.Image"));
		((ToolStripItem)ToolStripMenuItem121).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem121).set_Name("ToolStripMenuItem121");
		ToolStripMenuItem121.set_ShortcutKeys((Keys)131150);
		ToolStripMenuItem toolStripMenuItem121 = ToolStripMenuItem121;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem121).set_Size(size);
		((ToolStripItem)ToolStripMenuItem121).set_Text("&Nouveau");
		((ToolStripItem)ToolStripMenuItem122).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem122.Image"));
		((ToolStripItem)ToolStripMenuItem122).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem122).set_Name("ToolStripMenuItem122");
		ToolStripMenuItem122.set_ShortcutKeys((Keys)131151);
		ToolStripMenuItem toolStripMenuItem122 = ToolStripMenuItem122;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem122).set_Size(size);
		((ToolStripItem)ToolStripMenuItem122).set_Text("&Ouvrir");
		((ToolStripItem)ToolStripSeparator41).set_Name("ToolStripSeparator41");
		ToolStripSeparator toolStripSeparator41 = ToolStripSeparator41;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator41).set_Size(size);
		((ToolStripItem)ToolStripMenuItem123).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem123.Image"));
		((ToolStripItem)ToolStripMenuItem123).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem123).set_Name("ToolStripMenuItem123");
		ToolStripMenuItem123.set_ShortcutKeys((Keys)131155);
		ToolStripMenuItem toolStripMenuItem123 = ToolStripMenuItem123;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem123).set_Size(size);
		((ToolStripItem)ToolStripMenuItem123).set_Text("&Enregistrer");
		((ToolStripItem)ToolStripMenuItem124).set_Name("ToolStripMenuItem124");
		ToolStripMenuItem toolStripMenuItem124 = ToolStripMenuItem124;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem124).set_Size(size);
		((ToolStripItem)ToolStripMenuItem124).set_Text("Enregistrer &sous");
		((ToolStripItem)ToolStripSeparator42).set_Name("ToolStripSeparator42");
		ToolStripSeparator toolStripSeparator42 = ToolStripSeparator42;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator42).set_Size(size);
		((ToolStripItem)ToolStripMenuItem125).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem125.Image"));
		((ToolStripItem)ToolStripMenuItem125).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem125).set_Name("ToolStripMenuItem125");
		ToolStripMenuItem125.set_ShortcutKeys((Keys)131152);
		ToolStripMenuItem toolStripMenuItem125 = ToolStripMenuItem125;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem125).set_Size(size);
		((ToolStripItem)ToolStripMenuItem125).set_Text("&Imprimer");
		((ToolStripItem)ToolStripMenuItem126).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem126.Image"));
		((ToolStripItem)ToolStripMenuItem126).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem126).set_Name("ToolStripMenuItem126");
		ToolStripMenuItem toolStripMenuItem126 = ToolStripMenuItem126;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem126).set_Size(size);
		((ToolStripItem)ToolStripMenuItem126).set_Text("Aperçu a&vant impression");
		((ToolStripItem)ToolStripMenuItem127).set_Name("ToolStripMenuItem127");
		ToolStripMenuItem toolStripMenuItem127 = ToolStripMenuItem127;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem127).set_Size(size);
		((ToolStripItem)ToolStripMenuItem127).set_Text("Configuration de l'impression");
		((ToolStripItem)ToolStripSeparator43).set_Name("ToolStripSeparator43");
		ToolStripSeparator toolStripSeparator43 = ToolStripSeparator43;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator43).set_Size(size);
		((ToolStripItem)ToolStripMenuItem128).set_Name("ToolStripMenuItem128");
		ToolStripMenuItem toolStripMenuItem128 = ToolStripMenuItem128;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem128).set_Size(size);
		((ToolStripItem)ToolStripMenuItem128).set_Text("&Quitter");
		((ToolStripDropDownItem)ToolStripMenuItem129).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripMenuItem130,
			(ToolStripItem)ToolStripMenuItem131,
			(ToolStripItem)ToolStripSeparator44,
			(ToolStripItem)ToolStripMenuItem132,
			(ToolStripItem)ToolStripMenuItem133,
			(ToolStripItem)ToolStripMenuItem134,
			(ToolStripItem)ToolStripSeparator45,
			(ToolStripItem)ToolStripMenuItem135
		});
		((ToolStripItem)ToolStripMenuItem129).set_Name("ToolStripMenuItem129");
		ToolStripMenuItem toolStripMenuItem129 = ToolStripMenuItem129;
		size = new Size(56, 20);
		((ToolStripItem)toolStripMenuItem129).set_Size(size);
		((ToolStripItem)ToolStripMenuItem129).set_Text("&Edition");
		((ToolStripItem)ToolStripMenuItem130).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem130.Image"));
		((ToolStripItem)ToolStripMenuItem130).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem130).set_Name("ToolStripMenuItem130");
		ToolStripMenuItem130.set_ShortcutKeys((Keys)131162);
		ToolStripMenuItem toolStripMenuItem130 = ToolStripMenuItem130;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem130).set_Size(size);
		((ToolStripItem)ToolStripMenuItem130).set_Text("&Annuler");
		((ToolStripItem)ToolStripMenuItem131).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem131.Image"));
		((ToolStripItem)ToolStripMenuItem131).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem131).set_Name("ToolStripMenuItem131");
		ToolStripMenuItem131.set_ShortcutKeys((Keys)131161);
		ToolStripMenuItem toolStripMenuItem131 = ToolStripMenuItem131;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem131).set_Size(size);
		((ToolStripItem)ToolStripMenuItem131).set_Text("&Rétablir");
		((ToolStripItem)ToolStripSeparator44).set_Name("ToolStripSeparator44");
		ToolStripSeparator toolStripSeparator44 = ToolStripSeparator44;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator44).set_Size(size);
		((ToolStripItem)ToolStripMenuItem132).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem132.Image"));
		((ToolStripItem)ToolStripMenuItem132).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem132).set_Name("ToolStripMenuItem132");
		ToolStripMenuItem132.set_ShortcutKeys((Keys)131160);
		ToolStripMenuItem toolStripMenuItem132 = ToolStripMenuItem132;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem132).set_Size(size);
		((ToolStripItem)ToolStripMenuItem132).set_Text("Co&uper");
		((ToolStripItem)ToolStripMenuItem133).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem133.Image"));
		((ToolStripItem)ToolStripMenuItem133).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem133).set_Name("ToolStripMenuItem133");
		ToolStripMenuItem133.set_ShortcutKeys((Keys)131139);
		ToolStripMenuItem toolStripMenuItem133 = ToolStripMenuItem133;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem133).set_Size(size);
		((ToolStripItem)ToolStripMenuItem133).set_Text("&Copier");
		((ToolStripItem)ToolStripMenuItem134).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem134.Image"));
		((ToolStripItem)ToolStripMenuItem134).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem134).set_Name("ToolStripMenuItem134");
		ToolStripMenuItem134.set_ShortcutKeys((Keys)131158);
		ToolStripMenuItem toolStripMenuItem134 = ToolStripMenuItem134;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem134).set_Size(size);
		((ToolStripItem)ToolStripMenuItem134).set_Text("&Coller");
		((ToolStripItem)ToolStripSeparator45).set_Name("ToolStripSeparator45");
		ToolStripSeparator toolStripSeparator45 = ToolStripSeparator45;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator45).set_Size(size);
		((ToolStripItem)ToolStripMenuItem135).set_Name("ToolStripMenuItem135");
		ToolStripMenuItem135.set_ShortcutKeys((Keys)131137);
		ToolStripMenuItem toolStripMenuItem135 = ToolStripMenuItem135;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem135).set_Size(size);
		((ToolStripItem)ToolStripMenuItem135).set_Text("Sélectionner &tout");
		((ToolStripDropDownItem)ToolStripMenuItem136).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolStripMenuItem137,
			(ToolStripItem)ToolStripMenuItem138
		});
		((ToolStripItem)ToolStripMenuItem136).set_Name("ToolStripMenuItem136");
		ToolStripMenuItem toolStripMenuItem136 = ToolStripMenuItem136;
		size = new Size(70, 20);
		((ToolStripItem)toolStripMenuItem136).set_Size(size);
		((ToolStripItem)ToolStripMenuItem136).set_Text("&Affichage");
		ToolStripMenuItem137.set_Checked(true);
		ToolStripMenuItem137.set_CheckOnClick(true);
		ToolStripMenuItem137.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem137).set_Name("ToolStripMenuItem137");
		ToolStripMenuItem toolStripMenuItem137 = ToolStripMenuItem137;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem137).set_Size(size);
		((ToolStripItem)ToolStripMenuItem137).set_Text("&Barre d'outils");
		ToolStripMenuItem138.set_Checked(true);
		ToolStripMenuItem138.set_CheckOnClick(true);
		ToolStripMenuItem138.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem138).set_Name("ToolStripMenuItem138");
		ToolStripMenuItem toolStripMenuItem138 = ToolStripMenuItem138;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem138).set_Size(size);
		((ToolStripItem)ToolStripMenuItem138).set_Text("&Barre d'état");
		((ToolStripDropDownItem)ToolStripMenuItem139).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripMenuItem140 });
		((ToolStripItem)ToolStripMenuItem139).set_Name("ToolStripMenuItem139");
		ToolStripMenuItem toolStripMenuItem139 = ToolStripMenuItem139;
		size = new Size(50, 20);
		((ToolStripItem)toolStripMenuItem139).set_Size(size);
		((ToolStripItem)ToolStripMenuItem139).set_Text("&Outils");
		((ToolStripItem)ToolStripMenuItem140).set_Name("ToolStripMenuItem140");
		ToolStripMenuItem toolStripMenuItem140 = ToolStripMenuItem140;
		size = new Size(116, 22);
		((ToolStripItem)toolStripMenuItem140).set_Size(size);
		((ToolStripItem)ToolStripMenuItem140).set_Text("&Options");
		((ToolStripDropDownItem)ToolStripMenuItem141).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem142,
			(ToolStripItem)ToolStripMenuItem143,
			(ToolStripItem)ToolStripMenuItem144,
			(ToolStripItem)ToolStripMenuItem145,
			(ToolStripItem)ToolStripMenuItem146,
			(ToolStripItem)ToolStripMenuItem147
		});
		((ToolStripItem)ToolStripMenuItem141).set_Name("ToolStripMenuItem141");
		ToolStripMenuItem toolStripMenuItem141 = ToolStripMenuItem141;
		size = new Size(63, 20);
		((ToolStripItem)toolStripMenuItem141).set_Size(size);
		((ToolStripItem)ToolStripMenuItem141).set_Text("F&enêtres");
		((ToolStripItem)ToolStripMenuItem142).set_Name("ToolStripMenuItem142");
		ToolStripMenuItem toolStripMenuItem142 = ToolStripMenuItem142;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem142).set_Size(size);
		((ToolStripItem)ToolStripMenuItem142).set_Text("&Nouvelle fenêtre");
		((ToolStripItem)ToolStripMenuItem143).set_Name("ToolStripMenuItem143");
		ToolStripMenuItem toolStripMenuItem143 = ToolStripMenuItem143;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem143).set_Size(size);
		((ToolStripItem)ToolStripMenuItem143).set_Text("&Cascade");
		((ToolStripItem)ToolStripMenuItem144).set_Name("ToolStripMenuItem144");
		ToolStripMenuItem toolStripMenuItem144 = ToolStripMenuItem144;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem144).set_Size(size);
		((ToolStripItem)ToolStripMenuItem144).set_Text("Mosaïque &verticale");
		((ToolStripItem)ToolStripMenuItem145).set_Name("ToolStripMenuItem145");
		ToolStripMenuItem toolStripMenuItem145 = ToolStripMenuItem145;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem145).set_Size(size);
		((ToolStripItem)ToolStripMenuItem145).set_Text("Mosaïque &horizontale");
		((ToolStripItem)ToolStripMenuItem146).set_Name("ToolStripMenuItem146");
		ToolStripMenuItem toolStripMenuItem146 = ToolStripMenuItem146;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem146).set_Size(size);
		((ToolStripItem)ToolStripMenuItem146).set_Text("&Fermer tout");
		((ToolStripItem)ToolStripMenuItem147).set_Name("ToolStripMenuItem147");
		ToolStripMenuItem toolStripMenuItem147 = ToolStripMenuItem147;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem147).set_Size(size);
		((ToolStripItem)ToolStripMenuItem147).set_Text("&Réorganiser les icônes");
		((ToolStripDropDownItem)ToolStripMenuItem148).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ToolStripMenuItem149,
			(ToolStripItem)ToolStripMenuItem150,
			(ToolStripItem)ToolStripMenuItem151,
			(ToolStripItem)ToolStripSeparator46,
			(ToolStripItem)ToolStripMenuItem152
		});
		((ToolStripItem)ToolStripMenuItem148).set_Name("ToolStripMenuItem148");
		ToolStripMenuItem toolStripMenuItem148 = ToolStripMenuItem148;
		size = new Size(24, 20);
		((ToolStripItem)toolStripMenuItem148).set_Size(size);
		((ToolStripItem)ToolStripMenuItem148).set_Text("&?");
		((ToolStripItem)ToolStripMenuItem149).set_Name("ToolStripMenuItem149");
		ToolStripMenuItem149.set_ShortcutKeys((Keys)131184);
		ToolStripMenuItem toolStripMenuItem149 = ToolStripMenuItem149;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem149).set_Size(size);
		((ToolStripItem)ToolStripMenuItem149).set_Text("&Contenu");
		((ToolStripItem)ToolStripMenuItem150).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem150.Image"));
		((ToolStripItem)ToolStripMenuItem150).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem150).set_Name("ToolStripMenuItem150");
		ToolStripMenuItem toolStripMenuItem150 = ToolStripMenuItem150;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem150).set_Size(size);
		((ToolStripItem)ToolStripMenuItem150).set_Text("&Index");
		((ToolStripItem)ToolStripMenuItem151).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem151.Image"));
		((ToolStripItem)ToolStripMenuItem151).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem151).set_Name("ToolStripMenuItem151");
		ToolStripMenuItem toolStripMenuItem151 = ToolStripMenuItem151;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem151).set_Size(size);
		((ToolStripItem)ToolStripMenuItem151).set_Text("&Rechercher");
		((ToolStripItem)ToolStripSeparator46).set_Name("ToolStripSeparator46");
		ToolStripSeparator toolStripSeparator46 = ToolStripSeparator46;
		size = new Size(163, 6);
		((ToolStripItem)toolStripSeparator46).set_Size(size);
		((ToolStripItem)ToolStripMenuItem152).set_Name("ToolStripMenuItem152");
		ToolStripMenuItem toolStripMenuItem152 = ToolStripMenuItem152;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem152).set_Size(size);
		((ToolStripItem)ToolStripMenuItem152).set_Text("À pr&opos de...");
		((ToolStripItem)ToolStripSeparator47).set_Name("ToolStripSeparator47");
		ToolStripSeparator toolStripSeparator47 = ToolStripSeparator47;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator47).set_Size(size);
		((ToolStripItem)ToolStripButton19).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton19).set_Image((Image)componentResourceManager.GetObject("ToolStripButton19.Image"));
		((ToolStripItem)ToolStripButton19).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton19).set_Name("ToolStripButton19");
		ToolStripButton toolStripButton19 = ToolStripButton19;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton19).set_Size(size);
		((ToolStripItem)ToolStripButton19).set_Text("Aide");
		((ToolStrip)StatusStrip5).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel5 });
		StatusStrip statusStrip11 = StatusStrip5;
		location = new Point(0, 272);
		((Control)statusStrip11).set_Location(location);
		((Control)StatusStrip5).set_Name("StatusStrip5");
		StatusStrip statusStrip12 = StatusStrip5;
		size = new Size(211, 22);
		((Control)statusStrip12).set_Size(size);
		((Control)StatusStrip5).set_TabIndex(22);
		((Control)StatusStrip5).set_Text("StatusStrip");
		((ToolStripItem)ToolStripStatusLabel5).set_Name("ToolStripStatusLabel5");
		ToolStripStatusLabel toolStripStatusLabel6 = ToolStripStatusLabel5;
		size = new Size(27, 17);
		((ToolStripItem)toolStripStatusLabel6).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel5).set_Text("État");
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
		((ToolStripItem)ToolStripSeparator48).set_Name("ToolStripSeparator48");
		ToolStripSeparator toolStripSeparator48 = ToolStripSeparator48;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator48).set_Size(size);
		ToolStrip5.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripButton22,
			(ToolStripItem)ToolStripButton23,
			(ToolStripItem)ToolStripButton24,
			(ToolStripItem)ToolStripSeparator48,
			(ToolStripItem)ToolStripButton21,
			(ToolStripItem)ToolStripButton20,
			(ToolStripItem)ToolStripSeparator47,
			(ToolStripItem)ToolStripButton19
		});
		ToolStrip toolStrip11 = ToolStrip5;
		location = new Point(0, 196);
		((Control)toolStrip11).set_Location(location);
		((Control)ToolStrip5).set_Name("ToolStrip5");
		ToolStrip toolStrip12 = ToolStrip5;
		size = new Size(211, 25);
		((Control)toolStrip12).set_Size(size);
		((Control)ToolStrip5).set_TabIndex(21);
		((Control)ToolStrip5).set_Text("ToolStrip");
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
		((ToolStrip)MenuStrip6).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem153,
			(ToolStripItem)ToolStripMenuItem162,
			(ToolStripItem)ToolStripMenuItem169,
			(ToolStripItem)ToolStripMenuItem172,
			(ToolStripItem)ToolStripMenuItem174,
			(ToolStripItem)ToolStripMenuItem181
		});
		MenuStrip menuStrip13 = MenuStrip6;
		location = new Point(0, 270);
		((Control)menuStrip13).set_Location(location);
		MenuStrip6.set_MdiWindowListItem(ToolStripMenuItem174);
		((Control)MenuStrip6).set_Name("MenuStrip6");
		MenuStrip menuStrip14 = MenuStrip6;
		size = new Size(211, 24);
		((Control)menuStrip14).set_Size(size);
		((Control)MenuStrip6).set_TabIndex(23);
		((Control)MenuStrip6).set_Text("MenuStrip6");
		((ToolStripDropDownItem)ToolStripMenuItem153).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)ToolStripMenuItem154,
			(ToolStripItem)ToolStripMenuItem155,
			(ToolStripItem)ToolStripSeparator49,
			(ToolStripItem)ToolStripMenuItem156,
			(ToolStripItem)ToolStripMenuItem157,
			(ToolStripItem)ToolStripSeparator50,
			(ToolStripItem)ToolStripMenuItem158,
			(ToolStripItem)ToolStripMenuItem159,
			(ToolStripItem)ToolStripMenuItem160,
			(ToolStripItem)ToolStripSeparator51,
			(ToolStripItem)ToolStripMenuItem161
		});
		((ToolStripItem)ToolStripMenuItem153).set_ImageTransparentColor(SystemColors.ActiveBorder);
		((ToolStripItem)ToolStripMenuItem153).set_Name("ToolStripMenuItem153");
		ToolStripMenuItem toolStripMenuItem153 = ToolStripMenuItem153;
		size = new Size(54, 20);
		((ToolStripItem)toolStripMenuItem153).set_Size(size);
		((ToolStripItem)ToolStripMenuItem153).set_Text("&Fichier");
		((ToolStripItem)ToolStripMenuItem154).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem154.Image"));
		((ToolStripItem)ToolStripMenuItem154).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem154).set_Name("ToolStripMenuItem154");
		ToolStripMenuItem154.set_ShortcutKeys((Keys)131150);
		ToolStripMenuItem toolStripMenuItem154 = ToolStripMenuItem154;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem154).set_Size(size);
		((ToolStripItem)ToolStripMenuItem154).set_Text("&Nouveau");
		((ToolStripItem)ToolStripMenuItem155).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem155.Image"));
		((ToolStripItem)ToolStripMenuItem155).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem155).set_Name("ToolStripMenuItem155");
		ToolStripMenuItem155.set_ShortcutKeys((Keys)131151);
		ToolStripMenuItem toolStripMenuItem155 = ToolStripMenuItem155;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem155).set_Size(size);
		((ToolStripItem)ToolStripMenuItem155).set_Text("&Ouvrir");
		((ToolStripItem)ToolStripSeparator49).set_Name("ToolStripSeparator49");
		ToolStripSeparator toolStripSeparator49 = ToolStripSeparator49;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator49).set_Size(size);
		((ToolStripItem)ToolStripMenuItem156).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem156.Image"));
		((ToolStripItem)ToolStripMenuItem156).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem156).set_Name("ToolStripMenuItem156");
		ToolStripMenuItem156.set_ShortcutKeys((Keys)131155);
		ToolStripMenuItem toolStripMenuItem156 = ToolStripMenuItem156;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem156).set_Size(size);
		((ToolStripItem)ToolStripMenuItem156).set_Text("&Enregistrer");
		((ToolStripItem)ToolStripMenuItem157).set_Name("ToolStripMenuItem157");
		ToolStripMenuItem toolStripMenuItem157 = ToolStripMenuItem157;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem157).set_Size(size);
		((ToolStripItem)ToolStripMenuItem157).set_Text("Enregistrer &sous");
		((ToolStripItem)ToolStripSeparator50).set_Name("ToolStripSeparator50");
		ToolStripSeparator toolStripSeparator50 = ToolStripSeparator50;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator50).set_Size(size);
		((ToolStripItem)ToolStripMenuItem158).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem158.Image"));
		((ToolStripItem)ToolStripMenuItem158).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem158).set_Name("ToolStripMenuItem158");
		ToolStripMenuItem158.set_ShortcutKeys((Keys)131152);
		ToolStripMenuItem toolStripMenuItem158 = ToolStripMenuItem158;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem158).set_Size(size);
		((ToolStripItem)ToolStripMenuItem158).set_Text("&Imprimer");
		((ToolStripItem)ToolStripMenuItem159).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem159.Image"));
		((ToolStripItem)ToolStripMenuItem159).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem159).set_Name("ToolStripMenuItem159");
		ToolStripMenuItem toolStripMenuItem159 = ToolStripMenuItem159;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem159).set_Size(size);
		((ToolStripItem)ToolStripMenuItem159).set_Text("Aperçu a&vant impression");
		((ToolStripItem)ToolStripMenuItem160).set_Name("ToolStripMenuItem160");
		ToolStripMenuItem toolStripMenuItem160 = ToolStripMenuItem160;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem160).set_Size(size);
		((ToolStripItem)ToolStripMenuItem160).set_Text("Configuration de l'impression");
		((ToolStripItem)ToolStripSeparator51).set_Name("ToolStripSeparator51");
		ToolStripSeparator toolStripSeparator51 = ToolStripSeparator51;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator51).set_Size(size);
		((ToolStripItem)ToolStripMenuItem161).set_Name("ToolStripMenuItem161");
		ToolStripMenuItem toolStripMenuItem161 = ToolStripMenuItem161;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem161).set_Size(size);
		((ToolStripItem)ToolStripMenuItem161).set_Text("&Quitter");
		((ToolStripDropDownItem)ToolStripMenuItem162).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripMenuItem163,
			(ToolStripItem)ToolStripMenuItem164,
			(ToolStripItem)ToolStripSeparator52,
			(ToolStripItem)ToolStripMenuItem165,
			(ToolStripItem)ToolStripMenuItem166,
			(ToolStripItem)ToolStripMenuItem167,
			(ToolStripItem)ToolStripSeparator53,
			(ToolStripItem)ToolStripMenuItem168
		});
		((ToolStripItem)ToolStripMenuItem162).set_Name("ToolStripMenuItem162");
		ToolStripMenuItem toolStripMenuItem162 = ToolStripMenuItem162;
		size = new Size(56, 20);
		((ToolStripItem)toolStripMenuItem162).set_Size(size);
		((ToolStripItem)ToolStripMenuItem162).set_Text("&Edition");
		((ToolStripItem)ToolStripMenuItem163).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem163.Image"));
		((ToolStripItem)ToolStripMenuItem163).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem163).set_Name("ToolStripMenuItem163");
		ToolStripMenuItem163.set_ShortcutKeys((Keys)131162);
		ToolStripMenuItem toolStripMenuItem163 = ToolStripMenuItem163;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem163).set_Size(size);
		((ToolStripItem)ToolStripMenuItem163).set_Text("&Annuler");
		((ToolStripItem)ToolStripMenuItem164).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem164.Image"));
		((ToolStripItem)ToolStripMenuItem164).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem164).set_Name("ToolStripMenuItem164");
		ToolStripMenuItem164.set_ShortcutKeys((Keys)131161);
		ToolStripMenuItem toolStripMenuItem164 = ToolStripMenuItem164;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem164).set_Size(size);
		((ToolStripItem)ToolStripMenuItem164).set_Text("&Rétablir");
		((ToolStripItem)ToolStripSeparator52).set_Name("ToolStripSeparator52");
		ToolStripSeparator toolStripSeparator52 = ToolStripSeparator52;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator52).set_Size(size);
		((ToolStripItem)ToolStripMenuItem165).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem165.Image"));
		((ToolStripItem)ToolStripMenuItem165).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem165).set_Name("ToolStripMenuItem165");
		ToolStripMenuItem165.set_ShortcutKeys((Keys)131160);
		ToolStripMenuItem toolStripMenuItem165 = ToolStripMenuItem165;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem165).set_Size(size);
		((ToolStripItem)ToolStripMenuItem165).set_Text("Co&uper");
		((ToolStripItem)ToolStripMenuItem166).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem166.Image"));
		((ToolStripItem)ToolStripMenuItem166).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem166).set_Name("ToolStripMenuItem166");
		ToolStripMenuItem166.set_ShortcutKeys((Keys)131139);
		ToolStripMenuItem toolStripMenuItem166 = ToolStripMenuItem166;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem166).set_Size(size);
		((ToolStripItem)ToolStripMenuItem166).set_Text("&Copier");
		((ToolStripItem)ToolStripMenuItem167).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem167.Image"));
		((ToolStripItem)ToolStripMenuItem167).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem167).set_Name("ToolStripMenuItem167");
		ToolStripMenuItem167.set_ShortcutKeys((Keys)131158);
		ToolStripMenuItem toolStripMenuItem167 = ToolStripMenuItem167;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem167).set_Size(size);
		((ToolStripItem)ToolStripMenuItem167).set_Text("&Coller");
		((ToolStripItem)ToolStripSeparator53).set_Name("ToolStripSeparator53");
		ToolStripSeparator toolStripSeparator53 = ToolStripSeparator53;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator53).set_Size(size);
		((ToolStripItem)ToolStripMenuItem168).set_Name("ToolStripMenuItem168");
		ToolStripMenuItem168.set_ShortcutKeys((Keys)131137);
		ToolStripMenuItem toolStripMenuItem168 = ToolStripMenuItem168;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem168).set_Size(size);
		((ToolStripItem)ToolStripMenuItem168).set_Text("Sélectionner &tout");
		((ToolStripDropDownItem)ToolStripMenuItem169).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolStripMenuItem170,
			(ToolStripItem)ToolStripMenuItem171
		});
		((ToolStripItem)ToolStripMenuItem169).set_Name("ToolStripMenuItem169");
		ToolStripMenuItem toolStripMenuItem169 = ToolStripMenuItem169;
		size = new Size(70, 20);
		((ToolStripItem)toolStripMenuItem169).set_Size(size);
		((ToolStripItem)ToolStripMenuItem169).set_Text("&Affichage");
		ToolStripMenuItem170.set_Checked(true);
		ToolStripMenuItem170.set_CheckOnClick(true);
		ToolStripMenuItem170.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem170).set_Name("ToolStripMenuItem170");
		ToolStripMenuItem toolStripMenuItem170 = ToolStripMenuItem170;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem170).set_Size(size);
		((ToolStripItem)ToolStripMenuItem170).set_Text("&Barre d'outils");
		ToolStripMenuItem171.set_Checked(true);
		ToolStripMenuItem171.set_CheckOnClick(true);
		ToolStripMenuItem171.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem171).set_Name("ToolStripMenuItem171");
		ToolStripMenuItem toolStripMenuItem171 = ToolStripMenuItem171;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem171).set_Size(size);
		((ToolStripItem)ToolStripMenuItem171).set_Text("&Barre d'état");
		((ToolStripDropDownItem)ToolStripMenuItem172).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripMenuItem173 });
		((ToolStripItem)ToolStripMenuItem172).set_Name("ToolStripMenuItem172");
		ToolStripMenuItem toolStripMenuItem172 = ToolStripMenuItem172;
		size = new Size(50, 20);
		((ToolStripItem)toolStripMenuItem172).set_Size(size);
		((ToolStripItem)ToolStripMenuItem172).set_Text("&Outils");
		((ToolStripItem)ToolStripMenuItem173).set_Name("ToolStripMenuItem173");
		ToolStripMenuItem toolStripMenuItem173 = ToolStripMenuItem173;
		size = new Size(116, 22);
		((ToolStripItem)toolStripMenuItem173).set_Size(size);
		((ToolStripItem)ToolStripMenuItem173).set_Text("&Options");
		((ToolStripDropDownItem)ToolStripMenuItem174).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem175,
			(ToolStripItem)ToolStripMenuItem176,
			(ToolStripItem)ToolStripMenuItem177,
			(ToolStripItem)ToolStripMenuItem178,
			(ToolStripItem)ToolStripMenuItem179,
			(ToolStripItem)ToolStripMenuItem180
		});
		((ToolStripItem)ToolStripMenuItem174).set_Name("ToolStripMenuItem174");
		ToolStripMenuItem toolStripMenuItem174 = ToolStripMenuItem174;
		size = new Size(63, 20);
		((ToolStripItem)toolStripMenuItem174).set_Size(size);
		((ToolStripItem)ToolStripMenuItem174).set_Text("F&enêtres");
		((ToolStripItem)ToolStripMenuItem175).set_Name("ToolStripMenuItem175");
		ToolStripMenuItem toolStripMenuItem175 = ToolStripMenuItem175;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem175).set_Size(size);
		((ToolStripItem)ToolStripMenuItem175).set_Text("&Nouvelle fenêtre");
		((ToolStripItem)ToolStripMenuItem176).set_Name("ToolStripMenuItem176");
		ToolStripMenuItem toolStripMenuItem176 = ToolStripMenuItem176;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem176).set_Size(size);
		((ToolStripItem)ToolStripMenuItem176).set_Text("&Cascade");
		((ToolStripItem)ToolStripMenuItem177).set_Name("ToolStripMenuItem177");
		ToolStripMenuItem toolStripMenuItem177 = ToolStripMenuItem177;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem177).set_Size(size);
		((ToolStripItem)ToolStripMenuItem177).set_Text("Mosaïque &verticale");
		((ToolStripItem)ToolStripMenuItem178).set_Name("ToolStripMenuItem178");
		ToolStripMenuItem toolStripMenuItem178 = ToolStripMenuItem178;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem178).set_Size(size);
		((ToolStripItem)ToolStripMenuItem178).set_Text("Mosaïque &horizontale");
		((ToolStripItem)ToolStripMenuItem179).set_Name("ToolStripMenuItem179");
		ToolStripMenuItem toolStripMenuItem179 = ToolStripMenuItem179;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem179).set_Size(size);
		((ToolStripItem)ToolStripMenuItem179).set_Text("&Fermer tout");
		((ToolStripItem)ToolStripMenuItem180).set_Name("ToolStripMenuItem180");
		ToolStripMenuItem toolStripMenuItem180 = ToolStripMenuItem180;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem180).set_Size(size);
		((ToolStripItem)ToolStripMenuItem180).set_Text("&Réorganiser les icônes");
		((ToolStripDropDownItem)ToolStripMenuItem181).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ToolStripMenuItem182,
			(ToolStripItem)ToolStripMenuItem183,
			(ToolStripItem)ToolStripMenuItem184,
			(ToolStripItem)ToolStripSeparator54,
			(ToolStripItem)ToolStripMenuItem185
		});
		((ToolStripItem)ToolStripMenuItem181).set_Name("ToolStripMenuItem181");
		ToolStripMenuItem toolStripMenuItem181 = ToolStripMenuItem181;
		size = new Size(24, 20);
		((ToolStripItem)toolStripMenuItem181).set_Size(size);
		((ToolStripItem)ToolStripMenuItem181).set_Text("&?");
		((ToolStripItem)ToolStripMenuItem182).set_Name("ToolStripMenuItem182");
		ToolStripMenuItem182.set_ShortcutKeys((Keys)131184);
		ToolStripMenuItem toolStripMenuItem182 = ToolStripMenuItem182;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem182).set_Size(size);
		((ToolStripItem)ToolStripMenuItem182).set_Text("&Contenu");
		((ToolStripItem)ToolStripMenuItem183).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem183.Image"));
		((ToolStripItem)ToolStripMenuItem183).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem183).set_Name("ToolStripMenuItem183");
		ToolStripMenuItem toolStripMenuItem183 = ToolStripMenuItem183;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem183).set_Size(size);
		((ToolStripItem)ToolStripMenuItem183).set_Text("&Index");
		((ToolStripItem)ToolStripMenuItem184).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem184.Image"));
		((ToolStripItem)ToolStripMenuItem184).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem184).set_Name("ToolStripMenuItem184");
		ToolStripMenuItem toolStripMenuItem184 = ToolStripMenuItem184;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem184).set_Size(size);
		((ToolStripItem)ToolStripMenuItem184).set_Text("&Rechercher");
		((ToolStripItem)ToolStripSeparator54).set_Name("ToolStripSeparator54");
		ToolStripSeparator toolStripSeparator54 = ToolStripSeparator54;
		size = new Size(163, 6);
		((ToolStripItem)toolStripSeparator54).set_Size(size);
		((ToolStripItem)ToolStripMenuItem185).set_Name("ToolStripMenuItem185");
		ToolStripMenuItem toolStripMenuItem185 = ToolStripMenuItem185;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem185).set_Size(size);
		((ToolStripItem)ToolStripMenuItem185).set_Text("À pr&opos de...");
		((ToolStripItem)ToolStripSeparator55).set_Name("ToolStripSeparator55");
		ToolStripSeparator toolStripSeparator55 = ToolStripSeparator55;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator55).set_Size(size);
		((ToolStripItem)ToolStripButton25).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton25).set_Image((Image)componentResourceManager.GetObject("ToolStripButton25.Image"));
		((ToolStripItem)ToolStripButton25).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton25).set_Name("ToolStripButton25");
		ToolStripButton toolStripButton25 = ToolStripButton25;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton25).set_Size(size);
		((ToolStripItem)ToolStripButton25).set_Text("Aide");
		((ToolStrip)StatusStrip6).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel6 });
		StatusStrip statusStrip13 = StatusStrip6;
		location = new Point(0, 250);
		((Control)statusStrip13).set_Location(location);
		((Control)StatusStrip6).set_Name("StatusStrip6");
		StatusStrip statusStrip14 = StatusStrip6;
		size = new Size(211, 22);
		((Control)statusStrip14).set_Size(size);
		((Control)StatusStrip6).set_TabIndex(25);
		((Control)StatusStrip6).set_Text("StatusStrip");
		((ToolStripItem)ToolStripStatusLabel6).set_Name("ToolStripStatusLabel6");
		ToolStripStatusLabel toolStripStatusLabel7 = ToolStripStatusLabel6;
		size = new Size(27, 17);
		((ToolStripItem)toolStripStatusLabel7).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel6).set_Text("État");
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
		((ToolStripItem)ToolStripSeparator56).set_Name("ToolStripSeparator56");
		ToolStripSeparator toolStripSeparator56 = ToolStripSeparator56;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator56).set_Size(size);
		ToolStrip6.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripButton28,
			(ToolStripItem)ToolStripButton29,
			(ToolStripItem)ToolStripButton30,
			(ToolStripItem)ToolStripSeparator56,
			(ToolStripItem)ToolStripButton27,
			(ToolStripItem)ToolStripButton26,
			(ToolStripItem)ToolStripSeparator55,
			(ToolStripItem)ToolStripButton25
		});
		ToolStrip toolStrip13 = ToolStrip6;
		location = new Point(0, 245);
		((Control)toolStrip13).set_Location(location);
		((Control)ToolStrip6).set_Name("ToolStrip6");
		ToolStrip toolStrip14 = ToolStrip6;
		size = new Size(211, 25);
		((Control)toolStrip14).set_Size(size);
		((Control)ToolStrip6).set_TabIndex(24);
		((Control)ToolStrip6).set_Text("ToolStrip");
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
		((ToolStrip)MenuStrip7).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem186,
			(ToolStripItem)ToolStripMenuItem195,
			(ToolStripItem)ToolStripMenuItem202,
			(ToolStripItem)ToolStripMenuItem205,
			(ToolStripItem)ToolStripMenuItem207,
			(ToolStripItem)ToolStripMenuItem214
		});
		MenuStrip menuStrip15 = MenuStrip7;
		location = new Point(0, 25);
		((Control)menuStrip15).set_Location(location);
		MenuStrip7.set_MdiWindowListItem(ToolStripMenuItem207);
		((Control)MenuStrip7).set_Name("MenuStrip7");
		MenuStrip menuStrip16 = MenuStrip7;
		size = new Size(417, 24);
		((Control)menuStrip16).set_Size(size);
		((Control)MenuStrip7).set_TabIndex(8);
		((Control)MenuStrip7).set_Text("MenuStrip7");
		((ToolStripDropDownItem)ToolStripMenuItem186).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)ToolStripMenuItem187,
			(ToolStripItem)ToolStripMenuItem188,
			(ToolStripItem)ToolStripSeparator57,
			(ToolStripItem)ToolStripMenuItem189,
			(ToolStripItem)ToolStripMenuItem190,
			(ToolStripItem)ToolStripSeparator58,
			(ToolStripItem)ToolStripMenuItem191,
			(ToolStripItem)ToolStripMenuItem192,
			(ToolStripItem)ToolStripMenuItem193,
			(ToolStripItem)ToolStripSeparator59,
			(ToolStripItem)ToolStripMenuItem194
		});
		((ToolStripItem)ToolStripMenuItem186).set_ImageTransparentColor(SystemColors.ActiveBorder);
		((ToolStripItem)ToolStripMenuItem186).set_Name("ToolStripMenuItem186");
		ToolStripMenuItem toolStripMenuItem186 = ToolStripMenuItem186;
		size = new Size(54, 20);
		((ToolStripItem)toolStripMenuItem186).set_Size(size);
		((ToolStripItem)ToolStripMenuItem186).set_Text("&Fichier");
		((ToolStripItem)ToolStripMenuItem187).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem187.Image"));
		((ToolStripItem)ToolStripMenuItem187).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem187).set_Name("ToolStripMenuItem187");
		ToolStripMenuItem187.set_ShortcutKeys((Keys)131150);
		ToolStripMenuItem toolStripMenuItem187 = ToolStripMenuItem187;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem187).set_Size(size);
		((ToolStripItem)ToolStripMenuItem187).set_Text("&Nouveau");
		((ToolStripItem)ToolStripMenuItem188).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem188.Image"));
		((ToolStripItem)ToolStripMenuItem188).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem188).set_Name("ToolStripMenuItem188");
		ToolStripMenuItem188.set_ShortcutKeys((Keys)131151);
		ToolStripMenuItem toolStripMenuItem188 = ToolStripMenuItem188;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem188).set_Size(size);
		((ToolStripItem)ToolStripMenuItem188).set_Text("&Ouvrir");
		((ToolStripItem)ToolStripSeparator57).set_Name("ToolStripSeparator57");
		ToolStripSeparator toolStripSeparator57 = ToolStripSeparator57;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator57).set_Size(size);
		((ToolStripItem)ToolStripMenuItem189).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem189.Image"));
		((ToolStripItem)ToolStripMenuItem189).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem189).set_Name("ToolStripMenuItem189");
		ToolStripMenuItem189.set_ShortcutKeys((Keys)131155);
		ToolStripMenuItem toolStripMenuItem189 = ToolStripMenuItem189;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem189).set_Size(size);
		((ToolStripItem)ToolStripMenuItem189).set_Text("&Enregistrer");
		((ToolStripItem)ToolStripMenuItem190).set_Name("ToolStripMenuItem190");
		ToolStripMenuItem toolStripMenuItem190 = ToolStripMenuItem190;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem190).set_Size(size);
		((ToolStripItem)ToolStripMenuItem190).set_Text("Enregistrer &sous");
		((ToolStripItem)ToolStripSeparator58).set_Name("ToolStripSeparator58");
		ToolStripSeparator toolStripSeparator58 = ToolStripSeparator58;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator58).set_Size(size);
		((ToolStripItem)ToolStripMenuItem191).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem191.Image"));
		((ToolStripItem)ToolStripMenuItem191).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem191).set_Name("ToolStripMenuItem191");
		ToolStripMenuItem191.set_ShortcutKeys((Keys)131152);
		ToolStripMenuItem toolStripMenuItem191 = ToolStripMenuItem191;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem191).set_Size(size);
		((ToolStripItem)ToolStripMenuItem191).set_Text("&Imprimer");
		((ToolStripItem)ToolStripMenuItem192).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem192.Image"));
		((ToolStripItem)ToolStripMenuItem192).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem192).set_Name("ToolStripMenuItem192");
		ToolStripMenuItem toolStripMenuItem192 = ToolStripMenuItem192;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem192).set_Size(size);
		((ToolStripItem)ToolStripMenuItem192).set_Text("Aperçu a&vant impression");
		((ToolStripItem)ToolStripMenuItem193).set_Name("ToolStripMenuItem193");
		ToolStripMenuItem toolStripMenuItem193 = ToolStripMenuItem193;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem193).set_Size(size);
		((ToolStripItem)ToolStripMenuItem193).set_Text("Configuration de l'impression");
		((ToolStripItem)ToolStripSeparator59).set_Name("ToolStripSeparator59");
		ToolStripSeparator toolStripSeparator59 = ToolStripSeparator59;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator59).set_Size(size);
		((ToolStripItem)ToolStripMenuItem194).set_Name("ToolStripMenuItem194");
		ToolStripMenuItem toolStripMenuItem194 = ToolStripMenuItem194;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem194).set_Size(size);
		((ToolStripItem)ToolStripMenuItem194).set_Text("&Quitter");
		((ToolStripDropDownItem)ToolStripMenuItem195).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripMenuItem196,
			(ToolStripItem)ToolStripMenuItem197,
			(ToolStripItem)ToolStripSeparator60,
			(ToolStripItem)ToolStripMenuItem198,
			(ToolStripItem)ToolStripMenuItem199,
			(ToolStripItem)ToolStripMenuItem200,
			(ToolStripItem)ToolStripSeparator61,
			(ToolStripItem)ToolStripMenuItem201
		});
		((ToolStripItem)ToolStripMenuItem195).set_Name("ToolStripMenuItem195");
		ToolStripMenuItem toolStripMenuItem195 = ToolStripMenuItem195;
		size = new Size(56, 20);
		((ToolStripItem)toolStripMenuItem195).set_Size(size);
		((ToolStripItem)ToolStripMenuItem195).set_Text("&Edition");
		((ToolStripItem)ToolStripMenuItem196).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem196.Image"));
		((ToolStripItem)ToolStripMenuItem196).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem196).set_Name("ToolStripMenuItem196");
		ToolStripMenuItem196.set_ShortcutKeys((Keys)131162);
		ToolStripMenuItem toolStripMenuItem196 = ToolStripMenuItem196;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem196).set_Size(size);
		((ToolStripItem)ToolStripMenuItem196).set_Text("&Annuler");
		((ToolStripItem)ToolStripMenuItem197).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem197.Image"));
		((ToolStripItem)ToolStripMenuItem197).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem197).set_Name("ToolStripMenuItem197");
		ToolStripMenuItem197.set_ShortcutKeys((Keys)131161);
		ToolStripMenuItem toolStripMenuItem197 = ToolStripMenuItem197;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem197).set_Size(size);
		((ToolStripItem)ToolStripMenuItem197).set_Text("&Rétablir");
		((ToolStripItem)ToolStripSeparator60).set_Name("ToolStripSeparator60");
		ToolStripSeparator toolStripSeparator60 = ToolStripSeparator60;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator60).set_Size(size);
		((ToolStripItem)ToolStripMenuItem198).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem198.Image"));
		((ToolStripItem)ToolStripMenuItem198).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem198).set_Name("ToolStripMenuItem198");
		ToolStripMenuItem198.set_ShortcutKeys((Keys)131160);
		ToolStripMenuItem toolStripMenuItem198 = ToolStripMenuItem198;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem198).set_Size(size);
		((ToolStripItem)ToolStripMenuItem198).set_Text("Co&uper");
		((ToolStripItem)ToolStripMenuItem199).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem199.Image"));
		((ToolStripItem)ToolStripMenuItem199).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem199).set_Name("ToolStripMenuItem199");
		ToolStripMenuItem199.set_ShortcutKeys((Keys)131139);
		ToolStripMenuItem toolStripMenuItem199 = ToolStripMenuItem199;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem199).set_Size(size);
		((ToolStripItem)ToolStripMenuItem199).set_Text("&Copier");
		((ToolStripItem)ToolStripMenuItem200).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem200.Image"));
		((ToolStripItem)ToolStripMenuItem200).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem200).set_Name("ToolStripMenuItem200");
		ToolStripMenuItem200.set_ShortcutKeys((Keys)131158);
		ToolStripMenuItem toolStripMenuItem200 = ToolStripMenuItem200;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem200).set_Size(size);
		((ToolStripItem)ToolStripMenuItem200).set_Text("&Coller");
		((ToolStripItem)ToolStripSeparator61).set_Name("ToolStripSeparator61");
		ToolStripSeparator toolStripSeparator61 = ToolStripSeparator61;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator61).set_Size(size);
		((ToolStripItem)ToolStripMenuItem201).set_Name("ToolStripMenuItem201");
		ToolStripMenuItem201.set_ShortcutKeys((Keys)131137);
		ToolStripMenuItem toolStripMenuItem201 = ToolStripMenuItem201;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem201).set_Size(size);
		((ToolStripItem)ToolStripMenuItem201).set_Text("Sélectionner &tout");
		((ToolStripDropDownItem)ToolStripMenuItem202).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolStripMenuItem203,
			(ToolStripItem)ToolStripMenuItem204
		});
		((ToolStripItem)ToolStripMenuItem202).set_Name("ToolStripMenuItem202");
		ToolStripMenuItem toolStripMenuItem202 = ToolStripMenuItem202;
		size = new Size(70, 20);
		((ToolStripItem)toolStripMenuItem202).set_Size(size);
		((ToolStripItem)ToolStripMenuItem202).set_Text("&Affichage");
		ToolStripMenuItem203.set_Checked(true);
		ToolStripMenuItem203.set_CheckOnClick(true);
		ToolStripMenuItem203.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem203).set_Name("ToolStripMenuItem203");
		ToolStripMenuItem toolStripMenuItem203 = ToolStripMenuItem203;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem203).set_Size(size);
		((ToolStripItem)ToolStripMenuItem203).set_Text("&Barre d'outils");
		ToolStripMenuItem204.set_Checked(true);
		ToolStripMenuItem204.set_CheckOnClick(true);
		ToolStripMenuItem204.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem204).set_Name("ToolStripMenuItem204");
		ToolStripMenuItem toolStripMenuItem204 = ToolStripMenuItem204;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem204).set_Size(size);
		((ToolStripItem)ToolStripMenuItem204).set_Text("&Barre d'état");
		((ToolStripDropDownItem)ToolStripMenuItem205).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripMenuItem206 });
		((ToolStripItem)ToolStripMenuItem205).set_Name("ToolStripMenuItem205");
		ToolStripMenuItem toolStripMenuItem205 = ToolStripMenuItem205;
		size = new Size(50, 20);
		((ToolStripItem)toolStripMenuItem205).set_Size(size);
		((ToolStripItem)ToolStripMenuItem205).set_Text("&Outils");
		((ToolStripItem)ToolStripMenuItem206).set_Name("ToolStripMenuItem206");
		ToolStripMenuItem toolStripMenuItem206 = ToolStripMenuItem206;
		size = new Size(116, 22);
		((ToolStripItem)toolStripMenuItem206).set_Size(size);
		((ToolStripItem)ToolStripMenuItem206).set_Text("&Options");
		((ToolStripDropDownItem)ToolStripMenuItem207).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem208,
			(ToolStripItem)ToolStripMenuItem209,
			(ToolStripItem)ToolStripMenuItem210,
			(ToolStripItem)ToolStripMenuItem211,
			(ToolStripItem)ToolStripMenuItem212,
			(ToolStripItem)ToolStripMenuItem213
		});
		((ToolStripItem)ToolStripMenuItem207).set_Name("ToolStripMenuItem207");
		ToolStripMenuItem toolStripMenuItem207 = ToolStripMenuItem207;
		size = new Size(63, 20);
		((ToolStripItem)toolStripMenuItem207).set_Size(size);
		((ToolStripItem)ToolStripMenuItem207).set_Text("F&enêtres");
		((ToolStripItem)ToolStripMenuItem208).set_Name("ToolStripMenuItem208");
		ToolStripMenuItem toolStripMenuItem208 = ToolStripMenuItem208;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem208).set_Size(size);
		((ToolStripItem)ToolStripMenuItem208).set_Text("&Nouvelle fenêtre");
		((ToolStripItem)ToolStripMenuItem209).set_Name("ToolStripMenuItem209");
		ToolStripMenuItem toolStripMenuItem209 = ToolStripMenuItem209;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem209).set_Size(size);
		((ToolStripItem)ToolStripMenuItem209).set_Text("&Cascade");
		((ToolStripItem)ToolStripMenuItem210).set_Name("ToolStripMenuItem210");
		ToolStripMenuItem toolStripMenuItem210 = ToolStripMenuItem210;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem210).set_Size(size);
		((ToolStripItem)ToolStripMenuItem210).set_Text("Mosaïque &verticale");
		((ToolStripItem)ToolStripMenuItem211).set_Name("ToolStripMenuItem211");
		ToolStripMenuItem toolStripMenuItem211 = ToolStripMenuItem211;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem211).set_Size(size);
		((ToolStripItem)ToolStripMenuItem211).set_Text("Mosaïque &horizontale");
		((ToolStripItem)ToolStripMenuItem212).set_Name("ToolStripMenuItem212");
		ToolStripMenuItem toolStripMenuItem212 = ToolStripMenuItem212;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem212).set_Size(size);
		((ToolStripItem)ToolStripMenuItem212).set_Text("&Fermer tout");
		((ToolStripItem)ToolStripMenuItem213).set_Name("ToolStripMenuItem213");
		ToolStripMenuItem toolStripMenuItem213 = ToolStripMenuItem213;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem213).set_Size(size);
		((ToolStripItem)ToolStripMenuItem213).set_Text("&Réorganiser les icônes");
		((ToolStripDropDownItem)ToolStripMenuItem214).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ToolStripMenuItem215,
			(ToolStripItem)ToolStripMenuItem216,
			(ToolStripItem)ToolStripMenuItem217,
			(ToolStripItem)ToolStripSeparator62,
			(ToolStripItem)ToolStripMenuItem218
		});
		((ToolStripItem)ToolStripMenuItem214).set_Name("ToolStripMenuItem214");
		ToolStripMenuItem toolStripMenuItem214 = ToolStripMenuItem214;
		size = new Size(24, 20);
		((ToolStripItem)toolStripMenuItem214).set_Size(size);
		((ToolStripItem)ToolStripMenuItem214).set_Text("&?");
		((ToolStripItem)ToolStripMenuItem215).set_Name("ToolStripMenuItem215");
		ToolStripMenuItem215.set_ShortcutKeys((Keys)131184);
		ToolStripMenuItem toolStripMenuItem215 = ToolStripMenuItem215;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem215).set_Size(size);
		((ToolStripItem)ToolStripMenuItem215).set_Text("&Contenu");
		((ToolStripItem)ToolStripMenuItem216).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem216.Image"));
		((ToolStripItem)ToolStripMenuItem216).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem216).set_Name("ToolStripMenuItem216");
		ToolStripMenuItem toolStripMenuItem216 = ToolStripMenuItem216;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem216).set_Size(size);
		((ToolStripItem)ToolStripMenuItem216).set_Text("&Index");
		((ToolStripItem)ToolStripMenuItem217).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem217.Image"));
		((ToolStripItem)ToolStripMenuItem217).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem217).set_Name("ToolStripMenuItem217");
		ToolStripMenuItem toolStripMenuItem217 = ToolStripMenuItem217;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem217).set_Size(size);
		((ToolStripItem)ToolStripMenuItem217).set_Text("&Rechercher");
		((ToolStripItem)ToolStripSeparator62).set_Name("ToolStripSeparator62");
		ToolStripSeparator toolStripSeparator62 = ToolStripSeparator62;
		size = new Size(163, 6);
		((ToolStripItem)toolStripSeparator62).set_Size(size);
		((ToolStripItem)ToolStripMenuItem218).set_Name("ToolStripMenuItem218");
		ToolStripMenuItem toolStripMenuItem218 = ToolStripMenuItem218;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem218).set_Size(size);
		((ToolStripItem)ToolStripMenuItem218).set_Text("À pr&opos de...");
		((ToolStripItem)ToolStripSeparator63).set_Name("ToolStripSeparator63");
		ToolStripSeparator toolStripSeparator63 = ToolStripSeparator63;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator63).set_Size(size);
		((ToolStripItem)ToolStripButton31).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton31).set_Image((Image)componentResourceManager.GetObject("ToolStripButton31.Image"));
		((ToolStripItem)ToolStripButton31).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton31).set_Name("ToolStripButton31");
		ToolStripButton toolStripButton31 = ToolStripButton31;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton31).set_Size(size);
		((ToolStripItem)ToolStripButton31).set_Text("Aide");
		((ToolStrip)StatusStrip7).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel7 });
		StatusStrip statusStrip15 = StatusStrip7;
		location = new Point(0, 360);
		((Control)statusStrip15).set_Location(location);
		((Control)StatusStrip7).set_Name("StatusStrip7");
		StatusStrip statusStrip16 = StatusStrip7;
		size = new Size(417, 22);
		((Control)statusStrip16).set_Size(size);
		((Control)StatusStrip7).set_TabIndex(10);
		((Control)StatusStrip7).set_Text("StatusStrip");
		((ToolStripItem)ToolStripStatusLabel7).set_Name("ToolStripStatusLabel7");
		ToolStripStatusLabel toolStripStatusLabel8 = ToolStripStatusLabel7;
		size = new Size(27, 17);
		((ToolStripItem)toolStripStatusLabel8).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel7).set_Text("État");
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
		((ToolStripItem)ToolStripSeparator64).set_Name("ToolStripSeparator64");
		ToolStripSeparator toolStripSeparator64 = ToolStripSeparator64;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator64).set_Size(size);
		ToolStrip7.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripButton34,
			(ToolStripItem)ToolStripButton35,
			(ToolStripItem)ToolStripButton36,
			(ToolStripItem)ToolStripSeparator64,
			(ToolStripItem)ToolStripButton33,
			(ToolStripItem)ToolStripButton32,
			(ToolStripItem)ToolStripSeparator63,
			(ToolStripItem)ToolStripButton31
		});
		ToolStrip toolStrip15 = ToolStrip7;
		location = new Point(0, 0);
		((Control)toolStrip15).set_Location(location);
		((Control)ToolStrip7).set_Name("ToolStrip7");
		ToolStrip toolStrip16 = ToolStrip7;
		size = new Size(417, 25);
		((Control)toolStrip16).set_Size(size);
		((Control)ToolStrip7).set_TabIndex(9);
		((Control)ToolStrip7).set_Text("ToolStrip");
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
		((ToolStrip)MenuStrip8).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem219,
			(ToolStripItem)ToolStripMenuItem228,
			(ToolStripItem)ToolStripMenuItem235,
			(ToolStripItem)ToolStripMenuItem238,
			(ToolStripItem)ToolStripMenuItem240,
			(ToolStripItem)ToolStripMenuItem247
		});
		MenuStrip menuStrip17 = MenuStrip8;
		location = new Point(0, 74);
		((Control)menuStrip17).set_Location(location);
		MenuStrip8.set_MdiWindowListItem(ToolStripMenuItem240);
		((Control)MenuStrip8).set_Name("MenuStrip8");
		MenuStrip menuStrip18 = MenuStrip8;
		size = new Size(417, 24);
		((Control)menuStrip18).set_Size(size);
		((Control)MenuStrip8).set_TabIndex(11);
		((Control)MenuStrip8).set_Text("MenuStrip8");
		((ToolStripDropDownItem)ToolStripMenuItem219).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)ToolStripMenuItem220,
			(ToolStripItem)ToolStripMenuItem221,
			(ToolStripItem)ToolStripSeparator65,
			(ToolStripItem)ToolStripMenuItem222,
			(ToolStripItem)ToolStripMenuItem223,
			(ToolStripItem)ToolStripSeparator66,
			(ToolStripItem)ToolStripMenuItem224,
			(ToolStripItem)ToolStripMenuItem225,
			(ToolStripItem)ToolStripMenuItem226,
			(ToolStripItem)ToolStripSeparator67,
			(ToolStripItem)ToolStripMenuItem227
		});
		((ToolStripItem)ToolStripMenuItem219).set_ImageTransparentColor(SystemColors.ActiveBorder);
		((ToolStripItem)ToolStripMenuItem219).set_Name("ToolStripMenuItem219");
		ToolStripMenuItem toolStripMenuItem219 = ToolStripMenuItem219;
		size = new Size(54, 20);
		((ToolStripItem)toolStripMenuItem219).set_Size(size);
		((ToolStripItem)ToolStripMenuItem219).set_Text("&Fichier");
		((ToolStripItem)ToolStripMenuItem220).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem220.Image"));
		((ToolStripItem)ToolStripMenuItem220).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem220).set_Name("ToolStripMenuItem220");
		ToolStripMenuItem220.set_ShortcutKeys((Keys)131150);
		ToolStripMenuItem toolStripMenuItem220 = ToolStripMenuItem220;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem220).set_Size(size);
		((ToolStripItem)ToolStripMenuItem220).set_Text("&Nouveau");
		((ToolStripItem)ToolStripMenuItem221).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem221.Image"));
		((ToolStripItem)ToolStripMenuItem221).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem221).set_Name("ToolStripMenuItem221");
		ToolStripMenuItem221.set_ShortcutKeys((Keys)131151);
		ToolStripMenuItem toolStripMenuItem221 = ToolStripMenuItem221;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem221).set_Size(size);
		((ToolStripItem)ToolStripMenuItem221).set_Text("&Ouvrir");
		((ToolStripItem)ToolStripSeparator65).set_Name("ToolStripSeparator65");
		ToolStripSeparator toolStripSeparator65 = ToolStripSeparator65;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator65).set_Size(size);
		((ToolStripItem)ToolStripMenuItem222).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem222.Image"));
		((ToolStripItem)ToolStripMenuItem222).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem222).set_Name("ToolStripMenuItem222");
		ToolStripMenuItem222.set_ShortcutKeys((Keys)131155);
		ToolStripMenuItem toolStripMenuItem222 = ToolStripMenuItem222;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem222).set_Size(size);
		((ToolStripItem)ToolStripMenuItem222).set_Text("&Enregistrer");
		((ToolStripItem)ToolStripMenuItem223).set_Name("ToolStripMenuItem223");
		ToolStripMenuItem toolStripMenuItem223 = ToolStripMenuItem223;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem223).set_Size(size);
		((ToolStripItem)ToolStripMenuItem223).set_Text("Enregistrer &sous");
		((ToolStripItem)ToolStripSeparator66).set_Name("ToolStripSeparator66");
		ToolStripSeparator toolStripSeparator66 = ToolStripSeparator66;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator66).set_Size(size);
		((ToolStripItem)ToolStripMenuItem224).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem224.Image"));
		((ToolStripItem)ToolStripMenuItem224).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem224).set_Name("ToolStripMenuItem224");
		ToolStripMenuItem224.set_ShortcutKeys((Keys)131152);
		ToolStripMenuItem toolStripMenuItem224 = ToolStripMenuItem224;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem224).set_Size(size);
		((ToolStripItem)ToolStripMenuItem224).set_Text("&Imprimer");
		((ToolStripItem)ToolStripMenuItem225).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem225.Image"));
		((ToolStripItem)ToolStripMenuItem225).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem225).set_Name("ToolStripMenuItem225");
		ToolStripMenuItem toolStripMenuItem225 = ToolStripMenuItem225;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem225).set_Size(size);
		((ToolStripItem)ToolStripMenuItem225).set_Text("Aperçu a&vant impression");
		((ToolStripItem)ToolStripMenuItem226).set_Name("ToolStripMenuItem226");
		ToolStripMenuItem toolStripMenuItem226 = ToolStripMenuItem226;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem226).set_Size(size);
		((ToolStripItem)ToolStripMenuItem226).set_Text("Configuration de l'impression");
		((ToolStripItem)ToolStripSeparator67).set_Name("ToolStripSeparator67");
		ToolStripSeparator toolStripSeparator67 = ToolStripSeparator67;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator67).set_Size(size);
		((ToolStripItem)ToolStripMenuItem227).set_Name("ToolStripMenuItem227");
		ToolStripMenuItem toolStripMenuItem227 = ToolStripMenuItem227;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem227).set_Size(size);
		((ToolStripItem)ToolStripMenuItem227).set_Text("&Quitter");
		((ToolStripDropDownItem)ToolStripMenuItem228).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripMenuItem229,
			(ToolStripItem)ToolStripMenuItem230,
			(ToolStripItem)ToolStripSeparator68,
			(ToolStripItem)ToolStripMenuItem231,
			(ToolStripItem)ToolStripMenuItem232,
			(ToolStripItem)ToolStripMenuItem233,
			(ToolStripItem)ToolStripSeparator69,
			(ToolStripItem)ToolStripMenuItem234
		});
		((ToolStripItem)ToolStripMenuItem228).set_Name("ToolStripMenuItem228");
		ToolStripMenuItem toolStripMenuItem228 = ToolStripMenuItem228;
		size = new Size(56, 20);
		((ToolStripItem)toolStripMenuItem228).set_Size(size);
		((ToolStripItem)ToolStripMenuItem228).set_Text("&Edition");
		((ToolStripItem)ToolStripMenuItem229).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem229.Image"));
		((ToolStripItem)ToolStripMenuItem229).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem229).set_Name("ToolStripMenuItem229");
		ToolStripMenuItem229.set_ShortcutKeys((Keys)131162);
		ToolStripMenuItem toolStripMenuItem229 = ToolStripMenuItem229;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem229).set_Size(size);
		((ToolStripItem)ToolStripMenuItem229).set_Text("&Annuler");
		((ToolStripItem)ToolStripMenuItem230).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem230.Image"));
		((ToolStripItem)ToolStripMenuItem230).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem230).set_Name("ToolStripMenuItem230");
		ToolStripMenuItem230.set_ShortcutKeys((Keys)131161);
		ToolStripMenuItem toolStripMenuItem230 = ToolStripMenuItem230;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem230).set_Size(size);
		((ToolStripItem)ToolStripMenuItem230).set_Text("&Rétablir");
		((ToolStripItem)ToolStripSeparator68).set_Name("ToolStripSeparator68");
		ToolStripSeparator toolStripSeparator68 = ToolStripSeparator68;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator68).set_Size(size);
		((ToolStripItem)ToolStripMenuItem231).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem231.Image"));
		((ToolStripItem)ToolStripMenuItem231).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem231).set_Name("ToolStripMenuItem231");
		ToolStripMenuItem231.set_ShortcutKeys((Keys)131160);
		ToolStripMenuItem toolStripMenuItem231 = ToolStripMenuItem231;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem231).set_Size(size);
		((ToolStripItem)ToolStripMenuItem231).set_Text("Co&uper");
		((ToolStripItem)ToolStripMenuItem232).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem232.Image"));
		((ToolStripItem)ToolStripMenuItem232).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem232).set_Name("ToolStripMenuItem232");
		ToolStripMenuItem232.set_ShortcutKeys((Keys)131139);
		ToolStripMenuItem toolStripMenuItem232 = ToolStripMenuItem232;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem232).set_Size(size);
		((ToolStripItem)ToolStripMenuItem232).set_Text("&Copier");
		((ToolStripItem)ToolStripMenuItem233).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem233.Image"));
		((ToolStripItem)ToolStripMenuItem233).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem233).set_Name("ToolStripMenuItem233");
		ToolStripMenuItem233.set_ShortcutKeys((Keys)131158);
		ToolStripMenuItem toolStripMenuItem233 = ToolStripMenuItem233;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem233).set_Size(size);
		((ToolStripItem)ToolStripMenuItem233).set_Text("&Coller");
		((ToolStripItem)ToolStripSeparator69).set_Name("ToolStripSeparator69");
		ToolStripSeparator toolStripSeparator69 = ToolStripSeparator69;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator69).set_Size(size);
		((ToolStripItem)ToolStripMenuItem234).set_Name("ToolStripMenuItem234");
		ToolStripMenuItem234.set_ShortcutKeys((Keys)131137);
		ToolStripMenuItem toolStripMenuItem234 = ToolStripMenuItem234;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem234).set_Size(size);
		((ToolStripItem)ToolStripMenuItem234).set_Text("Sélectionner &tout");
		((ToolStripDropDownItem)ToolStripMenuItem235).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolStripMenuItem236,
			(ToolStripItem)ToolStripMenuItem237
		});
		((ToolStripItem)ToolStripMenuItem235).set_Name("ToolStripMenuItem235");
		ToolStripMenuItem toolStripMenuItem235 = ToolStripMenuItem235;
		size = new Size(70, 20);
		((ToolStripItem)toolStripMenuItem235).set_Size(size);
		((ToolStripItem)ToolStripMenuItem235).set_Text("&Affichage");
		ToolStripMenuItem236.set_Checked(true);
		ToolStripMenuItem236.set_CheckOnClick(true);
		ToolStripMenuItem236.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem236).set_Name("ToolStripMenuItem236");
		ToolStripMenuItem toolStripMenuItem236 = ToolStripMenuItem236;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem236).set_Size(size);
		((ToolStripItem)ToolStripMenuItem236).set_Text("&Barre d'outils");
		ToolStripMenuItem237.set_Checked(true);
		ToolStripMenuItem237.set_CheckOnClick(true);
		ToolStripMenuItem237.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem237).set_Name("ToolStripMenuItem237");
		ToolStripMenuItem toolStripMenuItem237 = ToolStripMenuItem237;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem237).set_Size(size);
		((ToolStripItem)ToolStripMenuItem237).set_Text("&Barre d'état");
		((ToolStripDropDownItem)ToolStripMenuItem238).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripMenuItem239 });
		((ToolStripItem)ToolStripMenuItem238).set_Name("ToolStripMenuItem238");
		ToolStripMenuItem toolStripMenuItem238 = ToolStripMenuItem238;
		size = new Size(50, 20);
		((ToolStripItem)toolStripMenuItem238).set_Size(size);
		((ToolStripItem)ToolStripMenuItem238).set_Text("&Outils");
		((ToolStripItem)ToolStripMenuItem239).set_Name("ToolStripMenuItem239");
		ToolStripMenuItem toolStripMenuItem239 = ToolStripMenuItem239;
		size = new Size(116, 22);
		((ToolStripItem)toolStripMenuItem239).set_Size(size);
		((ToolStripItem)ToolStripMenuItem239).set_Text("&Options");
		((ToolStripDropDownItem)ToolStripMenuItem240).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem241,
			(ToolStripItem)ToolStripMenuItem242,
			(ToolStripItem)ToolStripMenuItem243,
			(ToolStripItem)ToolStripMenuItem244,
			(ToolStripItem)ToolStripMenuItem245,
			(ToolStripItem)ToolStripMenuItem246
		});
		((ToolStripItem)ToolStripMenuItem240).set_Name("ToolStripMenuItem240");
		ToolStripMenuItem toolStripMenuItem240 = ToolStripMenuItem240;
		size = new Size(63, 20);
		((ToolStripItem)toolStripMenuItem240).set_Size(size);
		((ToolStripItem)ToolStripMenuItem240).set_Text("F&enêtres");
		((ToolStripItem)ToolStripMenuItem241).set_Name("ToolStripMenuItem241");
		ToolStripMenuItem toolStripMenuItem241 = ToolStripMenuItem241;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem241).set_Size(size);
		((ToolStripItem)ToolStripMenuItem241).set_Text("&Nouvelle fenêtre");
		((ToolStripItem)ToolStripMenuItem242).set_Name("ToolStripMenuItem242");
		ToolStripMenuItem toolStripMenuItem242 = ToolStripMenuItem242;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem242).set_Size(size);
		((ToolStripItem)ToolStripMenuItem242).set_Text("&Cascade");
		((ToolStripItem)ToolStripMenuItem243).set_Name("ToolStripMenuItem243");
		ToolStripMenuItem toolStripMenuItem243 = ToolStripMenuItem243;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem243).set_Size(size);
		((ToolStripItem)ToolStripMenuItem243).set_Text("Mosaïque &verticale");
		((ToolStripItem)ToolStripMenuItem244).set_Name("ToolStripMenuItem244");
		ToolStripMenuItem toolStripMenuItem244 = ToolStripMenuItem244;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem244).set_Size(size);
		((ToolStripItem)ToolStripMenuItem244).set_Text("Mosaïque &horizontale");
		((ToolStripItem)ToolStripMenuItem245).set_Name("ToolStripMenuItem245");
		ToolStripMenuItem toolStripMenuItem245 = ToolStripMenuItem245;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem245).set_Size(size);
		((ToolStripItem)ToolStripMenuItem245).set_Text("&Fermer tout");
		((ToolStripItem)ToolStripMenuItem246).set_Name("ToolStripMenuItem246");
		ToolStripMenuItem toolStripMenuItem246 = ToolStripMenuItem246;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem246).set_Size(size);
		((ToolStripItem)ToolStripMenuItem246).set_Text("&Réorganiser les icônes");
		((ToolStripDropDownItem)ToolStripMenuItem247).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ToolStripMenuItem248,
			(ToolStripItem)ToolStripMenuItem249,
			(ToolStripItem)ToolStripMenuItem250,
			(ToolStripItem)ToolStripSeparator70,
			(ToolStripItem)ToolStripMenuItem251
		});
		((ToolStripItem)ToolStripMenuItem247).set_Name("ToolStripMenuItem247");
		ToolStripMenuItem toolStripMenuItem247 = ToolStripMenuItem247;
		size = new Size(24, 20);
		((ToolStripItem)toolStripMenuItem247).set_Size(size);
		((ToolStripItem)ToolStripMenuItem247).set_Text("&?");
		((ToolStripItem)ToolStripMenuItem248).set_Name("ToolStripMenuItem248");
		ToolStripMenuItem248.set_ShortcutKeys((Keys)131184);
		ToolStripMenuItem toolStripMenuItem248 = ToolStripMenuItem248;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem248).set_Size(size);
		((ToolStripItem)ToolStripMenuItem248).set_Text("&Contenu");
		((ToolStripItem)ToolStripMenuItem249).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem249.Image"));
		((ToolStripItem)ToolStripMenuItem249).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem249).set_Name("ToolStripMenuItem249");
		ToolStripMenuItem toolStripMenuItem249 = ToolStripMenuItem249;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem249).set_Size(size);
		((ToolStripItem)ToolStripMenuItem249).set_Text("&Index");
		((ToolStripItem)ToolStripMenuItem250).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem250.Image"));
		((ToolStripItem)ToolStripMenuItem250).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem250).set_Name("ToolStripMenuItem250");
		ToolStripMenuItem toolStripMenuItem250 = ToolStripMenuItem250;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem250).set_Size(size);
		((ToolStripItem)ToolStripMenuItem250).set_Text("&Rechercher");
		((ToolStripItem)ToolStripSeparator70).set_Name("ToolStripSeparator70");
		ToolStripSeparator toolStripSeparator70 = ToolStripSeparator70;
		size = new Size(163, 6);
		((ToolStripItem)toolStripSeparator70).set_Size(size);
		((ToolStripItem)ToolStripMenuItem251).set_Name("ToolStripMenuItem251");
		ToolStripMenuItem toolStripMenuItem251 = ToolStripMenuItem251;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem251).set_Size(size);
		((ToolStripItem)ToolStripMenuItem251).set_Text("À pr&opos de...");
		((ToolStripItem)ToolStripSeparator71).set_Name("ToolStripSeparator71");
		ToolStripSeparator toolStripSeparator71 = ToolStripSeparator71;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator71).set_Size(size);
		((ToolStripItem)ToolStripButton37).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton37).set_Image((Image)componentResourceManager.GetObject("ToolStripButton37.Image"));
		((ToolStripItem)ToolStripButton37).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton37).set_Name("ToolStripButton37");
		ToolStripButton toolStripButton37 = ToolStripButton37;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton37).set_Size(size);
		((ToolStripItem)ToolStripButton37).set_Text("Aide");
		((ToolStrip)StatusStrip8).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel8 });
		StatusStrip statusStrip17 = StatusStrip8;
		location = new Point(0, 338);
		((Control)statusStrip17).set_Location(location);
		((Control)StatusStrip8).set_Name("StatusStrip8");
		StatusStrip statusStrip18 = StatusStrip8;
		size = new Size(417, 22);
		((Control)statusStrip18).set_Size(size);
		((Control)StatusStrip8).set_TabIndex(13);
		((Control)StatusStrip8).set_Text("StatusStrip");
		((ToolStripItem)ToolStripStatusLabel8).set_Name("ToolStripStatusLabel8");
		ToolStripStatusLabel toolStripStatusLabel9 = ToolStripStatusLabel8;
		size = new Size(27, 17);
		((ToolStripItem)toolStripStatusLabel9).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel8).set_Text("État");
		((ToolStripItem)ToolStripButton38).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton38).set_Image((Image)componentResourceManager.GetObject("ToolStripButton38.Image"));
		((ToolStripItem)ToolStripButton38).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton38).set_Name("ToolStripButton38");
		ToolStripButton toolStripButton38 = ToolStripButton38;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton38).set_Size(size);
		((ToolStripItem)ToolStripButton38).set_Text("Aperçu avant impression");
		((ToolStripItem)ToolStripButton39).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton39).set_Image((Image)componentResourceManager.GetObject("ToolStripButton39.Image"));
		((ToolStripItem)ToolStripButton39).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton39).set_Name("ToolStripButton39");
		ToolStripButton toolStripButton39 = ToolStripButton39;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton39).set_Size(size);
		((ToolStripItem)ToolStripButton39).set_Text("Imprimer");
		((ToolStripItem)ToolStripSeparator72).set_Name("ToolStripSeparator72");
		ToolStripSeparator toolStripSeparator72 = ToolStripSeparator72;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator72).set_Size(size);
		ToolStrip8.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripButton40,
			(ToolStripItem)ToolStripButton41,
			(ToolStripItem)ToolStripButton42,
			(ToolStripItem)ToolStripSeparator72,
			(ToolStripItem)ToolStripButton39,
			(ToolStripItem)ToolStripButton38,
			(ToolStripItem)ToolStripSeparator71,
			(ToolStripItem)ToolStripButton37
		});
		ToolStrip toolStrip17 = ToolStrip8;
		location = new Point(0, 49);
		((Control)toolStrip17).set_Location(location);
		((Control)ToolStrip8).set_Name("ToolStrip8");
		ToolStrip toolStrip18 = ToolStrip8;
		size = new Size(417, 25);
		((Control)toolStrip18).set_Size(size);
		((Control)ToolStrip8).set_TabIndex(12);
		((Control)ToolStrip8).set_Text("ToolStrip");
		((ToolStripItem)ToolStripButton40).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton40).set_Image((Image)componentResourceManager.GetObject("ToolStripButton40.Image"));
		((ToolStripItem)ToolStripButton40).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton40).set_Name("ToolStripButton40");
		ToolStripButton toolStripButton40 = ToolStripButton40;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton40).set_Size(size);
		((ToolStripItem)ToolStripButton40).set_Text("Nouveau");
		((ToolStripItem)ToolStripButton41).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton41).set_Image((Image)componentResourceManager.GetObject("ToolStripButton41.Image"));
		((ToolStripItem)ToolStripButton41).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton41).set_Name("ToolStripButton41");
		ToolStripButton toolStripButton41 = ToolStripButton41;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton41).set_Size(size);
		((ToolStripItem)ToolStripButton41).set_Text("Ouvrir");
		((ToolStripItem)ToolStripButton42).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton42).set_Image((Image)componentResourceManager.GetObject("ToolStripButton42.Image"));
		((ToolStripItem)ToolStripButton42).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton42).set_Name("ToolStripButton42");
		ToolStripButton toolStripButton42 = ToolStripButton42;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton42).set_Size(size);
		((ToolStripItem)ToolStripButton42).set_Text("Enregistrer");
		((ToolStrip)MenuStrip9).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem252,
			(ToolStripItem)ToolStripMenuItem261,
			(ToolStripItem)ToolStripMenuItem268,
			(ToolStripItem)ToolStripMenuItem271,
			(ToolStripItem)ToolStripMenuItem273,
			(ToolStripItem)ToolStripMenuItem280
		});
		MenuStrip menuStrip19 = MenuStrip9;
		location = new Point(0, 123);
		((Control)menuStrip19).set_Location(location);
		MenuStrip9.set_MdiWindowListItem(ToolStripMenuItem273);
		((Control)MenuStrip9).set_Name("MenuStrip9");
		MenuStrip menuStrip20 = MenuStrip9;
		size = new Size(417, 24);
		((Control)menuStrip20).set_Size(size);
		((Control)MenuStrip9).set_TabIndex(14);
		((Control)MenuStrip9).set_Text("MenuStrip9");
		((ToolStripDropDownItem)ToolStripMenuItem252).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)ToolStripMenuItem253,
			(ToolStripItem)ToolStripMenuItem254,
			(ToolStripItem)ToolStripSeparator73,
			(ToolStripItem)ToolStripMenuItem255,
			(ToolStripItem)ToolStripMenuItem256,
			(ToolStripItem)ToolStripSeparator74,
			(ToolStripItem)ToolStripMenuItem257,
			(ToolStripItem)ToolStripMenuItem258,
			(ToolStripItem)ToolStripMenuItem259,
			(ToolStripItem)ToolStripSeparator75,
			(ToolStripItem)ToolStripMenuItem260
		});
		((ToolStripItem)ToolStripMenuItem252).set_ImageTransparentColor(SystemColors.ActiveBorder);
		((ToolStripItem)ToolStripMenuItem252).set_Name("ToolStripMenuItem252");
		ToolStripMenuItem toolStripMenuItem252 = ToolStripMenuItem252;
		size = new Size(54, 20);
		((ToolStripItem)toolStripMenuItem252).set_Size(size);
		((ToolStripItem)ToolStripMenuItem252).set_Text("&Fichier");
		((ToolStripItem)ToolStripMenuItem253).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem253.Image"));
		((ToolStripItem)ToolStripMenuItem253).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem253).set_Name("ToolStripMenuItem253");
		ToolStripMenuItem253.set_ShortcutKeys((Keys)131150);
		ToolStripMenuItem toolStripMenuItem253 = ToolStripMenuItem253;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem253).set_Size(size);
		((ToolStripItem)ToolStripMenuItem253).set_Text("&Nouveau");
		((ToolStripItem)ToolStripMenuItem254).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem254.Image"));
		((ToolStripItem)ToolStripMenuItem254).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem254).set_Name("ToolStripMenuItem254");
		ToolStripMenuItem254.set_ShortcutKeys((Keys)131151);
		ToolStripMenuItem toolStripMenuItem254 = ToolStripMenuItem254;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem254).set_Size(size);
		((ToolStripItem)ToolStripMenuItem254).set_Text("&Ouvrir");
		((ToolStripItem)ToolStripSeparator73).set_Name("ToolStripSeparator73");
		ToolStripSeparator toolStripSeparator73 = ToolStripSeparator73;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator73).set_Size(size);
		((ToolStripItem)ToolStripMenuItem255).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem255.Image"));
		((ToolStripItem)ToolStripMenuItem255).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem255).set_Name("ToolStripMenuItem255");
		ToolStripMenuItem255.set_ShortcutKeys((Keys)131155);
		ToolStripMenuItem toolStripMenuItem255 = ToolStripMenuItem255;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem255).set_Size(size);
		((ToolStripItem)ToolStripMenuItem255).set_Text("&Enregistrer");
		((ToolStripItem)ToolStripMenuItem256).set_Name("ToolStripMenuItem256");
		ToolStripMenuItem toolStripMenuItem256 = ToolStripMenuItem256;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem256).set_Size(size);
		((ToolStripItem)ToolStripMenuItem256).set_Text("Enregistrer &sous");
		((ToolStripItem)ToolStripSeparator74).set_Name("ToolStripSeparator74");
		ToolStripSeparator toolStripSeparator74 = ToolStripSeparator74;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator74).set_Size(size);
		((ToolStripItem)ToolStripMenuItem257).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem257.Image"));
		((ToolStripItem)ToolStripMenuItem257).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem257).set_Name("ToolStripMenuItem257");
		ToolStripMenuItem257.set_ShortcutKeys((Keys)131152);
		ToolStripMenuItem toolStripMenuItem257 = ToolStripMenuItem257;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem257).set_Size(size);
		((ToolStripItem)ToolStripMenuItem257).set_Text("&Imprimer");
		((ToolStripItem)ToolStripMenuItem258).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem258.Image"));
		((ToolStripItem)ToolStripMenuItem258).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem258).set_Name("ToolStripMenuItem258");
		ToolStripMenuItem toolStripMenuItem258 = ToolStripMenuItem258;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem258).set_Size(size);
		((ToolStripItem)ToolStripMenuItem258).set_Text("Aperçu a&vant impression");
		((ToolStripItem)ToolStripMenuItem259).set_Name("ToolStripMenuItem259");
		ToolStripMenuItem toolStripMenuItem259 = ToolStripMenuItem259;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem259).set_Size(size);
		((ToolStripItem)ToolStripMenuItem259).set_Text("Configuration de l'impression");
		((ToolStripItem)ToolStripSeparator75).set_Name("ToolStripSeparator75");
		ToolStripSeparator toolStripSeparator75 = ToolStripSeparator75;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator75).set_Size(size);
		((ToolStripItem)ToolStripMenuItem260).set_Name("ToolStripMenuItem260");
		ToolStripMenuItem toolStripMenuItem260 = ToolStripMenuItem260;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem260).set_Size(size);
		((ToolStripItem)ToolStripMenuItem260).set_Text("&Quitter");
		((ToolStripDropDownItem)ToolStripMenuItem261).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripMenuItem262,
			(ToolStripItem)ToolStripMenuItem263,
			(ToolStripItem)ToolStripSeparator76,
			(ToolStripItem)ToolStripMenuItem264,
			(ToolStripItem)ToolStripMenuItem265,
			(ToolStripItem)ToolStripMenuItem266,
			(ToolStripItem)ToolStripSeparator77,
			(ToolStripItem)ToolStripMenuItem267
		});
		((ToolStripItem)ToolStripMenuItem261).set_Name("ToolStripMenuItem261");
		ToolStripMenuItem toolStripMenuItem261 = ToolStripMenuItem261;
		size = new Size(56, 20);
		((ToolStripItem)toolStripMenuItem261).set_Size(size);
		((ToolStripItem)ToolStripMenuItem261).set_Text("&Edition");
		((ToolStripItem)ToolStripMenuItem262).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem262.Image"));
		((ToolStripItem)ToolStripMenuItem262).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem262).set_Name("ToolStripMenuItem262");
		ToolStripMenuItem262.set_ShortcutKeys((Keys)131162);
		ToolStripMenuItem toolStripMenuItem262 = ToolStripMenuItem262;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem262).set_Size(size);
		((ToolStripItem)ToolStripMenuItem262).set_Text("&Annuler");
		((ToolStripItem)ToolStripMenuItem263).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem263.Image"));
		((ToolStripItem)ToolStripMenuItem263).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem263).set_Name("ToolStripMenuItem263");
		ToolStripMenuItem263.set_ShortcutKeys((Keys)131161);
		ToolStripMenuItem toolStripMenuItem263 = ToolStripMenuItem263;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem263).set_Size(size);
		((ToolStripItem)ToolStripMenuItem263).set_Text("&Rétablir");
		((ToolStripItem)ToolStripSeparator76).set_Name("ToolStripSeparator76");
		ToolStripSeparator toolStripSeparator76 = ToolStripSeparator76;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator76).set_Size(size);
		((ToolStripItem)ToolStripMenuItem264).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem264.Image"));
		((ToolStripItem)ToolStripMenuItem264).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem264).set_Name("ToolStripMenuItem264");
		ToolStripMenuItem264.set_ShortcutKeys((Keys)131160);
		ToolStripMenuItem toolStripMenuItem264 = ToolStripMenuItem264;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem264).set_Size(size);
		((ToolStripItem)ToolStripMenuItem264).set_Text("Co&uper");
		((ToolStripItem)ToolStripMenuItem265).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem265.Image"));
		((ToolStripItem)ToolStripMenuItem265).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem265).set_Name("ToolStripMenuItem265");
		ToolStripMenuItem265.set_ShortcutKeys((Keys)131139);
		ToolStripMenuItem toolStripMenuItem265 = ToolStripMenuItem265;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem265).set_Size(size);
		((ToolStripItem)ToolStripMenuItem265).set_Text("&Copier");
		((ToolStripItem)ToolStripMenuItem266).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem266.Image"));
		((ToolStripItem)ToolStripMenuItem266).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem266).set_Name("ToolStripMenuItem266");
		ToolStripMenuItem266.set_ShortcutKeys((Keys)131158);
		ToolStripMenuItem toolStripMenuItem266 = ToolStripMenuItem266;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem266).set_Size(size);
		((ToolStripItem)ToolStripMenuItem266).set_Text("&Coller");
		((ToolStripItem)ToolStripSeparator77).set_Name("ToolStripSeparator77");
		ToolStripSeparator toolStripSeparator77 = ToolStripSeparator77;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator77).set_Size(size);
		((ToolStripItem)ToolStripMenuItem267).set_Name("ToolStripMenuItem267");
		ToolStripMenuItem267.set_ShortcutKeys((Keys)131137);
		ToolStripMenuItem toolStripMenuItem267 = ToolStripMenuItem267;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem267).set_Size(size);
		((ToolStripItem)ToolStripMenuItem267).set_Text("Sélectionner &tout");
		((ToolStripDropDownItem)ToolStripMenuItem268).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolStripMenuItem269,
			(ToolStripItem)ToolStripMenuItem270
		});
		((ToolStripItem)ToolStripMenuItem268).set_Name("ToolStripMenuItem268");
		ToolStripMenuItem toolStripMenuItem268 = ToolStripMenuItem268;
		size = new Size(70, 20);
		((ToolStripItem)toolStripMenuItem268).set_Size(size);
		((ToolStripItem)ToolStripMenuItem268).set_Text("&Affichage");
		ToolStripMenuItem269.set_Checked(true);
		ToolStripMenuItem269.set_CheckOnClick(true);
		ToolStripMenuItem269.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem269).set_Name("ToolStripMenuItem269");
		ToolStripMenuItem toolStripMenuItem269 = ToolStripMenuItem269;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem269).set_Size(size);
		((ToolStripItem)ToolStripMenuItem269).set_Text("&Barre d'outils");
		ToolStripMenuItem270.set_Checked(true);
		ToolStripMenuItem270.set_CheckOnClick(true);
		ToolStripMenuItem270.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem270).set_Name("ToolStripMenuItem270");
		ToolStripMenuItem toolStripMenuItem270 = ToolStripMenuItem270;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem270).set_Size(size);
		((ToolStripItem)ToolStripMenuItem270).set_Text("&Barre d'état");
		((ToolStripDropDownItem)ToolStripMenuItem271).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripMenuItem272 });
		((ToolStripItem)ToolStripMenuItem271).set_Name("ToolStripMenuItem271");
		ToolStripMenuItem toolStripMenuItem271 = ToolStripMenuItem271;
		size = new Size(50, 20);
		((ToolStripItem)toolStripMenuItem271).set_Size(size);
		((ToolStripItem)ToolStripMenuItem271).set_Text("&Outils");
		((ToolStripItem)ToolStripMenuItem272).set_Name("ToolStripMenuItem272");
		ToolStripMenuItem toolStripMenuItem272 = ToolStripMenuItem272;
		size = new Size(116, 22);
		((ToolStripItem)toolStripMenuItem272).set_Size(size);
		((ToolStripItem)ToolStripMenuItem272).set_Text("&Options");
		((ToolStripDropDownItem)ToolStripMenuItem273).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem274,
			(ToolStripItem)ToolStripMenuItem275,
			(ToolStripItem)ToolStripMenuItem276,
			(ToolStripItem)ToolStripMenuItem277,
			(ToolStripItem)ToolStripMenuItem278,
			(ToolStripItem)ToolStripMenuItem279
		});
		((ToolStripItem)ToolStripMenuItem273).set_Name("ToolStripMenuItem273");
		ToolStripMenuItem toolStripMenuItem273 = ToolStripMenuItem273;
		size = new Size(63, 20);
		((ToolStripItem)toolStripMenuItem273).set_Size(size);
		((ToolStripItem)ToolStripMenuItem273).set_Text("F&enêtres");
		((ToolStripItem)ToolStripMenuItem274).set_Name("ToolStripMenuItem274");
		ToolStripMenuItem toolStripMenuItem274 = ToolStripMenuItem274;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem274).set_Size(size);
		((ToolStripItem)ToolStripMenuItem274).set_Text("&Nouvelle fenêtre");
		((ToolStripItem)ToolStripMenuItem275).set_Name("ToolStripMenuItem275");
		ToolStripMenuItem toolStripMenuItem275 = ToolStripMenuItem275;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem275).set_Size(size);
		((ToolStripItem)ToolStripMenuItem275).set_Text("&Cascade");
		((ToolStripItem)ToolStripMenuItem276).set_Name("ToolStripMenuItem276");
		ToolStripMenuItem toolStripMenuItem276 = ToolStripMenuItem276;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem276).set_Size(size);
		((ToolStripItem)ToolStripMenuItem276).set_Text("Mosaïque &verticale");
		((ToolStripItem)ToolStripMenuItem277).set_Name("ToolStripMenuItem277");
		ToolStripMenuItem toolStripMenuItem277 = ToolStripMenuItem277;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem277).set_Size(size);
		((ToolStripItem)ToolStripMenuItem277).set_Text("Mosaïque &horizontale");
		((ToolStripItem)ToolStripMenuItem278).set_Name("ToolStripMenuItem278");
		ToolStripMenuItem toolStripMenuItem278 = ToolStripMenuItem278;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem278).set_Size(size);
		((ToolStripItem)ToolStripMenuItem278).set_Text("&Fermer tout");
		((ToolStripItem)ToolStripMenuItem279).set_Name("ToolStripMenuItem279");
		ToolStripMenuItem toolStripMenuItem279 = ToolStripMenuItem279;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem279).set_Size(size);
		((ToolStripItem)ToolStripMenuItem279).set_Text("&Réorganiser les icônes");
		((ToolStripDropDownItem)ToolStripMenuItem280).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ToolStripMenuItem281,
			(ToolStripItem)ToolStripMenuItem282,
			(ToolStripItem)ToolStripMenuItem283,
			(ToolStripItem)ToolStripSeparator78,
			(ToolStripItem)ToolStripMenuItem284
		});
		((ToolStripItem)ToolStripMenuItem280).set_Name("ToolStripMenuItem280");
		ToolStripMenuItem toolStripMenuItem280 = ToolStripMenuItem280;
		size = new Size(24, 20);
		((ToolStripItem)toolStripMenuItem280).set_Size(size);
		((ToolStripItem)ToolStripMenuItem280).set_Text("&?");
		((ToolStripItem)ToolStripMenuItem281).set_Name("ToolStripMenuItem281");
		ToolStripMenuItem281.set_ShortcutKeys((Keys)131184);
		ToolStripMenuItem toolStripMenuItem281 = ToolStripMenuItem281;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem281).set_Size(size);
		((ToolStripItem)ToolStripMenuItem281).set_Text("&Contenu");
		((ToolStripItem)ToolStripMenuItem282).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem282.Image"));
		((ToolStripItem)ToolStripMenuItem282).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem282).set_Name("ToolStripMenuItem282");
		ToolStripMenuItem toolStripMenuItem282 = ToolStripMenuItem282;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem282).set_Size(size);
		((ToolStripItem)ToolStripMenuItem282).set_Text("&Index");
		((ToolStripItem)ToolStripMenuItem283).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem283.Image"));
		((ToolStripItem)ToolStripMenuItem283).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem283).set_Name("ToolStripMenuItem283");
		ToolStripMenuItem toolStripMenuItem283 = ToolStripMenuItem283;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem283).set_Size(size);
		((ToolStripItem)ToolStripMenuItem283).set_Text("&Rechercher");
		((ToolStripItem)ToolStripSeparator78).set_Name("ToolStripSeparator78");
		ToolStripSeparator toolStripSeparator78 = ToolStripSeparator78;
		size = new Size(163, 6);
		((ToolStripItem)toolStripSeparator78).set_Size(size);
		((ToolStripItem)ToolStripMenuItem284).set_Name("ToolStripMenuItem284");
		ToolStripMenuItem toolStripMenuItem284 = ToolStripMenuItem284;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem284).set_Size(size);
		((ToolStripItem)ToolStripMenuItem284).set_Text("À pr&opos de...");
		((ToolStripItem)ToolStripSeparator79).set_Name("ToolStripSeparator79");
		ToolStripSeparator toolStripSeparator79 = ToolStripSeparator79;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator79).set_Size(size);
		((ToolStripItem)ToolStripButton43).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton43).set_Image((Image)componentResourceManager.GetObject("ToolStripButton43.Image"));
		((ToolStripItem)ToolStripButton43).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton43).set_Name("ToolStripButton43");
		ToolStripButton toolStripButton43 = ToolStripButton43;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton43).set_Size(size);
		((ToolStripItem)ToolStripButton43).set_Text("Aide");
		((ToolStrip)StatusStrip9).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel9 });
		StatusStrip statusStrip19 = StatusStrip9;
		location = new Point(0, 316);
		((Control)statusStrip19).set_Location(location);
		((Control)StatusStrip9).set_Name("StatusStrip9");
		StatusStrip statusStrip20 = StatusStrip9;
		size = new Size(417, 22);
		((Control)statusStrip20).set_Size(size);
		((Control)StatusStrip9).set_TabIndex(16);
		((Control)StatusStrip9).set_Text("StatusStrip");
		((ToolStripItem)ToolStripStatusLabel9).set_Name("ToolStripStatusLabel9");
		ToolStripStatusLabel toolStripStatusLabel10 = ToolStripStatusLabel9;
		size = new Size(27, 17);
		((ToolStripItem)toolStripStatusLabel10).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel9).set_Text("État");
		((ToolStripItem)ToolStripButton44).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton44).set_Image((Image)componentResourceManager.GetObject("ToolStripButton44.Image"));
		((ToolStripItem)ToolStripButton44).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton44).set_Name("ToolStripButton44");
		ToolStripButton toolStripButton44 = ToolStripButton44;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton44).set_Size(size);
		((ToolStripItem)ToolStripButton44).set_Text("Aperçu avant impression");
		((ToolStripItem)ToolStripButton45).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton45).set_Image((Image)componentResourceManager.GetObject("ToolStripButton45.Image"));
		((ToolStripItem)ToolStripButton45).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton45).set_Name("ToolStripButton45");
		ToolStripButton toolStripButton45 = ToolStripButton45;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton45).set_Size(size);
		((ToolStripItem)ToolStripButton45).set_Text("Imprimer");
		((ToolStripItem)ToolStripSeparator80).set_Name("ToolStripSeparator80");
		ToolStripSeparator toolStripSeparator80 = ToolStripSeparator80;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator80).set_Size(size);
		ToolStrip9.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripButton46,
			(ToolStripItem)ToolStripButton47,
			(ToolStripItem)ToolStripButton48,
			(ToolStripItem)ToolStripSeparator80,
			(ToolStripItem)ToolStripButton45,
			(ToolStripItem)ToolStripButton44,
			(ToolStripItem)ToolStripSeparator79,
			(ToolStripItem)ToolStripButton43
		});
		ToolStrip toolStrip19 = ToolStrip9;
		location = new Point(0, 98);
		((Control)toolStrip19).set_Location(location);
		((Control)ToolStrip9).set_Name("ToolStrip9");
		ToolStrip toolStrip20 = ToolStrip9;
		size = new Size(417, 25);
		((Control)toolStrip20).set_Size(size);
		((Control)ToolStrip9).set_TabIndex(15);
		((Control)ToolStrip9).set_Text("ToolStrip");
		((ToolStripItem)ToolStripButton46).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton46).set_Image((Image)componentResourceManager.GetObject("ToolStripButton46.Image"));
		((ToolStripItem)ToolStripButton46).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton46).set_Name("ToolStripButton46");
		ToolStripButton toolStripButton46 = ToolStripButton46;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton46).set_Size(size);
		((ToolStripItem)ToolStripButton46).set_Text("Nouveau");
		((ToolStripItem)ToolStripButton47).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton47).set_Image((Image)componentResourceManager.GetObject("ToolStripButton47.Image"));
		((ToolStripItem)ToolStripButton47).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton47).set_Name("ToolStripButton47");
		ToolStripButton toolStripButton47 = ToolStripButton47;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton47).set_Size(size);
		((ToolStripItem)ToolStripButton47).set_Text("Ouvrir");
		((ToolStripItem)ToolStripButton48).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton48).set_Image((Image)componentResourceManager.GetObject("ToolStripButton48.Image"));
		((ToolStripItem)ToolStripButton48).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton48).set_Name("ToolStripButton48");
		ToolStripButton toolStripButton48 = ToolStripButton48;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton48).set_Size(size);
		((ToolStripItem)ToolStripButton48).set_Text("Enregistrer");
		((ToolStrip)MenuStrip10).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem285,
			(ToolStripItem)ToolStripMenuItem294,
			(ToolStripItem)ToolStripMenuItem301,
			(ToolStripItem)ToolStripMenuItem304,
			(ToolStripItem)ToolStripMenuItem306,
			(ToolStripItem)ToolStripMenuItem313
		});
		MenuStrip menuStrip21 = MenuStrip10;
		location = new Point(0, 172);
		((Control)menuStrip21).set_Location(location);
		MenuStrip10.set_MdiWindowListItem(ToolStripMenuItem306);
		((Control)MenuStrip10).set_Name("MenuStrip10");
		MenuStrip menuStrip22 = MenuStrip10;
		size = new Size(417, 24);
		((Control)menuStrip22).set_Size(size);
		((Control)MenuStrip10).set_TabIndex(17);
		((Control)MenuStrip10).set_Text("MenuStrip10");
		((ToolStripDropDownItem)ToolStripMenuItem285).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)ToolStripMenuItem286,
			(ToolStripItem)ToolStripMenuItem287,
			(ToolStripItem)ToolStripSeparator81,
			(ToolStripItem)ToolStripMenuItem288,
			(ToolStripItem)ToolStripMenuItem289,
			(ToolStripItem)ToolStripSeparator82,
			(ToolStripItem)ToolStripMenuItem290,
			(ToolStripItem)ToolStripMenuItem291,
			(ToolStripItem)ToolStripMenuItem292,
			(ToolStripItem)ToolStripSeparator83,
			(ToolStripItem)ToolStripMenuItem293
		});
		((ToolStripItem)ToolStripMenuItem285).set_ImageTransparentColor(SystemColors.ActiveBorder);
		((ToolStripItem)ToolStripMenuItem285).set_Name("ToolStripMenuItem285");
		ToolStripMenuItem toolStripMenuItem285 = ToolStripMenuItem285;
		size = new Size(54, 20);
		((ToolStripItem)toolStripMenuItem285).set_Size(size);
		((ToolStripItem)ToolStripMenuItem285).set_Text("&Fichier");
		((ToolStripItem)ToolStripMenuItem286).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem286.Image"));
		((ToolStripItem)ToolStripMenuItem286).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem286).set_Name("ToolStripMenuItem286");
		ToolStripMenuItem286.set_ShortcutKeys((Keys)131150);
		ToolStripMenuItem toolStripMenuItem286 = ToolStripMenuItem286;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem286).set_Size(size);
		((ToolStripItem)ToolStripMenuItem286).set_Text("&Nouveau");
		((ToolStripItem)ToolStripMenuItem287).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem287.Image"));
		((ToolStripItem)ToolStripMenuItem287).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem287).set_Name("ToolStripMenuItem287");
		ToolStripMenuItem287.set_ShortcutKeys((Keys)131151);
		ToolStripMenuItem toolStripMenuItem287 = ToolStripMenuItem287;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem287).set_Size(size);
		((ToolStripItem)ToolStripMenuItem287).set_Text("&Ouvrir");
		((ToolStripItem)ToolStripSeparator81).set_Name("ToolStripSeparator81");
		ToolStripSeparator toolStripSeparator81 = ToolStripSeparator81;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator81).set_Size(size);
		((ToolStripItem)ToolStripMenuItem288).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem288.Image"));
		((ToolStripItem)ToolStripMenuItem288).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem288).set_Name("ToolStripMenuItem288");
		ToolStripMenuItem288.set_ShortcutKeys((Keys)131155);
		ToolStripMenuItem toolStripMenuItem288 = ToolStripMenuItem288;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem288).set_Size(size);
		((ToolStripItem)ToolStripMenuItem288).set_Text("&Enregistrer");
		((ToolStripItem)ToolStripMenuItem289).set_Name("ToolStripMenuItem289");
		ToolStripMenuItem toolStripMenuItem289 = ToolStripMenuItem289;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem289).set_Size(size);
		((ToolStripItem)ToolStripMenuItem289).set_Text("Enregistrer &sous");
		((ToolStripItem)ToolStripSeparator82).set_Name("ToolStripSeparator82");
		ToolStripSeparator toolStripSeparator82 = ToolStripSeparator82;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator82).set_Size(size);
		((ToolStripItem)ToolStripMenuItem290).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem290.Image"));
		((ToolStripItem)ToolStripMenuItem290).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem290).set_Name("ToolStripMenuItem290");
		ToolStripMenuItem290.set_ShortcutKeys((Keys)131152);
		ToolStripMenuItem toolStripMenuItem290 = ToolStripMenuItem290;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem290).set_Size(size);
		((ToolStripItem)ToolStripMenuItem290).set_Text("&Imprimer");
		((ToolStripItem)ToolStripMenuItem291).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem291.Image"));
		((ToolStripItem)ToolStripMenuItem291).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem291).set_Name("ToolStripMenuItem291");
		ToolStripMenuItem toolStripMenuItem291 = ToolStripMenuItem291;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem291).set_Size(size);
		((ToolStripItem)ToolStripMenuItem291).set_Text("Aperçu a&vant impression");
		((ToolStripItem)ToolStripMenuItem292).set_Name("ToolStripMenuItem292");
		ToolStripMenuItem toolStripMenuItem292 = ToolStripMenuItem292;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem292).set_Size(size);
		((ToolStripItem)ToolStripMenuItem292).set_Text("Configuration de l'impression");
		((ToolStripItem)ToolStripSeparator83).set_Name("ToolStripSeparator83");
		ToolStripSeparator toolStripSeparator83 = ToolStripSeparator83;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator83).set_Size(size);
		((ToolStripItem)ToolStripMenuItem293).set_Name("ToolStripMenuItem293");
		ToolStripMenuItem toolStripMenuItem293 = ToolStripMenuItem293;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem293).set_Size(size);
		((ToolStripItem)ToolStripMenuItem293).set_Text("&Quitter");
		((ToolStripDropDownItem)ToolStripMenuItem294).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripMenuItem295,
			(ToolStripItem)ToolStripMenuItem296,
			(ToolStripItem)ToolStripSeparator84,
			(ToolStripItem)ToolStripMenuItem297,
			(ToolStripItem)ToolStripMenuItem298,
			(ToolStripItem)ToolStripMenuItem299,
			(ToolStripItem)ToolStripSeparator85,
			(ToolStripItem)ToolStripMenuItem300
		});
		((ToolStripItem)ToolStripMenuItem294).set_Name("ToolStripMenuItem294");
		ToolStripMenuItem toolStripMenuItem294 = ToolStripMenuItem294;
		size = new Size(56, 20);
		((ToolStripItem)toolStripMenuItem294).set_Size(size);
		((ToolStripItem)ToolStripMenuItem294).set_Text("&Edition");
		((ToolStripItem)ToolStripMenuItem295).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem295.Image"));
		((ToolStripItem)ToolStripMenuItem295).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem295).set_Name("ToolStripMenuItem295");
		ToolStripMenuItem295.set_ShortcutKeys((Keys)131162);
		ToolStripMenuItem toolStripMenuItem295 = ToolStripMenuItem295;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem295).set_Size(size);
		((ToolStripItem)ToolStripMenuItem295).set_Text("&Annuler");
		((ToolStripItem)ToolStripMenuItem296).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem296.Image"));
		((ToolStripItem)ToolStripMenuItem296).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem296).set_Name("ToolStripMenuItem296");
		ToolStripMenuItem296.set_ShortcutKeys((Keys)131161);
		ToolStripMenuItem toolStripMenuItem296 = ToolStripMenuItem296;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem296).set_Size(size);
		((ToolStripItem)ToolStripMenuItem296).set_Text("&Rétablir");
		((ToolStripItem)ToolStripSeparator84).set_Name("ToolStripSeparator84");
		ToolStripSeparator toolStripSeparator84 = ToolStripSeparator84;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator84).set_Size(size);
		((ToolStripItem)ToolStripMenuItem297).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem297.Image"));
		((ToolStripItem)ToolStripMenuItem297).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem297).set_Name("ToolStripMenuItem297");
		ToolStripMenuItem297.set_ShortcutKeys((Keys)131160);
		ToolStripMenuItem toolStripMenuItem297 = ToolStripMenuItem297;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem297).set_Size(size);
		((ToolStripItem)ToolStripMenuItem297).set_Text("Co&uper");
		((ToolStripItem)ToolStripMenuItem298).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem298.Image"));
		((ToolStripItem)ToolStripMenuItem298).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem298).set_Name("ToolStripMenuItem298");
		ToolStripMenuItem298.set_ShortcutKeys((Keys)131139);
		ToolStripMenuItem toolStripMenuItem298 = ToolStripMenuItem298;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem298).set_Size(size);
		((ToolStripItem)ToolStripMenuItem298).set_Text("&Copier");
		((ToolStripItem)ToolStripMenuItem299).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem299.Image"));
		((ToolStripItem)ToolStripMenuItem299).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem299).set_Name("ToolStripMenuItem299");
		ToolStripMenuItem299.set_ShortcutKeys((Keys)131158);
		ToolStripMenuItem toolStripMenuItem299 = ToolStripMenuItem299;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem299).set_Size(size);
		((ToolStripItem)ToolStripMenuItem299).set_Text("&Coller");
		((ToolStripItem)ToolStripSeparator85).set_Name("ToolStripSeparator85");
		ToolStripSeparator toolStripSeparator85 = ToolStripSeparator85;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator85).set_Size(size);
		((ToolStripItem)ToolStripMenuItem300).set_Name("ToolStripMenuItem300");
		ToolStripMenuItem300.set_ShortcutKeys((Keys)131137);
		ToolStripMenuItem toolStripMenuItem300 = ToolStripMenuItem300;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem300).set_Size(size);
		((ToolStripItem)ToolStripMenuItem300).set_Text("Sélectionner &tout");
		((ToolStripDropDownItem)ToolStripMenuItem301).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolStripMenuItem302,
			(ToolStripItem)ToolStripMenuItem303
		});
		((ToolStripItem)ToolStripMenuItem301).set_Name("ToolStripMenuItem301");
		ToolStripMenuItem toolStripMenuItem301 = ToolStripMenuItem301;
		size = new Size(70, 20);
		((ToolStripItem)toolStripMenuItem301).set_Size(size);
		((ToolStripItem)ToolStripMenuItem301).set_Text("&Affichage");
		ToolStripMenuItem302.set_Checked(true);
		ToolStripMenuItem302.set_CheckOnClick(true);
		ToolStripMenuItem302.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem302).set_Name("ToolStripMenuItem302");
		ToolStripMenuItem toolStripMenuItem302 = ToolStripMenuItem302;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem302).set_Size(size);
		((ToolStripItem)ToolStripMenuItem302).set_Text("&Barre d'outils");
		ToolStripMenuItem303.set_Checked(true);
		ToolStripMenuItem303.set_CheckOnClick(true);
		ToolStripMenuItem303.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem303).set_Name("ToolStripMenuItem303");
		ToolStripMenuItem toolStripMenuItem303 = ToolStripMenuItem303;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem303).set_Size(size);
		((ToolStripItem)ToolStripMenuItem303).set_Text("&Barre d'état");
		((ToolStripDropDownItem)ToolStripMenuItem304).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripMenuItem305 });
		((ToolStripItem)ToolStripMenuItem304).set_Name("ToolStripMenuItem304");
		ToolStripMenuItem toolStripMenuItem304 = ToolStripMenuItem304;
		size = new Size(50, 20);
		((ToolStripItem)toolStripMenuItem304).set_Size(size);
		((ToolStripItem)ToolStripMenuItem304).set_Text("&Outils");
		((ToolStripItem)ToolStripMenuItem305).set_Name("ToolStripMenuItem305");
		ToolStripMenuItem toolStripMenuItem305 = ToolStripMenuItem305;
		size = new Size(116, 22);
		((ToolStripItem)toolStripMenuItem305).set_Size(size);
		((ToolStripItem)ToolStripMenuItem305).set_Text("&Options");
		((ToolStripDropDownItem)ToolStripMenuItem306).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem307,
			(ToolStripItem)ToolStripMenuItem308,
			(ToolStripItem)ToolStripMenuItem309,
			(ToolStripItem)ToolStripMenuItem310,
			(ToolStripItem)ToolStripMenuItem311,
			(ToolStripItem)ToolStripMenuItem312
		});
		((ToolStripItem)ToolStripMenuItem306).set_Name("ToolStripMenuItem306");
		ToolStripMenuItem toolStripMenuItem306 = ToolStripMenuItem306;
		size = new Size(63, 20);
		((ToolStripItem)toolStripMenuItem306).set_Size(size);
		((ToolStripItem)ToolStripMenuItem306).set_Text("F&enêtres");
		((ToolStripItem)ToolStripMenuItem307).set_Name("ToolStripMenuItem307");
		ToolStripMenuItem toolStripMenuItem307 = ToolStripMenuItem307;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem307).set_Size(size);
		((ToolStripItem)ToolStripMenuItem307).set_Text("&Nouvelle fenêtre");
		((ToolStripItem)ToolStripMenuItem308).set_Name("ToolStripMenuItem308");
		ToolStripMenuItem toolStripMenuItem308 = ToolStripMenuItem308;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem308).set_Size(size);
		((ToolStripItem)ToolStripMenuItem308).set_Text("&Cascade");
		((ToolStripItem)ToolStripMenuItem309).set_Name("ToolStripMenuItem309");
		ToolStripMenuItem toolStripMenuItem309 = ToolStripMenuItem309;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem309).set_Size(size);
		((ToolStripItem)ToolStripMenuItem309).set_Text("Mosaïque &verticale");
		((ToolStripItem)ToolStripMenuItem310).set_Name("ToolStripMenuItem310");
		ToolStripMenuItem toolStripMenuItem310 = ToolStripMenuItem310;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem310).set_Size(size);
		((ToolStripItem)ToolStripMenuItem310).set_Text("Mosaïque &horizontale");
		((ToolStripItem)ToolStripMenuItem311).set_Name("ToolStripMenuItem311");
		ToolStripMenuItem toolStripMenuItem311 = ToolStripMenuItem311;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem311).set_Size(size);
		((ToolStripItem)ToolStripMenuItem311).set_Text("&Fermer tout");
		((ToolStripItem)ToolStripMenuItem312).set_Name("ToolStripMenuItem312");
		ToolStripMenuItem toolStripMenuItem312 = ToolStripMenuItem312;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem312).set_Size(size);
		((ToolStripItem)ToolStripMenuItem312).set_Text("&Réorganiser les icônes");
		((ToolStripDropDownItem)ToolStripMenuItem313).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ToolStripMenuItem314,
			(ToolStripItem)ToolStripMenuItem315,
			(ToolStripItem)ToolStripMenuItem316,
			(ToolStripItem)ToolStripSeparator86,
			(ToolStripItem)ToolStripMenuItem317
		});
		((ToolStripItem)ToolStripMenuItem313).set_Name("ToolStripMenuItem313");
		ToolStripMenuItem toolStripMenuItem313 = ToolStripMenuItem313;
		size = new Size(24, 20);
		((ToolStripItem)toolStripMenuItem313).set_Size(size);
		((ToolStripItem)ToolStripMenuItem313).set_Text("&?");
		((ToolStripItem)ToolStripMenuItem314).set_Name("ToolStripMenuItem314");
		ToolStripMenuItem314.set_ShortcutKeys((Keys)131184);
		ToolStripMenuItem toolStripMenuItem314 = ToolStripMenuItem314;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem314).set_Size(size);
		((ToolStripItem)ToolStripMenuItem314).set_Text("&Contenu");
		((ToolStripItem)ToolStripMenuItem315).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem315.Image"));
		((ToolStripItem)ToolStripMenuItem315).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem315).set_Name("ToolStripMenuItem315");
		ToolStripMenuItem toolStripMenuItem315 = ToolStripMenuItem315;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem315).set_Size(size);
		((ToolStripItem)ToolStripMenuItem315).set_Text("&Index");
		((ToolStripItem)ToolStripMenuItem316).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem316.Image"));
		((ToolStripItem)ToolStripMenuItem316).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem316).set_Name("ToolStripMenuItem316");
		ToolStripMenuItem toolStripMenuItem316 = ToolStripMenuItem316;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem316).set_Size(size);
		((ToolStripItem)ToolStripMenuItem316).set_Text("&Rechercher");
		((ToolStripItem)ToolStripSeparator86).set_Name("ToolStripSeparator86");
		ToolStripSeparator toolStripSeparator86 = ToolStripSeparator86;
		size = new Size(163, 6);
		((ToolStripItem)toolStripSeparator86).set_Size(size);
		((ToolStripItem)ToolStripMenuItem317).set_Name("ToolStripMenuItem317");
		ToolStripMenuItem toolStripMenuItem317 = ToolStripMenuItem317;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem317).set_Size(size);
		((ToolStripItem)ToolStripMenuItem317).set_Text("À pr&opos de...");
		((ToolStripItem)ToolStripSeparator87).set_Name("ToolStripSeparator87");
		ToolStripSeparator toolStripSeparator87 = ToolStripSeparator87;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator87).set_Size(size);
		((ToolStripItem)ToolStripButton49).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton49).set_Image((Image)componentResourceManager.GetObject("ToolStripButton49.Image"));
		((ToolStripItem)ToolStripButton49).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton49).set_Name("ToolStripButton49");
		ToolStripButton toolStripButton49 = ToolStripButton49;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton49).set_Size(size);
		((ToolStripItem)ToolStripButton49).set_Text("Aide");
		((ToolStrip)StatusStrip10).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel10 });
		StatusStrip statusStrip21 = StatusStrip10;
		location = new Point(0, 294);
		((Control)statusStrip21).set_Location(location);
		((Control)StatusStrip10).set_Name("StatusStrip10");
		StatusStrip statusStrip22 = StatusStrip10;
		size = new Size(417, 22);
		((Control)statusStrip22).set_Size(size);
		((Control)StatusStrip10).set_TabIndex(19);
		((Control)StatusStrip10).set_Text("StatusStrip");
		((ToolStripItem)ToolStripStatusLabel10).set_Name("ToolStripStatusLabel10");
		ToolStripStatusLabel toolStripStatusLabel11 = ToolStripStatusLabel10;
		size = new Size(27, 17);
		((ToolStripItem)toolStripStatusLabel11).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel10).set_Text("État");
		((ToolStripItem)ToolStripButton50).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton50).set_Image((Image)componentResourceManager.GetObject("ToolStripButton50.Image"));
		((ToolStripItem)ToolStripButton50).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton50).set_Name("ToolStripButton50");
		ToolStripButton toolStripButton50 = ToolStripButton50;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton50).set_Size(size);
		((ToolStripItem)ToolStripButton50).set_Text("Aperçu avant impression");
		((ToolStripItem)ToolStripButton51).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton51).set_Image((Image)componentResourceManager.GetObject("ToolStripButton51.Image"));
		((ToolStripItem)ToolStripButton51).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton51).set_Name("ToolStripButton51");
		ToolStripButton toolStripButton51 = ToolStripButton51;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton51).set_Size(size);
		((ToolStripItem)ToolStripButton51).set_Text("Imprimer");
		((ToolStripItem)ToolStripSeparator88).set_Name("ToolStripSeparator88");
		ToolStripSeparator toolStripSeparator88 = ToolStripSeparator88;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator88).set_Size(size);
		ToolStrip10.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripButton52,
			(ToolStripItem)ToolStripButton53,
			(ToolStripItem)ToolStripButton54,
			(ToolStripItem)ToolStripSeparator88,
			(ToolStripItem)ToolStripButton51,
			(ToolStripItem)ToolStripButton50,
			(ToolStripItem)ToolStripSeparator87,
			(ToolStripItem)ToolStripButton49
		});
		ToolStrip toolStrip21 = ToolStrip10;
		location = new Point(0, 147);
		((Control)toolStrip21).set_Location(location);
		((Control)ToolStrip10).set_Name("ToolStrip10");
		ToolStrip toolStrip22 = ToolStrip10;
		size = new Size(417, 25);
		((Control)toolStrip22).set_Size(size);
		((Control)ToolStrip10).set_TabIndex(18);
		((Control)ToolStrip10).set_Text("ToolStrip");
		((ToolStripItem)ToolStripButton52).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton52).set_Image((Image)componentResourceManager.GetObject("ToolStripButton52.Image"));
		((ToolStripItem)ToolStripButton52).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton52).set_Name("ToolStripButton52");
		ToolStripButton toolStripButton52 = ToolStripButton52;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton52).set_Size(size);
		((ToolStripItem)ToolStripButton52).set_Text("Nouveau");
		((ToolStripItem)ToolStripButton53).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton53).set_Image((Image)componentResourceManager.GetObject("ToolStripButton53.Image"));
		((ToolStripItem)ToolStripButton53).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton53).set_Name("ToolStripButton53");
		ToolStripButton toolStripButton53 = ToolStripButton53;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton53).set_Size(size);
		((ToolStripItem)ToolStripButton53).set_Text("Ouvrir");
		((ToolStripItem)ToolStripButton54).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton54).set_Image((Image)componentResourceManager.GetObject("ToolStripButton54.Image"));
		((ToolStripItem)ToolStripButton54).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton54).set_Name("ToolStripButton54");
		ToolStripButton toolStripButton54 = ToolStripButton54;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton54).set_Size(size);
		((ToolStripItem)ToolStripButton54).set_Text("Enregistrer");
		((ToolStrip)MenuStrip11).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem318,
			(ToolStripItem)ToolStripMenuItem327,
			(ToolStripItem)ToolStripMenuItem334,
			(ToolStripItem)ToolStripMenuItem337,
			(ToolStripItem)ToolStripMenuItem339,
			(ToolStripItem)ToolStripMenuItem346
		});
		MenuStrip menuStrip23 = MenuStrip11;
		location = new Point(0, 221);
		((Control)menuStrip23).set_Location(location);
		MenuStrip11.set_MdiWindowListItem(ToolStripMenuItem339);
		((Control)MenuStrip11).set_Name("MenuStrip11");
		MenuStrip menuStrip24 = MenuStrip11;
		size = new Size(417, 24);
		((Control)menuStrip24).set_Size(size);
		((Control)MenuStrip11).set_TabIndex(20);
		((Control)MenuStrip11).set_Text("MenuStrip11");
		((ToolStripDropDownItem)ToolStripMenuItem318).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)ToolStripMenuItem319,
			(ToolStripItem)ToolStripMenuItem320,
			(ToolStripItem)ToolStripSeparator89,
			(ToolStripItem)ToolStripMenuItem321,
			(ToolStripItem)ToolStripMenuItem322,
			(ToolStripItem)ToolStripSeparator90,
			(ToolStripItem)ToolStripMenuItem323,
			(ToolStripItem)ToolStripMenuItem324,
			(ToolStripItem)ToolStripMenuItem325,
			(ToolStripItem)ToolStripSeparator91,
			(ToolStripItem)ToolStripMenuItem326
		});
		((ToolStripItem)ToolStripMenuItem318).set_ImageTransparentColor(SystemColors.ActiveBorder);
		((ToolStripItem)ToolStripMenuItem318).set_Name("ToolStripMenuItem318");
		ToolStripMenuItem toolStripMenuItem318 = ToolStripMenuItem318;
		size = new Size(54, 20);
		((ToolStripItem)toolStripMenuItem318).set_Size(size);
		((ToolStripItem)ToolStripMenuItem318).set_Text("&Fichier");
		((ToolStripItem)ToolStripMenuItem319).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem319.Image"));
		((ToolStripItem)ToolStripMenuItem319).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem319).set_Name("ToolStripMenuItem319");
		ToolStripMenuItem319.set_ShortcutKeys((Keys)131150);
		ToolStripMenuItem toolStripMenuItem319 = ToolStripMenuItem319;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem319).set_Size(size);
		((ToolStripItem)ToolStripMenuItem319).set_Text("&Nouveau");
		((ToolStripItem)ToolStripMenuItem320).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem320.Image"));
		((ToolStripItem)ToolStripMenuItem320).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem320).set_Name("ToolStripMenuItem320");
		ToolStripMenuItem320.set_ShortcutKeys((Keys)131151);
		ToolStripMenuItem toolStripMenuItem320 = ToolStripMenuItem320;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem320).set_Size(size);
		((ToolStripItem)ToolStripMenuItem320).set_Text("&Ouvrir");
		((ToolStripItem)ToolStripSeparator89).set_Name("ToolStripSeparator89");
		ToolStripSeparator toolStripSeparator89 = ToolStripSeparator89;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator89).set_Size(size);
		((ToolStripItem)ToolStripMenuItem321).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem321.Image"));
		((ToolStripItem)ToolStripMenuItem321).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem321).set_Name("ToolStripMenuItem321");
		ToolStripMenuItem321.set_ShortcutKeys((Keys)131155);
		ToolStripMenuItem toolStripMenuItem321 = ToolStripMenuItem321;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem321).set_Size(size);
		((ToolStripItem)ToolStripMenuItem321).set_Text("&Enregistrer");
		((ToolStripItem)ToolStripMenuItem322).set_Name("ToolStripMenuItem322");
		ToolStripMenuItem toolStripMenuItem322 = ToolStripMenuItem322;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem322).set_Size(size);
		((ToolStripItem)ToolStripMenuItem322).set_Text("Enregistrer &sous");
		((ToolStripItem)ToolStripSeparator90).set_Name("ToolStripSeparator90");
		ToolStripSeparator toolStripSeparator90 = ToolStripSeparator90;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator90).set_Size(size);
		((ToolStripItem)ToolStripMenuItem323).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem323.Image"));
		((ToolStripItem)ToolStripMenuItem323).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem323).set_Name("ToolStripMenuItem323");
		ToolStripMenuItem323.set_ShortcutKeys((Keys)131152);
		ToolStripMenuItem toolStripMenuItem323 = ToolStripMenuItem323;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem323).set_Size(size);
		((ToolStripItem)ToolStripMenuItem323).set_Text("&Imprimer");
		((ToolStripItem)ToolStripMenuItem324).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem324.Image"));
		((ToolStripItem)ToolStripMenuItem324).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem324).set_Name("ToolStripMenuItem324");
		ToolStripMenuItem toolStripMenuItem324 = ToolStripMenuItem324;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem324).set_Size(size);
		((ToolStripItem)ToolStripMenuItem324).set_Text("Aperçu a&vant impression");
		((ToolStripItem)ToolStripMenuItem325).set_Name("ToolStripMenuItem325");
		ToolStripMenuItem toolStripMenuItem325 = ToolStripMenuItem325;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem325).set_Size(size);
		((ToolStripItem)ToolStripMenuItem325).set_Text("Configuration de l'impression");
		((ToolStripItem)ToolStripSeparator91).set_Name("ToolStripSeparator91");
		ToolStripSeparator toolStripSeparator91 = ToolStripSeparator91;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator91).set_Size(size);
		((ToolStripItem)ToolStripMenuItem326).set_Name("ToolStripMenuItem326");
		ToolStripMenuItem toolStripMenuItem326 = ToolStripMenuItem326;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem326).set_Size(size);
		((ToolStripItem)ToolStripMenuItem326).set_Text("&Quitter");
		((ToolStripDropDownItem)ToolStripMenuItem327).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripMenuItem328,
			(ToolStripItem)ToolStripMenuItem329,
			(ToolStripItem)ToolStripSeparator92,
			(ToolStripItem)ToolStripMenuItem330,
			(ToolStripItem)ToolStripMenuItem331,
			(ToolStripItem)ToolStripMenuItem332,
			(ToolStripItem)ToolStripSeparator93,
			(ToolStripItem)ToolStripMenuItem333
		});
		((ToolStripItem)ToolStripMenuItem327).set_Name("ToolStripMenuItem327");
		ToolStripMenuItem toolStripMenuItem327 = ToolStripMenuItem327;
		size = new Size(56, 20);
		((ToolStripItem)toolStripMenuItem327).set_Size(size);
		((ToolStripItem)ToolStripMenuItem327).set_Text("&Edition");
		((ToolStripItem)ToolStripMenuItem328).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem328.Image"));
		((ToolStripItem)ToolStripMenuItem328).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem328).set_Name("ToolStripMenuItem328");
		ToolStripMenuItem328.set_ShortcutKeys((Keys)131162);
		ToolStripMenuItem toolStripMenuItem328 = ToolStripMenuItem328;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem328).set_Size(size);
		((ToolStripItem)ToolStripMenuItem328).set_Text("&Annuler");
		((ToolStripItem)ToolStripMenuItem329).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem329.Image"));
		((ToolStripItem)ToolStripMenuItem329).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem329).set_Name("ToolStripMenuItem329");
		ToolStripMenuItem329.set_ShortcutKeys((Keys)131161);
		ToolStripMenuItem toolStripMenuItem329 = ToolStripMenuItem329;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem329).set_Size(size);
		((ToolStripItem)ToolStripMenuItem329).set_Text("&Rétablir");
		((ToolStripItem)ToolStripSeparator92).set_Name("ToolStripSeparator92");
		ToolStripSeparator toolStripSeparator92 = ToolStripSeparator92;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator92).set_Size(size);
		((ToolStripItem)ToolStripMenuItem330).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem330.Image"));
		((ToolStripItem)ToolStripMenuItem330).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem330).set_Name("ToolStripMenuItem330");
		ToolStripMenuItem330.set_ShortcutKeys((Keys)131160);
		ToolStripMenuItem toolStripMenuItem330 = ToolStripMenuItem330;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem330).set_Size(size);
		((ToolStripItem)ToolStripMenuItem330).set_Text("Co&uper");
		((ToolStripItem)ToolStripMenuItem331).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem331.Image"));
		((ToolStripItem)ToolStripMenuItem331).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem331).set_Name("ToolStripMenuItem331");
		ToolStripMenuItem331.set_ShortcutKeys((Keys)131139);
		ToolStripMenuItem toolStripMenuItem331 = ToolStripMenuItem331;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem331).set_Size(size);
		((ToolStripItem)ToolStripMenuItem331).set_Text("&Copier");
		((ToolStripItem)ToolStripMenuItem332).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem332.Image"));
		((ToolStripItem)ToolStripMenuItem332).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem332).set_Name("ToolStripMenuItem332");
		ToolStripMenuItem332.set_ShortcutKeys((Keys)131158);
		ToolStripMenuItem toolStripMenuItem332 = ToolStripMenuItem332;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem332).set_Size(size);
		((ToolStripItem)ToolStripMenuItem332).set_Text("&Coller");
		((ToolStripItem)ToolStripSeparator93).set_Name("ToolStripSeparator93");
		ToolStripSeparator toolStripSeparator93 = ToolStripSeparator93;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator93).set_Size(size);
		((ToolStripItem)ToolStripMenuItem333).set_Name("ToolStripMenuItem333");
		ToolStripMenuItem333.set_ShortcutKeys((Keys)131137);
		ToolStripMenuItem toolStripMenuItem333 = ToolStripMenuItem333;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem333).set_Size(size);
		((ToolStripItem)ToolStripMenuItem333).set_Text("Sélectionner &tout");
		((ToolStripDropDownItem)ToolStripMenuItem334).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolStripMenuItem335,
			(ToolStripItem)ToolStripMenuItem336
		});
		((ToolStripItem)ToolStripMenuItem334).set_Name("ToolStripMenuItem334");
		ToolStripMenuItem toolStripMenuItem334 = ToolStripMenuItem334;
		size = new Size(70, 20);
		((ToolStripItem)toolStripMenuItem334).set_Size(size);
		((ToolStripItem)ToolStripMenuItem334).set_Text("&Affichage");
		ToolStripMenuItem335.set_Checked(true);
		ToolStripMenuItem335.set_CheckOnClick(true);
		ToolStripMenuItem335.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem335).set_Name("ToolStripMenuItem335");
		ToolStripMenuItem toolStripMenuItem335 = ToolStripMenuItem335;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem335).set_Size(size);
		((ToolStripItem)ToolStripMenuItem335).set_Text("&Barre d'outils");
		ToolStripMenuItem336.set_Checked(true);
		ToolStripMenuItem336.set_CheckOnClick(true);
		ToolStripMenuItem336.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem336).set_Name("ToolStripMenuItem336");
		ToolStripMenuItem toolStripMenuItem336 = ToolStripMenuItem336;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem336).set_Size(size);
		((ToolStripItem)ToolStripMenuItem336).set_Text("&Barre d'état");
		((ToolStripDropDownItem)ToolStripMenuItem337).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripMenuItem338 });
		((ToolStripItem)ToolStripMenuItem337).set_Name("ToolStripMenuItem337");
		ToolStripMenuItem toolStripMenuItem337 = ToolStripMenuItem337;
		size = new Size(50, 20);
		((ToolStripItem)toolStripMenuItem337).set_Size(size);
		((ToolStripItem)ToolStripMenuItem337).set_Text("&Outils");
		((ToolStripItem)ToolStripMenuItem338).set_Name("ToolStripMenuItem338");
		ToolStripMenuItem toolStripMenuItem338 = ToolStripMenuItem338;
		size = new Size(116, 22);
		((ToolStripItem)toolStripMenuItem338).set_Size(size);
		((ToolStripItem)ToolStripMenuItem338).set_Text("&Options");
		((ToolStripDropDownItem)ToolStripMenuItem339).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem340,
			(ToolStripItem)ToolStripMenuItem341,
			(ToolStripItem)ToolStripMenuItem342,
			(ToolStripItem)ToolStripMenuItem343,
			(ToolStripItem)ToolStripMenuItem344,
			(ToolStripItem)ToolStripMenuItem345
		});
		((ToolStripItem)ToolStripMenuItem339).set_Name("ToolStripMenuItem339");
		ToolStripMenuItem toolStripMenuItem339 = ToolStripMenuItem339;
		size = new Size(63, 20);
		((ToolStripItem)toolStripMenuItem339).set_Size(size);
		((ToolStripItem)ToolStripMenuItem339).set_Text("F&enêtres");
		((ToolStripItem)ToolStripMenuItem340).set_Name("ToolStripMenuItem340");
		ToolStripMenuItem toolStripMenuItem340 = ToolStripMenuItem340;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem340).set_Size(size);
		((ToolStripItem)ToolStripMenuItem340).set_Text("&Nouvelle fenêtre");
		((ToolStripItem)ToolStripMenuItem341).set_Name("ToolStripMenuItem341");
		ToolStripMenuItem toolStripMenuItem341 = ToolStripMenuItem341;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem341).set_Size(size);
		((ToolStripItem)ToolStripMenuItem341).set_Text("&Cascade");
		((ToolStripItem)ToolStripMenuItem342).set_Name("ToolStripMenuItem342");
		ToolStripMenuItem toolStripMenuItem342 = ToolStripMenuItem342;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem342).set_Size(size);
		((ToolStripItem)ToolStripMenuItem342).set_Text("Mosaïque &verticale");
		((ToolStripItem)ToolStripMenuItem343).set_Name("ToolStripMenuItem343");
		ToolStripMenuItem toolStripMenuItem343 = ToolStripMenuItem343;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem343).set_Size(size);
		((ToolStripItem)ToolStripMenuItem343).set_Text("Mosaïque &horizontale");
		((ToolStripItem)ToolStripMenuItem344).set_Name("ToolStripMenuItem344");
		ToolStripMenuItem toolStripMenuItem344 = ToolStripMenuItem344;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem344).set_Size(size);
		((ToolStripItem)ToolStripMenuItem344).set_Text("&Fermer tout");
		((ToolStripItem)ToolStripMenuItem345).set_Name("ToolStripMenuItem345");
		ToolStripMenuItem toolStripMenuItem345 = ToolStripMenuItem345;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem345).set_Size(size);
		((ToolStripItem)ToolStripMenuItem345).set_Text("&Réorganiser les icônes");
		((ToolStripDropDownItem)ToolStripMenuItem346).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ToolStripMenuItem347,
			(ToolStripItem)ToolStripMenuItem348,
			(ToolStripItem)ToolStripMenuItem349,
			(ToolStripItem)ToolStripSeparator94,
			(ToolStripItem)ToolStripMenuItem350
		});
		((ToolStripItem)ToolStripMenuItem346).set_Name("ToolStripMenuItem346");
		ToolStripMenuItem toolStripMenuItem346 = ToolStripMenuItem346;
		size = new Size(24, 20);
		((ToolStripItem)toolStripMenuItem346).set_Size(size);
		((ToolStripItem)ToolStripMenuItem346).set_Text("&?");
		((ToolStripItem)ToolStripMenuItem347).set_Name("ToolStripMenuItem347");
		ToolStripMenuItem347.set_ShortcutKeys((Keys)131184);
		ToolStripMenuItem toolStripMenuItem347 = ToolStripMenuItem347;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem347).set_Size(size);
		((ToolStripItem)ToolStripMenuItem347).set_Text("&Contenu");
		((ToolStripItem)ToolStripMenuItem348).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem348.Image"));
		((ToolStripItem)ToolStripMenuItem348).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem348).set_Name("ToolStripMenuItem348");
		ToolStripMenuItem toolStripMenuItem348 = ToolStripMenuItem348;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem348).set_Size(size);
		((ToolStripItem)ToolStripMenuItem348).set_Text("&Index");
		((ToolStripItem)ToolStripMenuItem349).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem349.Image"));
		((ToolStripItem)ToolStripMenuItem349).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem349).set_Name("ToolStripMenuItem349");
		ToolStripMenuItem toolStripMenuItem349 = ToolStripMenuItem349;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem349).set_Size(size);
		((ToolStripItem)ToolStripMenuItem349).set_Text("&Rechercher");
		((ToolStripItem)ToolStripSeparator94).set_Name("ToolStripSeparator94");
		ToolStripSeparator toolStripSeparator94 = ToolStripSeparator94;
		size = new Size(163, 6);
		((ToolStripItem)toolStripSeparator94).set_Size(size);
		((ToolStripItem)ToolStripMenuItem350).set_Name("ToolStripMenuItem350");
		ToolStripMenuItem toolStripMenuItem350 = ToolStripMenuItem350;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem350).set_Size(size);
		((ToolStripItem)ToolStripMenuItem350).set_Text("À pr&opos de...");
		((ToolStripItem)ToolStripSeparator95).set_Name("ToolStripSeparator95");
		ToolStripSeparator toolStripSeparator95 = ToolStripSeparator95;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator95).set_Size(size);
		((ToolStripItem)ToolStripButton55).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton55).set_Image((Image)componentResourceManager.GetObject("ToolStripButton55.Image"));
		((ToolStripItem)ToolStripButton55).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton55).set_Name("ToolStripButton55");
		ToolStripButton toolStripButton55 = ToolStripButton55;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton55).set_Size(size);
		((ToolStripItem)ToolStripButton55).set_Text("Aide");
		((ToolStrip)StatusStrip11).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel11 });
		StatusStrip statusStrip23 = StatusStrip11;
		location = new Point(0, 272);
		((Control)statusStrip23).set_Location(location);
		((Control)StatusStrip11).set_Name("StatusStrip11");
		StatusStrip statusStrip24 = StatusStrip11;
		size = new Size(417, 22);
		((Control)statusStrip24).set_Size(size);
		((Control)StatusStrip11).set_TabIndex(22);
		((Control)StatusStrip11).set_Text("StatusStrip");
		((ToolStripItem)ToolStripStatusLabel11).set_Name("ToolStripStatusLabel11");
		ToolStripStatusLabel toolStripStatusLabel12 = ToolStripStatusLabel11;
		size = new Size(27, 17);
		((ToolStripItem)toolStripStatusLabel12).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel11).set_Text("État");
		((ToolStripItem)ToolStripButton56).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton56).set_Image((Image)componentResourceManager.GetObject("ToolStripButton56.Image"));
		((ToolStripItem)ToolStripButton56).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton56).set_Name("ToolStripButton56");
		ToolStripButton toolStripButton56 = ToolStripButton56;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton56).set_Size(size);
		((ToolStripItem)ToolStripButton56).set_Text("Aperçu avant impression");
		((ToolStripItem)ToolStripButton57).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton57).set_Image((Image)componentResourceManager.GetObject("ToolStripButton57.Image"));
		((ToolStripItem)ToolStripButton57).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton57).set_Name("ToolStripButton57");
		ToolStripButton toolStripButton57 = ToolStripButton57;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton57).set_Size(size);
		((ToolStripItem)ToolStripButton57).set_Text("Imprimer");
		((ToolStripItem)ToolStripSeparator96).set_Name("ToolStripSeparator96");
		ToolStripSeparator toolStripSeparator96 = ToolStripSeparator96;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator96).set_Size(size);
		ToolStrip11.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripButton58,
			(ToolStripItem)ToolStripButton59,
			(ToolStripItem)ToolStripButton60,
			(ToolStripItem)ToolStripSeparator96,
			(ToolStripItem)ToolStripButton57,
			(ToolStripItem)ToolStripButton56,
			(ToolStripItem)ToolStripSeparator95,
			(ToolStripItem)ToolStripButton55
		});
		ToolStrip toolStrip23 = ToolStrip11;
		location = new Point(0, 196);
		((Control)toolStrip23).set_Location(location);
		((Control)ToolStrip11).set_Name("ToolStrip11");
		ToolStrip toolStrip24 = ToolStrip11;
		size = new Size(417, 25);
		((Control)toolStrip24).set_Size(size);
		((Control)ToolStrip11).set_TabIndex(21);
		((Control)ToolStrip11).set_Text("ToolStrip");
		((ToolStripItem)ToolStripButton58).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton58).set_Image((Image)componentResourceManager.GetObject("ToolStripButton58.Image"));
		((ToolStripItem)ToolStripButton58).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton58).set_Name("ToolStripButton58");
		ToolStripButton toolStripButton58 = ToolStripButton58;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton58).set_Size(size);
		((ToolStripItem)ToolStripButton58).set_Text("Nouveau");
		((ToolStripItem)ToolStripButton59).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton59).set_Image((Image)componentResourceManager.GetObject("ToolStripButton59.Image"));
		((ToolStripItem)ToolStripButton59).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton59).set_Name("ToolStripButton59");
		ToolStripButton toolStripButton59 = ToolStripButton59;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton59).set_Size(size);
		((ToolStripItem)ToolStripButton59).set_Text("Ouvrir");
		((ToolStripItem)ToolStripButton60).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton60).set_Image((Image)componentResourceManager.GetObject("ToolStripButton60.Image"));
		((ToolStripItem)ToolStripButton60).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton60).set_Name("ToolStripButton60");
		ToolStripButton toolStripButton60 = ToolStripButton60;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton60).set_Size(size);
		((ToolStripItem)ToolStripButton60).set_Text("Enregistrer");
		((ToolStrip)MenuStrip12).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem351,
			(ToolStripItem)ToolStripMenuItem360,
			(ToolStripItem)ToolStripMenuItem367,
			(ToolStripItem)ToolStripMenuItem370,
			(ToolStripItem)ToolStripMenuItem372,
			(ToolStripItem)ToolStripMenuItem379
		});
		MenuStrip menuStrip25 = MenuStrip12;
		location = new Point(0, 270);
		((Control)menuStrip25).set_Location(location);
		MenuStrip12.set_MdiWindowListItem(ToolStripMenuItem372);
		((Control)MenuStrip12).set_Name("MenuStrip12");
		MenuStrip menuStrip26 = MenuStrip12;
		size = new Size(417, 24);
		((Control)menuStrip26).set_Size(size);
		((Control)MenuStrip12).set_TabIndex(23);
		((Control)MenuStrip12).set_Text("MenuStrip12");
		((ToolStripDropDownItem)ToolStripMenuItem351).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)ToolStripMenuItem352,
			(ToolStripItem)ToolStripMenuItem353,
			(ToolStripItem)ToolStripSeparator97,
			(ToolStripItem)ToolStripMenuItem354,
			(ToolStripItem)ToolStripMenuItem355,
			(ToolStripItem)ToolStripSeparator98,
			(ToolStripItem)ToolStripMenuItem356,
			(ToolStripItem)ToolStripMenuItem357,
			(ToolStripItem)ToolStripMenuItem358,
			(ToolStripItem)ToolStripSeparator99,
			(ToolStripItem)ToolStripMenuItem359
		});
		((ToolStripItem)ToolStripMenuItem351).set_ImageTransparentColor(SystemColors.ActiveBorder);
		((ToolStripItem)ToolStripMenuItem351).set_Name("ToolStripMenuItem351");
		ToolStripMenuItem toolStripMenuItem351 = ToolStripMenuItem351;
		size = new Size(54, 20);
		((ToolStripItem)toolStripMenuItem351).set_Size(size);
		((ToolStripItem)ToolStripMenuItem351).set_Text("&Fichier");
		((ToolStripItem)ToolStripMenuItem352).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem352.Image"));
		((ToolStripItem)ToolStripMenuItem352).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem352).set_Name("ToolStripMenuItem352");
		ToolStripMenuItem352.set_ShortcutKeys((Keys)131150);
		ToolStripMenuItem toolStripMenuItem352 = ToolStripMenuItem352;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem352).set_Size(size);
		((ToolStripItem)ToolStripMenuItem352).set_Text("&Nouveau");
		((ToolStripItem)ToolStripMenuItem353).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem353.Image"));
		((ToolStripItem)ToolStripMenuItem353).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem353).set_Name("ToolStripMenuItem353");
		ToolStripMenuItem353.set_ShortcutKeys((Keys)131151);
		ToolStripMenuItem toolStripMenuItem353 = ToolStripMenuItem353;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem353).set_Size(size);
		((ToolStripItem)ToolStripMenuItem353).set_Text("&Ouvrir");
		((ToolStripItem)ToolStripSeparator97).set_Name("ToolStripSeparator97");
		ToolStripSeparator toolStripSeparator97 = ToolStripSeparator97;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator97).set_Size(size);
		((ToolStripItem)ToolStripMenuItem354).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem354.Image"));
		((ToolStripItem)ToolStripMenuItem354).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem354).set_Name("ToolStripMenuItem354");
		ToolStripMenuItem354.set_ShortcutKeys((Keys)131155);
		ToolStripMenuItem toolStripMenuItem354 = ToolStripMenuItem354;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem354).set_Size(size);
		((ToolStripItem)ToolStripMenuItem354).set_Text("&Enregistrer");
		((ToolStripItem)ToolStripMenuItem355).set_Name("ToolStripMenuItem355");
		ToolStripMenuItem toolStripMenuItem355 = ToolStripMenuItem355;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem355).set_Size(size);
		((ToolStripItem)ToolStripMenuItem355).set_Text("Enregistrer &sous");
		((ToolStripItem)ToolStripSeparator98).set_Name("ToolStripSeparator98");
		ToolStripSeparator toolStripSeparator98 = ToolStripSeparator98;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator98).set_Size(size);
		((ToolStripItem)ToolStripMenuItem356).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem356.Image"));
		((ToolStripItem)ToolStripMenuItem356).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem356).set_Name("ToolStripMenuItem356");
		ToolStripMenuItem356.set_ShortcutKeys((Keys)131152);
		ToolStripMenuItem toolStripMenuItem356 = ToolStripMenuItem356;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem356).set_Size(size);
		((ToolStripItem)ToolStripMenuItem356).set_Text("&Imprimer");
		((ToolStripItem)ToolStripMenuItem357).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem357.Image"));
		((ToolStripItem)ToolStripMenuItem357).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem357).set_Name("ToolStripMenuItem357");
		ToolStripMenuItem toolStripMenuItem357 = ToolStripMenuItem357;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem357).set_Size(size);
		((ToolStripItem)ToolStripMenuItem357).set_Text("Aperçu a&vant impression");
		((ToolStripItem)ToolStripMenuItem358).set_Name("ToolStripMenuItem358");
		ToolStripMenuItem toolStripMenuItem358 = ToolStripMenuItem358;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem358).set_Size(size);
		((ToolStripItem)ToolStripMenuItem358).set_Text("Configuration de l'impression");
		((ToolStripItem)ToolStripSeparator99).set_Name("ToolStripSeparator99");
		ToolStripSeparator toolStripSeparator99 = ToolStripSeparator99;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator99).set_Size(size);
		((ToolStripItem)ToolStripMenuItem359).set_Name("ToolStripMenuItem359");
		ToolStripMenuItem toolStripMenuItem359 = ToolStripMenuItem359;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem359).set_Size(size);
		((ToolStripItem)ToolStripMenuItem359).set_Text("&Quitter");
		((ToolStripDropDownItem)ToolStripMenuItem360).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripMenuItem361,
			(ToolStripItem)ToolStripMenuItem362,
			(ToolStripItem)ToolStripSeparator100,
			(ToolStripItem)ToolStripMenuItem363,
			(ToolStripItem)ToolStripMenuItem364,
			(ToolStripItem)ToolStripMenuItem365,
			(ToolStripItem)ToolStripSeparator101,
			(ToolStripItem)ToolStripMenuItem366
		});
		((ToolStripItem)ToolStripMenuItem360).set_Name("ToolStripMenuItem360");
		ToolStripMenuItem toolStripMenuItem360 = ToolStripMenuItem360;
		size = new Size(56, 20);
		((ToolStripItem)toolStripMenuItem360).set_Size(size);
		((ToolStripItem)ToolStripMenuItem360).set_Text("&Edition");
		((ToolStripItem)ToolStripMenuItem361).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem361.Image"));
		((ToolStripItem)ToolStripMenuItem361).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem361).set_Name("ToolStripMenuItem361");
		ToolStripMenuItem361.set_ShortcutKeys((Keys)131162);
		ToolStripMenuItem toolStripMenuItem361 = ToolStripMenuItem361;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem361).set_Size(size);
		((ToolStripItem)ToolStripMenuItem361).set_Text("&Annuler");
		((ToolStripItem)ToolStripMenuItem362).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem362.Image"));
		((ToolStripItem)ToolStripMenuItem362).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem362).set_Name("ToolStripMenuItem362");
		ToolStripMenuItem362.set_ShortcutKeys((Keys)131161);
		ToolStripMenuItem toolStripMenuItem362 = ToolStripMenuItem362;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem362).set_Size(size);
		((ToolStripItem)ToolStripMenuItem362).set_Text("&Rétablir");
		((ToolStripItem)ToolStripSeparator100).set_Name("ToolStripSeparator100");
		ToolStripSeparator toolStripSeparator100 = ToolStripSeparator100;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator100).set_Size(size);
		((ToolStripItem)ToolStripMenuItem363).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem363.Image"));
		((ToolStripItem)ToolStripMenuItem363).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem363).set_Name("ToolStripMenuItem363");
		ToolStripMenuItem363.set_ShortcutKeys((Keys)131160);
		ToolStripMenuItem toolStripMenuItem363 = ToolStripMenuItem363;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem363).set_Size(size);
		((ToolStripItem)ToolStripMenuItem363).set_Text("Co&uper");
		((ToolStripItem)ToolStripMenuItem364).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem364.Image"));
		((ToolStripItem)ToolStripMenuItem364).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem364).set_Name("ToolStripMenuItem364");
		ToolStripMenuItem364.set_ShortcutKeys((Keys)131139);
		ToolStripMenuItem toolStripMenuItem364 = ToolStripMenuItem364;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem364).set_Size(size);
		((ToolStripItem)ToolStripMenuItem364).set_Text("&Copier");
		((ToolStripItem)ToolStripMenuItem365).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem365.Image"));
		((ToolStripItem)ToolStripMenuItem365).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem365).set_Name("ToolStripMenuItem365");
		ToolStripMenuItem365.set_ShortcutKeys((Keys)131158);
		ToolStripMenuItem toolStripMenuItem365 = ToolStripMenuItem365;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem365).set_Size(size);
		((ToolStripItem)ToolStripMenuItem365).set_Text("&Coller");
		((ToolStripItem)ToolStripSeparator101).set_Name("ToolStripSeparator101");
		ToolStripSeparator toolStripSeparator101 = ToolStripSeparator101;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator101).set_Size(size);
		((ToolStripItem)ToolStripMenuItem366).set_Name("ToolStripMenuItem366");
		ToolStripMenuItem366.set_ShortcutKeys((Keys)131137);
		ToolStripMenuItem toolStripMenuItem366 = ToolStripMenuItem366;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem366).set_Size(size);
		((ToolStripItem)ToolStripMenuItem366).set_Text("Sélectionner &tout");
		((ToolStripDropDownItem)ToolStripMenuItem367).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolStripMenuItem368,
			(ToolStripItem)ToolStripMenuItem369
		});
		((ToolStripItem)ToolStripMenuItem367).set_Name("ToolStripMenuItem367");
		ToolStripMenuItem toolStripMenuItem367 = ToolStripMenuItem367;
		size = new Size(70, 20);
		((ToolStripItem)toolStripMenuItem367).set_Size(size);
		((ToolStripItem)ToolStripMenuItem367).set_Text("&Affichage");
		ToolStripMenuItem368.set_Checked(true);
		ToolStripMenuItem368.set_CheckOnClick(true);
		ToolStripMenuItem368.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem368).set_Name("ToolStripMenuItem368");
		ToolStripMenuItem toolStripMenuItem368 = ToolStripMenuItem368;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem368).set_Size(size);
		((ToolStripItem)ToolStripMenuItem368).set_Text("&Barre d'outils");
		ToolStripMenuItem369.set_Checked(true);
		ToolStripMenuItem369.set_CheckOnClick(true);
		ToolStripMenuItem369.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem369).set_Name("ToolStripMenuItem369");
		ToolStripMenuItem toolStripMenuItem369 = ToolStripMenuItem369;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem369).set_Size(size);
		((ToolStripItem)ToolStripMenuItem369).set_Text("&Barre d'état");
		((ToolStripDropDownItem)ToolStripMenuItem370).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripMenuItem371 });
		((ToolStripItem)ToolStripMenuItem370).set_Name("ToolStripMenuItem370");
		ToolStripMenuItem toolStripMenuItem370 = ToolStripMenuItem370;
		size = new Size(50, 20);
		((ToolStripItem)toolStripMenuItem370).set_Size(size);
		((ToolStripItem)ToolStripMenuItem370).set_Text("&Outils");
		((ToolStripItem)ToolStripMenuItem371).set_Name("ToolStripMenuItem371");
		ToolStripMenuItem toolStripMenuItem371 = ToolStripMenuItem371;
		size = new Size(116, 22);
		((ToolStripItem)toolStripMenuItem371).set_Size(size);
		((ToolStripItem)ToolStripMenuItem371).set_Text("&Options");
		((ToolStripDropDownItem)ToolStripMenuItem372).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem373,
			(ToolStripItem)ToolStripMenuItem374,
			(ToolStripItem)ToolStripMenuItem375,
			(ToolStripItem)ToolStripMenuItem376,
			(ToolStripItem)ToolStripMenuItem377,
			(ToolStripItem)ToolStripMenuItem378
		});
		((ToolStripItem)ToolStripMenuItem372).set_Name("ToolStripMenuItem372");
		ToolStripMenuItem toolStripMenuItem372 = ToolStripMenuItem372;
		size = new Size(63, 20);
		((ToolStripItem)toolStripMenuItem372).set_Size(size);
		((ToolStripItem)ToolStripMenuItem372).set_Text("F&enêtres");
		((ToolStripItem)ToolStripMenuItem373).set_Name("ToolStripMenuItem373");
		ToolStripMenuItem toolStripMenuItem373 = ToolStripMenuItem373;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem373).set_Size(size);
		((ToolStripItem)ToolStripMenuItem373).set_Text("&Nouvelle fenêtre");
		((ToolStripItem)ToolStripMenuItem374).set_Name("ToolStripMenuItem374");
		ToolStripMenuItem toolStripMenuItem374 = ToolStripMenuItem374;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem374).set_Size(size);
		((ToolStripItem)ToolStripMenuItem374).set_Text("&Cascade");
		((ToolStripItem)ToolStripMenuItem375).set_Name("ToolStripMenuItem375");
		ToolStripMenuItem toolStripMenuItem375 = ToolStripMenuItem375;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem375).set_Size(size);
		((ToolStripItem)ToolStripMenuItem375).set_Text("Mosaïque &verticale");
		((ToolStripItem)ToolStripMenuItem376).set_Name("ToolStripMenuItem376");
		ToolStripMenuItem toolStripMenuItem376 = ToolStripMenuItem376;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem376).set_Size(size);
		((ToolStripItem)ToolStripMenuItem376).set_Text("Mosaïque &horizontale");
		((ToolStripItem)ToolStripMenuItem377).set_Name("ToolStripMenuItem377");
		ToolStripMenuItem toolStripMenuItem377 = ToolStripMenuItem377;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem377).set_Size(size);
		((ToolStripItem)ToolStripMenuItem377).set_Text("&Fermer tout");
		((ToolStripItem)ToolStripMenuItem378).set_Name("ToolStripMenuItem378");
		ToolStripMenuItem toolStripMenuItem378 = ToolStripMenuItem378;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem378).set_Size(size);
		((ToolStripItem)ToolStripMenuItem378).set_Text("&Réorganiser les icônes");
		((ToolStripDropDownItem)ToolStripMenuItem379).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ToolStripMenuItem380,
			(ToolStripItem)ToolStripMenuItem381,
			(ToolStripItem)ToolStripMenuItem382,
			(ToolStripItem)ToolStripSeparator102,
			(ToolStripItem)ToolStripMenuItem383
		});
		((ToolStripItem)ToolStripMenuItem379).set_Name("ToolStripMenuItem379");
		ToolStripMenuItem toolStripMenuItem379 = ToolStripMenuItem379;
		size = new Size(24, 20);
		((ToolStripItem)toolStripMenuItem379).set_Size(size);
		((ToolStripItem)ToolStripMenuItem379).set_Text("&?");
		((ToolStripItem)ToolStripMenuItem380).set_Name("ToolStripMenuItem380");
		ToolStripMenuItem380.set_ShortcutKeys((Keys)131184);
		ToolStripMenuItem toolStripMenuItem380 = ToolStripMenuItem380;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem380).set_Size(size);
		((ToolStripItem)ToolStripMenuItem380).set_Text("&Contenu");
		((ToolStripItem)ToolStripMenuItem381).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem381.Image"));
		((ToolStripItem)ToolStripMenuItem381).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem381).set_Name("ToolStripMenuItem381");
		ToolStripMenuItem toolStripMenuItem381 = ToolStripMenuItem381;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem381).set_Size(size);
		((ToolStripItem)ToolStripMenuItem381).set_Text("&Index");
		((ToolStripItem)ToolStripMenuItem382).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem382.Image"));
		((ToolStripItem)ToolStripMenuItem382).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem382).set_Name("ToolStripMenuItem382");
		ToolStripMenuItem toolStripMenuItem382 = ToolStripMenuItem382;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem382).set_Size(size);
		((ToolStripItem)ToolStripMenuItem382).set_Text("&Rechercher");
		((ToolStripItem)ToolStripSeparator102).set_Name("ToolStripSeparator102");
		ToolStripSeparator toolStripSeparator102 = ToolStripSeparator102;
		size = new Size(163, 6);
		((ToolStripItem)toolStripSeparator102).set_Size(size);
		((ToolStripItem)ToolStripMenuItem383).set_Name("ToolStripMenuItem383");
		ToolStripMenuItem toolStripMenuItem383 = ToolStripMenuItem383;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem383).set_Size(size);
		((ToolStripItem)ToolStripMenuItem383).set_Text("À pr&opos de...");
		((ToolStripItem)ToolStripSeparator103).set_Name("ToolStripSeparator103");
		ToolStripSeparator toolStripSeparator103 = ToolStripSeparator103;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator103).set_Size(size);
		((ToolStripItem)ToolStripButton61).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton61).set_Image((Image)componentResourceManager.GetObject("ToolStripButton61.Image"));
		((ToolStripItem)ToolStripButton61).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton61).set_Name("ToolStripButton61");
		ToolStripButton toolStripButton61 = ToolStripButton61;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton61).set_Size(size);
		((ToolStripItem)ToolStripButton61).set_Text("Aide");
		((ToolStrip)StatusStrip12).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel12 });
		StatusStrip statusStrip25 = StatusStrip12;
		location = new Point(0, 250);
		((Control)statusStrip25).set_Location(location);
		((Control)StatusStrip12).set_Name("StatusStrip12");
		StatusStrip statusStrip26 = StatusStrip12;
		size = new Size(417, 22);
		((Control)statusStrip26).set_Size(size);
		((Control)StatusStrip12).set_TabIndex(25);
		((Control)StatusStrip12).set_Text("StatusStrip");
		((ToolStripItem)ToolStripStatusLabel12).set_Name("ToolStripStatusLabel12");
		ToolStripStatusLabel toolStripStatusLabel13 = ToolStripStatusLabel12;
		size = new Size(27, 17);
		((ToolStripItem)toolStripStatusLabel13).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel12).set_Text("État");
		((ToolStripItem)ToolStripButton62).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton62).set_Image((Image)componentResourceManager.GetObject("ToolStripButton62.Image"));
		((ToolStripItem)ToolStripButton62).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton62).set_Name("ToolStripButton62");
		ToolStripButton toolStripButton62 = ToolStripButton62;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton62).set_Size(size);
		((ToolStripItem)ToolStripButton62).set_Text("Aperçu avant impression");
		((ToolStripItem)ToolStripButton63).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton63).set_Image((Image)componentResourceManager.GetObject("ToolStripButton63.Image"));
		((ToolStripItem)ToolStripButton63).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton63).set_Name("ToolStripButton63");
		ToolStripButton toolStripButton63 = ToolStripButton63;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton63).set_Size(size);
		((ToolStripItem)ToolStripButton63).set_Text("Imprimer");
		((ToolStripItem)ToolStripSeparator104).set_Name("ToolStripSeparator104");
		ToolStripSeparator toolStripSeparator104 = ToolStripSeparator104;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator104).set_Size(size);
		ToolStrip12.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripButton64,
			(ToolStripItem)ToolStripButton65,
			(ToolStripItem)ToolStripButton66,
			(ToolStripItem)ToolStripSeparator104,
			(ToolStripItem)ToolStripButton63,
			(ToolStripItem)ToolStripButton62,
			(ToolStripItem)ToolStripSeparator103,
			(ToolStripItem)ToolStripButton61
		});
		ToolStrip toolStrip25 = ToolStrip12;
		location = new Point(0, 245);
		((Control)toolStrip25).set_Location(location);
		((Control)ToolStrip12).set_Name("ToolStrip12");
		ToolStrip toolStrip26 = ToolStrip12;
		size = new Size(417, 25);
		((Control)toolStrip26).set_Size(size);
		((Control)ToolStrip12).set_TabIndex(24);
		((Control)ToolStrip12).set_Text("ToolStrip");
		((ToolStripItem)ToolStripButton64).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton64).set_Image((Image)componentResourceManager.GetObject("ToolStripButton64.Image"));
		((ToolStripItem)ToolStripButton64).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton64).set_Name("ToolStripButton64");
		ToolStripButton toolStripButton64 = ToolStripButton64;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton64).set_Size(size);
		((ToolStripItem)ToolStripButton64).set_Text("Nouveau");
		((ToolStripItem)ToolStripButton65).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton65).set_Image((Image)componentResourceManager.GetObject("ToolStripButton65.Image"));
		((ToolStripItem)ToolStripButton65).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton65).set_Name("ToolStripButton65");
		ToolStripButton toolStripButton65 = ToolStripButton65;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton65).set_Size(size);
		((ToolStripItem)ToolStripButton65).set_Text("Ouvrir");
		((ToolStripItem)ToolStripButton66).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton66).set_Image((Image)componentResourceManager.GetObject("ToolStripButton66.Image"));
		((ToolStripItem)ToolStripButton66).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton66).set_Name("ToolStripButton66");
		ToolStripButton toolStripButton66 = ToolStripButton66;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton66).set_Size(size);
		((ToolStripItem)ToolStripButton66).set_Text("Enregistrer");
		((ToolStrip)MenuStrip13).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem384,
			(ToolStripItem)ToolStripMenuItem393,
			(ToolStripItem)ToolStripMenuItem400,
			(ToolStripItem)ToolStripMenuItem403,
			(ToolStripItem)ToolStripMenuItem405,
			(ToolStripItem)ToolStripMenuItem412
		});
		MenuStrip menuStrip27 = MenuStrip13;
		location = new Point(0, 319);
		((Control)menuStrip27).set_Location(location);
		MenuStrip13.set_MdiWindowListItem(ToolStripMenuItem405);
		((Control)MenuStrip13).set_Name("MenuStrip13");
		MenuStrip menuStrip28 = MenuStrip13;
		size = new Size(417, 24);
		((Control)menuStrip28).set_Size(size);
		((Control)MenuStrip13).set_TabIndex(26);
		((Control)MenuStrip13).set_Text("MenuStrip13");
		((ToolStripDropDownItem)ToolStripMenuItem384).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)ToolStripMenuItem385,
			(ToolStripItem)ToolStripMenuItem386,
			(ToolStripItem)ToolStripSeparator105,
			(ToolStripItem)ToolStripMenuItem387,
			(ToolStripItem)ToolStripMenuItem388,
			(ToolStripItem)ToolStripSeparator106,
			(ToolStripItem)ToolStripMenuItem389,
			(ToolStripItem)ToolStripMenuItem390,
			(ToolStripItem)ToolStripMenuItem391,
			(ToolStripItem)ToolStripSeparator107,
			(ToolStripItem)ToolStripMenuItem392
		});
		((ToolStripItem)ToolStripMenuItem384).set_ImageTransparentColor(SystemColors.ActiveBorder);
		((ToolStripItem)ToolStripMenuItem384).set_Name("ToolStripMenuItem384");
		ToolStripMenuItem toolStripMenuItem384 = ToolStripMenuItem384;
		size = new Size(54, 20);
		((ToolStripItem)toolStripMenuItem384).set_Size(size);
		((ToolStripItem)ToolStripMenuItem384).set_Text("&Fichier");
		((ToolStripItem)ToolStripMenuItem385).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem385.Image"));
		((ToolStripItem)ToolStripMenuItem385).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem385).set_Name("ToolStripMenuItem385");
		ToolStripMenuItem385.set_ShortcutKeys((Keys)131150);
		ToolStripMenuItem toolStripMenuItem385 = ToolStripMenuItem385;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem385).set_Size(size);
		((ToolStripItem)ToolStripMenuItem385).set_Text("&Nouveau");
		((ToolStripItem)ToolStripMenuItem386).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem386.Image"));
		((ToolStripItem)ToolStripMenuItem386).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem386).set_Name("ToolStripMenuItem386");
		ToolStripMenuItem386.set_ShortcutKeys((Keys)131151);
		ToolStripMenuItem toolStripMenuItem386 = ToolStripMenuItem386;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem386).set_Size(size);
		((ToolStripItem)ToolStripMenuItem386).set_Text("&Ouvrir");
		((ToolStripItem)ToolStripSeparator105).set_Name("ToolStripSeparator105");
		ToolStripSeparator toolStripSeparator105 = ToolStripSeparator105;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator105).set_Size(size);
		((ToolStripItem)ToolStripMenuItem387).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem387.Image"));
		((ToolStripItem)ToolStripMenuItem387).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem387).set_Name("ToolStripMenuItem387");
		ToolStripMenuItem387.set_ShortcutKeys((Keys)131155);
		ToolStripMenuItem toolStripMenuItem387 = ToolStripMenuItem387;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem387).set_Size(size);
		((ToolStripItem)ToolStripMenuItem387).set_Text("&Enregistrer");
		((ToolStripItem)ToolStripMenuItem388).set_Name("ToolStripMenuItem388");
		ToolStripMenuItem toolStripMenuItem388 = ToolStripMenuItem388;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem388).set_Size(size);
		((ToolStripItem)ToolStripMenuItem388).set_Text("Enregistrer &sous");
		((ToolStripItem)ToolStripSeparator106).set_Name("ToolStripSeparator106");
		ToolStripSeparator toolStripSeparator106 = ToolStripSeparator106;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator106).set_Size(size);
		((ToolStripItem)ToolStripMenuItem389).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem389.Image"));
		((ToolStripItem)ToolStripMenuItem389).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem389).set_Name("ToolStripMenuItem389");
		ToolStripMenuItem389.set_ShortcutKeys((Keys)131152);
		ToolStripMenuItem toolStripMenuItem389 = ToolStripMenuItem389;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem389).set_Size(size);
		((ToolStripItem)ToolStripMenuItem389).set_Text("&Imprimer");
		((ToolStripItem)ToolStripMenuItem390).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem390.Image"));
		((ToolStripItem)ToolStripMenuItem390).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem390).set_Name("ToolStripMenuItem390");
		ToolStripMenuItem toolStripMenuItem390 = ToolStripMenuItem390;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem390).set_Size(size);
		((ToolStripItem)ToolStripMenuItem390).set_Text("Aperçu a&vant impression");
		((ToolStripItem)ToolStripMenuItem391).set_Name("ToolStripMenuItem391");
		ToolStripMenuItem toolStripMenuItem391 = ToolStripMenuItem391;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem391).set_Size(size);
		((ToolStripItem)ToolStripMenuItem391).set_Text("Configuration de l'impression");
		((ToolStripItem)ToolStripSeparator107).set_Name("ToolStripSeparator107");
		ToolStripSeparator toolStripSeparator107 = ToolStripSeparator107;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator107).set_Size(size);
		((ToolStripItem)ToolStripMenuItem392).set_Name("ToolStripMenuItem392");
		ToolStripMenuItem toolStripMenuItem392 = ToolStripMenuItem392;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem392).set_Size(size);
		((ToolStripItem)ToolStripMenuItem392).set_Text("&Quitter");
		((ToolStripDropDownItem)ToolStripMenuItem393).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripMenuItem394,
			(ToolStripItem)ToolStripMenuItem395,
			(ToolStripItem)ToolStripSeparator108,
			(ToolStripItem)ToolStripMenuItem396,
			(ToolStripItem)ToolStripMenuItem397,
			(ToolStripItem)ToolStripMenuItem398,
			(ToolStripItem)ToolStripSeparator109,
			(ToolStripItem)ToolStripMenuItem399
		});
		((ToolStripItem)ToolStripMenuItem393).set_Name("ToolStripMenuItem393");
		ToolStripMenuItem toolStripMenuItem393 = ToolStripMenuItem393;
		size = new Size(56, 20);
		((ToolStripItem)toolStripMenuItem393).set_Size(size);
		((ToolStripItem)ToolStripMenuItem393).set_Text("&Edition");
		((ToolStripItem)ToolStripMenuItem394).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem394.Image"));
		((ToolStripItem)ToolStripMenuItem394).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem394).set_Name("ToolStripMenuItem394");
		ToolStripMenuItem394.set_ShortcutKeys((Keys)131162);
		ToolStripMenuItem toolStripMenuItem394 = ToolStripMenuItem394;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem394).set_Size(size);
		((ToolStripItem)ToolStripMenuItem394).set_Text("&Annuler");
		((ToolStripItem)ToolStripMenuItem395).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem395.Image"));
		((ToolStripItem)ToolStripMenuItem395).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem395).set_Name("ToolStripMenuItem395");
		ToolStripMenuItem395.set_ShortcutKeys((Keys)131161);
		ToolStripMenuItem toolStripMenuItem395 = ToolStripMenuItem395;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem395).set_Size(size);
		((ToolStripItem)ToolStripMenuItem395).set_Text("&Rétablir");
		((ToolStripItem)ToolStripSeparator108).set_Name("ToolStripSeparator108");
		ToolStripSeparator toolStripSeparator108 = ToolStripSeparator108;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator108).set_Size(size);
		((ToolStripItem)ToolStripMenuItem396).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem396.Image"));
		((ToolStripItem)ToolStripMenuItem396).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem396).set_Name("ToolStripMenuItem396");
		ToolStripMenuItem396.set_ShortcutKeys((Keys)131160);
		ToolStripMenuItem toolStripMenuItem396 = ToolStripMenuItem396;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem396).set_Size(size);
		((ToolStripItem)ToolStripMenuItem396).set_Text("Co&uper");
		((ToolStripItem)ToolStripMenuItem397).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem397.Image"));
		((ToolStripItem)ToolStripMenuItem397).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem397).set_Name("ToolStripMenuItem397");
		ToolStripMenuItem397.set_ShortcutKeys((Keys)131139);
		ToolStripMenuItem toolStripMenuItem397 = ToolStripMenuItem397;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem397).set_Size(size);
		((ToolStripItem)ToolStripMenuItem397).set_Text("&Copier");
		((ToolStripItem)ToolStripMenuItem398).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem398.Image"));
		((ToolStripItem)ToolStripMenuItem398).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem398).set_Name("ToolStripMenuItem398");
		ToolStripMenuItem398.set_ShortcutKeys((Keys)131158);
		ToolStripMenuItem toolStripMenuItem398 = ToolStripMenuItem398;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem398).set_Size(size);
		((ToolStripItem)ToolStripMenuItem398).set_Text("&Coller");
		((ToolStripItem)ToolStripSeparator109).set_Name("ToolStripSeparator109");
		ToolStripSeparator toolStripSeparator109 = ToolStripSeparator109;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator109).set_Size(size);
		((ToolStripItem)ToolStripMenuItem399).set_Name("ToolStripMenuItem399");
		ToolStripMenuItem399.set_ShortcutKeys((Keys)131137);
		ToolStripMenuItem toolStripMenuItem399 = ToolStripMenuItem399;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem399).set_Size(size);
		((ToolStripItem)ToolStripMenuItem399).set_Text("Sélectionner &tout");
		((ToolStripDropDownItem)ToolStripMenuItem400).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolStripMenuItem401,
			(ToolStripItem)ToolStripMenuItem402
		});
		((ToolStripItem)ToolStripMenuItem400).set_Name("ToolStripMenuItem400");
		ToolStripMenuItem toolStripMenuItem400 = ToolStripMenuItem400;
		size = new Size(70, 20);
		((ToolStripItem)toolStripMenuItem400).set_Size(size);
		((ToolStripItem)ToolStripMenuItem400).set_Text("&Affichage");
		ToolStripMenuItem401.set_Checked(true);
		ToolStripMenuItem401.set_CheckOnClick(true);
		ToolStripMenuItem401.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem401).set_Name("ToolStripMenuItem401");
		ToolStripMenuItem toolStripMenuItem401 = ToolStripMenuItem401;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem401).set_Size(size);
		((ToolStripItem)ToolStripMenuItem401).set_Text("&Barre d'outils");
		ToolStripMenuItem402.set_Checked(true);
		ToolStripMenuItem402.set_CheckOnClick(true);
		ToolStripMenuItem402.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem402).set_Name("ToolStripMenuItem402");
		ToolStripMenuItem toolStripMenuItem402 = ToolStripMenuItem402;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem402).set_Size(size);
		((ToolStripItem)ToolStripMenuItem402).set_Text("&Barre d'état");
		((ToolStripDropDownItem)ToolStripMenuItem403).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripMenuItem404 });
		((ToolStripItem)ToolStripMenuItem403).set_Name("ToolStripMenuItem403");
		ToolStripMenuItem toolStripMenuItem403 = ToolStripMenuItem403;
		size = new Size(50, 20);
		((ToolStripItem)toolStripMenuItem403).set_Size(size);
		((ToolStripItem)ToolStripMenuItem403).set_Text("&Outils");
		((ToolStripItem)ToolStripMenuItem404).set_Name("ToolStripMenuItem404");
		ToolStripMenuItem toolStripMenuItem404 = ToolStripMenuItem404;
		size = new Size(116, 22);
		((ToolStripItem)toolStripMenuItem404).set_Size(size);
		((ToolStripItem)ToolStripMenuItem404).set_Text("&Options");
		((ToolStripDropDownItem)ToolStripMenuItem405).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem406,
			(ToolStripItem)ToolStripMenuItem407,
			(ToolStripItem)ToolStripMenuItem408,
			(ToolStripItem)ToolStripMenuItem409,
			(ToolStripItem)ToolStripMenuItem410,
			(ToolStripItem)ToolStripMenuItem411
		});
		((ToolStripItem)ToolStripMenuItem405).set_Name("ToolStripMenuItem405");
		ToolStripMenuItem toolStripMenuItem405 = ToolStripMenuItem405;
		size = new Size(63, 20);
		((ToolStripItem)toolStripMenuItem405).set_Size(size);
		((ToolStripItem)ToolStripMenuItem405).set_Text("F&enêtres");
		((ToolStripItem)ToolStripMenuItem406).set_Name("ToolStripMenuItem406");
		ToolStripMenuItem toolStripMenuItem406 = ToolStripMenuItem406;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem406).set_Size(size);
		((ToolStripItem)ToolStripMenuItem406).set_Text("&Nouvelle fenêtre");
		((ToolStripItem)ToolStripMenuItem407).set_Name("ToolStripMenuItem407");
		ToolStripMenuItem toolStripMenuItem407 = ToolStripMenuItem407;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem407).set_Size(size);
		((ToolStripItem)ToolStripMenuItem407).set_Text("&Cascade");
		((ToolStripItem)ToolStripMenuItem408).set_Name("ToolStripMenuItem408");
		ToolStripMenuItem toolStripMenuItem408 = ToolStripMenuItem408;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem408).set_Size(size);
		((ToolStripItem)ToolStripMenuItem408).set_Text("Mosaïque &verticale");
		((ToolStripItem)ToolStripMenuItem409).set_Name("ToolStripMenuItem409");
		ToolStripMenuItem toolStripMenuItem409 = ToolStripMenuItem409;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem409).set_Size(size);
		((ToolStripItem)ToolStripMenuItem409).set_Text("Mosaïque &horizontale");
		((ToolStripItem)ToolStripMenuItem410).set_Name("ToolStripMenuItem410");
		ToolStripMenuItem toolStripMenuItem410 = ToolStripMenuItem410;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem410).set_Size(size);
		((ToolStripItem)ToolStripMenuItem410).set_Text("&Fermer tout");
		((ToolStripItem)ToolStripMenuItem411).set_Name("ToolStripMenuItem411");
		ToolStripMenuItem toolStripMenuItem411 = ToolStripMenuItem411;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem411).set_Size(size);
		((ToolStripItem)ToolStripMenuItem411).set_Text("&Réorganiser les icônes");
		((ToolStripDropDownItem)ToolStripMenuItem412).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ToolStripMenuItem413,
			(ToolStripItem)ToolStripMenuItem414,
			(ToolStripItem)ToolStripMenuItem415,
			(ToolStripItem)ToolStripSeparator110,
			(ToolStripItem)ToolStripMenuItem416
		});
		((ToolStripItem)ToolStripMenuItem412).set_Name("ToolStripMenuItem412");
		ToolStripMenuItem toolStripMenuItem412 = ToolStripMenuItem412;
		size = new Size(24, 20);
		((ToolStripItem)toolStripMenuItem412).set_Size(size);
		((ToolStripItem)ToolStripMenuItem412).set_Text("&?");
		((ToolStripItem)ToolStripMenuItem413).set_Name("ToolStripMenuItem413");
		ToolStripMenuItem413.set_ShortcutKeys((Keys)131184);
		ToolStripMenuItem toolStripMenuItem413 = ToolStripMenuItem413;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem413).set_Size(size);
		((ToolStripItem)ToolStripMenuItem413).set_Text("&Contenu");
		((ToolStripItem)ToolStripMenuItem414).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem414.Image"));
		((ToolStripItem)ToolStripMenuItem414).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem414).set_Name("ToolStripMenuItem414");
		ToolStripMenuItem toolStripMenuItem414 = ToolStripMenuItem414;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem414).set_Size(size);
		((ToolStripItem)ToolStripMenuItem414).set_Text("&Index");
		((ToolStripItem)ToolStripMenuItem415).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem415.Image"));
		((ToolStripItem)ToolStripMenuItem415).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem415).set_Name("ToolStripMenuItem415");
		ToolStripMenuItem toolStripMenuItem415 = ToolStripMenuItem415;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem415).set_Size(size);
		((ToolStripItem)ToolStripMenuItem415).set_Text("&Rechercher");
		((ToolStripItem)ToolStripSeparator110).set_Name("ToolStripSeparator110");
		ToolStripSeparator toolStripSeparator110 = ToolStripSeparator110;
		size = new Size(163, 6);
		((ToolStripItem)toolStripSeparator110).set_Size(size);
		((ToolStripItem)ToolStripMenuItem416).set_Name("ToolStripMenuItem416");
		ToolStripMenuItem toolStripMenuItem416 = ToolStripMenuItem416;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem416).set_Size(size);
		((ToolStripItem)ToolStripMenuItem416).set_Text("À pr&opos de...");
		((ToolStripItem)ToolStripSeparator111).set_Name("ToolStripSeparator111");
		ToolStripSeparator toolStripSeparator111 = ToolStripSeparator111;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator111).set_Size(size);
		((ToolStripItem)ToolStripButton67).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton67).set_Image((Image)componentResourceManager.GetObject("ToolStripButton67.Image"));
		((ToolStripItem)ToolStripButton67).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton67).set_Name("ToolStripButton67");
		ToolStripButton toolStripButton67 = ToolStripButton67;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton67).set_Size(size);
		((ToolStripItem)ToolStripButton67).set_Text("Aide");
		((ToolStrip)StatusStrip13).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel13 });
		StatusStrip statusStrip27 = StatusStrip13;
		location = new Point(0, 228);
		((Control)statusStrip27).set_Location(location);
		((Control)StatusStrip13).set_Name("StatusStrip13");
		StatusStrip statusStrip28 = StatusStrip13;
		size = new Size(417, 22);
		((Control)statusStrip28).set_Size(size);
		((Control)StatusStrip13).set_TabIndex(28);
		((Control)StatusStrip13).set_Text("StatusStrip");
		((ToolStripItem)ToolStripStatusLabel13).set_Name("ToolStripStatusLabel13");
		ToolStripStatusLabel toolStripStatusLabel14 = ToolStripStatusLabel13;
		size = new Size(27, 17);
		((ToolStripItem)toolStripStatusLabel14).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel13).set_Text("État");
		((ToolStripItem)ToolStripButton68).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton68).set_Image((Image)componentResourceManager.GetObject("ToolStripButton68.Image"));
		((ToolStripItem)ToolStripButton68).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton68).set_Name("ToolStripButton68");
		ToolStripButton toolStripButton68 = ToolStripButton68;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton68).set_Size(size);
		((ToolStripItem)ToolStripButton68).set_Text("Aperçu avant impression");
		((ToolStripItem)ToolStripButton69).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton69).set_Image((Image)componentResourceManager.GetObject("ToolStripButton69.Image"));
		((ToolStripItem)ToolStripButton69).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton69).set_Name("ToolStripButton69");
		ToolStripButton toolStripButton69 = ToolStripButton69;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton69).set_Size(size);
		((ToolStripItem)ToolStripButton69).set_Text("Imprimer");
		((ToolStripItem)ToolStripSeparator112).set_Name("ToolStripSeparator112");
		ToolStripSeparator toolStripSeparator112 = ToolStripSeparator112;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator112).set_Size(size);
		ToolStrip13.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripButton70,
			(ToolStripItem)ToolStripButton71,
			(ToolStripItem)ToolStripButton72,
			(ToolStripItem)ToolStripSeparator112,
			(ToolStripItem)ToolStripButton69,
			(ToolStripItem)ToolStripButton68,
			(ToolStripItem)ToolStripSeparator111,
			(ToolStripItem)ToolStripButton67
		});
		ToolStrip toolStrip27 = ToolStrip13;
		location = new Point(0, 294);
		((Control)toolStrip27).set_Location(location);
		((Control)ToolStrip13).set_Name("ToolStrip13");
		ToolStrip toolStrip28 = ToolStrip13;
		size = new Size(417, 25);
		((Control)toolStrip28).set_Size(size);
		((Control)ToolStrip13).set_TabIndex(27);
		((Control)ToolStrip13).set_Text("ToolStrip");
		((ToolStripItem)ToolStripButton70).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton70).set_Image((Image)componentResourceManager.GetObject("ToolStripButton70.Image"));
		((ToolStripItem)ToolStripButton70).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton70).set_Name("ToolStripButton70");
		ToolStripButton toolStripButton70 = ToolStripButton70;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton70).set_Size(size);
		((ToolStripItem)ToolStripButton70).set_Text("Nouveau");
		((ToolStripItem)ToolStripButton71).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton71).set_Image((Image)componentResourceManager.GetObject("ToolStripButton71.Image"));
		((ToolStripItem)ToolStripButton71).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton71).set_Name("ToolStripButton71");
		ToolStripButton toolStripButton71 = ToolStripButton71;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton71).set_Size(size);
		((ToolStripItem)ToolStripButton71).set_Text("Ouvrir");
		((ToolStripItem)ToolStripButton72).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton72).set_Image((Image)componentResourceManager.GetObject("ToolStripButton72.Image"));
		((ToolStripItem)ToolStripButton72).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton72).set_Name("ToolStripButton72");
		ToolStripButton toolStripButton72 = ToolStripButton72;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton72).set_Size(size);
		((ToolStripItem)ToolStripButton72).set_Text("Enregistrer");
		((ToolStrip)MenuStrip14).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem417,
			(ToolStripItem)ToolStripMenuItem426,
			(ToolStripItem)ToolStripMenuItem433,
			(ToolStripItem)ToolStripMenuItem436,
			(ToolStripItem)ToolStripMenuItem438,
			(ToolStripItem)ToolStripMenuItem445
		});
		MenuStrip menuStrip29 = MenuStrip14;
		location = new Point(0, 368);
		((Control)menuStrip29).set_Location(location);
		MenuStrip14.set_MdiWindowListItem(ToolStripMenuItem438);
		((Control)MenuStrip14).set_Name("MenuStrip14");
		MenuStrip menuStrip30 = MenuStrip14;
		size = new Size(417, 24);
		((Control)menuStrip30).set_Size(size);
		((Control)MenuStrip14).set_TabIndex(29);
		((Control)MenuStrip14).set_Text("MenuStrip14");
		((ToolStripDropDownItem)ToolStripMenuItem417).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)ToolStripMenuItem418,
			(ToolStripItem)ToolStripMenuItem419,
			(ToolStripItem)ToolStripSeparator113,
			(ToolStripItem)ToolStripMenuItem420,
			(ToolStripItem)ToolStripMenuItem421,
			(ToolStripItem)ToolStripSeparator114,
			(ToolStripItem)ToolStripMenuItem422,
			(ToolStripItem)ToolStripMenuItem423,
			(ToolStripItem)ToolStripMenuItem424,
			(ToolStripItem)ToolStripSeparator115,
			(ToolStripItem)ToolStripMenuItem425
		});
		((ToolStripItem)ToolStripMenuItem417).set_ImageTransparentColor(SystemColors.ActiveBorder);
		((ToolStripItem)ToolStripMenuItem417).set_Name("ToolStripMenuItem417");
		ToolStripMenuItem toolStripMenuItem417 = ToolStripMenuItem417;
		size = new Size(54, 20);
		((ToolStripItem)toolStripMenuItem417).set_Size(size);
		((ToolStripItem)ToolStripMenuItem417).set_Text("&Fichier");
		((ToolStripItem)ToolStripMenuItem418).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem418.Image"));
		((ToolStripItem)ToolStripMenuItem418).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem418).set_Name("ToolStripMenuItem418");
		ToolStripMenuItem418.set_ShortcutKeys((Keys)131150);
		ToolStripMenuItem toolStripMenuItem418 = ToolStripMenuItem418;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem418).set_Size(size);
		((ToolStripItem)ToolStripMenuItem418).set_Text("&Nouveau");
		((ToolStripItem)ToolStripMenuItem419).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem419.Image"));
		((ToolStripItem)ToolStripMenuItem419).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem419).set_Name("ToolStripMenuItem419");
		ToolStripMenuItem419.set_ShortcutKeys((Keys)131151);
		ToolStripMenuItem toolStripMenuItem419 = ToolStripMenuItem419;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem419).set_Size(size);
		((ToolStripItem)ToolStripMenuItem419).set_Text("&Ouvrir");
		((ToolStripItem)ToolStripSeparator113).set_Name("ToolStripSeparator113");
		ToolStripSeparator toolStripSeparator113 = ToolStripSeparator113;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator113).set_Size(size);
		((ToolStripItem)ToolStripMenuItem420).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem420.Image"));
		((ToolStripItem)ToolStripMenuItem420).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem420).set_Name("ToolStripMenuItem420");
		ToolStripMenuItem420.set_ShortcutKeys((Keys)131155);
		ToolStripMenuItem toolStripMenuItem420 = ToolStripMenuItem420;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem420).set_Size(size);
		((ToolStripItem)ToolStripMenuItem420).set_Text("&Enregistrer");
		((ToolStripItem)ToolStripMenuItem421).set_Name("ToolStripMenuItem421");
		ToolStripMenuItem toolStripMenuItem421 = ToolStripMenuItem421;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem421).set_Size(size);
		((ToolStripItem)ToolStripMenuItem421).set_Text("Enregistrer &sous");
		((ToolStripItem)ToolStripSeparator114).set_Name("ToolStripSeparator114");
		ToolStripSeparator toolStripSeparator114 = ToolStripSeparator114;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator114).set_Size(size);
		((ToolStripItem)ToolStripMenuItem422).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem422.Image"));
		((ToolStripItem)ToolStripMenuItem422).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem422).set_Name("ToolStripMenuItem422");
		ToolStripMenuItem422.set_ShortcutKeys((Keys)131152);
		ToolStripMenuItem toolStripMenuItem422 = ToolStripMenuItem422;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem422).set_Size(size);
		((ToolStripItem)ToolStripMenuItem422).set_Text("&Imprimer");
		((ToolStripItem)ToolStripMenuItem423).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem423.Image"));
		((ToolStripItem)ToolStripMenuItem423).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem423).set_Name("ToolStripMenuItem423");
		ToolStripMenuItem toolStripMenuItem423 = ToolStripMenuItem423;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem423).set_Size(size);
		((ToolStripItem)ToolStripMenuItem423).set_Text("Aperçu a&vant impression");
		((ToolStripItem)ToolStripMenuItem424).set_Name("ToolStripMenuItem424");
		ToolStripMenuItem toolStripMenuItem424 = ToolStripMenuItem424;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem424).set_Size(size);
		((ToolStripItem)ToolStripMenuItem424).set_Text("Configuration de l'impression");
		((ToolStripItem)ToolStripSeparator115).set_Name("ToolStripSeparator115");
		ToolStripSeparator toolStripSeparator115 = ToolStripSeparator115;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator115).set_Size(size);
		((ToolStripItem)ToolStripMenuItem425).set_Name("ToolStripMenuItem425");
		ToolStripMenuItem toolStripMenuItem425 = ToolStripMenuItem425;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem425).set_Size(size);
		((ToolStripItem)ToolStripMenuItem425).set_Text("&Quitter");
		((ToolStripDropDownItem)ToolStripMenuItem426).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripMenuItem427,
			(ToolStripItem)ToolStripMenuItem428,
			(ToolStripItem)ToolStripSeparator116,
			(ToolStripItem)ToolStripMenuItem429,
			(ToolStripItem)ToolStripMenuItem430,
			(ToolStripItem)ToolStripMenuItem431,
			(ToolStripItem)ToolStripSeparator117,
			(ToolStripItem)ToolStripMenuItem432
		});
		((ToolStripItem)ToolStripMenuItem426).set_Name("ToolStripMenuItem426");
		ToolStripMenuItem toolStripMenuItem426 = ToolStripMenuItem426;
		size = new Size(56, 20);
		((ToolStripItem)toolStripMenuItem426).set_Size(size);
		((ToolStripItem)ToolStripMenuItem426).set_Text("&Edition");
		((ToolStripItem)ToolStripMenuItem427).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem427.Image"));
		((ToolStripItem)ToolStripMenuItem427).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem427).set_Name("ToolStripMenuItem427");
		ToolStripMenuItem427.set_ShortcutKeys((Keys)131162);
		ToolStripMenuItem toolStripMenuItem427 = ToolStripMenuItem427;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem427).set_Size(size);
		((ToolStripItem)ToolStripMenuItem427).set_Text("&Annuler");
		((ToolStripItem)ToolStripMenuItem428).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem428.Image"));
		((ToolStripItem)ToolStripMenuItem428).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem428).set_Name("ToolStripMenuItem428");
		ToolStripMenuItem428.set_ShortcutKeys((Keys)131161);
		ToolStripMenuItem toolStripMenuItem428 = ToolStripMenuItem428;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem428).set_Size(size);
		((ToolStripItem)ToolStripMenuItem428).set_Text("&Rétablir");
		((ToolStripItem)ToolStripSeparator116).set_Name("ToolStripSeparator116");
		ToolStripSeparator toolStripSeparator116 = ToolStripSeparator116;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator116).set_Size(size);
		((ToolStripItem)ToolStripMenuItem429).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem429.Image"));
		((ToolStripItem)ToolStripMenuItem429).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem429).set_Name("ToolStripMenuItem429");
		ToolStripMenuItem429.set_ShortcutKeys((Keys)131160);
		ToolStripMenuItem toolStripMenuItem429 = ToolStripMenuItem429;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem429).set_Size(size);
		((ToolStripItem)ToolStripMenuItem429).set_Text("Co&uper");
		((ToolStripItem)ToolStripMenuItem430).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem430.Image"));
		((ToolStripItem)ToolStripMenuItem430).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem430).set_Name("ToolStripMenuItem430");
		ToolStripMenuItem430.set_ShortcutKeys((Keys)131139);
		ToolStripMenuItem toolStripMenuItem430 = ToolStripMenuItem430;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem430).set_Size(size);
		((ToolStripItem)ToolStripMenuItem430).set_Text("&Copier");
		((ToolStripItem)ToolStripMenuItem431).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem431.Image"));
		((ToolStripItem)ToolStripMenuItem431).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem431).set_Name("ToolStripMenuItem431");
		ToolStripMenuItem431.set_ShortcutKeys((Keys)131158);
		ToolStripMenuItem toolStripMenuItem431 = ToolStripMenuItem431;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem431).set_Size(size);
		((ToolStripItem)ToolStripMenuItem431).set_Text("&Coller");
		((ToolStripItem)ToolStripSeparator117).set_Name("ToolStripSeparator117");
		ToolStripSeparator toolStripSeparator117 = ToolStripSeparator117;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator117).set_Size(size);
		((ToolStripItem)ToolStripMenuItem432).set_Name("ToolStripMenuItem432");
		ToolStripMenuItem432.set_ShortcutKeys((Keys)131137);
		ToolStripMenuItem toolStripMenuItem432 = ToolStripMenuItem432;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem432).set_Size(size);
		((ToolStripItem)ToolStripMenuItem432).set_Text("Sélectionner &tout");
		((ToolStripDropDownItem)ToolStripMenuItem433).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolStripMenuItem434,
			(ToolStripItem)ToolStripMenuItem435
		});
		((ToolStripItem)ToolStripMenuItem433).set_Name("ToolStripMenuItem433");
		ToolStripMenuItem toolStripMenuItem433 = ToolStripMenuItem433;
		size = new Size(70, 20);
		((ToolStripItem)toolStripMenuItem433).set_Size(size);
		((ToolStripItem)ToolStripMenuItem433).set_Text("&Affichage");
		ToolStripMenuItem434.set_Checked(true);
		ToolStripMenuItem434.set_CheckOnClick(true);
		ToolStripMenuItem434.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem434).set_Name("ToolStripMenuItem434");
		ToolStripMenuItem toolStripMenuItem434 = ToolStripMenuItem434;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem434).set_Size(size);
		((ToolStripItem)ToolStripMenuItem434).set_Text("&Barre d'outils");
		ToolStripMenuItem435.set_Checked(true);
		ToolStripMenuItem435.set_CheckOnClick(true);
		ToolStripMenuItem435.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem435).set_Name("ToolStripMenuItem435");
		ToolStripMenuItem toolStripMenuItem435 = ToolStripMenuItem435;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem435).set_Size(size);
		((ToolStripItem)ToolStripMenuItem435).set_Text("&Barre d'état");
		((ToolStripDropDownItem)ToolStripMenuItem436).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripMenuItem437 });
		((ToolStripItem)ToolStripMenuItem436).set_Name("ToolStripMenuItem436");
		ToolStripMenuItem toolStripMenuItem436 = ToolStripMenuItem436;
		size = new Size(50, 20);
		((ToolStripItem)toolStripMenuItem436).set_Size(size);
		((ToolStripItem)ToolStripMenuItem436).set_Text("&Outils");
		((ToolStripItem)ToolStripMenuItem437).set_Name("ToolStripMenuItem437");
		ToolStripMenuItem toolStripMenuItem437 = ToolStripMenuItem437;
		size = new Size(116, 22);
		((ToolStripItem)toolStripMenuItem437).set_Size(size);
		((ToolStripItem)ToolStripMenuItem437).set_Text("&Options");
		((ToolStripDropDownItem)ToolStripMenuItem438).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem439,
			(ToolStripItem)ToolStripMenuItem440,
			(ToolStripItem)ToolStripMenuItem441,
			(ToolStripItem)ToolStripMenuItem442,
			(ToolStripItem)ToolStripMenuItem443,
			(ToolStripItem)ToolStripMenuItem444
		});
		((ToolStripItem)ToolStripMenuItem438).set_Name("ToolStripMenuItem438");
		ToolStripMenuItem toolStripMenuItem438 = ToolStripMenuItem438;
		size = new Size(63, 20);
		((ToolStripItem)toolStripMenuItem438).set_Size(size);
		((ToolStripItem)ToolStripMenuItem438).set_Text("F&enêtres");
		((ToolStripItem)ToolStripMenuItem439).set_Name("ToolStripMenuItem439");
		ToolStripMenuItem toolStripMenuItem439 = ToolStripMenuItem439;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem439).set_Size(size);
		((ToolStripItem)ToolStripMenuItem439).set_Text("&Nouvelle fenêtre");
		((ToolStripItem)ToolStripMenuItem440).set_Name("ToolStripMenuItem440");
		ToolStripMenuItem toolStripMenuItem440 = ToolStripMenuItem440;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem440).set_Size(size);
		((ToolStripItem)ToolStripMenuItem440).set_Text("&Cascade");
		((ToolStripItem)ToolStripMenuItem441).set_Name("ToolStripMenuItem441");
		ToolStripMenuItem toolStripMenuItem441 = ToolStripMenuItem441;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem441).set_Size(size);
		((ToolStripItem)ToolStripMenuItem441).set_Text("Mosaïque &verticale");
		((ToolStripItem)ToolStripMenuItem442).set_Name("ToolStripMenuItem442");
		ToolStripMenuItem toolStripMenuItem442 = ToolStripMenuItem442;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem442).set_Size(size);
		((ToolStripItem)ToolStripMenuItem442).set_Text("Mosaïque &horizontale");
		((ToolStripItem)ToolStripMenuItem443).set_Name("ToolStripMenuItem443");
		ToolStripMenuItem toolStripMenuItem443 = ToolStripMenuItem443;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem443).set_Size(size);
		((ToolStripItem)ToolStripMenuItem443).set_Text("&Fermer tout");
		((ToolStripItem)ToolStripMenuItem444).set_Name("ToolStripMenuItem444");
		ToolStripMenuItem toolStripMenuItem444 = ToolStripMenuItem444;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem444).set_Size(size);
		((ToolStripItem)ToolStripMenuItem444).set_Text("&Réorganiser les icônes");
		((ToolStripDropDownItem)ToolStripMenuItem445).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ToolStripMenuItem446,
			(ToolStripItem)ToolStripMenuItem447,
			(ToolStripItem)ToolStripMenuItem448,
			(ToolStripItem)ToolStripSeparator118,
			(ToolStripItem)ToolStripMenuItem449
		});
		((ToolStripItem)ToolStripMenuItem445).set_Name("ToolStripMenuItem445");
		ToolStripMenuItem toolStripMenuItem445 = ToolStripMenuItem445;
		size = new Size(24, 20);
		((ToolStripItem)toolStripMenuItem445).set_Size(size);
		((ToolStripItem)ToolStripMenuItem445).set_Text("&?");
		((ToolStripItem)ToolStripMenuItem446).set_Name("ToolStripMenuItem446");
		ToolStripMenuItem446.set_ShortcutKeys((Keys)131184);
		ToolStripMenuItem toolStripMenuItem446 = ToolStripMenuItem446;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem446).set_Size(size);
		((ToolStripItem)ToolStripMenuItem446).set_Text("&Contenu");
		((ToolStripItem)ToolStripMenuItem447).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem447.Image"));
		((ToolStripItem)ToolStripMenuItem447).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem447).set_Name("ToolStripMenuItem447");
		ToolStripMenuItem toolStripMenuItem447 = ToolStripMenuItem447;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem447).set_Size(size);
		((ToolStripItem)ToolStripMenuItem447).set_Text("&Index");
		((ToolStripItem)ToolStripMenuItem448).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem448.Image"));
		((ToolStripItem)ToolStripMenuItem448).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem448).set_Name("ToolStripMenuItem448");
		ToolStripMenuItem toolStripMenuItem448 = ToolStripMenuItem448;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem448).set_Size(size);
		((ToolStripItem)ToolStripMenuItem448).set_Text("&Rechercher");
		((ToolStripItem)ToolStripSeparator118).set_Name("ToolStripSeparator118");
		ToolStripSeparator toolStripSeparator118 = ToolStripSeparator118;
		size = new Size(163, 6);
		((ToolStripItem)toolStripSeparator118).set_Size(size);
		((ToolStripItem)ToolStripMenuItem449).set_Name("ToolStripMenuItem449");
		ToolStripMenuItem toolStripMenuItem449 = ToolStripMenuItem449;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem449).set_Size(size);
		((ToolStripItem)ToolStripMenuItem449).set_Text("À pr&opos de...");
		((ToolStripItem)ToolStripSeparator119).set_Name("ToolStripSeparator119");
		ToolStripSeparator toolStripSeparator119 = ToolStripSeparator119;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator119).set_Size(size);
		((ToolStripItem)ToolStripButton73).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton73).set_Image((Image)componentResourceManager.GetObject("ToolStripButton73.Image"));
		((ToolStripItem)ToolStripButton73).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton73).set_Name("ToolStripButton73");
		ToolStripButton toolStripButton73 = ToolStripButton73;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton73).set_Size(size);
		((ToolStripItem)ToolStripButton73).set_Text("Aide");
		((ToolStrip)StatusStrip14).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel14 });
		StatusStrip statusStrip29 = StatusStrip14;
		location = new Point(0, 206);
		((Control)statusStrip29).set_Location(location);
		((Control)StatusStrip14).set_Name("StatusStrip14");
		StatusStrip statusStrip30 = StatusStrip14;
		size = new Size(417, 22);
		((Control)statusStrip30).set_Size(size);
		((Control)StatusStrip14).set_TabIndex(31);
		((Control)StatusStrip14).set_Text("StatusStrip");
		((ToolStripItem)ToolStripStatusLabel14).set_Name("ToolStripStatusLabel14");
		ToolStripStatusLabel toolStripStatusLabel15 = ToolStripStatusLabel14;
		size = new Size(27, 17);
		((ToolStripItem)toolStripStatusLabel15).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel14).set_Text("État");
		((ToolStripItem)ToolStripButton74).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton74).set_Image((Image)componentResourceManager.GetObject("ToolStripButton74.Image"));
		((ToolStripItem)ToolStripButton74).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton74).set_Name("ToolStripButton74");
		ToolStripButton toolStripButton74 = ToolStripButton74;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton74).set_Size(size);
		((ToolStripItem)ToolStripButton74).set_Text("Aperçu avant impression");
		((ToolStripItem)ToolStripButton75).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton75).set_Image((Image)componentResourceManager.GetObject("ToolStripButton75.Image"));
		((ToolStripItem)ToolStripButton75).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton75).set_Name("ToolStripButton75");
		ToolStripButton toolStripButton75 = ToolStripButton75;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton75).set_Size(size);
		((ToolStripItem)ToolStripButton75).set_Text("Imprimer");
		((ToolStripItem)ToolStripSeparator120).set_Name("ToolStripSeparator120");
		ToolStripSeparator toolStripSeparator120 = ToolStripSeparator120;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator120).set_Size(size);
		ToolStrip14.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripButton76,
			(ToolStripItem)ToolStripButton77,
			(ToolStripItem)ToolStripButton78,
			(ToolStripItem)ToolStripSeparator120,
			(ToolStripItem)ToolStripButton75,
			(ToolStripItem)ToolStripButton74,
			(ToolStripItem)ToolStripSeparator119,
			(ToolStripItem)ToolStripButton73
		});
		ToolStrip toolStrip29 = ToolStrip14;
		location = new Point(0, 343);
		((Control)toolStrip29).set_Location(location);
		((Control)ToolStrip14).set_Name("ToolStrip14");
		ToolStrip toolStrip30 = ToolStrip14;
		size = new Size(417, 25);
		((Control)toolStrip30).set_Size(size);
		((Control)ToolStrip14).set_TabIndex(30);
		((Control)ToolStrip14).set_Text("ToolStrip");
		((ToolStripItem)ToolStripButton76).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton76).set_Image((Image)componentResourceManager.GetObject("ToolStripButton76.Image"));
		((ToolStripItem)ToolStripButton76).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton76).set_Name("ToolStripButton76");
		ToolStripButton toolStripButton76 = ToolStripButton76;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton76).set_Size(size);
		((ToolStripItem)ToolStripButton76).set_Text("Nouveau");
		((ToolStripItem)ToolStripButton77).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton77).set_Image((Image)componentResourceManager.GetObject("ToolStripButton77.Image"));
		((ToolStripItem)ToolStripButton77).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton77).set_Name("ToolStripButton77");
		ToolStripButton toolStripButton77 = ToolStripButton77;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton77).set_Size(size);
		((ToolStripItem)ToolStripButton77).set_Text("Ouvrir");
		((ToolStripItem)ToolStripButton78).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton78).set_Image((Image)componentResourceManager.GetObject("ToolStripButton78.Image"));
		((ToolStripItem)ToolStripButton78).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton78).set_Name("ToolStripButton78");
		ToolStripButton toolStripButton78 = ToolStripButton78;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton78).set_Size(size);
		((ToolStripItem)ToolStripButton78).set_Text("Enregistrer");
		((ToolStrip)MenuStrip15).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem450,
			(ToolStripItem)ToolStripMenuItem459,
			(ToolStripItem)ToolStripMenuItem466,
			(ToolStripItem)ToolStripMenuItem469,
			(ToolStripItem)ToolStripMenuItem471,
			(ToolStripItem)ToolStripMenuItem478
		});
		MenuStrip menuStrip31 = MenuStrip15;
		location = new Point(0, 417);
		((Control)menuStrip31).set_Location(location);
		MenuStrip15.set_MdiWindowListItem(ToolStripMenuItem471);
		((Control)MenuStrip15).set_Name("MenuStrip15");
		MenuStrip menuStrip32 = MenuStrip15;
		size = new Size(417, 24);
		((Control)menuStrip32).set_Size(size);
		((Control)MenuStrip15).set_TabIndex(32);
		((Control)MenuStrip15).set_Text("MenuStrip15");
		((ToolStripDropDownItem)ToolStripMenuItem450).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)ToolStripMenuItem451,
			(ToolStripItem)ToolStripMenuItem452,
			(ToolStripItem)ToolStripSeparator121,
			(ToolStripItem)ToolStripMenuItem453,
			(ToolStripItem)ToolStripMenuItem454,
			(ToolStripItem)ToolStripSeparator122,
			(ToolStripItem)ToolStripMenuItem455,
			(ToolStripItem)ToolStripMenuItem456,
			(ToolStripItem)ToolStripMenuItem457,
			(ToolStripItem)ToolStripSeparator123,
			(ToolStripItem)ToolStripMenuItem458
		});
		((ToolStripItem)ToolStripMenuItem450).set_ImageTransparentColor(SystemColors.ActiveBorder);
		((ToolStripItem)ToolStripMenuItem450).set_Name("ToolStripMenuItem450");
		ToolStripMenuItem toolStripMenuItem450 = ToolStripMenuItem450;
		size = new Size(54, 20);
		((ToolStripItem)toolStripMenuItem450).set_Size(size);
		((ToolStripItem)ToolStripMenuItem450).set_Text("&Fichier");
		((ToolStripItem)ToolStripMenuItem451).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem451.Image"));
		((ToolStripItem)ToolStripMenuItem451).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem451).set_Name("ToolStripMenuItem451");
		ToolStripMenuItem451.set_ShortcutKeys((Keys)131150);
		ToolStripMenuItem toolStripMenuItem451 = ToolStripMenuItem451;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem451).set_Size(size);
		((ToolStripItem)ToolStripMenuItem451).set_Text("&Nouveau");
		((ToolStripItem)ToolStripMenuItem452).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem452.Image"));
		((ToolStripItem)ToolStripMenuItem452).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem452).set_Name("ToolStripMenuItem452");
		ToolStripMenuItem452.set_ShortcutKeys((Keys)131151);
		ToolStripMenuItem toolStripMenuItem452 = ToolStripMenuItem452;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem452).set_Size(size);
		((ToolStripItem)ToolStripMenuItem452).set_Text("&Ouvrir");
		((ToolStripItem)ToolStripSeparator121).set_Name("ToolStripSeparator121");
		ToolStripSeparator toolStripSeparator121 = ToolStripSeparator121;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator121).set_Size(size);
		((ToolStripItem)ToolStripMenuItem453).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem453.Image"));
		((ToolStripItem)ToolStripMenuItem453).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem453).set_Name("ToolStripMenuItem453");
		ToolStripMenuItem453.set_ShortcutKeys((Keys)131155);
		ToolStripMenuItem toolStripMenuItem453 = ToolStripMenuItem453;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem453).set_Size(size);
		((ToolStripItem)ToolStripMenuItem453).set_Text("&Enregistrer");
		((ToolStripItem)ToolStripMenuItem454).set_Name("ToolStripMenuItem454");
		ToolStripMenuItem toolStripMenuItem454 = ToolStripMenuItem454;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem454).set_Size(size);
		((ToolStripItem)ToolStripMenuItem454).set_Text("Enregistrer &sous");
		((ToolStripItem)ToolStripSeparator122).set_Name("ToolStripSeparator122");
		ToolStripSeparator toolStripSeparator122 = ToolStripSeparator122;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator122).set_Size(size);
		((ToolStripItem)ToolStripMenuItem455).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem455.Image"));
		((ToolStripItem)ToolStripMenuItem455).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem455).set_Name("ToolStripMenuItem455");
		ToolStripMenuItem455.set_ShortcutKeys((Keys)131152);
		ToolStripMenuItem toolStripMenuItem455 = ToolStripMenuItem455;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem455).set_Size(size);
		((ToolStripItem)ToolStripMenuItem455).set_Text("&Imprimer");
		((ToolStripItem)ToolStripMenuItem456).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem456.Image"));
		((ToolStripItem)ToolStripMenuItem456).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem456).set_Name("ToolStripMenuItem456");
		ToolStripMenuItem toolStripMenuItem456 = ToolStripMenuItem456;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem456).set_Size(size);
		((ToolStripItem)ToolStripMenuItem456).set_Text("Aperçu a&vant impression");
		((ToolStripItem)ToolStripMenuItem457).set_Name("ToolStripMenuItem457");
		ToolStripMenuItem toolStripMenuItem457 = ToolStripMenuItem457;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem457).set_Size(size);
		((ToolStripItem)ToolStripMenuItem457).set_Text("Configuration de l'impression");
		((ToolStripItem)ToolStripSeparator123).set_Name("ToolStripSeparator123");
		ToolStripSeparator toolStripSeparator123 = ToolStripSeparator123;
		size = new Size(228, 6);
		((ToolStripItem)toolStripSeparator123).set_Size(size);
		((ToolStripItem)ToolStripMenuItem458).set_Name("ToolStripMenuItem458");
		ToolStripMenuItem toolStripMenuItem458 = ToolStripMenuItem458;
		size = new Size(231, 22);
		((ToolStripItem)toolStripMenuItem458).set_Size(size);
		((ToolStripItem)ToolStripMenuItem458).set_Text("&Quitter");
		((ToolStripDropDownItem)ToolStripMenuItem459).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripMenuItem460,
			(ToolStripItem)ToolStripMenuItem461,
			(ToolStripItem)ToolStripSeparator124,
			(ToolStripItem)ToolStripMenuItem462,
			(ToolStripItem)ToolStripMenuItem463,
			(ToolStripItem)ToolStripMenuItem464,
			(ToolStripItem)ToolStripSeparator125,
			(ToolStripItem)ToolStripMenuItem465
		});
		((ToolStripItem)ToolStripMenuItem459).set_Name("ToolStripMenuItem459");
		ToolStripMenuItem toolStripMenuItem459 = ToolStripMenuItem459;
		size = new Size(56, 20);
		((ToolStripItem)toolStripMenuItem459).set_Size(size);
		((ToolStripItem)ToolStripMenuItem459).set_Text("&Edition");
		((ToolStripItem)ToolStripMenuItem460).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem460.Image"));
		((ToolStripItem)ToolStripMenuItem460).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem460).set_Name("ToolStripMenuItem460");
		ToolStripMenuItem460.set_ShortcutKeys((Keys)131162);
		ToolStripMenuItem toolStripMenuItem460 = ToolStripMenuItem460;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem460).set_Size(size);
		((ToolStripItem)ToolStripMenuItem460).set_Text("&Annuler");
		((ToolStripItem)ToolStripMenuItem461).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem461.Image"));
		((ToolStripItem)ToolStripMenuItem461).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem461).set_Name("ToolStripMenuItem461");
		ToolStripMenuItem461.set_ShortcutKeys((Keys)131161);
		ToolStripMenuItem toolStripMenuItem461 = ToolStripMenuItem461;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem461).set_Size(size);
		((ToolStripItem)ToolStripMenuItem461).set_Text("&Rétablir");
		((ToolStripItem)ToolStripSeparator124).set_Name("ToolStripSeparator124");
		ToolStripSeparator toolStripSeparator124 = ToolStripSeparator124;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator124).set_Size(size);
		((ToolStripItem)ToolStripMenuItem462).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem462.Image"));
		((ToolStripItem)ToolStripMenuItem462).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem462).set_Name("ToolStripMenuItem462");
		ToolStripMenuItem462.set_ShortcutKeys((Keys)131160);
		ToolStripMenuItem toolStripMenuItem462 = ToolStripMenuItem462;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem462).set_Size(size);
		((ToolStripItem)ToolStripMenuItem462).set_Text("Co&uper");
		((ToolStripItem)ToolStripMenuItem463).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem463.Image"));
		((ToolStripItem)ToolStripMenuItem463).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem463).set_Name("ToolStripMenuItem463");
		ToolStripMenuItem463.set_ShortcutKeys((Keys)131139);
		ToolStripMenuItem toolStripMenuItem463 = ToolStripMenuItem463;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem463).set_Size(size);
		((ToolStripItem)ToolStripMenuItem463).set_Text("&Copier");
		((ToolStripItem)ToolStripMenuItem464).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem464.Image"));
		((ToolStripItem)ToolStripMenuItem464).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem464).set_Name("ToolStripMenuItem464");
		ToolStripMenuItem464.set_ShortcutKeys((Keys)131158);
		ToolStripMenuItem toolStripMenuItem464 = ToolStripMenuItem464;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem464).set_Size(size);
		((ToolStripItem)ToolStripMenuItem464).set_Text("&Coller");
		((ToolStripItem)ToolStripSeparator125).set_Name("ToolStripSeparator125");
		ToolStripSeparator toolStripSeparator125 = ToolStripSeparator125;
		size = new Size(203, 6);
		((ToolStripItem)toolStripSeparator125).set_Size(size);
		((ToolStripItem)ToolStripMenuItem465).set_Name("ToolStripMenuItem465");
		ToolStripMenuItem465.set_ShortcutKeys((Keys)131137);
		ToolStripMenuItem toolStripMenuItem465 = ToolStripMenuItem465;
		size = new Size(206, 22);
		((ToolStripItem)toolStripMenuItem465).set_Size(size);
		((ToolStripItem)ToolStripMenuItem465).set_Text("Sélectionner &tout");
		((ToolStripDropDownItem)ToolStripMenuItem466).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolStripMenuItem467,
			(ToolStripItem)ToolStripMenuItem468
		});
		((ToolStripItem)ToolStripMenuItem466).set_Name("ToolStripMenuItem466");
		ToolStripMenuItem toolStripMenuItem466 = ToolStripMenuItem466;
		size = new Size(70, 20);
		((ToolStripItem)toolStripMenuItem466).set_Size(size);
		((ToolStripItem)ToolStripMenuItem466).set_Text("&Affichage");
		ToolStripMenuItem467.set_Checked(true);
		ToolStripMenuItem467.set_CheckOnClick(true);
		ToolStripMenuItem467.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem467).set_Name("ToolStripMenuItem467");
		ToolStripMenuItem toolStripMenuItem467 = ToolStripMenuItem467;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem467).set_Size(size);
		((ToolStripItem)ToolStripMenuItem467).set_Text("&Barre d'outils");
		ToolStripMenuItem468.set_Checked(true);
		ToolStripMenuItem468.set_CheckOnClick(true);
		ToolStripMenuItem468.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem468).set_Name("ToolStripMenuItem468");
		ToolStripMenuItem toolStripMenuItem468 = ToolStripMenuItem468;
		size = new Size(143, 22);
		((ToolStripItem)toolStripMenuItem468).set_Size(size);
		((ToolStripItem)ToolStripMenuItem468).set_Text("&Barre d'état");
		((ToolStripDropDownItem)ToolStripMenuItem469).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripMenuItem470 });
		((ToolStripItem)ToolStripMenuItem469).set_Name("ToolStripMenuItem469");
		ToolStripMenuItem toolStripMenuItem469 = ToolStripMenuItem469;
		size = new Size(50, 20);
		((ToolStripItem)toolStripMenuItem469).set_Size(size);
		((ToolStripItem)ToolStripMenuItem469).set_Text("&Outils");
		((ToolStripItem)ToolStripMenuItem470).set_Name("ToolStripMenuItem470");
		ToolStripMenuItem toolStripMenuItem470 = ToolStripMenuItem470;
		size = new Size(116, 22);
		((ToolStripItem)toolStripMenuItem470).set_Size(size);
		((ToolStripItem)ToolStripMenuItem470).set_Text("&Options");
		((ToolStripDropDownItem)ToolStripMenuItem471).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem472,
			(ToolStripItem)ToolStripMenuItem473,
			(ToolStripItem)ToolStripMenuItem474,
			(ToolStripItem)ToolStripMenuItem475,
			(ToolStripItem)ToolStripMenuItem476,
			(ToolStripItem)ToolStripMenuItem477
		});
		((ToolStripItem)ToolStripMenuItem471).set_Name("ToolStripMenuItem471");
		ToolStripMenuItem toolStripMenuItem471 = ToolStripMenuItem471;
		size = new Size(63, 20);
		((ToolStripItem)toolStripMenuItem471).set_Size(size);
		((ToolStripItem)ToolStripMenuItem471).set_Text("F&enêtres");
		((ToolStripItem)ToolStripMenuItem472).set_Name("ToolStripMenuItem472");
		ToolStripMenuItem toolStripMenuItem472 = ToolStripMenuItem472;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem472).set_Size(size);
		((ToolStripItem)ToolStripMenuItem472).set_Text("&Nouvelle fenêtre");
		((ToolStripItem)ToolStripMenuItem473).set_Name("ToolStripMenuItem473");
		ToolStripMenuItem toolStripMenuItem473 = ToolStripMenuItem473;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem473).set_Size(size);
		((ToolStripItem)ToolStripMenuItem473).set_Text("&Cascade");
		((ToolStripItem)ToolStripMenuItem474).set_Name("ToolStripMenuItem474");
		ToolStripMenuItem toolStripMenuItem474 = ToolStripMenuItem474;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem474).set_Size(size);
		((ToolStripItem)ToolStripMenuItem474).set_Text("Mosaïque &verticale");
		((ToolStripItem)ToolStripMenuItem475).set_Name("ToolStripMenuItem475");
		ToolStripMenuItem toolStripMenuItem475 = ToolStripMenuItem475;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem475).set_Size(size);
		((ToolStripItem)ToolStripMenuItem475).set_Text("Mosaïque &horizontale");
		((ToolStripItem)ToolStripMenuItem476).set_Name("ToolStripMenuItem476");
		ToolStripMenuItem toolStripMenuItem476 = ToolStripMenuItem476;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem476).set_Size(size);
		((ToolStripItem)ToolStripMenuItem476).set_Text("&Fermer tout");
		((ToolStripItem)ToolStripMenuItem477).set_Name("ToolStripMenuItem477");
		ToolStripMenuItem toolStripMenuItem477 = ToolStripMenuItem477;
		size = new Size(190, 22);
		((ToolStripItem)toolStripMenuItem477).set_Size(size);
		((ToolStripItem)ToolStripMenuItem477).set_Text("&Réorganiser les icônes");
		((ToolStripDropDownItem)ToolStripMenuItem478).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ToolStripMenuItem479,
			(ToolStripItem)ToolStripMenuItem480,
			(ToolStripItem)ToolStripMenuItem481,
			(ToolStripItem)ToolStripSeparator126,
			(ToolStripItem)ToolStripMenuItem482
		});
		((ToolStripItem)ToolStripMenuItem478).set_Name("ToolStripMenuItem478");
		ToolStripMenuItem toolStripMenuItem478 = ToolStripMenuItem478;
		size = new Size(24, 20);
		((ToolStripItem)toolStripMenuItem478).set_Size(size);
		((ToolStripItem)ToolStripMenuItem478).set_Text("&?");
		((ToolStripItem)ToolStripMenuItem479).set_Name("ToolStripMenuItem479");
		ToolStripMenuItem479.set_ShortcutKeys((Keys)131184);
		ToolStripMenuItem toolStripMenuItem479 = ToolStripMenuItem479;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem479).set_Size(size);
		((ToolStripItem)ToolStripMenuItem479).set_Text("&Contenu");
		((ToolStripItem)ToolStripMenuItem480).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem480.Image"));
		((ToolStripItem)ToolStripMenuItem480).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem480).set_Name("ToolStripMenuItem480");
		ToolStripMenuItem toolStripMenuItem480 = ToolStripMenuItem480;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem480).set_Size(size);
		((ToolStripItem)ToolStripMenuItem480).set_Text("&Index");
		((ToolStripItem)ToolStripMenuItem481).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem481.Image"));
		((ToolStripItem)ToolStripMenuItem481).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripMenuItem481).set_Name("ToolStripMenuItem481");
		ToolStripMenuItem toolStripMenuItem481 = ToolStripMenuItem481;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem481).set_Size(size);
		((ToolStripItem)ToolStripMenuItem481).set_Text("&Rechercher");
		((ToolStripItem)ToolStripSeparator126).set_Name("ToolStripSeparator126");
		ToolStripSeparator toolStripSeparator126 = ToolStripSeparator126;
		size = new Size(163, 6);
		((ToolStripItem)toolStripSeparator126).set_Size(size);
		((ToolStripItem)ToolStripMenuItem482).set_Name("ToolStripMenuItem482");
		ToolStripMenuItem toolStripMenuItem482 = ToolStripMenuItem482;
		size = new Size(166, 22);
		((ToolStripItem)toolStripMenuItem482).set_Size(size);
		((ToolStripItem)ToolStripMenuItem482).set_Text("À pr&opos de...");
		((ToolStripItem)ToolStripSeparator127).set_Name("ToolStripSeparator127");
		ToolStripSeparator toolStripSeparator127 = ToolStripSeparator127;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator127).set_Size(size);
		((ToolStripItem)ToolStripButton79).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton79).set_Image((Image)componentResourceManager.GetObject("ToolStripButton79.Image"));
		((ToolStripItem)ToolStripButton79).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton79).set_Name("ToolStripButton79");
		ToolStripButton toolStripButton79 = ToolStripButton79;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton79).set_Size(size);
		((ToolStripItem)ToolStripButton79).set_Text("Aide");
		((ToolStrip)StatusStrip15).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel15 });
		StatusStrip statusStrip31 = StatusStrip15;
		location = new Point(0, 184);
		((Control)statusStrip31).set_Location(location);
		((Control)StatusStrip15).set_Name("StatusStrip15");
		StatusStrip statusStrip32 = StatusStrip15;
		size = new Size(417, 22);
		((Control)statusStrip32).set_Size(size);
		((Control)StatusStrip15).set_TabIndex(34);
		((Control)StatusStrip15).set_Text("StatusStrip");
		((ToolStripItem)ToolStripStatusLabel15).set_Name("ToolStripStatusLabel15");
		ToolStripStatusLabel toolStripStatusLabel16 = ToolStripStatusLabel15;
		size = new Size(27, 17);
		((ToolStripItem)toolStripStatusLabel16).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel15).set_Text("État");
		((ToolStripItem)ToolStripButton80).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton80).set_Image((Image)componentResourceManager.GetObject("ToolStripButton80.Image"));
		((ToolStripItem)ToolStripButton80).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton80).set_Name("ToolStripButton80");
		ToolStripButton toolStripButton80 = ToolStripButton80;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton80).set_Size(size);
		((ToolStripItem)ToolStripButton80).set_Text("Aperçu avant impression");
		((ToolStripItem)ToolStripButton81).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton81).set_Image((Image)componentResourceManager.GetObject("ToolStripButton81.Image"));
		((ToolStripItem)ToolStripButton81).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton81).set_Name("ToolStripButton81");
		ToolStripButton toolStripButton81 = ToolStripButton81;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton81).set_Size(size);
		((ToolStripItem)ToolStripButton81).set_Text("Imprimer");
		((ToolStripItem)ToolStripSeparator128).set_Name("ToolStripSeparator128");
		ToolStripSeparator toolStripSeparator128 = ToolStripSeparator128;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator128).set_Size(size);
		ToolStrip15.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ToolStripButton82,
			(ToolStripItem)ToolStripButton83,
			(ToolStripItem)ToolStripButton84,
			(ToolStripItem)ToolStripSeparator128,
			(ToolStripItem)ToolStripButton81,
			(ToolStripItem)ToolStripButton80,
			(ToolStripItem)ToolStripSeparator127,
			(ToolStripItem)ToolStripButton79
		});
		ToolStrip toolStrip31 = ToolStrip15;
		location = new Point(0, 392);
		((Control)toolStrip31).set_Location(location);
		((Control)ToolStrip15).set_Name("ToolStrip15");
		ToolStrip toolStrip32 = ToolStrip15;
		size = new Size(417, 25);
		((Control)toolStrip32).set_Size(size);
		((Control)ToolStrip15).set_TabIndex(33);
		((Control)ToolStrip15).set_Text("ToolStrip");
		((ToolStripItem)ToolStripButton82).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton82).set_Image((Image)componentResourceManager.GetObject("ToolStripButton82.Image"));
		((ToolStripItem)ToolStripButton82).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton82).set_Name("ToolStripButton82");
		ToolStripButton toolStripButton82 = ToolStripButton82;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton82).set_Size(size);
		((ToolStripItem)ToolStripButton82).set_Text("Nouveau");
		((ToolStripItem)ToolStripButton83).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton83).set_Image((Image)componentResourceManager.GetObject("ToolStripButton83.Image"));
		((ToolStripItem)ToolStripButton83).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton83).set_Name("ToolStripButton83");
		ToolStripButton toolStripButton83 = ToolStripButton83;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton83).set_Size(size);
		((ToolStripItem)ToolStripButton83).set_Text("Ouvrir");
		((ToolStripItem)ToolStripButton84).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton84).set_Image((Image)componentResourceManager.GetObject("ToolStripButton84.Image"));
		((ToolStripItem)ToolStripButton84).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)ToolStripButton84).set_Name("ToolStripButton84");
		ToolStripButton toolStripButton84 = ToolStripButton84;
		size = new Size(23, 22);
		((ToolStripItem)toolStripButton84).set_Size(size);
		((ToolStripItem)ToolStripButton84).set_Text("Enregistrer");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(632, 453);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ToolStripContainer);
		((Control)this).set_Name("Explorer1");
		((Form)this).set_Text("Explorer1");
		((Control)StatusStrip).ResumeLayout(false);
		((Control)StatusStrip).PerformLayout();
		((Control)ToolStrip).ResumeLayout(false);
		((Control)ToolStrip).PerformLayout();
		((Control)MenuStrip).ResumeLayout(false);
		((Control)MenuStrip).PerformLayout();
		((Control)ToolStripContainer.get_BottomToolStripPanel()).ResumeLayout(false);
		((Control)ToolStripContainer.get_BottomToolStripPanel()).PerformLayout();
		((Control)ToolStripContainer.get_ContentPanel()).ResumeLayout(false);
		((Control)ToolStripContainer.get_TopToolStripPanel()).ResumeLayout(false);
		((Control)ToolStripContainer.get_TopToolStripPanel()).PerformLayout();
		((Control)ToolStripContainer).ResumeLayout(false);
		((Control)ToolStripContainer).PerformLayout();
		((Control)SplitContainer.get_Panel1()).ResumeLayout(false);
		((Control)SplitContainer.get_Panel1()).PerformLayout();
		((Control)SplitContainer.get_Panel2()).ResumeLayout(false);
		((Control)SplitContainer.get_Panel2()).PerformLayout();
		((ISupportInitialize)SplitContainer).EndInit();
		((Control)SplitContainer).ResumeLayout(false);
		((Control)MenuStrip2).ResumeLayout(false);
		((Control)MenuStrip2).PerformLayout();
		((Control)StatusStrip2).ResumeLayout(false);
		((Control)StatusStrip2).PerformLayout();
		((Control)ToolStrip2).ResumeLayout(false);
		((Control)ToolStrip2).PerformLayout();
		((Control)MenuStrip1).ResumeLayout(false);
		((Control)MenuStrip1).PerformLayout();
		((Control)StatusStrip1).ResumeLayout(false);
		((Control)StatusStrip1).PerformLayout();
		((Control)ToolStrip1).ResumeLayout(false);
		((Control)ToolStrip1).PerformLayout();
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
		((Control)MenuStrip7).ResumeLayout(false);
		((Control)MenuStrip7).PerformLayout();
		((Control)StatusStrip7).ResumeLayout(false);
		((Control)StatusStrip7).PerformLayout();
		((Control)ToolStrip7).ResumeLayout(false);
		((Control)ToolStrip7).PerformLayout();
		((Control)MenuStrip8).ResumeLayout(false);
		((Control)MenuStrip8).PerformLayout();
		((Control)StatusStrip8).ResumeLayout(false);
		((Control)StatusStrip8).PerformLayout();
		((Control)ToolStrip8).ResumeLayout(false);
		((Control)ToolStrip8).PerformLayout();
		((Control)MenuStrip9).ResumeLayout(false);
		((Control)MenuStrip9).PerformLayout();
		((Control)StatusStrip9).ResumeLayout(false);
		((Control)StatusStrip9).PerformLayout();
		((Control)ToolStrip9).ResumeLayout(false);
		((Control)ToolStrip9).PerformLayout();
		((Control)MenuStrip10).ResumeLayout(false);
		((Control)MenuStrip10).PerformLayout();
		((Control)StatusStrip10).ResumeLayout(false);
		((Control)StatusStrip10).PerformLayout();
		((Control)ToolStrip10).ResumeLayout(false);
		((Control)ToolStrip10).PerformLayout();
		((Control)MenuStrip11).ResumeLayout(false);
		((Control)MenuStrip11).PerformLayout();
		((Control)StatusStrip11).ResumeLayout(false);
		((Control)StatusStrip11).PerformLayout();
		((Control)ToolStrip11).ResumeLayout(false);
		((Control)ToolStrip11).PerformLayout();
		((Control)MenuStrip12).ResumeLayout(false);
		((Control)MenuStrip12).PerformLayout();
		((Control)StatusStrip12).ResumeLayout(false);
		((Control)StatusStrip12).PerformLayout();
		((Control)ToolStrip12).ResumeLayout(false);
		((Control)ToolStrip12).PerformLayout();
		((Control)MenuStrip13).ResumeLayout(false);
		((Control)MenuStrip13).PerformLayout();
		((Control)StatusStrip13).ResumeLayout(false);
		((Control)StatusStrip13).PerformLayout();
		((Control)ToolStrip13).ResumeLayout(false);
		((Control)ToolStrip13).PerformLayout();
		((Control)MenuStrip14).ResumeLayout(false);
		((Control)MenuStrip14).PerformLayout();
		((Control)StatusStrip14).ResumeLayout(false);
		((Control)StatusStrip14).PerformLayout();
		((Control)ToolStrip14).ResumeLayout(false);
		((Control)ToolStrip14).PerformLayout();
		((Control)MenuStrip15).ResumeLayout(false);
		((Control)MenuStrip15).PerformLayout();
		((Control)StatusStrip15).ResumeLayout(false);
		((Control)StatusStrip15).PerformLayout();
		((Control)ToolStrip15).ResumeLayout(false);
		((Control)ToolStrip15).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void Explorer1_Load(object sender, EventArgs e)
	{
		SetUpListViewColumns();
		LoadTree();
	}

	private void LoadTree()
	{
		TreeNode val = TreeView.get_Nodes().Add("Root");
		val.get_Nodes().Add("TreeItem1");
		val.get_Nodes().Add("TreeItem2");
		val.get_Nodes().Add("TreeItem3");
	}

	private void LoadListView()
	{
		ListView.get_Items().Clear();
		ListViewItem val = ListView.get_Items().Add("ListViewItem1");
		val.set_ImageKey("Graph1");
		val.get_SubItems().AddRange(new string[2] { "Colonne2", "Colonne3" });
		val = ListView.get_Items().Add("ListViewItem2");
		val.set_ImageKey("Graph2");
		val.get_SubItems().AddRange(new string[2] { "Colonne2", "Colonne3" });
		val = ListView.get_Items().Add("ListViewItem3");
		val.set_ImageKey("Graph3");
		val.get_SubItems().AddRange(new string[2] { "Colonne2", "Colonne3" });
	}

	private void SetUpListViewColumns()
	{
		SetView((View)2);
		ColumnHeader val = ListView.get_Columns().Add("Colonne1");
		val.set_Width(90);
		SetView((View)1);
		val.set_Width(100);
		val = ListView.get_Columns().Add("Colonne2");
		val.set_Width(70);
		val = ListView.get_Columns().Add("Colonne3");
		val.set_Width(70);
	}

	private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
	{
		ToolBarToolStripMenuItem.set_Checked(!ToolBarToolStripMenuItem.get_Checked());
		((Control)ToolStrip).set_Visible(ToolBarToolStripMenuItem.get_Checked());
	}

	private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
	{
		StatusBarToolStripMenuItem.set_Checked(!StatusBarToolStripMenuItem.get_Checked());
		((Control)StatusStrip).set_Visible(StatusBarToolStripMenuItem.get_Checked());
	}

	private void ToggleFoldersVisible()
	{
		FoldersToolStripMenuItem.set_Checked(!FoldersToolStripMenuItem.get_Checked());
		FoldersToolStripButton.set_Checked(FoldersToolStripMenuItem.get_Checked());
		SplitContainer.set_Panel1Collapsed(!FoldersToolStripMenuItem.get_Checked());
	}

	private void FoldersToolStripMenuItem_Click(object sender, EventArgs e)
	{
		ToggleFoldersVisible();
	}

	private void FoldersToolStripButton_Click(object sender, EventArgs e)
	{
		ToggleFoldersVisible();
	}

	private void SetView(View View)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected I4, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		ToolStripMenuItem val = null;
		switch ((int)View)
		{
		default:
			View = (View)1;
			val = DetailsToolStripMenuItem;
			break;
		case 0:
			val = LargeIconsToolStripMenuItem;
			break;
		case 1:
			val = DetailsToolStripMenuItem;
			break;
		case 2:
			val = SmallIconsToolStripMenuItem;
			break;
		case 3:
			val = ListToolStripMenuItem;
			break;
		case 4:
			val = TileToolStripMenuItem;
			break;
		}
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((ArrangedElementCollection)((ToolStripDropDownItem)ListViewToolStripButton).get_DropDownItems()).GetEnumerator();
			while (enumerator.MoveNext())
			{
				ToolStripMenuItem val2 = (ToolStripMenuItem)enumerator.Current;
				if (val2 == val)
				{
					val2.set_Checked(true);
				}
				else
				{
					val2.set_Checked(false);
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		ListView.set_View(View);
	}

	private void ListToolStripMenuItem_Click(object sender, EventArgs e)
	{
		SetView((View)3);
	}

	private void DetailsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		SetView((View)1);
	}

	private void LargeIconsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		SetView((View)0);
	}

	private void SmallIconsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		SetView((View)2);
	}

	private void TileToolStripMenuItem_Click(object sender, EventArgs e)
	{
		SetView((View)4);
	}

	private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_InitialDirectory(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments());
		((FileDialog)val).set_Filter("Fichiers texte (*.txt)|*.txt");
		((CommonDialog)val).ShowDialog((IWin32Window)(object)this);
		((FileDialog)val).get_FileName();
	}

	private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).set_InitialDirectory(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments());
		((FileDialog)val).set_Filter("Fichiers texte (*.txt)|*.txt");
		((CommonDialog)val).ShowDialog((IWin32Window)(object)this);
		((FileDialog)val).get_FileName();
	}

	private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
	{
		LoadListView();
	}
}
