using System;
using Dietpolix.Models;
using Dietpolix.Views;

namespace Dietpolix.Presenters
{
    class FormDietpolixPresenter
    {
        IFormDietpolix formdietpolix;
        Model model;

        public FormDietpolixPresenter(Model model, FormDietpolix formdietpolix)
        {
            this.model = model;
            this.formdietpolix = formdietpolix;

            formdietpolix.VEvent_OnlogOutToolStripMenuItem += View_VEvent_OnlogOutToolStripMenuItem;
        }

        private void View_VEvent_OnlogOutToolStripMenuItem(object arg1, EventArgs arg2)
        {
            formdietpolix.SetUserControl(2);
        }
    }
}
