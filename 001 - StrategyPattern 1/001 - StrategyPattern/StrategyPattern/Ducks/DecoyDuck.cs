using StrategyPattern.Interfaces.FlyBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Behaviors;

namespace StrategyPattern.Ducks
{
    internal class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            FlyBehaviors = new FlyNoWay();
            QuackBehaviors = new MuteQuack();
            SwimBehaviors = new SwimNoWay();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Decoy Duck");
        }
        
    }
}
