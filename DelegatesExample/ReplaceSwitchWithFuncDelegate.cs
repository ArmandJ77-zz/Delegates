using System;
using System.Collections.Generic;

namespace DelegatesExample
{
    //This is a basic example of replacing a switch statement
    //granted that most of the business logic can be replaced 
    //with lambdas 
    class ReplaceSwitchWithFuncDelegate
    {
        static void Main(string[] args)
        {
            //Seed InputCollection
            List<Product> ProductsCollection =
                new List<Product> { new Product { Name = "Blade", Type = ProductType.Ultrabook } };

            var SetMarketingInfo = new Dictionary<string, Func<string>>()
            {
                { ProductType.Ultrabook.ToString(), () => UltrabookInfo() },
                { ProductType.Keyboard.ToString(), () => UltrabookInfo() },
                { ProductType.Headsets.ToString(), () => UltrabookInfo() }
            };


            ProductsCollection.ForEach(x => );

        }

        //These can also be converted to properties but in 
        //a real world implementation this would each have 
        //business logic
        public static string UltrabookInfo() => "Ultra thin gaming laptop";
        public static string KeyboardInfo() => "Has color changing LEDs";
        public static string HeadsetInfo() => "Really comfy headsets";
    }

    class Product
    {
        public string Name { get; set; }
        public ProductType Type { get; set; }
        public string MarketingInfo { get; set; }
    }

    enum ProductType
    {
        Ultrabook,
        Keyboard,
        Headsets        
    }

    //Some Basic functions to simulate external class Logic calls
    class Calculations
    {
        public Add(int input, int incrementer)
        {

        }
    }
}
