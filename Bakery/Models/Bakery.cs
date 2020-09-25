using System;

namespace Bakery

{
  public class Bread
  {
    public static int GetPrice(int quantity)
    {
      int number = quantity/3;
      int remainder = quantity%3;
      Console.WriteLine(number.ToString());
      Console.WriteLine(remainder.ToString());
      return 5;
    }
  }

  public class Pastry
  {
    // properties, constructors, methods, etc. go here
  }
}