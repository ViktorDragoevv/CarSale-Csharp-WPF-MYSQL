   M S B A M L   `   `   `  ����?  ;Bank, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BankBank  5   	       Bank.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Bank     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5         menuParentStyle �� 
TargetType �� Property �� Value  Menu.Static.Foreground �� Color  Menu.Static.Background  Menu.Static.Border  MenuItemStyle1 �� RelativeSource �� AncestorType  MenuItemControlTemplate1 �� Triggers	 P� Property
 P� Value �� 
ResourceId �� TypeInTargetAssembly �� 
TargetType ��Name J� SnapsToDevicePixels � ColumnDefinitions z� SharedSizeGroup ��Name m� Icon F�Name �� HeaderStringFormat �� ContentStringFormat ��Name J� Opacity m� InputGestureText �� Triggers �� 
TargetName ]� 
Conditions �� Property �� Value  MenuItemControlTemplate2 �Name  � AllowsTransparency! �� Padding" ��Name# �� ClearTypeHint$ ��Name% �� ElementName& ��Name-  'System.Windows.Input.KeyboardNavigation'   DirectionalNavigation( � IsSharedSizeScope)   TabNavigation* P� 
SourceName��%�  &	        &	 p     &	 �     &	 �     &	 �     7  7  7  7  &	 F    &	 {    �� 5      " m�60   .�5      ��  � ��
 �   �63   �� 5       � ��
 �����63   5      �� 5      $ White��6A   �� 5      $ Black��6A   �� 5      $ Transparent��6=   �� 5      " m�6/   .�5      ��  � �� 6C   �� *HorizontalContentAlignment+ �� " ���� 5       � �� 6A   �� *VerticalContentAlignment+ �� " ���� 5       � ��
 �   �63   �� 5       � ��
 ���� 64   �� 5       � ��
 �����63   �� 5       � ��$ 0q�68   �� 5       �@��PanningMode$
 Both=�6A   �� 5       �@��IsFlicksEnabled .  6?   �� 5        � ��# �  61    5!      P� 5"      	 �@m�Role$
 TopLevelHeader=�62   . �5#      ��  � ��
 ���� 6;   �� 5$       � ��
 ���� 6<   �� 5%       � ��8   6;   �� 5&       � �� 69   C� *�� $ TopLevelHeaderTemplateKey��" m�+�� 5'       � ��$	 6,0q�68   5(      P� 5)      	 �@m�Role$
 TopLevelItem=�62   . �5*      ��  � ��8  6;   �� 5+       � ��8  6<   �� 5,       � ��8  6;   �� 5-       � �� 69   C� *�� $ TopLevelItemTemplateKey��" m�+�� 5.       � ��$	 6,0q�68   5/      P� 50      	 �@m�Role$
 SubmenuHeader=�62   . �51      ��  � �� 69   C� *�� $ SubmenuHeaderTemplateKey��" m�+52      P� 53      	 �@J�IsMouseOver
 . . �54      ��  � ��
 �����6;   55      P� 56      	 �@J�IsKeyboardFocusWithin
 . . �57      ��  � �� �#0a99f36;   58      5:      �� 5;      " m�6C   .R�5<      �� $ templateRoot��6   #��z��63   #��z��6_   #��z��6�    . ._�5=      � $��-1q�6    5>      �� 5?   "   $��22��63   $ MenuItemIconColumnGroup��6A   $
��Auto �6k   �� 5@   "   $��13 �63   �� 5A   "   $��* �63   �� 5B   "   $��30 �63   �� 5C   "   $ MenuItemIGTColumnGroup��63   $
��Auto �6\   �� 5D   "   $��20 �63   .+�5F      �� $
 Icon��6/   #��z 6=   $
��Icon��6^   $��Center=�6s   $��16��6�   $��3q�6�   # z 6�   $��Center=�6�   $��16��6�   �� 5G      $ 
GlyphPanel��6%   ���	#FF26A0DA$��1q�6Q   ���	#3D26A0DA}�.  $��Center=�6�   $��22��6�   $��-1,0,0,0q�6�   $y�Hidden=�6�   $��Center=�6�   $��22��6�   ._�5H   "   F� $ Glyph��6'   T������� �O �`�G �ڊ � �D �ڊ �    �XO � � �g5 ���A  ] ������� @    р�� �O ���	#FF212121$��LeftToRight=�6�   $��11��6�   $��10��6�   5I      �� 5J      $ menuHeaderContainer��6/   #��z��6L   #��z��6   $��2��6�   # z 6�   $��Header��6�   $
��Left=�6  #��z��6  ��. # z 6]  $��Center=�6�  �� 5K      $ menuGestureText��6(   $��4��6A   #��z��6Q   $	 0.7Q�6t   #��z 6�   $��Center=�6�   5L      5M       5N      P� 5O      
 62   Z� 	 �@m�Icon. �5P      �� $
 Icon��6;    � y�$ 	Collapsed=�6M   5Q      P� 5R      	 �@m�	IsChecked
 . . �5S      �� $ 
