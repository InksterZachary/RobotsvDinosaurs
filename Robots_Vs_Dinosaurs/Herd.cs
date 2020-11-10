using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_Vs_Dinosaurs
{
    class Herd
    {
        //member variables
        public List<Dinosaur> dinoTeam;


        //constructors (Spawns)
        public Herd()
        {
            dinoTeam = new List<Dinosaur>();
            populateHerd();
        }


        //member methods

        public void populateHerd()
        {
            Dinosaur hybrid = new Dinosaur("Robo-Rex", 500, 250, 150);
            Dinosaur blue = new Dinosaur("Velociraptor", 100, 300, 250);
            Dinosaur highFlyer = new Dinosaur("Pterodactly", 150, 400, 100);

            dinoTeam.Add(hybrid);
            dinoTeam.Add(blue);
            dinoTeam.Add(highFlyer);
        }
    }
}
