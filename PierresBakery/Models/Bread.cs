using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    static public int LoafPrice { get; }
    static public int LoafCount { get; set; }
    static public int TotalBreadPrice { get; set; }

    static Bread()
    {
      LoafPrice = 5;
    }
    static public void CalculateTotalBreadPrice(int orderQuantity)
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
    }
  }
}

// Possibly add interface to DRY code. IBread?