using System;
using Dietpolix.Models;
using Dietpolix.Views;
using System.Collections.Generic;
using Dietpolix.Classes;

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
            searchscreen.VEvent_OnbuttonSearch += View_VEvent_OnbuttonSearch;
            searchscreen.VEvent_OnProductSelectedIndexChanged += View_VEvent_OnProductSelectedIndexChanged;
        }

        private void View_VEvent_OnbuttonAddToDiet(object arg1, EventArgs arg2)
        {
            searchscreen.parent.SetUserControl(1);
        }
        private void View_VEvent_OnbuttonSearch(object arg1, EventArgs arg2)
        {
            model.listofproducts = model.apimanager.SearchItems(searchscreen.ProductName);

            List<string> ListOfProductNames = new List<string>();
            foreach(var product in model.listofproducts)
            {
                ListOfProductNames.Add(product.name);
                if (model.databasemanager.CheckIfProductExists(product.name) == false)
                {
                    model.databasemanager.AddProduct(null, product.name, product.calories, product.total_carbohydrate, product.total_fat, product.sodium, product.sugars, product.protein, product.serving_weight_grams);
                }
            }
            searchscreen.ListOfProducts = ListOfProductNames.ToArray();

            List<Diet> consumptions = model.databasemanager.GetConsumption("test","2018-07-02", "2018-07-22");
            model.printingmanager.CreatePDF(consumptions, "2018-07-02", "2018-07-22");
        }
        //TO-DO finish printing product detail
        private string desc = "Calories: {0} Total fat: {1} Portion weight: {2}";
        private void View_VEvent_OnProductSelectedIndexChanged(object arg1, EventArgs arg2)
        {
            if (searchscreen.SelectedProductID != -1 && model.listofproducts != null)
            {
                string description = String.Format(desc, model.listofproducts[searchscreen.SelectedProductID].calories, model.listofproducts[searchscreen.SelectedProductID].total_fat, model.listofproducts[searchscreen.SelectedProductID].serving_weight_grams);
                searchscreen.ProductDetails = description;
            }
        }

    }
}
