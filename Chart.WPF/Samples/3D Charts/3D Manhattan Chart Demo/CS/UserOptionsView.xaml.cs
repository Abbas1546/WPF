﻿using System;
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
using Syncfusion.Windows.Chart;

namespace _3DManhattanChart
{
    /// <summary>
    /// Interaction logic for UserOptionsView.xaml
    /// </summary>
    public partial class UserOptionsView : UserControl
    {
        public UserOptionsView()
        {
            InitializeComponent();
           // type.ItemsSource = new List<ChartTypes> { ChartTypes.Column, ChartTypes.Area, ChartTypes.Line, ChartTypes.Bar, ChartTypes.Scatter };
        }
    }
}
