   M S B A M L   `   `   `  ����E  ALabProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:LabProject
LabProject  5   	       LabProject.Admin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   >d2http://schemas.microsoft.com/expression/blend/2008    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:LabProject     5   	     � Title$  Admin��5   	   $	��850��6   $
��1000��6$    � 	Resources 5	         	StatusBut �� 
TargetType �� Property �� Value  listPanelTemplate��%L  &	        &	 s     '�� �     �� 5
   
   " ��6"   .�5      ��  � ��$ Webdings)�6+   �� 5       � ��$	 100(�6)   5      �� 5   
   .R�5      � 5      �� 5   
   " ��6   .�5      ��  � ��$ 40��6'   �� 5       � ��$ 40��6&   �� 5       � ��$ 20, 0q�6'   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $	��750 �6   .+�5   
   � $��0��6    � ColumnDefinitions 5       �� 5!      $	��500 �6#   �� 5"      $	��500 �6#   .+�5$      �� $��0��6   #��[  6%   $����6H   �� 5%      $��1��6   #��[  6%   $����6H   5&      �� 5(   
   $��1��6   .��5)      �  5*      �� 5+      $��60 �6$   �� 5,      $	��150 �6$   �� 5-      $��60 �6$   �� 5.      $	��150 �6$   �� 5/      $��60 �6$   �� 50      $
��auto �6$   �� 51      $��60 �6$   �� 52      $	��150 �6$   .+�55      �� $��Номера��6   �� 56      $��0��6    �� Orientation$ 
Horizontal=�6*   $��Right=�6C   .+�57      �� -   5        $��Service��57      6E   �� 58      -   5        $
��Info��58      6D   59      �� 5<      $��1��6   #��[ 6r   ��6'   �� *Living_Rooms+ �� SelectedItem 6L   �� *IsApartament+��5=      �� 5>      .R�5?      �� .+�5@   "   �� ��6,   �� 	 �� Path$	 Number�
 �� ValidatesOnExceptions
 .  �� StringFormat$ Комната № {0}���� 5A   "   ��6,   �� $	 Status�
 . $	 {0}���� 5B   "   ��6,   �� $	 Price�
 . $ Цена: {0}$���� 5C   "   5D      5E      5G      �� 5I      $��Обслуживание��6   $��2��60   �� 5J      $��2��6   $ 
Horizontal=�6*   $��Right=�6C   .+�5K      �� -   5        $��Right=�5K      $��2��69   $��AddMenu��6\   �� 5L      -   5        $��Right=�5L      $��2��69   $��
AddServise��6G   6\   �� 5M      -   5        $��Right=�5M      $��2��69   6F   5N      �� 5P      $��3��6   #��[ 6p   ��6'   �� *All_Servise_Room+ 6P   �� *IsRoom+��5Q      �� 5R      .R�5S      �� .+�5T   "   �� ��6,   �� $
	 Name�
 . $	 {0}���� 5W   "   5X      5Y      5[      �� 5]      $��Персонал��6   $��4��6,   �� 5^      $��4��6   $ 
Horizontal=�6*   $��Right=�6C   .+�5_      �� -   5        $��?��5_   /   �� 5`      -   5        $��+��5`   .   �� 5a      -   5        $��C��5a   1   5b      �� 5d      $��5��6   #��[ 6�   ��6'   �� *Staff+ �� Mode$ TwoWay=� 6R   �� *
IsPerson+$ TwoWay=���5e      �� 5f      .R�5g      �� $	��180��6)   $	��160��66   .+�5h   "   �� $	��140��6F   $	��140��6S   $��Center=�6_   ��6(   �� $	 Photo�6_   �� 5i   "   $��Center=�6,   $
��Wrap=�6I   ��5j   &   �� 5k   *   $
	 Name�62    �� 	Converter 5l   .      LabProject.ConvertName  5m   2   5o   +   5q   #   �� 5r   "   $��Center=�6�   ��6,   �� $	 Salary�
 . $ Зарплата: {0}$��6�   �� 5s   "   5t      5u      5w      �� 5y      $��
Гости��6   $��6��6)   �� 5z      $��6��6   $ 
Horizontal=�6*   $��Right=�6C   .+�5{      �� -	   5        $��?��5{   .   �� 5|      -
   5        $��C��5|   0   5}      �� 5      $��7��6   #��[ 6j   ��6'   �� *
List_Guest+ 6J   �� *IsHost+��5�      �� 5�      .R�5�      �� .+�5�   "   �� ��6,   �� $
	 Name�
 . $ ФИО: {0}���� 5�   "   ��6,   �� $	 Number�
 . $ Номер: {0}���� 5�   "   5�      5�      5�      5�      5�      5�      5�      