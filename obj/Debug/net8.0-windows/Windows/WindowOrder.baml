   M S B A M L   `   `   `  ����G  CConfectioner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Confectioner.WindowsConfectioner.Windows  5   	   &     Confectioner.Windows.WindowOrder   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Confectioner.Windows     5   	     � Title$  Заказы��5      $	��450��6   $	��800��6,   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��60* �6   �� 5      $
��270* �6   �� 5      $	��60* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��dtgorder��5         AutoGenerateColumns$ False��6R      CanUserAddRows$ False��5      $��
10,5,219,5q�6   $��1��6,      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Количество��5         Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6#   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   %   �� *
Quantity+5   #     5      $ Цена��5      $ 1* 6    5   %   �� *Price+5        5      $ Дата выдачи��5      $ 1* 6$    5   %   �� *DateOfIssue+5   $     5      $ Дата заказа��5      $ 1* 6$    5   %   �� *	DataOrder+5   $     5      $ Код клиента��5      $ 1* 6$    5   %   �� *Client.FirstName+5   $     5      $% Код ассортимента��5      $ 1* 6)    5   %   �� *Assortment.ProductName+5   )   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 Auto 6)      CellTemplate 5      �� 5       .R�5!      �� $��BtnEditProductor��6%   -   5        $ ��Редактировать��5#   !   5$      5&      5(      �� 5*   
   ���#DEB887$	��100q�6'   $��0,-1,0,1q�5+      �� 5,   
   ���#DEB887$	��100q�6'   $��0,4,0,0q�5-      $��2��6   �� 5/   
   -   5        	 ��Name$	 texts��5/      $��Заказы��50      $��	70,15,0,0q�51      $��25(�52      
 J� RenderTransformOrigin$
 0.5,0.5&�6   
���   �$
��Left=�53      $	��Top=�54      �� 55   
   -   5         ��Name$ Button_ADD_tr��55      $��Добавление��6(   $
��Left=�6=   $��	625,0,0,0q�56      $��Center=�6   $��28��6O   $	��138��6[   
���   �$��12(�57      $��2��6%   $
 -1.03,-1.746&�62   �� 58   
   -   5        $ Button_delete_tre��58      $��Удаление��6,   $
��Left=�6?   $��	462,0,0,0q�59      $��Center=�6   $��28��6P   $	��138��6\   
���   �$��12(�5:      $��2��6#   $
 -1.03,-1.746&�60   �� 5;   
   -   5        $ Button_back_tre��5;      $��На главную��6*   $
��Left=�6?   $��10,0,0,0q�5<      $��Center=�6   $��28��6.   $	��100��6:   
���   �$��12(�5=      $��2��6#   $
 -1.03,-1.746&�6N   �� 5>   
    �� Orientation$ Vertical=�6   $	��Top=�5?      $	��279��6'   $��2��64   .+�5@      �� $(��"Сортировка по цене��6   $��
600,85,1,1q�5A      �� 5B      $ Vertical=�6   $��54��60   .+�5C      	� -   5        $��	rdUp_four��5C      $!��По возрастанию��6/   $��
600,10,1,1q�6a   	� 5D      -   5        $��rdDown_four��5D      $��По убыванию��61   $��
600,10,1,1q�6b   5E      �� 5F      $$��Поиск по клиенту��6   $��
600,10,1,1q�61   �� 5G      -	   5         ��Name$ txtSearch_tr��5G      $��
600,0,30,1q�5H      5I      5J      5K      