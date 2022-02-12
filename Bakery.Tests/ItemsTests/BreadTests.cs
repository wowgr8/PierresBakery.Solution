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
    public void GetPrice_GetBreadPrice_5()
    {
      //Arrange
      int sampleQuantity = 1;
      //Act
      Bread loafBread = new Bread(sampleQuantity);
      //Assert
      Assert.AreEqual(loafBread.GetPrice(), 5);
    }

    [TestMethod]
    public void GetPrice_DiscountEveryThirdQuantity_10()
    {
      //Arrange
      int sampleQuantity = 3;
      //Act
      Bread loafBread = new Bread(sampleQuantity);
      //Assert
      Assert.AreEqual(loafBread.GetPrice(), 10);
    }

    [TestMethod]
    public void GetPrice_DiscountQuantityContainingAnyVariablesOfThree_15()
    {
      //Arrange
      int sampleQuantity = 4;
      //Act
      Bread loafBread = new Bread(sampleQuantity);
      //Assert
      Assert.AreEqual(loafBread.GetPrice(), 15);
    }
  }
}