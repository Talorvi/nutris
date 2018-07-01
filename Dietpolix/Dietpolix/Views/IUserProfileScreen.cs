using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dietpolix.Views
{
    public interface IUserProfileScreen
    {
        event Action<object, EventArgs> VEvent_OnbuttonEditProfile;
        event Action<object, EventArgs> VEvent_OnbuttonCancelEdit;
        event Action<object, EventArgs> VEvent_OnbuttonChangePassword;
        event Action<object, EventArgs> VEvent_OnbuttonCancelPasswordChange;
        event Action<object, EventArgs> VEvent_OnLoad;
        event Action<object, EventArgs> VEvent_OnVisibleChanged;

        void ShowEditProfile();
        void ShowChangePassword();
        void HideEditProfile();
        void HideChangePassword();

        string Login { set; }
        string OldPassword { get; set; }
        string Password1 { get; set; }
        string Password2 { get; set; }
        string Sex { get; set; }
        string Age { get; set; }
        string Weight { get; set; }
        string Height { get; set; }
        string Lifestyle { get; set; }
        string Aim { get; set; }
        Control FormDietpolix { get; }
        FormDietpolix parent { get; }
    }
}
