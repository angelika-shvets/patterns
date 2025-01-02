
namespace Patterns.Domain.AbstractFactoryPattern;

public class CafeFactoryBootstrap
{
    //bootstrap part... just for example
    private readonly IAbstractFactory _cafeFactory;
    private readonly ICafeDrinkProvider _cafeDrinkProvider;
    
    public CafeFactoryBootstrap(int config)
    {
        _cafeFactory = config == 1 ? new TheatreCafeDrinkFactory() : new CinemaCafeDrinkFactory();
        
        _cafeDrinkProvider = new CafeDrinkProvider(_cafeFactory);
    }

    public async Task<string> GetTeaDescription()
    {
       return await _cafeDrinkProvider.GetTeaDescription();
    }
    public async Task<string> GetCoffeeDescription()
    {
        return await _cafeDrinkProvider.GetCoffeeDescription();
    }
}