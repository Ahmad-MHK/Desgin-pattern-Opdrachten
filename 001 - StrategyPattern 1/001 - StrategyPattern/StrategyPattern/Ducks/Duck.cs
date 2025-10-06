using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    internal abstract class Duck
    {
        protected IFlyBehavior? FlyBehaviors;
        protected IQuackBehavior? QuackBehaviors;
        protected ISwimBehavior? SwimBehaviors;

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            FlyBehaviors = flyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            QuackBehaviors = quackBehavior;
        }


        public abstract void Display();

        public void PerformQuack()
        {
            QuackBehaviors?.Quack();
            FlyBehaviors?.Fly();
            SwimBehaviors?.Swim();
        }

        public void PerformFly()
        {
            FlyBehaviors?.Fly();
        }
        
        public void PerformSwim()
        {
            SwimBehaviors?.Swim();
        }
    }
}
