   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    Workbench Example.   (Workbench_Example.View.Dialogs.AboutView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	     � Title$  ABOUT��5   	    � 
ResizeMode$ NoResize=�5   	   $
��Auto��5   	   $
��Auto��6    � SizeToContent$ WidthAndHeight=�5   	      AccentColorBrush(   "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   5	   	      ShowIconOnTitleBar .    SaveWindowPosition .    WindowTransitionsEnabled .      NonActiveWindowTitleBrush
 ����� J� InputBindings 5      �� 5   
   	 �� Gesture$	 Enter��66   
 �� Command
 6   �� *CloseCommand+66   �� 5   
   $		 ESC��66   
 6   �� *CloseCommand+66   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   � $��1��6   .+�5       �  � ColumnDefinitions 5!      �� 5"      $
��Auto �6'   �� 5#      $��* �6'   �� 5$      $
��Auto �6'   �� 5%      $��* �6'   .+�5(      �� -   5         ��Name$ lbl_AplicationNameLabel��5(      $��0��69   $��0��6F   $��3q�6V   $��Aplication Name:��6a   �� 5)      -   5        $ lbl_AplicatationName��5)      $��0��66   $��1��6C   $��3q�6S   $��Workbench Example��6^   �� 5+      -   5        $  lbl_AplicationVersionLabel��5+      $��0��6<   $��2��6I   $��3q�6Y   $��Version:��6d   �� 5,      -   5        $ lbl_AplicationVersion��5,      $��0��67   $��3��6D   $��3q�6T   ��6_   �� *	Version+5-      5.      �� 51   
   -   5         ��Name$ tbk_AplicationDescription��51      $��2��67   $
��Wrap=�6D   $��8q�6X   '%Developed with visual studio 2013 by �� 52   3   -   5        $*��$https://www.linkedin.com/in/whurter/?�52   =   .�6�   Werner Hurter.6�   53      �� 56   
   -   5         ��Name$ btn_AboutOk��56      $��3��6&   $	��_OK��63   $��10q�6A   $��50��6M   $��Center=�6}   $��Center=�6�   ��6[   �� *CloseCommand+6�   57      58      