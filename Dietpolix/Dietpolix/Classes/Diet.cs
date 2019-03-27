using System;

namespace Dietpolix.Classes
{
    public class Diet
    {
        public Diet(string login, string product_name, string quantity, string date, string carbohydrates, string fat, string protein)
        {
            this.login = login;
            this.product_name = product_name;
            this.quantity = Decimal.Parse(quantity);
            this.date = date;
            this.carbohydrates = Double.Parse(carbohydrates);
            this.fat = Double.Parse(fat);
            this.protein = Double.Parse(protein);
        }
        public string login { get; set; }
        public string product_name { get; set; }
        public decimal? quantity { get; set; }
        public string date { get; set; }
        public double carbohydrates { get; set; }
        public double fat { get; set; }
        public double protein { get; set; }
    }
}
