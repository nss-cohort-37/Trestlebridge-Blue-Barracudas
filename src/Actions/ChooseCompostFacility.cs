using System;
using System.Collections.Generic;
using System.Linq;

using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Processes;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class ChooseCompostFacility
    {
        public static void CollectInput (Farm farm, IProcess process)
        {
            Utils.Clear ();

            for (int i = 0; i < farm.PlowedFields.Count; i++)
            {

                if (farm.PlowedFields[i].processCount != farm.PlowedFields[i].ProcessCapacity)
                {

                    var processedCount = 0;
                    Console.WriteLine ($"{i + 1}. {farm.PlowedFields[i].ToString()} Max Capacity: {farm.PlowedFields[i].ProcessCapacity}");

                    processedCount = farm.PlowedFields[i]._processes
                        .Where (process => process.Type == "Compost")
                        .Count ();
                    Console.WriteLine ($" {processedCount}");

                
                }

            }

            //
            Console.WriteLine ();
            // How can I output the type of animal chosen here?

            Console.WriteLine ($"Where are you composting?");
            Console.Write ("> ");
            int choice = Int32.Parse (Console.ReadLine ()) - 1;

            farm.ProcessedPlowed[choice].AddProcess(process);
            // farm.PlowedFields[choice].Remove(seed);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);
        }
    }
}