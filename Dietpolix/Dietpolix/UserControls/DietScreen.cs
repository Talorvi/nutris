using System;
using System.Windows.Forms;
using Dietpolix.Views;
using System.Collections.Generic;

namespace Dietpolix
{
    public partial class DietScreen : UserControl, IDietScreen
    {
        FormDietpolix parent;
        public DietScreen(FormDietpolix parent)
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

        FormDietpolix IDietScreen.parent
        {
            get
            {
                return parent;
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
                textBoxDetails.Text = value;
            }
        }
        public int SelectedProductID
        {
            get
            {
                return listBoxMatches.SelectedIndex;
            }
        }

        public int SelectedDietProductID
        {
            get
            {
                return listBoxCurrentDiet.SelectedIndex;
            }
        }

        public void ShowAddToDiet()
        {
            groupBoxAddToDiet.Visible = true;
        }

        public void HideAddToDiet()
        {
            groupBoxAddToDiet.Visible = false;
        }

        public string GetPortionSize()
        {
            return numericUpDownPortionSize.Value.ToString();
        }

        public void ShowAddedProducts()
        {
            if (listBoxCurrentDiet.Items.IndexOf("<No products in diet>") == 0)
                listBoxCurrentDiet.Items.Clear();
            listBoxCurrentDiet.Items.Add(listBoxMatches.SelectedItem.ToString() + " " + GetPortionSize().ToString() + "g");
        }

        public void RemoveDietProduct()
        {
            if (listBoxCurrentDiet.Items.IndexOf("<No products in diet>") == -1)
                listBoxCurrentDiet.Items.Remove(listBoxCurrentDiet.SelectedItem);
            if(listBoxCurrentDiet.Items.Count==0)
                listBoxCurrentDiet.Items.Add("<No products in diet>");
        }

        //public void ShowTodayDiet(List<string> products)
        //{
        //    listBoxCurrentDiet.Items.AddRange(products.ToArray());
        //}

        public event Action<object, EventArgs> VEvent_OnbuttonSearch;
        public event Action<object, EventArgs> VEvent_OnProductSelectedIndexChanged;
        public event Action<object, EventArgs> VEvent_OnbuttonAddToDiet;
        public event Action<object, EventArgs> VEvent_OnbuttonCancel;
        public event Action<object, EventArgs> VEvent_OnbuttonAdd;
        public event Action<object, EventArgs> VEvent_OnbuttonRemove;
        public event Action<object, EventArgs> VEvent_OnLoad;

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

        private void buttonAddToDiet_Click(object sender, EventArgs e)
        {
            if (this.VEvent_OnbuttonAddToDiet != null)
            {
                VEvent_OnbuttonAddToDiet(sender, e);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (this.VEvent_OnbuttonCancel != null)
            {
                VEvent_OnbuttonCancel(sender, e);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (this.VEvent_OnbuttonAdd != null)
            {
                VEvent_OnbuttonAdd(sender, e);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (this.VEvent_OnbuttonRemove != null)
            {
                VEvent_OnbuttonRemove(sender, e);
            }
        }

        private void DietScreen_Load(object sender, EventArgs e)
        {
            if (this.VEvent_OnLoad != null)
            {
                VEvent_OnLoad(sender, e);
            }
        }
    }
}
