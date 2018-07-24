﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Interactivity;
using System.Windows;
using Syncfusion.Windows.Chart;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Markup;
using Syncfusion.Windows.SampleLayout;

namespace Serialization
{
    class SerializationBehavior : Behavior<Window1>
    {
        private string xamlString = String.Empty;
        private Chart chart;
        protected override void OnAttached()
        {
            this.chart = this.AssociatedObject.Chart1;
            this.AssociatedObject.btn_save.Click += new RoutedEventHandler(btn_save_Click);
            this.AssociatedObject.btn_load.Click += new RoutedEventHandler(btn_load_Click);
            base.OnAttached();
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            xamlString = chart.Serialize();
            this.AssociatedObject.ScrollContents.Content = new TextBlock() { Background = new SolidColorBrush(new Color() { R = 0XEA, G = 0XF2, B = 0XFB, A = 0XFF }), Text = xamlString }; ;
        }

        private void btn_load_Click(object sender, RoutedEventArgs e)
        {
            Chart new_Chart = XamlReader.Parse(xamlString) as Chart;
            this.AssociatedObject.ScrollContents.Content = new_Chart;
        }
    }
}
