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

//Pierre offers the following deal for Bread: Buy 2, get 1 free. A single loaf costs $5, then:

//two loaves costs $10
//three loaves cost $10
//four loaves costs $15
//five loaves cost $20
//six loaves costs $20
//seven loaves cost $25
//Can you see a pattern? Every 3rd loaf of bread is free.