using System;
using Dietpolix.Models;
using Dietpolix.Views;
using System.Collections.Generic;

namespace Dietpolix.Presenters
{
    public class UserProfileScreenPresenter
    {
        IUserProfileScreen userprofilescreen;
        Model model;

        public UserProfileScreenPresenter(Model model, UserProfileScreen userprofilescreen)
        {
            this.model = model;
            this.userprofilescreen = userprofilescreen;

            userprofilescreen.VEvent_OnbuttonEditProfile += View_VEvent_OnbuttonEditProfile;
            userprofilescreen.VEvent_OnbuttonCancelEdit += View_VEvent_OnCancelEdit;
            userprofilescreen.VEvent_OnbuttonChangePassword += View_VEvent_OnbuttonChangePassword;
            userprofilescreen.VEvent_OnbuttonCancelPasswordChange += View_VEvent_OnbuttonCancelPasswordChange;
            userprofilescreen.VEvent_OnLoad += View_VEvent_OnLoad;
            userprofilescreen.VEvent_OnVisibleChanged += View_VEvent_OnVisibleChanged;
            userprofilescreen.VEvent_OnSubmitEdit += View_VEvent_OnSubmitEdit;
            userprofilescreen.VEvent_OnSubmitPasswordChange += View_VEvent_OnSubmitPasswordChange;
        }

        private void View_VEvent_OnbuttonCancelPasswordChange(object arg1, EventArgs arg2)
        {
            userprofilescreen.HideChangePassword();
        }

        private void View_VEvent_OnbuttonChangePassword(object arg1, EventArgs arg2)
        {
            userprofilescreen.ShowChangePassword();
        }

        private void View_VEvent_OnCancelEdit(object arg1, EventArgs arg2)
        {
            userprofilescreen.HideEditProfile();
        }

        private void View_VEvent_OnbuttonEditProfile(object arg1, EventArgs arg2)
        {
            userprofilescreen.ShowEditProfile();
        }
        private void View_VEvent_OnLoad(object arg1, EventArgs arg2)
        {
            View_VEvent_OnVisibleChanged(arg1, arg2);
        }
        private void View_VEvent_OnVisibleChanged(object arg1, EventArgs arg2)
        {
            List<String> userinfo = model.databasemanager.GetUserInfo(model.user.login);
            if (userinfo.Count == 8)
            {
                model.user = new Classes.User(userinfo[0], userinfo[1], userinfo[2], userinfo[3], Int32.Parse(userinfo[4]), Int32.Parse(userinfo[5]), userinfo[6], userinfo[7]);
                userprofilescreen.Login = model.user.login;
                userprofilescreen.Sex = model.user._sex.ToString();
                userprofilescreen.Age = model.user.age.ToString();
                userprofilescreen.Weight = model.user.weight.ToString();
                userprofilescreen.Height = model.user.height.ToString();
                userprofilescreen.Lifestyle = model.user._lifestyle.ToString();
                userprofilescreen.Aim = model.user._aim.ToString();
            }
        }
        private void View_VEvent_OnSubmitEdit(object arg1, EventArgs arg2)
        {
            //TO-DO Verification
            model.databasemanager.UpdateUserInfo(model.user.login, userprofilescreen.Sex, "1999-11-11", userprofilescreen.Weight, userprofilescreen.Height, userprofilescreen.Lifestyle, userprofilescreen.Aim);
            View_VEvent_OnVisibleChanged(arg1, arg2);
            userprofilescreen.HideEditProfile();
        }
        private void View_VEvent_OnSubmitPasswordChange(object arg1, EventArgs arg2)
        {
            //TO-DO Verification
            if(model.databasemanager.UpdatePassword(model.user.login, userprofilescreen.OldPassword, userprofilescreen.Password1) == true)
            {
                userprofilescreen.parent.SetUserControl(2);
            }
        }
    }
}
