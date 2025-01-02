namespace Patterns.Domain.AbstractFactoryPattern;

public class CafeDrinkProvider: ICafeDrinkProvider
{
    private readonly IAbstractTea _abstractTea;
    private readonly IAbstractCoffee _abstractCoffee;
    
    private readonly IAbstractFactory _abstractFactory;
    
    public CafeDrinkProvider(IAbstractFactory abstractFactory)
    {
        _abstractTea = abstractFactory.CreateTea();
        _abstractCoffee = abstractFactory.CreateCoffee();
    }
    
    public async Task<string> GetCoffeeDescription()
    {
        var description = await _abstractCoffee.GetCoffeeDescription();
        Console.WriteLine(description);
        return description;
    }
    
    public async Task<string> GetTeaDescription()
    {
        var description = await _abstractTea.GetTeaDescription();
        Console.WriteLine(description);
        return description;
    }
}