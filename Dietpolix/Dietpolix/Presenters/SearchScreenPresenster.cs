using System;
using Dietpolix.Models;
using Dietpolix.Views;

namespace Dietpolix.Presenters
{
    public class SearchScreenPresenter
    {
        ISearchScreen searchscreen;
        Model model;

        public SearchScreenPresenter(Model model, SearchScreen searchscreen)
        {
            this.model = model;
            this.searchscreen = searchscreen;

            searchscreen.VEvent_OnbuttonAddToDiet += View_VEvent_OnbuttonAddToDiet;
        }

        private void View_VEvent_OnbuttonAddToDiet(object arg1, EventArgs arg2)
        {
            searchscreen.parent.SetUserControl(1);
        }
    }
}
