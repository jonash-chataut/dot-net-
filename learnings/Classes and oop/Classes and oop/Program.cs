using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a rectangle obj
            rectangle rect1;
            rect1.length = 10;
            rect1.width = 200;
            rect1.display();

            //Calling constructor
            rectangle rect2 = new rectangle(500, 450);
            rect2.display();

            //animal class 
            Animals cat = new Animals("Cat", "Meow");
            cat.makesound();

            Animals no_animal = new Animals();
            no_animal.makesound();
           

        }
        // ----- STRUCTS -----
        // A struct is a user defined type that
        // contain multiple fields and methods
        struct rectangle
        {
            public double length;
            public double width;

            //constructor
            public rectangle(int l=1, int w=1)
            {
                length = l;
                width = w;
            }
             public void display()
            {
                Console.WriteLine($"L={length} and W={width}");
            }
        }
    }
}
