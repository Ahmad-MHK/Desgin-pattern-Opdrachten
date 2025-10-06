using System;
using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using DecoratorPattern.Stores;

namespace DecoratorPattern.Factories
{
    internal class BeverageFactory : BeverageStore
    {
        public override Beverage CreateBeverage(BeverageType type)
        {
            return type switch
            {
                // Basic beverages
                BeverageType.Espresso => new Espresso(),
                BeverageType.Chocolate => new Chocolate(),
                BeverageType.Water => new Water(),

                // Complex beverages (pre-made combinations)
                BeverageType.Doppio => new Espresso(new Espresso()),
                BeverageType.Lungo => new Water(new Espresso()),
                BeverageType.Macchiato => new MilkFoam(new Espresso()),
                BeverageType.Corretta => new Liqour(new Espresso()),
                BeverageType.ConPanna => new Whip(new Espresso()),
                BeverageType.Cappuccino => new MilkFoam(new SteamedMilk(new Espresso())),
                BeverageType.Americano => new Water(new Water(new Espresso())),
                BeverageType.CaffeLatte => new MilkFoam(new SteamedMilk(new SteamedMilk(new Espresso()))),
                BeverageType.FlatWhite => new SteamedMilk(new SteamedMilk(new Espresso())),
                BeverageType.Romana => new Lemon(new Espresso()),
                BeverageType.Marocchino => new MilkFoam(new Chocolate(new Espresso())),
                BeverageType.Mocha => new Whip(new SteamedMilk(new Chocolate(new Espresso()))),
                BeverageType.Bicerin => new Whip(new WhiteChocolate(new BlackChocolate(new Espresso()))),
                BeverageType.Breve => new HalfMilk(new MilkFoam(new Espresso())),
                BeverageType.RafCoffee => new Cream(new VanillaSugar(new Espresso())),
                BeverageType.MeadRaf => new Cream(new Honey(new Espresso())),
                BeverageType.Galao => new MilkFoam(new MilkFoam(new Espresso())),
                BeverageType.CaffeAffogato => new IceCream(new Espresso()),
                BeverageType.ViennaCoffee => new Whip(new Whip(new Espresso())),
                BeverageType.Glace => new IceCream(new Espresso()),
                BeverageType.ChocolateMilk => new Milk(new Milk(new Chocolate())),
                BeverageType.DemiCreme => new Cream(new Espresso()),
                BeverageType.LatteMacchiato => new MilkFoam(new SteamedMilk(new SteamedMilk(new Espresso()))),
                BeverageType.Freddo => new Ice(new Liqour(new Espresso())),
                BeverageType.Frappuccino => new Whip(new SteamedMilk(new Ice(new Espresso()))),
                BeverageType.CaramelFrappuccino => new Syrup(new Cream(new Whip(new SteamedMilk(new Ice(new Espresso()))))),
                BeverageType.Frappe => new IceCream(new SteamedMilk(new Espresso())),
                BeverageType.IrishCoffee => new Whip(new Whiskey(new Espresso())),
                
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, "Unsupported beverage type")
            };
        }
    }
}
