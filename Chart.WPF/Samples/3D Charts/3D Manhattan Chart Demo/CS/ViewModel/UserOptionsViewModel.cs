﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Syncfusion.Windows.Chart;

namespace _3DManhattanChart
{
    public class UserOptionsViewModel : INotifyPropertyChanged
    {
        public UserOptionsViewModel()
        {
            this.type = ChartTypes.Column;
            this.allow3DRotate = false;
            this.allow3DView = true;
            this.IsClusteredView = false;
            this.TypeCollection = new List<ChartTypes> { ChartTypes.Column, ChartTypes.Area, ChartTypes.Line, ChartTypes.Bar, ChartTypes.Scatter };
        }

        private ChartTypes type;
        public ChartTypes Type
        {
            get { return type; }
            set { type = value; OnPropertyChanged("Type"); }
        }

        public List<ChartTypes> TypeCollection { get; set; }

        private bool allow3DView;
        public bool Allow3DView
        {
            get { return allow3DView; }
            set { allow3DView = value; OnPropertyChanged("Allow3DView"); }
        }

        private bool allow3DRotate;
        public bool Allow3DRotate
        {
            get { return allow3DRotate; }
            set { allow3DRotate = value; OnPropertyChanged("Allow3DRotate"); }
        }

        private bool isClusteredView;
        public bool IsClusteredView
        {
            get { return isClusteredView; }
            set { isClusteredView = value; OnPropertyChanged("IsClusteredView"); }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                      new PropertyChangedEventArgs(property));
            }
        }
    }
}
