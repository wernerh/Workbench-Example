   M S B A M L   `   `   `  ����L  HWorkbench Example, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Workbench_Example.ConvertersWorkbench_Example.Converters  5   	   H DMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	   Q-clr-namespace:Workbench_Example.View.BehaviorWorkbench_Example.View.Behavior  5   	   ?$clr-namespace:Workbench_Example.ViewWorkbench_Example.View  5	   	   I)clr-namespace:Workbench_Example.View.PaneWorkbench_Example.View.Pane  5
   	   '    !Workbench_Example.View.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   m iXceed.Wpf.AvalonDock.Themes.Expression, Version=2.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4i eXceed.Wpf.AvalonDock.Themes.VS2010, Version=2.6.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4g cXceed.Wpf.AvalonDock.Themes.Aero, Version=2.6.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4h	 dXceed.Wpf.AvalonDock.Themes.Metro, Version=2.6.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4[
 WXceed.Wpf.AvalonDock, Version=2.6.1.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4E
avalonDock,http://schemas.xceed.com/wpf/xaml/avalondock    	 
 5   	   ?dock,http://schemas.xceed.com/wpf/xaml/avalondock    	 
 5   	   C
converters*clr-namespace:Workbench_Example.Converters    	 
 5   	   Rcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro    	 
 5   	   Dbehavior-clr-namespace:Workbench_Example.View.Behavior    	 
 5   	   8views$clr-namespace:Workbench_Example.View    	 
 5	   	   <pane)clr-namespace:Workbench_Example.View.Pane    	 
 5
   	   -   5        $	��600��5   	   $	��800��6   (  "MahApps.Metro.Controls.MetroWindow    ShowIconOnTitleBar  .    SaveWindowPosition .    AccentColorBrush   	GlowBrush# �   5   	    � Title 5   	   �� *DialogTitle+ J� InputBindings 5      �� 5   
    �� Gesture$ CTRL+O��6=    �� Command 6   �� *ThemeOptionsCommand+6=    � 	Resources 5      :   4Workbench_Example.Converters.ActiveDocumentConverter  ActiveDocumentConverter? 
 9Xceed.Wpf.AvalonDock.Converters.BoolToVisibilityConverter  BoolToVisibilityConverter��%:   &	       &	        5   
   6-     5   
   6/   5      .��5      �  � RowDefinitions 5   
   �� 5       $
��Auto �6   �� 5!      $��* �6   �� 5"      $
��Auto �6   .+�5&   
   ]� $��0��6   .+�5'      o� .@�5)      m� $��_File��6   .@�5*      m� $��E_xit��6   	 m� Command	 6.   �� *ExitCommand+5+      m� 5-      $��_View��6   .@�5.      m� $��St_art Page��6   	 64   �� *ViewStartPageCommand+5/      m� 51      $��_Tools��6   .@�52      m� $��	_Tool One��6   
 m� IsCheckable
 .  m� 	IsChecked 62   �� *ToolOne.IsVisible+ �� Mode$ TwoWay=�6g   m� 53      $��	T_ool Two��6   
 .  62   �� *ToolTwo.IsVisible+$ TwoWay=�6g   m� 54      $��_Options...��6    m� InputGestureText$ Ctrl+O��6\   	 64   �� *ThemeOptionsCommand+6\   55      m� 57      $��_Help��6   .@�58      m� $��_About��6   	 6/   �� *AboutCommand+59      5:      5;      ) 
 #Xceed.Wpf.AvalonDock.DockingManager  5>   
   -   5          Name$ DockingManager��5>   $   $��1��5?   $      Theme 5@   $   �� *AvalonDockTheme+   AnchorablesSource 5A   $   �� *Tools+   DocumentsSource 5B   $   �� *	Documents+   ActiveContent 5C   $   �� *ActiveDocument+$ TwoWay=� �� 	Converter# [ @   :Workbench_Example.View.Behavior.AvalonDockLayoutSerializer   LoadLayoutCommand 5E   $   �� *Layout.LoadLayoutCommand+   SaveLayoutCommand 5F   $   �� *Layout.SaveLayoutCommand+ 5I      1 
 +Xceed.Wpf.AvalonDock.Controls.ContextMenuEx �� 
TargetType �� BasedOn��%0   '        7���� 5J      "  6   8   6G   5K         AnchorableContextMenu 5N      �� 5O      .@�5P      m� $��Float��6   	 6.   ��  �� Path$ FloatCommand�m� 5Q      $
��Dock��6   	 6-   �� $ DockCommand�m� 5R      $��	Auto Hide��6   	 62   �� $ AutoHideCommand�m� 5S      $
��Hide��6   	 6-   �� $ HideCommand�m� 5T      $��Close��6   	 6.   �� $ CloseCommand�5U      !   LayoutItemTemplateSelector 5Y      6   0Workbench_Example.View.Pane.PaneTemplateSelector  5Z         StartPageTemplate 5\      �� 5]      .R�5^      *   $Workbench_Example.View.StartPageView  5_         ToolOneTemplate 5b      �� 5c      5e         ToolTwoTemplate 5h      �� 5i      5k      5m      '    LayoutItemContainerStyleSelector 5q      3	   -Workbench_Example.View.Pane.PaneStyleSelector	  5r       	  StartPageStyle 5t      �� 5u      6
 
 0Xceed.Wpf.AvalonDock.Controls.LayoutDocumentItem" 
 6    .�5v      �� . 
 (Xceed.Wpf.AvalonDock.Controls.LayoutItem  �� Property  �@ Title! �� Value! 66   �� *
Model.Name+�� 5w        �@ 	ContentId! 6:   �� *Model.ContentID+�� 5x        �@ IsActive! 69   �� *Model.IsActive+5y      " 	  ToolOneStyle" 5|      �� 5}      "  6    .�5~      ��   �@ Title! 66   �� *Model.Title+�� 5        � y�! 6;   �� *Model.IsVisible+$ TwoWay=�# [   System.Windows.Visibility#   Hidden$ �� ConverterParameter#$ Z# �� 5�        �@ 	ContentId! 6:   �� *Model.ContentID+5�      % 	  ToolTwoStyle% 5�      �� 5�      "  6    .�5�      ��   �@ Title! 66   �� *Model.Title+�� 5�        � y�! 6;   �� *Model.IsVisible+$ TwoWay=�# [ #$ Z# �� 5�        �@ 	ContentId! 6:   �� *Model.ContentID+5�      5�      &   LayoutUpdateStrategy& 5�      3   -Workbench_Example.View.Pane.LayoutInitializer  5�      '   Layout.' 5�      , 
 &Xceed.Wpf.AvalonDock.Layout.LayoutRoot  (   	RootPanel.( 5�      - 
 'Xceed.Wpf.AvalonDock.Layout.LayoutPanel  )   Orientation$) 
Horizontal=�6)   � 
 �Xceed.Wpf.AvalonDock.Layout.LayoutGroup`1[[Xceed.Wpf.AvalonDock.Layout.ILayoutPanelElement, Xceed.Wpf.AvalonDock, Version=2.6.1.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]]*   Children.* 5�      4 
 .Xceed.Wpf.AvalonDock.Layout.LayoutDocumentPane  -   5        DocumentPane��5�   4   6 
 0Xceed.Wpf.AvalonDock.Layout.LayoutAnchorablePane  5�      -   5        	ToolsPane��� 
 �Xceed.Wpf.AvalonDock.Layout.LayoutPositionableGroup`1[[Xceed.Wpf.AvalonDock.Layout.LayoutAnchorable, Xceed.Wpf.AvalonDock, Version=2.6.1.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]]+   DockMinHeight$	+ 300Q�5�   I   ,   DockMinWidth$	, 300Q�6]   5�      5�      5�      � 5�   
   $��2��6   #���   6   - � ColumnDefinitions- 5�      �� 5�      $
��Auto �6#   �� 5�      $��* �6#   �� 5�      $
��Auto �6#   .+�5�      �� $��0��6   
�������$	��3,0q�6Y   $��4q�6f   $
��Left=�6r   $��Center=�6�   ��6$   �� *StatusMessage+6�   5�      5�      5�      