using System;
using Dietpolix.Models;
using Dietpolix.Views;

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

        private void View_VEvent_OnLoad(object arg1, EventArgs arg2)
        {
            //TO-DO please, don't crash :(
            if (model.CountBMI(model.user.weight, model.user.height) == 0)
            {
                mainscreen.DrawGeneralPieChart();
                return;
            }
            int age= Int32.Parse(model.user.age);
            double bmr = model.CountBMR(model.user.weight, model.user.height, age, model.user._sex.ToString());
            mainscreen.ShowInfo(model.CountBMI(model.user.weight, model.user.height),
                model.CountBMR(model.user.weight, model.user.height, age, model.user._sex.ToString()),
                model.CountCPM(bmr, model.user._lifestyle.ToString(), model.user._aim.ToString()));
        }
    }
}

