using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// in order to be able to log to a text file, we need to add the following
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //asking the user to input a number
            Console.WriteLine("Please, enter a number:");
            //putting code within a try and catch block, to make sure the user enters a number
            try
            {
                //setting userNumber as number entered by the user
                string userNumberastext = Console.ReadLine();
                int userNumber = Convert.ToInt32(userNumberastext);
                
                //printing that number to a text file
                File.WriteAllText(@"C:\Users\jeff\testlog.txt", userNumberastext);
                //printing text file back to the user. First, reading the content of the file
                using (StreamReader file = new StreamReader(@"C:\Users\jeff\testlog.txt"))
                {
                    string linetext;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((linetext = file.ReadLine()) != null)
                    {
                        Console.WriteLine("You typed in: " + linetext);
                    }
                }
            }

            catch (Exception ex)
            {
                //show the user what went wrong
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
            
        }
    }
}
