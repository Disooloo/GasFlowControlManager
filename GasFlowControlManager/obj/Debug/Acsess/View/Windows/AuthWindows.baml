   M S B A M L   `   `   `  ����P  LGasFlowControlManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:GasFlowControlManager.Acsess.View.Windows)GasFlowControlManager.Acsess.View.Windows  5   	   ;    5GasFlowControlManager.Acsess.View.Windows.AuthWindows   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Ilocal7clr-namespace:GasFlowControlManager.Acsess.View.Windows     5   	   c _MaterialDesignThemes.MahApps, Version=0.2.2.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   
   -   5           MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ LoginWindow��5   	   $	��550��6   $	��800��6*    � AllowsTransparency .  � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	    � Icon$ /Acsess/Image/icon.ico��5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5    
   � -   5        $��Closing��5       .+�5#      '  !MaterialDesignThemes.Wpf.PackIcon  -   5        $��ClickMouseClosing��5%   &   	   Kind$	 Close=�5#   &   
 � Cursor$

 Hand��5$   &   $��25��5&   &   $��25��5'   &   $	��Top=�5)   &   $��	10,5,10,0q�6>   ��5(   &   ��  �� ElementName$ loginBox�� �� Path$ BorderBrush�5)   >   5*      #  MaterialDesignThemes.Wpf.Card  5,   
   $��1��6   $��Stretch=�5-      $��Stretch=�5.      .��5/      �� $��/Acsess/Image/hr.jpg��6   50      � 52   
   $��0��6   $��Stretch=�6   $��Center=�6=    � RowDefinitions 53      �� 54      �� 55      �� 56      �� 57      .+�59      �� $��0��6    $  MaterialDesignHeadline4TextBlock#��[ 5:      $��Center=�5;      Авторизация5=      �� 5>       �� Orientation$ 
Horizontal=�6   $��1��62   $��0,20,0,0q�6?   $��Center=�6Q   .+�5?        $��1��6*   $��0��67   $	 Account=�5@   *   $��Center=�5B   *   $��	10,5,10,0q�6E   ��5A   *   �� $ loginBox��$ BorderBrush�5D      �� 5E      -   5        $��loginBox��5F       % !MaterialDesignFloatingHintTextBox#��[ 5G      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Логин��5H      $	��140��5I      .��6!   5J      5K      �� 5L      $ 
Horizontal=�6   $��2��62   $��0,20,0,0q�6?   $��Center=�6Q   .+�5M        $��1��6*   $��0��67   $		 Key=�5N   *   $��Center=�5P   *   $��	10,5,10,0q�6E   ��5O   *   �� $ passwordBox��$ BorderBrush�5R      G� 5S      -   5        $��passwordBox��5S      $ Пароль��5T         
Foreground
 � � �.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush
 � � �$	��140��5W      {�.  ) %MaterialDesignFloatingHintPasswordBox#��[ 5Y      5Z      5[      �� 5\      $ 
Horizontal=�6   $��3��62   $��	90,20,0,0q�6?   $��Center=�6R   .+�5]      �� $!��Запомнить меня��6   $��Stretch=�64   $

 Hand��6R   6b   �� 5^      -   5         " MaterialDesignFlatDarkBgButton#��[ 5^      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 20��5_      $��40��5`      $��80��6%   $��50,0,0,0q�60   .��5a   ,   
Войти5c      5d      5e      5f      5g      