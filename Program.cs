    using System;

namespace Bruner_Zach_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates a new greeting object called greetings
            Greetings greetings = new Greetings();
            // Calls the welcome method on the greetings
            greetings.Welcome();
            
            // Puts What is your name squire into the command prompt
            Console.WriteLine("What is your name squire?");
            // gets input from user
            string userName = Console.ReadLine();
            // Calls the Hello users method and passes the UserName
            greetings.Hello(userName);
        }
    }
}
