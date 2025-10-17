using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fight_to_death_2p
{
    class Battle
    {
        // This is a utility class so it makes sense
        // to have just static methods

        // Recieve both Warrior objects
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            // Loop giving each Warrior a chance to attack
            // and block each turn until 1 dies
                while (true)
            {
                if (GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    Console.WriteLine($"Game scores:" +
                        $"\n{warrior1.Name}: {warrior1.Health} Health" +
                        $"\n{warrior2.Name}: {warrior2.Health} Health");
                    break;
                }
                if (GetAttackResult(warrior2,warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    Console.WriteLine($"Game scores:" +
                       $"\n{warrior1.Name}: {warrior1.Health} Health" +
                       $"\n{warrior2.Name}: {warrior2.Health} Health");
                    break;
                }
            }
        }

        // Accept 2 Warriors
        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            // Calculate one Warriors attack and the others block
            double warAttkAmt_A = warriorA.Attack();
            double warBlkAmt_B = warriorB.Block();

            // Subtract block from attack
            double dmg2B = warAttkAmt_A - warBlkAmt_B;

            // If there was damage subtract that from the health
            if (dmg2B > 0)
            {
                warriorB.Health = warriorB.Health - dmg2B;
            }
            else dmg2B = 0;

            // Print out info on who attacked who and for how
            Console.WriteLine($"{warriorA.Name} attacks on {warriorB.Name} and deals {dmg2B} damage");
            // Provide output on the change to health
            Console.WriteLine($"{warriorB.Name} has {warriorB.Health} Health");

            // Check if the warriors health fell below
            // zero and if so print a message and send
            // a response that will end the loop
            if (warriorB.Health <= 0)
            {
                Console.WriteLine($"{warriorB.Name} is dead and {warriorA.Name} is the winner");
                return "Game Over";

            }
            else return "Fight Again";
        }
    }
}
