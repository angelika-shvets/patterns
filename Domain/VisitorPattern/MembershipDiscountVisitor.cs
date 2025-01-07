namespace Patterns.Domain.VisitorPattern;

public class MembershipDiscountVisitor : IVisitor
{
    public async Task Visit(AmericanoCoffee americanoCoffee)
    {
        americanoCoffee.Price *= 0.8m;
        await Task.CompletedTask;
    }

    public async Task Visit(CappuccinoCoffee cappuccinoCoffee)
    {
        cappuccinoCoffee.Price *= 0.9m;
        await Task.CompletedTask;
    }
}