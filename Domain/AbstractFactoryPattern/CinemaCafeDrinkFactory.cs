using Patterns.Domain.AbstractFactoryPattern.CafeDrinks;

namespace Patterns.Domain.AbstractFactoryPattern;

public class CinemaCafeDrinkFactory: IAbstractFactory
{
    public IAbstractCoffee CreateCoffee()
    {
        return new AmericanoCoffee();
    }

    public IAbstractTea CreateTea()
    {
        return new BlackTea();
    }
}