﻿#pragma checksum "..\..\..\..\..\..\Acsess\View\Pages\UserPagesLink\UserHomePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C98BAB287C2BEABFCE6902ADC1C1D329E904DD364080B6CC1D0C18506F3C778B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using GasFlowControlManager.Acsess.View.Pages.UserPagesLink;
using MaterialDesignThemes.MahApps;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace GasFlowControlManager.Acsess.View.Pages.UserPagesLink {
    
    
    /// <summary>
    /// UserHomePage
    /// </summary>
    public partial class UserHomePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\..\..\Acsess\View\Pages\UserPagesLink\UserHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Hello;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\..\Acsess\View\Pages\UserPagesLink\UserHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock userName;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\..\..\Acsess\View\Pages\UserPagesLink\UserHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock coutAgr;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\..\..\Acsess\View\Pages\UserPagesLink\UserHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBox_search;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\..\..\Acsess\View\Pages\UserPagesLink\UserHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBox;
        
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
            System.Uri resourceLocater = new System.Uri("/GasFlowControlManager;component/acsess/view/pages/userpageslink/userhomepage.xam" +
                    "l", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Acsess\View\Pages\UserPagesLink\UserHomePage.xaml"
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
            
            #line 15 "..\..\..\..\..\..\Acsess\View\Pages\UserPagesLink\UserHomePage.xaml"
            ((GasFlowControlManager.Acsess.View.Pages.UserPagesLink.UserHomePage)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Page_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Hello = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.userName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.coutAgr = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.TBox_search = ((System.Windows.Controls.TextBox)(target));
            
            #line 75 "..\..\..\..\..\..\Acsess\View\Pages\UserPagesLink\UserHomePage.xaml"
            this.TBox_search.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.listBox = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

