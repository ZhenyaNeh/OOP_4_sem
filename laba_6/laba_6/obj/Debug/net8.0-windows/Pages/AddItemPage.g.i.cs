﻿#pragma checksum "..\..\..\..\Pages\AddItemPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EDAD672002C7AF12E87B8E7BD4DDF1A0849415FB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using laba_6;


namespace laba_6 {
    
    
    /// <summary>
    /// AddItemPage
    /// </summary>
    public partial class AddItemPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\..\Pages\AddItemPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back_Button;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Pages\AddItemPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock AddTitle;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Pages\AddItemPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image AddImageItem;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Pages\AddItemPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Price_TextBox;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Pages\AddItemPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CPU_TextBox;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\Pages\AddItemPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GPU_TextBox;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\Pages\AddItemPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox descriptionFieldRus;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\Pages\AddItemPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox descriptionFieldEng;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\Pages\AddItemPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddItem;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/laba_6;V1.0.0.0;component/pages/additempage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\AddItemPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Back_Button = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\Pages\AddItemPage.xaml"
            this.Back_Button.Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AddTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.AddImageItem = ((System.Windows.Controls.Image)(target));
            
            #line 43 "..\..\..\..\Pages\AddItemPage.xaml"
            this.AddImageItem.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.AddImageItem_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Price_TextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 47 "..\..\..\..\Pages\AddItemPage.xaml"
            this.Price_TextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Price_TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CPU_TextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 63 "..\..\..\..\Pages\AddItemPage.xaml"
            this.CPU_TextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.CPU_TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.GPU_TextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 67 "..\..\..\..\Pages\AddItemPage.xaml"
            this.GPU_TextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.GPU_TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.descriptionFieldRus = ((System.Windows.Controls.TextBox)(target));
            
            #line 79 "..\..\..\..\Pages\AddItemPage.xaml"
            this.descriptionFieldRus.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.descriptionFieldRus_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.descriptionFieldEng = ((System.Windows.Controls.TextBox)(target));
            
            #line 84 "..\..\..\..\Pages\AddItemPage.xaml"
            this.descriptionFieldEng.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.descriptionFieldEng_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.AddItem = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\..\Pages\AddItemPage.xaml"
            this.AddItem.Click += new System.Windows.RoutedEventHandler(this.AddItem_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