GlyphPanel��6;    � y�$ Visible=�6S   �� 5T      $
 Icon��6;    � y�$ 	Collapsed=�6M   5U      P� 5V      	 �@m�IsHighlighted
 . . �5W      �� $ templateRoot��6;    � ��
 ��  �6U   5Y      P� 5Z      	 � {�
 .  . �5[      �� $ templateRoot��6G    � �� �	#FF7070706a   �� 5\      $ Glyph��65    � �� �	#FF7070706H   5]      ]� 5^       5_      �� 5`   "    �@m�IsHighlighted . 6E   �� 5a   "    � {� .  6A   ./�5c      �� $ templateRoot��6;    � �� �	#0A0000006U   �� 5d      $ templateRoot��6<    � �� �	#210000006V   5e      5g      �� 5h      " m�6C   .R�5i      �� $ templateRoot��6   #��z��63   #��z��6_   #��z��6�    . ._�5j      � $��Center=�6    5k      �� 5l   "   $
��Auto �63   �� 5m   "   $
��Auto �63   .+�5o      �� $
 Icon��6/   #��z 6=   $
��Icon��6^   $��Center=�6s   $��16��6�   $��3q�6�   # z 6�   $��Center=�6�   $��16��6�   F� 5p      $ 
GlyphPanel��6#   T������� �O �`�G �ڊ � �D �ڊ �    �XO � � �g5 ���A  ] ������� @    р�� �O #��z��6|   $��LeftToRight=�6�   $��3q�6�   $y�	Collapsed=�6�   $��Center=�6�   �� 5q      #��z��6/   #��z��6b   $��1��6�   # z 6�   $��Header��6�   #��z��6�   ��. # z 6%  � 5r      $ 
PART_Popup��6$     . |�.  #��� -�6�   $��Bottom=�6  ��6d   �� *IsSubmenuOpen+ �� *TemplatedParent+.��5s   "   �� $ SubMenuBorder��6)   ���	#FF999999$��1q�6X   ���	#FFF0F0F0$! 2q�6�   ._�5t   &   �� $" SubMenuScrollViewer��63   ��6P   C� *�� $ MenuScrollViewer��" �+.��5u   *   � $# Enabled=�6/   .+�5v   .   �� $
��Left=�65   $��0��6P   $	��Top=�6[   $��0��6s   .+�5w   2   �� $$ 
OpaqueRect��6<   ��6P   �� *
Background+$% SubMenuBorder����6�   �� *ActualHeight+$% SubMenuBorder����6�   �� *ActualWidth+$% SubMenuBorder��5x   /   �� 5y   .   ���	#FFD7D7D7$
��Left=�6I   $��29,2,0,2q�6d   $��1��6v   �� 5z   .   $& ItemsPresenter��6=   $' Cycle=�6U   ( . # z 6�   $) Cycle=�6�   5{   +   5|   '   5}   #   5~      5      5�       5�      P� 5�      "	 �@m�IsSuspendingPopupAnimation
 . . �5�      �� $ 
PART_Popup��6?    � ��$
 None=�6W   5�      P� 5�      
 62   Z� 	 �@m�Icon. �5�      �� $
 Icon��6;    � y�$ 	Collapsed=�6M   5�      P� 5�      	 �@m�	IsChecked
 . . �5�      �� $ 
GlyphPanel��6;    � y�$ Visible=�6S   �� 5�      $
 Icon��6;    � y�$ 	Collapsed=�6M   5�      P� 5�      	 �@m�IsHighlighted
 . . �5�      �� $ templateRoot��6;    � ��
 ��  �6U   5�      P� 5�      	 � {�
 .  . �5�      �� $ templateRoot��6G    � �� �	#FF7070706a   �� 5�      $ 
GlyphPanel��65    � �� �	#FF7070706M   5�      P� 5�      $* SubMenuScrollViewer��6>   	 � ��
 .  . �5�      �� $ 
OpaqueRect��6;    6S   �� *VerticalOffset+$% SubMenuScrollViewer�� �@��Top�� 5�      $ 
OpaqueRect��6<    6T   �� *HorizontalOffset+$% SubMenuScrollViewer�� �@��Left5�      5�      5�      .��5�      �� .+�5�      o� .@�5�      m� $��_File��6#   #��[  62   #���  6[   #���  6�   .@�5�      m� -   5        $
��_New��5�   '   65   m� 5�      $��_Save��6'   m� 5�      $��_Quit��6'   5�      m� 5�      $��_Edit��6#   #��[  62   #���  6\   #���  6�   .@�5�      m� $��_Copy��6'   m� 5�      $
��_Cut��6'   m� 5�      $��_Paste��6'   5�      5�      5�      5�      