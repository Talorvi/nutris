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

            mainscreen.VEvent_OnSelectedIndexChanged += View_VEvent_OnSelectedIndexChanged;
            mainscreen.VEvent_OnLoad += View_VEvent_OnLoad;
        }

        private void View_VEvent_OnLoad(object arg1, EventArgs arg2)
        {
            //TO-DO please, don't crash :(
            /*if (model.CountBMI(model.user.weight,model.user.height)!=0)
            {
                mainscreen.DrawGeneralPieChart();
                return;
            }*/
            mainscreen.parent.SetUserControl(6);
            
        }

        private void View_VEvent_OnSelectedIndexChanged(object arg1, EventArgs arg2)
        {
            
        }
    }
}

