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
      Console.WriteLine("Please select a valid menu item number from 1 to 7.");
      try
      {
        int userSelection = int.Parse(Console.ReadLine());
        Console.WriteLine("Excellent choice. How many would you like?");
        int orderQuantity = int.Parse(Console.ReadLine());
        int orderTotal = CalculateTotalPrice(userSelection, orderQuantity);
    
        if (userSelection >= 1 && userSelection <= 7)
        {
          Console.WriteLine($"Your total is: ${orderTotal}");
          Console.WriteLine("Thank you for your order!");
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


    static int CalculateTotalPrice(int userSelection, int orderQuantity)
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
