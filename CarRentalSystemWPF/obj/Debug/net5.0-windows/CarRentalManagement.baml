   M S B A M L   `   `   `  ????O  KVuNguyenHuyChuongWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:VuNguyenHuyChuongWPFVuNguyenHuyChuongWPF  5   	   .    (VuNguyenHuyChuongWPF.CarRentalManagement   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:VuNguyenHuyChuongWPF     5   	     ? Title$  CarRentalManagement??5   	   $	??450??6%   $	??800??62   .??5	      ? .+?5
   
   ?? .+?5      ??  ?? Orientation$ 
Horizontal=?6   $??	0,12,0,12q?62   .+?5      ?? -   5         ??Name$ txtCarId??5      $??39??6,   ${?False??67   $y?Hidden=?6?   ??6I   ??  ?? Path$ CarId? ?? Mode$ OneWay=? ? DataContext 6r   ?? *SelectedItem+ ?? ElementName$ lsvCarRental??6?   ?? 5      -   5        $ txtCustomerId??5      $??39??61   ${?False??6<   $y?Hidden=?6?   ??6N   ?? $ 
CustomerId?$ OneWay=? 6|   ?? *SelectedItem+$ lsvCarRental??6?   5      ?? 5      -   5         ??Name$ lsvCarRental??5      $	??310??6-    ?? View 5      ?? 5      .P?5      ?? $??
CustomerId??6)   	 ?? Width$		 125??6=   
 ?? DisplayMemberBinding
 6I   ?? *
CustomerId+?? 5      $??CarId??6)   $		 120??68   
 6D   ?? *CarId+?? 5      $??
PickupDate??6)   $		 120??6=   
 6I   ?? *
PickupDate+?? 5      $??
ReturnDate??6)   $		 150??6=   
 6I   ?? *
ReturnDate+?? 5      $??	RentPrice??6)   $		 100??6<   
 6H   ?? *	RentPrice+5      5      ?? 5      $ 
Horizontal=?6   $??0,8,0,0q?62   .+?5      ?? -   5         ??Name$ btnAdd??5      $	??Add??6)   $	??120??67   $??45,0,0,0q?6C   $??30??6U   6a   ?? 5      -   5        $ 	btnUpdate??5      $??Update??6,   $	??120??6=   $??25,0,0,0q?6I   6[   ?? 5      -   5        $ 	btnDelete??5      $??Delete??6,   $	??120??6=   $??25,0,0,0q?6I   6[   ?? 5      -   5        $ 	btnCancel??5      $??Cancel??6,   $	??120??6=   $??25,0,0,0q?6I   6[   5      5       5!      5"      