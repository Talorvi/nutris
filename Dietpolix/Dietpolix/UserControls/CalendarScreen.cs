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

        public string GetDate
        {
            get
            {
                return monthCalendarDiet.SelectionEnd.ToString("yyyy-MM-dd");
            }
        }

        public void ShowDiet(string[] products)
        {
            listBoxUserDayDiet.Items.Clear();
            if (products.Length != 0)
            {
                listBoxUserDayDiet.Items.AddRange(products);
            }
            else
            {
                listBoxUserDayDiet.Items.Add("<No products in diet>");
            }

        }

        public event Action<object, EventArgs> VEvent_OnmonthCalendarDiet_DateSelected;

        private void monthCalendarDiet_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (this.VEvent_OnmonthCalendarDiet_DateSelected != null)
            {
                VEvent_OnmonthCalendarDiet_DateSelected(sender, e);
            }
        }
    }
}
