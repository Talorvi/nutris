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
            formdietpolix.VEvent_OnmyaccountToolStripMenuItem += View_VEvent_OnmyaccountToolStripMenuItem;
            formdietpolix.VEvent_OnhometoolStripMenuItem += View_VEvent_OnhometoolStripMenuItem;
            formdietpolix.VEvent_OncalendarToolStripMenuItem += View_VEvent_OncalendarToolStripMenuItem;
            formdietpolix.VEvent_OnsearchToolStripMenuItem += View_VEvent_OnsearchToolStripMenuItem;
            formdietpolix.VEvent_OndietToolStripMenuItem += View_VEvent_OndietToolStripMenuItem;
            model.databasemanager.GetConsumption("2018-07-02", "2018-07-22");
        }

        private void View_VEvent_OndietToolStripMenuItem(object sender, EventArgs e)
        {
            formdietpolix.SetUserControl(1);
        }

        private void View_VEvent_OnsearchToolStripMenuItem(object sender, EventArgs e)
        {
            formdietpolix.SetUserControl(5);
        }

        private void View_VEvent_OncalendarToolStripMenuItem(object sender, EventArgs e)
        {
            formdietpolix.SetUserControl(0);
        }

        private void View_VEvent_OnhometoolStripMenuItem(object sender, EventArgs e)
        {
            formdietpolix.SetUserControl(3);
        }

        private void View_VEvent_OnmyaccountToolStripMenuItem(object sender, EventArgs e)
        {
            formdietpolix.SetUserControl(6);
        }

        private void View_VEvent_OnlogOutToolStripMenuItem(object arg1, EventArgs arg2)
        {
            formdietpolix.SetUserControl(2);
            formdietpolix.HideMenu();
        }
    }
}
