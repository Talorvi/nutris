using System;
using Dietpolix.Models;
using Dietpolix.Views;
using System.Collections.Generic;

namespace Dietpolix.Presenters
{
    public class MainScreenPresenter
    {
        
        IMainScreen mainscreen;
        Model model;

        string sex = "";
        int age = 0;
        string weight = "";
        string height = "";
        string lifestyle = "";
        string aim = "";

        public MainScreenPresenter(Model model, MainScreen mainscreen)
        {
            this.model = model;
            this.mainscreen = mainscreen;

            mainscreen.VEvent_OnLoad += View_VEvent_OnLoad;
            mainscreen.VEvent_OnlinkLabelGotouserprofile += View_VEvent_OnlinkLabelGotouserprofile;
        }

        private void View_VEvent_OnlinkLabelGotouserprofile(object arg1, EventArgs arg2)
        {
            mainscreen.parent.SetUserControl(6);
        }

        private void View_VEvent_OnLoad(object arg1, EventArgs arg2)
        {
            List<String> userinfo = model.databasemanager.GetUserInfo(model.user.login);
            if (userinfo.Count == 8)
            {
                model.user = new Classes.User(userinfo[0], userinfo[1], userinfo[2], userinfo[3], Int32.Parse(userinfo[4]), Int32.Parse(userinfo[5]), userinfo[6], userinfo[7]);
                mainscreen.Name = model.user.name;
                sex = model.user._sex.ToString();
                //age = Int32.Parse(model.user.age);
                weight = model.user.weight.ToString();
                height = model.user.height.ToString();
                lifestyle = model.user._lifestyle.ToString();
                aim = model.user._aim.ToString();
            }

            //TO-DO please, don't crash :(
            //if (model.CountBMI(model.user.weight, model.user.height) == 0)
            if (model.CountBMI(85, 175) == 0)
            {
                mainscreen.DrawGeneralPieChart();
                return;
            }
            age= Int32.Parse(model.user.age);
            double bmr = model.CountBMR(model.user.weight, model.user.height, age, model.user._sex.ToString());
            mainscreen.ShowInfo(model.CountBMI(85, 175), bmr,
                model.CountCPM(bmr, model.user._lifestyle.ToString(), model.user._aim.ToString()));
            mainscreen.parent.SetUserControl(3);
        }
    }
}

