using System;
using System.Windows.Forms;

namespace Dietpolix.Views
{
    public interface ILoginScreen
    {
        event Action<object, EventArgs> VEvent_OnLogIn;
        event Action<object, EventArgs> VEvent_OnRegisterLink;

        string Login { get; set; }
        string Password { get; set; }
        Control FormDietpolix { get; }
    }
}
