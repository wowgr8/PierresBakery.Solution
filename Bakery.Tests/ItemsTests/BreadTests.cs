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
      int samplePrice = 5;
      //Act      
      Bread loafBread = new Bread(samplePrice);
      //Assert
      Assert.AreEqual(typeof(Bread), loafBread.GetType());
    }

    [TestMethod]
    public void BreadConstructor_SetPriceProperty_5()
    {
      //Arrange
      int samplePrice = 5;

      //Act
      Bread loafBread = new Bread(samplePrice);

      //Assert
      Assert.AreEqual(loafBread.Price, 5);
    }

    [TestMethod]
    public void GetQuantity_GetBreadQuantity_1()
    {
      //Arrange
      int samplePrice = 5;
      //Act
      Bread loafBread = new Bread(samplePrice);
      //Assert
      Assert.AreEqual(loafBread.GetQuantity(), 1);
    }
    
  }
}