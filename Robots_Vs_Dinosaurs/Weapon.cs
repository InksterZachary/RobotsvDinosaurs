using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_Vs_Dinosaurs
{
    class Weapon
    {
        //member variables
        
        public string name;
        public string type;
        public int attackPower;

        //constructor
        public Weapon(string name, string type, int attackPower)
        {
            this.name = name;
            this.type = type;
            this.attackPower = attackPower;
        }
        

        //member methods

    }
}
