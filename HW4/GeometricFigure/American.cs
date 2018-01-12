using System;
using System.Collections.Generic;
using System.Text;

namespace Human
{
    public class American : Person
    {
        public American(string name)
        {
            Name = name;
            SayHello();
        }
        public override void SayHello()
        {
            Console.WriteLine("Hello, my name is : {0}, and i'm American. ", Name);
        }
    }
}
