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
      Console.WriteLine("\n--------------[Our Prices:]-------------");      
      Console.WriteLine("Bread: Single loaf $5 Buy 2 get 1 free!");
      Console.WriteLine("Pastry: Buy 1 for $2 or 3 for $5!");
      Console.WriteLine("----------------------------------------");
      Console.WriteLine("\nPress any key to continue...");
      Console.ReadLine();      
      PrintMenu();
      bool shopping = true;
      while (shopping)
      {                     
        string userInput = Console.ReadLine().ToLower();
        shopping = UserInput(userInput);        
      }
      CheckOut();      
    }

    public static void PrintMenu()
      {
        Console.WriteLine("\n------------MENU------------");        
        Console.WriteLine("'1' to add Sour Dough Bread");
        Console.WriteLine("'2' to add Wheat Bread");
        Console.WriteLine("'3' to add Rye Bread");
        Console.WriteLine("'4' to add Scone Pastry");
        Console.WriteLine("'5' to add Muffin Pastry");
        Console.WriteLine("'6' to add Croissant Pastry");
        Console.WriteLine("----------------------------");
        Console.WriteLine("Type 's' to view Shopping Cart");
        Console.WriteLine("Type 'c' to clear your cart");
        Console.WriteLine("Type 'm' to see the menu");
        Console.WriteLine("Type 'd' when you're done");
        Console.WriteLine("----------------------------");
        Console.WriteLine("\n(Type the number, then hit enter to add the item to your cart)");
        Console.WriteLine("(If wanting to add multiple items, follow the number with a space then a quantity)");
        Console.WriteLine("(Example: typing '1 6' will add 6 Sour Dough Loafs)");
      }

    public static void PrintCart()
    {
      Console.WriteLine("\n----------------------");
      Console.WriteLine("   [Shpping Cart:] ");
      Console.WriteLine("----------------------");
      List<Bread> breadCart = ShoppingCart.GetBread();
      List<Pastry> pastryCart = ShoppingCart.GetPastry();
      if (breadCart.Count == 0 && pastryCart.Count == 0)
      {
        Console.WriteLine(" *(Empty)");
      } else 
      {
        foreach (Bread bread in breadCart)
        {
          Console.WriteLine($" *({bread.Description})");
        }  
        int breadQuantity = ShoppingCart.GetBread().Count;
        int breadSubTotal = Bread.GetPrice(breadQuantity);
        Console.WriteLine($" [Bread subtotal: ${breadSubTotal.ToString()}]\n"); 
        foreach (Pastry pastry in pastryCart)
        {
          Console.WriteLine($" *({pastry.Description})");
        }
        int pastryQuantity = ShoppingCart.GetPastry().Count;
        int pastrySubTotal = Pastry.GetPrice(pastryQuantity);
        Console.WriteLine($" [Pastry subtotal: ${pastrySubTotal.ToString()}]");
      }
      string grandTotal = ShoppingCart.GetTotal().ToString();
      Console.WriteLine("----------------------"); 
      Console.WriteLine($"  [Grand Total: ${grandTotal}]");
      Console.WriteLine("----------------------"); 
      Console.WriteLine("\n(Type 'm' to see the menu, 'c' to clear the cart, and 'd' when done.)");      
    }

    public static bool UserInput(string userInput)
    {
      string[] inputSplit = userInput.Split(' ');
      switch (inputSplit[0])
        {
          case ("1"):
            Bread sourDough = new Bread("Sour Dough Loaf");            
            if (inputSplit.Length > 1)
            {
              AddMultipleBread(inputSplit[1],sourDough);              
            } else
            {
              ShoppingCart.AddBread(sourDough);            
              Console.WriteLine("\n*** Sour dough Loaf added! ***");
            }   
            return true;
          case ("2"):
            Bread wheat = new Bread("Wheat Loaf");            
            if (inputSplit.Length > 1)
            {
              AddMultipleBread(inputSplit[1],wheat);              
            } else
            {
              ShoppingCart.AddBread(wheat);
              Console.WriteLine("\n*** Wheat Loaf added! ***");
            }            
            return true;
          case ("3"):
            Bread rye = new Bread("Rye Loaf");            
            if (inputSplit.Length > 1)
            {
              AddMultipleBread(inputSplit[1],rye);              
            } else
            {
              ShoppingCart.AddBread(rye);
              Console.WriteLine("\n*** Rye Loaf added! ***");
            }            
            return true;            
          case ("4"):
            Pastry scone = new Pastry("Scone Pastry");
            if (inputSplit.Length > 1)
            {
              AddMultiplePastry(inputSplit[1],scone);              
            } else
            {
              ShoppingCart.AddPastry(scone);
              Console.WriteLine("\n*** Scone Pastry added! ***");
            }            
            return true;
          case ("5"):
            Pastry muffin = new Pastry("Muffin Pastry");
             if (inputSplit.Length > 1)
            {
              AddMultiplePastry(inputSplit[1],muffin);              
            } else
            {
              ShoppingCart.AddPastry(muffin);
              Console.WriteLine("\n*** Muffin Pastry added! ***");
            }            
            return true;
          case ("6"):
            Pastry croissant = new Pastry("Croissant Pastry");
             if (inputSplit.Length > 1)
            {
              AddMultiplePastry(inputSplit[1],croissant);              
            } else
            {
              ShoppingCart.AddPastry(croissant);
              Console.WriteLine("\n*** Croissant Pastry added! ***");
            }            
            return true;
          case ("c"):            
            Console.WriteLine("\n*** Cart cleared! ***");
            ShoppingCart.ClearAll();
            return true;
           case ("m"):            
            PrintMenu();            
            return true;
          case ("d"):            
            Console.WriteLine("\n*** Proceeding to Checkout ***");
            return false;
          case ("s"):            
            PrintCart();
            return true;
          default:
            Console.WriteLine("\n*** Sorry please try again...type the NUMBER of the item you want. Type 'm' to see the menu. ***");
            return true;
        } 
    }

    public static void CheckOut()
    {
      int breadQuantity = ShoppingCart.GetBread().Count;
      int pastryQuantity = ShoppingCart.GetPastry().Count;
      int grandTotal = ShoppingCart.GetTotal();
      string stringTotal = ShoppingCart.GetTotal().ToString();
      string saveTotal = (breadQuantity*5+pastryQuantity*2-grandTotal).ToString();
      Console.WriteLine("\n\n------------[Checkout]-------------\n");
      Console.WriteLine($"   [Bread Qty: {breadQuantity.ToString()} / Pastry Qty: {pastryQuantity.ToString()}]\n");
      Console.WriteLine($"        [Grand Total: ${grandTotal}]\n");
      Console.WriteLine($"        [You Saved: ${saveTotal}!!!]\n");      
      Console.WriteLine("         <<<Thank you!>>>\n");
      Console.WriteLine("            -Pierre");
      Console.WriteLine("----------------------------------");
      Console.WriteLine("\n\n\n   [{(< Built by Ben Stoller >)}]");
    }

    public static void AddMultipleBread(string quantity, Bread bread)
    {
      int qty = 1;
      bool canConvert = int.TryParse(quantity, out qty);
      if (canConvert)
      {                
        for (int i = 0; i < qty; i++)
        {
          ShoppingCart.AddBread(bread);                  
        }
        Console.WriteLine($"\n*** {qty.ToString()} {bread.Description}s added! ***");
      } else
      {
        Console.WriteLine("\n*** Sorry please try again...type the NUMBER of the item you want, followed by quantity. Type 'm' to see the menu. ***");
      }
    }

    public static void AddMultiplePastry(string quantity, Pastry pastry)
    {
      int qty = 1;
      bool canConvert = int.TryParse(quantity, out qty);
      if (canConvert)
      {                
        for (int i = 0; i < qty; i++)
        {
          ShoppingCart.AddPastry(pastry);                  
        }
        Console.WriteLine($"\n*** {qty.ToString()} {pastry.Description} added! ***");
      } else
      {
        Console.WriteLine("\n*** Sorry please try again...type the NUMBER of the item you want, followed by QUANTITY. Type 'm' to see the menu. ***");
      }
    }
  }
}