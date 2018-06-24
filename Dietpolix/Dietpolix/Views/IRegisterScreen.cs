using System;

namespace Dietpolix.Views
{
    public interface IRegisterScreen
    {
        event Action<object, EventArgs> VEvent_OnRegister;

        string Login { get; set; }
        string Name { get; set; }
        string Password1 { get; set; }
        string Password2 { get; set; }
    }
}
