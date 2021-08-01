using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourFavoriteThings.Favorites
{
  class Car : Vehicle
  {
    public bool canFly { get; set; }
    public Car(int year, string make, string model) : base(year, make, model)
    {
      if (model == "Delorean")
      {
        canFly = true;
      } else
      {
        canFly = false;
      }
    }

    public void TimeTravel()
    {
      if (canFly)
      {
        Console.WriteLine($"The {base.Model} speeds to 88MPH and disappears!");
      }
      else
      {
        Console.WriteLine($"You watch too many movies, {base.Make} doesn't make flying cars.");
      }
    }
  }
}
