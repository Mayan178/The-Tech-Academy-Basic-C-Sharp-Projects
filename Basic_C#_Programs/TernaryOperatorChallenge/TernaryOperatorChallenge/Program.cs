using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperatorChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your name");
            string yourName = Console.ReadLine();

            string yourResult = yourName == "David" ? "Your name is David" : "Your name is not David. It is " + yourName;
            Console.WriteLine(yourResult);
            Console.ReadLine();
        }
    }
}
