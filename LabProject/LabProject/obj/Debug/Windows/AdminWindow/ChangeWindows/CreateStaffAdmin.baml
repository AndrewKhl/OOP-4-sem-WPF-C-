   M S B A M L   `   `   `  ����E  ALabProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:LabProject
LabProject  5   	   !    LabProject.CreateStaffAdmin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   >d2http://schemas.microsoft.com/expression/blend/2008    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:LabProject     5   	     � Title$  CreateStaffAdmin��5   	   $	��950��6"   $	��600��6/    � 	Resources 5
       �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value �� RelativeSource	 �� Path��%�   '��       �� 5   
   " ��6    5      P� 5       �@=�HasError . . �5      ��  � ��
 �  ��63   �� 5       �@�ToolTip 5      ��  �� *Self+$)	 #(Validation.Errors)[0].ErrorContent�5      5      5      .��5      � 
 � DataContext
 6   �� *
IsPerson+ � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $	��130 �6   �� 5      $	��150 �6   �� 5      $��50 �6   �� 5       $
��auto �6    � ColumnDefinitions 5#   
   �� 5$      $	��150 �6   �� 5%      $	��420 �6   .+�5(   
   �� $��1��6   $��0��6$   $��Анкета��61   �� 5)   
   $��0��6   $��1��6$   $��ФИО��61   �� 5*   
   $��0��6   $��2��6$   $��Дата рождения��61   �� 5+   
   $��0��6   $��3��6$   $��Фото��61   �� 5,   
   $��0��6   $��4��6$   $%��Зарабатная плата��61   �� 5-   
   $��0��6   $��5��6$   $��Место работы��61   �� 5.   
   $��0��6   $��6��6$   $��Справка��61   �� 50   
   -   5         ��Name$
 Name��50   /   $��1��6   $��1��6"   .��6=   .��51      �� $
	 Name�6    �� NotifyOnValidationError .  �� UpdateSourceTrigger$ PropertyChanged=�6A    �� Mode$ TwoWay=�6g    �� ValidationRules 52         LabProject.RulesForName  53      5  /System.Windows.Controls.ExceptionValidationRule  54      56      57      �� 58   
   $��1��6   $��2��6"   .��6/   .��59      �� $	 Bithday�6    . $ PropertyChanged=�6D   $ TwoWay=�6j    5:         LabProject.RulesForDate  5;        5<      5>      5?      �� 5A   
   $��1��6   $��3��6"   .��6/   ��5B      �� 5C      $	 Photo�6    . $ TwoWay=�6F   $ PropertyChanged=�6T    �� 	Converter 5D         LabProject.PhotoStaff  5E      5G      .��5H      5I      �� 5K   
   $��1��6   $��4��6"   .��6/   .��5L      �� $	 Salary�6    . $ PropertyChanged=�6C   $ TwoWay=�6i    5M         LabProject.RulesForNumber  5N        5O      5Q      5R      �� 5S   
   $��1��6   $��6��6"    �� TextWrapping$
 Wrap=�6/   ��6C   �� $	 Comments�$ TwoWay=�$ PropertyChanged=�� 5U   
   $��1��6   $��5��6    5V      �� 5W      $��10 �6    �� 5X      $��30 �6    �� 5Y      $��30 �6    �� 5Z      $��30 �6    �� 5[      $��30 �6     5]      �� 5^      $	��180 �6#   �� 5_      $	��180 �6#   �� 5`      $
��auto �6#   .+�5b      	� -   5         	�Name$	 Bar��5b      $	��Bar��6'   $��0��65   $��1��6E    	� 	GroupName$	 Job��6R   6b   	� 5c      -   5        $ 
Restaurant��5c      $��
Restaurant��6.   $��0��6C   $��2��6S   $	 Job��6`   6p   	� 5d      -   5        $
 Pool��5d      $
��Pool��6(   $��0��67   $��3��6G   $	 Job��6T   6d   	� 5e      -   5        $	 Gym��5e      $	��Gym��6'   $��1��65   $��1��6E   $	 Job��6R   6b   	� 5f      -   5        $ Kitchen��5f      $��Kitchen��6+   $��1��6=   $��2��6M   $	 Job��6Z   6j   	� 5g      -   5        $
 Hall��5g      $
��Hall��6(   $��1��67   $��3��6G   $	 Job��6T   6d   	� 5h      -   5        $ Cabinets��5h      $��Cabinets��6,   $��1��6?   $��4��6O   $	 Job��6\   6l   	� 5i      -	   5        $ TehnicalBuilding��5i      $��TehnicalBuilding��64   $��0��6O   $��4��6_   $	 Job��6l   6|   �� 5j      -
   5         ��Name$ IsMain��5j      $��IsMain��6'   $��3��68   $��1��6H   6U   5k      � 5n   
   $��1��6   $��7��6    5o      �� 5p      �� 5q      �� 5r      .+�5t      �� -   5        $��2��5t      $��Right=�6%   $��40��6A   $	��100��6M   $��Добавить��6k   
�������6~   �� 5u      -   5        $��1��5u      $��Right=�6%   $��40��6A   $	��100��6M   $��Удалить��6i   
�������6{   5v      5w      5x      