   M S B A M L   `   `   `  ����P  LGasFlowControlManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:GasFlowControlManager.Acsess.View.Pages.Admins.GasFlowControlManager.Acsess.View.Pages.Admins  5      D    >GasFlowControlManager.Acsess.View.Pages.Admins.GasEmulatorPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Nlocal<clr-namespace:GasFlowControlManager.Acsess.View.Pages.Admins     5      c _MaterialDesignThemes.MahApps, Version=0.2.2.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5        N� Title$  GasEmulatorPage��5
      .��5      � .+�5   
   �� $	��400��6   $	��900��6    $��70q�6/    �� CornerRadius$ 30��5      ���#FFF���#FFF$��1q�5   $    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$
 Gray��6#      	Direction$	 270Q�60      ShadowDepth$ 6Q�5   #      Opacity$	 0.8Q�63      
BlurRadius$ 10Q�5   #   ._�5      � .+�5      ]� .+�5      �� $��Эмулятор для: ��6    $��50 20q�5       $��23(�5       ���#7A89C25       �� 5      $
��0 20q�6    �� 5      $��23(�5      $
��Bold"�5      ���#7A89C2�5      ��  �� Path$
 Name�5       �� 5    "   $�(��6&   ���#7A89C26/    �� 5!   "   ���#7A89C2�6&   �� $ Id�6?    �� 5"   "   $�)��6&   ���#7A89C26/   5#      '  !MaterialDesignThemes.Wpf.PackIcon  5$      -   5        $��ClosingModel��5)   .   	   Kind$	 Close=�5$   .   $��Right=�5%   .   $	��Top=�5&   .   $��50 20q�5'   .   
 � Cursor$

 Hand��5(   .   $��40��5+   .   $��40��6:   5-      �� 5.      $	��Top=�5/      $
��Left=�50      $��30 100q�51      .+�52      ]� .+�53        $	 Company=�62   $��Right=�54   2   $	��Top=�55   2   $��50 20q�56   2   $

 Hand��57   2   ���#AFA2FF$��40��59   2   $��40��6>   �� 5:      -   5        $��Manufacturer��5B   #   $	��550��5:   #    �� 
IsReadOnly . $��50��5<   #   ���#AFA2FF$��24(�5>   #   $
 No��5?   #   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$  Производитель��5A   #   ��5@   #   �� $ Manufacturer�5B   #   5C      ]� 5D      .+�5E        $	 CarBrakeLowPressure=�62   $��Right=�5F   6   $	��Top=�5G   6   $��50 20q�5H   6   $

 Hand��5I   6   ���#AFA2FF$��40��5K   6   $��40��6B   �� 5L      -   5        $��MaxFlowRate��5T   #   $	��550��5L   #   $��50��5M   #   ���#AFA2FF$��24(�5O   #   $
 No��5P   #    . $/ )Максимальное давление��5S   #   ��5R   #   �� $ MaxFlowRate�5T   #   5U      ]� 5V      .+�5W        $	 CarBrakeLowPressure=�62   $��Right=�5X   2   $	��Top=�5Y   2   $��50 20q�5Z   2   $

 Hand��5[   2   ���#AFA2FF$��40��5]   2   $��40��6>   �� 5^      -   5        $��MaxPressure��5d   #   $	��550��5^   #   $��50��5_   #   ���#7AC27E$��24(�5a   #   $&  Текущее давление ��5c   #   ��5b   #   �� $ CurrentFlowRate�5d   #   5e      ]� 5f      .+�5g        $	 Speedometer=�62   $��Right=�5h   2   $	��Top=�5i   2   $��50 20q�5j   2   $

 Hand��5k   2   ���#AFA2FF$��40��5m   2   $��40��6>   �� 5n      -   5        $��MaxPrыessure��5v   #   $	��550��5n   #   $��50��5o   #   ���#AFA2FF$��24(�5q   #    . $
 No��5s   #   $< 6Максимальное скорость потока��5u   #   ��5t   #   �� $ MaxPressure�5v   #   5w      ]� 5x      .+�5y        $	 Speedometer=�62   $��Right=�5z   2   $	��Top=�5{   2   $��50 20q�5|   2   $

 Hand��5}   2   ���#AFA2FF$��40��5   2   $��40��6>   �� 5�      -   5        $��MaxPыфrыessure��5�   #   $	��550��5�   #   $��50��5�   #   ���#7AC27E$��24(�5�   #   $2 ,Текущая скорость потока��5�   #   ��5�   #   �� $ CurrentPressure�5�   #   5�      ]� 5�      .+�5�        $	 power=�62   $��Right=�5�   2   $	��Top=�5�   2   $��50 20q�5�   2   $

 Hand��5�   2   ���#AFA2FF$��40��5�   2   $��40��6>   �� 5�      -   5        $��Power��5�   #    $   MaterialDesignFilterChipCheckBox#��[  5�   #   $ Power��5�   #   $	��220��5�   #   $��50��6/   
��� � � d� 	IsChecked 5�   #   �� $ Power�5�      �� 5�      -   5        $��SaveAgr��5�      $��Right=�5�      $��Center=�5�      $��Сохранить��5�      $��32(�5�      $��50��5�      $��200 20q�5�         MaterialDesignFlatDarkButton#��[ 5�      5�      5�      5�      5�      5�      