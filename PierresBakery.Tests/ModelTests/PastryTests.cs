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
      int orderQuantity = 2;
      int expectedPrice = 4;
      Pastry.CalculateTotalPastryPrice(orderQuantity);
      Assert.AreEqual(expectedPrice, Pastry.TotalPastryPrice);
    }
  }
}