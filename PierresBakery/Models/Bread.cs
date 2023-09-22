using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    static public int LoafCost { get; }

    static Bread()
    {
      LoafCost = 5;

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