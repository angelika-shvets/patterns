namespace Patterns.Domain.BuilderPattern;

public class CoffeeDirector:ICoffeeDirector
{
    private readonly ICoffeeBuilder _coffeeBuilder;
    
    public CoffeeDirector(ICoffeeBuilder coffeeBuilder)
    {
        _coffeeBuilder = coffeeBuilder;
    }

    public async Task<string> BuildAmericanoCoffee()
    {
        await _coffeeBuilder.AddCoffeeType();
        await _coffeeBuilder.AddWater();
        return await _coffeeBuilder.BuildCoffee();
    }

    public async Task<string> BuildCappuccinoCoffee()
    {
        await _coffeeBuilder.AddCoffeeType();
        await _coffeeBuilder.AddWater();
        await _coffeeBuilder.AddMilk();
        return await _coffeeBuilder.BuildCoffee();
    }
}