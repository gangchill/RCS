﻿#pragma checksum "C:\Acer Backup\Information Engineering\Usability Engineering-Design\Project\rcs_UE\RCS\shoppinglist.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "273913B3E9D5B5B0BA84DAE44C5E0027"
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
    
    
    public partial class shoppinglist : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal Microsoft.Phone.Shell.ApplicationBar applicationbar;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton Home;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton AddButton;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.ListBox shoppingList_List;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/RCS;component/shoppinglist.xaml", System.UriKind.Relative));
            this.applicationbar = ((Microsoft.Phone.Shell.ApplicationBar)(this.FindName("applicationbar")));
            this.Home = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("Home")));
            this.AddButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("AddButton")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.shoppingList_List = ((System.Windows.Controls.ListBox)(this.FindName("shoppingList_List")));
        }
    }
}

