using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            if (yourName != "John")
            {
                Console.WriteLine("You are not John");
            }

            else
            {
                Console.WriteLine("Welcome back John!");
            }

            Console.ReadLine();

        }
    }
}
