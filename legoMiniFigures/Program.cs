using legoMiniFigures.Heads;
using legoMiniFigures.Torsos;
using System;

namespace legoMiniFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new NathanHead();
            var reptileBody = new ReptilianTorso();
;            reptileBody.Color = "Brown";

            var figure = new MiniFigure(head, reptileBody);

            figure.Greet();
            figure.TakeABreak();

            Console.ReadLine();
        }
    }
}
