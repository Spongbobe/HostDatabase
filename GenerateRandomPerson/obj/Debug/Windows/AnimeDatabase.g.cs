﻿#pragma checksum "..\..\..\Windows\AnimeDatabase.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "694FFD6AD4F49EDB59046731F36FD0DADFD2D845721B23E1D6D97C69054C812E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GenerateRandomPerson.Windows;
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


namespace GenerateRandomPerson.Windows {
    
    
    /// <summary>
    /// AnimeDatabase
    /// </summary>
    public partial class AnimeDatabase : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Windows\AnimeDatabase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GenerateRandomPerson.Windows.AnimeDatabase mainWdw;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Windows\AnimeDatabase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid mainGrid;
        
        #line default
        #line hidden
        
        
        #line 172 "..\..\..\Windows\AnimeDatabase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchTb;
        
        #line default
        #line hidden
        
        
        #line 178 "..\..\..\Windows\AnimeDatabase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button searchBtn;
        
        #line default
        #line hidden
        
        
        #line 191 "..\..\..\Windows\AnimeDatabase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView animeListView;
        
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
            System.Uri resourceLocater = new System.Uri("/GenerateRandomPerson;component/windows/animedatabase.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\AnimeDatabase.xaml"
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
            this.mainWdw = ((GenerateRandomPerson.Windows.AnimeDatabase)(target));
            
            #line 16 "..\..\..\Windows\AnimeDatabase.xaml"
            this.mainWdw.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.mainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.searchTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.searchBtn = ((System.Windows.Controls.Button)(target));
            
            #line 179 "..\..\..\Windows\AnimeDatabase.xaml"
            this.searchBtn.Click += new System.Windows.RoutedEventHandler(this.searchTb_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.animeListView = ((System.Windows.Controls.ListView)(target));
            
            #line 190 "..\..\..\Windows\AnimeDatabase.xaml"
            this.animeListView.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.animeListView_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

