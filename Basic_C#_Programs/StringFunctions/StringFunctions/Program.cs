using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "The man said, \\Hello\", Jesse. \n Hello on a new line. \n \t Hello on a tab.";
            //// first way of doing it, with escape characters
            //string filename = "C:\\Users\\Jesse";
            //// second way of doing it, using the @ sign
            //string newfilename = @"C:\Users\Jesse";

            //bool trueorfalse = name.Contains("s");
            //trueorfalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();

            //name = name.ToLower();


            //Console.WriteLine(name);

            //string name = "Jesse";
            //name = "Joe";

            //using stringbuilder
            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jesse");

            Console.WriteLine(sb);
            
            Console.ReadLine();
        }
    }
}
