using System;
using System.Collections.Generic;

namespace Robots_Vs_Dinosaurs
{
    class Dinosaur
    {
        //member variables
        
        public string type;
        public int health;
        public int energy;
        public int attackPower;
        
        //constructors
        public Dinosaur(string type, int health, int energy, int attackPower)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.attackPower = attackPower;
        }
        
        //member methods
        public void JawDropper(Robot robot)
        {
            if (energy > 25)
            {
                energy -= 25;
            }
            else if(energy < 25)
            {
                energy -= energy;
            }
            if (robot.health > 40)
            {
                robot.health -= 40;
            }
            else if(robot.health < 40)
            {
                robot.health -= robot.health;
            }

            
        }

    }
}
