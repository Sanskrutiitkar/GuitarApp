using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.model
{
    internal class GuitarSpecs : SeperateEnums
    {
        private Builder _builder;
        private string _model;
        private GuitarType _type;
        private TopWood _topWood;
        private BackWood _backWood;
        private int _numberOfStrings;

        public Builder Builder { get { return _builder; } }
        public string Model { get { return _model; } }
        public GuitarType Type { get { return _type; } }
        public TopWood TopWood { get { return _topWood; } }
        public BackWood BackWood { get { return _backWood; } }
        public int NumberOfStrings { get { return _numberOfStrings; } }

        public GuitarSpecs(Builder builder, string model, GuitarType type, TopWood topWood, BackWood backWood, int numberOfStrings)
        {
            _builder = builder;
            _model = model;
            _type = type;
            _topWood = topWood;
            _backWood = backWood;
            _numberOfStrings = numberOfStrings;
        }
    }
}
