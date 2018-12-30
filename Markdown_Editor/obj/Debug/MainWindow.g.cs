﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2B2E21BA79827BA91FB59DC20879DB5F0B092687"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Fluent;
using Fluent.Converters;
using Fluent.Metro.Behaviours;
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


namespace Markdown_Editor {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : Fluent.RibbonWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button btnLoad;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button btnSaveAs;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button btn_bold;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button btn_italic;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button btn_markCode;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button btn_seperator;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button btn_linebreak;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button btn_paragraph;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.DropDownButton ddbtn_Heading;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button btn_quote;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button btn_unquote;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox rtbMainText;
        
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
            System.Uri resourceLocater = new System.Uri("/Markdown_Editor;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.btnLoad = ((Fluent.Button)(target));
            
            #line 24 "..\..\MainWindow.xaml"
            this.btnLoad.Click += new System.Windows.RoutedEventHandler(this.btnLoad_click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnSave = ((Fluent.Button)(target));
            
            #line 27 "..\..\MainWindow.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnSaveAs = ((Fluent.Button)(target));
            
            #line 28 "..\..\MainWindow.xaml"
            this.btnSaveAs.Click += new System.Windows.RoutedEventHandler(this.btnSaveAs_click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_bold = ((Fluent.Button)(target));
            
            #line 33 "..\..\MainWindow.xaml"
            this.btn_bold.Click += new System.Windows.RoutedEventHandler(this.btnBold_click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_italic = ((Fluent.Button)(target));
            
            #line 34 "..\..\MainWindow.xaml"
            this.btn_italic.Click += new System.Windows.RoutedEventHandler(this.btnItalic_click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_markCode = ((Fluent.Button)(target));
            
            #line 37 "..\..\MainWindow.xaml"
            this.btn_markCode.Click += new System.Windows.RoutedEventHandler(this.btnCode_click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_seperator = ((Fluent.Button)(target));
            
            #line 42 "..\..\MainWindow.xaml"
            this.btn_seperator.Click += new System.Windows.RoutedEventHandler(this.btnSeparator_click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_linebreak = ((Fluent.Button)(target));
            
            #line 43 "..\..\MainWindow.xaml"
            this.btn_linebreak.Click += new System.Windows.RoutedEventHandler(this.btnLineBreak_click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btn_paragraph = ((Fluent.Button)(target));
            
            #line 44 "..\..\MainWindow.xaml"
            this.btn_paragraph.Click += new System.Windows.RoutedEventHandler(this.btnParagraph_click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ddbtn_Heading = ((Fluent.DropDownButton)(target));
            return;
            case 11:
            
            #line 49 "..\..\MainWindow.xaml"
            ((Fluent.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.OnClickHeading1Level);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 50 "..\..\MainWindow.xaml"
            ((Fluent.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.OnClickHeading2Level);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 51 "..\..\MainWindow.xaml"
            ((Fluent.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.OnClickHeading3Level);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 52 "..\..\MainWindow.xaml"
            ((Fluent.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.OnClickHeading4Level);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 53 "..\..\MainWindow.xaml"
            ((Fluent.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.OnClickHeading5Level);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 54 "..\..\MainWindow.xaml"
            ((Fluent.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.OnClickHeading6Level);
            
            #line default
            #line hidden
            return;
            case 17:
            this.btn_quote = ((Fluent.Button)(target));
            
            #line 59 "..\..\MainWindow.xaml"
            this.btn_quote.Click += new System.Windows.RoutedEventHandler(this.btnQuote_click);
            
            #line default
            #line hidden
            return;
            case 18:
            this.btn_unquote = ((Fluent.Button)(target));
            
            #line 60 "..\..\MainWindow.xaml"
            this.btn_unquote.Click += new System.Windows.RoutedEventHandler(this.btnUnQuote_click);
            
            #line default
            #line hidden
            return;
            case 19:
            this.rtbMainText = ((System.Windows.Controls.RichTextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

