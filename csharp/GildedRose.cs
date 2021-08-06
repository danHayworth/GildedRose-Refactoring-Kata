using System.Collections.Generic;

namespace csharp
{
    // Dan Hayworth
    // 07-Aug-2021


    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                RefactoredUpdateQuality(Items[i]);
            }
        }

        private static void RefactoredUpdateQuality(Item item)
        {
            // changing the if statements to a switch case scenario
            switch (item.Name)
            {              
                case "Aged Brie":

                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                    item.SellIn = item.SellIn - 1;

                    if (item.SellIn < 0)
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }
                    }
                    break;

                case "Backstage passes to a TAFKAL80ETC concert":

                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;

                        if (item.SellIn < 11 && item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }

                        if (item.SellIn < 6 && item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }
                    }
                    item.SellIn = item.SellIn - 1;

                    if (item.SellIn < 0)
                    {
                        item.Quality = item.Quality - item.Quality;
                    }
                    break;

                case "Sulfuras, Hand of Ragnaros":

                    break;

                case "Conjured":

                    if (item.Quality > 0)
                    {
                        item.Quality = item.Quality == 1 ? item.Quality - 1 : item.Quality - 2;

                    }

                    item.SellIn = item.SellIn - 1;

                    if (item.SellIn < 0 && item.Quality > 0)
                    {
                        if (item.Quality == 1)
                        {
                            item.Quality = item.Quality - 1;
                        }
                        else
                        {
                            item.Quality = item.Quality - 2;
                        }
                    }
                    break;

                default:

                    if (item.Quality > 0)
                    {
                        item.Quality = item.Quality - 1;
                    }
                    item.SellIn = item.SellIn - 1;

                    if (item.SellIn < 0 && item.Quality > 0)
                    {
                        item.Quality = item.Quality - 1;
                    }
                    break;
            }
        }
    }
}


