using System;
using System.Windows.Forms;

namespace Dietpolix.Views
{
    interface IFormDietpolix
    {
        event EventHandler VEvent_OnlogOutToolStripMenuItem;
        event EventHandler VEvent_OnmyaccountToolStripMenuItem;
        event EventHandler VEvent_OnhometoolStripMenuItem;
        event EventHandler VEvent_OncalendarToolStripMenuItem;
        event EventHandler VEvent_OnsearchToolStripMenuItem;
        event EventHandler VEvent_OndietToolStripMenuItem;

        void SetUserControl(int id);
        void ShowMenu();
        void HideMenu();
    }
}
