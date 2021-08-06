using ApprovalTests;
using ApprovalTests.Combinations;
using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System.Collections.Generic;

namespace csharp.Tests
{
    [UseReporter(typeof(DiffReporter))]
    [TestFixture]
    [TestClass()]
    public class GildedRoseTests
    {
        [TestMethod()]
        public void GildedRoseTest()
        {
            IList<Item> items = new List<Item>(Program.Items);
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Approvals.VerifyAll<Item>(items, label: "");           
        }

        [TestMethod()]
        public void UpdateQualityTest()
        {
            CombinationApprovals.VerifyAllCombinations(
                getStringItem,
                new string[] { "foo" },
                new int[] {0 },
                new int[] {0}
                );
        }
        private string getStringItem(string name, int sellIn, int quality)
        {           
            IList<Item> newItems = new List<Item>() { new Item { Name = name, SellIn = sellIn, Quality = quality } };
            GildedRose gilded = new GildedRose(newItems);
            gilded.UpdateQuality();
            return newItems[0].ToString();
            
        }
    }
}