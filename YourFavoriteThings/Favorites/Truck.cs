using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourFavoriteThings.Favorites
{
  class Truck : Vehicle
  {
    public int TowCapacity = 9400;
    public Truck(int year, string make, string model) : base(year, make, model)
    {

    }

    public void Tow(int load)
    {
      if (load < TowCapacity)
      {
        Console.WriteLine($"The {base.Make} {base.Model} was able to tow the load.");
      }
      else if (TowCapacity < load)
      {
        Console.WriteLine($"The max tow capacity of the {base.Model} is {TowCapacity}, and cannot haul this load.");
      }
    }

  }
}
