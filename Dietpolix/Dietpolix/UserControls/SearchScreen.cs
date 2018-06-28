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

        FormDietpolix ISearchScreen.parent
        {
            get
            {
                return parent;
            }
        }

        public event Action<object, EventArgs> VEvent_OnbuttonAddToDiet;

        private void buttonAddToDiet_Click(object sender, System.EventArgs e)
        {
            if (this.VEvent_OnbuttonAddToDiet != null)
            {
                VEvent_OnbuttonAddToDiet(sender, e);
            }
        }
    }
}
