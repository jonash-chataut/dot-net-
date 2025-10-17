using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_to_death_2p
{
    class Warrior
    {
        // Define the Warriors properties
        public string Name { get; set; } = "Warrior";
        public double Health { get; set; } = 0;
        public double AttackMax { get; set; } = 0;
        public double BlockMax {get; set; } = 0;

        // Always create a single Random instance and reuse
        // it or you will get the same value over and over
        Random rnd = new Random();

        // Constructor initializes the warrior
        public Warrior(string name, double health, double attackmax, double blockmax)
        {
            Name = name;
            Health = health;
            AttackMax = attackmax;
            BlockMax = blockmax;
        }

        // Generate a random atack value from 1
        // to the warriors maximum attack value
        public double Attack()
        {
            return rnd.Next(1, (int)AttackMax);
        }
        // Generate a random block value from
        // 1 to the warriors maximum block
        public double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }
    }
}
