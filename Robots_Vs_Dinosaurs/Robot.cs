using System;
using System.Collections.Generic;
using System.Data;
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
        public Random random;
        //public List<Action<Dinosaur>> roboAttack;
        

        //constructors
        public Robot(string name, int health, int powerLevel, Weapon weapon)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            this.weapon = weapon;
            
            //roboAttack = new List<Action<Dinosaur>>();
            //RobotAttackList();

        }
        
        //member methods
        //public void RobotAttackList()
        //{
            //roboAttack.Add(LaserBlast);
           // roboAttack.Add(Spray);
           // roboAttack.Add(Devastation);
       // }


        public bool RobotAttack(Dinosaur dinosaur)
        {
            random = new Random();
            int r = random.Next(0, 4);
            switch (r)
            {
                case 0:
                    return LaserBlast(dinosaur);
                    
                case 1:
                    return Spray(dinosaur);
                    
                case 2:
                    return Devastation(dinosaur);
                    
                case 3:
                    return LaserRegen(dinosaur);
                    
            }
            return true;
        }
        public bool LaserBlast(Dinosaur dinosaur) 
        {
            if (powerLevel >= 20)
            {
                powerLevel -= 20;
                Console.WriteLine("Laser blast on target");
            }
            else if(powerLevel < 20)
            {
                powerLevel -= powerLevel;
                Console.WriteLine("Laser blast on target, power levels critical!");
            }
            else if(powerLevel == 0)
            {
                powerLevel += 100;
                Console.WriteLine("Power level restored");
            }
            if(dinosaur.health >= 50)
            {
                dinosaur.health -= 50;
                
            }
            else
            {
                dinosaur.health -= dinosaur.health;
                return false;
            }
            return true;
            //if attack hits dinosaur increase powerlevel by 2
            //if attack misses dinosaur nothing happens
        }
        public bool LaserRegen(Dinosaur dinosaur)
        {
            if (powerLevel >= 20)
            {
                powerLevel -= 20;
            }
            else if (powerLevel < 20)
            {
                powerLevel -= powerLevel;
            }
            else
            {
                powerLevel += 100;
                Console.WriteLine("Power has been increased by 100");
            }
            if(health < 30 && health != 0)
            {
                health += 25;
                Console.WriteLine("Health has been increased by 25!");
                return true;
            }
            else if(health > 30)
            {
                health += 15;
                Console.WriteLine("Health has been increased by 15.");
                return true;
            }
            else
            {
                Console.WriteLine("Dinosaur has been killed and can not be resurrected.");
                return false;
            }
        }
        public bool Spray(Dinosaur dinosaur)
        {
            if (powerLevel >= 20)
            {
                powerLevel -= 20;
                Console.WriteLine("Target successfully hit");
            }
            else if (powerLevel < 20)
            {
                powerLevel -= powerLevel;
                Console.WriteLine("Robot is out of power!");
            }
            else if (powerLevel == 0)
            {
                powerLevel += 100;
                Console.WriteLine("Power levels have been restored to 100");
            }
            if(dinosaur.health >= 75)
            {
                dinosaur.health -= 75;
                return true;
            }
            else
            {
                dinosaur.health -= dinosaur.health;
                Console.WriteLine("Dinosaur has been destroyed!");
                return false;
            }   
        }
        public bool Devastation(Dinosaur dinosaur)
        {
            if (powerLevel > 30)
            {
                powerLevel -= 30;
                Console.WriteLine("Attack was devastating!!");
            }    
            else if(powerLevel < 30)
            {
                powerLevel -= powerLevel;
                Console.WriteLine("Power levels have been depleted..");
            }
            else if(powerLevel == 0)
            {
                powerLevel += 100;
                Console.WriteLine("Power levels have been restored to 100");
            }
            if (dinosaur.health > 80)
            {
                dinosaur.health -= 80;
                return true;
            }
            else 
            {
                dinosaur.health -= dinosaur.health;
                Console.WriteLine("Dino-MITED");
                return false;
            }
           
        }

    }
}
