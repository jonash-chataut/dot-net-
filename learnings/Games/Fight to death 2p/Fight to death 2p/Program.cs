using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Fight_to_death_2p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //name and max of health attack block 
            //this is what the warrior class need to have

            //stats of game
            double health = 1000, attack_max = 120, block_max = 40;
            Console.WriteLine("The power of all warriors are:");
            Console.WriteLine($"Health: {health}\nMax_Attack: {attack_max}\nMax_Block: {block_max}");
            string warrior1, warrior2;
            Console.WriteLine("\nPlayers");
            Console.WriteLine("Warrior 1 ");
            Console.Write("Name: ");
            warrior1=Console.ReadLine();
            Console.WriteLine("Warrior 2 ");
            Console.Write("Name: ");
            warrior2=Console.ReadLine();

            Warrior player_A = new Warrior(warrior1, health, attack_max,block_max);
            Warrior player_B = new Warrior(warrior2,health,attack_max,block_max);

            Battle.StartFight(player_A,player_B);
            Console.ReadLine();
        }
    }
}
