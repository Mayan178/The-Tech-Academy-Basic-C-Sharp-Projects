using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //setting a constant for our welcome message
            const string welcomeMessage = "Welcome to our friendly page.";

            //writing the welcome message to the Console
            Console.WriteLine(welcomeMessage);
            //ask for the user's first name
            Console.WriteLine("Please, enter your firstname:");
            //set up a variable firstname to store the user answer
            var firstName = Console.ReadLine();
            //ask user if they have a nickname
            Console.WriteLine("Do you have a nickname?: y for yes, n for no.");
            //depending upon answer, set to true or false
            if (Console.ReadLine() == "y")
            {
                bool isNickname = true;
                Console.WriteLine("What is your nickname?");
                var nickName = Console.ReadLine();

                Message myMessage = new Message(firstName, nickName);
            }
            else
            {
                bool isNickname = false;
                Message myMessage = new Message(firstName);
            }
            



            Console.ReadLine();
        }
    }
}
