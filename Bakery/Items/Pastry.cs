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
  }
}