namespace Patterns.Domain.AbstractFactoryPattern;

public interface IAbstractFactory
{
    IAbstractCoffee CreateCoffee();
    IAbstractTea CreateTea();
}