   M S B A M L   `   `   `  ����E  ALabProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:LabProject
LabProject  5   	       LabProject.ServiseRoom   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:LabProject     5   	     � Title$  ServiseRoom��5   	   $	��600��6   $	��350��6*    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�   '��       �� 5
   
   " ��6   .�5      ��  � ��$ 60��6&   �� 5       � ��$ 20��6'   �� 5       � ��$ 10q�6'   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      $	��100 �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $	��550 �6   .+�5   
   �� $��0��6   $��0��6"   $��2��62   .+�5      �� $��Service��6   $��Center=�6'   �� 5      $��Center=�65   ��6   �� *IsRoom.Name+65   5      �� 5   
   $��1��6   $��1��6%   .+�5      �� -   5        $	��Add��5      6#   �� 5       -   5        $��Delete��5       6&   5!      �� 5"   
   $��0��6   $��1��6%   .+�5#      �� ��6   �� *IsRoom.Service+ �� SelectedItem 6=   �� *Serv+�� 5$      -   5         ��Name$
 Serv��5$      6&   5%      5&      5'      