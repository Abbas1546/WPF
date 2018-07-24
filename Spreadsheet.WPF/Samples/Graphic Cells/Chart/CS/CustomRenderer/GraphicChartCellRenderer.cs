﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Syncfusion.Windows.Controls.Grid;
using Syncfusion.Windows.Chart;
using Syncfusion.XlsIO;
using System.Data;
using System.Windows;
using System.ComponentModel;

namespace ChartDemo.CustomRenderer
{
    public class GraphicChartCellModel:GraphicCellModel<GraphicChartCellRenderer>
    {
        public GraphicChartCellModel()
        {

        }
    }

    public class GraphicChartCellRenderer : GraphicCellRendererBase<Chart>
    {
        public GraphicChartCellRenderer()
        {

        }

        protected override Chart CreateUIElement(GraphicStyleInfo cellInfo)
        {
            if (cellInfo.CellValue != null && cellInfo.CellValue is IChartShape)
            {
                IChartShape chartShape = cellInfo.CellValue as IChartShape;
                return chartShape.CreateChart();
            }
            else if (cellInfo.CellValue != null && cellInfo.CellValue is IChart)
            {
                IChart chartShape = cellInfo.CellValue as IChart;
                return chartShape.CreateChart();
            }
            return base.CreateUIElement(cellInfo);
        }

        protected override void OnInitializeContent(Chart element, GraphicStyleInfo style)
        {
            element.Background = style.Background;
            element.BorderBrush = style.BorderBrush;
            element.BorderThickness = style.BorderThickness;
            base.OnInitializeContent(element, style);
        }
    }
}
