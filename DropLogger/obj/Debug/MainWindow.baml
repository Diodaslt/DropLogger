   M S B A M L   `   `   `  ����E  ADropLogger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DropLogger
DropLogger  5   	       DropLogger.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )coreclr-namespace:DropLogger     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowStyle$
 None=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � 
ResizeMode$ NoResize=�5   	      PrussianBlueColorBrush#��[  5   	   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      CaptionHeight$ 25Q�6    � 	Resources 5       �� DataType   DropLogger.LogViewModel   DropLogger.LogControl!   DropLogger.ProfileViewModel   DropLogger.ProfileControl   DropLogger.ExtraViewModel   DropLogger.ExtraControl��%�   (��       5      *, +)(�� 2     5      *, +)(�� d     5      *, +)�� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      5      .��5      �  � ColumnDefinitions 5    
   �� 5!      $	��200 �6   �� 5"      $��* �6   	 � RowDefinitions	 5$   
   �� 5%      $��25 �6   �� 5&      $��70 �6   �� 5'      $��70 �6   �� 5(      $��70 �6   �� 5)      $��* �6   .+�5.   
   �� -   5        
 ��Name$
 titlebar��5/       $	��Top=�5.      $��25��5/        RichBlackFOGRAColorBrush#��[ 50      $��3��51      53      $   DropLogger.WindowChromeControl  56   
   $��2��6#   �� 59   
   $��1��6   $	��LOG��5:        MenuItemButton#��[ 5<      ��5;      �� *LogViewCommand+5<      �� 5>   
   $��2��6   $��PROFILE��5?      #��[ 5A      ��5@      �� *ProfileViewCommand+5A      �� 5C   
   $��3��6   $��EXTRA��5D      #��[ 5F      ��5E      �� *ExtraViewCommand+5F      �� 5J   
   $��1��6   $��1��6!   $��4��5K      ._�5N      �� ��6   �� *CurrentView+5O      5P      5Q      