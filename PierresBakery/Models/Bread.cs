namespace PierresBakery.Models
{
  public interface IBread
  {
    int CalculateTotalBreadPrice(int orderQuantity);
  }
  public class WhiteOrWheat : IBread
  {
    public int LoafPrice { get; }
    public int LoafCount { get; set; }
    public int TotalBreadPrice { get; set; }
    public WhiteOrWheat()
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
  public class Baguette : IBread
  {
    public int LoafPrice { get; }
    public int LoafCount { get; set; }
    public int TotalBreadPrice { get; set; }
    public Baguette()
    {
      LoafPrice = 6;
    }
    public int CalculateTotalBreadPrice(int orderQuantity)
    {
      TotalBreadPrice = 0;
      LoafCount = (orderQuantity / 2) + (orderQuantity % 2);
      TotalBreadPrice = LoafCount * LoafPrice;
      return TotalBreadPrice;
    }
  }
  public class Brioche : IBread
  {
    public int LoafPrice { get; }
    public int LoafCount { get; set; }
    public int TotalBreadPrice { get; set; }
    public Brioche()
    {
      LoafPrice = 8;
    }
    public int CalculateTotalBreadPrice(int orderQuantity)
    {
      TotalBreadPrice = 0;
      int halfOff = orderQuantity / 2;
      TotalBreadPrice = halfOff * (LoafPrice + (LoafPrice / 2));
      if (orderQuantity % 2 == 1)
      {
        TotalBreadPrice += LoafPrice;
      }
      return TotalBreadPrice;
      
    }
  }
}