using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourFavoriteThings.Favorites
{
  class Food
  {
    public string Name { get; set; }
    public string Meal { get; set; }

    public void Eat()
    {
      Console.WriteLine($"You just ate {Name} for {Meal}.");
    }

    public void Cook()
    {
      Console.WriteLine($"You just cooked {Name} for {Meal}.");
    }

  }
}
