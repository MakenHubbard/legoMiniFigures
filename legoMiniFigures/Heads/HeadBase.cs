using System;

namespace legoMiniFigures.Heads
{
    abstract class Head
    {
        public abstract bool HasHair { get; }

        public  virtual void Talk()
        {
            Console.WriteLine("Im a talking head");
        }

        public abstract void Eat();
    }

}
