using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopAppLibrary;
using ShopAppLibrary.Factory;
using ShopAppLibrary.Proxy;

namespace UnitTests
{
    [TestClass]
    public class OrderProxyTests
    {
        [TestMethod]
        public void CalculatePriceWithTaxes_WhenItemHasOwnerWithRegionEU_ReturnFullPriceCorrectly()
        {
            // Arrange
            var vendor = new Vendor() { Region = "EU", Name = "VendorTest" };
            var item = new Item() { Owner = vendor, Price = 10 };
            var orderProxy = new OrderProxy();
            var expected = 10 + (10 * .24m);

            // Act
            var actual = orderProxy.CalculatePriceWithTaxes(item);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatePriceWithTaxes_WhenItemHasOwnerWithRegionLocal_ReturnFullPriceCorrectly()
        {
            // Arrange
            var vendor = new Vendor() { Region = "LOCAL", Name = "VendorTest" };
            var item = new Item() { Owner = vendor, Price = 10 };
            var orderProxy = new OrderProxy();
            var expected = 10 + 10 * .19m;

            // Act
            var actual = orderProxy.CalculatePriceWithTaxes(item);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatePriceWithTaxes_WhenItemHasOwnerWithRegionUnknown_ReturnFullPriceCorrectly()
        {
            // Arrange
            var vendor = new Vendor() { Name = "VendorTest" };
            var item = new Item() { Owner = vendor, Price = 10 };
            var orderProxy = new OrderProxy();
            var expected = 10 + 10 * .35m;

            // Act
            var actual = orderProxy.CalculatePriceWithTaxes(item);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatePriceWithTaxes_WhenItemHasOwnerUnknown_ReturnFullPriceCorrectly()
        {
            // Arrange
            var vendor = new Vendor() { };
            var item = new Item() { Owner = vendor, Price = 10 };
            var orderProxy = new OrderProxy();
            var expected = 10;

            // Act
            var actual = orderProxy.CalculatePriceWithTaxes(item);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
