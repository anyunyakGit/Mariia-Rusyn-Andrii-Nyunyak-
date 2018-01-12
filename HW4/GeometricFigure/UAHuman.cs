using System;
using System.Collections.Generic;
using System.Text;

namespace Human
{
   public class UAHuman : Person
    {
        public UAHuman (string name)
        {
            Name = name;
            SayHello();
        }
        public override void SayHello()
        {
            Console.WriteLine("Привiт, мене звати : {0} i я Українець", Name);
        }
    }
}
