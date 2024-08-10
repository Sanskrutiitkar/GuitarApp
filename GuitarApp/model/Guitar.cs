using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.model
{
   
    internal class Guitar
    {
        private string _serialNumber;
        private double _price;
        private GuitarSpecs _specs;

        public string SerialNumber { get { return _serialNumber; } }
        public double Price { get { return _price; } }
        public GuitarSpecs Specs { get { return _specs; } }

        public Guitar(string serialNumber, double price, GuitarSpecs specs)
        {
            _serialNumber = serialNumber;
            _price = price;
            _specs = specs;
        }

    }
}
