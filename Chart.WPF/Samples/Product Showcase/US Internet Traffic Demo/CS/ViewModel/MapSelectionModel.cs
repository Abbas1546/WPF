﻿#region Copyright Syncfusion Inc. 2001 - 2012
// Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Syncfusion.Windows.Controls.Map;
using System.Windows;
using System.Windows.Shapes;
using System.Windows.Media;

namespace USInternetTrafficDemo
{
    public class MapSelectionModel : INotifyPropertyChanged
    {       
        static Random rand = new Random();
        public MapSelectionModel()
        {
            string[] states = { "Texas","Alaska","NewMexico","Colorado","California","Florida","NewYork","Oregon","Montono","Wyoming",
                                  "Washington","Albama","Georgia","Maine","Indiana","Idaho","Arizona","Minnesota","Missouri","North Carolina",
                                  "South Carolina","Nevada","South Dakota","Kansas","Okiahoma","Utahi","Michgan","Nebraska","Kansas","IOWA","Wisconsin",
                                   "Illinois","Arkansas","Louisiana","Mississippi","Tennessee","Ohio","Pennsylvania","WestVirginia","Virginia",
                                    "Vermont","NewHampShire","Massachusetts","Connecticut","Hawaii","NewJersey","MaryLand","Delaware"};
            this.USCountries = new ObservableCollection<StateWiseWebPageUsageModel>();
            for (int i = 0; i < states.Count(); i++)
            {
                StateWiseWebPageUsageModel model = new StateWiseWebPageUsageModel(states[i]);
                model.MonthlyUsages = new ObservableCollection<MonthlyPageUsageModel>();
                string[] months = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

                for (int j = 0; j < 12; j++)
                {
                    model.MonthlyUsages.Add(new MonthlyPageUsageModel() { AvgTimeSpend = rand.Next(5, 35), DateTime = months[j], NewVisitors = rand.Next(0, 150), TotalVisits = rand.Next(230, 23000) });
                }
                this.USCountries.Add(model);
            }

            //For PieChart
            TrafficSourceModel day1 = new TrafficSourceModel();
            day1.Percentage = 75;
            day1.Others = "Response Time";

            TrafficSourceModel day2 = new TrafficSourceModel();
            day2.Percentage = 180;
            day2.Others = "Packet Loss";

            TrafficSourceModel day3 = new TrafficSourceModel();
            day3.Percentage = 272.1;
            day3.Others = "Internet Users";

            TrafficSourceModel day4 = new TrafficSourceModel();
            day4.Percentage = 78.3;
            day4.Others = "Penetration";

            var collection1 = new ObservableCollection<TrafficSourceModel>();
            collection1.Add(day1);
            collection1.Add(day2);
            collection1.Add(day3);
            collection1.Add(day4);

            this.TrafficSourceModel = collection1;

           
            //main.MainView.DataContext = USCountries[5];
           // main.Map.Loaded += new RoutedEventHandler(Map_Loaded);
            
        }

        //void Map_Loaded(object sender, RoutedEventArgs e)
        //{
        //    main.Map.ZoomLevel = 4d;
        //    main.Map.EnableZoom = false;
        //    main.Map.ShowLatLonPoints = false;
        //    .InitializeMap(shapeControl);
        //    grid1.DataContext = grid2.DataContext = grid3.DataContext = Model.USCountries[5];
        //}

        private ObservableCollection<StateWiseWebPageUsageModel> _USCountries;
        public ObservableCollection<StateWiseWebPageUsageModel> USCountries 
        {
            get
            {
                return this._USCountries;
            }
            set
            {
                this._USCountries = value;
            }
        }

        public StateWiseWebPageUsageModel SelectedStateModel
        {
            get;
            set;
        }

        public ObservableCollection<TrafficSourceModel> TrafficSourceModel
        {
            get;
            set;
        }

