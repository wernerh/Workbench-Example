   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    Workbench Example0   *Workbench_Example.View.Dialogs.OptionsView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	     � Title$  Theme Options��5   	   $	��600��5   	    � SizeToContent$ Height=�5   	    � 
ResizeMode$ NoResize=�5   	      AccentColorBrush(   "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   5	   	      ShowIconOnTitleBar .    SaveWindowPosition .    WindowTransitionsEnabled .      NonActiveWindowTitleBrush
 ����� J� InputBindings 5      �� 5   
   	 �� Gesture$	 Enter��63   
 �� Command
 6   �� *	OkCommand+63   �� 5   
   $		 ESC��67   
 6   �� *CancelCommand+67   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��Application Theme��6    .��5      �  � ColumnDefinitions 5       �� 5!      $
��Auto �6'   �� 5"      $��* �6'   �� 5#      $
��Auto �6'   �� 5$      $��* �6'    5&      �� 5'      $
��Auto �6$   �� 5(      $
��Auto �6$   .+�5,      �� $��0��6   $��0��6(   $��5q�66   $	��115��6A   $��Application Theme :��6P   �� 5-      $��1��6   $��0��6+   $��5q�68   $	��115��6C   $��Center=�6�   ��6R   �� *ThemeOptions+ �� SelectedItem 6w   �� *Theme+6�   �� 50      $��2��6   $��0��6(   $��5q�66   $	��115��6A   $��Application Accent :��6P   �� 51      $��3��6   $��0��6+   $��5q�68   $	��115��6C   $��Center=�6�   ��6R   �� *ThemeAccents+ 6w   �� *ThemeAccent+6�   �� 54      $��0��6   $��1��6(   $��5q�66   $	��115��6A   $��Workbench Theme :��6P   �� 55      $��1��6   $��1��6+   $��5q�68   $	��115��6C   $��Center=�6�   ��6R   �� *WorkBenchThemes+ 6z   �� *WorkBenchTheme+6�   56      57      �� 5:   
   $��1��6   $��General��6    .��5;      �  5<      �� 5=      $
��Auto �6'   �� 5>      $��* �6'    5@      �� 5A      $
��Auto �6$   .+�5E      �� $��0��6   $��0��6(   $��5q�66   $	��115��6A   $��Show start page :��6P    � ToolTip$! Show start page on start up��6l   �� 5F      $��1��6   $��0��6+   $��5q�68   $	��115��6C   $��Center=�6v   $! Show start page on start up��6�    d� 	IsChecked 6R   �� *ShowStartPage+6�   5G      5H      �� 5K   
   $��2��6   $��Right=�6"   $��10q�6>   $��Center=�6J    �� Orientation$ 
Horizontal=�6e   .+�5L      �� $��50��6   $��3q�6$   $��_Default��6/   ��6B   �� *DefaultCommand+�� 5M      $��50��6   $��3q�6$   $��_Preview��6/   ��6B   �� *PreviewCommand+�� 5N      $��50��6   $��3q�6$   $	��_OK��6/   ��6=   �� *	OkCommand+�� 5O      $��50��6   $��3q�6$   $��_Cancel��6/   ��6A   �� *CancelCommand+5P      5Q      5R      