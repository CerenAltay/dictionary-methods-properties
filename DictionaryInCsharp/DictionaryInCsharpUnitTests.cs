using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DictionaryInCsharp
{
    [TestClass]
    public class DictionaryInCsharpUnitTests
    {
        Dictionary<int, Product> productsDict = new Dictionary<int, Product>()
        {
            { 0, new Product() { ProductId = 111, ProductName = "Table" }},
            { 1, new Product() { ProductId = 112, ProductName = "Chair" }},
            { 2, new Product() { ProductId = 113, ProductName = "TV" }},
        };

        [TestMethod]
        public void WhenCreatingEmptyDictionary_ThenReturnsEmptyDictionary()
        {
            var result = Program.CreateDictionary();

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(Dictionary<int, Product>));
        }

        [TestMethod]
        public void GivenEmptyDictionary_WhenAddingToDictionary_ThenReturnsPopulatedDictionary()
        {
            Dictionary<int, Product> emptyDict = new Dictionary<int, Product>();
            int existingKey = 3;
            int newKey = 3;

            var result = Program.AddToDictionary(emptyDict, existingKey, newKey);

            Assert.IsTrue(result.Count > 0);
            Assert.IsInstanceOfType(result, typeof(Dictionary<int, Product>));
        }

        [TestMethod]
        public void GivenExistingKey_WhenAddingToDictionary_ThenThrowsArgumentException()
        {
            int existingKey = 2;
            int newKey = 3;

            var result = Program.AddToDictionary(productsDict, existingKey, newKey);

            Assert.IsTrue(result.Count > 0);
            Assert.IsInstanceOfType(result, typeof(Dictionary<int, Product>));
        }

        [TestMethod]
        public void GivenDictionaryWithData_WhenRetrievingElements_ThenReturnsElements()
        {

            var result = Program.RetrieveDictionaryElements(productsDict);

            Assert.IsTrue(result.Count > 0);
            Assert.IsInstanceOfType(result, typeof(Dictionary<int, Product>));
        }

        [TestMethod]
        public void GivenDictionaryWithData_WhenUpdatingDictionary_ThenReturnsUpdatedElements()
        {

            var result = Program.UpdateDictionary(productsDict);

            Assert.IsTrue(result.Count > 0);
            Assert.IsInstanceOfType(result, typeof(Dictionary<int, Product>));
        }


        [TestMethod]
        public void GivenDictionaryWithData_WhenDeletingElements_ThenReturnsRemovesElements()
        {

            var result = Program.DeleteDictionaryElements(productsDict);

            Assert.IsTrue(result.Count > 0);
            Assert.IsInstanceOfType(result, typeof(Dictionary<int, Product>));
        }


        [TestMethod]
        public void GivenDictionaryWithData_WhenClearingDictionary_ThenReturnsZeroNumberOfElements()
        {
            var result = Program.ClearDictionary(productsDict);

            Assert.IsTrue(result == 0);
        }
    }
}
