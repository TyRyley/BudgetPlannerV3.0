﻿#pragma checksum "..\..\RentOrBuy.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "703A9281E97CE68CFA2B2133E6BBC2E9A8448D998B0843CA155BDB2D617D16AC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BudgetPlannerV3._0;
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


namespace BudgetPlannerV3._0 {
    
    
    /// <summary>
    /// RentOrBuy
    /// </summary>
    public partial class RentOrBuy : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\RentOrBuy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button rentBtn;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\RentOrBuy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buyBtn;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\RentOrBuy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button helpBtn;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\RentOrBuy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/BudgetPlannerV3.0;component/rentorbuy.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RentOrBuy.xaml"
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
            this.rentBtn = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\RentOrBuy.xaml"
            this.rentBtn.Click += new System.Windows.RoutedEventHandler(this.rentBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.buyBtn = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\RentOrBuy.xaml"
            this.buyBtn.Click += new System.Windows.RoutedEventHandler(this.buyBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.helpBtn = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\RentOrBuy.xaml"
            this.helpBtn.Click += new System.Windows.RoutedEventHandler(this.helpBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.backBtn = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\RentOrBuy.xaml"
            this.backBtn.Click += new System.Windows.RoutedEventHandler(this.backBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

