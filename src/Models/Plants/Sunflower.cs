using System;

using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sunflower : IResource, ISunflower, ISeedProducing, IProcess
    {
        private int _seedsProduced = 40;
        public string Type { get; } = "Sunflower";


        public string ProcessType { get; } = "Compost";
        public double Harvest ()
        {
            return _seedsProduced;
        }

        public override string ToString ()
        {
            return $"Sunflower. Yum!";
        }
    }
}