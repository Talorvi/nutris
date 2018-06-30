using System;
using System.Windows.Forms;

namespace Dietpolix.Views
{
    public interface IMainScreen
    {
        event Action<object, EventArgs> VEvent_OnSelectedIndexChanged;
        event Action<object, EventArgs> VEvent_OnLoad;
        //event EventHandler VEvent_OnRegisterLink;

        void DrawGeneralPieChart();

        Control FormDietpolix { get; }
        FormDietpolix parent { get; }
    }
}
