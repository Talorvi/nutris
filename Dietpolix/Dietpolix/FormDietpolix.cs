using Dietpolix.Models;
using Dietpolix.Presenters;
using Dietpolix.UserControls;
using Dietpolix.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Dietpolix
{
    public partial class FormDietpolix : Form, Views.IFormDietpolix
    {
        public FormDietpolix()
        {
            InitializeComponent();
            OnStart();
            groupBox.Controls.AddRange(ListOfObjects.ToArray());
            SetUserControl(2);
        }
        void IFormDietpolix.SetUserControl(int id)
        {
            foreach (UserControl usercontrol in groupBox.Controls)
            {
                usercontrol.Hide();
            }
            groupBox.Controls[id].Show();
        }

        public bool IsTextboxFilled(ErrorProvider errorprovider, List<TextBox> listoftextbox)
        {
            foreach (TextBox textbox in listoftextbox)
            {
                if (textbox.Text == "")
                    errorprovider.SetError(textbox, "");
            }
            foreach (TextBox textbox in listoftextbox)
            {
                if (textbox.Text == "")
                {
                    errorprovider.SetError(textbox, "Empty textbox");
                    return false;
                }
                errorprovider.SetError(textbox, "");
            }
                return true;
        }

        public void SetUserControl(int id)
        {
            foreach (UserControl usercontrol in groupBox.Controls)
            {
                usercontrol.Visible = false;
                usercontrol.Hide();
            }
            groupBox.Controls[id].Visible = true;
            groupBox.Controls[id].Show();
        }

        public void HideMenu()
        {
            if (menuStrip.Visible == true)
            {
                menuStrip.Visible = false;
            }
        }
        public void ShowMenu()
        {
            if(menuStrip.Visible == false)
            {
                menuStrip.Visible = true;
            }
        }

        private List<UserControl> ListOfObjects = new List<UserControl>();
        Model model = new Model();

        private void OnStart()
        {
            model.user = new Classes.User();
            CalendarScreen calendarscreen = new CalendarScreen(this);            // 0
            DietScreen dietscreen = new DietScreen(this);                        // 1
            LoginScreen loginscreen = new LoginScreen(this);                     // 2
            MainScreen mainscreen = new MainScreen(this);                        // 3
            RegisterScreen registerscreen = new RegisterScreen(this);            // 4
            SearchScreen searchscreen = new SearchScreen(this);                  // 5
            UserProfileScreen userprofilescreen = new UserProfileScreen(this);   // 6

            UserControl[] ArrayOfObjects = { calendarscreen, dietscreen, loginscreen, mainscreen, registerscreen, searchscreen, userprofilescreen };
            ListOfObjects.AddRange(ArrayOfObjects);

            CalendarScreenPresenter calendarscreenpresenter = new CalendarScreenPresenter(model, (CalendarScreen)ListOfObjects[0]);       
            DietScreenPresenter dietscreenpresenter = new DietScreenPresenter(model, (DietScreen)ListOfObjects[1]);
            LoginScreenPresenter loginscreenpresenter = new LoginScreenPresenter(model, (LoginScreen)ListOfObjects[2]);
            MainScreenPresenter mainscreenpresenter = new MainScreenPresenter(model, (MainScreen)ListOfObjects[3]);                       
            RegisterScreenPresenter registerscreenpresenter = new RegisterScreenPresenter(model, (RegisterScreen)ListOfObjects[4]);            
            SearchScreenPresenter searchscreenpresenter = new SearchScreenPresenter(model, (SearchScreen)ListOfObjects[5]);                  
            UserProfileScreenPresenter userprofilescreenpresenter = new UserProfileScreenPresenter(model, (UserProfileScreen)ListOfObjects[6]);   
        }

        public event EventHandler VEvent_OnlogOutToolStripMenuItem;
        public event EventHandler VEvent_OnmyaccountToolStripMenuItem;
        public event EventHandler VEvent_OnhometoolStripMenuItem;
        public event EventHandler VEvent_OncalendarToolStripMenuItem;
        public event EventHandler VEvent_OnsearchToolStripMenuItem;
        public event EventHandler VEvent_OndietToolStripMenuItem;

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.VEvent_OnlogOutToolStripMenuItem != null)
            {
                VEvent_OnlogOutToolStripMenuItem(sender, e);
            }
        }

        private void myaccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.VEvent_OnmyaccountToolStripMenuItem != null)
            {
                VEvent_OnmyaccountToolStripMenuItem(sender, e);
            }
        }

        private void hometoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.VEvent_OnhometoolStripMenuItem != null)
            {
                VEvent_OnhometoolStripMenuItem(sender, e);
            }
        }

        private void calendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.VEvent_OncalendarToolStripMenuItem != null)
            {
                VEvent_OncalendarToolStripMenuItem(sender, e);
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.VEvent_OnsearchToolStripMenuItem != null)
            {
                VEvent_OnsearchToolStripMenuItem(sender, e);
            }
        }

        private void dietToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.VEvent_OndietToolStripMenuItem != null)
            {
                VEvent_OndietToolStripMenuItem(sender, e);
            }
        }
    }
}
