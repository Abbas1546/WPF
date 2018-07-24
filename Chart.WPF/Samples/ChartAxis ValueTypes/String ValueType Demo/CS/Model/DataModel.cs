﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace AxisStringValueTypeDemo
{
    public class DataModel : INotifyPropertyChanged
    {

        private string carbrand;
        public string CarBrand
        {
            get
            {
                return carbrand;
            }
            set
            {
                carbrand = value;
                OnPropertyChanged("CarBrand");
            }
        }

        public double salesamount;
        public double SalesAmount
        {
            get
            {
                return salesamount;
            }
            set
            {
                salesamount = value;
                OnPropertyChanged("SalesAmount");
            }
        }

        public double profitpercentage;
        public double ProfitPercentage
        {
            get
            {
                return profitpercentage;
            }
            set
            {
                profitpercentage = value;
                OnPropertyChanged("ProfitPercentage");
            }
        }

        public double averageraise;
        public double AverageRaise
        {
            get
            {
                return averageraise;
            }
            set
            {
                averageraise = value;
                OnPropertyChanged("AverageRaise");
            }
        }

        public double investedamount;
        public double InvestedAmount
        {
            get
            {
                return investedamount;
            }
            set
            {
                investedamount = value;
                OnPropertyChanged("InvestedAmount");
            }
        }


        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(String property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property.ToString()));
            }
        }
        #endregion
    }
}
