using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Items;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      int sampleQuantity = 1;
      Pastry sweetPastry = new Pastry(sampleQuantity);
      Assert.AreEqual(typeof(Pastry), sweetPastry.GetType());
    }

    [TestMethod]
    public void PastryConstructor_SetQuantityProperty_1()
    {
      int sampleQuantity = 1;
      Pastry sweetPastry = new Pastry(sampleQuantity);
      Assert.AreEqual(sweetPastry.Quantity, 1);
    }

    [TestMethod]
    public void GetPrice_GetPastryPrice_2()
    {
      int sampleQuantity = 1;
      Pastry sweetPastry = new Pastry(sampleQuantity);
      Assert.AreEqual(sweetPastry.GetPrice(), 2);
    }
  }
}