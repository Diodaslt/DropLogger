   M S B A M L   `   `   `  ����E  ADropLogger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DropLogger
DropLogger  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� 
TargetType   	Hoverless �� Property �� Value'   !System.Windows.Shell.WindowChrome �� 
TargetType �� Padding  SystemButton �� BasedOn �� Triggers P� Property P� Value  RemoveButton  RemoveItemButton  MenuItemButton	 ��Name
 J� SnapsToDevicePixels �� Color'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard �� 
TargetName �� TargetProperty8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime �� Value  ProfileSelectionButton �Name � ColumnDefinitions � RowDefinitions �� 	MaxLength �� UpdateSourceTrigger �� Triggers �� 
TargetName �� CornerRadius
 � Tag!   DropLogger.ProfileViewModel   Profile �� Source �� Path�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      !coreclr-namespace:DropLogger  5      %�  &	        &	 \    7   &	 �    7   &	 8    7   &	 �    7   &	 �	    7  �� 5      "  ��6   .�5   
   ��  � ��
 ���� 6'   �� 5	   
    � ��$ 0q�6,   �� 5
   
     �@  IsHitTestVisibleInChrome . 6B   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      �� # z��6   #��z��6A   ._�5      �� $��Center=�6+   $��Center=�6F   5      5      5      5      �� 5      "  ��6!   8   .�5   
   ��  � ��
 �����6'   �� 5   
    � �� �#0519246'    5   
   P� 5       �@J�IsMouseOver . . �5      ��  � �� �#0B39546/   5      P� 5       �@J�IsMouseCaptured . . �5      ��  � �� �#0519246/   5       5"      �� 5%      "  ��6!   8   .�5&   
   ��  � ��
 �����6'   �� 5'   
    � �� �#0727366'   �� 5(   
    � ��$
 Bold"�6'   �� 5)   
    � ��
 �����6'    5*   
   P� 5+       �@J�IsMouseOver . . �5,      ��  � �� �#0519246/   5-      P� 5.       �@J�IsMouseCaptured . . �5/      ��  � �� �#0727366/   50      52      �� 55      "  ��6%   8   .�56   
   ��  � ��
 ���� 6'   �� 57   
    � ��$
 Bold"�6'   �� 58   
    � �� �#0519246'    59   
   P� 5:       �@J�IsMouseOver . . �5;      ��  � �� �#0727366/   5<      P� 5=       �@J�IsMouseCaptured . . �5>      ��  � ��
 �����6/   5?      5A      �� 5D      "  ��6#   8   .�5E   
   ��  �@J�SnapsToDevicePixels . 60   �� 5F   
    �@�OverridesDefaultStyle . 62   �� 5G   
    � ��
 �����6'   �� 5H   
    � ��$ 5q�6,   �� 5I   
    � ��
 �  ��6(   �� 5J   
    � ��$ 30(�6%   �� 5K   
    � �� 5L      �� 5M      " ��6"   .R�5N      �� $	 Border��6   $ 0q�5O      
������ $��5 0 0 0q�5Q      $��-1 0 0 0q�5R      
 . ��5T      �� 5U      $ Transparent��6.    5W        5X      SelectionStates��. 5Y   "     	Unfocused��6.     5Z   "   	MouseOver��. 5[   &   �� .��5\   *   �� $ Border��6G   $w q(Panel.Background).                                                                       (SolidColorBrush.Color)�5]   G   .g�5_   .     $ 0��6B   $ #072736��5`   B   5a   +   �� 5b   *   $ Border��6G   $ BorderBrush.Color�5c   G   .g�5d   .     $ 0��6B   $ #051924��5e   B   5f   +   5g   '   5h   #   5i      ._�5k      �� $
��Left=�6+   $��Center=�6F   5l      5m      5o      5p      �� 5s      "  ��6   .�5t   
   ��  � �� 5u      �� 5v      " ��6"   .R�5w      � $ profilebutton��6   ���#C3C3C3 5x      �� 5y      $��* �6/   �� 5z      $��* �6/   �� 5{      $��* �6/   �� 5|      $��* �6/   �� 5}      $
��0.5* �6/    5�      �� 5�      $��30 �6,   �� 5�      $��* �6,   .+�5�      �� 
������ $��0��5�   !   $��5��61   $��2 0 2 2q�5�   !   ���#0727365�   !   �� 5�      .��6"   ��5�      �� 5�   "   "  ��6(   .�5�   &   ��  � �� 5�   *   �� 5�   .   " ��6>   .R�5�   2   �� $	��btn��5�   :   ���#051924$��0��5�   :   $��5q�6J   $
��Bold"�5�   :   
������ $	��Top=�5�   :   $��0q�5�   :   $ 10��5�   :   ��5�   :   �� *	logname+$ PropertyChanged=�5�   :    5�   2   P� 5�   6    �@J�IsMouseOver . . �5�   :   �� $	 btn��6A    � �� �#C3C3C36h   5�   7   5�   /   5�   '   5�   #   .��5�   -   5�      �� 5�      ���#051924$��1��5�   $   $��5q�64   $
��Bold"�5�   $   
������ $	��Top=�5�   $   ��5�   $   �� *type+5�   $   �� 5�      ���#051924$��2��5�   $   $��5q�64   $
��Bold"�5�   $   
������ $	��Top=�5�   $   ��5�   $   �� *	killCount+5�   $   �� 5�      ���#051924$��3��5�   $   $��5q�64   $
��Bold"�5�   $   
������ $	��Top=�5�   $   ��5�   $   �� *	tripValue+5�   $   �� 5�      ���#072736$��1q�5�   !   $ 2��5�   !   $��4��5�   !   $��5q�5�   !   ._�5�      �� 8��  $��DELETE��5�   %    5�   %   �� *id+��5�   %   �� # Z $ RemoveProfileCommand���5�   %   �� *id+5�       5�        5�      CommonStates��. 5�   "     	MouseOver��. 5�   "   �� .��5�   &   �� $ profilebutton��6C   $w q(Panel.Background).                                                                       (SolidColorBrush.Color)�5�   G   .g�5�   *     $ 0��6>   $ #B6C9D2��5�   >   5�   '   5�   #   5�        5�   "   
Normal��. 5�   &   �� .��5�   *   �� $ profilebutton��6G   $w q(Panel.Background).                                                                       (SolidColorBrush.Color)�5�   G   .g�5�   .     $ 0��6B   $ Transparent��5�   B   5�   +   5�   '   5�   #     5�   "   Focused��. 5�   &   �� .��5�   *   �� $ profilebutton��6G   $w q(Panel.Background).                                                                       (SolidColorBrush.Color)�5�   G   .g�5�   .     $ 0��6B   $ #B6C9D2��5�   B   5�   +   5�   '   5�   #   5�      5�      5�      5�      5�      5�      