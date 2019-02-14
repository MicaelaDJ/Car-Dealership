using System;
using System.Collections.Generic;

namespace Dealership {

  public class Program
  {
    public static void Main()
    {
      Car porsche = new Car("2014 Porsche 911", 114991, 7864, "This car goes really fast!");
      Car ford = new Car("2011 Ford F450", 55995, 14241, "Our logo is really straight-forward.");
      Car lexus = new Car("2013 Lexus RX 350", 44700, 20000, "Made in Japan.");
      Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979, "Every 'e' is pronounced differently!");

      List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };

      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      Console.WriteLine("Enter maximum mileage: ");
      string stringMaxMiles = Console.ReadLine();
      int maxMiles = int.Parse(stringMaxMiles);

      List<Car> CarsMatchingSearch = new List<Car>(0);

      foreach (Car automobile in Cars)
      {
        if (automobile.WorthBuying(maxPrice, maxMiles))
        {
          CarsMatchingSearch.Add(automobile);
        }
        if (!(automobile.WorthBuying(maxPrice, maxMiles)))
        {
          Console.WriteLine("This car is not available per your criteria.");
        }
      }

      foreach(Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine("----------------------");
        Console.WriteLine(automobile.GetMakeModel());
        Console.WriteLine(automobile.GetMiles() + " miles");
        Console.WriteLine("$" + automobile.GetPrice());
        Console.WriteLine(automobile.GetInfo());
      }
    }
  }

}
