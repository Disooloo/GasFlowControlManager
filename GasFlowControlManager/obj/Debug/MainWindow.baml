   M S B A M L   `   `   `  ����P  LGasFlowControlManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:GasFlowControlManagerGasFlowControlManager  5   	   &     GasFlowControlManager.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:GasFlowControlManager     5   	   c _MaterialDesignThemes.MahApps, Version=0.2.2.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5	   	      MaterialDesignBody#���   5
   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$N HМенеджер по регулированию расхода газа��5   	   $	��900��5   	   $
��1000��6   $	��750��5   	   $
��1300��6    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ 	CanResize=�5   	    � Icon$ /Acsess/Image/icon.ico��5   	    � WindowState$ 	Maximized=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $	��70* �6   �� 5      $
��651* �6   .+�5   
   � -   5        $��Header��5      $��0��5       .+�5!      ]� .+�5#      �� -   5        $	��Log��5)      $��Логи��5#      $��32(�5$      ���#AFA2FF$
��Left=�5&      $��Center=�5'      $��60 0 0 0q�5(       � Cursor$
 Hand��5+      '  !MaterialDesignThemes.Wpf.PackIcon  5,      	   Kind$	 LogicGateAnd=�6.   $	��5 0q�5-   .   $��20��6;   $��20��6G   5.      �� 50      -   5        $��Users��56      $��Пользователи��50      $��32(�51      ���#AFA2FF$
��Left=�53      $��Center=�54      $��60 0 0 0q�55      $
 Hand��58        59      $	 Users=�6.   $	��5 0q�5:   .   $��20��6;   $��20��6G   5;      �� 5=      -   5        $
��Exit��5C      $��
Выйти��5=      $��32(�5>      ���#AFA2FF$��Right=�5@      $��Center=�5A      $��60 0 q�5B      $
 Hand��5E        5F      $	 ExitRun=�6.   $	��5 0q�5G   .   $��20��6;   $��20��6G   5H      5J      5K      � 5L   
   $��1��6   .+�5M       � -   5        $��	MainFrame��5N      ���#E3D7FF
  � NavigationUIVisibility$
 Hidden=�5O      5Q      5R      5S      