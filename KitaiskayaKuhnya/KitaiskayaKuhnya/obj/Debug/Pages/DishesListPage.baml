   M S B A M L   `   `   `  ����K  GKitaiskayaKuhnya, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:KitaiskayaKuhnya.PagesKitaiskayaKuhnya.Pages  5      +    %KitaiskayaKuhnya.Pages.DishesListPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:KitaiskayaKuhnya.Pages     5        N� Title$  DishesListPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGridDishes��5         
IsReadOnly .    AutoGenerateColumns .  
���  ��   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *id+  5      $ TypeDish��6%    67   �� *
idTypeDish+  5      $
 Name��6%    63   �� *Name+  5      $
 Cost��6%    63   �� *Cost+  5      $ ProductionCost��6%    6=   �� *ProductionCost+  5      $ StoplistStatus��6%    6=   �� *StoplistStatus+5      �� 5   
   -   5         ��Name$ 	AddButton��5      $��1��6$   $!��Добавить блюдо��61   
��� ���6^   �� 5   
   -   5        $ 
BackButton��5      $��2��6%   $��
Назад��62   
��� ���6V   5      5      