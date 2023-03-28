using System;

    class Program
    {
        static void Main()
        {

        //Printing the first couple of lines
        Console.WriteLine("Academy of Learning Career College\nStudent Daily Report");
        Console.ReadLine();

        //Asking the first question
        Console.WriteLine("A. What is your name?");
        //setting yourName variable as a string to hold user input
        string yourName = Console.ReadLine();

        //Asking the second question
        Console.WriteLine("B. What course are you on?");
        //setting yourCourse variable as a string to hold user input
        string yourCourse = Console.ReadLine();

        //Asking the third question
        Console.WriteLine("C. What page number?");
        //setting pageNumber variable as a string to hold user input
        string pageNumber = Console.ReadLine();
        //now casting the pageNumber to an int
        int pNum = Convert.ToInt32(pageNumber);

        //Asking the forth question
        Console.WriteLine("D. Do you need help with anything? Please answer \"true\" or \"false\"");
        //setting help variable as a string to hold user input
        string help = Console.ReadLine();
        //now converting to a true or false value
        bool needhelp = Convert.ToBoolean(help);

        //Asking the fifth question
        Console.WriteLine("E. Were there any positive experiences you’d like to share? Please give specifics.");
        //setting yourExperience variable as a string to hold user input
        string yourExperience = Console.ReadLine();

        //Asking the sixth question
        Console.WriteLine("F. Is there any other feedback you’d like to provide? Please be specific.");
        //setting yourFeedback variable as a string to hold user input
        string yourFeedback = Console.ReadLine();

        //Asking the seventh question
        Console.WriteLine("G. How many hours did you study today?");
        //setting hoursStudied variable as a string to hold user input
        string hoursStudied = Console.ReadLine();
        //now casting the hoursStudied to an int
        int hStudied = Convert.ToInt32(hoursStudied);

        //reaching the end of the questions, display message
        Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
        Console.ReadLine();

    }
}

