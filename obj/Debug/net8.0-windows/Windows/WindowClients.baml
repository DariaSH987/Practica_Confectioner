   M S B A M L   `   `   `  ����G  CConfectioner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Confectioner.WindowsConfectioner.Windows  5   	   (    "Confectioner.Windows.WindowClients   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Confectioner.Windows     5   	     � Title$  Клиенты��5   	   $	��450��6   $	��800��6&   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��60* �6   �� 5      $
��270* �6   �� 5      $	��60* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��	dtgclient��5         AutoGenerateColumns$ False��6T      CanUserAddRows$ False��5      $��
10,5,234,5q�6   $��1��6,      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��5         Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   %   �� *	FirstName+5        5      $! Номер телефона��5      $ 1* 6'    5   %   �� *Phone+5   '     5      $ 
Адрес��5      $ 1* 6    5   %   �� *	Address+5      4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 Auto 6)      CellTemplate 5      �� 5      .R�5      �� $��BtnEdit��6%   -   5        $ ��Редактировать��5   !   5      5       5"      �� 5$   
   ���#DEB887$	��100q�6'   $��0,-1,0,1q�5%      �� 5&   
   ���#DEB887$	��100q�6'   $��0,4,0,0q�5'      $��2��6   �� 5)   
   -   5        	 ��Name$	 texts��5)      $��Клиенты��5*      $��	70,15,0,0q�5+      $��25(�5,      
 J� RenderTransformOrigin$
 0.5,0.5&�6   
���   �$
��Left=�5-      $	��Top=�5.      �� 5/   
   -   5         ��Name$ 
Button_ADD��5/      $��Добавление��50      $
��Left=�51      $��	625,0,0,0q�52      $��Center=�53      $��28��54      $	��138��55      
���   �$��12(�57      $��2��6   $
 -1.03,-1.746&�59      �� 5:   
   -   5        $ Button_delete��5:      $��Удаление��5;      $
��Left=�5<      $��	462,0,0,0q�5=      $��Center=�5>      $��28��5@      $	��138��5A      
���   �$��12(�5C      $��2��6   $
 -1.03,-1.746&�5D      �� 5E   
   -   5        $ Button_back��5E      $��На главную��5F      $
��Left=�5G      $��10,0,0,0q�5H      $��Center=�5I      $��28��5J      $	��100��5K      
���   �$��12(�5M      $��2��6   $
 -1.03,-1.746&�5O      �� 5P   
    �� Orientation$ Vertical=�6   $	��Top=�5Q      $	��279��6'   $��2��64   .+�5R      �� $%��Сортировка Имени��6   $��
600,85,1,1q�5S      �� 5T      $ Vertical=�6   $��54��60   .+�5U      	� -   5        $
��rdUp��5U      $!��По возрастанию��6*   $��
600,10,1,1q�6V   	� 5V      -   5        $��rdDown��5V      $��По убыванию��6,   $��
600,10,1,1q�6W   5W      �� 5X      $3��-Поиск по номеру телефона��6   $��
600,30,1,1q�69   �� 5Y      -	   5         ��Name$ 	txtSearch��5Y      $��
600,0,30,1q�5Z   *   �� 5[      $,��&Фильтрация по адресу��6   $��
600,0,50,1q�65   �� 5\      -
   5        $��
cmbclients��5\      $��
600,0,30,1q�5]   6   5^      5_      5`      