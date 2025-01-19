namespace Patterns.Domain.DecoratorPattern;

public interface ICoffeeDescription
{
    Task<string> GetCoffeeDescription();
}