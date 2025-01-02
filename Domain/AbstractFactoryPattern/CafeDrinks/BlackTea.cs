namespace Patterns.Domain.AbstractFactoryPattern.CafeDrinks;

public class BlackTea: IAbstractTea
{
    public Task<string> GetTeaDescription()
    {
        var description =
            "Black Tea is the most common type of tea accounting for up to 85% of total tea consumption in the western world.";
        
        return Task.FromResult(description);
    }
}