using System;
using YourFavoriteThings.Favorites;

namespace YourFavoriteThings
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Your favorite things");

      var pizza = new Food();
      pizza.Name = "Pizza";
      pizza.Meal = "Dinner";

      var tacos = new Food
      {
        Name = "Tacos",
        Meal = "Lunch"
      };

      tacos.Cook();
      tacos.Eat();

      pizza.Cook();
      pizza.Eat();

      var salvos = new Restaurant("Salvo's", "Smyrna", "Pizza");
      salvos.Number = "555-5555";

      var hemingways = new Restaurant("Hemingway's", "Nashville", "Tavern");
      hemingways.Number = "867-5309";

      salvos.Info();
      salvos.Order();

      hemingways.Info();
      hemingways.Order();

    }
  }
}
