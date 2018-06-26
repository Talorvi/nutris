using System;
using System.Windows.Forms;

namespace Dietpolix.Views
{
    interface IFormDietpolix
    {
        event Action<object, EventArgs> VEvent_OnlogOutToolStripMenuItem;

        void SetUserControl(int id);
    }
}
