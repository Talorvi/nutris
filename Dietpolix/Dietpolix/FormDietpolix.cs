using Dietpolix.Models;
using Dietpolix.Presenters;
using Dietpolix.UserControls;
using Dietpolix.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dietpolix
{
    public partial class FormDietpolix : Form
    {
        public FormDietpolix()
        {
            InitializeComponent();
            OnStart();
            groupBox.Controls.AddRange(ListOfObjects.ToArray());
            SetUserControl(2);
            //DrawPieChart(2,5,3,4,1);
        }
        public void SetUserControl(int id)
        {
            foreach(UserControl usercontrol in groupBox.Controls)
            {
                usercontrol.Hide();
            }
            groupBox.Controls[id].Show();
            
        }

        private List<UserControl> ListOfObjects = new List<UserControl>();
        Model model = new Model();

        private void OnStart()
        {
            CalendarScreen calendarscreen = new CalendarScreen();            // 0
            DietScreen dietscreen = new DietScreen();                        // 1
            LoginScreen loginscreen = new LoginScreen(this);                 // 2
            MainScreen mainscreen = new MainScreen();                        // 3
            RegisterScreen registerscreen = new RegisterScreen();            // 4
            SearchScreen searchscreen = new SearchScreen();                  // 5
            UserProfileScreen userprofilescreen = new UserProfileScreen();   // 6

            UserControl[] ArrayOfObjects = { calendarscreen, dietscreen, loginscreen, mainscreen, registerscreen, searchscreen, userprofilescreen };
            ListOfObjects.AddRange(ArrayOfObjects);

            CalendarScreenPresenter calendarscreenpresenter = new CalendarScreenPresenter();       
            DietScreenPresenter dietscreenpresenter = new DietScreenPresenter();
            LoginScreenPresenter loginscreenpresenter = new LoginScreenPresenter(model, (LoginScreen)ListOfObjects[2]);
            MainScreenPresenter mainscreenpresenter = new MainScreenPresenter();                       
            RegisterScreenPresenter registerscreenpresenter = new RegisterScreenPresenter();            
            SearchScreenPresenter searchscreenpresenter = new SearchScreenPresenter();                  
            UserProfileScreenPresenter userprofilescreenpresenter = new UserProfileScreenPresenter();   
        }
        
        /*private void DrawPieChart(int value1, int value2, int value3, int value4, int value5)
        {
            //reset your chart series and legends
            chart1.Series.Clear();
            chart1.Legends.Clear();

            //Add a new Legend(if needed) and do some formating
            chart1.Legends.Add("MyLegend");
            chart1.Legends[0].LegendStyle = LegendStyle.Table;
            chart1.Legends[0].Docking = Docking.Bottom;
            chart1.Legends[0].Alignment = StringAlignment.Center;
            chart1.Legends[0].Title = "MyTitle";
            chart1.Legends[0].BorderColor = Color.Black;

            //Add a new chart-series
            string seriesname = "MySeriesName";
            chart1.Series.Add(seriesname);
            //set the chart-type to "Pie"
            chart1.Series[seriesname].ChartType = SeriesChartType.Pie;

            //Add some datapoints so the series. in this case you can pass the values to this method
            chart1.Series[seriesname].Points.AddXY("MyPointName", value1);
            chart1.Series[seriesname].Points.AddXY("MyPointName1", value2);
            chart1.Series[seriesname].Points.AddXY("MyPointName2", value3);
            chart1.Series[seriesname].Points.AddXY("MyPointName3", value4);
            chart1.Series[seriesname].Points.AddXY("MyPointName4", value5);
        }*/
    }
}
