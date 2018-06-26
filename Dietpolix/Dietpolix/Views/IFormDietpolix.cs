using System;
using System.Windows.Forms;

namespace Dietpolix.Views
{
    interface IFormDietpolix
    {
        event EventHandler VEvent_OnlogOutToolStripMenuItem;
        event EventHandler VEvent_OnmyaccountToolStripMenuItem;

        void SetUserControl(int id);
    }
}
