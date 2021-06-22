using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    { 
        public Bird()
        {
        }

        public string TypeOfBeak { get; set; }
        public string PlumageColor { get; set; }
        public bool InFlight { get; set; }


        public void tweetTweet()
        {
            Console.WriteLine("~Tweet tweet!~");
        }
    }
}
