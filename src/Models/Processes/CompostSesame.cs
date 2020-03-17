using System;

using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Processes
{
    public class Compost : IProcess, IPlowed
    { 
                private int _rowsProduced = 13;

               public string Type { get; } = "Sesame";

               public string ProcessType { get; } = "Compost";

                  public double Harvest () {
                  return _rowsProduced;
                        }
               


    

        public override string ToString ()
        {
            return $"Yay We re Composting!";
        }
    }
}