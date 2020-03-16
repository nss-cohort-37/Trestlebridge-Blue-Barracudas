using System;
using System.Collections.Generic;
using System.Linq;

using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class ChoosePlowedField
    {
        public static void CollectInput(Farm farm, IPlowed seed)
        {
            Utils.Clear();

            for (int i = 0; i < farm.PlowedFields.Count; i++)
            {

                if (farm.PlowedFields[i].seedCount != farm.PlowedFields[i].Capacity)
                {

                    var sesameCount = 0;
                    var sunflowerCount = 0;
                    Console.WriteLine($"{i + 1}. {farm.PlowedFields[i].ToString()} Max Capacity: {farm.PlowedFields[i].Capacity}");

                    sesameCount = farm.PlowedFields[i]._seeds
                        .Where(plant => plant.Type == "Sesame")
                        .Count();
                    Console.WriteLine($"Sesame: {sesameCount}\n");

                    sunflowerCount = farm.PlowedFields[i]._seeds
                        .Where(plant => plant.Type == "Sunflower")
                        .Count();
                    Console.WriteLine($"Sunflower: {sunflowerCount}\n");

                }

            }

            //
            Console.WriteLine();
            // How can I output the type of animal chosen here?

            Console.WriteLine($"Place the plant where?");
            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine()) - 1;

            farm.PlowedFields[choice].AddResource(seed);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);
        }
    }
}