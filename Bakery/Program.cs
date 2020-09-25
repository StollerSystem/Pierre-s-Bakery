using System;
using System.Collections.Generic;

namespace Bakery
{   
  public class Program
  {
    public static void Main() 
    {
      Console.WriteLine("\n*** Welcome to Pierre's Bakery! ***");
      Console.WriteLine("\nOur prices:");
      Console.WriteLine("Bread: Buy 2 get 1 free! Single loaf $5");
      Console.WriteLine("Pastry: Buy 1 for $2 or 3 for $5!");
      Console.WriteLine("\nPress any key to continue...");
      Console.ReadLine();
      // LOOP HERE AND SHOW CART 
      Console.WriteLine("Type the number, then hit enter to add the item to your cart");
      Console.WriteLine("'1' to add Sour Dough Bread");
      Console.WriteLine("'2' to add Wheat Bread");
      Console.WriteLine("'3' to add Rye Bread");
      Console.WriteLine("'4' to add Scone Pastry");
      Console.WriteLine("'5' to add Muffin Pastry");
      Console.WriteLine("'6' to add Croissant Pastry");
      Console.WriteLine("Type 'c' to clear your cart!");
      Console.WriteLine("Type 'd' when you're done!");
      bool shopping = true;
      while (shopping)
      {
        // print cart here
        Console.WriteLine("\nShpping cart: ");
        List<Bread> breadCart = ShoppingCart.GetBread();
        List<Pastry> pastryCart = ShoppingCart.GetPastry();
        if (breadCart.Count == 0 && pastryCart.Count == 0)
        {
          Console.WriteLine("-Empty!");
        } else 
        {
            foreach (Bread bread in breadCart)
          {
            Console.WriteLine("-"+bread.Description);
          }          
          foreach (Pastry pastry in pastryCart)
          {
            Console.WriteLine("-"+pastry.Description);
          }
        }        
        // ORDER FORM
        
        string userInput = Console.ReadLine().ToLower();

        switch (userInput)
        {
          case ("1"):
            Bread sourDough = new Bread("Sour Dough");
            ShoppingCart.AddBread(sourDough);
            Console.WriteLine("Sour dough added!");
            break;
          case ("2"):
            Bread wheat = new Bread("Wheat");
            ShoppingCart.AddBread(wheat);
            Console.WriteLine("Wheat added!");
            break;
          case ("3"):
            Bread rye = new Bread("Rye");
            ShoppingCart.AddBread(rye);
            Console.WriteLine("Rye added!");
            break;
          case ("4"):
            Pastry scone = new Pastry("Scone");
            ShoppingCart.AddPastry(scone);
            Console.WriteLine("Scone added!");
            break;
          case ("5"):
            Pastry muffin = new Pastry("Muffin");
            ShoppingCart.AddPastry(muffin);
            Console.WriteLine("Muffin added!");
            break;
          case ("6"):
            Pastry croissant = new Pastry("Croissant");
            ShoppingCart.AddPastry(croissant);
            Console.WriteLine("Croissant added!");
            break;
          case ("c"):
            //CLEAR
            Console.WriteLine("Cart cleared!");
            ShoppingCart.ClearAll();
            break;
          case ("d"):
            //DONE
            Console.WriteLine("done!");
            shopping = false;
            break;
          default:
            Console.WriteLine("Sorry please try again...type the NUMBER of the item you want.");
            break;
        } 
      }
    }
  }
}