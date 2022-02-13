using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Items;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      int sampleQuantity = 1;
      Bread loafBread = new Bread(sampleQuantity);
      Assert.AreEqual(typeof(Bread), loafBread.GetType());
    }

    [TestMethod]
    public void BreadConstructor_SetQuantityProperty_1()
    {
      int sampleQuantity = 1;
      Bread loafBread = new Bread(sampleQuantity);
      Assert.AreEqual(loafBread.Quantity, 1);
    }

    [TestMethod]
    public void GetPrice_GetBreadPrice_5()
    {
      int sampleQuantity = 1;
      Bread loafBread = new Bread(sampleQuantity);
      Assert.AreEqual(loafBread.GetPrice(), 5);
    }

    [TestMethod]
    public void GetPrice_DiscountEveryThirdQuantity_10()
    {
      int sampleQuantity = 3;
      Bread loafBread = new Bread(sampleQuantity);
      Assert.AreEqual(loafBread.GetPrice(), 10);
    }

    [TestMethod]
    public void GetPrice_DiscountQuantityContainingAnyVariablesOfThree_15()
    {
      int sampleQuantity = 4;
      Bread loafBread = new Bread(sampleQuantity);
      Assert.AreEqual(loafBread.GetPrice(), 15);
    }
  }
}