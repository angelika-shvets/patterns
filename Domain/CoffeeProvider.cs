using Patterns.Domain.BuilderPattern;
using Patterns.Domain.DecoratorPattern;

namespace Patterns.Domain;

public class CoffeeProvider : ICoffeeProvider
{
    private const string Americano = "Americano";
    private const string Cappuccino = "Cappuccino";
    private readonly ICoffeeDirector _coffeeDirector;
   // private readonly ICoffeeDescription _coffeeDescription;

//    public CoffeeProvider(ICoffeeDirector coffeeDirector, ICoffeeDescription coffeeDescription)
    public CoffeeProvider(ICoffeeDirector coffeeDirector)
    {
        _coffeeDirector = coffeeDirector;
      //  _coffeeDescription = coffeeDescription;
    }


    public async Task<string> MakeCoffeeByName(string coffee)
    {
        //for example
        return coffee switch
        {
            Americano => await _coffeeDirector.BuildAmericanoCoffee(),
            Cappuccino => await _coffeeDirector.BuildCappuccinoCoffee(),
            _ => "Some default coffee"
        };
    }

    // public Task<string> GetCoffeeDescriptionByName(string coffee)
    // {
    //     return _coffeeDescription.GetCoffeeDescription();
    // }
}