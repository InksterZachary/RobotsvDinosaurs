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
        Herd herd = new Herd();
        Fleet fleet = new Fleet();
        //constructors
        public Battlefield()
        {
            herd.populateHerd();
            fleet.populateFleet();
        }

        //member methods
        public string Run(string victor)
        {

        }
    }
}
