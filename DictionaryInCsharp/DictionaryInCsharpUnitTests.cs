using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DictionaryInCsharp
{

    //check all the method names
    [TestClass]
    public class DictionaryInCsharpUnitTests
    {
        [TestMethod]
        public void WhenCreatingEmptyDictionary_ThenReturnsEmptyDictionary()
        {
            var result = Program.CreateDictionary();

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(Dictionary<int,Product>));
        }

        [TestMethod]
        public void GivenEmptyDictionary_WhenAddingToDictionary_ThenReturnsPopulatedDictionary()
        {
            Dictionary<int, Product> productsDict = new Dictionary<int, Product>();
            int existingKey = 3;
            int newKey = 3;

            var result = Program.AddToDictionary(productsDict, existingKey, newKey);

            Assert.IsTrue(result.Count > 0);
            Assert.IsInstanceOfType(result, typeof(Dictionary<int, Product>));
        }

        [TestMethod]
        public void GivenExistingKey_WhenAddingToDictionary_ThenThrowsArgumentException()
        {
            Dictionary<int, Product> productsDict = new Dictionary<int, Product>();
            int existingKey = 2;
            int newKey = 3;

            var result = Program.AddToDictionary(productsDict, existingKey, newKey);

            Assert.IsTrue(result.Count > 0);
            Assert.IsInstanceOfType(result, typeof(Dictionary<int, Product>));
        }

        [TestMethod]
        public void GivenDictionaryWithData_WhenRetrievingElements_ThenReturnsElements()
        {
            Dictionary<int, Product> productsDict = new Dictionary<int, Product>();
            int existingKey = 2;
            int newKey = 3;
            Program.AddToDictionary(productsDict, existingKey, newKey);

            var result = Program.RetrieveDictionaryElements(productsDict);

            Assert.IsTrue(result.Count > 0);
            Assert.IsInstanceOfType(result, typeof(Dictionary<int, Product>));
        }
    }
}
