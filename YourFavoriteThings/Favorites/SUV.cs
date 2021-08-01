using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourFavoriteThings.Favorites
{
  class SUV : Vehicle
  {
    public bool Is4WD { get; set; }
    public SUV(int year, string make, string model, bool is4wd) : base(year, make, model)
    {
      Is4WD = is4wd;
    }

    public void Offroad()
    {
      if (Is4WD)
      {
        Console.WriteLine($"The {base.Model} takes it off road.");
      } else
      {
        Console.WriteLine($"The {base.Model} is not a 4-wheel drive vehicle, and should stick to paved roads.");
      }
    }
  }
}
