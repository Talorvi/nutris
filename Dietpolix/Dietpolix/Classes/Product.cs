using System;

namespace Dietpolix.Classes
{
    public class Product
    {
        public Product(string id, string name, decimal? calories, decimal? total_carbohydrate, decimal? total_fat, decimal? sodium, decimal? sugars, decimal? protein, decimal? serving_weight_grams)
        {
            if (id == null)
            {
                this.id = null;
            }
            else
            {
                this.id = Int32.Parse(id);
            }
            this.name = name;
            this.calories = calories;
            this.total_carbohydrate = total_carbohydrate;
            this.total_fat = total_fat;
            this.sodium = sodium;
            this.sugars = sugars;
            this.protein = protein;
            this.serving_weight_grams = serving_weight_grams;
        }
        public int? id { get; set; }
        public string name { get; set; }
        public decimal? calories { get; set; }
        public decimal? total_carbohydrate { get; set; }
        public decimal? total_fat { get; set; }
        public decimal? sodium { get; set; }
        public decimal? sugars { get; set; }
        public decimal? protein { get; set; }
        public decimal? serving_weight_grams { get; set; }
    }
}
