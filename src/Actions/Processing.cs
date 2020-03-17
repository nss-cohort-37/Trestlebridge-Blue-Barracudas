using System;

using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class Processing
    {
        public static void CollectInput (Farm farm)
        {
            Console.WriteLine ("1. Seed Harvester");
            Console.WriteLine ("2. Meat Processor");
            Console.WriteLine ("3. Egg Gatherer");
            Console.WriteLine ("4. Composter");
            Console.WriteLine ("5. Feather Harvester");

            Console.WriteLine ();
            Console.WriteLine ("What are you processing today?");

            Console.Write ("> ");
            string choice = Console.ReadLine ();

            switch (Int32.Parse (choice))
            {
                case 1:
                    Console.WriteLine ("ONLY COMPOST FUNCTIONAL RIGHT NOW");
                    Console.ReadLine ();
                    break;
                case 2:
                    Console.WriteLine ("ONLY COMPOST FUNCTIONAL RIGHT NOW");
                    Console.ReadLine ();
                    break;
                case 3:
                    Console.WriteLine ("ONLY COMPOST FUNCTIONAL RIGHT NOW");
                    Console.ReadLine ();
                    break;
                case 4:
                    ChooseCompostFacility.CollectInput (farm);
                    break;
                case 5:
                    Console.WriteLine ("ONLY COMPOST FUNCTIONAL RIGHT NOW");
                    Console.ReadLine ();
                    break;
                default:
                    //   throw new ArgumentOutOfRangeException("Unknown value");
                    Console.WriteLine ("That's not a valid choice! Please try again!");
                    Console.ReadLine ();
                    break;
            }
        }
    }
}