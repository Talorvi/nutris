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
        }

        private void View_VEvent_OnSelectedIndexChanged(object arg1, EventArgs arg2)
        {
            
        }
    }
}

