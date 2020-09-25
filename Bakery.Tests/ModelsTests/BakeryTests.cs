using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Bakery;


namespace Bakery.Tests  
{
  [TestClass]
  public class BakeryTests : IDisposable
  {
    public void Dispose()
    {
      ShoppingCart.ClearAll();
    }

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread("test");
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Item()
    {
      Pastry newPastry = new Pastry("test");
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void BreadGetPrice_ReturnsTotalPrice_int()
    {      
      Assert.AreEqual(35, Bread.GetPrice(10));
    }

    [TestMethod]
    public void PastryGetPrice_ReturnsTotalPrice_int()
    {      
      Assert.AreEqual(17, Pastry.GetPrice(10));
    }

    [TestMethod]

    public void Bread_CreateObjectWithDescription_string()
    {
      Bread wheat = new Bread("Wheat");
      Assert.AreEqual("Wheat", wheat.Description);
    }

    [TestMethod]

    public void Pastry_CreatePastryWithDescription_string()
    {
      Pastry scone = new Pastry("Scone");
      Assert.AreEqual("Scone", scone.Description);
    }

    [TestMethod]
    public void ShoppingCart_AddBreadToList_Bread()
    {
      Bread sourDough = new Bread("Sour Dough");
      ShoppingCart.AddBread(sourDough);
      List<Bread> breadCart = ShoppingCart.GetBread();
      Assert.AreEqual(sourDough.Description,breadCart[0].Description);
    }

    [TestMethod]
    public void ShoppingCart_AddPastryToList_Pastry()
    {
      Pastry muffin = new Pastry("Muffin");
      ShoppingCart.AddPastry(muffin);
      List<Pastry> pastryCart = ShoppingCart.GetPastry();
      Assert.AreEqual(muffin.Description,pastryCart[0].Description);
    }

    [TestMethod]
    public void GetBread_ReturnsEmtpyList_BreadList()
    {
      List<Bread> newList = new List<Bread> { };
      List<Bread> result = ShoppingCart.GetBread();
      CollectionAssert.AreEqual(newList,result);
    }

    [TestMethod]
    public void GetPastry_ReturnsEmtpyList_PastryList()
    {
      List<Pastry> newList2 = new List<Pastry> { };
      List<Pastry> result = ShoppingCart.GetPastry();
      CollectionAssert.AreEqual(newList2,result);
    }

    [TestMethod]
    public void ShoppingCart_GetGrandTotal_int()
    {
      Bread sourDough = new Bread("Sour Dough");
      ShoppingCart.AddBread(sourDough);
      ShoppingCart.AddBread(sourDough);
      ShoppingCart.AddBread(sourDough);
      ShoppingCart.AddBread(sourDough);
      ShoppingCart.AddBread(sourDough);
      List<Bread> breadCart = ShoppingCart.GetBread();
      Console.WriteLine(breadCart.Count);
      Pastry muffin = new Pastry("Muffin");
      ShoppingCart.AddPastry(muffin);
      ShoppingCart.AddPastry(muffin);
      ShoppingCart.AddPastry(muffin);
      ShoppingCart.AddPastry(muffin);
      ShoppingCart.AddPastry(muffin);
      List<Pastry> pastryCart = ShoppingCart.GetPastry();
      Console.WriteLine(pastryCart.Count);
      int total = ShoppingCart.GetTotal();
      Assert.AreEqual(29,total);
    }
  }
}