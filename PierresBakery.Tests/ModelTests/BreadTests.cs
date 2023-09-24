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
      Assert.AreEqual(expectedPrice, loafOfWhiteOrWheat.TotalBreadPrice);
    }
     [TestMethod]
      public void CalculateTotalBreadPrice_WillUpdateTotalBreadPriceDiscount_Int()
      {
      WhiteOrWheat loafOfWhiteOrWheat = new WhiteOrWheat();
      int orderQuantity = 6;
      int expectedPrice = 20;
      loafOfWhiteOrWheat.CalculateTotalBreadPrice(orderQuantity);
      Assert.AreEqual(expectedPrice, loafOfWhiteOrWheat.TotalBreadPrice);
    }
    [TestMethod]
    public void CalculateTotalBreadPrice_WillUpdateTotalBaguettePrice_Int()
    {
      Baguette loafOfBaguette = new Baguette();
      int orderQuantity = 4;
      int expectedPrice = 12;
      loafOfBaguette.CalculateTotalBreadPrice(orderQuantity);
      Assert.AreEqual(expectedPrice, loafOfBaguette.TotalBreadPrice);
    }
    [TestMethod]
    public void CalculateTotalBreadPrice_WillUpdateTotalBaguetteResetPrice_Int()
    {
      Baguette loafOfBaguette = new Baguette();
      int orderQuantity = 5;
      int expectedPrice = 18;
      loafOfBaguette.CalculateTotalBreadPrice(orderQuantity);
      Assert.AreEqual(expectedPrice, loafOfBaguette.TotalBreadPrice);
    }
    [TestMethod]
    public void CalculateTotalBreadPriceWillUpdateTotalBriochePrice_Int()
    {
      Brioche loafOfBrioche = new Brioche();
      int orderQuantity = 3;
      int expectedPrice = 20;
      loafOfBrioche.CalculateTotalBreadPrice(orderQuantity);
      Assert.AreEqual(expectedPrice, loafOfBrioche.TotalBreadPrice);
    }
    [TestMethod]
    public void CalculateTotalBreadPriceWillUpdateTotalBriocheResetPrice_Int()
    {
      Brioche loafOfBrioche = new Brioche();
      int orderQuantity = 4;
      int expectedPrice = 24;
      loafOfBrioche.CalculateTotalBreadPrice(orderQuantity);
      Assert.AreEqual(expectedPrice, loafOfBrioche.TotalBreadPrice);
    }
  }
}