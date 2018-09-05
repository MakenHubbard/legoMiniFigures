using System;
using System.Collections.Generic;
using System.Text;

namespace legoMiniFigures.Torsos
{
    class ReptilianTorso : Torso
    {
       
        public int NumberOfArms { get; set; }

        public void Dance()
        {
            Console.WriteLine("*BReakdances vigoursly");
        }

        public void Twist()
        {
            Console.WriteLine("A little bit louder now");
        }




    }
}
