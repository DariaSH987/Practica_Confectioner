   M S B A M L   `   `   `  ����G  CConfectioner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Confectioner.WindowsConfectioner.Windows  5   	   )    #Confectioner.Windows.WindowSupplier   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Confectioner.Windows     5   	     � Title$  Поставщики��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��60* �6   �� 5      $
��270* �6   �� 5      $	��60* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��dtgsuppliers��5         AutoGenerateColumns$ False��6Y      CanUserAddRows$ False��5      $��
10,5,234,5q�6   $��1��6,      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��5         Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6!   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   %   �� *SuppliersName+5   !     5      $ Товары��5      $ 1* 6    5   %   �� *Goods+5      4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 Auto 6)      CellTemplate 5      �� 5      .R�5      �� $��BtnEditProduct_one��6%   -   5        $ ��Редактировать��5   !   5      5      5       �� 5"   
   ���#DEB887$	��100q�6'   $��0,-1,0,1q�5#      �� 5$   
   ���#DEB887$	��100q�6'   $��0,4,0,0q�5%      $��2��6   �� 5'   
   -   5        	 ��Name$	 texts��5'      $��Поставщики��5(      $��	70,15,0,0q�5)      $��25(�5*      
 J� RenderTransformOrigin$
 0.5,0.5&�6   
���   �$
��Left=�5+      $	��Top=�5,      �� 5-   
   -   5         ��Name$ Button_ADD_two��5-      $��Добавление��6)   $
��Left=�6>   $��	625,0,0,0q�5.      $��Center=�6   $��28��61   $	��138��6=   
���   �$��12(�5/      $��2��6%   $
 -1.03,-1.746&�6P   �� 50   
   -   5        $ Button_delete_two��50      $��Удаление��6,   $
��Left=�6?   $��	462,0,0,0q�51      $��Center=�6   $��28��6P   $	��138��6\   
���   �$��12(�52      $��2��6#   $
 -1.03,-1.746&�61   �� 53   
   -   5        $ Button_back_two��53      $��На главную��6*   $
��Left=�6?   $��10,0,0,0q�54      $��Center=�6   $��28��6.   $	��100��6:   
���   �$��12(�55      $��2��6#   $
 -1.03,-1.746&�6O   �� 56   
    �� Orientation$ Vertical=�6   $	��Top=�57      $	��279��6'   $��2��64   .+�58      �� $.��(Сортировка по товарам��6   $��
600,85,1,1q�59      �� 5:      $ Vertical=�6   $��54��60   .+�5;      	� -   5        $��rdUp_one��5;      $!��По возрастанию��6.   $��
600,10,1,1q�6^   	� 5<      -   5        $��
rdDown_one��5<      $��По убыванию��60   $��
600,10,1,1q�6_   5=      �� 5>      $&�� Поиск по названию��6   $��
600,10,1,1q�62   �� 5?      -	   5         ��Name$ txtSearch_two��5?      $��
600,0,30,1q�5@   .   5A      5B      5C      