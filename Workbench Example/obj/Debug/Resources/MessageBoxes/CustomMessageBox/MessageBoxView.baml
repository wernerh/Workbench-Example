   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    Workbench ExampleN   HWorkbench_Example.Resources.MessageBoxes.CustomMessageBox.MessageBoxView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	      AccentColorBrush(   "MahApps.Metro.Controls.MetroWindow    	GlowBrush#  �   5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	      WindowTransitionsEnabled .  $	��200��5
   	   $	��500��6       NonActiveWindowTitleBrush
 ����� � Title 5   	   �� *DialogTitle+ � 	Resources 5        	BoolToVis��%   &	       �� 5   
   6'   5       J� InputBindings 5      �� 5   
    �� Gesture$ Enter��66   	 �� Command	 6   �� *OkYesCommand+66   �� 5   
   $	 Esc��67   	 6   �� *CancelCommand+67   .��5      � 
 � RowDefinitions
 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��25q�6;   $��Center=�6G   $��Center=�6b   .+�5       �� $
��Auto=�6   $
��Auto=�6>   .��5!      �� $	��400��65   $��5q�6D   $
��Wrap=�6O   ��6   �� *	Message+6O   5"      5#      �� 5&   
   $��1��6   $��Right=�6"   $��0,0,5,5q�6>   $��Center=�6O   $ 
Horizontal=�6j   .+�5'      �� $��50��6   $��3q�6$   $
��_Yes��6/   y�6>   �� *IsYesButtonVisible+ �� 	Converter# [ ��6�   �� *
YesCommand+�� 5(      $��50��6   $��3q�6$   $	��_No��6/   y�6=   �� *IsNoButtonVisible+# [ ��6�   �� *	NoCommand+�� 5)      $��50��6   $��3q�6$   $	��_OK��6/   y�6=   �� *IsOkButtonVisible+# [ ��6�   �� *	OkCommand+�� 5*      $��50��6   $��3q�6$   $��_Cancel��6/   y�6A   �� *IsCancelButtonVisible+# [ ��6�   �� *CancelCommand+5+      5,      5-      