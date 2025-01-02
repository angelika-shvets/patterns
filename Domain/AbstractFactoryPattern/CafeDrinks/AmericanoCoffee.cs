namespace Patterns.Domain.AbstractFactoryPattern.CafeDrinks;

public class AmericanoCoffee: IAbstractCoffee
{
    public async Task<string> GetCoffeeDescription()
    {
        var description = "An americano is simply just hot water and espresso.";
        return await Task.FromResult(description);
    }
}