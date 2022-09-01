using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates the planets as obejct
            Planet mercury = new Planet("Mercury", 4879, 167);
            Planet venus = new Planet("Venus", 12104, 464);
            Planet earth = new Planet("Earth", 12756, 15);
            Planet mars = new Planet("Mars", 6792, -65);
            Planet jupiter = new Planet("Jupiter", 142984, -110);
            Planet saturn = new Planet("Saturn", 120536, -140);
            Planet uranus = new Planet("Uranus", 51118, -195);
            Planet neptune = new Planet("Neptune", 49528, -200);
            Planet pluto = new Planet("Pluto", 2370, -225);


            List<Planet> planets = new List<Planet>();

            // adding planets
            planets.Add(mercury);
            planets.Add(earth);
            planets.Add(mars);
            planets.Add(jupiter);
            planets.Add(saturn);
            planets.Add(uranus);
            planets.Add(neptune);
            planets.Add(pluto);

            Console.WriteLine("Opgave 3");
            foreach (Planet i in planets)
            {
                Console.WriteLine(i.Name);
            }

            // Inserting venus on the list index 1
            Console.WriteLine();
            Console.WriteLine("Opgave 4 & 5");
            planets.Insert(1, venus);

            foreach (Planet i in planets)
            {
                Console.WriteLine(i.Name);
            }


            // removing the planet pluto from the list
            Console.WriteLine();
            Console.WriteLine("Opgave 6");

            planets.Remove(pluto);

            foreach (Planet i in planets)
            {
                Console.WriteLine(i.Name);
            }

            // Adding the planet pluto to the list
            Console.WriteLine();
            Console.WriteLine("Opgave 7");

            planets.Add(pluto);

            foreach (Planet i in planets)
            {
                Console.WriteLine(i.Name);
            }

            // Counting the number of planets in our list
            Console.WriteLine();
            Console.WriteLine("Opgave 8");

            Console.WriteLine("Antal planeter: " + planets.Count());

            
            Console.WriteLine();
            Console.WriteLine("Opgave 9");
            List<Planet> planetTemperature = new List<Planet>();

            // Looping through a foreach and adds the planets that has a higher temperature then 0
            foreach (Planet i in planets)
            {
                if(i.Temperature < 0)
                {
                    planetTemperature.Add(i);
                }
            }
            foreach(Planet i in planetTemperature)
            {
                Console.WriteLine(i.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Opgave 10");
            List<Planet> planetDiameter = new List<Planet>();

            // Looping through a foreach and adds the planets that are bigger then 10000 and smaller 50000 to a new list
            foreach (Planet i in planets)
            {
                if (i.Diameter > 10000 && i.Diameter < 50000)
                {
                    planetDiameter.Add(i);
                }
            }
            // Looping through a foreach to display the newly planets added to our new list
            foreach (Planet i in planetDiameter)
            {
                Console.WriteLine(i.Name);
            }

            // Removing all planets from the list
            planets.Clear();


            Console.ReadLine();
        }
    }
}
