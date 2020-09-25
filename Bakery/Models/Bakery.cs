using System;

namespace Bakery

{
  public class Bread
  {
    public static int GetPrice(int quantity)
    {
      int btgoNumber = quantity/3;
      int fullPriceRemainder = quantity%3;
      // Console.WriteLine(btgoNumber.ToString());
      // Console.WriteLine(fullPriceRemainder.ToString());      
      return btgoNumber*10+fullPriceRemainder*5;
    }
  }

  public class Pastry
  {
    public static int GetPrice(int quantity)
    {      
      return 5;
    }
  }
}