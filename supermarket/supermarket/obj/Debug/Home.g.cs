﻿#pragma checksum "..\..\Home.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A9607B376557F44F1CA272BBD72C5BBE4B36767BDA791A297AFD63B41C159DC2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using supermarket;


namespace supermarket {
    
    
    /// <summary>
    /// Home
    /// </summary>
    public partial class Home : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Home_Grid;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button New_Billing;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Employees_Mang;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid New_Billing_Grid;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LV_New_Billing;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Bestellung;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Rechnungskosten;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Employees_Mang_Grid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/supermarket;component/home.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Home.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Home_Grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.New_Billing = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\Home.xaml"
            this.New_Billing.Click += new System.Windows.RoutedEventHandler(this.New_Billing_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Employees_Mang = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\Home.xaml"
            this.Employees_Mang.Click += new System.Windows.RoutedEventHandler(this.Employees_Mang_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.New_Billing_Grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            
            #line 80 "..\..\Home.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Home_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LV_New_Billing = ((System.Windows.Controls.ListView)(target));
            
            #line 113 "..\..\Home.xaml"
            this.LV_New_Billing.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.LV_New_Billing_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Bestellung = ((System.Windows.Controls.DataGrid)(target));
            
            #line 143 "..\..\Home.xaml"
            this.Bestellung.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.Bestellung_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Rechnungskosten = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.Employees_Mang_Grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 10:
            
            #line 181 "..\..\Home.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Home_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 207 "..\..\Home.xaml"
            ((System.Windows.Controls.DataGrid)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.Bestellung_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

