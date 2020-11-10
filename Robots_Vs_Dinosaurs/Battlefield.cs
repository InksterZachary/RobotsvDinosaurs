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
        public string Run(string victor) //If herd is a member variable of Battlefiel.cs why don't I have access to it's construct "dinoTeam"
        {
            while(herd.dinoTeam.Count > 0 && fleet.roboTeam.Count > 0)
            {

            }
        }
    }
}
