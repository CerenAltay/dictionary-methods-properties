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
        public void WhenCreatingDictionary_ThenReturnsEmptyDictionary()
        {
            var result = Program.CreateDictionary();

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(Dictionary<,>));
        }


        [TestMethod]
        public void GivenEmptyDictionary_WhenAddingToDictionary_ThenReturnsPopulatedDictionary()
        {
            
            
            

            //Assert.IsNotNull(result);
            //Assert.IsInstanceOfType(result, typeof(Dictionary<,>));
        }

    }
}
