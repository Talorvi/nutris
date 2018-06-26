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
                usercontrol.Hide();
            }
            groupBox.Controls[id].Show();
        }

        private List<UserControl> ListOfObjects = new List<UserControl>();
        Model model = new Model();

        private void OnStart()
        {
            CalendarScreen calendarscreen = new CalendarScreen();            // 0
            DietScreen dietscreen = new DietScreen();                        // 1
            LoginScreen loginscreen = new LoginScreen(this);                 // 2
            MainScreen mainscreen = new MainScreen(this);                    // 3
            RegisterScreen registerscreen = new RegisterScreen(this);        // 4
            SearchScreen searchscreen = new SearchScreen();                  // 5
            UserProfileScreen userprofilescreen = new UserProfileScreen(this);   // 6

            UserControl[] ArrayOfObjects = { calendarscreen, dietscreen, loginscreen, mainscreen, registerscreen, searchscreen, userprofilescreen };
            ListOfObjects.AddRange(ArrayOfObjects);

            CalendarScreenPresenter calendarscreenpresenter = new CalendarScreenPresenter();       
            DietScreenPresenter dietscreenpresenter = new DietScreenPresenter();
            LoginScreenPresenter loginscreenpresenter = new LoginScreenPresenter(model, (LoginScreen)ListOfObjects[2]);
            MainScreenPresenter mainscreenpresenter = new MainScreenPresenter(model, (MainScreen)ListOfObjects[3]);                       
            RegisterScreenPresenter registerscreenpresenter = new RegisterScreenPresenter(model, (RegisterScreen)ListOfObjects[4]);            
            SearchScreenPresenter searchscreenpresenter = new SearchScreenPresenter();                  
            UserProfileScreenPresenter userprofilescreenpresenter = new UserProfileScreenPresenter(model, (UserProfileScreen)ListOfObjects[6]);   
        }

        public event EventHandler VEvent_OnlogOutToolStripMenuItem;
        public event EventHandler VEvent_OnmyaccountToolStripMenuItem;

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
    }
}
