   M S B A M L   `   `   `  ����?  ;Bank, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BankBank  5   	       Bank.MainWin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Bank     5   	   -   5          � Title$  MainWin��5   	   $	��600��6   $
��1400��6&    � WindowStyle$
 None=�69    � 
ResizeMode$ NoResize=�6L    � 	Resources 5
         btv  	VsMenuTop �� 
TargetType m� IsSubmenuOpen � AllowsTransparency K� IsItemsHost �� 
TargetType	 �� Triggers
 P� Property P� Value �� Property �� Value  	VsMenuSub ]�Name �� RelativeSource �� Triggers �� 
TargetName��%q  &	        &	      &	 �    'o� �    �� 5   
   6'   �� 5   
   " m�6,   .R�5      �� $
��15px(�6   $��40��63   .+�5      �� #��z��6   $��5q�6;   
�������6F   � 5      #��z 6    . |�.  .��5      �� $��1q�6   
�������
���  ��._�5      ��  . 6%   5      5      ��5      �� 5      " ��6   	 5      P� 5      
 �@J�IsMouseOver . . �5   "   ��  � ��
 �����6?   5      5       5"      5#      �� 5&   
   " m�6,   .R�5'      ]� $ panel��62   $
��15px(�6   .+�5)      �� $��20��6a   $	��5,0q�6l   ��6   �� *Icon+ �� *TemplatedParent+6l   �� 5*      #��z��6   
���   �$��0,5,5,5q�6N   � 5.      #��z 6    . |�.  $��Right=�6m   .��5/      �� $��1q�6   
�������
�����p�._�51      ��  . 6%   52      53      54       55      P� 56      
 �@m�IsHighlighted . . �57      �� $ panel��63    � ��
 ���p�6F   58      5:      �� 5=   
   " o�6   .�5@      ��  � ��
 ���w�6+   �� 5B       � ��$
 40px��6'   5C      5E      .��5H      �� .+�5I   
   o�  o� 
IsMainMenu . .@�5K      m� $��	_Меню��6   #��[ 6&   .@�5L      m� -   5        $F��@_Изход от администраторския акаунт��5L      #��[ 6H    m� Icon$ images/log-out.png��6n   6�   m� 5M      -   5        $/��)_Изход от приложението��5M      #��[ 6<   $ images/log-out.png��6b   6|   5N      m� 5O      $��_Добави��6   #��[ 6(   .@�5P      m� -   5        $F��@_Добави/Редактирай/Изтрий Оператор��5P      #��[ 6H   $ images/nurse.png��6n   6�   m� 5Q      -   5        $M��G_Добави нова компания/нов цвят/нов клас��5Q      #��[ 6N   $ images/test-tubes.png��6t   6�   5S      5T       � 5U   
   -   5        $��adminMainFrame��5U      $	��759��6&     � NavigationUIVisibility$ Hidden=�63   5W      5Y      