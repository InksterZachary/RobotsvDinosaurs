using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_Vs_Dinosaurs
{
    class Fleet
    {
        public List<Robot> roboTeam;

        public Fleet()
        {
            roboTeam = new List<Robot>();
            populateFleet();
        }
        public void FleetAttack(Herd herd)
        {
            //We have two lists ROBOTS and DINOSAURS
            for(int i =0; i < roboTeam.Count; i++)
            {
                if(i < herd.dinoTeam.Count)
                {
                    bool fatality = roboTeam[i].RobotAttack(herd.dinoTeam[i]);
                    if(fatality)
                    {
                        herd.dinoTeam.RemoveAt(i);
                    }
                    
                }
            }
            //All living robots should attack their opponent
            //if opponent is present attack
            //else dont attack
        }
        public void populateFleet()
        {
            Weapon laserBlaster = new Weapon("Laser Blaster", "Energy", 25);
            Weapon shotGun = new Weapon("Shot Gun", "Gun", 100);
            Weapon gatGun = new Weapon("Laser Gatling Gun", "Energy", 10);

            Robot cyborg = new Robot("Cyborg", 100, 200, laserBlaster);
            Robot metalHead = new Robot("Metal Head", 200, 100, shotGun);
            Robot terminator = new Robot("Terminator", 500, 250, gatGun);
            roboTeam.Add(cyborg);
            roboTeam.Add(metalHead);
            roboTeam.Add(terminator);

            if (cyborg.health == 0)
            {
                roboTeam.Remove(cyborg);
            }
            if (metalHead.health == 0)
            {
                roboTeam.Remove(metalHead);
            }
            if (terminator.health == 0)
            {
                roboTeam.Remove(terminator);
            }
        }
    }
}
