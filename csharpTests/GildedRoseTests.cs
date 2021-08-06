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
                new string[] { "foo", "Aged Brie", "Backstage passes to a TAFKAL80ETC concert", "Sulfuras, Hand of Ragnaros", "Conjured"},
                new int[] { 0, 10, 5, -1 },
                new int[] { 0, 1, 49 }
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