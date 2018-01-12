using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentClass studentClass = new StudentClass("andriy", "Nyunyak");
            StudentClass studentClass1 = new StudentClass("andffdsafasdfriy", "Nyunfsdfsdafasdfayak",2);
            StudentClass studentClass2 = new StudentClass("fsadfasdfasd", "Nyfdsaffdsfasdfunyak",3,1,100,100,100);
            StudentClass studentClass3 = new StudentClass("andriy", "Nyunyak", 4,72,86,50,89);

            Console.ReadLine();
        }

    }
}
