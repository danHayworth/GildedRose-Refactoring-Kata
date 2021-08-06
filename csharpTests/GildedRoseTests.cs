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
                getNames,
                new string[] { },
                new int[] { },
                new int[] { }
                );
        }
        private string getNames(string name, int sellIn, int quality)
        {           
            IList<Item> newItems = new List<Item>() { new Item { Name = name, Quality = quality, SellIn = sellIn } };
            GildedRose gilded = new GildedRose(newItems);
            gilded.UpdateQuality();
            return newItems[0].ToString();
            
        }
    }
}