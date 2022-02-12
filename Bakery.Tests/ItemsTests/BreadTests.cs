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
      int sampleQuantity = 1;
      //Act      
      Bread loafBread = new Bread(sampleQuantity);
      //Assert
      Assert.AreEqual(typeof(Bread), loafBread.GetType());
    }

    [TestMethod]
    public void BreadConstructor_SetQuantityProperty_1()
    {
      //Arrange
      int sampleQuantity = 1;

      //Act
      Bread loafBread = new Bread(sampleQuantity);

      //Assert
      Assert.AreEqual(loafBread.Quantity, 1);
    }

    [TestMethod]
    public void GetPrice_GetBreadPrice_1()
    {
      //Arrange
      int sampleQuantity = 1;
      //Act
      Bread loafBread = new Bread(sampleQuantity);
      //Assert
      Assert.AreEqual(loafBread.GetPrice(), 5);
    }
    
  }
}