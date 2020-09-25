using System;

namespace Bakery
{   
  public class Program
  {
    public static void Main() 
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Our prices:");
      Console.WriteLine("Bread: Buy 2 get 1 free! Single loaf $5");
      Console.WriteLine("Pastry: Buy 1 for $2 or 3 for $5!");
      Console.WriteLine("Press any key to continue");
      Console.ReadLine();
      // LOOP HERE AND SHOW CART 
      bool shopping = true;
      while (shopping)
      {
        // print cart here
        Console.WriteLine("'sd' to add Sour Dough Bread");
        string userInput = Console.ReadLine().ToLower();

        switch (userInput)
        {
          case ("sd"):
          // ADD SOUR DOUGH
            Console.WriteLine("Sour dough added!");
            break;
          case ("d"):
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