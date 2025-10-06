using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using DecoratorPattern.Factories;
using DecoratorPattern.Stores;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BeverageStore factory = new BeverageFactory();

            // Espresso
            Beverage espresso = factory.Order(BeverageType.Espresso, Size.GRANDE);

            // Doppio
            Beverage doppio = factory.Order(BeverageType.Doppio, Size.GRANDE);

            // Lungo
            Beverage lungo = factory.Order(BeverageType.Lungo, Size.TALL);

            // Macchiato
            Beverage macchiato = factory.Order(BeverageType.Macchiato, Size.VENDI);

            // Corretta
            Beverage corretta = factory.Order(BeverageType.Corretta);

            // Con Panna
            Beverage conPanna = factory.Order(BeverageType.ConPanna, Size.VENDI);

            // Cappuccino
            Beverage cappuccino = factory.Order(BeverageType.Cappuccino, Size.GRANDE);

            // Americano
            Beverage americano = factory.Order(BeverageType.Americano, Size.VENDI);

            // Caffe Latte
            Beverage caffeLatte = factory.Order(BeverageType.CaffeLatte);

            // Flat White
            Beverage flatWhite = factory.Order(BeverageType.FlatWhite, Size.GRANDE);

            // Romana
            Beverage romana = factory.Order(BeverageType.Romana, Size.VENDI);

            // Marocchino
            Beverage marocchino = factory.Order(BeverageType.Marocchino);

            // Mocha
            Beverage mocha = factory.Order(BeverageType.Mocha, Size.GRANDE);

            // Bicerin
            Beverage bicerin = factory.Order(BeverageType.Bicerin, Size.VENDI);

            // Breve
            Beverage breve = factory.Order(BeverageType.Breve);

            // Raf coffee
            Beverage rafCoffee = factory.Order(BeverageType.RafCoffee, Size.GRANDE);

            // Mead raf
            Beverage meadRaf = factory.Order(BeverageType.MeadRaf, Size.VENDI);

            // Galao
            Beverage galao = factory.Order(BeverageType.Galao);

            // Caffe affogato
            Beverage caffeAffogato = factory.Order(BeverageType.CaffeAffogato, Size.GRANDE);

            // Vienna coffee
            Beverage viennaCoffee = factory.Order(BeverageType.ViennaCoffee);

            // Glace
            Beverage glace = factory.Order(BeverageType.Glace, Size.GRANDE);

            // Chocolate milk
            Beverage chocolateMilk = factory.Order(BeverageType.ChocolateMilk, Size.VENDI);

            // Demi - creme
            Beverage demiCreme = factory.Order(BeverageType.DemiCreme);

            // Latte macchiato
            Beverage latteMacchiato = factory.Order(BeverageType.LatteMacchiato, Size.GRANDE);

            // Freddo
            Beverage freddo = factory.Order(BeverageType.Freddo, Size.VENDI);

            // Frappuccino
            Beverage frappuccino = factory.Order(BeverageType.Frappuccino, Size.GRANDE);

            // Caramel frappuccino
            Beverage caramelFrappuccino = factory.Order(BeverageType.CaramelFrappuccino);

            // Frappe
            Beverage frappe = factory.Order(BeverageType.Frappe, Size.VENDI);

            // Irish Coffee
            Beverage irishCoffee = factory.Order(BeverageType.IrishCoffee, Size.VENDI);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine($"{beverage.GetDescription()} ({beverage.Size}) ${beverage.cost():#.##}");
        }
    }
}
