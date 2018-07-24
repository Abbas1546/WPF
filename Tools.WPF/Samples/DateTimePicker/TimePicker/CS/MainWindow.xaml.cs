﻿using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace TimePicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    public sealed partial class MainWindow : ChromelessWindow
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        void SelectorFormatStringChanged(object sender, SelectionChangedEventArgs e)
        {
            string formatstring = ((sender as ComboBox).SelectedItem as ComboBoxItem).Tag.ToString();
            if (TP1 != null)
                TP1.SelectorFormatString = formatstring;
            if (TP2 != null)
                TP2.SelectorFormatString = formatstring;
        }

        private void Loaded(object sender, RoutedEventArgs e)
        {
            ((ComboBox)sender).SelectedIndex = 0;
        }
    }

    public class TimePickerProperties : NotificationObject
    {
        private String formatString = "t";

        public String FormatString
        {
            get { return formatString; }
            set { formatString = value; RaisePropertyChanged("FormatString"); }
        }
    }

    public class NotificationObject : INotifyPropertyChanged
    {
        public void RaisePropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
