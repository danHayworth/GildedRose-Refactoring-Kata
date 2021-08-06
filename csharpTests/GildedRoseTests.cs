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

        }
    }
}