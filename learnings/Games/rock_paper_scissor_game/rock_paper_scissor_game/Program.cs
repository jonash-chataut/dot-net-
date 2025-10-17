using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissor_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int computer_response;
            string user_response;
            bool playagain = true;
            string yes_no;

            while (playagain)
            {
                Console.Write("<----- Enter your choice ----->\nRock, paper or scissor ->");
                user_response = Console.ReadLine();
                user_response = user_response.ToUpper();
                computer_response = rnd.Next(0, 3);
                // 0 -> Rock, 1 -> Paper, 2 -> Scissor
                if (user_response == "ROCK" && computer_response==0)
                {
                    Console.WriteLine("Computer choosed -> Rock \nIt is a Draw \n:(");
                    
                }
                else if (user_response == "PAPER" && computer_response == 0)
                {
                    Console.WriteLine("Computer choosed -> Rock \nYou won !!! \n:)");

                }

                else if (user_response == "SCISSOR" && computer_response == 0)
                {
                    Console.WriteLine("Computer choosed -> Rock \nComputer won !!! \n:(");

                }

                else if (user_response == "ROCK" && computer_response == 1)
                {
                    Console.WriteLine("Computer choosed -> Paper \nComputer won !!! \n:(");

                }
                else if (user_response == "PAPER" && computer_response == 1)
                {
                    Console.WriteLine("Computer choosed -> Paper \n It is a Draw \n:(");

                }
                else if (user_response == "SCISSOR" && computer_response == 1)
                {
                    Console.WriteLine("Computer choosed -> Paper \nYou won !!! \n:)");

                }
                else if (user_response == "ROCK" && computer_response == 2)
                {
                    Console.WriteLine("Computer choosed -> Scissor \nYou won !!! \n:)");

                }
                else if (user_response == "PAPER" && computer_response == 2)
                {
                    Console.WriteLine("Computer choosed -> Scissor \nCPU won !!! \n:(");

                }
                else if (user_response == "SCISSOR" && computer_response == 2)
                {
                    Console.WriteLine("Computer choosed -> Scissor \nIt is a Draw!!! \n:(");

                }
                else
                {
                    Console.WriteLine("Error !!!!\n Sorryyyyyy..... Try again");
                }

                Console.Write("Do you wana play again (Y/N) ->");
                yes_no = Console.ReadLine();
                _ = yes_no.ToLower();
                if (yes_no == "y")
                {
                    playagain = true;
                }

                else
                {
                    playagain = false;
                }


            }
            Console.WriteLine("Thanks for playing.........");
        }
    }
}
