   M S B A M L   `   `   `  ����P  LGasFlowControlManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:GasFlowControlManager.Acsess.View.Pages.Admins.GasFlowControlManager.Acsess.View.Pages.Admins  5      B    <GasFlowControlManager.Acsess.View.Pages.Admins.UsersListPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Nlocal<clr-namespace:GasFlowControlManager.Acsess.View.Pages.Admins     5      c _MaterialDesignThemes.MahApps, Version=0.2.2.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5	      -   5           MaterialDesignBody#���   5        N� Title$  UsersListPage��5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��5* �6   �� 5      $��7* �6   .+�5   
   � $��1��6   $��50q�6    � RowDefinitions 5      �� 5      $
��148* �6    �� 5      $
��177* �6    .+�5      � $��Stretch=�6   $��Stretch=�61   .+�5      �� $,��&/Acsess/Image/meeting-1453895_1280.png��6   5      #  MaterialDesignThemes.Wpf.Card  5      $��1��6"   $��Center=�5   "   $	��Top=�5   "   .��5      � .+�5       &   System.Windows.Controls.DataGrid  -   5        $��DBlist��5          AutoGenerateColumns .     
IsReadOnly . ��. $
��Auto=�5#      $
��Auto=�5$         Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$ #��61      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6<   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6F   �� 	 �� Path$	 Id�  5(      $ Имя��61   $ * 6>    6H   �� $	 FullName�  5)      $ Должность��61   $ * 6D    6N   �� $	 Position�  5*      $ 
Логин��61   $ * 6@    6J   �� $	 Login�  5+      $ 
Админ��61    6@   �� $	 IsAdmin�  5,      $% Дата регистрации��61    6K   �� $	 RegistrationDate�  5-      $! Последний вход��61    6I   �� $	 LastLoginDate�4  .System.Windows.Controls.DataGridTemplateColumn  5/      $ Действия��65   
   CellTemplate
 50   "   �� 51   &   .R�52   *   �� -   5        $��Подробнее��52   1   6E   53   '   55      57      59      5:      5;      � 5=   
   $��0��6   $	��Top=�5>      $	��480��5?      $	��100q�5@      .+�5A      ]� .+�5B      �� $%��Добавить нового: ��6   $��30(�5C      $
��Left=�5D      $
��10 0q�5E       $  MaterialDesignHeadline4TextBlock#��[ 5F      �� 5G      -   5        $��	logotitle��5H      $��Пользователя��5G      $��30(�5I      $
��Bold"�5J      ���#AFA2FF#��[ 5L      5M      � 5N      $��50 -80q�6   $
��Left=�6#   $��Center=�6>   .+�5O      ��  �� Orientation$ Vertical=�6   $	��234��64   .+�5P      �� $ 
Horizontal=�6!   .+�5Q      '  !MaterialDesignThemes.Wpf.PackIcon  $��1��62      Kind$ Person=�6?   $��Center=�5S   &   ��5R   &   ��  �� ElementName$ FullName��$	 BorderBrush�5S   &   �� 5U      -   5        $��FullName��5U   "    % !MaterialDesignFloatingHintTextBox#��[ 5V   "   )	  #MaterialDesignThemes.Wpf.HintAssist 	  Hint$ Имя��5W   "   $	��199��5X   "   $��40��6.   ��5Y   "   �� $	 FullName�5Z      �� 5\      $ 
Horizontal=�6!   .+�5]        $��1��62   $
 Work=�6?   $��Center=�5_   &   ��5^   &   �� $ Position��$	 BorderBrush�5_   &   �� 5a      -   5        $��Position��5a   "   #��[ 5b      $ Должность��5c      $	��199��5d      $��40��6"   ��5e      �� $	 Position�5f      �� 5h      $ 
Horizontal=�6!   .+�5i        $��1��62   $
 Post=�6?   $��Center=�5k   &   ��5j   &   �� $ Login��$	 BorderBrush�5k   &   �� 5m      -   5        $��Login��5m   "   #��[ 5n      $ 
Логин��5o      $	��199��5p      $��40��6"   ��5q      �� $	 Login�5r      �� 5t      $ 
Horizontal=�6!   .+�5u      �� $��
Админ��6$   $��Center=�5v   $   $��Center=�5w   $   �� 5y      -   5        $��IsAdmin��5y   #    $  MaterialDesignFilterChipCheckBox#��[ 5z   #   $ 
Админ��5{   #   $	��199��5|   #   $��40��6/   
��� � � d� 	IsChecked 5~   #   �� $	 IsAdmin�5      �� 5�      $ 
Horizontal=�6!   .+�5�      �� -	   5        $��password��5�   "   #��[ 5�      $ Пароль��5�      $	��180��5�      $��40��6"   ��5�      �� $	 Password�  5�      -
   5        $��
passAddGen��5�   &   $��1��5�   2   $��0��6?   $ PasswordAdd=�6O   $��50��5�   &   $��50��61    � Cursor$
 Hand��5�   &   $��Center=�5�   &   ��5�   &   �� $ Password��$	 BorderBrush�5�   &   5�      �� 5�      $ 
Horizontal=�6!   .+�5�        $��1��62   $��0��6?   $ Phone=�6O   $��Center=�5�   &   ��5�   &   �� $ Phone��$	 BorderBrush�5�   &   �� 5�      -   5        $��Phone��5�   "   #��[ 5�   "   $ Телефон��5�   "   $	��199��5�   "   $��40��6.   ��5�   "   �� $	 Phone�5�      �� 5�      $ 
Horizontal=�6!   .+�5�        $��1��62   $��0��6?   $ Email=�6O   $��Center=�5�   2   ��5�   2   �� $ Phone��$	 BorderBrush�5�   2   �� 5�      -   5        $��email��5�   "   #��[ 5�   "   $ Email��5�   "   $	��199��5�   "   $��40��6.   ��5�   "   �� $	 Email�5�      �� 5�      $ 
Horizontal=�6!   .+�5�        $��1��62   $��0��6?   $ ImageDescription=�6O   $��Center=�5�   2   ��5�   2   �� $ Phone��$	 BorderBrush�5�   2   �� 5�      -   5        $��description��5�   "   #��[ 5�   "   $ Описание��5�   "   $	��199��5�   "   $��40��6.   ��5�   "   �� $	 	Derection�5�      5�      5�      � 5�      $
��Left=�6   $��Bottom=�5�      $��0 -120q�5�      $	��300��5�      .+�5�      �� -   5        $
��back��5�       + 'MaterialDesignFlatSecondaryDarkBgButton#��[ 5�      +
  %MaterialDesignThemes.Wpf.ButtonAssist 
  CornerRadius$ 20��5�      $��40��5�      $��80��6%   $
��Left=�5�      $
��40 0q�5�      .��5�   8   
Назад5�      �� 5�      -   5        $��	UserStore��5�      #��[ 5�      $ 20��5�      ���#7AC27E$��40��5�      $	��120��6%   $��Right=�5�      .��5�   B   Сохранить5�      5�      5�      5�      5�      