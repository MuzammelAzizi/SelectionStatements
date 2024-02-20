using System;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to numbers magic game");
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine("try to guess my fav number to win a price");
            var userInput = int.Parse(Console.ReadLine());


            if (userInput < favNumber)
            {
                Console.WriteLine($"{userInput} too low");
            }
            else if(userInput > favNumber)

            {
                Console.WriteLine($"{userInput} too high");
            }
            else 
            {
                 Console.WriteLine($"{userInput} you guest it");
            }
        }
    }
}
