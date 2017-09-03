using System;
using System.Collections.Generic;

namespace DelegatesExample
{
    //1 - Define object
    class Product
    {
        public string Name { get; set; }
        public ProductType Type { get; set; }
        public string MarketingInfo { get; set; }
    }

    //2 - Define enums
    enum ProductType
    {
        Ultrabook,
        Keyboard,
        Headsets
    }

    class ReplaceSwitchWithFuncDelegate
    {
        //This is a basic example of replacing a switch statement
        //granted that most of the business logic can be replaced 
        //with lambdas 
        static void Main(string[] args)
        {
            //3 - Seed InputCollection
            List<Product> ProductsCollection =
                new List<Product> {
                    new Product { Name = "Razer Blade Pro", Type = ProductType.Ultrabook },
                    new Product { Name = "Razer Orinata", Type = ProductType.Keyboard },
                    new Product { Name = "Kraken Pro V2", Type = ProductType.Headsets },
                };

            //4 - Define a dictionary which accepts a string as a condition and retruns a delagte result of type string
            //The replacement of the traditional switch, although its important to note that if each
            //func returns a diffirent type then use a return func<dynamic> instead of func<string>
            var SetMarketingInfo = new Dictionary<string, Func<string>>()
            {
                { ProductType.Ultrabook.ToString(), () => UltrabookInfo() },
                { ProductType.Keyboard.ToString(), () => KeyboardInfo() },
                { ProductType.Headsets.ToString(), () => HeadsetInfo() }
            };

            // 6 - Iterate over the collection and assign the correct marketing information
            ProductsCollection.ForEach(x => x.MarketingInfo = SetMarketingInfo[x.Type.ToString()].Invoke());

            // 7 - Iterate over colection and display the products
            ProductsCollection.ForEach(x => Console.WriteLine(x.MarketingInfo));
        }

        // 5 - These can also be converted to properties but in a real
        // world implementation this would each contain some business logic
        // or reads from a repository
        public static string UltrabookInfo() => "Ultra thin gaming laptop";
        public static string KeyboardInfo() => "Has color changing LEDs";
        public static string HeadsetInfo() => "Really comfy headsets";
    }
}
