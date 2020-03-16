using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sunflower : IResource, ISunflower
    {
        private int _seedsProduced = 40;
        public string Type { get; } = "Sesame";

        public double Harvest () {
            return _seedsProduced;
        }

        public override string ToString () {
            return $"Sesame. Yum!";
        }
    }
}