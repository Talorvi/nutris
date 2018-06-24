using System;
using System.Windows.Forms;
using Dietpolix.Views;

namespace Dietpolix
{
    public partial class LoginScreen : UserControl, ILoginScreen
    {
        FormDietpolix parent;
        public LoginScreen(FormDietpolix parent)
        {
            InitializeComponent();
            this.parent = parent;
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
        public Control FormDietpolix
        {
            get
            {
                return this.Parent;
            }
        }

        FormDietpolix ILoginScreen.parent
        {
            get
            {
                return parent;
            }
        }

        //public FormDietpolix

        public event Action<object, EventArgs> VEvent_OnLogIn;
        public event EventHandler VEvent_OnRegisterLink;

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.VEvent_OnRegisterLink != null)
            {
                VEvent_OnRegisterLink(sender, e);
            }
        }
    }
}
