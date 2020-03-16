using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trestlebridge;
using Trestlebridge.Actions;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class ChickenHouse : IFacility<IChicken>

    {
        private int _capacity = 2;
        private Guid _id = Guid.NewGuid ();
        public double chickenCount
        {
            get
            {
                return _chickens.Count;
            }
        }
        private List<IChicken> _chickens = new List<IChicken> ();

        // private List<IEggsProducing> _eggs = new List<IEggsProducing>();

        // private List<IFeatherProducing> _feathers = new List<IFeatherProducing>();
        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }
        public void AddResource (IChicken chicken)
        {
        
            if (_chickens.Count < Capacity)
            {
                _chickens.Add (chicken);
                return;
            }
            //
            else
            {
                Console.WriteLine ("Too many chickens in there!");
                Console.WriteLine ("Hit ENTER to continue.");
                Console.ReadLine ();
                return;
            }
        
        }

        public void AddResource (List<IChicken> animals)
        {
            // TODO: implement this...
            throw new NotImplementedException ();
        }


        public override string ToString ()
        {
            StringBuilder output = new StringBuilder ();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            output.Append ($"Chicken House {shortId} has {this._chickens.Count} chickens!\n");
            this._chickens.ForEach (a => output.Append ($"   {a}\n"));
            return output.ToString ();
        }
    }
}