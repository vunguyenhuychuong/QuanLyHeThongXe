﻿#pragma checksum "..\..\..\CarRentalManagementPopUp.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8AD394C3B59DB69F62FAF615E3527F1A8C5C747F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using VuNguyenHuyChuongWPF;


namespace VuNguyenHuyChuongWPF {
    
    
    /// <summary>
    /// CarRentalManagementPopUp
    /// </summary>
    public partial class CarRentalManagementPopUp : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\CarRentalManagementPopUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbAdd_Update;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\CarRentalManagementPopUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCustomerId;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\CarRentalManagementPopUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCarId;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\CarRentalManagementPopUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPickupDate;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\CarRentalManagementPopUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtReturnDate;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\CarRentalManagementPopUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRentPrice;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\CarRentalManagementPopUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd_Update;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\CarRentalManagementPopUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/VuNguyenHuyChuongWPF;component/carrentalmanagementpopup.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CarRentalManagementPopUp.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lbAdd_Update = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.txtCustomerId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtCarId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtPickupDate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtReturnDate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtRentPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnAdd_Update = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\CarRentalManagementPopUp.xaml"
            this.btnAdd_Update.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Update_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\CarRentalManagementPopUp.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
