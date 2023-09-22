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
      WhiteOrWheat loafOfWhiteOrWheat = new WhiteOrWheat();
      int orderQuantity = 1;
      int expectedPrice = 5;
      loafOfWhiteOrWheat.CalculateTotalBreadPrice(orderQuantity);
      Assert.AreEqual(expectedPrice, WhiteOrWheat.TotalBreadPrice);
    }
     [TestMethod]
      public void CalculateTotalBreadPrice_WillUpdateTotalBreadPriceDiscount_Int()
      {
      WhiteOrWheat loafOfWhiteOrWheat = new WhiteOrWheat();
      int orderQuantity = 6;
      int expectedPrice = 20;
      loafOfWhiteOrWheat.CalculateTotalBreadPrice(orderQuantity);
      Assert.AreEqual(expectedPrice, WhiteOrWheat.TotalBreadPrice);
    }
  }
}