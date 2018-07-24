﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.IO;
using System.Globalization;

namespace ChartTechnicalIndicatorDemo
{
    public class TechnicalIndicatorData
    {
        public DateTime TimeStamp
        {
            get;
            set;
        }
        public double High
        {
            get;
            set;
        }
        public double Low
        {
            get;
            set;
        }
        public double Last
        {
            get;
            set;
        }
        public double Open
        {
            get;
            set;
        }
        public double Volume
        {
            get;
            set;
        }
    }
    
    public class DataCollection : ObservableCollection<TechnicalIndicatorData>
    {
        public List<TechnicalIndicatorData> datalist = new List<TechnicalIndicatorData>();
        public DataCollection()
        {
            datalist = this.GetPricesFromCSVFile("..\\..\\Data\\GOOG.csv");        
        }

        public List<TechnicalIndicatorData> GetPricesFromCSVFile(string fileName)
        {
            char[] comma = new char[] { ',' };
            char[] slashN = new char[] { '\n' };
            List<TechnicalIndicatorData> list = new List<TechnicalIndicatorData>();
            string s = File.ReadAllText(fileName);
            string[] lines = s.Split(slashN);
            bool firstLine = true;
            string[] values;
            int count = lines.Count() - 2;            
            TechnicalIndicatorData priceInfo;
            int index = 0;
            foreach (string line in lines)
            {
                if (count != -1 && index >= count)
                    break;                
                if (!firstLine)
                {
                    values = line.Split(comma);
                    if (values.GetLength(0) > 5)
                    {
                        priceInfo = new TechnicalIndicatorData()
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

}
