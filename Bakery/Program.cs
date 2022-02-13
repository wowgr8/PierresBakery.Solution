using System;
using Bakery.Items;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("We have deals on bread and pastries today!");
      Console.WriteLine("For bread its buy 2 get 1 FREE! A single loaf costs $5, two loaves costs $10, and three loaves cost $10.");
      Console.WriteLine("For pastries its buy 1 for $2 or 3 for $5. Four pastries costs $7, five pastries costs $9, and six pastries costs $10. Limit of 6 pastries per customer.");
      Console.WriteLine("How much bread would you like today? Please enter a number, there are no limits!");
      string stringSelectedBread = Console.ReadLine();
      int selectedBread = int.Parse(stringSelectedBread);
      Console.WriteLine("How many pastries would you like today? Please enter a number up to 6.");
      string stringSelectedPastry = Console.ReadLine();
      int selectedPastry = int.Parse(stringSelectedPastry);
      Bread breadOrder = new Bread(selectedBread);
      Pastry pastryOrder = new Pastry(selectedPastry);
      Console.WriteLine("Your total for bread is: $" + breadOrder.GetPrice() + " and your total for pastries is: $" + pastryOrder.GetPrice() + ". That's a grand total of: $" + (breadOrder.GetPrice() + pastryOrder.GetPrice()));

    }
  }
}