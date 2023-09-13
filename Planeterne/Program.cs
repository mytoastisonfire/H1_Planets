using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Design og opret din "Planet" klasse med de tilhørende properties
            List<Planet> planets = new List<Planet>();

            //2. Opret en liste og tilføj følgende planeter Merkur, Jorden, Mars, Jupiter, Saturn, Uranus, Neptun, Pluto ved at bruge Add metoden
            planets.Add(new Planet("Mercury", 88, 4879, -173));
            planets.Add(new Planet("Earth", 365, 12742, 15));
            planets.Add(new Planet("Mars", 687, 6779, -65));
            planets.Add(new Planet("Jupiter", 4333, 139822, -110));
            planets.Add(new Planet("Saturn", 10759, 116464, -140));
            planets.Add(new Planet("Uranus", 30687, 50724, -195));
            planets.Add(new Planet("Neptune", 60200, 49244, -200));
            planets.Add(new Planet("Pluto", 90520, 2370, -225));

            //3. Udskriv nu din liste, ved at bruge foreach løkken
            Console.WriteLine("The planets in the list:");
            foreach (var planet in planets)
            {
                Console.WriteLine(planet);
            }

            //4. I listen over planeter, mangler der Venus. Så Venus skal indsættes i listen. Da planeter er sorteret i rækkefølge fra Solen,
            //skal Venus indsættes lige efter Merkur og lige før Jorden
            Planet venus = new Planet("Venus", 225, 12104, 465);
            planets.Insert(1, venus);

            //5. Prøv at udskrive din liste igen, ligger Venus på sin plads?
            Console.WriteLine("\nThe planets after Venus has been added:");
            foreach (var planet in planets)
            {
                Console.WriteLine(planet);
            }

            //6. Fjern Pluto fra listen. Udskriv listen og se om Pluto er forsvundet
            planets.Remove(planets.Find(p => p._name == "Pluto"));

            //7. Indsæt Pluto igen
            planets.Add(new Planet("Pluto", 90520, 2370, -225));

            //8. Der findes en metode til at få antallet af elementer i en liste, find den og udskriv antallet til konsollen
            Console.WriteLine($"\nNumber of planets in the list: {planets.Count}");

            //9. Opret en ny liste med planeter, der har en "mean temperature" under 0
            List<Planet> coldPlanets = new List<Planet>();
            foreach (var planet in planets)
            {
                if (planet._meanTemperature < 0)
                {
                    coldPlanets.Add(planet);
                }
            }
            Console.WriteLine("\nPlanets with a mean temperature under 0C:");
            foreach (var planet in coldPlanets)
            { 
                Console.WriteLine(planet); 
            }
            /*eftersom at det ikke er specificeret hvilken temperatur skala der er snak om, så kunne man også vælge at lave en
             * liste med alle planeter der har en "mean temperature" på under 0 Kelvin der ville se sådan ud: */

            List<Planet> planetsUnder0K = new List<Planet>();
            Console.WriteLine("\nPlanets with a mean temperature under 0K:");
            foreach (var planet in planetsUnder0K)
            {
                Console.WriteLine(planet);
            }


            //10. Opret en ny liste og tilgøj alle de planeter som har en diameter på over 10000km - men under 50000km
            List<Planet> mediumSizedPlanets = new List<Planet>();
            foreach ( var planet in planets)
            {
                if(planet._diameter > 10000 && planet._diameter < 50000)
                {
                    mediumSizedPlanets.Add(planet);
                }
            }
            Console.WriteLine("\nPlanets with a diameter between 10000 and 50000km:");
            foreach(var planet in mediumSizedPlanets)
            {
                Console.WriteLine(planet);
            }

            //11. Prøv som det sidste at fjerne alle planeter fra listen
            planets.Clear();
        }
    }
    class Planet
    {
        public string _name { get; }
        public int _orbitDays { get; }
        public double _diameter { get; }
        public short _meanTemperature { get; }

        public Planet(string name, int orbitDays, double diameter, short meanTemperature)
        {
            _name = name;
            _orbitDays = orbitDays;
            _diameter = diameter;
            _meanTemperature = meanTemperature;
        }

        public override string ToString()
        {
            return $"{_name} - Orbit: {_orbitDays} days, Diameter: {_diameter} km, Mean temperature: {_meanTemperature}C";
        }
    }
}
