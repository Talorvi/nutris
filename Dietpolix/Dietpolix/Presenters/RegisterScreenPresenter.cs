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
            if (registerscreen.parent.IsTextboxFilled(registerscreen.GiveErrorProvider(), registerscreen.ListOfTextboxes()))
            {
                if (registerscreen.Password1 == registerscreen.Password2)
                {
                    bool LoginExists = model.databasemanager.CheckIfLoginExists(registerscreen.Login);
                    if (LoginExists == false)
                    {
                        bool CanAddUser = model.databasemanager.TryToAddUser(registerscreen.Login, registerscreen.Password1, registerscreen.Name, 0);
                        if (CanAddUser == true)
                            registerscreen.ShowInfo();
                    }
                    else System.Windows.Forms.MessageBox.Show("Login is already taken");
                }
                else System.Windows.Forms.MessageBox.Show("Passwords don't match");
            }
                
        }

        private void View_VEvent_OnGotoLogin(object arg1, EventArgs arg2)
        {
            registerscreen.parent.SetUserControl(2);
        }
    }
}
