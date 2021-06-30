using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopAppLibrary;
using ShopAppLibrary.Factory;

namespace UnitTests
{
    [TestClass]
    public class ItemBasedTaxFactoryTests
    {
        [TestMethod]
        public void GetTaxObject_WhenItemHasOwner_ReturnTaxByRegionObject()
        {
            // Arrange
            var vendor = new Vendor() { Name = "TestVendor"};
            var item = new Item() { Owner = vendor};
            var itemBasedTaxFactory = new ItemBasedTaxFactory(item);

            // Act
            var tax = itemBasedTaxFactory.GetTaxObject();

            // Assert
            Assert.IsInstanceOfType(tax , typeof(TaxByRegion));
        }

        [TestMethod]
        public void GetTaxObject_WhenItemHasNoOwner_ReturnNoTaxObject()
        {
            // Arrange
            var item = new Item();
            var itemBasedTaxFactory = new ItemBasedTaxFactory(item);

            // Act
            var tax = itemBasedTaxFactory.GetTaxObject();

            // Assert
            Assert.IsInstanceOfType(tax, typeof(NoTax));
        }
    }
}
