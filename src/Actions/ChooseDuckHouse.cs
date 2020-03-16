using System;
using System.Linq;

using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseDuckHouse
    {
        public static void CollectInput(Farm farm, IDuck duck)
        {
            Utils.Clear();

            for (int i = 0; i < farm.DuckHouses.Count; i++)
            {

                if (farm.DuckHouses[i].duckCount != farm.DuckHouses[i].Capacity)
                {

                    Console.WriteLine($"{i + 1}. {farm.DuckHouses[i].ToString()} Max Capacity: {farm.DuckHouses[i].Capacity}");
                }

            }

            //
            Console.WriteLine();
            // How can I output the type of Duck chosen here?

            Console.WriteLine($"Place the Duck where?");
            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine()) - 1;

            farm.DuckHouses[choice].AddResource(duck);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(Duck, choice);
        }
    }
}