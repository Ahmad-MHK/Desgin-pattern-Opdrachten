using System;
using StrategyPattern.Behaviors;

namespace StrategyPattern.Ducks
{
    internal class RubberDuck : Duck
    {
        public RubberDuck()
        {
            QuackBehaviors = new Squeak();
            FlyBehaviors = new FlyNoWay();
            SwimBehaviors = new SwimNoWay();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Rubber Duck");
            PerformFly();
            PerformQuack();
            PerformSwim();
        }
    }
}
