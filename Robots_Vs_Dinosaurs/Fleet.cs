using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_Vs_Dinosaurs
{
    class Fleet
    {
        public List<Robot> robots;

        public Fleet()
        {
            robots = new List<Robot>();
            populateFleet();
        }
        public void populateFleet()
        {
            Weapon laserBlaster = new Weapon("Laser Blaster", "Energy", 25);
            Weapon shotGun = new Weapon("Shot Gun", "Gun", 100);
            Weapon gatGun = new Weapon("Laser Gatling Gun", "Energy", 10);

            Robot cyborg = new Robot("Cyborg", 100, 200, laserBlaster);
            Robot metalHead = new Robot("Metal Head", 200, 100, shotGun);
            Robot terminator = new Robot("Terminator", 500, 250, gatGun);
            robots.Add(cyborg);


        }
    }
}
