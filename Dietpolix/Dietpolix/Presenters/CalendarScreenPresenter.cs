using System;
using Dietpolix.Models;
using Dietpolix.Views;
using System.Collections.Generic;

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

            calendarscreen.VEvent_OnmonthCalendarDiet_DateSelected += View_VEvent_OnmonthCalendarDiet_DateSelected;
        }

        private void View_VEvent_OnmonthCalendarDiet_DateSelected(object arg1, EventArgs arg2)
        {
            string login = "";
            List<String> userinfo = model.databasemanager.GetUserInfo(model.user.login);
            if (userinfo.Count == 8)
            {
                model.user = new Classes.User(userinfo[0], userinfo[1], userinfo[2], userinfo[3], Int32.Parse(userinfo[4]), Int32.Parse(userinfo[5]), userinfo[6], userinfo[7]);
                login = model.user.login;
            }
            List<Classes.Diet> dietlist = model.databasemanager.GetConsumption(login, calendarscreen.GetDate, calendarscreen.GetDate);
            List<string> products = new List<string>();

            foreach (var product in dietlist)
            {
                products.Add(product.product_name + " " + product.quantity.ToString());
            }
            calendarscreen.ShowDiet(products.ToArray());
        }
    }
}
