using System;

namespace TV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pess volume you would like to set on the console ");
            int button = 0;
            VolumeClass volumeClass = new VolumeClass();

            while (button != 666)
            {
                button = Convert.ToInt32(Console.ReadLine());

                if (button == 1)
                {
                     volumeClass.swtichVolUp();
                }
                else if (button == 0)
                {
                    volumeClass.swtichVolLow();
                }
                else
                {
                    volumeClass.Vol(button);
                }

            }
        }
    }
}
