namespace Patterns.Domain.BuilderPattern;

public interface ICoffeeDirector
{
    Task<string> BuildAmericanoCoffee();
    Task<string> BuildCappuccinoCoffee();
}