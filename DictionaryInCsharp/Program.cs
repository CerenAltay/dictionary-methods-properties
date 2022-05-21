﻿using System;
using System.Collections.Generic;

namespace DictionaryInCsharp
{
    public class Program
    {
        public static Dictionary<int, Product> CreateDictionary()
        {
            Dictionary<int, Product> productsDict = new Dictionary<int, Product>();

            return productsDict;
        }

        public static Dictionary<int, Product> AddToDictionary(Dictionary<int, Product> productsDict)
        {
            productsDict.Add(0, new Product() { ProductId = 111, ProductName = "Table" });
            productsDict.Add(1, new Product() { ProductId = 112, ProductName = "Chair" });
            productsDict.Add(2, new Product() { ProductId = 113, ProductName = "TV" });

            try
            {
                productsDict.Add(2, new Product() { ProductId = 113, ProductName = "Wardrobe" });
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (productsDict.TryAdd(3, new Product() { ProductId = 114, ProductName = "Lamp" }))
            {
                Console.WriteLine($"Product is added.");
            }

            return productsDict;
        }


        public static Product RetrieveDictionaryElements(Dictionary<int, Product> productsDict)
        {
            Console.WriteLine();
            foreach(KeyValuePair<int, Product> product in productsDict)
            {
                Console.WriteLine($"Key = {product.Key}, Value = {product.Value.ProductId}, {product.Value.ProductName}");
            }
            Console.WriteLine();

            var prod = (productsDict.GetValueOrDefault(2));

            return prod;
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
            productsDict.Remove(2);

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

            //creating empty dictionary 
            Dictionary<int, string> dict1 = new Dictionary<int, string>();

            //creating dictionary with number of elements
            Dictionary<int, string> dict2 = new Dictionary<int, string>(10);

            //creating dictionary with data
            Dictionary<int, string> dict3 = new Dictionary<int, string>()
            {
                {1, "Red"},
                {2, "Yellow"},
                {3, "Green"},
            };

            Dictionary<int, Product> productsDict = CreateDictionary();

            AddToDictionary(productsDict);

            Console.WriteLine();

            RetrieveDictionaryElements(productsDict);
            Console.WriteLine();

            UpdateDictionary(productsDict);
            Console.WriteLine();

            DeleteDictionaryElements(productsDict);
            Console.WriteLine();

            ClearDictionary(productsDict);
            Console.WriteLine();
        }
    }
}
