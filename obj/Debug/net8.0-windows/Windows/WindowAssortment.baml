   M S B A M L   `   `   `  ����G  CConfectioner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Confectioner.WindowsConfectioner.Windows  5   	   +    %Confectioner.Windows.WindowAssortment   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Confectioner.Windows     5   	     � Title$  Ассортимент��5   	   $	��450��6   $	��800��6*   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��60* �6   �� 5      $
��270* �6   �� 5      $	��60* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��dtgassortiment��5         AutoGenerateColumns$ False��6^      CanUserAddRows$ False��5      $��
10,5,234,5q�6   $��1��6,      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$' !Название продукта��5         Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6*   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   %   �� *ProductName+5   *     5      $ Начинка��5      $ 1* 6     5   %   �� *
Stuffing+5         5      $ 
Декор��5      $ 1* 6    5   %   �� *Decor+5        5      $ Поставщик��5   %   $ 1* 68    5   %   �� *Supplier.SuppliersName+5   8     5      $ Цена��5   %   $ 1* 63    5   %   �� *Price+5   3   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 Auto 6)      CellTemplate 5      �� 5      .R�5      �� $��BtnEditProduct_four��6%   -   5        $ ��Редактировать��5!   !   5"      5$      5&      �� 5(   
   ���#DEB887$	��100q�6'   $��0,-1,0,1q�5)      �� 5*   
   ���#DEB887$	��100q�6'   $��0,4,0,0q�5+      $��2��6   �� 5-   
   -   5        	 ��Name$	 texts��5-      $��Ассортимент��5.      $��	70,15,0,0q�5/      $��25(�50      
 J� RenderTransformOrigin$
 0.5,0.5&�6   
���   �$
��Left=�51      $	��Top=�52      �� 53   
   -   5         ��Name$ Button_ADD_four��53      $��Добавление��6*   $
��Left=�6?   $��	625,0,0,0q�54      $��Center=�6   $��28��61   $	��138��6=   
���   �$��12(�55      $��2��6%   $
 -1.03,-1.746&�6Q   �� 56   
   -   5        $ Button_delete_four��56      $��Удаление��6-   $
��Left=�6@   $��	462,0,0,0q�57      $��Center=�6   $��28��6Q   $	��138��6]   
���   �$��12(�58      $��2��6#   $
 -1.03,-1.746&�61   �� 59   
   -   5        $ Button_back_four��59      $��На главную��6+   $
��Left=�6@   $��10,0,0,0q�5:      $��Center=�6   $��28��6.   $	��100��6:   
���   �$��12(�5;      $��2��6#   $
 -1.03,-1.746&�6P   �� 5<   
    �� Orientation$ Vertical=�6   $	��Top=�5=      $	��279��6'   $��2��64   .+�5>      �� $.��(Сортировка по начинке��6   $��
600,85,1,1q�5?      �� 5@      $ Vertical=�6   $��54��60   .+�5A      	� -   5        $��rdUp_two��5A      $!��По возрастанию��6.   $��
600,10,1,1q�6^   	� 5B      -   5        $��
rdDown_two��5B      $��По убыванию��60   $��
600,10,1,1q�6`   5C      �� 5D      $"��Поиск по декору��6   $��
600,30,1,1q�60   �� 5E      -	   5         ��Name$ txtSearch_four��5E      $��
600,0,30,1q�5F   /   �� 5G      $+��%Фильтрация названию��6   $��
600,0,50,1q�64   $	��145��6H   �� 5H      -
   5        $��cmbassortment��5H      $��
600,0,30,1q�5I   9   5J      5K      5L      