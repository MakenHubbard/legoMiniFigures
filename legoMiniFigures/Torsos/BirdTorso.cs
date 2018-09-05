using System;
using System.Collections.Generic;
using System.Text;

namespace legoMiniFigures.Torsos
{
    class BirdTorso : ReptilianTorso
    {
        
        public bool CanFly { get; set; }

        public void Fly()
        {
            if (CanFly)
            {
                Console.WriteLine("I believe I can Fly ...");
            }
            else
            {
                Console.WriteLine("I am a Flightless bird.");
            }
        }


    }

}
