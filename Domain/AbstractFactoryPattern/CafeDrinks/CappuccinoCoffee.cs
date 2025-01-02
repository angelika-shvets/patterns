namespace Patterns.Domain.AbstractFactoryPattern.CafeDrinks;

public class CappuccinoCoffee: IAbstractCoffee
{
    public Task<string> GetCoffeeDescription()
    {
        var description = "A cappuccino is the perfect balance of espresso, steamed milk and foam.";
        
        return Task.FromResult(description);
    }
}