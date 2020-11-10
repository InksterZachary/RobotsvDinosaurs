using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Robots_Vs_Dinosaurs
{
    class Robot
    {
        //member variables
        public string name;
        public int health;
        public int powerLevel;
        public Weapon weapon;
        

        //constructors
        public Robot(string name, int health, int powerLevel, Weapon weapon)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            this.weapon = weapon;
        }
        
        //member methods
        public void LaserBlast(Dinosaur dinosaur) 
        {
            if (powerLevel >= 20)
            {
                powerLevel -= 20;
            }
            else if(powerLevel < 20)
            {
                powerLevel -= powerLevel;
            }
            //if laserBlast hits dinosaur decrease health by 25
            if(health >= 25)
            {
                health -= 25;
            }
            else
            {
                health = 0;
            }
            //if attack hits dinosaur increase powerlevel by 2
            //if attack misses dinosaur nothing happens
        }
        public void LaserRegen(Robot robot)
        {
            if (powerLevel >= 20)
            {
                powerLevel -= 20;
            }
            else if (powerLevel < 20)
            {
                powerLevel = 0;
            }
            if(health < 30)
            {
                health += 25;
            }
            else if(health > 30)
            {
                health += 15;
            }
        }

    }
}
