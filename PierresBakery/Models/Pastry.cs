namespace PierresBakery.Models
{
    public interface IPastry
    {
      int CalculateTotalPastryPrice(int orderQuantity);
    }
    public class Pastry
  {
    static public int PastryPrice { get; }
    static public int PastryCount { get; set; }
    static public int TotalPastryPrice { get; set; }

    static Pastry()
    {
      PastryPrice = 2;
    }
    static public void CalculateTotalPastryPrice(int orderQuantity)
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
    }
  }
}