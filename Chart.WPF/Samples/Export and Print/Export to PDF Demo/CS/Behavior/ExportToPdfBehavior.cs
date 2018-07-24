﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Interactivity;
using Syncfusion.Windows.Chart.Converter;

namespace ChartExport
{
    class ExportToPdfBehavior:Behavior<Window1>
    {
        protected override void OnAttached()
        {
            this.AssociatedObject.Loaded += new System.Windows.RoutedEventHandler(AssociatedObject_Loaded);
        }

        void AssociatedObject_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {

            this.AssociatedObject.ConvertBtn.Click += new System.Windows.RoutedEventHandler(ConvertBtn_Click);
        }

        void ConvertBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ChartPdfConverterControl control = new ChartPdfConverterControl();
            control.ChartPdfConverter(this.AssociatedObject.Chart1, "chartpdf.pdf");
        }

    }
}
