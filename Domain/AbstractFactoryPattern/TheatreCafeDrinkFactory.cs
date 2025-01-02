using Patterns.Domain.AbstractFactoryPattern.CafeDrinks;

namespace Patterns.Domain.AbstractFactoryPattern;

public class TheatreCafeDrinkFactory: IAbstractFactory
{
    public IAbstractCoffee CreateCoffee()
    {
        return new CappuccinoCoffee();
    }

    public IAbstractTea CreateTea()
    {
        return new GreenTea();
    }
}