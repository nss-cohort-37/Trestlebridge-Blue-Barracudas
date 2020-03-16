using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Trestlebridge;
using Trestlebridge.Actions;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class NaturalField : IFacility<INatural>
    {
        private int _capacity = 12;
        private Guid _id = Guid.NewGuid ();
        public double seedCount
        {
            get
            {
                return _seeds.Count;
            }
        }
        public List<INatural> _seeds = new List<INatural> ();
        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }
        public void AddResource (INatural seed)
        {
            // while (true)
            // {
            if (_seeds.Count < Capacity)
            {
                _seeds.Add (seed);
                return;
            }
            //
            else
            {
                Console.WriteLine ("Too many seeds in there!");
                Console.WriteLine ("Hit ENTER to continue.");
                Console.ReadLine ();
                return;
            }
            //}
        }
        public void AddResource (List<INatural> seeds)
        {
            // TODO: implement this...
            throw new NotImplementedException ();
        }
        public override string ToString ()
        {
            StringBuilder output = new StringBuilder ();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            output.Append ($"Natural field {shortId} has {this._seeds.Count} plants\n");
            this._seeds.ForEach (a => output.Append ($"   {a}\n"));
            return output.ToString ();
        }
    }
}