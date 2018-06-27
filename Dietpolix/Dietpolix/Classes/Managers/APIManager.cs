﻿using Nutritionix;
using System;

namespace Dietpolix.Classes.Managers
{
    public class APIManagaer
    {
        public APIManagaer()
        {

        }
        //static APIManagaer()
        //{
            // TODO: Replace with your Nutritionix API ID and Key
            //string AppId = "0128e9a3";
            //string AppKey = "38e703f742f5baa7b4bbe96e2d9b26a5";
        //}

        private static readonly string AppId= "0128e9a3";
        private static readonly string AppKey= "38e703f742f5baa7b4bbe96e2d9b26a5";

        public void RunAll()
        {
            SearchItems();
            //PowerSearchItems();
            //RetrieveItem();
            //RetrieveItemByUPC();
            //RetrieveBrand();
            //RetrieveItemsByBrand();
        }

        public static void SearchItems()
        {
            var nutritionix = new NutritionixClient();
            nutritionix.Initialize(AppId, AppKey);

            var request = new SearchRequest { Query = "beer" };
            Console.WriteLine("Searching Nutritionix for 'beer'...");
            SearchResponse response = nutritionix.SearchItems(request);

            Console.WriteLine("Displaying results 1 - {0} of {1}", response.Results.Length, response.TotalResults);
            foreach (SearchResult result in response.Results)
            {
                Console.WriteLine("* {0}", result.Item.Name);
            }

            Console.WriteLine();
        }
        
        public static void PowerSearchItems()
        {
            var nutritionix = new NutritionixClient();
            nutritionix.Initialize(AppId, AppKey);

            var request = new PowerSearchRequest
            {
                Queries = new QueryFilterCollection { new QueryFilter(x => x.Name, "frap*"), new QueryFilter(x => x.BrandName, "Starbucks") },
                Fields = new SearchResultFieldCollection { x => x.Name, x => x.BrandName, x => x.NutritionFact_Calories, x => x.ItemType },
                SortBy = new SearchResultSort(x => x.NutritionFact_Calories, SortOrder.Descending),
                Filters = new SearchFilterCollection
                {
                    new ItemTypeFilter {Negated = true, ItemType = ItemType.Packaged}
                }
            };

            Console.WriteLine("Power Searching Nutritionix for: Item Name: 'frap*' and Brand Name: 'Starbucks' sorted by calories, not a packaged food...");
            SearchResponse response = nutritionix.SearchItems(request);

            Console.WriteLine("Displaying results 1 - {0} of {1}", response.Results.Length, response.TotalResults);
            foreach (SearchResult result in response.Results)
            {
                Console.WriteLine("* {0} {1} ({2} calories) from the {3} database", result.Item.BrandName, result.Item.Name, result.Item.NutritionFact_Calories, result.Item.ItemType);
            }

            Console.WriteLine();
        }

        public static void RetrieveItem()
        {
            var nutritionix = new NutritionixClient();
            nutritionix.Initialize(AppId, AppKey);

            Console.WriteLine("Retrieving 'Raspberry Pie' from Nutritionix...");
            Item item = nutritionix.RetrieveItem("56dfd0652c93fba9556c02e7");

            Console.WriteLine("Item Id: {0}", item.Id);
            Console.WriteLine("Item Name: {0}", item.Name);
            Console.WriteLine("Brand Name: {0}", item.BrandName);

            Console.WriteLine("Calories: {0}", item.NutritionFact_Calories);
            Console.WriteLine("Sugar: {0} g", item.NutritionFact_Sugar);

            Console.WriteLine();
        }

        public static void RetrieveItemByUPC()
        {
            var nutritionix = new NutritionixClient();
            nutritionix.Initialize(AppId, AppKey);

            const string upc = "029000071087";
            Console.WriteLine("Looking up UPC code: {0}...", upc);
            Item item = nutritionix.RetrieveItemByUPC(upc);

            Console.WriteLine("Item Id: {0}", item.Id);
            Console.WriteLine("Item Name: {0}", item.Name);
            Console.WriteLine("Brand Name: {0}", item.BrandName);

            Console.WriteLine("Calories: {0}", item.NutritionFact_Calories);
            Console.WriteLine("Sugar: {0} g", item.NutritionFact_Sugar);

            Console.WriteLine();
        }

        public static void RetrieveBrand()
        {
            var nutritionix = new NutritionixClient();
            nutritionix.Initialize(AppId, AppKey);

            Console.WriteLine("Retrieving 'Taco Bell' from Nutritionix...");
            Brand brand = nutritionix.RetrieveBrand("513fbc1283aa2dc80c000020");

            Console.WriteLine("Brand Id: {0}", brand.Id);
            Console.WriteLine("Brand Name: {0}", brand.Name);

            Console.WriteLine("Logo: {0}", brand.LogoUrl);
            Console.WriteLine("Website: {0}", brand.Website);

            Console.WriteLine();
        }

        public static void RetrieveItemsByBrand()
        {
            var nutritionix = new NutritionixClient();
            nutritionix.Initialize(AppId, AppKey);

            var request = new SearchRequest { BrandId = "513fbc1283aa2dc80c000024" };
            Console.WriteLine("Searching Nutritionix for the Olive Garden brand...");
            SearchResponse response = nutritionix.SearchItems(request);

            Console.WriteLine("Displaying results 1 - {0} of {1}", response.Results.Length, response.TotalResults);
            foreach (SearchResult result in response.Results)
            {
                Console.WriteLine("* {0}", result.Item.Name);
            }

            Console.WriteLine();
        }
    }
}