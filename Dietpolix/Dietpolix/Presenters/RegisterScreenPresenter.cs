using System;
using Dietpolix.Models;
using Dietpolix.Views;
using Dietpolix.UserControls;

namespace Dietpolix.Presenters
{
    public class RegisterScreenPresenter
    {
        IRegisterScreen registerscreen;
        Model model;

        public RegisterScreenPresenter(Model model, RegisterScreen registerscreen)
        {
            this.model = model;
            this.registerscreen = registerscreen;

            registerscreen.VEvent_OnRegister += View_VEvent_OnRegister;
            registerscreen.VEvent_OnGotoLogin += View_VEvent_OnGotoLogin;
        }

        private void View_VEvent_OnRegister(object arg1, EventArgs arg2)
        {
            registerscreen.ShowInfo();
        }

        private void View_VEvent_OnGotoLogin(object arg1, EventArgs arg2)
        {
            registerscreen.parent.SetUserControl(2);
        }
    }
}
