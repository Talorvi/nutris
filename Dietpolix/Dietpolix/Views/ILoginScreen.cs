using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietpolix.Views
{
    public interface ILoginScreen
    {
        event Action<object, EventArgs> VEvent_OnLogIn;
        event Action<object, EventArgs> VEvent_OnRegisterLink;

        string Login { get; set; }
        string Password { get; set; }
        //.ControlCollection formdietpolix { get; set; }
    }
}
