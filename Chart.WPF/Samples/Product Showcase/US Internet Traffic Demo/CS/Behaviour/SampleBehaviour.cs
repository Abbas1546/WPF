﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Interactivity;
using Syncfusion.Windows.SampleLayout;

namespace USInternetTrafficDemo
{
    public class SampleBehaviour : Behavior<MainWindow>
    {
        private MainWindow mainwindow;
        protected override void OnAttached()
        {
            base.OnAttached();
            mainwindow = this.AssociatedObject as MainWindow;
            mainwindow.shapeControl.ShapesLoaded += new Syncfusion.Windows.Controls.Map.ShapesLoadedEventHandler(shapeControl_ShapesLoaded);
        }

        void shapeControl_ShapesLoaded(object sender, Syncfusion.Windows.Controls.Map.ShapesLoadedEventArgs args)
        {
            (mainwindow.DataContext as MapSelectionModel).InitializeMap(mainwindow.shapeControl, mainwindow);
        }       
    }
}
