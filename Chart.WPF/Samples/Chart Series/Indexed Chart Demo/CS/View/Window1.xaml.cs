﻿#region Copyright Syncfusion Inc. 2001 - 2012
// Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Syncfusion.Windows.Shared;
using System.Globalization;
using Syncfusion.Windows.Chart;
using System.Collections.ObjectModel;
using Syncfusion.Windows.SampleLayout;

namespace IndexedChart
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : SampleLayoutWindow
    {
        #region Constructor
        /// <summary>
        /// Construcor for Window1
        /// </summary>
        public Window1()
        {
            InitializeComponent();
           
        }
        
        #endregion     

        private void Chk1_Checked(object sender, RoutedEventArgs e)
        {
           
            slvalue.Visibility = Visibility.Visible;
            textBoxSlider.Visibility = Visibility.Visible; 
               
            
           
         }

        private void Chk1_Unchecked(object sender, RoutedEventArgs e)
        {
            
            slvalue.Visibility = Visibility.Collapsed;
            textBoxSlider.Visibility = Visibility.Collapsed;  
        }

       
    }  
}
