﻿#pragma checksum "..\..\..\..\Windows\WindowAddOrders.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78DB8516AEE91F13C1B8081B059519A138C74939"
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
    /// WindowAddOrders
    /// </summary>
    public partial class WindowAddOrders : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\Windows\WindowAddOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtprice;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Windows\WindowAddOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtqua;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Windows\WindowAddOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtdateof;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Windows\WindowAddOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtdateor;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\Windows\WindowAddOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtcl;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Windows\WindowAddOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtassort;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\Windows\WindowAddOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSave_th;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\Windows\WindowAddOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btnback_th;
        
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
            System.Uri resourceLocater = new System.Uri("/Confectioner;component/windows/windowaddorders.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\WindowAddOrders.xaml"
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
            this.txtprice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtqua = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtdateof = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtdateor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtcl = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtassort = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.BtnSave_th = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\..\Windows\WindowAddOrders.xaml"
            this.BtnSave_th.Click += new System.Windows.RoutedEventHandler(this.BtnSave_th_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Btnback_th = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\..\Windows\WindowAddOrders.xaml"
            this.Btnback_th.Click += new System.Windows.RoutedEventHandler(this.Btnback_th_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

