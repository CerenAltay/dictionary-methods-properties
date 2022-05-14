using System;
using System.Collections.Generic;

namespace DictionaryInCsharp
{
    public class Program
    {
        public static Dictionary<int, Product> CreateDictionary()
        {

            //
            Dictionary<int, Product> productsDict = new Dictionary<int, Product>();

            return productsDict;
        }

        public static Dictionary<int, Product> AddToDictionary(Dictionary<int, Product> productsDict, int existingKey, int newKey)
        {
            productsDict.Add(0, new Product() { ProductId = 111, ProductName = "Table" });
            productsDict.Add(1, new Product() { ProductId = 112, ProductName = "Chair" });
            productsDict.Add(2, new Product() { ProductId = 113, ProductName = "TV" });

            existingKey = 2;

            int key = 2;

            try
            {
                productsDict.Add(key, new Product() { ProductId = 113, ProductName = "Wardrobe" });
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //newKey = 3;

            if (productsDict.TryAdd(newKey, new Product() { ProductId = 114, ProductName = "Lamp" }))
            {
                Console.WriteLine($"Product is added.");
            }


            return productsDict;
        }

        public static Dictionary<int, Product> RetrieveDictionaryElements(Dictionary<int, Product> productsDict)
        {
            foreach (KeyValuePair<int, Product> product in productsDict)
            {
                Console.WriteLine($"Key= {product.Key}, Value = {product.Value.ProductId}, {product.Value.ProductName}");
            }

            int dictKey = 1;

            if (productsDict.ContainsKey(dictKey))
            {
                Console.WriteLine($"Dictionary Key = {dictKey} exists, it's value is = {productsDict[dictKey].ProductId}, {productsDict[dictKey].ProductName}");
            }

            //use get value or default extension method
            if (productsDict.TryGetValue(dictKey, out Product product1))
            {
                Console.WriteLine($"Key: {dictKey}, Value: {product1.ProductId}, {product1.ProductName}");
            }

            var prod = (productsDict.GetValueOrDefault(5));

            return productsDict;
        }

        public static Dictionary<int, Product> UpdateDictionary(Dictionary<int, Product> productsDict)
        {
            productsDict[0] = new Product() { ProductId = 110, ProductName = "Desk" };

            foreach (KeyValuePair<int, Product> product in productsDict)
            {
                Console.WriteLine($"Key = {product.Key}, Value = {product.Value.ProductId}, {product.Value.ProductName}");
            }

            return productsDict;
        }

        public static Dictionary<int, Product> DeleteDictionaryElements(Dictionary<int, Product> productsDict)
        {
            productsDict.Remove(3);

            foreach (KeyValuePair<int, Product> product in productsDict)
            {
                Console.WriteLine($"Key = {product.Key}, Value = {product.Value.ProductId}, {product.Value.ProductName}");
            }

            return productsDict;
        }

        public static int ClearDictionary(Dictionary<int, Product> productsDict)
        {
            productsDict.Clear();

            int numberOfElements = productsDict.Count;

            Console.WriteLine($"Number of dictionary elements: {numberOfElements}");

            return numberOfElements;
        }

        static void Main(string[] args)
        {

            //
            Dictionary<int, string> dict1 = new Dictionary<int, string>();

            //
            Dictionary<int, string> dict2 = new Dictionary<int, string>(10);

            //
            Dictionary<int, string> dict3 = new Dictionary<int, string>()
            {
                {1, "Red"},
                {2, "Yellow"},
                {3, "Green"},
            };

            Dictionary<int, Product> productsDict = CreateDictionary();

            AddToDictionary(productsDict, 2, 3);

            RetrieveDictionaryElements(productsDict);

            UpdateDictionary(productsDict);

            DeleteDictionaryElements(productsDict);

            ClearDictionary(productsDict);
        }
    }
}
