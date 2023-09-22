namespace PierresBakery.Models
{
  public interface IPastry
  {
    int CalculateTotalPastryPrice(int orderQuantity);
  }
  // Buy 3 get 1 free
  public class Croissant : IPastry
  {
    public int PastryPrice { get; }
    public int PastryCount { get; set; }
    public int TotalPastryPrice { get; set; }

    public Croissant()
    {
      PastryPrice = 2;
    }
    public int CalculateTotalPastryPrice(int orderQuantity)
    {
      PastryCount = orderQuantity;
      TotalPastryPrice = 0;
      
      for (int i = 1; i <= orderQuantity; i++)
      {
        TotalPastryPrice += PastryPrice;
        if (i % 4 == 0)
        {
          TotalPastryPrice -= PastryPrice;
        }
      }
        return TotalPastryPrice;
      }
  }
    // Full price
  public class KouignAmann : IPastry
  {
    public int PastryPrice { get; }
    public int PastryCount { get; set; }
    public int TotalPastryPrice { get; set; }
    public KouignAmann()
    {
      PastryPrice = 5;
    }
    public int CalculateTotalPastryPrice(int orderQuantity)
    {
      TotalPastryPrice = PastryPrice * orderQuantity;
      return TotalPastryPrice;
    }
  }
   // Buy 3 get 1 half off
  public class PainAuChocolat : IPastry
  {
    public int PastryPrice { get; }
    public int PastryCount { get; set; }
    public int TotalPastryPrice { get; set; }
    public PainAuChocolat()
    {
      PastryPrice = 4;
    }
    public int CalculateTotalPastryPrice(int orderQuantity)
    {
      PastryCount = orderQuantity;
      TotalPastryPrice = 0;

      for (int i = 1; i <= orderQuantity; i++)
      {
        TotalPastryPrice += PastryPrice;
        if (i % 4 == 0)
        {
          TotalPastryPrice -= PastryPrice / 2;
        }
      }
      return TotalPastryPrice;
    }
  }
}