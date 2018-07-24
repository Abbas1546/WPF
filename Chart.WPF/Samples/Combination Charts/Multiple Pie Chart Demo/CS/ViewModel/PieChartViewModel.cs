﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using Syncfusion.Windows.Chart;
using System.Windows.Data;

namespace PieChart
{
    public class PieChartViewModel
    {
        public PieChartViewModel()
        {
            this.Expenditure = new List<CompanyExpense>();
            Expenditure.Add(new CompanyExpense() { Expense = "Seeds", Amount = 20d, Amount1=40d, Amount2=60d });
            Expenditure.Add(new CompanyExpense() { Expense = "Fertilizers ", Amount = 23d, Amount1=46d, Amount2=69d });
            Expenditure.Add(new CompanyExpense() { Expense = "Insurance", Amount = 12d, Amount1=24d, Amount2=36d });
            Expenditure.Add(new CompanyExpense() { Expense = "Labor", Amount = 25d, Amount1=50d, Amount2=75d });
            Expenditure.Add(new CompanyExpense() { Expense = "Warehousing", Amount = 10d, Amount1=20d, Amount2=30d });
            Expenditure.Add(new CompanyExpense() { Expense = "Taxes", Amount = 10d, Amount1=20d, Amount2=30d });
            Expenditure.Add(new CompanyExpense() { Expense = "Truck", Amount = 10d, Amount1=20d,Amount2=30d });

        }

        public IList<CompanyExpense> Expenditure
        {
            get;
            set;
        }
        public Array PaletteCollection
        {
            get
            {
                return new ChartColorPalette[] { ChartColorPalette.Nature, 
                                          ChartColorPalette.Metro, 
                                          ChartColorPalette.Default, 
                                          ChartColorPalette.DefaultDark,
                                          ChartColorPalette.MixedFantasy
                                        };
            }
        }
    }
    #region Converter
    public class Labelconvertor : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            // This is possible during design time load
            if (!(value is CompanyExpense))
                return String.Empty;

            CompanyExpense info = value as CompanyExpense;

            return String.Format("{0} %",info.Amount);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
    public class Labelconvertor2 : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            // This is possible during design time load
            if (!(value is CompanyExpense))
                return String.Empty;

            CompanyExpense info = value as CompanyExpense;

            return String.Format("{0} %", info.Amount1);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    public class Labelconvertor3 : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            // This is possible during design time load
            if (!(value is CompanyExpense))
                return String.Empty;

            CompanyExpense info = value as CompanyExpense;

            return String.Format("{0} %", info.Amount2);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
 public class TooltipConverter : IValueConverter
    {
        #region IValueConverter Members
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return String.Empty;

            ChartSegment seg = value as ChartSegment;
            return seg.Item;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
    public class InteriorConverter : IValueConverter
    {
        #region IValueConverter Members
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return String.Empty;

            ChartSegment seg = value as ChartSegment;
            return seg.Interior;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
    #endregion

}
