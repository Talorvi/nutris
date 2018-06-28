using System;
using Dietpolix.Models;
using Dietpolix.Views;

namespace Dietpolix.Presenters
{
    public class DietScreenPresenter
    {
        IDietScreen dietscreen;
        Model model;

        public DietScreenPresenter(Model model, DietScreen dietscreen)
        {
            this.model = model;
            this.dietscreen = dietscreen;

        }
    }
}
