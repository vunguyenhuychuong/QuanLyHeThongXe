   M S B A M L   `   `   `  ????O  KVuNguyenHuyChuongWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CarRentalSystemWPFCarRentalSystemWPF  5   	   &     CarRentalSystemWPF.CarManagement   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:CarRentalSystemWPF     5   	     ? Title$  CarManagement??5   	   $	??450??6   $	??959??6,   .??5	      ? .+?5
   
   ?? .+?5      ??  ?? Orientation$ 
Horizontal=?6   $??	0,12,0,12q?62   .+?5      ?? .??6   Selected id:6&   ?? 5      -   5         ??Name$ txtSelectedId??5      $??86??61   ${?False??6<   ??6N   ??  ?? Path$ CarId? ?? Mode$ OneWay=? ? DataContext 6w   ??  ?? ElementName$ lsvCar??$ SelectedItem?6?   5      ?? 5      -   5         ??Name$ lsvCar??5      $	??310??6'    ?? View 5      ?? 5      .P?5      ?? $??CarID??6)   	 ?? Width$	 80??68   
 ?? DisplayMemberBinding
 6C   ?? *CarId+?? 5      $??CarName??6)   $		 100??6:   
 6F   ?? *	CarName+?? 5      $??CarModelYear??6)   $		 100??6?   
 6K   ?? *CarModelYear+?? 5      $??Capacity??6)   $		 100??6;   
 6G   ?? *
Capacity+?? 5      $??Color??6)   $		 100??68   
 6D   ?? *Color+?? 5      $??Description??6)   $		 100??6>   
 6J   ?? *Description+?? 5      $??
ImportDate??6)   $		 100??6=   
 6I   ?? *
ImportDate+?? 5      $??	RentPrice??6)   $		 100??6<   
 6H   ?? *	RentPrice+?? 5      $??Status??6)   $	 80??69   
 6D   ?? *Status+?? 5      $??
ProducerID??6)   $		 100??6=   
 6I   ?? *
ProducerId+5      5      ?? 5      $ 
Horizontal=?6   $??0,8,0,0q?62   .+?5       ?? -   5         ??Name$ btnAdd??5       $	??Add??6)   $	??150??67   $??45,0,0,0q?6C   $??30??6U   6a   ?? 5!      -   5        $ 	btnUpdate??5!      $??Update??6,   $	??150??6=   $??25,0,0,0q?6I   6[   ?? 5"      -   5        $ 	btnDelete??5"      $??Delete??6,   $	??150??6=   $??25,0,0,0q?6I   6[   ?? 5#      -   5        $ 	btnCancel??5#      $??Cancel??6,   $	??150??6=   $??25,0,0,0q?6I   6[   5$      5%      5&      5'      