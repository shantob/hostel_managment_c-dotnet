   M S B A M L   `   `   `  ����  hostel_managment     hostel_managment.Dashboard   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  	Dashboard��5   	   $	��400��6   $	��600��6(   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5
      $��* �6   .+�5   
   o� $��Stretch=�6   $	��Top=�6-   ���	#FFF99797.@�5      m� -   5        $��	Dashboard��5      6*   m� 5      $��Members��6   .@�5      m� -   5        $��List Member��5      60   m� 5      -   5        $��
Add Member��5      6/   5      m� 5      -   5        $��Par Days Count��5      6/   m� 5      -   5        $��
Fixed Cost��5      6+   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��DemoDataGrid��5       $��1��6      AutoGenerateColumns .  $��	0,21,0,28q�6P      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ SL��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 30 6J   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *SlNo+6J     5      $ Member Name��6%   $	 100 6Y    6:   �� *
MemberName+6Y     5      $ 
Total Cost��6%   $ 80 6W    69   �� *	TotalCost+6W     5      $ 	Paid Cost��6%   $ 80 6U    68   �� *
PaidCost+6U     5       $ Due Cost��6%   $ 80 6S    67   �� *	DueCost+6S     5!      $ 
Total Mill��6%   $ 80 6W    69   �� *	TotalMill+6W     5"      $ 
Fixed Cost��6%   $ 80 6W    69   �� *	FixedCost+6W     5#      $
 Date��6%   $	 150 6P    63   �� *
DateTime+6P   5%      �� 5&   
   -   5         ��Name$ button��5&      $��Add A New Summary��6!   $
��Left=�6=   $��	467,1,0,0q�6X   $��1��6k   $	��Top=�6x   $	��125��6�   ���	#FFFDFDFD���	#FFF353536�   5'      5(      