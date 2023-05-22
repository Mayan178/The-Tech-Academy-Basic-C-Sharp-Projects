using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//for file usage
//using System.IO;
//referring to the Casino library
using Casino;
using Casino.TwentyOne;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime yearofBirth = new DateTime(2005, 01, 01, 05, 31, 05);
            //DateTime yearofGraduation = new DateTime(2023, 06, 01, 15, 31, 05);

            //TimeSpan ageAtGraduation = yearofGraduation - yearofBirth;
            //TimeSpan ageAtGraduation = yearofGraduation - yearofBirth;

            //string text = "Here is some text.";
            //File.WriteAllText(@"C:\Users\LENOVO-THINKPAD-T430\test_log.txt", text);

            //creating a constant
            const string casinoName = "Grand Hotel and Casino";
            

            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.",casinoName);
            string playername = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            { 
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }
            
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playername);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playername, bank);
                //setting up unique identifier for the player
                player.Id = Guid.NewGuid();
                //logging the Id
                using (StreamWriter file = new StreamWriter(@"C:\Users\LENOVO-THINKPAD-T430\test_log.txt", true))
                {
                    file.WriteLine(player.Id);
                }

                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;

                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException)
                    {
                        Console.WriteLine("Security! Kick this person out!");
                        Console.ReadLine();
                        //stops right here!
                        return;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occurred. Please, contact your System Administrator.");
                        Console.ReadLine();
                        //stops right here!
                        return;
                    }
                    
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
        }

      
    }
}
