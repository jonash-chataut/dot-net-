using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            pizza per1 = new pizza("Mayonezes","Burger" );

        }
    }

    class pizza
    {
        //string bread, sauce, cheese, topping;
         public pizza(params string[] pizza_items) {
            Console.WriteLine($"Items you wanted in your pizza are: {string.Join(",",pizza_items)}");
                    
        }
    }

}
