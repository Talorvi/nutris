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
        void ShowInfo(double bmi, double bmr, double cpm);

        Control FormDietpolix { get; }
        FormDietpolix parent { get; }
    }
}
