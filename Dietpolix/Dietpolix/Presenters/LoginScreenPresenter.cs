using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void View_VEvent_OnRegisterLink(object arg1, EventArgs arg2)
        {
            
        }
    }
}
