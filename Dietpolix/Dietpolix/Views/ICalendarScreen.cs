using System;
using System.Windows.Forms;

namespace Dietpolix.Views
{
    public interface ICalendarScreen
    {
        event Action<object, EventArgs> VEvent_OnmonthCalendarDiet_DateSelected;
        event Action<object, EventArgs> VEvent_OnbuttonEdit;

        string GetDate { get; }
        void ShowDiet(string[] products);

        Control FormDietpolix { get; }
        FormDietpolix parent { get; }
    }
}
