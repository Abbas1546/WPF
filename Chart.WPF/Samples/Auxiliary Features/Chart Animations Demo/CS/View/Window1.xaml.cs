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
using Syncfusion.Windows.Shared;
using System.Collections.ObjectModel;
using System.Globalization;
using Syncfusion.Windows.Chart;
using System.Collections;
using System.Windows.Media.Animation;
using Syncfusion.Windows.SampleLayout;

namespace ChartAnimations
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : SampleLayoutWindow
    {
        #region Constructor
        public Window1()
        {
            InitializeComponent();
        }

       
        #endregion

        #region Helper Methods
        
       
        #region ApplyTemplateToSeries
        /// <summary>
        /// Sets template to series
        /// </summary>
        private void ApplyTemplateToSeries(string Key, Chart chart)
        {
            foreach (ChartSeries series in chart.Areas[0].Series)
            {
                series.Template = this.Resources[Key] as DataTemplate;

                // Resetting DataSource to null helps force a redraw on the chart while changing the template.
                // This workaround, of course, won't be necessary if you don't plan to change the series' template
                // during runtime.
                IEnumerable source = series.DataSource as IEnumerable;
                series.DataSource = null;
                series.DataSource = source;
            }
        }
        #endregion

        #region ApplyColumnTemplate
        #endregion

        

    

    }

    
    public class MonthlyNetCollection : ObservableCollection<MonthlyNet>
    {
        public MonthlyNetCollection()
            : base()
        {
            Random rand = new Random(DateTime.Now.Millisecond);

            for (int i = 1; i <= 12; i++)
            {
                this.Add(new MonthlyNet(i, CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i).Substring(0, 3), rand.Next(15, 100)));
            }
        }
    }
    #endregion
}
