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
        public string weapon;

        //constructors
        public Robot(string name, int health, int powerLevel, string weapon)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            this.weapon = weapon;
        }
        //member methods


    }
}
