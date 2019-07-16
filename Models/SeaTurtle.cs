using System;

namespace ZanyZoo
{
    public class SeaTurtle : IWalkable, ISwimmable
    {
        public int MaximumDepth { get; } = 100;

        public void Run()
        {
            Console.WriteLine("The sea turtle runs.  Very slowly...");

        }

        public void Walk()
        {
            Console.WriteLine("The sea turtle is now walking.");
        }

        public void Swim()
        {
            Console.WriteLine("The sea turtle swims.  Much faster than it can run!");
        }
    }
}