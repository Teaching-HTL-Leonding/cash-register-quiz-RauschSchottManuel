   M S B A M L   `   `   `  ����N  JCashRegister.UICore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CashRegister.UICoreCashRegister.UICore  5   	   $    CashRegister.UICore.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:CashRegister.UICore     5   	     � Title$  Cash Register Exercise��5   	   $	��700��6(   $
��1000��65    � 	Resources 5         TotalSum �� 
TargetType �� Property �� Value  TotalSumText �� BasedOn 
 Basket  CheckoutButton  ProductButton��%�  &	        &	 �     7   &	     &	 �    &	 .    �� 5   
   " ��6!   .�5      ��  � ��$ Lucida Console)�6+   �� 5       � ��$ 50(�6)   �� 5       � ��$ Right=�64   5      �� 5   
   " ��6%   8   .�5      ��  � ��$ 20(�6)   �� 5       � ��$ 0,5,0,0q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$ Lucida Console)�6+   �� 5       � ��$ 10(�6)   �� 5       � ��$ 0,0,0,5q�6'   5      �� 5    
   " ��6'   .�5!      ��  � ��$ Lucida Console)�6+   �� 5"       � ��$ 50(�6)   5#      �� 5%   
   " ��6&   .�5&      ��  � ��$	 150��6&   �� 5'       � ��$	 100��6'   �� 5(       � ��$ 5,5,0,0q�6'   5)      5*      .��5+      �  � ColumnDefinitions 5,   
   �� 5.      $��2* �6   �� 5/      $��* �6   .+�54   
   �� $
��Auto=�6   .��58      �� $��
10,10,5,10q�6   ��6/   ��  �� Path$ Products���59      �� 5<      .R�5>      �� -   5        #��[ 5>   !   ��6T   �� $ ProductName�5?   !   5@      ��5D      �� 5E      .R�5F      � 5G      5I      5J      � 5L   
   $��1��6   $��
5,10,10,10q�6    � RowDefinitions 5M      �� 5N      $��* �6    �� 5P      $
��Auto �6    �� 5Q      $
��Auto �6    �� 5R      $	��100 �6    .+�5V      &   System.Windows.Controls.DataGrid  	   AutoGenerateColumns$	 False��6;   
   
IsReadOnly$

 True��6W      CanUserAddRows$ False��5W      ��5V      �� $ Basket�   Columns 5X      0  *System.Windows.Controls.DataGridTextColumn  5Y      ,  &System.Windows.Controls.DataGridColumn   Header$ Produkt��6)      MinWidth$	 200Q�6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� $ ProductName�6_     5Z      $ Menge��6)    68   �� $ Amount�  5[      $ Preis��6)    68   �� $ 
TotalPrice�5]      �� 5^      $��1��6   $��Gesamtsumme:��6%   #��[ 69   �� 5_      $��2��6   #��[  6D   ��6%   �� $ TotalSum�6D   �� 5`      -   5        $��4��5`      #��[ 6"   .��6i   
Checkout6s   5a      5b      5c      