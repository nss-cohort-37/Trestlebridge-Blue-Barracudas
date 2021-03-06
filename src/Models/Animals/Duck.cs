using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Duck : IResource, IDuck {

        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 1.7;
         private double _eggsProduced = 7;
          private double _featherProduced= 0.5;

        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public string Type { get; } = "Duck";

        // Methods

        public double Butcher () {
            return _meatProduced;
        }

        public double Eggs () {
            return _eggsProduced;
        }

        public double Feather () {
            return _featherProduced;

        }

        public override string ToString () {
            return $"Duck {this._shortId}. Quack Quack!";
        }
    }
}