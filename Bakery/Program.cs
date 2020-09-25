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

        

        Console.WriteLine("\n'sd' to add Sour Dough Bread");
        string userInput = Console.ReadLine().ToLower();

        switch (userInput)
        {
          case ("sd"):
            // ADD SOUR DOUGH
            Bread sourDough = new Bread("Sour Dough");
            ShoppingCart.AddBread(sourDough);
            Console.WriteLine("Sour dough added!");
            break;

          case ("mf"):
            // ADD SOUR DOUGH
            Pastry muffin = new Pastry("Muffin");
            ShoppingCart.AddPastry(muffin);
            Console.WriteLine("Muffin added!");
            break;

          case ("d"):
            //DONE
            Console.WriteLine("done!");
            shopping = false;
            break;
          default:
            Console.WriteLine("what?");
            break;
        } 
      }
    }
  }
}