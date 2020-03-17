using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
    public class Farm
    {

        public List<GrazingField> GrazingFields { get; } = new List<GrazingField> ();

        public List<ProcessedPlowedField> ProcessedPlowed  { get; } = new List<ProcessedPlowedField>();

        public List<NaturalField> ProcessedNatural  { get; } = new List<NaturalField>();

        public List<DuckHouse> DuckHouses { get; } = new List<DuckHouse> ();
        public List<ChickenHouse> ChickenHouses { get; } = new List<ChickenHouse> ();
        public List<NaturalField> NaturalFields { get; } = new List<NaturalField> ();

        public List<PlowedField> PlowedFields { get; } = new List<PlowedField> ();

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void PurchaseResource<T> (IResource resource, int index)
        {
            Console.WriteLine (typeof (T).ToString ());
            switch (typeof (T).ToString ())
            {
                case "Cow":
                    GrazingFields[index].AddResource ((IGrazing) resource);
                    break;
                case "Sheep":
                    GrazingFields[index].AddResource ((IGrazing) resource);
                    break;
                case "Pig":
                    GrazingFields[index].AddResource ((IGrazing) resource);
                    break;
                case "Ostrich":
                    GrazingFields[index].AddResource ((IGrazing) resource);
                    break;
                case "Goat":
                    GrazingFields[index].AddResource ((IGrazing) resource);
                    break;
                case "Duck":
                    DuckHouses[index].AddResource ((IDuck) resource);
                    break;
                case "Chicken":
                    ChickenHouses[index].AddResource ((IChicken) resource);
                    break;
                case "Sesame":
                    PlowedFields[index].AddResource ((IPlowed) resource);
                    NaturalFields[index].AddResource ((INatural) resource);
                    break;
                case "Wildflower":
                    PlowedFields[index].AddResource ((IPlowed) resource);
                    NaturalFields[index].AddResource ((INatural) resource);
                    break;
                case "Sunflower":
                    PlowedFields[index].AddResource ((IPlowed) resource);
                    NaturalFields[index].AddResource ((INatural) resource);
                    break;
                default:
                    break;
            }

        }

         public void ProcessResource <T> (IProcess process, int index)
        {
            Console.WriteLine (typeof (T).ToString ());
            switch (typeof (T).ToString ())
            {
                case "Compost":
                    ProcessedPlowed[index].AddProcess ((IPlowed) process);
                    break;
               
                default:
                    break;
            }

        }


        public void AddGrazingField (GrazingField field)
        {
            GrazingFields.Add (field);
        }

        public void AddProcessedPlowed (ProcessedPlowedField field)
        {
            ProcessedPlowed.Add (field);
        }
        public void AddNaturalField (NaturalField field)
        {
            NaturalFields.Add (field);
        }

        public void AddDuckHouse (DuckHouse house)
        {
            DuckHouses.Add (house);
        }

        public void AddChickenHouse (ChickenHouse house)
        {
            ChickenHouses.Add (house);
        }

        public void AddPlowedField (PlowedField field)
        {
            PlowedFields.Add (field);
        }

        public override string ToString ()
        {
            StringBuilder report = new StringBuilder ();

            GrazingFields.ForEach (gf => report.Append (gf));
            NaturalFields.ForEach (nf => report.Append (nf));
            DuckHouses.ForEach (dh => report.Append (dh));
            ChickenHouses.ForEach (ch => report.Append (ch));
            PlowedFields.ForEach (pf => report.Append (pf));

            return report.ToString ();
        }
    }
}