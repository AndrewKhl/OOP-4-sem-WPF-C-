   M S B A M L   `   `   `  ����E  ALabProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:LabProject
LabProject  5   	   #    LabProject.InfoEnterRoomAdmin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:LabProject     5   	     � Title$  InfoEnterRoomAdmin��5   	   $	��950��6$   $	��600��61    � 	Resources 5
         listPanelTemplate��%2   &	        �� 5   
   .R�5      � 5      5      .��5      �  � DataContext 6   �� *IsRoom+ � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $	��200 �6   �� 5      $	��200 �6   �� 5      $	��100 �6   �� 5      $	��150 �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   ��6!   ��  �� Path$
 Name� �� UpdateSourceTrigger$ PropertyChanged=�� 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5      $
��auto �6#   .+�5"      �� $��1��6   ��6(   �� $ Comment�5#      � 5%   
   $��2��6    6   �� $
 Main� 5&      �� 5'      $��50 �6    �� 5(      $	��150 �6    .+�5*      �� $��0��6   ��6%   �� $
 Name�5+      � 5-   
   $��3��6    5.      �� 5/      $	��300 �6#   �� 50      $
��auto �6#   .+�53      �� $��0��6   ��6(   �� $ Floor� �� ValidatesOnExceptions .  �� StringFormat$- 'Находится на {0} этаже.��54      �� 56   
   $��4��6   #��[  6=   ��6   �� *Staff+��57      �� 58      .R�59      �� .+�5:      �� ��6$   �� $
 Name� . $ ФИО: {0}��5;      5<      5>      5@      5A      