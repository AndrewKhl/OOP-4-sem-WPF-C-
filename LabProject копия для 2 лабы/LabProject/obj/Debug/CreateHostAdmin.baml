   M S B A M L   `   `   `  ����E  ALabProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:LabProject
LabProject  5   	        LabProject.CreateHostAdmin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:LabProject     5   	     � Title$  CreateHostAdmin��5   	   $	��950��6!   $	��600��6.   .��5
      �  � DataContext 6   �� *IsHost+ � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $	��150 �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $	��420 �6   .+�5   
   �� $��1��6   $��0��6$   $��Анкета��61   �� 5   
   $��0��6   $��1��6$   $��ФИО��61   �� 5   
   $��0��6   $��2��6$   $��Дата рождения��61   �� 5   
   $��0��6   $��3��6$   $��Фото��61   �� 5   
   $��0��6   $��4��6$   $��Справка��61   �� 5   
   $��1��6   $��1��6"   ��6/   ��  �� Path$
 Name� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5    
   $��1��6   $��2��6"   ��6/   �� $ Bithday�$ TwoWay=�$ PropertyChanged=��� 5!   
   $��1��6   $��3��6"   ��6/   �� $ Photo�$ TwoWay=�$ PropertyChanged=��� 5"   
   $��1��6   $��4��6"    �� TextWrapping$
 Wrap=�6/   ��6C   �� $ Comments�$ TwoWay=�$ PropertyChanged=��� 5$   
   -   5        $��Right=�5$      $��1��6-   $��5��6=   $��40��6J   $	��100��6V   6b   5%      5&      