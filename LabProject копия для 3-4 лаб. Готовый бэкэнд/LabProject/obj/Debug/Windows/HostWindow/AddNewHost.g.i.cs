﻿#pragma checksum "..\..\..\..\Windows\HostWindow\AddNewHost.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D7A93038B6B9154C7DD2EC4D4B853D09E6FA811F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using LabProject;
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


namespace LabProject {
    
    
    /// <summary>
    /// AddNewHost
    /// </summary>
    public partial class AddNewHost : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 47 "..\..\..\..\Windows\HostWindow\AddNewHost.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox AllRooms;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\Windows\HostWindow\AddNewHost.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker StartDate;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\Windows\HostWindow\AddNewHost.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker EndDate;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\..\Windows\HostWindow\AddNewHost.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Name;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\..\..\Windows\HostWindow\AddNewHost.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Photo;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\..\Windows\HostWindow\AddNewHost.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Date;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\..\..\Windows\HostWindow\AddNewHost.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Comments;
        
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
            System.Uri resourceLocater = new System.Uri("/LabProject;component/windows/hostwindow/addnewhost.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\HostWindow\AddNewHost.xaml"
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
            this.AllRooms = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            
            #line 61 "..\..\..\..\Windows\HostWindow\AddNewHost.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.InfoAboutApartment);
            
            #line default
            #line hidden
            return;
            case 3:
            this.StartDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.EndDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            
            #line 88 "..\..\..\..\Windows\HostWindow\AddNewHost.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Find);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Photo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.Date = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.Comments = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 166 "..\..\..\..\Windows\HostWindow\AddNewHost.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddNewGuest);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

