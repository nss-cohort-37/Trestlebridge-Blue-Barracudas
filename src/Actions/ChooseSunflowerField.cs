using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class ChooseSunflowerField
    {
        public static void CollectInput(Farm farm, ISunflower seed)
        {
            Utils.Clear();

            for (int i = 0; i < farm.PlowedFields.Count; i++)
            {

                if (farm.PlowedFields[i].seedCount != farm.PlowedFields[i].Capacity)
                {

                    Console.WriteLine($"{i + 1}. {farm.PlowedFields[i].ToString()} Max Capacity: {farm.PlowedFields[i].Capacity}");
                }
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

            farm.PlowedFields[choice].AddResource(seed);
            farm.NaturalFields[choice].AddResource(seed);


            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);
        }
    }
}