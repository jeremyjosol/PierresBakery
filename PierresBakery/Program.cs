using System;
using PierresBakery.Models;

namespace PierresBakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");      
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");  
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~Welcome to Pierre's Bakery!~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*"); 
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*"); 
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~MENU:~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*"); 
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");  
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*BREAD*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*"); 
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*WHITE OR WHEAT~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*"); 
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*$5~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*"); 
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~BAGUETTE*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*"); 
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*$6~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*BRIOCHE*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");  
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*$8~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*PASTRY~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~CROISSANT~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");  
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*$2~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~KOUIGN AMANN*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");  
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*$5~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~PAIN AU CHOCOLAT*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");  
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*$4~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");  
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");   
      Console.WriteLine("");
      ProcessOrder();
    }
    static void ProcessOrder()
    {
      ShowMenu();
      try
      {
        Console.WriteLine("For bread options, please select a valid menu number from 1-4.");
        int userBreadSelection = int.Parse(Console.ReadLine());
        Console.WriteLine("For pastry options, please select a valid menu number from 5-7. ");
        int userPastrySelection = int.Parse(Console.ReadLine());
        
        if (userBreadSelection >= 1 && userBreadSelection <= 4 && userPastrySelection >= 5 && userPastrySelection <= 7)
        {
          Console.WriteLine("Excellent selections."); 
          Console.WriteLine("How many loaves of bread would you like?");
          int loafOrderQuantity = int.Parse(Console.ReadLine());
          Console.WriteLine("And for your pastry selection?");
          int pastryOrderQuantity = int.Parse(Console.ReadLine());
          int loafOrderTotal = CalculateTotalBreadPrice(userBreadSelection, loafOrderQuantity);
          Console.WriteLine(" ");
          Console.WriteLine($"Your total price for your loaves of bread is: ${loafOrderTotal}");
          int pastryOrderTotal = CalculateTotalPastryPrice(userPastrySelection, pastryOrderQuantity);
          Console.WriteLine($"Your total price for your pastries is: ${pastryOrderTotal}");
          Console.WriteLine(" ");
          int orderTotal = loafOrderTotal + pastryOrderTotal;
          Console.WriteLine($"Your total price today is: ${orderTotal}");
          Console.WriteLine("Ready to checkout?");
          Console.WriteLine("Please enter: yes / no");
          string userCheckout = Console.ReadLine();     
          if (userCheckout.ToLower() == "yes")
          {
            Console.WriteLine($"To confirm, please enter the correct total of ${orderTotal} to process your order.");
            string confirmOrder = Console.ReadLine();
            if (confirmOrder == orderTotal.ToString())
            {
              Console.WriteLine("Payment successful. Thank you for your order, goodbye!");
            }
            else
            {
              CatchError();
              Console.WriteLine("Payment amount does not match.");
            }
          }
          else if (userCheckout.ToLower() == "no")
          {
            ProcessOrder();
          }
        }
        else
        {
          HandleUserInputError();
          CatchError();
        }
      }
      catch
      {
        CatchError();
      }
    }
    static void ShowMenu()
    {
      Console.WriteLine(" ");
      Console.WriteLine("                             What would you like to order today?");
      Console.WriteLine(" ");
      Console.WriteLine("                           1. White | Buy 2 get 1 free *SPECIAL*");
      Console.WriteLine("                           2. Wheat | Buy 2 get 1 free *SPECIAL*");
      Console.WriteLine("                           3. Baguette | Buy 1 get 1 free *SPECIAL*");
      Console.WriteLine("                           4. Brioche | Buy 1 get 1 50% off *SPECIAL*");
      Console.WriteLine("                           5. Croissant | Buy 3 get 1 free *SPECIAL*");
      Console.WriteLine("                           6. Kouign Amann");
      Console.WriteLine("                           7. Pain Au Chocolat | Buy 3 get 1 half off");
      Console.WriteLine(" ");
      Console.WriteLine(" ");
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
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine(" ");
      Console.WriteLine("Your order could not be processed.");
      Console.WriteLine(" ");
      Console.ResetColor();
    }
    static void CatchError()
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Let's try to process your order again.");
      Console.WriteLine(" ");
      Console.ResetColor();
      ProcessOrder();
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
