﻿#pragma checksum "..\..\..\..\Windows\EditSuppliersWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72F1819FF97B553788452A6B39E132F5E22DA2E2"
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
    /// EditSuppliersWindow
    /// </summary>
    public partial class EditSuppliersWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\Windows\EditSuppliersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txttitle;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Windows\EditSuppliersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtgoods;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Windows\EditSuppliersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSave_edi;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Windows\EditSuppliersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btnback_edi;
        
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
            System.Uri resourceLocater = new System.Uri("/Confectioner;component/windows/editsupplierswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\EditSuppliersWindow.xaml"
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
            this.txttitle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtgoods = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.BtnSave_edi = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\Windows\EditSuppliersWindow.xaml"
            this.BtnSave_edi.Click += new System.Windows.RoutedEventHandler(this.BtnSave_edi_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Btnback_edi = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\Windows\EditSuppliersWindow.xaml"
            this.Btnback_edi.Click += new System.Windows.RoutedEventHandler(this.Btnback_edi_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
