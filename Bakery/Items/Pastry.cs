using System;

namespace Bakery.Items
{
  public class Pastry
  {
    public int Quantity {get; set;}

    public Pastry(int pastryQuantity)
    {
      Quantity = pastryQuantity;
    }

    public int GetPrice()
    {
      int price = Quantity;
      switch (price)
      {
        case 1:
          price = 2;
          break;
        case 2:
          price = 3;
          break;
        case 3:
          price = 5;
          break;
        case 4:
          price = 7;
          break;
        case 5:
          price = 9;
          break;
        case 6:
          price = 10;
          break;
      }
      return price;
    }
  }
}