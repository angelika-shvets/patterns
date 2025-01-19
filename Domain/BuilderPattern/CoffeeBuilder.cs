namespace Patterns.Domain.BuilderPattern;

public class CoffeeBuilder : ICoffeeBuilder
{
    private readonly ICoffee _coffee;

    public CoffeeBuilder(ICoffee coffee)
    {
        // ?? or initialization
        _coffee = coffee;
    }

    public async Task AddCoffeeType()
    {
        await _coffee.Add("Add coffee");
    }

    public async Task AddWater()
    {
        await _coffee.Add("Add water");
    }

    public async Task AddMilk()
    {
        await _coffee.Add("Add milk");
    }

    public async Task<string> BuildCoffee()
    {
        var coffee = await _coffee.GetCoffee();
        await _coffee.Reset();
        return coffee;
    }
}