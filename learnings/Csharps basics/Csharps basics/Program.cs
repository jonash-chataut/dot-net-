using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharps_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
// printing the hello world line 
            //Console.WriteLine("Hello World");
            //giving values to the args from solution exp abd testing 
            //for now given is 1 to 7
            //for (int i=0; i < args.Length; i++)
            //{
            //    Console.WriteLine(args[i]);
            //}
            //sayhola();

// biggest and smallest intergers
            Console.WriteLine("Biggest interger is: {0} \nSmallest interger is: {1}", int.MaxValue,int.MinValue);

        }
        //create a functiom
        private static void sayhola()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}",name);
        }
    }
}
