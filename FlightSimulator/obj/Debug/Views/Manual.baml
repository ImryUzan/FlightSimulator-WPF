   M S B A M L   `   `   `  ����J  FFlightSimulator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FlightSimulator.ViewsFlightSimulator.Views  5   	   =#clr-namespace:FlightSimulator.ViewsFlightSimulator.Views  5   	   "    FlightSimulator.Views.Manual   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:FlightSimulator.Views     5   	   8Controls#clr-namespace:FlightSimulator.Views     5   	   .��5
      � $	��430��6   $	��470��6     � ColumnDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��2��6   $��Center=�6"   $��0��6>   $��← thorttel →��6N   $��15(�6c    � LayoutTransform 5      �� 5       �� Angle$ 90Q�6"   5       �� 5$   
   -   5        $��LeftSl��5$   P   $��2��6   $��1��6    � Maximum$ 1Q�6^    � Minimum$ 0Q�6j   $��29��6v    �� TickPlacement$ TopLeft=�6�    �� TickFrequency$	 0.1Q�6�    �� Orientation$ Vertical=�6�   	 � Value	 6/   �� *ChangeTorttel+6�   $   FlightSimulator.Views.Joystick  5'   
   -   5        
  Name$
 MyJoy��5'      $��2��6�   $��2��6�   $��Center=�6�   $��Center=�6�      Aileron 6+   �� *
AileronP+ �� Mode$ OneWayToSource=�   Elevator 6\   �� *	ElevatorP+$ OneWayToSource=�6�   �� 5(   
   -   5        $��valThorttel��5(      $��1��6'   $��1��64   ��6D   ��  �� ElementName$ LeftSl�� �� Path$ Value� �� StringFormat$ N2��6�   �� 5,   
   -   5        $��Rudder��5,   M   $��3��6   $��2��6   $ 1Q�6[   $ -1Q�6g   $��25��6t   $ BottomRight=�6�   $	 0.2Q�6�   	 6.   �� *ChangeRudder+6�   �� 5-   
   $��Center=�6   $��← elevator →��6/   $��2��6C   $��4��6P   $��15(�6`    5.      �� 5/      $ 90Q�6"   51      �� 55   
   $��← aileron →��6   $��Center=�6(   $��0��6E   $��2��6R   $��15(�6b   6r   �� 56   
   -   5        $��RudderSlide��56      $��4��6'   $��2��64   $��Center=�6D   $��← rudder →��6a   $��15(�6s   6�   �� 57   
   -   5        $��	valRudder��57      $��3��6%   $��3��62   ��6B   �� $ Rudder��$ Value�$ N2��6�   �� 5:   
   $��0��6   $��3��6"   $��40��62   ��6=   �� $ MyJoy��$ Aileron�$ N2��6   �� 5;   
   $��1��6   $��4��6"   $��40��62   ��6=   �� $ MyJoy��$ Elevator�$ N2�� 5<      �� 5=      $ 90Q�6"   5?      5B      5C      