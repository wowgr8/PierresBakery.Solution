using System;

namespace Bakery.Items
{
  public class Bread
  {
    public int Quantity {get; set;}

    public Bread(int breadQuantity) 
    {
      Quantity = breadQuantity;
    }

    public int GetPrice()
    {
      int regularPrice = 0;
      int dividedPrice = 0;
      int totalPrice = 0;
      int remainder = 0;
      int remainderDiscount = 0;

      if((Quantity % 3) == 0)
      {
        regularPrice = Quantity * 5;
        dividedPrice = regularPrice / 3;
        totalPrice = regularPrice - dividedPrice;
      }
      else if((Quantity == 1) || (Quantity == 2))
      {
        totalPrice = Quantity * 5 ;
      }
      else 
      {
        remainder = Quantity % 3;
        regularPrice = Quantity * 5;
        remainderDiscount = remainder * 5;
        totalPrice = regularPrice - remainderDiscount;
      }
      return totalPrice;
    }
  }
}