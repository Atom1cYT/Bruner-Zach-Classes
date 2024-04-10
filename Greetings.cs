    using System;
using System.Collections.Generic;
using System.Text;

namespace Bruner_Zach_Classes
{
    internal class Greetings
    {

        public void Welcome()
            // Says Hello username welcome
        {
            Console.WriteLine("Hello Travler, welcome!");
        }

        public void Hello(string name)
            // Passes through saying Thank you for joining us
        {
            Console.WriteLine($"{name}, thank you for joining us today!");
        }

    }
}