using System;

namespace PierresBakery.Models
{
  public interface IBread
  {
    int CalculateTotalBreadPrice(int orderQuantity);
  }
  public class WhiteOrWheat : IBread
  {
    static public int LoafPrice { get; }
    static public int LoafCount { get; set; }
    static public int TotalBreadPrice { get; set; }

    static WhiteOrWheat()
    {
      LoafPrice = 5;
    }
    public int CalculateTotalBreadPrice(int orderQuantity)
    {

      LoafCount = orderQuantity;
      TotalBreadPrice = 0;

      for (int i = 1; i <= orderQuantity; i++)
      {
        TotalBreadPrice += LoafPrice;
        if (i % 3 == 0)
        {
          TotalBreadPrice -= LoafPrice;
        }
      }
      return TotalBreadPrice;
    }
  }
}

// Possibly add interface to DRY code. IBread?