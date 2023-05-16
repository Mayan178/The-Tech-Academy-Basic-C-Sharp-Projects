using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the Number and set the amount to a specific value
            Number number = new Number();
            number.Amount = 124.45M;
            //printing out to Console
            Console.WriteLine("The amount is " + number.Amount);
            Console.ReadLine();
        }
    }
}
