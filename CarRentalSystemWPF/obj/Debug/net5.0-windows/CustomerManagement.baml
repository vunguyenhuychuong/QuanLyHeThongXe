   M S B A M L   `   `   `  ????O  KVuNguyenHuyChuongWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CarRentalSystemWPFCarRentalSystemWPF  5   	   +    %CarRentalSystemWPF.CustomerManagement   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:CarRentalSystemWPF     5   	     ? Title$  CustomerManagement??5   	   $	??450??6$   $	??800??61   .??5	      ? .+?5
   
   ? .+?5      ?? .+?5      ??  ?? Orientation$ 
Horizontal=?6   $??	0,12,0,12q?66   .+?5      ?? .??6   Selected id:6*   ?? 5      -   5         ??Name$ txtSelectedId??5      $??86??65   ${?False??6@   ??6R   ??  ?? Path$ 
CustomerId? ?? Mode$ OneWay=? ? DataContext 6?   ??  ?? ElementName$ lsvCustomer??$ SelectedItem?6?   5      ?? 5      -   5         ??Name$ lsvCustomer??5      $	??310??60    ?? View 5      ?? 5      .P?5      ?? $??
CustomerID??6-   	 ?? Width$		 100??6A   
 ?? DisplayMemberBinding
 6M   ?? *
CustomerId+?? 5      $??CustomerName??6-   $		 230??6C   
 6O   ?? *CustomerName+?? 5      $??Mobile??6-   $		 120??6=   
 6I   ?? *Mobile+?? 5      $??CustomerEmail??6-   $		 100??6D   
 6P   ?? *CustomerEmail+?? 5      $??CustomerPassword??6-   $		 100??6G   
 6S   ?? *CustomerPassword+?? 5      $??IdentityCard??6-   $		 100??6C   
 6O   ?? *IdentityCard+?? 5      $??LicenseNumber??6-   $		 100??6D   
 6P   ?? *LicenceNumber+?? 5      $??LicenseDate??6-   $		 100??6B   
 6N   ?? *LicenceDate+5      5      ?? 5      $ 
Horizontal=?6   $??0,8,0,0q?66   .+?5      ?? -   5         ??Name$ btnCarRental??5      $??	CarRental??63   $	??120??6G   $??45,0,0,0q?6S   6e   ?? 5       -   5        $ btnAdd??5       $	??Add??6-   $	??120??6;   $??45,0,0,0q?6G   $??30??6Y   6e   ?? 5!      -   5        $ 	btnUpdate??5!      $??Update??60   $	??120??6A   $??25,0,0,0q?6M   6_   ?? 5"      -   5        $ 	btnDelete??5"      $??Delete??60   $	??120??6A   $??25,0,0,0q?6M   6_   ?? 5#      -   5        $ 	btnCancel??5#      $??Cancel??60   $	??120??6A   $??25,0,0,0q?6M   6_   5$      5%      5&      5'      5(      