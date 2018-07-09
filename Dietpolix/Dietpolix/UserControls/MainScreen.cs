using System;
using System.Windows.Forms;
using Dietpolix.Views;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace Dietpolix
{
    public partial class MainScreen : UserControl, IMainScreen
    {
        FormDietpolix parent;
        public MainScreen(FormDietpolix parent)
        {
            InitializeComponent();
            this.parent = parent;
            //DrawPieChart(2, 5, 3, 4, 1);
        }

        public Control FormDietpolix
        {
            get
            {
                return this.Parent;
            }
        }

        FormDietpolix IMainScreen.parent
        {
            get
            {
                return parent;
            }
        }

        public void DrawGeneralPieChart()
        {
            chartMyDream.Series.Clear();
            chartMyDream.Legends.Clear();
            chartMyDream.Legends.Add("Nutriens");
            chartMyDream.Legends[0].LegendStyle = LegendStyle.Table;
            chartMyDream.Legends[0].Docking = Docking.Bottom;
            chartMyDream.Legends[0].Alignment = StringAlignment.Center;
            chartMyDream.Legends[0].Title = "General need for nutriens";
            chartMyDream.Legends[0].BorderColor = Color.Black;
            string seriesname = "MySeriesName";
            chartMyDream.Series.Add(seriesname);
            chartMyDream.Series[seriesname].ChartType = SeriesChartType.Pie;

            chartMyDream.Series[seriesname].Points.AddXY("Proteins", 25);
            chartMyDream.Series[seriesname].Points.AddXY("Carbohydrates", 55);
            chartMyDream.Series[seriesname].Points.AddXY("Fat", 20);
        }

        private void DrawPieChart(int value1, int value2, int value3, int value4, int value5)
        {
            //reset your chart series and legends
            chartMyDream.Series.Clear();
            chartMyDream.Legends.Clear();

            //Add a new Legend(if needed) and do some formating
            chartMyDream.Legends.Add("MyLegend");
            chartMyDream.Legends[0].LegendStyle = LegendStyle.Table;
            chartMyDream.Legends[0].Docking = Docking.Bottom;
            chartMyDream.Legends[0].Alignment = StringAlignment.Center;
            chartMyDream.Legends[0].Title = "MyTitle";
            chartMyDream.Legends[0].BorderColor = Color.Black;

            //Add a new chart-series
            string seriesname = "MySeriesName";
            chartMyDream.Series.Add(seriesname);
            //set the chart-type to "Pie"
            chartMyDream.Series[seriesname].ChartType = SeriesChartType.Pie;

            //Add some datapoints so the series. in this case you can pass the values to this method
            chartMyDream.Series[seriesname].Points.AddXY("MyPointName", value1);
            chartMyDream.Series[seriesname].Points.AddXY("MyPointName1", value2);
            chartMyDream.Series[seriesname].Points.AddXY("MyPointName2", value3);
            chartMyDream.Series[seriesname].Points.AddXY("MyPointName3", value4);
            chartMyDream.Series[seriesname].Points.AddXY("MyPointName4", value5);
        }

        public void ShowInfo(double bmi, double bmr, double cpm)
        {
            labelUserBMI.Text = bmi.ToString();
            labelUserCaloriesDemand.Text = bmr.ToString() + " - " + cpm.ToString();
        }

        public event Action<object, EventArgs> VEvent_OnLoad;
        public event Action<object, EventArgs> VEvent_OnlinkLabelGotouserprofile;

        private void MainScreen_Load(object sender, EventArgs e)
        {
            if (this.VEvent_OnLoad != null)
            {
                VEvent_OnLoad(sender, e);
            }
        }


        private void linkLabelGotouserprofile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.VEvent_OnlinkLabelGotouserprofile != null)
            {
                VEvent_OnlinkLabelGotouserprofile(sender, e);
            }
        }
    }
}
