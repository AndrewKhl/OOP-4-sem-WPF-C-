   M S B A M L   `   `   `  ����E  ALabProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:LabProject
LabProject  5   	       LabProject.InfoStaffAdmin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:LabProject     5   	     � Title$  InfoStaffAdmin��5   	   $	��400��6    $	��620��6-    � 	Resources 5	       �� 
TargetType �� Property �� Value��%R   '��       �� 5
   
   " ��6   .�5      ��  � ��$ 15(�6)   5      5      .��5      �  � DataContext 6   �� *
IsPerson+ � ColumnDefinitions 5   
   �� 5      $	��400 �6   �� 5      $	��200 �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $	��200 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $
��auto �6   .+�5   
   �� $��1��6   $��1��6    $��5��6-   $��Center=�6>   ��6Y   ��  �� Path$ Photo��� 5   
   $��Center=�6/   $��Center=�6L   $��30(�6g   $
��Bold"�6u   $��2��6�   ��6   �� $
 Name�6�   �� 5   
   $��1��6   $
��Wrap=�6@   ��6!   �� $ Comments�6@   �� 5   
   $��2��6   ��6!   �� $	 Job�	 �� StringFormat$!	 Место работы {0}���� 5   
   $��3��6   ��6!   �� $ Salary�$	 Зарплата {0}$��5       5!      