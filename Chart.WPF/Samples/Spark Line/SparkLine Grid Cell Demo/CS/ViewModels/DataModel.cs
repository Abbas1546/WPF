﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace SparkLineGridCellDemo
{
    public class DataModel
    {
        private double _Day;
        public double Day
        {
            get
            {
                return _Day;
            }
            set
            {
                this._Day = value;
            }
        }

        private double _ShareHolders;
        public double ShareHolders
        {
            get
            {
                return _ShareHolders;
            }
            set
            {
                this._ShareHolders = value;
            }
        }


        private double _YearPerformance;
        public double YearPerformance
        {
            get
            {
                return _YearPerformance;
            }
            set
            {
                this._YearPerformance = value;
            }
        }
    }

    public class SparkModel
    {
        public SparkModel()
        {
            this.DayActivity = new ObservableCollection<DataModel>();
            this.Transaction = new ObservableCollection<DataModel>();
            this.OneYearPerformance = new ObservableCollection<DataModel>();
        }

        private string _CompanyName;
        public string CompanyName
        {
            get
            {
                return this._CompanyName;
            }
            set
            {
                this._CompanyName = value;
            }
        }

        private double _High;
        public double High
        {
            get
            {
                return this._High;
            }
            set
            {
                this._High = value;
            }
        }

        private DateTime _Date;
        public DateTime Date
        {
            get
            {
                return this._Date;
            }
            set
            {
                this._Date = value;
            }
        }

        private double _Low;
        public double Low
        {
            get
            {
                return this._Low;
            }
            set
            {
                this._Low = value;
            }
        }

        private double _MarketCap;
        public double MarketCap
        {
            get
            {
                return this._MarketCap;
            }
            set
            {
                this._MarketCap = value;
            }
        }

        private double _Performance;
        public double Performance
        {
            get
            {
                return this._Performance;
            }
            set
            {
                this._Performance = value;
            }
        }
        private ObservableCollection<DataModel> _DayActivity;
        public ObservableCollection<DataModel> DayActivity 
        {
            get
            {
                return this._DayActivity;
            }
            set
            {
                this._DayActivity = value;
            }
        }

        private ObservableCollection<DataModel> _Transaction;
        public ObservableCollection<DataModel> Transaction
        {
            get
            {
                return this._Transaction;
            }
            set
            {
                this._Transaction = value;
            }
        }

        private ObservableCollection<DataModel> _OneYearPerformance;
        public ObservableCollection<DataModel> OneYearPerformance
        {
            get
            {
                return this._OneYearPerformance;
            }
            set
            {
                this._OneYearPerformance = value;
            }
        }


    }
}
