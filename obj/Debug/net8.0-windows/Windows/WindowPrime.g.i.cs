﻿#pragma checksum "..\..\..\..\Windows\WindowPrime.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E55A934A681BE1F80877046B9C771DBC070ED0D7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Confectioner.Windows;
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


namespace Confectioner.Windows {
    
    
    /// <summary>
    /// WindowPrime
    /// </summary>
    public partial class WindowPrime : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\Windows\WindowPrime.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Clients;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Windows\WindowPrime.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Assortment;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Windows\WindowPrime.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_suppliers;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Windows\WindowPrime.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Orders;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Confectioner;component/windows/windowprime.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\WindowPrime.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Button_Clients = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\Windows\WindowPrime.xaml"
            this.Button_Clients.Click += new System.Windows.RoutedEventHandler(this.Button_Clients_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Button_Assortment = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\Windows\WindowPrime.xaml"
            this.Button_Assortment.Click += new System.Windows.RoutedEventHandler(this.Button_Assortment_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Button_suppliers = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\Windows\WindowPrime.xaml"
            this.Button_suppliers.Click += new System.Windows.RoutedEventHandler(this.Button_suppliers_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Button_Orders = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\Windows\WindowPrime.xaml"
            this.Button_Orders.Click += new System.Windows.RoutedEventHandler(this.Button_Orders_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
