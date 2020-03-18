using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trestlebridge;
using Trestlebridge.Actions;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class PlowedField : IFacility<IPlowed>, IProcess
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

        public string ProcessType { get; } = "Compost";



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
            if (_seeds.Count < Capacity)
            {
                _seeds.Add (seed);
                return;
            }

            else
            {
                Console.WriteLine ("Too many plants in there!");
                Console.WriteLine ("Hit ENTER to continue.");
                Console.ReadLine ();
                return;
            }
        }

         public void RemoveResource (IPlowed seed)
        {
        
                _seeds.Remove (seed);
                Console.WriteLine("Resoure removed");
        
                return;
        }
        

            public void AddResource (List<IPlowed> seeds)
        {
            // TODO: implement this...
            throw new NotImplementedException ();
        }


   private Guid _id2 = Guid.NewGuid ();

        private int _processCapacity = 5;
         public double processCount
        {
            get
            {
                return _processes.Count;
            }
        }


        public List<IPlowed> _processes = new List<IPlowed> ();


        public void processedCount (List<IPlowed> _processes)
        {
            foreach (IPlowed process in _processes)
            {
                if (process.ProcessType == "Compost");
                {
          
                }
            }
        }

           public double ProcessCapacity
        {
            get
            {
                return _processCapacity;
            }
        }
          public void AddProcess (IPlowed process)
        {
            // TODO: implement this...
              {
            // while (true)
            // {
            if (_processes.Count < ProcessCapacity)
            {
                _processes.Add (process);
                return;
            }
            //
            else
            {
                Console.WriteLine ("Too many processes in there!");
                Console.WriteLine ("Hit ENTER to continue.");
                Console.ReadLine ();
                return;
            }
            //}
        }
        }
        
    
      
        public override string ToString ()
        {
            StringBuilder output = new StringBuilder ();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            string shortId2 = $"{this._id2.ToString().Substring(this._id2.ToString().Length - 6)}";

            output.Append ($"Plowed field {shortId} has {this._seeds.Count}  plants\n");
            output.Append($"It also have {this._processes.Count} processes going!");
            // this._seeds.ForEach (a => output.Append ($"   {a}\n"));

            return output.ToString ();

        }
    }
}