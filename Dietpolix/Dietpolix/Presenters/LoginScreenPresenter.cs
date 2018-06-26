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
        }

        private void View_VEvent_OnLogIn(object arg1, EventArgs arg2)
        {
            if (loginscreen.parent.IsTextboxFilled(loginscreen.GiveErrorProvider(), loginscreen.ListOfTextboxes()))
                loginscreen.parent.SetUserControl(3);
        }

        private void View_VEvent_OnRegisterLink(object arg1, EventArgs arg2)
        {
            loginscreen.parent.SetUserControl(4);
            Console.WriteLine("lol");
            //loginscreen.FormDietpolix.Hide();
        }
    }
}
