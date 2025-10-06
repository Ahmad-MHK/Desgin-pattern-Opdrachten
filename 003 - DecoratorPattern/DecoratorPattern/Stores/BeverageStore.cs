using DecoratorPattern.Beverages;
using DecoratorPattern.Factories;

namespace DecoratorPattern.Stores
{
    internal abstract class BeverageStore 
    {
        public Beverage Order(BeverageType type, Size size = Size.TALL)
        {
            var beverage = CreateBeverage(type);
            beverage.Size = size;
            PrintBeverage(beverage);
            return beverage;
        }

        // Factory Method to be implemented by concrete stores
        public abstract Beverage CreateBeverage(BeverageType type);
        void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine($"{beverage.GetDescription()} ({beverage.Size}) ${beverage.cost():#.##}");
        }
    }
}
