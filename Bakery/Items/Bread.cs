using System;

namespace Bakery.Items
{
  public class Bread //This is a class
  {
    public int Price {get; set;} //This is a field
    public int Quantity {get; set;}

    public Bread(int breadPrice) // This is a constructor
    {
      Price = breadPrice;
    }

    public int GetQuantity() // This is a method
    {
      return Quantity = Price / 5 ;
    }
  }
}