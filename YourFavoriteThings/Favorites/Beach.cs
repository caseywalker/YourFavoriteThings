using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourFavoriteThings.Favorites
{
  class Beach : Vacation
  {
    public bool isSummer { get; set; }
    public Beach(string name, string location, string vacationType, bool summer) : base(name, location, vacationType)
    {
      isSummer = summer;
    }

    public void Activities()
    {
      if (isSummer)
      {
        Console.WriteLine($"Go parasailing over the beach!");
      }
      else
      {
        Console.WriteLine($"Go check out some local restaurants.");
      }
    }
  }
}
