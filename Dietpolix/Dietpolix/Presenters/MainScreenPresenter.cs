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
        string Login = "";
        string Sex = "";
        string Age = "";
        string Weight = "";
        string Height = "";
        string Lifestyle = "";
        string Aim = "";
        private void View_VEvent_OnLoad(object arg1, EventArgs arg2)
        {
            mainscreen.DrawGeneralPieChart();

            List<String> userinfo = model.databasemanager.GetUserInfo(model.user.login);
            if (userinfo.Count == 8)
            {
                model.user = new Classes.User(userinfo[0], userinfo[1], userinfo[2], userinfo[3], Int32.Parse(userinfo[4]), Int32.Parse(userinfo[5]), userinfo[6], userinfo[7]);
                Login = model.user.login;
                Sex = model.user._sex.ToString();
                Age = model.user.age.ToString();
                Weight = model.user.weight.ToString();
                Height = model.user.height.ToString();
                Lifestyle = model.user._lifestyle.ToString();
                Aim = model.user._aim.ToString();
            }

            double bmi = model.CountBMI(model.user.weight, model.user.height);
            if (bmi == 0)
            {
                return;
            }
            double bmr = model.CountBMR(model.user.weight, model.user.height, model.CalculateAge(model.user.age), model.user._sex.ToString());
            mainscreen.ShowInfo(model.CountBMI(Int32.Parse(Weight), Int32.Parse(Height)),
                bmr, model.CountCPM(bmr, Lifestyle, Aim));
        }
    }
}

