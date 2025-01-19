namespace Patterns.Domain.DecoratorPattern;

public class CappuccinoDecorator: ICoffeeDescription
{
    private readonly ICoffeeDescription _coffee;
    
    public CappuccinoDecorator(ICoffeeDescription coffee)
    {
        _coffee = coffee;
    }
    
    public async Task<string> GetCoffeeDescription()
    {
        var description = await _coffee.GetCoffeeDescription();
        
        description = $"{description} some additional Cappuccino description";

        return description;
    }
}