   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   -   5        $
��Main��5   Z     � Title$  
MainWindow��6	   $	��450��6   $	��300��6)    � WindowStartupLocation$ CenterScreen=�65    � 	Resources 5	         btnTemplate �� 
TargetType �� CornerRadius �� TextAlignment �� Triggers P� Property P� Value	 �� 
TargetName
 �� Property �� Value��%&  &	        �� 5
   
   " ��6.   .R�5      �� $��	btnBorder��5      
�������$��50��5      $��50��5      $	 100��5      $��2q�5      
���   �._�5      �� $��20(�5      #��z��5      
���   �$ Center=�5      $��Center=�5      $��Center=�5      5      5       5      P� 5       �@J�IsMouseOver . . �5      �� $	 	btnBorder��6   
 � ��
 �����6J   5      P� 5        � �� . . �5!      �� $	 	btnBorder��6   
 � ��
 �����6J   5"      5$      5%      .��5)      �  � RowDefinitions 5*   
   �� 5+      �� 5,      $��50 �6   .+�5.   
   �� $��Stretch=�6    �� SelectedItem 67   �� *SelectedText+��6]   �� *Texts+��5/      �� 50      .R�51      �  � ColumnDefinitions 52      �� 53      �� 54      $��50 �60   .+�56      �� .+�57      �� $��20(�6G   ��6$   �� *MainWindowText+6G   58      A� 59      $��1��6&    A� Columns$ 1��66    A� Rows$ 2��6B   .+�5:      �� $
��😎��6m   ��6%   �� *DataContext.ViewButtonCommand+ �� ElementName$
 Main��6m   5<      5=      5>      5@      5A      5B      