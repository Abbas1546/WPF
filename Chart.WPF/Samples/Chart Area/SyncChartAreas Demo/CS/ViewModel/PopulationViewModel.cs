﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Data;

namespace MultipleAreasWithSingleXAxis
{
    public class SyncChartAreaModel
    {
        public SyncChartAreaModel()
        {
            this.Products = new ObservableCollection<Population>();
            DateTime dt = new DateTime(1998, 1, 1);
            Random rand = new Random(DateTime.Now.Millisecond);
            Products.Add(new Population() { Year = dt, IncreaseInPopulation = 99, LiteracyGrowth = 20, AbovePovertyLine = 53, BelowPovertyLine = 21, BirthRate = 89 });
            Products.Add(new Population() { Year = dt.AddYears(1), IncreaseInPopulation = 34, LiteracyGrowth = 22, AbovePovertyLine = 76 , BelowPovertyLine = 49, BirthRate = 64});
            Products.Add(new Population() { Year = dt.AddYears(2), IncreaseInPopulation = 45, LiteracyGrowth = 30, AbovePovertyLine = 80, BelowPovertyLine = 12, BirthRate = 77 });
            Products.Add(new Population() { Year = dt.AddYears(3), IncreaseInPopulation = 88, LiteracyGrowth = 26, AbovePovertyLine = 50, BelowPovertyLine = 33, BirthRate = 90 });
            Products.Add(new Population() { Year = dt.AddYears(4), IncreaseInPopulation = 21, LiteracyGrowth = 36, AbovePovertyLine = 68, BelowPovertyLine = 39, BirthRate = 61 });
            Products.Add(new Population() { Year = dt.AddYears(5), IncreaseInPopulation = 78, LiteracyGrowth = 20, AbovePovertyLine = 90, BelowPovertyLine = 15, BirthRate = 81 });
            Products.Add(new Population() { Year = dt.AddYears(6), IncreaseInPopulation = 65, LiteracyGrowth = 40, AbovePovertyLine = 73, BelowPovertyLine = 9, BirthRate = 78 });
        }

        public ObservableCollection<Population> Products { get; set; }

    }

    public class SplitterConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double myvalue = (double)value;
            return myvalue.ToString().Substring(0, 3);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }

}
