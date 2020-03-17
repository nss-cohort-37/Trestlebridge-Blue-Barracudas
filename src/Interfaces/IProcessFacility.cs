using System.Collections.Generic;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Interfaces
{
    public interface IProcessFacility<T>
    {
         double ProcessCapacity { get; }

        
        void AddProcess (T process);
        void AddProcess (List<T> processes);
    }
}