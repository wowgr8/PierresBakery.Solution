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
      Pastry sweetPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), sweetPastry.GetType());
    }
  }
}