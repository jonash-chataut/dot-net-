using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hey, " + name);
            Console.WriteLine("Enter the number of tangaries you want to have: ");
            string tan = Console.ReadLine();
            Console.WriteLine("Since for the series i am giving you 7 more thala for a reason i.e " + (Convert.ToInt32(tan) + 7));

        }
    }
}
