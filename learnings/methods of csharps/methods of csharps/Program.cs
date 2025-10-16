using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_of_csharps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers to add: " );
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            getsum(x, y);

            // swapping numbers by ref func concopt
            Console.WriteLine($"Before swapping: {x}, {y}");
            swapp(ref x,ref y);
            Console.WriteLine($"After swapping: {x}, {y}");

            int dd;
            doubleit(x, out dd);// dd bhanne var ma yo func ko out basyo
            Console.WriteLine($"The double of {x} is {dd}");

            //params
            Console.WriteLine($"The sum of 1 2 3 4 5 is {getsummore(1, 2, 3, 4, 5)}");
            Console.WriteLine($"The sum of {x} and {y} twice is {getsummore(x,y,x,y)}");


        }
        // pass by var func
        static void getsum(int x, int y)
        {
            Console.WriteLine($"Sum is: {x+y}");

        }

        // out bhanne ko concept
        static void doubleit (int n, out int solution)
        {
            solution = n * 2;
        }

        // pass by ref
        public static void swapp(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        //params method
        static double getsummore(params int[] nums)
        {
            int sum = 0;
            foreach(int i in nums)
            {
                sum += i;
            }
            return sum;
        }
    }
}
