   M S B A M L   `   `   `  ����E  ADropLogger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DropLogger
DropLogger  5          DropLogger.ProfileControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )coreclr-namespace:DropLogger     5        � 	Resources  5
       �� DataType$   DropLogger.AddProfileViewModel"   DropLogger.AddProfileControl��%G   (��       5      *, +)�� 6
   "  6   .R�5        5      5      .��5      �    LightGrayColorBrush#��[  6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��PROFILE��6   $��30(�6#     PrussianBlueColorBrush#��[ 61   $��Center=�5      $
��Left=�5      $
��Bold"�5       $��5q�6&   �� 5$   
   -   5         ��Name$ 	AddButton��5%      $��1��5$      $	��ADD��5&      $��30��5'      $��70��5(      $��5q�5)      $
��Left=�5*      $��Center=�5+        RemoveButton#��[ 5,      
 � Tag$ AddProfileControl��5.      ��5-      �� *AddProfileCommand+5.      �� 53   
   $��2��54      $��Right=�55      $��Center=�56      $��20(�57      $��10q�58        GunMetalColorBrush#��[ 59      ��53      �� !   DropLogger.ProfileViewModel   Profile �� Source# Z  �� Path$ selectedprofilename�	 �� FallbackValue$	 Fallback��59      � 5=   
   $��1��6   $��3��6    5>      �� 5?      $��* �6#   �� 5@      $��* �6#   �� 5A      $��* �6#   �� 5B      $��* �6#   �� 5C      $
��0.5* �6#    5F      �� 5G      $��30 �6    �� 5H      $��* �6    .+�5K      �� #��[ 6   $��0��5L      $��5��6%   $��2q�5M      #��[ 5N      �� 5R      $
��Name��6   
�������$
��Bold"�5S      $��0��5T      $��5q�6(   
������ $	��Top=�5V      �� 5Z      $��Template��6   
�������$
��Bold"�5[      $��1��5\      $��5q�6(   
������ $	��Top=�5^      �� 5b      $��Kills Count��6   
�������$
��Bold"�5c      $��2��5d      $��5q�6(   
������ $	��Top=�5f      �� 5j      $��Value��6   
�������$
��Bold"�5k      $��3��5l      $��5q�6(   
������ $	��Top=�5n      �� 5r      
�������$
��Bold"�5s      $��4��5t      $��5q�6(   
������ $	��Top=�5v      '   !DropLogger.ProfileItemListControl  5y      $��1��6*   $��5��67   5z      �� 5|   
   $��0��6   $��0��6(   $��3��68   $��2��6L   ��5}      �� *CurrentView+$	 FALLBACK��5      5�      