   M S B A M L   `   `   `  ����I  EAdventureWorks, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:AdventureWorksAdventureWorks  5      X TAdventureWorks.ViewModelLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulltRclr-namespace:AdventureWorks.ViewModelLayer;assembly=AdventureWorks.ViewModelLayerAdventureWorks.ViewModelLayer 5      )    #AdventureWorks.ProductDetailControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:AdventureWorks     5      avmRclr-namespace:AdventureWorks.ViewModelLayer;assembly=AdventureWorks.ViewModelLayer     5      -   5          � 	Resources  5!      4  .AdventureWorks.ViewModelLayer.ProductViewModel   	viewModel��%   &	          5"   
   6   5#      .��5$      �  � DataContext# [  6    � ColumnDefinitions 5%   
   �� 5&      $
��Auto �6   �� 5'      $��* �6    � RowDefinitions 5)   
   �� 5*      $
��Auto �6   �� 5+      $
��Auto �6   �� 5,      $
��Auto �6   �� 5-      $
��Auto �6   �� 5.      $
��Auto �6   �� 5/      $
��Auto �6   �� 50      $
��Auto �6   �� 51      $
��Auto �6   �� 52      $
��Auto �6   �� 53      $
��Auto �6   �� 54      $
��Auto �6   �� 55      $
��Auto �6   �� 56      $
��Auto �6   �� 57      $
��Auto �6   .+�59   
   �� $��0��6   $��
Product ID��5:      �� 5;   
   $��0��6   $��1��5<      ��5=      ��  �� Path$ Entity.ProductID��� 5>   
   $��1��6   $��Product Name��5?      �� 5@   
   $��1��6   $��1��5A      ��5B      �� $ Entity.Name��� 5C   
   $��2��6   $��Product Number��5D      �� 5E   
   $��2��6   $��1��5F      ��5G      �� $ Entity.ProductNumber��� 5H   
   $��3��6   $��Color��5I      �� 5J   
   $��3��6   $��1��5K      ��5L      �� $ Entity.Color��� 5M   
   $��4��6   $��Standard Cost��5N      �� 5O   
   $��4��6   $��1��5P      ��5Q      �� $ Entity.StandardCost��� 5R   
   $��5��6   $��
List Price��5S      �� 5T   
   $��5��6   $��1��5U      ��5V      �� $ Entity.ListPrice��� 5W   
   $��6��6   $
��Size��5X      �� 5Y   
   $��6��6   $��1��5Z      ��5[      �� $ Entity.Size��� 5\   
   $��7��6   $��Weight��5]      �� 5^   
   $��7��6   $��1��5_      ��5`      �� $ Entity.Weight��� 5a   
   $��8��6   $��Sell Start Date��5b      �� 5c   
   $��8��6   $��1��5d      ��5e      �� $ Entity.SellStartDate��� 5f   
   $��9��6   $��Sell End Date��5g      �� 5h   
   $��9��6   $��1��5i      ��5j      �� $ Entity.SellEndDate�.��69   5k      5l      5m      