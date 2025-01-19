namespace Patterns.Domain.BuilderPattern;

public interface ICoffeeBuilder
{
    Task AddCoffeeType();
    Task AddWater();
    Task AddMilk();
    Task<string> BuildCoffee();
}