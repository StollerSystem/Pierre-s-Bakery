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
      int three4Five = quantity/3;
      int one4Two = quantity%3;
      return three4Five*5+one4Two*2;
    }
  }
}