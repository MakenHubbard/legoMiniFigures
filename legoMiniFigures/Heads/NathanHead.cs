using System;
using System.Collections.Generic;
using System.Text;

namespace legoMiniFigures.Heads
{
    class NathanHead : Head
    {
        public override bool HasHair { get { return true; } }
        public string HairColor { get { return "Salt and Peppa"; } }
        public string Texture { get; set; }

        public override void Eat()
        {
            Console.WriteLine("I never get to eat because of needy students");
        }
    }

}
