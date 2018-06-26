using System;
using System.Windows.Forms;
using Dietpolix.Views;

namespace Dietpolix.UserControls
{
    public partial class RegisterScreen : UserControl, IRegisterScreen
    {
        FormDietpolix parent;
        public RegisterScreen(FormDietpolix parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        public Control FormDietpolix
        {
            get
            {
                return this.Parent;
            }
        }

        FormDietpolix IRegisterScreen.parent
        {
            get
            {
                return parent;
            }
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
        public event Action<object, EventArgs> VEvent_OnGotoLogin;
        

        public void ShowInfo()
        {
            labelInfo.Visible = true;
            linkLabelGotoLogin.Visible = true;
            buttonCancelRegister.Visible = false;
            foreach(var t in this.Controls)
            {
                if (t is TextBox)
                {
                    ((TextBox)t).Text = String.Empty;
                }
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (this.VEvent_OnRegister != null)
            {
                VEvent_OnRegister(sender, e);
            }
        }

        private void buttonCancelRegister_Click(object sender, EventArgs e)
        {
            if (this.VEvent_OnGotoLogin != null)
            {
                VEvent_OnGotoLogin(sender, e);
            }
        }

        private void linkLabelGotoLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.VEvent_OnGotoLogin != null)
            {
                VEvent_OnGotoLogin(sender, e);
            }
        }

        private void RegisterScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
                if (this.VEvent_OnRegister != null)
                {
                    VEvent_OnRegister(sender, e);
                }
        }
    }
}
