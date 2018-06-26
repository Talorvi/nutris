﻿using System;
using Dietpolix.Models;
using Dietpolix.Views;

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
    }
}
