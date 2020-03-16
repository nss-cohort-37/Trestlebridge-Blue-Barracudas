using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Trestlebridge;
using Trestlebridge.Actions;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class PlowedField : IFacility<IPlowed>
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
        public List<IPlowed> _seeds = new List<IPlowed> ();

        public void sesameCount (List<IPlowed> _seeds)
        {
            foreach (IResource seed in _seeds)
            {
                if (seed.Type == "Sesame")
                {

                }
            }
        }

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }
        public void AddResource (IPlowed seed)
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
                Console.WriteLine ("Too many plants in there!");
                Console.WriteLine ("Hit ENTER to continue.");
                Console.ReadLine ();
                return;
            }
            //}
        }
        public void AddResource (List<IPlowed> seeds)
        {
            // TODO: implement this...
            throw new NotImplementedException ();
        }
        public override string ToString ()
        {
            StringBuilder output = new StringBuilder ();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            output.Append ($"Plowed field {shortId} has {this._seeds.Count}  plants\n");
            // this._seeds.ForEach (a => output.Append ($"   {a}\n"));

            return output.ToString ();

        }
    }
}