   M S B A M L   `   `   `  ????H  DLivePortfolio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:LivePortfolioLivePortfolio  5   	        LivePortfolio.AssetsWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:LivePortfolio     5   	     ? Title$  Assets??5   	   $	??500??6   $	??300??6%   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $??32 ?6   ?? 5      $??* ?6    ? ColumnDefinitions 5   
   ?? 5      $??* ?6   .+?5   
   ?? $??0??6   $??0??6"   $??Stretch=?62   $??Stretch=?6P    ?? Orientation$ 
Horizontal=?6l   .+?5      ?? $??25??6   $??25??6!   $??2,2,2,2q?6-      SVCSimpleButton#??[  6?   .??6h   +6k   5      ?? 5   
   $??1??6     SVCSimpleBorder#??[ 6   ._?5      &   System.Windows.Controls.DataGrid     AutoGenerateColumns .     SelectionMode$ Extended=?6R      SelectionUnit$ FullRow=?6k      CanUserReorderColumns .    CanUserResizeColumns . 	   CanUserResizeRows	 .  
   CanUserSortColumns
 .    AlternatingRowBackground
 ????? ?? AlternationCount$ 2??5   =      GridLinesVisibility$
 None=?6R   ??5      ?? *Assets+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id??6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToCells 6<      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6b   ?? *Id+  5      $ Ticker??6)   $ 75 6<    .   6[   ?? *Ticker+  5      $
 Name??6)   $	 250 6<    .   6[   ?? *Name+  5      $
 Type??6)   $	 100 6<    .   6[   ?? *	AssetType+  5      $	 Bid??6)   $ 75 6<    .   6[   ?? *
BidPrice+  5      $ Offer??6)   $ 50 6<    .   6[   ?? *
OfferPrice+  5       $ Dividend??6)   $ 50 6<    .   6[   ?? *
Dividend+  5!      $	 P/E??6)   $ 50 6<    .   6[   ?? *PriceEarnings+  5"      $ Updated??6)   $	 100 6<    .   6[   ?? *	Updated+4  .System.Windows.Controls.DataGridCheckBoxColumn  5#      $
 Held??6-   $ 50 6@    .  6_   ?? *InPortfolio+5%      5&      5(      5)      