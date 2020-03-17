using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trestlebridge;
using Trestlebridge.Actions;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class ProcessedPlowedField : IProcessFacility<IProcess>
    {
        private Guid _id = Guid.NewGuid ();

        private int _processCapacity = 1;
         public double processCount
        {
            get
            {
                return _processes.Count;
            }
        }


        public List<IProcess> _processes = new List<IProcess> ();


        // public void processedCount (List<IProcess> _processes)
        // {
        //     foreach (IProcess process in _processes)
        //     {
        //         if (process.Type == "Compost");
        //         {
          
        //         }
        //     }
        // }

           public double ProcessCapacity
        {
            get
            {
                return _processCapacity;
            }
        }
          public void AddProcess (IProcess process)
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
        
        public void AddProcess (List<IProcess> processes)
        {
            // TODO: implement this...
            throw new NotImplementedException ();
        }
        
      
        public override string ToString ()
        {
            StringBuilder output = new StringBuilder ();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            output.Append ($"Plowed field {shortId} has {this._processes.Count}  plants in process\n");
            // this._seeds.ForEach (a => output.Append ($"   {a}\n"));

            return output.ToString ();

        }
    }
}