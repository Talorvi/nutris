using System;

namespace Dietpolix.Classes
{
    public class Diet
    {
        public Diet(string login, string product_name, string quantity, string date)
        {
            this.login = login;
            this.product_name = product_name;
            this.quantity = Decimal.Parse(quantity);
            this.date = date;
        }
        public string login { get; set; }
        public string product_name { get; set; }
        public decimal? quantity { get; set; }
        public string date { get; set; }
    }
}
