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
        public void HerdAttack(Fleet fleet)
        {
            for (int i = 0; i < dinoTeam.Count; i++)
            {
                if (i < fleet.roboTeam.Count)
                {
                    bool destruction = dinoTeam[i].JawDropper(fleet.roboTeam[i]);
                    if(destruction)
                    {
                        fleet.roboTeam.RemoveAt(i);
                    }
                }
            }
        }

        public void populateHerd()
        {
            Dinosaur hybrid = new Dinosaur("Robo-Rex", 500, 250, 150);
            Dinosaur blue = new Dinosaur("Velociraptor", 100, 300, 250);
            Dinosaur highFlyer = new Dinosaur("Pterodactly", 150, 400, 100);

            dinoTeam.Add(hybrid);
            dinoTeam.Add(blue);
            dinoTeam.Add(highFlyer);
            if(hybrid.health == 0)
            {
                dinoTeam.Remove(hybrid);
            }
            if (blue.health == 0)
            {
                dinoTeam.Remove(blue);
            }
            if (highFlyer.health == 0)
            {
                dinoTeam.Remove(highFlyer);
            }
        }
    }
}
