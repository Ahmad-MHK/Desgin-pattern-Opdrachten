using System;
using StrategyPattern.Interfaces.QuackBehavior;

namespace StrategyPattern.Behaviors
{
    public class QuackSound : IQuackBehavior
    {
        public void Quack() => Console.WriteLine("Quack!");
    }

    public class MuteQuack : IQuackBehavior
    {
        public void Quack() => Console.WriteLine("<< Silence >>");
    }

    public class Squeak : IQuackBehavior
    {
        public void Quack() => Console.WriteLine("<< Squeak >>");
    }
}
