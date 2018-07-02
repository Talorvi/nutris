using Nutritionix;
using System;
using System.Collections.Generic;

namespace Dietpolix.Classes.Managers
{
    public class APIManager
    {
        public APIManager()
        {

        }

        private static readonly string AppId= "0128e9a3";
        private static readonly string AppKey= "38e703f742f5baa7b4bbe96e2d9b26a5";

        public List<Product> SearchItems(string product)
        {
            List<Product> ListOfProducts = new List<Product>();

            var nutritionix = new NutritionixClient();
            nutritionix.Initialize(AppId, AppKey);

            var request = new SearchRequest
            {
                Query = product,
                Fields = new SearchResultFieldCollection { x => x.Name, x => x.BrandName, x => x.NutritionFact_Calories, x => x.ItemType, x => x.NutritionFact_TotalCarbohydrate, x => x.NutritionFact_TotalFat, x => x.NutritionFact_Sodium, x => x.NutritionFact_Sugar, x => x.NutritionFact_Protein, x => x.NutritionFact_ServingGramWeight },
            };
            SearchResponse response = nutritionix.SearchItems(request);

            foreach (SearchResult result in response.Results)
            {
                ListOfProducts.Add(new Product(result.Item.Id, result.Item.Name, result.Item.NutritionFact_Calories, result.Item.NutritionFact_TotalCarbohydrate, result.Item.NutritionFact_TotalFat, result.Item.NutritionFact_Sodium, result.Item.NutritionFact_Sugar, result.Item.NutritionFact_Protein, result.Item.NutritionFact_ServingGramWeight));
            }

            return ListOfProducts;
        }
    }
}
