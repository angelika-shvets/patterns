namespace Patterns.Domain.AbstractFactoryPattern;

public interface IAbstractCoffee
{
    Task<string> GetCoffeeDescription();
}