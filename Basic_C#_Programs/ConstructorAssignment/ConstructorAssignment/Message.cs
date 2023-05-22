using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Message
    {
        string firstName { get; set; }
        string nickName { get; set; }

        //setting up a chaining constructor
        //only one parameter given....the firstname (no nickname)
        public Message(string firstName) : this(firstName, "N/A")
        {
        }
        //2 parameters given: firstname and nickname
        public Message(string firstName, string nickName)
        {
            Console.WriteLine("Your name is " + firstName + " and your nickname is " + nickName + ".");

        }
    }
}
