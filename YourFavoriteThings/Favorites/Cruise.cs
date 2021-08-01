using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourFavoriteThings.Favorites
{
  class Cruise : Vacation
  {
    public bool isInternational { get; set; }
    public Cruise(string name, string location, string vacationType, bool international) : base(name, location, vacationType)
    {
      isInternational = international;
    }

    public void Requirements()
    {
      if (isInternational)
      {
        Console.WriteLine($"You will need a passport for this {base.VacationType}.");
      }
      else
      {
        Console.WriteLine($"This {base.VacationType} is staying in {base.Location}, and will not require a passport.");
      }
    }
  }
}
