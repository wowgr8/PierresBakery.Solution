using System;

namespace Bakery.Items
{
  public class Bread
  {
    public int Price {get; set;} 
    public int Quantity {get; set;}

    public Bread(int breadQuantity) 
    {
      Quantity = breadQuantity;
      Price = Quantity;
    }

    public int GetPrice()
    {
      int regularPrice = 0;
      int dividedPrice = 0;
      int totalPrice = 0;
      int remainder = 0;
      int remainderDiscount = 0;

      if((Price % 3) == 0)
      {
        regularPrice = Price * 5;
        dividedPrice = regularPrice / 3;
        totalPrice = regularPrice - dividedPrice;
      }
      else if((Price == 1) || (Price == 2))
      {
        totalPrice = Price * 5 ;
      }
      else if(((Price % 3) != 0)|| (Price != 1) || (Price != 2))
      {
        remainder = Price % 3;
        regularPrice = Price * 5;
        remainderDiscount = remainder * 5;
        totalPrice = regularPrice - remainderDiscount;
      }
      return totalPrice;
    }
  }
}