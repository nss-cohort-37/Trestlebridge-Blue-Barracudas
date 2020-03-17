using System;
using System.Linq;

using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
  public class ChooseChickenHouse
  {
    public static void CollectInput(Farm farm, IChicken chicken)
    {
      Utils.Clear();

      for (int i = 0; i < farm.ChickenHouses.Count; i++)
      {

        if (farm.ChickenHouses[i].chickenCount != farm.ChickenHouses[i].Capacity)
        {

          Console.WriteLine($"{i + 1}. {farm.ChickenHouses[i].ToString()} Max Capacity: {farm.ChickenHouses[i].Capacity}");
        }

      }

      //
      Console.WriteLine();
      // How can I output the type of chicken chosen here?

      Console.WriteLine($"Place the chicken where?");
      Console.Write("> ");
      int choice = Int32.Parse(Console.ReadLine()) - 1;

      if (choice < farm.ChickenHouses.Count)
      {
        farm.ChickenHouses[choice].AddResource(chicken);
      }
      else
      {
        Console.WriteLine("Not a valid facility. You may need to create one!");
        Console.ReadLine();
      }

      /*
          Couldn't get this to work. Can you?
          Stretch goal. Only if the app is fully functional.
       */
      // farm.PurchaseResource<IGrazing>(chicken, choice);
    }
  }
}