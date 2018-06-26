using System;
using System.Windows.Forms;

namespace Dietpolix.Views
{
    interface IFormDietpolix
    {
        event EventHandler VEvent_OnlogOutToolStripMenuItem;

        void SetUserControl(int id);
    }
}
