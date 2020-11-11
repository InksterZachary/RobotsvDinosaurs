using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Robots_Vs_Dinosaurs
{
    class Battlefield
    {
        //member variables
        public Herd herd;
        public Fleet fleet;
        //constructors
        public Battlefield()
        {
            herd = new Herd();
            fleet = new Fleet();
        }

        //member methods
        public void Run() 
        {

            while (herd.dinoTeam.Count > 0 && fleet.roboTeam.Count > 0)
            {
                fleet.FleetAttack(herd);
                herd.HerdAttack(fleet);
            }

            DeclareWinner();
            
            
        }
        public void DeclareWinner()
        {
            if (herd.dinoTeam.Count == 0)
            {
                Console.WriteLine("Robots have conquered the world!!");
            }
            else if (fleet.roboTeam.Count == 0)
            {
                Console.WriteLine("The dinosaurs shall remain free from their enslavers.");
            }
        }
    }
}
