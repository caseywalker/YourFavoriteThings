using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourFavoriteThings.Favorites
{
  class Pizza : Food
  {
    public string Toppings { get; set; }
    public int BakeTime { get; set; }

    public void Cook(int cookTime)
    {
      if (cookTime == BakeTime)
      {
        Console.WriteLine($"The {base.Name} is cooked to perfection.");

      } else if (cookTime > BakeTime)
      {
        Console.WriteLine($"The {base.Name} was cooked for too long.");
      }
      else if (cookTime < BakeTime)
      {
        Console.WriteLine($"The {base.Name} is undercooked.");
      }
    }
  }
}
