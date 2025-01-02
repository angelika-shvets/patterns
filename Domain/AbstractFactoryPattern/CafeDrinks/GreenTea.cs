namespace Patterns.Domain.AbstractFactoryPattern.CafeDrinks;

public class GreenTea: IAbstractTea
{
    public Task<string> GetTeaDescription()
    {
        var description =
            "Green Tea is unoxidized tea. The leaves are heated soon after picking in order to destroy the enzymes that cause oxidation.";
        
        return Task.FromResult(description);
    }
}