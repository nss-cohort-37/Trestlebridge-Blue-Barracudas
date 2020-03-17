using System;
using System.Linq;

using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput (Farm farm, IGrazing animal)
        {
            Utils.Clear ();

            for (int i = 0; i < farm.GrazingFields.Count; i++)
            {

                if (farm.GrazingFields[i].animalCount != farm.GrazingFields[i].Capacity)
                {
                    var cowCount = 0;
                    var pigCount = 0;
                    var goatCount = 0;
                    var ostrichCount = 0;
                    var sheepCount = 0;

                    Console.WriteLine ($"{i + 1}. {farm.GrazingFields[i].ToString()} Max Capacity: {farm.GrazingFields[i].Capacity}");

                    cowCount = farm.GrazingFields[i]._animals
                        .Where (monkeyButt => monkeyButt.Type == "Cow")
                        .Count ();
                    Console.WriteLine ($"Cow: {cowCount}");

                    pigCount = farm.GrazingFields[i]._animals
                        .Where (monkeyButt => monkeyButt.Type == "Pig")
                        .Count ();
                    Console.WriteLine ($"Pig: {pigCount}");

                    goatCount = farm.GrazingFields[i]._animals
                        .Where (monkeyButt => monkeyButt.Type == "Goat")
                        .Count ();
                    Console.WriteLine ($"Goat: {goatCount}");

                    ostrichCount = farm.GrazingFields[i]._animals
                        .Where (monkeyButt => monkeyButt.Type == "Ostrich")
                        .Count ();
                    Console.WriteLine ($"Ostrich: {ostrichCount}");

                    sheepCount = farm.GrazingFields[i]._animals
                        .Where (monkeyButt => monkeyButt.Type == "Sheep")
                        .Count ();
                    Console.WriteLine ($"Sheep: {sheepCount}\n");
                }

            }

            //
            Console.WriteLine ();
            // How can I output the type of animal chosen here?

            Console.WriteLine ($"Place the animal where?");
            Console.Write ("> ");
            string choiceChecker = Console.ReadLine ();
            try
            {
                int choice = Int32.Parse (choiceChecker) - 1;
                if (choice < farm.GrazingFields.Count)
                {
                    farm.GrazingFields[choice].AddResource (animal);
                }
                else
                {
                    Console.WriteLine ("Not a valid field. You may need to create one!");
                    Console.ReadLine ();
                }
            }
            catch (Exception)
            {
                Console.WriteLine ($"This is not a valid choice. Try again.");
                Console.ReadLine ();
            }

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);
        }
    }
}