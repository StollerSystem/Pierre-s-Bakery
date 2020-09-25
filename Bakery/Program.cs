using System;
using System.Collections.Generic;

namespace Bakery
{   
  public class Program
  {
    public static void Main() 
    { 
      Console.WriteLine("\n\n----------------------------------------");
      Console.WriteLine("|  *** Welcome to Pierre's Bakery ***  |");
      Console.WriteLine("----------------------------------------");
      Console.WriteLine("\nOur Prices:");
      Console.WriteLine("Bread: Single loaf $5 Buy 2 get 1 free!");
      Console.WriteLine("Pastry: Buy 1 for $2 or 3 for $5!");
      Console.WriteLine("\nPress any key to continue...");
      Console.ReadLine();
      // LOOP HERE AND SHOW CART 
      PrintMenu();
      bool shopping = true;
      while (shopping)
      {
        // print cart here
       PrintCart();    
        // ORDER FORM        
        string userInput = Console.ReadLine().ToLower();

        switch (userInput)
        {
          case ("1"):
            Bread sourDough = new Bread("Sour Dough");
            ShoppingCart.AddBread(sourDough);
            Console.WriteLine("\n*** Sour dough added! ***");
            break;
          case ("2"):
            Bread wheat = new Bread("Wheat");
            ShoppingCart.AddBread(wheat);
            Console.WriteLine("\n*** Wheat added! ***");
            break;
          case ("3"):
            Bread rye = new Bread("Rye");
            ShoppingCart.AddBread(rye);
            Console.WriteLine("\n*** Rye added! ***");
            break;
          case ("4"):
            Pastry scone = new Pastry("Scone");
            ShoppingCart.AddPastry(scone);
            Console.WriteLine("\n*** Scone added! ***");
            break;
          case ("5"):
            Pastry muffin = new Pastry("Muffin");
            ShoppingCart.AddPastry(muffin);
            Console.WriteLine("\n*** Muffin added! ***");
            break;
          case ("6"):
            Pastry croissant = new Pastry("Croissant");
            ShoppingCart.AddPastry(croissant);
            Console.WriteLine("\n*** Croissant added! ***");
            break;
          case ("c"):
            //CLEAR
            Console.WriteLine("\n*** Cart cleared! ***");
            ShoppingCart.ClearAll();
            break;
           case ("m"):
            //Menu
            PrintMenu();            
            break;
          case ("d"):
            //DONE
            Console.WriteLine("done!");
            shopping = false;
            break;
          default:
            Console.WriteLine("Sorry please try again...type the NUMBER of the item you want. Type 'm' to see the menu.");
            break;
        } 
      }      
    }
    public static void PrintMenu()
      {
        Console.WriteLine("\n-----------MENU-----------");        
        Console.WriteLine("'1' to add Sour Dough Bread");
        Console.WriteLine("'2' to add Wheat Bread");
        Console.WriteLine("'3' to add Rye Bread");
        Console.WriteLine("'4' to add Scone Pastry");
        Console.WriteLine("'5' to add Muffin Pastry");
        Console.WriteLine("'6' to add Croissant Pastry");
        Console.WriteLine("Type 'c' to clear your cart!");
        Console.WriteLine("Type 'm' to see the menu!");
        Console.WriteLine("Type 'd' when you're done!");
        Console.WriteLine("--------------------------");
        Console.WriteLine("\n(Type the number, then hit enter to add the item to your cart)");
      }

    public static void PrintCart()
    {
      Console.WriteLine("\n----------------------");
      Console.WriteLine("Shpping Cart: ");
      List<Bread> breadCart = ShoppingCart.GetBread();
      List<Pastry> pastryCart = ShoppingCart.GetPastry();
      if (breadCart.Count == 0 && pastryCart.Count == 0)
      {
        Console.WriteLine(" -(Empty)");
      } else 
      {
          foreach (Bread bread in breadCart)
        {
          Console.WriteLine($" -({bread.Description})");
        }  
        int breadQuantity = ShoppingCart.GetBread().Count;
        int breadSubTotal = Bread.GetPrice(breadQuantity);
        Console.WriteLine($"  [Bread subtotal: ${breadSubTotal.ToString()}]"); 

        foreach (Pastry pastry in pastryCart)
        {
          Console.WriteLine($" -({pastry.Description})");
        }
        int pastryQuantity = ShoppingCart.GetPastry().Count;
        int pastrySubTotal = Pastry.GetPrice(pastryQuantity);
        Console.WriteLine($"  [Pastry subtotal: ${pastrySubTotal.ToString()}]");
      }
      string grandTotal = ShoppingCart.GetTotal().ToString();
      Console.WriteLine("----------------------"); 
      Console.WriteLine($"  [Grand Total: ${grandTotal}");
      Console.WriteLine("----------------------"); 
      Console.WriteLine("(Type 'm' to see the menu, 'c' to clear the cart, and 'd' when done.)");
    }
  }
}