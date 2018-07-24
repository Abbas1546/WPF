﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.IO;
using System.Globalization;
using System.Windows.Data;
using Syncfusion.Windows.Chart;

namespace TimeLineControlSample
{
   public class DataCollection : ObservableCollection<TimeLineData>
    {
        public List<TimeLineData> datalist = new List<TimeLineData>();
        public DataCollection()
        {
            datalist = this.GetPricesFromCSVFile("..\\..\\Data\\GOOG.csv");
        }

        public List<TimeLineData> GetPricesFromCSVFile(string fileName)
        {
            char[] comma = new char[] { ',' };
            char[] slashN = new char[] { '\n' };
            List<TimeLineData> list = new List<TimeLineData>();
            string s = File.ReadAllText(fileName);
            string[] lines = s.Split(slashN);
            bool firstLine = true;
            string[] values;
            int count = lines.Count() - 2;
            TimeLineData priceInfo;
            int index = 0;
            foreach (string line in lines)
            {
                if (index == 750)
                {
                }
                if (count != -1 && index >= 1250)
                    break;
                if (!firstLine)
                {
                    values = line.Split(comma);
                    if (values.GetLength(0) > 5)
                    {
                        priceInfo = new TimeLineData()
                        {
                            TimeStamp = DateTime.Parse(values[0], CultureInfo.InvariantCulture),
                            Open = double.Parse(values[1]),
                            High = double.Parse(values[2]),
                            Low = double.Parse(values[3]),
                            Last = double.Parse(values[4]),
                            Volume = double.Parse(values[5])
                        };
                        list.Insert(index, priceInfo);
                        index++;
                    }
                }
                else
                {
                    firstLine = false;
                }
            }
            return list;
        }
    }

   public class LabelConverter : IValueConverter
   {

       public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
       {
           if (value.GetType() == typeof(ChartAxisLabel))
           {
               DateTime date;
               DateTime.TryParse((value as ChartAxisLabel).Content.ToString(), out date);
               if (date.Month >= 1 && date.Month <= 3)
               {
                   return "Q1";
               }
               else if (date.Month >= 4 && date.Month <= 6)
               {
                   return "Q2";
               }
               else if (date.Month >= 7 && date.Month <= 9)
               {
                   return "Q3";
               }
               else if (date.Month >= 10 && date.Month <= 12)
               {
                   return "Q4";
               }
           }
           return value;
       }

       public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
       {
           throw new NotImplementedException();
       }
   }

}
