   M S B A M L   `   `   `  ����?  ;var4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:var4var4  5   	       var4.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:var4     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   .+�5   
   (  "System.Windows.Controls.DatePicker  -   5        $��
datePicker��5   ?   $��0��6   $��0��6"   $��10q�62      IsDropDownOpen .    SelectedDateFormat$
 Long=�6g   �� 5   
   $��0��6   $��1��6"    �� Orientation$ 
Horizontal=�62   .+�5      &   System.Windows.Controls.Calendar  -   5          Name$ calendar��5      $��20q�6)      SelectedDate$ 
09/29/2021X�65      DisplayDate$ 
09/29/2021��6O   �� 5      $��20,95,20,85q�6   $��20��6+   $	��140��67   ��6C   �� *SelectedDate+	 �� ElementName$	 calendar��5      5      5      