using System;

namespace Bakery.Items
{
  public class Bread //This is a class
  {
    public int Price {get; set;} //This is a field
    public int Quantity {get; set;}

    public Bread(int breadQuantity) //This is a constructor
    {
      Quantity = breadQuantity;
      Price = Quantity;
    }

    public int GetPrice() // This is a method
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
      else if ((Price % 3) != 0)
      {
        remainder = Price % 3; //1
        regularPrice = Price * 5; //20
        remainderDiscount = remainder * 5; //5
        totalPrice = regularPrice - remainderDiscount;
      }
      return totalPrice;
    }
  }
}