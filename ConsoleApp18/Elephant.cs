﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Elephant
    {
       public int EarSize;
       public string Name;
        public void WhoAmI()
        {
            Console.WriteLine($"My name is {Name}");
            Console.WriteLine($"My earsize is {EarSize}");
        }
        public void HearMessage(string message, Elephant whoSaidIt)
        {
            Console.WriteLine(Name + " heard a message");
            Console.WriteLine(whoSaidIt.Name + " said this: " + message);
        }
        public void SpeakTo(Elephant whoToTalkTo, string message)
        {
            whoToTalkTo.HearMessage(message, this);
        }
    }
}
