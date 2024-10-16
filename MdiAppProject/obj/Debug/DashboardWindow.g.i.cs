﻿#pragma checksum "..\..\DashboardWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "20846D5626AA8F8AFC0D086AEFABCA36B172FED7B1DF7B0DE4FEFC30CCE00D7B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MdiAppProject;
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


namespace MdiAppProject {
    
    
    /// <summary>
    /// DashboardWindow
    /// </summary>
    public partial class DashboardWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddMedication;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMedicationSchedule;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdherenceTracking;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReminders;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReports;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnProfile;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSettings;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblPatientName;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogOut;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid medicationDataGrid;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstReminders;
        
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
            System.Uri resourceLocater = new System.Uri("/MdiAppProject;component/dashboardwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DashboardWindow.xaml"
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
            
            #line 8 "..\..\DashboardWindow.xaml"
            ((MdiAppProject.DashboardWindow)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            
            #line 8 "..\..\DashboardWindow.xaml"
            ((MdiAppProject.DashboardWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnAddMedication = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\DashboardWindow.xaml"
            this.btnAddMedication.Click += new System.Windows.RoutedEventHandler(this.btnAddMedication_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnMedicationSchedule = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\DashboardWindow.xaml"
            this.btnMedicationSchedule.Click += new System.Windows.RoutedEventHandler(this.btnMedicationSchedule_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnAdherenceTracking = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\DashboardWindow.xaml"
            this.btnAdherenceTracking.Click += new System.Windows.RoutedEventHandler(this.btnAdherenceTracking_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnReminders = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\DashboardWindow.xaml"
            this.btnReminders.Click += new System.Windows.RoutedEventHandler(this.btnReminders_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnReports = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\DashboardWindow.xaml"
            this.btnReports.Click += new System.Windows.RoutedEventHandler(this.btnReports_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnProfile = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\DashboardWindow.xaml"
            this.btnProfile.Click += new System.Windows.RoutedEventHandler(this.btnProfile_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnSettings = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\DashboardWindow.xaml"
            this.btnSettings.Click += new System.Windows.RoutedEventHandler(this.btnSettings_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.lblPatientName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.btnLogOut = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\DashboardWindow.xaml"
            this.btnLogOut.Click += new System.Windows.RoutedEventHandler(this.btnLogOut_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.medicationDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 12:
            this.lstReminders = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

