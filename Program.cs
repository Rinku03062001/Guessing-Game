using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomnumber = random.Next(1, 100);

            int maxAttempts = 5;
            int attempts = 0;

            while (attempts < maxAttempts)
            {
                Console.WriteLine("Enter your guess (1-100) : ");
                int guess = int.Parse(Console.ReadLine());

                if (guess == randomnumber)
                {
                    Console.WriteLine("Congratulations, Guessing Successful!");
                    break;
                }
                else if (guess > randomnumber)
                {
                    Console.WriteLine("Too high, Try Again");
                }
                else
                {
                    Console.WriteLine("Too low, Try Again");
                }
                attempts++;
            }
            if (attempts == maxAttempts)
            {
                Console.WriteLine("Game Over, The correct number is " + randomnumber);
            }
        }
    }
}
