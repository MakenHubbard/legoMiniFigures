using legoMiniFigures.Heads;
using legoMiniFigures.Torsos;
using System;

namespace legoMiniFigures
{
    class MiniFigure
    {
        private readonly Head _head;
        private readonly Torso _torso;

        public MiniFigure(Head head, Torso torso)
        {
            _head = head;
            _torso = torso;
        }

        public void DoStuff()
        {
            _head.Talk();
            _head.Eat();
        }

        public void Greet()
        {
            _head.Talk();

        }

        public void TakeABreak()
        {
            _head.Eat();
            //var birdTorso = _torso as BirdTorso;
            //if (birdTorso != null)
            //{
            //    birdTorso.Fly();
            //}

            //if (_torso is BirdTorso)
            //{
            //    var birdTorso = (BirdTorso)_torso;
            //    birdTorso.Fly();
            //    birdTorso.Dance();
            //    birdTorso.Fly();
           // }
            //else (_torso is ReptilianTorso) {
             //   var reptilianTorso = (ReptilianTorso)_torso;
             //   reptilianTorso.Dance();
            //}

            switch(_torso)
            {
                case BirdTorso bird:
                    bird.Fly();
                    bird.Dance();
                    bird.Fly();
                    break;
                case ReptilianTorso reptile:
                    reptile.Dance();
                    break;
                case Torso boringTorso:
                    Console.WriteLine($@"the boring torso was {boringTorso.Color} and has {boringTorso.NumberOfArms} arms");
                    break;
                
            }
        }
    }
}
