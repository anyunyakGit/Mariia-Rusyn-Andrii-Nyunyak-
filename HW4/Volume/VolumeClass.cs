using System;
using System.Collections.Generic;
using System.Text;

namespace TV
{
    class VolumeClass
    {
        int сurrentVolume;

        public int CurrentVolume
        {
            get => сurrentVolume;
            set => сurrentVolume = value;
        }
        int maxVol = 100;
        int minVol = 1;
        public void swtichVolUp()
        {
            CurrentVolume++;
            if (CurrentVolume > maxVol)
            {
                CurrentVolume = minVol;
            }
            Console.WriteLine("Current volume is : {0}", сurrentVolume);
        }

        public void swtichVolLow()
        {
            CurrentVolume--;
            if (CurrentVolume < 1)
            {
                CurrentVolume = maxVol;
            }
            Console.WriteLine("Chanel channel is : {0}", сurrentVolume);
        }
        public void Vol(int vol)
        {
            if (vol > maxVol || vol < minVol)
                Console.WriteLine("Insert correct volume value, current volume is : {0}", CurrentVolume);
            else
                Console.WriteLine("Current volume: {0}", CurrentVolume = vol);
        }
    }
}
