   M S B A M L   `   `   `  ����G  CConfectioner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Confectioner.WindowsConfectioner.Windows  5   	   +    %Confectioner.Windows.EditClientWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Confectioner.Windows     5   	     � Title$/  )Редактировать клиента��5   
   $	��550��6(   $	��700��65   .��5	      � ���#FFEBCD$��0,0,0,3q�6     � RowDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��3* �6   .+�5   
   �� $��Имя��6   $��0��5      $��0��5      �� 5   
   -   5        $��txtname��5      $��0��5      $��1��5      ��5      �� *	FirstName+5      �� 5   
   $!��Номер телефона��6   $��1��5   
   $��0��5   
   �� 5    
   -   5        $��txtphone��5       $��1��5"      $��1��5#      ��5!      �� *Phone+5#      �� 5%   
   $��
Адрес��6   $��2��5&   
   $��0��5'   
   �� 5(   
   -   5        $��
txtaddress��5(      $��2��5*      $��1��5+      ��5)      �� *	Address+5+      �� 5.   
   -   5        $��BtnSave_edit��54      $ ��Редактировать��5.      ���#DEB887$��4��50      $	��150��51      $��30��52      $��18(�53       J� RenderTransformOrigin$ 0.956,0.675&�55   -   $��1��6Q   $��250,5,20,61q�6a   �� 56   
   -   5        $��Btnback_edit��5<      $��
Назад��56      ���#DEB887$��4��58      $	��150��59      $��30��5:      $��18(�5;      $ 0.956,0.675&�5=   -   $��10,5,120,61q�6Q   5>      5?      