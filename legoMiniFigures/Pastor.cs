using System;
using System.Collections.Generic;
using System.Text;

namespace legoMiniFigures
{
    class Pastor : Person, IGreeter
    { 

        public void Greet(IGreetable person)
        {
            Console.Write($"Hey {person.Name}");
        }

    }

    internal class Person : IGreetable
    {
        public string Name { get; set; }
    }

}
