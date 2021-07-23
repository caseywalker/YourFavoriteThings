using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourFavoriteThings.Favorites
{
  class Vacation
  {
    public string Name { get; set; }
    public string Location { get; set; }
    public string VacationType { get; set; }

    public Vacation(string name, string location, string vacationType)
    {
      Name = name;
      Location = location;
      VacationType = vacationType;
    }
    public void Destination()
    {
      Console.WriteLine($"{Name} is located in {Location}");
    }

    public void Type()
    {
      Console.WriteLine($"{Name} is a {VacationType} vacation.");
    }

  }
}
