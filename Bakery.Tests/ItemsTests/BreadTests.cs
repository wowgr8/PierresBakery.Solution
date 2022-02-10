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
      //Arrange
      Bread loafBread = new Bread();
      Assert.AreEqual(typeof(Bread), loafBread.GetType());
    }
  }
}