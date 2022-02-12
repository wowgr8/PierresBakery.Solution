using System;

namespace Bakery.Items
{
  public class Pastry
  {
    public int Quantity {get; set;}
    public int Price {get; set;}

    public Pastry(int pastryQuantity)
    {
      Quantity = pastryQuantity;
      Price = Quantity;
    }

    public int GetPrice()
    {
      switch (Price)
      {
        case 1:
          Price = 2;
          break;
        case 2:
          Price = 3;
          break;
        case 3:
          Price = 5;
          break;
        case 4:
          Price = 7;
          break;
        case 5:
          Price = 9;
          break;
        case 6:
          Price = 10;
          break;
      }
      return Price;
    }
  }
}