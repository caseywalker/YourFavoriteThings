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

      pizza.Cook();
      pizza.Eat();

    }
  }
}
