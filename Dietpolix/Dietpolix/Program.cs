using Dietpolix.Models;
using Dietpolix.Presenters;
using System;
using System.Windows.Forms;

namespace Dietpolix
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Model model = new Model();
            FormDietpolix formdietpolix = new FormDietpolix();
            FormDietpolixPresenter presenter = new FormDietpolixPresenter(model, formdietpolix);
            Application.Run(formdietpolix);
        }
    }
}
