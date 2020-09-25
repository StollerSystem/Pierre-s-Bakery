using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread("test");
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Item()
    {
      Pastry newPastry = new Pastry();
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


  }
}