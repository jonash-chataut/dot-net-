using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int max = 100;
            int min = 1;
            int guess;
            int number;
            int no_guesses;
            string response;
            bool playagain = true;

            while (playagain)
            {
                no_guesses = 0;
                guess = 0;
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.Write("Guess a number between " + min + " - " + max +" -> " );
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess = " + guess);
                    if (guess > number)
                    {
                        Console.WriteLine("Try smaller number :( ");
                    }

                    else if (guess < number) 
                    {
                        Console.WriteLine("Try greater number :( ");
                    }

                    no_guesses++;


                }
                Console.WriteLine("You guessed it :)");
                Console.WriteLine("Number to guess = " + number);
                Console.WriteLine("No. of guesses = " + no_guesses);
                Console.Write("You want to play again (Y/N) -> ");
                response = Console.ReadLine();
                response.ToUpper();
                if (response == "Y")
                {
                    playagain = true;
                }
                else
                {
                    playagain = false;
                }
            }

            Console.WriteLine("Thanks for playing......");
            Console.WriteLine("Hope you enjoyed :)");
        }
    }
}
