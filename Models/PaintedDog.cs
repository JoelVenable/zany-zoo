using System;

namespace ZanyZoo
{
    public class PaintedDog : IWalkable
    {
        public void Run()
        {
            Console.WriteLine("Animal is now running.");
        }

        public void Walk()
        {
            Console.WriteLine("Animal is now walking...");
        }
    }

}

