using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class CreateFacility
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Grazing field");
            Console.WriteLine("2. Plowed field");

            Console.WriteLine();
            Console.WriteLine("Choose what you want to create");

            Console.Write("> ");
            string input = Console.ReadLine();

            switch (Int32.Parse(input))
            {
                case 1:
                    farm.AddGrazingField(new GrazingField());
                    Console.WriteLine("Your new grazing field was created!");
                    foreach (var field in farm.GrazingFields)
                    {
                        Console.WriteLine($"{field.ToString()}");
                    }
                    Console.WriteLine("Please hit enter");
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
        }
    }
}