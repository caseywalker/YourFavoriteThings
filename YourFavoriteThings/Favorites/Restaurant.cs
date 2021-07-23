using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourFavoriteThings.Favorites
{
  class Restaurant
  {
    public string Name { get; set; }
    public string Location { get; set; }
    public string Type { get; set; }
    public string Number { get; set; }

    public Restaurant(string name, string location, string type)
    {
      Name = name;
      Location = location;
      Type = type;
    }

    public void Info()
    {
      Console.WriteLine($"Restaurant {Name} is located in {Location}, and is a {Type} restaurant.");
    }

    public void Order()
    {
      Console.WriteLine($"To order food from {Name}, call {Number}.");
    }
  }
}
