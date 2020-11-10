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
        public void laserBlast(Dinosaur dinosaur) 
        {
            powerLevel -= 20;
            //if laserBlast hits dinosaur decrease health by 25
            if(health >= 10)
            {
                health -= 10;
            }
            else
            {
                health = 0;
            }
            //if attack hits dinosaur increase powerlevel by 2
            //if attack misses dinosaur nothing happens

        }

    }
}
