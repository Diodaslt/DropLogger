   M S B A M L   `   `   `  ����E  ADropLogger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DropLogger
DropLogger  5      #    DropLogger.DropLogItemControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )coreclr-namespace:DropLogger     5      .��5	      ��    RichBlackFOGRAColorBrush#��[  6   $��1q�6E     �� CornerRadius$  5��6Y   
�������._�5
   
   � 
�������$��2q�6"    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   �� -   5         ��Name$ 
ItemNumber��5      $��0��5      $
��auto��5      $��Center=�5      $��Center=�5      $��12(�5      $
��Bold"�5      $��5 0 0 0q�5      ��5      �� *id+5      �� 5!   
   $��1��6   $��NoWrap=�5#      $
��Left=�5$      $��Center=�5%      $��12(�5&      $
��Bold"�5'      $��10 0 0 0q�5(      ��5"      �� *
itemName+5(      �� 5,   
   -   5         ��Name$ RemoveItemButton��5-      $��2��5,      $��X��5.      $��20(�5/      $
��Bold"�50      $��Center=�51      $��Center=�52        RemoveItemButton#��[ 53      ��54      �� !   DropLogger.ProfileViewModel   Profile �� Source# Z  �� Path$ RemoveItemCommand���55      �� *id+ � Triggers 58   
   :� 59       :� RoutedEvent$ Button.Loaded��6   .[�5:      �� .��5;      �� .��5<      W� 	 �� 
TargetName$	 RemoveItemButton��5=      
 �� TargetProperty$
 Opacity�5>       W� From$ 0X�5?      	 W� To$ 0X�6%    g� Duration$ 0:0:1D�6,    g� AutoReverse . 6=   5A      5B      5C      :� 5D      $ Button.MouseEnter��6   .[�5E      �� .��5F      �� .��5G      W� $	 RemoveItemButton��5H      $
 Opacity�5I      $ 0X�5J      $ 1X�6%   $ 0:0:1D�6,   5L      5M      5N      :� 5O      $ Button.MouseLeave��6   .[�5P      �� .��5Q      �� .��5R      W� $	 RemoveItemButton��5S      $
 Opacity�5T      $ 1X�5U      $ 0X�6%   $ 0:0:1D�6,   5W      5X      5Y      5[      5\      5]      