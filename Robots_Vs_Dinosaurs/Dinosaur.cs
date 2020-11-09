using System;

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


    }
}
