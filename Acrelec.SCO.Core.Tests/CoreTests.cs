using Acrelec.SCO.Core.Interfaces;
using Acrelec.SCO.Core.Providers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Acrelec.SCO.Core.Tests
{
    [TestClass]
    public class CoreTests
    {
        [TestMethod]
        public void ItemsProviderAvailableMatchesDataTest()
        {
            IItemsProvider itemsProvider = new ItemsProvider("ContentItems.json");
            Assert.AreEqual(3, itemsProvider.AllPOSItems.Where(posItem => posItem.IsAvailable).Count());

            //todo - write an assert to check only for items that are available (IsAvailable=True)
        }

        [TestMethod]
        public void OrderedItemsByCodeTest()
        {
            IItemsProvider itemsProvider = new ItemsProvider("ContentItems.json");
            int[] codes = new[] { 200, 100, 101, 50 }; 

            //todo - write the code to order the items ascendent by UnitPrice
            int[] expectedCodesOrder = new[] { 50, 100, 101, 200 };
            Array.Sort(codes);
            
            //compare the ordered itemCodes to see it matches the expected order
            CollectionAssert.AreEqual(expectedCodesOrder, codes);
        }
    }
}
