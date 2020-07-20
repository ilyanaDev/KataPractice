using System.Collections.Generic;

namespace csharp
{
    public interface IUpdateQuality
    {
        void UpdateQuality(Item item);
    }

    public class UpdateNormalQuality : IUpdateQuality
    {
        public void UpdateQuality(Item item)
        {
            
            if(item.Quality > 0)
            {
                item.Quality = item.Quality - 1;
            }

            item.SellIn = item.SellIn - 1;

            if (item.Quality > 0 && item.SellIn < 0)
            {
                item.Quality = item.Quality - 1;
            }


        }

    }

    public class UpdateAgedBrieQuality : IUpdateQuality
    {
        public void UpdateQuality(Item item)
        {

            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0 && item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }

        }
    }

    public class UpdateSulfurasQuality : IUpdateQuality
    {
        public void UpdateQuality(Item item)
        {
            //do nothing
        }
    }
    public class UpdateBackStagePassesQuality : IUpdateQuality
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;

                if (item.SellIn < 11)
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }

                if (item.SellIn < 6)
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
            
            }

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
        }

    }

    public class UpdateConjuredQuality : IUpdateQuality
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 2;
            }

            item.SellIn = item.SellIn - 1;

            if (item.Quality > 0 && item.SellIn < 0)
            {
                item.Quality = item.Quality - 2;
            }


        }

    }


    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (Item item in Items)
            {
                if (item.Name == "Aged Brie")
                {
                    var Updater = new UpdateAgedBrieQuality();
                    Updater.UpdateQuality(item);
                    break;
                }

                if (item.Name == "Sulfuras, Hand of Ragnaros")
                {
                    var Updater = new UpdateSulfurasQuality();
                    Updater.UpdateQuality(item);
                    break;
                }

                if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    var Updater = new UpdateBackStagePassesQuality();
                    Updater.UpdateQuality(item);
                    break;
                }

                if (item.Name == "Conjured")
                {
                    var Updater = new UpdateConjuredQuality();
                    Updater.UpdateQuality(item);
                    break;
                }

                var Updater1 = new UpdateNormalQuality();
                Updater1.UpdateQuality(item);
                break;
            }
        }
    }
}
