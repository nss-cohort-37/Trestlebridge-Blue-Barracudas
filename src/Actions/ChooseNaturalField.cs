using System;
using System.Linq;

using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class ChooseNaturalField
    {
        public static void CollectInput(Farm farm, INatural seed)
        {
            Utils.Clear();

            for (int i = 0; i < farm.NaturalFields.Count; i++)
            {

                if (farm.NaturalFields[i].seedCount != farm.NaturalFields[i].Capacity)
                {

                    Console.WriteLine($"{i + 1}. {farm.NaturalFields[i].ToString()} Max Capacity: {farm.NaturalFields[i].Capacity}");
                }

            }

            //
            Console.WriteLine();
            // How can I output the type of animal chosen here?

            Console.WriteLine($"Place the plant where?");
            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine()) - 1;

            farm.NaturalFields[choice].AddResource(seed);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);
        }
    }
}