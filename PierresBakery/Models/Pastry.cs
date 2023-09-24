namespace PierresBakery.Models
{
  public interface IPastry
  {
    int CalculateTotalPastryPrice(int orderQuantity);
  }
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