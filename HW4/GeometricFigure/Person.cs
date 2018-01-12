using System;
using System.Collections.Generic;
using System.Text;

namespace Human
{
    public  abstract class Person
    {
        public  string name;

        public string Name
        {
            get => name;
            set => name = value;
        }
        public abstract void SayHello(); 
        
        
    }
}
