namespace PierresBakery.Models
{
    public interface IPastry
    {
      int CalculateTotalPastryPrice(int orderQuantity);
    }
    public class Croissant : IPastry
  {
    int PastryPrice { get; }
    int PastryCount { get; set; }
    int TotalPastryPrice { get; set; }

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
}