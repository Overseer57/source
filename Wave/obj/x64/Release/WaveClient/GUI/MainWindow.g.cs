﻿#pragma checksum "..\..\..\..\..\WaveClient\GUI\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "00C4A9C82E8BFC9E9119ABADD375FE1FF18D2DA0EF8F7C0FA972BD3F9E7FAA6C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using System.Windows.Forms;
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
using WaveClient.GUI;


namespace WaveClient.GUI {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\..\WaveClient\GUI\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Chrome;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\WaveClient\GUI\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TitleBlock;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\WaveClient\GUI\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Controls;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\WaveClient\GUI\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse Control_Minimize;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\WaveClient\GUI\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse Control_Maximize;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\WaveClient\GUI\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse Control_Close;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\WaveClient\GUI\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Content;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\WaveClient\GUI\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame NavigationFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/WaveClient;component/waveclient/gui/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\WaveClient\GUI\MainWindow.xaml"
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
            this.Chrome = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.TitleBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.Controls = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.Control_Minimize = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 19 "..\..\..\..\..\WaveClient\GUI\MainWindow.xaml"
            this.Control_Minimize.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Control_Minimize_MouseUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Control_Maximize = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 20 "..\..\..\..\..\WaveClient\GUI\MainWindow.xaml"
            this.Control_Maximize.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Control_Maximize_MouseUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Control_Close = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 21 "..\..\..\..\..\WaveClient\GUI\MainWindow.xaml"
            this.Control_Close.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Control_Close_MouseUp);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Content = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.NavigationFrame = ((System.Windows.Controls.Frame)(target));
            
            #line 25 "..\..\..\..\..\WaveClient\GUI\MainWindow.xaml"
            this.NavigationFrame.Navigating += new System.Windows.Navigation.NavigatingCancelEventHandler(this.NavigationFrame_Navigated);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

