using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

using Trestlebridge.Models;
using Trestlebridge.Models.Processes;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ProcessResource
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Compost");
            Console.WriteLine("2. Butchering");
        
            Console.WriteLine();
            Console.WriteLine("What are you processing?");

            Console.Write("> ");
            string choice = Console.ReadLine();

            switch (Int32.Parse(choice))
            {
                    case 1:
                    ChooseCompostFacility.CollectInput(farm, new Compost());
                    break;
                    case 2:
                    // Butchering.CollectInput(farm);
                    break; 
                default:
                    break;
            }
        }
    }
}