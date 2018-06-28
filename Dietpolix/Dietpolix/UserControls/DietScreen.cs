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
    }
}
