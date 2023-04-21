using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //Concatenating three strings
            //first, defining the 3 strings
            string name = "David";
            string action = " is reading";
            string what = " a book.\n\n";
            // now concatenating by using the + sign
            string fullSentence = name + action + what;
            // now displaying the outcome
            Console.WriteLine(fullSentence);


            //Converting a string to uppercase
            // making use of the fullSentence variable to turn into uppercase
            string upperSentence = fullSentence.ToUpper();
            // now displaying the outcome
            Console.WriteLine(upperSentence);

            //Creating a StringBuilder and building a paragraph of text, one sentence at a time
            StringBuilder myParagraph = new StringBuilder();
            //now add to this string builder, one sentence at a time
            myParagraph.Append("Charlie and the Chocolate Factory is a story of a very poor boy named Charlie Buket's visit to a chocolate factory.");
            myParagraph.Append(" The chocolate factory belongs to a very rich businessman named Mr. Willy Wonka whose chocolates are famous worldwide.");
            myParagraph.Append(" Mr. Willy Wonka invites five lucky children for a tour around his chocolate factory among which Charlie is one.");
            myParagraph.Append(" Other children are Augustus Gloop, Veruca Salt, Violet Beauregarde and Mike Teavee.");
            myParagraph.Append(" Every child is accompanied by a guardian and Charlie has come with his grandfather Joe.");
            myParagraph.Append(" The following story is a chapter from the book.");
            // now displaying the outcome
            Console.WriteLine(myParagraph);

            Console.ReadLine();
        }
    }
}
