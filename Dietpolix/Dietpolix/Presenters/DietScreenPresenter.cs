using System;
using Dietpolix.Models;
using Dietpolix.Views;
using System.Collections.Generic;

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

            dietscreen.VEvent_OnbuttonSearch += View_VEvent_OnbuttonSearch;
            dietscreen.VEvent_OnProductSelectedIndexChanged += View_VEvent_OnProductSelectedIndexChanged;
            dietscreen.VEvent_OnbuttonAddToDiet += View_VEvent_OnbuttonAddToDiet;
            dietscreen.VEvent_OnbuttonCancel += View_VEvent_OnbuttonCancel;
            dietscreen.VEvent_OnbuttonAdd += View_VEvent_OnbuttonAdd;
            dietscreen.VEvent_OnbuttonRemove += View_VEvent_OnbuttonRemove;
            dietscreen.VEvent_OnLoad += View_VEvent_OnLoad;

        }

        private void View_VEvent_OnLoad(object arg1, EventArgs arg2)
        {
            string login = "";
            List<String> userinfo = model.databasemanager.GetUserInfo(model.user.login);
            if (userinfo.Count == 8)
            {
                model.user = new Classes.User(userinfo[0], userinfo[1], userinfo[2], userinfo[3], Int32.Parse(userinfo[4]), Int32.Parse(userinfo[5]), userinfo[6], userinfo[7]);
                login = model.user.login;
            }
            List<Classes.Diet> dietlist = model.databasemanager.GetConsumption(login, dietscreen.GetDate, dietscreen.GetDate);
            List<string> products = new List<string>();

            foreach (var product in dietlist )
            {
                products.Add(product.product_name + " " + product.quantity.ToString() + "g");
            }
            dietscreen.ShowTodayDiet(products.ToArray());
        }

        private void View_VEvent_OnbuttonRemove(object arg1, EventArgs arg2)
        {
            if(dietscreen.SelectedDietProductID != -1)
            {
                    string login = "";
                    List<String> userinfo = model.databasemanager.GetUserInfo(model.user.login);
                    if (userinfo.Count == 8)
                    {
                        model.user = new Classes.User(userinfo[0], userinfo[1], userinfo[2], userinfo[3], Int32.Parse(userinfo[4]), Int32.Parse(userinfo[5]), userinfo[6], userinfo[7]);
                        login = model.user.login;
                    }
                    dietscreen.GetPortionSize();
                model.databasemanager.RemoveConsumption(login, dietscreen.SelectedProductID.ToString(), dietscreen.GetPortionSize(), DateTime.Today.ToString());
                
                    dietscreen.RemoveDietProduct();
            }
        }

        private void View_VEvent_OnbuttonAdd(object arg1, EventArgs arg2)
        {
            if(dietscreen.SelectedProductID!=-1)
            {
                string login = "";
                List<String> userinfo = model.databasemanager.GetUserInfo(model.user.login);
                if (userinfo.Count == 8)
                {
                    model.user = new Classes.User(userinfo[0], userinfo[1], userinfo[2], userinfo[3], Int32.Parse(userinfo[4]), Int32.Parse(userinfo[5]), userinfo[6], userinfo[7]);
                    login = model.user.login;
                }
                dietscreen.GetPortionSize();
                model.databasemanager.AddConsumption(login, dietscreen.SelectedProductID.ToString(), dietscreen.GetPortionSize(), DateTime.Today.ToString());
                dietscreen.ShowAddedProducts();
                dietscreen.HideAddToDiet();
            }
        }

        private void View_VEvent_OnbuttonCancel(object arg1, EventArgs arg2)
        {
            dietscreen.HideAddToDiet();
        }

        private void View_VEvent_OnbuttonAddToDiet(object arg1, EventArgs arg2)
        {
            dietscreen.ShowAddToDiet();
        }

        private string desc = "Calories: {0} Total fat: {1} Portion weight: {2}";
        private void View_VEvent_OnProductSelectedIndexChanged(object arg1, EventArgs arg2)
        {
            if (dietscreen.SelectedProductID != -1 && model.listofproducts != null)
            {
                string description = String.Format(desc, model.listofproducts[dietscreen.SelectedProductID].calories, 
                    model.listofproducts[dietscreen.SelectedProductID].total_fat, model.listofproducts[dietscreen.SelectedProductID].serving_weight_grams);
                dietscreen.ProductDetails = description;
            }
        }

        private void View_VEvent_OnbuttonSearch(object arg1, EventArgs arg2)
        {
            model.listofproducts = model.apimanager.SearchItems(dietscreen.ProductName);

            List<string> ListOfProductNames = new List<string>();
            foreach (var product in model.listofproducts)
            {
                ListOfProductNames.Add(product.name);
                if (model.databasemanager.CheckIfProductExists(product.name) == false)
                {
                    model.databasemanager.AddProduct(null, product.name, product.calories, product.total_carbohydrate, product.total_fat, product.sodium, product.sugars, product.protein, product.serving_weight_grams);
                }
            }
            dietscreen.ListOfProducts = ListOfProductNames.ToArray();
        }
    }
}
