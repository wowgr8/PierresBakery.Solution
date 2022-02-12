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
      return Price * 2;
    }
  }
}