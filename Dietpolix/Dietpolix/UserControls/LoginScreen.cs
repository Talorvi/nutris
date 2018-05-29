using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dietpolix.Views;

namespace Dietpolix
{
    public partial class LoginScreen : UserControl, ILoginScreen
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        public string Login
        {
            get
            {
                return textBoxLogin.Text;
            }

            set
            {
                textBoxLogin.Text = value;
            }
        }

        public string Password
        {
            get
            {
                return textBoxPassword.Text;
            }

            set
            {
                textBoxPassword.Text = value;
            }
        }

        public event Action<object, EventArgs> VEvent_OnLogIn;
        public event Action<object, EventArgs> VEvent_OnRegisterLink;
    }
}
