   M S B A M L   `   `   `  ����E  ADropLogger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DropLogger
DropLogger  5      "    DropLogger.AddProfileControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )coreclr-namespace:DropLogger     5        � 	Resources  5
       �� DataType!   DropLogger.ProfileViewModel   DropLogger.ProfileControl��%G   (��       5      *, +)�� 6
   "  6   .R�5        5      5      .��5      �    LightGrayColorBrush#��[  6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��30 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6   �� 5      $��* �6   .+�5!   
   �� $��PROFILE��6   $��30(�6#     PrussianBlueColorBrush#��[ 61   $��Center=�5"      $
��Left=�5#      $
��Bold"�5$      $��5q�6&   �� 5(   
   -   5         ��Name$ 	AddButton��5)      $��1��5(      $
��BACK��5*      $��30��5+      $��70��5,      $��5q�5-      $
��Left=�5.      $��Center=�5/        RemoveButton#��[ 50      
 � Tag$ AddProfileControl��52      ��51      �� *GoBackCommand+52      �� 56   
   $��2��6   $
��SAVE��57      #��[ 59      $��30��5:      $��70��6   $��5 5 15 5q�5;      $��Right=�5<      ��58      �� *SaveProfileCommand+5<      �� 5@   
   $��Name the log��6   $��Center=�5A      $��1��5B      $��20(�5C      $
��Bold"�5D      $��5q�5E      �� 5I   
   $��2��6   $��0��5J      $��5q�5K        TextBoxStyle#��[ 5L       �� 	MaxLength$ 10��5N      ��5M      �� *	logname+5N      �� 5R   
   $��Select Template��6   $��3��5S      $��0��5T      $��2��5U      $��5q�5V      $��20(�5W      $
��Bold"�5X      $��Center=�5Y      �� 5]   
   $��4��6   $��5q�5^      ��5_      �� *	ComboList+ �� Mode$ TwoWay=� �� SelectedValue 5`      �� *SelectedItem+��5b      �� 5c      .R�5d      �� ��6    �� *type+5e      5g      �� 5i   
   $��0��6   $��0��6(   $��3��68   $��6��6L   ��5j      �� *CurrentView+5l      5m      