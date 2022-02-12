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
    }

    public int GetPrice() // This is a method
    {
      return Price = Quantity * 5 ;
    }
  }
}