using System;
using System.Collections.Generic;


namespace Bakery

{
  public class ShoppingCart 
  {
    private static List<Bread> _breadCart = new List<Bread> {};
    private static List<Pastry> _pastryCart = new List<Pastry> {};


  }


  public class Bread
  {
    public string Description { get; set; }
    public Bread(string description)
    {
      Description = description;
    }

    public static int GetPrice(int quantity)
    {
      int btgoNumber = quantity/3;
      int fullPriceRemainder = quantity%3;          
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