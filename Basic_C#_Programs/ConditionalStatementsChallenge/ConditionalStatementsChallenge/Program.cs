using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //asking for user to input their age
            Console.WriteLine("How old are you?");
            //saving user input as yourAge variable
            int yourAge = Convert.ToInt32(Console.ReadLine());

            //now checking against different age groups to work out whether the user is a child, a teenager or an adult
            if (yourAge < 13)
                { 
                Console.WriteLine("You are a child!"); 
                }
            else if (yourAge >= 13 && yourAge <= 19)
                { 
                Console.WriteLine("You are a teenager!"); 
                }

            else
                { 
                Console.WriteLine("You are an adult"); 
                }

            Console.ReadLine();
        }
    }
}
