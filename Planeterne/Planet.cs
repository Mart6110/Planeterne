using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne
{
    class Planet
    {
        // Variables
        private string name;
        private int diameter;
        private int temperature;

        // Makes it so we can get the variables in main method
        public string Name { get { return name; }  }
        public int Diameter { get { return diameter; } }
        public int Temperature { get { return temperature; } }

        // Constructors
        public Planet(string name, int diameter, int temperature)
        {
            this.name = name;
            this.diameter = diameter;
            this.temperature = temperature;
        }

    }
}
