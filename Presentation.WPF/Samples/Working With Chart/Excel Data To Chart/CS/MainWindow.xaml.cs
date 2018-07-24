using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Diagnostics;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using Syncfusion.Presentation;
using Syncfusion.Windows.Shared;
using Syncfusion.OfficeChart;

namespace PPTXToImage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ChromelessWindow
    {
        public MainWindow()
        {
            InitializeComponent();			
            ImageSourceConverter img = new ImageSourceConverter();
            string file = @"..\..\..\..\..\..\..\Common\Images\Presentation\ppt_header.png";
            this.image1.Source = (ImageSource)img.ConvertFromString(file);
            this.Icon = (ImageSource)img.ConvertFromString(@"..\..\..\..\..\..\..\Common\Images\Presentation\App.ico");
        }


        private void btnCreateImage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Getting data from file
                string dataPath = @"..\..\..\..\..\..\..\Common\Data\Presentation\";
                //New Instance of PowerPoint is Created.[Equivalent to launching MS PowerPoint with no slides].
                IPresentation presentation = Presentation.Create();

                //Method call to create SmartArt and add it into slides.
                CreateSlide1(presentation,dataPath);
                presentation.Save("ChartSample.pptx");
                if (System.Windows.MessageBox.Show("Do you want to view the generated PowerPoint Presentation?", "Excel Data To Chart",
                        MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                {
                    System.Diagnostics.Process.Start("ChartSample.pptx");
                    this.Close();
                }
            }
            catch (Exception exception)
            {
                System.Windows.MessageBox.Show("This Presentation could not be created, please contact Syncfusion Direct-Trac system at http://www.syncfusion.com/support/default.aspx for any queries. ", "OOPS..Sorry!",
                    MessageBoxButton.OK);
                this.Close();
            }
        }
        # region Slide1
        private void CreateSlide1(IPresentation presentation, string dataPath)
        {
            ISlide slide1 = presentation.Slides.Add(SlideLayoutType.TitleOnly);
            IShape titleShape = slide1.Shapes[0] as IShape;
            titleShape.Height = 1.45 * 72;
            titleShape.Width = 11.5 * 72;
            titleShape.Left = 0.92 * 72;
            titleShape.Top = 0.4 * 72;

            IParagraph titleParagarph = titleShape.TextBody.AddParagraph();
            ITextPart titleTextPart = titleParagarph.TextParts.Add();
            titleTextPart.Text = "Northwind Management Report";
            titleTextPart.Font.FontSize = 44;
            titleTextPart.Font.FontName = "Calibri Light (Headings)";
            titleParagarph.HorizontalAlignment = HorizontalAlignmentType.Center;
            titleTextPart.Font.Color = ColorObject.FromArgb(0, 112, 48, 160);

            //Load the excel template as stream
            Stream excelStream = File.OpenRead(dataPath + "Excel_Template.xlsx");
            RectangleF chartSize = new RectangleF();
            chartSize.Width = (float)9.66 * 72;
            chartSize.Height = (float)5.57 * 72;

            IPresentationChart excelChart = slide1.Shapes.AddChart(excelStream, 1, "B2:C6", chartSize);
            //Set chart data
            excelChart.ChartType = OfficeChartType.Bar_Clustered;
            excelChart.ChartTitle = "Purchase Details";
            excelChart.ChartTitleArea.FontName = "Calibri (Body)";
            excelChart.ChartTitleArea.Size = 14;
            //Set name to chart series            
            excelChart.Series[0].Name = "Sum of Purchases";
            excelChart.Series[1].Name = "Sum of Future Expenses";
            //Set Chart Data table
            excelChart.HasDataTable = true;
            excelChart.DataTable.HasBorders = true;
            excelChart.DataTable.HasHorzBorder = true;
            excelChart.DataTable.HasVertBorder = true;
            excelChart.DataTable.ShowSeriesKeys = true;
            excelChart.HasLegend = false;
            //Setting background color
            excelChart.ChartArea.Fill.ForeColor = System.Drawing.Color.FromArgb(208, 206, 206);
            excelChart.PlotArea.Fill.ForeColor = System.Drawing.Color.FromArgb(208, 206, 206);
            //Setting line pattern to the chart area
            excelChart.PrimaryCategoryAxis.Border.LinePattern = OfficeChartLinePattern.None;
            excelChart.PrimaryValueAxis.Border.LinePattern = OfficeChartLinePattern.None;
            excelChart.ChartArea.Border.LinePattern = OfficeChartLinePattern.None;
            excelChart.PrimaryValueAxis.MajorGridLines.Border.LineColor = System.Drawing.Color.FromArgb(175, 171, 171);
            //Set label for primary catagory axis
            excelChart.PrimaryCategoryAxis.CategoryLabels = excelChart.ChartData[2, 1, 6, 1];
            excelChart.CategoryLabelLevel = OfficeCategoriesLabelLevel.CategoriesLabelLevelNone;
            //excelChart.XPos = (float)1.6 * 72;
            //excelChart.YPos = (float)1.8 * 72;
            slide1.Shapes[1].Left = (float)1.8 * 72;
            slide1.Shapes[1].Top = (float)1.6 * 72;


        }
        #endregion				
    }
}
          
