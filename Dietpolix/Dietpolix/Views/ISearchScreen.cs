using System;
using System.Windows.Forms;

namespace Dietpolix.Views
{
    public interface ISearchScreen
    {
        event Action<object, EventArgs> VEvent_OnbuttonAddToDiet;
        event Action<object, EventArgs> VEvent_OnbuttonSearch;
        event Action<object, EventArgs> VEvent_OnProductSelectedIndexChanged;

        Control FormDietpolix { get; }
        string[] ListOfProducts { set; }
        string ProductName { get; }
        int SelectedProductID { get; }
        string ProductDetails { set; }
        FormDietpolix parent { get; }
    }
}
