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

namespace Dietpolix.UserControls
{
    public partial class RegisterScreen : UserControl, IRegisterScreen
    {
        public RegisterScreen()
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

        public string Password1
        {
            get
            {
                return textBoxPassword1.Text;
            }

            set
            {
                textBoxPassword1.Text = value;
            }
        }

        public string Password2
        {
            get
            {
                return textBoxPassword2.Text;
            }

            set
            {
                textBoxPassword2.Text = value;
            }
        }

        public event Action<object, EventArgs> VEvent_OnRegister;
    }
}
