using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseUpdateQualityShould
    {
        public Item getNormalItem(int sellIn = 5, int quality = 5)
        {
            return new Item { Name = "Sword", Quality = quality, SellIn = sellIn };
        }
        public Item getAgedBrie(int sellIn = 5, int quality = 5)
        {
            return new Item { Name = "Aged Brie", Quality = quality, SellIn = sellIn };
        }
        public Item getSulfuras()
        {
            return new Item { Name = "Sulfuras, Hand of Ragnaros", Quality = 80, SellIn = 5 };
        }
        public Item getBackstagePasses(int sellIn = 11, int quality = 5)
        {
            return new Item { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = quality, SellIn = sellIn };
        }


        [Test]
        public void NormalItemDecrementSellInByOne()
        {
            //Arrange
            IList<Item> Items = new List<Item> { this.getNormalItem() };

            int originalSellIn = Items[0].SellIn;
            int originalQuality = Items[0].Quality;
            GildedRose GR = new GildedRose(Items);

            //Act
            GR.UpdateQuality();

            //Assert
            Assert.AreEqual(originalSellIn - 1, Items[0].SellIn);
        }

        [Test]
        public void NormalItemDecrementQualityByOneBeforeSellIn()
        {
            //Arrange
            IList<Item> Items = new List<Item> { this.getNormalItem() };
            GildedRose GR = new GildedRose(Items);

            int originalSellIn = Items[0].SellIn;
            int originalQuality = Items[0].Quality;
            //Act
            GR.UpdateQuality();

            //Assert
            Assert.AreEqual(originalQuality - 1, Items[0].Quality);
        }

        [Test]
        public void NormalItemDecrementQualityByTwoAfterSellIn()
        {
            //Arrange
            IList<Item> Items = new List<Item> { this.getNormalItem(-1, 5) };
            GildedRose GR = new GildedRose(Items);

            int originalSellIn = Items[0].SellIn;
            int originalQuality = Items[0].Quality;
            //Act
            GR.UpdateQuality();

            //Assert
            Assert.AreEqual(originalQuality - 2, Items[0].Quality);
        }

        [Test]
        public void ItemQualityNotDecrementedBelowZero()
        {
            //Arrange
            IList<Item> Items = new List<Item> { this.getNormalItem(-1, 0) };
            GildedRose GR = new GildedRose(Items);

            int originalSellIn = Items[0].SellIn;
            int originalQuality = Items[0].Quality;
            //Act
            GR.UpdateQuality();

            //Assert
            Assert.AreEqual(0, Items[0].Quality);
        }

        [Test]
        public void AgedBrieQualityIncreasesByOneBeforeSellIn()
        {
            //Arrange
            IList<Item> Items = new List<Item> { this.getAgedBrie() };
            GildedRose GR = new GildedRose(Items);

            int originalSellIn = Items[0].SellIn;
            int originalQuality = Items[0].Quality;
            //Act
            GR.UpdateQuality();

            //Assert
            Assert.AreEqual(originalQuality + 1, Items[0].Quality);
        }

        [Test]
        public void AgedBrieQualityIncreasesByTwoAfterSellIn()
        {
            //Arrange
            IList<Item> Items = new List<Item> { this.getAgedBrie(-1, 5) };
            GildedRose GR = new GildedRose(Items);

            int originalSellIn = Items[0].SellIn;
            int originalQuality = Items[0].Quality;
            //Act
            GR.UpdateQuality();

            //Assert
            Assert.AreEqual(originalQuality + 2, Items[0].Quality);
        }

        [Test]
        public void AgedBrieQualityNotIncrementedAboveFifty()
        {
            //Arrange
            IList<Item> Items = new List<Item> { this.getAgedBrie(-1, 50) };
            GildedRose GR = new GildedRose(Items);

            int originalSellIn = Items[0].SellIn;
            int originalQuality = Items[0].Quality;
            //Act
            GR.UpdateQuality();

            //Assert
            Assert.AreEqual(50, Items[0].Quality);
        }

        [Test]
        public void SulfurasQualityNotChanged()
        {
            //Arrange
            IList<Item> Items = new List<Item> { this.getSulfuras() };
            GildedRose GR = new GildedRose(Items);

            int originalSellIn = Items[0].SellIn;
            int originalQuality = Items[0].Quality;
            //Act
            GR.UpdateQuality();

            //Assert
            Assert.AreEqual(originalQuality, Items[0].Quality);
        }

        [Test]
        public void SulfurasSellInNotDecremented()
        {
            //Arrange
            IList<Item> Items = new List<Item> { this.getSulfuras() };
            GildedRose GR = new GildedRose(Items);

            int originalSellIn = Items[0].SellIn;
            int originalQuality = Items[0].Quality;
            //Act
            GR.UpdateQuality();

            //Assert
            Assert.AreEqual(originalSellIn, Items[0].SellIn);
        }

        [Test]
        public void BackstagePassesSellInDecrementedByOne()
        {
            //Arrange
            IList<Item> Items = new List<Item> { this.getBackstagePasses() };
            GildedRose GR = new GildedRose(Items);

            int originalSellIn = Items[0].SellIn;
            int originalQuality = Items[0].Quality;
            //Act
            GR.UpdateQuality();

            //Assert
            Assert.AreEqual(originalSellIn - 1, Items[0].SellIn);
        }

        [Test]
        public void BackstagePassesQualityToZeroAfterSellIn()
        {
            //Arrange
            IList<Item> Items = new List<Item> { this.getBackstagePasses(-2, 5) };
            GildedRose GR = new GildedRose(Items);

            int originalSellIn = Items[0].SellIn;
            int originalQuality = Items[0].Quality;
            //Act
            GR.UpdateQuality();

            //Assert
            Assert.AreEqual(0, Items[0].Quality);
        }

        [Test]
        public void BackstagePassesQualityUpByOneAt11Days()
        {
            //Arrange
            IList<Item> Items = new List<Item> { this.getBackstagePasses() };
            GildedRose GR = new GildedRose(Items);

            int originalSellIn = Items[0].SellIn;
            int originalQuality = Items[0].Quality;
            //Act
            GR.UpdateQuality();

            //Assert
            Assert.AreEqual(originalQuality + 1, Items[0].Quality);
        }

        [Test]
        public void BackstagePassesQualityUpBy2At10Days()
        {
            //Arrange
            IList<Item> Items = new List<Item> { this.getBackstagePasses(10, 5) };
            GildedRose GR = new GildedRose(Items);

            int originalSellIn = Items[0].SellIn;
            int originalQuality = Items[0].Quality;
            //Act
            GR.UpdateQuality();

            //Assert
            Assert.AreEqual(originalQuality + 2, Items[0].Quality);
        }

        [Test]
        public void BackstagePassesQualityUpBy3At5Days()
        {
            //Arrange
            IList<Item> Items = new List<Item> { this.getBackstagePasses(5, 5) };
            GildedRose GR = new GildedRose(Items);

            int originalSellIn = Items[0].SellIn;
            int originalQuality = Items[0].Quality;
            //Act
            GR.UpdateQuality();

            //Assert
            Assert.AreEqual(originalQuality + 3, Items[0].Quality);
        }

    }
}
