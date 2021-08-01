using System;
using YourFavoriteThings.Favorites;

namespace YourFavoriteThings
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Your favorite things");

      var pepperoniPizza = new Pizza();
      pepperoniPizza.Toppings = "Pepperoni";
      pepperoniPizza.BakeTime = 20;

      pepperoniPizza.Cook(20);

      var taco = new Tacos(TacoType.Fajitas);
      taco.TacoInfo();

      var wings = new Wings(WingType.Traditional, WingFlavor.Hot, 20);
      wings.Spicy();



      var salvos = new Restaurant("Salvo's", "Smyrna", "Pizza");
      salvos.Number = "555-5555";

      var hemingways = new Restaurant("Hemingway's", "Nashville", "Tavern");
      hemingways.Number = "867-5309";

      salvos.Info();
      salvos.Order();

      hemingways.Info();
      hemingways.Order();

      var orangeBeach = new Beach("Orange Beach", "Alabama", "Beach", true);
      var gatlinburg = new Mountains("Gatlinburg", "Tennessee", "Mountains", false);
      var cruise = new Cruise("Disney Cruise", "Florida", "Cruise", false);

      orangeBeach.Activities();
      gatlinburg.Activities();
      cruise.Requirements();

      var myVehicle = new Truck(2016, "Ford", "F150");
      var dreamVehicle = new SUV(2021, "Ford", "Bronco", true);
      var dmc = new Car(1982, "DMC", "Delorean");

      myVehicle.Fuel(36);
      dreamVehicle.Purchase(50000);
      myVehicle.Tow(5000);
      dreamVehicle.Offroad();
      dmc.TimeTravel();

    }
  }
}
