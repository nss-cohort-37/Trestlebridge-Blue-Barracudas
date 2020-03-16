using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class DualFields
    {
        public static void CollectInput(Farm farm )
        {
            Console.WriteLine("1. Natural");
            Console.WriteLine("2. Plowed");

            Console.WriteLine();
            Console.WriteLine("What type of field?");

            Console.Write("> ");
            string choice = Console.ReadLine();

            switch (Int32.Parse(choice))
            {
                    case 1:
                    ChooseNaturalField.CollectInput(farm, new Sunflower());
                    break;
                    case 2:
                    ChoosePlowedField.CollectInput(farm, new Sunflower());
                    break;
                default:
                    break;
            }
        }
    }
}