   M S B A M L   `   `   `  ����J  FFlightSimulator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FlightSimulator.ViewsFlightSimulator.Views  5   	   *    $FlightSimulator.Views.SettingsWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:FlightSimulator.Views     5   	     � Title$  SettingsWindow��5   	   $	��180��6    $	��300��6-   $	��180��69   $	��300��6I   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � 	Resources 5   
    �� 
TargetType �� Property �� Value��%�   '��       '�� r     �� 5      " ��6   .�5      ��  �@��Padding$ 3q�6,   �� 5       � ��$ 3q�6+   5      �� 5      " ��6   .�5      ��  � ��$ 3q�6,   �� 5       � ��$ 3q�6+   5      5      .+�5   
   (� $��0��6   $��0��6#   .��5      �� Flight Server IP:6,   5       �� 5"   
   -   5         ��Name$ txtServerIP��5"      $��2��6'   ��68   �� *FlightServerIP+6Z   (� 5#   
   $��0��6   $��1��6#   .��5$      �� Flight Info Port:6,   5%      �� 5'   
   -   5        $ txtMazeName��5'      $��2��6'   $��1��67   ��6D   �� *FlightInfoPort+6f   (� 5)   
   $��0��6   $��2��6"   .��5*      �� Flight Command Port:6/   5+      �� 5-   
   -   5        $ txtMazteName��5-      $��2��6(   $��2��68   ��6E   �� *FlightCommandPort+6j   �� 5/   
   $��0��6   $��3��6!   $��30��6O   $��50��6[   ��6.   �� *ClickCommand+.��6f   OK6j   �� 50   
   $��1��6   $��3��6!   $��30��6P   $��50��6\   ��6.   �� *CancelCommand+.��6h   Cancel6p   52      53      