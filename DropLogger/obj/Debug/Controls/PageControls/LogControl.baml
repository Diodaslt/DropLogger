   M S B A M L   `   `   `  ����E  ADropLogger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DropLogger
DropLogger  5          DropLogger.LogControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )coreclr-namespace:DropLogger     5      .��5	      �    LightGrayColorBrush#��[  6     � ColumnDefinitions  5
   
   �� 5      $
��1.5* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   #   DropLogger.ItemDisplayControl  $��1��6"   $��0��6/   '   !DropLogger.DropLogItemListControl  5   
   $��1��6&   $��0��66   $��2��6C   �� 5   
   $��List is empty��6   $��1��5      $��1��5      $��30(�5      $
��Bold"�5        RichBlackFOGRAColorBrush#��[ 5       $��Center=�5"      $	��Top=�5#      $��10q�5$      y�5!      ��    DropLogger.ListProperties   Instance �� Source# Z  �� Path$ isDropLogEmpty� �� 	Converter *   $DropLogger.BoolToVisibilityConverter  5$      �� 5(   
   $��Create a profile first��6   $��1��5)      $��0��5*      $��2��5+      $��30(�5,      #��[ 5-      $
��Bold"�5.      $
��Wrap=�5/      $��Center=�50      $	��Top=�51      $��10q�53      y�52      �� # Z $ isProfileListEmpty�   53      � 57   
   $��0��6   $��0��6     58      �� 59      $��* �6#   �� 5:      $��* �6#   �� 5;      $��* �6#   �� 5<      $��* �6#   .+�5@      �� $	��LOG��6   $��30(�6#     PrussianBlueColorBrush#��[ 61   $	��Top=�5A      $
��Left=�6,   $
��Bold"�5B      $��5q�6&   �� 5F      $��1��5G      $��Center=�5H      $��Center=�5I      $��25(�5J      $
��Bold"�5K      #��[ 5L      ��5F      �� *DropList.Count+5L      "   DropLogger.TotalValueControl  5P      $��2��6%   $��2��65   5Q      5R      5S      