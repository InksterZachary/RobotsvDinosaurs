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
        //public List<Action<Robot>> dinoAttacks;
        
        
        //constructors
        public Dinosaur(string type, int health, int energy, int attackPower)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.attackPower = attackPower;
           // dinoAttacks = new List<Action<Robot>>();
           // DinoAttackList();
        }
        
        //member methods
        //public void DinoAttackList()
        //{
           // dinoAttacks.Add(JawDropper);
            //dinoAttacks.Add(MeatGrinder);
            //dinoAttacks.Add(Calamity);
        //}
        public bool JawDropper(Robot robot)
        {
            if (energy > 25)
            {
                energy -= 25;
            }
            else if(energy < 25 && energy != 0)
            {
                energy -= energy;
                Console.WriteLine("Energy levels have been depleted.");
            }
            else if(energy == 0)
            {
                energy += 100;
                Console.WriteLine("Energy levels have been restored");
            }
            if (robot.health > 40)
            {
                robot.health -= 40;
                Console.WriteLine("Jaw Dropper attack was highly effective!");
            }
            else if(robot.health < 40)
            {
                robot.health -= robot.health;
                return false;
            }
            return true;
        }
        public void HideRecover(Robot robot)
        {
            if(energy > 50)
            {
                energy -= 50;
            }
            else if(energy < 50 && energy != 0)
            {
                energy -= energy;
            }
            else if(energy == 0)
            {
                energy += 100;
                Console.WriteLine("Energy has been restored to 100");
            }
            if (health > 0 && health < 85)
            {
                health += 15;
            }
        }
        public bool MeatGrinder(Robot robot)
        {
            if (energy >= 25)
            {
                energy -= 25;
            }
            else if (energy < 25 && energy != 0)
            {
                energy -= energy;
            }
            else if (energy == 0)
            {
                energy += 100;
                Console.WriteLine("Energy has been restored.");
            }
            if(robot.health >= 20)
            {
                robot.health -= 20;
                Console.WriteLine("Meat Grinder was highly effective!");
            }
            else if(robot.health < 20)
            {
                robot.health -= robot.health;
                Console.WriteLine("Robot has been destroyed!");
                return false;
            }
            return true;
        }
        public bool Calamity(Robot robot)
        {

            if (energy > 40)
            {
                energy -= 40;
            }
            else if (energy < 40 && energy != 0)
            {
                energy -= energy;
                Console.WriteLine("Dino needs to rest.");
            }
            else if(energy == 0)
            {
                energy += 100;
                Console.WriteLine("Dino is restored to 100 and ready to fight!");
            }
            if (robot.health > 20)
            {
                robot.health -= 20;
                Console.WriteLine("Calamity proved devastating.");
            }
            else if (robot.health < 20)
            {
                robot.health -= robot.health;
                Console.WriteLine("Robot has been decomissioned!");
                return false;
            }
            return true;
        }
    }
}
