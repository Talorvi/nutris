using System;
using System.Windows.Forms;
using Dietpolix.Views;
using System.Collections.Generic;

namespace Dietpolix
{
    public partial class SearchScreen : UserControl, ISearchScreen
    {
        FormDietpolix parent;
        public SearchScreen(FormDietpolix parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        public Control FormDietpolix
        {
            get
            {
                return this.Parent;
            }
        }

        public string[] ListOfProducts
        {
            set
            {
                if (value != null)
                {
                    listBoxMatches.Items.Clear();
                    listBoxMatches.Items.AddRange(value);
                }
            }
        }
        new public string ProductName
        {
            get
            {
                return textBoxSearchProduct.Text;
            }
        }
        public string ProductDetails
        {
            set
            {
                textBoxProductDetails.Text = value;
            }
        }
        public int SelectedProductID
        {
            get
            {
                return listBoxMatches.SelectedIndex;
            }
        }

        FormDietpolix ISearchScreen.parent
        {
            get
            {
                return parent;
            }
        }

        public event Action<object, EventArgs> VEvent_OnbuttonAddToDiet;
        public event Action<object, EventArgs> VEvent_OnbuttonSearch;
        public event Action<object, EventArgs> VEvent_OnProductSelectedIndexChanged;

        private void buttonAddToDiet_Click(object sender, System.EventArgs e)
        {
            if (this.VEvent_OnbuttonAddToDiet != null)
            {
                VEvent_OnbuttonAddToDiet(sender, e);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (this.VEvent_OnbuttonSearch != null)
            {
                VEvent_OnbuttonSearch(sender, e);
            }
        }

        private void listBoxMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.VEvent_OnProductSelectedIndexChanged != null)
            {
                VEvent_OnProductSelectedIndexChanged(sender, e);
            }
        }
    }
}
