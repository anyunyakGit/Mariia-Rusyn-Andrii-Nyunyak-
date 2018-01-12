using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    class StudentClass
    {
         string studentName;
         string lastName;
         int cource;
        int mark;
         bool stependiya;
     
        
        public StudentClass (string name, string secondName)
        {
            this.studentName = name;
            this.lastName = secondName;

            Console.WriteLine("Name is : {0}, Last name is : {1}", name, secondName);
        }

        public StudentClass (string name, string secondName, int studentCource)
        {
            this.studentName = name;
            this.lastName = secondName;
            this.cource = studentCource;

            Console.WriteLine("Name is : {0}, Last name is : {1}, student is on : {2} course", name, secondName, studentCource);
        }

        public StudentClass(string name, string secondName, int studentCource, int ocinka1, int ocinka2, int ocinka4, int ocinka3)
        {
            this.studentName = name;
            this.lastName = secondName;
            this.cource = studentCource;


           
            this.mark = ((ocinka1 + ocinka2 + ocinka3 + ocinka4) / 4);


            if (mark > 72 )
            {
                stependiya = true;
            }
            else
            {
                stependiya = false;
            }
            Console.WriteLine("Name is : {0}, Last name is : {1}, student is on : {2} course, and stependia is : {3}", name, secondName, studentCource, stependiya);
        }
    }
}
