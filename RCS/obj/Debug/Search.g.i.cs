﻿#pragma checksum "C:\Acer Backup\Information Engineering\Usability Engineering-Design\Project\rcs_UE\RCS\Search.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "345FFC146499002A7CD302459436374A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Controls.Primitives;
using Microsoft.Phone.Shell;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace RCS {
    
    
    public partial class Search : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal Microsoft.Phone.Shell.ApplicationBar applicationbar;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton Searchbutton;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal Microsoft.Phone.Controls.Primitives.HorizontalLoopingSelector dishtype_Selector;
        
        internal Microsoft.Phone.Controls.Primitives.HorizontalLoopingSelector selectorLeft;
        
        internal Microsoft.Phone.Controls.Primitives.HorizontalLoopingSelector cookingType_Selector;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/RCS;component/Search.xaml", System.UriKind.Relative));
            this.applicationbar = ((Microsoft.Phone.Shell.ApplicationBar)(this.FindName("applicationbar")));
            this.Searchbutton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("Searchbutton")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.dishtype_Selector = ((Microsoft.Phone.Controls.Primitives.HorizontalLoopingSelector)(this.FindName("dishtype_Selector")));
            this.selectorLeft = ((Microsoft.Phone.Controls.Primitives.HorizontalLoopingSelector)(this.FindName("selectorLeft")));
            this.cookingType_Selector = ((Microsoft.Phone.Controls.Primitives.HorizontalLoopingSelector)(this.FindName("cookingType_Selector")));
        }
    }
}

