using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourFavoriteThings.Favorites
{
  class Wings : Food
  {
    public WingType Type { get; set; }
    public WingFlavor Flavor { get; set; }
    public double Count { get; set; }
    public double Price { get; set; }

    public Wings(WingType type, WingFlavor flavor, double count)
    {
      Type = type;
      Flavor = flavor;
      Count = count;
      Price = count * 1.29;
    }

    public void Spicy()
    {
      Console.WriteLine($"You ordered {Count} {Flavor} {Type} wings, the total price is ${Price}.");
    }
  }
}
