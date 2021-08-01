using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourFavoriteThings.Favorites
{
  class Mountains : Vacation
  {
    public bool isWinter { get; }
    public Mountains(string name, string location, string vacationType, bool winter) : base(name, location, vacationType)
    {
      isWinter = winter;
    }

    public void Activities()
    {
      if (isWinter)
      {
        Console.WriteLine($"Ski down the mountains in {base.Location}.");
      }
      else
      {
        Console.WriteLine($"Go hike the trails in {base.Location}.");
      }
    }
  }
}
