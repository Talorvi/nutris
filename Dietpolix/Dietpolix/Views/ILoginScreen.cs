using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dietpolix.Views
{
    public interface ILoginScreen
    {
        event Action<object, EventArgs> VEvent_OnLogIn;
        event EventHandler VEvent_OnRegisterLink;

        List<TextBox> ListOfTextboxes();
        ErrorProvider GiveErrorProvider();

        string Login { get; set; }
        string Password { get; set; }
        Control FormDietpolix { get; }
        FormDietpolix parent { get; }
    }
}
