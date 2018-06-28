using System;
using System.Windows.Forms;

namespace Dietpolix.Views
{
    public interface ICalendarScreen
    {

        Control FormDietpolix { get; }
        FormDietpolix parent { get; }
    }
}
