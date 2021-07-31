using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourFavoriteThings.Favorites
{
  class Tacos : Food
  {
    public string Tortilla { get; set; }
    public Protein Protein { get; set; }
    public TacoType Type { get; set; }

    public Tacos(TacoType type)
    {
      switch (type) 
      {
        case TacoType.Fajitas:
          Tortilla = "flour";
          Protein = Protein.Steak;
          break;
        case TacoType.Traditional:
          Tortilla = "corn";
          Protein = Protein.Chorizo;
          break;
        case TacoType.Softshell:
          Tortilla = "flour";
          Protein = Protein.Chicken;
          break;
        case TacoType.Hardshell:
          Tortilla = "crunchy corn";
          Protein = Protein.Beef;
          break;
        default:
          Console.WriteLine("nope");
          break;
      }

    }

    public void TacoInfo()
    {
      Console.WriteLine($"The tacos are {Type} with {Protein} and a {Tortilla} tortilla.");
    }
  }
}
