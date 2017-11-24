using System;

namespace BuzzFizz.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a program that prints to the console the numbers from 1 to 100
             * But for multiples of three print "Buzz" instead of the number 
             * and for the multiples of five print "Fizz".
             * For numbers which are multiples of both three and five print "BuzzFizz"
             */
            for (var i = 1; i <= 100; i++)
            {
                Console.WriteLine(BuzzFizz.GetStringOutput(i));
            }

            Console.WriteLine("Press enter to quit...");
            Console.ReadLine();
        }
    }
}
