using System;
using StrategyPattern.Interfaces.SwimBehavior;

namespace StrategyPattern.Behaviors
{
    public class SwimWithFins : ISwimBehavior
    {
        public void Swim() => Console.WriteLine("I'm swimming with fins!");
    }

    public class SwimNoWay : ISwimBehavior
    {
        public void Swim() => Console.WriteLine("I can't swim.");
    }
}
