using System;
using Dietpolix.Models;
using Dietpolix.Views;

namespace Dietpolix.Presenters
{
    public class CalendarScreenPresenter
    {
        ICalendarScreen calendarscreen;
        Model model;

        public CalendarScreenPresenter(Model model, CalendarScreen calendarscreen)
        {
            this.model = model;
            this.calendarscreen = calendarscreen;

        }
    }
}
