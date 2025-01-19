
using Patterns.Domain.DecoratorPattern;

namespace Patterns.Domain;

public class CoffeeDescription : ICoffeeDescription
{
    private readonly List<object> _compound;

    public CoffeeDescription()
    {
        _compound = new List<object>();
    }
    
    public Task<string> GetCoffeeDescription()
    {
        var description = "some coffee basic description";
        
        return Task.FromResult(description);
    }
}