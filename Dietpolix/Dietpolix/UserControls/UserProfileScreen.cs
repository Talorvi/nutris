using System;
using System.Windows.Forms;
using Dietpolix.Views;
using System.Collections.Generic;

namespace Dietpolix
{
    public partial class UserProfileScreen : UserControl, IUserProfileScreen
    {
        FormDietpolix parent;
        public UserProfileScreen(FormDietpolix parent)
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

        FormDietpolix IUserProfileScreen.parent
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
                return textBoxLoginChange.Text;
            }

            set
            {
                textBoxLoginChange.Text = value;
            }
        }

        public string OldPassword
        {
            get
            {
                return textBoxOldPassword.Text;
            }

            set
            {
                textBoxOldPassword.Text = value;
            }
        }

        public string Password1
        {
            get
            {
                return textBoxNewPassword.Text;
            }

            set
            {
                textBoxNewPassword.Text = value;
            }
        }

        public string Password2
        {
            get
            {
                return textBoxNewPassword2.Text;
            }

            set
            {
                textBoxNewPassword2.Text = value;
            }
        }

        public string Sex
        {
            get
            {
                return comboBoxSexChange.Text;
            }

            set
            {
                comboBoxSexChange.Text = value;
            }
        }

        public string Age
        {
            get
            {
                return numericUpDownAgeChange.Text;
            }

            set
            {
                numericUpDownAgeChange.Text = value;
            }
        }

        public string Weight
        {
            get
            {
                return numericUpDownWeightChange.Text;
            }

            set
            {
                numericUpDownWeightChange.Text = value;
            }
        }

        public string Lifestyle
        {
            get
            {
                return comboBoxLifestyleChange.Text;
            }

            set
            {
                comboBoxLifestyleChange.Text = value;
            }
        }

        public string Aim
        {
            get
            {
                return comboBoxAimChange.Text;
            }

            set
            {
                comboBoxAimChange.Text = value;
            }
        }

        public event Action<object, EventArgs> VEvent_OnbuttonEditProfile;
        public event Action<object, EventArgs> VEvent_OnbuttonCancelEdit;
        public event Action<object, EventArgs> VEvent_OnbuttonChangePassword;
        public event Action<object, EventArgs> VEvent_OnbuttonCancelPasswordChange;

        public void ShowEditProfile()
        {
            groupBoxEditProfile.Visible = true;
        }

        public void ShowChangePassword()
        {
            groupBoxChangePassword.Visible = true;
        }

        public void HideEditProfile()
        {
            groupBoxEditProfile.Visible = false;
        }

        public void HideChangePassword()
        {
            groupBoxChangePassword.Visible = false;
        }

        private void buttonEditProfile_Click(object sender, System.EventArgs e)
        {
            if (this.VEvent_OnbuttonEditProfile != null)
            {
                VEvent_OnbuttonEditProfile(sender, e);
            }
        }

        private void buttonCancelEdit_Click(object sender, EventArgs e)
        {
            if (this.VEvent_OnbuttonCancelEdit != null)
            {
                VEvent_OnbuttonCancelEdit(sender, e);
            }
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            if (this.VEvent_OnbuttonChangePassword != null)
            {
                VEvent_OnbuttonChangePassword(sender, e);
            }
        }

        private void buttonCancelPasswordChange_Click(object sender, EventArgs e)
        {
            if (this.VEvent_OnbuttonCancelPasswordChange != null)
            {
                VEvent_OnbuttonCancelPasswordChange(sender, e);
            }
        }
    }
}
