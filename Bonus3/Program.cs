using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 101);
            Console.WriteLine(randomNumber);
            int i = 1;
            while (i < 100)
            {
                Console.WriteLine("Guess a number between 1 and 100!");
                int guess = int.Parse(Console.ReadLine());
                while (guess > 100 || guess < 1)
                {
                    Console.WriteLine("You guessed outside of the range! I won't hold that against you. Try again!");
                    guess = int.Parse(Console.ReadLine());
                }

                if (guess - randomNumber >= 10)
                {
                    Console.WriteLine("Way too high!");
                    i++;
                }
                else if (guess - randomNumber < 10 && guess - randomNumber > 0)
                {
                    Console.WriteLine("A little too high!");
                    i++;
                }
                else if (guess - randomNumber < 0 && guess - randomNumber > -10)
                {
                    Console.WriteLine("A little too low!");
                    i++;
                }
                else if (guess - randomNumber <= -10)
                {
                    Console.WriteLine("Way too low!");
                    i++;
                }
                else
                {
                    if (i > 50)
                    {
                        Console.WriteLine($"You did it in {i} tries. You need to work on your guesswork");
                        break;
                    }
                    else if (i <= 50 && i > 25)
                    {
                        Console.WriteLine($"You did it in {i} tries. You can do better next time!");
                        break;
                    }
                    else if (i <= 25 && i > 1)
                    {
                        Console.WriteLine($"You did it in {i} tries. Not bad!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Are you psychic or something?!");
                        break;
                    }
                }
            }

            Console.WriteLine("Would you like to play again? (y/n)");
            string answer = Console.ReadLine();
            while (answer != "y" && answer != "n")
            {
                Console.WriteLine("Sorry I didn't understand that. Try typing 'y' or 'n'");
                answer = Console.ReadLine();
                if (answer == "y" || answer == "n")
                {
                    break;
                }
            }

            if (answer == "n")
            {
                Console.WriteLine("Thanks for playing! Goodbye!");
            }
            else // (answer == "y")
            {
                Main(args);
            }
        }
    }
}
