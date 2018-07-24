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
using Syncfusion.Windows.SampleLayout;

namespace Imagery_Service_Demo
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1: SampleLayoutWindow
    {
        BingMapKeyDialog child = new BingMapKeyDialog();
        public Window1()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(Window1_Loaded);
        }
        void Window1_Loaded(object sender, RoutedEventArgs e)
        {
            child.Owner = this;
            child.ShowDialog();
        }
        
    }
}
