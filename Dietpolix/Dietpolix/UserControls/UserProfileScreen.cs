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
            set
            {
                labelUserLogin.Text = value;
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
                labelUserSex.Text = value;
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
                labelUserAge.Text = value;
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
                labelUserWeight.Text = value;
            }
        }
        new public string Height
        {
            get
            {
                return numericUpDownHeightChange.Text;
            }
            set
            {
                numericUpDownHeightChange.Text = value;
                labelUserHeight.Text = value;
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
                labelUserLifestyle.Text = value;
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
                labelUserAim.Text = value;
            }
        }

        public event Action<object, EventArgs> VEvent_OnbuttonEditProfile;
        public event Action<object, EventArgs> VEvent_OnbuttonCancelEdit;
        public event Action<object, EventArgs> VEvent_OnbuttonChangePassword;
        public event Action<object, EventArgs> VEvent_OnbuttonCancelPasswordChange;
        public event Action<object, EventArgs> VEvent_OnLoad;
        public event Action<object, EventArgs> VEvent_OnVisibleChanged;
        public event Action<object, EventArgs> VEvent_OnSubmitEdit;
        public event Action<object, EventArgs> VEvent_OnSubmitPasswordChange;

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

        private void UserProfileScreen_Load(object sender, EventArgs e)
        {
            if (VEvent_OnLoad != null)
            {
                VEvent_OnLoad(sender, e);
            }
        }

        private void UserProfileScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true){
                if (VEvent_OnVisibleChanged != null)
                {
                    VEvent_OnVisibleChanged(sender, e);
                }
            }
        }

        private void buttonSubmitEdit_Click(object sender, EventArgs e)
        {
            if (VEvent_OnSubmitEdit != null)
            {
                VEvent_OnSubmitEdit(sender, e);
            }
        }

        private void buttonSubmitPasswordChange_Click(object sender, EventArgs e)
        {
            if (VEvent_OnSubmitPasswordChange != null)
            {
                VEvent_OnSubmitPasswordChange(sender, e);
            }
        }
    }
}
