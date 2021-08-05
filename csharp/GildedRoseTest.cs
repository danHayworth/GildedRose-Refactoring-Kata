using ApprovalTests;
using ApprovalTests.Reporters;
using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [UseReporter(typeof(DiffReporter))]
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void GildedRose()
        {
            IList<Item> items = new List<Item>() { new Item() { Name = "foo", Quality = 1, SellIn = 2 } };
            GildedRose app  = new GildedRose(items);
            app.UpdateQuality();
            Approvals.Verify(items[0].Name);
        }
    }
}
