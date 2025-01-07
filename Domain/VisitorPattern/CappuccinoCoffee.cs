namespace Patterns.Domain.VisitorPattern;

public class CappuccinoCoffee: IVisitable
{
    public string? Name { get; set; }
    public decimal Price { get; set; }
    
    public async Task Accept(IVisitor visitor)
    {
        await visitor.Visit(this);
    }
}