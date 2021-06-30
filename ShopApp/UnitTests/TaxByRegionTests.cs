using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopAppLibrary;
using ShopAppLibrary.Factory;

namespace UnitTests
{
    [TestClass]
    public class TaxByRegionTests
    {
        [TestMethod]
        public void CalculateTax_WhenItemHasOwnerWithRegionEU_ReturnCorrectTax()
        {
            // Arrange
            var vendor = new Vendor() { Region = "EU"};
            var item = new Item() { Owner = vendor , Price = 10};
            var tax = new TaxByRegion();
            var expected = 10 * .24m;

            // Act
            var actual = tax.CalculateTax(item);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateTax_WhenItemHasOwnerWithRegionLocal_ReturnCorrectTax()
        {
            // Arrange
            var vendor = new Vendor() { Region = "LOCAL" };
            var item = new Item() { Owner = vendor, Price = 10 };
            var tax = new TaxByRegion();
            var expected = 10 * .19m;

            // Act
            var actual = tax.CalculateTax(item);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateTax_WhenItemHasOwnerWithRegionUnknown_ReturnCorrectTax()
        {
            // Arrange
            var vendor = new Vendor() { };
            var item = new Item() { Owner = vendor, Price = 10 };
            var tax = new TaxByRegion();
            var expected = 10 * .35m;

            // Act
            var actual = tax.CalculateTax(item);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
