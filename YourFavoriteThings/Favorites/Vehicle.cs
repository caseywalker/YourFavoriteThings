using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourFavoriteThings.Favorites
{
  class Vehicle
  {
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }

    public Vehicle(int year, string make, string model)
    {
      Year = year;
      Make = make;
      Model = model;
    }

    public void Fuel(int gallons)
    {
      Console.WriteLine($"Gassed up the {Model} with {gallons} gallons of gas.");
    }

    public void Purchase(int amount)
    {
      Console.WriteLine($"You purchased a {Year} {Make} {Model} for ${amount} dollars");
    }
  }
}
