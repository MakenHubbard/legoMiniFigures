using System;

namespace legoMiniFigures.Heads
{
    abstract class Head
    {
        public abstract bool HasHair { get; }

        public  virtual void Talk(IGreetable greetable)
        {
            Console.WriteLine($"Im a talking head, {greetable.Name}");
        }

        public abstract void Eat();
    }

}
