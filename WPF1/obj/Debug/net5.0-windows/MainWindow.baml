   M S B A M L   `   `   `  ����?  ;WPF1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPF1WPF1  5   	   clr-namespace:WPF1WPF1  5   	       WPF1.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:WPF1     5   	   !ucclr-namespace:WPF1     5   	     � WindowStyle$
  None=�5	   	    � AllowsTransparency$
 true��5
   	   
������ $��10q�5   	    � Title$ 
MainWindow��5   	   $	��450��6   $	��800��6)   .��5      �� ���#272537 �� CornerRadius$ 20��6"   ._�5   
   �  � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��3* �6#   �� 5      $��0.45* �6#    � RowDefinitions 5      �� 5      $��* �6    6-   �� 5      $��8* �6    6.   .+�5      �� -   5        $��	LeftPanel��5      ���#23222a.+�5      �� $��DemiBold"�6   $��22(�62   $��Center=�6@   $��Center=�5      
������� �� Padding$ 10q�6L   
Test app5      5      �� 5      -   5        $��LeftMenu��5      $��1��6)   ���#23222a5!      �� 5"      -   5        $��RightTopPanel��5"      $��1��6.   ���#23222a5#   .   �� 5$      $��2��6   ���#23222a.+�5%         WPF1.MinMaxClose  5&      �� 5'      -   5        $��rightMainPanel��5'   J   $��1��6   $��1��6)   $��2��66   .+�5(      �� $	��250��6   $��Right=�6)   .+�5)      �� 
������� �� Target 6   ��  �� ElementName$ txtName��.��5*      �� 	 �� Orientation$	 
Horizontal=�6%   .+�5+      �� $F��@http://cdn1.iconfinder.com/data/icons/fatcow/16/bullet_green.png��6$   �� 5,      $��_Name:��6)   
 �� 
FontWeight$
 DemiBold"�67   5-      5.      �� 5/      -   5        $��txtName��5/       � ToolTip$ 	You name:��6-   �� 50      
������� 6   �� $ txtMail��.��51      �� $	 
Horizontal=�6%   .+�52      �� $E��?http://cdn1.iconfinder.com/data/icons/fatcow/16/bullet_blue.png��6$   �� 53      $��_Mail:��6)   $
 DemiBold"�67   54      55      �� 56      -   5        $��txtMail��56      $ your Email:��6-   57      58      59      5:      5;      