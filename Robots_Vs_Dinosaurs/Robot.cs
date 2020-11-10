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
        public List<Action<Dinosaur>> roboAttack;
        

        //constructors
        public Robot(string name, int health, int powerLevel, Weapon weapon)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            this.weapon = weapon;
            roboAttack = new List<Action<Dinosaur>>();
            RobotAttackList();
        }
        
        //member methods
        public void RobotAttackList()
        {
            roboAttack.Add(LaserBlast);
            roboAttack.Add(Spray);
            roboAttack.Add(Devastation);
        }
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
                health -= health;
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
                powerLevel -= powerLevel;
            }
            if(health < 30 && health != 0)
            {
                health += 25;
            }
            else if(health > 30)
            {
                health += 15;
            }
            else if(health == 0)
            {
                Console.WriteLine("Robot has already been decommissioned. Can't be rebuilt.");
            }
        }
        public void Spray(Dinosaur dinosaur)
        {
            if(powerLevel >= 10)
            {
                powerLevel -= 10;
            }
            else if(powerLevel < 10)
            {
                powerLevel -= powerLevel;
            }
            if(health >= 35)
            {
                health -= 35;
            }
            else if(health < 35)
            {
                health -= health;
            }
        }
        public void Devastation(Dinosaur dinosaur)
        {
            if (powerLevel > 30)
            {
                powerLevel -= 30;
            }    
            else if(powerLevel < 30)
            {
                powerLevel -= powerLevel;
            }
            if (health > 40)
            {
                health -= 40;
            }
            else if (health < 40)
            {
                health -= health;
            }
           
        }

    }
}
