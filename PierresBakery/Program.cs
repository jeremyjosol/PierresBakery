using System;
using PierresBakery.Models;

namespace PierresBakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");      
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");  
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~Welcome to Pierre's Bakery!~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*"); 
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*"); 
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~MENU:~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*"); 
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");  
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*BREAD*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*"); 
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*WHITE OR WHEAT~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*"); 
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*$5~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*"); 
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~BAGUETTE*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*"); 
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*$6~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*BRIOCHE*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");  
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*$8~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*PASTRY~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~CROISSANT~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");  
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*$2~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~KOUIGN AMANN*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");  
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*$5~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~PAIN AU CHOCOLAT*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");  
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*$4~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");  
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");   
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("What would you like to order today?");
      Console.WriteLine("1. White | Buy 2 get 1 free *SPECIAL*");
      Console.WriteLine("2. Wheat | Buy 2 get 1 free *SPECIAL*");
      Console.WriteLine("3. Baguette | Buy 1 get 1 free *SPECIAL*");
      Console.WriteLine("4. Brioche | Buy 1 get 1 50% off *SPECIAL*");
      Console.WriteLine("5. Croissant | Buy 3 get 1 free *SPECIAL*");
      Console.WriteLine("6. Kouign Amann");
      Console.WriteLine("7. Pain Au Chocolat | Buy 3 get 1 half off");
      Console.WriteLine("For bread options, please select a valid menu number from 1-4.");
      Console.WriteLine("For pastry options, please select a valid menu number from 5-7. ");
      try
      {
        int userBreadSelection = int.Parse(Console.ReadLine());
        int userPastrySelection = int.Parse(Console.ReadLine());
        if (userBreadSelection >= 1 && userBreadSelection <= 4)
        {
          Console.WriteLine("Excellent choice. How many would you like?");
          int orderQuantity = int.Parse(Console.ReadLine());
          int orderTotal = CalculateTotalBreadPrice(userBreadSelection, orderQuantity);
          Console.WriteLine($"Your total for bread is: ${orderTotal}");
        }
        else if (userPastrySelection >= 5 && userPastrySelection <= 7)
        {
          Console.WriteLine("Excellent choice. How many would you like?");
          int orderQuantity = int.Parse(Console.ReadLine());
          int orderTotal = CalculateTotalPastryPrice(userPastrySelection, orderQuantity);
          Console.WriteLine($"Your total for pastries is: ${orderTotal}");
        }
        else
        {
          HandleUserInputError();
        }
      }
      catch
      {
        CatchError();
      }
    }
    static int CalculateTotalBreadPrice(int userSelection, int orderQuantity)
    {
      switch (userSelection)
      {
        case 1:
        return CalculateBreadTotal(new WhiteOrWheat(), orderQuantity);
        case 2:
        return CalculateBreadTotal(new WhiteOrWheat(), orderQuantity);
        case 3:
        return CalculateBreadTotal(new Baguette(), orderQuantity);
        case 4:
        return CalculateBreadTotal(new Brioche(), orderQuantity);
        default: 
        return 0;
        }
    }
    static int CalculateTotalPastryPrice(int userSelection, int orderQuantity)
    {
      switch (userSelection)
      {
        case 5:
        return CalculatePastryTotal(new Croissant(), orderQuantity);
        case 6: 
        return CalculatePastryTotal(new KouignAmann(), orderQuantity);
        case 7:
        return CalculatePastryTotal(new PainAuChocolat(), orderQuantity);
        default: 
        return 0;
      }
    }
    static void HandleUserInputError()
    {
      Console.WriteLine("Your order could not be processed.");
      Console.WriteLine("Please enter a valid entry.");
    }
    static void CatchError()
    {
      Console.WriteLine("Please try again.");
    }
    static int CalculateBreadTotal(IBread bread, int orderQuantity)
    {
      return bread.CalculateTotalBreadPrice(orderQuantity);
    }

    static int CalculatePastryTotal(IPastry pastry, int orderQuantity)
    {
      return pastry.CalculateTotalPastryPrice(orderQuantity);
    }
  }
}
