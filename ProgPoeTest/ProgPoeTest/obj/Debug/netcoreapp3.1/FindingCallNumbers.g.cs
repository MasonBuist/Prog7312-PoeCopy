﻿#pragma checksum "..\..\..\FindingCallNumbers.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53B1DE60493BE657CB7C8330A31369201D76E3C7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ProgPoeTest;
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


namespace ProgPoeTest {
    
    
    /// <summary>
    /// FindingCallNumbers
    /// </summary>
    public partial class FindingCallNumbers : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\FindingCallNumbers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStart;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\FindingCallNumbers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblQheader;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\FindingCallNumbers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEnd;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\FindingCallNumbers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblScore;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\FindingCallNumbers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblQ;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\FindingCallNumbers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbOne;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\FindingCallNumbers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbTwo;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\FindingCallNumbers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbThr;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\FindingCallNumbers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbFou;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\FindingCallNumbers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblQheader_Copy;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProgPoeTest;component/findingcallnumbers.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\FindingCallNumbers.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnStart = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\FindingCallNumbers.xaml"
            this.btnStart.Click += new System.Windows.RoutedEventHandler(this.btnStart_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblQheader = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.btnEnd = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\FindingCallNumbers.xaml"
            this.btnEnd.Click += new System.Windows.RoutedEventHandler(this.btnEnd_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 49 "..\..\..\FindingCallNumbers.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Hint_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lblScore = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.lblQ = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.rbOne = ((System.Windows.Controls.RadioButton)(target));
            
            #line 65 "..\..\..\FindingCallNumbers.xaml"
            this.rbOne.Checked += new System.Windows.RoutedEventHandler(this.rbOne_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.rbTwo = ((System.Windows.Controls.RadioButton)(target));
            
            #line 67 "..\..\..\FindingCallNumbers.xaml"
            this.rbTwo.Checked += new System.Windows.RoutedEventHandler(this.rbTwo_Checked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.rbThr = ((System.Windows.Controls.RadioButton)(target));
            
            #line 69 "..\..\..\FindingCallNumbers.xaml"
            this.rbThr.Checked += new System.Windows.RoutedEventHandler(this.rbThr_Checked);
            
            #line default
            #line hidden
            return;
            case 10:
            this.rbFou = ((System.Windows.Controls.RadioButton)(target));
            
            #line 71 "..\..\..\FindingCallNumbers.xaml"
            this.rbFou.Checked += new System.Windows.RoutedEventHandler(this.rbFou_Checked);
            
            #line default
            #line hidden
            return;
            case 11:
            this.lblQheader_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            
            #line 75 "..\..\..\FindingCallNumbers.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MainMenu_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
