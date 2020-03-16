using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trestlebridge;
using Trestlebridge.Actions;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class DuckHouse : IFacility<IDuck>

    {
        private int _capacity = 2;
        private Guid _id = Guid.NewGuid ();
        public double duckCount
        {
            get
            {
                return _ducks.Count;
            }
        }
        private List<IDuck> _ducks = new List<IDuck> ();

        // private List<IEggsProducing> _eggs = new List<IEggsProducing>();

        // private List<IFeatherProducing> _feathers = new List<IFeatherProducing>();
        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }
        public void AddResource (IDuck duck)
        {
        
            if (_ducks.Count < Capacity)
            {
                _ducks.Add (duck);
                return;
            }
            //
            else
            {
                Console.WriteLine ("Too many Ducks in there!");
                Console.WriteLine ("Hit ENTER to continue.");
                Console.ReadLine ();
                return;
            }
        
        }

        public void AddResource (List<IDuck> animals)
        {
            // TODO: implement this...
            throw new NotImplementedException ();
        }


        public override string ToString ()
        {
            StringBuilder output = new StringBuilder ();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            output.Append ($"Duck House {shortId} has {this._ducks.Count} ducks!\n");
            this._ducks.ForEach (a => output.Append ($"   {a}\n"));
            return output.ToString ();
        }
    }
}