using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

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
        public void HideRecover(Dinosaur dinosaur)
        {
            if(dinosaur.energy > 50 && dinosaur.energy <= 100)
            {
                dinosaur.energy += 50;
            }
            if (dinosaur.health > 0 && dinosaur.health < 85)
            {
                dinosaur.health += 15;
            }
        }

    }
}
