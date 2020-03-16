using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Trestlebridge;
using Trestlebridge.Actions;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class GrazingField : IFacility<IGrazing>
    {
        private int _capacity = 20;
        private Guid _id = Guid.NewGuid();
        public double animalCount
        {
            get
            {
                return _animals.Count;
            }
        }
        public List<IGrazing> _animals = new List<IGrazing>();
        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }
        public void AddResource(IGrazing animal)
        {
            // while (true)
            // {
            if (_animals.Count < Capacity)
            {
                _animals.Add(animal);
                return;
            }
            //
            else
            {
                Console.WriteLine("Too many animals in there!");
                Console.WriteLine("Hit ENTER to continue.");
                Console.ReadLine();
                return;
            }
            //}
        }
        public void AddResource(List<IGrazing> animals)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            output.Append($"Grazing field {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));
            return output.ToString();
        }
    }
}