using System;
using System.Windows.Forms;

namespace Dietpolix.Views
{
    public interface IMainScreen
    {
        event Action<object, EventArgs> VEvent_OnLoad;
        event Action<object, EventArgs> VEvent_OnlinkLabelGotouserprofile;
        //event EventHandler VEvent_OnRegisterLink;

        void DrawGeneralPieChart();
        void DrawMyPieChart(double proteins, double carbohydrates, double fat);
        void ShowInfo(double bmi, double bmr, double cpm);
        void ShowDiet(string[] products);
        void ShowHello(string username);
        DateTime WhichDate(int option);
        void ShowMyPieChart();

        Control FormDietpolix { get; }
        FormDietpolix parent { get; }
    }
}
