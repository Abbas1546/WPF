﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Interactivity;
using Syncfusion.Windows.Tools.Controls;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows;
using System.ComponentModel;

namespace CustomizedToolBarDemo
{
    public class SelectionChangedAction : TargetedTriggerAction<RichTextBoxAdv>
    {
        public UIElement Element
        {
            get { return (UIElement)GetValue(ElementProperty); }
            set { SetValue(ElementProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Element.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ElementProperty =
            DependencyProperty.Register("Element", typeof(UIElement), typeof(SelectionChangedAction), new UIPropertyMetadata(null));


        protected override void Invoke(object parameter)
        {
            RichTextBoxAdv rte = Element as RichTextBoxAdv;
            System.Windows.Controls.SelectionChangedEventArgs args = parameter as System.Windows.Controls.SelectionChangedEventArgs;
            if (rte != null && args != null)
            {
                if (args.AddedItems[0].ToString() == "Transparent")
                {
                    rte.Background = new SolidColorBrush(Color.FromArgb(255, 214, 245, 146));
                }
                else
                    rte.Background = Brushes.White;
            }
        }
    }
}
