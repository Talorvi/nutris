using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dietpolix.Classes;

namespace Dietpolix.Views
{
    public interface IDietScreen
    {
        event Action<object, EventArgs> VEvent_OnbuttonSearch;
        event Action<object, EventArgs> VEvent_OnProductSelectedIndexChanged;
        event Action<object, EventArgs> VEvent_OnbuttonAddToDiet;
        event Action<object, EventArgs> VEvent_OnbuttonCancel;
        event Action<object, EventArgs> VEvent_OnbuttonAdd;
        event Action<object, EventArgs> VEvent_OnbuttonRemove;
        event Action<object, EventArgs> VEvent_OnLoad;

        void ShowAddToDiet();
        void HideAddToDiet();
        string GetPortionSize();
        void ShowAddedProducts();
        void RemoveDietProduct();
        //void ShowTodayDiet(List<string> products);

        string ProductName { get; }
        string[] ListOfProducts { set; }
        int SelectedProductID { get; }
        int SelectedDietProductID { get; }
        string ProductDetails { set; }
        Control FormDietpolix { get; }
        FormDietpolix parent { get; }
    }
}
