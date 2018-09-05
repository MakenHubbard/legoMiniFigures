using legoMiniFigures.Heads;
using legoMiniFigures.Torsos;
using legoMiniFigures.Legs;
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
            var babyLegs = new BabyLegs();
            babyLegs.Length = 19;
            babyLegs.MainColor = "purple";
            babyLegs.ShoeColor = "yellow";

            var bestTeacher = new MiniFigure("Nathan",head, reptileBody, babyLegs);

            bestTeacher.Greet();

            var head2 = new MartinHead();
            var birdBody = new BirdTorso();
            ; reptileBody.Color = "pink";
            var manLegs = new Legs.Legs();
            manLegs.Length = 10;
            manLegs.MainColor = "blue";
            manLegs.ShoeColor = "brown";

            var martin = new MiniFigure("Steve", head2, birdBody, manLegs);

            martin.Greet();

            bestTeacher.Karate(martin);

            bestTeacher.TakeABreak();
            martin.TakeABreak();

            Console.ReadLine();
        }
    }
}
