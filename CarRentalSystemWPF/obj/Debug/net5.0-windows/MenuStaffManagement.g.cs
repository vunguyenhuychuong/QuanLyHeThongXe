#pragma checksum "..\..\..\MenuStaffManagement.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A553D3AA94B9686528BAB6FB248C149EA7A81DD6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CarRentalSystemWPF;
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


namespace CarRentalSystemWPF {
    
    
    /// <summary>
    /// MenuStaffManagement
    /// </summary>
    public partial class MenuStaffManagement : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\MenuStaffManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSelectedId;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\MenuStaffManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnViewProfile;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\MenuStaffManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCarManagement;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\MenuStaffManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCustomerManagement;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\MenuStaffManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/VuNguyenHuyChuongWPF;component/menustaffmanagement.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MenuStaffManagement.xaml"
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
            this.txtSelectedId = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\..\MenuStaffManagement.xaml"
            this.txtSelectedId.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtSelectedId_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnViewProfile = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\MenuStaffManagement.xaml"
            this.btnViewProfile.Click += new System.Windows.RoutedEventHandler(this.btnMemberManagement_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnCarManagement = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\MenuStaffManagement.xaml"
            this.btnCarManagement.Click += new System.Windows.RoutedEventHandler(this.btnCarManagement_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnCustomerManagement = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\MenuStaffManagement.xaml"
            this.btnCustomerManagement.Click += new System.Windows.RoutedEventHandler(this.btnCustomerManagement_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\MenuStaffManagement.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.btnCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

