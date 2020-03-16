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
            Console.WriteLine("3. Natural field");
            Console.WriteLine("4. Chicken House");
            Console.WriteLine("5. Duck House");

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
                    //       case 2:
                    // farm.addPlowedField(new PlowedField());
                    // Console.WriteLine("Your new plowed field was created!");
                    // foreach (var field in farm.PlowedFields)
                    // {
                    //     Console.WriteLine($"{field.ToString()}");
                    // }
                    // Console.WriteLine("Please hit enter");
                    // Console.ReadLine();
                    // break;
                case 3:
                    farm.AddNaturalField(new NaturalField());
                    Console.WriteLine("Your new natural field was created!");
                    foreach (var field in farm.NaturalFields)
                    {
                        Console.WriteLine($"{field.ToString()}");
                    }
                    Console.WriteLine("Please hit enter");
                    Console.ReadLine();
                    break;
                        case 4:
                    farm.AddChickenHouse(new ChickenHouse());
                    Console.WriteLine("Your new chicken house was created!");
                    foreach (var house in farm.ChickenHouses)
                    {
                        Console.WriteLine($"{house.ToString()}");
                    }
                    Console.WriteLine("Please hit enter");
                    Console.ReadLine();
                    break;
                       case 5:
                    farm.AddDuckHouse(new DuckHouse());
                    Console.WriteLine("Your new duck house was created!");
                    foreach (var house in farm.DuckHouses)
                    {
                        Console.WriteLine($"{house.ToString()}");
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