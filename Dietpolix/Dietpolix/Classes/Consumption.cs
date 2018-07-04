using System;

namespace Dietpolix.Classes
{
    public class Consumption
    {
        public Consumption(string login, string product_id, string quantity, string date)
        {
            this.login = login;
            this.product_id = Int32.Parse(product_id);
            this.quantity = Decimal.Parse(quantity);
            this.date = date;
        }
        public string login { get; set; }
        public int product_id { get; set; }
        public decimal? quantity { get; set; }
        public string date { get; set; }

    }
}
