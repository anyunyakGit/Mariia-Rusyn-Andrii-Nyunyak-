using System;
using System.Collections.Generic;
using System.Text;

namespace TV
{
    class Televizor
    {
        int currebntChanel;
        public int CurrebntChanel
        {
            get => currebntChanel;
            set => currebntChanel = value;
        }

        int maxChanel = 55;
        int minChanel = 1;
        public void swtichChanelNext()
        {
            CurrebntChanel++;
            if (CurrebntChanel > maxChanel)
            {
                CurrebntChanel = minChanel;                
            }
            Console.WriteLine("Current chanal is : {0}", CurrebntChanel);
        }

        public void swtichChanelPrevious()
        {
            CurrebntChanel--;
            if (CurrebntChanel < 1)
            {
                CurrebntChanel = maxChanel;
            }
            Console.WriteLine("Chanel channel is : {0}", CurrebntChanel);
        }
        public void ChanalNumber(int chanal)
        {   
           if (chanal > maxChanel || chanal < minChanel)
           Console.WriteLine("Insert correct chanel, current channel is : {0}", CurrebntChanel);
           else
            Console.WriteLine("Current Channel: {0}", CurrebntChanel = chanal);
        }
    }
}
