   M S B A M L   `   `   `  ����E  ALabProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:LabProject
LabProject  5   	       LabProject.RoomInfo   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:LabProject     5   	     � Title$  RoomInfo��5   	   $	��950��6   $	��620��6'   .��5
      �  � DataContext 6   �� *IsRoom+ � RowDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $	��300 �6   �� 5      $
��auto �6   �� 5      $	��100 �6   .+�5   
   �� $��0��6   $��72(�6a   $��Center=�6o   $��Center=�6�   $��Italic$�6�   $
��Bold"�6�   ��6!   ��  �� Path$
 Name� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��1��6   $��Center=�6�   $��16(�6�   ��6!   �� $ Working_hours� �� ValidatesOnExceptions .  �� StringFormat$- 'Находится на {0} этаже.��6�   �� 5   
   $��2��6   $��Center=�6�   $��16(�6�   ��6!   �� $ Floor� . $- 'Находится на {0} этаже.��6�   �� 5   
   $��3��6   $��Center=�6;   $��Center=�6X   $��10q�6s   ��6   �� $ Image�6s   �� 5   
   $��4��6   $
��Wrap=�6@   $��20(�6T   $��Center=�6b   $��10, 20q�6}   $��Italic$�6�   ��6"   �� $ Comment�6�   5      5      