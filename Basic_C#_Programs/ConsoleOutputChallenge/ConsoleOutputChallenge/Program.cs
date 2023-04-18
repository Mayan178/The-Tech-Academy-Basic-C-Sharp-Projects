using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOutputChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //using greater than operator
            Console.WriteLine("How old are you?");
            int yourAge = Convert.ToInt32(Console.ReadLine());

            if (yourAge > 17)
                {
                Console.WriteLine("You are old enough to drive!");
                }

            //using lesser than operator
            if (yourAge < 18)
                {
                Console.WriteLine("You are not old enough to drive!");
                }

            Console.ReadLine();
        }
    }
}
