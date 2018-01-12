using System;

namespace TV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pess button on the console ");
            int button = 0;
            Televizor televizor = new Televizor();
            
            while (button != 666)
            {
                button = Convert.ToInt32(Console.ReadLine());
               
                if (button == 1)
                {
                    televizor.swtichChanelNext();
                }
                else if (button == 0)
                {
                    televizor.swtichChanelPrevious();
                }
                else 
                {
                    televizor.ChanalNumber(button);
                }
                
            }
        }
    }
}
