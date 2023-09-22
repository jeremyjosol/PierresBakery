using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;


namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void CalculateTotalPastryPrice_WillUpdateTotalPastryPrice_Int()
    {
      Croissant croissantPastry = new Croissant();
      int orderQuantity = 2;
      int expectedPrice = 4;
      croissantPastry.CalculateTotalPastryPrice(orderQuantity);
      Assert.AreEqual(expectedPrice, croissantPastry.TotalPastryPrice);
    }
    [TestMethod]
    public void CalculateTotalPastryPrice_WillUpdateTotalPastryPriceDiscount_Int()
    {
      Croissant croissantPastry = new Croissant();
      int orderQuantity = 8;
      int expectedPrice = 12;
      croissantPastry.CalculateTotalPastryPrice(orderQuantity);
      Assert.AreEqual(expectedPrice, croissantPastry.TotalPastryPrice);
    }
  }
}