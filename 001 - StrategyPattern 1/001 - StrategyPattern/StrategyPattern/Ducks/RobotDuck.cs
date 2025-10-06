
using System;
using StrategyPattern.Behaviors;

namespace StrategyPattern.Ducks
{
    internal class RobotDuck : Duck
    {
        public RobotDuck()
        {
            QuackBehaviors = new MuteQuack();
            FlyBehaviors = new FlyNoWay();
            SwimBehaviors = new SwimNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Robot Duck");
        }
    }
}
