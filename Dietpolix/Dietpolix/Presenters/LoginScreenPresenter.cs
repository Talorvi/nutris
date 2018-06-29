using System;
using Dietpolix.Models;
using Dietpolix.Views;

namespace Dietpolix.Presenters
{
    public class LoginScreenPresenter
    {
        ILoginScreen loginscreen;
        Model model;

        public LoginScreenPresenter(Model model, LoginScreen loginscreen)
        {
            this.model = model;
            this.loginscreen = loginscreen;

            loginscreen.VEvent_OnRegisterLink += View_VEvent_OnRegisterLink;
            loginscreen.VEvent_OnLogIn += View_VEvent_OnLogIn;
            loginscreen.VEvent_OnLoad += View_VEvent_OnLoad;
        }

        private void View_VEvent_OnLoad(object arg1, EventArgs arg2)
        {
            loginscreen.ClearAllTextboxes();
        }

        private void View_VEvent_OnLogIn(object arg1, EventArgs arg2)
        {
            if (loginscreen.parent.IsTextboxFilled(loginscreen.GiveErrorProvider(), loginscreen.ListOfTextboxes()))
            {
                bool successLogin = model.databasemanager.TryToLogIn(loginscreen.Login, loginscreen.Password);
                if (successLogin == true)
                {
                    loginscreen.parent.SetUserControl(3);
                    loginscreen.parent.ShowMenu();
                }
                else
                {
                    //TO-DO
                }
            }
        }

        private void View_VEvent_OnRegisterLink(object arg1, EventArgs arg2)
        {
            loginscreen.parent.SetUserControl(4);
        }
    }
}
