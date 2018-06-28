using System;
using System.Windows.Forms;
using Dietpolix.Views;
using System.Collections.Generic;

namespace Dietpolix
{
    public partial class CalendarScreen : UserControl, ICalendarScreen
    {
        FormDietpolix parent;
        public CalendarScreen(FormDietpolix parent)
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

        FormDietpolix ICalendarScreen.parent
        {
            get
            {
                return parent;
            }
        }
    }
}
