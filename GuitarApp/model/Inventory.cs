using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.model
{
    internal class Inventory 
    {
        private List<Guitar> _guitars = new List<Guitar>();

        public void AddGuitar(Guitar guitar)
        {
            _guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            foreach (Guitar guitar in _guitars)
            {
                if (guitar.SerialNumber == serialNumber)
                {
                    return guitar;
                }
            }
            return null; 
        }

        public List<Guitar> Search(GuitarSpecs specs)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();

            foreach (Guitar guitar in _guitars)
            {
                if (Matches(guitar.Specs, specs))
                {
                    matchingGuitars.Add(guitar);
                }
            }

            return matchingGuitars;
        }

        private bool Matches(GuitarSpecs guitarSpecs, GuitarSpecs searchSpecs)
        {
   
            bool builderMatches = searchSpecs.Builder == guitarSpecs.Builder;
            bool modelMatches = string.IsNullOrEmpty(searchSpecs.Model) || searchSpecs.Model == guitarSpecs.Model;
            bool typeMatches = searchSpecs.Type == guitarSpecs.Type;
            bool topWoodMatches = searchSpecs.TopWood == guitarSpecs.TopWood;
            bool backWoodMatches = searchSpecs.BackWood == guitarSpecs.BackWood;
            bool numberOfStringsMatches = searchSpecs.NumberOfStrings == guitarSpecs.NumberOfStrings;

            return builderMatches && modelMatches && typeMatches && topWoodMatches && backWoodMatches && numberOfStringsMatches;
        }
    }
}
