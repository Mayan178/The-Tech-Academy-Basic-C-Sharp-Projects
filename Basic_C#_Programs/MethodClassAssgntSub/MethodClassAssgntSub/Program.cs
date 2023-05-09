using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssgntSub
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the method passing through 2 numbers
            MathsOps.TakeAwaySixty(10, 20);
            //now calling the same method specifying the parameters by name
            MathsOps.TakeAwaySixty(numberOne: 100, numberTwo: 200);
            // this stops the console from closing and enables us to see the text 
           Console.ReadLine();
        }
    }
}
