   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    Workbench Example\   VWorkbench_Example.Resources.MessageBoxes.CustomExceptionMessageBox.ExceptionMessageBox   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	      AccentColorBrush(   "MahApps.Metro.Controls.MetroWindow    	GlowBrush#  �   5   	    � 
ResizeMode$ NoResize=�5   	      WindowTransitionsEnabled .   � WindowStartupLocation$ CenterScreen=�5
   	    � SizeToContent$ Height=�5   	   $	��500��6        NonActiveWindowTitleBrush
 ����� � Title 5   	   �� *DialogTitle+ � DataContext 5   	   ��  �� RelativeSource �� *Self+	 J� InputBindings	 5      �� 5   
   
 �� Gesture$
 Enter��63    �� Command 6   �� *	OkCommand+63   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��2��6"    �� Orientation$ 
Horizontal=�66   $��50,40q�6O   .+�5       �� $��25��6-   $��25��69   $
��Fill=�6D   ��6   �� *Image+6D   �� 5!      $	��400��63   $��5q�6B    �� Padding$ 10q�6M   $
��Wrap=�6Z   ��6   �� *	BasicInfo+6Z   5"      �� 5%   
   $��1��6   $��2��6"   $
��10,5q�66   $��Right=�6D   $��Center=�6`   $ 
Horizontal=�6{   .+�5&      �� -   5        $��btn_Ok��5&      $��50��6#   $	��_OK��61   ��6?   �� *	OkCommand+5'      9� 5*   
   $��Advanced Information��6   $��2��61   $��2��6>   $��5q�6R   .��5+      � $
��Auto��6    5,      �� 5-      $
��Auto �6'   �� 5.      $��* �6'    50      �� 51      $
��Auto �6$   �� 52      $
��Auto �6$   .+�54      R� -   5        $��trv_AdvancedInfo��54      $��0��63   $��0��6@   $��10q�6P   $��
10,5,10,10q�6\   6q   �� 55      $��0��6   $��1��6'   $��10q�67    �� TextWrapping$
 Wrap=�6C    �� 
IsReadOnly . ��6i   �� *AdvancedInfo+�� 56      $��1��6   $��2��6*   $
��10,5q�6>   $��Right=�6L   $��Center=�6h   $ 
Horizontal=�6�   .+�57      �� -   5        $��btn_Save��57      $��50��6-   $��Save to file��6;   6R   58      59      5:      5;      5<      