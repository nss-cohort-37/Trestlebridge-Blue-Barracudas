using System;
using System.Collections.Generic;
using System.Linq;

using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ChooseCompostFacility
    {
        public static void CollectInput (Farm farm)
        {
            var Choices = new List<ICompost> ();

            for (int i = 0; i < farm.NaturalFields.Count; i++)
            {
                if (farm.NaturalFields[i].seedCount != farm.NaturalFields[i].Capacity)
                {
                    var sunflowerCount = 0;

                    Console.WriteLine ($"{i + 1}. {farm.NaturalFields[i].ToString()} ");
                    Choices.Add (farm.NaturalFields[i]);

                    sunflowerCount = farm.NaturalFields[i]._seeds
                        .Where (plant => plant.Type == "Sunflower")
                        .Count ();
                    Console.WriteLine ($"Sunflower: {sunflowerCount}\n");
                }

            }

            for (int i = 0; i < farm.PlowedFields.Count; i++)
            {

                if (farm.PlowedFields[i].seedCount != farm.PlowedFields[i].Capacity)
                {

                    var sesameCount = 0;
                    var sunflowerCount = 0;
                    Console.WriteLine ($"{i + farm.NaturalFields.Count + 1}. {farm.PlowedFields[i].ToString()} Max Capacity: {farm.PlowedFields[i].Capacity}");

                    sesameCount = farm.PlowedFields[i]._seeds
                        .Where (plant => plant.Type == "Sesame")
                        .Count ();
                    Console.WriteLine ($"Sesame: {sesameCount}\n");

                    sunflowerCount = farm.PlowedFields[i]._seeds
                        .Where (plant => plant.Type == "Sunflower")
                        .Count ();
                    Console.WriteLine ($"Sunflower: {sunflowerCount}\n");

                }

            }

            Console.WriteLine ($"Which field would you like to Process");
            Console.Write ("> ");
            int choice = Int32.Parse (Console.ReadLine ()) - 1;

            farm.NaturalFields[choice].addProcessing ();

        }
    }
}