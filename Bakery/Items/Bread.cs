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

      if((Price % 3) == 0)
      {
        regularPrice = Price * 5;
        dividedPrice = regularPrice / 3;
        totalPrice = regularPrice - dividedPrice;
      }
      else 
      {
        totalPrice = Price * 5 ;
      }
      return totalPrice;
    }
  }
}