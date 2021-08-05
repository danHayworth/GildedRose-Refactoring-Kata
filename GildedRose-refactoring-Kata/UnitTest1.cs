using NUnit.Framework;
using csharp;

namespace GildedRose_refactoring_Kata
{
    public class Tests
    {
        [TestFixture]
        public class GildedRoseTest
        {
            [Test]
            public void foo()
            {
                IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
                GildedRose app = new GildedRose(Items);
                app.UpdateQuality();
                Assert.AreEqual("fixme", Items[0].Name);
            }
        }
    }
}