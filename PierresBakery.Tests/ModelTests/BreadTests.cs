using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;


namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void CalculateTotalBreadPrice_WillUpdateTotalBreadPrice_Int()
    {
      int orderQuantity = 1;
      int expectedPrice = 5;
      Bread.CalculateTotalBreadPrice(orderQuantity);
      Assert.AreEqual(expectedPrice, Bread.TotalBreadPrice);
    }
     [TestMethod]
      public void CalculateTotalBreadPrice_WillUpdateTotalBreadPriceDiscount_Int()
      {
      int orderQuantity = 3;
      int expectedPrice = 10;
      Bread.CalculateTotalBreadPrice(orderQuantity);
      Assert.AreEqual(expectedPrice, Bread.TotalBreadPrice);
    }
  }
}