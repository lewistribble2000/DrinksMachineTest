   M S B A M L   `   `   `  ????H  DDrinksMachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:DrinksMachine.ViewsDrinksMachine.Views  5      "    DrinksMachine.Views.Sub3View   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:DrinksMachine.Views     5      -   5        
???????.??5	      ?   ? RowDefinitions  5
   
   ?? 5      $??* ?6   ?? 5      $??25 ?6   ?? 5      $??25 ?6   .+?5   
   ?? .+?5      A? -   5         A?Name$ ellipse??5   -   $y?	Collapsed=?6   ???#41271C$	??160??6M    ?? Left$	 320??6Z   
 ?? Top$ 80??6l   $	??160??6|    J? OpacityMask 5      !? 5       j? TileMode$
 Tile=?6F    j? Viewport$ 0,-1,1,3?6V    j? Stretch$
 None=?6j    !? Visual 6"   ?? 	 ?? ElementName$
	 wave??
 ?? RelativeTransform
 5      V? 5      .~?5   "   ?? ?? 5   "   ?? 5   "   T? 5   "    T? Y 65   ?? *Value+$	 y??5      5      5      ? 5      -   5         ?Name$
 wave??5      $	??377??6!   $
 -250??6.   $ 23??6A   $	??160??6Q   ???	#00000000  5      ?? 5       $??1* ?6$   ?? 5!      ??6$   ?? *Value+$	 	amplitude???? 5"      $??1* ?6$   .+?5$      F? ???	#FF82C6FF????p ?? ??Z9???SP????Z9???P??f???fӰ
f?
??Z9????$7??Z9???Ӆ$7L*??$7?)??$7?)??b??*? ?? L*? ?? L*?? ?? L*?~?? L*? ?? ??Z9???	 ?? Stretch$
 Fill=?63  $??1??6B  ?? 5%      ???	#FF82C6FF$??2??6-   $??0,-1,0,0q?6:   5&      ?? 5'      -   5         ??Name$ y??5'   ,   $y?	Collapsed=?6   $	??200??67    ? Minimum$
 -0.6Q?6C    ? Maximum$ 1Q?6R    ? Value$	 0.5Q?6^   ?? 5(      -   5        $ 	amplitude??5(   ,   $y?	Collapsed=?6   $	??200??6?   $ 1Q?6L   $	 100Q?6X   $ 20Q?6f   5)      ?? 5*   
   -   5         ??Name$ btnPour??5*       ?? Interval$ 1??6(   $??Pour your drink??65   $y?	Collapsed=?6O   $??Bottom=?6|   $??Center=?6?   $??0??6?   ?? 5,   
   -   5         ??Name$ imgTea??5,      $y?	Collapsed=?6    $??/Images/HotChocolate.jpg??67   ?? 5-   
   -   5         ??Name$ 	btnReturn??5-      $??Choose your next drink??6$   $??0??6e   $??Bottom=?6r   $y?	Collapsed=?6?   ??6E   ?? *BackCommand+6?   ?? 5/   
   -	   5         ??Name$ txtProgress??5/      
???   ?$??Bottom=?6<   $??1??6W   $??Center=?6d    ? Triggers 50      :? 51       :? RoutedEvent$ FrameworkElement.Loaded??6   .[?52      ?? .??53      ?? .??54      ??  ?? 
TargetName$ txtProgress??6<    ?? TargetProperty$ (TextBlock.Text)?6`    g? Duration$ 0:0:6D?55   <    g? FillBehavior$
 Stop=?6M   .?56   "   a?  ?? Value$ Boiling the water...??69    ?? KeyTime$ 0:0:0??6V   a? 57   "   $  Adding chocolate powder...??69   $ 0:0:3??6\   a? 58   "   $' !Please pour your hot chocolate...??69   $ 0:0:6??6c   59      5:      5;      5<      5>      ? 5?   
   $ 0Q?6   $	 100Q?6"   $??10??60   $??Bottom=?6<   $??2??6W    5@      :? 5A      $ FrameworkElement.Loaded??6   .[?5B      ?? .??5C      ?? .??5D      W?  W? From 06.   	  W? To  10067   $ Value?6@   $ 00:00:6D?6b   5E      5F      5G      5I      5J      5K      