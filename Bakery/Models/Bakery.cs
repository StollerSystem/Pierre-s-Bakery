using System;

namespace Bakery

{
  public class Bread
  {
    public int GetPrice(int quantity)
    {
      int number = Math.Floor(quantity/3);
      int remainder = quantity%3;
      Console.WriteLine(number,remainder);
    }
  }

  public class Pastry
  {
    // properties, constructors, methods, etc. go here
  }
}