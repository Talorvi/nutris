using System;
using System.Windows.Forms;
using Dietpolix.Views;
using Dietpolix.Classes.Managers;
using System.Collections.Generic;

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
        public event Action<object, EventArgs> VEvent_OnLoad;

        List<TextBox> ListOfT = new List<TextBox>();
        public List<TextBox> ListOfTextboxes()
        {
            TextBox[] ArrayOfTextBoxes = { textBoxLogin, textBoxPassword};
            ListOfT.AddRange(ArrayOfTextBoxes);
            return (ListOfT);
        }
        public ErrorProvider GiveErrorProvider()
        {
            return errorProviderEmptyTextBox;
        }

        public void ClearAllTextboxes()
        {
            foreach (var t in this.Controls)
            {
                if (t is TextBox)
                {
                    ((TextBox)t).Text = String.Empty;
                }
            }
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.VEvent_OnRegisterLink != null)
            {
                VEvent_OnRegisterLink(sender, e);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (this.VEvent_OnLogIn != null)
            {
                VEvent_OnLogIn(sender, e);
            }
        }

        private void LoginScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
                if (this.VEvent_OnLogIn != null)
                {
                    VEvent_OnLogIn(sender, e);
                }
        }

        private void LoginScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (this.VEvent_OnLoad != null)
            {
                VEvent_OnLoad(sender, e);
            }
        }
    }
}
