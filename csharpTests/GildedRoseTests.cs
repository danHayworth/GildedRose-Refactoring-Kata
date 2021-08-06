using ApprovalTests;
using ApprovalTests.Combinations;
using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace csharp.Tests
{
    [UseReporter(typeof(DiffReporter))]
    [TestClass()]
    public class GildedRoseTests
    {
        [TestMethod()]
        public void GildedRoseTest()
        {
            IList<Item> items = new List<Item>() { new Item() { Name = "foo", Quality = 1, SellIn = 2 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            //CombinationApprovals.VerifyAllCombinations<Item>();
            Approvals.AssertEquals("foo", items[0].Name);
        }

        [TestMethod()]
        public void UpdateQualityTest()
        {

        }
    }
}