        public void InitializeMap(ShapeFileLayer shapeControl, MainWindow main)
        {
            //main.Map.ZoomLevel = 4d;
            //main.Map.EnableZoom = false;
            //main.Map.ShowLatLonPoints = false;
            Point point;
            FrameworkElement point_Element;
            SolidColorBrush mapbrush = new SolidColorBrush(Color.FromArgb(0xFF,0x5B,0x84,0x00));
            var model = this.USCountries;
            //TEXAS
            point = shapeControl.LatitudeLongitudeToPoint(new Point(-99, 29));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Texas";
            (point_Element as Path).Name = "Texas";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[0];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-112, 25));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Alaska";
            (point_Element as Path).Name = "Alaska";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[1]; 

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-107, 35));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "New Mexico";
            (point_Element as Path).Name = "NewMexico";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[2];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-108, 39));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Colorado";
            (point_Element as Path).Name = "Colorado";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[3];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-120, 37));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "California";
            (point_Element as Path).Name = "California";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[4]; 

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-81, 28));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Florida";
            (point_Element as Path).Name = "Florida";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[5];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-74, 42));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "New York";
            (point_Element as Path).Name = "NewYork";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[6]; 

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-120, 43));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Oregon";
            (point_Element as Path).Name = "Oregon";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[7]; 

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-110, 47));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Montana";
            (point_Element as Path).Name = "Montana";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[8]; 

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-107, 43));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Wyoming";
            (point_Element as Path).Name = "Wyoming";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[9];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-120, 47));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Washington";
            (point_Element as Path).Name = "Washington";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[10];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-86, 32));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Albama";
            (point_Element as Path).Name = "Albama";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[11]; 

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-83, 32));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Georgia";
            (point_Element as Path).Name = "Georgia";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[12]; 

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-69, 45));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Maine";
            (point_Element as Path).Name = "Maine";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[13];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-86, 39));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Indiana";
            (point_Element as Path).Name = "Indiana";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[14];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-115, 44));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Idaho";
            (point_Element as Path).Name = "Idaho";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[15];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-111, 34));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Arizona";
            (point_Element as Path).Name = "Arizona";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[16];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-95, 46));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Minnesota";
            (point_Element as Path).Name = "Minnesota";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[17];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-92, 38));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Missouri";
            (point_Element as Path).Name = "Missouri";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[18];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-79, 35));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "North Carolina";
            (point_Element as Path).Name = "NorthCarolina";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[19];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-80, 33));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "South Carolina";
            (point_Element as Path).Name = "SouthCarolina";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[20];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-119, 36));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Nevada";
            (point_Element as Path).Name = "Nevada";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[21];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-101, 44));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "South Dakota";
            (point_Element as Path).Name = "SouthDakota";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[22];

          
            point = shapeControl.LatitudeLongitudeToPoint(new Point(-99, 46));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Kansas";
            (point_Element as Path).Name = "Dhana";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[23];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-97, 35));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Okiahoma";
            (point_Element as Path).Name = "Okiahoma";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[24];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-111, 39));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Utahi";
            (point_Element as Path).Name = "Utahi";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[25];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-84, 43));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Michgan";
            (point_Element as Path).Name = "Michgan";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[25];

           
            point = shapeControl.LatitudeLongitudeToPoint(new Point(-97, 41));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Nebraska";
            (point_Element as Path).Name = "Nebraska";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[26];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-97, 38));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Kansas";
            (point_Element as Path).Name = "Kansas";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[27];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-92, 41));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "IOWA";
            (point_Element as Path).Name = "IOWA";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[28];
            /*new*/
            point = shapeControl.LatitudeLongitudeToPoint(new Point(-89, 44));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Wisconsin";
            (point_Element as Path).Name = "WisConsin";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[29];


            point = shapeControl.LatitudeLongitudeToPoint(new Point(-89, 40));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Illinois";
            (point_Element as Path).Name = "Illinois";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[30];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-92, 35));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Arkansas";
            (point_Element as Path).Name = "Arkansas";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[31];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-92, 31));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Louisiana";
            (point_Element as Path).Name = "Louisiana";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[32];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-89, 33));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Mississippi";
            (point_Element as Path).Name = "Mississippi";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[33];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-85, 36));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Tennessee";
            (point_Element as Path).Name = "Tennessee";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[34];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-84, 37));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Kentucky";
            (point_Element as Path).Name = "Kentucky";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[35];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-83, 40));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Ohio";
            (point_Element as Path).Name = "Ohio";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[36];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-78, 40));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Pennsylvania";
            (point_Element as Path).Name = "Pennsylvania";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[37];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-81, 38));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "WestVirginia";
            (point_Element as Path).Name = "WestVirginia";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[38];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-78, 37));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Virginia";
            (point_Element as Path).Name = "Virginia";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[39];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-72, 44));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Vermont";
            (point_Element as Path).Name = "Vermont";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[40];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-71, 43));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "NewHampshire";
            (point_Element as Path).Name = "NewHampShire";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[41];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-71.482818162290229, 42.299436188952662));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Massachusetts";
            (point_Element as Path).Name = "Massachusetts";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[42];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-72.646, 41.862));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Connecticut";
            (point_Element as Path).Name = "Connecticut";
            
            (point_Element as Path).Tag = this.USCountries[43];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-95, 20));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Hawaii";
            (point_Element as Path).Name = "Hawaii";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[44];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-74.683697416024671,40.408007539018669));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "NewJersey";
            (point_Element as Path).Name = "NewJersey";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[45];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-75.556664485224971,38.3710843775513));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "MaryLand";
            (point_Element as Path).Name = "MaryLand";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[46];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-75.411169973691585, 38.807567912151455));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Delaware";
            (point_Element as Path).Name = "Delaware";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[47];

            point = shapeControl.LatitudeLongitudeToPoint(new Point(-72.210290719957143, 41.426469119752362));
            point_Element = shapeControl.PointToElement(point);
            (point_Element as Path).ToolTip = "Delaware";
            (point_Element as Path).Name = "Delaware";
            (point_Element as Path).Fill = mapbrush;
            (point_Element as Path).Tag = this.USCountries[47];

             shapeControl.Tag = this.USCountries[5];

        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
