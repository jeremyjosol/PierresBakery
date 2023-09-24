using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void CalculateTotalPastryPrice_WillUpdateTotalCroissantPrice_Int()
    {
      Croissant croissantPastry = new Croissant();
      int orderQuantity = 2;
      int expectedPrice = 4;
      croissantPastry.CalculateTotalPastryPrice(orderQuantity);
      Assert.AreEqual(expectedPrice, croissantPastry.TotalPastryPrice);
    }
    [TestMethod]
    public void CalculateTotalPastryPrice_WillUpdateTotalCroissantPriceDiscount_Int()
    {
      Croissant croissantPastry = new Croissant();
      int orderQuantity = 8;
      int expectedPrice = 12;
      croissantPastry.CalculateTotalPastryPrice(orderQuantity);
      Assert.AreEqual(expectedPrice, croissantPastry.TotalPastryPrice);
    }
    [TestMethod]
    public void CalculateTotalPastryPrice_WillUpdateTotalKouignAmannPrice_Int()
    {
      KouignAmann kouignAmannPastry = new KouignAmann();
      int orderQuantity = 5;
      int expectedPrice = 25;
      kouignAmannPastry.CalculateTotalPastryPrice(orderQuantity);
      Assert.AreEqual(expectedPrice, kouignAmannPastry.TotalPastryPrice);
    }
    [TestMethod]
    public void CalculateTotalPastryPrice_WillUpdateTotalKouignAmannResetPrice_Int()
    {
      KouignAmann kouignAmannPastry = new KouignAmann();
      int orderQuantity = 6;
      int expectedPrice = 30;
      kouignAmannPastry.CalculateTotalPastryPrice(orderQuantity);
      Assert.AreEqual(expectedPrice, kouignAmannPastry.TotalPastryPrice);
    }
    [TestMethod]
    public void CalculateTotalPastryPrice_WillUpdateTotalPainAuChocolatPrice_Int()
    {
      PainAuChocolat painAuChocolat = new PainAuChocolat();
      int orderQuantity = 8;
      int expectedPrice = 28;
      painAuChocolat.CalculateTotalPastryPrice(orderQuantity);
      Assert.AreEqual(expectedPrice, painAuChocolat.TotalPastryPrice);
    }
    [TestMethod]
    public void CalculateTotalPastryPrice_WillUpdateTotalPainAuChocolatResetPrice_Int()
    {
      PainAuChocolat painAuChocolat = new PainAuChocolat();
      int orderQuantity = 1;
      int expectedPrice = 4;
      painAuChocolat.CalculateTotalPastryPrice(orderQuantity);
      Assert.AreEqual(expectedPrice, painAuChocolat.TotalPastryPrice);
    }
  }
}