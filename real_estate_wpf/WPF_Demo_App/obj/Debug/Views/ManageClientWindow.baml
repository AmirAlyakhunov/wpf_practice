   M S B A M L   `   `   `  ����G  CWPF_Demo_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WPF_Demo_App.ViewsWPF_Demo_App.Views  5   	   +    %WPF_Demo_App.Views.ManageClientWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WPF_Demo_App.Views     5   	     � Title$  ManageClientWindow��5   	   $	��450��6$   $
��1000��61   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��250 �6   �� 5      $	��150 �6   �� 5      .+�5   
   �� .+�5      �� -   5        $��	LbClients��5      $	��200��6V   $��10q�6b   $	��360��6n   ��5      �� 5      .R�5      �� ��6$   �� *PersonSet.FullName+5      5      �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        $��BtnNew��5      $	��New��6'      ButtonAgent#��[  65   6Z   �� 5      -   5        $��	BtnDelete��5      $��Delete��6*   #��[  6;   6`   5      5      �� 5   
   -   5        $��SpEdit��5   1   $	��150��6   $��1��6!   .+�5      �� $��
First name��6     TextBlockSPEl#��[ 6*   �� 5      -   5         ��Name$ TbFirstName��5        TextBoxSPEl#��[ 6+   �� 5      $��Middle name��6   #��[ 6+   �� 5       -   5        $ TbMiddleName��5       #��[ 6-   �� 5!      $��	Last name��6   #��[ 6)   �� 5"      -   5        $ 
TbLastName��5"      #��[ 6+   �� 5#      $��Phone��6   #��[ 6%   �� 5$      -   5        $ TbPhone��5$      #��[ 6(   �� 5%      $��Email��6   #��[ 6%   �� 5&      -	   5        $ TbEmail��5&      #��[ 6(   �� 5'      -
   5         ��Name$ BtnEdit��5'      $
��Edit��6&     
ButtonSPEl#��[ 65   6Y   5(      �� 5)   
   $��2��6   $	�� 10q�6%   .+�5*      �� $��Demands��6   #��[ 6'   &   System.Windows.Controls.DataGrid  5+      -   5          Name$ 	DgDemands��5+         
IsReadOnly .    AutoGenerateColumns .  $	��150��6X   $��
5, 5, 5, 5q�6e      SelectionMode$ Single=�6y   	   HeadersVisibility$	 Column=�6�   
   Columns
 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn   Header$
 Type��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *RealEstateFilterSet.Type+  5.      $ Client��6)    69   �� *%#PersonSet_Client.PersonSet.FullName+  5/      $ Agent��6)    68   �� *$"PersonSet_Agent.PersonSet.FullName+  50      $ Address��6)    6:   �� *Address_City+  51      $ 	Max Price��6)    6<   �� *
MaxPrice+53      �� 54      $��Supplies��6   #��[ 6(     55      -   5        $ 
DgSupplies��55       .  .  $	��150��6Y   $��
5, 5, 5, 5q�6f   $ Single=�6z   $	 Column=�6�   
 56        57      $ 
RealEstate��6)    6=   �� *RealEstateSet.Info+  58      $ Price��6)    68   �� *Price+  59      $ Client��6)    69   �� *%#PersonSet_Client.PersonSet.FullName+  5:      $ Agent��6)    68   �� *$"PersonSet_Agent.PersonSet.FullName+5<      5=      5>      5?      